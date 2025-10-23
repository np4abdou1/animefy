using System;

namespace System.Xml.Schema
{
	// Token: 0x0200026F RID: 623
	internal class Datatype_normalizedString : Datatype_string
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0007642C File Offset: 0x0007462C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NormalizedString;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			get
			{
				return XmlSchemaWhiteSpace.Replace;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}
	}
}
