using System;

namespace System.Xml.Schema
{
	// Token: 0x0200027B RID: 635
	internal class Datatype_integer : Datatype_decimal
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00075B6B File Offset: 0x00073D6B
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.Integer;
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00076600 File Offset: 0x00074800
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = this.FacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				decimal num;
				ex = XmlConvert.TryToInteger(s, out num);
				if (ex == null)
				{
					ex = this.FacetsChecker.CheckValueFacets(num, this);
					if (ex == null)
					{
						typedValue = num;
						return null;
					}
				}
			}
			return ex;
		}
	}
}
