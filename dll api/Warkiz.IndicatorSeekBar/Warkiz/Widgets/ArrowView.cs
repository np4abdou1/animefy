using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000002 RID: 2
	[Register("com/warkiz/widget/ArrowView", DoNotGenerateAcw = true)]
	public class ArrowView : View
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		internal static IntPtr class_ref
		{
			get
			{
				return ArrowView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002074 File Offset: 0x00000274
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ArrowView._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000207C File Offset: 0x0000027C
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ArrowView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020A0 File Offset: 0x000002A0
		protected override Type ThresholdType
		{
			get
			{
				return ArrowView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020AC File Offset: 0x000002AC
		protected ArrowView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B8 File Offset: 0x000002B8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ArrowView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			base.SetHandle(ArrowView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ArrowView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			GC.KeepAlive(context);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002154 File Offset: 0x00000354
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ArrowView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			base.SetHandle(ArrowView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ArrowView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000221C File Offset: 0x0000041C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ArrowView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			ptr[2] = new JniArgumentValue(defStyleAttr);
			base.SetHandle(ArrowView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ArrowView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x04000001 RID: 1
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/ArrowView", typeof(ArrowView));
	}
}
