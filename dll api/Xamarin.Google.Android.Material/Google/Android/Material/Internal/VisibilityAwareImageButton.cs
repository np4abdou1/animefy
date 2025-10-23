using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Internal
{
	// Token: 0x02000093 RID: 147
	[Register("com/google/android/material/internal/VisibilityAwareImageButton", DoNotGenerateAcw = true)]
	public class VisibilityAwareImageButton : ImageButton
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0001B27E File Offset: 0x0001947E
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0001B286 File Offset: 0x00019486
		public override ViewStates Visibility
		{
			get
			{
				return base.Visibility;
			}
			set
			{
				base.Visibility = value;
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0001B28F File Offset: 0x0001948F
		public void SetVisibility(ViewStates visibility)
		{
			this.Visibility = visibility;
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0001B298 File Offset: 0x00019498
		internal static IntPtr class_ref
		{
			get
			{
				return VisibilityAwareImageButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0001B2BC File Offset: 0x000194BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VisibilityAwareImageButton._members;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0001B2C4 File Offset: 0x000194C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VisibilityAwareImageButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0001B2E8 File Offset: 0x000194E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VisibilityAwareImageButton._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001B2F4 File Offset: 0x000194F4
		protected VisibilityAwareImageButton(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0001B300 File Offset: 0x00019500
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VisibilityAwareImageButton(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(VisibilityAwareImageButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VisibilityAwareImageButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0001B3B0 File Offset: 0x000195B0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe VisibilityAwareImageButton(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(VisibilityAwareImageButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VisibilityAwareImageButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0001B48C File Offset: 0x0001968C
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe VisibilityAwareImageButton(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(VisibilityAwareImageButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				VisibilityAwareImageButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0001B57C File Offset: 0x0001977C
		public int UserSetVisibility
		{
			[Register("getUserSetVisibility", "()I", "")]
			get
			{
				return VisibilityAwareImageButton._members.InstanceMethods.InvokeNonvirtualInt32Method("getUserSetVisibility.()I", this, null);
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0001B598 File Offset: 0x00019798
		[Register("internalSetVisibility", "(IZ)V", "")]
		public unsafe void InternalSetVisibility(int visibility, bool fromUser)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visibility);
			ptr[1] = new JniArgumentValue(fromUser);
			VisibilityAwareImageButton._members.InstanceMethods.InvokeNonvirtualVoidMethod("internalSetVisibility.(IZ)V", this, ptr);
		}

		// Token: 0x040002E7 RID: 743
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/internal/VisibilityAwareImageButton", typeof(VisibilityAwareImageButton));
	}
}
