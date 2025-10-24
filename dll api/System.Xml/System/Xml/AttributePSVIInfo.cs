using System;
using System.Xml.Schema;

namespace System.Xml
{
	// Token: 0x0200012B RID: 299
	internal class AttributePSVIInfo
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x00043C46 File Offset: 0x00041E46
		internal AttributePSVIInfo()
		{
			this.attributeSchemaInfo = new XmlSchemaInfo();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00043C59 File Offset: 0x00041E59
		internal void Reset()
		{
			this.typedAttributeValue = null;
			this.localName = string.Empty;
			this.namespaceUri = string.Empty;
			this.attributeSchemaInfo.Clear();
		}

		// Token: 0x0400080D RID: 2061
		internal string localName;

		// Token: 0x0400080E RID: 2062
		internal string namespaceUri;

		// Token: 0x0400080F RID: 2063
		internal object typedAttributeValue;

		// Token: 0x04000810 RID: 2064
		internal XmlSchemaInfo attributeSchemaInfo;
	}
}
