using System;

namespace System.Collections.Generic
{
	// Token: 0x0200064B RID: 1611
	[Serializable]
	internal sealed class InternalStringComparer : EqualityComparer<string>
	{
		// Token: 0x060030D3 RID: 12499 RVA: 0x000C4AD4 File Offset: 0x000C2CD4
		public override int GetHashCode(string obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000C4AE1 File Offset: 0x000C2CE1
		public override bool Equals(string x, string y)
		{
			if (x == null)
			{
				return y == null;
			}
			return x == y || x.Equals(y);
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000C4AF8 File Offset: 0x000C2CF8
		internal override int IndexOf(string[] array, string value, int startIndex, int count)
		{
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (Array.UnsafeLoad<string>(array, i) == value)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
