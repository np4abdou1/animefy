using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Ads
{
	// Token: 0x020002DC RID: 732
	[Register("com/unity3d/ads/UnityAdsBaseOptions", DoNotGenerateAcw = true)]
	public class UnityAdsBaseOptions : Java.Lang.Object
	{
		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x0006902C File Offset: 0x0006722C
		internal static IntPtr class_ref
		{
			get
			{
				return UnityAdsBaseOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x00069050 File Offset: 0x00067250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAdsBaseOptions._members;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x00069058 File Offset: 0x00067258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAdsBaseOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x0006907C File Offset: 0x0006727C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAdsBaseOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000021E8 File Offset: 0x000003E8
		protected UnityAdsBaseOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00069088 File Offset: 0x00067288
		[Register(".ctor", "()V", "")]
		public UnityAdsBaseOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAdsBaseOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAdsBaseOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x000690F6 File Offset: 0x000672F6
		private static Delegate GetGetDataHandler()
		{
			if (UnityAdsBaseOptions.cb_getData == null)
			{
				UnityAdsBaseOptions.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(UnityAdsBaseOptions.n_GetData));
			}
			return UnityAdsBaseOptions.cb_getData;
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0006911A File Offset: 0x0006731A
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<UnityAdsBaseOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x00069130 File Offset: 0x00067330
		public virtual JSONObject Data
		{
			[Register("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(UnityAdsBaseOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00069162 File Offset: 0x00067362
		private static Delegate GetSet_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (UnityAdsBaseOptions.cb_set_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				UnityAdsBaseOptions.cb_set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(UnityAdsBaseOptions.n_Set_Ljava_lang_String_Ljava_lang_String_));
			}
			return UnityAdsBaseOptions.cb_set_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00069188 File Offset: 0x00067388
		private static void n_Set_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			UnityAdsBaseOptions @object = Java.Lang.Object.GetObject<UnityAdsBaseOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_value, JniHandleOwnership.DoNotTransfer);
			@object.Set(@string, string2);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000691B4 File Offset: 0x000673B4
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void Set(string key, string value)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			IntPtr intPtr2 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				UnityAdsBaseOptions._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00069230 File Offset: 0x00067430
		private static Delegate GetSetObjectId_Ljava_lang_String_Handler()
		{
			if (UnityAdsBaseOptions.cb_setObjectId_Ljava_lang_String_ == null)
			{
				UnityAdsBaseOptions.cb_setObjectId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(UnityAdsBaseOptions.n_SetObjectId_Ljava_lang_String_));
			}
			return UnityAdsBaseOptions.cb_setObjectId_Ljava_lang_String_;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00069254 File Offset: 0x00067454
		private static void n_SetObjectId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_objectId)
		{
			UnityAdsBaseOptions @object = Java.Lang.Object.GetObject<UnityAdsBaseOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_objectId, JniHandleOwnership.DoNotTransfer);
			@object.SetObjectId(@string);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00069278 File Offset: 0x00067478
		[Register("setObjectId", "(Ljava/lang/String;)V", "GetSetObjectId_Ljava_lang_String_Handler")]
		public unsafe virtual void SetObjectId(string objectId)
		{
			IntPtr intPtr = JNIEnv.NewString(objectId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UnityAdsBaseOptions._members.InstanceMethods.InvokeVirtualVoidMethod("setObjectId.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400083F RID: 2111
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/ads/UnityAdsBaseOptions", typeof(UnityAdsBaseOptions));

		// Token: 0x04000840 RID: 2112
		private static Delegate cb_getData;

		// Token: 0x04000841 RID: 2113
		private static Delegate cb_set_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000842 RID: 2114
		private static Delegate cb_setObjectId_Ljava_lang_String_;
	}
}
