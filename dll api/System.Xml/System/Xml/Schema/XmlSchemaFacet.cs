using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Abstract class for all facets that are used when simple types are derived by restriction.</summary>
	// Token: 0x020002ED RID: 749
	public abstract class XmlSchemaFacet : XmlSchemaAnnotated
	{
		/// <summary>Gets or sets the <see langword="value" /> attribute of the facet.</summary>
		/// <returns>The value attribute.</returns>
		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00097D97 File Offset: 0x00095F97
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00097D9F File Offset: 0x00095F9F
		[XmlAttribute("value")]
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		/// <summary>Gets or sets information that indicates that this facet is fixed.</summary>
		/// <returns>If <see langword="true" />, value is fixed; otherwise, <see langword="false" />. The default is <see langword="false" />.Optional.</returns>
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00097DA8 File Offset: 0x00095FA8
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x00097DB0 File Offset: 0x00095FB0
		[XmlAttribute("fixed")]
		[DefaultValue(false)]
		public virtual bool IsFixed
		{
			get
			{
				return this.isFixed;
			}
			set
			{
				if (!(this is XmlSchemaEnumerationFacet) && !(this is XmlSchemaPatternFacet))
				{
					this.isFixed = value;
				}
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00097DC9 File Offset: 0x00095FC9
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x00097DD1 File Offset: 0x00095FD1
		internal FacetType FacetType
		{
			get
			{
				return this.facetType;
			}
			set
			{
				this.facetType = value;
			}
		}

		// Token: 0x040010C0 RID: 4288
		private string value;

		// Token: 0x040010C1 RID: 4289
		private bool isFixed;

		// Token: 0x040010C2 RID: 4290
		private FacetType facetType;
	}
}
