using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000AC RID: 172
	[Register("com/applovin/mediation/MaxAdRevenueListener", DoNotGenerateAcw = true)]
	internal class IMaxAdRevenueListenerInvoker : Java.Lang.Object, IMaxAdRevenueListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0000F324 File Offset: 0x0000D524
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdRevenueListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0000F348 File Offset: 0x0000D548
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdRevenueListenerInvoker._members;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0000F34F File Offset: 0x0000D54F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0000F357 File Offset: 0x0000D557
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdRevenueListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000F363 File Offset: 0x0000D563
		public static IMaxAdRevenueListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdRevenueListener>(handle, transfer);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000F36C File Offset: 0x0000D56C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdRevenueListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAdRevenueListener'.");
			}
			return handle;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000F397 File Offset: 0x0000D597
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public IMaxAdRevenueListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdRevenueListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000F400 File Offset: 0x0000D600
		private static Delegate GetOnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_Handler()
		{
			if (IMaxAdRevenueListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ == null)
			{
				IMaxAdRevenueListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxAdRevenueListenerInvoker.n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_));
			}
			return IMaxAdRevenueListenerInvoker.cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000F424 File Offset: 0x0000D624
		private static void n_OnAdRevenuePaid_Lcom_applovin_mediation_MaxAd_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAdRevenueListener @object = Java.Lang.Object.GetObject<IMaxAdRevenueListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMaxAd object2 = Java.Lang.Object.GetObject<IMaxAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdRevenuePaid(object2);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000F448 File Offset: 0x0000D648
		public unsafe void OnAdRevenuePaid(IMaxAd p0)
		{
			if (this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ == IntPtr.Zero)
			{
				this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_ = JNIEnv.GetMethodID(this.class_ref, "onAdRevenuePaid", "(Lcom/applovin/mediation/MaxAd;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_, ptr);
		}

		// Token: 0x040001E1 RID: 481
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdRevenueListener", typeof(IMaxAdRevenueListenerInvoker));

		// Token: 0x040001E2 RID: 482
		private IntPtr class_ref;

		// Token: 0x040001E3 RID: 483
		private static Delegate cb_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;

		// Token: 0x040001E4 RID: 484
		private IntPtr id_onAdRevenuePaid_Lcom_applovin_mediation_MaxAd_;
	}
}
