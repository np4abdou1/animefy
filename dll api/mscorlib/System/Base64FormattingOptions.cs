using System;

namespace System
{
	/// <summary>Specifies whether relevant <see cref="Overload:System.Convert.ToBase64CharArray" /> and <see cref="Overload:System.Convert.ToBase64String" /> methods insert line breaks in their output. </summary>
	// Token: 0x0200008D RID: 141
	[Flags]
	public enum Base64FormattingOptions
	{
		/// <summary>Does not insert line breaks after every 76 characters in the string representation.</summary>
		// Token: 0x040001DE RID: 478
		None = 0,
		/// <summary>Inserts line breaks after every 76 characters in the string representation.</summary>
		// Token: 0x040001DF RID: 479
		InsertLineBreaks = 1
	}
}
