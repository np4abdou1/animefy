using System;

namespace System.Reflection
{
	/// <summary>Provides information about an <see cref="T:System.Reflection.Assembly" /> reference.</summary>
	// Token: 0x0200048D RID: 1165
	[Flags]
	public enum AssemblyNameFlags
	{
		/// <summary>Specifies that no flags are in effect.</summary>
		// Token: 0x04000FA3 RID: 4003
		None = 0,
		/// <summary>Specifies that a public key is formed from the full public key rather than the public key token.</summary>
		// Token: 0x04000FA4 RID: 4004
		PublicKey = 1,
		/// <summary>Specifies that just-in-time (JIT) compiler optimization is disabled for the assembly. This is the exact opposite of the meaning that is suggested by the member name.</summary>
		// Token: 0x04000FA5 RID: 4005
		EnableJITcompileOptimizer = 16384,
		/// <summary>Specifies that just-in-time (JIT) compiler tracking is enabled for the assembly.</summary>
		// Token: 0x04000FA6 RID: 4006
		EnableJITcompileTracking = 32768,
		/// <summary>Specifies that the assembly can be retargeted at runtime to an assembly from a different publisher. This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04000FA7 RID: 4007
		Retargetable = 256
	}
}
