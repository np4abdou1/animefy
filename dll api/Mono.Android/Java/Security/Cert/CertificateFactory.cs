using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Security.Cert
{
	// Token: 0x0200036C RID: 876
	[Register("java/security/cert/CertificateFactory", DoNotGenerateAcw = true)]
	public class CertificateFactory : Java.Lang.Object
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0006EA99 File Offset: 0x0006CC99
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CertificateFactory._members;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CertificateFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x0006EAC4 File Offset: 0x0006CCC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CertificateFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000021E0 File Offset: 0x000003E0
		protected CertificateFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0006EAD0 File Offset: 0x0006CCD0
		public unsafe Certificate GenerateCertificate(Stream inStream)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(inStream);
			Certificate @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Certificate>(CertificateFactory._members.InstanceMethods.InvokeNonvirtualObjectMethod("generateCertificate.(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(inStream);
			}
			return @object;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0006EB44 File Offset: 0x0006CD44
		public unsafe static CertificateFactory GetInstance(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			CertificateFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CertificateFactory>(CertificateFactory._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000FF8 RID: 4088
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/CertificateFactory", typeof(CertificateFactory));
	}
}
