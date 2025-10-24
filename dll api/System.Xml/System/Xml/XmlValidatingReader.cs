using System;

namespace System.Xml
{
	/// <summary>Represents a reader that provides document type definition (DTD), XML-Data Reduced (XDR) schema, and XML Schema definition language (XSD) validation.This class is obsolete. Starting with the .NET Framework 2.0, we recommend that you use the <see cref="T:System.Xml.XmlReaderSettings" /> class and the <see cref="Overload:System.Xml.XmlReader.Create" /> method to create a validating XML reader.</summary>
	// Token: 0x020000F3 RID: 243
	public class XmlValidatingReader : XmlReader
	{
		/// <summary>Gets the type of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000397AE File Offset: 0x000379AE
		public override XmlNodeType NodeType
		{
			get
			{
				return this.impl.NodeType;
			}
		}

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns String.Empty.</returns>
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000397BB File Offset: 0x000379BB
		public override string LocalName
		{
			get
			{
				return this.impl.LocalName;
			}
		}

		/// <summary>Gets the namespace Uniform Resource Identifier (URI) (as defined in the World Wide Web Consortium (W3C) Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x000397C8 File Offset: 0x000379C8
		public override string NamespaceURI
		{
			get
			{
				return this.impl.NamespaceURI;
			}
		}

		/// <summary>Gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x000397D5 File Offset: 0x000379D5
		public override string Prefix
		{
			get
			{
				return this.impl.Prefix;
			}
		}

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value 
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
		///           The white space between markup in a mixed content model. 
		///             <see langword="Text" />
		///           The content of the text node. 
		///             <see langword="Whitespace" />
		///           The white space between markup. 
		///             <see langword="XmlDeclaration" />
		///           The content of the declaration. </returns>
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x000397E2 File Offset: 0x000379E2
		public override string Value
		{
			get
			{
				return this.impl.Value;
			}
		}

		/// <summary>Gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x000397EF File Offset: 0x000379EF
		public override int Depth
		{
			get
			{
				return this.impl.Depth;
			}
		}

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x000397FC File Offset: 0x000379FC
		public override string BaseURI
		{
			get
			{
				return this.impl.BaseURI;
			}
		}

		/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlValidatingReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) that ends with /&gt;; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00039809 File Offset: 0x00037A09
		public override bool IsEmptyElement
		{
			get
			{
				return this.impl.IsEmptyElement;
			}
		}

		/// <summary>Gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node. This number includes default attributes.</returns>
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00039816 File Offset: 0x00037A16
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
		// Token: 0x0600083A RID: 2106 RVA: 0x00039823 File Offset: 0x00037A23
		public override string GetAttribute(string name)
		{
			return this.impl.GetAttribute(name);
		}

		/// <summary>Gets the value of the attribute with the specified local name and namespace Uniform Resource Identifier (URI).</summary>
		/// <param name="localName">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned. This method does not move the reader.</returns>
		// Token: 0x0600083B RID: 2107 RVA: 0x00039831 File Offset: 0x00037A31
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return this.impl.GetAttribute(localName, namespaceURI);
		}

		/// <summary>Gets the value of the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
		/// <returns>The value of the specified attribute.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlValidatingReader.AttributeCount" />. </exception>
		// Token: 0x0600083C RID: 2108 RVA: 0x00039840 File Offset: 0x00037A40
		public override string GetAttribute(int i)
		{
			return this.impl.GetAttribute(i);
		}

		/// <summary>Moves to the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>
		///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the position of the reader does not change.</returns>
		// Token: 0x0600083D RID: 2109 RVA: 0x0003984E File Offset: 0x00037A4E
		public override bool MoveToAttribute(string name)
		{
			return this.impl.MoveToAttribute(name);
		}

		/// <summary>Moves to the first attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
		// Token: 0x0600083E RID: 2110 RVA: 0x0003985C File Offset: 0x00037A5C
		public override bool MoveToFirstAttribute()
		{
			return this.impl.MoveToFirstAttribute();
		}

		/// <summary>Moves to the next attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
		// Token: 0x0600083F RID: 2111 RVA: 0x00039869 File Offset: 0x00037A69
		public override bool MoveToNextAttribute()
		{
			return this.impl.MoveToNextAttribute();
		}

		/// <summary>Moves to the element that contains the current attribute node.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
		// Token: 0x06000840 RID: 2112 RVA: 0x00039876 File Offset: 0x00037A76
		public override bool MoveToElement()
		{
			return this.impl.MoveToElement();
		}

		/// <summary>Parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
		/// <returns>
		///     <see langword="true" /> if there are nodes to return.
		///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of String.Empty.</returns>
		// Token: 0x06000841 RID: 2113 RVA: 0x00039883 File Offset: 0x00037A83
		public override bool ReadAttributeValue()
		{
			return this.impl.ReadAttributeValue();
		}

		/// <summary>Reads the next node from the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the next node was read successfully; <see langword="false" /> if there are no more nodes to read.</returns>
		// Token: 0x06000842 RID: 2114 RVA: 0x00039890 File Offset: 0x00037A90
		public override bool Read()
		{
			return this.impl.Read();
		}

		/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0003989D File Offset: 0x00037A9D
		public override bool EOF
		{
			get
			{
				return this.impl.EOF;
			}
		}

		/// <summary>Gets the state of the reader.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000398AA File Offset: 0x00037AAA
		public override ReadState ReadState
		{
			get
			{
				return this.impl.ReadState;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>
		///     <see langword="XmlNameTable" /> that enables you to get the atomized version of a string within the node.</returns>
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000398B7 File Offset: 0x00037AB7
		public override XmlNameTable NameTable
		{
			get
			{
				return this.impl.NameTable;
			}
		}

		/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
		/// <param name="prefix">The prefix whose namespace Uniform Resource Identifier (URI) you want to resolve. To match the default namespace, pass an empty string. </param>
		/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
		// Token: 0x06000846 RID: 2118 RVA: 0x000398C4 File Offset: 0x00037AC4
		public override string LookupNamespace(string prefix)
		{
			string text = this.impl.LookupNamespace(prefix);
			if (text != null && text.Length == 0)
			{
				text = null;
			}
			return text;
		}

		/// <summary>Resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
		/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an <see langword="EntityReference" /> node. </exception>
		// Token: 0x06000847 RID: 2119 RVA: 0x000398EC File Offset: 0x00037AEC
		public override void ResolveEntity()
		{
			this.impl.ResolveEntity();
		}

		/// <summary>Gets or sets a value indicating whether to do namespace support.</summary>
		/// <returns>
		///     <see langword="true" /> to do namespace support; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000398F9 File Offset: 0x00037AF9
		public bool Namespaces
		{
			get
			{
				return this.impl.Namespaces;
			}
		}

		// Token: 0x04000682 RID: 1666
		private XmlValidatingReaderImpl impl;
	}
}
