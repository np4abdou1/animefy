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
	// Token: 0x020000DA RID: 218
	[Register("android/widget/LinearLayout", DoNotGenerateAcw = true)]
	public class LinearLayout : ViewGroup
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000987E File Offset: 0x00007A7E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinearLayout._members;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00009888 File Offset: 0x00007A88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinearLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000098AC File Offset: 0x00007AAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinearLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00003AAC File Offset: 0x00001CAC
		protected LinearLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000098B8 File Offset: 0x00007AB8
		public unsafe LinearLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(LinearLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00009994 File Offset: 0x00007B94
		public unsafe LinearLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(LinearLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LinearLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00009A84 File Offset: 0x00007C84
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (LinearLayout.cb_onLayout_ZIIII == null)
			{
				LinearLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(LinearLayout.n_OnLayout_ZIIII));
			}
			return LinearLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00009AA8 File Offset: 0x00007CA8
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<LinearLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00009AC0 File Offset: 0x00007CC0
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			LinearLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x04000106 RID: 262
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/LinearLayout", typeof(LinearLayout));

		// Token: 0x04000107 RID: 263
		private static Delegate cb_onLayout_ZIIII;
	}
}
