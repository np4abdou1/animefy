using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200002C RID: 44
	public class SafeGCHandle : SafeHandle
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x000033C4 File Offset: 0x000015C4
		public SafeGCHandle(object v, GCHandleType typ) : base(IntPtr.Zero, true)
		{
			if (v != null)
			{
				GCHandle value = GCHandle.Alloc(v, typ);
				base.SetHandle(GCHandle.ToIntPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002F66 File Offset: 0x00001166
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000033F4 File Offset: 0x000015F4
		protected override bool ReleaseHandle()
		{
			GCHandle.FromIntPtr(this.handle).Free();
			return true;
		}
	}
}
