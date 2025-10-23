using System;

namespace System.Xml
{
	/// <summary>Gets the node immediately preceding or following this node.</summary>
	// Token: 0x02000145 RID: 325
	public abstract class XmlLinkedNode : XmlNode
	{
		// Token: 0x06000B9E RID: 2974 RVA: 0x00049703 File Offset: 0x00047903
		internal XmlLinkedNode(XmlDocument doc) : base(doc)
		{
			this.next = null;
		}

		/// <summary>Gets the node immediately preceding this node.</summary>
		/// <returns>The preceding <see cref="T:System.Xml.XmlNode" /> or <see langword="null" /> if one does not exist.</returns>
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00049714 File Offset: 0x00047914
		public override XmlNode PreviousSibling
		{
			get
			{
				XmlNode parentNode = this.ParentNode;
				if (parentNode != null)
				{
					XmlNode xmlNode;
					XmlNode nextSibling;
					for (xmlNode = parentNode.FirstChild; xmlNode != null; xmlNode = nextSibling)
					{
						nextSibling = xmlNode.NextSibling;
						if (nextSibling == this)
						{
							break;
						}
					}
					return xmlNode;
				}
				return null;
			}
		}

		/// <summary>Gets the node immediately following this node.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> immediately following this node or <see langword="null" /> if one does not exist.</returns>
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00049748 File Offset: 0x00047948
		public override XmlNode NextSibling
		{
			get
			{
				XmlNode parentNode = this.ParentNode;
				if (parentNode != null && this.next != parentNode.FirstChild)
				{
					return this.next;
				}
				return null;
			}
		}

		// Token: 0x040008B3 RID: 2227
		internal XmlLinkedNode next;
	}
}
