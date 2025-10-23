using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.IO.Path
{
	// Token: 0x0200022E RID: 558
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/ExperimentalPathApi", DoNotGenerateAcw = true)]
	internal class IExperimentalPathApiInvoker : Java.Lang.Object, IExperimentalPathApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00056738 File Offset: 0x00054938
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalPathApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0005675C File Offset: 0x0005495C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalPathApiInvoker._members;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00056763 File Offset: 0x00054963
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0005676B File Offset: 0x0005496B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalPathApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00056777 File Offset: 0x00054977
		[NullableContext(2)]
		public static IExperimentalPathApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalPathApi>(handle, transfer);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00056780 File Offset: 0x00054980
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalPathApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.io.path.ExperimentalPathApi'.");
			}
			return handle;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x000567AB File Offset: 0x000549AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000567DC File Offset: 0x000549DC
		public IExperimentalPathApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalPathApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00056814 File Offset: 0x00054A14
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalPathApiInvoker.cb_annotationType == null)
			{
				IExperimentalPathApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalPathApiInvoker.n_AnnotationType));
			}
			return IExperimentalPathApiInvoker.cb_annotationType;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00056838 File Offset: 0x00054A38
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalPathApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0005684C File Offset: 0x00054A4C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0005689D File Offset: 0x00054A9D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalPathApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalPathApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalPathApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalPathApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000568C4 File Offset: 0x00054AC4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalPathApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x000568E8 File Offset: 0x00054AE8
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

		// Token: 0x060019D6 RID: 6614 RVA: 0x0005695B File Offset: 0x00054B5B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalPathApiInvoker.cb_hashCode == null)
			{
				IExperimentalPathApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalPathApiInvoker.n_GetHashCode));
			}
			return IExperimentalPathApiInvoker.cb_hashCode;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0005697F File Offset: 0x00054B7F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalPathApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0005698E File Offset: 0x00054B8E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000569CE File Offset: 0x00054BCE
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalPathApiInvoker.cb_toString == null)
			{
				IExperimentalPathApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalPathApiInvoker.n_ToString));
			}
			return IExperimentalPathApiInvoker.cb_toString;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000569F2 File Offset: 0x00054BF2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalPathApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00056A08 File Offset: 0x00054C08
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007DF RID: 2015
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/ExperimentalPathApi", typeof(IExperimentalPathApiInvoker));

		// Token: 0x040007E0 RID: 2016
		private IntPtr class_ref;

		// Token: 0x040007E1 RID: 2017
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040007E2 RID: 2018
		private IntPtr id_annotationType;

		// Token: 0x040007E3 RID: 2019
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040007E4 RID: 2020
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040007E5 RID: 2021
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040007E6 RID: 2022
		private IntPtr id_hashCode;

		// Token: 0x040007E7 RID: 2023
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040007E8 RID: 2024
		private IntPtr id_toString;
	}
}
