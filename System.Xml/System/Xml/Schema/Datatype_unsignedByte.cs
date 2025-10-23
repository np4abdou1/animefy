using System;

namespace System.Xml.Schema
{
	// Token: 0x02000286 RID: 646
	internal class Datatype_unsignedByte : Datatype_unsignedShort
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x00076C43 File Offset: 0x00074E43
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_unsignedByte.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00076C4A File Offset: 0x00074E4A
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UnsignedByte;
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00076C50 File Offset: 0x00074E50
		internal override int Compare(object value1, object value2)
		{
			return ((byte)value1).CompareTo(value2);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00076C6C File Offset: 0x00074E6C
		public override Type ValueType
		{
			get
			{
				return Datatype_unsignedByte.atomicValueType;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00076C73 File Offset: 0x00074E73
		internal override Type ListValueType
		{
			get
			{
				return Datatype_unsignedByte.listValueType;
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00076C7C File Offset: 0x00074E7C
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_unsignedByte.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				byte b;
				ex = XmlConvert.TryToByte(s, out b);
				if (ex == null)
				{
					ex = Datatype_unsignedByte.numeric10FacetsChecker.CheckValueFacets((short)b, this);
					if (ex == null)
					{
						typedValue = b;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D83 RID: 3459
		private static readonly Type atomicValueType = typeof(byte);

		// Token: 0x04000D84 RID: 3460
		private static readonly Type listValueType = typeof(byte[]);

		// Token: 0x04000D85 RID: 3461
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(0m, 255m);
	}
}
