using System;

namespace System.Xml.Schema
{
	// Token: 0x02000276 RID: 630
	internal class Datatype_NCName : Datatype_Name
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x0007645C File Offset: 0x0007465C
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.NCName;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00076460 File Offset: 0x00074660
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			Exception ex = DatatypeImplementation.stringFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				ex = DatatypeImplementation.stringFacetsChecker.CheckValueFacets(s, this);
				if (ex == null)
				{
					nameTable.Add(s);
					typedValue = s;
					return null;
				}
			}
			return ex;
		}
	}
}
