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
	// Token: 0x02000167 RID: 359
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmSynthetic", DoNotGenerateAcw = true)]
	internal class IJvmSyntheticInvoker : Java.Lang.Object, IJvmSynthetic, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x0003CD00 File Offset: 0x0003AF00
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmSyntheticInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0003CD24 File Offset: 0x0003AF24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmSyntheticInvoker._members;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0003CD2B File Offset: 0x0003AF2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0003CD33 File Offset: 0x0003AF33
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmSyntheticInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0003CD3F File Offset: 0x0003AF3F
		[NullableContext(2)]
		public static IJvmSynthetic GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmSynthetic>(handle, transfer);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0003CD48 File Offset: 0x0003AF48
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmSyntheticInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmSynthetic'.");
			}
			return handle;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0003CD73 File Offset: 0x0003AF73
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
		public IJvmSyntheticInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmSyntheticInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0003CDDC File Offset: 0x0003AFDC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmSyntheticInvoker.cb_annotationType == null)
			{
				IJvmSyntheticInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSyntheticInvoker.n_AnnotationType));
			}
			return IJvmSyntheticInvoker.cb_annotationType;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0003CE00 File Offset: 0x0003B000
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmSynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0003CE14 File Offset: 0x0003B014
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0003CE65 File Offset: 0x0003B065
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmSyntheticInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmSyntheticInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmSyntheticInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmSyntheticInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0003CE8C File Offset: 0x0003B08C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmSynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0003CEB0 File Offset: 0x0003B0B0
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

		// Token: 0x06001291 RID: 4753 RVA: 0x0003CF23 File Offset: 0x0003B123
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmSyntheticInvoker.cb_hashCode == null)
			{
				IJvmSyntheticInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmSyntheticInvoker.n_GetHashCode));
			}
			return IJvmSyntheticInvoker.cb_hashCode;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0003CF47 File Offset: 0x0003B147
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmSynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0003CF56 File Offset: 0x0003B156
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0003CF96 File Offset: 0x0003B196
		private static Delegate GetToStringHandler()
		{
			if (IJvmSyntheticInvoker.cb_toString == null)
			{
				IJvmSyntheticInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSyntheticInvoker.n_ToString));
			}
			return IJvmSyntheticInvoker.cb_toString;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0003CFBA File Offset: 0x0003B1BA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmSynthetic>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0003CFD0 File Offset: 0x0003B1D0
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400061B RID: 1563
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmSynthetic", typeof(IJvmSyntheticInvoker));

		// Token: 0x0400061C RID: 1564
		private IntPtr class_ref;

		// Token: 0x0400061D RID: 1565
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400061E RID: 1566
		private IntPtr id_annotationType;

		// Token: 0x0400061F RID: 1567
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000620 RID: 1568
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000621 RID: 1569
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000622 RID: 1570
		private IntPtr id_hashCode;

		// Token: 0x04000623 RID: 1571
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000624 RID: 1572
		private IntPtr id_toString;
	}
}
