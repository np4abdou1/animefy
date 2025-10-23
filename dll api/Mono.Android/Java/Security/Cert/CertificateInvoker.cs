using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Security.Cert
{
	// Token: 0x0200036B RID: 875
	[Register("java/security/cert/Certificate", DoNotGenerateAcw = true)]
	internal class CertificateInvoker : Certificate
	{
		// Token: 0x060026AF RID: 9903 RVA: 0x0006E9EB File Offset: 0x0006CBEB
		public CertificateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0006E9F5 File Offset: 0x0006CBF5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CertificateInvoker._members;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x0006E9FC File Offset: 0x0006CBFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CertificateInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0006EA08 File Offset: 0x0006CC08
		public override byte[] GetEncoded()
		{
			return (byte[])JNIEnv.GetArray(CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEncoded.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x0006EA4C File Offset: 0x0006CC4C
		public override string ToString()
		{
			return JNIEnv.GetString(CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000FF7 RID: 4087
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/Certificate", typeof(CertificateInvoker));
	}
}
