using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Timer
{
	// Token: 0x02000093 RID: 147
	[Register("com/unity3d/services/core/timer/IIntervalTimerFactory", DoNotGenerateAcw = true)]
	internal class IIntervalTimerFactoryInvoker : Java.Lang.Object, IIntervalTimerFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0000F740 File Offset: 0x0000D940
		private static IntPtr java_class_ref
		{
			get
			{
				return IIntervalTimerFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000F764 File Offset: 0x0000D964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIntervalTimerFactoryInvoker._members;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000F76B File Offset: 0x0000D96B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000F773 File Offset: 0x0000D973
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIntervalTimerFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000F77F File Offset: 0x0000D97F
		public static IIntervalTimerFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIntervalTimerFactory>(handle, transfer);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000F788 File Offset: 0x0000D988
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIntervalTimerFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.timer.IIntervalTimerFactory'.");
			}
			return handle;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000F7B3 File Offset: 0x0000D9B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public IIntervalTimerFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIntervalTimerFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000F81C File Offset: 0x0000DA1C
		private static Delegate GetCreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_Handler()
		{
			if (IIntervalTimerFactoryInvoker.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ == null)
			{
				IIntervalTimerFactoryInvoker.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(IIntervalTimerFactoryInvoker.n_CreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_));
			}
			return IIntervalTimerFactoryInvoker.cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000F840 File Offset: 0x0000DA40
		private static IntPtr n_CreateTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IIntervalTimerFactory @object = Java.Lang.Object.GetObject<IIntervalTimerFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Integer object2 = Java.Lang.Object.GetObject<Integer>(native_p0, JniHandleOwnership.DoNotTransfer);
			Integer object3 = Java.Lang.Object.GetObject<Integer>(native_p1, JniHandleOwnership.DoNotTransfer);
			IIntervalTimerListener object4 = Java.Lang.Object.GetObject<IIntervalTimerListener>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateTimer(object2, object3, object4));
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000F87C File Offset: 0x0000DA7C
		public unsafe IIntervalTimer CreateTimer(Integer p0, Integer p1, IIntervalTimerListener p2)
		{
			if (this.id_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ == IntPtr.Zero)
			{
				this.id_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_ = JNIEnv.GetMethodID(this.class_ref, "createTimer", "(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/timer/IIntervalTimerListener;)Lcom/unity3d/services/core/timer/IIntervalTimer;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			return Java.Lang.Object.GetObject<IIntervalTimer>(JNIEnv.CallObjectMethod(base.Handle, this.id_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000137 RID: 311
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/timer/IIntervalTimerFactory", typeof(IIntervalTimerFactoryInvoker));

		// Token: 0x04000138 RID: 312
		private IntPtr class_ref;

		// Token: 0x04000139 RID: 313
		private static Delegate cb_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_;

		// Token: 0x0400013A RID: 314
		private IntPtr id_createTimer_Ljava_lang_Integer_Ljava_lang_Integer_Lcom_unity3d_services_core_timer_IIntervalTimerListener_;
	}
}
