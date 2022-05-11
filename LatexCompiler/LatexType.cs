using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexCompiler
{
    public class LCompileUnit : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitCompileUnit(this);
        }


        public LCompileUnit() : base(1, NodeType.NT_COMPILEUNIT)
        {
        }
    }
    /*
    public class LEXPRESSION : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitExpression(this);
        }


        public LEXPRESSION() : base(1, NodeType.NT_EXPRESSION)
        {
        }
    }
    */
    public class LSqrt : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitSqrt(this);
        }


        public LSqrt() : base(1, NodeType.NT_SQUAREROOT)
        {
        }
    }

    public class LNSqrt : ASTElement
    {
        public const int CT_NUMBER = 0, CT_EXPRESSION = 1;

        public static readonly string[] msc_contextNames = { "numberContext", "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitNSqrt(this);
        }


        public LNSqrt() : base(2, NodeType.NT_NSQUAREROOT)
        {
        }
    }

    public class LFrac : ASTElement
    {
        public const int CT_EXPRESSION1 = 0, CT_EXPRESSION2 = 1;
        // public const int CT_EXPRESSION1 = 0;

        public static readonly string[] msc_contextNames = { "numerator", "denominator" };
        //public static readonly string[] msc_contextNames = { "expressionContext1" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitFraction(this);
        }


        public LFrac() : base(2, NodeType.NT_FRACTION)
        {
        }
    }

    public class LFloor : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitFloor(this);
        }


        public LFloor() : base(1, NodeType.NT_FLOOR)
        {
        }
    }

    public class LCeil : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitCeil(this);
        }


        public LCeil() : base(1, NodeType.NT_CEIL)
        {
        }
    }

    public class LCos : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitCos(this);
        }


        public LCos() : base(1, NodeType.NT_COS)
        {
        }
    }

    public class LSin : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitSin(this);
        }


        public LSin() : base(1, NodeType.NT_SIN)
        {
        }
    }

    public class LArcCos : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitArcCos(this);
        }


        public LArcCos() : base(1, NodeType.NT_ARCCOS)
        {
        }
    }

    public class LArcSin : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitArcSin(this);
        }


        public LArcSin() : base(1, NodeType.NT_ARCSIN)
        {
        }
    }

    public class LArcTan : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitArcTan(this);
        }


        public LArcTan() : base(1, NodeType.NT_ARCTAN)
        {
        }
    }

    public class LLog : ASTElement
    {
        public const int CT_EXPRESSION = 0;

        public static readonly string[] msc_contextNames = { "expressionContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitLog(this);
        }


        public LLog() : base(1, NodeType.NT_LOG)
        {
        }
    }

    public class LFunction : ASTElement
    {
        public const int CT_FUNCTION_NAME = 0, CT_EXPRESSION1 = 1, CT_EXPRESSION2 = 2;

        public static readonly string[] msc_contextNames = { "functionName", "argument1", "argument2" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitFunction(this);
        }


        public LFunction() : base(3, NodeType.NT_FUNCTION)
        {
        }
    }

    public class LSum : ASTElement
    {
        public const int CT_EXPRESSION1 = 0, CT_EXPRESSION2 = 1, CT_EXPRESSION3 = 2;

        public static readonly string[] msc_contextNames = { "expressionContext1", "expressionContext2", "Body" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitSum(this);
        }


        public LSum() : base(3, NodeType.NT_SUM)
        {
        }
    }

    public class LLim : ASTElement
    {
        public const int CT_EXPRESSION1 = 0, CT_EXPRESSION2 = 1, CT_EXPRESSION3 = 2;

        public static readonly string[] msc_contextNames = { "expressionContext1", "expressionContext2", "body" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitLim(this);
        }


        public LLim() : base(3, NodeType.NT_LIM)
        {
        }
    }

    public class LProduct : ASTElement
    {
        public const int CT_EXPRESSION1 = 0, CT_EXPRESSION2 = 1, CT_EXPRESSION3 = 2;

        public static readonly string[] msc_contextNames = { "expressionContext1", "expressionContext2", "body" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitProduct(this);
        }


        public LProduct() : base(3, NodeType.NT_PRODUCT)
        {
        }
    }

    public class LIntegrals : ASTElement
    {
        public const int CT_EXPRESSION1 = 0, CT_EXPRESSION2 = 1, CT_EXPRESSION3 = 2;

        public static readonly string[] msc_contextNames = { "expressionContext1", "expressionContext2", "body" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitIntegrals(this);
        }


        public LIntegrals() : base(3, NodeType.NT_INTEGRALS)
        {
        }
    }

    public class LAddition : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitAddition(this);
        }


        public LAddition() : base(2, NodeType.NT_ADDITION)
        {
        }
    }

    public class LSubtraction : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitSubtraction(this);
        }


        public LSubtraction() : base(2, NodeType.NT_SUBTRACTION)
        {
        }
    }

    public class LMultiplication : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitMultiplication(this);
        }


        public LMultiplication() : base(2, NodeType.NT_MULTIPLICATION)
        {
        }
    }

    public class LDivision : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitDivision(this);
        }


        public LDivision() : base(3, NodeType.NT_DIVISION)
        {
        }
    }

    public class LLT : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitLT(this);
        }


        public LLT() : base(2, NodeType.NT_LT)
        {
        }
    }
    public class LLTE : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitLTE(this);
        }


        public LLTE() : base(2, NodeType.NT_LTE)
        {
        }
    }

    public class LGT : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitGT(this);
        }


        public LGT() : base(2, NodeType.NT_GT)
        {
        }
    }

    public class LGTE : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitGTE(this);
        }


        public LGTE() : base(2, NodeType.NT_GTE)
        {
        }
    }

    public class LEXP : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitEXP(this);
        }


        public LEXP() : base(2, NodeType.NT_EXP)
        {
        }
    }

    public class LEXPMINUS : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1, CT_RIGHT2 = 2;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext", "RightContext2" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitEXPMINUS(this);
        }


        public LEXPMINUS() : base(3, NodeType.NT_EXPMINUS)
        {
        }
    }

    public class LAssign : ASTElement
    {
        public const int CT_LEFT = 0, CT_RIGHT = 1;

        public static readonly string[] msc_contextNames = { "LeftContext", "RightContext" };

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitAssign(this);
        }


        public LAssign() : base(2, NodeType.NT_ASSIGNMENT)
        {
        }
    }

    public class LNUMBER : ASTElement
    {
        private string m_text;
        private int m_value;

        public string MName1 => m_text;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitNumber(this);
        }

        public LNUMBER(string name) : base(0, NodeType.NT_NUMBER)
        {
            m_text = name;
            m_value = int.Parse(name);
        }
    }

    public class LVARIABLE : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitVariable(this);
        }

        public LVARIABLE(string name) : base(0, NodeType.NT_VARIABLE)
        {
            m_name = name;
        }
    }

    public class LINF : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitInf(this);
        }

        public LINF(string name) : base(0, NodeType.NT_INF)
        {
            m_name = name;
        }
    }

    public class LALPHA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitAlpha(this);
        }

        public LALPHA(string name) : base(0, NodeType.NT_ALPHA)
        {
            m_name = name;
        }
    }

    public class LBETA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitBeta(this);
        }

        public LBETA(string name) : base(0, NodeType.NT_BETA)
        {
            m_name = name;
        }
    }

    public class LCHI : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitChi(this);
        }

        public LCHI(string name) : base(0, NodeType.NT_CHI)
        {
            m_name = name;
        }
    }

    public class LDELTA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitDelta(this);
        }

        public LDELTA(string name) : base(0, NodeType.NT_DELTA)
        {
            m_name = name;
        }
    }

    public class LKAPPA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitKappa(this);
        }

        public LKAPPA(string name) : base(0, NodeType.NT_KAPPA)
        {
            m_name = name;
        }
    }

    public class LLAMBDA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitLambda(this);
        }

        public LLAMBDA(string name) : base(0, NodeType.NT_LAMBDA)
        {
            m_name = name;
        }
    }

    public class LOMEGA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitOmega(this);
        }

        public LOMEGA(string name) : base(0, NodeType.NT_OMEGA)
        {
            m_name = name;
        }
    }

    public class LPHI : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitPhi(this);
        }

        public LPHI(string name) : base(0, NodeType.NT_PHI)
        {
            m_name = name;
        }
    }

    public class LPI : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitPi(this);
        }

        public LPI(string name) : base(0, NodeType.NT_PI)
        {
            m_name = name;
        }
    }

    public class LSIGMA : ASTElement
    {
        private string m_name;

        public string MName1 => m_name;

        public override T Accept<T>(ASTBaseVisitor<T> visitor)
        {
            LatexCompilerASTBaseVisitor<T> latexVisitor = visitor as LatexCompilerASTBaseVisitor<T>;  //casting in C#
            return latexVisitor.VisitSigma(this);
        }

        public LSIGMA(string name) : base(0, NodeType.NT_SIGMA)
        {
            m_name = name;
        }
    }




}
