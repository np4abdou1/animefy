using System;
using System.Collections;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x0200031F RID: 799
	internal class XmlSchemaSubstitutionGroup : XmlSchemaObject
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0009ACC4 File Offset: 0x00098EC4
		[XmlIgnore]
		internal ArrayList Members
		{
			get
			{
				return this.membersList;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0009ACCC File Offset: 0x00098ECC
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0009ACD4 File Offset: 0x00098ED4
		[XmlIgnore]
		internal XmlQualifiedName Examplar
		{
			get
			{
				return this.examplar;
			}
			set
			{
				this.examplar = value;
			}
		}

		// Token: 0x04001132 RID: 4402
		private ArrayList membersList = new ArrayList();

		// Token: 0x04001133 RID: 4403
		private XmlQualifiedName examplar = XmlQualifiedName.Empty;
	}
}
