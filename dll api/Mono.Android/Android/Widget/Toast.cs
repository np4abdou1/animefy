using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000FD RID: 253
	[Register("android/widget/Toast", DoNotGenerateAcw = true)]
	public class Toast : Java.Lang.Object
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000D3E9 File Offset: 0x0000B5E9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Toast._members;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Toast._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0000D414 File Offset: 0x0000B614
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Toast._members.ManagedPeerType;
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Toast(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000D420 File Offset: 0x0000B620
		public unsafe Toast(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(Toast._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Toast._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		private static Delegate GetSetDuration_IHandler()
		{
			if (Toast.cb_setDuration_I == null)
			{
				Toast.cb_setDuration_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Toast.n_SetDuration_I));
			}
			return Toast.cb_setDuration_I;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		private static void n_SetDuration_I(IntPtr jnienv, IntPtr native__this, int native_duration)
		{
			Java.Lang.Object.GetObject<Toast>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration = (ToastLength)native_duration;
		}

		// Token: 0x17000117 RID: 279
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x0000D514 File Offset: 0x0000B714
		public unsafe virtual ToastLength Duration
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)value);
				Toast._members.InstanceMethods.InvokeVirtualVoidMethod("setDuration.(I)V", this, ptr);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000D54F File Offset: 0x0000B74F
		private static Delegate GetSetView_Landroid_view_View_Handler()
		{
			if (Toast.cb_setView_Landroid_view_View_ == null)
			{
				Toast.cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Toast.n_SetView_Landroid_view_View_));
			}
			return Toast.cb_setView_Landroid_view_View_;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000D574 File Offset: 0x0000B774
		private static void n_SetView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			Toast @object = Java.Lang.Object.GetObject<Toast>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.View = object2;
		}

		// Token: 0x17000118 RID: 280
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x0000D598 File Offset: 0x0000B798
		public unsafe virtual View View
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Toast._members.InstanceMethods.InvokeVirtualVoidMethod("setView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		private static Delegate GetShowHandler()
		{
			if (Toast.cb_show == null)
			{
				Toast.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Toast.n_Show));
			}
			return Toast.cb_show;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000D620 File Offset: 0x0000B820
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Toast>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000D62F File Offset: 0x0000B82F
		public virtual void Show()
		{
			Toast._members.InstanceMethods.InvokeVirtualVoidMethod("show.()V", this, null);
		}

		// Token: 0x04000172 RID: 370
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Toast", typeof(Toast));

		// Token: 0x04000173 RID: 371
		private static Delegate cb_setDuration_I;

		// Token: 0x04000174 RID: 372
		private static Delegate cb_setView_Landroid_view_View_;

		// Token: 0x04000175 RID: 373
		private static Delegate cb_show;
	}
}
