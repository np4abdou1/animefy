using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C1 RID: 193
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/request/target/SimpleTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Z"
	})]
	public abstract class SimpleTarget : BaseTarget
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		internal new static IntPtr class_ref
		{
			get
			{
				return SimpleTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0001F618 File Offset: 0x0001D818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SimpleTarget._members;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0001F620 File Offset: 0x0001D820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SimpleTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0001F644 File Offset: 0x0001D844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SimpleTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0001F650 File Offset: 0x0001D850
		protected SimpleTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001F65C File Offset: 0x0001D85C
		[Register(".ctor", "()V", "")]
		public SimpleTarget() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SimpleTarget._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SimpleTarget._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001F6CC File Offset: 0x0001D8CC
		[Register(".ctor", "(II)V", "")]
		public unsafe SimpleTarget(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(SimpleTarget._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			SimpleTarget._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001F764 File Offset: 0x0001D964
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "")]
		public unsafe sealed override void GetSize(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				SimpleTarget._members.InstanceMethods.InvokeNonvirtualVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001F7CC File Offset: 0x0001D9CC
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (SimpleTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				SimpleTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SimpleTarget.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return SimpleTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001F7F0 File Offset: 0x0001D9F0
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<SimpleTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001F814 File Offset: 0x0001DA14
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe override void RemoveCallback(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				SimpleTarget._members.InstanceMethods.InvokeVirtualVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x04000282 RID: 642
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/SimpleTarget", typeof(SimpleTarget));

		// Token: 0x04000283 RID: 643
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
	}
}
