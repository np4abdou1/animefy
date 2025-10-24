using System;

namespace System.Xml.Schema
{
	// Token: 0x02000280 RID: 640
	internal class Datatype_short : Datatype_int
	{
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0007684C File Offset: 0x00074A4C
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_short.numeric10FacetsChecker;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00076853 File Offset: 0x00074A53
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Short;
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00076858 File Offset: 0x00074A58
		internal override int Compare(object value1, object value2)
		{
			return ((short)value1).CompareTo(value2);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00076874 File Offset: 0x00074A74
		public override Type ValueType
		{
			get
			{
				return Datatype_short.atomicValueType;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0007687B File Offset: 0x00074A7B
		internal override Type ListValueType
		{
			get
			{
				return Datatype_short.listValueType;
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00076884 File Offset: 0x00074A84
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_short.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				short num;
				ex = XmlConvert.TryToInt16(s, out num);
				if (ex == null)
				{
					ex = Datatype_short.numeric10FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D73 RID: 3443
		private static readonly Type atomicValueType = typeof(short);

		// Token: 0x04000D74 RID: 3444
		private static readonly Type listValueType = typeof(short[]);

		// Token: 0x04000D75 RID: 3445
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(-32768m, 32767m);
	}
}
