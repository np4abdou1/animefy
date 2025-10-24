using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Backend.Cct
{
	// Token: 0x02000027 RID: 39
	[Register("com/google/android/datatransport/backend/cct/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000678C File Offset: 0x0000498C
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000067B0 File Offset: 0x000049B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000067B8 File Offset: 0x000049B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000067DC File Offset: 0x000049DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000020B4 File Offset: 0x000002B4
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000067E8 File Offset: 0x000049E8
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

		// Token: 0x04000062 RID: 98
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000063 RID: 99
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000064 RID: 100
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.google.android.datatransport.backend.cct";

		// Token: 0x04000065 RID: 101
		[Register("VERSION_NAME")]
		public const string VersionName = "3.1.9";

		// Token: 0x04000066 RID: 102
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/backend/cct/BuildConfig", typeof(BuildConfig));
	}
}
