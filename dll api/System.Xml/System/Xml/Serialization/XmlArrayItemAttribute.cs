using System;
using System.Text;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>Represents an attribute that specifies the derived types that the <see cref="T:System.Xml.Serialization.XmlSerializer" /> can place in a serialized array.</summary>
	// Token: 0x020001DF RID: 479
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlArrayItemAttribute : Attribute
	{
		/// <summary>Gets or sets the XML data type of the generated XML element.</summary>
		/// <returns>An XML schema definition (XSD) data type, as defined by the World Wide Web Consortium (www.w3.org) document "XML Schema Part 2: DataTypes".</returns>
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00064964 File Offset: 0x00062B64
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
		}

		/// <summary>Gets or sets the name of the generated XML element.</summary>
		/// <returns>The name of the generated XML element. The default is the member identifier.</returns>
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0006497A File Offset: 0x00062B7A
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
		}

		/// <summary>Gets or sets a value that indicates whether the name of the generated XML element is qualified.</summary>
		/// <returns>One of the <see cref="T:System.Xml.Schema.XmlSchemaForm" /> values. The default is <see langword="XmlSchemaForm.None" />.</returns>
		/// <exception cref="T:System.Exception">The <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Form" /> property is set to <see langword="XmlSchemaForm.Unqualified" /> and a <see cref="P:System.Xml.Serialization.XmlArrayItemAttribute.Namespace" /> value is specified. </exception>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00064990 File Offset: 0x00062B90
		public XmlSchemaForm Form
		{
			get
			{
				return this.form;
			}
		}

		/// <summary>Gets or sets the namespace of the generated XML element.</summary>
		/// <returns>The namespace of the generated XML element.</returns>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00064998 File Offset: 0x00062B98
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.Serialization.XmlSerializer" /> must serialize a member as an empty XML tag with the <see langword="xsi:nil" /> attribute set to <see langword="true" />.</summary>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.Serialization.XmlSerializer" /> generates the <see langword="xsi:nil" /> attribute; otherwise, <see langword="false" />, and no instance is generated. The default is <see langword="true" />.</returns>
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000649A0 File Offset: 0x00062BA0
		public bool IsNullable
		{
			get
			{
				return this.isNullable;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000649A8 File Offset: 0x00062BA8
		internal bool IsNullableSpecified
		{
			get
			{
				return this.isNullableSpecified;
			}
		}

		/// <summary>Gets or sets the type allowed in an array.</summary>
		/// <returns>A <see cref="T:System.Type" /> that is allowed in the array.</returns>
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000649B0 File Offset: 0x00062BB0
		public Type Type
		{
			get
			{
				return this.type;
			}
		}

		/// <summary>Gets or sets the level in a hierarchy of XML elements that the <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> affects.</summary>
		/// <returns>The zero-based index of a set of indexes in an array of arrays.</returns>
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x000649B8 File Offset: 0x00062BB8
		public int NestingLevel
		{
			get
			{
				return this.nestingLevel;
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000649C0 File Offset: 0x00062BC0
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XAIA ");
			KeyHelper.AddField(sb, 1, this.ns);
			KeyHelper.AddField(sb, 2, this.elementName);
			KeyHelper.AddField(sb, 3, this.form.ToString(), XmlSchemaForm.None.ToString());
			KeyHelper.AddField(sb, 4, this.isNullable, true);
			KeyHelper.AddField(sb, 5, this.dataType);
			KeyHelper.AddField(sb, 6, this.nestingLevel, 0);
			KeyHelper.AddField(sb, 7, this.type);
			sb.Append('|');
		}

		// Token: 0x04000B4E RID: 2894
		private string dataType;

		// Token: 0x04000B4F RID: 2895
		private string elementName;

		// Token: 0x04000B50 RID: 2896
		private XmlSchemaForm form;

		// Token: 0x04000B51 RID: 2897
		private string ns;

		// Token: 0x04000B52 RID: 2898
		private bool isNullable;

		// Token: 0x04000B53 RID: 2899
		private bool isNullableSpecified;

		// Token: 0x04000B54 RID: 2900
		private int nestingLevel;

		// Token: 0x04000B55 RID: 2901
		private Type type;
	}
}
