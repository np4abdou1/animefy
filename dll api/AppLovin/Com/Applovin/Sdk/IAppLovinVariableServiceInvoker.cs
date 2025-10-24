using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009F RID: 159
	[Register("com/applovin/sdk/AppLovinVariableService", DoNotGenerateAcw = true)]
	internal class IAppLovinVariableServiceInvoker : Java.Lang.Object, IAppLovinVariableService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0000DB98 File Offset: 0x0000BD98
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinVariableServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinVariableServiceInvoker._members;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000DBCB File Offset: 0x0000BDCB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinVariableServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000DBD7 File Offset: 0x0000BDD7
		public static IAppLovinVariableService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinVariableService>(handle, transfer);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinVariableServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinVariableService'.");
			}
			return handle;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000DC0B File Offset: 0x0000BE0B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000DC3C File Offset: 0x0000BE3C
		public IAppLovinVariableServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinVariableServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000DC74 File Offset: 0x0000BE74
		private static Delegate GetGetBoolean_Ljava_lang_String_Handler()
		{
			if (IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_ == null)
			{
				IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAppLovinVariableServiceInvoker.n_GetBoolean_Ljava_lang_String_));
			}
			return IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000DC98 File Offset: 0x0000BE98
		private static bool n_GetBoolean_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinVariableService @object = Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0000DCBC File Offset: 0x0000BEBC
		public unsafe bool GetBoolean(string p0)
		{
			if (this.id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_getBoolean_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000DD2D File Offset: 0x0000BF2D
		private static Delegate GetGetBoolean_Ljava_lang_String_ZHandler()
		{
			if (IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_Z == null)
			{
				IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_Z(IAppLovinVariableServiceInvoker.n_GetBoolean_Ljava_lang_String_Z));
			}
			return IAppLovinVariableServiceInvoker.cb_getBoolean_Ljava_lang_String_Z;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000DD54 File Offset: 0x0000BF54
		private static bool n_GetBoolean_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			IAppLovinVariableService @object = Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetBoolean(@string, p1);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public unsafe bool GetBoolean(string p0, bool p1)
		{
			if (this.id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
			{
				this.id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID(this.class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_getBoolean_Ljava_lang_String_Z, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		private static Delegate GetGetString_Ljava_lang_String_Handler()
		{
			if (IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_ == null)
			{
				IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAppLovinVariableServiceInvoker.n_GetString_Ljava_lang_String_));
			}
			return IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000DE20 File Offset: 0x0000C020
		private static IntPtr n_GetString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinVariableService @object = Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string));
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000DE48 File Offset: 0x0000C048
		public unsafe string GetString(string p0)
		{
			if (this.id_getString_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getString_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @string;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000DEBF File Offset: 0x0000C0BF
		private static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IAppLovinVariableServiceInvoker.n_GetString_Ljava_lang_String_Ljava_lang_String_));
			}
			return IAppLovinVariableServiceInvoker.cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000DEE4 File Offset: 0x0000C0E4
		private static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinVariableService @object = Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetString(@string, string2));
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000DF18 File Offset: 0x0000C118
		public unsafe string GetString(string p0, string p1)
		{
			if (this.id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getString_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @string;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000DFAF File Offset: 0x0000C1AF
		private static Delegate GetLoadVariablesHandler()
		{
			if (IAppLovinVariableServiceInvoker.cb_loadVariables == null)
			{
				IAppLovinVariableServiceInvoker.cb_loadVariables = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinVariableServiceInvoker.n_LoadVariables));
			}
			return IAppLovinVariableServiceInvoker.cb_loadVariables;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000DFD3 File Offset: 0x0000C1D3
		private static void n_LoadVariables(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadVariables();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000DFE2 File Offset: 0x0000C1E2
		public void LoadVariables()
		{
			if (this.id_loadVariables == IntPtr.Zero)
			{
				this.id_loadVariables = JNIEnv.GetMethodID(this.class_ref, "loadVariables", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadVariables);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000E022 File Offset: 0x0000C222
		private static Delegate GetSetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_Handler()
		{
			if (IAppLovinVariableServiceInvoker.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ == null)
			{
				IAppLovinVariableServiceInvoker.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinVariableServiceInvoker.n_SetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_));
			}
			return IAppLovinVariableServiceInvoker.cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000E048 File Offset: 0x0000C248
		private static void n_SetOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinVariableService @object = Java.Lang.Object.GetObject<IAppLovinVariableService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinVariableServiceOnVariablesUpdateListener object2 = Java.Lang.Object.GetObject<IAppLovinVariableServiceOnVariablesUpdateListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetOnVariablesUpdateListener(object2);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000E06C File Offset: 0x0000C26C
		public unsafe void SetOnVariablesUpdateListener(IAppLovinVariableServiceOnVariablesUpdateListener p0)
		{
			if (this.id_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ == IntPtr.Zero)
			{
				this.id_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_ = JNIEnv.GetMethodID(this.class_ref, "setOnVariablesUpdateListener", "(Lcom/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_, ptr);
		}

		// Token: 0x04000194 RID: 404
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinVariableService", typeof(IAppLovinVariableServiceInvoker));

		// Token: 0x04000195 RID: 405
		private IntPtr class_ref;

		// Token: 0x04000196 RID: 406
		private static Delegate cb_getBoolean_Ljava_lang_String_;

		// Token: 0x04000197 RID: 407
		private IntPtr id_getBoolean_Ljava_lang_String_;

		// Token: 0x04000198 RID: 408
		private static Delegate cb_getBoolean_Ljava_lang_String_Z;

		// Token: 0x04000199 RID: 409
		private IntPtr id_getBoolean_Ljava_lang_String_Z;

		// Token: 0x0400019A RID: 410
		private static Delegate cb_getString_Ljava_lang_String_;

		// Token: 0x0400019B RID: 411
		private IntPtr id_getString_Ljava_lang_String_;

		// Token: 0x0400019C RID: 412
		private static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400019D RID: 413
		private IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x0400019E RID: 414
		private static Delegate cb_loadVariables;

		// Token: 0x0400019F RID: 415
		private IntPtr id_loadVariables;

		// Token: 0x040001A0 RID: 416
		private static Delegate cb_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_;

		// Token: 0x040001A1 RID: 417
		private IntPtr id_setOnVariablesUpdateListener_Lcom_applovin_sdk_AppLovinVariableService_OnVariablesUpdateListener_;
	}
}
