using System;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003C0 RID: 960
	internal enum InternalParseTypeE
	{
		// Token: 0x04000C91 RID: 3217
		Empty,
		// Token: 0x04000C92 RID: 3218
		SerializedStreamHeader,
		// Token: 0x04000C93 RID: 3219
		Object,
		// Token: 0x04000C94 RID: 3220
		Member,
		// Token: 0x04000C95 RID: 3221
		ObjectEnd,
		// Token: 0x04000C96 RID: 3222
		MemberEnd,
		// Token: 0x04000C97 RID: 3223
		Headers,
		// Token: 0x04000C98 RID: 3224
		HeadersEnd,
		// Token: 0x04000C99 RID: 3225
		SerializedStreamHeaderEnd,
		// Token: 0x04000C9A RID: 3226
		Envelope,
		// Token: 0x04000C9B RID: 3227
		EnvelopeEnd,
		// Token: 0x04000C9C RID: 3228
		Body,
		// Token: 0x04000C9D RID: 3229
		BodyEnd
	}
}
