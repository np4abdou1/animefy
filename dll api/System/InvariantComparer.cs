using System;
using System.Collections;
using System.Globalization;

namespace System
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	internal class InvariantComparer : IComparer
	{
		// Token: 0x060002ED RID: 749 RVA: 0x0000C00D File Offset: 0x0000A20D
		internal InvariantComparer()
		{
			this.m_compareInfo = CultureInfo.InvariantCulture.CompareInfo;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000C028 File Offset: 0x0000A228
		public int Compare(object a, object b)
		{
			string text = a as string;
			string text2 = b as string;
			if (text != null && text2 != null)
			{
				return this.m_compareInfo.Compare(text, text2);
			}
			return Comparer.Default.Compare(a, b);
		}

		// Token: 0x04000192 RID: 402
		private CompareInfo m_compareInfo;

		// Token: 0x04000193 RID: 403
		internal static readonly InvariantComparer Default = new InvariantComparer();
	}
}
