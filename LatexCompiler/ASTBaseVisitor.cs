using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public abstract class ASTBaseVisitor<T>
    {
        public virtual T Visit(ASTElement node)
        {
            return node.Accept(this);
        }

        public virtual T VisitChildren(ASTElement node)
        {
            for (int i = 0; i < node.GetContextNumber(); i++)
            {
                foreach (ASTElement child in node.GetChildren(i))
                {
                    Visit(child);
                }
            }

            return default(T);
        }

        public virtual T VisitChildren(ASTElement node, int context)
        {
            foreach (ASTElement child in node.GetChildren(context))
            {
                Visit(child);
            }

            return default(T);
        }
    }


    public class LatexCompilerASTBaseVisitor<T> : ASTBaseVisitor<T>
    {
        public virtual T VisitCompileUnit(LCompileUnit node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitSqrt(LSqrt node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitNSqrt(LNSqrt node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitFraction(LFrac node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitFloor(LFloor node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitCeil(LCeil node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitCos(LCos node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitSin(LSin node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitArcCos(LArcCos node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitArcSin(LArcSin node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitArcTan(LArcTan node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitLog(LLog node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitFunction(LFunction node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitSum(LSum node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitLim(LLim node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitProduct(LProduct node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitIntegrals(LIntegrals node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitAddition(LAddition node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitSubtraction(LSubtraction node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitMultiplication(LMultiplication node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitDivision(LDivision node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitLT(LLT node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitLTE(LLTE node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitGT(LGT node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitGTE(LGTE node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitEXP(LEXP node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitEXPMINUS(LEXPMINUS node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitAssign(LAssign node)
        {
            return VisitChildren(node);
        }

        public virtual T VisitNumber(LNUMBER node)
        {
            return default(T);
        }

        public virtual T VisitVariable(LVARIABLE node)
        {
            return default(T);
        }

        public virtual T VisitInf(LINF node)
        {
            return default(T);
        }

        public virtual T VisitAlpha(LALPHA node)
        {
            return default(T);
        }

        public virtual T VisitBeta(LBETA node)
        {
            return default(T);
        }

        public virtual T VisitChi(LCHI node)
        {
            return default(T);
        }
        public virtual T VisitDelta(LDELTA node)
        {
            return default(T);
        }

        public virtual T VisitKappa(LKAPPA node)
        {
            return default(T);
        }

        public virtual T VisitLambda(LLAMBDA node)
        {
            return default(T);
        }

        public virtual T VisitOmega(LOMEGA node)
        {
            return default(T);
        }

        public virtual T VisitPhi(LPHI node)
        {
            return default(T);
        }

        public virtual T VisitPi(LPI node)
        {
            return default(T);
        }

        public virtual T VisitSigma(LSIGMA node)
        {
            return default(T);
        }
        /*
        public virtual T VisitExpression(LEXPRESSION node)
        {
            return VisitChildren(node);
        }
        */
    }
}

