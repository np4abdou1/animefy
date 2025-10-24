using System;

namespace System.Xml.Schema
{
	// Token: 0x02000283 RID: 643
	internal class Datatype_unsignedLong : Datatype_nonNegativeInteger
	{
		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x000769FC File Offset: 0x00074BFC
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_unsignedLong.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00076A03 File Offset: 0x00074C03
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UnsignedLong;
			}
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00076A08 File Offset: 0x00074C08
		internal override int Compare(object value1, object value2)
		{
			return ((ulong)value1).CompareTo(value2);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00076A24 File Offset: 0x00074C24
		public override Type ValueType
		{
			get
			{
				return Datatype_unsignedLong.atomicValueType;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00076A2B File Offset: 0x00074C2B
		internal override Type ListValueType
		{
			get
			{
				return Datatype_unsignedLong.listValueType;
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00076A34 File Offset: 0x00074C34
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_unsignedLong.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				ulong num;
				ex = XmlConvert.TryToUInt64(s, out num);
				if (ex == null)
				{
					ex = Datatype_unsignedLong.numeric10FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D7A RID: 3450
		private static readonly Type atomicValueType = typeof(ulong);

		// Token: 0x04000D7B RID: 3451
		private static readonly Type listValueType = typeof(ulong[]);

		// Token: 0x04000D7C RID: 3452
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(0m, 18446744073709551615m);
	}
}
