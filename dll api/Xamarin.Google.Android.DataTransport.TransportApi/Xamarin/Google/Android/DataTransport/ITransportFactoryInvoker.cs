using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000012 RID: 18
	[Register("com/google/android/datatransport/TransportFactory", DoNotGenerateAcw = true)]
	internal class ITransportFactoryInvoker : Java.Lang.Object, ITransportFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002C00 File Offset: 0x00000E00
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransportFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002C24 File Offset: 0x00000E24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransportFactoryInvoker._members;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002C2B File Offset: 0x00000E2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002C33 File Offset: 0x00000E33
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransportFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002C3F File Offset: 0x00000E3F
		public static ITransportFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransportFactory>(handle, transfer);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002C48 File Offset: 0x00000E48
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransportFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.TransportFactory'.");
			}
			return handle;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002C73 File Offset: 0x00000E73
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public ITransportFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransportFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002CDC File Offset: 0x00000EDC
		private static Delegate GetGetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_Handler()
		{
			if (ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_ == null)
			{
				ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(ITransportFactoryInvoker.n_GetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_));
			}
			return ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002D00 File Offset: 0x00000F00
		private static IntPtr n_GetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			ITransportFactory @object = Java.Lang.Object.GetObject<ITransportFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			Encoding object3 = Java.Lang.Object.GetObject<Encoding>(native_p2, JniHandleOwnership.DoNotTransfer);
			ITransformer object4 = Java.Lang.Object.GetObject<ITransformer>(native_p3, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetTransport(@string, object2, object3, object4));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002D48 File Offset: 0x00000F48
		public unsafe ITransport GetTransport(string p0, Class p1, Encoding p2, ITransformer p3)
		{
			if (this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_ == IntPtr.Zero)
			{
				this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_ = JNIEnv.GetMethodID(this.class_ref, "getTransport", "(Ljava/lang/String;Ljava/lang/Class;Lcom/google/android/datatransport/Encoding;Lcom/google/android/datatransport/Transformer;)Lcom/google/android/datatransport/Transport;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			ITransport @object = Java.Lang.Object.GetObject<ITransport>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002E32 File Offset: 0x00001032
		[Obsolete]
		private static Delegate GetGetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_Handler()
		{
			if (ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_ == null)
			{
				ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(ITransportFactoryInvoker.n_GetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_));
			}
			return ITransportFactoryInvoker.cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002E58 File Offset: 0x00001058
		[Obsolete]
		private static IntPtr n_GetTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ITransportFactory @object = Java.Lang.Object.GetObject<ITransportFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_p1, JniHandleOwnership.DoNotTransfer);
			ITransformer object3 = Java.Lang.Object.GetObject<ITransformer>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetTransport(@string, object2, object3));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002E94 File Offset: 0x00001094
		public unsafe ITransport GetTransport(string p0, Class p1, ITransformer p2)
		{
			if (this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_ == IntPtr.Zero)
			{
				this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_ = JNIEnv.GetMethodID(this.class_ref, "getTransport", "(Ljava/lang/String;Ljava/lang/Class;Lcom/google/android/datatransport/Transformer;)Lcom/google/android/datatransport/Transport;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
			ITransport @object = Java.Lang.Object.GetObject<ITransport>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/TransportFactory", typeof(ITransportFactoryInvoker));

		// Token: 0x04000019 RID: 25
		private IntPtr class_ref;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_;

		// Token: 0x0400001B RID: 27
		private IntPtr id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Encoding_Lcom_google_android_datatransport_Transformer_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_;

		// Token: 0x0400001D RID: 29
		private IntPtr id_getTransport_Ljava_lang_String_Ljava_lang_Class_Lcom_google_android_datatransport_Transformer_;
	}
}
