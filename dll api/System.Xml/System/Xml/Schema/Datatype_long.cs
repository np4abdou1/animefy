using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027E RID: 638
	internal class Datatype_long : Datatype_integer
	{
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x000766B0 File Offset: 0x000748B0
		internal override FacetsChecker FacetsChecker
		{
			get
			{
				return Datatype_long.numeric10FacetsChecker;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0000C89B File Offset: 0x0000AA9B
		internal override bool HasValueFacets
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000766B7 File Offset: 0x000748B7
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Long;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000766BC File Offset: 0x000748BC
		internal override int Compare(object value1, object value2)
		{
			return ((long)value1).CompareTo(value2);
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000766D8 File Offset: 0x000748D8
		public override Type ValueType
		{
			get
			{
				return Datatype_long.atomicValueType;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x000766DF File Offset: 0x000748DF
		internal override Type ListValueType
		{
			get
			{
				return Datatype_long.listValueType;
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x000766E8 File Offset: 0x000748E8
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = Datatype_long.numeric10FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				long num;
				ex = XmlConvert.TryToInt64(s, out num);
				if (ex == null)
				{
					ex = Datatype_long.numeric10FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}

		// Token: 0x04000D6D RID: 3437
		private static readonly Type atomicValueType = typeof(long);

		// Token: 0x04000D6E RID: 3438
		private static readonly Type listValueType = typeof(long[]);

		// Token: 0x04000D6F RID: 3439
		private static readonly FacetsChecker numeric10FacetsChecker = new Numeric10FacetsChecker(-9223372036854775808m, 9223372036854775807m);
	}
}
