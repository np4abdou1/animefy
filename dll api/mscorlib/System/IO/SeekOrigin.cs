using System;

namespace System.IO
{
	/// <summary>Specifies the position in a stream to use for seeking.</summary>
	// Token: 0x0200052E RID: 1326
	public enum SeekOrigin
	{
		/// <summary>Specifies the beginning of a stream.</summary>
		// Token: 0x04001454 RID: 5204
		Begin,
		/// <summary>Specifies the current position within a stream.</summary>
		// Token: 0x04001455 RID: 5205
		Current,
		/// <summary>Specifies the end of a stream.</summary>
		// Token: 0x04001456 RID: 5206
		End
	}
}
