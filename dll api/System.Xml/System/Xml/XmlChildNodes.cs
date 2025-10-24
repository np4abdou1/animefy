using System;
using System.Collections;

namespace System.Xml
{
	// Token: 0x02000139 RID: 313
	internal class XmlChildNodes : XmlNodeList
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x000471EB File Offset: 0x000453EB
		public XmlChildNodes(XmlNode container)
		{
			this.container = container;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x000471FC File Offset: 0x000453FC
		public override XmlNode Item(int i)
		{
			if (i < 0)
			{
				return null;
			}
			XmlNode xmlNode = this.container.FirstChild;
			while (xmlNode != null)
			{
				if (i == 0)
				{
					return xmlNode;
				}
				xmlNode = xmlNode.NextSibling;
				i--;
			}
			return null;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00047234 File Offset: 0x00045434
		public override int Count
		{
			get
			{
				int num = 0;
				for (XmlNode xmlNode = this.container.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00047260 File Offset: 0x00045460
		public override IEnumerator GetEnumerator()
		{
			if (this.container.FirstChild == null)
			{
				return XmlDocument.EmptyEnumerator;
			}
			return new XmlChildEnumerator(this.container);
		}

		// Token: 0x04000868 RID: 2152
		private XmlNode container;
	}
}
