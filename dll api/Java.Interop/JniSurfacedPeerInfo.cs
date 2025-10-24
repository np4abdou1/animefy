using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x0200007E RID: 126
	public class JniSurfacedPeerInfo
	{
		// Token: 0x1700007E RID: 126
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x0000FA90 File Offset: 0x0000DC90
		private int JniIdentityHashCode
		{
			[CompilerGenerated]
			set
			{
				this.<JniIdentityHashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000FA99 File Offset: 0x0000DC99
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000FAA1 File Offset: 0x0000DCA1
		public WeakReference<IJavaPeerable> SurfacedPeer { get; private set; }

		// Token: 0x0600042A RID: 1066 RVA: 0x0000FAAA File Offset: 0x0000DCAA
		public JniSurfacedPeerInfo(int jniIdentityHashCode, WeakReference<IJavaPeerable> surfacedPeer)
		{
			this.JniIdentityHashCode = jniIdentityHashCode;
			this.SurfacedPeer = surfacedPeer;
		}
	}
}
