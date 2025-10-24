using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace System.Linq.Expressions
{
	/// <summary>Represents indexing a property or array.</summary>
	// Token: 0x02000090 RID: 144
	[DebuggerTypeProxy(typeof(Expression.IndexExpressionProxy))]
	public sealed class IndexExpression : Expression, IArgumentProvider
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x000123B3 File Offset: 0x000105B3
		internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
		{
			indexer == null;
			this.Object = instance;
			this.Indexer = indexer;
			this._arguments = arguments;
		}

		/// <summary>Returns the node type of this <see cref="T:System.Linq.Expressions.Expression" />.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.ExpressionType" /> that represents this expression.</returns>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000123D8 File Offset: 0x000105D8
		public sealed override ExpressionType NodeType
		{
			get
			{
				return ExpressionType.Index;
			}
		}

		/// <summary>Gets the static type of the expression that this <see cref="T:System.Linq.Expressions.Expression" /> represents.</summary>
		/// <returns>The <see cref="P:System.Linq.Expressions.IndexExpression.Type" /> that represents the static type of the expression.</returns>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000123DC File Offset: 0x000105DC
		public sealed override Type Type
		{
			get
			{
				if (this.Indexer != null)
				{
					return this.Indexer.PropertyType;
				}
				return this.Object.Type.GetElementType();
			}
		}

		/// <summary>An object to index.</summary>
		/// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> representing the object to index.</returns>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00012408 File Offset: 0x00010608
		public Expression Object { get; }

		/// <summary>Gets the <see cref="T:System.Reflection.PropertyInfo" /> for the property if the expression represents an indexed property, returns null otherwise.</summary>
		/// <returns>The <see cref="T:System.Reflection.PropertyInfo" /> for the property if the expression represents an indexed property, otherwise null.</returns>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00012410 File Offset: 0x00010610
		public PropertyInfo Indexer { get; }

		// Token: 0x060004B1 RID: 1201 RVA: 0x00012418 File Offset: 0x00010618
		public Expression GetArgument(int index)
		{
			return this._arguments[index];
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00012426 File Offset: 0x00010626
		public int ArgumentCount
		{
			get
			{
				return this._arguments.Count;
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00012433 File Offset: 0x00010633
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return visitor.VisitIndex(this);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001243C File Offset: 0x0001063C
		internal Expression Rewrite(Expression instance, Expression[] arguments)
		{
			return Expression.MakeIndex(instance, this.Indexer, arguments ?? this._arguments);
		}

		// Token: 0x0400015A RID: 346
		private IReadOnlyList<Expression> _arguments;
	}
}
