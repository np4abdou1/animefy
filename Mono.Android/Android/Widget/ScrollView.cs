using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000F2 RID: 242
	[Register("android/widget/ScrollView", DoNotGenerateAcw = true)]
	public class ScrollView : FrameLayout
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0000BDAB File Offset: 0x00009FAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScrollView._members;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScrollView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScrollView._members.ManagedPeerType;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000710C File Offset: 0x0000530C
		protected ScrollView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public unsafe ScrollView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScrollView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrollView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		public unsafe ScrollView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScrollView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrollView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		public unsafe void SmoothScrollTo(int x, int y)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(y);
			ScrollView._members.InstanceMethods.InvokeNonvirtualVoidMethod("smoothScrollTo.(II)V", this, ptr);
		}

		// Token: 0x04000150 RID: 336
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ScrollView", typeof(ScrollView));
	}
}
