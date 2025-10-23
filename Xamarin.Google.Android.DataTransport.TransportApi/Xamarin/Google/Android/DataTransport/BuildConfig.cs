using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000009 RID: 9
	[Register("com/google/android/datatransport/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002058 File Offset: 0x00000258
		internal static IntPtr class_ref
		{
			get
			{
				return BuildConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000207C File Offset: 0x0000027C
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
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002084 File Offset: 0x00000284
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
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020A8 File Offset: 0x000002A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BuildConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020B4 File Offset: 0x000002B4
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020C0 File Offset: 0x000002C0
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

		// Token: 0x04000001 RID: 1
		[Register("APPLICATION_ID")]
		public const string ApplicationId = "com.google.android.datatransport";

		// Token: 0x04000002 RID: 2
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000003 RID: 3
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000004 RID: 4
		[Register("FLAVOR")]
		public const string Flavor = "";

		// Token: 0x04000005 RID: 5
		[Register("VERSION_CODE")]
		public const int VersionCode = -1;

		// Token: 0x04000006 RID: 6
		[Register("VERSION_NAME")]
		public const string VersionName = "";

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/BuildConfig", typeof(BuildConfig));
	}
}
