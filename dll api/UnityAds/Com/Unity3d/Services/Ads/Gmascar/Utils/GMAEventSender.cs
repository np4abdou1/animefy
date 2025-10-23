using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Utils
{
	// Token: 0x02000201 RID: 513
	[Register("com/unity3d/services/ads/gmascar/utils/GMAEventSender", DoNotGenerateAcw = true)]
	public class GMAEventSender : Java.Lang.Object
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0004560C File Offset: 0x0004380C
		internal static IntPtr class_ref
		{
			get
			{
				return GMAEventSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00045630 File Offset: 0x00043830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAEventSender._members;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00045638 File Offset: 0x00043838
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAEventSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0004565C File Offset: 0x0004385C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAEventSender._members.ManagedPeerType;
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GMAEventSender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00045668 File Offset: 0x00043868
		[Register(".ctor", "()V", "")]
		public GMAEventSender() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GMAEventSender._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GMAEventSender._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000456D6 File Offset: 0x000438D6
		private static Delegate GetSend_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_Handler()
		{
			if (GMAEventSender.cb_send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_ == null)
			{
				GMAEventSender.cb_send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(GMAEventSender.n_Send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_));
			}
			return GMAEventSender.cb_send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_;
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000456FC File Offset: 0x000438FC
		private static void n_Send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native__params)
		{
			GMAEventSender @object = Java.Lang.Object.GetObject<GMAEventSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GMAEvent object2 = Java.Lang.Object.GetObject<GMAEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Send(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00045744 File Offset: 0x00043944
		[Register("send", "(Lcom/unity3d/scar/adapter/common/GMAEvent;[Ljava/lang/Object;)V", "GetSend_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_Handler")]
		public unsafe virtual void Send(GMAEvent e, params Java.Lang.Object[] @params)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(@params);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				GMAEventSender._members.InstanceMethods.InvokeVirtualVoidMethod("send.(Lcom/unity3d/scar/adapter/common/GMAEvent;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, @params);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(e);
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/utils/GMAEventSender", typeof(GMAEventSender));

		// Token: 0x040005D6 RID: 1494
		private static Delegate cb_send_Lcom_unity3d_scar_adapter_common_GMAEvent_arrayLjava_lang_Object_;
	}
}
