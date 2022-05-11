using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public class LatexGeneration : LatexCompilerASTBaseVisitor<CodeContainer>
    {
        public String symbols = "";
        private CCFile m_translatedFile;
        private Stack<(CEmmitableCodeContainer, CEmmitableCodeContainer, int)> m_parentsInfo = new Stack<(CEmmitableCodeContainer, CEmmitableCodeContainer, int)>();
        // ^ First argument: parent, Second argument: function that local variables are declared, Third Argument: parent context

        public CCFile MTranslatedFile => m_translatedFile;


        public override CodeContainer VisitCompileUnit(LCompileUnit node)
        {
            m_translatedFile = new CCFile(true);

            m_translatedFile.AddCode("\\documentclass[12pt]{article}\n", CCFile.mc_PREPROCESSOR);
            m_translatedFile.AddCode("\\usepackage{geometry}\n", CCFile.mc_PREPROCESSOR);
            m_translatedFile.AddCode("\\usepackage{graphicx}\n", CCFile.mc_PREPROCESSOR);
            m_translatedFile.AddCode("\\usepackage{amsmath}\n", CCFile.mc_PREPROCESSOR);
            m_translatedFile.AddCode("\\usepackage{esint}\n", CCFile.mc_PREPROCESSOR);
            m_translatedFile.AddCode("\\title{Compilers 2}\n", CCFile.mc_PREPROCESSOR);

            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple;


            infoTuple = (m_translatedFile.MainContainer.GetChild(CMainFunctionContainer.mc_BODY), m_translatedFile.MainContainer,
                    CCompoundContainer.mc_COMPOUNDSTATEMENT_BODY);
            m_parentsInfo.Push(infoTuple);
            symbols = "";
            VisitChildren(node, LCompileUnit.CT_EXPRESSION);
            m_parentsInfo.Pop();

            return null;
        }

       
        public override CodeContainer VisitSqrt(LSqrt node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item1);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LSqrt.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\sqrt{");
                symbols = symbols + "}";
                Visit(node.GetChild(LSqrt.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + "}";
                rep.AddCode("\\sqrt{" + Visit(node.GetChild(LSqrt.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitCos(LCos node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LCos.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\cos(");
                symbols = symbols + ")";
                Visit(node.GetChild(LCos.CT_EXPRESSION, 0));               
            }
            else
            {
                symbols = symbols + ")";
                rep.AddCode("\\cos(" + Visit(node.GetChild(LCos.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitSin(LSin node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LSin.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\sin(");
                symbols = symbols + ")";
                Visit(node.GetChild(LSin.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + ")";
                rep.AddCode("\\sin(" + Visit(node.GetChild(LSin.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitArcCos(LArcCos node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LArcCos.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\arccos(");
                symbols = symbols + ")";
                Visit(node.GetChild(LArcCos.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + ")";
                rep.AddCode("\\arccos(" + Visit(node.GetChild(LArcCos.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitArcSin(LArcSin node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LArcSin.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\arcsin(");
                symbols = symbols + ")";
                Visit(node.GetChild(LArcSin.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + ")";
                rep.AddCode("\\arcsin(" + Visit(node.GetChild(LArcSin.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitArcTan(LArcTan node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LArcTan.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\arctan(");
                symbols = symbols + ")";
                Visit(node.GetChild(LArcTan.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + ")";
                rep.AddCode("\\arctan(" + Visit(node.GetChild(LArcTan.CT_EXPRESSION, 0)));
            }
            return rep;
        }


        public override CodeContainer VisitNSqrt(LNSqrt node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LNSqrt.CT_EXPRESSION);
            
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            
            rep.AddCode("\\sqrt[");
            symbols = symbols + "]";
            rep.AddCode(Visit(node.GetChild(LNSqrt.CT_NUMBER, 0)));


            symbols = "";
           
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("{");
                symbols = symbols + "}";
                Visit(node.GetChild(LNSqrt.CT_EXPRESSION, 0));
            }
            else
            {             
                rep.AddCode("{");
                symbols = symbols + "}";
                rep.AddCode(Visit(node.GetChild(LNSqrt.CT_EXPRESSION, 0)));
                rep.AddCode(" \\] \n");
            }


            return rep;
        }

        public override CodeContainer VisitFraction(LFrac node)         //Works only for numbers
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child1 = node.GetChild(LFrac.CT_EXPRESSION1);
            ASTElement child2 = node.GetChild(LFrac.CT_EXPRESSION2);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }


            rep.AddCode("\\frac");
            rep.AddCode("{");
            symbols = symbols + "}";
            //rep.AddCode(Visit(node.GetChild(LFrac.CT_EXPRESSION1, 0)));
            rep.AddCode(Visit(node.GetChild(LFrac.CT_EXPRESSION1, 0)));
            

            rep.AddCode("{");
            //rep.AddCode(Visit(node.GetChild(LFrac.CT_EXPRESSION1, 0)));
            rep.AddCode(Visit(node.GetChild(LFrac.CT_EXPRESSION2, 0)));

            rep.AddCode(" \\]");





            return rep;
        }

        public override CodeContainer VisitFloor(LFloor node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LFloor.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\lfloor " );
                symbols = symbols + "roolfr\\ ";
                Visit(node.GetChild(LFloor.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + "roolfr\\ ";
                rep.AddCode("\\lfloor " + Visit(node.GetChild(LFloor.CT_EXPRESSION, 0)));
            }
            return rep;
        }

        public override CodeContainer VisitCeil(LCeil node)
        {
            (CEmmitableCodeContainer, CEmmitableCodeContainer, int) infoTuple = m_parentsInfo.Peek();
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, infoTuple.Item2);
            infoTuple.Item1.AddCode(rep, infoTuple.Item3);

            ASTElement child = node.GetChild(LCeil.CT_EXPRESSION);
            // Translation.
            //Console.WriteLine(node.MParent);
            //Console.WriteLine(child.Type);
            if (node.MParent.ToString().Contains("CompileUnit"))
            {
                rep.AddCode("\\[ ");
                symbols = "";
            }
            if (!child.Type.ToString().Contains("VARIABLE") && !child.Type.ToString().Contains("NUMBER"))
            {
                rep.AddCode("\\lceil ");
                symbols = symbols + "liecr\\ ";
                Visit(node.GetChild(LFloor.CT_EXPRESSION, 0));
            }
            else
            {
                symbols = symbols + "liecr\\ ";
                rep.AddCode("\\lceil " + Visit(node.GetChild(LFloor.CT_EXPRESSION, 0)));
            }
            return rep;
        }
        //terminals

        public override CodeContainer VisitNumber(LNUMBER node)
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, null);
            // Translation.
            rep.AddCode(node.MName1);
            //reverse the string symbols
            char[] charArray = symbols.ToCharArray();
            Array.Reverse(charArray);
            symbols = new string(charArray);

            //Console.WriteLine(node.MParent);
            if (node.MParent.ToString().Contains("NSqrt"))
                symbols = symbols + "";
            else if (node.MParent.ToString().Contains("Frac"))
                symbols = symbols + "";
            else
                symbols = symbols + " \\]\n";
            rep.AddCode(symbols);
            return rep;
        }

        public override CodeContainer VisitVariable(LVARIABLE node)
        {
            CodeContainer rep = new CodeContainer(CodeContainerType.CT_CODEREPOSITORY, null);

            // Translation.
            rep.AddCode(node.MName1);
            //reverse the string symbols
            char[] charArray = symbols.ToCharArray();
            Array.Reverse(charArray);
            symbols = new string(charArray);

            if (node.MParent.ToString().Contains("NSqrt"))
                symbols = symbols + "";
            else if (node.MParent.ToString().Contains("Frac"))
                symbols = symbols + "";
            else
                symbols = symbols + " \\]\n";
            rep.AddCode(symbols);
            return rep;
        }



    }
}
