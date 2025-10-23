using System;

namespace System.Xml.Serialization
{
	// Token: 0x02000213 RID: 531
	internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0006E100 File Offset: 0x0006C300
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0006E108 File Offset: 0x0006C308
		public int FlatArrayIndex
		{
			get
			{
				return this._flatArrayIndex;
			}
			set
			{
				this._flatArrayIndex = value;
			}
		}

		// Token: 0x04000C0A RID: 3082
		private int _flatArrayIndex;
	}
}
