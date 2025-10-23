using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Handlers
{
	// Token: 0x02000208 RID: 520
	[Register("com/unity3d/services/ads/gmascar/handlers/ScarInterstitialAdHandler", DoNotGenerateAcw = true)]
	public class ScarInterstitialAdHandler : ScarAdHandlerBase, IScarInterstitialAdListenerWrapper, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00045F5C File Offset: 0x0004415C
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAdHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x00045F80 File Offset: 0x00044180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAdHandler._members;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00045F88 File Offset: 0x00044188
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAdHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00045FAC File Offset: 0x000441AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAdHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00045F23 File Offset: 0x00044123
		protected ScarInterstitialAdHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00045FB8 File Offset: 0x000441B8
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", "")]
		public unsafe ScarInterstitialAdHandler(ScarAdMetadata scarAdMetadata, EventSubject eventSubject) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				ptr[1] = new JniArgumentValue((eventSubject == null) ? IntPtr.Zero : eventSubject.Handle);
				base.SetHandle(ScarInterstitialAdHandler._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarInterstitialAdHandler._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(scarAdMetadata);
				GC.KeepAlive(eventSubject);
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00046090 File Offset: 0x00044290
		private static Delegate GetOnAdFailedToShow_ILjava_lang_String_Handler()
		{
			if (ScarInterstitialAdHandler.cb_onAdFailedToShow_ILjava_lang_String_ == null)
			{
				ScarInterstitialAdHandler.cb_onAdFailedToShow_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(ScarInterstitialAdHandler.n_OnAdFailedToShow_ILjava_lang_String_));
			}
			return ScarInterstitialAdHandler.cb_onAdFailedToShow_ILjava_lang_String_;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000460B4 File Offset: 0x000442B4
		private static void n_OnAdFailedToShow_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int errorCode, IntPtr native_errorString)
		{
			ScarInterstitialAdHandler @object = Java.Lang.Object.GetObject<ScarInterstitialAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorString, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToShow(errorCode, @string);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000460D8 File Offset: 0x000442D8
		[Register("onAdFailedToShow", "(ILjava/lang/String;)V", "GetOnAdFailedToShow_ILjava_lang_String_Handler")]
		public unsafe virtual void OnAdFailedToShow(int errorCode, string errorString)
		{
			IntPtr intPtr = JNIEnv.NewString(errorString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(errorCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ScarInterstitialAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onAdFailedToShow.(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00046148 File Offset: 0x00044348
		private static Delegate GetOnAdImpressionHandler()
		{
			if (ScarInterstitialAdHandler.cb_onAdImpression == null)
			{
				ScarInterstitialAdHandler.cb_onAdImpression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarInterstitialAdHandler.n_OnAdImpression));
			}
			return ScarInterstitialAdHandler.cb_onAdImpression;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0004616C File Offset: 0x0004436C
		private static void n_OnAdImpression(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarInterstitialAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdImpression();
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0004617B File Offset: 0x0004437B
		[Register("onAdImpression", "()V", "GetOnAdImpressionHandler")]
		public virtual void OnAdImpression()
		{
			ScarInterstitialAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onAdImpression.()V", this, null);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00046194 File Offset: 0x00044394
		private static Delegate GetOnAdLeftApplicationHandler()
		{
			if (ScarInterstitialAdHandler.cb_onAdLeftApplication == null)
			{
				ScarInterstitialAdHandler.cb_onAdLeftApplication = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarInterstitialAdHandler.n_OnAdLeftApplication));
			}
			return ScarInterstitialAdHandler.cb_onAdLeftApplication;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000461B8 File Offset: 0x000443B8
		private static void n_OnAdLeftApplication(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarInterstitialAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLeftApplication();
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000461C7 File Offset: 0x000443C7
		[Register("onAdLeftApplication", "()V", "GetOnAdLeftApplicationHandler")]
		public virtual void OnAdLeftApplication()
		{
			ScarInterstitialAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLeftApplication.()V", this, null);
		}

		// Token: 0x040005E6 RID: 1510
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/ScarInterstitialAdHandler", typeof(ScarInterstitialAdHandler));

		// Token: 0x040005E7 RID: 1511
		private static Delegate cb_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x040005E8 RID: 1512
		private static Delegate cb_onAdImpression;

		// Token: 0x040005E9 RID: 1513
		private static Delegate cb_onAdLeftApplication;
	}
}
