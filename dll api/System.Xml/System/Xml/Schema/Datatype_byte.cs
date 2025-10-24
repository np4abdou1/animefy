using System;

namespace System.Xml.Schema
{
	// Token: 0x02000281 RID: 641
	internal class Datatype_byte : Datatype_short
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00076914 File Offset: 0x00074B14
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_byte.numeric10FacetsChecker;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0007691B File Offset: 0x00074B1B
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Byte;
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00076920 File Offset: 0x00074B20
		internal override int Compare(object value1, object value2)
		{
			return ((sbyte)value1).CompareTo(value2);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0007693C File Offset: 0x00074B3C
		public override Type ValueType
		{
			get
			{
				return Datatype_byte.atomicValueType;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00076943 File Offset: 0x00074B43
		internal override Type ListValueType
		{
			get
			{
				return Datatype_byte.listValueType;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0007694C File Offset: 0x00074B4C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_byte.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				sbyte b;
				ex = XmlConvert.TryToSByte(s, out b);
				if (ex == null)
				{
					ex = Datatype_byte.numeric10FacetsChecker.CheckValueFacets((short)b, this);
					if (ex == null)
					{
						typedValue = b;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D76 RID: 3446
		private static readonly Type atomicValueType = typeof(sbyte);

		// Token: 0x04000D77 RID: 3447
		private static readonly Type listValueType = typeof(sbyte[]);

		// Token: 0x04000D78 RID: 3448
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(-128m, 127m);
	}
}
