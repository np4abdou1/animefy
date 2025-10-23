using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000038 RID: 56
	[Register("com/google/errorprone/annotations/RestrictedApi", DoNotGenerateAcw = true)]
	internal class IRestrictedApiInvoker : Java.Lang.Object, IRestrictedApi, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x000060D0 File Offset: 0x000042D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IRestrictedApiInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000060F4 File Offset: 0x000042F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRestrictedApiInvoker._members;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000060FB File Offset: 0x000042FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006103 File Offset: 0x00004303
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRestrictedApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000610F File Offset: 0x0000430F
		public static IRestrictedApi GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRestrictedApi>(handle, transfer);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006118 File Offset: 0x00004318
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRestrictedApiInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.RestrictedApi'.");
			}
			return handle;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006143 File Offset: 0x00004343
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006174 File Offset: 0x00004374
		public IRestrictedApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRestrictedApiInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000061AC File Offset: 0x000043AC
		private static Delegate GetAllowedOnPathHandler()
		{
			if (IRestrictedApiInvoker.cb_allowedOnPath == null)
			{
				IRestrictedApiInvoker.cb_allowedOnPath = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_AllowedOnPath));
			}
			return IRestrictedApiInvoker.cb_allowedOnPath;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000061D0 File Offset: 0x000043D0
		private static IntPtr n_AllowedOnPath(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowedOnPath());
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000061E4 File Offset: 0x000043E4
		public string AllowedOnPath()
		{
			if (this.id_allowedOnPath == IntPtr.Zero)
			{
				this.id_allowedOnPath = JNIEnv.GetMethodID(this.class_ref, "allowedOnPath", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_allowedOnPath), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006235 File Offset: 0x00004435
		private static Delegate GetAllowlistAnnotationsHandler()
		{
			if (IRestrictedApiInvoker.cb_allowlistAnnotations == null)
			{
				IRestrictedApiInvoker.cb_allowlistAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_AllowlistAnnotations));
			}
			return IRestrictedApiInvoker.cb_allowlistAnnotations;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006259 File Offset: 0x00004459
		private static IntPtr n_AllowlistAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowlistAnnotations());
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006270 File Offset: 0x00004470
		public Class[] AllowlistAnnotations()
		{
			if (this.id_allowlistAnnotations == IntPtr.Zero)
			{
				this.id_allowlistAnnotations = JNIEnv.GetMethodID(this.class_ref, "allowlistAnnotations", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_allowlistAnnotations), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000062D0 File Offset: 0x000044D0
		private static Delegate GetAllowlistWithWarningAnnotationsHandler()
		{
			if (IRestrictedApiInvoker.cb_allowlistWithWarningAnnotations == null)
			{
				IRestrictedApiInvoker.cb_allowlistWithWarningAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_AllowlistWithWarningAnnotations));
			}
			return IRestrictedApiInvoker.cb_allowlistWithWarningAnnotations;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000062F4 File Offset: 0x000044F4
		private static IntPtr n_AllowlistWithWarningAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Class>(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowlistWithWarningAnnotations());
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006308 File Offset: 0x00004508
		public Class[] AllowlistWithWarningAnnotations()
		{
			if (this.id_allowlistWithWarningAnnotations == IntPtr.Zero)
			{
				this.id_allowlistWithWarningAnnotations = JNIEnv.GetMethodID(this.class_ref, "allowlistWithWarningAnnotations", "()[Ljava/lang/Class;");
			}
			return (Class[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_allowlistWithWarningAnnotations), JniHandleOwnership.TransferLocalRef, typeof(Class));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00006368 File Offset: 0x00004568
		private static Delegate GetExplanationHandler()
		{
			if (IRestrictedApiInvoker.cb_explanation == null)
			{
				IRestrictedApiInvoker.cb_explanation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_Explanation));
			}
			return IRestrictedApiInvoker.cb_explanation;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000638C File Offset: 0x0000458C
		private static IntPtr n_Explanation(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Explanation());
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000063A0 File Offset: 0x000045A0
		public string Explanation()
		{
			if (this.id_explanation == IntPtr.Zero)
			{
				this.id_explanation = JNIEnv.GetMethodID(this.class_ref, "explanation", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_explanation), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000063F1 File Offset: 0x000045F1
		private static Delegate GetLinkHandler()
		{
			if (IRestrictedApiInvoker.cb_link == null)
			{
				IRestrictedApiInvoker.cb_link = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_Link));
			}
			return IRestrictedApiInvoker.cb_link;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00006415 File Offset: 0x00004615
		private static IntPtr n_Link(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Link());
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000642C File Offset: 0x0000462C
		public string Link()
		{
			if (this.id_link == IntPtr.Zero)
			{
				this.id_link = JNIEnv.GetMethodID(this.class_ref, "link", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_link), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000647D File Offset: 0x0000467D
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRestrictedApiInvoker.cb_annotationType == null)
			{
				IRestrictedApiInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_AnnotationType));
			}
			return IRestrictedApiInvoker.cb_annotationType;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000064A1 File Offset: 0x000046A1
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000064B8 File Offset: 0x000046B8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00006509 File Offset: 0x00004709
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRestrictedApiInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRestrictedApiInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRestrictedApiInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRestrictedApiInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00006530 File Offset: 0x00004730
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00006554 File Offset: 0x00004754
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

		// Token: 0x060001EF RID: 495 RVA: 0x000065C7 File Offset: 0x000047C7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRestrictedApiInvoker.cb_hashCode == null)
			{
				IRestrictedApiInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRestrictedApiInvoker.n_GetHashCode));
			}
			return IRestrictedApiInvoker.cb_hashCode;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000065EB File Offset: 0x000047EB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000065FA File Offset: 0x000047FA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000663A File Offset: 0x0000483A
		private static Delegate GetToStringHandler()
		{
			if (IRestrictedApiInvoker.cb_toString == null)
			{
				IRestrictedApiInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictedApiInvoker.n_ToString));
			}
			return IRestrictedApiInvoker.cb_toString;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000665E File Offset: 0x0000485E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRestrictedApi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00006674 File Offset: 0x00004874
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000D1 RID: 209
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/RestrictedApi", typeof(IRestrictedApiInvoker));

		// Token: 0x040000D2 RID: 210
		private IntPtr class_ref;

		// Token: 0x040000D3 RID: 211
		private static Delegate cb_allowedOnPath;

		// Token: 0x040000D4 RID: 212
		private IntPtr id_allowedOnPath;

		// Token: 0x040000D5 RID: 213
		private static Delegate cb_allowlistAnnotations;

		// Token: 0x040000D6 RID: 214
		private IntPtr id_allowlistAnnotations;

		// Token: 0x040000D7 RID: 215
		private static Delegate cb_allowlistWithWarningAnnotations;

		// Token: 0x040000D8 RID: 216
		private IntPtr id_allowlistWithWarningAnnotations;

		// Token: 0x040000D9 RID: 217
		private static Delegate cb_explanation;

		// Token: 0x040000DA RID: 218
		private IntPtr id_explanation;

		// Token: 0x040000DB RID: 219
		private static Delegate cb_link;

		// Token: 0x040000DC RID: 220
		private IntPtr id_link;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_annotationType;

		// Token: 0x040000DE RID: 222
		private IntPtr id_annotationType;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000E0 RID: 224
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_hashCode;

		// Token: 0x040000E2 RID: 226
		private IntPtr id_hashCode;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_toString;

		// Token: 0x040000E4 RID: 228
		private IntPtr id_toString;
	}
}
