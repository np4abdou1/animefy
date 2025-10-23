using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950
{
	// Token: 0x02000264 RID: 612
	[Register("com/unity3d/scar/adapter/v1950/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x000597AC File Offset: 0x000579AC
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000597D0 File Offset: 0x000579D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x000597D8 File Offset: 0x000579D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000597FC File Offset: 0x000579FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00059808 File Offset: 0x00057A08
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

		// Token: 0x04000705 RID: 1797
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000706 RID: 1798
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000707 RID: 1799
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.scar.adapter.v1950";

		// Token: 0x04000708 RID: 1800
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/BuildConfig", typeof(BuildConfig));
	}
}
