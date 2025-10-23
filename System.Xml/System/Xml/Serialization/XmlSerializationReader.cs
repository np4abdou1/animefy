using System;
using System.Collections;
using System.Globalization;

namespace System.Xml.Serialization
{
	/// <summary>Controls deserialization by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class. </summary>
	// Token: 0x020001FA RID: 506
	public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
	{
		// Token: 0x06001077 RID: 4215 RVA: 0x0006810C File Offset: 0x0006630C
		internal void Initialize(XmlReader reader, XmlSerializer eventSource)
		{
			this.w3SchemaNS = reader.NameTable.Add("http://www.w3.org/2001/XMLSchema");
			this.w3InstanceNS = reader.NameTable.Add("http://www.w3.org/2001/XMLSchema-instance");
			this.w3InstanceNS2000 = reader.NameTable.Add("http://www.w3.org/2000/10/XMLSchema-instance");
			this.w3InstanceNS1999 = reader.NameTable.Add("http://www.w3.org/1999/XMLSchema-instance");
			this.soapNS = reader.NameTable.Add("http://schemas.xmlsoap.org/soap/encoding/");
			this.wsdlNS = reader.NameTable.Add("http://schemas.xmlsoap.org/wsdl/");
			this.nullX = reader.NameTable.Add("null");
			this.nil = reader.NameTable.Add("nil");
			this.typeX = reader.NameTable.Add("type");
			this.arrayType = reader.NameTable.Add("arrayType");
			this.reader = reader;
			this.eventSource = eventSource;
			this.arrayQName = new XmlQualifiedName("Array", this.soapNS);
			this.InitIDs();
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0006821F File Offset: 0x0006641F
		private ArrayList EnsureArrayList(ArrayList list)
		{
			if (list == null)
			{
				list = new ArrayList();
			}
			return list;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0006822C File Offset: 0x0006642C
		private Hashtable EnsureHashtable(Hashtable hash)
		{
			if (hash == null)
			{
				hash = new Hashtable();
			}
			return hash;
		}

		/// <summary>Gets the XML document object into which the XML document is being deserialized. </summary>
		/// <returns>An <see cref="T:System.Xml.XmlDocument" /> that represents the deserialized <see cref="T:System.Xml.XmlDocument" /> data.</returns>
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00068241 File Offset: 0x00066441
		protected XmlDocument Document
		{
			get
			{
				if (this.document == null)
				{
					this.document = new XmlDocument(this.reader.NameTable);
				}
				return this.document;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.XmlReader" /> object that is being used by <see cref="T:System.Xml.Serialization.XmlSerializationReader" />. </summary>
		/// <returns>The <see cref="T:System.Xml.XmlReader" /> that is being used by the <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.</returns>
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00068267 File Offset: 0x00066467
		protected XmlReader Reader
		{
			get
			{
				return this.reader;
			}
		}

		/// <summary>Stores an object that contains a callback method that will be called, as necessary, to fill in .NET Framework collections or enumerations that map to SOAP-encoded arrays or SOAP-encoded, multi-referenced elements. </summary>
		/// <param name="fixup">A <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate and the callback method's input data.</param>
		// Token: 0x0600107D RID: 4221 RVA: 0x00068270 File Offset: 0x00066470
		protected void AddFixup(XmlSerializationReader.CollectionFixup fixup)
		{
			this.collFixups = this.EnsureHashtable(this.collFixups);
			this.collFixups[fixup.Id] = fixup;
			if (this.delayedListFixups != null && this.delayedListFixups.ContainsKey(fixup.Id))
			{
				fixup.CollectionItems = this.delayedListFixups[fixup.Id];
				this.delayedListFixups.Remove(fixup.Id);
			}
		}

		/// <summary>Stores an object that contains a callback method instance that will be called, as necessary, to fill in the objects in a SOAP-encoded array. </summary>
		/// <param name="fixup">An <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate and the callback method's input data.</param>
		// Token: 0x0600107E RID: 4222 RVA: 0x000682E4 File Offset: 0x000664E4
		protected void AddFixup(XmlSerializationReader.Fixup fixup)
		{
			this.fixups = this.EnsureArrayList(this.fixups);
			this.fixups.Add(fixup);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00068305 File Offset: 0x00066505
		private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup)
		{
			this.collItemFixups = this.EnsureArrayList(this.collItemFixups);
			this.collItemFixups.Add(fixup);
		}

		/// <summary>Stores an implementation of the <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" /> delegate and its input data for a later invocation. </summary>
		/// <param name="name">The name of the .NET Framework type that is being deserialized.</param>
		/// <param name="ns">The namespace of the .NET Framework type that is being deserialized.</param>
		/// <param name="type">The <see cref="T:System.Type" /> to be deserialized.</param>
		/// <param name="read">An <see cref="T:System.Xml.Serialization.XmlSerializationReadCallback" /> delegate.</param>
		// Token: 0x06001080 RID: 4224 RVA: 0x00068328 File Offset: 0x00066528
		protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read)
		{
			XmlSerializationReader.WriteCallbackInfo writeCallbackInfo = new XmlSerializationReader.WriteCallbackInfo();
			writeCallbackInfo.Type = type;
			writeCallbackInfo.TypeName = name;
			writeCallbackInfo.TypeNs = ns;
			writeCallbackInfo.Callback = read;
			this.typesCallbacks = this.EnsureHashtable(this.typesCallbacks);
			this.typesCallbacks.Add(new XmlQualifiedName(name, ns), writeCallbackInfo);
		}

		/// <summary>Stores an object that is being deserialized from a SOAP-encoded <see langword="multiRef" /> element for later access through the <see cref="M:System.Xml.Serialization.XmlSerializationReader.GetTarget(System.String)" /> method. </summary>
		/// <param name="id">The value of the <see langword="id" /> attribute of a <see langword="multiRef" /> element that identifies the element.</param>
		/// <param name="o">The object that is deserialized from the XML element.</param>
		// Token: 0x06001081 RID: 4225 RVA: 0x00068380 File Offset: 0x00066580
		protected void AddTarget(string id, object o)
		{
			if (id != null)
			{
				this.targets = this.EnsureHashtable(this.targets);
				if (this.targets[id] == null)
				{
					this.targets.Add(id, o);
					return;
				}
			}
			else
			{
				if (o != null)
				{
					return;
				}
				this.noIDTargets = this.EnsureArrayList(this.noIDTargets);
				this.noIDTargets.Add(o);
			}
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000683E4 File Offset: 0x000665E4
		private string CurrentTag()
		{
			XmlNodeType nodeType = this.reader.NodeType;
			switch (nodeType)
			{
			case XmlNodeType.Element:
				return string.Format("<{0} xmlns='{1}'>", this.reader.LocalName, this.reader.NamespaceURI);
			case XmlNodeType.Attribute:
				return this.reader.Value;
			case XmlNodeType.Text:
				return "CDATA";
			case XmlNodeType.CDATA:
			case XmlNodeType.EntityReference:
				break;
			case XmlNodeType.Entity:
				return "<?";
			case XmlNodeType.ProcessingInstruction:
				return "<--";
			default:
				if (nodeType == XmlNodeType.EndElement)
				{
					return ">";
				}
				break;
			}
			return "(unknown)";
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a SOAP-encoded collection type cannot be modified and its values cannot be filled in. </summary>
		/// <param name="name">The fully qualified name of the .NET Framework type for which there is a mapping.</param>
		/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
		// Token: 0x06001083 RID: 4227 RVA: 0x00068472 File Offset: 0x00066672
		protected Exception CreateReadOnlyCollectionException(string name)
		{
			return new InvalidOperationException(string.Format("Could not serialize {0}. Default constructors are required for collections and enumerators.", name));
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that an enumeration value is not valid. </summary>
		/// <param name="value">The enumeration value that is not valid.</param>
		/// <param name="enumType">The enumeration type.</param>
		/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
		// Token: 0x06001084 RID: 4228 RVA: 0x00068484 File Offset: 0x00066684
		protected Exception CreateUnknownConstantException(string value, Type enumType)
		{
			return new InvalidOperationException(string.Format("'{0}' is not a valid value for {1}.", value, enumType));
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that the current position of <see cref="T:System.Xml.XmlReader" /> represents an unknown XML node. </summary>
		/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
		// Token: 0x06001085 RID: 4229 RVA: 0x00068497 File Offset: 0x00066697
		protected Exception CreateUnknownNodeException()
		{
			return new InvalidOperationException(this.CurrentTag() + " was not expected");
		}

		/// <summary>Creates an <see cref="T:System.InvalidOperationException" /> that indicates that a type is unknown. </summary>
		/// <param name="type">An <see cref="T:System.Xml.XmlQualifiedName" /> that represents the name of the unknown type.</param>
		/// <returns>An <see cref="T:System.InvalidOperationException" /> exception.</returns>
		// Token: 0x06001086 RID: 4230 RVA: 0x000684B0 File Offset: 0x000666B0
		protected Exception CreateUnknownTypeException(XmlQualifiedName type)
		{
			return new InvalidOperationException(string.Concat(new string[]
			{
				"The specified type was not recognized: name='",
				type.Name,
				"' namespace='",
				type.Namespace,
				"', at ",
				this.CurrentTag()
			}));
		}

		/// <summary>Ensures that a given array, or a copy, is large enough to contain a specified index. </summary>
		/// <param name="a">The <see cref="T:System.Array" /> that is being checked.</param>
		/// <param name="index">The required index.</param>
		/// <param name="elementType">The <see cref="T:System.Type" /> of the array's elements.</param>
		/// <returns>The existing <see cref="T:System.Array" />, if it is already large enough; otherwise, a new, larger array that contains the original array's elements.</returns>
		// Token: 0x06001087 RID: 4231 RVA: 0x00068500 File Offset: 0x00066700
		protected Array EnsureArrayIndex(Array a, int index, Type elementType)
		{
			if (a != null && index < a.Length)
			{
				return a;
			}
			int length;
			if (a == null)
			{
				length = 32;
			}
			else
			{
				length = a.Length * 2;
			}
			Array array = Array.CreateInstance(elementType, length);
			if (a != null)
			{
				Array.Copy(a, array, index);
			}
			return array;
		}

		/// <summary>Determines whether the XML element where the <see cref="T:System.Xml.XmlReader" /> is currently positioned has a null attribute set to the value <see langword="true" />.</summary>
		/// <returns>
		///     <see langword="true" /> if <see cref="T:System.Xml.XmlReader" /> is currently positioned over a null attribute with the value <see langword="true" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001088 RID: 4232 RVA: 0x00068540 File Offset: 0x00066740
		protected bool GetNullAttr()
		{
			string attribute = this.reader.GetAttribute(this.nullX, this.w3InstanceNS);
			if (attribute == null)
			{
				attribute = this.reader.GetAttribute(this.nil, this.w3InstanceNS);
				if (attribute == null)
				{
					attribute = this.reader.GetAttribute(this.nullX, this.w3InstanceNS2000);
					if (attribute == null)
					{
						attribute = this.reader.GetAttribute(this.nullX, this.w3InstanceNS1999);
					}
				}
			}
			return attribute != null;
		}

		/// <summary>Gets an object that is being deserialized from a SOAP-encoded <see langword="multiRef" /> element and that was stored earlier by <see cref="M:System.Xml.Serialization.XmlSerializationReader.AddTarget(System.String,System.Object)" />.  </summary>
		/// <param name="id">The value of the <see langword="id" /> attribute of a <see langword="multiRef" /> element that identifies the element.</param>
		/// <returns>An object to be deserialized from a SOAP-encoded <see langword="multiRef" /> element.</returns>
		// Token: 0x06001089 RID: 4233 RVA: 0x000685BC File Offset: 0x000667BC
		protected object GetTarget(string id)
		{
			if (this.targets == null)
			{
				return null;
			}
			object obj = this.targets[id];
			if (obj != null)
			{
				if (this.referencedObjects == null)
				{
					this.referencedObjects = new Hashtable();
				}
				this.referencedObjects[obj] = obj;
			}
			return obj;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00068604 File Offset: 0x00066804
		private bool TargetReady(string id)
		{
			return this.targets != null && this.targets.ContainsKey(id);
		}

		/// <summary>Gets the value of the <see langword="xsi:type" /> attribute for the XML element at the current location of the <see cref="T:System.Xml.XmlReader" />. </summary>
		/// <returns>An XML qualified name that indicates the data type of an XML element.</returns>
		// Token: 0x0600108B RID: 4235 RVA: 0x0006861C File Offset: 0x0006681C
		protected XmlQualifiedName GetXsiType()
		{
			string attribute = this.Reader.GetAttribute(this.typeX, "http://www.w3.org/2001/XMLSchema-instance");
			if (attribute == string.Empty || attribute == null)
			{
				attribute = this.Reader.GetAttribute(this.typeX, this.w3InstanceNS1999);
				if (attribute == string.Empty || attribute == null)
				{
					attribute = this.Reader.GetAttribute(this.typeX, this.w3InstanceNS2000);
					if (attribute == string.Empty || attribute == null)
					{
						return null;
					}
				}
			}
			int num = attribute.IndexOf(":");
			if (num == -1)
			{
				return new XmlQualifiedName(attribute, this.Reader.NamespaceURI);
			}
			string prefix = attribute.Substring(0, num);
			return new XmlQualifiedName(attribute.Substring(num + 1), this.Reader.LookupNamespace(prefix));
		}

		/// <summary>Initializes callback methods that populate objects that map to SOAP-encoded XML data. </summary>
		// Token: 0x0600108C RID: 4236
		protected abstract void InitCallbacks();

		/// <summary>Stores element and attribute names in a <see cref="T:System.Xml.NameTable" /> object. </summary>
		// Token: 0x0600108D RID: 4237
		protected abstract void InitIDs();

		/// <summary>Determines whether an XML attribute name indicates an XML namespace. </summary>
		/// <param name="name">The name of an XML attribute.</param>
		/// <returns>
		///     <see langword="true " />if the XML attribute name indicates an XML namespace; otherwise, <see langword="false" />.</returns>
		// Token: 0x0600108E RID: 4238 RVA: 0x000686E8 File Offset: 0x000668E8
		protected bool IsXmlnsAttribute(string name)
		{
			int length = name.Length;
			if (length < 5)
			{
				return false;
			}
			if (length == 5)
			{
				return name == "xmlns";
			}
			return name.StartsWith("xmlns:");
		}

		/// <summary>Sets the value of the XML attribute if it is of type <see langword="arrayType" /> from the Web Services Description Language (WSDL) namespace. </summary>
		/// <param name="attr">An <see cref="T:System.Xml.XmlAttribute" /> that may have the type <see langword="wsdl:array" />.</param>
		// Token: 0x0600108F RID: 4239 RVA: 0x00068720 File Offset: 0x00066920
		protected void ParseWsdlArrayType(XmlAttribute attr)
		{
			if (attr.NamespaceURI == this.wsdlNS && attr.LocalName == this.arrayType)
			{
				string text = "";
				string str;
				string str2;
				TypeTranslator.ParseArrayType(attr.Value, out str, out text, out str2);
				if (text != "")
				{
					text = this.Reader.LookupNamespace(text) + ":";
				}
				attr.Value = text + str + str2;
			}
		}

		/// <summary>Makes the <see cref="T:System.Xml.XmlReader" /> read the fully qualified name of the element where it is currently positioned. </summary>
		/// <returns>The fully qualified name of the current XML element.</returns>
		// Token: 0x06001090 RID: 4240 RVA: 0x0006879C File Offset: 0x0006699C
		protected XmlQualifiedName ReadElementQualifiedName()
		{
			this.readCount++;
			if (this.reader.IsEmptyElement)
			{
				this.reader.Skip();
				return this.ToXmlQualifiedName(string.Empty);
			}
			this.reader.ReadStartElement();
			XmlQualifiedName result = this.ToXmlQualifiedName(this.reader.ReadString());
			this.reader.ReadEndElement();
			return result;
		}

		/// <summary>Makes the <see cref="T:System.Xml.XmlReader" /> read an XML end tag.</summary>
		// Token: 0x06001091 RID: 4241 RVA: 0x00068804 File Offset: 0x00066A04
		protected void ReadEndElement()
		{
			this.readCount++;
			while (this.reader.NodeType == XmlNodeType.Whitespace)
			{
				this.reader.Skip();
			}
			if (this.reader.NodeType != XmlNodeType.None)
			{
				this.reader.ReadEndElement();
				return;
			}
			this.reader.Skip();
		}

		/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the current XML element if the element has a null attribute with the value true. </summary>
		/// <returns>
		///     <see langword="true" /> if the element has a null="true" attribute value and has been read; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001092 RID: 4242 RVA: 0x00068860 File Offset: 0x00066A60
		protected bool ReadNull()
		{
			if (!this.GetNullAttr())
			{
				return false;
			}
			this.readCount++;
			if (this.reader.IsEmptyElement)
			{
				this.reader.Skip();
				return true;
			}
			this.reader.ReadStartElement();
			while (this.reader.NodeType != XmlNodeType.EndElement)
			{
				this.UnknownNode(null);
			}
			this.ReadEndElement();
			return true;
		}

		/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the fully qualified name of the element where it is currently positioned. </summary>
		/// <returns>A <see cref="T:System.Xml.XmlQualifiedName" /> that represents the fully qualified name of the current XML element; otherwise, <see langword="null" /> if a null="true" attribute value is present.</returns>
		// Token: 0x06001093 RID: 4243 RVA: 0x000688C9 File Offset: 0x00066AC9
		protected XmlQualifiedName ReadNullableQualifiedName()
		{
			if (this.ReadNull())
			{
				return null;
			}
			return this.ReadElementQualifiedName();
		}

		/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read a simple, text-only XML element that could be <see langword="null" />. </summary>
		/// <returns>The string value; otherwise, <see langword="null" />.</returns>
		// Token: 0x06001094 RID: 4244 RVA: 0x000688DB File Offset: 0x00066ADB
		protected string ReadNullableString()
		{
			if (this.ReadNull())
			{
				return null;
			}
			this.readCount++;
			return this.reader.ReadElementString();
		}

		/// <summary>Deserializes an object from a SOAP-encoded <see langword="multiRef" /> XML element. </summary>
		/// <returns>The value of the referenced element in the document.</returns>
		// Token: 0x06001095 RID: 4245 RVA: 0x00068900 File Offset: 0x00066B00
		protected object ReadReferencedElement()
		{
			return this.ReadReferencedElement(this.Reader.LocalName, this.Reader.NamespaceURI);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0006891E File Offset: 0x00066B1E
		private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname)
		{
			if (this.typesCallbacks == null)
			{
				this.typesCallbacks = new Hashtable();
				this.InitCallbacks();
			}
			return (XmlSerializationReader.WriteCallbackInfo)this.typesCallbacks[qname];
		}

		/// <summary>Deserializes an object from a SOAP-encoded <see langword="multiRef" /> XML element. </summary>
		/// <param name="name">The local name of the element's XML Schema data type.</param>
		/// <param name="ns">The namespace of the element's XML Schema data type.</param>
		/// <returns>The value of the referenced element in the document.</returns>
		// Token: 0x06001097 RID: 4247 RVA: 0x0006894C File Offset: 0x00066B4C
		protected object ReadReferencedElement(string name, string ns)
		{
			XmlQualifiedName xmlQualifiedName = this.GetXsiType();
			if (xmlQualifiedName == null)
			{
				xmlQualifiedName = new XmlQualifiedName(name, ns);
			}
			string attribute = this.Reader.GetAttribute("id");
			string attribute2 = this.Reader.GetAttribute(this.arrayType, this.soapNS);
			object obj;
			if (xmlQualifiedName == this.arrayQName || (attribute2 != null && attribute2.Length > 0))
			{
				XmlSerializationReader.CollectionFixup collectionFixup = (this.collFixups != null) ? ((XmlSerializationReader.CollectionFixup)this.collFixups[attribute]) : null;
				if (this.ReadList(out obj))
				{
					if (collectionFixup != null)
					{
						collectionFixup.Callback(collectionFixup.Collection, obj);
						this.collFixups.Remove(attribute);
						obj = collectionFixup.Collection;
					}
				}
				else if (collectionFixup != null)
				{
					collectionFixup.CollectionItems = (object[])obj;
					obj = collectionFixup.Collection;
				}
			}
			else
			{
				XmlSerializationReader.WriteCallbackInfo callbackInfo = this.GetCallbackInfo(xmlQualifiedName);
				if (callbackInfo == null)
				{
					obj = this.ReadTypedPrimitive(xmlQualifiedName, attribute != null);
				}
				else
				{
					obj = callbackInfo.Callback();
				}
			}
			this.AddTarget(attribute, obj);
			return obj;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00068A58 File Offset: 0x00066C58
		private bool ReadList(out object resultList)
		{
			string attribute = this.Reader.GetAttribute(this.arrayType, this.soapNS);
			if (attribute == null)
			{
				attribute = this.Reader.GetAttribute(this.arrayType, this.wsdlNS);
			}
			XmlQualifiedName xmlQualifiedName = this.ToXmlQualifiedName(attribute);
			int num = xmlQualifiedName.Name.LastIndexOf('[');
			string text = xmlQualifiedName.Name.Substring(num);
			string text2 = xmlQualifiedName.Name.Substring(0, num);
			int num2 = int.Parse(text.Substring(1, text.Length - 2), CultureInfo.InvariantCulture);
			num = text2.IndexOf('[');
			if (num == -1)
			{
				num = text2.Length;
			}
			string text3 = text2.Substring(0, num);
			string typeName;
			if (xmlQualifiedName.Namespace == this.w3SchemaNS)
			{
				typeName = TypeTranslator.GetPrimitiveTypeData(text3).Type.FullName + text2.Substring(num);
			}
			else
			{
				XmlSerializationReader.WriteCallbackInfo callbackInfo = this.GetCallbackInfo(new XmlQualifiedName(text3, xmlQualifiedName.Namespace));
				typeName = callbackInfo.Type.FullName + text2.Substring(num) + ", " + callbackInfo.Type.Assembly.FullName;
			}
			Array array = Array.CreateInstance(Type.GetType(typeName), num2);
			bool result = true;
			if (this.Reader.IsEmptyElement)
			{
				this.readCount++;
				this.Reader.Skip();
			}
			else
			{
				this.Reader.ReadStartElement();
				for (int i = 0; i < num2; i++)
				{
					this.whileIterationCount++;
					this.readCount++;
					this.Reader.MoveToContent();
					string text4;
					object value = this.ReadReferencingElement(text2, xmlQualifiedName.Namespace, out text4);
					if (text4 == null)
					{
						array.SetValue(value, i);
					}
					else
					{
						this.AddFixup(new XmlSerializationReader.CollectionItemFixup(array, i, text4));
						result = false;
					}
				}
				this.whileIterationCount = 0;
				this.Reader.ReadEndElement();
			}
			resultList = array;
			return result;
		}

		/// <summary>Deserializes objects from the SOAP-encoded <see langword="multiRef" /> elements in a SOAP message. </summary>
		// Token: 0x06001099 RID: 4249 RVA: 0x00068C54 File Offset: 0x00066E54
		protected void ReadReferencedElements()
		{
			this.reader.MoveToContent();
			XmlNodeType nodeType = this.reader.NodeType;
			while (nodeType != XmlNodeType.EndElement && nodeType != XmlNodeType.None)
			{
				this.whileIterationCount++;
				this.readCount++;
				this.ReadReferencedElement();
				this.reader.MoveToContent();
				nodeType = this.reader.NodeType;
			}
			this.whileIterationCount = 0;
			if (this.delayedListFixups != null)
			{
				foreach (object obj in this.delayedListFixups)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					this.AddTarget((string)dictionaryEntry.Key, dictionaryEntry.Value);
				}
			}
			if (this.collItemFixups != null)
			{
				foreach (object obj2 in this.collItemFixups)
				{
					XmlSerializationReader.CollectionItemFixup collectionItemFixup = (XmlSerializationReader.CollectionItemFixup)obj2;
					collectionItemFixup.Collection.SetValue(this.GetTarget(collectionItemFixup.Id), collectionItemFixup.Index);
				}
			}
			if (this.collFixups != null)
			{
				foreach (object obj3 in this.collFixups.Values)
				{
					XmlSerializationReader.CollectionFixup collectionFixup = (XmlSerializationReader.CollectionFixup)obj3;
					collectionFixup.Callback(collectionFixup.Collection, collectionFixup.CollectionItems);
				}
			}
			if (this.fixups != null)
			{
				foreach (object obj4 in this.fixups)
				{
					XmlSerializationReader.Fixup fixup = (XmlSerializationReader.Fixup)obj4;
					fixup.Callback(fixup);
				}
			}
			if (this.targets != null)
			{
				foreach (object obj5 in this.targets)
				{
					DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj5;
					if (dictionaryEntry2.Value != null && (this.referencedObjects == null || !this.referencedObjects.Contains(dictionaryEntry2.Value)))
					{
						this.UnreferencedObject((string)dictionaryEntry2.Key, dictionaryEntry2.Value);
					}
				}
			}
		}

		/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element. </summary>
		/// <param name="fixupReference">An output string into which the <see langword="href" /> attribute value is read.</param>
		/// <returns>The deserialized object.</returns>
		// Token: 0x0600109A RID: 4250 RVA: 0x00068EEC File Offset: 0x000670EC
		protected object ReadReferencingElement(out string fixupReference)
		{
			return this.ReadReferencingElement(this.Reader.LocalName, this.Reader.NamespaceURI, false, out fixupReference);
		}

		/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element. </summary>
		/// <param name="name">The local name of the element's XML Schema data type.</param>
		/// <param name="ns">The namespace of the element's XML Schema data type.</param>
		/// <param name="fixupReference">An output string into which the <see langword="href" /> attribute value is read.</param>
		/// <returns>The deserialized object.</returns>
		// Token: 0x0600109B RID: 4251 RVA: 0x00068F0C File Offset: 0x0006710C
		protected object ReadReferencingElement(string name, string ns, out string fixupReference)
		{
			return this.ReadReferencingElement(name, ns, false, out fixupReference);
		}

		/// <summary>Deserializes an object from an XML element in a SOAP message that contains a reference to a <see langword="multiRef" /> element.</summary>
		/// <param name="name">The local name of the element's XML Schema data type.</param>
		/// <param name="ns">The namespace of the element's XML Schema data type.</param>
		/// <param name="elementCanBeType">
		///       <see langword="true" /> if the element name is also the XML Schema data type name; otherwise, <see langword="false" />.</param>
		/// <param name="fixupReference">An output string into which the value of the <see langword="href" /> attribute is read.</param>
		/// <returns>The deserialized object.</returns>
		// Token: 0x0600109C RID: 4252 RVA: 0x00068F18 File Offset: 0x00067118
		protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference)
		{
			if (this.ReadNull())
			{
				fixupReference = null;
				return null;
			}
			string text = this.Reader.GetAttribute("href");
			if (text == string.Empty || text == null)
			{
				fixupReference = null;
				XmlQualifiedName xmlQualifiedName = this.GetXsiType();
				if (xmlQualifiedName == null)
				{
					xmlQualifiedName = new XmlQualifiedName(name, ns);
				}
				string attribute = this.Reader.GetAttribute(this.arrayType, this.soapNS);
				if (xmlQualifiedName == this.arrayQName || attribute != null)
				{
					this.delayedListFixups = this.EnsureHashtable(this.delayedListFixups);
					string str = "__<";
					int num = this.delayedFixupId;
					this.delayedFixupId = num + 1;
					fixupReference = str + num.ToString() + ">";
					object value;
					this.ReadList(out value);
					this.delayedListFixups[fixupReference] = value;
					return null;
				}
				XmlSerializationReader.WriteCallbackInfo callbackInfo = this.GetCallbackInfo(xmlQualifiedName);
				if (callbackInfo == null)
				{
					return this.ReadTypedPrimitive(xmlQualifiedName, true);
				}
				return callbackInfo.Callback();
			}
			else
			{
				if (text.StartsWith("#"))
				{
					text = text.Substring(1);
				}
				this.readCount++;
				this.Reader.Skip();
				if (this.TargetReady(text))
				{
					fixupReference = null;
					return this.GetTarget(text);
				}
				fixupReference = text;
				return null;
			}
		}

		/// <summary>Populates an object from its XML representation at the current location of the <see cref="T:System.Xml.XmlReader" />. </summary>
		/// <param name="serializable">An <see cref="T:System.Xml.Serialization.IXmlSerializable" /> that corresponds to the current position of the <see cref="T:System.Xml.XmlReader" />.</param>
		/// <returns>An object that implements the <see cref="T:System.Xml.Serialization.IXmlSerializable" /> interface with its members populated from the location of the <see cref="T:System.Xml.XmlReader" />.</returns>
		// Token: 0x0600109D RID: 4253 RVA: 0x00069060 File Offset: 0x00067260
		protected IXmlSerializable ReadSerializable(IXmlSerializable serializable)
		{
			if (this.ReadNull())
			{
				return null;
			}
			int depth = this.reader.Depth;
			this.readCount++;
			serializable.ReadXml(this.reader);
			this.Reader.MoveToContent();
			while (this.reader.Depth > depth)
			{
				this.reader.Skip();
			}
			if (this.reader.Depth == depth && this.reader.NodeType == XmlNodeType.EndElement)
			{
				this.reader.ReadEndElement();
			}
			return serializable;
		}

		/// <summary>Gets the value of the XML node at which the <see cref="T:System.Xml.XmlReader" /> is currently positioned. </summary>
		/// <param name="type">The <see cref="T:System.Xml.XmlQualifiedName" /> that represents the simple data type for the current location of the <see cref="T:System.Xml.XmlReader" />.</param>
		/// <returns>The value of the node as a .NET Framework value type, if the value is a simple XML Schema data type.</returns>
		// Token: 0x0600109E RID: 4254 RVA: 0x000690ED File Offset: 0x000672ED
		protected object ReadTypedPrimitive(XmlQualifiedName type)
		{
			return this.ReadTypedPrimitive(type, false);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000690F8 File Offset: 0x000672F8
		private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown)
		{
			if (qname == null)
			{
				qname = this.GetXsiType();
			}
			TypeData typeData = TypeTranslator.FindPrimitiveTypeData(qname.Name);
			if (typeData == null || typeData.SchemaType != SchemaTypes.Primitive)
			{
				this.readCount++;
				XmlNode xmlNode = this.Document.ReadNode(this.reader);
				if (reportUnknown)
				{
					this.OnUnknownNode(xmlNode, null, null);
				}
				if (xmlNode.ChildNodes.Count == 0 && xmlNode.Attributes.Count == 0)
				{
					return new object();
				}
				XmlElement xmlElement = xmlNode as XmlElement;
				if (xmlElement == null)
				{
					return new XmlNode[]
					{
						xmlNode
					};
				}
				XmlNode[] array = new XmlNode[xmlElement.Attributes.Count + xmlElement.ChildNodes.Count];
				int num = 0;
				foreach (object obj in xmlElement.Attributes)
				{
					XmlNode xmlNode2 = (XmlNode)obj;
					array[num++] = xmlNode2;
				}
				foreach (object obj2 in xmlElement.ChildNodes)
				{
					XmlNode xmlNode3 = (XmlNode)obj2;
					array[num++] = xmlNode3;
				}
				return array;
			}
			else
			{
				if (typeData.Type == typeof(XmlQualifiedName))
				{
					return this.ReadNullableQualifiedName();
				}
				this.readCount++;
				return XmlCustomFormatter.FromXmlString(typeData, this.Reader.ReadElementString());
			}
		}

		/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read the XML node at its current position. </summary>
		/// <param name="wrapped">
		///       <see langword="true" /> to read content only after reading the element's start element; otherwise, <see langword="false" />.</param>
		/// <returns>An <see cref="T:System.Xml.XmlNode" /> that represents the XML node that has been read.</returns>
		// Token: 0x060010A0 RID: 4256 RVA: 0x000692A0 File Offset: 0x000674A0
		protected XmlNode ReadXmlNode(bool wrapped)
		{
			this.readCount++;
			XmlNode xmlNode = this.Document.ReadNode(this.reader);
			if (wrapped)
			{
				return xmlNode.FirstChild;
			}
			return xmlNode;
		}

		/// <summary>Instructs the <see cref="T:System.Xml.XmlReader" /> to read an XML document root element at its current position.</summary>
		/// <param name="wrapped">
		///       <see langword="true" /> if the method should read content only after reading the element's start element; otherwise, <see langword="false" />.</param>
		/// <returns>An <see cref="T:System.Xml.XmlDocument" /> that contains the root element that has been read.</returns>
		// Token: 0x060010A1 RID: 4257 RVA: 0x000692D8 File Offset: 0x000674D8
		protected XmlDocument ReadXmlDocument(bool wrapped)
		{
			this.readCount++;
			if (wrapped)
			{
				this.reader.ReadStartElement();
			}
			this.reader.MoveToContent();
			XmlDocument xmlDocument = new XmlDocument(this.reader.NameTable);
			XmlNode newChild = xmlDocument.ReadNode(this.reader);
			xmlDocument.AppendChild(newChild);
			if (wrapped)
			{
				this.reader.ReadEndElement();
			}
			return xmlDocument;
		}

		/// <summary>Ensures that a given array, or a copy, is no larger than a specified length. </summary>
		/// <param name="a">The array that is being checked.</param>
		/// <param name="length">The maximum length of the array.</param>
		/// <param name="elementType">The <see cref="T:System.Type" /> of the array's elements.</param>
		/// <param name="isNullable">
		///       <see langword="true" /> if <see langword="null" /> for the array, if present for the input array, can be returned; otherwise, a new, smaller array.</param>
		/// <returns>The existing <see cref="T:System.Array" />, if it is already small enough; otherwise, a new, smaller array that contains the original array's elements up to the size of<paramref name=" length" />.</returns>
		// Token: 0x060010A2 RID: 4258 RVA: 0x00069340 File Offset: 0x00067540
		protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable)
		{
			if (length == 0 && isNullable)
			{
				return null;
			}
			if (a == null)
			{
				return Array.CreateInstance(elementType, length);
			}
			if (a.Length == length)
			{
				return a;
			}
			Array array = Array.CreateInstance(elementType, length);
			Array.Copy(a, array, length);
			return array;
		}

		/// <summary>Obtains an <see cref="T:System.Xml.XmlQualifiedName" /> from a name that may contain a prefix. </summary>
		/// <param name="value">A name that may contain a prefix.</param>
		/// <returns>An <see cref="T:System.Xml.XmlQualifiedName" /> that represents a namespace-qualified XML name.</returns>
		// Token: 0x060010A3 RID: 4259 RVA: 0x00069380 File Offset: 0x00067580
		protected XmlQualifiedName ToXmlQualifiedName(string value)
		{
			int num = value.LastIndexOf(':');
			string array = XmlConvert.DecodeName(value);
			string name;
			string text;
			if (num < 0)
			{
				name = this.reader.NameTable.Add(array);
				text = this.reader.LookupNamespace(string.Empty);
			}
			else
			{
				string text2 = value.Substring(0, num);
				text = this.reader.LookupNamespace(text2);
				if (text == null)
				{
					throw new InvalidOperationException("namespace " + text2 + " not defined");
				}
				name = this.reader.NameTable.Add(value.Substring(num + 1));
			}
			return new XmlQualifiedName(name, text);
		}

		/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownAttribute" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> property.</param>
		/// <param name="attr">A <see cref="T:System.Xml.XmlAttribute" /> that represents the attribute in question.</param>
		/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
		// Token: 0x060010A4 RID: 4260 RVA: 0x0006941C File Offset: 0x0006761C
		protected void UnknownAttribute(object o, XmlAttribute attr, string qnames)
		{
			int lineNumber;
			int linePosition;
			if (this.Reader is XmlTextReader)
			{
				lineNumber = ((XmlTextReader)this.Reader).LineNumber;
				linePosition = ((XmlTextReader)this.Reader).LinePosition;
			}
			else
			{
				lineNumber = 0;
				linePosition = 0;
			}
			XmlAttributeEventArgs e = new XmlAttributeEventArgs(attr, lineNumber, linePosition, o, qnames);
			if (this.eventSource != null)
			{
				this.eventSource.OnUnknownAttribute(e);
			}
		}

		/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownElement" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.XmlAttributeEventArgs.ObjectBeingDeserialized" /> property.</param>
		/// <param name="elem">The <see cref="T:System.Xml.XmlElement" /> for which an event is raised.</param>
		/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
		// Token: 0x060010A5 RID: 4261 RVA: 0x00069480 File Offset: 0x00067680
		protected void UnknownElement(object o, XmlElement elem, string qnames)
		{
			int lineNumber;
			int linePosition;
			if (this.Reader is XmlTextReader)
			{
				lineNumber = ((XmlTextReader)this.Reader).LineNumber;
				linePosition = ((XmlTextReader)this.Reader).LinePosition;
			}
			else
			{
				lineNumber = 0;
				linePosition = 0;
			}
			XmlElementEventArgs e = new XmlElementEventArgs(elem, lineNumber, linePosition, o, qnames);
			if (this.eventSource != null)
			{
				this.eventSource.OnUnknownElement(e);
			}
		}

		/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />. </summary>
		/// <param name="o">The object that is being deserialized.</param>
		// Token: 0x060010A6 RID: 4262 RVA: 0x000694E1 File Offset: 0x000676E1
		protected void UnknownNode(object o)
		{
			this.UnknownNode(o, null);
		}

		/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="o">The object being deserialized.</param>
		/// <param name="qnames">A comma-delimited list of XML qualified names.</param>
		// Token: 0x060010A7 RID: 4263 RVA: 0x000694EB File Offset: 0x000676EB
		protected void UnknownNode(object o, string qnames)
		{
			this.OnUnknownNode(this.ReadXmlNode(false), o, qnames);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000694FC File Offset: 0x000676FC
		private void OnUnknownNode(XmlNode node, object o, string qnames)
		{
			int lineNumber;
			int linePosition;
			if (this.Reader is XmlTextReader)
			{
				lineNumber = ((XmlTextReader)this.Reader).LineNumber;
				linePosition = ((XmlTextReader)this.Reader).LinePosition;
			}
			else
			{
				lineNumber = 0;
				linePosition = 0;
			}
			if (node is XmlAttribute)
			{
				this.UnknownAttribute(o, (XmlAttribute)node, qnames);
				return;
			}
			if (node is XmlElement)
			{
				this.UnknownElement(o, (XmlElement)node, qnames);
				return;
			}
			if (this.eventSource != null)
			{
				this.eventSource.OnUnknownNode(new XmlNodeEventArgs(node, lineNumber, linePosition, o));
			}
			if (this.Reader.ReadState == ReadState.EndOfFile)
			{
				throw new InvalidOperationException("End of document found");
			}
		}

		/// <summary>Raises an <see cref="E:System.Xml.Serialization.XmlSerializer.UnreferencedObject" /> event for the current position of the <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="id">A unique string that is used to identify the unreferenced object, subsequently accessible through the <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedId" /> property.</param>
		/// <param name="o">An object that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> is attempting to deserialize, subsequently accessible through the <see cref="P:System.Xml.Serialization.UnreferencedObjectEventArgs.UnreferencedObject" /> property.</param>
		// Token: 0x060010A9 RID: 4265 RVA: 0x000695A1 File Offset: 0x000677A1
		protected void UnreferencedObject(string id, object o)
		{
			if (this.eventSource != null)
			{
				this.eventSource.OnUnreferencedObject(new UnreferencedObjectEventArgs(o, id));
			}
		}

		// Token: 0x04000B97 RID: 2967
		private XmlDocument document;

		// Token: 0x04000B98 RID: 2968
		private XmlReader reader;

		// Token: 0x04000B99 RID: 2969
		private ArrayList fixups;

		// Token: 0x04000B9A RID: 2970
		private Hashtable collFixups;

		// Token: 0x04000B9B RID: 2971
		private ArrayList collItemFixups;

		// Token: 0x04000B9C RID: 2972
		private Hashtable typesCallbacks;

		// Token: 0x04000B9D RID: 2973
		private ArrayList noIDTargets;

		// Token: 0x04000B9E RID: 2974
		private Hashtable targets;

		// Token: 0x04000B9F RID: 2975
		private Hashtable delayedListFixups;

		// Token: 0x04000BA0 RID: 2976
		private XmlSerializer eventSource;

		// Token: 0x04000BA1 RID: 2977
		private int delayedFixupId;

		// Token: 0x04000BA2 RID: 2978
		private Hashtable referencedObjects;

		// Token: 0x04000BA3 RID: 2979
		private int readCount;

		// Token: 0x04000BA4 RID: 2980
		private int whileIterationCount;

		// Token: 0x04000BA5 RID: 2981
		private string w3SchemaNS;

		// Token: 0x04000BA6 RID: 2982
		private string w3InstanceNS;

		// Token: 0x04000BA7 RID: 2983
		private string w3InstanceNS2000;

		// Token: 0x04000BA8 RID: 2984
		private string w3InstanceNS1999;

		// Token: 0x04000BA9 RID: 2985
		private string soapNS;

		// Token: 0x04000BAA RID: 2986
		private string wsdlNS;

		// Token: 0x04000BAB RID: 2987
		private string nullX;

		// Token: 0x04000BAC RID: 2988
		private string nil;

		// Token: 0x04000BAD RID: 2989
		private string typeX;

		// Token: 0x04000BAE RID: 2990
		private string arrayType;

		// Token: 0x04000BAF RID: 2991
		private XmlQualifiedName arrayQName;

		// Token: 0x020001FB RID: 507
		private class WriteCallbackInfo
		{
			// Token: 0x04000BB0 RID: 2992
			public Type Type;

			// Token: 0x04000BB1 RID: 2993
			public string TypeName;

			// Token: 0x04000BB2 RID: 2994
			public string TypeNs;

			// Token: 0x04000BB3 RID: 2995
			public XmlSerializationReadCallback Callback;
		}

		/// <summary>Holds an <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate instance, plus the method's inputs; also supplies the method's parameters. </summary>
		// Token: 0x020001FC RID: 508
		protected class CollectionFixup
		{
			// Token: 0x060010AB RID: 4267 RVA: 0x000695BD File Offset: 0x000677BD
			internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id)
			{
				this.callback = callback;
				this.collection = collection;
				this.id = id;
			}

			/// <summary>Gets the callback method that instantiates the <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate. </summary>
			/// <returns>The <see cref="T:System.Xml.Serialization.XmlSerializationCollectionFixupCallback" /> delegate that points to the callback method.</returns>
			// Token: 0x17000354 RID: 852
			// (get) Token: 0x060010AC RID: 4268 RVA: 0x000695DA File Offset: 0x000677DA
			public XmlSerializationCollectionFixupCallback Callback
			{
				get
				{
					return this.callback;
				}
			}

			/// <summary>Gets the <paramref name="object collection" /> for the callback method. </summary>
			/// <returns>The collection that is used for the fixup.</returns>
			// Token: 0x17000355 RID: 853
			// (get) Token: 0x060010AD RID: 4269 RVA: 0x000695E2 File Offset: 0x000677E2
			public object Collection
			{
				get
				{
					return this.collection;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x060010AE RID: 4270 RVA: 0x000695EA File Offset: 0x000677EA
			internal object Id
			{
				get
				{
					return this.id;
				}
			}

			/// <summary>Gets the array into which the callback method copies a collection. </summary>
			/// <returns>The array into which the callback method copies a collection.</returns>
			// Token: 0x17000357 RID: 855
			// (get) Token: 0x060010AF RID: 4271 RVA: 0x000695F2 File Offset: 0x000677F2
			// (set) Token: 0x060010B0 RID: 4272 RVA: 0x000695FA File Offset: 0x000677FA
			public object CollectionItems
			{
				get
				{
					return this.collectionItems;
				}
				internal set
				{
					this.collectionItems = value;
				}
			}

			// Token: 0x04000BB4 RID: 2996
			private XmlSerializationCollectionFixupCallback callback;

			// Token: 0x04000BB5 RID: 2997
			private object collection;

			// Token: 0x04000BB6 RID: 2998
			private object collectionItems;

			// Token: 0x04000BB7 RID: 2999
			private string id;
		}

		/// <summary>Holds an <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate instance, plus the method's inputs; also serves as the parameter for the method.</summary>
		// Token: 0x020001FD RID: 509
		protected class Fixup
		{
			/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializationReader.Fixup" /> class.</summary>
			/// <param name="o">The object that contains other objects whose values get filled in by the callback implementation.</param>
			/// <param name="callback">A method that instantiates the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</param>
			/// <param name="count">The size of the string array obtained through the <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Ids" /> property.</param>
			// Token: 0x060010B1 RID: 4273 RVA: 0x00069603 File Offset: 0x00067803
			public Fixup(object o, XmlSerializationFixupCallback callback, int count)
			{
				this.source = o;
				this.callback = callback;
				this.ids = new string[count];
			}

			/// <summary>Gets the callback method that creates an instance of the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</summary>
			/// <returns>The callback method that creates an instance of the <see cref="T:System.Xml.Serialization.XmlSerializationFixupCallback" /> delegate.</returns>
			// Token: 0x17000358 RID: 856
			// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00069625 File Offset: 0x00067825
			public XmlSerializationFixupCallback Callback
			{
				get
				{
					return this.callback;
				}
			}

			/// <summary>Gets or sets an array of keys for the objects that belong to the <see cref="P:System.Xml.Serialization.XmlSerializationReader.Fixup.Source" /> property whose values get filled in by the callback implementation.</summary>
			/// <returns>The array of keys.</returns>
			// Token: 0x17000359 RID: 857
			// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0006962D File Offset: 0x0006782D
			public string[] Ids
			{
				get
				{
					return this.ids;
				}
			}

			/// <summary>Gets or sets the object that contains other objects whose values get filled in by the callback implementation.</summary>
			/// <returns>The source containing objects with values to fill.</returns>
			// Token: 0x1700035A RID: 858
			// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00069635 File Offset: 0x00067835
			public object Source
			{
				get
				{
					return this.source;
				}
			}

			// Token: 0x04000BB8 RID: 3000
			private object source;

			// Token: 0x04000BB9 RID: 3001
			private string[] ids;

			// Token: 0x04000BBA RID: 3002
			private XmlSerializationFixupCallback callback;
		}

		// Token: 0x020001FE RID: 510
		private class CollectionItemFixup
		{
			// Token: 0x060010B5 RID: 4277 RVA: 0x0006963D File Offset: 0x0006783D
			public CollectionItemFixup(Array list, int index, string id)
			{
				this.list = list;
				this.index = index;
				this.id = id;
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0006965A File Offset: 0x0006785A
			public Array Collection
			{
				get
				{
					return this.list;
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00069662 File Offset: 0x00067862
			public int Index
			{
				get
				{
					return this.index;
				}
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0006966A File Offset: 0x0006786A
			public string Id
			{
				get
				{
					return this.id;
				}
			}

			// Token: 0x04000BBB RID: 3003
			private Array list;

			// Token: 0x04000BBC RID: 3004
			private int index;

			// Token: 0x04000BBD RID: 3005
			private string id;
		}
	}
}
