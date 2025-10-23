using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100
{
	// Token: 0x02000237 RID: 567
	[Register("com/unity3d/scar/adapter/v2100/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000503A0 File Offset: 0x0004E5A0
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000503C4 File Offset: 0x0004E5C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000503CC File Offset: 0x0004E5CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000503F0 File Offset: 0x0004E5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000503FC File Offset: 0x0004E5FC
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

		// Token: 0x040006C0 RID: 1728
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x040006C1 RID: 1729
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x040006C2 RID: 1730
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.scar.adapter.v2100";

		// Token: 0x040006C3 RID: 1731
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/BuildConfig", typeof(BuildConfig));
	}
}
