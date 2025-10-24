using System;
using System.Collections;
using System.IO;
using System.Security;

namespace Mono.Xml
{
	// Token: 0x02000029 RID: 41
	internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00002A41 File Offset: 0x00000C41
		public SecurityParser()
		{
			this.stack = new Stack();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A54 File Offset: 0x00000C54
		public void LoadXml(string xml)
		{
			this.root = null;
			this.stack.Clear();
			base.Parse(new StringReader(xml), this);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002A75 File Offset: 0x00000C75
		public SecurityElement ToXml()
		{
			return this.root;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void OnProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void OnIgnorableWhitespace(string s)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002A80 File Offset: 0x00000C80
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
			SecurityElement securityElement = new SecurityElement(name);
			if (this.root == null)
			{
				this.root = securityElement;
				this.current = securityElement;
			}
			else
			{
				((SecurityElement)this.stack.Peek()).AddChild(securityElement);
			}
			this.stack.Push(securityElement);
			this.current = securityElement;
			int length = attrs.Length;
			for (int i = 0; i < length; i++)
			{
				this.current.AddAttribute(attrs.GetName(i), SecurityElement.Escape(attrs.GetValue(i)));
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002B06 File Offset: 0x00000D06
		public void OnEndElement(string name)
		{
			this.current = (SecurityElement)this.stack.Pop();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002B1E File Offset: 0x00000D1E
		public void OnChars(string ch)
		{
			this.current.Text = SecurityElement.Escape(ch);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void OnEndParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x040000BB RID: 187
		private SecurityElement root;

		// Token: 0x040000BC RID: 188
		private SecurityElement current;

		// Token: 0x040000BD RID: 189
		private Stack stack;
	}
}
