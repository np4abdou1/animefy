using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002C2 RID: 706
	[Register("com/unity3d/ads/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00066F20 File Offset: 0x00065120
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x00066F44 File Offset: 0x00065144
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00066F4C File Offset: 0x0006514C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00066F70 File Offset: 0x00065170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00066F7C File Offset: 0x0006517C
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

		// Token: 0x040007FE RID: 2046
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x040007FF RID: 2047
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000800 RID: 2048
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.ads";

		// Token: 0x04000801 RID: 2049
		[Register("VERSION_CODE")]
		public const int VersionCode = 4500;

		// Token: 0x04000802 RID: 2050
		[Register("VERSION_NAME")]
		public const string VersionName = "4.5.0";

		// Token: 0x04000803 RID: 2051
		[Register("WEBVIEW_BRANCH")]
		public const string WebviewBranch = "4.5.0";

		// Token: 0x04000804 RID: 2052
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/BuildConfig", typeof(BuildConfig));
	}
}
