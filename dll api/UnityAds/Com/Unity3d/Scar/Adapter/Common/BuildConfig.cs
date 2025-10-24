using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x02000295 RID: 661
	[Register("com/unity3d/scar/adapter/common/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x00061278 File Offset: 0x0005F478
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x0006129C File Offset: 0x0005F49C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000612A4 File Offset: 0x0005F4A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x060025CB RID: 9675 RVA: 0x000612C8 File Offset: 0x0005F4C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000612D4 File Offset: 0x0005F4D4
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

		// Token: 0x04000756 RID: 1878
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000757 RID: 1879
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000758 RID: 1880
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.scar.adapter.common";

		// Token: 0x04000759 RID: 1881
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/BuildConfig", typeof(BuildConfig));
	}
}
