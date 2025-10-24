using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000095 RID: 149
	internal static class IOSelector
	{
		// Token: 0x060003C4 RID: 964
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Add(IntPtr handle, IOSelectorJob job);
	}
}
