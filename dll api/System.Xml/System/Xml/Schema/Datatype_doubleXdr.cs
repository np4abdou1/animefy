using System;

namespace System.Xml.Schema
{
	// Token: 0x02000288 RID: 648
	internal class Datatype_doubleXdr : Datatype_double
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x00076D30 File Offset: 0x00074F30
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			double num;
			try
			{
				num = XmlConvert.ToDouble(s);
			}
			catch (Exception innerException)
			{
				throw new XmlSchemaException(Res.GetString("The value '{0}' is invalid according to its data type.", new object[]
				{
					s
				}), innerException);
			}
			if (double.IsInfinity(num) || double.IsNaN(num))
			{
				throw new XmlSchemaException("The value '{0}' is invalid according to its data type.", s);
			}
			return num;
		}
	}
}
