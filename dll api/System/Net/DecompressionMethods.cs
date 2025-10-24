using System;

namespace System.Net
{
	/// <summary>Represents the file compression and decompression encoding format to be used to compress the data received in response to an <see cref="T:System.Net.HttpWebRequest" />.</summary>
	// Token: 0x020001A2 RID: 418
	[Flags]
	public enum DecompressionMethods
	{
		/// <summary>Do not use compression.</summary>
		// Token: 0x0400081A RID: 2074
		None = 0,
		/// <summary>Use the gZip compression-decompression algorithm.</summary>
		// Token: 0x0400081B RID: 2075
		GZip = 1,
		/// <summary>Use the deflate compression-decompression algorithm.</summary>
		// Token: 0x0400081C RID: 2076
		Deflate = 2
	}
}
