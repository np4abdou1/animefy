using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200015E RID: 350
	[Register("android/view/ViewPropertyAnimator", DoNotGenerateAcw = true)]
	public class ViewPropertyAnimator : Java.Lang.Object
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00020B55 File Offset: 0x0001ED55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPropertyAnimator._members;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00020B5C File Offset: 0x0001ED5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPropertyAnimator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00020B80 File Offset: 0x0001ED80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPropertyAnimator._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ViewPropertyAnimator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00020B8C File Offset: 0x0001ED8C
		private static Delegate GetRotation_FHandler()
		{
			if (ViewPropertyAnimator.cb_rotation_F == null)
			{
				ViewPropertyAnimator.cb_rotation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_L(ViewPropertyAnimator.n_Rotation_F));
			}
			return ViewPropertyAnimator.cb_rotation_F;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		private static IntPtr n_Rotation_F(IntPtr jnienv, IntPtr native__this, float value)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewPropertyAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Rotation(value));
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		public unsafe virtual ViewPropertyAnimator Rotation(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimator>(ViewPropertyAnimator._members.InstanceMethods.InvokeVirtualObjectMethod("rotation.(F)Landroid/view/ViewPropertyAnimator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00020C11 File Offset: 0x0001EE11
		private static Delegate GetSetDuration_JHandler()
		{
			if (ViewPropertyAnimator.cb_setDuration_J == null)
			{
				ViewPropertyAnimator.cb_setDuration_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(ViewPropertyAnimator.n_SetDuration_J));
			}
			return ViewPropertyAnimator.cb_setDuration_J;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00020C35 File Offset: 0x0001EE35
		private static IntPtr n_SetDuration_J(IntPtr jnienv, IntPtr native__this, long duration)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewPropertyAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDuration(duration));
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00020C4C File Offset: 0x0001EE4C
		public unsafe virtual ViewPropertyAnimator SetDuration(long duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<ViewPropertyAnimator>(ViewPropertyAnimator._members.InstanceMethods.InvokeVirtualObjectMethod("setDuration.(J)Landroid/view/ViewPropertyAnimator;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00020C95 File Offset: 0x0001EE95
		private static Delegate GetStartHandler()
		{
			if (ViewPropertyAnimator.cb_start == null)
			{
				ViewPropertyAnimator.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ViewPropertyAnimator.n_Start));
			}
			return ViewPropertyAnimator.cb_start;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00020CB9 File Offset: 0x0001EEB9
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ViewPropertyAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public virtual void Start()
		{
			ViewPropertyAnimator._members.InstanceMethods.InvokeVirtualVoidMethod("start.()V", this, null);
		}

		// Token: 0x04000421 RID: 1057
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewPropertyAnimator", typeof(ViewPropertyAnimator));

		// Token: 0x04000422 RID: 1058
		private static Delegate cb_rotation_F;

		// Token: 0x04000423 RID: 1059
		private static Delegate cb_setDuration_J;

		// Token: 0x04000424 RID: 1060
		private static Delegate cb_start;
	}
}
