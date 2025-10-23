using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents a reader that provides fast, noncached, forward-only access to XML data.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000075 RID: 117
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlReader : IDisposable
	{
		/// <summary>Gets the <see cref="T:System.Xml.XmlReaderSettings" /> object used to create this <see cref="T:System.Xml.XmlReader" /> instance.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlReaderSettings" /> object used to create this reader instance. If this reader was not created using the <see cref="Overload:System.Xml.XmlReader.Create" /> method, this property returns <see langword="null" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001520A File Offset: 0x0001340A
		public virtual XmlReaderSettings Settings
		{
			get
			{
				return null;
			}
		}

		/// <summary>When overridden in a derived class, gets the type of the current node.</summary>
		/// <returns>One of the enumeration values that specify the type of the current node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000414 RID: 1044
		public abstract XmlNodeType NodeType { get; }

		/// <summary>When overridden in a derived class, gets the qualified name of the current node.</summary>
		/// <returns>The qualified name of the current node. For example, <see langword="Name" /> is <see langword="bk:book" /> for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node type Name 
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
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001520D File Offset: 0x0001340D
		public virtual string Name
		{
			get
			{
				if (this.Prefix.Length == 0)
				{
					return this.LocalName;
				}
				return this.NameTable.Add(this.Prefix + ":" + this.LocalName);
			}
		}

		/// <summary>When overridden in a derived class, gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns <see langword="String.Empty" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000416 RID: 1046
		public abstract string LocalName { get; }

		/// <summary>When overridden in a derived class, gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000417 RID: 1047
		public abstract string NamespaceURI { get; }

		/// <summary>When overridden in a derived class, gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000418 RID: 1048
		public abstract string Prefix { get; }

		/// <summary>When overridden in a derived class, gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return <see langword="String.Empty" />.Node type Value 
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
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000419 RID: 1049
		public abstract string Value { get; }

		/// <summary>When overridden in a derived class, gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600041A RID: 1050
		public abstract int Depth { get; }

		/// <summary>When overridden in a derived class, gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600041B RID: 1051
		public abstract string BaseURI { get; }

		/// <summary>When overridden in a derived class, gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) that ends with /&gt;; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600041C RID: 1052
		public abstract bool IsEmptyElement { get; }

		/// <summary>When overridden in a derived class, gets a value indicating whether the current node is an attribute that was generated from the default value defined in the DTD or schema.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an attribute whose value was generated from the default value defined in the DTD or schema; <see langword="false" /> if the attribute value was explicitly set.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool IsDefault
		{
			get
			{
				return false;
			}
		}

		/// <summary>When overridden in a derived class, gets the quotation mark character used to enclose the value of an attribute node.</summary>
		/// <returns>The quotation mark character (" or ') used to enclose the value of an attribute node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00015244 File Offset: 0x00013444
		public virtual char QuoteChar
		{
			get
			{
				return '"';
			}
		}

		/// <summary>When overridden in a derived class, gets the current <see langword="xml:space" /> scope.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no <see langword="xml:space" /> scope exists, this property defaults to <see langword="XmlSpace.None" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual XmlSpace XmlSpace
		{
			get
			{
				return XmlSpace.None;
			}
		}

		/// <summary>When overridden in a derived class, gets the current <see langword="xml:lang" /> scope.</summary>
		/// <returns>The current <see langword="xml:lang" /> scope.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00015248 File Offset: 0x00013448
		public virtual string XmlLang
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>Gets the schema information that has been assigned to the current node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the schema information for the current node. Schema information can be set on elements, attributes, or on text nodes with a non-null <see cref="P:System.Xml.XmlReader.ValueType" /> (typed values).If the current node is not one of the above node types, or if the <see langword="XmlReader" /> instance does not report schema information, this property returns <see langword="null" />.If this property is called from an <see cref="T:System.Xml.XmlTextReader" /> or an <see cref="T:System.Xml.XmlValidatingReader" /> object, this property always returns <see langword="null" />. These <see langword="XmlReader" /> implementations do not expose schema information through the <see langword="SchemaInfo" /> property.If you have to get the post-schema-validation information set (PSVI) for an element, position the reader on the end tag of the element, rather than on the start tag. You get the PSVI through the <see langword="SchemaInfo" /> property of a reader. The validating reader that is created through <see cref="Overload:System.Xml.XmlReader.Create" /> with the <see cref="P:System.Xml.XmlReaderSettings.ValidationType" /> property set to <see cref="F:System.Xml.ValidationType.Schema" /> has complete PSVI for an element only when the reader is positioned on the end tag of an element.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001524F File Offset: 0x0001344F
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this as IXmlSchemaInfo;
			}
		}

		/// <summary>Gets The Common Language Runtime (CLR) type for the current node.</summary>
		/// <returns>The CLR type that corresponds to the typed value of the node. The default is <see langword="System.String" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00015257 File Offset: 0x00013457
		public virtual Type ValueType
		{
			get
			{
				return typeof(string);
			}
		}

		/// <summary>When overridden in a derived class, gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000423 RID: 1059
		public abstract int AttributeCount { get; }

		/// <summary>When overridden in a derived class, gets the value of the attribute with the specified <see cref="P:System.Xml.XmlReader.Name" />.</summary>
		/// <param name="name">The qualified name of the attribute.</param>
		/// <returns>The value of the specified attribute. If the attribute is not found or the value is <see langword="String.Empty" />, <see langword="null" /> is returned.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000424 RID: 1060
		public abstract string GetAttribute(string name);

		/// <summary>When overridden in a derived class, gets the value of the attribute with the specified <see cref="P:System.Xml.XmlReader.LocalName" /> and <see cref="P:System.Xml.XmlReader.NamespaceURI" />.</summary>
		/// <param name="name">The local name of the attribute.</param>
		/// <param name="namespaceURI">The namespace URI of the attribute.</param>
		/// <returns>The value of the specified attribute. If the attribute is not found or the value is <see langword="String.Empty" />, <see langword="null" /> is returned. This method does not move the reader.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="name" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000425 RID: 1061
		public abstract string GetAttribute(string name, string namespaceURI);

		/// <summary>When overridden in a derived class, gets the value of the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute. The index is zero-based. (The first attribute has index 0.)</param>
		/// <returns>The value of the specified attribute. This method does not move the reader.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="i" /> is out of range. It must be non-negative and less than the size of the attribute collection.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000426 RID: 1062
		public abstract string GetAttribute(int i);

		/// <summary>When overridden in a derived class, moves to the attribute with the specified <see cref="P:System.Xml.XmlReader.Name" />.</summary>
		/// <param name="name">The qualified name of the attribute.</param>
		/// <returns>
		///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the reader's position does not change.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		/// <exception cref="T:System.ArgumentException">The parameter is an empty string.</exception>
		// Token: 0x06000427 RID: 1063
		public abstract bool MoveToAttribute(string name);

		/// <summary>When overridden in a derived class, moves to the attribute with the specified index.</summary>
		/// <param name="i">The index of the attribute.</param>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The parameter has a negative value.</exception>
		// Token: 0x06000428 RID: 1064 RVA: 0x00015264 File Offset: 0x00013464
		public virtual void MoveToAttribute(int i)
		{
			if (i < 0 || i >= this.AttributeCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			this.MoveToElement();
			this.MoveToFirstAttribute();
			for (int j = 0; j < i; j++)
			{
				this.MoveToNextAttribute();
			}
		}

		/// <summary>When overridden in a derived class, moves to the first attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000429 RID: 1065
		public abstract bool MoveToFirstAttribute();

		/// <summary>When overridden in a derived class, moves to the next attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600042A RID: 1066
		public abstract bool MoveToNextAttribute();

		/// <summary>When overridden in a derived class, moves to the element that contains the current attribute node.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600042B RID: 1067
		public abstract bool MoveToElement();

		/// <summary>When overridden in a derived class, parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
		/// <returns>
		///     <see langword="true" /> if there are nodes to return.
		///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of <see langword="String.Empty" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600042C RID: 1068
		public abstract bool ReadAttributeValue();

		/// <summary>When overridden in a derived class, reads the next node from the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the next node was read successfully; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600042D RID: 1069
		public abstract bool Read();

		/// <summary>When overridden in a derived class, gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600042E RID: 1070
		public abstract bool EOF { get; }

		/// <summary>When overridden in a derived class, changes the <see cref="P:System.Xml.XmlReader.ReadState" /> to <see cref="F:System.Xml.ReadState.Closed" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600042F RID: 1071 RVA: 0x00008574 File Offset: 0x00006774
		public virtual void Close()
		{
		}

		/// <summary>When overridden in a derived class, gets the state of the reader.</summary>
		/// <returns>One of the enumeration values that specifies the state of the reader.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000430 RID: 1072
		public abstract ReadState ReadState { get; }

		/// <summary>Skips the children of the current node.</summary>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000431 RID: 1073 RVA: 0x000152AA File Offset: 0x000134AA
		public virtual void Skip()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return;
			}
			this.SkipSubtree();
		}

		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>The <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000432 RID: 1074
		public abstract XmlNameTable NameTable { get; }

		/// <summary>When overridden in a derived class, resolves a namespace prefix in the current element's scope.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. </param>
		/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000433 RID: 1075
		public abstract string LookupNamespace(string prefix);

		/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader can parse and resolve entities; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool CanResolveEntity
		{
			get
			{
				return false;
			}
		}

		/// <summary>When overridden in a derived class, resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
		/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an <see langword="EntityReference" /> node; this implementation of the reader cannot resolve entities (<see cref="P:System.Xml.XmlReader.CanResolveEntity" /> returns <see langword="false" />).</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000435 RID: 1077
		public abstract void ResolveEntity();

		/// <summary>Gets a value indicating whether the <see cref="T:System.Xml.XmlReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.XmlReader" /> implements the <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" /> method; otherwise <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000A216 File Offset: 0x00008416
		public virtual bool CanReadValueChunk
		{
			get
			{
				return false;
			}
		}

		/// <summary>Reads large streams of text embedded in an XML document.</summary>
		/// <param name="buffer">The array of characters that serves as the buffer to which the text contents are written. This value cannot be <see langword="null" />.</param>
		/// <param name="index">The offset within the buffer where the <see cref="T:System.Xml.XmlReader" /> can start to copy the results.</param>
		/// <param name="count">The maximum number of characters to copy into the buffer. The actual number of characters copied is returned from this method.</param>
		/// <returns>The number of characters read into the buffer. The value zero is returned when there is no more text content.</returns>
		/// <exception cref="T:System.InvalidOperationException">The current node does not have a value (<see cref="P:System.Xml.XmlReader.HasValue" /> is <see langword="false" />).</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> value is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The index into the buffer, or index + count is larger than the allocated buffer size.</exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Xml.XmlReader" /> implementation does not support this method.</exception>
		/// <exception cref="T:System.Xml.XmlException">The XML data is not well-formed.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000437 RID: 1079 RVA: 0x000152BD File Offset: 0x000134BD
		public virtual int ReadValueChunk(char[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("ReadValueChunk method is not supported on this XmlReader. Use CanReadValueChunk property to find out if an XmlReader implements it."));
		}

		/// <summary>When overridden in a derived class, reads the contents of an element or text node as a string. However, we recommend that you use the <see cref="Overload:System.Xml.XmlReader.ReadElementContentAsString" /> method instead, because it provides a more straightforward way to handle this operation.</summary>
		/// <returns>The contents of the element or an empty string.</returns>
		/// <exception cref="T:System.Xml.XmlException">An error occurred while parsing the XML.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000438 RID: 1080 RVA: 0x000152D0 File Offset: 0x000134D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadString()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return string.Empty;
			}
			this.MoveToElement();
			if (this.NodeType == XmlNodeType.Element)
			{
				if (this.IsEmptyElement)
				{
					return string.Empty;
				}
				if (!this.Read())
				{
					throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
				}
				if (this.NodeType == XmlNodeType.EndElement)
				{
					return string.Empty;
				}
			}
			string text = string.Empty;
			while (XmlReader.IsTextualNode(this.NodeType))
			{
				text += this.Value;
				if (!this.Read())
				{
					break;
				}
			}
			return text;
		}

		/// <summary>Checks whether the current node is a content (non-white space text, <see langword="CDATA" />, <see langword="Element" />, <see langword="EndElement" />, <see langword="EntityReference" />, or <see langword="EndEntity" />) node. If the node is not a content node, the reader skips ahead to the next content node or end of file. It skips over nodes of the following type: <see langword="ProcessingInstruction" />, <see langword="DocumentType" />, <see langword="Comment" />, <see langword="Whitespace" />, or <see langword="SignificantWhitespace" />.</summary>
		/// <returns>The <see cref="P:System.Xml.XmlReader.NodeType" /> of the current node found by the method or <see langword="XmlNodeType.None" /> if the reader has reached the end of the input stream.</returns>
		/// <exception cref="T:System.Xml.XmlException">Incorrect XML encountered in the input stream.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000439 RID: 1081 RVA: 0x00015360 File Offset: 0x00013560
		public virtual XmlNodeType MoveToContent()
		{
			for (;;)
			{
				XmlNodeType nodeType = this.NodeType;
				switch (nodeType)
				{
				case XmlNodeType.Element:
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.EntityReference:
					goto IL_33;
				case XmlNodeType.Attribute:
					goto IL_2C;
				default:
					if (nodeType - XmlNodeType.EndElement <= 1)
					{
						goto IL_33;
					}
					if (!this.Read())
					{
						goto Block_2;
					}
					break;
				}
			}
			IL_2C:
			this.MoveToElement();
			IL_33:
			return this.NodeType;
			Block_2:
			return this.NodeType;
		}

		/// <summary>Checks that the current node is an element and advances the reader to the next node.</summary>
		/// <exception cref="T:System.Xml.XmlException">Incorrect XML was encountered in the input stream.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600043A RID: 1082 RVA: 0x000153B8 File Offset: 0x000135B8
		public virtual void ReadStartElement()
		{
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			this.Read();
		}

		/// <summary>Reads a text-only element. However, we recommend that you use the <see cref="M:System.Xml.XmlReader.ReadElementContentAsString" /> method instead, because it provides a more straightforward way to handle this operation.</summary>
		/// <returns>The text contained in the element that was read. An empty string if the element is empty.</returns>
		/// <exception cref="T:System.Xml.XmlException">The next content node is not a start tag; or the element found does not contain a simple text value.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600043B RID: 1083 RVA: 0x000153FC File Offset: 0x000135FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadElementString()
		{
			string result = string.Empty;
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (!this.IsEmptyElement)
			{
				this.Read();
				result = this.ReadString();
				if (this.NodeType != XmlNodeType.EndElement)
				{
					throw new XmlException("Unexpected node type {0}. {1} method can only be called on elements with simple or empty content.", new string[]
					{
						this.NodeType.ToString(),
						"ReadElementString"
					}, this as IXmlLineInfo);
				}
				this.Read();
			}
			else
			{
				this.Read();
			}
			return result;
		}

		/// <summary>Checks that the current content node is an end tag and advances the reader to the next node.</summary>
		/// <exception cref="T:System.Xml.XmlException">The current node is not an end tag or if incorrect XML is encountered in the input stream.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600043C RID: 1084 RVA: 0x000154A4 File Offset: 0x000136A4
		public virtual void ReadEndElement()
		{
			if (this.MoveToContent() != XmlNodeType.EndElement)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			this.Read();
		}

		/// <summary>Calls <see cref="M:System.Xml.XmlReader.MoveToContent" /> and tests if the current content node is a start tag or empty element tag and if the <see cref="P:System.Xml.XmlReader.LocalName" /> and <see cref="P:System.Xml.XmlReader.NamespaceURI" /> properties of the element found match the given strings.</summary>
		/// <param name="localname">The string to match against the <see langword="LocalName" /> property of the element found.</param>
		/// <param name="ns">The string to match against the <see langword="NamespaceURI" /> property of the element found.</param>
		/// <returns>
		///     <see langword="true" /> if the resulting node is an element. <see langword="false" /> if a node type other than <see langword="XmlNodeType.Element" /> was found or if the <see langword="LocalName" /> and <see langword="NamespaceURI" /> properties of the element do not match the specified strings.</returns>
		/// <exception cref="T:System.Xml.XmlException">Incorrect XML is encountered in the input stream.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600043D RID: 1085 RVA: 0x000154E7 File Offset: 0x000136E7
		public virtual bool IsStartElement(string localname, string ns)
		{
			return this.MoveToContent() == XmlNodeType.Element && this.LocalName == localname && this.NamespaceURI == ns;
		}

		/// <summary>When overridden in a derived class, reads all the content, including markup, as a string.</summary>
		/// <returns>All the XML content, including markup, in the current node. If the current node has no children, an empty string is returned.If the current node is neither an element nor attribute, an empty string is returned.</returns>
		/// <exception cref="T:System.Xml.XmlException">The XML was not well-formed, or an error occurred while parsing the XML.</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x0600043E RID: 1086 RVA: 0x00015510 File Offset: 0x00013710
		public virtual string ReadInnerXml()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return string.Empty;
			}
			if (this.NodeType != XmlNodeType.Attribute && this.NodeType != XmlNodeType.Element)
			{
				this.Read();
				return string.Empty;
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			XmlWriter xmlWriter = this.CreateWriterForInnerOuterXml(stringWriter);
			try
			{
				if (this.NodeType == XmlNodeType.Attribute)
				{
					((XmlTextWriter)xmlWriter).QuoteChar = this.QuoteChar;
					this.WriteAttributeValue(xmlWriter);
				}
				if (this.NodeType == XmlNodeType.Element)
				{
					this.WriteNode(xmlWriter, false);
				}
			}
			finally
			{
				xmlWriter.Close();
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000155B0 File Offset: 0x000137B0
		private void WriteNode(XmlWriter xtw, bool defattr)
		{
			int num = (this.NodeType == XmlNodeType.None) ? -1 : this.Depth;
			while (this.Read() && num < this.Depth)
			{
				switch (this.NodeType)
				{
				case XmlNodeType.Element:
					xtw.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceURI);
					((XmlTextWriter)xtw).QuoteChar = this.QuoteChar;
					xtw.WriteAttributes(this, defattr);
					if (this.IsEmptyElement)
					{
						xtw.WriteEndElement();
					}
					break;
				case XmlNodeType.Text:
					xtw.WriteString(this.Value);
					break;
				case XmlNodeType.CDATA:
					xtw.WriteCData(this.Value);
					break;
				case XmlNodeType.EntityReference:
					xtw.WriteEntityRef(this.Name);
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.XmlDeclaration:
					xtw.WriteProcessingInstruction(this.Name, this.Value);
					break;
				case XmlNodeType.Comment:
					xtw.WriteComment(this.Value);
					break;
				case XmlNodeType.DocumentType:
					xtw.WriteDocType(this.Name, this.GetAttribute("PUBLIC"), this.GetAttribute("SYSTEM"), this.Value);
					break;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					xtw.WriteWhitespace(this.Value);
					break;
				case XmlNodeType.EndElement:
					xtw.WriteFullEndElement();
					break;
				}
			}
			if (num == this.Depth && this.NodeType == XmlNodeType.EndElement)
			{
				this.Read();
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001572C File Offset: 0x0001392C
		private void WriteAttributeValue(XmlWriter xtw)
		{
			string name = this.Name;
			while (this.ReadAttributeValue())
			{
				if (this.NodeType == XmlNodeType.EntityReference)
				{
					xtw.WriteEntityRef(this.Name);
				}
				else
				{
					xtw.WriteString(this.Value);
				}
			}
			this.MoveToAttribute(name);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00015778 File Offset: 0x00013978
		private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(sw);
			this.SetNamespacesFlag(xmlTextWriter);
			return xmlTextWriter;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00015794 File Offset: 0x00013994
		private void SetNamespacesFlag(XmlTextWriter xtw)
		{
			XmlTextReader xmlTextReader = this as XmlTextReader;
			if (xmlTextReader != null)
			{
				xtw.Namespaces = xmlTextReader.Namespaces;
				return;
			}
			XmlValidatingReader xmlValidatingReader = this as XmlValidatingReader;
			if (xmlValidatingReader != null)
			{
				xtw.Namespaces = xmlValidatingReader.Namespaces;
			}
		}

		/// <summary>Gets a value indicating whether the current node has any attributes.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000157CE File Offset: 0x000139CE
		public virtual bool HasAttributes
		{
			get
			{
				return this.AttributeCount > 0;
			}
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Xml.XmlReader" /> class.</summary>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000444 RID: 1092 RVA: 0x000157D9 File Offset: 0x000139D9
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Xml.XmlReader" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		// Token: 0x06000445 RID: 1093 RVA: 0x000157E2 File Offset: 0x000139E2
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.ReadState != ReadState.Closed)
			{
				this.Close();
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0001520A File Offset: 0x0001340A
		internal virtual XmlNamespaceManager NamespaceManager
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000157F6 File Offset: 0x000139F6
		internal static bool IsTextualNode(XmlNodeType nodeType)
		{
			return ((ulong)XmlReader.IsTextualNodeBitmap & (ulong)(1L << (int)(nodeType & (XmlNodeType)31))) > 0UL;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001580A File Offset: 0x00013A0A
		internal static bool HasValueInternal(XmlNodeType nodeType)
		{
			return ((ulong)XmlReader.HasValueBitmap & (ulong)(1L << (int)(nodeType & (XmlNodeType)31))) > 0UL;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00015820 File Offset: 0x00013A20
		private bool SkipSubtree()
		{
			this.MoveToElement();
			if (this.NodeType == XmlNodeType.Element && !this.IsEmptyElement)
			{
				int depth = this.Depth;
				while (this.Read() && depth < this.Depth)
				{
				}
				return this.NodeType == XmlNodeType.EndElement && this.Read();
			}
			return this.Read();
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00015878 File Offset: 0x00013A78
		internal bool IsDefaultInternal
		{
			get
			{
				if (this.IsDefault)
				{
					return true;
				}
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				return schemaInfo != null && schemaInfo.IsDefault;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001520A File Offset: 0x0001340A
		internal virtual IDtdInfo DtdInfo
		{
			get
			{
				return null;
			}
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified URI and settings.</summary>
		/// <param name="inputUri">The URI for the file containing the XML data. The <see cref="T:System.Xml.XmlResolver" /> object on the <see cref="T:System.Xml.XmlReaderSettings" /> object is used to convert the path to a canonical data representation. If <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> is <see langword="null" />, a new <see cref="T:System.Xml.XmlUrlResolver" /> object is used.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="inputUri" /> value is <see langword="null" />.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by the URI cannot be found.</exception>
		/// <exception cref="T:System.UriFormatException">
		///           In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.The URI format is not correct.</exception>
		// Token: 0x0600044C RID: 1100 RVA: 0x000158A4 File Offset: 0x00013AA4
		public static XmlReader Create(string inputUri, XmlReaderSettings settings)
		{
			return XmlReader.Create(inputUri, settings, null);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified URI, settings, and context information for parsing.</summary>
		/// <param name="inputUri">The URI for the file containing the XML data. The <see cref="T:System.Xml.XmlResolver" /> object on the <see cref="T:System.Xml.XmlReaderSettings" /> object is used to convert the path to a canonical data representation. If <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> is <see langword="null" />, a new <see cref="T:System.Xml.XmlUrlResolver" /> object is used.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
		/// <param name="inputContext">The context information required to parse the XML fragment. The context information can include the <see cref="T:System.Xml.XmlNameTable" /> to use, encoding, namespace scope, the current xml:lang and xml:space scope, base URI, and document type definition. This value can be <see langword="null" />.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see langword="inputUri" /> value is <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">The <see cref="T:System.Xml.XmlReader" /> does not have sufficient permissions to access the location of the XML data.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Xml.XmlReaderSettings.NameTable" />  and <see cref="P:System.Xml.XmlParserContext.NameTable" /> properties both contain values. (Only one of these <see langword="NameTable" /> properties can be set and used).</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified by the URI cannot be found.</exception>
		/// <exception cref="T:System.UriFormatException">The URI format is not correct.</exception>
		// Token: 0x0600044D RID: 1101 RVA: 0x000158AE File Offset: 0x00013AAE
		public static XmlReader Create(string inputUri, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(inputUri, inputContext);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance with the specified stream and settings.</summary>
		/// <param name="input">The stream that contains the XML data.The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
		// Token: 0x0600044E RID: 1102 RVA: 0x000158C2 File Offset: 0x00013AC2
		public static XmlReader Create(Stream input, XmlReaderSettings settings)
		{
			return XmlReader.Create(input, settings, string.Empty);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance using the specified stream, base URI, and settings.</summary>
		/// <param name="input">The stream that contains the XML data. The <see cref="T:System.Xml.XmlReader" /> scans the first bytes of the stream looking for a byte order mark or other sign of encoding. When encoding is determined, the encoding is used to continue reading the stream, and processing continues parsing the input as a stream of (Unicode) characters.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
		/// <param name="baseUri">The base URI for the entity or document being read. This value can be <see langword="null" />.
		///       Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
		// Token: 0x0600044F RID: 1103 RVA: 0x000158D0 File Offset: 0x00013AD0
		public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, null, baseUri, null);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified text reader and settings.</summary>
		/// <param name="input">The text reader from which to read the XML data. A text reader returns a stream of Unicode characters, so the encoding specified in the XML declaration isn't used by the XML reader to decode the data stream.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" />. This value can be <see langword="null" />.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
		// Token: 0x06000450 RID: 1104 RVA: 0x000158E6 File Offset: 0x00013AE6
		public static XmlReader Create(TextReader input, XmlReaderSettings settings)
		{
			return XmlReader.Create(input, settings, string.Empty);
		}

		/// <summary>Creates a new <see cref="T:System.Xml.XmlReader" /> instance by using the specified text reader, settings, and base URI.</summary>
		/// <param name="input">The text reader from which to read the XML data. A text reader returns a stream of Unicode characters, so the encoding specified in the XML declaration isn't used by the <see cref="T:System.Xml.XmlReader" /> to decode the data stream.</param>
		/// <param name="settings">The settings for the new <see cref="T:System.Xml.XmlReader" /> instance. This value can be <see langword="null" />.</param>
		/// <param name="baseUri">The base URI for the entity or document being read. This value can be <see langword="null" />.
		///       Security Note   The base URI is used to resolve the relative URI of the XML document. Do not use a base URI from an untrusted source.</param>
		/// <returns>An object that is used to read the XML data in the stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> value is <see langword="null" />.</exception>
		// Token: 0x06000451 RID: 1105 RVA: 0x000158F4 File Offset: 0x00013AF4
		public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, baseUri, null);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001590C File Offset: 0x00013B0C
		internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			byte[] array = new byte[XmlReader.CalcBufferSize(input)];
			int num = 0;
			int num2;
			do
			{
				num2 = input.Read(array, num, array.Length - num);
				num += num2;
			}
			while (num2 > 0 && num < 2);
			XmlReader xmlReader;
			if (num >= 2 && array[0] == 223 && array[1] == 255)
			{
				if (inputContext != null)
				{
					throw new ArgumentException(Res.GetString("BinaryXml Parser does not support initialization with XmlParserContext."), "inputContext");
				}
				xmlReader = new XmlSqlBinaryReader(input, array, num, string.Empty, settings.CloseInput, settings);
			}
			else
			{
				xmlReader = new XmlTextReaderImpl(input, array, num, settings, null, string.Empty, inputContext, settings.CloseInput);
			}
			if (settings.ValidationType != ValidationType.None)
			{
				xmlReader = settings.AddValidation(xmlReader);
			}
			if (settings.Async)
			{
				xmlReader = XmlAsyncCheckReader.CreateAsyncCheckWrapper(xmlReader);
			}
			return xmlReader;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000159D8 File Offset: 0x00013BD8
		internal static int CalcBufferSize(Stream input)
		{
			int num = 4096;
			if (input.CanSeek)
			{
				long length = input.Length;
				if (length < (long)num)
				{
					num = checked((int)length);
				}
				else if (length > 65536L)
				{
					num = 8192;
				}
			}
			return num;
		}

		/// <summary>Asynchronously gets the value of the current node.</summary>
		/// <returns>The value of the current node.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> asynchronous method was called without setting the <see cref="P:System.Xml.XmlReaderSettings.Async" /> flag to <see langword="true" />. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “Set XmlReaderSettings.Async to true if you want to use Async Methods.”</exception>
		// Token: 0x06000454 RID: 1108 RVA: 0x00002B48 File Offset: 0x00000D48
		public virtual Task<string> GetValueAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>Asynchronously reads the next node from the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the next node was read successfully; <see langword="false" /> if there are no more nodes to read.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> asynchronous method was called without setting the <see cref="P:System.Xml.XmlReaderSettings.Async" /> flag to <see langword="true" />. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “Set XmlReaderSettings.Async to true if you want to use Async Methods.”</exception>
		// Token: 0x06000455 RID: 1109 RVA: 0x00002B48 File Offset: 0x00000D48
		public virtual Task<bool> ReadAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>Asynchronously checks whether the current node is a content node. If the node is not a content node, the reader skips ahead to the next content node or end of file.</summary>
		/// <returns>The <see cref="P:System.Xml.XmlReader.NodeType" /> of the current node found by the method or <see langword="XmlNodeType.None" /> if the reader has reached the end of the input stream.</returns>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> method was called before a previous asynchronous operation finished. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “An asynchronous operation is already in progress.”</exception>
		/// <exception cref="T:System.InvalidOperationException">An <see cref="T:System.Xml.XmlReader" /> asynchronous method was called without setting the <see cref="P:System.Xml.XmlReaderSettings.Async" /> flag to <see langword="true" />. In this case, <see cref="T:System.InvalidOperationException" /> is thrown with the message “Set XmlReaderSettings.Async to true if you want to use Async Methods.”</exception>
		// Token: 0x06000456 RID: 1110 RVA: 0x00015A14 File Offset: 0x00013C14
		public virtual Task<XmlNodeType> MoveToContentAsync()
		{
			XmlReader.<MoveToContentAsync>d__197 <MoveToContentAsync>d__;
			<MoveToContentAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XmlNodeType>.Create();
			<MoveToContentAsync>d__.<>4__this = this;
			<MoveToContentAsync>d__.<>1__state = -1;
			<MoveToContentAsync>d__.<>t__builder.Start<XmlReader.<MoveToContentAsync>d__197>(ref <MoveToContentAsync>d__);
			return <MoveToContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040002B3 RID: 691
		private static uint IsTextualNodeBitmap = 24600U;

		// Token: 0x040002B4 RID: 692
		private static uint CanReadContentAsBitmap = 123324U;

		// Token: 0x040002B5 RID: 693
		private static uint HasValueBitmap = 157084U;
	}
}
