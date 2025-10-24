using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Security.Cert
{
	// Token: 0x0200036F RID: 879
	[Register("java/security/cert/X509Certificate", DoNotGenerateAcw = true)]
	public abstract class X509Certificate : Certificate, IX509Extension, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x0006EF15 File Offset: 0x0006D115
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return X509Certificate._members;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0006EF1C File Offset: 0x0006D11C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return X509Certificate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x0006EF40 File Offset: 0x0006D140
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return X509Certificate._members.ManagedPeerType;
			}
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0006E9EB File Offset: 0x0006CBEB
		protected X509Certificate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0006EF4C File Offset: 0x0006D14C
		private static Delegate GetGetExtensionValue_Ljava_lang_String_Handler()
		{
			if (X509Certificate.cb_getExtensionValue_Ljava_lang_String_ == null)
			{
				X509Certificate.cb_getExtensionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(X509Certificate.n_GetExtensionValue_Ljava_lang_String_));
			}
			return X509Certificate.cb_getExtensionValue_Ljava_lang_String_;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0006EF70 File Offset: 0x0006D170
		private static IntPtr n_GetExtensionValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			X509Certificate @object = Java.Lang.Object.GetObject<X509Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_oid, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.GetExtensionValue(@string));
		}

		// Token: 0x060026DA RID: 9946
		public abstract byte[] GetExtensionValue(string oid);

		// Token: 0x060026DB RID: 9947 RVA: 0x0006EF98 File Offset: 0x0006D198
		private static Delegate GetGetCriticalExtensionOIDsHandler()
		{
			if (X509Certificate.cb_getCriticalExtensionOIDs == null)
			{
				X509Certificate.cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(X509Certificate.n_GetCriticalExtensionOIDs));
			}
			return X509Certificate.cb_getCriticalExtensionOIDs;
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0006EFBC File Offset: 0x0006D1BC
		private static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<X509Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CriticalExtensionOIDs);
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060026DD RID: 9949
		public abstract ICollection<string> CriticalExtensionOIDs { get; }

		// Token: 0x060026DE RID: 9950 RVA: 0x0006EFD0 File Offset: 0x0006D1D0
		private static Delegate GetHasUnsupportedCriticalExtensionHandler()
		{
			if (X509Certificate.cb_hasUnsupportedCriticalExtension == null)
			{
				X509Certificate.cb_hasUnsupportedCriticalExtension = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(X509Certificate.n_HasUnsupportedCriticalExtension));
			}
			return X509Certificate.cb_hasUnsupportedCriticalExtension;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0006EFF4 File Offset: 0x0006D1F4
		private static bool n_HasUnsupportedCriticalExtension(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<X509Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUnsupportedCriticalExtension;
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060026E0 RID: 9952
		public abstract bool HasUnsupportedCriticalExtension { get; }

		// Token: 0x060026E1 RID: 9953 RVA: 0x0006F003 File Offset: 0x0006D203
		private static Delegate GetGetNonCriticalExtensionOIDsHandler()
		{
			if (X509Certificate.cb_getNonCriticalExtensionOIDs == null)
			{
				X509Certificate.cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(X509Certificate.n_GetNonCriticalExtensionOIDs));
			}
			return X509Certificate.cb_getNonCriticalExtensionOIDs;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0006F027 File Offset: 0x0006D227
		private static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<X509Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NonCriticalExtensionOIDs);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060026E3 RID: 9955
		public abstract ICollection<string> NonCriticalExtensionOIDs { get; }

		// Token: 0x04001003 RID: 4099
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/X509Certificate", typeof(X509Certificate));

		// Token: 0x04001004 RID: 4100
		private static Delegate cb_getExtensionValue_Ljava_lang_String_;

		// Token: 0x04001005 RID: 4101
		private static Delegate cb_getCriticalExtensionOIDs;

		// Token: 0x04001006 RID: 4102
		private static Delegate cb_hasUnsupportedCriticalExtension;

		// Token: 0x04001007 RID: 4103
		private static Delegate cb_getNonCriticalExtensionOIDs;
	}
}
