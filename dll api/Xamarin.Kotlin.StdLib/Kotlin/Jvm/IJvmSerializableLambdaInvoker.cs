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
	// Token: 0x02000161 RID: 353
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmSerializableLambda", DoNotGenerateAcw = true)]
	internal class IJvmSerializableLambdaInvoker : Java.Lang.Object, IJvmSerializableLambda, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmSerializableLambdaInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x0003C2FC File Offset: 0x0003A4FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmSerializableLambdaInvoker._members;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0003C303 File Offset: 0x0003A503
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0003C30B File Offset: 0x0003A50B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmSerializableLambdaInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0003C317 File Offset: 0x0003A517
		[NullableContext(2)]
		public static IJvmSerializableLambda GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmSerializableLambda>(handle, transfer);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0003C320 File Offset: 0x0003A520
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmSerializableLambdaInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmSerializableLambda'.");
			}
			return handle;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0003C34B File Offset: 0x0003A54B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0003C37C File Offset: 0x0003A57C
		public IJvmSerializableLambdaInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmSerializableLambdaInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmSerializableLambdaInvoker.cb_annotationType == null)
			{
				IJvmSerializableLambdaInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSerializableLambdaInvoker.n_AnnotationType));
			}
			return IJvmSerializableLambdaInvoker.cb_annotationType;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0003C3D8 File Offset: 0x0003A5D8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmSerializableLambda>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0003C3EC File Offset: 0x0003A5EC
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0003C43D File Offset: 0x0003A63D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmSerializableLambdaInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmSerializableLambdaInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmSerializableLambdaInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmSerializableLambdaInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0003C464 File Offset: 0x0003A664
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmSerializableLambda>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0003C488 File Offset: 0x0003A688
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

		// Token: 0x0600124E RID: 4686 RVA: 0x0003C4FB File Offset: 0x0003A6FB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmSerializableLambdaInvoker.cb_hashCode == null)
			{
				IJvmSerializableLambdaInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmSerializableLambdaInvoker.n_GetHashCode));
			}
			return IJvmSerializableLambdaInvoker.cb_hashCode;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0003C51F File Offset: 0x0003A71F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmSerializableLambda>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0003C52E File Offset: 0x0003A72E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0003C56E File Offset: 0x0003A76E
		private static Delegate GetToStringHandler()
		{
			if (IJvmSerializableLambdaInvoker.cb_toString == null)
			{
				IJvmSerializableLambdaInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSerializableLambdaInvoker.n_ToString));
			}
			return IJvmSerializableLambdaInvoker.cb_toString;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0003C592 File Offset: 0x0003A792
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmSerializableLambda>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0003C5A8 File Offset: 0x0003A7A8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005FB RID: 1531
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmSerializableLambda", typeof(IJvmSerializableLambdaInvoker));

		// Token: 0x040005FC RID: 1532
		private IntPtr class_ref;

		// Token: 0x040005FD RID: 1533
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005FE RID: 1534
		private IntPtr id_annotationType;

		// Token: 0x040005FF RID: 1535
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000600 RID: 1536
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000601 RID: 1537
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000602 RID: 1538
		private IntPtr id_hashCode;

		// Token: 0x04000603 RID: 1539
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000604 RID: 1540
		private IntPtr id_toString;
	}
}
