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
	// Token: 0x020000B6 RID: 182
	[Register("android/widget/CheckBox", DoNotGenerateAcw = true)]
	public class CheckBox : CompoundButton
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00005C03 File Offset: 0x00003E03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CheckBox._members;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00005C0C File Offset: 0x00003E0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CheckBox._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00005C30 File Offset: 0x00003E30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CheckBox._members.ManagedPeerType;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00005C3C File Offset: 0x00003E3C
		protected CheckBox(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00005C48 File Offset: 0x00003E48
		public unsafe CheckBox(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CheckBox._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CheckBox._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00005D24 File Offset: 0x00003F24
		public unsafe CheckBox(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(CheckBox._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CheckBox._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/CheckBox", typeof(CheckBox));
	}
}
