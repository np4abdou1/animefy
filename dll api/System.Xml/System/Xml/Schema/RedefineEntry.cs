using System;

namespace System.Xml.Schema
{
	// Token: 0x020002A8 RID: 680
	internal class RedefineEntry
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x0007F55A File Offset: 0x0007D75A
		public RedefineEntry(XmlSchemaRedefine external, XmlSchema schema)
		{
			this.redefine = external;
			this.schemaToUpdate = schema;
		}

		// Token: 0x04000DED RID: 3565
		internal XmlSchemaRedefine redefine;

		// Token: 0x04000DEE RID: 3566
		internal XmlSchema schemaToUpdate;
	}
}
