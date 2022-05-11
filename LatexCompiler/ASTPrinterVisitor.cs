using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace LatexCompiler
{
    class ASTPrinterVisitor : LatexCompilerASTBaseVisitor<int>
    {
        private StreamWriter m_dotFile;
        private ASTElement m_root;
        private String m_dotFilename;
        private static int ms_clusterSerial = 0;

        public ASTPrinterVisitor(string dotFilename)
        {
            m_dotFilename = dotFilename;
            m_root = null;
            m_dotFile = null;
        }

        public void ExtractSubgraphs(ASTElement element, int context, string[] contextNames)
        {
            m_dotFile.WriteLine($"subgraph cluster{ms_clusterSerial++} {{");
            m_dotFile.WriteLine("node [style=filled,color=white];");
            m_dotFile.WriteLine("style=filled;");
            m_dotFile.WriteLine("color=lightgrey;");

            foreach (ASTElement c in element.GetChildren(context))
            {
                m_dotFile.Write($"{c.MName};");
            }
            m_dotFile.WriteLine("");
            m_dotFile.WriteLine($"label = \"{contextNames[context]}\";");
            m_dotFile.WriteLine("}");
        }



        public override int VisitCompileUnit(LCompileUnit node)
        {
            //Open dotFile
            m_dotFile = new StreamWriter(m_dotFilename);

            m_dotFile.WriteLine("digraph G{");
            //Generate edge with parent (ommited here)

            //Generate contexts
            ExtractSubgraphs(node, LCompileUnit.CT_EXPRESSION, LCompileUnit.msc_contextNames);


            //Visit contexts
            base.VisitCompileUnit(node);

            //Close dotFile
            m_dotFile.WriteLine("}");
            m_dotFile.Close();

            //Call graphviz to print tree
            //Prepare the process dot to run
            ProcessStartInfo start = new ProcessStartInfo();
            //Enter, in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = "-Tgif " +
                              Path.GetFileName("ast.dot") + " -o " +
                              Path.GetFileNameWithoutExtension("ast") + ".gif";
            //Enter the executable to run , including the complete path
            start.FileName = "dot";
            //Do you want to show the console window?
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            int exitCode;

            //Run the external process and wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                //Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }

            return 0;
        }
        /*
        public override int VisitExpression(LEXPRESSION node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LEXPRESSION.CT_EXPRESSION, LEXPRESSION.msc_contextNames);


            // Visit Assignment
            base.VisitExpression(node);

            return 0;
        }
        */
        public override int VisitAddition(LAddition node)
        {
            //Generate edge with parent
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LAddition.CT_LEFT, LAddition.msc_contextNames);
            ExtractSubgraphs(node, LAddition.CT_RIGHT, LAddition.msc_contextNames);

            // Visit Assignment
            base.VisitAddition(node);

            return 0;
        }

        public override int VisitMultiplication(LMultiplication node)
        {
            //Generate edge with parent
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LMultiplication.CT_LEFT, LMultiplication.msc_contextNames);
            ExtractSubgraphs(node, LMultiplication.CT_RIGHT, LMultiplication.msc_contextNames);

            // Visit Assignment
            base.VisitMultiplication(node);

            return 0;
        }

        public override int VisitDivision(LDivision node)
        {
            //Generate edge with parent
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LDivision.CT_LEFT, LDivision.msc_contextNames);
            ExtractSubgraphs(node, LDivision.CT_RIGHT, LDivision.msc_contextNames);

            // Visit Assignment
            base.VisitDivision(node);

            return 0;
        }

        public override int VisitSubtraction(LSubtraction node)
        {
            //Generate edge with parent
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LSubtraction.CT_LEFT, LSubtraction.msc_contextNames);
            ExtractSubgraphs(node, LSubtraction.CT_RIGHT, LSubtraction.msc_contextNames);

            // Visit Assignment
            base.VisitSubtraction(node);

            return 0;
        }
        public override int VisitGT(LGT node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LGT.CT_LEFT, LGT.msc_contextNames);
            ExtractSubgraphs(node, LGT.CT_RIGHT, LGT.msc_contextNames);

            // Visit Assignment
            base.VisitGT(node);

            return 0;
        }

        public override int VisitGTE(LGTE node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LGTE.CT_LEFT, LGTE.msc_contextNames);
            ExtractSubgraphs(node, LGTE.CT_RIGHT, LGTE.msc_contextNames);

            // Visit Assignment
            base.VisitGTE(node);

            return 0;
        }

        public override int VisitLT(LLT node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LLT.CT_LEFT, LLT.msc_contextNames);
            ExtractSubgraphs(node, LLT.CT_RIGHT, LLT.msc_contextNames);

            // Visit Assignment
            base.VisitLT(node);

            return 0;
        }

        public override int VisitLTE(LLTE node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LLTE.CT_LEFT, LLTE.msc_contextNames);
            ExtractSubgraphs(node, LLTE.CT_RIGHT, LLTE.msc_contextNames);

            // Visit Assignment
            base.VisitLTE(node);

            return 0;
        }

        public override int VisitNSqrt(LNSqrt node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LNSqrt.CT_NUMBER, LNSqrt.msc_contextNames);
            ExtractSubgraphs(node, LNSqrt.CT_EXPRESSION, LNSqrt.msc_contextNames);

            // Visit Assignment
            base.VisitNSqrt(node);

            return 0;
        }

        public override int VisitSqrt(LSqrt node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LSqrt.CT_EXPRESSION, LSqrt.msc_contextNames);


            // Visit Assignment
            base.VisitSqrt(node);

            return 0;
        }

        public override int VisitFraction(LFrac node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LFrac.CT_EXPRESSION1, LFrac.msc_contextNames);
            ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitFraction(node);

            return 0;
        }

        public override int VisitFloor(LFloor node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LFloor.CT_EXPRESSION, LFloor.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitFloor(node);

            return 0;
        }

        public override int VisitCeil(LCeil node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LCeil.CT_EXPRESSION, LCeil.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitCeil(node);

            return 0;
        }

        public override int VisitCos(LCos node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LCos.CT_EXPRESSION, LCos.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitCos(node);

            return 0;
        }

        public override int VisitSin(LSin node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LSin.CT_EXPRESSION, LSin.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitSin(node);

            return 0;
        }

        public override int VisitArcSin(LArcSin node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LArcSin.CT_EXPRESSION, LArcSin.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitArcSin(node);

            return 0;
        }

        public override int VisitArcCos(LArcCos node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LArcCos.CT_EXPRESSION, LArcCos.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitArcCos(node);

            return 0;
        }

        public override int VisitArcTan(LArcTan node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LArcTan.CT_EXPRESSION, LArcTan.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitArcTan(node);

            return 0;
        }

        public override int VisitLog(LLog node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LLog.CT_EXPRESSION, LLog.msc_contextNames);
            //ExtractSubgraphs(node, LFrac.CT_EXPRESSION2, LFrac.msc_contextNames);

            // Visit Assignment
            base.VisitLog(node);

            return 0;
        }

        public override int VisitFunction(LFunction node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LFunction.CT_FUNCTION_NAME, LFunction.msc_contextNames);
            ExtractSubgraphs(node, LFunction.CT_EXPRESSION1, LFunction.msc_contextNames);
            ExtractSubgraphs(node, LFunction.CT_EXPRESSION2, LFunction.msc_contextNames);
            // Visit Assignment
            base.VisitFunction(node);

            return 0;
        }

        public override int VisitSum(LSum node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LSum.CT_EXPRESSION1, LSum.msc_contextNames);
            ExtractSubgraphs(node, LSum.CT_EXPRESSION2, LSum.msc_contextNames);
            ExtractSubgraphs(node, LSum.CT_EXPRESSION3, LSum.msc_contextNames);
            // Visit Assignment
            base.VisitSum(node);

            return 0;
        }

        public override int VisitLim(LLim node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LLim.CT_EXPRESSION1, LLim.msc_contextNames);
            ExtractSubgraphs(node, LLim.CT_EXPRESSION2, LLim.msc_contextNames);
            ExtractSubgraphs(node, LLim.CT_EXPRESSION3, LLim.msc_contextNames);
            // Visit Assignment
            base.VisitLim(node);

            return 0;
        }

        public override int VisitProduct(LProduct node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LProduct.CT_EXPRESSION1, LProduct.msc_contextNames);
            ExtractSubgraphs(node, LProduct.CT_EXPRESSION2, LProduct.msc_contextNames);
            ExtractSubgraphs(node, LProduct.CT_EXPRESSION3, LProduct.msc_contextNames);
            // Visit Assignment
            base.VisitProduct(node);

            return 0;
        }

        public override int VisitIntegrals(LIntegrals node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LIntegrals.CT_EXPRESSION1, LIntegrals.msc_contextNames);
            ExtractSubgraphs(node, LIntegrals.CT_EXPRESSION2, LIntegrals.msc_contextNames);
            ExtractSubgraphs(node, LIntegrals.CT_EXPRESSION3, LIntegrals.msc_contextNames);
            // Visit Assignment
            base.VisitIntegrals(node);

            return 0;
        }

        public override int VisitAssign(LAssign node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LAssign.CT_LEFT, LAssign.msc_contextNames);
            ExtractSubgraphs(node, LAssign.CT_RIGHT, LAssign.msc_contextNames);
            // Visit Assignment
            base.VisitAssign(node);

            return 0;
        }

        public override int VisitEXP(LEXP node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LEXP.CT_LEFT, LEXP.msc_contextNames);
            ExtractSubgraphs(node, LEXP.CT_RIGHT, LEXP.msc_contextNames);
            // Visit Assignment
            base.VisitEXP(node);

            return 0;
        }

        public override int VisitEXPMINUS(LEXPMINUS node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            //Generate contexts
            ExtractSubgraphs(node, LEXPMINUS.CT_LEFT, LEXPMINUS.msc_contextNames);
            ExtractSubgraphs(node, LEXPMINUS.CT_RIGHT, LEXPMINUS.msc_contextNames);
            ExtractSubgraphs(node, LEXPMINUS.CT_RIGHT2, LEXPMINUS.msc_contextNames);
            // Visit Assignment
            base.VisitEXPMINUS(node);

            return 0;
        }

        //terminals
        public override int VisitNumber(LNUMBER node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitVariable(LVARIABLE node)
        {
            //Generate edge with parent
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitInf(LINF node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitAlpha(LALPHA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitBeta(LBETA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitChi(LCHI node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitDelta(LDELTA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitKappa(LKAPPA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitLambda(LLAMBDA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitOmega(LOMEGA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitPhi(LPHI node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitPi(LPI node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }

        public override int VisitSigma(LSIGMA node)
        {
            m_dotFile.WriteLine($"{node.MParent.MName}->{node.MName};");

            return 0;
        }
    }
}
