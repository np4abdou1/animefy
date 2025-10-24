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
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DelicateCoroutinesApi", DoNotGenerateAcw = true)]
	internal class IDelicateCoroutinesApiInvoker : Java.Lang.Object, IDelicateCoroutinesApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		private static IntPtr java_class_ref
		{
			get
			{
				return IDelicateCoroutinesApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0000D200 File Offset: 0x0000B400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDelicateCoroutinesApiInvoker._members;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000D207 File Offset: 0x0000B407
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0000D20F File Offset: 0x0000B40F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDelicateCoroutinesApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000D21B File Offset: 0x0000B41B
		[NullableContext(2)]
		public static IDelicateCoroutinesApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDelicateCoroutinesApi>(handle, transfer);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000D224 File Offset: 0x0000B424
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDelicateCoroutinesApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.DelicateCoroutinesApi'.");
			}
			return handle;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000D24F File Offset: 0x0000B44F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000D280 File Offset: 0x0000B480
		public IDelicateCoroutinesApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDelicateCoroutinesApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDelicateCoroutinesApiInvoker.cb_annotationType == null)
			{
				IDelicateCoroutinesApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDelicateCoroutinesApiInvoker.n_AnnotationType));
			}
			return IDelicateCoroutinesApiInvoker.cb_annotationType;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDelicateCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000D341 File Offset: 0x0000B541
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDelicateCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDelicateCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDelicateCoroutinesApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDelicateCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000D368 File Offset: 0x0000B568
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDelicateCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000D38C File Offset: 0x0000B58C
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

		// Token: 0x060003D5 RID: 981 RVA: 0x0000D3FF File Offset: 0x0000B5FF
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDelicateCoroutinesApiInvoker.cb_hashCode == null)
			{
				IDelicateCoroutinesApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDelicateCoroutinesApiInvoker.n_GetHashCode));
			}
			return IDelicateCoroutinesApiInvoker.cb_hashCode;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000D423 File Offset: 0x0000B623
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDelicateCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000D432 File Offset: 0x0000B632
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000D472 File Offset: 0x0000B672
		private static Delegate GetToStringHandler()
		{
			if (IDelicateCoroutinesApiInvoker.cb_toString == null)
			{
				IDelicateCoroutinesApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDelicateCoroutinesApiInvoker.n_ToString));
			}
			return IDelicateCoroutinesApiInvoker.cb_toString;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000D496 File Offset: 0x0000B696
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDelicateCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000150 RID: 336
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DelicateCoroutinesApi", typeof(IDelicateCoroutinesApiInvoker));

		// Token: 0x04000151 RID: 337
		private IntPtr class_ref;

		// Token: 0x04000152 RID: 338
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000153 RID: 339
		private IntPtr id_annotationType;

		// Token: 0x04000154 RID: 340
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000155 RID: 341
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000156 RID: 342
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000157 RID: 343
		private IntPtr id_hashCode;

		// Token: 0x04000158 RID: 344
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000159 RID: 345
		private IntPtr id_toString;
	}
}
