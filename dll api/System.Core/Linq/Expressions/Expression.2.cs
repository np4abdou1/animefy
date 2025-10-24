using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;

namespace System.Linq.Expressions
{
	/// <summary>Represents a strongly typed lambda expression as a data structure in the form of an expression tree. This class cannot be inherited.</summary>
	/// <typeparam name="TDelegate">The type of the delegate that the <see cref="T:System.Linq.Expressions.Expression`1" /> represents.</typeparam>
	// Token: 0x0200009C RID: 156
	public class Expression<TDelegate> : LambdaExpression
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00012914 File Offset: 0x00010B14
		internal Expression(Expression body) : base(body)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001291D File Offset: 0x00010B1D
		internal sealed override Type TypeCore
		{
			get
			{
				return typeof(TDelegate);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00012929 File Offset: 0x00010B29
		internal override Type PublicType
		{
			get
			{
				return typeof(Expression<TDelegate>);
			}
		}

		/// <summary>Compiles the lambda expression described by the expression tree into executable code and produces a delegate that represents the lambda expression.</summary>
		/// <returns>A delegate of type <paramref name="TDelegate" /> that represents the compiled lambda expression described by the <see cref="T:System.Linq.Expressions.Expression`1" />.</returns>
		// Token: 0x060004FC RID: 1276 RVA: 0x00012935 File Offset: 0x00010B35
		public new TDelegate Compile()
		{
			return this.Compile(false);
		}

		/// <summary>Compiles the lambda expression described by the expression tree into interpreted or compiled code and produces a delegate that represents the lambda expression.</summary>
		/// <param name="preferInterpretation">
		///   <see langword="true" /> to indicate that the expression should be compiled to an interpreted form, if it is available; <see langword="false" /> otherwise.</param>
		/// <returns>A delegate that represents the compiled lambda expression described by the <see cref="T:System.Linq.Expressions.Expression`1" />.</returns>
		// Token: 0x060004FD RID: 1277 RVA: 0x0001293E File Offset: 0x00010B3E
		public new TDelegate Compile(bool preferInterpretation)
		{
			return (TDelegate)((object)LambdaCompiler.Compile(this));
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001294B File Offset: 0x00010B4B
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitLambda<TDelegate>(this);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00012954 File Offset: 0x00010B54
		internal override LambdaExpression Accept(StackSpiller spiller)
		{
			return spiller.Rewrite<TDelegate>(this);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00012960 File Offset: 0x00010B60
		internal static Expression<TDelegate> Create(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters)
		{
			if (name != null || tailCall)
			{
				return new FullExpression<TDelegate>(body, name, tailCall, parameters);
			}
			switch (parameters.Count)
			{
			case 0:
				return new Expression0<TDelegate>(body);
			case 1:
				return new Expression1<TDelegate>(body, parameters[0]);
			case 2:
				return new Expression2<TDelegate>(body, parameters[0], parameters[1]);
			case 3:
				return new Expression3<TDelegate>(body, parameters[0], parameters[1], parameters[2]);
			default:
				return new ExpressionN<TDelegate>(body, parameters);
			}
		}
	}
}
