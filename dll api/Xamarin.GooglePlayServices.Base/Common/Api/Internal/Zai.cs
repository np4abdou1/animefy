using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000041 RID: 65
	[Register("com/google/android/gms/common/api/internal/zai", DoNotGenerateAcw = true)]
	public abstract class Zai : Java.Lang.Object
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000882B File Offset: 0x00006A2B
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00008842 File Offset: 0x00006A42
		[Register("zac")]
		public int Zac
		{
			get
			{
				return Zai._members.InstanceFields.GetInt32Value("zac.I", this);
			}
			set
			{
				Zai._members.InstanceFields.SetValue("zac.I", this, value);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000885C File Offset: 0x00006A5C
		internal static IntPtr class_ref
		{
			get
			{
				return Zai._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00008880 File Offset: 0x00006A80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Zai._members;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00008888 File Offset: 0x00006A88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Zai._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000088AC File Offset: 0x00006AAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Zai._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003280 File Offset: 0x00001480
		protected Zai(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000088B8 File Offset: 0x00006AB8
		[Register(".ctor", "(I)V", "")]
		public unsafe Zai(int p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			base.SetHandle(Zai._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Zai._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000893C File Offset: 0x00006B3C
		private static Delegate GetZad_Lcom_google_android_gms_common_api_Status_Handler()
		{
			if (Zai.cb_zad_Lcom_google_android_gms_common_api_Status_ == null)
			{
				Zai.cb_zad_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Zai.n_Zad_Lcom_google_android_gms_common_api_Status_));
			}
			return Zai.cb_zad_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00008960 File Offset: 0x00006B60
		private static void n_Zad_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Zai @object = Java.Lang.Object.GetObject<Zai>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Zad(object2);
		}

		// Token: 0x0600028F RID: 655
		[Register("zad", "(Lcom/google/android/gms/common/api/Status;)V", "GetZad_Lcom_google_android_gms_common_api_Status_Handler")]
		public abstract void Zad(Statuses p0);

		// Token: 0x06000290 RID: 656 RVA: 0x00008983 File Offset: 0x00006B83
		private static Delegate GetZae_Ljava_lang_Exception_Handler()
		{
			if (Zai.cb_zae_Ljava_lang_Exception_ == null)
			{
				Zai.cb_zae_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Zai.n_Zae_Ljava_lang_Exception_));
			}
			return Zai.cb_zae_Ljava_lang_Exception_;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000089A8 File Offset: 0x00006BA8
		private static void n_Zae_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Zai @object = Java.Lang.Object.GetObject<Zai>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Zae(object2);
		}

		// Token: 0x06000292 RID: 658
		[Register("zae", "(Ljava/lang/Exception;)V", "GetZae_Ljava_lang_Exception_Handler")]
		public abstract void Zae(Java.Lang.Exception p0);

		// Token: 0x06000293 RID: 659 RVA: 0x000089CB File Offset: 0x00006BCB
		private static Delegate GetZaf_Lcom_google_android_gms_common_api_internal_zabq_Handler()
		{
			if (Zai.cb_zaf_Lcom_google_android_gms_common_api_internal_zabq_ == null)
			{
				Zai.cb_zaf_Lcom_google_android_gms_common_api_internal_zabq_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Zai.n_Zaf_Lcom_google_android_gms_common_api_internal_zabq_));
			}
			return Zai.cb_zaf_Lcom_google_android_gms_common_api_internal_zabq_;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000089F0 File Offset: 0x00006BF0
		private static void n_Zaf_Lcom_google_android_gms_common_api_internal_zabq_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Zai @object = Java.Lang.Object.GetObject<Zai>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Zabq object2 = Java.Lang.Object.GetObject<Zabq>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Zaf(object2);
		}

		// Token: 0x06000295 RID: 661
		[Register("zaf", "(Lcom/google/android/gms/common/api/internal/zabq;)V", "GetZaf_Lcom_google_android_gms_common_api_internal_zabq_Handler")]
		public abstract void Zaf(Zabq p0);

		// Token: 0x06000296 RID: 662 RVA: 0x00008A13 File Offset: 0x00006C13
		private static Delegate GetZag_Lcom_google_android_gms_common_api_internal_zaad_ZHandler()
		{
			if (Zai.cb_zag_Lcom_google_android_gms_common_api_internal_zaad_Z == null)
			{
				Zai.cb_zag_Lcom_google_android_gms_common_api_internal_zaad_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(Zai.n_Zag_Lcom_google_android_gms_common_api_internal_zaad_Z));
			}
			return Zai.cb_zag_Lcom_google_android_gms_common_api_internal_zaad_Z;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00008A38 File Offset: 0x00006C38
		private static void n_Zag_Lcom_google_android_gms_common_api_internal_zaad_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			Zai @object = Java.Lang.Object.GetObject<Zai>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Zaad object2 = Java.Lang.Object.GetObject<Zaad>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Zag(object2, p1);
		}

		// Token: 0x06000298 RID: 664
		[Register("zag", "(Lcom/google/android/gms/common/api/internal/zaad;Z)V", "GetZag_Lcom_google_android_gms_common_api_internal_zaad_ZHandler")]
		public abstract void Zag(Zaad p0, bool p1);

		// Token: 0x04000082 RID: 130
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/zai", typeof(Zai));

		// Token: 0x04000083 RID: 131
		private static Delegate cb_zad_Lcom_google_android_gms_common_api_Status_;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_zae_Ljava_lang_Exception_;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_zaf_Lcom_google_android_gms_common_api_internal_zabq_;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_zag_Lcom_google_android_gms_common_api_internal_zaad_Z;
	}
}
