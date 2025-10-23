using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop
{
	// Token: 0x0200043B RID: 1083
	public static class Runtime
	{
		// Token: 0x06002F24 RID: 12068 RVA: 0x0008357C File Offset: 0x0008177C
		public static List<WeakReference> GetSurfacedObjects()
		{
			List<JniSurfacedPeerInfo> surfacedPeers = JNIEnvInit.AndroidValueManager.GetSurfacedPeers();
			List<WeakReference> list = new List<WeakReference>(surfacedPeers.Count);
			using (List<JniSurfacedPeerInfo>.Enumerator enumerator = surfacedPeers.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IJavaPeerable target;
					if (enumerator.Current.SurfacedPeer.TryGetTarget(out target))
					{
						list.Add(new WeakReference(target, true));
					}
				}
			}
			return list;
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x000835F4 File Offset: 0x000817F4
		public static int MaxGlobalReferenceCount
		{
			get
			{
				return RuntimeNativeMethods._monodroid_max_gref_get();
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000451FB File Offset: 0x000433FB
		public static int GlobalReferenceCount
		{
			get
			{
				return RuntimeNativeMethods._monodroid_gref_get();
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000835FB File Offset: 0x000817FB
		public static int LocalReferenceCount
		{
			get
			{
				return JniEnvironment.LocalReferenceCount;
			}
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00083602 File Offset: 0x00081802
		public static bool IsGCUserPeer(IJavaObject value)
		{
			return value != null && Runtime.IsGCUserPeer(value.Handle);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x00083614 File Offset: 0x00081814
		public static bool IsGCUserPeer(IntPtr value)
		{
			return JNIEnv.IsGCUserPeer(value);
		}
	}
}
