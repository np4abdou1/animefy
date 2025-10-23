using System;

namespace System.Xml.Schema
{
	// Token: 0x02000285 RID: 645
	internal class Datatype_unsignedShort : Datatype_unsignedInt
	{
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x00076B80 File Offset: 0x00074D80
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_unsignedShort.numeric10FacetsChecker;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00076B87 File Offset: 0x00074D87
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.UnsignedShort;
			}
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00076B8C File Offset: 0x00074D8C
		internal override int Compare(object value1, object value2)
		{
			return ((ushort)value1).CompareTo(value2);
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00076BA8 File Offset: 0x00074DA8
		public override Type ValueType
		{
			get
			{
				return Datatype_unsignedShort.atomicValueType;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x00076BAF File Offset: 0x00074DAF
		internal override Type ListValueType
		{
			get
			{
				return Datatype_unsignedShort.listValueType;
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00076BB8 File Offset: 0x00074DB8
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_unsignedShort.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				ushort num;
				ex = XmlConvert.TryToUInt16(s, out num);
				if (ex == null)
				{
					ex = Datatype_unsignedShort.numeric10FacetsChecker.CheckValueFacets((int)num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D80 RID: 3456
		private static readonly Type atomicValueType = typeof(ushort);

		// Token: 0x04000D81 RID: 3457
		private static readonly Type listValueType = typeof(ushort[]);

		// Token: 0x04000D82 RID: 3458
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(0m, 65535m);
	}
}
