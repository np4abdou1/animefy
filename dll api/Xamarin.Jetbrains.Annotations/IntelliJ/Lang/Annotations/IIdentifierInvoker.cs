using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200004E RID: 78
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Identifier", DoNotGenerateAcw = true)]
	internal class IIdentifierInvoker : Java.Lang.Object, IIdentifier, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00006BB0 File Offset: 0x00004DB0
		private static IntPtr java_class_ref
		{
			get
			{
				return IIdentifierInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00006BD4 File Offset: 0x00004DD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIdentifierInvoker._members;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00006BDB File Offset: 0x00004DDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00006BE3 File Offset: 0x00004DE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIdentifierInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00006BEF File Offset: 0x00004DEF
		[NullableContext(2)]
		public static IIdentifier GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIdentifier>(handle, transfer);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00006BF8 File Offset: 0x00004DF8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIdentifierInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.Identifier'.");
			}
			return handle;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00006C23 File Offset: 0x00004E23
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00006C54 File Offset: 0x00004E54
		public IIdentifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIdentifierInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00006C8C File Offset: 0x00004E8C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IIdentifierInvoker.cb_annotationType == null)
			{
				IIdentifierInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIdentifierInvoker.n_AnnotationType));
			}
			return IIdentifierInvoker.cb_annotationType;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00006CB0 File Offset: 0x00004EB0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIdentifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00006CC4 File Offset: 0x00004EC4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00006D15 File Offset: 0x00004F15
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IIdentifierInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IIdentifierInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IIdentifierInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IIdentifierInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00006D3C File Offset: 0x00004F3C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IIdentifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00006D60 File Offset: 0x00004F60
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

		// Token: 0x06000248 RID: 584 RVA: 0x00006DD3 File Offset: 0x00004FD3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IIdentifierInvoker.cb_hashCode == null)
			{
				IIdentifierInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIdentifierInvoker.n_GetHashCode));
			}
			return IIdentifierInvoker.cb_hashCode;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00006DF7 File Offset: 0x00004FF7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIdentifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00006E06 File Offset: 0x00005006
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00006E46 File Offset: 0x00005046
		private static Delegate GetToStringHandler()
		{
			if (IIdentifierInvoker.cb_toString == null)
			{
				IIdentifierInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIdentifierInvoker.n_ToString));
			}
			return IIdentifierInvoker.cb_toString;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00006E6A File Offset: 0x0000506A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IIdentifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00006E80 File Offset: 0x00005080
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000F9 RID: 249
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/Identifier", typeof(IIdentifierInvoker));

		// Token: 0x040000FA RID: 250
		private IntPtr class_ref;

		// Token: 0x040000FB RID: 251
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000FC RID: 252
		private IntPtr id_annotationType;

		// Token: 0x040000FD RID: 253
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000FE RID: 254
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000FF RID: 255
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000100 RID: 256
		private IntPtr id_hashCode;

		// Token: 0x04000101 RID: 257
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000102 RID: 258
		private IntPtr id_toString;
	}
}
