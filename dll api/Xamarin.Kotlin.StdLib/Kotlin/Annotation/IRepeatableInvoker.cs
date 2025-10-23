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
	// Token: 0x0200028B RID: 651
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/annotation/Repeatable", DoNotGenerateAcw = true)]
	internal class IRepeatableInvoker : Java.Lang.Object, IRepeatable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00061E60 File Offset: 0x00060060
		private static IntPtr java_class_ref
		{
			get
			{
				return IRepeatableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x00061E84 File Offset: 0x00060084
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRepeatableInvoker._members;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00061E8B File Offset: 0x0006008B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x00061E93 File Offset: 0x00060093
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRepeatableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00061E9F File Offset: 0x0006009F
		[NullableContext(2)]
		public static IRepeatable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRepeatable>(handle, transfer);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00061EA8 File Offset: 0x000600A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRepeatableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.annotation.Repeatable'.");
			}
			return handle;
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00061ED3 File Offset: 0x000600D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00061F04 File Offset: 0x00060104
		public IRepeatableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRepeatableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00061F3C File Offset: 0x0006013C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRepeatableInvoker.cb_annotationType == null)
			{
				IRepeatableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRepeatableInvoker.n_AnnotationType));
			}
			return IRepeatableInvoker.cb_annotationType;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00061F60 File Offset: 0x00060160
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRepeatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00061F74 File Offset: 0x00060174
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00061FC5 File Offset: 0x000601C5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRepeatableInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRepeatableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRepeatableInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRepeatableInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00061FEC File Offset: 0x000601EC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRepeatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00062010 File Offset: 0x00060210
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

		// Token: 0x06001D66 RID: 7526 RVA: 0x00062083 File Offset: 0x00060283
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRepeatableInvoker.cb_hashCode == null)
			{
				IRepeatableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRepeatableInvoker.n_GetHashCode));
			}
			return IRepeatableInvoker.cb_hashCode;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000620A7 File Offset: 0x000602A7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRepeatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000620B6 File Offset: 0x000602B6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000620F6 File Offset: 0x000602F6
		private static Delegate GetToStringHandler()
		{
			if (IRepeatableInvoker.cb_toString == null)
			{
				IRepeatableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRepeatableInvoker.n_ToString));
			}
			return IRepeatableInvoker.cb_toString;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0006211A File Offset: 0x0006031A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRepeatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00062130 File Offset: 0x00060330
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040008EE RID: 2286
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/annotation/Repeatable", typeof(IRepeatableInvoker));

		// Token: 0x040008EF RID: 2287
		private IntPtr class_ref;

		// Token: 0x040008F0 RID: 2288
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040008F1 RID: 2289
		private IntPtr id_annotationType;

		// Token: 0x040008F2 RID: 2290
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040008F3 RID: 2291
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040008F4 RID: 2292
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040008F5 RID: 2293
		private IntPtr id_hashCode;

		// Token: 0x040008F6 RID: 2294
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040008F7 RID: 2295
		private IntPtr id_toString;
	}
}
