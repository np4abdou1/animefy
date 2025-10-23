using System;

namespace System.Xml.Serialization
{
	// Token: 0x02000214 RID: 532
	internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0006E111 File Offset: 0x0006C311
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0006E119 File Offset: 0x0006C319
		public ListMap ListMap
		{
			get
			{
				return this._listMap;
			}
			set
			{
				this._listMap = value;
			}
		}

		// Token: 0x04000C0B RID: 3083
		private ListMap _listMap;
	}
}
