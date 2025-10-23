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
	// Token: 0x020000C1 RID: 193
	[Register("android/widget/EditText", DoNotGenerateAcw = true)]
	public class EditText : TextView
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x000066A7 File Offset: 0x000048A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EditText._members;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000066B0 File Offset: 0x000048B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EditText._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000066D4 File Offset: 0x000048D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EditText._members.ManagedPeerType;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00005A10 File Offset: 0x00003C10
		protected EditText(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000066E0 File Offset: 0x000048E0
		public unsafe EditText(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(EditText._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EditText._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000067BC File Offset: 0x000049BC
		public unsafe EditText(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(EditText._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EditText._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000068AC File Offset: 0x00004AAC
		private static Delegate GetSetSelection_IHandler()
		{
			if (EditText.cb_setSelection_I == null)
			{
				EditText.cb_setSelection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(EditText.n_SetSelection_I));
			}
			return EditText.cb_setSelection_I;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000068D0 File Offset: 0x00004AD0
		private static void n_SetSelection_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			Java.Lang.Object.GetObject<EditText>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelection(index);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000068E0 File Offset: 0x00004AE0
		public unsafe virtual void SetSelection(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			EditText._members.InstanceMethods.InvokeVirtualVoidMethod("setSelection.(I)V", this, ptr);
		}

		// Token: 0x0400009E RID: 158
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/EditText", typeof(EditText));

		// Token: 0x0400009F RID: 159
		private static Delegate cb_setSelection_I;
	}
}
