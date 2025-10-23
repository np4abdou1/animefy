using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200001A RID: 26
	[Register("com/google/android/datatransport/runtime/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002668 File Offset: 0x00000868
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000268C File Offset: 0x0000088C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BuildConfig._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002694 File Offset: 0x00000894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000026B8 File Offset: 0x000008B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000026C4 File Offset: 0x000008C4
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000026D0 File Offset: 0x000008D0
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

		// Token: 0x0400000D RID: 13
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x0400000E RID: 14
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x0400000F RID: 15
		[Register("LIBRARY_PACKAGE_NAME")]
		public const string LibraryPackageName = "com.google.android.datatransport.runtime";

		// Token: 0x04000010 RID: 16
		[Register("VERSION_NAME")]
		public const string VersionName = "3.1.9";

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/BuildConfig", typeof(BuildConfig));
	}
}
