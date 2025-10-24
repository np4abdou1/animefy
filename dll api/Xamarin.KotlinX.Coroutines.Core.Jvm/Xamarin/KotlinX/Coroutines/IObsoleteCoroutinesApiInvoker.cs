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
	// Token: 0x02000070 RID: 112
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ObsoleteCoroutinesApi", DoNotGenerateAcw = true)]
	internal class IObsoleteCoroutinesApiInvoker : Java.Lang.Object, IObsoleteCoroutinesApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		private static IntPtr java_class_ref
		{
			get
			{
				return IObsoleteCoroutinesApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000F410 File Offset: 0x0000D610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IObsoleteCoroutinesApiInvoker._members;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000F417 File Offset: 0x0000D617
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000F41F File Offset: 0x0000D61F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IObsoleteCoroutinesApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000F42B File Offset: 0x0000D62B
		[NullableContext(2)]
		public static IObsoleteCoroutinesApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IObsoleteCoroutinesApi>(handle, transfer);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000F434 File Offset: 0x0000D634
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IObsoleteCoroutinesApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.ObsoleteCoroutinesApi'.");
			}
			return handle;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000F45F File Offset: 0x0000D65F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000F490 File Offset: 0x0000D690
		public IObsoleteCoroutinesApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IObsoleteCoroutinesApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IObsoleteCoroutinesApiInvoker.cb_annotationType == null)
			{
				IObsoleteCoroutinesApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IObsoleteCoroutinesApiInvoker.n_AnnotationType));
			}
			return IObsoleteCoroutinesApiInvoker.cb_annotationType;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000F4EC File Offset: 0x0000D6EC
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IObsoleteCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000F500 File Offset: 0x0000D700
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000F551 File Offset: 0x0000D751
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IObsoleteCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IObsoleteCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IObsoleteCoroutinesApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IObsoleteCoroutinesApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000F578 File Offset: 0x0000D778
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IObsoleteCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000F59C File Offset: 0x0000D79C
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

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000F60F File Offset: 0x0000D80F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IObsoleteCoroutinesApiInvoker.cb_hashCode == null)
			{
				IObsoleteCoroutinesApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IObsoleteCoroutinesApiInvoker.n_GetHashCode));
			}
			return IObsoleteCoroutinesApiInvoker.cb_hashCode;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000F633 File Offset: 0x0000D833
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IObsoleteCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000F642 File Offset: 0x0000D842
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000F682 File Offset: 0x0000D882
		private static Delegate GetToStringHandler()
		{
			if (IObsoleteCoroutinesApiInvoker.cb_toString == null)
			{
				IObsoleteCoroutinesApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IObsoleteCoroutinesApiInvoker.n_ToString));
			}
			return IObsoleteCoroutinesApiInvoker.cb_toString;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000F6A6 File Offset: 0x0000D8A6
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IObsoleteCoroutinesApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001A8 RID: 424
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ObsoleteCoroutinesApi", typeof(IObsoleteCoroutinesApiInvoker));

		// Token: 0x040001A9 RID: 425
		private IntPtr class_ref;

		// Token: 0x040001AA RID: 426
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040001AB RID: 427
		private IntPtr id_annotationType;

		// Token: 0x040001AC RID: 428
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001AD RID: 429
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001AE RID: 430
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040001AF RID: 431
		private IntPtr id_hashCode;

		// Token: 0x040001B0 RID: 432
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040001B1 RID: 433
		private IntPtr id_toString;
	}
}
