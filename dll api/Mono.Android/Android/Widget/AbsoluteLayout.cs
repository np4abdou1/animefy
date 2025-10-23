using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A5 RID: 165
	[Register("android/widget/AbsoluteLayout", DoNotGenerateAcw = true)]
	public class AbsoluteLayout : ViewGroup
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00003A73 File Offset: 0x00001C73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbsoluteLayout._members;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00003A7C File Offset: 0x00001C7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbsoluteLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbsoluteLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected AbsoluteLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public unsafe AbsoluteLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(AbsoluteLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsoluteLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003B94 File Offset: 0x00001D94
		public unsafe AbsoluteLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(AbsoluteLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsoluteLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003C84 File Offset: 0x00001E84
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (AbsoluteLayout.cb_onLayout_ZIIII == null)
			{
				AbsoluteLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(AbsoluteLayout.n_OnLayout_ZIIII));
			}
			return AbsoluteLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003CA8 File Offset: 0x00001EA8
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<AbsoluteLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003CC0 File Offset: 0x00001EC0
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			AbsoluteLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x0400004E RID: 78
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsoluteLayout", typeof(AbsoluteLayout));

		// Token: 0x0400004F RID: 79
		private static Delegate cb_onLayout_ZIIII;
	}
}
