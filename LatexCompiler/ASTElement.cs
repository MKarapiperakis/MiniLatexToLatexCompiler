using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public class ASTElementChildrenEnumerator : IEnumerator<ASTElement>
    {
        private int m_currentContext;
        private int m_currentChildIndex;
        private ASTElement m_currentChild;
        private ASTElement m_currentNode;


        public ASTElement Current => m_currentChild;

        public ASTElementChildrenEnumerator(ASTElement mCurrentNode)  //take a node
        {
            m_currentNode = mCurrentNode;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            m_currentChildIndex++;
            if (m_currentChildIndex == m_currentNode.GetContextChildrenNumber(m_currentContext))  //cheking if we are at the end of a child's node context
            {

                if (m_currentContext + 1 == m_currentNode.GetContextNumber())  //checking if we are at a leaf
                {
                    return false;  //we reached the end
                }
                else
                {
                    m_currentContext++;
                    while (m_currentNode.GetContextChildrenNumber(m_currentContext) == 0 &&
                           m_currentContext < m_currentNode.GetContextNumber()) //Searching for empty contexts to ommit
                    {
                        m_currentContext++;
                    }

                    if (m_currentContext == m_currentNode.GetContextNumber())  //checking if we are at a leaf
                    {
                        return false;  //we reached the end
                    }
                    else
                    {
                        m_currentChildIndex = 0;
                        m_currentChild = m_currentNode.GetChild(m_currentContext, m_currentChildIndex);
                        return true;
                    }

                }
            }
            else
            {
                m_currentChild = m_currentNode.GetChild(m_currentContext, m_currentChildIndex);
                return true;
            }

        }

        public void Reset()  //we initiate the variables
        {
            m_currentContext = -1;
            m_currentChildIndex = -1;
            m_currentChild = null;
        }

        object IEnumerator.Current => Current;
    }

    public enum NodeType
    {
        NT_NA,
        NT_COMPILEUNIT,
        NT_ASSIGNMENT,
        NT_ADDITION,
        NT_SUBTRACTION,
        NT_MULTIPLICATION,
        NT_DIVISION,
        NT_NUMBER,
        NT_VARIABLE,
        NT_GT,
        NT_GTE,
        NT_LT,
        NT_LTE,
        NT_EQUAL,
        NT_NEQUAL,
        NT_EXP,
        NT_EXPMINUS,
        NT_SQUAREROOT,
        NT_NSQUAREROOT,
        NT_FRACTION,
        NT_FLOOR,
        NT_CEIL,
        NT_COS,
        NT_SIN,
        NT_ARCCOS,
        NT_ARCSIN,
        NT_ARCTAN,
        NT_LOG,
        NT_FUNCTION,
        NT_SUM,
        NT_LIM,
        NT_PRODUCT,
        NT_INTEGRALS,
        NT_INF,
        NT_ALPHA,
        NT_BETA,
        NT_CHI,
        NT_DELTA,
        NT_KAPPA,
        NT_LAMBDA,
        NT_OMEGA,
        NT_PHI,
        NT_PI,
        NT_SIGMA,
        NT_EXPRESSION


    }

    public abstract class ASTElement : IEnumerable<ASTElement>
    {

        private List<ASTElement>[] m_children = null;  //References to the children of the node
        private ASTElement m_parent;   //Reference to the parent of the node
        private int m_serial;  //Node's id
        private string m_name;  //Node's name
        private static int m_serialCounter = 0;   //Node's id (for the whole tree)
        private NodeType m_type;

        public NodeType Type
        {
            get => m_type;
        }

        public ASTElement MParent
        {
            get => m_parent;
            set => m_parent = value;
        }

        //so that we can access the parent and name of the node
        public virtual string MName => m_name;


        public IEnumerator<ASTElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public abstract T Accept<T>(ASTBaseVisitor<T> visitor);

        protected ASTElement(int context, NodeType type)  //ASTElement Constructor
        {
            m_serial = m_serialCounter++;
            m_type = type;
            m_name = GenerateNodeName();
            if (context != 0)  //0 = the node has no children so don't initialize the m_children
            {
                m_children = new List<ASTElement>[context];  //if the node has children, we make room for them in the list
                for (int i = 0; i < context; i++)
                {
                    m_children[i] = new List<ASTElement>();
                }
            }

        }

        public void AddChild(ASTElement child, int contextIndex)
        {
            m_children[contextIndex].Add(child);   //We add the child to that specific position in the list

        }

        public ASTElement GetChild(int context, int index = 0)
        {
            return m_children[context][index];   //We get a child from the list (from what context/team of children and which one of them from the list

        }

        public IEnumerable<ASTElement> GetChildren(int context)
        {
            return m_children[context];
        }

        public IEnumerable<ASTElement> GetContextChildren(int context)
        {
            foreach (ASTElement c in m_children[context])
            {
                yield return c;
            }
        }

        public virtual string GenerateNodeName()
        {
            return Enum.GetName(typeof(NodeType), Type) + "_" + m_serial;  //The default name of a node
        }

        public int GetContextChildrenNumber(int context)
        {
            if (m_children != null && m_children.Length > context)
            {
                return m_children[context].Count;
            }
            else if (m_children != null && m_children.Length <= context)
            {
                throw new IndexOutOfRangeException("Index out of context's array range for the current node!\n");
            }
            else
            {
                return 0;
            }
        }

        public int GetContextNumber()
        {
            return m_children.Length;
        }
    }
}
