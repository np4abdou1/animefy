using System;
using System.Globalization;

namespace System.Data
{
	// Token: 0x02000064 RID: 100
	internal sealed class ExprException
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x00022633 File Offset: 0x00020833
		private static OverflowException _Overflow(string error)
		{
			OverflowException ex = new OverflowException(error);
			ExceptionBuilder.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00022642 File Offset: 0x00020842
		private static InvalidExpressionException _Expr(string error)
		{
			InvalidExpressionException ex = new InvalidExpressionException(error);
			ExceptionBuilder.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00022651 File Offset: 0x00020851
		private static SyntaxErrorException _Syntax(string error)
		{
			SyntaxErrorException ex = new SyntaxErrorException(error);
			ExceptionBuilder.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00022660 File Offset: 0x00020860
		private static EvaluateException _Eval(string error)
		{
			EvaluateException ex = new EvaluateException(error);
			ExceptionBuilder.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00022660 File Offset: 0x00020860
		private static EvaluateException _Eval(string error, Exception innerException)
		{
			EvaluateException ex = new EvaluateException(error);
			ExceptionBuilder.TraceExceptionAsReturnValue(ex);
			return ex;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0002266F File Offset: 0x0002086F
		public static Exception InvokeArgument()
		{
			return ExceptionBuilder._Argument("Need a row or a table to Invoke DataFilter.");
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0002267B File Offset: 0x0002087B
		public static Exception NYI(string moreinfo)
		{
			return ExprException._Expr(SR.Format("The feature not implemented. {0}.", moreinfo));
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002268D File Offset: 0x0002088D
		public static Exception MissingOperand(OperatorInfo before)
		{
			return ExprException._Syntax(SR.Format("Syntax error: Missing operand after '{0}' operator.", Operators.ToString(before._op)));
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000226A9 File Offset: 0x000208A9
		public static Exception MissingOperator(string token)
		{
			return ExprException._Syntax(SR.Format("Syntax error: Missing operand after '{0}' operator.", token));
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000226BB File Offset: 0x000208BB
		public static Exception TypeMismatch(string expr)
		{
			return ExprException._Eval(SR.Format("Type mismatch in expression '{0}'.", expr));
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000226CD File Offset: 0x000208CD
		public static Exception FunctionArgumentOutOfRange(string arg, string func)
		{
			return ExceptionBuilder._ArgumentOutOfRange(arg, SR.Format("{0}() argument is out of range.", func));
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000226E0 File Offset: 0x000208E0
		public static Exception ExpressionTooComplex()
		{
			return ExprException._Eval("Expression is too complex.");
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000226EC File Offset: 0x000208EC
		public static Exception UnboundName(string name)
		{
			return ExprException._Eval(SR.Format("Cannot find column [{0}].", name));
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000226FE File Offset: 0x000208FE
		public static Exception InvalidString(string str)
		{
			return ExprException._Syntax(SR.Format("The expression contains an invalid string constant: {0}.", str));
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00022710 File Offset: 0x00020910
		public static Exception UndefinedFunction(string name)
		{
			return ExprException._Eval(SR.Format("The expression contains undefined function call {0}().", name));
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00022722 File Offset: 0x00020922
		public static Exception SyntaxError()
		{
			return ExprException._Syntax("Syntax error in the expression.");
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0002272E File Offset: 0x0002092E
		public static Exception FunctionArgumentCount(string name)
		{
			return ExprException._Eval(SR.Format("Invalid number of arguments: function {0}().", name));
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00022740 File Offset: 0x00020940
		public static Exception MissingRightParen()
		{
			return ExprException._Syntax("The expression is missing the closing parenthesis.");
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0002274C File Offset: 0x0002094C
		public static Exception UnknownToken(string token, int position)
		{
			return ExprException._Syntax(SR.Format("Cannot interpret token '{0}' at position {1}.", token, position.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0002276A File Offset: 0x0002096A
		public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position)
		{
			return ExprException._Syntax(SR.Format("Expected {0}, but actual token at the position {2} is {1}.", tokExpected.ToString(), tokCurr.ToString(), position.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000227A1 File Offset: 0x000209A1
		public static Exception DatatypeConvertion(Type type1, Type type2)
		{
			return ExprException._Eval(SR.Format("Cannot convert from {0} to {1}.", type1.ToString(), type2.ToString()));
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000227BE File Offset: 0x000209BE
		public static Exception DatavalueConvertion(object value, Type type, Exception innerException)
		{
			return ExprException._Eval(SR.Format("Cannot convert value '{0}' to Type: {1}.", value.ToString(), type.ToString()), innerException);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000227DC File Offset: 0x000209DC
		public static Exception InvalidName(string name)
		{
			return ExprException._Syntax(SR.Format("Invalid column name [{0}].", name));
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000227EE File Offset: 0x000209EE
		public static Exception InvalidDate(string date)
		{
			return ExprException._Syntax(SR.Format("The expression contains invalid date constant '{0}'.", date));
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00022800 File Offset: 0x00020A00
		public static Exception NonConstantArgument()
		{
			return ExprException._Eval("Only constant expressions are allowed in the expression list for the IN operator.");
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0002280C File Offset: 0x00020A0C
		public static Exception InvalidPattern(string pat)
		{
			return ExprException._Eval(SR.Format("Error in Like operator: the string pattern '{0}' is invalid.", pat));
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002281E File Offset: 0x00020A1E
		public static Exception InWithoutParentheses()
		{
			return ExprException._Syntax("Syntax error: The items following the IN keyword must be separated by commas and be enclosed in parentheses.");
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0002282A File Offset: 0x00020A2A
		public static Exception InWithoutList()
		{
			return ExprException._Syntax("Syntax error: The IN keyword must be followed by a non-empty list of expressions separated by commas, and also must be enclosed in parentheses.");
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00022836 File Offset: 0x00020A36
		public static Exception InvalidIsSyntax()
		{
			return ExprException._Syntax("Syntax error: Invalid usage of 'Is' operator. Correct syntax: <expression> Is [Not] Null.");
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00022842 File Offset: 0x00020A42
		public static Exception Overflow(Type type)
		{
			return ExprException._Overflow(SR.Format("Value is either too large or too small for Type '{0}'.", type.Name));
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00022859 File Offset: 0x00020A59
		public static Exception ArgumentType(string function, int arg, Type type)
		{
			return ExprException._Eval(SR.Format("Type mismatch in function argument: {0}(), argument {1}, expected {2}.", function, arg.ToString(CultureInfo.InvariantCulture), type.ToString()));
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0002287D File Offset: 0x00020A7D
		public static Exception ArgumentTypeInteger(string function, int arg)
		{
			return ExprException._Eval(SR.Format("Type mismatch in function argument: {0}(), argument {1}, expected one of the Integer types.", function, arg.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0002289B File Offset: 0x00020A9B
		public static Exception TypeMismatchInBinop(int op, Type type1, Type type2)
		{
			return ExprException._Eval(SR.Format("Cannot perform '{0}' operation on {1} and {2}.", Operators.ToString(op), type1.ToString(), type2.ToString()));
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000228BE File Offset: 0x00020ABE
		public static Exception AmbiguousBinop(int op, Type type1, Type type2)
		{
			return ExprException._Eval(SR.Format("Operator '{0}' is ambiguous on operands of type '{1}' and '{2}'. Cannot mix signed and unsigned types. Please use explicit Convert() function.", Operators.ToString(op), type1.ToString(), type2.ToString()));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000228E1 File Offset: 0x00020AE1
		public static Exception UnsupportedOperator(int op)
		{
			return ExprException._Eval(SR.Format("The expression contains unsupported operator '{0}'.", Operators.ToString(op)));
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000228F8 File Offset: 0x00020AF8
		public static Exception InvalidNameBracketing(string name)
		{
			return ExprException._Syntax(SR.Format("The expression contains invalid name: '{0}'.", name));
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0002290A File Offset: 0x00020B0A
		public static Exception MissingOperandBefore(string op)
		{
			return ExprException._Syntax(SR.Format("Syntax error: Missing operand before '{0}' operator.", op));
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0002291C File Offset: 0x00020B1C
		public static Exception TooManyRightParentheses()
		{
			return ExprException._Syntax("The expression has too many closing parentheses.");
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00022928 File Offset: 0x00020B28
		public static Exception UnresolvedRelation(string name, string expr)
		{
			return ExprException._Eval(SR.Format("The table [{0}] involved in more than one relation. You must explicitly mention a relation name in the expression '{1}'.", name, expr));
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0002293B File Offset: 0x00020B3B
		internal static EvaluateException BindFailure(string relationName)
		{
			return ExprException._Eval(SR.Format("Cannot find the parent relation '{0}'.", relationName));
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0002294D File Offset: 0x00020B4D
		public static Exception AggregateArgument()
		{
			return ExprException._Syntax("Syntax error in aggregate argument: Expecting a single column argument with possible 'Child' qualifier.");
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00022959 File Offset: 0x00020B59
		public static Exception AggregateUnbound(string expr)
		{
			return ExprException._Eval(SR.Format("Unbound reference in the aggregate expression '{0}'.", expr));
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0002296B File Offset: 0x00020B6B
		public static Exception EvalNoContext()
		{
			return ExprException._Eval("Cannot evaluate non-constant expression without current row.");
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00022977 File Offset: 0x00020B77
		public static Exception ExpressionUnbound(string expr)
		{
			return ExprException._Eval(SR.Format("Unbound reference in the expression '{0}'.", expr));
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00022989 File Offset: 0x00020B89
		public static Exception ComputeNotAggregate(string expr)
		{
			return ExprException._Eval(SR.Format("Cannot evaluate. Expression '{0}' is not an aggregate.", expr));
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0002299B File Offset: 0x00020B9B
		public static Exception FilterConvertion(string expr)
		{
			return ExprException._Eval(SR.Format("Filter expression '{0}' does not evaluate to a Boolean term.", expr));
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000229AD File Offset: 0x00020BAD
		public static Exception LookupArgument()
		{
			return ExprException._Syntax("Syntax error in Lookup expression: Expecting keyword 'Parent' followed by a single column argument with possible relation qualifier: Parent[(<relation_name>)].<column_name>.");
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000229B9 File Offset: 0x00020BB9
		public static Exception InvalidType(string typeName)
		{
			return ExprException._Eval(SR.Format("Invalid type name '{0}'.", typeName));
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000229CB File Offset: 0x00020BCB
		public static Exception InvalidHoursArgument()
		{
			return ExprException._Eval("'hours' argument is out of range. Value must be between -14 and +14.");
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000229D7 File Offset: 0x00020BD7
		public static Exception InvalidMinutesArgument()
		{
			return ExprException._Eval("'minutes' argument is out of range. Value must be between -59 and +59.");
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000229E3 File Offset: 0x00020BE3
		public static Exception InvalidTimeZoneRange()
		{
			return ExprException._Eval("Provided range for time one exceeds total of 14 hours.");
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000229EF File Offset: 0x00020BEF
		public static Exception MismatchKindandTimeSpan()
		{
			return ExprException._Eval("Kind property of provided DateTime argument, does not match 'hours' and 'minutes' arguments.");
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000229FB File Offset: 0x00020BFB
		public static Exception UnsupportedDataType(Type type)
		{
			return ExceptionBuilder._Argument(SR.Format("A DataColumn of type '{0}' does not support expression.", type.FullName));
		}
	}
}
