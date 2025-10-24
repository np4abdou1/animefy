using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x0200002D RID: 45
	[Register("com/google/errorprone/annotations/MustBeClosed", DoNotGenerateAcw = true)]
	internal class IMustBeClosedInvoker : Java.Lang.Object, IMustBeClosed, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00005304 File Offset: 0x00003504
		private static IntPtr java_class_ref
		{
			get
			{
				return IMustBeClosedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005328 File Offset: 0x00003528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMustBeClosedInvoker._members;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000532F File Offset: 0x0000352F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00005337 File Offset: 0x00003537
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMustBeClosedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005343 File Offset: 0x00003543
		public static IMustBeClosed GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMustBeClosed>(handle, transfer);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000534C File Offset: 0x0000354C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMustBeClosedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.MustBeClosed'.");
			}
			return handle;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005377 File Offset: 0x00003577
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000053A8 File Offset: 0x000035A8
		public IMustBeClosedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMustBeClosedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000053E0 File Offset: 0x000035E0
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMustBeClosedInvoker.cb_annotationType == null)
			{
				IMustBeClosedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeClosedInvoker.n_AnnotationType));
			}
			return IMustBeClosedInvoker.cb_annotationType;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005404 File Offset: 0x00003604
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMustBeClosed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005418 File Offset: 0x00003618
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005469 File Offset: 0x00003669
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMustBeClosedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMustBeClosedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMustBeClosedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMustBeClosedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005490 File Offset: 0x00003690
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMustBeClosed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000054B4 File Offset: 0x000036B4
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

		// Token: 0x06000178 RID: 376 RVA: 0x00005527 File Offset: 0x00003727
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMustBeClosedInvoker.cb_hashCode == null)
			{
				IMustBeClosedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMustBeClosedInvoker.n_GetHashCode));
			}
			return IMustBeClosedInvoker.cb_hashCode;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000554B File Offset: 0x0000374B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMustBeClosed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000555A File Offset: 0x0000375A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000559A File Offset: 0x0000379A
		private static Delegate GetToStringHandler()
		{
			if (IMustBeClosedInvoker.cb_toString == null)
			{
				IMustBeClosedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMustBeClosedInvoker.n_ToString));
			}
			return IMustBeClosedInvoker.cb_toString;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000055BE File Offset: 0x000037BE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMustBeClosed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000055D4 File Offset: 0x000037D4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000A3 RID: 163
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/MustBeClosed", typeof(IMustBeClosedInvoker));

		// Token: 0x040000A4 RID: 164
		private IntPtr class_ref;

		// Token: 0x040000A5 RID: 165
		private static Delegate cb_annotationType;

		// Token: 0x040000A6 RID: 166
		private IntPtr id_annotationType;

		// Token: 0x040000A7 RID: 167
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000A8 RID: 168
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_hashCode;

		// Token: 0x040000AA RID: 170
		private IntPtr id_hashCode;

		// Token: 0x040000AB RID: 171
		private static Delegate cb_toString;

		// Token: 0x040000AC RID: 172
		private IntPtr id_toString;
	}
}
