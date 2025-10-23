using System;

namespace System.Xml.Schema
{
	// Token: 0x020002B9 RID: 697
	internal sealed class SchemaNotation
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x0008C480 File Offset: 0x0008A680
		internal SchemaNotation(XmlQualifiedName name)
		{
			this.name = name;
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x0008C48F File Offset: 0x0008A68F
		internal XmlQualifiedName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0008C497 File Offset: 0x0008A697
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0008C49F File Offset: 0x0008A69F
		internal string SystemLiteral
		{
			get
			{
				return this.systemLiteral;
			}
			set
			{
				this.systemLiteral = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0008C4A8 File Offset: 0x0008A6A8
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0008C4B0 File Offset: 0x0008A6B0
		internal string Pubid
		{
			get
			{
				return this.pubid;
			}
			set
			{
				this.pubid = value;
			}
		}

		// Token: 0x04000F72 RID: 3954
		private XmlQualifiedName name;

		// Token: 0x04000F73 RID: 3955
		private string systemLiteral;

		// Token: 0x04000F74 RID: 3956
		private string pubid;
	}
}
