using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000156 RID: 342
	[Register("com/applovin/impl/mediation/MaxMediatedNetworkInfoImpl", DoNotGenerateAcw = true)]
	public class MaxMediatedNetworkInfoImpl : Java.Lang.Object, IMaxMediatedNetworkInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00030A6C File Offset: 0x0002EC6C
		internal static IntPtr class_ref
		{
			get
			{
				return MaxMediatedNetworkInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00030A90 File Offset: 0x0002EC90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxMediatedNetworkInfoImpl._members;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00030A98 File Offset: 0x0002EC98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxMediatedNetworkInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00030ABC File Offset: 0x0002ECBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxMediatedNetworkInfoImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxMediatedNetworkInfoImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe MaxMediatedNetworkInfoImpl(JSONObject p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(MaxMediatedNetworkInfoImpl._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxMediatedNetworkInfoImpl._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00030B78 File Offset: 0x0002ED78
		private static Delegate GetGetAdapterClassNameHandler()
		{
			if (MaxMediatedNetworkInfoImpl.cb_getAdapterClassName == null)
			{
				MaxMediatedNetworkInfoImpl.cb_getAdapterClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxMediatedNetworkInfoImpl.n_GetAdapterClassName));
			}
			return MaxMediatedNetworkInfoImpl.cb_getAdapterClassName;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00030B9C File Offset: 0x0002ED9C
		private static IntPtr n_GetAdapterClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxMediatedNetworkInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterClassName);
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		public virtual string AdapterClassName
		{
			[Register("getAdapterClassName", "()Ljava/lang/String;", "GetGetAdapterClassNameHandler")]
			get
			{
				return JNIEnv.GetString(MaxMediatedNetworkInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00030BE2 File Offset: 0x0002EDE2
		private static Delegate GetGetAdapterVersionHandler()
		{
			if (MaxMediatedNetworkInfoImpl.cb_getAdapterVersion == null)
			{
				MaxMediatedNetworkInfoImpl.cb_getAdapterVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxMediatedNetworkInfoImpl.n_GetAdapterVersion));
			}
			return MaxMediatedNetworkInfoImpl.cb_getAdapterVersion;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00030C06 File Offset: 0x0002EE06
		private static IntPtr n_GetAdapterVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxMediatedNetworkInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdapterVersion);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00030C1C File Offset: 0x0002EE1C
		public virtual string AdapterVersion
		{
			[Register("getAdapterVersion", "()Ljava/lang/String;", "GetGetAdapterVersionHandler")]
			get
			{
				return JNIEnv.GetString(MaxMediatedNetworkInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00030C4E File Offset: 0x0002EE4E
		private static Delegate GetGetNameHandler()
		{
			if (MaxMediatedNetworkInfoImpl.cb_getName == null)
			{
				MaxMediatedNetworkInfoImpl.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxMediatedNetworkInfoImpl.n_GetName));
			}
			return MaxMediatedNetworkInfoImpl.cb_getName;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00030C72 File Offset: 0x0002EE72
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxMediatedNetworkInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00030C88 File Offset: 0x0002EE88
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(MaxMediatedNetworkInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00030CBA File Offset: 0x0002EEBA
		private static Delegate GetGetSdkVersionHandler()
		{
			if (MaxMediatedNetworkInfoImpl.cb_getSdkVersion == null)
			{
				MaxMediatedNetworkInfoImpl.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxMediatedNetworkInfoImpl.n_GetSdkVersion));
			}
			return MaxMediatedNetworkInfoImpl.cb_getSdkVersion;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00030CDE File Offset: 0x0002EEDE
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxMediatedNetworkInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00030CF4 File Offset: 0x0002EEF4
		public virtual string SdkVersion
		{
			[Register("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get
			{
				return JNIEnv.GetString(MaxMediatedNetworkInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getSdkVersion.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400058E RID: 1422
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxMediatedNetworkInfoImpl", typeof(MaxMediatedNetworkInfoImpl));

		// Token: 0x0400058F RID: 1423
		private static Delegate cb_getAdapterClassName;

		// Token: 0x04000590 RID: 1424
		private static Delegate cb_getAdapterVersion;

		// Token: 0x04000591 RID: 1425
		private static Delegate cb_getName;

		// Token: 0x04000592 RID: 1426
		private static Delegate cb_getSdkVersion;
	}
}
