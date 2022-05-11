grammar Grammar;

/*
 * Parser Rules
 */

compileUnit
	: expr+ EOF
	;

expr:
	  expression												#Expression_expr
	| expression op=(MULTI|DIV) expr							#MultiDiv_expr
	| expression op=(PLUS|MINUS) expr							#PlusMinus_expr
	| expression op=(GT|LT|GTE|LTE) expr						#GTLTGTELTE_expr
	| expression EXP expr										#ExpExpression_expr
	| expression EXP LB MINUS? expr RB expr?					#ExpExpressionMinus_expr
	| expression ASSIGN<assoc=right> expr						#Assign_expr
	;

expression
	: squareRoot				//tetragwnikh riza
	| fraction					//klasmata
	| greekLetters				//ellhnika grammata
	| floor						//floor
	| ceil						//ceil
	| functions					//synarthseis
	| sum						//athroisma
	| lim						//oria
	| product					//ginomeno	
	| integrals					//oloklhrwmata
	| paren						//parentheseis
	| NUMBER				
	| VARIABLE	
	| INF
	;


paren
	:	LP expr+ RP
	;

//LB = {		LBrackets = [
squareRoot
	: SQUARE LB expr+ RB									#Square_expression
	| SQUARE LBrackets NUMBER RBrackets	LB expr+ RB			#NSquare_expression
	;

fraction
	:	FRAC LB expr RB	LB expr RB							#Fraction_expression
	;
floor
	: LFLOOR expr+ RFLOOR									#Floor_expression
	;

ceil
	: LCEIL	expr+ RCEIL										#Ceil_expression
	;

functions
	: COS LP expr+ RP										#Cos_expression
	| SIN LP expr+ RP										#Sin_expression
	| ARCCOS LP expr+ RP									#Arccos_expression
	| ARCSIN LP expr+ RP									#Arcsin_expression
	| ARCTAN LP expr+ RP									#Arctan_expression
	| LOG LP expr+ RP										#Log_expression
	| VARIABLE LP expr (','expr)? RP						#Simple_Function_expression
	;

//LB = {		LBrackets = [
sum
	: SUM ('_' LB expr RB)? (EXP LB expr RB)? expr?			#Sum_expression
	  ;

lim
	: LIM ('_' LB expr  TO expr RB)? expr?					#Lim_expression
	;

product
	: PROD ('_' LB expr RB)? (EXP LB expr RB)? expr?		#Product_expression
	;

integrals
	: INT ('_'  LB expr RB)? (EXP LB expr RB)? expr? 		#Integrals_expression
	;

greekLetters
	: Alpha				
	| Beta				
	| Chi
	| Delta
	| Kappa
	| Lambda
	| Omega
	| Phi
	| Pi
	| Sigma
	;


/*
 * Lexer Rules
 */

EXP: '^';
FRAC: '\\frac';
//greek letters
Alpha: '\\alpha';
Beta: '\\beta';
Chi: '\\chi';
Delta: '\\delta';
Kappa: '\\kappa';
Lambda: '\\lambda';
Omega: '\\omega';
Phi: '\\phi';
Pi: '\\pi';
Sigma: '\\sigma';


SQUARE: '\\sqrt';


LFLOOR: '\\lfloor';
RFLOOR: '\\rfloor';

LCEIL: '\\lceil';
RCEIL: '\\rceil';

COS: '\\cos';
SIN: '\\sin';
ARCCOS: '\\arccos'; 
ARCSIN: '\\arcsin'; 
ARCTAN: '\\arctan'; 
LOG: '\\log';
LIM: '\\lim';

LB : '{';
RB : '}';
LBrackets: '[';
RBrackets: ']';



PLUS : '+';
MINUS : '-';
MULTI : '*';
DIV : '/';
LP: '(';
RP: ')';
GT : '>';
GTE : '>=';
LT : '<';
LTE : '<=';

ASSIGN : '=';
TO: '\\to';

SUM: '\\sum';
PROD: '\\prod';
INT: '\\int';

NUMBER : '0'|[1-9][0-9]*;
VARIABLE : [a-zA-Z][a-zA-Z']*;
INF: '\\infty';


WS
	:	[\n\r\t ] -> skip
	;
