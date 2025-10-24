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
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DslMarker", DoNotGenerateAcw = true)]
	internal class IDslMarkerInvoker : Java.Lang.Object, IDslMarker, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00004414 File Offset: 0x00002614
		private static IntPtr java_class_ref
		{
			get
			{
				return IDslMarkerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00004438 File Offset: 0x00002638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDslMarkerInvoker._members;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000443F File Offset: 0x0000263F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00004447 File Offset: 0x00002647
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDslMarkerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00004453 File Offset: 0x00002653
		[NullableContext(2)]
		public static IDslMarker GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDslMarker>(handle, transfer);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000445C File Offset: 0x0000265C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDslMarkerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.DslMarker'.");
			}
			return handle;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00004487 File Offset: 0x00002687
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000044B8 File Offset: 0x000026B8
		public IDslMarkerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDslMarkerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000044F0 File Offset: 0x000026F0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IDslMarkerInvoker.cb_annotationType == null)
			{
				IDslMarkerInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDslMarkerInvoker.n_AnnotationType));
			}
			return IDslMarkerInvoker.cb_annotationType;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00004514 File Offset: 0x00002714
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDslMarker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00004528 File Offset: 0x00002728
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00004579 File Offset: 0x00002779
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IDslMarkerInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IDslMarkerInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IDslMarkerInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IDslMarkerInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000045A0 File Offset: 0x000027A0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IDslMarker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000045C4 File Offset: 0x000027C4
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

		// Token: 0x060001DC RID: 476 RVA: 0x00004637 File Offset: 0x00002837
		private static Delegate GetGetHashCodeHandler()
		{
			if (IDslMarkerInvoker.cb_hashCode == null)
			{
				IDslMarkerInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IDslMarkerInvoker.n_GetHashCode));
			}
			return IDslMarkerInvoker.cb_hashCode;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000465B File Offset: 0x0000285B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IDslMarker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000466A File Offset: 0x0000286A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000046AA File Offset: 0x000028AA
		private static Delegate GetToStringHandler()
		{
			if (IDslMarkerInvoker.cb_toString == null)
			{
				IDslMarkerInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDslMarkerInvoker.n_ToString));
			}
			return IDslMarkerInvoker.cb_toString;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000046CE File Offset: 0x000028CE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IDslMarker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000046E4 File Offset: 0x000028E4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000056 RID: 86
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DslMarker", typeof(IDslMarkerInvoker));

		// Token: 0x04000057 RID: 87
		private IntPtr class_ref;

		// Token: 0x04000058 RID: 88
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000059 RID: 89
		private IntPtr id_annotationType;

		// Token: 0x0400005A RID: 90
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400005B RID: 91
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400005C RID: 92
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400005D RID: 93
		private IntPtr id_hashCode;

		// Token: 0x0400005E RID: 94
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400005F RID: 95
		private IntPtr id_toString;
	}
}
