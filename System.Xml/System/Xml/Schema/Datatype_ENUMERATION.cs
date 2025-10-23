using System;

namespace System.Xml.Schema
{
	// Token: 0x0200028B RID: 651
	internal class Datatype_ENUMERATION : Datatype_NMTOKEN
	{
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00047A36 File Offset: 0x00045C36
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.ENUMERATION;
			}
		}
	}
}
