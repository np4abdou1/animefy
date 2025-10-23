using System;

namespace System
{
	/// <summary>Defines the kinds of <see cref="T:System.Uri" />s for the <see cref="M:System.Uri.IsWellFormedUriString(System.String,System.UriKind)" /> and several <see cref="Overload:System.Uri.#ctor" /> methods.</summary>
	// Token: 0x0200007F RID: 127
	public enum UriKind
	{
		/// <summary>The kind of the Uri is indeterminate.</summary>
		// Token: 0x04000208 RID: 520
		RelativeOrAbsolute,
		/// <summary>The Uri is an absolute Uri.</summary>
		// Token: 0x04000209 RID: 521
		Absolute,
		/// <summary>The Uri is a relative Uri.</summary>
		// Token: 0x0400020A RID: 522
		Relative
	}
}
