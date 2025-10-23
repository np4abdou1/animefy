using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000ED RID: 237
	[Register("com/google/android/datatransport/runtime/dagger/internal/MapProviderFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public sealed class MapProviderFactory : Java.Lang.Object
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00017568 File Offset: 0x00015768
		internal static IntPtr class_ref
		{
			get
			{
				return MapProviderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0001758C File Offset: 0x0001578C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MapProviderFactory._members;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00017594 File Offset: 0x00015794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MapProviderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x000175B8 File Offset: 0x000157B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MapProviderFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MapProviderFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000262 RID: 610
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/MapProviderFactory", typeof(MapProviderFactory));
	}
}
