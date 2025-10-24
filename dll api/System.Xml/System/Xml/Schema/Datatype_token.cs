using System;

namespace System.Xml.Schema
{
	// Token: 0x02000271 RID: 625
	internal class Datatype_token : Datatype_normalizedString
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00076438 File Offset: 0x00074638
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Token;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000466F0 File Offset: 0x000448F0
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Collapse;
			}
		}
	}
}
