using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x02000032 RID: 50
	[Register("com/google/android/datatransport/runtime/time/Clock", DoNotGenerateAcw = true)]
	internal class IClockInvoker : Java.Lang.Object, IClock, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000528C File Offset: 0x0000348C
		private static IntPtr java_class_ref
		{
			get
			{
				return IClockInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000052B0 File Offset: 0x000034B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IClockInvoker._members;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000052B7 File Offset: 0x000034B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000052BF File Offset: 0x000034BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IClockInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000052CB File Offset: 0x000034CB
		public static IClock GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IClock>(handle, transfer);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000052D4 File Offset: 0x000034D4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IClockInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.time.Clock'.");
			}
			return handle;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000052FF File Offset: 0x000034FF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005330 File Offset: 0x00003530
		public IClockInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IClockInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005368 File Offset: 0x00003568
		private static Delegate GetGetTimeHandler()
		{
			if (IClockInvoker.cb_getTime == null)
			{
				IClockInvoker.cb_getTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IClockInvoker.n_GetTime));
			}
			return IClockInvoker.cb_getTime;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000538C File Offset: 0x0000358C
		private static long n_GetTime(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IClock>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Time;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000539B File Offset: 0x0000359B
		public long Time
		{
			get
			{
				if (this.id_getTime == IntPtr.Zero)
				{
					this.id_getTime = JNIEnv.GetMethodID(this.class_ref, "getTime", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getTime);
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/Clock", typeof(IClockInvoker));

		// Token: 0x04000051 RID: 81
		private IntPtr class_ref;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_getTime;

		// Token: 0x04000053 RID: 83
		private IntPtr id_getTime;
	}
}
