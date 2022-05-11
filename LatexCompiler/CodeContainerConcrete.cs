using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public class CCFile : CComboContainer
    {
        public const int mc_PREPROCESSOR = 0, mc_FUNCTION_DEFINITION = 1, mc_GLOBALVARS = 2, mc_FUNCTION_DECLARATIONS = 3;
        public readonly string[] mc_contextNames = { "PREPROCESSOR", "FUNCTION_DEFINITION", "GLOBALVARS", "FUNCTION_DECLARATIONS" };

        private HashSet<string> m_globalVarSymbolTable = new HashSet<string>();
        private HashSet<string> m_FunctionsSymbolTable = new HashSet<string>();

        private CMainFunctionContainer m_mainContainer = null;
        public CMainFunctionContainer MainContainer => m_mainContainer;

        public CCFile(bool withStartUpFunction) : base(CodeContainerType.CT_FILE, null, 4)
        {
            if (withStartUpFunction)
            {
                m_mainContainer = new CMainFunctionContainer(this);
                AddCode(m_mainContainer, mc_FUNCTION_DEFINITION);
            }
        }

        public void DeclareGlobalVariable(string varname)
        {
            CodeContainer rep;
            if (!m_globalVarSymbolTable.Contains(varname))
            {
                m_globalVarSymbolTable.Add(varname);
                rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
                rep.AddCode("float " + varname + "\n", mc_GLOBALVARS);
                // AddCode(rep, mc_GLOBALVARS);
            }
        }

        public void DeclareFunction(string funname, string funargs)
        {
            CodeContainer rep;
            if (!m_FunctionsSymbolTable.Contains(funname))
            {
                rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
                rep.AddCode("float " + funname);
                m_FunctionsSymbolTable.Add(funname);
                rep.AddCode("(" + funargs + ")\n", mc_FUNCTION_DECLARATIONS);
                //AddCode(rep, mc_FUNCTION_DECLARATIONS);
            }
        }

        public override CodeContainer AssemblyCodeContainer()
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, null);

            rep.AddCode(AssemblyContext(mc_PREPROCESSOR));
            //rep.AddCode(AssemblyContext(mc_FUNCTION_DECLARATIONS));
            //rep.AddCode(AssemblyContext(mc_GLOBALVARS));
            rep.AddCode(AssemblyContext(mc_FUNCTION_DEFINITION));
            return rep;
        }


    }

    public class CFunctionContainer : CComboContainer
    {
        public const int mc_FNAME = 0, mc_ARGS = 1, mc_BODY = 2;
        public readonly String[] mc_contextNames = { "FNAME", "ARGS", "BODY" };

        private HashSet<string> m_localSymbolTable = new HashSet<string>();
        private CCFile m_file;

        public CFunctionContainer(CEmmitableCodeContainer parent) : base(CodeContainerType.CT_FUNCTION_DEFINITION, parent, 3)
        {
            AddCode(new CCompoundContainer(this), mc_BODY);
            m_file = parent as CCFile;
        }

        public override CodeContainer AssemblyCodeContainer()
        {
            return null;
        }


    }

    public class CCompoundContainer : CComboContainer
    {
        public const int mc_COMPOUNDSTATEMENT_DECLARATIONS = 0, mc_COMPOUNDSTATEMENT_BODY = 1;
        public readonly String[] mc_contextNames = { "COMPOUNDSTATEMENT_DECLARATIONS", "COMPOUNDSTATEMENT_BODY" };

        public CCompoundContainer(CEmmitableCodeContainer parent) : base(CodeContainerType.CT_COMPOUNDCONTAINER, parent, 2)
        {
        }

        public override CodeContainer AssemblyCodeContainer()
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, MParent);
            rep.AddNewLine();
            rep.AddCode("\\author{Karapiperakis Emmanouil}");
            rep.AddNewLine();         
            rep.AddCode("\\date{" + DateTime.Now.ToString("MM/dd/yyyy") + "}");
            rep.AddNewLine();
            rep.AddCode("\\maketitle");
            rep.AddNewLine();
            rep.AddCode("%*** CODE STARTS HERE ***");
            rep.AddNewLine();
            rep.AddCode(AssemblyContext(mc_COMPOUNDSTATEMENT_BODY));
            rep.AddNewLine();
            rep.AddCode("%*** CODE ENDS HERE ***");
            return rep;
        }


    }





    public class CMainFunctionContainer : CFunctionContainer
    {
        public CMainFunctionContainer(CComboContainer parent) : base(parent)
        {
            
        }

        public override CodeContainer AssemblyCodeContainer()
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, this);
            rep.AddCode("\\begin{document}");
            rep.AddNewLine();
            rep.AddCode(AssemblyContext(mc_BODY));
            rep.AddCode("\\end{document}");
            return rep;
        }
    }
}
