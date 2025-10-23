using System;
using Android.Runtime;
using Java.Lang;

namespace Com.Wang.Avi
{
	// Token: 0x02000004 RID: 4
	[Register("com/wang/avi/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002B95 File Offset: 0x00000D95
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/BuildConfig", ref BuildConfig.java_class_handle);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002BA6 File Offset: 0x00000DA6
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig.class_ref;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002BAD File Offset: 0x00000DAD
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BuildConfig);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002BB9 File Offset: 0x00000DB9
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Register(".ctor", "()V", "")]
		public BuildConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(BuildConfig))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (BuildConfig.id_ctor == IntPtr.Zero)
			{
				BuildConfig.id_ctor = JNIEnv.GetMethodID(BuildConfig.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(BuildConfig.class_ref, BuildConfig.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, BuildConfig.class_ref, BuildConfig.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x04000016 RID: 22
		[Register("APPLICATION_ID")]
		public const string ApplicationId = "com.wang.avi";

		// Token: 0x04000017 RID: 23
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000018 RID: 24
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000019 RID: 25
		[Register("FLAVOR")]
		public const string Flavor = "";

		// Token: 0x0400001A RID: 26
		[Register("VERSION_CODE")]
		public const int VersionCode = 33;

		// Token: 0x0400001B RID: 27
		[Register("VERSION_NAME")]
		public const string VersionName = "2.1.3";

		// Token: 0x0400001C RID: 28
		internal static IntPtr java_class_handle;

		// Token: 0x0400001D RID: 29
		private static IntPtr id_ctor;
	}
}
