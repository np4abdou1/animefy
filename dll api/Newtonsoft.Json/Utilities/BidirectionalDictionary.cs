using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	[Nullable(0)]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x0001AC62 File Offset: 0x00018E62
		public BidirectionalDictionary() : this(EqualityComparer<TFirst>.Default, EqualityComparer<TSecond>.Default)
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001AC74 File Offset: 0x00018E74
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer) : this(firstEqualityComparer, secondEqualityComparer, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001AC88 File Offset: 0x00018E88
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
			this._firstToSecond = new Dictionary<TFirst, TSecond>(firstEqualityComparer);
			this._secondToFirst = new Dictionary<TSecond, TFirst>(secondEqualityComparer);
			this._duplicateFirstErrorMessage = duplicateFirstErrorMessage;
			this._duplicateSecondErrorMessage = duplicateSecondErrorMessage;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		public void Set(TFirst first, TSecond second)
		{
			TSecond tsecond;
			if (this._firstToSecond.TryGetValue(first, out tsecond) && !tsecond.Equals(second))
			{
				throw new ArgumentException(this._duplicateFirstErrorMessage.FormatWith(CultureInfo.InvariantCulture, first));
			}
			TFirst tfirst;
			if (this._secondToFirst.TryGetValue(second, out tfirst) && !tfirst.Equals(first))
			{
				throw new ArgumentException(this._duplicateSecondErrorMessage.FormatWith(CultureInfo.InvariantCulture, second));
			}
			this._firstToSecond.Add(first, second);
			this._secondToFirst.Add(second, first);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001AD61 File Offset: 0x00018F61
		public bool TryGetByFirst(TFirst first, [Nullable(2)] [NotNullWhen(true)] out TSecond second)
		{
			return this._firstToSecond.TryGetValue(first, out second);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001AD70 File Offset: 0x00018F70
		public bool TryGetBySecond(TSecond second, [Nullable(2)] [NotNullWhen(true)] out TFirst first)
		{
			return this._secondToFirst.TryGetValue(second, out first);
		}

		// Token: 0x04000377 RID: 887
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x04000378 RID: 888
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x04000379 RID: 889
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x0400037A RID: 890
		private readonly string _duplicateSecondErrorMessage;
	}
}
