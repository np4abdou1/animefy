using System;

namespace System.Linq.Expressions
{
	/// <summary>Describes the node types for the nodes of an expression tree.</summary>
	// Token: 0x02000089 RID: 137
	public enum ExpressionType
	{
		/// <summary>An addition operation, such as a + b, without overflow checking, for numeric operands.</summary>
		// Token: 0x040000FC RID: 252
		Add,
		/// <summary>An addition operation, such as (a + b), with overflow checking, for numeric operands.</summary>
		// Token: 0x040000FD RID: 253
		AddChecked,
		/// <summary>A bitwise or logical <see langword="AND" /> operation, such as (a &amp; b) in C# and (a And b) in Visual Basic.</summary>
		// Token: 0x040000FE RID: 254
		And,
		/// <summary>A conditional <see langword="AND" /> operation that evaluates the second operand only if the first operand evaluates to <see langword="true" />. It corresponds to (a &amp;&amp; b) in C# and (a AndAlso b) in Visual Basic.</summary>
		// Token: 0x040000FF RID: 255
		AndAlso,
		/// <summary>An operation that obtains the length of a one-dimensional array, such as array.Length.</summary>
		// Token: 0x04000100 RID: 256
		ArrayLength,
		/// <summary>An indexing operation in a one-dimensional array, such as array[index] in C# or array(index) in Visual Basic.</summary>
		// Token: 0x04000101 RID: 257
		ArrayIndex,
		/// <summary>A method call, such as in the obj.sampleMethod() expression.</summary>
		// Token: 0x04000102 RID: 258
		Call,
		/// <summary>A node that represents a null coalescing operation, such as (a ?? b) in C# or If(a, b) in Visual Basic.</summary>
		// Token: 0x04000103 RID: 259
		Coalesce,
		/// <summary>A conditional operation, such as a &gt; b ? a : b in C# or If(a &gt; b, a, b) in Visual Basic.</summary>
		// Token: 0x04000104 RID: 260
		Conditional,
		/// <summary>A constant value.</summary>
		// Token: 0x04000105 RID: 261
		Constant,
		/// <summary>A cast or conversion operation, such as (SampleType)obj in C#or CType(obj, SampleType) in Visual Basic. For a numeric conversion, if the converted value is too large for the destination type, no exception is thrown.</summary>
		// Token: 0x04000106 RID: 262
		Convert,
		/// <summary>A cast or conversion operation, such as (SampleType)obj in C#or CType(obj, SampleType) in Visual Basic. For a numeric conversion, if the converted value does not fit the destination type, an exception is thrown.</summary>
		// Token: 0x04000107 RID: 263
		ConvertChecked,
		/// <summary>A division operation, such as (a / b), for numeric operands.</summary>
		// Token: 0x04000108 RID: 264
		Divide,
		/// <summary>A node that represents an equality comparison, such as (a == b) in C# or (a = b) in Visual Basic.</summary>
		// Token: 0x04000109 RID: 265
		Equal,
		/// <summary>A bitwise or logical <see langword="XOR" /> operation, such as (a ^ b) in C# or (a Xor b) in Visual Basic.</summary>
		// Token: 0x0400010A RID: 266
		ExclusiveOr,
		/// <summary>A "greater than" comparison, such as (a &gt; b).</summary>
		// Token: 0x0400010B RID: 267
		GreaterThan,
		/// <summary>A "greater than or equal to" comparison, such as (a &gt;= b).</summary>
		// Token: 0x0400010C RID: 268
		GreaterThanOrEqual,
		/// <summary>An operation that invokes a delegate or lambda expression, such as sampleDelegate.Invoke().</summary>
		// Token: 0x0400010D RID: 269
		Invoke,
		/// <summary>A lambda expression, such as a =&gt; a + a in C# or Function(a) a + a in Visual Basic.</summary>
		// Token: 0x0400010E RID: 270
		Lambda,
		/// <summary>A bitwise left-shift operation, such as (a &lt;&lt; b).</summary>
		// Token: 0x0400010F RID: 271
		LeftShift,
		/// <summary>A "less than" comparison, such as (a &lt; b).</summary>
		// Token: 0x04000110 RID: 272
		LessThan,
		/// <summary>A "less than or equal to" comparison, such as (a &lt;= b).</summary>
		// Token: 0x04000111 RID: 273
		LessThanOrEqual,
		/// <summary>An operation that creates a new <see cref="T:System.Collections.IEnumerable" /> object and initializes it from a list of elements, such as new List&lt;SampleType&gt;(){ a, b, c } in C# or Dim sampleList = { a, b, c } in Visual Basic.</summary>
		// Token: 0x04000112 RID: 274
		ListInit,
		/// <summary>An operation that reads from a field or property, such as obj.SampleProperty.</summary>
		// Token: 0x04000113 RID: 275
		MemberAccess,
		/// <summary>An operation that creates a new object and initializes one or more of its members, such as new Point { X = 1, Y = 2 } in C# or New Point With {.X = 1, .Y = 2} in Visual Basic.</summary>
		// Token: 0x04000114 RID: 276
		MemberInit,
		/// <summary>An arithmetic remainder operation, such as (a % b) in C# or (a Mod b) in Visual Basic.</summary>
		// Token: 0x04000115 RID: 277
		Modulo,
		/// <summary>A multiplication operation, such as (a * b), without overflow checking, for numeric operands.</summary>
		// Token: 0x04000116 RID: 278
		Multiply,
		/// <summary>An multiplication operation, such as (a * b), that has overflow checking, for numeric operands.</summary>
		// Token: 0x04000117 RID: 279
		MultiplyChecked,
		/// <summary>An arithmetic negation operation, such as (-a). The object a should not be modified in place.</summary>
		// Token: 0x04000118 RID: 280
		Negate,
		/// <summary>A unary plus operation, such as (+a). The result of a predefined unary plus operation is the value of the operand, but user-defined implementations might have unusual results.</summary>
		// Token: 0x04000119 RID: 281
		UnaryPlus,
		/// <summary>An arithmetic negation operation, such as (-a), that has overflow checking. The object a should not be modified in place.</summary>
		// Token: 0x0400011A RID: 282
		NegateChecked,
		/// <summary>An operation that calls a constructor to create a new object, such as new SampleType().</summary>
		// Token: 0x0400011B RID: 283
		New,
		/// <summary>An operation that creates a new one-dimensional array and initializes it from a list of elements, such as new SampleType[]{a, b, c} in C# or New SampleType(){a, b, c} in Visual Basic.</summary>
		// Token: 0x0400011C RID: 284
		NewArrayInit,
		/// <summary>An operation that creates a new array, in which the bounds for each dimension are specified, such as new SampleType[dim1, dim2] in C# or New SampleType(dim1, dim2) in Visual Basic.</summary>
		// Token: 0x0400011D RID: 285
		NewArrayBounds,
		/// <summary>A bitwise complement or logical negation operation. In C#, it is equivalent to (~a) for integral types and to (!a) for Boolean values. In Visual Basic, it is equivalent to (Not a). The object a should not be modified in place.</summary>
		// Token: 0x0400011E RID: 286
		Not,
		/// <summary>An inequality comparison, such as (a != b) in C# or (a &lt;&gt; b) in Visual Basic.</summary>
		// Token: 0x0400011F RID: 287
		NotEqual,
		/// <summary>A bitwise or logical <see langword="OR" /> operation, such as (a | b) in C# or (a Or b) in Visual Basic.</summary>
		// Token: 0x04000120 RID: 288
		Or,
		/// <summary>A short-circuiting conditional <see langword="OR" /> operation, such as (a || b) in C# or (a OrElse b) in Visual Basic.</summary>
		// Token: 0x04000121 RID: 289
		OrElse,
		/// <summary>A reference to a parameter or variable that is defined in the context of the expression. For more information, see <see cref="T:System.Linq.Expressions.ParameterExpression" />.</summary>
		// Token: 0x04000122 RID: 290
		Parameter,
		/// <summary>A mathematical operation that raises a number to a power, such as (a ^ b) in Visual Basic.</summary>
		// Token: 0x04000123 RID: 291
		Power,
		/// <summary>An expression that has a constant value of type <see cref="T:System.Linq.Expressions.Expression" />. A <see cref="F:System.Linq.Expressions.ExpressionType.Quote" /> node can contain references to parameters that are defined in the context of the expression it represents.</summary>
		// Token: 0x04000124 RID: 292
		Quote,
		/// <summary>A bitwise right-shift operation, such as (a &gt;&gt; b).</summary>
		// Token: 0x04000125 RID: 293
		RightShift,
		/// <summary>A subtraction operation, such as (a - b), without overflow checking, for numeric operands.</summary>
		// Token: 0x04000126 RID: 294
		Subtract,
		/// <summary>An arithmetic subtraction operation, such as (a - b), that has overflow checking, for numeric operands.</summary>
		// Token: 0x04000127 RID: 295
		SubtractChecked,
		/// <summary>An explicit reference or boxing conversion in which <see langword="null" /> is supplied if the conversion fails, such as (obj as SampleType) in C# or TryCast(obj, SampleType) in Visual Basic.</summary>
		// Token: 0x04000128 RID: 296
		TypeAs,
		/// <summary>A type test, such as obj is SampleType in C# or TypeOf obj is SampleType in Visual Basic.</summary>
		// Token: 0x04000129 RID: 297
		TypeIs,
		/// <summary>An assignment operation, such as (a = b).</summary>
		// Token: 0x0400012A RID: 298
		Assign,
		/// <summary>A block of expressions.</summary>
		// Token: 0x0400012B RID: 299
		Block,
		/// <summary>Debugging information.</summary>
		// Token: 0x0400012C RID: 300
		DebugInfo,
		/// <summary>A unary decrement operation, such as (a - 1) in C# and Visual Basic. The object a should not be modified in place.</summary>
		// Token: 0x0400012D RID: 301
		Decrement,
		/// <summary>A dynamic operation.</summary>
		// Token: 0x0400012E RID: 302
		Dynamic,
		/// <summary>A default value.</summary>
		// Token: 0x0400012F RID: 303
		Default,
		/// <summary>An extension expression.</summary>
		// Token: 0x04000130 RID: 304
		Extension,
		/// <summary>A "go to" expression, such as goto Label in C# or GoTo Label in Visual Basic.</summary>
		// Token: 0x04000131 RID: 305
		Goto,
		/// <summary>A unary increment operation, such as (a + 1) in C# and Visual Basic. The object a should not be modified in place.</summary>
		// Token: 0x04000132 RID: 306
		Increment,
		/// <summary>An index operation or an operation that accesses a property that takes arguments. </summary>
		// Token: 0x04000133 RID: 307
		Index,
		/// <summary>A label.</summary>
		// Token: 0x04000134 RID: 308
		Label,
		/// <summary>A list of run-time variables. For more information, see <see cref="T:System.Linq.Expressions.RuntimeVariablesExpression" />.</summary>
		// Token: 0x04000135 RID: 309
		RuntimeVariables,
		/// <summary>A loop, such as for or while.</summary>
		// Token: 0x04000136 RID: 310
		Loop,
		/// <summary>A switch operation, such as <see langword="switch" /> in C# or <see langword="Select Case" /> in Visual Basic.</summary>
		// Token: 0x04000137 RID: 311
		Switch,
		/// <summary>An operation that throws an exception, such as throw new Exception().</summary>
		// Token: 0x04000138 RID: 312
		Throw,
		/// <summary>A <see langword="try-catch" /> expression.</summary>
		// Token: 0x04000139 RID: 313
		Try,
		/// <summary>An unbox value type operation, such as <see langword="unbox" /> and <see langword="unbox.any" /> instructions in MSIL. </summary>
		// Token: 0x0400013A RID: 314
		Unbox,
		/// <summary>An addition compound assignment operation, such as (a += b), without overflow checking, for numeric operands.</summary>
		// Token: 0x0400013B RID: 315
		AddAssign,
		/// <summary>A bitwise or logical <see langword="AND" /> compound assignment operation, such as (a &amp;= b) in C#.</summary>
		// Token: 0x0400013C RID: 316
		AndAssign,
		/// <summary>An division compound assignment operation, such as (a /= b), for numeric operands.</summary>
		// Token: 0x0400013D RID: 317
		DivideAssign,
		/// <summary>A bitwise or logical <see langword="XOR" /> compound assignment operation, such as (a ^= b) in C#.</summary>
		// Token: 0x0400013E RID: 318
		ExclusiveOrAssign,
		/// <summary>A bitwise left-shift compound assignment, such as (a &lt;&lt;= b).</summary>
		// Token: 0x0400013F RID: 319
		LeftShiftAssign,
		/// <summary>An arithmetic remainder compound assignment operation, such as (a %= b) in C#.</summary>
		// Token: 0x04000140 RID: 320
		ModuloAssign,
		/// <summary>A multiplication compound assignment operation, such as (a *= b), without overflow checking, for numeric operands.</summary>
		// Token: 0x04000141 RID: 321
		MultiplyAssign,
		/// <summary>A bitwise or logical <see langword="OR" /> compound assignment, such as (a |= b) in C#.</summary>
		// Token: 0x04000142 RID: 322
		OrAssign,
		/// <summary>A compound assignment operation that raises a number to a power, such as (a ^= b) in Visual Basic.</summary>
		// Token: 0x04000143 RID: 323
		PowerAssign,
		/// <summary>A bitwise right-shift compound assignment operation, such as (a &gt;&gt;= b).</summary>
		// Token: 0x04000144 RID: 324
		RightShiftAssign,
		/// <summary>A subtraction compound assignment operation, such as (a -= b), without overflow checking, for numeric operands.</summary>
		// Token: 0x04000145 RID: 325
		SubtractAssign,
		/// <summary>An addition compound assignment operation, such as (a += b), with overflow checking, for numeric operands.</summary>
		// Token: 0x04000146 RID: 326
		AddAssignChecked,
		/// <summary>A multiplication compound assignment operation, such as (a *= b), that has overflow checking, for numeric operands.</summary>
		// Token: 0x04000147 RID: 327
		MultiplyAssignChecked,
		/// <summary>A subtraction compound assignment operation, such as (a -= b), that has overflow checking, for numeric operands.</summary>
		// Token: 0x04000148 RID: 328
		SubtractAssignChecked,
		/// <summary>A unary prefix increment, such as (++a). The object a should be modified in place.</summary>
		// Token: 0x04000149 RID: 329
		PreIncrementAssign,
		/// <summary>A unary prefix decrement, such as (--a). The object a should be modified in place.</summary>
		// Token: 0x0400014A RID: 330
		PreDecrementAssign,
		/// <summary>A unary postfix increment, such as (a++). The object a should be modified in place.</summary>
		// Token: 0x0400014B RID: 331
		PostIncrementAssign,
		/// <summary>A unary postfix decrement, such as (a--). The object a should be modified in place.</summary>
		// Token: 0x0400014C RID: 332
		PostDecrementAssign,
		/// <summary>An exact type test.</summary>
		// Token: 0x0400014D RID: 333
		TypeEqual,
		/// <summary>A ones complement operation, such as (~a) in C#.</summary>
		// Token: 0x0400014E RID: 334
		OnesComplement,
		/// <summary>A <see langword="true" /> condition value.</summary>
		// Token: 0x0400014F RID: 335
		IsTrue,
		/// <summary>A <see langword="false" /> condition value.</summary>
		// Token: 0x04000150 RID: 336
		IsFalse
	}
}
