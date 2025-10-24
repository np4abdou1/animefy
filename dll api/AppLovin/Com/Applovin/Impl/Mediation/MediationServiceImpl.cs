using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Impl.Sdk;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x0200015A RID: 346
	[Register("com/applovin/impl/mediation/MediationServiceImpl", DoNotGenerateAcw = true)]
	public class MediationServiceImpl : Java.Lang.Object, AppLovinBroadcastManager.IReceiver, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00031280 File Offset: 0x0002F480
		internal static IntPtr class_ref
		{
			get
			{
				return MediationServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000312A4 File Offset: 0x0002F4A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediationServiceImpl._members;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000312AC File Offset: 0x0002F4AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediationServiceImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000312D0 File Offset: 0x0002F4D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediationServiceImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MediationServiceImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x000312DC File Offset: 0x0002F4DC
		private static Delegate GetGetAndResetCustomPostBodyDataHandler()
		{
			if (MediationServiceImpl.cb_getAndResetCustomPostBodyData == null)
			{
				MediationServiceImpl.cb_getAndResetCustomPostBodyData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MediationServiceImpl.n_GetAndResetCustomPostBodyData));
			}
			return MediationServiceImpl.cb_getAndResetCustomPostBodyData;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00031300 File Offset: 0x0002F500
		private static IntPtr n_GetAndResetCustomPostBodyData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MediationServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AndResetCustomPostBodyData);
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00031314 File Offset: 0x0002F514
		public virtual JSONObject AndResetCustomPostBodyData
		{
			[Register("getAndResetCustomPostBodyData", "()Lorg/json/JSONObject;", "GetGetAndResetCustomPostBodyDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(MediationServiceImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAndResetCustomPostBodyData.()Lorg/json/JSONObject;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00031346 File Offset: 0x0002F546
		private static Delegate GetDestroyAd_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (MediationServiceImpl.cb_destroyAd_Lcom_applovin_mediation_MaxAd_ == null)
			{
				MediationServiceImpl.cb_destroyAd_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationServiceImpl.n_DestroyAd_Lcom_applovin_mediation_MaxAd_));
			}
			return MediationServiceImpl.cb_destroyAd_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0003136C File Offset: 0x0002F56C
		private static void n_DestroyAd_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationServiceImpl @object = Java.Lang.Object.GetObject<MediationServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.DestroyAd(object2);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00031390 File Offset: 0x0002F590
		[Register("destroyAd", "(Lcom/applovin/mediation/MaxAd;)V", "GetDestroyAd_Lcom_applovin_mediation_MaxAd_Handler")]
		public unsafe virtual void DestroyAd(IMaxAd p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				MediationServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("destroyAd.(Lcom/applovin/mediation/MaxAd;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000313F8 File Offset: 0x0002F5F8
		private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_Handler()
		{
			if (MediationServiceImpl.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ == null)
			{
				MediationServiceImpl.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MediationServiceImpl.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_));
			}
			return MediationServiceImpl.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0003141C File Offset: 0x0002F61C
		private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			MediationServiceImpl @object = Java.Lang.Object.GetObject<MediationServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_p1, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnReceive(object2, object3, p);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00031454 File Offset: 0x0002F654
		[Register("onReceive", "(Landroid/content/Context;Landroid/content/Intent;Ljava/util/Map;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_Handler")]
		public unsafe virtual void OnReceive(Context p0, Intent p1, IDictionary<string, Java.Lang.Object> p2)
		{
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				MediationServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("onReceive.(Landroid/content/Context;Landroid/content/Intent;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00031508 File Offset: 0x0002F708
		private static Delegate GetSetCustomPostBodyData_Lorg_json_JSONObject_Handler()
		{
			if (MediationServiceImpl.cb_setCustomPostBodyData_Lorg_json_JSONObject_ == null)
			{
				MediationServiceImpl.cb_setCustomPostBodyData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediationServiceImpl.n_SetCustomPostBodyData_Lorg_json_JSONObject_));
			}
			return MediationServiceImpl.cb_setCustomPostBodyData_Lorg_json_JSONObject_;
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0003152C File Offset: 0x0002F72C
		private static void n_SetCustomPostBodyData_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			MediationServiceImpl @object = Java.Lang.Object.GetObject<MediationServiceImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomPostBodyData(object2);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00031550 File Offset: 0x0002F750
		[Register("setCustomPostBodyData", "(Lorg/json/JSONObject;)V", "GetSetCustomPostBodyData_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetCustomPostBodyData(JSONObject p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				MediationServiceImpl._members.InstanceMethods.InvokeVirtualVoidMethod("setCustomPostBodyData.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400059C RID: 1436
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MediationServiceImpl", typeof(MediationServiceImpl));

		// Token: 0x0400059D RID: 1437
		private static Delegate cb_getAndResetCustomPostBodyData;

		// Token: 0x0400059E RID: 1438
		private static Delegate cb_destroyAd_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x0400059F RID: 1439
		private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_Ljava_util_Map_;

		// Token: 0x040005A0 RID: 1440
		private static Delegate cb_setCustomPostBodyData_Lorg_json_JSONObject_;
	}
}
