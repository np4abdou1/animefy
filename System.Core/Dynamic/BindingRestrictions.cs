using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	/// <summary>Represents a set of binding restrictions on the <see cref="T:System.Dynamic.DynamicMetaObject" /> under which the dynamic binding is valid.</summary>
	// Token: 0x02000111 RID: 273
	[DebuggerTypeProxy(typeof(BindingRestrictions.BindingRestrictionsProxy))]
	[DebuggerDisplay("{DebugView}")]
	public abstract class BindingRestrictions
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x000072DD File Offset: 0x000054DD
		private BindingRestrictions()
		{
		}

		// Token: 0x060008F7 RID: 2295
		internal abstract Expression GetExpression();

		/// <summary>Merges the set of binding restrictions with the current binding restrictions.</summary>
		/// <param name="restrictions">The set of restrictions with which to merge the current binding restrictions.</param>
		/// <returns>The new set of binding restrictions.</returns>
		// Token: 0x060008F8 RID: 2296 RVA: 0x00022D6E File Offset: 0x00020F6E
		public BindingRestrictions Merge(BindingRestrictions restrictions)
		{
			ContractUtils.RequiresNotNull(restrictions, "restrictions");
			if (this == BindingRestrictions.Empty)
			{
				return restrictions;
			}
			if (restrictions == BindingRestrictions.Empty)
			{
				return this;
			}
			return new BindingRestrictions.MergedRestriction(this, restrictions);
		}

		/// <summary>Creates the binding restriction that check the expression for runtime type identity.</summary>
		/// <param name="expression">The expression to test.</param>
		/// <param name="type">The exact type to test.</param>
		/// <returns>The new binding restrictions.</returns>
		// Token: 0x060008F9 RID: 2297 RVA: 0x00022D96 File Offset: 0x00020F96
		public static BindingRestrictions GetTypeRestriction(Expression expression, Type type)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			ContractUtils.RequiresNotNull(type, "type");
			return new BindingRestrictions.TypeRestriction(expression, type);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00022DB5 File Offset: 0x00020FB5
		internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			if (obj.Value == null && obj.HasValue)
			{
				return BindingRestrictions.GetInstanceRestriction(obj.Expression, null);
			}
			return BindingRestrictions.GetTypeRestriction(obj.Expression, obj.LimitType);
		}

		/// <summary>Creates the binding restriction that checks the expression for object instance identity.</summary>
		/// <param name="expression">The expression to test.</param>
		/// <param name="instance">The exact object instance to test.</param>
		/// <returns>The new binding restrictions.</returns>
		// Token: 0x060008FB RID: 2299 RVA: 0x00022DE5 File Offset: 0x00020FE5
		public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance)
		{
			ContractUtils.RequiresNotNull(expression, "expression");
			return new BindingRestrictions.InstanceRestriction(expression, instance);
		}

		/// <summary>Creates the <see cref="T:System.Linq.Expressions.Expression" /> representing the binding restrictions.</summary>
		/// <returns>The expression tree representing the restrictions.</returns>
		// Token: 0x060008FC RID: 2300 RVA: 0x00022DF9 File Offset: 0x00020FF9
		public Expression ToExpression()
		{
			return this.GetExpression();
		}

		/// <summary>Represents an empty set of binding restrictions. This field is read only.</summary>
		// Token: 0x040002AB RID: 683
		public static readonly BindingRestrictions Empty = new BindingRestrictions.CustomRestriction(Utils.Constant(true));

		// Token: 0x02000112 RID: 274
		private sealed class TestBuilder
		{
			// Token: 0x060008FE RID: 2302 RVA: 0x00022E13 File Offset: 0x00021013
			internal void Append(BindingRestrictions restrictions)
			{
				if (this._unique.Add(restrictions))
				{
					this.Push(restrictions.GetExpression(), 0);
				}
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00022E30 File Offset: 0x00021030
			internal Expression ToExpression()
			{
				Expression expression = this._tests.Pop().Node;
				while (this._tests.Count > 0)
				{
					expression = Expression.AndAlso(this._tests.Pop().Node, expression);
				}
				return expression;
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x00022E78 File Offset: 0x00021078
			private void Push(Expression node, int depth)
			{
				while (this._tests.Count > 0 && this._tests.Peek().Depth == depth)
				{
					node = Expression.AndAlso(this._tests.Pop().Node, node);
					depth++;
				}
				this._tests.Push(new BindingRestrictions.TestBuilder.AndNode
				{
					Node = node,
					Depth = depth
				});
			}

			// Token: 0x040002AC RID: 684
			private readonly HashSet<BindingRestrictions> _unique = new HashSet<BindingRestrictions>();

			// Token: 0x040002AD RID: 685
			private readonly Stack<BindingRestrictions.TestBuilder.AndNode> _tests = new Stack<BindingRestrictions.TestBuilder.AndNode>();

			// Token: 0x02000113 RID: 275
			private struct AndNode
			{
				// Token: 0x040002AE RID: 686
				internal int Depth;

				// Token: 0x040002AF RID: 687
				internal Expression Node;
			}
		}

		// Token: 0x02000114 RID: 276
		private sealed class MergedRestriction : BindingRestrictions
		{
			// Token: 0x06000902 RID: 2306 RVA: 0x00022F07 File Offset: 0x00021107
			internal MergedRestriction(BindingRestrictions left, BindingRestrictions right)
			{
				this.Left = left;
				this.Right = right;
			}

			// Token: 0x06000903 RID: 2307 RVA: 0x00022F20 File Offset: 0x00021120
			internal override Expression GetExpression()
			{
				BindingRestrictions.TestBuilder testBuilder = new BindingRestrictions.TestBuilder();
				Stack<BindingRestrictions> stack = new Stack<BindingRestrictions>();
				BindingRestrictions bindingRestrictions = this;
				for (;;)
				{
					BindingRestrictions.MergedRestriction mergedRestriction = bindingRestrictions as BindingRestrictions.MergedRestriction;
					if (mergedRestriction != null)
					{
						stack.Push(mergedRestriction.Right);
						bindingRestrictions = mergedRestriction.Left;
					}
					else
					{
						testBuilder.Append(bindingRestrictions);
						if (stack.Count == 0)
						{
							break;
						}
						bindingRestrictions = stack.Pop();
					}
				}
				return testBuilder.ToExpression();
			}

			// Token: 0x040002B0 RID: 688
			internal readonly BindingRestrictions Left;

			// Token: 0x040002B1 RID: 689
			internal readonly BindingRestrictions Right;
		}

		// Token: 0x02000115 RID: 277
		private sealed class CustomRestriction : BindingRestrictions
		{
			// Token: 0x06000904 RID: 2308 RVA: 0x00022F78 File Offset: 0x00021178
			internal CustomRestriction(Expression expression)
			{
				this._expression = expression;
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x00022F87 File Offset: 0x00021187
			public override bool Equals(object obj)
			{
				BindingRestrictions.CustomRestriction customRestriction = obj as BindingRestrictions.CustomRestriction;
				return ((customRestriction != null) ? customRestriction._expression : null) == this._expression;
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00022FA3 File Offset: 0x000211A3
			public override int GetHashCode()
			{
				return 613566756 ^ this._expression.GetHashCode();
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00022FB6 File Offset: 0x000211B6
			internal override Expression GetExpression()
			{
				return this._expression;
			}

			// Token: 0x040002B2 RID: 690
			private readonly Expression _expression;
		}

		// Token: 0x02000116 RID: 278
		private sealed class TypeRestriction : BindingRestrictions
		{
			// Token: 0x06000908 RID: 2312 RVA: 0x00022FBE File Offset: 0x000211BE
			internal TypeRestriction(Expression parameter, Type type)
			{
				this._expression = parameter;
				this._type = type;
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x00022FD4 File Offset: 0x000211D4
			public override bool Equals(object obj)
			{
				BindingRestrictions.TypeRestriction typeRestriction = obj as BindingRestrictions.TypeRestriction;
				return ((typeRestriction != null) ? typeRestriction._expression : null) == this._expression && TypeUtils.AreEquivalent(typeRestriction._type, this._type);
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x0002300F File Offset: 0x0002120F
			public override int GetHashCode()
			{
				return 1227133513 ^ this._expression.GetHashCode() ^ this._type.GetHashCode();
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x0002302E File Offset: 0x0002122E
			internal override Expression GetExpression()
			{
				return Expression.TypeEqual(this._expression, this._type);
			}

			// Token: 0x040002B3 RID: 691
			private readonly Expression _expression;

			// Token: 0x040002B4 RID: 692
			private readonly Type _type;
		}

		// Token: 0x02000117 RID: 279
		private sealed class InstanceRestriction : BindingRestrictions
		{
			// Token: 0x0600090C RID: 2316 RVA: 0x00023041 File Offset: 0x00021241
			internal InstanceRestriction(Expression parameter, object instance)
			{
				this._expression = parameter;
				this._instance = instance;
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x00023058 File Offset: 0x00021258
			public override bool Equals(object obj)
			{
				BindingRestrictions.InstanceRestriction instanceRestriction = obj as BindingRestrictions.InstanceRestriction;
				return ((instanceRestriction != null) ? instanceRestriction._expression : null) == this._expression && instanceRestriction._instance == this._instance;
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00023090 File Offset: 0x00021290
			public override int GetHashCode()
			{
				return -1840700270 ^ RuntimeHelpers.GetHashCode(this._instance) ^ this._expression.GetHashCode();
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x000230B0 File Offset: 0x000212B0
			internal override Expression GetExpression()
			{
				if (this._instance == null)
				{
					return Expression.Equal(Expression.Convert(this._expression, typeof(object)), Utils.Null);
				}
				ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
				return Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Assign(parameterExpression, Expression.Constant(this._instance, typeof(object))),
					Expression.AndAlso(Expression.NotEqual(parameterExpression, Utils.Null), Expression.Equal(Expression.Convert(this._expression, typeof(object)), parameterExpression))
				}));
			}

			// Token: 0x040002B5 RID: 693
			private readonly Expression _expression;

			// Token: 0x040002B6 RID: 694
			private readonly object _instance;
		}

		// Token: 0x02000118 RID: 280
		private sealed class BindingRestrictionsProxy
		{
		}
	}
}
