using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;

namespace System.Linq.Expressions
{
	/// <summary>Describes a lambda expression. This captures a block of code that is similar to a .NET method body.</summary>
	// Token: 0x0200009B RID: 155
	[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x000128A5 File Offset: 0x00010AA5
		internal LambdaExpression(Expression body)
		{
			this._body = body;
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.LambdaExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000128B4 File Offset: 0x00010AB4
		public sealed override Type Type
		{
			get
			{
				return this.TypeCore;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004E7 RID: 1255
		internal abstract Type TypeCore { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004E8 RID: 1256
		internal abstract Type PublicType { get; }

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000128BC File Offset: 0x00010ABC
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Lambda;
			}
		}

		/// <summary>Gets the parameters of the lambda expression.</summary>
		/// <returns>A <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> of <see cref="T:System.Linq.Expressions.ParameterExpression" /> objects that represent the parameters of the lambda expression.</returns>
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000128C0 File Offset: 0x00010AC0
		public ReadOnlyCollection<ParameterExpression> Parameters
		{
			get
			{
				return this.GetOrMakeParameters();
			}
		}

		/// <summary>Gets the name of the lambda expression.</summary>
		/// <returns>The name of the lambda expression.</returns>
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000128C8 File Offset: 0x00010AC8
		public string Name
		{
			get
			{
				return this.NameCore;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00008E73 File Offset: 0x00007073
		internal virtual string NameCore
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the body of the lambda expression.</summary>
		/// <returns>An <see cref="T:System.Linq.Expressions.Expression" /> that represents the body of the lambda expression.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000128D0 File Offset: 0x00010AD0
		public Expression Body
		{
			get
			{
				return this._body;
			}
		}

		/// <summary>Gets the return type of the lambda expression.</summary>
		/// <returns>The <see cref="T:System.Type" /> object representing the type of the lambda expression.</returns>
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000128D8 File Offset: 0x00010AD8
		public Type ReturnType
		{
			get
			{
				return this.Type.GetInvokeMethod().ReturnType;
			}
		}

		/// <summary>Gets the value that indicates if the lambda expression will be compiled with the tail call optimization.</summary>
		/// <returns>True if the lambda expression will be compiled with the tail call optimization, otherwise false.</returns>
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000128EA File Offset: 0x00010AEA
		public bool TailCall
		{
			get
			{
				return this.TailCallCore;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00008049 File Offset: 0x00006249
		internal virtual bool TailCallCore
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeParameters()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000128F2 File Offset: 0x00010AF2
		[ExcludeFromCodeCoverage]
		ParameterExpression IParameterProvider.GetParameter(int index)
		{
			return this.GetParameter(index);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000128FB File Offset: 0x00010AFB
		[ExcludeFromCodeCoverage]
		int IParameterProvider.ParameterCount
		{
			get
			{
				return this.ParameterCount;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		/// <summary>Produces a delegate that represents the lambda expression.</summary>
		/// <returns>A <see cref="T:System.Delegate" /> that contains the compiled version of the lambda expression.</returns>
		// Token: 0x060004F6 RID: 1270 RVA: 0x00012903 File Offset: 0x00010B03
		public Delegate Compile()
		{
			return this.Compile(false);
		}

		/// <summary>Produces an interpreted or compiled delegate that represents the lambda expression. </summary>
		/// <param name="preferInterpretation">
		///   <see langword="true" /> to indicate that the expression should be compiled to an interpreted form, if it's available; otherwise, <see langword="false" />.</param>
		/// <returns>A delegate that represents the compiled lambda expression described by the <see cref="T:System.Linq.Expressions.LambdaExpression" /> object.</returns>
		// Token: 0x060004F7 RID: 1271 RVA: 0x0001290C File Offset: 0x00010B0C
		public Delegate Compile(bool preferInterpretation)
		{
			return LambdaCompiler.Compile(this);
		}

		// Token: 0x060004F8 RID: 1272
		internal abstract LambdaExpression Accept(StackSpiller spiller);

		// Token: 0x04000173 RID: 371
		private readonly Expression _body;
	}
}
