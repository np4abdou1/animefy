using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Security.Cert
{
	// Token: 0x0200036A RID: 874
	[Register("java/security/cert/Certificate", DoNotGenerateAcw = true)]
	public abstract class Certificate : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x0006E929 File Offset: 0x0006CB29
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Certificate._members;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0006E930 File Offset: 0x0006CB30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Certificate._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x0006E954 File Offset: 0x0006CB54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Certificate._members.ManagedPeerType;
			}
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Certificate(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0006E960 File Offset: 0x0006CB60
		private static Delegate GetGetEncodedHandler()
		{
			if (Certificate.cb_getEncoded == null)
			{
				Certificate.cb_getEncoded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Certificate.n_GetEncoded));
			}
			return Certificate.cb_getEncoded;
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0006E984 File Offset: 0x0006CB84
		private static IntPtr n_GetEncoded(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetEncoded());
		}

		// Token: 0x060026AA RID: 9898
		public abstract byte[] GetEncoded();

		// Token: 0x060026AB RID: 9899 RVA: 0x0006E998 File Offset: 0x0006CB98
		private static Delegate GetToStringHandler()
		{
			if (Certificate.cb_toString == null)
			{
				Certificate.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Certificate.n_ToString));
			}
			return Certificate.cb_toString;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Certificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060026AD RID: 9901
		public new abstract string ToString();

		// Token: 0x04000FF4 RID: 4084
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/Certificate", typeof(Certificate));

		// Token: 0x04000FF5 RID: 4085
		private static Delegate cb_getEncoded;

		// Token: 0x04000FF6 RID: 4086
		private static Delegate cb_toString;
	}
}
