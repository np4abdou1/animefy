using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	/// <summary>Contains helper methods called from dynamically generated methods.</summary>
	// Token: 0x020000FE RID: 254
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public static class RuntimeOps
	{
		/// <summary>Gets the value of an item in an expando object.</summary>
		/// <param name="expando">The expando object.</param>
		/// <param name="indexClass">The class of the expando object.</param>
		/// <param name="index">The index of the member.</param>
		/// <param name="name">The name of the member.</param>
		/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
		/// <param name="value">The out parameter containing the value of the member.</param>
		/// <returns>True if the member exists in the expando object, otherwise false.</returns>
		// Token: 0x06000887 RID: 2183 RVA: 0x000213BD File Offset: 0x0001F5BD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value)
		{
			return expando.TryGetValue(indexClass, index, name, ignoreCase, out value);
		}

		/// <summary>Sets the value of an item in an expando object.</summary>
		/// <param name="expando">The expando object.</param>
		/// <param name="indexClass">The class of the expando object.</param>
		/// <param name="index">The index of the member.</param>
		/// <param name="value">The value of the member.</param>
		/// <param name="name">The name of the member.</param>
		/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
		/// <returns>Returns the index for the set member.</returns>
		// Token: 0x06000888 RID: 2184 RVA: 0x000213CC File Offset: 0x0001F5CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase)
		{
			expando.TrySetValue(indexClass, index, value, name, ignoreCase, false);
			return value;
		}

		/// <summary>Deletes the value of an item in an expando object.</summary>
		/// <param name="expando">The expando object.</param>
		/// <param name="indexClass">The class of the expando object.</param>
		/// <param name="index">The index of the member.</param>
		/// <param name="name">The name of the member.</param>
		/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
		/// <returns>true if the item was successfully removed; otherwise, false.</returns>
		// Token: 0x06000889 RID: 2185 RVA: 0x000213DD File Offset: 0x0001F5DD
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase)
		{
			return expando.TryDeleteValue(indexClass, index, name, ignoreCase, ExpandoObject.Uninitialized);
		}

		/// <summary>Checks the version of the Expando object.</summary>
		/// <param name="expando">The Expando object.</param>
		/// <param name="version">The version to check.</param>
		/// <returns>Returns true if the version is equal; otherwise, false.</returns>
		// Token: 0x0600088A RID: 2186 RVA: 0x000213EF File Offset: 0x0001F5EF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static bool ExpandoCheckVersion(ExpandoObject expando, object version)
		{
			return expando.Class == version;
		}

		/// <summary>Promotes an Expando object from one class to a new class.</summary>
		/// <param name="expando">The Expando object.</param>
		/// <param name="oldClass">The old class of the Expando object.</param>
		/// <param name="newClass">The new class of the Expando object.</param>
		// Token: 0x0600088B RID: 2187 RVA: 0x000213FA File Offset: 0x0001F5FA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass)
		{
			expando.PromoteClass(oldClass, newClass);
		}

		/// <summary>Quotes the provided expression tree.</summary>
		/// <param name="expression">The expression to quote.</param>
		/// <param name="hoistedLocals">The hoisted local state provided by the compiler.</param>
		/// <param name="locals">The actual hoisted local values.</param>
		/// <returns>The quoted expression.</returns>
		// Token: 0x0600088C RID: 2188 RVA: 0x00021404 File Offset: 0x0001F604
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Expression Quote(Expression expression, object hoistedLocals, object[] locals)
		{
			return new RuntimeOps.ExpressionQuoter((HoistedLocals)hoistedLocals, locals).Visit(expression);
		}

		/// <summary>Creates an interface that can be used to modify closed over variables at runtime.</summary>
		/// <param name="data">The closure array.</param>
		/// <param name="indexes">An array of indicies into the closure array where variables are found.</param>
		/// <returns>An interface to access variables.</returns>
		// Token: 0x0600088D RID: 2189 RVA: 0x00021418 File Offset: 0x0001F618
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IRuntimeVariables CreateRuntimeVariables(object[] data, long[] indexes)
		{
			return new RuntimeOps.RuntimeVariableList(data, indexes);
		}

		/// <summary>Creates an interface that can be used to modify closed over variables at runtime.</summary>
		/// <returns>An interface to access variables.</returns>
		// Token: 0x0600088E RID: 2190 RVA: 0x00021421 File Offset: 0x0001F621
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IRuntimeVariables CreateRuntimeVariables()
		{
			return new RuntimeOps.EmptyRuntimeVariables();
		}

		// Token: 0x020000FF RID: 255
		private sealed class ExpressionQuoter : ExpressionVisitor
		{
			// Token: 0x0600088F RID: 2191 RVA: 0x00021428 File Offset: 0x0001F628
			internal ExpressionQuoter(HoistedLocals scope, object[] locals)
			{
				this._scope = scope;
				this._locals = locals;
			}

			// Token: 0x06000890 RID: 2192 RVA: 0x0002144C File Offset: 0x0001F64C
			protected internal override Expression VisitLambda<T>(Expression<T> node)
			{
				if (node.ParameterCount > 0)
				{
					HashSet<ParameterExpression> hashSet = new HashSet<ParameterExpression>();
					int i = 0;
					int parameterCount = node.ParameterCount;
					while (i < parameterCount)
					{
						hashSet.Add(node.GetParameter(i));
						i++;
					}
					this._shadowedVars.Push(hashSet);
				}
				Expression expression = this.Visit(node.Body);
				if (node.ParameterCount > 0)
				{
					this._shadowedVars.Pop();
				}
				if (expression == node.Body)
				{
					return node;
				}
				return node.Rewrite(expression, null);
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x000214CC File Offset: 0x0001F6CC
			protected internal override Expression VisitBlock(BlockExpression node)
			{
				if (node.Variables.Count > 0)
				{
					this._shadowedVars.Push(new HashSet<ParameterExpression>(node.Variables));
				}
				Expression[] array = ExpressionVisitorUtils.VisitBlockExpressions(this, node);
				if (node.Variables.Count > 0)
				{
					this._shadowedVars.Pop();
				}
				if (array == null)
				{
					return node;
				}
				return node.Rewrite(node.Variables, array);
			}

			// Token: 0x06000892 RID: 2194 RVA: 0x00021534 File Offset: 0x0001F734
			protected override CatchBlock VisitCatchBlock(CatchBlock node)
			{
				if (node.Variable != null)
				{
					this._shadowedVars.Push(new HashSet<ParameterExpression>
					{
						node.Variable
					});
				}
				Expression expression = this.Visit(node.Body);
				Expression expression2 = this.Visit(node.Filter);
				if (node.Variable != null)
				{
					this._shadowedVars.Pop();
				}
				if (expression == node.Body && expression2 == node.Filter)
				{
					return node;
				}
				return Expression.MakeCatchBlock(node.Test, node.Variable, expression, expression2);
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x000215BC File Offset: 0x0001F7BC
			protected internal override Expression VisitParameter(ParameterExpression node)
			{
				IStrongBox box = this.GetBox(node);
				if (box == null)
				{
					return node;
				}
				return Expression.Field(Expression.Constant(box), "Value");
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x000215E8 File Offset: 0x0001F7E8
			private IStrongBox GetBox(ParameterExpression variable)
			{
				using (Stack<HashSet<ParameterExpression>>.Enumerator enumerator = this._shadowedVars.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.Contains(variable))
						{
							return null;
						}
					}
				}
				HoistedLocals hoistedLocals = this._scope;
				object[] array = this._locals;
				int num;
				while (!hoistedLocals.Indexes.TryGetValue(variable, out num))
				{
					hoistedLocals = hoistedLocals.Parent;
					if (hoistedLocals == null)
					{
						throw ContractUtils.Unreachable;
					}
					array = HoistedLocals.GetParent(array);
				}
				return (IStrongBox)array[num];
			}

			// Token: 0x0400028A RID: 650
			private readonly HoistedLocals _scope;

			// Token: 0x0400028B RID: 651
			private readonly object[] _locals;

			// Token: 0x0400028C RID: 652
			private readonly Stack<HashSet<ParameterExpression>> _shadowedVars = new Stack<HashSet<ParameterExpression>>();
		}

		// Token: 0x02000100 RID: 256
		private sealed class EmptyRuntimeVariables : IRuntimeVariables
		{
		}

		// Token: 0x02000101 RID: 257
		[DefaultMember("Item")]
		private sealed class RuntimeVariableList : IRuntimeVariables
		{
			// Token: 0x06000896 RID: 2198 RVA: 0x00021684 File Offset: 0x0001F884
			internal RuntimeVariableList(object[] data, long[] indexes)
			{
				this._data = data;
				this._indexes = indexes;
			}

			// Token: 0x0400028D RID: 653
			private readonly object[] _data;

			// Token: 0x0400028E RID: 654
			private readonly long[] _indexes;
		}
	}
}
