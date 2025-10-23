using System;

namespace System.Xml.Schema
{
	// Token: 0x02000284 RID: 644
	internal class Datatype_unsignedInt : Datatype_unsignedLong
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00076AC1 File Offset: 0x00074CC1
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_unsignedInt.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00076AC8 File Offset: 0x00074CC8
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UnsignedInt;
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00076ACC File Offset: 0x00074CCC
		internal override int Compare(object value1, object value2)
		{
			return ((uint)value1).CompareTo(value2);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00076AE8 File Offset: 0x00074CE8
		public override Type ValueType
		{
			get
			{
				return Datatype_unsignedInt.atomicValueType;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00076AEF File Offset: 0x00074CEF
		internal override Type ListValueType
		{
			get
			{
				return Datatype_unsignedInt.listValueType;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00076AF8 File Offset: 0x00074CF8
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_unsignedInt.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				uint num;
				ex = XmlConvert.TryToUInt32(s, out num);
				if (ex == null)
				{
					ex = Datatype_unsignedInt.numeric10FacetsChecker.CheckValueFacets((long)((ulong)num), this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D7D RID: 3453
		private static readonly Type atomicValueType = typeof(uint);

		// Token: 0x04000D7E RID: 3454
		private static readonly Type listValueType = typeof(uint[]);

		// Token: 0x04000D7F RID: 3455
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(0m, 4294967295m);
	}
}
