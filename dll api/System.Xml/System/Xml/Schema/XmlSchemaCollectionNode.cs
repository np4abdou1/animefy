using System;

namespace System.Xml.Schema
{
	// Token: 0x020002DB RID: 731
	internal sealed class XmlSchemaCollectionNode
	{
		// Token: 0x17000595 RID: 1429
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0009675D File Offset: 0x0009495D
		internal string NamespaceURI
		{
			set
			{
				this.namespaceUri = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00096766 File Offset: 0x00094966
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0009676E File Offset: 0x0009496E
		internal SchemaInfo SchemaInfo
		{
			get
			{
				return this.schemaInfo;
			}
			set
			{
				this.schemaInfo = value;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x00096777 File Offset: 0x00094977
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0009677F File Offset: 0x0009497F
		internal XmlSchema Schema
		{
			get
			{
				return this.schema;
			}
			set
			{
				this.schema = value;
			}
		}

		// Token: 0x0400105B RID: 4187
		private string namespaceUri;

		// Token: 0x0400105C RID: 4188
		private SchemaInfo schemaInfo;

		// Token: 0x0400105D RID: 4189
		private XmlSchema schema;
	}
}
