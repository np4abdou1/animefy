using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Activity.Result.Contract;
using AndroidX.Core.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000021 RID: 33
	[Register("androidx/activity/result/ActivityResultLauncher", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"I"
	})]
	public abstract class ActivityResultLauncher : Java.Lang.Object
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004438 File Offset: 0x00002638
		internal static IntPtr class_ref
		{
			get
			{
				return ActivityResultLauncher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000445C File Offset: 0x0000265C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultLauncher._members;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004464 File Offset: 0x00002664
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActivityResultLauncher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00004488 File Offset: 0x00002688
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultLauncher._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003484 File Offset: 0x00001684
		protected ActivityResultLauncher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004494 File Offset: 0x00002694
		[Register(".ctor", "()V", "")]
		public ActivityResultLauncher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActivityResultLauncher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActivityResultLauncher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004502 File Offset: 0x00002702
		private static Delegate GetGetContractHandler()
		{
			if (ActivityResultLauncher.cb_getContract == null)
			{
				ActivityResultLauncher.cb_getContract = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActivityResultLauncher.n_GetContract));
			}
			return ActivityResultLauncher.cb_getContract;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004526 File Offset: 0x00002726
		private static IntPtr n_GetContract(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActivityResultLauncher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RawContract);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F6 RID: 246
		protected abstract ActivityResultContract RawContract { [Register("getContract", "()Landroidx/activity/result/contract/ActivityResultContract;", "GetGetContractHandler")] get; }

		// Token: 0x060000F7 RID: 247 RVA: 0x0000453A File Offset: 0x0000273A
		private static Delegate GetLaunch_Ljava_lang_Object_Handler()
		{
			if (ActivityResultLauncher.cb_launch_Ljava_lang_Object_ == null)
			{
				ActivityResultLauncher.cb_launch_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActivityResultLauncher.n_Launch_Ljava_lang_Object_));
			}
			return ActivityResultLauncher.cb_launch_Ljava_lang_Object_;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00004560 File Offset: 0x00002760
		private static void n_Launch_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			ActivityResultLauncher @object = Java.Lang.Object.GetObject<ActivityResultLauncher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_input, JniHandleOwnership.DoNotTransfer);
			@object.Launch(object2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00004584 File Offset: 0x00002784
		[Register("launch", "(Ljava/lang/Object;)V", "GetLaunch_Ljava_lang_Object_Handler")]
		public unsafe virtual void Launch(Java.Lang.Object input)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(input);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ActivityResultLauncher._members.InstanceMethods.InvokeVirtualVoidMethod("launch.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(input);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000045E8 File Offset: 0x000027E8
		private static Delegate GetLaunch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler()
		{
			if (ActivityResultLauncher.cb_launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_ == null)
			{
				ActivityResultLauncher.cb_launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActivityResultLauncher.n_Launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_));
			}
			return ActivityResultLauncher.cb_launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000460C File Offset: 0x0000280C
		private static void n_Launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			ActivityResultLauncher @object = Java.Lang.Object.GetObject<ActivityResultLauncher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			ActivityOptionsCompat object3 = Java.Lang.Object.GetObject<ActivityOptionsCompat>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Launch(object2, object3);
		}

		// Token: 0x060000FC RID: 252
		[Register("launch", "(Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", "GetLaunch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler")]
		public abstract void Launch(Java.Lang.Object p0, ActivityOptionsCompat p1);

		// Token: 0x060000FD RID: 253 RVA: 0x00004638 File Offset: 0x00002838
		private static Delegate GetUnregisterHandler()
		{
			if (ActivityResultLauncher.cb_unregister == null)
			{
				ActivityResultLauncher.cb_unregister = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActivityResultLauncher.n_Unregister));
			}
			return ActivityResultLauncher.cb_unregister;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000465C File Offset: 0x0000285C
		private static void n_Unregister(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActivityResultLauncher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Unregister();
		}

		// Token: 0x060000FF RID: 255
		[Register("unregister", "()V", "GetUnregisterHandler")]
		public abstract void Unregister();

		// Token: 0x04000037 RID: 55
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultLauncher", typeof(ActivityResultLauncher));

		// Token: 0x04000038 RID: 56
		private static Delegate cb_getContract;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_launch_Ljava_lang_Object_;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_launch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_;

		// Token: 0x0400003B RID: 59
		private static Delegate cb_unregister;
	}
}
