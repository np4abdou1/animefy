using System;
using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Controls the XML schema that is generated when the attribute target is serialized by the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	// Token: 0x0200020C RID: 524
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public class XmlTypeAttribute : Attribute
	{
		/// <summary>Gets or sets a value that indicates whether to include the type in XML schema documents.</summary>
		/// <returns>
		///     <see langword="true" /> to include the type in XML schema documents; otherwise, <see langword="false" />.</returns>
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0006D77F File Offset: 0x0006B97F
		public bool IncludeInSchema
		{
			get
			{
				return this.includeInSchema;
			}
		}

		/// <summary>Gets or sets the namespace of the XML type.</summary>
		/// <returns>The namespace of the XML type.</returns>
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0006D787 File Offset: 0x0006B987
		public string Namespace
		{
			get
			{
				return this.ns;
			}
		}

		/// <summary>Gets or sets the name of the XML type.</summary>
		/// <returns>The name of the XML type.</returns>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0006D78F File Offset: 0x0006B98F
		public string TypeName
		{
			get
			{
				if (this.typeName == null)
				{
					return string.Empty;
				}
				return this.typeName;
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0006D7A5 File Offset: 0x0006B9A5
		internal void AddKeyHash(StringBuilder sb)
		{
			sb.Append("XTA ");
			KeyHelper.AddField(sb, 1, this.ns);
			KeyHelper.AddField(sb, 2, this.typeName);
			KeyHelper.AddField(sb, 4, this.includeInSchema);
			sb.Append('|');
		}

		// Token: 0x04000BEA RID: 3050
		private bool includeInSchema;

		// Token: 0x04000BEB RID: 3051
		private string ns;

		// Token: 0x04000BEC RID: 3052
		private string typeName;
	}
}
