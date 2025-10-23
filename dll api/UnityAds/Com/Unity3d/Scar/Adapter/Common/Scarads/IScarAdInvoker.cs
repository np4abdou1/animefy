using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002BC RID: 700
	[Register("com/unity3d/scar/adapter/common/scarads/IScarAd", DoNotGenerateAcw = true)]
	internal class IScarAdInvoker : Java.Lang.Object, IScarAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000662DC File Offset: 0x000644DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarAdInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x00066300 File Offset: 0x00064500
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarAdInvoker._members;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00066307 File Offset: 0x00064507
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x0006630F File Offset: 0x0006450F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x0006631B File Offset: 0x0006451B
		public static IScarAd GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarAd>(handle, transfer);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00066324 File Offset: 0x00064524
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarAdInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.scarads.IScarAd'.");
			}
			return handle;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x0006634F File Offset: 0x0006454F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00066380 File Offset: 0x00064580
		public IScarAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarAdInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000663B8 File Offset: 0x000645B8
		private static Delegate GetLoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (IScarAdInvoker.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				IScarAdInvoker.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IScarAdInvoker.n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return IScarAdInvoker.cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000663DC File Offset: 0x000645DC
		private static void n_LoadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IScarAd @object = Java.Lang.Object.GetObject<IScarAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.LoadAd(object2);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00066400 File Offset: 0x00064600
		public unsafe void LoadAd(IScarLoadListener p0)
		{
			if (this.id_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == IntPtr.Zero)
			{
				this.id_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNIEnv.GetMethodID(this.class_ref, "loadAd", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_, ptr);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00066478 File Offset: 0x00064678
		private static Delegate GetShow_Landroid_app_Activity_Handler()
		{
			if (IScarAdInvoker.cb_show_Landroid_app_Activity_ == null)
			{
				IScarAdInvoker.cb_show_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IScarAdInvoker.n_Show_Landroid_app_Activity_));
			}
			return IScarAdInvoker.cb_show_Landroid_app_Activity_;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0006649C File Offset: 0x0006469C
		private static void n_Show_Landroid_app_Activity_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IScarAd @object = Java.Lang.Object.GetObject<IScarAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Activity object2 = Java.Lang.Object.GetObject<Activity>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x000664C0 File Offset: 0x000646C0
		public unsafe void Show(Activity p0)
		{
			if (this.id_show_Landroid_app_Activity_ == IntPtr.Zero)
			{
				this.id_show_Landroid_app_Activity_ = JNIEnv.GetMethodID(this.class_ref, "show", "(Landroid/app/Activity;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_show_Landroid_app_Activity_, ptr);
		}

		// Token: 0x040007E9 RID: 2025
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/scarads/IScarAd", typeof(IScarAdInvoker));

		// Token: 0x040007EA RID: 2026
		private IntPtr class_ref;

		// Token: 0x040007EB RID: 2027
		private static Delegate cb_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040007EC RID: 2028
		private IntPtr id_loadAd_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040007ED RID: 2029
		private static Delegate cb_show_Landroid_app_Activity_;

		// Token: 0x040007EE RID: 2030
		private IntPtr id_show_Landroid_app_Activity_;
	}
}
