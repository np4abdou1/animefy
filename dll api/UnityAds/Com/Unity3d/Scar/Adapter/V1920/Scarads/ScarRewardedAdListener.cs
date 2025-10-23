using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x02000292 RID: 658
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarRewardedAdListener", DoNotGenerateAcw = true)]
	public class ScarRewardedAdListener : Java.Lang.Object
	{
		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00061068 File Offset: 0x0005F268
		internal static IntPtr class_ref
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0006108C File Offset: 0x0005F28C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarRewardedAdListener._members;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00061094 File Offset: 0x0005F294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarRewardedAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x000610B8 File Offset: 0x0005F2B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarRewardedAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarRewardedAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000610C4 File Offset: 0x0005F2C4
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarRewardedAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarRewardedAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000610E8 File Offset: 0x0005F2E8
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarRewardedAdListener @object = Java.Lang.Object.GetObject<ScarRewardedAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0006110C File Offset: 0x0005F30C
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

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060025BF RID: 9663 RVA: 0x00061174 File Offset: 0x0005F374
		// (remove) Token: 0x060025C0 RID: 9664 RVA: 0x000611C0 File Offset: 0x0005F3C0
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

		// Token: 0x060025C1 RID: 9665 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x04000750 RID: 1872
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarRewardedAdListener", typeof(ScarRewardedAdListener));

		// Token: 0x04000751 RID: 1873
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x04000752 RID: 1874
		private WeakReference weak_implementor_SetLoadListener;
	}
}
