using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Animations
{
	// Token: 0x02000181 RID: 385
	[Register("android/view/animation/AlphaAnimation", DoNotGenerateAcw = true)]
	public class AlphaAnimation : Animation
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x000229E3 File Offset: 0x00020BE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AlphaAnimation._members;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000229EC File Offset: 0x00020BEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AlphaAnimation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x00022A10 File Offset: 0x00020C10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AlphaAnimation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00022A1C File Offset: 0x00020C1C
		protected AlphaAnimation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00022A28 File Offset: 0x00020C28
		public unsafe AlphaAnimation(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AlphaAnimation._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AlphaAnimation._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00022B04 File Offset: 0x00020D04
		public unsafe AlphaAnimation(float fromAlpha, float toAlpha) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(fromAlpha);
			ptr[1] = new JniArgumentValue(toAlpha);
			base.SetHandle(AlphaAnimation._members.InstanceMethods.StartCreateInstance("(FF)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			AlphaAnimation._members.InstanceMethods.FinishCreateInstance("(FF)V", this, ptr);
		}

		// Token: 0x0400061D RID: 1565
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/animation/AlphaAnimation", typeof(AlphaAnimation));
	}
}
