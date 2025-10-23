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
	// Token: 0x02000075 RID: 117
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/OverloadResolutionByLambdaReturnType", DoNotGenerateAcw = true)]
	internal class IOverloadResolutionByLambdaReturnTypeInvoker : Java.Lang.Object, IOverloadResolutionByLambdaReturnType, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00006994 File Offset: 0x00004B94
		private static IntPtr java_class_ref
		{
			get
			{
				return IOverloadResolutionByLambdaReturnTypeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000069B8 File Offset: 0x00004BB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOverloadResolutionByLambdaReturnTypeInvoker._members;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000069BF File Offset: 0x00004BBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000069C7 File Offset: 0x00004BC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOverloadResolutionByLambdaReturnTypeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000069D3 File Offset: 0x00004BD3
		[NullableContext(2)]
		public static IOverloadResolutionByLambdaReturnType GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOverloadResolutionByLambdaReturnType>(handle, transfer);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000069DC File Offset: 0x00004BDC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOverloadResolutionByLambdaReturnTypeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.OverloadResolutionByLambdaReturnType'.");
			}
			return handle;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00006A07 File Offset: 0x00004C07
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00006A38 File Offset: 0x00004C38
		public IOverloadResolutionByLambdaReturnTypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOverloadResolutionByLambdaReturnTypeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00006A70 File Offset: 0x00004C70
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IOverloadResolutionByLambdaReturnTypeInvoker.cb_annotationType == null)
			{
				IOverloadResolutionByLambdaReturnTypeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOverloadResolutionByLambdaReturnTypeInvoker.n_AnnotationType));
			}
			return IOverloadResolutionByLambdaReturnTypeInvoker.cb_annotationType;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00006A94 File Offset: 0x00004C94
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOverloadResolutionByLambdaReturnType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00006AA8 File Offset: 0x00004CA8
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00006AF9 File Offset: 0x00004CF9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IOverloadResolutionByLambdaReturnTypeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IOverloadResolutionByLambdaReturnTypeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IOverloadResolutionByLambdaReturnTypeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IOverloadResolutionByLambdaReturnTypeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00006B20 File Offset: 0x00004D20
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IOverloadResolutionByLambdaReturnType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00006B44 File Offset: 0x00004D44
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

		// Token: 0x060002DD RID: 733 RVA: 0x00006BB7 File Offset: 0x00004DB7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IOverloadResolutionByLambdaReturnTypeInvoker.cb_hashCode == null)
			{
				IOverloadResolutionByLambdaReturnTypeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IOverloadResolutionByLambdaReturnTypeInvoker.n_GetHashCode));
			}
			return IOverloadResolutionByLambdaReturnTypeInvoker.cb_hashCode;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00006BDB File Offset: 0x00004DDB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IOverloadResolutionByLambdaReturnType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00006BEA File Offset: 0x00004DEA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00006C2A File Offset: 0x00004E2A
		private static Delegate GetToStringHandler()
		{
			if (IOverloadResolutionByLambdaReturnTypeInvoker.cb_toString == null)
			{
				IOverloadResolutionByLambdaReturnTypeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOverloadResolutionByLambdaReturnTypeInvoker.n_ToString));
			}
			return IOverloadResolutionByLambdaReturnTypeInvoker.cb_toString;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00006C4E File Offset: 0x00004E4E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IOverloadResolutionByLambdaReturnType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00006C64 File Offset: 0x00004E64
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000CB RID: 203
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/OverloadResolutionByLambdaReturnType", typeof(IOverloadResolutionByLambdaReturnTypeInvoker));

		// Token: 0x040000CC RID: 204
		private IntPtr class_ref;

		// Token: 0x040000CD RID: 205
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040000CE RID: 206
		private IntPtr id_annotationType;

		// Token: 0x040000CF RID: 207
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000D0 RID: 208
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000D1 RID: 209
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040000D2 RID: 210
		private IntPtr id_hashCode;

		// Token: 0x040000D3 RID: 211
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000D4 RID: 212
		private IntPtr id_toString;
	}
}
