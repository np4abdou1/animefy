using System;
using System.Globalization;

namespace System
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public class OrdinalComparer : StringComparer
	{
		// Token: 0x0600093D RID: 2365 RVA: 0x00029591 File Offset: 0x00027791
		internal OrdinalComparer(bool ignoreCase)
		{
			this._ignoreCase = ignoreCase;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000295A0 File Offset: 0x000277A0
		public override int Compare(string x, string y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			if (this._ignoreCase)
			{
				return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
			}
			return string.CompareOrdinal(x, y);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000295CA File Offset: 0x000277CA
		public override bool Equals(string x, string y)
		{
			if (x == y)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (this._ignoreCase)
			{
				return x.Length == y.Length && string.Compare(x, y, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return x.Equals(y);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00029605 File Offset: 0x00027805
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.obj);
			}
			if (this._ignoreCase)
			{
				return CompareInfo.GetIgnoreCaseHash(obj);
			}
			return obj.GetHashCode();
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00029628 File Offset: 0x00027828
		public override bool Equals(object obj)
		{
			OrdinalComparer ordinalComparer = obj as OrdinalComparer;
			return ordinalComparer != null && this._ignoreCase == ordinalComparer._ignoreCase;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00029650 File Offset: 0x00027850
		public override int GetHashCode()
		{
			int hashCode = "OrdinalComparer".GetHashCode();
			if (!this._ignoreCase)
			{
				return hashCode;
			}
			return ~hashCode;
		}

		// Token: 0x04000371 RID: 881
		private readonly bool _ignoreCase;
	}
}
