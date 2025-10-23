using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML document. For the components and usage of an <see cref="T:System.Xml.Linq.XDocument" /> object, see XDocument Class Overview.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000012 RID: 18
	public class XDocument : XContainer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class. </summary>
		// Token: 0x06000072 RID: 114 RVA: 0x00004369 File Offset: 0x00002569
		public XDocument()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XDocument" /> class from an existing <see cref="T:System.Xml.Linq.XDocument" /> object.</summary>
		/// <param name="other">The <see cref="T:System.Xml.Linq.XDocument" /> object that will be copied.</param>
		// Token: 0x06000073 RID: 115 RVA: 0x00004371 File Offset: 0x00002571
		public XDocument(XDocument other) : base(other)
		{
			if (other._declaration != null)
			{
				this._declaration = new XDeclaration(other._declaration);
			}
		}

		/// <summary>Gets or sets the XML declaration for this document.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XDeclaration" /> that contains the XML declaration for this document.</returns>
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004393 File Offset: 0x00002593
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000439B File Offset: 0x0000259B
		public XDeclaration Declaration
		{
			get
			{
				return this._declaration;
			}
			set
			{
				this._declaration = value;
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XDocument" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000043A4 File Offset: 0x000025A4
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Document;
			}
		}

		/// <summary>Gets the root element of the XML Tree for this document.</summary>
		/// <returns>The root <see cref="T:System.Xml.Linq.XElement" /> of the XML tree.</returns>
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000043A8 File Offset: 0x000025A8
		public XElement Root
		{
			get
			{
				return this.GetFirstNode<XElement>();
			}
		}

		/// <summary>Write this document to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x06000078 RID: 120 RVA: 0x000043B0 File Offset: 0x000025B0
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (this._declaration != null && this._declaration.Standalone == "yes")
			{
				writer.WriteStartDocument(true);
			}
			else if (this._declaration != null && this._declaration.Standalone == "no")
			{
				writer.WriteStartDocument(false);
			}
			else
			{
				writer.WriteStartDocument();
			}
			base.WriteContentTo(writer);
			writer.WriteEndDocument();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000442E File Offset: 0x0000262E
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return this.WriteToAsyncInternal(writer, cancellationToken);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004458 File Offset: 0x00002658
		private Task WriteToAsyncInternal(XmlWriter writer, CancellationToken cancellationToken)
		{
			XDocument.<WriteToAsyncInternal>d__41 <WriteToAsyncInternal>d__;
			<WriteToAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteToAsyncInternal>d__.<>4__this = this;
			<WriteToAsyncInternal>d__.writer = writer;
			<WriteToAsyncInternal>d__.cancellationToken = cancellationToken;
			<WriteToAsyncInternal>d__.<>1__state = -1;
			<WriteToAsyncInternal>d__.<>t__builder.Start<XDocument.<WriteToAsyncInternal>d__41>(ref <WriteToAsyncInternal>d__);
			return <WriteToAsyncInternal>d__.<>t__builder.Task;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000044AB File Offset: 0x000026AB
		internal override void AddAttribute(XAttribute a)
		{
			throw new ArgumentException("An attribute cannot be added to content.");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000044AB File Offset: 0x000026AB
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			throw new ArgumentException("An attribute cannot be added to content.");
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000044B7 File Offset: 0x000026B7
		internal override XNode CloneNode()
		{
			return new XDocument(this);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000044C0 File Offset: 0x000026C0
		internal override bool DeepEquals(XNode node)
		{
			XDocument xdocument = node as XDocument;
			return xdocument != null && base.ContentsEqual(xdocument);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000044E0 File Offset: 0x000026E0
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000044E8 File Offset: 0x000026E8
		private T GetFirstNode<T>() where T : XNode
		{
			XNode xnode = this.content as XNode;
			if (xnode != null)
			{
				T t;
				for (;;)
				{
					xnode = xnode.next;
					t = (xnode as T);
					if (t != null)
					{
						break;
					}
					if (xnode == this.content)
					{
						goto IL_35;
					}
				}
				return t;
			}
			IL_35:
			return default(T);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004534 File Offset: 0x00002734
		internal static bool IsWhitespace(string s)
		{
			foreach (char c in s)
			{
				if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004574 File Offset: 0x00002774
		internal override void ValidateNode(XNode node, XNode previous)
		{
			XmlNodeType nodeType = node.NodeType;
			switch (nodeType)
			{
			case XmlNodeType.Element:
				this.ValidateDocument(previous, XmlNodeType.DocumentType, XmlNodeType.None);
				return;
			case XmlNodeType.Attribute:
				return;
			case XmlNodeType.Text:
				this.ValidateString(((XText)node).Value);
				return;
			case XmlNodeType.CDATA:
				throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.CDATA));
			default:
				if (nodeType == XmlNodeType.Document)
				{
					throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.Document));
				}
				if (nodeType != XmlNodeType.DocumentType)
				{
					return;
				}
				this.ValidateDocument(previous, XmlNodeType.None, XmlNodeType.Element);
				return;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004600 File Offset: 0x00002800
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
			XNode xnode = this.content as XNode;
			if (xnode != null)
			{
				if (previous == null)
				{
					allowBefore = allowAfter;
				}
				for (;;)
				{
					xnode = xnode.next;
					XmlNodeType nodeType = xnode.NodeType;
					if (nodeType == XmlNodeType.Element || nodeType == XmlNodeType.DocumentType)
					{
						if (nodeType != allowBefore)
						{
							break;
						}
						allowBefore = XmlNodeType.None;
					}
					if (xnode == previous)
					{
						allowBefore = allowAfter;
					}
					if (xnode == this.content)
					{
						return;
					}
				}
				throw new InvalidOperationException("This operation would create an incorrectly structured document.");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000465B File Offset: 0x0000285B
		internal override void ValidateString(string s)
		{
			if (!XDocument.IsWhitespace(s))
			{
				throw new ArgumentException("Non-whitespace characters cannot be added to content.");
			}
		}

		// Token: 0x0400003E RID: 62
		private XDeclaration _declaration;
	}
}
