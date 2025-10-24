using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000BE RID: 190
	[Register("com/applovin/mediation/MaxMediatedNetworkInfo", DoNotGenerateAcw = true)]
	internal class IMaxMediatedNetworkInfoInvoker : Java.Lang.Object, IMaxMediatedNetworkInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000106D0 File Offset: 0x0000E8D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxMediatedNetworkInfoInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000106F4 File Offset: 0x0000E8F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxMediatedNetworkInfoInvoker._members;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x000106FB File Offset: 0x0000E8FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00010703 File Offset: 0x0000E903
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxMediatedNetworkInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001070F File Offset: 0x0000E90F
		public static IMaxMediatedNetworkInfo GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(handle, transfer);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00010718 File Offset: 0x0000E918
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxMediatedNetworkInfoInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxMediatedNetworkInfo'.");
			}
			return handle;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00010743 File Offset: 0x0000E943
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00010774 File Offset: 0x0000E974
		public IMaxMediatedNetworkInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxMediatedNetworkInfoInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000107AC File Offset: 0x0000E9AC
		private static Delegate GetGetAdapterClassNameHandler()
		{
			if (IMaxMediatedNetworkInfoInvoker.cb_getAdapterClassName == null)
			{
				IMaxMediatedNetworkInfoInvoker.cb_getAdapterClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxMediatedNetworkInfoInvoker.n_GetAdapterClassName));
			}
			return IMaxMediatedNetworkInfoInvoker.cb_getAdapterClassName;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000107D0 File Offset: 0x0000E9D0
		private static IntPtr n_GetAdapterClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterClassName);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000107E4 File Offset: 0x0000E9E4
		public string AdapterClassName
		{
			get
			{
				if (this.id_getAdapterClassName == IntPtr.Zero)
				{
					this.id_getAdapterClassName = JNIEnv.GetMethodID(this.class_ref, "getAdapterClassName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdapterClassName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00010835 File Offset: 0x0000EA35
		private static Delegate GetGetAdapterVersionHandler()
		{
			if (IMaxMediatedNetworkInfoInvoker.cb_getAdapterVersion == null)
			{
				IMaxMediatedNetworkInfoInvoker.cb_getAdapterVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxMediatedNetworkInfoInvoker.n_GetAdapterVersion));
			}
			return IMaxMediatedNetworkInfoInvoker.cb_getAdapterVersion;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00010859 File Offset: 0x0000EA59
		private static IntPtr n_GetAdapterVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterVersion);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00010870 File Offset: 0x0000EA70
		public string AdapterVersion
		{
			get
			{
				if (this.id_getAdapterVersion == IntPtr.Zero)
				{
					this.id_getAdapterVersion = JNIEnv.GetMethodID(this.class_ref, "getAdapterVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdapterVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000108C1 File Offset: 0x0000EAC1
		private static Delegate GetGetNameHandler()
		{
			if (IMaxMediatedNetworkInfoInvoker.cb_getName == null)
			{
				IMaxMediatedNetworkInfoInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxMediatedNetworkInfoInvoker.n_GetName));
			}
			return IMaxMediatedNetworkInfoInvoker.cb_getName;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000108E5 File Offset: 0x0000EAE5
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000108FC File Offset: 0x0000EAFC
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001094D File Offset: 0x0000EB4D
		private static Delegate GetGetSdkVersionHandler()
		{
			if (IMaxMediatedNetworkInfoInvoker.cb_getSdkVersion == null)
			{
				IMaxMediatedNetworkInfoInvoker.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxMediatedNetworkInfoInvoker.n_GetSdkVersion));
			}
			return IMaxMediatedNetworkInfoInvoker.cb_getSdkVersion;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00010971 File Offset: 0x0000EB71
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00010988 File Offset: 0x0000EB88
		public string SdkVersion
		{
			get
			{
				if (this.id_getSdkVersion == IntPtr.Zero)
				{
					this.id_getSdkVersion = JNIEnv.GetMethodID(this.class_ref, "getSdkVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000224 RID: 548
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxMediatedNetworkInfo", typeof(IMaxMediatedNetworkInfoInvoker));

		// Token: 0x04000225 RID: 549
		private IntPtr class_ref;

		// Token: 0x04000226 RID: 550
		private static Delegate cb_getAdapterClassName;

		// Token: 0x04000227 RID: 551
		private IntPtr id_getAdapterClassName;

		// Token: 0x04000228 RID: 552
		private static Delegate cb_getAdapterVersion;

		// Token: 0x04000229 RID: 553
		private IntPtr id_getAdapterVersion;

		// Token: 0x0400022A RID: 554
		private static Delegate cb_getName;

		// Token: 0x0400022B RID: 555
		private IntPtr id_getName;

		// Token: 0x0400022C RID: 556
		private static Delegate cb_getSdkVersion;

		// Token: 0x0400022D RID: 557
		private IntPtr id_getSdkVersion;
	}
}
