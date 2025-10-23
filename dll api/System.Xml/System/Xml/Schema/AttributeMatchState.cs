using System;

namespace System.Xml.Schema
{
	// Token: 0x020002B4 RID: 692
	internal enum AttributeMatchState
	{
		// Token: 0x04000E50 RID: 3664
		AttributeFound,
		// Token: 0x04000E51 RID: 3665
		AnyIdAttributeFound,
		// Token: 0x04000E52 RID: 3666
		UndeclaredElementAndAttribute,
		// Token: 0x04000E53 RID: 3667
		UndeclaredAttribute,
		// Token: 0x04000E54 RID: 3668
		AnyAttributeLax,
		// Token: 0x04000E55 RID: 3669
		AnyAttributeSkip,
		// Token: 0x04000E56 RID: 3670
		ProhibitedAnyAttribute,
		// Token: 0x04000E57 RID: 3671
		ProhibitedAttribute,
		// Token: 0x04000E58 RID: 3672
		AttributeNameMismatch,
		// Token: 0x04000E59 RID: 3673
		ValidateAttributeInvalidCall
	}
}
