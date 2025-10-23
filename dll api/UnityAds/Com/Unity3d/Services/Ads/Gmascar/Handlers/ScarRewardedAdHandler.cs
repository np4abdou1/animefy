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
	// Token: 0x02000209 RID: 521
	[Register("com/unity3d/services/ads/gmascar/handlers/ScarRewardedAdHandler", DoNotGenerateAcw = true)]
	public class ScarRewardedAdHandler : ScarAdHandlerBase, IScarRewardedAdListenerWrapper, IScarAdListenerWrapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x000461FC File Offset: 0x000443FC
		internal new static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAdHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00046220 File Offset: 0x00044420
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAdHandler._members;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00046228 File Offset: 0x00044428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAdHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x0004624C File Offset: 0x0004444C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAdHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00045F23 File Offset: 0x00044123
		protected ScarRewardedAdHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00046258 File Offset: 0x00044458
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", "")]
		public unsafe ScarRewardedAdHandler(ScarAdMetadata scarAdMetadata, EventSubject eventSubject) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScarRewardedAdHandler._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScarRewardedAdHandler._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Lcom/unity3d/services/core/misc/EventSubject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(scarAdMetadata);
				GC.KeepAlive(eventSubject);
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00046330 File Offset: 0x00044530
		private static Delegate GetOnAdFailedToShow_ILjava_lang_String_Handler()
		{
			if (ScarRewardedAdHandler.cb_onAdFailedToShow_ILjava_lang_String_ == null)
			{
				ScarRewardedAdHandler.cb_onAdFailedToShow_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(ScarRewardedAdHandler.n_OnAdFailedToShow_ILjava_lang_String_));
			}
			return ScarRewardedAdHandler.cb_onAdFailedToShow_ILjava_lang_String_;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00046354 File Offset: 0x00044554
		private static void n_OnAdFailedToShow_ILjava_lang_String_(IntPtr jnienv, IntPtr native__this, int errorCode, IntPtr native_errorString)
		{
			ScarRewardedAdHandler @object = Java.Lang.Object.GetObject<ScarRewardedAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorString, JniHandleOwnership.DoNotTransfer);
			@object.OnAdFailedToShow(errorCode, @string);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00046378 File Offset: 0x00044578
		[Register("onAdFailedToShow", "(ILjava/lang/String;)V", "GetOnAdFailedToShow_ILjava_lang_String_Handler")]
		public unsafe virtual void OnAdFailedToShow(int errorCode, string errorString)
		{
			IntPtr intPtr = JNIEnv.NewString(errorString);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(errorCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ScarRewardedAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onAdFailedToShow.(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000463E8 File Offset: 0x000445E8
		private static Delegate GetOnAdImpressionHandler()
		{
			if (ScarRewardedAdHandler.cb_onAdImpression == null)
			{
				ScarRewardedAdHandler.cb_onAdImpression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarRewardedAdHandler.n_OnAdImpression));
			}
			return ScarRewardedAdHandler.cb_onAdImpression;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0004640C File Offset: 0x0004460C
		private static void n_OnAdImpression(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarRewardedAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdImpression();
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0004641B File Offset: 0x0004461B
		[Register("onAdImpression", "()V", "GetOnAdImpressionHandler")]
		public virtual void OnAdImpression()
		{
			ScarRewardedAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onAdImpression.()V", this, null);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00046434 File Offset: 0x00044634
		private static Delegate GetOnUserEarnedRewardHandler()
		{
			if (ScarRewardedAdHandler.cb_onUserEarnedReward == null)
			{
				ScarRewardedAdHandler.cb_onUserEarnedReward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScarRewardedAdHandler.n_OnUserEarnedReward));
			}
			return ScarRewardedAdHandler.cb_onUserEarnedReward;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00046458 File Offset: 0x00044658
		private static void n_OnUserEarnedReward(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScarRewardedAdHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnUserEarnedReward();
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00046467 File Offset: 0x00044667
		[Register("onUserEarnedReward", "()V", "GetOnUserEarnedRewardHandler")]
		public virtual void OnUserEarnedReward()
		{
			ScarRewardedAdHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onUserEarnedReward.()V", this, null);
		}

		// Token: 0x040005EA RID: 1514
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/ScarRewardedAdHandler", typeof(ScarRewardedAdHandler));

		// Token: 0x040005EB RID: 1515
		private static Delegate cb_onAdFailedToShow_ILjava_lang_String_;

		// Token: 0x040005EC RID: 1516
		private static Delegate cb_onAdImpression;

		// Token: 0x040005ED RID: 1517
		private static Delegate cb_onUserEarnedReward;
	}
}
