using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027F RID: 639
	internal class Datatype_int : Datatype_long
	{
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00076785 File Offset: 0x00074985
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_int.numeric10FacetsChecker;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0007678C File Offset: 0x0007498C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Int;
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00076790 File Offset: 0x00074990
		internal override int Compare(object value1, object value2)
		{
			return ((int)value1).CompareTo(value2);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000767AC File Offset: 0x000749AC
		public override Type ValueType
		{
			get
			{
				return Datatype_int.atomicValueType;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x000767B3 File Offset: 0x000749B3
		internal override Type ListValueType
		{
			get
			{
				return Datatype_int.listValueType;
			}
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000767BC File Offset: 0x000749BC
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_int.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				int num;
				ex = XmlConvert.TryToInt32(s, out num);
				if (ex == null)
				{
					ex = Datatype_int.numeric10FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D70 RID: 3440
		private static readonly Type atomicValueType = typeof(int);

		// Token: 0x04000D71 RID: 3441
		private static readonly Type listValueType = typeof(int[]);

		// Token: 0x04000D72 RID: 3442
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(-2147483648m, 2147483647m);
	}
}
