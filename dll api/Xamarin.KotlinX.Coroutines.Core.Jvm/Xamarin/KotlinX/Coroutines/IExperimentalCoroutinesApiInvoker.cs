using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000062 RID: 98
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ExperimentalCoroutinesApi", DoNotGenerateAcw = true)]
	internal class IExperimentalCoroutinesApiInvoker : Java.Lang.Object, IExperimentalCoroutinesApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000D684 File Offset: 0x0000B884
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalCoroutinesApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalCoroutinesApiInvoker._members;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000D6AF File Offset: 0x0000B8AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000D6B7 File Offset: 0x0000B8B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalCoroutinesApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000D6C3 File Offset: 0x0000B8C3
		[NullableContext(2)]
		public static IExperimentalCoroutinesApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalCoroutinesApi>(handle, transfer);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalCoroutinesApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ExperimentalCoroutinesApi'.");
			}
			return handle;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000D6F7 File Offset: 0x0000B8F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000D728 File Offset: 0x0000B928
		public IExperimentalCoroutinesApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalCoroutinesApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000D760 File Offset: 0x0000B960
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalCoroutinesApiInvoker.cb_annotationType == null)
			{
				IExperimentalCoroutinesApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalCoroutinesApiInvoker.n_AnnotationType));
			}
			return IExperimentalCoroutinesApiInvoker.cb_annotationType;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000D784 File Offset: 0x0000B984
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000D798 File Offset: 0x0000B998
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000D7E9 File Offset: 0x0000B9E9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalCoroutinesApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000D810 File Offset: 0x0000BA10
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000D834 File Offset: 0x0000BA34
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalCoroutinesApiInvoker.cb_hashCode == null)
			{
				IExperimentalCoroutinesApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalCoroutinesApiInvoker.n_GetHashCode));
			}
			return IExperimentalCoroutinesApiInvoker.cb_hashCode;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D8CB File Offset: 0x0000BACB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D8DA File Offset: 0x0000BADA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000D91A File Offset: 0x0000BB1A
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalCoroutinesApiInvoker.cb_toString == null)
			{
				IExperimentalCoroutinesApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalCoroutinesApiInvoker.n_ToString));
			}
			return IExperimentalCoroutinesApiInvoker.cb_toString;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000D93E File Offset: 0x0000BB3E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000D954 File Offset: 0x0000BB54
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400015E RID: 350
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ExperimentalCoroutinesApi", typeof(IExperimentalCoroutinesApiInvoker));

		// Token: 0x0400015F RID: 351
		private IntPtr class_ref;

		// Token: 0x04000160 RID: 352
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000161 RID: 353
		private IntPtr id_annotationType;

		// Token: 0x04000162 RID: 354
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000163 RID: 355
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000164 RID: 356
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000165 RID: 357
		private IntPtr id_hashCode;

		// Token: 0x04000166 RID: 358
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000167 RID: 359
		private IntPtr id_toString;
	}
}
