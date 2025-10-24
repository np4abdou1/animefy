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
	// Token: 0x02000151 RID: 337
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmDefaultWithCompatibility", DoNotGenerateAcw = true)]
	internal class IJvmDefaultWithCompatibilityInvoker : Java.Lang.Object, IJvmDefaultWithCompatibility, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x0003A86C File Offset: 0x00038A6C
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmDefaultWithCompatibilityInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0003A890 File Offset: 0x00038A90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmDefaultWithCompatibilityInvoker._members;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0003A897 File Offset: 0x00038A97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0003A89F File Offset: 0x00038A9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmDefaultWithCompatibilityInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0003A8AB File Offset: 0x00038AAB
		[NullableContext(2)]
		public static IJvmDefaultWithCompatibility GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmDefaultWithCompatibility>(handle, transfer);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0003A8B4 File Offset: 0x00038AB4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmDefaultWithCompatibilityInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmDefaultWithCompatibility'.");
			}
			return handle;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0003A8DF File Offset: 0x00038ADF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0003A910 File Offset: 0x00038B10
		public IJvmDefaultWithCompatibilityInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmDefaultWithCompatibilityInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0003A948 File Offset: 0x00038B48
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmDefaultWithCompatibilityInvoker.cb_annotationType == null)
			{
				IJvmDefaultWithCompatibilityInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultWithCompatibilityInvoker.n_AnnotationType));
			}
			return IJvmDefaultWithCompatibilityInvoker.cb_annotationType;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0003A96C File Offset: 0x00038B6C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmDefaultWithCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0003A980 File Offset: 0x00038B80
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003A9D1 File Offset: 0x00038BD1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmDefaultWithCompatibilityInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmDefaultWithCompatibilityInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmDefaultWithCompatibilityInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmDefaultWithCompatibilityInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003A9F8 File Offset: 0x00038BF8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmDefaultWithCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0003AA1C File Offset: 0x00038C1C
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

		// Token: 0x060011A2 RID: 4514 RVA: 0x0003AA8F File Offset: 0x00038C8F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmDefaultWithCompatibilityInvoker.cb_hashCode == null)
			{
				IJvmDefaultWithCompatibilityInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmDefaultWithCompatibilityInvoker.n_GetHashCode));
			}
			return IJvmDefaultWithCompatibilityInvoker.cb_hashCode;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0003AAB3 File Offset: 0x00038CB3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmDefaultWithCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003AAC2 File Offset: 0x00038CC2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0003AB02 File Offset: 0x00038D02
		private static Delegate GetToStringHandler()
		{
			if (IJvmDefaultWithCompatibilityInvoker.cb_toString == null)
			{
				IJvmDefaultWithCompatibilityInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultWithCompatibilityInvoker.n_ToString));
			}
			return IJvmDefaultWithCompatibilityInvoker.cb_toString;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0003AB26 File Offset: 0x00038D26
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmDefaultWithCompatibility>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0003AB3C File Offset: 0x00038D3C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmDefaultWithCompatibility", typeof(IJvmDefaultWithCompatibilityInvoker));

		// Token: 0x040005AA RID: 1450
		private IntPtr class_ref;

		// Token: 0x040005AB RID: 1451
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005AC RID: 1452
		private IntPtr id_annotationType;

		// Token: 0x040005AD RID: 1453
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005AE RID: 1454
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005AF RID: 1455
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005B0 RID: 1456
		private IntPtr id_hashCode;

		// Token: 0x040005B1 RID: 1457
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005B2 RID: 1458
		private IntPtr id_toString;
	}
}
