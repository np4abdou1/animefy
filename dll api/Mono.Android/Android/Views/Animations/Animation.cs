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
	// Token: 0x02000182 RID: 386
	[Register("android/view/animation/Animation", DoNotGenerateAcw = true)]
	public abstract class Animation : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00022BB6 File Offset: 0x00020DB6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Animation._members;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00022BC0 File Offset: 0x00020DC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Animation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00022BE4 File Offset: 0x00020DE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Animation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Animation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00022BF0 File Offset: 0x00020DF0
		public unsafe Animation(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(Animation._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Animation._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00022CCC File Offset: 0x00020ECC
		private static Delegate GetSetDuration_JHandler()
		{
			if (Animation.cb_setDuration_J == null)
			{
				Animation.cb_setDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_V(Animation.n_SetDuration_J));
			}
			return Animation.cb_setDuration_J;
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00022CF0 File Offset: 0x00020EF0
		private static void n_SetDuration_J(IntPtr jnienv, IntPtr native__this, long durationMillis)
		{
			Java.Lang.Object.GetObject<Animation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration = durationMillis;
		}

		// Token: 0x17000290 RID: 656
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00022D00 File Offset: 0x00020F00
		public unsafe virtual long Duration
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				Animation._members.InstanceMethods.InvokeVirtualVoidMethod("setDuration.(J)V", this, ptr);
			}
		}

		// Token: 0x0400061E RID: 1566
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/animation/Animation", typeof(Animation));

		// Token: 0x0400061F RID: 1567
		private static Delegate cb_setDuration_J;
	}
}
