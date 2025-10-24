using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Firebase.Encoders
{
	// Token: 0x02000005 RID: 5
	[Register("com/google/firebase/encoders/DataEncoder", DoNotGenerateAcw = true)]
	internal class IDataEncoderInvoker : Java.Lang.Object, IDataEncoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		private static IntPtr java_class_ref
		{
			get
			{
				return IDataEncoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002074 File Offset: 0x00000274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDataEncoderInvoker._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000207B File Offset: 0x0000027B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002083 File Offset: 0x00000283
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDataEncoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000208F File Offset: 0x0000028F
		public static IDataEncoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDataEncoder>(handle, transfer);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002098 File Offset: 0x00000298
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDataEncoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.firebase.encoders.DataEncoder'.");
			}
			return handle;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020C3 File Offset: 0x000002C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020F4 File Offset: 0x000002F4
		public IDataEncoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDataEncoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000212C File Offset: 0x0000032C
		private static Delegate GetEncode_Ljava_lang_Object_Handler()
		{
			if (IDataEncoderInvoker.cb_encode_Ljava_lang_Object_ == null)
			{
				IDataEncoderInvoker.cb_encode_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDataEncoderInvoker.n_Encode_Ljava_lang_Object_));
			}
			return IDataEncoderInvoker.cb_encode_Ljava_lang_Object_;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002150 File Offset: 0x00000350
		private static IntPtr n_Encode_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDataEncoder @object = Java.Lang.Object.GetObject<IDataEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.Encode(object2));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002178 File Offset: 0x00000378
		public unsafe string Encode(Java.Lang.Object p0)
		{
			if (this.id_encode_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_encode_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "encode", "(Ljava/lang/Object;)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_encode_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021F1 File Offset: 0x000003F1
		private static Delegate GetEncode_Ljava_lang_Object_Ljava_io_Writer_Handler()
		{
			if (IDataEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_Writer_ == null)
			{
				IDataEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_Writer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IDataEncoderInvoker.n_Encode_Ljava_lang_Object_Ljava_io_Writer_));
			}
			return IDataEncoderInvoker.cb_encode_Ljava_lang_Object_Ljava_io_Writer_;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002218 File Offset: 0x00000418
		private static void n_Encode_Ljava_lang_Object_Ljava_io_Writer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IDataEncoder @object = Java.Lang.Object.GetObject<IDataEncoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Writer object3 = Java.Lang.Object.GetObject<Writer>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Encode(object2, object3);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002244 File Offset: 0x00000444
		public unsafe void Encode(Java.Lang.Object p0, Writer p1)
		{
			if (this.id_encode_Ljava_lang_Object_Ljava_io_Writer_ == IntPtr.Zero)
			{
				this.id_encode_Ljava_lang_Object_Ljava_io_Writer_ = JNIEnv.GetMethodID(this.class_ref, "encode", "(Ljava/lang/Object;Ljava/io/Writer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_encode_Ljava_lang_Object_Ljava_io_Writer_, ptr);
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/firebase/encoders/DataEncoder", typeof(IDataEncoderInvoker));

		// Token: 0x04000002 RID: 2
		private IntPtr class_ref;

		// Token: 0x04000003 RID: 3
		private static Delegate cb_encode_Ljava_lang_Object_;

		// Token: 0x04000004 RID: 4
		private IntPtr id_encode_Ljava_lang_Object_;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_encode_Ljava_lang_Object_Ljava_io_Writer_;

		// Token: 0x04000006 RID: 6
		private IntPtr id_encode_Ljava_lang_Object_Ljava_io_Writer_;
	}
}
