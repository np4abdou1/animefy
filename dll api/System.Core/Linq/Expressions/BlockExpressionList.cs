using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;

namespace System.Linq.Expressions
{
	// Token: 0x02000079 RID: 121
	internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable
	{
		// Token: 0x06000351 RID: 849 RVA: 0x0000FA7E File Offset: 0x0000DC7E
		internal BlockExpressionList(BlockExpression provider, Expression arg0)
		{
			this._block = provider;
			this._arg0 = arg0;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000FA94 File Offset: 0x0000DC94
		public int IndexOf(Expression item)
		{
			if (this._arg0 == item)
			{
				return 0;
			}
			for (int i = 1; i < this._block.ExpressionCount; i++)
			{
				if (this._block.GetExpression(i) == item)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Insert(int index, Expression item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void RemoveAt(int index)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x17000072 RID: 114
		public Expression this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this._arg0;
				}
				return this._block.GetExpression(index);
			}
			[ExcludeFromCodeCoverage]
			set
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Add(Expression item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public void Clear()
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000FAEC File Offset: 0x0000DCEC
		public bool Contains(Expression item)
		{
			return this.IndexOf(item) != -1;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		public void CopyTo(Expression[] array, int index)
		{
			ContractUtils.RequiresNotNull(array, "array");
			if (index < 0)
			{
				throw Error.ArgumentOutOfRange("index");
			}
			int expressionCount = this._block.ExpressionCount;
			if (index + expressionCount > array.Length)
			{
				throw new ArgumentException();
			}
			array[index++] = this._arg0;
			for (int i = 1; i < expressionCount; i++)
			{
				array[index++] = this._block.GetExpression(i);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0000FB6B File Offset: 0x0000DD6B
		public int Count
		{
			get
			{
				return this._block.ExpressionCount;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public bool IsReadOnly
		{
			get
			{
				throw ContractUtils.Unreachable;
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000F672 File Offset: 0x0000D872
		[ExcludeFromCodeCoverage]
		public bool Remove(Expression item)
		{
			throw ContractUtils.Unreachable;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000FB78 File Offset: 0x0000DD78
		public IEnumerator<Expression> GetEnumerator()
		{
			yield return this._arg0;
			int num;
			for (int i = 1; i < this._block.ExpressionCount; i = num + 1)
			{
				yield return this._block.GetExpression(i);
				num = i;
			}
			yield break;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000FB87 File Offset: 0x0000DD87
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040000E1 RID: 225
		private readonly BlockExpression _block;

		// Token: 0x040000E2 RID: 226
		private readonly Expression _arg0;
	}
}
