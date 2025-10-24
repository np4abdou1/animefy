using System;

namespace Java.Interop
{
	// Token: 0x0200007B RID: 123
	internal struct JavaVMInterface
	{
		// Token: 0x0400011C RID: 284
		public IntPtr reserved0;

		// Token: 0x0400011D RID: 285
		public IntPtr reserved1;

		// Token: 0x0400011E RID: 286
		public IntPtr reserved2;

		// Token: 0x0400011F RID: 287
		public DestroyJavaVMDelegate DestroyJavaVM;

		// Token: 0x04000120 RID: 288
		public AttachCurrentThreadDelegate AttachCurrentThread;

		// Token: 0x04000121 RID: 289
		public DetachCurrentThreadDelegate DetachCurrentThread;

		// Token: 0x04000122 RID: 290
		public GetEnvDelegate GetEnv;

		// Token: 0x04000123 RID: 291
		public AttachCurrentThreadAsDaemonDelegate AttachCurrentThreadAsDaemon;
	}
}
