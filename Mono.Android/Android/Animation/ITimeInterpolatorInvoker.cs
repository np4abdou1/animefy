using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Animation
{
	// Token: 0x02000252 RID: 594
	[Register("android/animation/TimeInterpolator", DoNotGenerateAcw = true)]
	internal class ITimeInterpolatorInvoker : Java.Lang.Object, ITimeInterpolator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00037138 File Offset: 0x00035338
		private static IntPtr java_class_ref
		{
			get
			{
				return ITimeInterpolatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x0003715C File Offset: 0x0003535C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITimeInterpolatorInvoker._members;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00037163 File Offset: 0x00035363
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0003716B File Offset: 0x0003536B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITimeInterpolatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00037177 File Offset: 0x00035377
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITimeInterpolatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.animation.TimeInterpolator'.");
			}
			return handle;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x000371A2 File Offset: 0x000353A2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000371D4 File Offset: 0x000353D4
		public ITimeInterpolatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITimeInterpolatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0003720C File Offset: 0x0003540C
		private static Delegate GetGetInterpolation_FHandler()
		{
			if (ITimeInterpolatorInvoker.cb_getInterpolation_F == null)
			{
				ITimeInterpolatorInvoker.cb_getInterpolation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_F(ITimeInterpolatorInvoker.n_GetInterpolation_F));
			}
			return ITimeInterpolatorInvoker.cb_getInterpolation_F;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00037230 File Offset: 0x00035430
		private static float n_GetInterpolation_F(IntPtr jnienv, IntPtr native__this, float input)
		{
			return Java.Lang.Object.GetObject<ITimeInterpolator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetInterpolation(input);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00037240 File Offset: 0x00035440
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

		// Token: 0x04000965 RID: 2405
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/TimeInterpolator", typeof(ITimeInterpolatorInvoker));

		// Token: 0x04000966 RID: 2406
		private IntPtr class_ref;

		// Token: 0x04000967 RID: 2407
		private static Delegate cb_getInterpolation_F;

		// Token: 0x04000968 RID: 2408
		private IntPtr id_getInterpolation_F;
	}
}
