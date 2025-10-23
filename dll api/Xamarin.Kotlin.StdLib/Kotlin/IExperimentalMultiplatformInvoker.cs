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
	// Token: 0x02000060 RID: 96
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ExperimentalMultiplatform", DoNotGenerateAcw = true)]
	internal class IExperimentalMultiplatformInvoker : Java.Lang.Object, IExperimentalMultiplatform, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00004750 File Offset: 0x00002950
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalMultiplatformInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00004774 File Offset: 0x00002974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalMultiplatformInvoker._members;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000477B File Offset: 0x0000297B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00004783 File Offset: 0x00002983
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalMultiplatformInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000478F File Offset: 0x0000298F
		[NullableContext(2)]
		public static IExperimentalMultiplatform GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalMultiplatform>(handle, transfer);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004798 File Offset: 0x00002998
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalMultiplatformInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.ExperimentalMultiplatform'.");
			}
			return handle;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000047C3 File Offset: 0x000029C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000047F4 File Offset: 0x000029F4
		public IExperimentalMultiplatformInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalMultiplatformInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000482C File Offset: 0x00002A2C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalMultiplatformInvoker.cb_annotationType == null)
			{
				IExperimentalMultiplatformInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalMultiplatformInvoker.n_AnnotationType));
			}
			return IExperimentalMultiplatformInvoker.cb_annotationType;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004850 File Offset: 0x00002A50
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalMultiplatform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004864 File Offset: 0x00002A64
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000048B5 File Offset: 0x00002AB5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalMultiplatformInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalMultiplatformInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalMultiplatformInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalMultiplatformInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000048DC File Offset: 0x00002ADC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalMultiplatform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00004900 File Offset: 0x00002B00
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

		// Token: 0x060001F1 RID: 497 RVA: 0x00004973 File Offset: 0x00002B73
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalMultiplatformInvoker.cb_hashCode == null)
			{
				IExperimentalMultiplatformInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalMultiplatformInvoker.n_GetHashCode));
			}
			return IExperimentalMultiplatformInvoker.cb_hashCode;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00004997 File Offset: 0x00002B97
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalMultiplatform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000049A6 File Offset: 0x00002BA6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000049E6 File Offset: 0x00002BE6
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalMultiplatformInvoker.cb_toString == null)
			{
				IExperimentalMultiplatformInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalMultiplatformInvoker.n_ToString));
			}
			return IExperimentalMultiplatformInvoker.cb_toString;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004A0A File Offset: 0x00002C0A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalMultiplatform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00004A20 File Offset: 0x00002C20
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000060 RID: 96
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ExperimentalMultiplatform", typeof(IExperimentalMultiplatformInvoker));

		// Token: 0x04000061 RID: 97
		private IntPtr class_ref;

		// Token: 0x04000062 RID: 98
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000063 RID: 99
		private IntPtr id_annotationType;

		// Token: 0x04000064 RID: 100
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000065 RID: 101
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000066 RID: 102
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000067 RID: 103
		private IntPtr id_hashCode;

		// Token: 0x04000068 RID: 104
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000069 RID: 105
		private IntPtr id_toString;
	}
}
