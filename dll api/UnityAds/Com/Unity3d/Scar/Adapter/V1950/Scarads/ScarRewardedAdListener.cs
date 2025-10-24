using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x0200027A RID: 634
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarRewardedAdListener", DoNotGenerateAcw = true)]
	public class ScarRewardedAdListener : Java.Lang.Object
	{
		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0005D7A4 File Offset: 0x0005B9A4
		internal static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0005D7C8 File Offset: 0x0005B9C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAdListener._members;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0005D7D0 File Offset: 0x0005B9D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0005D7F4 File Offset: 0x0005B9F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarRewardedAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0005D800 File Offset: 0x0005BA00
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarRewardedAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0005D824 File Offset: 0x0005BA24
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarRewardedAdListener @object = Java.Lang.Object.GetObject<ScarRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0005D848 File Offset: 0x0005BA48
		[Register("setLoadListener", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", "GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler")]
		public unsafe virtual void SetLoadListener(IScarLoadListener loadListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadListener == null) ? IntPtr.Zero : ((Java.Lang.Object)loadListener).Handle);
				ScarRewardedAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("setLoadListener.(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadListener);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600239B RID: 9115 RVA: 0x0005D8B0 File Offset: 0x0005BAB0
		// (remove) Token: 0x0600239C RID: 9116 RVA: 0x0005D8FC File Offset: 0x0005BAFC
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

		// Token: 0x0600239D RID: 9117 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x04000728 RID: 1832
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarRewardedAdListener", typeof(ScarRewardedAdListener));

		// Token: 0x04000729 RID: 1833
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x0400072A RID: 1834
		private WeakReference weak_implementor_SetLoadListener;
	}
}
