using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Adview
{
	// Token: 0x0200015F RID: 351
	[Register("com/applovin/impl/adview/AppLovinRewardedInterstitialAd", DoNotGenerateAcw = true)]
	public class AppLovinRewardedInterstitialAd : Java.Lang.Object
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x00032198 File Offset: 0x00030398
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinRewardedInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x000321BC File Offset: 0x000303BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinRewardedInterstitialAd._members;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x000321C4 File Offset: 0x000303C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinRewardedInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x000321E8 File Offset: 0x000303E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinRewardedInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinRewardedInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000321F4 File Offset: 0x000303F4
		[Register(".ctor", "(Lcom/applovin/sdk/AppLovinSdk;)V", "")]
		public unsafe AppLovinRewardedInterstitialAd(AppLovinSdk p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinRewardedInterstitialAd._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinRewardedInterstitialAd._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/sdk/AppLovinSdk;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000322A4 File Offset: 0x000304A4
		private static Delegate GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler()
		{
			if (AppLovinRewardedInterstitialAd.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ == null)
			{
				AppLovinRewardedInterstitialAd.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinRewardedInterstitialAd.n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_));
			}
			return AppLovinRewardedInterstitialAd.cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000322C8 File Offset: 0x000304C8
		private static void n_SetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinRewardedInterstitialAd @object = Java.Lang.Object.GetObject<AppLovinRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdClickListener object2 = Java.Lang.Object.GetObject<IAppLovinAdClickListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdClickListener(object2);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000322EC File Offset: 0x000304EC
		[Register("setAdClickListener", "(Lcom/applovin/sdk/AppLovinAdClickListener;)V", "GetSetAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_Handler")]
		public unsafe virtual void SetAdClickListener(IAppLovinAdClickListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdClickListener.(Lcom/applovin/sdk/AppLovinAdClickListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00032354 File Offset: 0x00030554
		private static Delegate GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler()
		{
			if (AppLovinRewardedInterstitialAd.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ == null)
			{
				AppLovinRewardedInterstitialAd.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinRewardedInterstitialAd.n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_));
			}
			return AppLovinRewardedInterstitialAd.cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00032378 File Offset: 0x00030578
		private static void n_SetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinRewardedInterstitialAd @object = Java.Lang.Object.GetObject<AppLovinRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdDisplayListener object2 = Java.Lang.Object.GetObject<IAppLovinAdDisplayListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdDisplayListener(object2);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0003239C File Offset: 0x0003059C
		[Register("setAdDisplayListener", "(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", "GetSetAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_Handler")]
		public unsafe virtual void SetAdDisplayListener(IAppLovinAdDisplayListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdDisplayListener.(Lcom/applovin/sdk/AppLovinAdDisplayListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00032404 File Offset: 0x00030604
		private static Delegate GetSetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler()
		{
			if (AppLovinRewardedInterstitialAd.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ == null)
			{
				AppLovinRewardedInterstitialAd.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinRewardedInterstitialAd.n_SetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_));
			}
			return AppLovinRewardedInterstitialAd.cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00032428 File Offset: 0x00030628
		private static void n_SetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinRewardedInterstitialAd @object = Java.Lang.Object.GetObject<AppLovinRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdVideoPlaybackListener object2 = Java.Lang.Object.GetObject<IAppLovinAdVideoPlaybackListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetAdVideoPlaybackListener(object2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0003244C File Offset: 0x0003064C
		[Register("setAdVideoPlaybackListener", "(Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V", "GetSetAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_Handler")]
		public unsafe virtual void SetAdVideoPlaybackListener(IAppLovinAdVideoPlaybackListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("setAdVideoPlaybackListener.(Lcom/applovin/sdk/AppLovinAdVideoPlaybackListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000324B4 File Offset: 0x000306B4
		private static Delegate GetShow_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Handler()
		{
			if (AppLovinRewardedInterstitialAd.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_ == null)
			{
				AppLovinRewardedInterstitialAd.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(AppLovinRewardedInterstitialAd.n_Show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_));
			}
			return AppLovinRewardedInterstitialAd.cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000324D8 File Offset: 0x000306D8
		private static void n_Show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			AppLovinRewardedInterstitialAd @object = Java.Lang.Object.GetObject<AppLovinRewardedInterstitialAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IAppLovinAd object2 = Java.Lang.Object.GetObject<IAppLovinAd>(native_p0, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_p1, JniHandleOwnership.DoNotTransfer);
			IAppLovinAdRewardListener object4 = Java.Lang.Object.GetObject<IAppLovinAdRewardListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.Show(object2, object3, object4);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00032510 File Offset: 0x00030710
		[Register("show", "(Lcom/applovin/sdk/AppLovinAd;Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;)V", "GetShow_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_Handler")]
		public unsafe virtual void Show(IAppLovinAd p0, Context p1, IAppLovinAdRewardListener p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				AppLovinRewardedInterstitialAd._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Lcom/applovin/sdk/AppLovinAd;Landroid/content/Context;Lcom/applovin/sdk/AppLovinAdRewardListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600116B RID: 4459 RVA: 0x000325D0 File Offset: 0x000307D0
		// (remove) Token: 0x0600116C RID: 4460 RVA: 0x0003261C File Offset: 0x0003081C
		public event EventHandler<AppLovinAdClickEventArgs> AdClick
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdClickListener, IAppLovinAdClickListenerImplementor>(ref this.weak_implementor_SetAdClickListener, new Func<IAppLovinAdClickListenerImplementor>(this.__CreateIAppLovinAdClickListenerImplementor), new Action<IAppLovinAdClickListener>(this.SetAdClickListener), delegate(IAppLovinAdClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinAdClickEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdClickListener, IAppLovinAdClickListenerImplementor>(ref this.weak_implementor_SetAdClickListener, new Func<IAppLovinAdClickListenerImplementor, bool>(IAppLovinAdClickListenerImplementor.__IsEmpty), delegate(IAppLovinAdClickListener __v)
				{
					this.SetAdClickListener(null);
				}, delegate(IAppLovinAdClickListenerImplementor __h)
				{
					__h.Handler = (EventHandler<AppLovinAdClickEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0003266C File Offset: 0x0003086C
		private IAppLovinAdClickListenerImplementor __CreateIAppLovinAdClickListenerImplementor()
		{
			return new IAppLovinAdClickListenerImplementor(this);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600116E RID: 4462 RVA: 0x00032674 File Offset: 0x00030874
		// (remove) Token: 0x0600116F RID: 4463 RVA: 0x000326C0 File Offset: 0x000308C0
		public event EventHandler<AdDisplayedEventArgs> AdDisplayed
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor>(this.__CreateIAppLovinAdDisplayListenerImplementor), new Action<IAppLovinAdDisplayListener>(this.SetAdDisplayListener), delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdDisplayedHandler = (EventHandler<AdDisplayedEventArgs>)Delegate.Combine(__h.AdDisplayedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor, bool>(IAppLovinAdDisplayListenerImplementor.__IsEmpty), delegate(IAppLovinAdDisplayListener __v)
				{
					this.SetAdDisplayListener(null);
				}, delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdDisplayedHandler = (EventHandler<AdDisplayedEventArgs>)Delegate.Remove(__h.AdDisplayedHandler, value);
				});
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001170 RID: 4464 RVA: 0x00032710 File Offset: 0x00030910
		// (remove) Token: 0x06001171 RID: 4465 RVA: 0x0003275C File Offset: 0x0003095C
		public event EventHandler<AdHiddenEventArgs> AdHidden
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor>(this.__CreateIAppLovinAdDisplayListenerImplementor), new Action<IAppLovinAdDisplayListener>(this.SetAdDisplayListener), delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdHiddenHandler = (EventHandler<AdHiddenEventArgs>)Delegate.Combine(__h.AdHiddenHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdDisplayListener, IAppLovinAdDisplayListenerImplementor>(ref this.weak_implementor_SetAdDisplayListener, new Func<IAppLovinAdDisplayListenerImplementor, bool>(IAppLovinAdDisplayListenerImplementor.__IsEmpty), delegate(IAppLovinAdDisplayListener __v)
				{
					this.SetAdDisplayListener(null);
				}, delegate(IAppLovinAdDisplayListenerImplementor __h)
				{
					__h.AdHiddenHandler = (EventHandler<AdHiddenEventArgs>)Delegate.Remove(__h.AdHiddenHandler, value);
				});
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000327AC File Offset: 0x000309AC
		private IAppLovinAdDisplayListenerImplementor __CreateIAppLovinAdDisplayListenerImplementor()
		{
			return new IAppLovinAdDisplayListenerImplementor(this);
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001173 RID: 4467 RVA: 0x000327B4 File Offset: 0x000309B4
		// (remove) Token: 0x06001174 RID: 4468 RVA: 0x00032800 File Offset: 0x00030A00
		public event EventHandler<VideoPlaybackBeganEventArgs> VideoPlaybackBegan
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdVideoPlaybackListener, IAppLovinAdVideoPlaybackListenerImplementor>(ref this.weak_implementor_SetAdVideoPlaybackListener, new Func<IAppLovinAdVideoPlaybackListenerImplementor>(this.__CreateIAppLovinAdVideoPlaybackListenerImplementor), new Action<IAppLovinAdVideoPlaybackListener>(this.SetAdVideoPlaybackListener), delegate(IAppLovinAdVideoPlaybackListenerImplementor __h)
				{
					__h.VideoPlaybackBeganHandler = (EventHandler<VideoPlaybackBeganEventArgs>)Delegate.Combine(__h.VideoPlaybackBeganHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdVideoPlaybackListener, IAppLovinAdVideoPlaybackListenerImplementor>(ref this.weak_implementor_SetAdVideoPlaybackListener, new Func<IAppLovinAdVideoPlaybackListenerImplementor, bool>(IAppLovinAdVideoPlaybackListenerImplementor.__IsEmpty), delegate(IAppLovinAdVideoPlaybackListener __v)
				{
					this.SetAdVideoPlaybackListener(null);
				}, delegate(IAppLovinAdVideoPlaybackListenerImplementor __h)
				{
					__h.VideoPlaybackBeganHandler = (EventHandler<VideoPlaybackBeganEventArgs>)Delegate.Remove(__h.VideoPlaybackBeganHandler, value);
				});
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001175 RID: 4469 RVA: 0x00032850 File Offset: 0x00030A50
		// (remove) Token: 0x06001176 RID: 4470 RVA: 0x0003289C File Offset: 0x00030A9C
		public event EventHandler<VideoPlaybackEndedEventArgs> VideoPlaybackEnded
		{
			add
			{
				EventHelper.AddEventHandler<IAppLovinAdVideoPlaybackListener, IAppLovinAdVideoPlaybackListenerImplementor>(ref this.weak_implementor_SetAdVideoPlaybackListener, new Func<IAppLovinAdVideoPlaybackListenerImplementor>(this.__CreateIAppLovinAdVideoPlaybackListenerImplementor), new Action<IAppLovinAdVideoPlaybackListener>(this.SetAdVideoPlaybackListener), delegate(IAppLovinAdVideoPlaybackListenerImplementor __h)
				{
					__h.VideoPlaybackEndedHandler = (EventHandler<VideoPlaybackEndedEventArgs>)Delegate.Combine(__h.VideoPlaybackEndedHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IAppLovinAdVideoPlaybackListener, IAppLovinAdVideoPlaybackListenerImplementor>(ref this.weak_implementor_SetAdVideoPlaybackListener, new Func<IAppLovinAdVideoPlaybackListenerImplementor, bool>(IAppLovinAdVideoPlaybackListenerImplementor.__IsEmpty), delegate(IAppLovinAdVideoPlaybackListener __v)
				{
					this.SetAdVideoPlaybackListener(null);
				}, delegate(IAppLovinAdVideoPlaybackListenerImplementor __h)
				{
					__h.VideoPlaybackEndedHandler = (EventHandler<VideoPlaybackEndedEventArgs>)Delegate.Remove(__h.VideoPlaybackEndedHandler, value);
				});
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000328EC File Offset: 0x00030AEC
		private IAppLovinAdVideoPlaybackListenerImplementor __CreateIAppLovinAdVideoPlaybackListenerImplementor()
		{
			return new IAppLovinAdVideoPlaybackListenerImplementor(this);
		}

		// Token: 0x040005AD RID: 1453
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/AppLovinRewardedInterstitialAd", typeof(AppLovinRewardedInterstitialAd));

		// Token: 0x040005AE RID: 1454
		private static Delegate cb_setAdClickListener_Lcom_applovin_sdk_AppLovinAdClickListener_;

		// Token: 0x040005AF RID: 1455
		private static Delegate cb_setAdDisplayListener_Lcom_applovin_sdk_AppLovinAdDisplayListener_;

		// Token: 0x040005B0 RID: 1456
		private static Delegate cb_setAdVideoPlaybackListener_Lcom_applovin_sdk_AppLovinAdVideoPlaybackListener_;

		// Token: 0x040005B1 RID: 1457
		private static Delegate cb_show_Lcom_applovin_sdk_AppLovinAd_Landroid_content_Context_Lcom_applovin_sdk_AppLovinAdRewardListener_;

		// Token: 0x040005B2 RID: 1458
		private WeakReference weak_implementor_SetAdClickListener;

		// Token: 0x040005B3 RID: 1459
		private WeakReference weak_implementor_SetAdDisplayListener;

		// Token: 0x040005B4 RID: 1460
		private WeakReference weak_implementor_SetAdVideoPlaybackListener;
	}
}
