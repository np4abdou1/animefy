using System;

namespace System.Text
{
	/// <summary>Defines the type of normalization to perform.</summary>
	// Token: 0x0200025C RID: 604
	public enum NormalizationForm
	{
		/// <summary>Indicates that a Unicode string is normalized using full canonical decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
		// Token: 0x0400083F RID: 2111
		FormC = 1,
		/// <summary>Indicates that a Unicode string is normalized using full canonical decomposition.</summary>
		// Token: 0x04000840 RID: 2112
		FormD,
		/// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
		// Token: 0x04000841 RID: 2113
		FormKC = 5,
		/// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition.</summary>
		// Token: 0x04000842 RID: 2114
		FormKD
	}
}
