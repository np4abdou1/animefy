using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Wraps a managed object holding a handle to a resource that is passed to unmanaged code using platform invoke.</summary>
	// Token: 0x020003FA RID: 1018
	public readonly struct HandleRef
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.HandleRef" /> class with the object to wrap and a handle to the resource used by unmanaged code.</summary>
		/// <param name="wrapper">A managed object that should not be finalized until the platform invoke call returns. </param>
		/// <param name="handle">An <see cref="T:System.IntPtr" /> that indicates a handle to a resource. </param>
		// Token: 0x06001F20 RID: 7968 RVA: 0x000863BB File Offset: 0x000845BB
		public HandleRef(object wrapper, IntPtr handle)
		{
			this._wrapper = wrapper;
			this._handle = handle;
		}

		/// <summary>Gets the handle to a resource.</summary>
		/// <returns>The handle to a resource.</returns>
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x000863CB File Offset: 0x000845CB
		public IntPtr Handle
		{
			get
			{
				return this._handle;
			}
		}

		// Token: 0x04000E82 RID: 3714
		private readonly object _wrapper;

		// Token: 0x04000E83 RID: 3715
		private readonly IntPtr _handle;
	}
}
