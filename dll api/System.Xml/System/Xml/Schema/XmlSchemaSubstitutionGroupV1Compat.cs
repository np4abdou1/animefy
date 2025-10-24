using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	// Token: 0x02000320 RID: 800
	internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0009ACFB File Offset: 0x00098EFB
		[XmlIgnore]
		internal XmlSchemaChoice Choice
		{
			get
			{
				return this.choice;
			}
		}

		// Token: 0x04001134 RID: 4404
		private XmlSchemaChoice choice = new XmlSchemaChoice();
	}
}
