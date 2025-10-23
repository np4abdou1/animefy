using System;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Controls XML serialization of the attribute target as an XML root element.</summary>
	// Token: 0x020001F4 RID: 500
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.ReturnValue)]
	public class XmlRootAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> class.</summary>
		// Token: 0x0600105B RID: 4187 RVA: 0x00068005 File Offset: 0x00066205
		public XmlRootAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> class and specifies the name of the XML root element.</summary>
		/// <param name="elementName">The name of the XML root element. </param>
		// Token: 0x0600105C RID: 4188 RVA: 0x00068014 File Offset: 0x00066214
		public XmlRootAttribute(string elementName)
		{
			this.elementName = elementName;
		}

		/// <summary>Gets or sets the XSD data type of the XML root element.</summary>
		/// <returns>An XSD (XML Schema Document) data type, as defined by the World Wide Web Consortium (www.w3.org) document named "XML Schema: DataTypes".</returns>
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0006802A File Offset: 0x0006622A
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x00068040 File Offset: 0x00066240
		public string DataType
		{
			get
			{
				if (this.dataType == null)
				{
					return string.Empty;
				}
				return this.dataType;
			}
			set
			{
				this.dataType = value;
			}
		}

		/// <summary>Gets or sets the name of the XML element that is generated and recognized by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class's <see cref="M:System.Xml.Serialization.XmlSerializer.Serialize(System.IO.TextWriter,System.Object)" /> and <see cref="M:System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.Stream)" /> methods, respectively.</summary>
		/// <returns>The name of the XML root element that is generated and recognized in an XML-document instance. The default is the name of the serialized class.</returns>
		// Token: 0x1700034D RID: 845
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x00068049 File Offset: 0x00066249
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x0006805F File Offset: 0x0006625F
		public string ElementName
		{
			get
			{
				if (this.elementName == null)
				{
					return string.Empty;
				}
				return this.elementName;
			}
			set
			{
				this.elementName = value;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.Serialization.XmlSerializer" /> must serialize a member that is set to <see langword="null" /> into the <see langword="xsi:nil" /> attribute set to <see langword="true" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Serialization.XmlSerializer" /> generates the <see langword="xsi:nil" /> attribute; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00068068 File Offset: 0x00066268
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x00068070 File Offset: 0x00066270
		public bool IsNullable
		{
			get
			{
				return this.isNullable;
			}
			set
			{
				this.isNullable = value;
			}
		}

		/// <summary>Gets or sets the namespace for the XML root element.</summary>
		/// <returns>The namespace for the XML element.</returns>
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00068079 File Offset: 0x00066279
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00068081 File Offset: 0x00066281
		public string Namespace
		{
			get
			{
				return this.ns;
			}
			set
			{
				this.ns = value;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0006808C File Offset: 0x0006628C
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XRA ");
			KeyHelper.AddField(sb, 1, this.ns);
			KeyHelper.AddField(sb, 2, this.elementName);
			KeyHelper.AddField(sb, 3, this.dataType);
			KeyHelper.AddField(sb, 4, this.isNullable);
			sb.Append('|');
		}

		// Token: 0x04000B91 RID: 2961
		private string dataType;

		// Token: 0x04000B92 RID: 2962
		private string elementName;

		// Token: 0x04000B93 RID: 2963
		private bool isNullable = true;

		// Token: 0x04000B94 RID: 2964
		private string ns;
	}
}
