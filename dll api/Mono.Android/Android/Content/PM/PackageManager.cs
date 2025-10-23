using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.PM
{
	// Token: 0x020002AE RID: 686
	[Register("android/content/pm/PackageManager", DoNotGenerateAcw = true)]
	public abstract class PackageManager : Java.Lang.Object
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00044667 File Offset: 0x00042867
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PackageManager._members;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00044670 File Offset: 0x00042870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PackageManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00044694 File Offset: 0x00042894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PackageManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PackageManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000446A0 File Offset: 0x000428A0
		private static Delegate GetGetLaunchIntentForPackage_Ljava_lang_String_Handler()
		{
			if (PackageManager.cb_getLaunchIntentForPackage_Ljava_lang_String_ == null)
			{
				PackageManager.cb_getLaunchIntentForPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PackageManager.n_GetLaunchIntentForPackage_Ljava_lang_String_));
			}
			return PackageManager.cb_getLaunchIntentForPackage_Ljava_lang_String_;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000446C4 File Offset: 0x000428C4
		private static IntPtr n_GetLaunchIntentForPackage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_packageName)
		{
			PackageManager @object = Java.Lang.Object.GetObject<PackageManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_packageName, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetLaunchIntentForPackage(@string));
		}

		// Token: 0x06001A67 RID: 6759
		public abstract Intent GetLaunchIntentForPackage(string packageName);

		// Token: 0x04000B35 RID: 2869
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/pm/PackageManager", typeof(PackageManager));

		// Token: 0x04000B36 RID: 2870
		private static Delegate cb_getLaunchIntentForPackage_Ljava_lang_String_;
	}
}
