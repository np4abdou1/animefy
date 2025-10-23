using System;
using System.Xml.Schema;

namespace System.Data
{
	// Token: 0x0200009B RID: 155
	internal sealed class ConstraintTable
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x0002EA7C File Offset: 0x0002CC7C
		public ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c)
		{
			this.table = t;
			this.constraint = c;
		}

		// Token: 0x04000312 RID: 786
		public DataTable table;

		// Token: 0x04000313 RID: 787
		public XmlSchemaIdentityConstraint constraint;
	}
}
