using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations.Concurrent
{
	// Token: 0x0200004D RID: 77
	[Register("com/google/errorprone/annotations/concurrent/LazyInit", DoNotGenerateAcw = true)]
	internal class ILazyInitInvoker : Java.Lang.Object, ILazyInit, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00007834 File Offset: 0x00005A34
		private static IntPtr java_class_ref
		{
			get
			{
				return ILazyInitInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00007858 File Offset: 0x00005A58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILazyInitInvoker._members;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000785F File Offset: 0x00005A5F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00007867 File Offset: 0x00005A67
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILazyInitInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00007873 File Offset: 0x00005A73
		public static ILazyInit GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILazyInit>(handle, transfer);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000787C File Offset: 0x00005A7C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILazyInitInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.concurrent.LazyInit'.");
			}
			return handle;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000078A7 File Offset: 0x00005AA7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000078D8 File Offset: 0x00005AD8
		public ILazyInitInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILazyInitInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00007910 File Offset: 0x00005B10
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ILazyInitInvoker.cb_annotationType == null)
			{
				ILazyInitInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILazyInitInvoker.n_AnnotationType));
			}
			return ILazyInitInvoker.cb_annotationType;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00007934 File Offset: 0x00005B34
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILazyInit>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00007948 File Offset: 0x00005B48
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007999 File Offset: 0x00005B99
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ILazyInitInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ILazyInitInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ILazyInitInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ILazyInitInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000079C0 File Offset: 0x00005BC0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ILazyInit>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000079E4 File Offset: 0x00005BE4
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

		// Token: 0x06000286 RID: 646 RVA: 0x00007A57 File Offset: 0x00005C57
		private static Delegate GetGetHashCodeHandler()
		{
			if (ILazyInitInvoker.cb_hashCode == null)
			{
				ILazyInitInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ILazyInitInvoker.n_GetHashCode));
			}
			return ILazyInitInvoker.cb_hashCode;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00007A7B File Offset: 0x00005C7B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILazyInit>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00007A8A File Offset: 0x00005C8A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00007ACA File Offset: 0x00005CCA
		private static Delegate GetToStringHandler()
		{
			if (ILazyInitInvoker.cb_toString == null)
			{
				ILazyInitInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILazyInitInvoker.n_ToString));
			}
			return ILazyInitInvoker.cb_toString;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00007AEE File Offset: 0x00005CEE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILazyInit>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00007B04 File Offset: 0x00005D04
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000116 RID: 278
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/concurrent/LazyInit", typeof(ILazyInitInvoker));

		// Token: 0x04000117 RID: 279
		private IntPtr class_ref;

		// Token: 0x04000118 RID: 280
		private static Delegate cb_annotationType;

		// Token: 0x04000119 RID: 281
		private IntPtr id_annotationType;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400011B RID: 283
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400011C RID: 284
		private static Delegate cb_hashCode;

		// Token: 0x0400011D RID: 285
		private IntPtr id_hashCode;

		// Token: 0x0400011E RID: 286
		private static Delegate cb_toString;

		// Token: 0x0400011F RID: 287
		private IntPtr id_toString;
	}
}
