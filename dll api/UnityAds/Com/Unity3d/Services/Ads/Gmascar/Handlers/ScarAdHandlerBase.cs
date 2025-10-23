using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Com.Unity3d.Services.Ads.Gmascar.Utils;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Handlers
{
	// Token: 0x02000206 RID: 518
	[Register("com/unity3d/services/ads/gmascar/handlers/ScarAdHandlerBase", DoNotGenerateAcw = true)]
	public abstract class ScarAdHandlerBase : Java.Lang.Object, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00045A2C File Offset: 0x00043C2C
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00045A5C File Offset: 0x00043C5C
		[Register("_eventSubject")]
		protected EventSubject EventSubject
		{
			get
			{
				return Java.Lang.Object.GetObject<EventSubject>(ScarAdHandlerBase._members.InstanceFields.GetObjectValue("_eventSubject.Lcom/unity3d/services/core/misc/EventSubject;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdHandlerBase._members.InstanceFields.SetValue("_eventSubject.Lcom/unity3d/services/core/misc/EventSubject;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00045AA8 File Offset: 0x00043CA8
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00045AD8 File Offset: 0x00043CD8
		[Register("_gmaEventSender")]
		protected GMAEventSender GmaEventSender
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEventSender>(ScarAdHandlerBase._members.InstanceFields.GetObjectValue("_gmaEventSender.Lcom/unity3d/services/ads/gmascar/utils/GMAEventSender;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdHandlerBase._members.InstanceFields.SetValue("_gmaEventSender.Lcom/unity3d/services/ads/gmascar/utils/GMAEventSender;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00045B24 File Offset: 0x00043D24
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00045B54 File Offset: 0x00043D54
		[Register("_scarAdMetadata")]
		protected ScarAdMetadata ScarAdMetadata
		{
			get
			{
				return Java.Lang.Object.GetObject<ScarAdMetadata>(ScarAdHandlerBase._members.InstanceFields.GetObjectValue("_scarAdMetadata.Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdHandlerBase._members.InstanceFields.SetValue("_scarAdMetadata.Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00045BA0 File Offset: 0x00043DA0
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdHandlerBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00045BC4 File Offset: 0x00043DC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdHandlerBase._members;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00045BCC File Offset: 0x00043DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdHandlerBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00045BF0 File Offset: 0x00043DF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdHandlerBase._members.ManagedPeerType;
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdHandlerBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00045BFC File Offset: 0x00043DFC
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", "")]
		public unsafe ScarAdHandlerBase(ScarAdMetadata scarAdMetadata, EventSubject eventSubject) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScarAdHandlerBase._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarAdHandlerBase._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(scarAdMetadata);
				GC.KeepAlive(eventSubject);
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00045CD4 File Offset: 0x00043ED4
		private static Delegate GetOnAdClickedHandler()
		{
			if (ScarAdHandlerBase.cb_onAdClicked == null)
			{
				ScarAdHandlerBase.cb_onAdClicked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarAdHandlerBase.n_OnAdClicked));
			}
			return ScarAdHandlerBase.cb_onAdClicked;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00045CF8 File Offset: 0x00043EF8
		private static void n_OnAdClicked(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClicked();
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00045D07 File Offset: 0x00043F07
		[Register("onAdClicked", "()V", "GetOnAdClickedHandler")]
		public virtual void OnAdClicked()
		{
			ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdClicked.()V", this, null);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00045D20 File Offset: 0x00043F20
		private static Delegate GetOnAdClosedHandler()
		{
			if (ScarAdHandlerBase.cb_onAdClosed == null)
			{
				ScarAdHandlerBase.cb_onAdClosed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarAdHandlerBase.n_OnAdClosed));
			}
			return ScarAdHandlerBase.cb_onAdClosed;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00045D44 File Offset: 0x00043F44
		private static void n_OnAdClosed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdClosed();
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00045D53 File Offset: 0x00043F53
		[Register("onAdClosed", "()V", "GetOnAdClosedHandler")]
		public virtual void OnAdClosed()
		{
			ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdClosed.()V", this, null);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00045D6C File Offset: 0x00043F6C
		private static Delegate GetOnAdFailedToLoad_ILjava_lang_String_Handler()
		{
			if (ScarAdHandlerBase.cb_onAdFailedToLoad_ILjava_lang_String_ == null)
			{
				ScarAdHandlerBase.cb_onAdFailedToLoad_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(ScarAdHandlerBase.n_OnAdFailedToLoad_ILjava_lang_String_));
			}
			return ScarAdHandlerBase.cb_onAdFailedToLoad_ILjava_lang_String_;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00045D90 File Offset: 0x00043F90
		private static void n_OnAdFailedToLoad_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int errorCode, IntPtr native_errorString)
		{
			ScarAdHandlerBase @object = Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorString, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToLoad(errorCode, @string);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00045DB4 File Offset: 0x00043FB4
		[Register("onAdFailedToLoad", "(ILjava/lang/String;)V", "GetOnAdFailedToLoad_ILjava_lang_String_Handler")]
		public unsafe virtual void OnAdFailedToLoad(int errorCode, string errorString)
		{
			IntPtr intPtr = JNIEnv.NewString(errorString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(errorCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdFailedToLoad.(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00045E24 File Offset: 0x00044024
		private static Delegate GetOnAdLoadedHandler()
		{
			if (ScarAdHandlerBase.cb_onAdLoaded == null)
			{
				ScarAdHandlerBase.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarAdHandlerBase.n_OnAdLoaded));
			}
			return ScarAdHandlerBase.cb_onAdLoaded;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00045E48 File Offset: 0x00044048
		private static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded();
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00045E57 File Offset: 0x00044057
		[Register("onAdLoaded", "()V", "GetOnAdLoadedHandler")]
		public virtual void OnAdLoaded()
		{
			ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdLoaded.()V", this, null);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00045E70 File Offset: 0x00044070
		private static Delegate GetOnAdOpenedHandler()
		{
			if (ScarAdHandlerBase.cb_onAdOpened == null)
			{
				ScarAdHandlerBase.cb_onAdOpened = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarAdHandlerBase.n_OnAdOpened));
			}
			return ScarAdHandlerBase.cb_onAdOpened;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00045E94 File Offset: 0x00044094
		private static void n_OnAdOpened(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdOpened();
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00045EA3 File Offset: 0x000440A3
		[Register("onAdOpened", "()V", "GetOnAdOpenedHandler")]
		public virtual void OnAdOpened()
		{
			ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdOpened.()V", this, null);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00045EBC File Offset: 0x000440BC
		private static Delegate GetOnAdSkippedHandler()
		{
			if (ScarAdHandlerBase.cb_onAdSkipped == null)
			{
				ScarAdHandlerBase.cb_onAdSkipped = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarAdHandlerBase.n_OnAdSkipped));
			}
			return ScarAdHandlerBase.cb_onAdSkipped;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00045EE0 File Offset: 0x000440E0
		private static void n_OnAdSkipped(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarAdHandlerBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdSkipped();
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00045EEF File Offset: 0x000440EF
		[Register("onAdSkipped", "()V", "GetOnAdSkippedHandler")]
		public virtual void OnAdSkipped()
		{
			ScarAdHandlerBase._members.InstanceMethods.InvokeVirtualVoidMethod("onAdSkipped.()V", this, null);
		}

		// Token: 0x040005DE RID: 1502
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/ScarAdHandlerBase", typeof(ScarAdHandlerBase));

		// Token: 0x040005DF RID: 1503
		private static Delegate cb_onAdClicked;

		// Token: 0x040005E0 RID: 1504
		private static Delegate cb_onAdClosed;

		// Token: 0x040005E1 RID: 1505
		private static Delegate cb_onAdFailedToLoad_ILjava_lang_String_;

		// Token: 0x040005E2 RID: 1506
		private static Delegate cb_onAdLoaded;

		// Token: 0x040005E3 RID: 1507
		private static Delegate cb_onAdOpened;

		// Token: 0x040005E4 RID: 1508
		private static Delegate cb_onAdSkipped;
	}
}
