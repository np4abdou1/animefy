using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200003C RID: 60
	[Register("com/google/errorprone/annotations/ThreadSafe", DoNotGenerateAcw = true)]
	internal class IThreadSafeInvoker : Java.Lang.Object, IThreadSafe, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00006A1C File Offset: 0x00004C1C
		private static IntPtr java_class_ref
		{
			get
			{
				return IThreadSafeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00006A40 File Offset: 0x00004C40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IThreadSafeInvoker._members;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00006A47 File Offset: 0x00004C47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00006A4F File Offset: 0x00004C4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IThreadSafeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006A5B File Offset: 0x00004C5B
		public static IThreadSafe GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IThreadSafe>(handle, transfer);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006A64 File Offset: 0x00004C64
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IThreadSafeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.ThreadSafe'.");
			}
			return handle;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00006A8F File Offset: 0x00004C8F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006AC0 File Offset: 0x00004CC0
		public IThreadSafeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IThreadSafeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00006AF8 File Offset: 0x00004CF8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IThreadSafeInvoker.cb_annotationType == null)
			{
				IThreadSafeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThreadSafeInvoker.n_AnnotationType));
			}
			return IThreadSafeInvoker.cb_annotationType;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006B1C File Offset: 0x00004D1C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IThreadSafe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006B30 File Offset: 0x00004D30
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006B81 File Offset: 0x00004D81
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IThreadSafeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IThreadSafeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IThreadSafeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IThreadSafeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006BA8 File Offset: 0x00004DA8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IThreadSafe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00006BCC File Offset: 0x00004DCC
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

		// Token: 0x06000219 RID: 537 RVA: 0x00006C3F File Offset: 0x00004E3F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IThreadSafeInvoker.cb_hashCode == null)
			{
				IThreadSafeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IThreadSafeInvoker.n_GetHashCode));
			}
			return IThreadSafeInvoker.cb_hashCode;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00006C63 File Offset: 0x00004E63
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IThreadSafe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00006C72 File Offset: 0x00004E72
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00006CB2 File Offset: 0x00004EB2
		private static Delegate GetToStringHandler()
		{
			if (IThreadSafeInvoker.cb_toString == null)
			{
				IThreadSafeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IThreadSafeInvoker.n_ToString));
			}
			return IThreadSafeInvoker.cb_toString;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00006CD6 File Offset: 0x00004ED6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IThreadSafe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00006CEC File Offset: 0x00004EEC
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000EF RID: 239
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/ThreadSafe", typeof(IThreadSafeInvoker));

		// Token: 0x040000F0 RID: 240
		private IntPtr class_ref;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_annotationType;

		// Token: 0x040000F2 RID: 242
		private IntPtr id_annotationType;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000F4 RID: 244
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_hashCode;

		// Token: 0x040000F6 RID: 246
		private IntPtr id_hashCode;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_toString;

		// Token: 0x040000F8 RID: 248
		private IntPtr id_toString;
	}
}
