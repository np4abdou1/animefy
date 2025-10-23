using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x02000296 RID: 662
	[Register("com/unity3d/scar/adapter/common/DispatchGroup", DoNotGenerateAcw = true)]
	public class DispatchGroup : Java.Lang.Object
	{
		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x00061360 File Offset: 0x0005F560
		internal static IntPtr class_ref
		{
			get
			{
				return DispatchGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00061384 File Offset: 0x0005F584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DispatchGroup._members;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x0006138C File Offset: 0x0005F58C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DispatchGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000613B0 File Offset: 0x0005F5B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DispatchGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DispatchGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000613BC File Offset: 0x0005F5BC
		[Register(".ctor", "()V", "")]
		public DispatchGroup() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DispatchGroup._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DispatchGroup._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0006142A File Offset: 0x0005F62A
		private static Delegate GetEnterHandler()
		{
			if (DispatchGroup.cb_enter == null)
			{
				DispatchGroup.cb_enter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DispatchGroup.n_Enter));
			}
			return DispatchGroup.cb_enter;
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0006144E File Offset: 0x0005F64E
		private static void n_Enter(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DispatchGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Enter();
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x0006145D File Offset: 0x0005F65D
		[Register("enter", "()V", "GetEnterHandler")]
		public virtual void Enter()
		{
			DispatchGroup._members.InstanceMethods.InvokeVirtualVoidMethod("enter.()V", this, null);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00061476 File Offset: 0x0005F676
		private static Delegate GetLeaveHandler()
		{
			if (DispatchGroup.cb_leave == null)
			{
				DispatchGroup.cb_leave = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DispatchGroup.n_Leave));
			}
			return DispatchGroup.cb_leave;
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x0006149A File Offset: 0x0005F69A
		private static void n_Leave(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DispatchGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Leave();
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x000614A9 File Offset: 0x0005F6A9
		[Register("leave", "()V", "GetLeaveHandler")]
		public virtual void Leave()
		{
			DispatchGroup._members.InstanceMethods.InvokeVirtualVoidMethod("leave.()V", this, null);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x000614C2 File Offset: 0x0005F6C2
		private static Delegate GetNotify_Ljava_lang_Runnable_Handler()
		{
			if (DispatchGroup.cb_notify_Ljava_lang_Runnable_ == null)
			{
				DispatchGroup.cb_notify_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DispatchGroup.n_Notify_Ljava_lang_Runnable_));
			}
			return DispatchGroup.cb_notify_Ljava_lang_Runnable_;
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x000614E8 File Offset: 0x0005F6E8
		private static void n_Notify_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			DispatchGroup @object = Java.Lang.Object.GetObject<DispatchGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRunnable object2 = Java.Lang.Object.GetObject<IRunnable>(native_r, JniHandleOwnership.DoNotTransfer);
			@object.Notify(object2);
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x0006150C File Offset: 0x0005F70C
		[Register("notify", "(Ljava/lang/Runnable;)V", "GetNotify_Ljava_lang_Runnable_Handler")]
		public unsafe virtual void Notify(IRunnable r)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((r == null) ? IntPtr.Zero : ((Java.Lang.Object)r).Handle);
				DispatchGroup._members.InstanceMethods.InvokeVirtualVoidMethod("notify.(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(r);
			}
		}

		// Token: 0x0400075A RID: 1882
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/DispatchGroup", typeof(DispatchGroup));

		// Token: 0x0400075B RID: 1883
		private static Delegate cb_enter;

		// Token: 0x0400075C RID: 1884
		private static Delegate cb_leave;

		// Token: 0x0400075D RID: 1885
		private static Delegate cb_notify_Ljava_lang_Runnable_;
	}
}
