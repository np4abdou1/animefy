using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000081 RID: 129
	[Register("com/applovin/sdk/AppLovinAdVideoPlaybackListener", DoNotGenerateAcw = true)]
	internal class IAppLovinAdVideoPlaybackListenerInvoker : Java.Lang.Object, IAppLovinAdVideoPlaybackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000B628 File Offset: 0x00009828
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinAdVideoPlaybackListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000B64C File Offset: 0x0000984C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinAdVideoPlaybackListenerInvoker._members;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000B653 File Offset: 0x00009853
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000B65B File Offset: 0x0000985B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinAdVideoPlaybackListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000B667 File Offset: 0x00009867
		public static IAppLovinAdVideoPlaybackListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(handle, transfer);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000B670 File Offset: 0x00009870
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinAdVideoPlaybackListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinAdVideoPlaybackListener'.");
			}
			return handle;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000B69B File Offset: 0x0000989B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000B6CC File Offset: 0x000098CC
		public IAppLovinAdVideoPlaybackListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinAdVideoPlaybackListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000B704 File Offset: 0x00009904
		private static Delegate GetVideoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_Handler()
		{
			if (IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_ == null)
			{
				IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinAdVideoPlaybackListenerInvoker.n_VideoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_));
			}
			return IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000B728 File Offset: 0x00009928
		private static void n_VideoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinAdVideoPlaybackListener @object = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.VideoPlaybackBegan(object2);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000B74C File Offset: 0x0000994C
		public unsafe void VideoPlaybackBegan(IAppLovinAd p0)
		{
			if (this.id_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_ == IntPtr.Zero)
			{
				this.id_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_ = JNIEnv.GetMethodID(this.class_ref, "videoPlaybackBegan", "(Lcom/applovin/sdk/AppLovinAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_, ptr);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000B7C4 File Offset: 0x000099C4
		private static Delegate GetVideoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZHandler()
		{
			if (IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ == null)
			{
				IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLDZ_V(IAppLovinAdVideoPlaybackListenerInvoker.n_VideoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ));
			}
			return IAppLovinAdVideoPlaybackListenerInvoker.cb_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000B7E8 File Offset: 0x000099E8
		private static void n_VideoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1, bool p2)
		{
			IAppLovinAdVideoPlaybackListener @object = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.VideoPlaybackEnded(object2, p1, p2);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000B810 File Offset: 0x00009A10
		public unsafe void VideoPlaybackEnded(IAppLovinAd p0, double p1, bool p2)
		{
			if (this.id_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ == IntPtr.Zero)
			{
				this.id_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ = JNIEnv.GetMethodID(this.class_ref, "videoPlaybackEnded", "(Lcom/applovin/sdk/AppLovinAd;DZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ, ptr);
		}

		// Token: 0x04000129 RID: 297
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinAdVideoPlaybackListener", typeof(IAppLovinAdVideoPlaybackListenerInvoker));

		// Token: 0x0400012A RID: 298
		private IntPtr class_ref;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x0400012C RID: 300
		private IntPtr id_videoPlaybackBegan_Lcom_applovin_sdk_AppLovinAd_;

		// Token: 0x0400012D RID: 301
		private static Delegate cb_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ;

		// Token: 0x0400012E RID: 302
		private IntPtr id_videoPlaybackEnded_Lcom_applovin_sdk_AppLovinAd_DZ;
	}
}
