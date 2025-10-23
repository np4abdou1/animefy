using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Annotation
{
	// Token: 0x0200028D RID: 653
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/annotation/Retention", DoNotGenerateAcw = true)]
	internal class IRetentionInvoker : Java.Lang.Object, IRetention, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x0006219C File Offset: 0x0006039C
		private static IntPtr java_class_ref
		{
			get
			{
				return IRetentionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000621C0 File Offset: 0x000603C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRetentionInvoker._members;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000621C7 File Offset: 0x000603C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000621CF File Offset: 0x000603CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRetentionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000621DB File Offset: 0x000603DB
		[NullableContext(2)]
		public static IRetention GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRetention>(handle, transfer);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000621E4 File Offset: 0x000603E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRetentionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.annotation.Retention'.");
			}
			return handle;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0006220F File Offset: 0x0006040F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00062240 File Offset: 0x00060440
		public IRetentionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRetentionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00062278 File Offset: 0x00060478
		private static Delegate GetValueHandler()
		{
			if (IRetentionInvoker.cb_value == null)
			{
				IRetentionInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRetentionInvoker.n_Value));
			}
			return IRetentionInvoker.cb_value;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0006229C File Offset: 0x0006049C
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRetention>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000622B0 File Offset: 0x000604B0
		[NullableContext(2)]
		public AnnotationRetention Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Lkotlin/annotation/AnnotationRetention;");
			}
			return Java.Lang.Object.GetObject<AnnotationRetention>(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00062301 File Offset: 0x00060501
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRetentionInvoker.cb_annotationType == null)
			{
				IRetentionInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRetentionInvoker.n_AnnotationType));
			}
			return IRetentionInvoker.cb_annotationType;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00062325 File Offset: 0x00060525
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRetention>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0006233C File Offset: 0x0006053C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0006238D File Offset: 0x0006058D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRetentionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRetentionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRetentionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRetentionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x000623B4 File Offset: 0x000605B4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRetention>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000623D8 File Offset: 0x000605D8
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

		// Token: 0x06001D7F RID: 7551 RVA: 0x0006244B File Offset: 0x0006064B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRetentionInvoker.cb_hashCode == null)
			{
				IRetentionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRetentionInvoker.n_GetHashCode));
			}
			return IRetentionInvoker.cb_hashCode;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0006246F File Offset: 0x0006066F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRetention>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0006247E File Offset: 0x0006067E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000624BE File Offset: 0x000606BE
		private static Delegate GetToStringHandler()
		{
			if (IRetentionInvoker.cb_toString == null)
			{
				IRetentionInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRetentionInvoker.n_ToString));
			}
			return IRetentionInvoker.cb_toString;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000624E2 File Offset: 0x000606E2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRetention>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000624F8 File Offset: 0x000606F8
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008F8 RID: 2296
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/Retention", typeof(IRetentionInvoker));

		// Token: 0x040008F9 RID: 2297
		private IntPtr class_ref;

		// Token: 0x040008FA RID: 2298
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x040008FB RID: 2299
		private IntPtr id_value;

		// Token: 0x040008FC RID: 2300
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040008FD RID: 2301
		private IntPtr id_annotationType;

		// Token: 0x040008FE RID: 2302
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040008FF RID: 2303
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000900 RID: 2304
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000901 RID: 2305
		private IntPtr id_hashCode;

		// Token: 0x04000902 RID: 2306
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x04000903 RID: 2307
		private IntPtr id_toString;
	}
}
