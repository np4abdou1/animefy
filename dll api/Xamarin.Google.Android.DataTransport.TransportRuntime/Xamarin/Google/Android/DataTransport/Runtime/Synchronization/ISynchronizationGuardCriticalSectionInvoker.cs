using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Synchronization
{
	// Token: 0x02000041 RID: 65
	[Register("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection", DoNotGenerateAcw = true)]
	internal class ISynchronizationGuardCriticalSectionInvoker : Java.Lang.Object, ISynchronizationGuardCriticalSection, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006300 File Offset: 0x00004500
		private static IntPtr java_class_ref
		{
			get
			{
				return ISynchronizationGuardCriticalSectionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00006324 File Offset: 0x00004524
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISynchronizationGuardCriticalSectionInvoker._members;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000632B File Offset: 0x0000452B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00006333 File Offset: 0x00004533
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISynchronizationGuardCriticalSectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000633F File Offset: 0x0000453F
		public static ISynchronizationGuardCriticalSection GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISynchronizationGuardCriticalSection>(handle, transfer);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006348 File Offset: 0x00004548
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISynchronizationGuardCriticalSectionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection'.");
			}
			return handle;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006373 File Offset: 0x00004573
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000063A4 File Offset: 0x000045A4
		public ISynchronizationGuardCriticalSectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISynchronizationGuardCriticalSectionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000063DC File Offset: 0x000045DC
		private static Delegate GetExecuteHandler()
		{
			if (ISynchronizationGuardCriticalSectionInvoker.cb_execute == null)
			{
				ISynchronizationGuardCriticalSectionInvoker.cb_execute = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISynchronizationGuardCriticalSectionInvoker.n_Execute));
			}
			return ISynchronizationGuardCriticalSectionInvoker.cb_execute;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006400 File Offset: 0x00004600
		private static IntPtr n_Execute(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISynchronizationGuardCriticalSection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Execute());
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006414 File Offset: 0x00004614
		public Java.Lang.Object Execute()
		{
			if (this.id_execute == IntPtr.Zero)
			{
				this.id_execute = JNIEnv.GetMethodID(this.class_ref, "execute", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_execute), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000074 RID: 116
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/synchronization/SynchronizationGuard$CriticalSection", typeof(ISynchronizationGuardCriticalSectionInvoker));

		// Token: 0x04000075 RID: 117
		private IntPtr class_ref;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_execute;

		// Token: 0x04000077 RID: 119
		private IntPtr id_execute;
	}
}
