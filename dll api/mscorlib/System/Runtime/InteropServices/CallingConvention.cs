using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Specifies the calling convention required to call methods implemented in unmanaged code.</summary>
	// Token: 0x02000419 RID: 1049
	[ComVisible(true)]
	[Serializable]
	public enum CallingConvention
	{
		/// <summary>This member is not actually a calling convention, but instead uses the default platform calling convention. For example, on Windows the default is <see cref="F:System.Runtime.InteropServices.CallingConvention.StdCall" /> and on Windows CE.NET it is <see cref="F:System.Runtime.InteropServices.CallingConvention.Cdecl" />.</summary>
		// Token: 0x04000F06 RID: 3846
		Winapi = 1,
		/// <summary>The caller cleans the stack. This enables calling functions with <see langword="varargs" />, which makes it appropriate to use for methods that accept a variable number of parameters, such as <see langword="Printf" />.</summary>
		// Token: 0x04000F07 RID: 3847
		Cdecl,
		/// <summary>The callee cleans the stack. This is the default convention for calling unmanaged functions with platform invoke.</summary>
		// Token: 0x04000F08 RID: 3848
		StdCall,
		/// <summary>The first parameter is the <see langword="this" /> pointer and is stored in register ECX. Other parameters are pushed on the stack. This calling convention is used to call methods on classes exported from an unmanaged DLL.</summary>
		// Token: 0x04000F09 RID: 3849
		ThisCall,
		/// <summary>This calling convention is not supported.</summary>
		// Token: 0x04000F0A RID: 3850
		FastCall
	}
}
