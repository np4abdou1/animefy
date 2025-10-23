using System;
using System.IO;

namespace System.Xml
{
	// Token: 0x0200013F RID: 319
	internal class XmlDOMTextWriter : XmlTextWriter
	{
		// Token: 0x06000B44 RID: 2884 RVA: 0x00048BF3 File Offset: 0x00046DF3
		public XmlDOMTextWriter(TextWriter w) : base(w)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00048BFC File Offset: 0x00046DFC
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			if (ns.Length == 0 && prefix.Length != 0)
			{
				prefix = "";
			}
			base.WriteStartElement(prefix, localName, ns);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00048C1E File Offset: 0x00046E1E
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			if (ns.Length == 0 && prefix.Length != 0)
			{
				prefix = "";
			}
			base.WriteStartAttribute(prefix, localName, ns);
		}
	}
}
