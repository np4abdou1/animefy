using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001EF RID: 495
	[Register("android/os/Looper", DoNotGenerateAcw = true)]
	public class Looper : Java.Lang.Object
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0002FC3B File Offset: 0x0002DE3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Looper._members;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0002FC44 File Offset: 0x0002DE44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Looper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0002FC68 File Offset: 0x0002DE68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Looper._members.ManagedPeerType;
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Looper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0002FC74 File Offset: 0x0002DE74
		public static Looper MainLooper
		{
			get
			{
				return Java.Lang.Object.GetObject<Looper>(Looper._members.StaticMethods.InvokeObjectMethod("getMainLooper.()Landroid/os/Looper;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0002FCA8 File Offset: 0x0002DEA8
		public static Looper MyLooper()
		{
			return Java.Lang.Object.GetObject<Looper>(Looper._members.StaticMethods.InvokeObjectMethod("myLooper.()Landroid/os/Looper;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000808 RID: 2056
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Looper", typeof(Looper));
	}
}
