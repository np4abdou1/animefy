using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000017 RID: 23
	[Register("com/bumptech/glide/gifdecoder/GifDecoder$GifDecodeStatus", DoNotGenerateAcw = true)]
	internal class IGifDecoderGifDecodeStatusInvoker : Java.Lang.Object, IGifDecoderGifDecodeStatus, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002C6C File Offset: 0x00000E6C
		private static IntPtr java_class_ref
		{
			get
			{
				return IGifDecoderGifDecodeStatusInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002C90 File Offset: 0x00000E90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGifDecoderGifDecodeStatusInvoker._members;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002C97 File Offset: 0x00000E97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002C9F File Offset: 0x00000E9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGifDecoderGifDecodeStatusInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002CAB File Offset: 0x00000EAB
		public static IGifDecoderGifDecodeStatus GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGifDecoderGifDecodeStatus>(handle, transfer);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002CB4 File Offset: 0x00000EB4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGifDecoderGifDecodeStatusInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.gifdecoder.GifDecoder.GifDecodeStatus'.");
			}
			return handle;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002CDF File Offset: 0x00000EDF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002D10 File Offset: 0x00000F10
		public IGifDecoderGifDecodeStatusInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGifDecoderGifDecodeStatusInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002D48 File Offset: 0x00000F48
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IGifDecoderGifDecodeStatusInvoker.cb_annotationType == null)
			{
				IGifDecoderGifDecodeStatusInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGifDecoderGifDecodeStatusInvoker.n_AnnotationType));
			}
			return IGifDecoderGifDecodeStatusInvoker.cb_annotationType;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002D6C File Offset: 0x00000F6C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGifDecoderGifDecodeStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002D80 File Offset: 0x00000F80
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002DD1 File Offset: 0x00000FD1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IGifDecoderGifDecodeStatusInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IGifDecoderGifDecodeStatusInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IGifDecoderGifDecodeStatusInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IGifDecoderGifDecodeStatusInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002DF8 File Offset: 0x00000FF8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IGifDecoderGifDecodeStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002E1C File Offset: 0x0000101C
		public new unsafe bool Equals(Java.Lang.Object obj)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((obj == null) ? IntPtr.Zero : obj.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002E8F File Offset: 0x0000108F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IGifDecoderGifDecodeStatusInvoker.cb_hashCode == null)
			{
				IGifDecoderGifDecodeStatusInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderGifDecodeStatusInvoker.n_GetHashCode));
			}
			return IGifDecoderGifDecodeStatusInvoker.cb_hashCode;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002EB3 File Offset: 0x000010B3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoderGifDecodeStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002EC2 File Offset: 0x000010C2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002F02 File Offset: 0x00001102
		private static Delegate GetToStringHandler()
		{
			if (IGifDecoderGifDecodeStatusInvoker.cb_toString == null)
			{
				IGifDecoderGifDecodeStatusInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGifDecoderGifDecodeStatusInvoker.n_ToString));
			}
			return IGifDecoderGifDecodeStatusInvoker.cb_toString;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002F26 File Offset: 0x00001126
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IGifDecoderGifDecodeStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002F3C File Offset: 0x0000113C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400001D RID: 29
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/GifDecoder$GifDecodeStatus", typeof(IGifDecoderGifDecodeStatusInvoker));

		// Token: 0x0400001E RID: 30
		private IntPtr class_ref;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_annotationType;

		// Token: 0x04000020 RID: 32
		private IntPtr id_annotationType;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000022 RID: 34
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_hashCode;

		// Token: 0x04000024 RID: 36
		private IntPtr id_hashCode;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_toString;

		// Token: 0x04000026 RID: 38
		private IntPtr id_toString;
	}
}
