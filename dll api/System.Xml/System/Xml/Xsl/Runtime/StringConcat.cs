using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Xml.Xsl.Runtime
{
	// Token: 0x0200021F RID: 543
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct StringConcat
	{
		// Token: 0x060011F0 RID: 4592 RVA: 0x0006F43E File Offset: 0x0006D63E
		public void Clear()
		{
			this.idxStr = 0;
			this.delimiter = null;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0006F44E File Offset: 0x0006D64E
		internal int Count
		{
			get
			{
				return this.idxStr;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0006F458 File Offset: 0x0006D658
		public string GetResult()
		{
			switch (this.idxStr)
			{
			case 0:
				return string.Empty;
			case 1:
				return this.s1;
			case 2:
				return this.s1 + this.s2;
			case 3:
				return this.s1 + this.s2 + this.s3;
			case 4:
				return this.s1 + this.s2 + this.s3 + this.s4;
			default:
				return string.Concat(this.strList.ToArray());
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0006F4F0 File Offset: 0x0006D6F0
		internal void ConcatNoDelimiter(string s)
		{
			switch (this.idxStr)
			{
			case 0:
				this.s1 = s;
				goto IL_A8;
			case 1:
				this.s2 = s;
				goto IL_A8;
			case 2:
				this.s3 = s;
				goto IL_A8;
			case 3:
				this.s4 = s;
				goto IL_A8;
			case 4:
			{
				int capacity = (this.strList == null) ? 8 : this.strList.Count;
				List<string> list = this.strList = new List<string>(capacity);
				list.Add(this.s1);
				list.Add(this.s2);
				list.Add(this.s3);
				list.Add(this.s4);
				break;
			}
			}
			this.strList.Add(s);
			IL_A8:
			this.idxStr++;
		}

		// Token: 0x04000C32 RID: 3122
		private string s1;

		// Token: 0x04000C33 RID: 3123
		private string s2;

		// Token: 0x04000C34 RID: 3124
		private string s3;

		// Token: 0x04000C35 RID: 3125
		private string s4;

		// Token: 0x04000C36 RID: 3126
		private string delimiter;

		// Token: 0x04000C37 RID: 3127
		private List<string> strList;

		// Token: 0x04000C38 RID: 3128
		private int idxStr;
	}
}
