using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Coroutines
{
	// Token: 0x02000262 RID: 610
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/RestrictsSuspension", DoNotGenerateAcw = true)]
	internal class IRestrictsSuspensionInvoker : Java.Lang.Object, IRestrictsSuspension, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0005D768 File Offset: 0x0005B968
		private static IntPtr java_class_ref
		{
			get
			{
				return IRestrictsSuspensionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0005D78C File Offset: 0x0005B98C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRestrictsSuspensionInvoker._members;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0005D793 File Offset: 0x0005B993
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x0005D79B File Offset: 0x0005B99B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRestrictsSuspensionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0005D7A7 File Offset: 0x0005B9A7
		[NullableContext(2)]
		public static IRestrictsSuspension GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRestrictsSuspension>(handle, transfer);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRestrictsSuspensionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.coroutines.RestrictsSuspension'.");
			}
			return handle;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0005D7DB File Offset: 0x0005B9DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0005D80C File Offset: 0x0005BA0C
		public IRestrictsSuspensionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRestrictsSuspensionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0005D844 File Offset: 0x0005BA44
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRestrictsSuspensionInvoker.cb_annotationType == null)
			{
				IRestrictsSuspensionInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictsSuspensionInvoker.n_AnnotationType));
			}
			return IRestrictsSuspensionInvoker.cb_annotationType;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0005D868 File Offset: 0x0005BA68
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRestrictsSuspension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0005D87C File Offset: 0x0005BA7C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0005D8CD File Offset: 0x0005BACD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRestrictsSuspensionInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRestrictsSuspensionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRestrictsSuspensionInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRestrictsSuspensionInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRestrictsSuspension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0005D918 File Offset: 0x0005BB18
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

		// Token: 0x06001BFC RID: 7164 RVA: 0x0005D98B File Offset: 0x0005BB8B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRestrictsSuspensionInvoker.cb_hashCode == null)
			{
				IRestrictsSuspensionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRestrictsSuspensionInvoker.n_GetHashCode));
			}
			return IRestrictsSuspensionInvoker.cb_hashCode;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0005D9AF File Offset: 0x0005BBAF
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRestrictsSuspension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0005D9BE File Offset: 0x0005BBBE
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0005D9FE File Offset: 0x0005BBFE
		private static Delegate GetToStringHandler()
		{
			if (IRestrictsSuspensionInvoker.cb_toString == null)
			{
				IRestrictsSuspensionInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRestrictsSuspensionInvoker.n_ToString));
			}
			return IRestrictsSuspensionInvoker.cb_toString;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0005DA22 File Offset: 0x0005BC22
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRestrictsSuspension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0005DA38 File Offset: 0x0005BC38
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400089D RID: 2205
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/RestrictsSuspension", typeof(IRestrictsSuspensionInvoker));

		// Token: 0x0400089E RID: 2206
		private IntPtr class_ref;

		// Token: 0x0400089F RID: 2207
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040008A0 RID: 2208
		private IntPtr id_annotationType;

		// Token: 0x040008A1 RID: 2209
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040008A2 RID: 2210
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040008A3 RID: 2211
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040008A4 RID: 2212
		private IntPtr id_hashCode;

		// Token: 0x040008A5 RID: 2213
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040008A6 RID: 2214
		private IntPtr id_toString;
	}
}
