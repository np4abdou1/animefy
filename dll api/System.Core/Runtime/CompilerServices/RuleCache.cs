using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic.Utils;

namespace System.Runtime.CompilerServices
{
	/// <summary>Represents a cache of runtime binding rules.</summary>
	/// <typeparam name="T">The delegate type.</typeparam>
	// Token: 0x0200010C RID: 268
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerStepThrough]
	public class RuleCache<T> where T : class
	{
		// Token: 0x060008EB RID: 2283 RVA: 0x00022B38 File Offset: 0x00020D38
		internal RuleCache()
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00022B56 File Offset: 0x00020D56
		internal T[] GetRules()
		{
			return this._rules;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00022B60 File Offset: 0x00020D60
		internal void MoveRule(T rule, int i)
		{
			object cacheLock = this._cacheLock;
			lock (cacheLock)
			{
				int num = this._rules.Length - i;
				if (num > 8)
				{
					num = 8;
				}
				int num2 = -1;
				int num3 = Math.Min(this._rules.Length, i + num);
				for (int j = i; j < num3; j++)
				{
					if (this._rules[j] == rule)
					{
						num2 = j;
						break;
					}
				}
				if (num2 >= 2)
				{
					T t = this._rules[num2];
					this._rules[num2] = this._rules[num2 - 1];
					this._rules[num2 - 1] = this._rules[num2 - 2];
					this._rules[num2 - 2] = t;
				}
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00022C4C File Offset: 0x00020E4C
		internal void AddRule(T newRule)
		{
			object cacheLock = this._cacheLock;
			lock (cacheLock)
			{
				this._rules = RuleCache<T>.AddOrInsert(this._rules, newRule);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00022C98 File Offset: 0x00020E98
		private static T[] AddOrInsert(T[] rules, T item)
		{
			if (rules.Length < 64)
			{
				return rules.AddLast(item);
			}
			int num = rules.Length + 1;
			T[] array;
			if (num > 128)
			{
				num = 128;
				array = rules;
			}
			else
			{
				array = new T[num];
				Array.Copy(rules, 0, array, 0, 64);
			}
			array[64] = item;
			Array.Copy(rules, 64, array, 65, num - 64 - 1);
			return array;
		}

		// Token: 0x040002A7 RID: 679
		private T[] _rules = Array.Empty<T>();

		// Token: 0x040002A8 RID: 680
		private readonly object _cacheLock = new object();
	}
}
