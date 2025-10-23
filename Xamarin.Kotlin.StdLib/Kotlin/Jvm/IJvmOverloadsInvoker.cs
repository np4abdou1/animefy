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
	// Token: 0x0200015D RID: 349
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmOverloads", DoNotGenerateAcw = true)]
	internal class IJvmOverloadsInvoker : Java.Lang.Object, IJvmOverloads, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0003BC60 File Offset: 0x00039E60
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmOverloadsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0003BC84 File Offset: 0x00039E84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmOverloadsInvoker._members;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0003BC8B File Offset: 0x00039E8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0003BC93 File Offset: 0x00039E93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmOverloadsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0003BC9F File Offset: 0x00039E9F
		[NullableContext(2)]
		public static IJvmOverloads GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmOverloads>(handle, transfer);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmOverloadsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmOverloads'.");
			}
			return handle;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0003BCD3 File Offset: 0x00039ED3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0003BD04 File Offset: 0x00039F04
		public IJvmOverloadsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmOverloadsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0003BD3C File Offset: 0x00039F3C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmOverloadsInvoker.cb_annotationType == null)
			{
				IJvmOverloadsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmOverloadsInvoker.n_AnnotationType));
			}
			return IJvmOverloadsInvoker.cb_annotationType;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0003BD60 File Offset: 0x00039F60
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmOverloads>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0003BD74 File Offset: 0x00039F74
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0003BDC5 File Offset: 0x00039FC5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmOverloadsInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmOverloadsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmOverloadsInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmOverloadsInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0003BDEC File Offset: 0x00039FEC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmOverloads>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0003BE10 File Offset: 0x0003A010
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

		// Token: 0x06001224 RID: 4644 RVA: 0x0003BE83 File Offset: 0x0003A083
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmOverloadsInvoker.cb_hashCode == null)
			{
				IJvmOverloadsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmOverloadsInvoker.n_GetHashCode));
			}
			return IJvmOverloadsInvoker.cb_hashCode;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0003BEA7 File Offset: 0x0003A0A7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmOverloads>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0003BEB6 File Offset: 0x0003A0B6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0003BEF6 File Offset: 0x0003A0F6
		private static Delegate GetToStringHandler()
		{
			if (IJvmOverloadsInvoker.cb_toString == null)
			{
				IJvmOverloadsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmOverloadsInvoker.n_ToString));
			}
			return IJvmOverloadsInvoker.cb_toString;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0003BF1A File Offset: 0x0003A11A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmOverloads>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0003BF30 File Offset: 0x0003A130
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005E7 RID: 1511
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmOverloads", typeof(IJvmOverloadsInvoker));

		// Token: 0x040005E8 RID: 1512
		private IntPtr class_ref;

		// Token: 0x040005E9 RID: 1513
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005EA RID: 1514
		private IntPtr id_annotationType;

		// Token: 0x040005EB RID: 1515
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005EC RID: 1516
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005ED RID: 1517
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005EE RID: 1518
		private IntPtr id_hashCode;

		// Token: 0x040005EF RID: 1519
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005F0 RID: 1520
		private IntPtr id_toString;
	}
}
