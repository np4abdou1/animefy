using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Webkit;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x0200003E RID: 62
	[Register("com/iab/omid/library/applovin/adsession/AdSessionContext", DoNotGenerateAcw = true)]
	public sealed class AdSessionContext : Java.Lang.Object
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000042DC File Offset: 0x000024DC
		internal static IntPtr class_ref
		{
			get
			{
				return AdSessionContext._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00004300 File Offset: 0x00002500
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
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00004308 File Offset: 0x00002508
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
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000432C File Offset: 0x0000252C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdSessionContext._members.ManagedPeerType;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000021F0 File Offset: 0x000003F0
		internal AdSessionContext(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00004338 File Offset: 0x00002538
		public AdSessionContextType AdSessionContextType
		{
			[Register("getAdSessionContextType", "()Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdSessionContextType>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getAdSessionContextType.()Lcom/iab/omid/library/applovin/adsession/AdSessionContextType;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000436C File Offset: 0x0000256C
		public string ContentUrl
		{
			[Register("getContentUrl", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getContentUrl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000043A0 File Offset: 0x000025A0
		public string CustomReferenceData
		{
			[Register("getCustomReferenceData", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getCustomReferenceData.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000043D4 File Offset: 0x000025D4
		public IDictionary<string, VerificationScriptResource> InjectedResourcesMap
		{
			[Register("getInjectedResourcesMap", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, VerificationScriptResource>.FromJniHandle(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getInjectedResourcesMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00004408 File Offset: 0x00002608
		public string OmidJsScriptContent
		{
			[Register("getOmidJsScriptContent", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getOmidJsScriptContent.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000443C File Offset: 0x0000263C
		public Partner Partner
		{
			[Register("getPartner", "()Lcom/iab/omid/library/applovin/adsession/Partner;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Partner>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getPartner.()Lcom/iab/omid/library/applovin/adsession/Partner;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00004470 File Offset: 0x00002670
		public IList<VerificationScriptResource> VerificationScriptResources
		{
			[Register("getVerificationScriptResources", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<VerificationScriptResource>.FromJniHandle(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getVerificationScriptResources.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000044A4 File Offset: 0x000026A4
		public WebView WebView
		{
			[Register("getWebView", "()Landroid/webkit/WebView;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WebView>(AdSessionContext._members.InstanceMethods.InvokeAbstractObjectMethod("getWebView.()Landroid/webkit/WebView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000044D8 File Offset: 0x000026D8
		[Register("createHtmlAdSessionContext", "(Lcom/iab/omid/library/applovin/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", "")]
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
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createHtmlAdSessionContext.(Lcom/iab/omid/library/applovin/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600019D RID: 413 RVA: 0x000045BC File Offset: 0x000027BC
		[Register("createJavascriptAdSessionContext", "(Lcom/iab/omid/library/applovin/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", "")]
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
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createJavascriptAdSessionContext.(Lcom/iab/omid/library/applovin/adsession/Partner;Landroid/webkit/WebView;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x0600019E RID: 414 RVA: 0x000046A0 File Offset: 0x000028A0
		[Register("createNativeAdSessionContext", "(Lcom/iab/omid/library/applovin/adsession/Partner;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", "")]
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
				@object = Java.Lang.Object.GetObject<AdSessionContext>(AdSessionContext._members.StaticMethods.InvokeObjectMethod("createNativeAdSessionContext.(Lcom/iab/omid/library/applovin/adsession/Partner;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;)Lcom/iab/omid/library/applovin/adsession/AdSessionContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x04000044 RID: 68
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/AdSessionContext", typeof(AdSessionContext));
	}
}
