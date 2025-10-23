using System;

namespace System.Xml.Schema
{
	// Token: 0x0200025C RID: 604
	internal class Datatype_yearMonthDuration : Datatype_duration
	{
		// Token: 0x060013BD RID: 5053 RVA: 0x00075EBC File Offset: 0x000740BC
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			typedValue = null;
			if (s == null || s.Length == 0)
			{
				return new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
			}
			Exception ex = DatatypeImplementation.durationFacetsChecker.CheckLexicalFacets(ref s, this);
			if (ex == null)
			{
				XsdDuration xsdDuration;
				ex = XsdDuration.TryParse(s, XsdDuration.DurationType.YearMonthDuration, out xsdDuration);
				if (ex == null)
				{
					TimeSpan timeSpan;
					ex = xsdDuration.TryToTimeSpan(XsdDuration.DurationType.YearMonthDuration, out timeSpan);
					if (ex == null)
					{
						ex = DatatypeImplementation.durationFacetsChecker.CheckValueFacets(timeSpan, this);
						if (ex == null)
						{
							typedValue = timeSpan;
							return null;
						}
					}
				}
			}
			return ex;
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00075F30 File Offset: 0x00074130
		public override XmlTypeCode TypeCode
		{
			get
			{
				return XmlTypeCode.YearMonthDuration;
			}
		}
	}
}
