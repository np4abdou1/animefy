using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E0 RID: 224
	internal sealed class HoistedLocals
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00016518 File Offset: 0x00014718
		internal HoistedLocals(HoistedLocals parent, ReadOnlyCollection<ParameterExpression> vars)
		{
			if (parent != null)
			{
				vars = vars.AddFirst(parent.SelfVariable);
			}
			Dictionary<Expression, int> dictionary = new Dictionary<Expression, int>(vars.Count);
			for (int i = 0; i < vars.Count; i++)
			{
				dictionary.Add(vars[i], i);
			}
			this.SelfVariable = Expression.Variable(typeof(object[]), null);
			this.Parent = parent;
			this.Variables = vars;
			this.Indexes = new ReadOnlyDictionary<Expression, int>(dictionary);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00016597 File Offset: 0x00014797
		internal ParameterExpression ParentVariable
		{
			get
			{
				HoistedLocals parent = this.Parent;
				if (parent == null)
				{
					return null;
				}
				return parent.SelfVariable;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000165AA File Offset: 0x000147AA
		internal static object[] GetParent(object[] locals)
		{
			return ((StrongBox<object[]>)locals[0]).Value;
		}

		// Token: 0x04000213 RID: 531
		internal readonly HoistedLocals Parent;

		// Token: 0x04000214 RID: 532
		internal readonly ReadOnlyDictionary<Expression, int> Indexes;

		// Token: 0x04000215 RID: 533
		internal readonly ReadOnlyCollection<ParameterExpression> Variables;

		// Token: 0x04000216 RID: 534
		internal readonly ParameterExpression SelfVariable;
	}
}
