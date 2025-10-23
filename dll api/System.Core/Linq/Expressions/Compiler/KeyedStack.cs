using System;
using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E2 RID: 226
	internal sealed class KeyedStack<TKey, TValue> where TValue : class
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x0001796C File Offset: 0x00015B6C
		internal void Push(TKey key, TValue value)
		{
			Stack<TValue> stack;
			if (!this._data.TryGetValue(key, out stack))
			{
				this._data.Add(key, stack = new Stack<TValue>());
			}
			stack.Push(value);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000179A4 File Offset: 0x00015BA4
		internal TValue TryPop(TKey key)
		{
			Stack<TValue> stack;
			TValue result;
			if (!this._data.TryGetValue(key, out stack) || !stack.TryPop(out result))
			{
				return default(TValue);
			}
			return result;
		}

		// Token: 0x04000217 RID: 535
		private readonly Dictionary<TKey, Stack<TValue>> _data = new Dictionary<TKey, Stack<TValue>>();
	}
}
