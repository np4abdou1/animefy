using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E0 RID: 224
	[Register("com/google/android/datatransport/runtime/dagger/internal/Beta", DoNotGenerateAcw = true)]
	internal class IBetaInvoker : Java.Lang.Object, IBeta, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0001615C File Offset: 0x0001435C
		private static IntPtr java_class_ref
		{
			get
			{
				return IBetaInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00016180 File Offset: 0x00014380
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBetaInvoker._members;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00016187 File Offset: 0x00014387
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001618F File Offset: 0x0001438F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBetaInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0001619B File Offset: 0x0001439B
		public static IBeta GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBeta>(handle, transfer);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000161A4 File Offset: 0x000143A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBetaInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.dagger.internal.Beta'.");
			}
			return handle;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000161CF File Offset: 0x000143CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00016200 File Offset: 0x00014400
		public IBetaInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBetaInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00016238 File Offset: 0x00014438
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IBetaInvoker.cb_annotationType == null)
			{
				IBetaInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBetaInvoker.n_AnnotationType));
			}
			return IBetaInvoker.cb_annotationType;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0001625C File Offset: 0x0001445C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBeta>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00016270 File Offset: 0x00014470
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000162C1 File Offset: 0x000144C1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IBetaInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IBetaInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBetaInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IBetaInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x000162E8 File Offset: 0x000144E8
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IBeta>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0001630C File Offset: 0x0001450C
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

		// Token: 0x060007EF RID: 2031 RVA: 0x0001637F File Offset: 0x0001457F
		private static Delegate GetGetHashCodeHandler()
		{
			if (IBetaInvoker.cb_hashCode == null)
			{
				IBetaInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBetaInvoker.n_GetHashCode));
			}
			return IBetaInvoker.cb_hashCode;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000163A3 File Offset: 0x000145A3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBeta>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000163B2 File Offset: 0x000145B2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000163F2 File Offset: 0x000145F2
		private static Delegate GetToStringHandler()
		{
			if (IBetaInvoker.cb_toString == null)
			{
				IBetaInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBetaInvoker.n_ToString));
			}
			return IBetaInvoker.cb_toString;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00016416 File Offset: 0x00014616
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IBeta>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0001642C File Offset: 0x0001462C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400022E RID: 558
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/Beta", typeof(IBetaInvoker));

		// Token: 0x0400022F RID: 559
		private IntPtr class_ref;

		// Token: 0x04000230 RID: 560
		private static Delegate cb_annotationType;

		// Token: 0x04000231 RID: 561
		private IntPtr id_annotationType;

		// Token: 0x04000232 RID: 562
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000233 RID: 563
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000234 RID: 564
		private static Delegate cb_hashCode;

		// Token: 0x04000235 RID: 565
		private IntPtr id_hashCode;

		// Token: 0x04000236 RID: 566
		private static Delegate cb_toString;

		// Token: 0x04000237 RID: 567
		private IntPtr id_toString;
	}
}
