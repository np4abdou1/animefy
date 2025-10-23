using System;
using System.Globalization;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000AE RID: 174
	internal sealed class RegexFC
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x0001DB97 File Offset: 0x0001BD97
		public RegexFC(bool nullable)
		{
			this._cc = new RegexCharClass();
			this._nullable = nullable;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001DBB4 File Offset: 0x0001BDB4
		public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
		{
			this._cc = new RegexCharClass();
			if (not)
			{
				if (ch > '\0')
				{
					this._cc.AddRange('\0', ch - '\u0001');
				}
				if (ch < '￿')
				{
					this._cc.AddRange(ch + '\u0001', char.MaxValue);
				}
			}
			else
			{
				this._cc.AddRange(ch, ch);
			}
			this.CaseInsensitive = caseInsensitive;
			this._nullable = nullable;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001DC23 File Offset: 0x0001BE23
		public RegexFC(string charClass, bool nullable, bool caseInsensitive)
		{
			this._cc = RegexCharClass.Parse(charClass);
			this._nullable = nullable;
			this.CaseInsensitive = caseInsensitive;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001DC48 File Offset: 0x0001BE48
		public bool AddFC(RegexFC fc, bool concatenate)
		{
			if (!this._cc.CanMerge || !fc._cc.CanMerge)
			{
				return false;
			}
			if (concatenate)
			{
				if (!this._nullable)
				{
					return true;
				}
				if (!fc._nullable)
				{
					this._nullable = false;
				}
			}
			else if (fc._nullable)
			{
				this._nullable = true;
			}
			this.CaseInsensitive |= fc.CaseInsensitive;
			this._cc.AddCharClass(fc._cc);
			return true;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001DCC3 File Offset: 0x0001BEC3
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0001DCCB File Offset: 0x0001BECB
		public bool CaseInsensitive { get; private set; }

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001DCD4 File Offset: 0x0001BED4
		public string GetFirstChars(CultureInfo culture)
		{
			if (this.CaseInsensitive)
			{
				this._cc.AddLowercase(culture);
			}
			return this._cc.ToStringClass();
		}

		// Token: 0x04000342 RID: 834
		private RegexCharClass _cc;

		// Token: 0x04000343 RID: 835
		public bool _nullable;
	}
}
