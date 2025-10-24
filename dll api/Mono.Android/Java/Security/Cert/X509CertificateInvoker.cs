using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Security.Cert
{
	// Token: 0x02000370 RID: 880
	[Register("java/security/cert/X509Certificate", DoNotGenerateAcw = true)]
	internal class X509CertificateInvoker : X509Certificate
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x0006F056 File Offset: 0x0006D256
		public X509CertificateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x0006F060 File Offset: 0x0006D260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return X509CertificateInvoker._members;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x0006F067 File Offset: 0x0006D267
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return X509CertificateInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x0006F074 File Offset: 0x0006D274
		public override ICollection<string> CriticalExtensionOIDs
		{
			get
			{
				return JavaSet<string>.FromJniHandle(X509CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCriticalExtensionOIDs.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x0006F0A6 File Offset: 0x0006D2A6
		public override bool HasUnsupportedCriticalExtension
		{
			get
			{
				return X509CertificateInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasUnsupportedCriticalExtension.()Z", this, null);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x0006F0C0 File Offset: 0x0006D2C0
		public override ICollection<string> NonCriticalExtensionOIDs
		{
			get
			{
				return JavaSet<string>.FromJniHandle(X509CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getNonCriticalExtensionOIDs.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0006F0F4 File Offset: 0x0006D2F4
		public unsafe override byte[] GetExtensionValue(string oid)
		{
			IntPtr intPtr = JNIEnv.NewString(oid);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(X509CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExtensionValue.(Ljava/lang/String;)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0006F170 File Offset: 0x0006D370
		public override byte[] GetEncoded()
		{
			return (byte[])JNIEnv.GetArray(X509CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEncoded.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0006F1B4 File Offset: 0x0006D3B4
		public override string ToString()
		{
			return JNIEnv.GetString(X509CertificateInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001008 RID: 4104
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/X509Certificate", typeof(X509CertificateInvoker));
	}
}
