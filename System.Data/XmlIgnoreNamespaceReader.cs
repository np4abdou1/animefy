using System;
using System.Collections.Generic;
using System.Xml;

namespace System.Data
{
	// Token: 0x0200009E RID: 158
	internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x000333DE File Offset: 0x000315DE
		internal XmlIgnoreNamespaceReader(XmlDocument xdoc, string[] namespacesToIgnore) : base(xdoc)
		{
			this._namespacesToIgnore = new List<string>(namespacesToIgnore);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000333F4 File Offset: 0x000315F4
		public override bool MoveToFirstAttribute()
		{
			return base.MoveToFirstAttribute() && ((!this._namespacesToIgnore.Contains(this.NamespaceURI) && (!(this.NamespaceURI == "http://www.w3.org/XML/1998/namespace") || !(this.LocalName != "lang"))) || this.MoveToNextAttribute());
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0003344C File Offset: 0x0003164C
		public override bool MoveToNextAttribute()
		{
			bool result;
			bool flag;
			do
			{
				result = false;
				flag = false;
				if (base.MoveToNextAttribute())
				{
					result = true;
					if (this._namespacesToIgnore.Contains(this.NamespaceURI) || (this.NamespaceURI == "http://www.w3.org/XML/1998/namespace" && this.LocalName != "lang"))
					{
						flag = true;
					}
				}
			}
			while (flag);
			return result;
		}

		// Token: 0x0400032A RID: 810
		private List<string> _namespacesToIgnore;
	}
}
