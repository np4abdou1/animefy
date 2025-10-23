using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000024 RID: 36
	[Register("com/google/errorprone/annotations/IncompatibleModifiers", DoNotGenerateAcw = true)]
	internal class IIncompatibleModifiersInvoker : Java.Lang.Object, IIncompatibleModifiers, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004320 File Offset: 0x00002520
		private static IntPtr java_class_ref
		{
			get
			{
				return IIncompatibleModifiersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004344 File Offset: 0x00002544
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIncompatibleModifiersInvoker._members;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000434B File Offset: 0x0000254B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004353 File Offset: 0x00002553
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIncompatibleModifiersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000435F File Offset: 0x0000255F
		public static IIncompatibleModifiers GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IIncompatibleModifiers>(handle, transfer);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004368 File Offset: 0x00002568
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIncompatibleModifiersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.IncompatibleModifiers'.");
			}
			return handle;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004393 File Offset: 0x00002593
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000043C4 File Offset: 0x000025C4
		public IIncompatibleModifiersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIncompatibleModifiersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000043FC File Offset: 0x000025FC
		private static Delegate GetModifierHandler()
		{
			if (IIncompatibleModifiersInvoker.cb_modifier == null)
			{
				IIncompatibleModifiersInvoker.cb_modifier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIncompatibleModifiersInvoker.n_Modifier));
			}
			return IIncompatibleModifiersInvoker.cb_modifier;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004420 File Offset: 0x00002620
		private static IntPtr n_Modifier(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Modifier>(Java.Lang.Object.GetObject<IIncompatibleModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modifier());
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004434 File Offset: 0x00002634
		public Modifier[] Modifier()
		{
			if (this.id_modifier == IntPtr.Zero)
			{
				this.id_modifier = JNIEnv.GetMethodID(this.class_ref, "modifier", "()[Lcom/google/errorprone/annotations/Modifier;");
			}
			return (Modifier[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_modifier), JniHandleOwnership.TransferLocalRef, typeof(Modifier));
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004494 File Offset: 0x00002694
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IIncompatibleModifiersInvoker.cb_annotationType == null)
			{
				IIncompatibleModifiersInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIncompatibleModifiersInvoker.n_AnnotationType));
			}
			return IIncompatibleModifiersInvoker.cb_annotationType;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000044B8 File Offset: 0x000026B8
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IIncompatibleModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000044CC File Offset: 0x000026CC
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000451D File Offset: 0x0000271D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IIncompatibleModifiersInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IIncompatibleModifiersInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IIncompatibleModifiersInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IIncompatibleModifiersInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004544 File Offset: 0x00002744
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IIncompatibleModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004568 File Offset: 0x00002768
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

		// Token: 0x06000111 RID: 273 RVA: 0x000045DB File Offset: 0x000027DB
		private static Delegate GetGetHashCodeHandler()
		{
			if (IIncompatibleModifiersInvoker.cb_hashCode == null)
			{
				IIncompatibleModifiersInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IIncompatibleModifiersInvoker.n_GetHashCode));
			}
			return IIncompatibleModifiersInvoker.cb_hashCode;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000045FF File Offset: 0x000027FF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IIncompatibleModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000460E File Offset: 0x0000280E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000464E File Offset: 0x0000284E
		private static Delegate GetToStringHandler()
		{
			if (IIncompatibleModifiersInvoker.cb_toString == null)
			{
				IIncompatibleModifiersInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIncompatibleModifiersInvoker.n_ToString));
			}
			return IIncompatibleModifiersInvoker.cb_toString;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004672 File Offset: 0x00002872
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IIncompatibleModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004688 File Offset: 0x00002888
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000070 RID: 112
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/IncompatibleModifiers", typeof(IIncompatibleModifiersInvoker));

		// Token: 0x04000071 RID: 113
		private IntPtr class_ref;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_modifier;

		// Token: 0x04000073 RID: 115
		private IntPtr id_modifier;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_annotationType;

		// Token: 0x04000075 RID: 117
		private IntPtr id_annotationType;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000077 RID: 119
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_hashCode;

		// Token: 0x04000079 RID: 121
		private IntPtr id_hashCode;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_toString;

		// Token: 0x0400007B RID: 123
		private IntPtr id_toString;
	}
}
