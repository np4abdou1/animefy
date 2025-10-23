using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920
{
	// Token: 0x0200027D RID: 637
	[Register("com/unity3d/scar/adapter/v1920/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0005D9B4 File Offset: 0x0005BBB4
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0005D9E0 File Offset: 0x0005BBE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x0005DA04 File Offset: 0x0005BC04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0005DA10 File Offset: 0x0005BC10
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

		// Token: 0x0400072E RID: 1838
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x0400072F RID: 1839
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000730 RID: 1840
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.unity3d.scar.adapter.v1920";

		// Token: 0x04000731 RID: 1841
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/BuildConfig", typeof(BuildConfig));
	}
}
