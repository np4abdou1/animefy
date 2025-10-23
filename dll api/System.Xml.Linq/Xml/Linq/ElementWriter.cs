using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	// Token: 0x02000025 RID: 37
	internal struct ElementWriter
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0000710B File Offset: 0x0000530B
		public ElementWriter(XmlWriter writer)
		{
			this._writer = writer;
			this._resolver = default(NamespaceResolver);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007120 File Offset: 0x00005320
		public void WriteElement(XElement e)
		{
			this.PushAncestors(e);
			XElement xelement = e;
			XNode xnode = e;
			for (;;)
			{
				e = (xnode as XElement);
				if (e != null)
				{
					this.WriteStartElement(e);
					if (e.content == null)
					{
						this.WriteEndElement();
					}
					else
					{
						string text = e.content as string;
						if (text == null)
						{
							xnode = ((XNode)e.content).next;
							continue;
						}
						this._writer.WriteString(text);
						this.WriteFullEndElement();
					}
				}
				else
				{
					xnode.WriteTo(this._writer);
				}
				while (xnode != xelement && xnode == xnode.parent.content)
				{
					xnode = xnode.parent;
					this.WriteFullEndElement();
				}
				if (xnode == xelement)
				{
					break;
				}
				xnode = xnode.next;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000071D0 File Offset: 0x000053D0
		public Task WriteElementAsync(XElement e, CancellationToken cancellationToken)
		{
			ElementWriter.<WriteElementAsync>d__4 <WriteElementAsync>d__;
			<WriteElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteElementAsync>d__.<>4__this = this;
			<WriteElementAsync>d__.e = e;
			<WriteElementAsync>d__.cancellationToken = cancellationToken;
			<WriteElementAsync>d__.<>1__state = -1;
			<WriteElementAsync>d__.<>t__builder.Start<ElementWriter.<WriteElementAsync>d__4>(ref <WriteElementAsync>d__);
			return <WriteElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007228 File Offset: 0x00005428
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
		{
			string namespaceName = ns.NamespaceName;
			if (namespaceName.Length == 0)
			{
				return string.Empty;
			}
			string prefixOfNamespace = this._resolver.GetPrefixOfNamespace(ns, allowDefaultNamespace);
			if (prefixOfNamespace != null)
			{
				return prefixOfNamespace;
			}
			if (namespaceName == "http://www.w3.org/XML/1998/namespace")
			{
				return "xml";
			}
			if (namespaceName == "http://www.w3.org/2000/xmlns/")
			{
				return "xmlns";
			}
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000727C File Offset: 0x0000547C
		private void PushAncestors(XElement e)
		{
			for (;;)
			{
				e = (e.parent as XElement);
				if (e == null)
				{
					break;
				}
				XAttribute xattribute = e.lastAttr;
				if (xattribute != null)
				{
					do
					{
						xattribute = xattribute.next;
						if (xattribute.IsNamespaceDeclaration)
						{
							this._resolver.AddFirst((xattribute.Name.NamespaceName.Length == 0) ? string.Empty : xattribute.Name.LocalName, XNamespace.Get(xattribute.Value));
						}
					}
					while (xattribute != e.lastAttr);
				}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000072F8 File Offset: 0x000054F8
		private void PushElement(XElement e)
		{
			this._resolver.PushScope();
			XAttribute xattribute = e.lastAttr;
			if (xattribute != null)
			{
				do
				{
					xattribute = xattribute.next;
					if (xattribute.IsNamespaceDeclaration)
					{
						this._resolver.Add((xattribute.Name.NamespaceName.Length == 0) ? string.Empty : xattribute.Name.LocalName, XNamespace.Get(xattribute.Value));
					}
				}
				while (xattribute != e.lastAttr);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000736C File Offset: 0x0000556C
		private void WriteEndElement()
		{
			this._writer.WriteEndElement();
			this._resolver.PopScope();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00007384 File Offset: 0x00005584
		private Task WriteEndElementAsync(CancellationToken cancellationToken)
		{
			ElementWriter.<WriteEndElementAsync>d__9 <WriteEndElementAsync>d__;
			<WriteEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteEndElementAsync>d__.<>4__this = this;
			<WriteEndElementAsync>d__.cancellationToken = cancellationToken;
			<WriteEndElementAsync>d__.<>1__state = -1;
			<WriteEndElementAsync>d__.<>t__builder.Start<ElementWriter.<WriteEndElementAsync>d__9>(ref <WriteEndElementAsync>d__);
			return <WriteEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000073D4 File Offset: 0x000055D4
		private void WriteFullEndElement()
		{
			this._writer.WriteFullEndElement();
			this._resolver.PopScope();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000073EC File Offset: 0x000055EC
		private Task WriteFullEndElementAsync(CancellationToken cancellationToken)
		{
			ElementWriter.<WriteFullEndElementAsync>d__11 <WriteFullEndElementAsync>d__;
			<WriteFullEndElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteFullEndElementAsync>d__.<>4__this = this;
			<WriteFullEndElementAsync>d__.cancellationToken = cancellationToken;
			<WriteFullEndElementAsync>d__.<>1__state = -1;
			<WriteFullEndElementAsync>d__.<>t__builder.Start<ElementWriter.<WriteFullEndElementAsync>d__11>(ref <WriteFullEndElementAsync>d__);
			return <WriteFullEndElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000743C File Offset: 0x0000563C
		private void WriteStartElement(XElement e)
		{
			this.PushElement(e);
			XNamespace @namespace = e.Name.Namespace;
			this._writer.WriteStartElement(this.GetPrefixOfNamespace(@namespace, true), e.Name.LocalName, @namespace.NamespaceName);
			XAttribute xattribute = e.lastAttr;
			if (xattribute != null)
			{
				do
				{
					xattribute = xattribute.next;
					@namespace = xattribute.Name.Namespace;
					string localName = xattribute.Name.LocalName;
					string namespaceName = @namespace.NamespaceName;
					this._writer.WriteAttributeString(this.GetPrefixOfNamespace(@namespace, false), localName, (namespaceName.Length == 0 && localName == "xmlns") ? "http://www.w3.org/2000/xmlns/" : namespaceName, xattribute.Value);
				}
				while (xattribute != e.lastAttr);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000074F0 File Offset: 0x000056F0
		private Task WriteStartElementAsync(XElement e, CancellationToken cancellationToken)
		{
			ElementWriter.<WriteStartElementAsync>d__13 <WriteStartElementAsync>d__;
			<WriteStartElementAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteStartElementAsync>d__.<>4__this = this;
			<WriteStartElementAsync>d__.e = e;
			<WriteStartElementAsync>d__.<>1__state = -1;
			<WriteStartElementAsync>d__.<>t__builder.Start<ElementWriter.<WriteStartElementAsync>d__13>(ref <WriteStartElementAsync>d__);
			return <WriteStartElementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000096 RID: 150
		private XmlWriter _writer;

		// Token: 0x04000097 RID: 151
		private NamespaceResolver _resolver;
	}
}
