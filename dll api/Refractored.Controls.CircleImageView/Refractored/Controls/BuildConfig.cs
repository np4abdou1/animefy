using System;
using Android.Runtime;
using Java.Lang;

namespace Refractored.Controls
{
	// Token: 0x02000004 RID: 4
	[Register("de/hdodenhof/circleimageview/BuildConfig", DoNotGenerateAcw = true)]
	public sealed class BuildConfig : Java.Lang.Object
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000211D File Offset: 0x0000031D
		internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002128 File Offset: 0x00000328
		[Register(".ctor", "()V", "")]
		public BuildConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				if (base.GetType() != typeof(BuildConfig))
				{
					base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", new JValue[0]), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, "()V", new JValue[0]);
				}
				else
				{
					if (BuildConfig.id_ctor == IntPtr.Zero)
					{
						BuildConfig.id_ctor = JNIEnv.GetMethodID(BuildConfig.class_ref, "<init>", "()V");
					}
					base.SetHandle(JNIEnv.StartCreateInstance(BuildConfig.class_ref, BuildConfig.id_ctor, new JValue[0]), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, BuildConfig.class_ref, BuildConfig.id_ctor, new JValue[0]);
				}
			}
			finally
			{
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002224 File Offset: 0x00000424
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("de/hdodenhof/circleimageview/BuildConfig", ref BuildConfig.java_class_handle);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002235 File Offset: 0x00000435
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BuildConfig.class_ref;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000223C File Offset: 0x0000043C
		protected override Type ThresholdType
		{
			get
			{
				return typeof(BuildConfig);
			}
		}

		// Token: 0x04000003 RID: 3
		[Register("APPLICATION_ID")]
		public const string ApplicationId = "de.hdodenhof.circleimageview";

		// Token: 0x04000004 RID: 4
		[Register("BUILD_TYPE")]
		public const string BuildType = "release";

		// Token: 0x04000005 RID: 5
		[Register("DEBUG")]
		public const bool Debug = false;

		// Token: 0x04000006 RID: 6
		[Register("FLAVOR")]
		public const string Flavor = "";

		// Token: 0x04000007 RID: 7
		[Register("VERSION_CODE")]
		public const int VersionCode = -1;

		// Token: 0x04000008 RID: 8
		[Register("VERSION_NAME")]
		public const string VersionName = "";

		// Token: 0x04000009 RID: 9
		internal static IntPtr java_class_handle;

		// Token: 0x0400000A RID: 10
		private static IntPtr id_ctor;
	}
}
