using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000.Scarads
{
	// Token: 0x0200025F RID: 607
	[Register("com/unity3d/scar/adapter/v2000/scarads/ScarAdListener", DoNotGenerateAcw = true)]
	public class ScarAdListener : Java.Lang.Object
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x000593B4 File Offset: 0x000575B4
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x000593E4 File Offset: 0x000575E4
		[Register("_loadListener")]
		protected IScarLoadListener LoadListener
		{
			get
			{
				return Java.Lang.Object.GetObject<IScarLoadListener>(ScarAdListener._members.InstanceFields.GetObjectValue("_loadListener.Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScarAdListener._members.InstanceFields.SetValue("_loadListener.Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00059430 File Offset: 0x00057630
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00059454 File Offset: 0x00057654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdListener._members;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0005945C File Offset: 0x0005765C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00059480 File Offset: 0x00057680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0005948C File Offset: 0x0005768C
		[Register(".ctor", "()V", "")]
		public ScarAdListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ScarAdListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ScarAdListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000594FA File Offset: 0x000576FA
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00059520 File Offset: 0x00057720
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdListener @object = Java.Lang.Object.GetObject<ScarAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00059544 File Offset: 0x00057744
		[Register("setLoadListener", "(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", "GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler")]
		public unsafe virtual void SetLoadListener(IScarLoadListener loadListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadListener == null) ? IntPtr.Zero : ((Java.Lang.Object)loadListener).Handle);
				ScarAdListener._members.InstanceMethods.InvokeVirtualVoidMethod("setLoadListener.(Lcom/unity3d/scar/adapter/common/scarads/IScarLoadListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadListener);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06002101 RID: 8449 RVA: 0x000595AC File Offset: 0x000577AC
		// (remove) Token: 0x06002102 RID: 8450 RVA: 0x000595F8 File Offset: 0x000577F8
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

		// Token: 0x06002103 RID: 8451 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x040006FD RID: 1789
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/scarads/ScarAdListener", typeof(ScarAdListener));

		// Token: 0x040006FE RID: 1790
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040006FF RID: 1791
		private WeakReference weak_implementor_SetLoadListener;
	}
}
