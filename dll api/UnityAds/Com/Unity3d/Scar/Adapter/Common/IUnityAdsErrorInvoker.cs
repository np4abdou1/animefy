using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A4 RID: 676
	[Register("com/unity3d/scar/adapter/common/IUnityAdsError", DoNotGenerateAcw = true)]
	internal class IUnityAdsErrorInvoker : Java.Lang.Object, IUnityAdsError, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x00063990 File Offset: 0x00061B90
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnityAdsErrorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000639B4 File Offset: 0x00061BB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnityAdsErrorInvoker._members;
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000639BB File Offset: 0x00061BBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000639C3 File Offset: 0x00061BC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnityAdsErrorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000639CF File Offset: 0x00061BCF
		public static IUnityAdsError GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnityAdsError>(handle, transfer);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000639D8 File Offset: 0x00061BD8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnityAdsErrorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IUnityAdsError'.");
			}
			return handle;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00063A03 File Offset: 0x00061C03
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00063A34 File Offset: 0x00061C34
		public IUnityAdsErrorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnityAdsErrorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00063A6C File Offset: 0x00061C6C
		private static Delegate GetGetCodeHandler()
		{
			if (IUnityAdsErrorInvoker.cb_getCode == null)
			{
				IUnityAdsErrorInvoker.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnityAdsErrorInvoker.n_GetCode));
			}
			return IUnityAdsErrorInvoker.cb_getCode;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00063A90 File Offset: 0x00061C90
		private static int n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnityAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code;
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x00063A9F File Offset: 0x00061C9F
		public int Code
		{
			get
			{
				if (this.id_getCode == IntPtr.Zero)
				{
					this.id_getCode = JNIEnv.GetMethodID(this.class_ref, "getCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getCode);
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00063ADF File Offset: 0x00061CDF
		private static Delegate GetGetDescriptionHandler()
		{
			if (IUnityAdsErrorInvoker.cb_getDescription == null)
			{
				IUnityAdsErrorInvoker.cb_getDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnityAdsErrorInvoker.n_GetDescription));
			}
			return IUnityAdsErrorInvoker.cb_getDescription;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00063B03 File Offset: 0x00061D03
		private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnityAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Description);
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x00063B18 File Offset: 0x00061D18
		public string Description
		{
			get
			{
				if (this.id_getDescription == IntPtr.Zero)
				{
					this.id_getDescription = JNIEnv.GetMethodID(this.class_ref, "getDescription", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00063B69 File Offset: 0x00061D69
		private static Delegate GetGetDomainHandler()
		{
			if (IUnityAdsErrorInvoker.cb_getDomain == null)
			{
				IUnityAdsErrorInvoker.cb_getDomain = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnityAdsErrorInvoker.n_GetDomain));
			}
			return IUnityAdsErrorInvoker.cb_getDomain;
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00063B8D File Offset: 0x00061D8D
		private static IntPtr n_GetDomain(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnityAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Domain);
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x00063BA4 File Offset: 0x00061DA4
		public string Domain
		{
			get
			{
				if (this.id_getDomain == IntPtr.Zero)
				{
					this.id_getDomain = JNIEnv.GetMethodID(this.class_ref, "getDomain", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getDomain), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IUnityAdsError", typeof(IUnityAdsErrorInvoker));

		// Token: 0x040007A7 RID: 1959
		private IntPtr class_ref;

		// Token: 0x040007A8 RID: 1960
		private static Delegate cb_getCode;

		// Token: 0x040007A9 RID: 1961
		private IntPtr id_getCode;

		// Token: 0x040007AA RID: 1962
		private static Delegate cb_getDescription;

		// Token: 0x040007AB RID: 1963
		private IntPtr id_getDescription;

		// Token: 0x040007AC RID: 1964
		private static Delegate cb_getDomain;

		// Token: 0x040007AD RID: 1965
		private IntPtr id_getDomain;
	}
}
