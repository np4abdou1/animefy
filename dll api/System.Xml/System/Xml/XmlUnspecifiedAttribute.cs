using System;

namespace System.Xml
{
	// Token: 0x02000157 RID: 343
	internal class XmlUnspecifiedAttribute : XmlAttribute
	{
		// Token: 0x06000CCD RID: 3277 RVA: 0x0004E908 File Offset: 0x0004CB08
		protected internal XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) : base(prefix, localName, namespaceURI, doc)
		{
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0004E915 File Offset: 0x0004CB15
		public override bool Specified
		{
			get
			{
				return this.fSpecified;
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0004E920 File Offset: 0x0004CB20
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			XmlUnspecifiedAttribute xmlUnspecifiedAttribute = (XmlUnspecifiedAttribute)ownerDocument.CreateDefaultAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
			xmlUnspecifiedAttribute.CopyChildren(ownerDocument, this, true);
			xmlUnspecifiedAttribute.fSpecified = true;
			return xmlUnspecifiedAttribute;
		}

		// Token: 0x170002AD RID: 685
		// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0004E961 File Offset: 0x0004CB61
		public override string InnerText
		{
			set
			{
				base.InnerText = value;
				this.fSpecified = true;
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0004E971 File Offset: 0x0004CB71
		public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result = base.InsertBefore(newChild, refChild);
			this.fSpecified = true;
			return result;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0004E982 File Offset: 0x0004CB82
		public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result = base.InsertAfter(newChild, refChild);
			this.fSpecified = true;
			return result;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0004E993 File Offset: 0x0004CB93
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			XmlNode result = base.RemoveChild(oldChild);
			this.fSpecified = true;
			return result;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0004E9A3 File Offset: 0x0004CBA3
		public override XmlNode AppendChild(XmlNode newChild)
		{
			XmlNode result = base.AppendChild(newChild);
			this.fSpecified = true;
			return result;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0004E9B3 File Offset: 0x0004CBB3
		public override void WriteTo(XmlWriter w)
		{
			if (this.fSpecified)
			{
				base.WriteTo(w);
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		internal void SetSpecified(bool f)
		{
			this.fSpecified = f;
		}

		// Token: 0x040008EF RID: 2287
		private bool fSpecified;
	}
}
