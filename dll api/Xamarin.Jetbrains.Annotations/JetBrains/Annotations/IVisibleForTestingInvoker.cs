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
	// Token: 0x02000037 RID: 55
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/VisibleForTesting", DoNotGenerateAcw = true)]
	internal class IVisibleForTestingInvoker : Java.Lang.Object, IVisibleForTesting, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000060F8 File Offset: 0x000042F8
		private static IntPtr java_class_ref
		{
			get
			{
				return IVisibleForTestingInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000611C File Offset: 0x0000431C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVisibleForTestingInvoker._members;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006123 File Offset: 0x00004323
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000612B File Offset: 0x0000432B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVisibleForTestingInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006137 File Offset: 0x00004337
		[NullableContext(2)]
		public static IVisibleForTesting GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IVisibleForTesting>(handle, transfer);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006140 File Offset: 0x00004340
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVisibleForTestingInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.VisibleForTesting'.");
			}
			return handle;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000616B File Offset: 0x0000436B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000619C File Offset: 0x0000439C
		public IVisibleForTestingInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVisibleForTestingInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000061D4 File Offset: 0x000043D4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IVisibleForTestingInvoker.cb_annotationType == null)
			{
				IVisibleForTestingInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVisibleForTestingInvoker.n_AnnotationType));
			}
			return IVisibleForTestingInvoker.cb_annotationType;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000061F8 File Offset: 0x000043F8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IVisibleForTesting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000620C File Offset: 0x0000440C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000625D File Offset: 0x0000445D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IVisibleForTestingInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IVisibleForTestingInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IVisibleForTestingInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IVisibleForTestingInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006284 File Offset: 0x00004484
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IVisibleForTesting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000062A8 File Offset: 0x000044A8
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

		// Token: 0x060001E1 RID: 481 RVA: 0x0000631B File Offset: 0x0000451B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IVisibleForTestingInvoker.cb_hashCode == null)
			{
				IVisibleForTestingInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IVisibleForTestingInvoker.n_GetHashCode));
			}
			return IVisibleForTestingInvoker.cb_hashCode;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000633F File Offset: 0x0000453F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IVisibleForTesting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000634E File Offset: 0x0000454E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000638E File Offset: 0x0000458E
		private static Delegate GetToStringHandler()
		{
			if (IVisibleForTestingInvoker.cb_toString == null)
			{
				IVisibleForTestingInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IVisibleForTestingInvoker.n_ToString));
			}
			return IVisibleForTestingInvoker.cb_toString;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000063B2 File Offset: 0x000045B2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IVisibleForTesting>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000063C8 File Offset: 0x000045C8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000CB RID: 203
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/VisibleForTesting", typeof(IVisibleForTestingInvoker));

		// Token: 0x040000CC RID: 204
		private IntPtr class_ref;

		// Token: 0x040000CD RID: 205
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000CE RID: 206
		private IntPtr id_annotationType;

		// Token: 0x040000CF RID: 207
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000D0 RID: 208
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000D1 RID: 209
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000D2 RID: 210
		private IntPtr id_hashCode;

		// Token: 0x040000D3 RID: 211
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000D4 RID: 212
		private IntPtr id_toString;
	}
}
