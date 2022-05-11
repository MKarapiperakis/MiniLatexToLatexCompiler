using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace LatexCompiler
{
    public class ASTGenerator : GrammarBaseVisitor<int>
    {
        private ASTElement m_root;

        public ASTElement MRoot => m_root;

        private Stack<(ASTElement, int)> m_contextData = new Stack<(ASTElement, int)>();


        public override int VisitCompileUnit(GrammarParser.CompileUnitContext context)
        {
            LCompileUnit newnode = new LCompileUnit();
            m_root = newnode;

            (ASTElement, int) t;


            t = (m_root, LCompileUnit.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())
            {
                Visit(child);

            }
            m_contextData.Pop();


            return 0;
        }

        /*
        public override int VisitExpression_expr([NotNull] GrammarParser.Expression_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LEXPRESSION newnode = new LEXPRESSION();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LEXPRESSION.CT_EXPRESSION);
            m_contextData.Push(t);
            Visit(context.expression());
            m_contextData.Pop();

            return 0;
        }
        */
        public override int VisitNSquare_expression([NotNull] GrammarParser.NSquare_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LNSqrt newnode = new LNSqrt();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LNSqrt.CT_NUMBER);
            m_contextData.Push(t);
            Visit(context.NUMBER());
            m_contextData.Pop();


            t = (newnode, LNSqrt.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();

            return 0;
        }

        public override int VisitSquare_expression([NotNull] GrammarParser.Square_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LSqrt newnode = new LSqrt();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LSqrt.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();

            return 0;
        }


        public override int VisitFraction_expression([NotNull] GrammarParser.Fraction_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LFrac newnode = new LFrac();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LFrac.CT_EXPRESSION1);
            m_contextData.Push(t);
            Visit(context.expr(0));
            m_contextData.Pop();

            t = (newnode, LFrac.CT_EXPRESSION2);
            m_contextData.Push(t);
            Visit(context.expr(1));
            m_contextData.Pop();



            return 0;
        }

        public override int VisitFloor_expression([NotNull] GrammarParser.Floor_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LFloor newnode = new LFloor();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LFloor.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();

            return 0;
        }

        public override int VisitCeil_expression([NotNull] GrammarParser.Ceil_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LCeil newnode = new LCeil();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LCeil.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitCos_expression([NotNull] GrammarParser.Cos_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LCos newnode = new LCos();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LCos.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();

            return 0;
        }

        public override int VisitSin_expression([NotNull] GrammarParser.Sin_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LSin newnode = new LSin();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LSin.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitArcsin_expression([NotNull] GrammarParser.Arcsin_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LArcSin newnode = new LArcSin();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LArcSin.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitArccos_expression([NotNull] GrammarParser.Arccos_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LArcCos newnode = new LArcCos();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LArcCos.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitArctan_expression([NotNull] GrammarParser.Arctan_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LArcTan newnode = new LArcTan();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LArcTan.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitLog_expression([NotNull] GrammarParser.Log_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LLog newnode = new LLog();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;


            t = (newnode, LLog.CT_EXPRESSION);
            m_contextData.Push(t);
            foreach (var child in context.expr())       //epeidh sth grammatikh einai expr+ kai epomenws mporw na exw polla
            {
                Visit(child);
            }
            m_contextData.Pop();
            return 0;
        }

        public override int VisitSimple_Function_expression([NotNull] GrammarParser.Simple_Function_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LFunction newnode = new LFunction();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LFunction.CT_FUNCTION_NAME);
            m_contextData.Push(t);
            Visit(context.VARIABLE());
            m_contextData.Pop();

            t = (newnode, LFunction.CT_EXPRESSION1);
            m_contextData.Push(t);
            Visit(context.expr(0));
            m_contextData.Pop();

            if (context.expr(1) != null)
            {
                t = (newnode, LFunction.CT_EXPRESSION2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }
            return 0;
        }

        public override int VisitSum_expression([NotNull] GrammarParser.Sum_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LSum newnode = new LSum();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            if (context.expr(0) != null)
            {
                t = (newnode, LSum.CT_EXPRESSION1);
                m_contextData.Push(t);
                Visit(context.expr(0));
                m_contextData.Pop();
            }

            if (context.expr(1) != null)
            {
                t = (newnode, LSum.CT_EXPRESSION2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }

            if (context.expr(2) != null)
            {
                t = (newnode, LSum.CT_EXPRESSION3);
                m_contextData.Push(t);
                Visit(context.expr(2));
                m_contextData.Pop();
            }

            return 0;
        }

        public override int VisitLim_expression([NotNull] GrammarParser.Lim_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LLim newnode = new LLim();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            if (context.expr(0) != null)
            {
                t = (newnode, LLim.CT_EXPRESSION1);
                m_contextData.Push(t);
                Visit(context.expr(0));
                m_contextData.Pop();
            }

            if (context.expr(1) != null)
            {
                t = (newnode, LLim.CT_EXPRESSION2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }

            if (context.expr(2) != null)
            {
                t = (newnode, LLim.CT_EXPRESSION3);
                m_contextData.Push(t);
                Visit(context.expr(2));
                m_contextData.Pop();
            }

            return 0;
        }

        public override int VisitProduct_expression([NotNull] GrammarParser.Product_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LProduct newnode = new LProduct();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            if (context.expr(0) != null)
            {
                t = (newnode, LProduct.CT_EXPRESSION1);
                m_contextData.Push(t);
                Visit(context.expr(0));
                m_contextData.Pop();
            }

            if (context.expr(1) != null)
            {
                t = (newnode, LProduct.CT_EXPRESSION2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }

            if (context.expr(2) != null)
            {
                t = (newnode, LProduct.CT_EXPRESSION3);
                m_contextData.Push(t);
                Visit(context.expr(2));
                m_contextData.Pop();
            }

            return 0;
        }

        public override int VisitIntegrals_expression([NotNull] GrammarParser.Integrals_expressionContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LIntegrals newnode = new LIntegrals();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            if (context.expr(0) != null)
            {
                t = (newnode, LIntegrals.CT_EXPRESSION1);
                m_contextData.Push(t);
                Visit(context.expr(0));
                m_contextData.Pop();
            }

            if (context.expr(1) != null)
            {
                t = (newnode, LIntegrals.CT_EXPRESSION2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }

            if (context.expr(2) != null)
            {
                t = (newnode, LIntegrals.CT_EXPRESSION3);
                m_contextData.Push(t);
                Visit(context.expr(2));
                m_contextData.Pop();
            }

            return 0;
        }


        public override int VisitPlusMinus_expr([NotNull] GrammarParser.PlusMinus_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            switch (context.op.Type)
            {
                case GrammarLexer.PLUS:
                    LAddition newnode = new LAddition();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode, parent_data.Item2);
                    newnode.MParent = parent_data.Item1;

                    t = (newnode, LAddition.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode, LAddition.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

                case GrammarLexer.MINUS:
                    LSubtraction newnode1 = new LSubtraction();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode1, parent_data.Item2);
                    newnode1.MParent = parent_data.Item1;

                    t = (newnode1, LSubtraction.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode1, LSubtraction.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

            }
            return 0;
        }

        public override int VisitMultiDiv_expr([NotNull] GrammarParser.MultiDiv_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            switch (context.op.Type)
            {
                case GrammarLexer.MULTI:
                    LMultiplication newnode = new LMultiplication();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode, parent_data.Item2);
                    newnode.MParent = parent_data.Item1;

                    t = (newnode, LMultiplication.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode, LMultiplication.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

                case GrammarLexer.DIV:
                    LDivision newnode1 = new LDivision();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode1, parent_data.Item2);
                    newnode1.MParent = parent_data.Item1;

                    t = (newnode1, LDivision.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode1, LDivision.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

            }
            return 0;
        }

        public override int VisitGTLTGTELTE_expr([NotNull] GrammarParser.GTLTGTELTE_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            switch (context.op.Type)
            {
                case GrammarLexer.GT:
                    LGT newnode = new LGT();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode, parent_data.Item2);
                    newnode.MParent = parent_data.Item1;

                    t = (newnode, LGT.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode, LGT.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

                case GrammarLexer.GTE:
                    LGTE newnode1 = new LGTE();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode1, parent_data.Item2);
                    newnode1.MParent = parent_data.Item1;

                    t = (newnode1, LGTE.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode1, LGTE.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;
                case GrammarLexer.LT:
                    LLT newnode2 = new LLT();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode2, parent_data.Item2);
                    newnode2.MParent = parent_data.Item1;

                    t = (newnode2, LLT.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode2, LLT.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;
                case GrammarLexer.LTE:
                    LLTE newnode3 = new LLTE();
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode3, parent_data.Item2);
                    newnode3.MParent = parent_data.Item1;

                    t = (newnode3, LLTE.CT_LEFT);
                    m_contextData.Push(t);
                    Visit(context.expression());
                    m_contextData.Pop();


                    t = (newnode3, LLTE.CT_RIGHT);
                    m_contextData.Push(t);
                    Visit(context.expr());
                    m_contextData.Pop();
                    break;

            }
            return 0;
        }

        public override int VisitAssign_expr([NotNull] GrammarParser.Assign_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LAssign newnode = new LAssign();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LLTE.CT_LEFT);
            m_contextData.Push(t);
            Visit(context.expression());
            m_contextData.Pop();


            t = (newnode, LLTE.CT_RIGHT);
            m_contextData.Push(t);
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExpExpression_expr([NotNull] GrammarParser.ExpExpression_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LEXP newnode = new LEXP();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LEXP.CT_LEFT);
            m_contextData.Push(t);
            Visit(context.expression());
            m_contextData.Pop();


            t = (newnode, LEXP.CT_RIGHT);
            m_contextData.Push(t);
            Visit(context.expr());
            m_contextData.Pop();

            return 0;
        }

        public override int VisitExpExpressionMinus_expr([NotNull] GrammarParser.ExpExpressionMinus_exprContext context)
        {
            (ASTElement, int) parent_data;
            (ASTElement, int) t;

            LEXPMINUS newnode = new LEXPMINUS();
            parent_data = m_contextData.Peek();
            parent_data.Item1.AddChild(newnode, parent_data.Item2);
            newnode.MParent = parent_data.Item1;

            t = (newnode, LEXPMINUS.CT_LEFT);
            m_contextData.Push(t);
            Visit(context.expression());
            m_contextData.Pop();



            t = (newnode, LEXPMINUS.CT_RIGHT);
            m_contextData.Push(t);
            Visit(context.expr(0));
            m_contextData.Pop();

            if (context.expr(1) != null)
            {
                t = (newnode, LEXPMINUS.CT_RIGHT2);
                m_contextData.Push(t);
                Visit(context.expr(1));
                m_contextData.Pop();
            }

            return 0;
        }

        public override int VisitTerminal([NotNull] ITerminalNode node)
        {
            (ASTElement, int) parent_data;


            switch (node.Symbol.Type)
            {
                case GrammarLexer.VARIABLE:
                    LVARIABLE newnode = new LVARIABLE(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode, parent_data.Item2);
                    newnode.MParent = parent_data.Item1;

                    break;

                case GrammarLexer.NUMBER:
                    LNUMBER newnode1 = new LNUMBER(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode1, parent_data.Item2);
                    newnode1.MParent = parent_data.Item1;

                    break;

                case GrammarLexer.INF:
                    LINF newnode2 = new LINF(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode2, parent_data.Item2);
                    newnode2.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Alpha:
                    LALPHA newnode3 = new LALPHA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode3, parent_data.Item2);
                    newnode3.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Beta:
                    LBETA newnode4 = new LBETA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode4, parent_data.Item2);
                    newnode4.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Chi:
                    LCHI newnode5 = new LCHI(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode5, parent_data.Item2);
                    newnode5.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Delta:
                    LDELTA newnode6 = new LDELTA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode6, parent_data.Item2);
                    newnode6.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Kappa:
                    LKAPPA newnode7 = new LKAPPA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode7, parent_data.Item2);
                    newnode7.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Lambda:
                    LLAMBDA newnode8 = new LLAMBDA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode8, parent_data.Item2);
                    newnode8.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Omega:
                    LOMEGA newnode9 = new LOMEGA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode9, parent_data.Item2);
                    newnode9.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Phi:
                    LPHI newnode10 = new LPHI(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode10, parent_data.Item2);
                    newnode10.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Pi:
                    LPI newnode11 = new LPI(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode11, parent_data.Item2);
                    newnode11.MParent = parent_data.Item1;

                    break;
                case GrammarLexer.Sigma:
                    LSIGMA newnode12 = new LSIGMA(node.Symbol.Text);
                    //Connect current node to parent:
                    parent_data = m_contextData.Peek();
                    parent_data.Item1.AddChild(newnode12, parent_data.Item2);
                    newnode12.MParent = parent_data.Item1;

                    break;


            }

            return 0;
        }



    }
}
