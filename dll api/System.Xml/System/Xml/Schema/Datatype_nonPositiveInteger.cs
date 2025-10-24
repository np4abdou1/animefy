using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027C RID: 636
	internal class Datatype_nonPositiveInteger : Datatype_integer
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00076654 File Offset: 0x00074854
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_nonPositiveInteger.numeric10FacetsChecker;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0007665B File Offset: 0x0007485B
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NonPositiveInteger;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000D6B RID: 3435
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(decimal.MinValue, 0m);
	}
}
