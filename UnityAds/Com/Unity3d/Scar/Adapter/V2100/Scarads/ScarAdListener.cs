using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100.Scarads
{
	// Token: 0x02000248 RID: 584
	[Register("com/unity3d/scar/adapter/v2100/scarads/ScarAdListener", DoNotGenerateAcw = true)]
	public class ScarAdListener : Java.Lang.Object
	{
		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x00055148 File Offset: 0x00053348
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x00055178 File Offset: 0x00053378
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

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x000551C4 File Offset: 0x000533C4
		internal static IntPtr class_ref
		{
			get
			{
				return ScarAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000551E8 File Offset: 0x000533E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdListener._members;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x000551F0 File Offset: 0x000533F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScarAdListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00055214 File Offset: 0x00053414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ScarAdListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00055220 File Offset: 0x00053420
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

		// Token: 0x06001E76 RID: 7798 RVA: 0x0005528E File Offset: 0x0005348E
		private static Delegate GetSetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_Handler()
		{
			if (ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ == null)
			{
				ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScarAdListener.n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_));
			}
			return ScarAdListener.cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000552B4 File Offset: 0x000534B4
		private static void n_SetLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_loadListener)
		{
			ScarAdListener @object = Java.Lang.Object.GetObject<ScarAdListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IScarLoadListener object2 = Java.Lang.Object.GetObject<IScarLoadListener>(native_loadListener, JniHandleOwnership.DoNotTransfer);
			@object.SetLoadListener(object2);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x000552D8 File Offset: 0x000534D8
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

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001E79 RID: 7801 RVA: 0x00055340 File Offset: 0x00053540
		// (remove) Token: 0x06001E7A RID: 7802 RVA: 0x0005538C File Offset: 0x0005358C
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

		// Token: 0x06001E7B RID: 7803 RVA: 0x000553DC File Offset: 0x000535DC
		private IScarLoadListenerImplementor __CreateIScarLoadListenerImplementor()
		{
			return new IScarLoadListenerImplementor(this);
		}

		// Token: 0x040006DA RID: 1754
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/scarads/ScarAdListener", typeof(ScarAdListener));

		// Token: 0x040006DB RID: 1755
		private static Delegate cb_setLoadListener_Lcom_unity3d_scar_adapter_common_scarads_IScarLoadListener_;

		// Token: 0x040006DC RID: 1756
		private WeakReference weak_implementor_SetLoadListener;
	}
}
