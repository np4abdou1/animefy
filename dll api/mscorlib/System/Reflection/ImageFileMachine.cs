using System;

namespace System.Reflection
{
	/// <summary>Identifies the platform targeted by an executable.</summary>
	// Token: 0x020004A2 RID: 1186
	public enum ImageFileMachine
	{
		/// <summary>Targets a 32-bit Intel processor.</summary>
		// Token: 0x04000FF3 RID: 4083
		I386 = 332,
		/// <summary>Targets a 64-bit Intel processor.</summary>
		// Token: 0x04000FF4 RID: 4084
		IA64 = 512,
		/// <summary>Targets a 64-bit AMD processor.</summary>
		// Token: 0x04000FF5 RID: 4085
		AMD64 = 34404,
		/// <summary>Targets an ARM processor.</summary>
		// Token: 0x04000FF6 RID: 4086
		ARM = 452
	}
}
