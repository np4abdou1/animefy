using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Sdk
{
	// Token: 0x02000134 RID: 308
	[Register("com/applovin/impl/sdk/VariableServiceImpl", DoNotGenerateAcw = true)]
	public class VariableServiceImpl : Java.Lang.Object, IAppLovinVariableService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0002644C File Offset: 0x0002464C
		internal static IntPtr class_ref
		{
			get
			{
				return VariableServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00026470 File Offset: 0x00024670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VariableServiceImpl._members;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00026478 File Offset: 0x00024678
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VariableServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0002649C File Offset: 0x0002469C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VariableServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000021F0 File Offset: 0x000003F0
		protected VariableServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000264A8 File Offset: 0x000246A8
		private static Delegate GetGetBoolean_Ljava_lang_String_Handler()
		{
			if (VariableServiceImpl.cb_getBoolean_Ljava_lang_String_ == null)
			{
				VariableServiceImpl.cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(VariableServiceImpl.n_GetBoolean_Ljava_lang_String_));
			}
			return VariableServiceImpl.cb_getBoolean_Ljava_lang_String_;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000264CC File Offset: 0x000246CC
		private static bool n_GetBoolean_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000264F0 File Offset: 0x000246F0
		[Register("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public unsafe virtual bool GetBoolean(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = VariableServiceImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("getBoolean.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00026550 File Offset: 0x00024750
		private static Delegate GetGetBoolean_Ljava_lang_String_ZHandler()
		{
			if (VariableServiceImpl.cb_getBoolean_Ljava_lang_String_Z == null)
			{
				VariableServiceImpl.cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(VariableServiceImpl.n_GetBoolean_Ljava_lang_String_Z));
			}
			return VariableServiceImpl.cb_getBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00026574 File Offset: 0x00024774
		private static bool n_GetBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string, p1);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00026598 File Offset: 0x00024798
		[Register("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler")]
		public unsafe virtual bool GetBoolean(string p0, bool p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				result = VariableServiceImpl._members.InstanceMethods.InvokeVirtualBooleanMethod("getBoolean.(Ljava/lang/String;Z)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00026608 File Offset: 0x00024808
		private static Delegate GetGetString_Ljava_lang_String_Handler()
		{
			if (VariableServiceImpl.cb_getString_Ljava_lang_String_ == null)
			{
				VariableServiceImpl.cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(VariableServiceImpl.n_GetString_Ljava_lang_String_));
			}
			return VariableServiceImpl.cb_getString_Ljava_lang_String_;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0002662C File Offset: 0x0002482C
		private static IntPtr n_GetString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string));
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00026654 File Offset: 0x00024854
		[Register("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public unsafe virtual string GetString(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(VariableServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getString.(Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @string;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000266C0 File Offset: 0x000248C0
		private static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (VariableServiceImpl.cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				VariableServiceImpl.cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(VariableServiceImpl.n_GetString_Ljava_lang_String_Ljava_lang_String_));
			}
			return VariableServiceImpl.cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000266E4 File Offset: 0x000248E4
		private static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string, string2));
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00026718 File Offset: 0x00024918
		[Register("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual string GetString(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(VariableServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000267A8 File Offset: 0x000249A8
		private static Delegate GetLoadVariablesHandler()
		{
			if (VariableServiceImpl.cb_loadVariables == null)
			{
				VariableServiceImpl.cb_loadVariables = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(VariableServiceImpl.n_LoadVariables));
			}
			return VariableServiceImpl.cb_loadVariables;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x000267CC File Offset: 0x000249CC
		private static void n_LoadVariables(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadVariables();
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x000267DB File Offset: 0x000249DB
		[Register("loadVariables", "()V", "GetLoadVariablesHandler")]
		public virtual void LoadVariables()
		{
			VariableServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("loadVariables.()V", this, null);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x000267F4 File Offset: 0x000249F4
		private static Delegate GetSetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_Handler()
		{
			if (VariableServiceImpl.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ == null)
			{
				VariableServiceImpl.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VariableServiceImpl.n_SetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_));
			}
			return VariableServiceImpl.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00026818 File Offset: 0x00024A18
		private static void n_SetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinVariableServiceOnVariablesUpdateListener object2 = Java.Lang.Object.GetObject<IAppLovinVariableServiceOnVariablesUpdateListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetOnVariablesUpdateListener(object2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0002683C File Offset: 0x00024A3C
		[Register("setOnVariablesUpdateListener", "(Lcom/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener;)V", "GetSetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_Handler")]
		public unsafe virtual void SetOnVariablesUpdateListener(IAppLovinVariableServiceOnVariablesUpdateListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				VariableServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setOnVariablesUpdateListener.(Lcom/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000268A4 File Offset: 0x00024AA4
		private static Delegate GetUpdateVariables_Lorg_json_JSONObject_Handler()
		{
			if (VariableServiceImpl.cb_updateVariables_Lorg_json_JSONObject_ == null)
			{
				VariableServiceImpl.cb_updateVariables_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(VariableServiceImpl.n_UpdateVariables_Lorg_json_JSONObject_));
			}
			return VariableServiceImpl.cb_updateVariables_Lorg_json_JSONObject_;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000268C8 File Offset: 0x00024AC8
		private static void n_UpdateVariables_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			VariableServiceImpl @object = Java.Lang.Object.GetObject<VariableServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.UpdateVariables(object2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000268EC File Offset: 0x00024AEC
		[Register("updateVariables", "(Lorg/json/JSONObject;)V", "GetUpdateVariables_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void UpdateVariables(JSONObject p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				VariableServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("updateVariables.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000E39 RID: 3641 RVA: 0x00026950 File Offset: 0x00024B50
		// (remove) Token: 0x06000E3A RID: 3642 RVA: 0x0002699C File Offset: 0x00024B9C
		public event EventHandler<AppLovinVariableServiceOnVariablesUpdateEventArgs> VariablesUpdate
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinVariableServiceOnVariablesUpdateListener, IAppLovinVariableServiceOnVariablesUpdateListenerImplementor>(ref this.weak_implementor_SetOnVariablesUpdateListener, new Func<IAppLovinVariableServiceOnVariablesUpdateListenerImplementor>(this.__CreateIAppLovinVariableServiceOnVariablesUpdateListenerImplementor), new Action<IAppLovinVariableServiceOnVariablesUpdateListener>(this.SetOnVariablesUpdateListener), delegate(IAppLovinVariableServiceOnVariablesUpdateListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinVariableServiceOnVariablesUpdateEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinVariableServiceOnVariablesUpdateListener, IAppLovinVariableServiceOnVariablesUpdateListenerImplementor>(ref this.weak_implementor_SetOnVariablesUpdateListener, new Func<IAppLovinVariableServiceOnVariablesUpdateListenerImplementor, bool>(IAppLovinVariableServiceOnVariablesUpdateListenerImplementor.__IsEmpty), delegate(IAppLovinVariableServiceOnVariablesUpdateListener __v)
				{
					this.SetOnVariablesUpdateListener(null);
				}, delegate(IAppLovinVariableServiceOnVariablesUpdateListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinVariableServiceOnVariablesUpdateEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000269EC File Offset: 0x00024BEC
		private IAppLovinVariableServiceOnVariablesUpdateListenerImplementor __CreateIAppLovinVariableServiceOnVariablesUpdateListenerImplementor()
		{
			return new IAppLovinVariableServiceOnVariablesUpdateListenerImplementor(this);
		}

		// Token: 0x040004DD RID: 1245
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/sdk/VariableServiceImpl", typeof(VariableServiceImpl));

		// Token: 0x040004DE RID: 1246
		private static Delegate cb_getBoolean_Ljava_lang_String_;

		// Token: 0x040004DF RID: 1247
		private static Delegate cb_getBoolean_Ljava_lang_String_Z;

		// Token: 0x040004E0 RID: 1248
		private static Delegate cb_getString_Ljava_lang_String_;

		// Token: 0x040004E1 RID: 1249
		private static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040004E2 RID: 1250
		private static Delegate cb_loadVariables;

		// Token: 0x040004E3 RID: 1251
		private static Delegate cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_;

		// Token: 0x040004E4 RID: 1252
		private static Delegate cb_updateVariables_Lorg_json_JSONObject_;

		// Token: 0x040004E5 RID: 1253
		private WeakReference weak_implementor_SetOnVariablesUpdateListener;
	}
}
