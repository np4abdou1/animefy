using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x0200028E RID: 654
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarInterstitialAdListener", DoNotGenerateAcw = true)]
	public class ScarInterstitialAdListener : Java.Lang.Object
	{
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x00060D34 File Offset: 0x0005EF34
		internal static IntPtr class_ref
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x00060D58 File Offset: 0x0005EF58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarInterstitialAdListener._members;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x00060D60 File Offset: 0x0005EF60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarInterstitialAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x00060D84 File Offset: 0x0005EF84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarInterstitialAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarInterstitialAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00060D90 File Offset: 0x0005EF90
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarInterstitialAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarInterstitialAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00060DB4 File Offset: 0x0005EFB4
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarInterstitialAdListener @object = Java.Lang.Object.GetObject<ScarInterstitialAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00060DD8 File Offset: 0x0005EFD8
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

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060025A5 RID: 9637 RVA: 0x00060E40 File Offset: 0x0005F040
		// (remove) Token: 0x060025A6 RID: 9638 RVA: 0x00060E8C File Offset: 0x0005F08C
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

		// Token: 0x060025A7 RID: 9639 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x04000748 RID: 1864
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarInterstitialAdListener", typeof(ScarInterstitialAdListener));

		// Token: 0x04000749 RID: 1865
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x0400074A RID: 1866
		private WeakReference weak_implementor_SetLoadListener;
	}
}
