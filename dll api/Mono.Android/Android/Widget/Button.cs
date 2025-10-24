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
	// Token: 0x020000B5 RID: 181
	[Register("android/widget/Button", DoNotGenerateAcw = true)]
	public class Button : TextView
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000059D7 File Offset: 0x00003BD7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Button._members;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000059E0 File Offset: 0x00003BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Button._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00005A04 File Offset: 0x00003C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Button._members.ManagedPeerType;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00005A10 File Offset: 0x00003C10
		protected Button(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00005A1C File Offset: 0x00003C1C
		public unsafe Button(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Button._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Button._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public unsafe Button(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Button._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Button._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0400008A RID: 138
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Button", typeof(Button));
	}
}
