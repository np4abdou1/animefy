using System;

namespace System.Xml.Schema
{
	// Token: 0x02000272 RID: 626
	internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00076438 File Offset: 0x00074638
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Token;
			}
		}
	}
}
