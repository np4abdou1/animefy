using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x02000276 RID: 630
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarInterstitialAdListener", DoNotGenerateAcw = true)]
	public class ScarInterstitialAdListener : Java.Lang.Object
	{
		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0005D470 File Offset: 0x0005B670
		internal static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0005D494 File Offset: 0x0005B694
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAdListener._members;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0005D49C File Offset: 0x0005B69C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarInterstitialAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0005D4CC File Offset: 0x0005B6CC
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarInterstitialAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0005D4F0 File Offset: 0x0005B6F0
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarInterstitialAdListener @object = Java.Lang.Object.GetObject<ScarInterstitialAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0005D514 File Offset: 0x0005B714
		[Register("setLoadListener", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", "GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler")]
		public unsafe virtual void SetLoadListener(IScarLoadListener loadListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadListener == null) ? IntPtr.Zero : ((Java.Lang.Object)loadListener).Handle);
				ScarInterstitialAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("setLoadListener.(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadListener);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06002381 RID: 9089 RVA: 0x0005D57C File Offset: 0x0005B77C
		// (remove) Token: 0x06002382 RID: 9090 RVA: 0x0005D5C8 File Offset: 0x0005B7C8
		public event EventHandler Load
		{
			add
			{
				EventHelper.AddEventHandler<IScarLoadListener, IScarLoadListenerImplementor>(ref this.weak_implementor_SetLoadListener, new Func<IScarLoadListenerImplementor>(this.__CreateIScarLoadListenerImplementor), new Action<IScarLoadListener>(this.SetLoadListener), delegate(IScarLoadListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IScarLoadListener, IScarLoadListenerImplementor>(ref this.weak_implementor_SetLoadListener, new Func<IScarLoadListenerImplementor, bool>(IScarLoadListenerImplementor.__IsEmpty), delegate(IScarLoadListener __v)
				{
					this.SetLoadListener(null);
				}, delegate(IScarLoadListenerImplementor __h)
				{
					__h.Handler = (EventHandler)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x04000720 RID: 1824
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarInterstitialAdListener", typeof(ScarInterstitialAdListener));

		// Token: 0x04000721 RID: 1825
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x04000722 RID: 1826
		private WeakReference weak_implementor_SetLoadListener;
	}
}
