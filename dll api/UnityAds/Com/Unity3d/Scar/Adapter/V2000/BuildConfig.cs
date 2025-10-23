using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000
{
	// Token: 0x0200024E RID: 590
	[Register("com/unity3d/scar/adapter/v2000/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00055670 File Offset: 0x00053870
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00055694 File Offset: 0x00053894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x0005569C File Offset: 0x0005389C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000556C0 File Offset: 0x000538C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000556CC File Offset: 0x000538CC
		[Register(".ctor", "()V", "")]
		public BuildConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BuildConfig._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BuildConfig._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x040006E3 RID: 1763
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x040006E4 RID: 1764
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x040006E5 RID: 1765
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.scar.adapter.v2000";

		// Token: 0x040006E6 RID: 1766
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/BuildConfig", typeof(BuildConfig));
	}
}
