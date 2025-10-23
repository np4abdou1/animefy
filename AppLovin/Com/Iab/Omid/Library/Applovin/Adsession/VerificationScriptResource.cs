using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Net;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x0200004A RID: 74
	[Register("com/iab/omid/library/applovin/adsession/VerificationScriptResource", DoNotGenerateAcw = true)]
	public sealed class VerificationScriptResource : Java.Lang.Object
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000057A8 File Offset: 0x000039A8
		internal static IntPtr class_ref
		{
			get
			{
				return VerificationScriptResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000057CC File Offset: 0x000039CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VerificationScriptResource._members;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600020B RID: 523 RVA: 0x000057D4 File Offset: 0x000039D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VerificationScriptResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000057F8 File Offset: 0x000039F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VerificationScriptResource._members.ManagedPeerType;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000021F0 File Offset: 0x000003F0
		internal VerificationScriptResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00005804 File Offset: 0x00003A04
		public URL ResourceUrl
		{
			[Register("getResourceUrl", "()Ljava/net/URL;", "")]
			get
			{
				return Java.Lang.Object.GetObject<URL>(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getResourceUrl.()Ljava/net/URL;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00005838 File Offset: 0x00003A38
		public string VendorKey
		{
			[Register("getVendorKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getVendorKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000586C File Offset: 0x00003A6C
		public string VerificationParameters
		{
			[Register("getVerificationParameters", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getVerificationParameters.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000058A0 File Offset: 0x00003AA0
		[Register("createVerificationScriptResourceWithParameters", "(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/VerificationScriptResource;", "")]
		public unsafe static VerificationScriptResource CreateVerificationScriptResourceWithParameters(string p0, URL p1, string p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			VerificationScriptResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<VerificationScriptResource>(VerificationScriptResource._members.StaticMethods.InvokeObjectMethod("createVerificationScriptResourceWithParameters.(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/VerificationScriptResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00005958 File Offset: 0x00003B58
		[Register("createVerificationScriptResourceWithoutParameters", "(Ljava/net/URL;)Lcom/iab/omid/library/applovin/adsession/VerificationScriptResource;", "")]
		public unsafe static VerificationScriptResource CreateVerificationScriptResourceWithoutParameters(URL p0)
		{
			VerificationScriptResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<VerificationScriptResource>(VerificationScriptResource._members.StaticMethods.InvokeObjectMethod("createVerificationScriptResourceWithoutParameters.(Ljava/net/URL;)Lcom/iab/omid/library/applovin/adsession/VerificationScriptResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000056 RID: 86
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/VerificationScriptResource", typeof(VerificationScriptResource));
	}
}
