using System;

namespace System.Xml.Schema
{
	// Token: 0x02000289 RID: 649
	internal class Datatype_floatXdr : Datatype_float
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x00076D9C File Offset: 0x00074F9C
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			float num;
			try
			{
				num = XmlConvert.ToSingle(s);
			}
			catch (Exception innerException)
			{
				throw new XmlSchemaException(Res.GetString("The value '{0}' is invalid according to its data type.", new object[]
				{
					s
				}), innerException);
			}
			if (float.IsInfinity(num) || float.IsNaN(num))
			{
				throw new XmlSchemaException("The value '{0}' is invalid according to its data type.", s);
			}
			return num;
		}
	}
}
