using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Javax.Net.Ssl
{
	// Token: 0x02000092 RID: 146
	[Register("javax/net/ssl/TrustManagerFactory", DoNotGenerateAcw = true)]
	public class TrustManagerFactory : Java.Lang.Object
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000026DF File Offset: 0x000008DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TrustManagerFactory._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000026E8 File Offset: 0x000008E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TrustManagerFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000270C File Offset: 0x0000090C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TrustManagerFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000021E0 File Offset: 0x000003E0
		protected TrustManagerFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002718 File Offset: 0x00000918
		public static string DefaultAlgorithm
		{
			get
			{
				return JNIEnv.GetString(TrustManagerFactory._members.StaticMethods.InvokeObjectMethod("getDefaultAlgorithm.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000274C File Offset: 0x0000094C
		public unsafe static TrustManagerFactory GetInstance(string algorithm)
		{
			IntPtr intPtr = JNIEnv.NewString(algorithm);
			TrustManagerFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TrustManagerFactory>(TrustManagerFactory._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;)Ljavax/net/ssl/TrustManagerFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000027B8 File Offset: 0x000009B8
		public ITrustManager[] GetTrustManagers()
		{
			return (ITrustManager[])JNIEnv.GetArray(TrustManagerFactory._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTrustManagers.()[Ljavax/net/ssl/TrustManager;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ITrustManager));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000027FC File Offset: 0x000009FC
		public unsafe void Init(KeyStore ks)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ks == null) ? IntPtr.Zero : ks.Handle);
				TrustManagerFactory._members.InstanceMethods.InvokeNonvirtualVoidMethod("init.(Ljava/security/KeyStore;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ks);
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/net/ssl/TrustManagerFactory", typeof(TrustManagerFactory));
	}
}
