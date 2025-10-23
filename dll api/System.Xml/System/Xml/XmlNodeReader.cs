using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>Represents a reader that provides fast, non-cached forward only access to XML data in an <see cref="T:System.Xml.XmlNode" />.</summary>
	// Token: 0x02000152 RID: 338
	public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
	{
		/// <summary>Creates an instance of the <see langword="XmlNodeReader" /> class using the specified <see cref="T:System.Xml.XmlNode" />.</summary>
		/// <param name="node">The <see langword="XmlNode" /> you want to read. </param>
		// Token: 0x06000C71 RID: 3185 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		public XmlNodeReader(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			this.readerNav = new XmlNodeReaderNavigator(node);
			this.curDepth = 0;
			this.readState = ReadState.Initial;
			this.fEOF = false;
			this.nodeType = XmlNodeType.None;
			this.bResolveEntity = false;
			this.bStartFromDocument = false;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004DCF7 File Offset: 0x0004BEF7
		internal bool IsInReadingStates()
		{
			return this.readState == ReadState.Interactive;
		}

		/// <summary>Gets the type of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlNodeType" /> values representing the type of the current node.</returns>
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0004DD02 File Offset: 0x0004BF02
		public override XmlNodeType NodeType
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return XmlNodeType.None;
				}
				return this.nodeType;
			}
		}

		/// <summary>Gets the qualified name of the current node.</summary>
		/// <returns>The qualified name of the current node. For example, <see langword="Name" /> is <see langword="bk:book" /> for the element &lt;bk:book&gt;.The name returned is dependent on the <see cref="P:System.Xml.XmlNodeReader.NodeType" /> of the node. The following node types return the listed values. All other node types return an empty string.Node Type Name 
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
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0004DD14 File Offset: 0x0004BF14
		public override string Name
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Name;
			}
		}

		/// <summary>Gets the local name of the current node.</summary>
		/// <returns>The name of the current node with the prefix removed. For example, <see langword="LocalName" /> is <see langword="book" /> for the element &lt;bk:book&gt;.For node types that do not have a name (like <see langword="Text" />, <see langword="Comment" />, and so on), this property returns String.Empty.</returns>
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0004DD2F File Offset: 0x0004BF2F
		public override string LocalName
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.LocalName;
			}
		}

		/// <summary>Gets the namespace URI (as defined in the W3C Namespace specification) of the node on which the reader is positioned.</summary>
		/// <returns>The namespace URI of the current node; otherwise an empty string.</returns>
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0004DD4A File Offset: 0x0004BF4A
		public override string NamespaceURI
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.NamespaceURI;
			}
		}

		/// <summary>Gets the namespace prefix associated with the current node.</summary>
		/// <returns>The namespace prefix associated with the current node.</returns>
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0004DD65 File Offset: 0x0004BF65
		public override string Prefix
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Prefix;
			}
		}

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>The value returned depends on the <see cref="P:System.Xml.XmlNodeReader.NodeType" /> of the node. The following table lists node types that have a value to return. All other node types return String.Empty.Node Type Value 
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
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0004DD80 File Offset: 0x0004BF80
		public override string Value
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Value;
			}
		}

		/// <summary>Gets the depth of the current node in the XML document.</summary>
		/// <returns>The depth of the current node in the XML document.</returns>
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0004DD9B File Offset: 0x0004BF9B
		public override int Depth
		{
			get
			{
				return this.curDepth;
			}
		}

		/// <summary>Gets the base URI of the current node.</summary>
		/// <returns>The base URI of the current node.</returns>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0004DDA3 File Offset: 0x0004BFA3
		public override string BaseURI
		{
			get
			{
				return this.readerNav.BaseURI;
			}
		}

		/// <summary>Gets a value indicating whether this reader can parse and resolve entities.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader can parse and resolve entities; otherwise, <see langword="false" />. <see langword="XmlNodeReader" /> always returns <see langword="true" />.</returns>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0000C89B File Offset: 0x0000AA9B
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		/// <summary>Gets a value indicating whether the current node is an empty element (for example, &lt;MyElement/&gt;).</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an element (<see cref="P:System.Xml.XmlNodeReader.NodeType" /> equals <see langword="XmlNodeType.Element" />) and it ends with /&gt;; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
		public override bool IsEmptyElement
		{
			get
			{
				return this.IsInReadingStates() && this.readerNav.IsEmptyElement;
			}
		}

		/// <summary>Gets a value indicating whether the current node is an attribute that was generated from the default value defined in the document type definition (DTD) or schema.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node is an attribute whose value was generated from the default value defined in the DTD or schema; <see langword="false" /> if the attribute value was explicitly set.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0004DDC7 File Offset: 0x0004BFC7
		public override bool IsDefault
		{
			get
			{
				return this.IsInReadingStates() && this.readerNav.IsDefault;
			}
		}

		/// <summary>Gets the current <see langword="xml:space" /> scope.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XmlSpace" /> values. If no <see langword="xml:space" /> scope exists, this property defaults to <see langword="XmlSpace.None" />.</returns>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0004DDDE File Offset: 0x0004BFDE
		public override XmlSpace XmlSpace
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return XmlSpace.None;
				}
				return this.readerNav.XmlSpace;
			}
		}

		/// <summary>Gets the current <see langword="xml:lang" /> scope.</summary>
		/// <returns>The current <see langword="xml:lang" /> scope.</returns>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0004DDF5 File Offset: 0x0004BFF5
		public override string XmlLang
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.XmlLang;
			}
		}

		/// <summary>Gets the schema information that has been assigned to the current node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object containing the schema information for the current node.</returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0004DE10 File Offset: 0x0004C010
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return null;
				}
				return this.readerNav.SchemaInfo;
			}
		}

		/// <summary>Gets the number of attributes on the current node.</summary>
		/// <returns>The number of attributes on the current node. This number includes default attributes.</returns>
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0004DE27 File Offset: 0x0004C027
		public override int AttributeCount
		{
			get
			{
				if (!this.IsInReadingStates() || this.nodeType == XmlNodeType.EndElement)
				{
					return 0;
				}
				return this.readerNav.AttributeCount;
			}
		}

		/// <summary>Gets the value of the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
		// Token: 0x06000C82 RID: 3202 RVA: 0x0004DE48 File Offset: 0x0004C048
		public override string GetAttribute(string name)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			return this.readerNav.GetAttribute(name);
		}

		/// <summary>Gets the value of the attribute with the specified local name and namespace URI.</summary>
		/// <param name="name">The local name of the attribute. </param>
		/// <param name="namespaceURI">The namespace URI of the attribute. </param>
		/// <returns>The value of the specified attribute. If the attribute is not found, <see langword="null" /> is returned.</returns>
		// Token: 0x06000C83 RID: 3203 RVA: 0x0004DE60 File Offset: 0x0004C060
		public override string GetAttribute(string name, string namespaceURI)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			string ns = (namespaceURI == null) ? string.Empty : namespaceURI;
			return this.readerNav.GetAttribute(name, ns);
		}

		/// <summary>Gets the value of the attribute with the specified index.</summary>
		/// <param name="attributeIndex">The index of the attribute. The index is zero-based. (The first attribute has index 0.) </param>
		/// <returns>The value of the specified attribute.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlNodeReader.AttributeCount" />. </exception>
		// Token: 0x06000C84 RID: 3204 RVA: 0x0004DE90 File Offset: 0x0004C090
		public override string GetAttribute(int attributeIndex)
		{
			if (!this.IsInReadingStates())
			{
				throw new ArgumentOutOfRangeException("attributeIndex");
			}
			return this.readerNav.GetAttribute(attributeIndex);
		}

		/// <summary>Moves to the attribute with the specified name.</summary>
		/// <param name="name">The qualified name of the attribute. </param>
		/// <returns>
		///     <see langword="true" /> if the attribute is found; otherwise, <see langword="false" />. If <see langword="false" />, the reader's position does not change.</returns>
		// Token: 0x06000C85 RID: 3205 RVA: 0x0004DEB4 File Offset: 0x0004C0B4
		public override bool MoveToAttribute(string name)
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			if (this.readerNav.MoveToAttribute(name))
			{
				this.curDepth++;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>Moves to the attribute with the specified index.</summary>
		/// <param name="attributeIndex">The index of the attribute. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="i" /> parameter is less than 0 or greater than or equal to <see cref="P:System.Xml.XmlReader.AttributeCount" />. </exception>
		// Token: 0x06000C86 RID: 3206 RVA: 0x0004DF34 File Offset: 0x0004C134
		public override void MoveToAttribute(int attributeIndex)
		{
			if (!this.IsInReadingStates())
			{
				throw new ArgumentOutOfRangeException("attributeIndex");
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			try
			{
				if (this.AttributeCount <= 0)
				{
					throw new ArgumentOutOfRangeException("attributeIndex");
				}
				this.readerNav.MoveToAttribute(attributeIndex);
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
			}
			catch
			{
				this.readerNav.RollBackMove(ref this.curDepth);
				throw;
			}
			this.curDepth++;
			this.nodeType = this.readerNav.NodeType;
		}

		/// <summary>Moves to the first attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if an attribute exists (the reader moves to the first attribute); otherwise, <see langword="false" /> (the position of the reader does not change).</returns>
		// Token: 0x06000C87 RID: 3207 RVA: 0x0004DFE0 File Offset: 0x0004C1E0
		public override bool MoveToFirstAttribute()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			if (this.AttributeCount > 0)
			{
				this.readerNav.MoveToAttribute(0);
				this.curDepth++;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>Moves to the next attribute.</summary>
		/// <returns>
		///     <see langword="true" /> if there is a next attribute; <see langword="false" /> if there are no more attributes.</returns>
		// Token: 0x06000C88 RID: 3208 RVA: 0x0004E064 File Offset: 0x0004C264
		public override bool MoveToNextAttribute()
		{
			if (!this.IsInReadingStates() || this.nodeType == XmlNodeType.EndElement)
			{
				return false;
			}
			this.readerNav.LogMove(this.curDepth);
			this.readerNav.ResetToAttribute(ref this.curDepth);
			if (this.readerNav.MoveToNextAttribute(ref this.curDepth))
			{
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>Moves to the element that contains the current attribute node.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned on an attribute (the reader moves to the element that owns the attribute); <see langword="false" /> if the reader is not positioned on an attribute (the position of the reader does not change).</returns>
		// Token: 0x06000C89 RID: 3209 RVA: 0x0004E0F0 File Offset: 0x0004C2F0
		public override bool MoveToElement()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.LogMove(this.curDepth);
			this.readerNav.ResetToAttribute(ref this.curDepth);
			if (this.readerNav.MoveToElement())
			{
				this.curDepth--;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>Reads the next node from the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the next node was read successfully; <see langword="false" /> if there are no more nodes to read.</returns>
		// Token: 0x06000C8A RID: 3210 RVA: 0x0004E177 File Offset: 0x0004C377
		public override bool Read()
		{
			return this.Read(false);
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x0004E180 File Offset: 0x0004C380
		private bool Read(bool fSkipChildren)
		{
			if (this.fEOF)
			{
				return false;
			}
			if (this.readState == ReadState.Initial)
			{
				if (this.readerNav.NodeType == XmlNodeType.Document || this.readerNav.NodeType == XmlNodeType.DocumentFragment)
				{
					this.bStartFromDocument = true;
					if (!this.ReadNextNode(fSkipChildren))
					{
						this.readState = ReadState.Error;
						return false;
					}
				}
				this.ReSetReadingMarks();
				this.readState = ReadState.Interactive;
				this.nodeType = this.readerNav.NodeType;
				this.curDepth = 0;
				return true;
			}
			if (this.bInReadBinary)
			{
				this.FinishReadBinary();
			}
			if (this.readerNav.CreatedOnAttribute)
			{
				return false;
			}
			this.ReSetReadingMarks();
			if (this.ReadNextNode(fSkipChildren))
			{
				return true;
			}
			if (this.readState == ReadState.Initial || this.readState == ReadState.Interactive)
			{
				this.readState = ReadState.Error;
			}
			if (this.readState == ReadState.EndOfFile)
			{
				this.nodeType = XmlNodeType.None;
			}
			return false;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0004E254 File Offset: 0x0004C454
		private bool ReadNextNode(bool fSkipChildren)
		{
			if (this.readState != ReadState.Interactive && this.readState != ReadState.Initial)
			{
				this.nodeType = XmlNodeType.None;
				return false;
			}
			bool flag = !fSkipChildren;
			XmlNodeType xmlNodeType = this.readerNav.NodeType;
			if (flag && this.nodeType != XmlNodeType.EndElement && this.nodeType != XmlNodeType.EndEntity && (xmlNodeType == XmlNodeType.Element || (xmlNodeType == XmlNodeType.EntityReference && this.bResolveEntity) || ((this.readerNav.NodeType == XmlNodeType.Document || this.readerNav.NodeType == XmlNodeType.DocumentFragment) && this.readState == ReadState.Initial)))
			{
				if (this.readerNav.MoveToFirstChild())
				{
					this.nodeType = this.readerNav.NodeType;
					this.curDepth++;
					if (this.bResolveEntity)
					{
						this.bResolveEntity = false;
					}
					return true;
				}
				if (this.readerNav.NodeType == XmlNodeType.Element && !this.readerNav.IsEmptyElement)
				{
					this.nodeType = XmlNodeType.EndElement;
					return true;
				}
				if (this.readerNav.NodeType == XmlNodeType.EntityReference && this.bResolveEntity)
				{
					this.bResolveEntity = false;
					this.nodeType = XmlNodeType.EndEntity;
					return true;
				}
				return this.ReadForward(fSkipChildren);
			}
			else
			{
				if (this.readerNav.NodeType == XmlNodeType.EntityReference && this.bResolveEntity)
				{
					if (this.readerNav.MoveToFirstChild())
					{
						this.nodeType = this.readerNav.NodeType;
						this.curDepth++;
					}
					else
					{
						this.nodeType = XmlNodeType.EndEntity;
					}
					this.bResolveEntity = false;
					return true;
				}
				return this.ReadForward(fSkipChildren);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0004E3D3 File Offset: 0x0004C5D3
		private void SetEndOfFile()
		{
			this.fEOF = true;
			this.readState = ReadState.EndOfFile;
			this.nodeType = XmlNodeType.None;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0004E3EA File Offset: 0x0004C5EA
		private bool ReadAtZeroLevel(bool fSkipChildren)
		{
			if (!fSkipChildren && this.nodeType != XmlNodeType.EndElement && this.readerNav.NodeType == XmlNodeType.Element && !this.readerNav.IsEmptyElement)
			{
				this.nodeType = XmlNodeType.EndElement;
				return true;
			}
			this.SetEndOfFile();
			return false;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x0004E428 File Offset: 0x0004C628
		private bool ReadForward(bool fSkipChildren)
		{
			if (this.readState == ReadState.Error)
			{
				return false;
			}
			if (!this.bStartFromDocument && this.curDepth == 0)
			{
				return this.ReadAtZeroLevel(fSkipChildren);
			}
			if (this.readerNav.MoveToNext())
			{
				this.nodeType = this.readerNav.NodeType;
				return true;
			}
			if (this.curDepth == 0)
			{
				return this.ReadAtZeroLevel(fSkipChildren);
			}
			if (!this.readerNav.MoveToParent())
			{
				return false;
			}
			if (this.readerNav.NodeType == XmlNodeType.Element)
			{
				this.curDepth--;
				this.nodeType = XmlNodeType.EndElement;
				return true;
			}
			if (this.readerNav.NodeType == XmlNodeType.EntityReference)
			{
				this.curDepth--;
				this.nodeType = XmlNodeType.EndEntity;
				return true;
			}
			return true;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x0004E4E4 File Offset: 0x0004C6E4
		private void ReSetReadingMarks()
		{
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
		}

		/// <summary>Gets a value indicating whether the reader is positioned at the end of the stream.</summary>
		/// <returns>
		///     <see langword="true" /> if the reader is positioned at the end of the stream; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0004E4FD File Offset: 0x0004C6FD
		public override bool EOF
		{
			get
			{
				return this.readState != ReadState.Closed && this.fEOF;
			}
		}

		/// <summary>Changes the <see cref="P:System.Xml.XmlNodeReader.ReadState" /> to <see langword="Closed" />.</summary>
		// Token: 0x06000C92 RID: 3218 RVA: 0x0004E510 File Offset: 0x0004C710
		public override void Close()
		{
			this.readState = ReadState.Closed;
		}

		/// <summary>Gets the state of the reader.</summary>
		/// <returns>One of the <see cref="T:System.Xml.ReadState" /> values.</returns>
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0004E519 File Offset: 0x0004C719
		public override ReadState ReadState
		{
			get
			{
				return this.readState;
			}
		}

		/// <summary>Skips the children of the current node.</summary>
		// Token: 0x06000C94 RID: 3220 RVA: 0x0004E521 File Offset: 0x0004C721
		public override void Skip()
		{
			this.Read(true);
		}

		/// <summary>Reads the contents of an element or text node as a string.</summary>
		/// <returns>The contents of the element or text-like node (This can include CDATA, Text nodes, and so on). This can be an empty string if the reader is positioned on something other than an element or text node, or if there is no more text content to return in the current context.
		///     <see langword="Note:" /> The text node can be either an element or an attribute text node.</returns>
		// Token: 0x06000C95 RID: 3221 RVA: 0x0004E52B File Offset: 0x0004C72B
		public override string ReadString()
		{
			if (this.NodeType == XmlNodeType.EntityReference && this.bResolveEntity && !this.Read())
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
			}
			return base.ReadString();
		}

		/// <summary>Gets a value indicating whether the current node has any attributes.</summary>
		/// <returns>
		///     <see langword="true" /> if the current node has attributes; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000157CE File Offset: 0x000139CE
		public override bool HasAttributes
		{
			get
			{
				return this.AttributeCount > 0;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlNameTable" /> associated with this implementation.</summary>
		/// <returns>The <see langword="XmlNameTable" /> enabling you to get the atomized version of a string within the node.</returns>
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0004E55C File Offset: 0x0004C75C
		public override XmlNameTable NameTable
		{
			get
			{
				return this.readerNav.NameTable;
			}
		}

		/// <summary>Resolves a namespace prefix in the current element's scope.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass an empty string. This string does not have to be atomized. </param>
		/// <returns>The namespace URI to which the prefix maps or <see langword="null" /> if no matching prefix is found.</returns>
		// Token: 0x06000C98 RID: 3224 RVA: 0x0004E56C File Offset: 0x0004C76C
		public override string LookupNamespace(string prefix)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			string text = this.readerNav.LookupNamespace(prefix);
			if (text != null && text.Length == 0)
			{
				return null;
			}
			return text;
		}

		/// <summary>Resolves the entity reference for <see langword="EntityReference" /> nodes.</summary>
		/// <exception cref="T:System.InvalidOperationException">The reader is not positioned on an <see langword="EntityReference" /> node. </exception>
		// Token: 0x06000C99 RID: 3225 RVA: 0x0004E59E File Offset: 0x0004C79E
		public override void ResolveEntity()
		{
			if (!this.IsInReadingStates() || this.nodeType != XmlNodeType.EntityReference)
			{
				throw new InvalidOperationException(Res.GetString("The node is not an expandable 'EntityReference' node."));
			}
			this.bResolveEntity = true;
		}

		/// <summary>Parses the attribute value into one or more <see langword="Text" />, <see langword="EntityReference" />, or <see langword="EndEntity" /> nodes.</summary>
		/// <returns>
		///     <see langword="true" /> if there are nodes to return.
		///     <see langword="false" /> if the reader is not positioned on an attribute node when the initial call is made or if all the attribute values have been read.An empty attribute, such as, misc="", returns <see langword="true" /> with a single node with a value of String.Empty.</returns>
		// Token: 0x06000C9A RID: 3226 RVA: 0x0004E5C8 File Offset: 0x0004C7C8
		public override bool ReadAttributeValue()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			if (this.readerNav.ReadAttributeValue(ref this.curDepth, ref this.bResolveEntity, ref this.nodeType))
			{
				this.bInReadBinary = false;
				return true;
			}
			return false;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0004E5FD File Offset: 0x0004C7FD
		private void FinishReadBinary()
		{
			this.bInReadBinary = false;
			this.readBinaryHelper.Finish();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.</summary>
		/// <param name="scope">
		///       <see cref="T:System.Xml.XmlNamespaceScope" /> object.</param>
		/// <returns>
		///     <see cref="T:System.Collections.IDictionary" /> object that contains the namespaces that are in scope.</returns>
		// Token: 0x06000C9C RID: 3228 RVA: 0x0004E611 File Offset: 0x0004C811
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.readerNav.GetNamespacesInScope(scope);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.</summary>
		/// <param name="namespaceName">
		///       <see cref="T:System.String" /> object that identifies the namespace.</param>
		/// <returns>
		///     <see cref="T:System.String" /> object that contains the namespace prefix.</returns>
		// Token: 0x06000C9D RID: 3229 RVA: 0x0004E61F File Offset: 0x0004C81F
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.readerNav.LookupPrefix(namespaceName);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.</summary>
		/// <param name="prefix">
		///       <see cref="T:System.String" /> that contains the namespace prefix.</param>
		/// <returns>
		///     <see cref="T:System.String" /> that contains the namespace name.</returns>
		// Token: 0x06000C9E RID: 3230 RVA: 0x0004E630 File Offset: 0x0004C830
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			if (!this.IsInReadingStates())
			{
				return this.readerNav.DefaultLookupNamespace(prefix);
			}
			string text = this.readerNav.LookupNamespace(prefix);
			if (text != null)
			{
				text = this.readerNav.NameTable.Add(text);
			}
			return text;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0004E675 File Offset: 0x0004C875
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.readerNav.Document.DtdSchemaInfo;
			}
		}

		// Token: 0x040008E1 RID: 2273
		private XmlNodeReaderNavigator readerNav;

		// Token: 0x040008E2 RID: 2274
		private XmlNodeType nodeType;

		// Token: 0x040008E3 RID: 2275
		private int curDepth;

		// Token: 0x040008E4 RID: 2276
		private ReadState readState;

		// Token: 0x040008E5 RID: 2277
		private bool fEOF;

		// Token: 0x040008E6 RID: 2278
		private bool bResolveEntity;

		// Token: 0x040008E7 RID: 2279
		private bool bStartFromDocument;

		// Token: 0x040008E8 RID: 2280
		private bool bInReadBinary;

		// Token: 0x040008E9 RID: 2281
		private ReadContentAsBinaryHelper readBinaryHelper;
	}
}
