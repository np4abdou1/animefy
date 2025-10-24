using System;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Specifies that the member (a field that returns an array of <see cref="T:System.Xml.XmlElement" /> or <see cref="T:System.Xml.XmlNode" /> objects) contains objects that represent any XML element that has no corresponding member in the object being serialized or deserialized.</summary>
	// Token: 0x020001DC RID: 476
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlAnyElementAttribute : Attribute
	{
		/// <summary>Gets or sets the XML element name.</summary>
		/// <returns>The name of the XML element.</returns>
		/// <exception cref="T:System.InvalidOperationException">The element name of an array member does not match the element name specified by the <see cref="P:System.Xml.Serialization.XmlAnyElementAttribute.Name" /> property. </exception>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0006478C File Offset: 0x0006298C
		public string Name
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

		/// <summary>Gets or sets the XML namespace generated in the XML document.</summary>
		/// <returns>An XML namespace.</returns>
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000647A2 File Offset: 0x000629A2
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		/// <summary>Gets or sets the explicit order in which the elements are serialized or deserialized.</summary>
		/// <returns>The order of the code generation.</returns>
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x000647AA File Offset: 0x000629AA
		public int Order
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000647B2 File Offset: 0x000629B2
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XAEA ");
			KeyHelper.AddField(sb, 1, this.ns);
			KeyHelper.AddField(sb, 2, this.elementName);
			sb.Append('|');
		}

		// Token: 0x04000B46 RID: 2886
		private string elementName;

		// Token: 0x04000B47 RID: 2887
		private string ns;

		// Token: 0x04000B48 RID: 2888
		private int order = -1;
	}
}
