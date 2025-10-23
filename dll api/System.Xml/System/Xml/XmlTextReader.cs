using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace System.Xml
{
	/// <summary>Represents a reader that provides fast, non-cached, forward-only access to XML data.Starting with the .NET Framework 2.0, we recommend that you use the <see cref="T:System.Xml.XmlReader" /> class instead.</summary>
	// Token: 0x0200007A RID: 122
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified stream.</summary>
		/// <param name="input">The stream containing the XML data to read. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="input" /> is <see langword="null" />. </exception>
		// Token: 0x0600049F RID: 1183 RVA: 0x0001696D File Offset: 0x00014B6D
		public XmlTextReader(Stream input)
		{
			this.impl = new XmlTextReaderImpl(input);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified URL, stream and <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="url">The URL to use for resolving external resources. The <see cref="P:System.Xml.XmlTextReader.BaseURI" /> is set to this value. If <paramref name="url" /> is <see langword="null" />, <see langword="BaseURI" /> is set to <see langword="String.Empty" />. </param>
		/// <param name="input">The stream containing the XML data to read. </param>
		/// <param name="nt">The <see langword="XmlNameTable" /> to use. </param>
		/// <exception cref="T:System.NullReferenceException">The <paramref name="input" /> or <paramref name="nt" /> value is <see langword="null" />. </exception>
		// Token: 0x060004A0 RID: 1184 RVA: 0x0001698D File Offset: 0x00014B8D
		public XmlTextReader(string url, Stream input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(url, input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="input">The <see langword="TextReader" /> containing the XML data to read. </param>
		// Token: 0x060004A1 RID: 1185 RVA: 0x000169AF File Offset: 0x00014BAF
		public XmlTextReader(TextReader input)
		{
			this.impl = new XmlTextReaderImpl(input);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified <see cref="T:System.IO.TextReader" /> and <see cref="T:System.Xml.XmlNameTable" />.</summary>
		/// <param name="input">The <see langword="TextReader" /> containing the XML data to read. </param>
		/// <param name="nt">The <see langword="XmlNameTable" /> to use. </param>
		/// <exception cref="T:System.NullReferenceException">The <paramref name="nt" /> value is <see langword="null" />. </exception>
		// Token: 0x060004A2 RID: 1186 RVA: 0x000169CF File Offset: 0x00014BCF
		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified stream, <see cref="T:System.Xml.XmlNodeType" />, and <see cref="T:System.Xml.XmlParserContext" />.</summary>
		/// <param name="xmlFragment">The stream containing the XML fragment to parse. </param>
		/// <param name="fragType">The <see cref="T:System.Xml.XmlNodeType" /> of the XML fragment. This also determines what the fragment can contain. (See table below.) </param>
		/// <param name="context">The <see cref="T:System.Xml.XmlParserContext" /> in which the <paramref name="xmlFragment" /> is to be parsed. This includes the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang, and the xml:space scope. </param>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="fragType" /> is not an Element, Attribute, or Document <see langword="XmlNodeType" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="xmlFragment" /> is <see langword="null" />. </exception>
		// Token: 0x060004A3 RID: 1187 RVA: 0x000169F0 File Offset: 0x00014BF0
		public XmlTextReader(Stream xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			this.impl = new XmlTextReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified string, <see cref="T:System.Xml.XmlNodeType" />, and <see cref="T:System.Xml.XmlParserContext" />.</summary>
		/// <param name="xmlFragment">The string containing the XML fragment to parse. </param>
		/// <param name="fragType">The <see cref="T:System.Xml.XmlNodeType" /> of the XML fragment. This also determines what the fragment string can contain. (See table below.) </param>
		/// <param name="context">The <see cref="T:System.Xml.XmlParserContext" /> in which the <paramref name="xmlFragment" /> is to be parsed. This includes the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang, and the xml:space scope. </param>
		/// <exception cref="T:System.Xml.XmlException">
		///         <paramref name="fragType" /> is not an <see langword="Element" />, <see langword="Attribute" />, or <see langword="Document" /><see langword="XmlNodeType" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="xmlFragment" /> is <see langword="null" />. </exception>
		// Token: 0x060004A4 RID: 1188 RVA: 0x00016A12 File Offset: 0x00014C12
		public XmlTextReader(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			this.impl = new XmlTextReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XmlTextReader" /> class with the specified file.</summary>
		/// <param name="url">The URL for the file containing the XML data. The <see cref="P:System.Xml.XmlTextReader.BaseURI" /> is set to this value. </param>
		/// <exception cref="T:System.IO.FileNotFoundException">The specified file cannot be found.</exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Part of the filename or directory cannot be found.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///         <paramref name="url" /> is an empty string.</exception>
		/// <exception cref="T:System.Net.WebException">The remote filename cannot be resolved.-or-An error occurred while processing the request.</exception>
		/// <exception cref="T:System.UriFormatException">
		///         <paramref name="url" /> is not a valid URI.</exception>
		// Token: 0x060004A5 RID: 1189 RVA: 0x00016A34 File Offset: 0x00014C34
		public XmlTextReader(string url)
		{
			this.impl = new XmlTextReaderImpl(url, new NameTable());
			this.impl.OuterReader = this;
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00016A59 File Offset: 0x00014C59
		public override XmlNodeType NodeType
		{
			get
			{
				return this.impl.NodeType;
			}
		}

		/// <summary>Gets the qualified name of the current node.</summary>
		/// <returns>The qualified name of the current node. For example, <see langword="Name" /> is <see langword="bk:book" /> for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlTextReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node Type Name 
		///             <see langword="Attribute" />
		///           The name of the attribute. 
		///             <see langword="DocumentType" />
		///           The document type name. 
		///             <see langword="Element" />
		///           The tag name. 
		///             <see langword="EntityReference" />
		///           The name of the entity referenced. 
		///             <see langword="ProcessingInstruction" />
		///           The target of the processing instruction. 
		///             <see langword="XmlDeclaration" />
		///           The literal string <see langword="xml" />. </returns>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00016A66 File Offset: 0x00014C66
		public override string Name
		{
			get
			{
				return this.impl.Name;
			}
		}

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns <see langword="String.Empty" />.</returns>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00016A73 File Offset: 0x00014C73
		public override string LocalName
		{
			get
			{
				return this.impl.LocalName;
			}
		}

		/// <summary>Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00016A80 File Offset: 0x00014C80
		public override string NamespaceURI
		{
			get
			{
				return this.impl.NamespaceURI;
			}
		}

		/// <summary>Gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00016A8D File Offset: 0x00014C8D
		public override string Prefix
		{
			get
			{
				return this.impl.Prefix;
			}
		}

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlTextReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return <see langword="String.Empty" />.Node Type Value 
		///             <see langword="Attribute" />
		///           The value of the attribute. 
		///             <see langword="CDATA" />
		///           The content of the CDATA section. 
		///             <see langword="Comment" />
		///           The content of the comment. 
		///             <see langword="DocumentType" />
		///           The internal subset. 
		///             <see langword="ProcessingInstruction" />
		///           The entire content, excluding the target. 
		///             <see langword="SignificantWhitespace" />
		///           The white space within an <see langword="xml:space" />= 'preserve' scope. 
		///             <see langword="Text" />
		///           The content of the text node. 
		///             <see langword="Whitespace" />
		///           The white space between markup. 
		///             <see langword="XmlDeclaration" />
		///           The content of the declaration. </returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00016A9A File Offset: 0x00014C9A
		public override string Value
		{
			get
			{
				return this.impl.Value;
			}
		}

		/// <summary>Gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00016AA7 File Offset: 0x00014CA7
		public override int Depth
		{
			get
			{
				return this.impl.Depth;
			}
		}

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00016AB4 File Offset: 0x00014CB4
		public override string BaseURI
		{
			get
			{
				return this.impl.BaseURI;
			}
		}

		/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlTextReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) that ends with /&gt;; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00016AC1 File Offset: 0x00014CC1
		public override bool IsEmptyElement
		{
			get
			{
				return this.impl.IsEmptyElement;
			}
		}

		/// <summary>Gets a value indicating whether the current node is an attribute that was generated from the default value defined in the DTD or schema.</summary>
		/// <returns>This property always returns <see langword="false" />. (<see cref="T:System.Xml.XmlTextReader" /> does not expand default attributes.) </returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00016ACE File Offset: 0x00014CCE
		public override bool IsDefault
		{
			get
			{
				return this.impl.IsDefault;
			}
		}

		/// <summary>Gets the quotation mark character used to enclose the value of an attribute node.</summary>
		/// <returns>The quotation mark character (" or ') used to enclose the value of an attribute node.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00016ADB File Offset: 0x00014CDB
		public override char QuoteChar
		{
			get
			{
				return this.impl.QuoteChar;
			}
		}

		/// <summary>Gets the current <see langword="xml:space" /> scope.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no <see langword="xml:space" /> scope exists, this property defaults to <see langword="XmlSpace.None" />.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00016AE8 File Offset: 0x00014CE8
		public override XmlSpace XmlSpace
		{
			get
			{
				return this.impl.XmlSpace;
			}
		}

		/// <summary>Gets the current <see langword="xml:lang" /> scope.</summary>
		/// <returns>The current <see langword="xml:lang" /> scope.</returns>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00016AF5 File Offset: 0x00014CF5
		public override string XmlLang
		{
			get
			{
				return this.impl.XmlLang;
			}
		}

		/// <summary>Gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node.</returns>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00016B02 File Offset: 0x00014D02
		public override int AttributeCount
		{
			get
			{
				return this.impl.AttributeCount;
			}
		}

		/// <summary>Gets the value of the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
		// Token: 0x060004B4 RID: 1204 RVA: 0x00016B0F File Offset: 0x00014D0F
		public override string GetAttribute(string name)
		{
			return this.impl.GetAttribute(name);
		}

		/// <summary>Gets the value of the attribute with the specified local name and namespace URI.</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned. This method does not move the reader.</returns>
		// Token: 0x060004B5 RID: 1205 RVA: 0x00016B1D File Offset: 0x00014D1D
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return this.impl.GetAttribute(localName, namespaceURI);
		}

		/// <summary>Gets the value of the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
		/// <returns>The value of the specified attribute.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlTextReader.AttributeCount" />. </exception>
		// Token: 0x060004B6 RID: 1206 RVA: 0x00016B2C File Offset: 0x00014D2C
		public override string GetAttribute(int i)
		{
			return this.impl.GetAttribute(i);
		}

		/// <summary>Moves to the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>
		///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the reader's position does not change.</returns>
		// Token: 0x060004B7 RID: 1207 RVA: 0x00016B3A File Offset: 0x00014D3A
		public override bool MoveToAttribute(string name)
		{
			return this.impl.MoveToAttribute(name);
		}

		/// <summary>Moves to the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlReader.AttributeCount" />. </exception>
		// Token: 0x060004B8 RID: 1208 RVA: 0x00016B48 File Offset: 0x00014D48
		public override void MoveToAttribute(int i)
		{
			this.impl.MoveToAttribute(i);
		}

		/// <summary>Moves to the first attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
		// Token: 0x060004B9 RID: 1209 RVA: 0x00016B56 File Offset: 0x00014D56
		public override bool MoveToFirstAttribute()
		{
			return this.impl.MoveToFirstAttribute();
		}

		/// <summary>Moves to the next attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
		// Token: 0x060004BA RID: 1210 RVA: 0x00016B63 File Offset: 0x00014D63
		public override bool MoveToNextAttribute()
		{
			return this.impl.MoveToNextAttribute();
		}

		/// <summary>Moves to the element that contains the current attribute node.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
		// Token: 0x060004BB RID: 1211 RVA: 0x00016B70 File Offset: 0x00014D70
		public override bool MoveToElement()
		{
			return this.impl.MoveToElement();
		}

		/// <summary>Parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
		/// <returns>
		///     <see langword="true" /> if there are nodes to return.
		///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of <see langword="String.Empty" />.</returns>
		// Token: 0x060004BC RID: 1212 RVA: 0x00016B7D File Offset: 0x00014D7D
		public override bool ReadAttributeValue()
		{
			return this.impl.ReadAttributeValue();
		}

		/// <summary>Reads the next node from the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the next node was read successfully; <see langword="false" /> if there are no more nodes to read.</returns>
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML. </exception>
		// Token: 0x060004BD RID: 1213 RVA: 0x00016B8A File Offset: 0x00014D8A
		public override bool Read()
		{
			return this.impl.Read();
		}

		/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00016B97 File Offset: 0x00014D97
		public override bool EOF
		{
			get
			{
				return this.impl.EOF;
			}
		}

		/// <summary>Changes the <see cref="P:System.Xml.XmlReader.ReadState" /> to <see langword="Closed" />.</summary>
		// Token: 0x060004BF RID: 1215 RVA: 0x00016BA4 File Offset: 0x00014DA4
		public override void Close()
		{
			this.impl.Close();
		}

		/// <summary>Gets the state of the reader.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00016BB1 File Offset: 0x00014DB1
		public override ReadState ReadState
		{
			get
			{
				return this.impl.ReadState;
			}
		}

		/// <summary>Skips the children of the current node.</summary>
		// Token: 0x060004C1 RID: 1217 RVA: 0x00016BBE File Offset: 0x00014DBE
		public override void Skip()
		{
			this.impl.Skip();
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>The <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the node.</returns>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00016BCB File Offset: 0x00014DCB
		public override XmlNameTable NameTable
		{
			get
			{
				return this.impl.NameTable;
			}
		}

		/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. This string does not have to be atomized. </param>
		/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Xml.XmlTextReader.Namespaces" /> property is set to <see langword="true" /> and the <paramref name="prefix" /> value is <see langword="null" />. </exception>
		// Token: 0x060004C3 RID: 1219 RVA: 0x00016BD8 File Offset: 0x00014DD8
		public override string LookupNamespace(string prefix)
		{
			string text = this.impl.LookupNamespace(prefix);
			if (text != null && text.Length == 0)
			{
				text = null;
			}
			return text;
		}

		/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader can parse and resolve entities; otherwise, <see langword="false" />. The <see langword="XmlTextReader" /> class always returns <see langword="true" />.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		/// <summary>Resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
		// Token: 0x060004C5 RID: 1221 RVA: 0x00016C00 File Offset: 0x00014E00
		public override void ResolveEntity()
		{
			this.impl.ResolveEntity();
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlTextReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.XmlTextReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method; otherwise <see langword="false" />. The <see cref="T:System.Xml.XmlTextReader" /> class always returns <see langword="false" />.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000A216 File Offset: 0x00008416
		public override bool CanReadValueChunk
		{
			get
			{
				return false;
			}
		}

		/// <summary>Reads the contents of an element or a text node as a string.</summary>
		/// <returns>The contents of the element or text node. This can be an empty string if the reader is positioned on something other than an element or text node, or if there is no more text content to return in the current context.
		///     <see langword="Note:" /> The text node can be either an element or an attribute text node.</returns>
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML. </exception>
		/// <exception cref="T:System.InvalidOperationException">An invalid operation was attempted. </exception>
		// Token: 0x060004C7 RID: 1223 RVA: 0x00016C0D File Offset: 0x00014E0D
		public override string ReadString()
		{
			this.impl.MoveOffEntityReference();
			return base.ReadString();
		}

		/// <summary>Gets a value indicating whether the class can return line information.</summary>
		/// <returns>
		///     <see langword="true" /> if the class can return line information; otherwise, <see langword="false" />.</returns>
		// Token: 0x060004C8 RID: 1224 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public bool HasLineInfo()
		{
			return true;
		}

		/// <summary>Gets the current line number.</summary>
		/// <returns>The current line number.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00016C20 File Offset: 0x00014E20
		public int LineNumber
		{
			get
			{
				return this.impl.LineNumber;
			}
		}

		/// <summary>Gets the current line position.</summary>
		/// <returns>The current line position.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00016C2D File Offset: 0x00014E2D
		public int LinePosition
		{
			get
			{
				return this.impl.LinePosition;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.</summary>
		/// <param name="scope">An <see cref="T:System.Xml.XmlNamespaceScope" /> value that specifies the type of namespace nodes to return.</param>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> that contains the current in-scope namespaces.</returns>
		// Token: 0x060004CB RID: 1227 RVA: 0x00016C3A File Offset: 0x00014E3A
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.impl.GetNamespacesInScope(scope);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.</summary>
		/// <param name="prefix">The prefix whose namespace URI you wish to find.</param>
		/// <returns>The namespace URI that is mapped to the prefix; <see langword="null" /> if the prefix is not mapped to a namespace URI.</returns>
		// Token: 0x060004CC RID: 1228 RVA: 0x00016C48 File Offset: 0x00014E48
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.impl.LookupNamespace(prefix);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.</summary>
		/// <param name="namespaceName">The namespace URI whose prefix you wish to find.</param>
		/// <returns>The prefix that is mapped to the namespace URI; <see langword="null" /> if the namespace URI is not mapped to a prefix.</returns>
		// Token: 0x060004CD RID: 1229 RVA: 0x00016C56 File Offset: 0x00014E56
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.impl.LookupPrefix(namespaceName);
		}

		/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
		/// <returns>
		///     <see langword="true" /> to do namespace support; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting this property after a read operation has occurred (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is not <see langword="ReadState.Initial" />). </exception>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00016C64 File Offset: 0x00014E64
		public bool Namespaces
		{
			get
			{
				return this.impl.Namespaces;
			}
		}

		/// <summary>Gets or sets a value indicating whether to normalize white space and attribute values.</summary>
		/// <returns>
		///     <see langword="true" /> to normalize; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Setting this property when the reader is closed (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is <see langword="ReadState.Closed" />). </exception>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00016C71 File Offset: 0x00014E71
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00016C7E File Offset: 0x00014E7E
		public bool Normalization
		{
			get
			{
				return this.impl.Normalization;
			}
			set
			{
				this.impl.Normalization = value;
			}
		}

		/// <summary>Gets or sets a value that specifies how white space is handled.</summary>
		/// <returns>One of the <see cref="T:System.Xml.WhitespaceHandling" /> values. The default is <see langword="WhitespaceHandling.All" /> (returns <see langword="Whitespace" /> and <see langword="SignificantWhitespace" /> nodes).</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Invalid value specified. </exception>
		/// <exception cref="T:System.InvalidOperationException">Setting this property when the reader is closed (<see cref="P:System.Xml.XmlTextReader.ReadState" /> is <see langword="ReadState.Closed" />). </exception>
		// Token: 0x170000D3 RID: 211
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00016C8C File Offset: 0x00014E8C
		public WhitespaceHandling WhitespaceHandling
		{
			set
			{
				this.impl.WhitespaceHandling = value;
			}
		}

		/// <summary>Gets or sets a value that specifies how the reader handles entities.</summary>
		/// <returns>One of the <see cref="T:System.Xml.EntityHandling" /> values. If no <see langword="EntityHandling" /> is specified, it defaults to <see langword="EntityHandling.ExpandCharEntities" />.</returns>
		// Token: 0x170000D4 RID: 212
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00016C9A File Offset: 0x00014E9A
		public EntityHandling EntityHandling
		{
			set
			{
				this.impl.EntityHandling = value;
			}
		}

		/// <summary>Sets the <see cref="T:System.Xml.XmlResolver" /> used for resolving DTD references.</summary>
		/// <returns>The <see langword="XmlResolver" /> to use. If set to <see langword="null" />, external resources are not resolved.In version 1.1 of the .NET Framework, the caller must be fully trusted in order to specify an <see langword="XmlResolver" />.</returns>
		// Token: 0x170000D5 RID: 213
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00016CA8 File Offset: 0x00014EA8
		public XmlResolver XmlResolver
		{
			set
			{
				this.impl.XmlResolver = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00016CB6 File Offset: 0x00014EB6
		internal XmlTextReaderImpl Impl
		{
			get
			{
				return this.impl;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00016CBE File Offset: 0x00014EBE
		internal override XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this.impl.NamespaceManager;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00016CCB File Offset: 0x00014ECB
		internal bool XmlValidatingReaderCompatibilityMode
		{
			set
			{
				this.impl.XmlValidatingReaderCompatibilityMode = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00016CD9 File Offset: 0x00014ED9
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.impl.DtdInfo;
			}
		}

		// Token: 0x040002D9 RID: 729
		private XmlTextReaderImpl impl;
	}
}
