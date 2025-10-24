using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200005A RID: 90
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlin/Deprecated", DoNotGenerateAcw = true)]
	internal class IDeprecatedInvoker : Java.Lang.Object, IDeprecated, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00003A54 File Offset: 0x00001C54
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeprecatedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00003A78 File Offset: 0x00001C78
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IDeprecatedInvoker._members;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00003A7F File Offset: 0x00001C7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00003A87 File Offset: 0x00001C87
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IDeprecatedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003A93 File Offset: 0x00001C93
		public static IDeprecated GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeprecated>(handle, transfer);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003A9C File Offset: 0x00001C9C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeprecatedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.Deprecated'.");
			}
			return handle;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003AC7 File Offset: 0x00001CC7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public IDeprecatedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeprecatedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003B30 File Offset: 0x00001D30
		[NullableContext(1)]
		private static Delegate GetLevelHandler()
		{
			if (IDeprecatedInvoker.cb_level == null)
			{
				IDeprecatedInvoker.cb_level = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedInvoker.n_Level));
			}
			return IDeprecatedInvoker.cb_level;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003B54 File Offset: 0x00001D54
		private static IntPtr n_Level(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Level());
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00003B68 File Offset: 0x00001D68
		public DeprecationLevel Level()
		{
			if (this.id_level == IntPtr.Zero)
			{
				this.id_level = JNIEnv.GetMethodID(this.class_ref, "level", "()Lkotlin/DeprecationLevel;");
			}
			return Java.Lang.Object.GetObject<DeprecationLevel>(JNIEnv.CallObjectMethod(base.Handle, this.id_level), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00003BB9 File Offset: 0x00001DB9
		[NullableContext(1)]
		private static Delegate GetMessageHandler()
		{
			if (IDeprecatedInvoker.cb_message == null)
			{
				IDeprecatedInvoker.cb_message = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedInvoker.n_Message));
			}
			return IDeprecatedInvoker.cb_message;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00003BDD File Offset: 0x00001DDD
		private static IntPtr n_Message(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message());
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public string Message()
		{
			if (this.id_message == IntPtr.Zero)
			{
				this.id_message = JNIEnv.GetMethodID(this.class_ref, "message", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_message), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003C45 File Offset: 0x00001E45
		[NullableContext(1)]
		private static Delegate GetReplaceWithHandler()
		{
			if (IDeprecatedInvoker.cb_replaceWith == null)
			{
				IDeprecatedInvoker.cb_replaceWith = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedInvoker.n_ReplaceWith));
			}
			return IDeprecatedInvoker.cb_replaceWith;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00003C69 File Offset: 0x00001E69
		private static IntPtr n_ReplaceWith(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplaceWith());
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00003C80 File Offset: 0x00001E80
		public IReplaceWith ReplaceWith()
		{
			if (this.id_replaceWith == IntPtr.Zero)
			{
				this.id_replaceWith = JNIEnv.GetMethodID(this.class_ref, "replaceWith", "()Lkotlin/ReplaceWith;");
			}
			return Java.Lang.Object.GetObject<IReplaceWith>(JNIEnv.CallObjectMethod(base.Handle, this.id_replaceWith), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003CD1 File Offset: 0x00001ED1
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDeprecatedInvoker.cb_annotationType == null)
			{
				IDeprecatedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedInvoker.n_AnnotationType));
			}
			return IDeprecatedInvoker.cb_annotationType;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003CF5 File Offset: 0x00001EF5
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003D0C File Offset: 0x00001F0C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003D5D File Offset: 0x00001F5D
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDeprecatedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDeprecatedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDeprecatedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDeprecatedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003D84 File Offset: 0x00001F84
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003DA8 File Offset: 0x00001FA8
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

		// Token: 0x060001A6 RID: 422 RVA: 0x00003E1B File Offset: 0x0000201B
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDeprecatedInvoker.cb_hashCode == null)
			{
				IDeprecatedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDeprecatedInvoker.n_GetHashCode));
			}
			return IDeprecatedInvoker.cb_hashCode;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003E3F File Offset: 0x0000203F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003E4E File Offset: 0x0000204E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00003E8E File Offset: 0x0000208E
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IDeprecatedInvoker.cb_toString == null)
			{
				IDeprecatedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeprecatedInvoker.n_ToString));
			}
			return IDeprecatedInvoker.cb_toString;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003EB2 File Offset: 0x000020B2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDeprecated>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00003EC8 File Offset: 0x000020C8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000036 RID: 54
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Deprecated", typeof(IDeprecatedInvoker));

		// Token: 0x04000037 RID: 55
		private IntPtr class_ref;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_level;

		// Token: 0x04000039 RID: 57
		private IntPtr id_level;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_message;

		// Token: 0x0400003B RID: 59
		private IntPtr id_message;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_replaceWith;

		// Token: 0x0400003D RID: 61
		private IntPtr id_replaceWith;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_annotationType;

		// Token: 0x0400003F RID: 63
		private IntPtr id_annotationType;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000041 RID: 65
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_hashCode;

		// Token: 0x04000043 RID: 67
		private IntPtr id_hashCode;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_toString;

		// Token: 0x04000045 RID: 69
		private IntPtr id_toString;
	}
}
