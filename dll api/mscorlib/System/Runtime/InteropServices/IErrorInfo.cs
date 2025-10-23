using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200041E RID: 1054
	[SuppressUnmanagedCodeSecurity]
	[Guid("1CF2B120-547D-101B-8E65-08002B2BD119")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	internal interface IErrorInfo
	{
		// Token: 0x06001F7F RID: 8063
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		int GetSource([MarshalAs(UnmanagedType.BStr)] out string pBstrSource);

		// Token: 0x06001F80 RID: 8064
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		int GetDescription([MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);

		// Token: 0x06001F81 RID: 8065
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		int GetHelpFile([MarshalAs(UnmanagedType.BStr)] out string pBstrHelpFile);

		// Token: 0x06001F82 RID: 8066
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		int GetHelpContext(out uint pdwHelpContext);
	}
}
