using System;

namespace System.Xml.Schema
{
	// Token: 0x02000287 RID: 647
	internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
	{
		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x00076D07 File Offset: 0x00074F07
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_positiveInteger.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00076D0E File Offset: 0x00074F0E
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.PositiveInteger;
			}
		}

		// Token: 0x04000D86 RID: 3462
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(1m, decimal.MaxValue);
	}
}
