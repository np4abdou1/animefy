using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000155 RID: 341
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmField", DoNotGenerateAcw = true)]
	internal class IJvmFieldInvoker : Java.Lang.Object, IJvmField, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0003AEE4 File Offset: 0x000390E4
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmFieldInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0003AF08 File Offset: 0x00039108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmFieldInvoker._members;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0003AF0F File Offset: 0x0003910F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0003AF17 File Offset: 0x00039117
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmFieldInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0003AF23 File Offset: 0x00039123
		[NullableContext(2)]
		public static IJvmField GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmField>(handle, transfer);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0003AF2C File Offset: 0x0003912C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmFieldInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmField'.");
			}
			return handle;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0003AF57 File Offset: 0x00039157
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0003AF88 File Offset: 0x00039188
		public IJvmFieldInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmFieldInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0003AFC0 File Offset: 0x000391C0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmFieldInvoker.cb_annotationType == null)
			{
				IJvmFieldInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmFieldInvoker.n_AnnotationType));
			}
			return IJvmFieldInvoker.cb_annotationType;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0003AFE4 File Offset: 0x000391E4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0003AFF8 File Offset: 0x000391F8
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0003B049 File Offset: 0x00039249
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmFieldInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmFieldInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmFieldInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmFieldInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0003B070 File Offset: 0x00039270
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0003B094 File Offset: 0x00039294
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

		// Token: 0x060011CC RID: 4556 RVA: 0x0003B107 File Offset: 0x00039307
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmFieldInvoker.cb_hashCode == null)
			{
				IJvmFieldInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmFieldInvoker.n_GetHashCode));
			}
			return IJvmFieldInvoker.cb_hashCode;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x0003B12B File Offset: 0x0003932B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0003B13A File Offset: 0x0003933A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0003B17A File Offset: 0x0003937A
		private static Delegate GetToStringHandler()
		{
			if (IJvmFieldInvoker.cb_toString == null)
			{
				IJvmFieldInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmFieldInvoker.n_ToString));
			}
			return IJvmFieldInvoker.cb_toString;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0003B19E File Offset: 0x0003939E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmField>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0003B1B4 File Offset: 0x000393B4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005BD RID: 1469
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmField", typeof(IJvmFieldInvoker));

		// Token: 0x040005BE RID: 1470
		private IntPtr class_ref;

		// Token: 0x040005BF RID: 1471
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005C0 RID: 1472
		private IntPtr id_annotationType;

		// Token: 0x040005C1 RID: 1473
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005C2 RID: 1474
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005C3 RID: 1475
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005C4 RID: 1476
		private IntPtr id_hashCode;

		// Token: 0x040005C5 RID: 1477
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005C6 RID: 1478
		private IntPtr id_toString;
	}
}
