using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.Xml.Serialization
{
	/// <summary>Represents an abstract class used for controlling serialization by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class.</summary>
	// Token: 0x02000203 RID: 515
	public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> class.</summary>
		// Token: 0x060010E8 RID: 4328 RVA: 0x0006B200 File Offset: 0x00069400
		protected XmlSerializationWriter()
		{
			this.qnameCount = 0;
			this.serializedObjects = new Hashtable();
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0006B21C File Offset: 0x0006941C
		internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss)
		{
			this.writer = writer;
			if (nss != null)
			{
				this.namespaces = new ArrayList();
				foreach (XmlQualifiedName xmlQualifiedName in nss.ToArray())
				{
					if (xmlQualifiedName.Name != "" && xmlQualifiedName.Namespace != "")
					{
						this.namespaces.Add(xmlQualifiedName);
					}
				}
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.XmlWriter" /> that is being used by the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.</summary>
		/// <returns>The <see cref="T:System.Xml.XmlWriter" /> used by the class instance.</returns>
		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0006B288 File Offset: 0x00069488
		protected XmlWriter Writer
		{
			get
			{
				return this.writer;
			}
		}

		/// <summary>Stores an implementation of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate and the type it applies to, for a later invocation.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of objects that are serialized.</param>
		/// <param name="typeName">The name of the type of objects that are serialized.</param>
		/// <param name="typeNs">The namespace of the type of objects that are serialized.</param>
		/// <param name="callback">An instance of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate.</param>
		// Token: 0x060010EB RID: 4331 RVA: 0x0006B290 File Offset: 0x00069490
		protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback)
		{
			XmlSerializationWriter.WriteCallbackInfo writeCallbackInfo = new XmlSerializationWriter.WriteCallbackInfo();
			writeCallbackInfo.Type = type;
			writeCallbackInfo.TypeName = typeName;
			writeCallbackInfo.TypeNs = typeNs;
			writeCallbackInfo.Callback = callback;
			if (this.callbacks == null)
			{
				this.callbacks = new Hashtable();
			}
			this.callbacks.Add(type, writeCallbackInfo);
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that an XML element that should adhere to the XML Schema <see langword="any" /> element declaration cannot be processed.</summary>
		/// <param name="name">The XML element that cannot be processed.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <returns>The newly created exception.</returns>
		// Token: 0x060010EC RID: 4332 RVA: 0x0006B2E0 File Offset: 0x000694E0
		protected Exception CreateUnknownAnyElementException(string name, string ns)
		{
			return new InvalidOperationException(string.Format("The XML element named '{0}' from namespace '{1}' was not expected. The XML element name and namespace must match those provided via XmlAnyElementAttribute(s).", name, ns));
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type being serialized is not being used in a valid manner or is unexpectedly encountered.</summary>
		/// <param name="o">The object whose type cannot be serialized.</param>
		/// <returns>The newly created exception.</returns>
		// Token: 0x060010ED RID: 4333 RVA: 0x0006B2F3 File Offset: 0x000694F3
		protected Exception CreateUnknownTypeException(object o)
		{
			return this.CreateUnknownTypeException(o.GetType());
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type being serialized is not being used in a valid manner or is unexpectedly encountered.</summary>
		/// <param name="type">The type that cannot be serialized.</param>
		/// <returns>The newly created exception.</returns>
		// Token: 0x060010EE RID: 4334 RVA: 0x0006B301 File Offset: 0x00069501
		protected Exception CreateUnknownTypeException(Type type)
		{
			return new InvalidOperationException(string.Format("The type {0} may not be used in this context.", type));
		}

		/// <summary>Returns an XML qualified name, with invalid characters replaced by escape sequences.</summary>
		/// <param name="xmlQualifiedName">An <see cref="T:System.Xml.XmlQualifiedName" /> that represents the XML to be written.</param>
		/// <returns>An XML qualified name, with invalid characters replaced by escape sequences.</returns>
		// Token: 0x060010EF RID: 4335 RVA: 0x0006B313 File Offset: 0x00069513
		protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName)
		{
			if (xmlQualifiedName == null || xmlQualifiedName == XmlQualifiedName.Empty)
			{
				return null;
			}
			return this.GetQualifiedName(xmlQualifiedName.Name, xmlQualifiedName.Namespace);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0006B340 File Offset: 0x00069540
		private string GetId(object o, bool addToReferencesList)
		{
			if (this.idGenerator == null)
			{
				this.idGenerator = new ObjectIDGenerator();
			}
			bool flag;
			long id = this.idGenerator.GetId(o, out flag);
			return string.Format(CultureInfo.InvariantCulture, "id{0}", id);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0006B384 File Offset: 0x00069584
		private bool AlreadyQueued(object ob)
		{
			if (this.idGenerator == null)
			{
				return false;
			}
			bool flag;
			this.idGenerator.HasId(ob, out flag);
			return !flag;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0006B3B0 File Offset: 0x000695B0
		private string GetNamespacePrefix(string ns)
		{
			string text = this.Writer.LookupPrefix(ns);
			if (text == null)
			{
				IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
				string format = "q{0}";
				int num = this.qnameCount + 1;
				this.qnameCount = num;
				text = string.Format(invariantCulture, format, num);
				this.WriteAttribute("xmlns", text, null, ns);
			}
			return text;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0006B404 File Offset: 0x00069604
		private string GetQualifiedName(string name, string ns)
		{
			if (ns == string.Empty)
			{
				return name;
			}
			string namespacePrefix = this.GetNamespacePrefix(ns);
			if (namespacePrefix == string.Empty)
			{
				return name;
			}
			return string.Format("{0}:{1}", namespacePrefix, name);
		}

		/// <summary>Initializes an instances of the <see cref="T:System.Xml.Serialization.XmlSerializationWriteCallback" /> delegate to serialize SOAP-encoded XML data.</summary>
		// Token: 0x060010F4 RID: 4340
		protected abstract void InitCallbacks();

		/// <summary>Initializes object references only while serializing a SOAP-encoded SOAP message.</summary>
		// Token: 0x060010F5 RID: 4341 RVA: 0x0006B443 File Offset: 0x00069643
		protected void TopLevelElement()
		{
			this.topLevelElement = true;
		}

		/// <summary>Writes an XML attribute.</summary>
		/// <param name="localName">The local name of the XML attribute.</param>
		/// <param name="ns">The namespace of the XML attribute.</param>
		/// <param name="value">The value of the XML attribute as a string.</param>
		// Token: 0x060010F6 RID: 4342 RVA: 0x0006B44C File Offset: 0x0006964C
		protected void WriteAttribute(string localName, string ns, string value)
		{
			this.WriteAttribute(null, localName, ns, value);
		}

		/// <summary>Writes an XML attribute where the namespace prefix is provided manually.</summary>
		/// <param name="prefix">The namespace prefix to write.</param>
		/// <param name="localName">The local name of the XML attribute.</param>
		/// <param name="ns">The namespace represented by the prefix.</param>
		/// <param name="value">The value of the XML attribute as a string.</param>
		// Token: 0x060010F7 RID: 4343 RVA: 0x0006B458 File Offset: 0x00069658
		protected void WriteAttribute(string prefix, string localName, string ns, string value)
		{
			if (value == null)
			{
				return;
			}
			this.Writer.WriteAttributeString(prefix, localName, ns, value);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0006B46F File Offset: 0x0006966F
		private void WriteXmlNode(XmlNode node)
		{
			if (node is XmlDocument)
			{
				node = ((XmlDocument)node).DocumentElement;
			}
			node.WriteTo(this.Writer);
		}

		/// <summary>Writes an XML node object within the body of a named XML element.</summary>
		/// <param name="node">The XML node to write, possibly a child XML element.</param>
		/// <param name="name">The local name of the parent XML element to write.</param>
		/// <param name="ns">The namespace of the parent XML element to write.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the object to serialize is <see langword="null" />; otherwise, <see langword="false" />.</param>
		/// <param name="any">
		///       <see langword="true" /> to indicate that the node, if an XML element, adheres to an XML Schema <see langword="any" /> element declaration; otherwise, <see langword="false" />.</param>
		// Token: 0x060010F9 RID: 4345 RVA: 0x0006B494 File Offset: 0x00069694
		protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
			if (name != string.Empty)
			{
				if (node == null)
				{
					if (isNullable)
					{
						this.WriteNullTagEncoded(name, ns);
						return;
					}
				}
				else
				{
					if (any)
					{
						this.WriteXmlNode(node);
						return;
					}
					this.Writer.WriteStartElement(name, ns);
					this.WriteXmlNode(node);
					this.Writer.WriteEndElement();
					return;
				}
			}
			else
			{
				this.WriteXmlNode(node);
			}
		}

		/// <summary>Instructs an <see cref="T:System.Xml.XmlWriter" /> object to write an <see cref="T:System.Xml.XmlNode" /> object within the body of a named XML element.</summary>
		/// <param name="node">The XML node to write, possibly a child XML element.</param>
		/// <param name="name">The local name of the parent XML element to write.</param>
		/// <param name="ns">The namespace of the parent XML element to write.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the object to serialize is <see langword="null" />; otherwise, <see langword="false" />.</param>
		/// <param name="any">
		///       <see langword="true" /> to indicate that the node, if an XML element, adheres to an XML Schema <see langword="any" /> element declaration; otherwise, <see langword="false" />.</param>
		// Token: 0x060010FA RID: 4346 RVA: 0x0006B4F4 File Offset: 0x000696F4
		protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any)
		{
			if (name != string.Empty)
			{
				if (node == null)
				{
					if (isNullable)
					{
						this.WriteNullTagLiteral(name, ns);
						return;
					}
				}
				else
				{
					if (any)
					{
						this.WriteXmlNode(node);
						return;
					}
					this.Writer.WriteStartElement(name, ns);
					this.WriteXmlNode(node);
					this.Writer.WriteEndElement();
					return;
				}
			}
			else
			{
				this.WriteXmlNode(node);
			}
		}

		/// <summary>Writes an XML element with a specified qualified name in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The name to write, using its prefix if namespace-qualified, in the element text.</param>
		// Token: 0x060010FB RID: 4347 RVA: 0x0006B551 File Offset: 0x00069751
		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value)
		{
			this.WriteElementQualifiedName(localName, ns, value, null);
		}

		/// <summary>Writes an XML element with a specified qualified name in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The name to write, using its prefix if namespace-qualified, in the element text.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the <see langword="xsi:type" /> attribute.</param>
		// Token: 0x060010FC RID: 4348 RVA: 0x0006B560 File Offset: 0x00069760
		protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
			localName = XmlCustomFormatter.FromXmlNCName(localName);
			this.WriteStartElement(localName, ns);
			if (xsiType != null)
			{
				this.WriteXsiType(xsiType.Name, xsiType.Namespace);
			}
			this.Writer.WriteString(this.FromXmlQualifiedName(value));
			this.WriteEndElement();
		}

		/// <summary>Writes an XML element with a specified value in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The text value of the XML element.</param>
		// Token: 0x060010FD RID: 4349 RVA: 0x0006B5B3 File Offset: 0x000697B3
		protected void WriteElementString(string localName, string ns, string value)
		{
			this.WriteElementString(localName, ns, value, null);
		}

		/// <summary>Writes an XML element with a specified value in its body.</summary>
		/// <param name="localName">The local name of the XML element.</param>
		/// <param name="ns">The namespace of the XML element.</param>
		/// <param name="value">The text value of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the <see langword="xsi:type" /> attribute.</param>
		// Token: 0x060010FE RID: 4350 RVA: 0x0006B5C0 File Offset: 0x000697C0
		protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType)
		{
			if (value == null)
			{
				return;
			}
			if (xsiType != null)
			{
				localName = XmlCustomFormatter.FromXmlNCName(localName);
				this.WriteStartElement(localName, ns);
				this.WriteXsiType(xsiType.Name, xsiType.Namespace);
				this.Writer.WriteString(value);
				this.WriteEndElement();
				return;
			}
			this.Writer.WriteElementString(localName, ns, value);
		}

		/// <summary>Writes a <see langword="&lt;closing&gt;" /> element tag.</summary>
		// Token: 0x060010FF RID: 4351 RVA: 0x0006B620 File Offset: 0x00069820
		protected void WriteEndElement()
		{
			this.WriteEndElement(null);
		}

		/// <summary>Writes a <see langword="&lt;closing&gt;" /> element tag.</summary>
		/// <param name="o">The object being serialized.</param>
		// Token: 0x06001100 RID: 4352 RVA: 0x0006B629 File Offset: 0x00069829
		protected void WriteEndElement(object o)
		{
			if (o != null)
			{
				this.serializedObjects.Remove(o);
			}
			this.Writer.WriteEndElement();
		}

		/// <summary>Writes the namespace declaration attributes.</summary>
		/// <param name="xmlns">The XML namespaces to declare.</param>
		// Token: 0x06001101 RID: 4353 RVA: 0x0006B648 File Offset: 0x00069848
		protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns)
		{
			if (xmlns == null)
			{
				return;
			}
			foreach (object obj in xmlns.Namespaces)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if ((string)dictionaryEntry.Value != string.Empty && this.Writer.LookupPrefix((string)dictionaryEntry.Value) != (string)dictionaryEntry.Key)
				{
					this.WriteAttribute("xmlns", (string)dictionaryEntry.Key, "http://www.w3.org/2000/xmlns/", (string)dictionaryEntry.Value);
				}
			}
		}

		/// <summary>Writes an XML element whose body contains a valid XML qualified name. <see cref="T:System.Xml.XmlWriter" /> inserts an <see langword="xsi:nil='true'" /> attribute if the string's value is <see langword="null" />.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The XML qualified name to write in the body of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the <see langword="xsi:type" /> attribute.</param>
		// Token: 0x06001102 RID: 4354 RVA: 0x0006B708 File Offset: 0x00069908
		protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType)
		{
			if (value != null)
			{
				this.WriteElementQualifiedName(name, ns, value, xsiType);
				return;
			}
			this.WriteNullTagEncoded(name, ns);
		}

		/// <summary>Writes an XML element whose body contains a valid XML qualified name. <see cref="T:System.Xml.XmlWriter" /> inserts an <see langword="xsi:nil='true'" /> attribute if the string's value is <see langword="null" />.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The XML qualified name to write in the body of the XML element.</param>
		// Token: 0x06001103 RID: 4355 RVA: 0x0006B727 File Offset: 0x00069927
		protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value)
		{
			if (value != null)
			{
				this.WriteElementQualifiedName(name, ns, value);
				return;
			}
			this.WriteNullTagLiteral(name, ns);
		}

		/// <summary>Writes an XML element that contains a string as the body. <see cref="T:System.Xml.XmlWriter" /> inserts an <see langword="xsi:nil='true'" /> attribute if the string's value is <see langword="null" />.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The string to write in the body of the XML element.</param>
		/// <param name="xsiType">The name of the XML Schema data type to be written to the <see langword="xsi:type" /> attribute.</param>
		// Token: 0x06001104 RID: 4356 RVA: 0x0006B744 File Offset: 0x00069944
		protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType)
		{
			if (value != null)
			{
				this.WriteElementString(name, ns, value, xsiType);
				return;
			}
			this.WriteNullTagEncoded(name, ns);
		}

		/// <summary>Writes an XML element that contains a string as the body. <see cref="T:System.Xml.XmlWriter" /> inserts an <see langword="xsi:nil='true'" /> attribute if the string's value is <see langword="null" />.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="value">The string to write in the body of the XML element.</param>
		// Token: 0x06001105 RID: 4357 RVA: 0x0006B75D File Offset: 0x0006995D
		protected void WriteNullableStringLiteral(string name, string ns, string value)
		{
			if (value != null)
			{
				this.WriteElementString(name, ns, value, null);
				return;
			}
			this.WriteNullTagLiteral(name, ns);
		}

		/// <summary>Writes an XML element with an <see langword="xsi:nil='true'" /> attribute.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		// Token: 0x06001106 RID: 4358 RVA: 0x0006B775 File Offset: 0x00069975
		protected void WriteNullTagEncoded(string name, string ns)
		{
			this.Writer.WriteStartElement(name, ns);
			this.Writer.WriteAttributeString("nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
			this.Writer.WriteEndElement();
		}

		/// <summary>Writes an XML element with an <see langword="xsi:nil='true'" /> attribute.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		// Token: 0x06001107 RID: 4359 RVA: 0x0006B7A9 File Offset: 0x000699A9
		protected void WriteNullTagLiteral(string name, string ns)
		{
			this.WriteStartElement(name, ns);
			this.Writer.WriteAttributeString("nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
			this.WriteEndElement();
		}

		/// <summary>Writes a SOAP message XML element that can contain a reference to a <see langword="multiRef" /> XML element for a given object.</summary>
		/// <param name="n">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized either in the current XML element or a <see langword="multiRef" /> element that referenced by the current element.</param>
		/// <param name="ambientType">The type stored in the object's type mapping (as opposed to the object's type found directly through the <see langword="typeof" /> operation).</param>
		/// <param name="suppressReference">
		///       <see langword="true" /> to serialize the object directly into the XML element rather than make the element reference another element that contains the data; otherwise, <see langword="false" />.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the object to serialize is <see langword="null" />; otherwise, <see langword="false" />.</param>
		// Token: 0x06001108 RID: 4360 RVA: 0x0006B7D4 File Offset: 0x000699D4
		protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable)
		{
			if (o == null)
			{
				if (isNullable)
				{
					this.WriteNullTagEncoded(n, ns);
				}
				return;
			}
			Type type = o.GetType();
			this.WriteStartElement(n, ns, true);
			this.CheckReferenceQueue();
			if (this.callbacks != null && this.callbacks.ContainsKey(o.GetType()))
			{
				XmlSerializationWriter.WriteCallbackInfo writeCallbackInfo = (XmlSerializationWriter.WriteCallbackInfo)this.callbacks[type];
				if (type.IsEnum)
				{
					writeCallbackInfo.Callback(o);
				}
				else if (suppressReference)
				{
					this.Writer.WriteAttributeString("id", this.GetId(o, false));
					if (ambientType != type)
					{
						this.WriteXsiType(writeCallbackInfo.TypeName, writeCallbackInfo.TypeNs);
					}
					writeCallbackInfo.Callback(o);
				}
				else
				{
					if (!this.AlreadyQueued(o))
					{
						this.referencedElements.Enqueue(o);
					}
					this.Writer.WriteAttributeString("href", "#" + this.GetId(o, true));
				}
			}
			else
			{
				TypeData typeData = TypeTranslator.GetTypeData(type, null, true);
				if (typeData.SchemaType == SchemaTypes.Primitive)
				{
					if (type != ambientType)
					{
						this.WriteXsiType(typeData.XmlType, "http://www.w3.org/2001/XMLSchema");
					}
					this.Writer.WriteString(XmlCustomFormatter.ToXmlString(typeData, o));
				}
				else
				{
					if (!this.IsPrimitiveArray(typeData))
					{
						throw new InvalidOperationException("Invalid type: " + type.FullName);
					}
					if (!this.AlreadyQueued(o))
					{
						this.referencedElements.Enqueue(o);
					}
					this.Writer.WriteAttributeString("href", "#" + this.GetId(o, true));
				}
			}
			this.WriteEndElement();
		}

		/// <summary>Serializes objects into SOAP-encoded <see langword="multiRef" /> XML elements in a SOAP message.</summary>
		// Token: 0x06001109 RID: 4361 RVA: 0x0006B978 File Offset: 0x00069B78
		protected void WriteReferencedElements()
		{
			if (this.referencedElements == null)
			{
				return;
			}
			if (this.callbacks == null)
			{
				return;
			}
			while (this.referencedElements.Count > 0)
			{
				object obj = this.referencedElements.Dequeue();
				TypeData typeData = TypeTranslator.GetTypeData(obj.GetType());
				XmlSerializationWriter.WriteCallbackInfo writeCallbackInfo = (XmlSerializationWriter.WriteCallbackInfo)this.callbacks[obj.GetType()];
				if (writeCallbackInfo != null)
				{
					this.WriteStartElement(writeCallbackInfo.TypeName, writeCallbackInfo.TypeNs, true);
					this.Writer.WriteAttributeString("id", this.GetId(obj, false));
					if (typeData.SchemaType != SchemaTypes.Array)
					{
						this.WriteXsiType(writeCallbackInfo.TypeName, writeCallbackInfo.TypeNs);
					}
					writeCallbackInfo.Callback(obj);
					this.WriteEndElement();
				}
				else if (this.IsPrimitiveArray(typeData))
				{
					this.WriteArray(obj, typeData);
				}
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0006BA48 File Offset: 0x00069C48
		private bool IsPrimitiveArray(TypeData td)
		{
			return td.SchemaType == SchemaTypes.Array && (td.ListItemTypeData.SchemaType == SchemaTypes.Primitive || td.ListItemType == typeof(object) || this.IsPrimitiveArray(td.ListItemTypeData));
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0006BA88 File Offset: 0x00069C88
		private void WriteArray(object o, TypeData td)
		{
			TypeData typeData = td;
			int num = -1;
			string text;
			do
			{
				typeData = typeData.ListItemTypeData;
				text = typeData.XmlType;
				num++;
			}
			while (typeData.SchemaType == SchemaTypes.Array);
			while (num-- > 0)
			{
				text += "[]";
			}
			this.WriteStartElement("Array", "http://schemas.xmlsoap.org/soap/encoding/", true);
			this.Writer.WriteAttributeString("id", this.GetId(o, false));
			if (td.SchemaType == SchemaTypes.Array)
			{
				Array array = (Array)o;
				int length = array.Length;
				this.Writer.WriteAttributeString("arrayType", "http://schemas.xmlsoap.org/soap/encoding/", this.GetQualifiedName(text, "http://www.w3.org/2001/XMLSchema") + "[" + length.ToString() + "]");
				for (int i = 0; i < length; i++)
				{
					this.WritePotentiallyReferencingElement("Item", "", array.GetValue(i), td.ListItemType, false, true);
				}
			}
			this.WriteEndElement();
		}

		/// <summary>Writes a SOAP message XML element that contains a reference to a <see langword="multiRef" /> element for a given object.</summary>
		/// <param name="n">The local name of the referencing element being written.</param>
		/// <param name="ns">The namespace of the referencing element being written.</param>
		/// <param name="o">The object being serialized.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the object to serialize is <see langword="null" />; otherwise, <see langword="false" />.</param>
		// Token: 0x0600110C RID: 4364 RVA: 0x0006BB7C File Offset: 0x00069D7C
		protected void WriteReferencingElement(string n, string ns, object o, bool isNullable)
		{
			if (o == null)
			{
				if (isNullable)
				{
					this.WriteNullTagEncoded(n, ns);
				}
				return;
			}
			this.CheckReferenceQueue();
			if (!this.AlreadyQueued(o))
			{
				this.referencedElements.Enqueue(o);
			}
			this.Writer.WriteStartElement(n, ns);
			this.Writer.WriteAttributeString("href", "#" + this.GetId(o, true));
			this.Writer.WriteEndElement();
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0006BBEE File Offset: 0x00069DEE
		private void CheckReferenceQueue()
		{
			if (this.referencedElements == null)
			{
				this.referencedElements = new Queue();
				this.InitCallbacks();
			}
		}

		/// <summary>Writes an object that uses custom XML formatting as an XML element.</summary>
		/// <param name="serializable">An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface that uses custom XML formatting.</param>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> class object is <see langword="null" />; otherwise, <see langword="false" />.</param>
		// Token: 0x0600110E RID: 4366 RVA: 0x0006BC09 File Offset: 0x00069E09
		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable)
		{
			this.WriteSerializable(serializable, name, ns, isNullable, true);
		}

		/// <summary>Instructs <see cref="T:System.Xml.XmlNode" /> to write an object that uses custom XML formatting as an XML element.</summary>
		/// <param name="serializable">An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface that uses custom XML formatting.</param>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> to write an <see langword="xsi:nil='true'" /> attribute if the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> object is <see langword="null" />; otherwise, <see langword="false" />.</param>
		/// <param name="wrapped">
		///       <see langword="true" /> to ignore writing the opening element tag; otherwise, <see langword="false" /> to write the opening element tag.</param>
		// Token: 0x0600110F RID: 4367 RVA: 0x0006BC18 File Offset: 0x00069E18
		protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped)
		{
			if (serializable == null)
			{
				if (isNullable && wrapped)
				{
					this.WriteNullTagLiteral(name, ns);
				}
				return;
			}
			if (wrapped)
			{
				this.Writer.WriteStartElement(name, ns);
			}
			serializable.WriteXml(this.Writer);
			if (wrapped)
			{
				this.Writer.WriteEndElement();
			}
		}

		/// <summary>Writes the XML declaration if the writer is positioned at the start of an XML document.</summary>
		// Token: 0x06001110 RID: 4368 RVA: 0x0006BC64 File Offset: 0x00069E64
		protected void WriteStartDocument()
		{
			if (this.Writer.WriteState == WriteState.Start)
			{
				this.Writer.WriteStartDocument();
			}
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		// Token: 0x06001111 RID: 4369 RVA: 0x0006BC7E File Offset: 0x00069E7E
		protected void WriteStartElement(string name, string ns)
		{
			this.WriteStartElement(name, ns, null, false);
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="writePrefixed">
		///       <see langword="true" /> to write the element name with a prefix if none is available for the specified namespace; otherwise, <see langword="false" />.</param>
		// Token: 0x06001112 RID: 4370 RVA: 0x0006BC8A File Offset: 0x00069E8A
		protected void WriteStartElement(string name, string ns, bool writePrefixed)
		{
			this.WriteStartElement(name, ns, null, writePrefixed);
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized as an XML element.</param>
		// Token: 0x06001113 RID: 4371 RVA: 0x0006BC96 File Offset: 0x00069E96
		protected void WriteStartElement(string name, string ns, object o)
		{
			this.WriteStartElement(name, ns, o, false);
		}

		/// <summary>Writes an opening element tag, including any attributes.</summary>
		/// <param name="name">The local name of the XML element to write.</param>
		/// <param name="ns">The namespace of the XML element to write.</param>
		/// <param name="o">The object being serialized as an XML element.</param>
		/// <param name="writePrefixed">
		///       <see langword="true" /> to write the element name with a prefix if none is available for the specified namespace; otherwise, <see langword="false" />.</param>
		// Token: 0x06001114 RID: 4372 RVA: 0x0006BCA2 File Offset: 0x00069EA2
		protected void WriteStartElement(string name, string ns, object o, bool writePrefixed)
		{
			this.WriteStartElement(name, ns, o, writePrefixed, this.namespaces);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0006BCB8 File Offset: 0x00069EB8
		private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces)
		{
			if (o != null)
			{
				if (this.serializedObjects.Contains(o))
				{
					throw new InvalidOperationException("A circular reference was detected while serializing an object of type " + o.GetType().Name);
				}
				this.serializedObjects[o] = o;
			}
			string text = null;
			if (this.topLevelElement && ns != null && ns.Length != 0 && namespaces != null)
			{
				foreach (object obj in namespaces)
				{
					XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
					if (xmlQualifiedName.Namespace == ns)
					{
						text = xmlQualifiedName.Name;
						writePrefixed = true;
						break;
					}
				}
			}
			if (writePrefixed && ns != string.Empty)
			{
				name = XmlCustomFormatter.FromXmlName(name);
				if (text == null)
				{
					text = this.Writer.LookupPrefix(ns);
				}
				if (text == null || text.Length == 0)
				{
					string str = "q";
					int num = this.qnameCount + 1;
					this.qnameCount = num;
					text = str + num.ToString();
				}
				this.Writer.WriteStartElement(text, name, ns);
			}
			else
			{
				this.Writer.WriteStartElement(name, ns);
			}
			if (this.topLevelElement)
			{
				if (namespaces != null)
				{
					foreach (object obj2 in namespaces)
					{
						XmlQualifiedName xmlQualifiedName2 = (XmlQualifiedName)obj2;
						string text2 = this.Writer.LookupPrefix(xmlQualifiedName2.Namespace);
						if (text2 == null || text2.Length == 0)
						{
							this.WriteAttribute("xmlns", xmlQualifiedName2.Name, "http://www.w3.org/2000/xmlns/", xmlQualifiedName2.Namespace);
						}
					}
				}
				this.topLevelElement = false;
			}
		}

		/// <summary>Writes an XML element whose text body is a value of a simple XML Schema data type.</summary>
		/// <param name="name">The local name of the element to write.</param>
		/// <param name="ns">The namespace of the element to write.</param>
		/// <param name="o">The object to be serialized in the element body.</param>
		/// <param name="xsiType">
		///       <see langword="true" /> if the XML element explicitly specifies the text value's type using the <see langword="xsi:type" /> attribute; otherwise, <see langword="false" />.</param>
		// Token: 0x06001116 RID: 4374 RVA: 0x0006BE78 File Offset: 0x0006A078
		protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType)
		{
			TypeData typeData = TypeTranslator.GetTypeData(o.GetType(), null, true);
			if (typeData.SchemaType != SchemaTypes.Primitive)
			{
				throw new InvalidOperationException(string.Format("The type of the argument object '{0}' is not primitive.", typeData.FullTypeName));
			}
			if (name == null)
			{
				ns = (typeData.IsXsdType ? "http://www.w3.org/2001/XMLSchema" : "http://microsoft.com/wsdl/types/");
				name = typeData.XmlType;
			}
			else
			{
				name = XmlCustomFormatter.FromXmlName(name);
			}
			this.Writer.WriteStartElement(name, ns);
			string value;
			if (o is XmlQualifiedName)
			{
				value = this.FromXmlQualifiedName((XmlQualifiedName)o);
			}
			else
			{
				value = XmlCustomFormatter.ToXmlString(typeData, o);
			}
			if (xsiType)
			{
				if (typeData.SchemaType != SchemaTypes.Primitive)
				{
					throw new InvalidOperationException(string.Format("The type {0} was not expected. Use the XmlInclude or SoapInclude attribute to specify types that are not known statically.", o.GetType().FullName));
				}
				this.WriteXsiType(typeData.XmlType, typeData.IsXsdType ? "http://www.w3.org/2001/XMLSchema" : "http://microsoft.com/wsdl/types/");
			}
			this.WriteValue(value);
			this.Writer.WriteEndElement();
		}

		/// <summary>Writes a specified string value.</summary>
		/// <param name="value">The value of the string to write.</param>
		// Token: 0x06001117 RID: 4375 RVA: 0x0006BF63 File Offset: 0x0006A163
		protected void WriteValue(string value)
		{
			if (value != null)
			{
				this.Writer.WriteString(value);
			}
		}

		/// <summary>Writes the specified <see cref="T:System.Xml.XmlNode" /> object as an XML attribute.</summary>
		/// <param name="node">The XML node to write.</param>
		/// <param name="container">An <see cref="T:System.Xml.Schema.XmlSchemaObject" /> object (or <see langword="null" />) used to generate a qualified name value for an <see langword="arrayType" /> attribute from the Web Services Description Language (WSDL) namespace ("http://schemas.xmlsoap.org/wsdl/").</param>
		// Token: 0x06001118 RID: 4376 RVA: 0x0006BF74 File Offset: 0x0006A174
		protected void WriteXmlAttribute(XmlNode node, object container)
		{
			XmlAttribute xmlAttribute = node as XmlAttribute;
			if (xmlAttribute == null)
			{
				throw new InvalidOperationException("The node must be either type XmlAttribute or a derived type.");
			}
			if (xmlAttribute.NamespaceURI == "http://schemas.xmlsoap.org/wsdl/" && xmlAttribute.LocalName == "arrayType")
			{
				string str;
				string ns;
				string str2;
				TypeTranslator.ParseArrayType(xmlAttribute.Value, out str, out ns, out str2);
				string qualifiedName = this.GetQualifiedName(str + str2, ns);
				this.WriteAttribute(xmlAttribute.Prefix, xmlAttribute.LocalName, xmlAttribute.NamespaceURI, qualifiedName);
				return;
			}
			this.WriteAttribute(xmlAttribute.Prefix, xmlAttribute.LocalName, xmlAttribute.NamespaceURI, xmlAttribute.Value);
		}

		/// <summary>Writes an <see langword="xsi:type" /> attribute for an XML element that is being serialized into a document.</summary>
		/// <param name="name">The local name of an XML Schema data type.</param>
		/// <param name="ns">The namespace of an XML Schema data type.</param>
		// Token: 0x06001119 RID: 4377 RVA: 0x0006C014 File Offset: 0x0006A214
		protected void WriteXsiType(string name, string ns)
		{
			if (ns != null && ns != string.Empty)
			{
				this.WriteAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", this.GetQualifiedName(name, ns));
				return;
			}
			this.WriteAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", name);
		}

		// Token: 0x04000BC7 RID: 3015
		private ObjectIDGenerator idGenerator;

		// Token: 0x04000BC8 RID: 3016
		private int qnameCount;

		// Token: 0x04000BC9 RID: 3017
		private bool topLevelElement;

		// Token: 0x04000BCA RID: 3018
		private ArrayList namespaces;

		// Token: 0x04000BCB RID: 3019
		private XmlWriter writer;

		// Token: 0x04000BCC RID: 3020
		private Queue referencedElements;

		// Token: 0x04000BCD RID: 3021
		private Hashtable callbacks;

		// Token: 0x04000BCE RID: 3022
		private Hashtable serializedObjects;

		// Token: 0x02000204 RID: 516
		private class WriteCallbackInfo
		{
			// Token: 0x04000BCF RID: 3023
			public Type Type;

			// Token: 0x04000BD0 RID: 3024
			public string TypeName;

			// Token: 0x04000BD1 RID: 3025
			public string TypeNs;

			// Token: 0x04000BD2 RID: 3026
			public XmlSerializationWriteCallback Callback;
		}
	}
}
