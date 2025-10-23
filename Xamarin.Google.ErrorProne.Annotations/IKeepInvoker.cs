using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200002A RID: 42
	[Register("com/google/errorprone/annotations/Keep", DoNotGenerateAcw = true)]
	internal class IKeepInvoker : Java.Lang.Object, IKeep, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00004FB4 File Offset: 0x000031B4
		private static IntPtr java_class_ref
		{
			get
			{
				return IKeepInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00004FD8 File Offset: 0x000031D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKeepInvoker._members;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00004FDF File Offset: 0x000031DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00004FE7 File Offset: 0x000031E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKeepInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00004FF3 File Offset: 0x000031F3
		public static IKeep GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKeep>(handle, transfer);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00004FFC File Offset: 0x000031FC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKeepInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.Keep'.");
			}
			return handle;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005027 File Offset: 0x00003227
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005058 File Offset: 0x00003258
		public IKeepInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKeepInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005090 File Offset: 0x00003290
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IKeepInvoker.cb_annotationType == null)
			{
				IKeepInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKeepInvoker.n_AnnotationType));
			}
			return IKeepInvoker.cb_annotationType;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000050B4 File Offset: 0x000032B4
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKeep>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000050C8 File Offset: 0x000032C8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005119 File Offset: 0x00003319
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IKeepInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IKeepInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IKeepInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IKeepInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005140 File Offset: 0x00003340
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IKeep>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005164 File Offset: 0x00003364
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

		// Token: 0x06000160 RID: 352 RVA: 0x000051D7 File Offset: 0x000033D7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IKeepInvoker.cb_hashCode == null)
			{
				IKeepInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IKeepInvoker.n_GetHashCode));
			}
			return IKeepInvoker.cb_hashCode;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000051FB File Offset: 0x000033FB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKeep>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000520A File Offset: 0x0000340A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000524A File Offset: 0x0000344A
		private static Delegate GetToStringHandler()
		{
			if (IKeepInvoker.cb_toString == null)
			{
				IKeepInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKeepInvoker.n_ToString));
			}
			return IKeepInvoker.cb_toString;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000526E File Offset: 0x0000346E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKeep>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005284 File Offset: 0x00003484
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000098 RID: 152
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/Keep", typeof(IKeepInvoker));

		// Token: 0x04000099 RID: 153
		private IntPtr class_ref;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_annotationType;

		// Token: 0x0400009B RID: 155
		private IntPtr id_annotationType;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400009D RID: 157
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_hashCode;

		// Token: 0x0400009F RID: 159
		private IntPtr id_hashCode;

		// Token: 0x040000A0 RID: 160
		private static Delegate cb_toString;

		// Token: 0x040000A1 RID: 161
		private IntPtr id_toString;
	}
}
