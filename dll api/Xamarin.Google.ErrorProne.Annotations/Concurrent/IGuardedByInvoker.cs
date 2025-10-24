using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004B RID: 75
	[Register("com/google/errorprone/annotations/concurrent/GuardedBy", DoNotGenerateAcw = true)]
	internal class IGuardedByInvoker : Java.Lang.Object, IGuardedBy, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000746C File Offset: 0x0000566C
		private static IntPtr java_class_ref
		{
			get
			{
				return IGuardedByInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00007490 File Offset: 0x00005690
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGuardedByInvoker._members;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00007497 File Offset: 0x00005697
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000749F File Offset: 0x0000569F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGuardedByInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000074AB File Offset: 0x000056AB
		public static IGuardedBy GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGuardedBy>(handle, transfer);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000074B4 File Offset: 0x000056B4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGuardedByInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.concurrent.GuardedBy'.");
			}
			return handle;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000074DF File Offset: 0x000056DF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00007510 File Offset: 0x00005710
		public IGuardedByInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGuardedByInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007548 File Offset: 0x00005748
		private static Delegate GetValueHandler()
		{
			if (IGuardedByInvoker.cb_value == null)
			{
				IGuardedByInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGuardedByInvoker.n_Value));
			}
			return IGuardedByInvoker.cb_value;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000756C File Offset: 0x0000576C
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IGuardedBy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007580 File Offset: 0x00005780
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000075D1 File Offset: 0x000057D1
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IGuardedByInvoker.cb_annotationType == null)
			{
				IGuardedByInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGuardedByInvoker.n_AnnotationType));
			}
			return IGuardedByInvoker.cb_annotationType;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000075F5 File Offset: 0x000057F5
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGuardedBy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000760C File Offset: 0x0000580C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000765D File Offset: 0x0000585D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IGuardedByInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IGuardedByInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IGuardedByInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IGuardedByInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00007684 File Offset: 0x00005884
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IGuardedBy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000076A8 File Offset: 0x000058A8
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

		// Token: 0x06000271 RID: 625 RVA: 0x0000771B File Offset: 0x0000591B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IGuardedByInvoker.cb_hashCode == null)
			{
				IGuardedByInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGuardedByInvoker.n_GetHashCode));
			}
			return IGuardedByInvoker.cb_hashCode;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000773F File Offset: 0x0000593F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGuardedBy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000774E File Offset: 0x0000594E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000778E File Offset: 0x0000598E
		private static Delegate GetToStringHandler()
		{
			if (IGuardedByInvoker.cb_toString == null)
			{
				IGuardedByInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGuardedByInvoker.n_ToString));
			}
			return IGuardedByInvoker.cb_toString;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000077B2 File Offset: 0x000059B2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IGuardedBy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000077C8 File Offset: 0x000059C8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400010A RID: 266
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/concurrent/GuardedBy", typeof(IGuardedByInvoker));

		// Token: 0x0400010B RID: 267
		private IntPtr class_ref;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_value;

		// Token: 0x0400010D RID: 269
		private IntPtr id_value;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_annotationType;

		// Token: 0x0400010F RID: 271
		private IntPtr id_annotationType;

		// Token: 0x04000110 RID: 272
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000111 RID: 273
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_hashCode;

		// Token: 0x04000113 RID: 275
		private IntPtr id_hashCode;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_toString;

		// Token: 0x04000115 RID: 277
		private IntPtr id_toString;
	}
}
