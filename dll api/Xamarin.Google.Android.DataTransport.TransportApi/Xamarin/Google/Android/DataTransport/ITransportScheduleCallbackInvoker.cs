using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000014 RID: 20
	[Register("com/google/android/datatransport/TransportScheduleCallback", DoNotGenerateAcw = true)]
	internal class ITransportScheduleCallbackInvoker : Java.Lang.Object, ITransportScheduleCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002F74 File Offset: 0x00001174
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransportScheduleCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002F98 File Offset: 0x00001198
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransportScheduleCallbackInvoker._members;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002F9F File Offset: 0x0000119F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002FA7 File Offset: 0x000011A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransportScheduleCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002FB3 File Offset: 0x000011B3
		public static ITransportScheduleCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransportScheduleCallback>(handle, transfer);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002FBC File Offset: 0x000011BC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransportScheduleCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.TransportScheduleCallback'.");
			}
			return handle;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002FE7 File Offset: 0x000011E7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003018 File Offset: 0x00001218
		public ITransportScheduleCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransportScheduleCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003050 File Offset: 0x00001250
		private static Delegate GetOnSchedule_Ljava_lang_Exception_Handler()
		{
			if (ITransportScheduleCallbackInvoker.cb_onSchedule_Ljava_lang_Exception_ == null)
			{
				ITransportScheduleCallbackInvoker.cb_onSchedule_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransportScheduleCallbackInvoker.n_OnSchedule_Ljava_lang_Exception_));
			}
			return ITransportScheduleCallbackInvoker.cb_onSchedule_Ljava_lang_Exception_;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003074 File Offset: 0x00001274
		private static void n_OnSchedule_Ljava_lang_Exception_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransportScheduleCallback @object = Java.Lang.Object.GetObject<ITransportScheduleCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Exception object2 = Java.Lang.Object.GetObject<Java.Lang.Exception>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSchedule(object2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003098 File Offset: 0x00001298
		public unsafe void OnSchedule(Java.Lang.Exception p0)
		{
			if (this.id_onSchedule_Ljava_lang_Exception_ == IntPtr.Zero)
			{
				this.id_onSchedule_Ljava_lang_Exception_ = JNIEnv.GetMethodID(this.class_ref, "onSchedule", "(Ljava/lang/Exception;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSchedule_Ljava_lang_Exception_, ptr);
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/TransportScheduleCallback", typeof(ITransportScheduleCallbackInvoker));

		// Token: 0x0400001F RID: 31
		private IntPtr class_ref;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_onSchedule_Ljava_lang_Exception_;

		// Token: 0x04000021 RID: 33
		private IntPtr id_onSchedule_Ljava_lang_Exception_;
	}
}
