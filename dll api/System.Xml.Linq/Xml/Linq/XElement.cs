using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML element.  See XElement Class Overview and the Remarks section on this page for usage information and examples.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000015 RID: 21
	[XmlTypeConvertor("ConvertForAssignment")]
	[XmlSchemaProvider(null, IsAny = true)]
	public class XElement : XContainer, IXmlSerializable
	{
		/// <summary>Gets an empty collection of elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contains an empty collection.</returns>
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004A6D File Offset: 0x00002C6D
		public static IEnumerable<XElement> EmptySequence
		{
			get
			{
				return Array.Empty<XElement>();
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class with the specified name. </summary>
		/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the element.</param>
		// Token: 0x06000094 RID: 148 RVA: 0x00004A74 File Offset: 0x00002C74
		public XElement(XName name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.name = name;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class with the specified name and content.</summary>
		/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the element name.</param>
		/// <param name="content">The contents of the element.</param>
		// Token: 0x06000095 RID: 149 RVA: 0x00004A97 File Offset: 0x00002C97
		public XElement(XName name, object content) : this(name)
		{
			base.AddContentSkipNotify(content);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class with the specified name and content.</summary>
		/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the element name.</param>
		/// <param name="content">The initial content of the element.</param>
		// Token: 0x06000096 RID: 150 RVA: 0x00004AA7 File Offset: 0x00002CA7
		public XElement(XName name, params object[] content) : this(name, content)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class from another <see cref="T:System.Xml.Linq.XElement" /> object.</summary>
		/// <param name="other">An <see cref="T:System.Xml.Linq.XElement" /> object to copy from.</param>
		// Token: 0x06000097 RID: 151 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public XElement(XElement other) : base(other)
		{
			this.name = other.name;
			XAttribute next = other.lastAttr;
			if (next != null)
			{
				do
				{
					next = next.next;
					this.AppendAttributeSkipNotify(new XAttribute(next));
				}
				while (next != other.lastAttr);
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XElement" /> class from an <see cref="T:System.Xml.Linq.XStreamingElement" /> object.</summary>
		/// <param name="other">An <see cref="T:System.Xml.Linq.XStreamingElement" /> that contains unevaluated queries that will be iterated for the contents of this <see cref="T:System.Xml.Linq.XElement" />.</param>
		// Token: 0x06000098 RID: 152 RVA: 0x00004AFA File Offset: 0x00002CFA
		public XElement(XStreamingElement other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.name = other.name;
			base.AddContentSkipNotify(other.content);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004B28 File Offset: 0x00002D28
		internal XElement() : this("default")
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004B3A File Offset: 0x00002D3A
		internal XElement(XmlReader r) : this(r, LoadOptions.None)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004369 File Offset: 0x00002569
		private XElement(XElement.AsyncConstructionSentry s)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004B44 File Offset: 0x00002D44
		internal XElement(XmlReader r, LoadOptions o)
		{
			this.ReadElementFrom(r, o);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004B54 File Offset: 0x00002D54
		internal static Task<XElement> CreateAsync(XmlReader r, CancellationToken cancellationToken)
		{
			XElement.<CreateAsync>d__14 <CreateAsync>d__;
			<CreateAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XElement>.Create();
			<CreateAsync>d__.r = r;
			<CreateAsync>d__.cancellationToken = cancellationToken;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<XElement.<CreateAsync>d__14>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		/// <summary>Serialize this element to a file.</summary>
		/// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
		// Token: 0x0600009E RID: 158 RVA: 0x00004B9F File Offset: 0x00002D9F
		public void Save(string fileName)
		{
			this.Save(fileName, base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Serialize this element to a file, optionally disabling formatting.</summary>
		/// <param name="fileName">A <see cref="T:System.String" /> that contains the name of the file.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
		// Token: 0x0600009F RID: 159 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public void Save(string fileName, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		/// <summary>Gets the first attribute of this element.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that contains the first attribute of this element.</returns>
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public XAttribute FirstAttribute
		{
			get
			{
				if (this.lastAttr == null)
				{
					return null;
				}
				return this.lastAttr.next;
			}
		}

		/// <summary>Gets a value indicating whether this element has at least one attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if this element has at least one attribute; otherwise <see langword="false" />.</returns>
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004C07 File Offset: 0x00002E07
		public bool HasAttributes
		{
			get
			{
				return this.lastAttr != null;
			}
		}

		/// <summary>Gets a value indicating whether this element has at least one child element.</summary>
		/// <returns>
		///     <see langword="true" /> if this element has at least one child element; otherwise <see langword="false" />.</returns>
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004C14 File Offset: 0x00002E14
		public bool HasElements
		{
			get
			{
				XNode xnode = this.content as XNode;
				if (xnode != null)
				{
					while (!(xnode is XElement))
					{
						xnode = xnode.next;
						if (xnode == this.content)
						{
							return false;
						}
					}
					return true;
				}
				return false;
			}
		}

		/// <summary>Gets a value indicating whether this element contains no content.</summary>
		/// <returns>
		///     <see langword="true" /> if this element contains no content; otherwise <see langword="false" />.</returns>
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004C4B File Offset: 0x00002E4B
		public bool IsEmpty
		{
			get
			{
				return this.content == null;
			}
		}

		/// <summary>Gets the last attribute of this element.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that contains the last attribute of this element.</returns>
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00004C56 File Offset: 0x00002E56
		public XAttribute LastAttribute
		{
			get
			{
				return this.lastAttr;
			}
		}

		/// <summary>Gets or sets the name of this element.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> that contains the name of this element.</returns>
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004C5E File Offset: 0x00002E5E
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00004C66 File Offset: 0x00002E66
		public XName Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Name);
				this.name = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Name);
				}
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XElement" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Element" />.</returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004C9E File Offset: 0x00002E9E
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Element;
			}
		}

		/// <summary>Gets or sets the concatenated text contents of this element.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains all of the text content of this element. If there are multiple text nodes, they will be concatenated.</returns>
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004CA4 File Offset: 0x00002EA4
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00004CE5 File Offset: 0x00002EE5
		public string Value
		{
			get
			{
				if (this.content == null)
				{
					return string.Empty;
				}
				string text = this.content as string;
				if (text != null)
				{
					return text;
				}
				StringBuilder sb = StringBuilderCache.Acquire(16);
				this.AppendText(sb);
				return StringBuilderCache.GetStringAndRelease(sb);
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				base.RemoveNodes();
				base.Add(value);
			}
		}

		/// <summary>Returns a collection of elements that contain this element, and the ancestors of this element. </summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and the ancestors of this element. </returns>
		// Token: 0x060000AA RID: 170 RVA: 0x00004D02 File Offset: 0x00002F02
		public IEnumerable<XElement> AncestorsAndSelf()
		{
			return base.GetAncestors(null, true);
		}

		/// <summary>Returns a filtered collection of elements that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and the ancestors of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
		// Token: 0x060000AB RID: 171 RVA: 0x00004D0C File Offset: 0x00002F0C
		public IEnumerable<XElement> AncestorsAndSelf(XName name)
		{
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return base.GetAncestors(name, true);
		}

		/// <summary>Returns the <see cref="T:System.Xml.Linq.XAttribute" /> of this <see cref="T:System.Xml.Linq.XElement" /> that has the specified <see cref="T:System.Xml.Linq.XName" />.</summary>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the <see cref="T:System.Xml.Linq.XAttribute" /> to get.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XAttribute" /> that has the specified <see cref="T:System.Xml.Linq.XName" />; <see langword="null" /> if there is no attribute with the specified name.</returns>
		// Token: 0x060000AC RID: 172 RVA: 0x00004D28 File Offset: 0x00002F28
		public XAttribute Attribute(XName name)
		{
			XAttribute next = this.lastAttr;
			if (next != null)
			{
				for (;;)
				{
					next = next.next;
					if (next.name == name)
					{
						break;
					}
					if (next == this.lastAttr)
					{
						goto IL_2A;
					}
				}
				return next;
			}
			IL_2A:
			return null;
		}

		/// <summary>Returns a collection of attributes of this element.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> of attributes of this element.</returns>
		// Token: 0x060000AD RID: 173 RVA: 0x00004D60 File Offset: 0x00002F60
		public IEnumerable<XAttribute> Attributes()
		{
			return this.GetAttributes(null);
		}

		/// <summary>Returns a filtered collection of attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> that contains the attributes of this element. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
		// Token: 0x060000AE RID: 174 RVA: 0x00004D69 File Offset: 0x00002F69
		public IEnumerable<XAttribute> Attributes(XName name)
		{
			if (!(name != null))
			{
				return XAttribute.EmptySequence;
			}
			return this.GetAttributes(name);
		}

		/// <summary>Returns a collection of nodes that contain this element, and all descendant nodes of this element, in document order.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XNode" /> that contain this element, and all descendant nodes of this element, in document order.</returns>
		// Token: 0x060000AF RID: 175 RVA: 0x00004D81 File Offset: 0x00002F81
		public IEnumerable<XNode> DescendantNodesAndSelf()
		{
			return base.GetDescendantNodes(true);
		}

		/// <summary>Returns a collection of elements that contain this element, and all descendant elements of this element, in document order.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> of elements that contain this element, and all descendant elements of this element, in document order.</returns>
		// Token: 0x060000B0 RID: 176 RVA: 0x00004D8A File Offset: 0x00002F8A
		public IEnumerable<XElement> DescendantsAndSelf()
		{
			return base.GetDescendants(null, true);
		}

		/// <summary>Returns a filtered collection of elements that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</summary>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> to match.</param>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XElement" /> that contain this element, and all descendant elements of this element, in document order. Only elements that have a matching <see cref="T:System.Xml.Linq.XName" /> are included in the collection.</returns>
		// Token: 0x060000B1 RID: 177 RVA: 0x00004D94 File Offset: 0x00002F94
		public IEnumerable<XElement> DescendantsAndSelf(XName name)
		{
			if (!(name != null))
			{
				return XElement.EmptySequence;
			}
			return base.GetDescendants(name, true);
		}

		/// <summary>Gets the default <see cref="T:System.Xml.Linq.XNamespace" /> of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> that contains the default namespace of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		// Token: 0x060000B2 RID: 178 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public XNamespace GetDefaultNamespace()
		{
			string namespaceOfPrefixInScope = this.GetNamespaceOfPrefixInScope("xmlns", null);
			if (namespaceOfPrefixInScope == null)
			{
				return XNamespace.None;
			}
			return XNamespace.Get(namespaceOfPrefixInScope);
		}

		/// <summary>Gets the namespace associated with a particular prefix for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
		/// <param name="prefix">A string that contains the namespace prefix to look up.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XNamespace" /> for the namespace associated with the prefix for this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		// Token: 0x060000B3 RID: 179 RVA: 0x00004DDC File Offset: 0x00002FDC
		public XNamespace GetNamespaceOfPrefix(string prefix)
		{
			if (prefix == null)
			{
				throw new ArgumentNullException("prefix");
			}
			if (prefix.Length == 0)
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid prefix.", prefix));
			}
			if (prefix == "xmlns")
			{
				return XNamespace.Xmlns;
			}
			string namespaceOfPrefixInScope = this.GetNamespaceOfPrefixInScope(prefix, null);
			if (namespaceOfPrefixInScope != null)
			{
				return XNamespace.Get(namespaceOfPrefixInScope);
			}
			if (prefix == "xml")
			{
				return XNamespace.Xml;
			}
			return null;
		}

		/// <summary>Gets the prefix associated with a namespace for this <see cref="T:System.Xml.Linq.XElement" />.</summary>
		/// <param name="ns">An <see cref="T:System.Xml.Linq.XNamespace" /> to look up.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace prefix.</returns>
		// Token: 0x060000B4 RID: 180 RVA: 0x00004E4C File Offset: 0x0000304C
		public string GetPrefixOfNamespace(XNamespace ns)
		{
			if (ns == null)
			{
				throw new ArgumentNullException("ns");
			}
			string namespaceName = ns.NamespaceName;
			bool flag = false;
			XElement xelement = this;
			XAttribute next;
			for (;;)
			{
				next = xelement.lastAttr;
				if (next != null)
				{
					bool flag2 = false;
					do
					{
						next = next.next;
						if (next.IsNamespaceDeclaration)
						{
							if (next.Value == namespaceName && next.Name.NamespaceName.Length != 0 && (!flag || this.GetNamespaceOfPrefixInScope(next.Name.LocalName, xelement) == null))
							{
								goto IL_72;
							}
							flag2 = true;
						}
					}
					while (next != xelement.lastAttr);
					flag = (flag || flag2);
				}
				xelement = (xelement.parent as XElement);
				if (xelement == null)
				{
					goto Block_8;
				}
			}
			IL_72:
			return next.Name.LocalName;
			Block_8:
			if (namespaceName == "http://www.w3.org/XML/1998/namespace")
			{
				if (!flag || this.GetNamespaceOfPrefixInScope("xml", null) == null)
				{
					return "xml";
				}
			}
			else if (namespaceName == "http://www.w3.org/2000/xmlns/")
			{
				return "xmlns";
			}
			return null;
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file.</summary>
		/// <param name="uri">A URI string referencing the file to load into a new <see cref="T:System.Xml.Linq.XElement" />.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
		// Token: 0x060000B5 RID: 181 RVA: 0x00004F25 File Offset: 0x00003125
		public static XElement Load(string uri)
		{
			return XElement.Load(uri, LoadOptions.None);
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a file, optionally preserving white space, setting the base URI, and retaining line information.</summary>
		/// <param name="uri">A URI string referencing the file to load into an <see cref="T:System.Xml.Linq.XElement" />.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the contents of the specified file.</returns>
		// Token: 0x060000B6 RID: 182 RVA: 0x00004F30 File Offset: 0x00003130
		public static XElement Load(string uri, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XElement result;
			using (XmlReader xmlReader = XmlReader.Create(uri, xmlReaderSettings))
			{
				result = XElement.Load(xmlReader, options);
			}
			return result;
		}

		/// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream.</summary>
		/// <param name="stream">The stream that contains the XML data.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that is contained in the stream.</returns>
		// Token: 0x060000B7 RID: 183 RVA: 0x00004F74 File Offset: 0x00003174
		public static XElement Load(Stream stream)
		{
			return XElement.Load(stream, LoadOptions.None);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.Linq.XElement" /> instance by using the specified stream, optionally preserving white space, setting the base URI, and retaining line information.</summary>
		/// <param name="stream">The stream containing the XML data.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> object that specifies whether to load base URI and line information.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> object used to read the data that the stream contains.</returns>
		// Token: 0x060000B8 RID: 184 RVA: 0x00004F80 File Offset: 0x00003180
		public static XElement Load(Stream stream, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XElement result;
			using (XmlReader xmlReader = XmlReader.Create(stream, xmlReaderSettings))
			{
				result = XElement.Load(xmlReader, options);
			}
			return result;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004FC4 File Offset: 0x000031C4
		public static Task<XElement> LoadAsync(Stream stream, LoadOptions options, CancellationToken cancellationToken)
		{
			XElement.<LoadAsync>d__50 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XElement>.Create();
			<LoadAsync>d__.stream = stream;
			<LoadAsync>d__.options = options;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<XElement.<LoadAsync>d__50>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />. </summary>
		/// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
		// Token: 0x060000BA RID: 186 RVA: 0x00005017 File Offset: 0x00003217
		public static XElement Load(TextReader textReader)
		{
			return XElement.Load(textReader, LoadOptions.None);
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from a <see cref="T:System.IO.TextReader" />, optionally preserving white space and retaining line information. </summary>
		/// <param name="textReader">A <see cref="T:System.IO.TextReader" /> that will be read for the <see cref="T:System.Xml.Linq.XElement" /> content.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.IO.TextReader" />.</returns>
		// Token: 0x060000BB RID: 187 RVA: 0x00005020 File Offset: 0x00003220
		public static XElement Load(TextReader textReader, LoadOptions options)
		{
			XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
			XElement result;
			using (XmlReader xmlReader = XmlReader.Create(textReader, xmlReaderSettings))
			{
				result = XElement.Load(xmlReader, options);
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005064 File Offset: 0x00003264
		public static Task<XElement> LoadAsync(TextReader textReader, LoadOptions options, CancellationToken cancellationToken)
		{
			XElement.<LoadAsync>d__53 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XElement>.Create();
			<LoadAsync>d__.textReader = textReader;
			<LoadAsync>d__.options = options;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<XElement.<LoadAsync>d__53>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />. </summary>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
		// Token: 0x060000BD RID: 189 RVA: 0x000050B7 File Offset: 0x000032B7
		public static XElement Load(XmlReader reader)
		{
			return XElement.Load(reader, LoadOptions.None);
		}

		/// <summary>Loads an <see cref="T:System.Xml.Linq.XElement" /> from an <see cref="T:System.Xml.XmlReader" />, optionally preserving white space, setting the base URI, and retaining line information.</summary>
		/// <param name="reader">A <see cref="T:System.Xml.XmlReader" /> that will be read for the content of the <see cref="T:System.Xml.Linq.XElement" />.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> that contains the XML that was read from the specified <see cref="T:System.Xml.XmlReader" />.</returns>
		// Token: 0x060000BE RID: 190 RVA: 0x000050C0 File Offset: 0x000032C0
		public static XElement Load(XmlReader reader, LoadOptions options)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (reader.MoveToContent() != XmlNodeType.Element)
			{
				throw new InvalidOperationException(SR.Format("The XmlReader must be on a node of type {0} instead of a node of type {1}.", XmlNodeType.Element, reader.NodeType));
			}
			XElement result = new XElement(reader, options);
			reader.MoveToContent();
			if (!reader.EOF)
			{
				throw new InvalidOperationException("The XmlReader state should be EndOfFile after this operation.");
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005126 File Offset: 0x00003326
		public static Task<XElement> LoadAsync(XmlReader reader, LoadOptions options, CancellationToken cancellationToken)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled<XElement>(cancellationToken);
			}
			return XElement.LoadAsyncInternal(reader, options, cancellationToken);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005150 File Offset: 0x00003350
		private static Task<XElement> LoadAsyncInternal(XmlReader reader, LoadOptions options, CancellationToken cancellationToken)
		{
			XElement.<LoadAsyncInternal>d__57 <LoadAsyncInternal>d__;
			<LoadAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder<XElement>.Create();
			<LoadAsyncInternal>d__.reader = reader;
			<LoadAsyncInternal>d__.options = options;
			<LoadAsyncInternal>d__.cancellationToken = cancellationToken;
			<LoadAsyncInternal>d__.<>1__state = -1;
			<LoadAsyncInternal>d__.<>t__builder.Start<XElement.<LoadAsyncInternal>d__57>(ref <LoadAsyncInternal>d__);
			return <LoadAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML.</summary>
		/// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
		// Token: 0x060000C1 RID: 193 RVA: 0x000051A3 File Offset: 0x000033A3
		public static XElement Parse(string text)
		{
			return XElement.Parse(text, LoadOptions.None);
		}

		/// <summary>Load an <see cref="T:System.Xml.Linq.XElement" /> from a string that contains XML, optionally preserving white space and retaining line information.</summary>
		/// <param name="text">A <see cref="T:System.String" /> that contains XML.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.LoadOptions" /> that specifies white space behavior, and whether to load base URI and line information.</param>
		/// <returns>An <see cref="T:System.Xml.Linq.XElement" /> populated from the string that contains XML.</returns>
		// Token: 0x060000C2 RID: 194 RVA: 0x000051AC File Offset: 0x000033AC
		public static XElement Parse(string text, LoadOptions options)
		{
			XElement result;
			using (StringReader stringReader = new StringReader(text))
			{
				XmlReaderSettings xmlReaderSettings = XNode.GetXmlReaderSettings(options);
				using (XmlReader xmlReader = XmlReader.Create(stringReader, xmlReaderSettings))
				{
					result = XElement.Load(xmlReader, options);
				}
			}
			return result;
		}

		/// <summary>Removes nodes and attributes from this <see cref="T:System.Xml.Linq.XElement" />.</summary>
		// Token: 0x060000C3 RID: 195 RVA: 0x0000520C File Offset: 0x0000340C
		public void RemoveAll()
		{
			this.RemoveAttributes();
			base.RemoveNodes();
		}

		/// <summary>Removes the attributes of this <see cref="T:System.Xml.Linq.XElement" />.</summary>
		// Token: 0x060000C4 RID: 196 RVA: 0x0000521C File Offset: 0x0000341C
		public void RemoveAttributes()
		{
			if (base.SkipNotify())
			{
				this.RemoveAttributesSkipNotify();
				return;
			}
			while (this.lastAttr != null)
			{
				XAttribute next = this.lastAttr.next;
				base.NotifyChanging(next, XObjectChangeEventArgs.Remove);
				if (this.lastAttr == null || next != this.lastAttr.next)
				{
					throw new InvalidOperationException("This operation was corrupted by external code.");
				}
				if (next != this.lastAttr)
				{
					this.lastAttr.next = next.next;
				}
				else
				{
					this.lastAttr = null;
				}
				next.parent = null;
				next.next = null;
				base.NotifyChanged(next, XObjectChangeEventArgs.Remove);
			}
		}

		/// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
		/// <param name="content">The content that will replace the child nodes and attributes of this element.</param>
		// Token: 0x060000C5 RID: 197 RVA: 0x000052B8 File Offset: 0x000034B8
		public void ReplaceAll(object content)
		{
			content = XContainer.GetContentSnapshot(content);
			this.RemoveAll();
			base.Add(content);
		}

		/// <summary>Replaces the child nodes and the attributes of this element with the specified content.</summary>
		/// <param name="content">A parameter list of content objects.</param>
		// Token: 0x060000C6 RID: 198 RVA: 0x000052CF File Offset: 0x000034CF
		public void ReplaceAll(params object[] content)
		{
			this.ReplaceAll(content);
		}

		/// <summary>Replaces the attributes of this element with the specified content.</summary>
		/// <param name="content">The content that will replace the attributes of this element.</param>
		// Token: 0x060000C7 RID: 199 RVA: 0x000052D8 File Offset: 0x000034D8
		public void ReplaceAttributes(object content)
		{
			content = XContainer.GetContentSnapshot(content);
			this.RemoveAttributes();
			base.Add(content);
		}

		/// <summary>Replaces the attributes of this element with the specified content.</summary>
		/// <param name="content">A parameter list of content objects.</param>
		// Token: 0x060000C8 RID: 200 RVA: 0x000052EF File Offset: 0x000034EF
		public void ReplaceAttributes(params object[] content)
		{
			this.ReplaceAttributes(content);
		}

		/// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
		// Token: 0x060000C9 RID: 201 RVA: 0x000052F8 File Offset: 0x000034F8
		public void Save(Stream stream)
		{
			this.Save(stream, base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Outputs this <see cref="T:System.Xml.Linq.XElement" /> to the specified <see cref="T:System.IO.Stream" />, optionally specifying formatting behavior.</summary>
		/// <param name="stream">The stream to output this <see cref="T:System.Xml.Linq.XElement" /> to.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> object that specifies formatting behavior.</param>
		// Token: 0x060000CA RID: 202 RVA: 0x00005308 File Offset: 0x00003508
		public void Save(Stream stream, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005348 File Offset: 0x00003548
		public Task SaveAsync(Stream stream, SaveOptions options, CancellationToken cancellationToken)
		{
			XElement.<SaveAsync>d__68 <SaveAsync>d__;
			<SaveAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsync>d__.<>4__this = this;
			<SaveAsync>d__.stream = stream;
			<SaveAsync>d__.options = options;
			<SaveAsync>d__.cancellationToken = cancellationToken;
			<SaveAsync>d__.<>1__state = -1;
			<SaveAsync>d__.<>t__builder.Start<XElement.<SaveAsync>d__68>(ref <SaveAsync>d__);
			return <SaveAsync>d__.<>t__builder.Task;
		}

		/// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="textWriter">A <see cref="T:System.IO.TextWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
		// Token: 0x060000CC RID: 204 RVA: 0x000053A3 File Offset: 0x000035A3
		public void Save(TextWriter textWriter)
		{
			this.Save(textWriter, base.GetSaveOptionsFromAnnotations());
		}

		/// <summary>Serialize this element to a <see cref="T:System.IO.TextWriter" />, optionally disabling formatting.</summary>
		/// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> to output the XML to.</param>
		/// <param name="options">A <see cref="T:System.Xml.Linq.SaveOptions" /> that specifies formatting behavior.</param>
		// Token: 0x060000CD RID: 205 RVA: 0x000053B4 File Offset: 0x000035B4
		public void Save(TextWriter textWriter, SaveOptions options)
		{
			XmlWriterSettings xmlWriterSettings = XNode.GetXmlWriterSettings(options);
			using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings))
			{
				this.Save(xmlWriter);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000053F4 File Offset: 0x000035F4
		public Task SaveAsync(TextWriter textWriter, SaveOptions options, CancellationToken cancellationToken)
		{
			XElement.<SaveAsync>d__71 <SaveAsync>d__;
			<SaveAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsync>d__.<>4__this = this;
			<SaveAsync>d__.textWriter = textWriter;
			<SaveAsync>d__.options = options;
			<SaveAsync>d__.cancellationToken = cancellationToken;
			<SaveAsync>d__.<>1__state = -1;
			<SaveAsync>d__.<>t__builder.Start<XElement.<SaveAsync>d__71>(ref <SaveAsync>d__);
			return <SaveAsync>d__.<>t__builder.Task;
		}

		/// <summary>Serialize this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">A <see cref="T:System.Xml.XmlWriter" /> that the <see cref="T:System.Xml.Linq.XElement" /> will be written to.</param>
		// Token: 0x060000CF RID: 207 RVA: 0x0000544F File Offset: 0x0000364F
		public void Save(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteStartDocument();
			this.WriteTo(writer);
			writer.WriteEndDocument();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005472 File Offset: 0x00003672
		public Task SaveAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return this.SaveAsyncInternal(writer, cancellationToken);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000549C File Offset: 0x0000369C
		private Task SaveAsyncInternal(XmlWriter writer, CancellationToken cancellationToken)
		{
			XElement.<SaveAsyncInternal>d__74 <SaveAsyncInternal>d__;
			<SaveAsyncInternal>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SaveAsyncInternal>d__.<>4__this = this;
			<SaveAsyncInternal>d__.writer = writer;
			<SaveAsyncInternal>d__.cancellationToken = cancellationToken;
			<SaveAsyncInternal>d__.<>1__state = -1;
			<SaveAsyncInternal>d__.<>t__builder.Start<XElement.<SaveAsyncInternal>d__74>(ref <SaveAsyncInternal>d__);
			return <SaveAsyncInternal>d__.<>t__builder.Task;
		}

		/// <summary>Sets the value of an attribute, adds an attribute, or removes an attribute. </summary>
		/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the attribute to change.</param>
		/// <param name="value">The value to assign to the attribute. The attribute is removed if the value is <see langword="null" />. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XAttribute.Value" /> property of the attribute.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
		// Token: 0x060000D2 RID: 210 RVA: 0x000054F0 File Offset: 0x000036F0
		public void SetAttributeValue(XName name, object value)
		{
			XAttribute xattribute = this.Attribute(name);
			if (value == null)
			{
				if (xattribute != null)
				{
					this.RemoveAttribute(xattribute);
					return;
				}
			}
			else
			{
				if (xattribute != null)
				{
					xattribute.Value = XContainer.GetStringValue(value);
					return;
				}
				this.AppendAttribute(new XAttribute(name, value));
			}
		}

		/// <summary>Sets the value of a child element, adds a child element, or removes a child element.</summary>
		/// <param name="name">An <see cref="T:System.Xml.Linq.XName" /> that contains the name of the child element to change.</param>
		/// <param name="value">The value to assign to the child element. The child element is removed if the value is <see langword="null" />. Otherwise, the value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property of the child element.</param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an instance of <see cref="T:System.Xml.Linq.XObject" />.</exception>
		// Token: 0x060000D3 RID: 211 RVA: 0x00005530 File Offset: 0x00003730
		public void SetElementValue(XName name, object value)
		{
			XElement xelement = base.Element(name);
			if (value == null)
			{
				if (xelement != null)
				{
					base.RemoveNode(xelement);
					return;
				}
			}
			else
			{
				if (xelement != null)
				{
					xelement.Value = XContainer.GetStringValue(value);
					return;
				}
				base.AddNode(new XElement(name, XContainer.GetStringValue(value)));
			}
		}

		/// <summary>Sets the value of this element.</summary>
		/// <param name="value">The value to assign to this element. The value is converted to its string representation and assigned to the <see cref="P:System.Xml.Linq.XElement.Value" /> property.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="value" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="value" /> is an <see cref="T:System.Xml.Linq.XObject" />.</exception>
		// Token: 0x060000D4 RID: 212 RVA: 0x00005575 File Offset: 0x00003775
		public void SetValue(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.Value = XContainer.GetStringValue(value);
		}

		/// <summary>Write this element to an <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">An <see cref="T:System.Xml.XmlWriter" /> into which this method will write.</param>
		// Token: 0x060000D5 RID: 213 RVA: 0x00005594 File Offset: 0x00003794
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			new ElementWriter(writer).WriteElement(this);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000055C0 File Offset: 0x000037C0
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
			return new ElementWriter(writer).WriteElementAsync(this, cancellationToken);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.String" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.String" />.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		// Token: 0x060000D7 RID: 215 RVA: 0x000055FB File Offset: 0x000037FB
		[CLSCompliant(false)]
		public static explicit operator string(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return element.Value;
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Boolean" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Boolean" />.</param>
		/// <returns>A <see cref="T:System.Boolean" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Boolean" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000D8 RID: 216 RVA: 0x00005608 File Offset: 0x00003808
		[CLSCompliant(false)]
		public static explicit operator bool(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToBoolean(element.Value.ToLowerInvariant());
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Boolean" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Boolean" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Boolean" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Boolean" /> value.</exception>
		// Token: 0x060000D9 RID: 217 RVA: 0x00005628 File Offset: 0x00003828
		[CLSCompliant(false)]
		public static explicit operator bool?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new bool?(XmlConvert.ToBoolean(element.Value.ToLowerInvariant()));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to an <see cref="T:System.Int32" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Int32" />.</param>
		/// <returns>A <see cref="T:System.Int32" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Int32" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000DA RID: 218 RVA: 0x00005657 File Offset: 0x00003857
		[CLSCompliant(false)]
		public static explicit operator int(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToInt32(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int32" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int32" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int32" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Int32" /> value.</exception>
		// Token: 0x060000DB RID: 219 RVA: 0x00005674 File Offset: 0x00003874
		[CLSCompliant(false)]
		public static explicit operator int?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new int?(XmlConvert.ToInt32(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.UInt32" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.UInt32" />.</param>
		/// <returns>A <see cref="T:System.UInt32" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.UInt32" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000DC RID: 220 RVA: 0x0000569E File Offset: 0x0000389E
		[CLSCompliant(false)]
		public static explicit operator uint(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToUInt32(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt32" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt32" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt32" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.UInt32" /> value.</exception>
		// Token: 0x060000DD RID: 221 RVA: 0x000056BC File Offset: 0x000038BC
		[CLSCompliant(false)]
		public static explicit operator uint?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new uint?(XmlConvert.ToUInt32(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to an <see cref="T:System.Int64" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Int64" />.</param>
		/// <returns>A <see cref="T:System.Int64" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Int64" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000DE RID: 222 RVA: 0x000056E6 File Offset: 0x000038E6
		[CLSCompliant(false)]
		public static explicit operator long(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToInt64(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int64" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int64" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Int64" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Int64" /> value.</exception>
		// Token: 0x060000DF RID: 223 RVA: 0x00005704 File Offset: 0x00003904
		[CLSCompliant(false)]
		public static explicit operator long?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new long?(XmlConvert.ToInt64(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.UInt64" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.UInt64" />.</param>
		/// <returns>A <see cref="T:System.UInt64" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.UInt64" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000E0 RID: 224 RVA: 0x0000572E File Offset: 0x0000392E
		[CLSCompliant(false)]
		public static explicit operator ulong(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToUInt64(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt64" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt64" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.UInt64" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.UInt64" /> value.</exception>
		// Token: 0x060000E1 RID: 225 RVA: 0x0000574C File Offset: 0x0000394C
		[CLSCompliant(false)]
		public static explicit operator ulong?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new ulong?(XmlConvert.ToUInt64(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Single" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Single" />.</param>
		/// <returns>A <see cref="T:System.Single" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Single" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000E2 RID: 226 RVA: 0x00005776 File Offset: 0x00003976
		[CLSCompliant(false)]
		public static explicit operator float(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToSingle(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Single" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Single" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Single" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Single" /> value.</exception>
		// Token: 0x060000E3 RID: 227 RVA: 0x00005794 File Offset: 0x00003994
		[CLSCompliant(false)]
		public static explicit operator float?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new float?(XmlConvert.ToSingle(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Double" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Double" />.</param>
		/// <returns>A <see cref="T:System.Double" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Double" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000E4 RID: 228 RVA: 0x000057BE File Offset: 0x000039BE
		[CLSCompliant(false)]
		public static explicit operator double(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToDouble(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Double" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Double" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Double" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Double" /> value.</exception>
		// Token: 0x060000E5 RID: 229 RVA: 0x000057DC File Offset: 0x000039DC
		[CLSCompliant(false)]
		public static explicit operator double?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new double?(XmlConvert.ToDouble(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Decimal" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Decimal" />.</param>
		/// <returns>A <see cref="T:System.Decimal" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Decimal" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000E6 RID: 230 RVA: 0x00005806 File Offset: 0x00003A06
		[CLSCompliant(false)]
		public static explicit operator decimal(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToDecimal(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Decimal" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Decimal" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Decimal" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Decimal" /> value.</exception>
		// Token: 0x060000E7 RID: 231 RVA: 0x00005824 File Offset: 0x00003A24
		[CLSCompliant(false)]
		public static explicit operator decimal?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new decimal?(XmlConvert.ToDecimal(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.DateTime" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.DateTime" />.</param>
		/// <returns>A <see cref="T:System.DateTime" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.DateTime" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000E8 RID: 232 RVA: 0x0000584E File Offset: 0x00003A4E
		[CLSCompliant(false)]
		public static explicit operator DateTime(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return DateTime.Parse(element.Value, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTime" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTime" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTime" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.DateTime" /> value.</exception>
		// Token: 0x060000E9 RID: 233 RVA: 0x00005874 File Offset: 0x00003A74
		[CLSCompliant(false)]
		public static explicit operator DateTime?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new DateTime?(DateTime.Parse(element.Value, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XAttribute" /> to a <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>A <see cref="T:System.DateTimeOffset" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.DateTimeOffset" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000EA RID: 234 RVA: 0x000058A8 File Offset: 0x00003AA8
		[CLSCompliant(false)]
		public static explicit operator DateTimeOffset(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToDateTimeOffset(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to an <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTimeOffset" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.DateTimeOffset" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.DateTimeOffset" /> value.</exception>
		// Token: 0x060000EB RID: 235 RVA: 0x000058C4 File Offset: 0x00003AC4
		[CLSCompliant(false)]
		public static explicit operator DateTimeOffset?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new DateTimeOffset?(XmlConvert.ToDateTimeOffset(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.TimeSpan" />.</param>
		/// <returns>A <see cref="T:System.TimeSpan" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.TimeSpan" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000EC RID: 236 RVA: 0x000058EE File Offset: 0x00003AEE
		[CLSCompliant(false)]
		public static explicit operator TimeSpan(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToTimeSpan(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.TimeSpan" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.TimeSpan" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.TimeSpan" /> value.</exception>
		// Token: 0x060000ED RID: 237 RVA: 0x0000590C File Offset: 0x00003B0C
		[CLSCompliant(false)]
		public static explicit operator TimeSpan?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new TimeSpan?(XmlConvert.ToTimeSpan(element.Value));
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Guid" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Guid" />.</param>
		/// <returns>A <see cref="T:System.Guid" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Guid" /> value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="element" /> parameter is <see langword="null" />.</exception>
		// Token: 0x060000EE RID: 238 RVA: 0x00005936 File Offset: 0x00003B36
		[CLSCompliant(false)]
		public static explicit operator Guid(XElement element)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			return XmlConvert.ToGuid(element.Value);
		}

		/// <summary>Cast the value of this <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:System.Nullable`1" /> of <see cref="T:System.Guid" />.</summary>
		/// <param name="element">The <see cref="T:System.Xml.Linq.XElement" /> to cast to <see cref="T:System.Nullable`1" /> of <see cref="T:System.Guid" />.</param>
		/// <returns>A <see cref="T:System.Nullable`1" /> of <see cref="T:System.Guid" /> that contains the content of this <see cref="T:System.Xml.Linq.XElement" />.</returns>
		/// <exception cref="T:System.FormatException">The element does not contain a valid <see cref="T:System.Guid" /> value.</exception>
		// Token: 0x060000EF RID: 239 RVA: 0x00005954 File Offset: 0x00003B54
		[CLSCompliant(false)]
		public static explicit operator Guid?(XElement element)
		{
			if (element == null)
			{
				return null;
			}
			return new Guid?(XmlConvert.ToGuid(element.Value));
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00005980 File Offset: 0x00003B80
		private static object ConvertForAssignment(object value)
		{
			XmlNode xmlNode = value as XmlNode;
			if (xmlNode == null)
			{
				return value;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.AppendChild(xmlDocument.ImportNode(xmlNode, true));
			return XElement.Parse(xmlDocument.InnerXml);
		}

		/// <summary>Gets an XML schema definition that describes the XML representation of this object.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchema" /> that describes the XML representation of the object that is produced by the <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> method and consumed by the <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" /> method.</returns>
		// Token: 0x060000F1 RID: 241 RVA: 0x000059B7 File Offset: 0x00003BB7
		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		/// <summary>Generates an object from its XML representation.</summary>
		/// <param name="reader">The <see cref="T:System.Xml.XmlReader" /> from which the object is deserialized.</param>
		// Token: 0x060000F2 RID: 242 RVA: 0x000059BC File Offset: 0x00003BBC
		void IXmlSerializable.ReadXml(XmlReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (this.parent != null || this.annotations != null || this.content != null || this.lastAttr != null)
			{
				throw new InvalidOperationException("This instance cannot be deserialized.");
			}
			if (reader.MoveToContent() != XmlNodeType.Element)
			{
				throw new InvalidOperationException(SR.Format("The XmlReader must be on a node of type {0} instead of a node of type {1}.", XmlNodeType.Element, reader.NodeType));
			}
			this.ReadElementFrom(reader, LoadOptions.None);
		}

		/// <summary>Converts an object into its XML representation.</summary>
		/// <param name="writer">The <see cref="T:System.Xml.XmlWriter" /> to which this object is serialized.</param>
		// Token: 0x060000F3 RID: 243 RVA: 0x00005A34 File Offset: 0x00003C34
		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
			this.WriteTo(writer);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005A3D File Offset: 0x00003C3D
		internal override void AddAttribute(XAttribute a)
		{
			if (this.Attribute(a.Name) != null)
			{
				throw new InvalidOperationException("Duplicate attribute.");
			}
			if (a.parent != null)
			{
				a = new XAttribute(a);
			}
			this.AppendAttribute(a);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005A6F File Offset: 0x00003C6F
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			if (this.Attribute(a.Name) != null)
			{
				throw new InvalidOperationException("Duplicate attribute.");
			}
			if (a.parent != null)
			{
				a = new XAttribute(a);
			}
			this.AppendAttributeSkipNotify(a);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005AA1 File Offset: 0x00003CA1
		internal void AppendAttribute(XAttribute a)
		{
			bool flag = base.NotifyChanging(a, XObjectChangeEventArgs.Add);
			if (a.parent != null)
			{
				throw new InvalidOperationException("This operation was corrupted by external code.");
			}
			this.AppendAttributeSkipNotify(a);
			if (flag)
			{
				base.NotifyChanged(a, XObjectChangeEventArgs.Add);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005AD8 File Offset: 0x00003CD8
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
			a.parent = this;
			if (this.lastAttr == null)
			{
				a.next = a;
			}
			else
			{
				a.next = this.lastAttr.next;
				this.lastAttr.next = a;
			}
			this.lastAttr = a;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005B18 File Offset: 0x00003D18
		private bool AttributesEqual(XElement e)
		{
			XAttribute next = this.lastAttr;
			XAttribute next2 = e.lastAttr;
			if (next != null && next2 != null)
			{
				for (;;)
				{
					next = next.next;
					next2 = next2.next;
					if (next.name != next2.name || next.value != next2.value)
					{
						break;
					}
					if (next == this.lastAttr)
					{
						goto Block_3;
					}
				}
				return false;
				Block_3:
				return next2 == e.lastAttr;
			}
			return next == null && next2 == null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005B8B File Offset: 0x00003D8B
		internal override XNode CloneNode()
		{
			return new XElement(this);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005B94 File Offset: 0x00003D94
		internal override bool DeepEquals(XNode node)
		{
			XElement xelement = node as XElement;
			return xelement != null && this.name == xelement.name && base.ContentsEqual(xelement) && this.AttributesEqual(xelement);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005BD0 File Offset: 0x00003DD0
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			XAttribute a = this.lastAttr;
			if (a != null)
			{
				do
				{
					a = a.next;
					if (name == null || a.name == name)
					{
						yield return a;
					}
				}
				while (a.parent == this && a != this.lastAttr);
			}
			yield break;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005BE8 File Offset: 0x00003DE8
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			for (XElement xelement = this; xelement != outOfScope; xelement = (xelement.parent as XElement))
			{
				XAttribute next = xelement.lastAttr;
				if (next != null)
				{
					for (;;)
					{
						next = next.next;
						if (next.IsNamespaceDeclaration && next.Name.LocalName == prefix)
						{
							break;
						}
						if (next == xelement.lastAttr)
						{
							goto IL_40;
						}
					}
					return next.Value;
				}
				IL_40:;
			}
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005C48 File Offset: 0x00003E48
		internal override int GetDeepHashCode()
		{
			int num = this.name.GetHashCode();
			num ^= base.ContentsHashCode();
			XAttribute next = this.lastAttr;
			if (next != null)
			{
				do
				{
					next = next.next;
					num ^= next.GetDeepHashCode();
				}
				while (next != this.lastAttr);
			}
			return num;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005C8E File Offset: 0x00003E8E
		private void ReadElementFrom(XmlReader r, LoadOptions o)
		{
			this.ReadElementFromImpl(r, o);
			if (!r.IsEmptyElement)
			{
				r.Read();
				base.ReadContentFrom(r, o);
			}
			r.Read();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005CB8 File Offset: 0x00003EB8
		private Task ReadElementFromAsync(XmlReader r, LoadOptions o, CancellationToken cancellationTokentoken)
		{
			XElement.<ReadElementFromAsync>d__120 <ReadElementFromAsync>d__;
			<ReadElementFromAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ReadElementFromAsync>d__.<>4__this = this;
			<ReadElementFromAsync>d__.r = r;
			<ReadElementFromAsync>d__.o = o;
			<ReadElementFromAsync>d__.cancellationTokentoken = cancellationTokentoken;
			<ReadElementFromAsync>d__.<>1__state = -1;
			<ReadElementFromAsync>d__.<>t__builder.Start<XElement.<ReadElementFromAsync>d__120>(ref <ReadElementFromAsync>d__);
			return <ReadElementFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005D14 File Offset: 0x00003F14
		private void ReadElementFromImpl(XmlReader r, LoadOptions o)
		{
			if (r.ReadState != ReadState.Interactive)
			{
				throw new InvalidOperationException("The XmlReader state should be Interactive.");
			}
			this.name = XNamespace.Get(r.NamespaceURI).GetName(r.LocalName);
			if ((o & LoadOptions.SetBaseUri) != LoadOptions.None)
			{
				string baseURI = r.BaseURI;
				if (!string.IsNullOrEmpty(baseURI))
				{
					base.SetBaseUri(baseURI);
				}
			}
			IXmlLineInfo xmlLineInfo = null;
			if ((o & LoadOptions.SetLineInfo) != LoadOptions.None)
			{
				xmlLineInfo = (r as IXmlLineInfo);
				if (xmlLineInfo != null && xmlLineInfo.HasLineInfo())
				{
					base.SetLineInfo(xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
				}
			}
			if (r.MoveToFirstAttribute())
			{
				do
				{
					XAttribute xattribute = new XAttribute(XNamespace.Get((r.Prefix.Length == 0) ? string.Empty : r.NamespaceURI).GetName(r.LocalName), r.Value);
					if (xmlLineInfo != null && xmlLineInfo.HasLineInfo())
					{
						xattribute.SetLineInfo(xmlLineInfo.LineNumber, xmlLineInfo.LinePosition);
					}
					this.AppendAttributeSkipNotify(xattribute);
				}
				while (r.MoveToNextAttribute());
				r.MoveToElement();
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005E08 File Offset: 0x00004008
		internal void RemoveAttribute(XAttribute a)
		{
			bool flag = base.NotifyChanging(a, XObjectChangeEventArgs.Remove);
			if (a.parent != this)
			{
				throw new InvalidOperationException("This operation was corrupted by external code.");
			}
			XAttribute xattribute = this.lastAttr;
			XAttribute next;
			while ((next = xattribute.next) != a)
			{
				xattribute = next;
			}
			if (xattribute == a)
			{
				this.lastAttr = null;
			}
			else
			{
				if (this.lastAttr == a)
				{
					this.lastAttr = xattribute;
				}
				xattribute.next = a.next;
			}
			a.parent = null;
			a.next = null;
			if (flag)
			{
				base.NotifyChanged(a, XObjectChangeEventArgs.Remove);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00005E94 File Offset: 0x00004094
		private void RemoveAttributesSkipNotify()
		{
			if (this.lastAttr != null)
			{
				XAttribute xattribute = this.lastAttr;
				do
				{
					XAttribute next = xattribute.next;
					xattribute.parent = null;
					xattribute.next = null;
					xattribute = next;
				}
				while (xattribute != this.lastAttr);
				this.lastAttr = null;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005ED7 File Offset: 0x000040D7
		internal void SetEndElementLineInfo(int lineNumber, int linePosition)
		{
			base.AddAnnotation(new LineInfoEndElementAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005EE6 File Offset: 0x000040E6
		internal override void ValidateNode(XNode node, XNode previous)
		{
			if (node is XDocument)
			{
				throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.Document));
			}
			if (node is XDocumentType)
			{
				throw new ArgumentException(SR.Format("A node of type {0} cannot be added to content.", XmlNodeType.DocumentType));
			}
		}

		// Token: 0x04000049 RID: 73
		internal XName name;

		// Token: 0x0400004A RID: 74
		internal XAttribute lastAttr;

		// Token: 0x02000016 RID: 22
		private struct AsyncConstructionSentry
		{
		}
	}
}
