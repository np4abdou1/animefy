using System;

namespace System.Xml.Schema
{
	// Token: 0x02000282 RID: 642
	internal class Datatype_nonNegativeInteger : Datatype_integer
	{
		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x000769D6 File Offset: 0x00074BD6
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_nonNegativeInteger.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000769DD File Offset: 0x00074BDD
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NonNegativeInteger;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000D79 RID: 3449
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(0m, decimal.MaxValue);
	}
}
