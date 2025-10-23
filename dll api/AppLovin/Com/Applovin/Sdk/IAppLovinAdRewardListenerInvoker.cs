using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000078 RID: 120
	[Register("com/applovin/sdk/AppLovinAdRewardListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdRewardListenerInvoker : Java.Lang.Object, IAppLovinAdRewardListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdRewardListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdRewardListenerInvoker._members;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000AB03 File Offset: 0x00008D03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000AB0B File Offset: 0x00008D0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdRewardListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000AB17 File Offset: 0x00008D17
		public static IAppLovinAdRewardListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(handle, transfer);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000AB20 File Offset: 0x00008D20
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdRewardListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdRewardListener'.");
			}
			return handle;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000AB4B File Offset: 0x00008D4B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000AB7C File Offset: 0x00008D7C
		public IAppLovinAdRewardListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdRewardListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000ABB4 File Offset: 0x00008DB4
		private static Delegate GetUserOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler()
		{
			if (IAppLovinAdRewardListenerInvoker.cb_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == null)
			{
				IAppLovinAdRewardListenerInvoker.cb_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdRewardListenerInvoker.n_UserOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_));
			}
			return IAppLovinAdRewardListenerInvoker.cb_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		private static void n_UserOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdRewardListener @object = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UserOverQuota(object2, p);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000AC04 File Offset: 0x00008E04
		public unsafe void UserOverQuota(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			if (this.id_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "userOverQuota", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000AC9C File Offset: 0x00008E9C
		private static Delegate GetUserRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler()
		{
			if (IAppLovinAdRewardListenerInvoker.cb_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == null)
			{
				IAppLovinAdRewardListenerInvoker.cb_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdRewardListenerInvoker.n_UserRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_));
			}
			return IAppLovinAdRewardListenerInvoker.cb_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		private static void n_UserRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdRewardListener @object = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UserRewardRejected(object2, p);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe void UserRewardRejected(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			if (this.id_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "userRewardRejected", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000AD84 File Offset: 0x00008F84
		private static Delegate GetUserRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_Handler()
		{
			if (IAppLovinAdRewardListenerInvoker.cb_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == null)
			{
				IAppLovinAdRewardListenerInvoker.cb_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinAdRewardListenerInvoker.n_UserRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_));
			}
			return IAppLovinAdRewardListenerInvoker.cb_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		private static void n_UserRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinAdRewardListener @object = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, string> p = JavaDictionary<string, string>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.UserRewardVerified(object2, p);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		public unsafe void UserRewardVerified(IAppLovinAd p0, IDictionary<string, string> p1)
		{
			if (this.id_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "userRewardVerified", "(Lcom/applovin/sdk/AppLovinAd;Ljava/util/Map;)V");
			}
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000AE6C File Offset: 0x0000906C
		private static Delegate GetValidationRequestFailed_Lcom_applovin_sdk_AppLovinAd_IHandler()
		{
			if (IAppLovinAdRewardListenerInvoker.cb_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I == null)
			{
				IAppLovinAdRewardListenerInvoker.cb_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IAppLovinAdRewardListenerInvoker.n_ValidationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I));
			}
			return IAppLovinAdRewardListenerInvoker.cb_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000AE90 File Offset: 0x00009090
		private static void n_ValidationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IAppLovinAdRewardListener @object = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ValidationRequestFailed(object2, p1);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000AEB4 File Offset: 0x000090B4
		public unsafe void ValidationRequestFailed(IAppLovinAd p0, int p1)
		{
			if (this.id_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I == IntPtr.Zero)
			{
				this.id_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I = JNIEnv.GetMethodID(this.class_ref, "validationRequestFailed", "(Lcom/applovin/sdk/AppLovinAd;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I, ptr);
		}

		// Token: 0x04000106 RID: 262
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdRewardListener", typeof(IAppLovinAdRewardListenerInvoker));

		// Token: 0x04000107 RID: 263
		private IntPtr class_ref;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x04000109 RID: 265
		private IntPtr id_userOverQuota_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x0400010B RID: 267
		private IntPtr id_userRewardRejected_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x0400010D RID: 269
		private IntPtr id_userRewardVerified_Lcom_applovin_sdk_AppLovinAd_Ljava_util_Map_;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I;

		// Token: 0x0400010F RID: 271
		private IntPtr id_validationRequestFailed_Lcom_applovin_sdk_AppLovinAd_I;
	}
}
