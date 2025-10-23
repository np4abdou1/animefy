using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AD RID: 429
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/SourceDebugExtension", DoNotGenerateAcw = true)]
	internal class ISourceDebugExtensionInvoker : Java.Lang.Object, ISourceDebugExtension, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x000444B0 File Offset: 0x000426B0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISourceDebugExtensionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000444D4 File Offset: 0x000426D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISourceDebugExtensionInvoker._members;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000444DB File Offset: 0x000426DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000444E3 File Offset: 0x000426E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISourceDebugExtensionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000444EF File Offset: 0x000426EF
		[NullableContext(2)]
		public static ISourceDebugExtension GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISourceDebugExtension>(handle, transfer);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000444F8 File Offset: 0x000426F8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISourceDebugExtensionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.SourceDebugExtension'.");
			}
			return handle;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00044523 File Offset: 0x00042723
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00044554 File Offset: 0x00042754
		public ISourceDebugExtensionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISourceDebugExtensionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0004458C File Offset: 0x0004278C
		private static Delegate GetValueHandler()
		{
			if (ISourceDebugExtensionInvoker.cb_value == null)
			{
				ISourceDebugExtensionInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISourceDebugExtensionInvoker.n_Value));
			}
			return ISourceDebugExtensionInvoker.cb_value;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000445B0 File Offset: 0x000427B0
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ISourceDebugExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000445C4 File Offset: 0x000427C4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00044624 File Offset: 0x00042824
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISourceDebugExtensionInvoker.cb_annotationType == null)
			{
				ISourceDebugExtensionInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISourceDebugExtensionInvoker.n_AnnotationType));
			}
			return ISourceDebugExtensionInvoker.cb_annotationType;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00044648 File Offset: 0x00042848
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISourceDebugExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0004465C File Offset: 0x0004285C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000446AD File Offset: 0x000428AD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISourceDebugExtensionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISourceDebugExtensionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISourceDebugExtensionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISourceDebugExtensionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000446D4 File Offset: 0x000428D4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISourceDebugExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000446F8 File Offset: 0x000428F8
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

		// Token: 0x0600152D RID: 5421 RVA: 0x0004476B File Offset: 0x0004296B
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISourceDebugExtensionInvoker.cb_hashCode == null)
			{
				ISourceDebugExtensionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISourceDebugExtensionInvoker.n_GetHashCode));
			}
			return ISourceDebugExtensionInvoker.cb_hashCode;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0004478F File Offset: 0x0004298F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISourceDebugExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0004479E File Offset: 0x0004299E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000447DE File Offset: 0x000429DE
		private static Delegate GetToStringHandler()
		{
			if (ISourceDebugExtensionInvoker.cb_toString == null)
			{
				ISourceDebugExtensionInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISourceDebugExtensionInvoker.n_ToString));
			}
			return ISourceDebugExtensionInvoker.cb_toString;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00044802 File Offset: 0x00042A02
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISourceDebugExtension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00044818 File Offset: 0x00042A18
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040006D3 RID: 1747
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/SourceDebugExtension", typeof(ISourceDebugExtensionInvoker));

		// Token: 0x040006D4 RID: 1748
		private IntPtr class_ref;

		// Token: 0x040006D5 RID: 1749
		[Nullable(2)]
		private static Delegate cb_value;

		// Token: 0x040006D6 RID: 1750
		private IntPtr id_value;

		// Token: 0x040006D7 RID: 1751
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040006D8 RID: 1752
		private IntPtr id_annotationType;

		// Token: 0x040006D9 RID: 1753
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040006DA RID: 1754
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040006DB RID: 1755
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040006DC RID: 1756
		private IntPtr id_hashCode;

		// Token: 0x040006DD RID: 1757
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040006DE RID: 1758
		private IntPtr id_toString;
	}
}
