using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200002E RID: 46
	internal class CompareBuf : EqualityComparer<byte[]>
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0000342C File Offset: 0x0000162C
		public CompareBuf(Func<IntPtr, IntPtr, int, bool> f)
		{
			this._f = f;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000343C File Offset: 0x0000163C
		public override bool Equals(byte[] p1, byte[] p2)
		{
			if (p1.Length != p2.Length)
			{
				return false;
			}
			GCHandle gchandle = GCHandle.Alloc(p1, GCHandleType.Pinned);
			GCHandle gchandle2 = GCHandle.Alloc(p2, GCHandleType.Pinned);
			bool result = this._f(gchandle.AddrOfPinnedObject(), gchandle2.AddrOfPinnedObject(), p1.Length);
			gchandle.Free();
			gchandle2.Free();
			return result;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000348D File Offset: 0x0000168D
		public override int GetHashCode(byte[] p)
		{
			return p.Length;
		}

		// Token: 0x040000E5 RID: 229
		private Func<IntPtr, IntPtr, int, bool> _f;
	}
}
