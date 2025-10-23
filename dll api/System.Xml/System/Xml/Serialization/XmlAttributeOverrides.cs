using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Allows you to override property, field, and class attributes when you use the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to serialize or deserialize an object.</summary>
	// Token: 0x020001E2 RID: 482
	public class XmlAttributeOverrides
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> class. </summary>
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00064B89 File Offset: 0x00062D89
		public XmlAttributeOverrides()
		{
			this.overrides = new Hashtable();
		}

		/// <summary>Gets the object associated with the specified, base-class, type.</summary>
		/// <param name="type">The base class <see cref="T:System.Type" /> that is associated with the collection of attributes you want to retrieve. </param>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents the collection of overriding attributes.</returns>
		// Token: 0x17000322 RID: 802
		public XmlAttributes this[Type type]
		{
			get
			{
				return this[type, string.Empty];
			}
		}

		/// <summary>Gets the object associated with the specified (base-class) type. The member parameter specifies the base-class member that is overridden.</summary>
		/// <param name="type">The base class <see cref="T:System.Type" /> that is associated with the collection of attributes you want. </param>
		/// <param name="member">The name of the overridden member that specifies the <see cref="T:System.Xml.Serialization.XmlAttributes" /> to return. </param>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents the collection of overriding attributes.</returns>
		// Token: 0x17000323 RID: 803
		public XmlAttributes this[Type type, string member]
		{
			get
			{
				return (XmlAttributes)this.overrides[this.GetKey(type, member)];
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00064BC4 File Offset: 0x00062DC4
		private TypeMember GetKey(Type type, string member)
		{
			return new TypeMember(type, member);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00064BD0 File Offset: 0x00062DD0
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XAO ");
			foreach (object obj in this.overrides)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				XmlAttributes xmlAttributes = (XmlAttributes)dictionaryEntry.Value;
				IFormattable formattable = dictionaryEntry.Key as IFormattable;
				sb.Append((formattable != null) ? formattable.ToString(null, CultureInfo.InvariantCulture) : dictionaryEntry.Key.ToString()).Append(' ');
				xmlAttributes.AddKeyHash(sb);
			}
			sb.Append("|");
		}

		// Token: 0x04000B5B RID: 2907
		private Hashtable overrides;
	}
}
