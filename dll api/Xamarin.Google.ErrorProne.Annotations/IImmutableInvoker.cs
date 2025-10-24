using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000022 RID: 34
	[Register("com/google/errorprone/annotations/Immutable", DoNotGenerateAcw = true)]
	internal class IImmutableInvoker : Java.Lang.Object, IImmutable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003F4C File Offset: 0x0000214C
		private static IntPtr java_class_ref
		{
			get
			{
				return IImmutableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003F70 File Offset: 0x00002170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IImmutableInvoker._members;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003F77 File Offset: 0x00002177
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00003F7F File Offset: 0x0000217F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IImmutableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003F8B File Offset: 0x0000218B
		public static IImmutable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IImmutable>(handle, transfer);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003F94 File Offset: 0x00002194
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IImmutableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.Immutable'.");
			}
			return handle;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003FBF File Offset: 0x000021BF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003FF0 File Offset: 0x000021F0
		public IImmutableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IImmutableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004028 File Offset: 0x00002228
		private static Delegate GetContainerOfHandler()
		{
			if (IImmutableInvoker.cb_containerOf == null)
			{
				IImmutableInvoker.cb_containerOf = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IImmutableInvoker.n_ContainerOf));
			}
			return IImmutableInvoker.cb_containerOf;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000404C File Offset: 0x0000224C
		private static IntPtr n_ContainerOf(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IImmutable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContainerOf());
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004060 File Offset: 0x00002260
		public string[] ContainerOf()
		{
			if (this.id_containerOf == IntPtr.Zero)
			{
				this.id_containerOf = JNIEnv.GetMethodID(this.class_ref, "containerOf", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_containerOf), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000040C0 File Offset: 0x000022C0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IImmutableInvoker.cb_annotationType == null)
			{
				IImmutableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IImmutableInvoker.n_AnnotationType));
			}
			return IImmutableInvoker.cb_annotationType;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000040E4 File Offset: 0x000022E4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IImmutable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000040F8 File Offset: 0x000022F8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004149 File Offset: 0x00002349
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IImmutableInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IImmutableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IImmutableInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IImmutableInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00004170 File Offset: 0x00002370
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IImmutable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004194 File Offset: 0x00002394
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

		// Token: 0x060000F8 RID: 248 RVA: 0x00004207 File Offset: 0x00002407
		private static Delegate GetGetHashCodeHandler()
		{
			if (IImmutableInvoker.cb_hashCode == null)
			{
				IImmutableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IImmutableInvoker.n_GetHashCode));
			}
			return IImmutableInvoker.cb_hashCode;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000422B File Offset: 0x0000242B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IImmutable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000423A File Offset: 0x0000243A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000427A File Offset: 0x0000247A
		private static Delegate GetToStringHandler()
		{
			if (IImmutableInvoker.cb_toString == null)
			{
				IImmutableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IImmutableInvoker.n_ToString));
			}
			return IImmutableInvoker.cb_toString;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000429E File Offset: 0x0000249E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IImmutable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000042B4 File Offset: 0x000024B4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000064 RID: 100
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/Immutable", typeof(IImmutableInvoker));

		// Token: 0x04000065 RID: 101
		private IntPtr class_ref;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_containerOf;

		// Token: 0x04000067 RID: 103
		private IntPtr id_containerOf;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_annotationType;

		// Token: 0x04000069 RID: 105
		private IntPtr id_annotationType;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400006B RID: 107
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_hashCode;

		// Token: 0x0400006D RID: 109
		private IntPtr id_hashCode;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_toString;

		// Token: 0x0400006F RID: 111
		private IntPtr id_toString;
	}
}
