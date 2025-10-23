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
	// Token: 0x0200007B RID: 123
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ReplaceWith", DoNotGenerateAcw = true)]
	internal class IReplaceWithInvoker : Java.Lang.Object, IReplaceWith, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000073D4 File Offset: 0x000055D4
		private static IntPtr java_class_ref
		{
			get
			{
				return IReplaceWithInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000073F8 File Offset: 0x000055F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IReplaceWithInvoker._members;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000073FF File Offset: 0x000055FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00007407 File Offset: 0x00005607
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IReplaceWithInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00007413 File Offset: 0x00005613
		[NullableContext(2)]
		public static IReplaceWith GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IReplaceWith>(handle, transfer);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000741C File Offset: 0x0000561C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IReplaceWithInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ReplaceWith'.");
			}
			return handle;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00007447 File Offset: 0x00005647
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00007478 File Offset: 0x00005678
		public IReplaceWithInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IReplaceWithInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000074B0 File Offset: 0x000056B0
		private static Delegate GetExpressionHandler()
		{
			if (IReplaceWithInvoker.cb_expression == null)
			{
				IReplaceWithInvoker.cb_expression = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReplaceWithInvoker.n_Expression));
			}
			return IReplaceWithInvoker.cb_expression;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000074D4 File Offset: 0x000056D4
		private static IntPtr n_Expression(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Expression());
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000074E8 File Offset: 0x000056E8
		[NullableContext(2)]
		public string Expression()
		{
			if (this.id_expression == IntPtr.Zero)
			{
				this.id_expression = JNIEnv.GetMethodID(this.class_ref, "expression", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_expression), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00007539 File Offset: 0x00005739
		private static Delegate GetImportsHandler()
		{
			if (IReplaceWithInvoker.cb_imports == null)
			{
				IReplaceWithInvoker.cb_imports = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReplaceWithInvoker.n_Imports));
			}
			return IReplaceWithInvoker.cb_imports;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000755D File Offset: 0x0000575D
		private static IntPtr n_Imports(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Imports());
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00007574 File Offset: 0x00005774
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] Imports()
		{
			if (this.id_imports == IntPtr.Zero)
			{
				this.id_imports = JNIEnv.GetMethodID(this.class_ref, "imports", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_imports), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000075D4 File Offset: 0x000057D4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IReplaceWithInvoker.cb_annotationType == null)
			{
				IReplaceWithInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReplaceWithInvoker.n_AnnotationType));
			}
			return IReplaceWithInvoker.cb_annotationType;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000075F8 File Offset: 0x000057F8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000760C File Offset: 0x0000580C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000765D File Offset: 0x0000585D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IReplaceWithInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IReplaceWithInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IReplaceWithInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IReplaceWithInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00007684 File Offset: 0x00005884
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000076A8 File Offset: 0x000058A8
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

		// Token: 0x06000328 RID: 808 RVA: 0x0000771B File Offset: 0x0000591B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IReplaceWithInvoker.cb_hashCode == null)
			{
				IReplaceWithInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IReplaceWithInvoker.n_GetHashCode));
			}
			return IReplaceWithInvoker.cb_hashCode;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000773F File Offset: 0x0000593F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000774E File Offset: 0x0000594E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000778E File Offset: 0x0000598E
		private static Delegate GetToStringHandler()
		{
			if (IReplaceWithInvoker.cb_toString == null)
			{
				IReplaceWithInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IReplaceWithInvoker.n_ToString));
			}
			return IReplaceWithInvoker.cb_toString;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000077B2 File Offset: 0x000059B2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IReplaceWith>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600032D RID: 813 RVA: 0x000077C8 File Offset: 0x000059C8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000EB RID: 235
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ReplaceWith", typeof(IReplaceWithInvoker));

		// Token: 0x040000EC RID: 236
		private IntPtr class_ref;

		// Token: 0x040000ED RID: 237
		[Nullable(2)]
		private static Delegate cb_expression;

		// Token: 0x040000EE RID: 238
		private IntPtr id_expression;

		// Token: 0x040000EF RID: 239
		[Nullable(2)]
		private static Delegate cb_imports;

		// Token: 0x040000F0 RID: 240
		private IntPtr id_imports;

		// Token: 0x040000F1 RID: 241
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000F2 RID: 242
		private IntPtr id_annotationType;

		// Token: 0x040000F3 RID: 243
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000F4 RID: 244
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000F5 RID: 245
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000F6 RID: 246
		private IntPtr id_hashCode;

		// Token: 0x040000F7 RID: 247
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000F8 RID: 248
		private IntPtr id_toString;
	}
}
