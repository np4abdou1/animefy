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
	// Token: 0x020000EF RID: 239
	[Register("android/widget/RelativeLayout", DoNotGenerateAcw = true)]
	public class RelativeLayout : ViewGroup
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000B77B File Offset: 0x0000997B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RelativeLayout._members;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000B784 File Offset: 0x00009984
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RelativeLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RelativeLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected RelativeLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000B7B4 File Offset: 0x000099B4
		public unsafe RelativeLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(RelativeLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RelativeLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000B890 File Offset: 0x00009A90
		public unsafe RelativeLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(RelativeLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RelativeLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000B980 File Offset: 0x00009B80
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (RelativeLayout.cb_onLayout_ZIIII == null)
			{
				RelativeLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(RelativeLayout.n_OnLayout_ZIIII));
			}
			return RelativeLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<RelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000B9BC File Offset: 0x00009BBC
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			RelativeLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x04000149 RID: 329
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/RelativeLayout", typeof(RelativeLayout));

		// Token: 0x0400014A RID: 330
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x020000F0 RID: 240
		[Register("android/widget/RelativeLayout$LayoutParams", DoNotGenerateAcw = true)]
		public new class LayoutParams : ViewGroup.MarginLayoutParams
		{
			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x0000BA69 File Offset: 0x00009C69
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RelativeLayout.LayoutParams._members;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000BA70 File Offset: 0x00009C70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RelativeLayout.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000BA94 File Offset: 0x00009C94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RelativeLayout.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00006F38 File Offset: 0x00005138
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x0000BAA0 File Offset: 0x00009CA0
			[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams(Context c, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					base.SetHandle(RelativeLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					RelativeLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x0400014B RID: 331
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/RelativeLayout$LayoutParams", typeof(RelativeLayout.LayoutParams));
		}
	}
}
