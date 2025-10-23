using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Represents a collection of attribute objects that control how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes and deserializes an object.</summary>
	// Token: 0x020001E3 RID: 483
	public class XmlAttributes
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributes" /> class.</summary>
		// Token: 0x06000FFA RID: 4090 RVA: 0x00064C84 File Offset: 0x00062E84
		public XmlAttributes()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributes" /> class and customizes how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes and deserializes an object. </summary>
		/// <param name="provider">A class that can provide alternative implementations of attributes that control XML serialization.</param>
		// Token: 0x06000FFB RID: 4091 RVA: 0x00064CB8 File Offset: 0x00062EB8
		public XmlAttributes(ICustomAttributeProvider provider)
		{
			foreach (object obj in provider.GetCustomAttributes(false))
			{
				if (obj is XmlAnyAttributeAttribute)
				{
					this.xmlAnyAttribute = (XmlAnyAttributeAttribute)obj;
				}
				else if (obj is XmlAnyElementAttribute)
				{
					this.xmlAnyElements.Add((XmlAnyElementAttribute)obj);
				}
				else if (obj is XmlArrayAttribute)
				{
					this.xmlArray = (XmlArrayAttribute)obj;
				}
				else if (obj is XmlArrayItemAttribute)
				{
					this.xmlArrayItems.Add((XmlArrayItemAttribute)obj);
				}
				else if (obj is XmlAttributeAttribute)
				{
					this.xmlAttribute = (XmlAttributeAttribute)obj;
				}
				else if (obj is XmlChoiceIdentifierAttribute)
				{
					this.xmlChoiceIdentifier = (XmlChoiceIdentifierAttribute)obj;
				}
				else if (obj is DefaultValueAttribute)
				{
					this.xmlDefaultValue = ((DefaultValueAttribute)obj).Value;
				}
				else if (obj is XmlElementAttribute)
				{
					this.xmlElements.Add((XmlElementAttribute)obj);
				}
				else if (obj is XmlEnumAttribute)
				{
					this.xmlEnum = (XmlEnumAttribute)obj;
				}
				else if (obj is XmlIgnoreAttribute)
				{
					this.xmlIgnore = true;
				}
				else if (obj is XmlNamespaceDeclarationsAttribute)
				{
					this.xmlns = true;
				}
				else if (obj is XmlRootAttribute)
				{
					this.xmlRoot = (XmlRootAttribute)obj;
				}
				else if (obj is XmlTextAttribute)
				{
					this.xmlText = (XmlTextAttribute)obj;
				}
				else if (obj is XmlTypeAttribute)
				{
					this.xmlType = (XmlTypeAttribute)obj;
				}
			}
			if (this.xmlIgnore)
			{
				this.xmlAnyAttribute = null;
				this.xmlAnyElements.Clear();
				this.xmlArray = null;
				this.xmlArrayItems.Clear();
				this.xmlAttribute = null;
				this.xmlChoiceIdentifier = null;
				this.xmlDefaultValue = null;
				this.xmlElements.Clear();
				this.xmlEnum = null;
				this.xmlns = false;
				this.xmlRoot = null;
				this.xmlText = null;
				this.xmlType = null;
			}
		}

		/// <summary>Gets or sets the <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> to override.</summary>
		/// <returns>The <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> to override.</returns>
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00064EDA File Offset: 0x000630DA
		public XmlAnyAttributeAttribute XmlAnyAttribute
		{
			get
			{
				return this.xmlAnyAttribute;
			}
		}

		/// <summary>Gets the collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects to override.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAnyElementAttributes" /> object that represents the collection of <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> objects.</returns>
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00064EE2 File Offset: 0x000630E2
		public XmlAnyElementAttributes XmlAnyElements
		{
			get
			{
				return this.xmlAnyElements;
			}
		}

		/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property that returns an array.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property that returns an array.</returns>
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00064EEA File Offset: 0x000630EA
		public XmlArrayAttribute XmlArray
		{
			get
			{
				return this.xmlArray;
			}
		}

		/// <summary>Gets or sets a collection of objects that specify how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes items inserted into an array returned by a public field or read/write property.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlArrayItemAttributes" /> object that contains a collection of <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> objects.</returns>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00064EF2 File Offset: 0x000630F2
		public XmlArrayItemAttributes XmlArrayItems
		{
			get
			{
				return this.xmlArrayItems;
			}
		}

		/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or public read/write property as an XML attribute.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" /> that controls the serialization of a public field or read/write property as an XML attribute.</returns>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00064EFA File Offset: 0x000630FA
		public XmlAttributeAttribute XmlAttribute
		{
			get
			{
				return this.xmlAttribute;
			}
		}

		/// <summary>Gets or sets an object that allows you to distinguish between a set of choices.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlChoiceIdentifierAttribute" /> that can be applied to a class member that is serialized as an <see langword="xsi:choice" /> element.</returns>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00064F02 File Offset: 0x00063102
		public XmlChoiceIdentifierAttribute XmlChoiceIdentifier
		{
			get
			{
				return this.xmlChoiceIdentifier;
			}
		}

		/// <summary>Gets or sets the default value of an XML element or attribute.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the default value of an XML element or attribute.</returns>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00064F0A File Offset: 0x0006310A
		public object XmlDefaultValue
		{
			get
			{
				return this.xmlDefaultValue;
			}
		}

		/// <summary>Gets a collection of objects that specify how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or read/write property as an XML element.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> that contains a collection of <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> objects.</returns>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00064F12 File Offset: 0x00063112
		public XmlElementAttributes XmlElements
		{
			get
			{
				return this.xmlElements;
			}
		}

		/// <summary>Gets or sets a value that specifies whether or not the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a public field or public read/write property.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Serialization.XmlSerializer" /> must not serialize the field or property; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00064F1A File Offset: 0x0006311A
		public bool XmlIgnore
		{
			get
			{
				return this.xmlIgnore;
			}
		}

		/// <summary>Gets or sets a value that specifies whether to keep all namespace declarations when an object containing a member that returns an <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> object is overridden.</summary>
		/// <returns>
		///     <see langword="true" /> if the namespace declarations should be kept; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00064F22 File Offset: 0x00063122
		public bool Xmlns
		{
			get
			{
				return this.xmlns;
			}
		}

		/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a class as an XML root element.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that overrides a class attributed as an XML root element.</returns>
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00064F2A File Offset: 0x0006312A
		public XmlRootAttribute XmlRoot
		{
			get
			{
				return this.xmlRoot;
			}
		}

		/// <summary>Gets or sets an object that instructs the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to serialize a public field or public read/write property as XML text.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlTextAttribute" /> that overrides the default serialization of a public property or field.</returns>
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00064F32 File Offset: 0x00063132
		public XmlTextAttribute XmlText
		{
			get
			{
				return this.xmlText;
			}
		}

		/// <summary>Gets or sets an object that specifies how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes a class to which the <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> has been applied.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> that overrides an <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> applied to a class declaration.</returns>
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00064F3A File Offset: 0x0006313A
		public XmlTypeAttribute XmlType
		{
			get
			{
				return this.xmlType;
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00064F44 File Offset: 0x00063144
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XA ");
			KeyHelper.AddField(sb, 1, this.xmlIgnore);
			KeyHelper.AddField(sb, 2, this.xmlns);
			KeyHelper.AddField(sb, 3, this.xmlAnyAttribute != null);
			this.xmlAnyElements.AddKeyHash(sb);
			this.xmlArrayItems.AddKeyHash(sb);
			this.xmlElements.AddKeyHash(sb);
			if (this.xmlArray != null)
			{
				this.xmlArray.AddKeyHash(sb);
			}
			if (this.xmlAttribute != null)
			{
				this.xmlAttribute.AddKeyHash(sb);
			}
			if (this.xmlDefaultValue == null)
			{
				sb.Append("n");
			}
			else if (!(this.xmlDefaultValue is DBNull))
			{
				string str = XmlCustomFormatter.ToXmlString(TypeTranslator.GetTypeData(this.xmlDefaultValue.GetType()), this.xmlDefaultValue);
				sb.Append("v" + str);
			}
			if (this.xmlEnum != null)
			{
				this.xmlEnum.AddKeyHash(sb);
			}
			if (this.xmlRoot != null)
			{
				this.xmlRoot.AddKeyHash(sb);
			}
			if (this.xmlText != null)
			{
				this.xmlText.AddKeyHash(sb);
			}
			if (this.xmlType != null)
			{
				this.xmlType.AddKeyHash(sb);
			}
			if (this.xmlChoiceIdentifier != null)
			{
				this.xmlChoiceIdentifier.AddKeyHash(sb);
			}
			sb.Append("|");
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600100A RID: 4106 RVA: 0x00065094 File Offset: 0x00063294
		internal int? Order
		{
			get
			{
				int? result = null;
				if (this.XmlElements.Count > 0)
				{
					result = new int?(this.XmlElements.Order);
				}
				else if (this.XmlArray != null)
				{
					result = new int?(this.XmlArray.Order);
				}
				else if (this.XmlAnyElements.Count > 0)
				{
					result = new int?(this.XmlAnyElements.Order);
				}
				return result;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00065108 File Offset: 0x00063308
		internal int SortableOrder
		{
			get
			{
				if (this.Order == null)
				{
					return int.MinValue;
				}
				return this.Order.Value;
			}
		}

		// Token: 0x04000B5C RID: 2908
		private XmlAnyAttributeAttribute xmlAnyAttribute;

		// Token: 0x04000B5D RID: 2909
		private XmlAnyElementAttributes xmlAnyElements = new XmlAnyElementAttributes();

		// Token: 0x04000B5E RID: 2910
		private XmlArrayAttribute xmlArray;

		// Token: 0x04000B5F RID: 2911
		private XmlArrayItemAttributes xmlArrayItems = new XmlArrayItemAttributes();

		// Token: 0x04000B60 RID: 2912
		private XmlAttributeAttribute xmlAttribute;

		// Token: 0x04000B61 RID: 2913
		private XmlChoiceIdentifierAttribute xmlChoiceIdentifier;

		// Token: 0x04000B62 RID: 2914
		private object xmlDefaultValue = DBNull.Value;

		// Token: 0x04000B63 RID: 2915
		private XmlElementAttributes xmlElements = new XmlElementAttributes();

		// Token: 0x04000B64 RID: 2916
		private XmlEnumAttribute xmlEnum;

		// Token: 0x04000B65 RID: 2917
		private bool xmlIgnore;

		// Token: 0x04000B66 RID: 2918
		private bool xmlns;

		// Token: 0x04000B67 RID: 2919
		private XmlRootAttribute xmlRoot;

		// Token: 0x04000B68 RID: 2920
		private XmlTextAttribute xmlText;

		// Token: 0x04000B69 RID: 2921
		private XmlTypeAttribute xmlType;
	}
}
