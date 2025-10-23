using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Webkit;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000029 RID: 41
	[Register("com/iab/omid/library/adcolony/adsession/AdSessionContext", DoNotGenerateAcw = true)]
	public sealed class AdSessionContext : Java.Lang.Object
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00004214 File Offset: 0x00002414
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004238 File Offset: 0x00002438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdSessionContext._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00004240 File Offset: 0x00002440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdSessionContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00004264 File Offset: 0x00002464
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionContext._members.ManagedPeerType;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002128 File Offset: 0x00000328
		internal AdSessionContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00004270 File Offset: 0x00002470
		public AdSessionContextType AdSessionContextType
		{
			[Register("getAdSessionContextType", "()Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionContextType.()Lcom/iab/omid/library/adcolony/adsession/AdSessionContextType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000042A4 File Offset: 0x000024A4
		public string ContentUrl
		{
			[Register("getContentUrl", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getContentUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000042D8 File Offset: 0x000024D8
		public string CustomReferenceData
		{
			[Register("getCustomReferenceData", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getCustomReferenceData.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000430C File Offset: 0x0000250C
		public IDictionary<string, VerificationScriptResource> InjectedResourcesMap
		{
			[Register("getInjectedResourcesMap", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, VerificationScriptResource>.FromJniHandle(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getInjectedResourcesMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00004340 File Offset: 0x00002540
		public string OmidJsScriptContent
		{
			[Register("getOmidJsScriptContent", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getOmidJsScriptContent.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00004374 File Offset: 0x00002574
		public Partner Partner
		{
			[Register("getPartner", "()Lcom/iab/omid/library/adcolony/adsession/Partner;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Partner>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getPartner.()Lcom/iab/omid/library/adcolony/adsession/Partner;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000043A8 File Offset: 0x000025A8
		public IList<VerificationScriptResource> VerificationScriptResources
		{
			[Register("getVerificationScriptResources", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<VerificationScriptResource>.FromJniHandle(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getVerificationScriptResources.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000043DC File Offset: 0x000025DC
		public WebView WebView
		{
			[Register("getWebView", "()Landroid/webkit/WebView;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebView>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getWebView.()Landroid/webkit/WebView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004410 File Offset: 0x00002610
		[Register("createHtmlAdSessionContext", "(Lcom/iab/omid/library/adcolony/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", "")]
		public unsafe static AdSessionContext CreateHtmlAdSessionContext(Partner p0, WebView p1, string p2, string p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			IntPtr intPtr2 = JNIEnv.NewString(p3);
			AdSessionContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createHtmlAdSessionContext.(Lcom/iab/omid/library/adcolony/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000044F4 File Offset: 0x000026F4
		[Register("createJavascriptAdSessionContext", "(Lcom/iab/omid/library/adcolony/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", "")]
		public unsafe static AdSessionContext CreateJavascriptAdSessionContext(Partner p0, WebView p1, string p2, string p3)
		{
			IntPtr intPtr = JNIEnv.NewString(p2);
			IntPtr intPtr2 = JNIEnv.NewString(p3);
			AdSessionContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createJavascriptAdSessionContext.(Lcom/iab/omid/library/adcolony/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000045D8 File Offset: 0x000027D8
		[Register("createNativeAdSessionContext", "(Lcom/iab/omid/library/adcolony/adsession/Partner;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", "")]
		public unsafe static AdSessionContext CreateNativeAdSessionContext(Partner p0, string p1, IList<VerificationScriptResource> p2, string p3, string p4)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IntPtr intPtr2 = JavaList<VerificationScriptResource>.ToLocalJniHandle(p2);
			IntPtr intPtr3 = JNIEnv.NewString(p3);
			IntPtr intPtr4 = JNIEnv.NewString(p4);
			AdSessionContext @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createNativeAdSessionContext.(Lcom/iab/omid/library/adcolony/adsession/Partner;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/adcolony/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x04000041 RID: 65
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/AdSessionContext", typeof(AdSessionContext));
	}
}
