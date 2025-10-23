using System;

namespace System.Xml.XPath
{
	/// <summary>Specifies the return type of the XPath expression.</summary>
	// Token: 0x020001C1 RID: 449
	public enum XPathResultType
	{
		/// <summary>A numeric value.</summary>
		// Token: 0x04000AF9 RID: 2809
		Number,
		/// <summary>A <see cref="T:System.String" /> value.</summary>
		// Token: 0x04000AFA RID: 2810
		String,
		/// <summary>A <see cref="T:System.Boolean" /><see langword="true" /> or <see langword="false" /> value.</summary>
		// Token: 0x04000AFB RID: 2811
		Boolean,
		/// <summary>A node collection.</summary>
		// Token: 0x04000AFC RID: 2812
		NodeSet,
		/// <summary>A tree fragment.</summary>
		// Token: 0x04000AFD RID: 2813
		Navigator = 1,
		/// <summary>Any of the XPath node types.</summary>
		// Token: 0x04000AFE RID: 2814
		Any = 5,
		/// <summary>The expression does not evaluate to the correct XPath type.</summary>
		// Token: 0x04000AFF RID: 2815
		Error
	}
}
