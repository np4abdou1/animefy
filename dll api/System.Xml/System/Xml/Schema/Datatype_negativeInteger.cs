using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027D RID: 637
	internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
	{
		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00076682 File Offset: 0x00074882
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_negativeInteger.numeric10FacetsChecker;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00076689 File Offset: 0x00074889
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NegativeInteger;
			}
		}

		// Token: 0x04000D6C RID: 3436
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(decimal.MinValue, -1m);
	}
}
