using System;

namespace System.Xml.Schema
{
	// Token: 0x02000270 RID: 624
	internal class Datatype_normalizedStringV1Compat : Datatype_string
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0007642C File Offset: 0x0007462C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NormalizedString;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}
	}
}
