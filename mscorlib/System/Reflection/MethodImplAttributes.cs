using System;

namespace System.Reflection
{
	/// <summary>Specifies flags for the attributes of a method implementation.</summary>
	// Token: 0x020004AA RID: 1194
	public enum MethodImplAttributes
	{
		/// <summary>Specifies flags about code type.</summary>
		// Token: 0x0400101B RID: 4123
		CodeTypeMask = 3,
		/// <summary>Specifies that the method implementation is in Microsoft intermediate language (MSIL).</summary>
		// Token: 0x0400101C RID: 4124
		IL = 0,
		/// <summary>Specifies that the method implementation is native.</summary>
		// Token: 0x0400101D RID: 4125
		Native,
		/// <summary>Specifies that the method implementation is in Optimized Intermediate Language (OPTIL).</summary>
		// Token: 0x0400101E RID: 4126
		OPTIL,
		/// <summary>Specifies that the method implementation is provided by the runtime.</summary>
		// Token: 0x0400101F RID: 4127
		Runtime,
		/// <summary>Specifies whether the method is implemented in managed or unmanaged code.</summary>
		// Token: 0x04001020 RID: 4128
		ManagedMask,
		/// <summary>Specifies that the method is implemented in unmanaged code.</summary>
		// Token: 0x04001021 RID: 4129
		Unmanaged = 4,
		/// <summary>Specifies that the method is implemented in managed code.</summary>
		// Token: 0x04001022 RID: 4130
		Managed = 0,
		/// <summary>Specifies that the method is not defined.</summary>
		// Token: 0x04001023 RID: 4131
		ForwardRef = 16,
		/// <summary>Specifies that the method signature is exported exactly as declared.</summary>
		// Token: 0x04001024 RID: 4132
		PreserveSig = 128,
		/// <summary>Specifies an internal call.</summary>
		// Token: 0x04001025 RID: 4133
		InternalCall = 4096,
		/// <summary>Specifies that the method is single-threaded through the body. Static methods (<see langword="Shared" /> in Visual Basic) lock on the type, whereas instance methods lock on the instance. You can also use the C# lock statement or the Visual Basic SyncLock statement for this purpose. </summary>
		// Token: 0x04001026 RID: 4134
		Synchronized = 32,
		/// <summary>Specifies that the method cannot be inlined.</summary>
		// Token: 0x04001027 RID: 4135
		NoInlining = 8,
		/// <summary>Specifies that the method should be inlined wherever possible.</summary>
		// Token: 0x04001028 RID: 4136
		AggressiveInlining = 256,
		/// <summary>Specifies that the method is not optimized by the just-in-time (JIT) compiler or by native code generation (see Ngen.exe) when debugging possible code generation problems.</summary>
		// Token: 0x04001029 RID: 4137
		NoOptimization = 64,
		/// <summary>Specifies a range check value.</summary>
		// Token: 0x0400102A RID: 4138
		MaxMethodImplVal = 65535
	}
}
