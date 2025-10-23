using System;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Controls how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes an enumeration member.</summary>
	// Token: 0x020001E8 RID: 488
	[AttributeUsage(AttributeTargets.Field)]
	public class XmlEnumAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlEnumAttribute" /> class, and specifies the XML value that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> generates or recognizes (when it serializes or deserializes the enumeration, respectively).</summary>
		/// <param name="name">The overriding name of the enumeration member. </param>
		// Token: 0x06001023 RID: 4131 RVA: 0x00065D90 File Offset: 0x00063F90
		public XmlEnumAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>Gets or sets the value generated in an XML-document instance when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes an enumeration, or the value recognized when it deserializes the enumeration member.</summary>
		/// <returns>The value generated in an XML-document instance when the <see cref="T:System.Xml.Serialization.XmlSerializer" /> serializes the enumeration, or the value recognized when it is deserializes the enumeration member.</returns>
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00065D9F File Offset: 0x00063F9F
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00065DA7 File Offset: 0x00063FA7
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XENA ");
			KeyHelper.AddField(sb, 1, this.name);
			sb.Append('|');
		}

		// Token: 0x04000B73 RID: 2931
		private string name;
	}
}
