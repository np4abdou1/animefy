using System;

namespace Java.Interop
{
	// Token: 0x0200006E RID: 110
	[Flags]
	public enum JniObjectReferenceOptions
	{
		// Token: 0x040000FC RID: 252
		None = 0,
		// Token: 0x040000FD RID: 253
		Copy = 1,
		// Token: 0x040000FE RID: 254
		CopyAndDispose = 3,
		// Token: 0x040000FF RID: 255
		CopyAndDoNotRegister = 5
	}
}
