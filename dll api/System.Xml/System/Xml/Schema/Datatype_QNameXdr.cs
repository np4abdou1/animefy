using System;

namespace System.Xml.Schema
{
	// Token: 0x0200028A RID: 650
	internal class Datatype_QNameXdr : Datatype_anySimpleType
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00048B41 File Offset: 0x00046D41
		public override XmlTokenizedType TokenizedType
		{
			get
			{
				return XmlTokenizedType.QName;
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00076E08 File Offset: 0x00075008
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			if (s == null || s.Length == 0)
			{
				throw new XmlSchemaException("The attribute value cannot be empty.", string.Empty);
			}
			if (nsmgr == null)
			{
				throw new ArgumentNullException("nsmgr");
			}
			object result;
			try
			{
				string text;
				result = XmlQualifiedName.Parse(s.Trim(), nsmgr, out text);
			}
			catch (XmlSchemaException ex)
			{
				throw ex;
			}
			catch (Exception innerException)
			{
				throw new XmlSchemaException(Res.GetString("The value '{0}' is invalid according to its data type.", new object[]
				{
					s
				}), innerException);
			}
			return result;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00076E8C File Offset: 0x0007508C
		public override Type ValueType
		{
			get
			{
				return Datatype_QNameXdr.atomicValueType;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00076E93 File Offset: 0x00075093
		internal override Type ListValueType
		{
			get
			{
				return Datatype_QNameXdr.listValueType;
			}
		}

		// Token: 0x04000D87 RID: 3463
		private static readonly Type atomicValueType = typeof(XmlQualifiedName);

		// Token: 0x04000D88 RID: 3464
		private static readonly Type listValueType = typeof(XmlQualifiedName[]);
	}
}
