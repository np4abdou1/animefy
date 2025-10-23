using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace System.Xml.XPath
{
	/// <summary>Provides a cursor model for navigating and editing XML data.</summary>
	// Token: 0x020001C4 RID: 452
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XPathNavigator : XPathItem, IXmlNamespaceResolver
	{
		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaType" /> information for the current node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object; default is <see langword="null" />.</returns>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000622A8 File Offset: 0x000604A8
		public override XmlSchemaType XmlType
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo == null || schemaInfo.Validity != XmlSchemaValidity.Valid)
				{
					return null;
				}
				XmlSchemaType memberType = schemaInfo.MemberType;
				if (memberType != null)
				{
					return memberType;
				}
				return schemaInfo.SchemaType;
			}
		}

		/// <summary>Gets the current node as a boxed object of the most appropriate .NET Framework type.</summary>
		/// <returns>The current node as a boxed object of the most appropriate .NET Framework type.</returns>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000622DC File Offset: 0x000604DC
		public override object TypedValue
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ChangeType(this.Value, datatype.ValueType, this);
							}
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ChangeType(datatype.ParseValue(this.Value, this.NameTable, this), datatype.ValueType, this);
							}
						}
					}
				}
				return this.Value;
			}
		}

		/// <summary>Gets the .NET Framework <see cref="T:System.Type" /> of the current node.</summary>
		/// <returns>The .NET Framework <see cref="T:System.Type" /> of the current node. The default value is <see cref="T:System.String" />.</returns>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00062374 File Offset: 0x00060574
		public override Type ValueType
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return datatype.ValueType;
							}
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return datatype.ValueType;
							}
						}
					}
				}
				return typeof(string);
			}
		}

		/// <summary>Gets the current node's value as a <see cref="T:System.Boolean" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.Boolean" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Boolean" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Boolean" /> is not valid.</exception>
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x000623E0 File Offset: 0x000605E0
		public override bool ValueAsBoolean
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToBoolean(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToBoolean(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToBoolean(this.Value);
			}
		}

		/// <summary>Gets the current node's value as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.DateTime" /> is not valid.</exception>
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0006246C File Offset: 0x0006066C
		public override DateTime ValueAsDateTime
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToDateTime(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToDateTime(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToDateTime(this.Value);
			}
		}

		/// <summary>Gets the current node's value as a <see cref="T:System.Double" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.Double" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Double" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Double" /> is not valid.</exception>
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x000624F8 File Offset: 0x000606F8
		public override double ValueAsDouble
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToDouble(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToDouble(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToDouble(this.Value);
			}
		}

		/// <summary>Gets the current node's value as an <see cref="T:System.Int32" />.</summary>
		/// <returns>The current node's value as an <see cref="T:System.Int32" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Int32" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int32" /> is not valid.</exception>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00062584 File Offset: 0x00060784
		public override int ValueAsInt
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToInt32(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToInt32(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToInt32(this.Value);
			}
		}

		/// <summary>Gets the current node's value as an <see cref="T:System.Int64" />.</summary>
		/// <returns>The current node's value as an <see cref="T:System.Int64" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Int64" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int64" /> is not valid.</exception>
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00062610 File Offset: 0x00060810
		public override long ValueAsLong
		{
			get
			{
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				if (schemaInfo != null)
				{
					if (schemaInfo.Validity == XmlSchemaValidity.Valid)
					{
						XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
						if (xmlSchemaType == null)
						{
							xmlSchemaType = schemaInfo.SchemaType;
						}
						if (xmlSchemaType != null)
						{
							return xmlSchemaType.ValueConverter.ToInt64(this.Value);
						}
					}
					else
					{
						XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
						if (xmlSchemaType != null)
						{
							XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
							if (datatype != null)
							{
								return xmlSchemaType.ValueConverter.ToInt64(datatype.ParseValue(this.Value, this.NameTable, this));
							}
						}
					}
				}
				return XmlUntypedConverter.Untyped.ToInt64(this.Value);
			}
		}

		/// <summary>Gets the current node's value as the <see cref="T:System.Type" /> specified, using the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object specified to resolve namespace prefixes.</summary>
		/// <param name="returnType">The <see cref="T:System.Type" /> to return the current node's value as.</param>
		/// <param name="nsResolver">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used to resolve namespace prefixes.</param>
		/// <returns>The value of the current node as the <see cref="T:System.Type" /> requested.</returns>
		/// <exception cref="T:System.FormatException">The current node's value is not in the correct format for the target type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast is not valid.</exception>
		// Token: 0x06000F66 RID: 3942 RVA: 0x0006269C File Offset: 0x0006089C
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			if (nsResolver == null)
			{
				nsResolver = this;
			}
			IXmlSchemaInfo schemaInfo = this.SchemaInfo;
			if (schemaInfo != null)
			{
				if (schemaInfo.Validity == XmlSchemaValidity.Valid)
				{
					XmlSchemaType xmlSchemaType = schemaInfo.MemberType;
					if (xmlSchemaType == null)
					{
						xmlSchemaType = schemaInfo.SchemaType;
					}
					if (xmlSchemaType != null)
					{
						return xmlSchemaType.ValueConverter.ChangeType(this.Value, returnType, nsResolver);
					}
				}
				else
				{
					XmlSchemaType xmlSchemaType = schemaInfo.SchemaType;
					if (xmlSchemaType != null)
					{
						XmlSchemaDatatype datatype = xmlSchemaType.Datatype;
						if (datatype != null)
						{
							return xmlSchemaType.ValueConverter.ChangeType(datatype.ParseValue(this.Value, this.NameTable, nsResolver), returnType, nsResolver);
						}
					}
				}
			}
			return XmlUntypedConverter.Untyped.ChangeType(this.Value, returnType, nsResolver);
		}

		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XmlNameTable" /> of the <see cref="T:System.Xml.XPath.XPathNavigator" />.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlNameTable" /> object enabling you to get the atomized version of a <see cref="T:System.String" /> within the XML document.</returns>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000F67 RID: 3943
		public abstract XmlNameTable NameTable { get; }

		/// <summary>Gets the namespace URI for the specified prefix.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass <see cref="F:System.String.Empty" />.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace URI assigned to the namespace prefix specified; <see langword="null" /> if no namespace URI is assigned to the prefix specified. The <see cref="T:System.String" /> returned is atomized.</returns>
		// Token: 0x06000F68 RID: 3944 RVA: 0x00062734 File Offset: 0x00060934
		public virtual string LookupNamespace(string prefix)
		{
			if (prefix == null)
			{
				return null;
			}
			if (this.NodeType != XPathNodeType.Element)
			{
				XPathNavigator xpathNavigator = this.Clone();
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.LookupNamespace(prefix);
				}
			}
			else if (this.MoveToNamespace(prefix))
			{
				string value = this.Value;
				this.MoveToParent();
				return value;
			}
			if (prefix.Length == 0)
			{
				return string.Empty;
			}
			if (prefix == "xml")
			{
				return "http://www.w3.org/XML/1998/namespace";
			}
			if (prefix == "xmlns")
			{
				return "http://www.w3.org/2000/xmlns/";
			}
			return null;
		}

		/// <summary>Gets the prefix declared for the specified namespace URI.</summary>
		/// <param name="namespaceURI">The namespace URI to resolve for the prefix.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace prefix assigned to the namespace URI specified; otherwise, <see cref="F:System.String.Empty" /> if no prefix is assigned to the namespace URI specified. The <see cref="T:System.String" /> returned is atomized.</returns>
		// Token: 0x06000F69 RID: 3945 RVA: 0x000627B4 File Offset: 0x000609B4
		public virtual string LookupPrefix(string namespaceURI)
		{
			if (namespaceURI == null)
			{
				return null;
			}
			XPathNavigator xpathNavigator = this.Clone();
			if (this.NodeType != XPathNodeType.Element)
			{
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.LookupPrefix(namespaceURI);
				}
			}
			else if (xpathNavigator.MoveToFirstNamespace(XPathNamespaceScope.All))
			{
				while (!(namespaceURI == xpathNavigator.Value))
				{
					if (!xpathNavigator.MoveToNextNamespace(XPathNamespaceScope.All))
					{
						goto IL_4C;
					}
				}
				return xpathNavigator.LocalName;
			}
			IL_4C:
			if (namespaceURI == this.LookupNamespace(string.Empty))
			{
				return string.Empty;
			}
			if (namespaceURI == "http://www.w3.org/XML/1998/namespace")
			{
				return "xml";
			}
			if (namespaceURI == "http://www.w3.org/2000/xmlns/")
			{
				return "xmlns";
			}
			return null;
		}

		/// <summary>Returns the in-scope namespaces of the current node.</summary>
		/// <param name="scope">An <see cref="T:System.Xml.XmlNamespaceScope" /> value specifying the namespaces to return.</param>
		/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> collection of namespace names keyed by prefix.</returns>
		// Token: 0x06000F6A RID: 3946 RVA: 0x00062850 File Offset: 0x00060A50
		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			XPathNodeType nodeType = this.NodeType;
			if ((nodeType != XPathNodeType.Element && scope != XmlNamespaceScope.Local) || nodeType == XPathNodeType.Attribute || nodeType == XPathNodeType.Namespace)
			{
				XPathNavigator xpathNavigator = this.Clone();
				if (xpathNavigator.MoveToParent())
				{
					return xpathNavigator.GetNamespacesInScope(scope);
				}
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			if (scope == XmlNamespaceScope.All)
			{
				dictionary["xml"] = "http://www.w3.org/XML/1998/namespace";
			}
			if (this.MoveToFirstNamespace((XPathNamespaceScope)scope))
			{
				do
				{
					string localName = this.LocalName;
					string value = this.Value;
					if (localName.Length != 0 || value.Length != 0 || scope == XmlNamespaceScope.Local)
					{
						dictionary[localName] = value;
					}
				}
				while (this.MoveToNextNamespace((XPathNamespaceScope)scope));
				this.MoveToParent();
			}
			return dictionary;
		}

		/// <summary>When overridden in a derived class, creates a new <see cref="T:System.Xml.XPath.XPathNavigator" /> positioned at the same node as this <see cref="T:System.Xml.XPath.XPathNavigator" />.</summary>
		/// <returns>A new <see cref="T:System.Xml.XPath.XPathNavigator" /> positioned at the same node as this <see cref="T:System.Xml.XPath.XPathNavigator" />.</returns>
		// Token: 0x06000F6B RID: 3947
		public abstract XPathNavigator Clone();

		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XPath.XPathNodeType" /> of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XPath.XPathNodeType" /> values representing the current node.</returns>
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000F6C RID: 3948
		public abstract XPathNodeType NodeType { get; }

		/// <summary>When overridden in a derived class, gets the <see cref="P:System.Xml.XPath.XPathNavigator.Name" /> of the current node without any namespace prefix.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the local name of the current node, or <see cref="F:System.String.Empty" /> if the current node does not have a name (for example, text or comment nodes).</returns>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000F6D RID: 3949
		public abstract string LocalName { get; }

		/// <summary>Moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the namespace node with the specified namespace prefix.</summary>
		/// <param name="name">The namespace prefix of the namespace node.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the specified namespace; <see langword="false" /> if a matching namespace node was not found, or if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is not positioned on an element node. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		// Token: 0x06000F6E RID: 3950 RVA: 0x000628EB File Offset: 0x00060AEB
		public virtual bool MoveToNamespace(string name)
		{
			if (this.MoveToFirstNamespace(XPathNamespaceScope.All))
			{
				while (!(name == this.LocalName))
				{
					if (!this.MoveToNextNamespace(XPathNamespaceScope.All))
					{
						this.MoveToParent();
						return false;
					}
				}
				return true;
			}
			return false;
		}

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the first namespace node that matches the <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> specified.</summary>
		/// <param name="namespaceScope">An <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> value describing the namespace scope. </param>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the first namespace node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		// Token: 0x06000F6F RID: 3951
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the next namespace node matching the <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> specified.</summary>
		/// <param name="namespaceScope">An <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> value describing the namespace scope. </param>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the next namespace node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		// Token: 0x06000F70 RID: 3952
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the parent node of the current node.</summary>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the parent node of the current node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		// Token: 0x06000F71 RID: 3953
		public abstract bool MoveToParent();

		/// <summary>Gets the schema information that has been assigned to the current node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object that contains the schema information for the current node.</returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0001524F File Offset: 0x0001344F
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this as IXmlSchemaInfo;
			}
		}
	}
}
