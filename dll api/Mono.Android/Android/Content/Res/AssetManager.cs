using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.Res
{
	// Token: 0x020002A7 RID: 679
	[Register("android/content/res/AssetManager", DoNotGenerateAcw = true)]
	public sealed class AssetManager : Java.Lang.Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00043CD3 File Offset: 0x00041ED3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetManager._members;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00043CDC File Offset: 0x00041EDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AssetManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00043D00 File Offset: 0x00041F00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x000021E0 File Offset: 0x000003E0
		internal AssetManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00043D0C File Offset: 0x00041F0C
		public void Close()
		{
			AssetManager._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x04000B20 RID: 2848
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/AssetManager", typeof(AssetManager));
	}
}
