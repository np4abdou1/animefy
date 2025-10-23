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
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/Synchronized", DoNotGenerateAcw = true)]
	internal class ISynchronizedInvoker : Java.Lang.Object, ISynchronized, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		private static IntPtr java_class_ref
		{
			get
			{
				return ISynchronizedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISynchronizedInvoker._members;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x0003DAA7 File Offset: 0x0003BCA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0003DAAF File Offset: 0x0003BCAF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISynchronizedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0003DABB File Offset: 0x0003BCBB
		[NullableContext(2)]
		public static ISynchronized GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISynchronized>(handle, transfer);
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISynchronizedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.Synchronized'.");
			}
			return handle;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0003DAEF File Offset: 0x0003BCEF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0003DB20 File Offset: 0x0003BD20
		public ISynchronizedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISynchronizedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0003DB58 File Offset: 0x0003BD58
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISynchronizedInvoker.cb_annotationType == null)
			{
				ISynchronizedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISynchronizedInvoker.n_AnnotationType));
			}
			return ISynchronizedInvoker.cb_annotationType;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0003DB7C File Offset: 0x0003BD7C
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISynchronized>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0003DB90 File Offset: 0x0003BD90
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0003DBE1 File Offset: 0x0003BDE1
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISynchronizedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISynchronizedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISynchronizedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISynchronizedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0003DC08 File Offset: 0x0003BE08
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISynchronized>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0003DC2C File Offset: 0x0003BE2C
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

		// Token: 0x060012E9 RID: 4841 RVA: 0x0003DC9F File Offset: 0x0003BE9F
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISynchronizedInvoker.cb_hashCode == null)
			{
				ISynchronizedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISynchronizedInvoker.n_GetHashCode));
			}
			return ISynchronizedInvoker.cb_hashCode;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0003DCC3 File Offset: 0x0003BEC3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISynchronized>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0003DCD2 File Offset: 0x0003BED2
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0003DD12 File Offset: 0x0003BF12
		private static Delegate GetToStringHandler()
		{
			if (ISynchronizedInvoker.cb_toString == null)
			{
				ISynchronizedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISynchronizedInvoker.n_ToString));
			}
			return ISynchronizedInvoker.cb_toString;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0003DD36 File Offset: 0x0003BF36
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISynchronized>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000645 RID: 1605
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/Synchronized", typeof(ISynchronizedInvoker));

		// Token: 0x04000646 RID: 1606
		private IntPtr class_ref;

		// Token: 0x04000647 RID: 1607
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000648 RID: 1608
		private IntPtr id_annotationType;

		// Token: 0x04000649 RID: 1609
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400064A RID: 1610
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400064B RID: 1611
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400064C RID: 1612
		private IntPtr id_hashCode;

		// Token: 0x0400064D RID: 1613
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400064E RID: 1614
		private IntPtr id_toString;
	}
}
