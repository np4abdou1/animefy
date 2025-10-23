using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000ED RID: 237
	[NullableContext(1)]
	[Nullable(0)]
	internal readonly struct StringReference
	{
		// Token: 0x170000E1 RID: 225
		public char this[int i]
		{
			get
			{
				return this._chars[i];
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000240AB File Offset: 0x000222AB
		public char[] Chars
		{
			get
			{
				return this._chars;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000240B3 File Offset: 0x000222B3
		public int StartIndex
		{
			get
			{
				return this._startIndex;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000240BB File Offset: 0x000222BB
		public int Length
		{
			get
			{
				return this._length;
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000240C3 File Offset: 0x000222C3
		public StringReference(char[] chars, int startIndex, int length)
		{
			this._chars = chars;
			this._startIndex = startIndex;
			this._length = length;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000240DA File Offset: 0x000222DA
		public override string ToString()
		{
			return new string(this._chars, this._startIndex, this._length);
		}

		// Token: 0x040004C5 RID: 1221
		private readonly char[] _chars;

		// Token: 0x040004C6 RID: 1222
		private readonly int _startIndex;

		// Token: 0x040004C7 RID: 1223
		private readonly int _length;
	}
}
