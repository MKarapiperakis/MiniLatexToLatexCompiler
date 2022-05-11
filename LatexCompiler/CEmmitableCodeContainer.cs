using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public enum CodeContainerType
    {
        CT_NA,
        CT_CODEREPOSITORY,
        CT_FILE,
        CT_FUNCTION_DEFINITION,
        CT_COMPOUNDCONTAINER,
        CT_IFCONTAINER,
        CT_FORCONTAINER,
        CT_WHILECONTAINER,
        CT_ADDITION
    }

    public abstract class CEmmitableCodeContainer
    {
        private CodeContainerType m_containerType;
        protected CEmmitableCodeContainer m_parent;
        private int m_serialNumber;
        private static int m_serialNumberCounter = 0;
        private string m_label;
        protected int m_nestingLevel = 0;

        // Properties
        public CodeContainerType MContainerType => m_containerType;
        public CEmmitableCodeContainer MParent => m_parent;
        public int MSerialNumber => m_serialNumber;
        public static int MSerialNumberCounter => m_serialNumberCounter;
        public string MLabel => m_label;

        protected int MNestingLevel
        {
            get => m_nestingLevel;
            set => m_nestingLevel = value;
        }

        protected CEmmitableCodeContainer(CodeContainerType mContainerType, CEmmitableCodeContainer mParent)
        {
            m_containerType = mContainerType;
            m_parent = mParent;
            m_serialNumber = m_serialNumberCounter++;
            m_label = m_containerType + "_" + m_serialNumber;
            m_nestingLevel = m_parent?.MNestingLevel ?? 0;
        }

        public void SetParent(CEmmitableCodeContainer parent)
        {
            m_parent = parent;
        }

        public abstract CodeContainer AssemblyCodeContainer();
        public abstract void AddCode(string code, int context = 0);
        public abstract void AddCode(CEmmitableCodeContainer code, int context = 0);
        public abstract string EmmitStdout();
        public abstract void EmmitToFile(StreamWriter f);

        public abstract void AddNewLine(int context = 0);
    }

    public abstract class CComboContainer : CEmmitableCodeContainer
    {
        protected List<CEmmitableCodeContainer>[] m_repository;

        private static int m_clusterSerial = 0;

        protected CComboContainer(CodeContainerType nodeType, CEmmitableCodeContainer parent, int numcontexts) : base(nodeType, parent)
        {
            m_repository = new List<CEmmitableCodeContainer>[numcontexts];
            for (int i = 0; i < numcontexts; i++)
            {
                m_repository[i] = new List<CEmmitableCodeContainer>();
            }
        }

        protected virtual CodeContainer AssemblyContext(int ct)
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
            for (int i = 0; i < m_repository[ct].Count; i++)
            {
                rep.AddCode(m_repository[ct][i].AssemblyCodeContainer());
            }
            return rep;
        }

        public override void AddCode(string code, int context)
        {
            CodeContainer container = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
            container.AddCode(code, 0);
            m_repository[context].Add(container);
        }

        public override void AddCode(CEmmitableCodeContainer code, int context)
        {
            m_repository[context].Add(code);
            code.SetParent(this);
        }

        public override void AddNewLine(int context)
        {
            CodeContainer container = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
            container.AddNewLine();
            m_repository[context].Add(container);
        }

        public override string EmmitStdout()
        {
            string s = AssemblyCodeContainer().ToString();
            Console.WriteLine(s);
            return s;
        }

        public override string ToString()
        {
            string s = AssemblyCodeContainer().ToString();
            return s;
        }

        public override void EmmitToFile(StreamWriter f)
        {
            string s = AssemblyCodeContainer().ToString();
            f.WriteLine(s);
        }

        internal CEmmitableCodeContainer GetChild(int ct, int index = 0)
        {
            return m_repository[ct][index];
        }

        internal CEmmitableCodeContainer[] GetContextChildren(int ct)
        {
            return m_repository[ct].ToArray();
        }


    }

    public class CodeContainer : CEmmitableCodeContainer
    {
        StringBuilder m_repository = new StringBuilder();

        public CodeContainer(CodeContainerType mContainerType, CEmmitableCodeContainer mParent) :
            base(mContainerType, mParent)
        {

        }

        public override void AddCode(string code, int context = 0)
        {
            string[] lines = code.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                m_repository.Append(line);
                if (code.Contains('\n'))
                {
                    m_repository.Append("\r\n");
                    m_repository.Append(new string('\t', m_nestingLevel));
                }
            }
        }

        public override void AddCode(CEmmitableCodeContainer code, int context = 0)
        {
            string str = code.ToString();
            AddCode(str, context);
        }

        public override void AddNewLine(int context = 0)
        {
            m_repository.Append("\r\n");
            m_repository.Append(new string('\t', m_nestingLevel));
        }


        public override string EmmitStdout()
        {
            System.Console.WriteLine(m_repository.ToString());
            return m_repository.ToString();
        }

        public override void EmmitToFile(StreamWriter f)
        {
            f.WriteLine(m_repository.ToString());
        }

        public override string ToString()
        {
            return m_repository.ToString();
        }

        public override CodeContainer AssemblyCodeContainer()
        {
            return this;
        }


    }
}
