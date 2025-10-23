﻿using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Represents the types of handles the <see cref="T:System.Runtime.InteropServices.GCHandle" /> class can allocate.</summary>
	// Token: 0x020003FD RID: 1021
	public enum GCHandleType
	{
		/// <summary>This handle type is used to track an object, but allow it to be collected. When an object is collected, the contents of the <see cref="T:System.Runtime.InteropServices.GCHandle" /> are zeroed. <see langword="Weak" /> references are zeroed before the finalizer runs, so even if the finalizer resurrects the object, the <see langword="Weak" /> reference is still zeroed.</summary>
		// Token: 0x04000E85 RID: 3717
		Weak,
		/// <summary>This handle type is similar to <see cref="F:System.Runtime.InteropServices.GCHandleType.Weak" />, but the handle is not zeroed if the object is resurrected during finalization.</summary>
		// Token: 0x04000E86 RID: 3718
		WeakTrackResurrection,
		/// <summary>This handle type represents an opaque handle, meaning you cannot resolve the address of the pinned object through the handle. You can use this type to track an object and prevent its collection by the garbage collector. This enumeration member is useful when an unmanaged client holds the only reference, which is undetectable from the garbage collector, to a managed object.</summary>
		// Token: 0x04000E87 RID: 3719
		Normal,
		/// <summary>This handle type is similar to <see cref="F:System.Runtime.InteropServices.GCHandleType.Normal" />, but allows the address of the pinned object to be taken. This prevents the garbage collector from moving the object and hence undermines the efficiency of the garbage collector. Use the <see cref="M:System.Runtime.InteropServices.GCHandle.Free" /> method to free the allocated handle as soon as possible.</summary>
		// Token: 0x04000E88 RID: 3720
		Pinned
	}
}
