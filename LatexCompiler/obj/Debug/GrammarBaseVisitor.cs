//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Manos\Desktop\LatexCompiler\LatexCompiler\Grammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace LatexCompiler {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGrammarVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GrammarBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IGrammarVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>Product_expression</c>
	/// labeled alternative in <see cref="GrammarParser.product"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProduct_expression([NotNull] GrammarParser.Product_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Cos_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCos_expression([NotNull] GrammarParser.Cos_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Simple_Function_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSimple_Function_expression([NotNull] GrammarParser.Simple_Function_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Log_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLog_expression([NotNull] GrammarParser.Log_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sin_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSin_expression([NotNull] GrammarParser.Sin_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arctan_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArctan_expression([NotNull] GrammarParser.Arctan_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arccos_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArccos_expression([NotNull] GrammarParser.Arccos_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Arcsin_expression</c>
	/// labeled alternative in <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArcsin_expression([NotNull] GrammarParser.Arcsin_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Square_expression</c>
	/// labeled alternative in <see cref="GrammarParser.squareRoot"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSquare_expression([NotNull] GrammarParser.Square_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>NSquare_expression</c>
	/// labeled alternative in <see cref="GrammarParser.squareRoot"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNSquare_expression([NotNull] GrammarParser.NSquare_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Sum_expression</c>
	/// labeled alternative in <see cref="GrammarParser.sum"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSum_expression([NotNull] GrammarParser.Sum_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Ceil_expression</c>
	/// labeled alternative in <see cref="GrammarParser.ceil"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCeil_expression([NotNull] GrammarParser.Ceil_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Fraction_expression</c>
	/// labeled alternative in <see cref="GrammarParser.fraction"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFraction_expression([NotNull] GrammarParser.Fraction_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Lim_expression</c>
	/// labeled alternative in <see cref="GrammarParser.lim"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLim_expression([NotNull] GrammarParser.Lim_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Integrals_expression</c>
	/// labeled alternative in <see cref="GrammarParser.integrals"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntegrals_expression([NotNull] GrammarParser.Integrals_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Expression_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression_expr([NotNull] GrammarParser.Expression_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>PlusMinus_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPlusMinus_expr([NotNull] GrammarParser.PlusMinus_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpExpressionMinus_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpExpressionMinus_expr([NotNull] GrammarParser.ExpExpressionMinus_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Assign_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssign_expr([NotNull] GrammarParser.Assign_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>GTLTGTELTE_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGTLTGTELTE_expr([NotNull] GrammarParser.GTLTGTELTE_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>MultiDiv_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultiDiv_expr([NotNull] GrammarParser.MultiDiv_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>ExpExpression_expr</c>
	/// labeled alternative in <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpExpression_expr([NotNull] GrammarParser.ExpExpression_exprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>Floor_expression</c>
	/// labeled alternative in <see cref="GrammarParser.floor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloor_expression([NotNull] GrammarParser.Floor_expressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.compileUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompileUnit([NotNull] GrammarParser.CompileUnitContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] GrammarParser.ExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] GrammarParser.ExpressionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.paren"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParen([NotNull] GrammarParser.ParenContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.squareRoot"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSquareRoot([NotNull] GrammarParser.SquareRootContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.fraction"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFraction([NotNull] GrammarParser.FractionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.floor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloor([NotNull] GrammarParser.FloorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.ceil"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCeil([NotNull] GrammarParser.CeilContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctions([NotNull] GrammarParser.FunctionsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.sum"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSum([NotNull] GrammarParser.SumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.lim"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLim([NotNull] GrammarParser.LimContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.product"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProduct([NotNull] GrammarParser.ProductContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.integrals"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntegrals([NotNull] GrammarParser.IntegralsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="GrammarParser.greekLetters"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGreekLetters([NotNull] GrammarParser.GreekLettersContext context) { return VisitChildren(context); }
}
} // namespace LatexCompiler
