using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Net;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000035 RID: 53
	[Register("com/iab/omid/library/adcolony/adsession/VerificationScriptResource", DoNotGenerateAcw = true)]
	public sealed class VerificationScriptResource : Java.Lang.Object
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000056E0 File Offset: 0x000038E0
		internal static IntPtr class_ref
		{
			get
			{
				return VerificationScriptResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00005704 File Offset: 0x00003904
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
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000570C File Offset: 0x0000390C
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
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00005730 File Offset: 0x00003930
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VerificationScriptResource._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002128 File Offset: 0x00000328
		internal VerificationScriptResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000573C File Offset: 0x0000393C
		public URL ResourceUrl
		{
			[Register("getResourceUrl", "()Ljava/net/URL;", "")]
			get
			{
				return Java.Lang.Object.GetObject<URL>(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getResourceUrl.()Ljava/net/URL;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005770 File Offset: 0x00003970
		public string VendorKey
		{
			[Register("getVendorKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getVendorKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000057A4 File Offset: 0x000039A4
		public string VerificationParameters
		{
			[Register("getVerificationParameters", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(VerificationScriptResource._members.InstanceMethods.InvokeAbstractObjectMethod("getVerificationParameters.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000057D8 File Offset: 0x000039D8
		[Register("createVerificationScriptResourceWithParameters", "(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/VerificationScriptResource;", "")]
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
				@object = Java.Lang.Object.GetObject<VerificationScriptResource>(VerificationScriptResource._members.StaticMethods.InvokeObjectMethod("createVerificationScriptResourceWithParameters.(Ljava/lang/String;Ljava/net/URL;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/VerificationScriptResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005890 File Offset: 0x00003A90
		[Register("createVerificationScriptResourceWithoutParameters", "(Ljava/net/URL;)Lcom/iab/omid/library/adcolony/adsession/VerificationScriptResource;", "")]
		public unsafe static VerificationScriptResource CreateVerificationScriptResourceWithoutParameters(URL p0)
		{
			VerificationScriptResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<VerificationScriptResource>(VerificationScriptResource._members.StaticMethods.InvokeObjectMethod("createVerificationScriptResourceWithoutParameters.(Ljava/net/URL;)Lcom/iab/omid/library/adcolony/adsession/VerificationScriptResource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000053 RID: 83
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/VerificationScriptResource", typeof(VerificationScriptResource));
	}
}
