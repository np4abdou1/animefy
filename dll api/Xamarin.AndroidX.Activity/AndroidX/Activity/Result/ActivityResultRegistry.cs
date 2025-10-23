using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.Activity.Result.Contract;
using AndroidX.Core.App;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000023 RID: 35
	[Register("androidx/activity/result/ActivityResultRegistry", DoNotGenerateAcw = true)]
	public abstract class ActivityResultRegistry : Java.Lang.Object
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004798 File Offset: 0x00002998
		internal static IntPtr class_ref
		{
			get
			{
				return ActivityResultRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000047BC File Offset: 0x000029BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultRegistry._members;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000047C4 File Offset: 0x000029C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActivityResultRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000047E8 File Offset: 0x000029E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003484 File Offset: 0x00001684
		protected ActivityResultRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000047F4 File Offset: 0x000029F4
		[Register(".ctor", "()V", "")]
		public ActivityResultRegistry() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActivityResultRegistry._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActivityResultRegistry._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004864 File Offset: 0x00002A64
		[Register("dispatchResult", "(IILandroid/content/Intent;)Z", "")]
		public unsafe bool DispatchResult(int requestCode, int resultCode, Intent data)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(resultCode);
				ptr[2] = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				result = ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualBooleanMethod("dispatchResult.(IILandroid/content/Intent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
			return result;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000048F4 File Offset: 0x00002AF4
		[Register("dispatchResult", "(ILjava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"O"
		})]
		public unsafe bool DispatchResult(int requestCode, Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			bool result2;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(intPtr);
				result2 = ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualBooleanMethod("dispatchResult.(ILjava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
			return result2;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000496C File Offset: 0x00002B6C
		private static Delegate GetOnLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler()
		{
			if (ActivityResultRegistry.cb_onLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_ == null)
			{
				ActivityResultRegistry.cb_onLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILLL_V(ActivityResultRegistry.n_OnLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_));
			}
			return ActivityResultRegistry.cb_onLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004990 File Offset: 0x00002B90
		private static void n_OnLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			ActivityResultRegistry @object = Java.Lang.Object.GetObject<ActivityResultRegistry>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActivityResultContract object2 = Java.Lang.Object.GetObject<ActivityResultContract>(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			ActivityOptionsCompat object4 = Java.Lang.Object.GetObject<ActivityOptionsCompat>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.OnLaunch(p0, object2, object3, object4);
		}

		// Token: 0x06000112 RID: 274
		[Register("onLaunch", "(ILandroidx/activity/result/contract/ActivityResultContract;Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", "GetOnLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public abstract void OnLaunch(int p0, ActivityResultContract p1, Java.Lang.Object p2, ActivityOptionsCompat p3);

		// Token: 0x06000113 RID: 275 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Register("onRestoreInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnRestoreInstanceState(Bundle savedInstanceState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedInstanceState == null) ? IntPtr.Zero : savedInstanceState.Handle);
				ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedInstanceState);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004A2C File Offset: 0x00002C2C
		[Register("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnSaveInstanceState(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualVoidMethod("onSaveInstanceState.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004A90 File Offset: 0x00002C90
		[Register("register", "(Ljava/lang/String;Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher Register(string key, ActivityResultContract contract, IActivityResultCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualObjectMethod("register.(Ljava/lang/String;Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(contract);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004B54 File Offset: 0x00002D54
		[Register("register", "(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe ActivityResultLauncher Register(string key, ILifecycleOwner lifecycleOwner, ActivityResultContract contract, IActivityResultCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			ActivityResultLauncher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((lifecycleOwner == null) ? IntPtr.Zero : ((Java.Lang.Object)lifecycleOwner).Handle);
				ptr[2] = new JniArgumentValue((contract == null) ? IntPtr.Zero : contract.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActivityResultLauncher>(ActivityResultRegistry._members.InstanceMethods.InvokeNonvirtualObjectMethod("register.(Ljava/lang/String;Landroidx/lifecycle/LifecycleOwner;Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(lifecycleOwner);
				GC.KeepAlive(contract);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x0400003D RID: 61
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultRegistry", typeof(ActivityResultRegistry));

		// Token: 0x0400003E RID: 62
		private static Delegate cb_onLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_;
	}
}
