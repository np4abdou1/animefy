using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Animations
{
	// Token: 0x02000186 RID: 390
	[Register("android/view/animation/Interpolator", DoNotGenerateAcw = true)]
	internal class IInterpolatorInvoker : Java.Lang.Object, IInterpolator, ITimeInterpolator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00022E60 File Offset: 0x00021060
		private static IntPtr java_class_ref
		{
			get
			{
				return IInterpolatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00022E84 File Offset: 0x00021084
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInterpolatorInvoker._members;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00022E8B File Offset: 0x0002108B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00022E93 File Offset: 0x00021093
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInterpolatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00022E9F File Offset: 0x0002109F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInterpolatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.animation.Interpolator'.");
			}
			return handle;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00022ECA File Offset: 0x000210CA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00022EFC File Offset: 0x000210FC
		public IInterpolatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInterpolatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00022F34 File Offset: 0x00021134
		private static Delegate GetGetInterpolation_FHandler()
		{
			if (IInterpolatorInvoker.cb_getInterpolation_F == null)
			{
				IInterpolatorInvoker.cb_getInterpolation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_F(IInterpolatorInvoker.n_GetInterpolation_F));
			}
			return IInterpolatorInvoker.cb_getInterpolation_F;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00022F58 File Offset: 0x00021158
		private static float n_GetInterpolation_F(IntPtr jnienv, IntPtr native__this, float input)
		{
			return Java.Lang.Object.GetObject<IInterpolator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetInterpolation(input);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00022F68 File Offset: 0x00021168
		public unsafe float GetInterpolation(float input)
		{
			if (this.id_getInterpolation_F == IntPtr.Zero)
			{
				this.id_getInterpolation_F = JNIEnv.GetMethodID(this.class_ref, "getInterpolation", "(F)F");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(input);
			return JNIEnv.CallFloatMethod(base.Handle, this.id_getInterpolation_F, ptr);
		}

		// Token: 0x04000622 RID: 1570
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/animation/Interpolator", typeof(IInterpolatorInvoker));

		// Token: 0x04000623 RID: 1571
		private IntPtr class_ref;

		// Token: 0x04000624 RID: 1572
		private static Delegate cb_getInterpolation_F;

		// Token: 0x04000625 RID: 1573
		private IntPtr id_getInterpolation_F;
	}
}
