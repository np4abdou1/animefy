using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x02000035 RID: 53
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/UnmodifiableView", DoNotGenerateAcw = true)]
	internal class IUnmodifiableViewInvoker : Java.Lang.Object, IUnmodifiableView, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00005DBC File Offset: 0x00003FBC
		private static IntPtr java_class_ref
		{
			get
			{
				return IUnmodifiableViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00005DE0 File Offset: 0x00003FE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IUnmodifiableViewInvoker._members;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00005DE7 File Offset: 0x00003FE7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00005DEF File Offset: 0x00003FEF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IUnmodifiableViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005DFB File Offset: 0x00003FFB
		[NullableContext(2)]
		public static IUnmodifiableView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IUnmodifiableView>(handle, transfer);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005E04 File Offset: 0x00004004
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IUnmodifiableViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.UnmodifiableView'.");
			}
			return handle;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005E2F File Offset: 0x0000402F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005E60 File Offset: 0x00004060
		public IUnmodifiableViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IUnmodifiableViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00005E98 File Offset: 0x00004098
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IUnmodifiableViewInvoker.cb_annotationType == null)
			{
				IUnmodifiableViewInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnmodifiableViewInvoker.n_AnnotationType));
			}
			return IUnmodifiableViewInvoker.cb_annotationType;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005EBC File Offset: 0x000040BC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IUnmodifiableView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00005ED0 File Offset: 0x000040D0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005F21 File Offset: 0x00004121
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IUnmodifiableViewInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IUnmodifiableViewInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IUnmodifiableViewInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IUnmodifiableViewInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005F48 File Offset: 0x00004148
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IUnmodifiableView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005F6C File Offset: 0x0000416C
		[NullableContext(2)]
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

		// Token: 0x060001CC RID: 460 RVA: 0x00005FDF File Offset: 0x000041DF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IUnmodifiableViewInvoker.cb_hashCode == null)
			{
				IUnmodifiableViewInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IUnmodifiableViewInvoker.n_GetHashCode));
			}
			return IUnmodifiableViewInvoker.cb_hashCode;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00006003 File Offset: 0x00004203
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IUnmodifiableView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006012 File Offset: 0x00004212
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006052 File Offset: 0x00004252
		private static Delegate GetToStringHandler()
		{
			if (IUnmodifiableViewInvoker.cb_toString == null)
			{
				IUnmodifiableViewInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IUnmodifiableViewInvoker.n_ToString));
			}
			return IUnmodifiableViewInvoker.cb_toString;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006076 File Offset: 0x00004276
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IUnmodifiableView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000608C File Offset: 0x0000428C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C1 RID: 193
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/UnmodifiableView", typeof(IUnmodifiableViewInvoker));

		// Token: 0x040000C2 RID: 194
		private IntPtr class_ref;

		// Token: 0x040000C3 RID: 195
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000C4 RID: 196
		private IntPtr id_annotationType;

		// Token: 0x040000C5 RID: 197
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000C6 RID: 198
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000C7 RID: 199
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000C8 RID: 200
		private IntPtr id_hashCode;

		// Token: 0x040000C9 RID: 201
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000CA RID: 202
		private IntPtr id_toString;
	}
}
