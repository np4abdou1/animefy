using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm
{
	// Token: 0x02000165 RID: 357
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmSuppressWildcards", DoNotGenerateAcw = true)]
	internal class IJvmSuppressWildcardsInvoker : Java.Lang.Object, IJvmSuppressWildcards, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0003C950 File Offset: 0x0003AB50
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmSuppressWildcardsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0003C974 File Offset: 0x0003AB74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmSuppressWildcardsInvoker._members;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003C97B File Offset: 0x0003AB7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0003C983 File Offset: 0x0003AB83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmSuppressWildcardsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0003C98F File Offset: 0x0003AB8F
		[NullableContext(2)]
		public static IJvmSuppressWildcards GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmSuppressWildcards>(handle, transfer);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0003C998 File Offset: 0x0003AB98
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmSuppressWildcardsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmSuppressWildcards'.");
			}
			return handle;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0003C9C3 File Offset: 0x0003ABC3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
		public IJvmSuppressWildcardsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmSuppressWildcardsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		private static Delegate GetSuppressHandler()
		{
			if (IJvmSuppressWildcardsInvoker.cb_suppress == null)
			{
				IJvmSuppressWildcardsInvoker.cb_suppress = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IJvmSuppressWildcardsInvoker.n_Suppress));
			}
			return IJvmSuppressWildcardsInvoker.cb_suppress;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0003CA50 File Offset: 0x0003AC50
		private static bool n_Suppress(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmSuppressWildcards>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Suppress();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0003CA5F File Offset: 0x0003AC5F
		public bool Suppress()
		{
			if (this.id_suppress == IntPtr.Zero)
			{
				this.id_suppress = JNIEnv.GetMethodID(this.class_ref, "suppress", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_suppress);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0003CA9F File Offset: 0x0003AC9F
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmSuppressWildcardsInvoker.cb_annotationType == null)
			{
				IJvmSuppressWildcardsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSuppressWildcardsInvoker.n_AnnotationType));
			}
			return IJvmSuppressWildcardsInvoker.cb_annotationType;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0003CAC3 File Offset: 0x0003ACC3
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmSuppressWildcards>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0003CAD8 File Offset: 0x0003ACD8
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0003CB29 File Offset: 0x0003AD29
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmSuppressWildcardsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmSuppressWildcardsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmSuppressWildcardsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmSuppressWildcardsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0003CB50 File Offset: 0x0003AD50
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmSuppressWildcards>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0003CB74 File Offset: 0x0003AD74
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

		// Token: 0x0600127C RID: 4732 RVA: 0x0003CBE7 File Offset: 0x0003ADE7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmSuppressWildcardsInvoker.cb_hashCode == null)
			{
				IJvmSuppressWildcardsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmSuppressWildcardsInvoker.n_GetHashCode));
			}
			return IJvmSuppressWildcardsInvoker.cb_hashCode;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0003CC0B File Offset: 0x0003AE0B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmSuppressWildcards>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0003CC1A File Offset: 0x0003AE1A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0003CC5A File Offset: 0x0003AE5A
		private static Delegate GetToStringHandler()
		{
			if (IJvmSuppressWildcardsInvoker.cb_toString == null)
			{
				IJvmSuppressWildcardsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmSuppressWildcardsInvoker.n_ToString));
			}
			return IJvmSuppressWildcardsInvoker.cb_toString;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0003CC7E File Offset: 0x0003AE7E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmSuppressWildcards>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0003CC94 File Offset: 0x0003AE94
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400060F RID: 1551
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmSuppressWildcards", typeof(IJvmSuppressWildcardsInvoker));

		// Token: 0x04000610 RID: 1552
		private IntPtr class_ref;

		// Token: 0x04000611 RID: 1553
		[Nullable(2)]
		private static Delegate cb_suppress;

		// Token: 0x04000612 RID: 1554
		private IntPtr id_suppress;

		// Token: 0x04000613 RID: 1555
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000614 RID: 1556
		private IntPtr id_annotationType;

		// Token: 0x04000615 RID: 1557
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000616 RID: 1558
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000617 RID: 1559
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000618 RID: 1560
		private IntPtr id_hashCode;

		// Token: 0x04000619 RID: 1561
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400061A RID: 1562
		private IntPtr id_toString;
	}
}
