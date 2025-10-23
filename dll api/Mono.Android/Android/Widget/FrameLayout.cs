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
	// Token: 0x020000C6 RID: 198
	[Register("android/widget/FrameLayout", DoNotGenerateAcw = true)]
	public class FrameLayout : ViewGroup
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00006B4B File Offset: 0x00004D4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FrameLayout._members;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00006B54 File Offset: 0x00004D54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FrameLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00006B78 File Offset: 0x00004D78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FrameLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected FrameLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00006B84 File Offset: 0x00004D84
		public unsafe FrameLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(FrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00006C34 File Offset: 0x00004E34
		public unsafe FrameLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00006D10 File Offset: 0x00004F10
		public unsafe FrameLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00006E00 File Offset: 0x00005000
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (FrameLayout.cb_onLayout_ZIIII == null)
			{
				FrameLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(FrameLayout.n_OnLayout_ZIIII));
			}
			return FrameLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00006E24 File Offset: 0x00005024
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			Java.Lang.Object.GetObject<FrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, left, top, right, bottom);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00006E3C File Offset: 0x0000503C
		protected unsafe override void OnLayout(bool changed, int left, int top, int right, int bottom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(left);
			ptr[2] = new JniArgumentValue(top);
			ptr[3] = new JniArgumentValue(right);
			ptr[4] = new JniArgumentValue(bottom);
			FrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x040000A6 RID: 166
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/FrameLayout", typeof(FrameLayout));

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x020000C7 RID: 199
		[Register("android/widget/FrameLayout$LayoutParams", DoNotGenerateAcw = true)]
		public new class LayoutParams : ViewGroup.MarginLayoutParams
		{
			// Token: 0x17000079 RID: 121
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x00006EE9 File Offset: 0x000050E9
			[Register("gravity")]
			public GravityFlags Gravity
			{
				set
				{
					FrameLayout.LayoutParams._members.InstanceFields.SetValue("gravity.I", this, (int)value);
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00006F01 File Offset: 0x00005101
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return FrameLayout.LayoutParams._members;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00006F08 File Offset: 0x00005108
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return FrameLayout.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x00006F2C File Offset: 0x0000512C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return FrameLayout.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00006F38 File Offset: 0x00005138
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00006F44 File Offset: 0x00005144
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
					base.SetHandle(FrameLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					FrameLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00007020 File Offset: 0x00005220
			[Register(".ctor", "(II)V", "")]
			public unsafe LayoutParams(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				base.SetHandle(FrameLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FrameLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x040000A8 RID: 168
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/FrameLayout$LayoutParams", typeof(FrameLayout.LayoutParams));
		}
	}
}
