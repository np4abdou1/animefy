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
	// Token: 0x02000082 RID: 130
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/SubclassOptInRequired", DoNotGenerateAcw = true)]
	internal class ISubclassOptInRequiredInvoker : Java.Lang.Object, ISubclassOptInRequired, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00008214 File Offset: 0x00006414
		private static IntPtr java_class_ref
		{
			get
			{
				return ISubclassOptInRequiredInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00008238 File Offset: 0x00006438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISubclassOptInRequiredInvoker._members;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0000823F File Offset: 0x0000643F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00008247 File Offset: 0x00006447
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISubclassOptInRequiredInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00008253 File Offset: 0x00006453
		[NullableContext(2)]
		public static ISubclassOptInRequired GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISubclassOptInRequired>(handle, transfer);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000825C File Offset: 0x0000645C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISubclassOptInRequiredInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.SubclassOptInRequired'.");
			}
			return handle;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00008287 File Offset: 0x00006487
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000082B8 File Offset: 0x000064B8
		public ISubclassOptInRequiredInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISubclassOptInRequiredInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000082F0 File Offset: 0x000064F0
		private static Delegate GetMarkerClassHandler()
		{
			if (ISubclassOptInRequiredInvoker.cb_markerClass == null)
			{
				ISubclassOptInRequiredInvoker.cb_markerClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubclassOptInRequiredInvoker.n_MarkerClass));
			}
			return ISubclassOptInRequiredInvoker.cb_markerClass;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00008314 File Offset: 0x00006514
		private static IntPtr n_MarkerClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubclassOptInRequired>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MarkerClass());
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00008328 File Offset: 0x00006528
		[NullableContext(2)]
		public Class MarkerClass()
		{
			if (this.id_markerClass == IntPtr.Zero)
			{
				this.id_markerClass = JNIEnv.GetMethodID(this.class_ref, "markerClass", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_markerClass), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00008379 File Offset: 0x00006579
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISubclassOptInRequiredInvoker.cb_annotationType == null)
			{
				ISubclassOptInRequiredInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubclassOptInRequiredInvoker.n_AnnotationType));
			}
			return ISubclassOptInRequiredInvoker.cb_annotationType;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000839D File Offset: 0x0000659D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISubclassOptInRequired>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000083B4 File Offset: 0x000065B4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00008405 File Offset: 0x00006605
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISubclassOptInRequiredInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISubclassOptInRequiredInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISubclassOptInRequiredInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISubclassOptInRequiredInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000842C File Offset: 0x0000662C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISubclassOptInRequired>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00008450 File Offset: 0x00006650
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

		// Token: 0x06000382 RID: 898 RVA: 0x000084C3 File Offset: 0x000066C3
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISubclassOptInRequiredInvoker.cb_hashCode == null)
			{
				ISubclassOptInRequiredInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISubclassOptInRequiredInvoker.n_GetHashCode));
			}
			return ISubclassOptInRequiredInvoker.cb_hashCode;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000084E7 File Offset: 0x000066E7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISubclassOptInRequired>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000084F6 File Offset: 0x000066F6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00008536 File Offset: 0x00006736
		private static Delegate GetToStringHandler()
		{
			if (ISubclassOptInRequiredInvoker.cb_toString == null)
			{
				ISubclassOptInRequiredInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISubclassOptInRequiredInvoker.n_ToString));
			}
			return ISubclassOptInRequiredInvoker.cb_toString;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000855A File Offset: 0x0000675A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISubclassOptInRequired>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00008570 File Offset: 0x00006770
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000114 RID: 276
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/SubclassOptInRequired", typeof(ISubclassOptInRequiredInvoker));

		// Token: 0x04000115 RID: 277
		private IntPtr class_ref;

		// Token: 0x04000116 RID: 278
		[Nullable(2)]
		private static Delegate cb_markerClass;

		// Token: 0x04000117 RID: 279
		private IntPtr id_markerClass;

		// Token: 0x04000118 RID: 280
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000119 RID: 281
		private IntPtr id_annotationType;

		// Token: 0x0400011A RID: 282
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400011B RID: 283
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400011C RID: 284
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400011D RID: 285
		private IntPtr id_hashCode;

		// Token: 0x0400011E RID: 286
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400011F RID: 287
		private IntPtr id_toString;
	}
}
