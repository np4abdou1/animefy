﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace System.Xml.Linq
{
	/// <summary>Represents an XML attribute.</summary>
	// Token: 0x02000006 RID: 6
	public class XAttribute : XObject
	{
		/// <summary>Gets an empty collection of attributes.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> of <see cref="T:System.Xml.Linq.XAttribute" /> containing an empty collection.</returns>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		public static IEnumerable<XAttribute> EmptySequence
		{
			get
			{
				return Array.Empty<XAttribute>();
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XAttribute" /> class from the specified name and value. </summary>
		/// <param name="name">The <see cref="T:System.Xml.Linq.XName" /> of the attribute.</param>
		/// <param name="value">An <see cref="T:System.Object" /> containing the value of the attribute.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> or <paramref name="value" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000007 RID: 7 RVA: 0x000020A4 File Offset: 0x000002A4
		public XAttribute(XName name, object value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			string stringValue = XContainer.GetStringValue(value);
			XAttribute.ValidateAttribute(name, stringValue);
			this.name = name;
			this.value = stringValue;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Linq.XAttribute" /> class from another <see cref="T:System.Xml.Linq.XAttribute" /> object. </summary>
		/// <param name="other">An <see cref="T:System.Xml.Linq.XAttribute" /> object to copy from.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06000008 RID: 8 RVA: 0x000020F5 File Offset: 0x000002F5
		public XAttribute(XAttribute other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.name = other.name;
			this.value = other.value;
		}

		/// <summary>Determines if this attribute is a namespace declaration.</summary>
		/// <returns>
		///     <see langword="true" /> if this attribute is a namespace declaration; otherwise <see langword="false" />.</returns>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002124 File Offset: 0x00000324
		public bool IsNamespaceDeclaration
		{
			get
			{
				string namespaceName = this.name.NamespaceName;
				if (namespaceName.Length == 0)
				{
					return this.name.LocalName == "xmlns";
				}
				return namespaceName == "http://www.w3.org/2000/xmlns/";
			}
		}

		/// <summary>Gets the expanded name of this attribute.</summary>
		/// <returns>An <see cref="T:System.Xml.Linq.XName" /> containing the name of this attribute.</returns>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002163 File Offset: 0x00000363
		public XName Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets the node type for this node.</summary>
		/// <returns>The node type. For <see cref="T:System.Xml.Linq.XAttribute" /> objects, this value is <see cref="F:System.Xml.XmlNodeType.Attribute" />.</returns>
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000216B File Offset: 0x0000036B
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Attribute;
			}
		}

		/// <summary>Gets or sets the value of this attribute.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the value of this attribute.</returns>
		/// <exception cref="T:System.ArgumentNullException">When setting, the <paramref name="value" /> is <see langword="null" />.</exception>
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000216E File Offset: 0x0000036E
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002176 File Offset: 0x00000376
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				XAttribute.ValidateAttribute(this.name, value);
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.value = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Converts the current <see cref="T:System.Xml.Linq.XAttribute" /> object to a string representation.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the XML text representation of an attribute and its value.</returns>
		// Token: 0x0600000E RID: 14 RVA: 0x000021B4 File Offset: 0x000003B4
		public override string ToString()
		{
			string result;
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings
				{
					ConformanceLevel = ConformanceLevel.Fragment
				}))
				{
					xmlWriter.WriteAttributeString(this.GetPrefixOfNamespace(this.name.Namespace), this.name.LocalName, this.name.NamespaceName, this.value);
				}
				result = stringWriter.ToString().Trim();
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002258 File Offset: 0x00000458
		internal int GetDeepHashCode()
		{
			return this.name.GetHashCode() ^ this.value.GetHashCode();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002274 File Offset: 0x00000474
		internal string GetPrefixOfNamespace(XNamespace ns)
		{
			string namespaceName = ns.NamespaceName;
			if (namespaceName.Length == 0)
			{
				return string.Empty;
			}
			if (this.parent != null)
			{
				return ((XElement)this.parent).GetPrefixOfNamespace(ns);
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

		// Token: 0x06000011 RID: 17 RVA: 0x000022D0 File Offset: 0x000004D0
		private static void ValidateAttribute(XName name, string value)
		{
			string namespaceName = name.NamespaceName;
			if (namespaceName == "http://www.w3.org/2000/xmlns/")
			{
				if (value.Length == 0)
				{
					throw new ArgumentException(SR.Format("The prefix '{0}' cannot be bound to the empty namespace name.", name.LocalName));
				}
				if (value == "http://www.w3.org/XML/1998/namespace")
				{
					if (name.LocalName != "xml")
					{
						throw new ArgumentException("The prefix 'xml' is bound to the namespace name 'http://www.w3.org/XML/1998/namespace'. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
					}
				}
				else
				{
					if (value == "http://www.w3.org/2000/xmlns/")
					{
						throw new ArgumentException("The prefix 'xmlns' is bound to the namespace name 'http://www.w3.org/2000/xmlns/'. It must not be declared. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
					}
					string localName = name.LocalName;
					if (localName == "xml")
					{
						throw new ArgumentException("The prefix 'xml' is bound to the namespace name 'http://www.w3.org/XML/1998/namespace'. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
					}
					if (localName == "xmlns")
					{
						throw new ArgumentException("The prefix 'xmlns' is bound to the namespace name 'http://www.w3.org/2000/xmlns/'. It must not be declared. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
					}
				}
			}
			else if (namespaceName.Length == 0 && name.LocalName == "xmlns")
			{
				if (value == "http://www.w3.org/XML/1998/namespace")
				{
					throw new ArgumentException("The prefix 'xml' is bound to the namespace name 'http://www.w3.org/XML/1998/namespace'. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
				}
				if (value == "http://www.w3.org/2000/xmlns/")
				{
					throw new ArgumentException("The prefix 'xmlns' is bound to the namespace name 'http://www.w3.org/2000/xmlns/'. It must not be declared. Other prefixes must not be bound to this namespace name, and it must not be declared as the default namespace.");
				}
			}
		}

		// Token: 0x04000004 RID: 4
		internal XAttribute next;

		// Token: 0x04000005 RID: 5
		internal XName name;

		// Token: 0x04000006 RID: 6
		internal string value;
	}
}
