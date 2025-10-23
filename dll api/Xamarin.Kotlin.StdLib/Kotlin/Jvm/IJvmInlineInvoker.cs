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
	// Token: 0x02000157 RID: 343
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmInline", DoNotGenerateAcw = true)]
	internal class IJvmInlineInvoker : Java.Lang.Object, IJvmInline, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0003B220 File Offset: 0x00039420
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmInlineInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0003B244 File Offset: 0x00039444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmInlineInvoker._members;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0003B24B File Offset: 0x0003944B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0003B253 File Offset: 0x00039453
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmInlineInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0003B25F File Offset: 0x0003945F
		[NullableContext(2)]
		public static IJvmInline GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmInline>(handle, transfer);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0003B268 File Offset: 0x00039468
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmInlineInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmInline'.");
			}
			return handle;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0003B293 File Offset: 0x00039493
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0003B2C4 File Offset: 0x000394C4
		public IJvmInlineInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmInlineInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0003B2FC File Offset: 0x000394FC
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmInlineInvoker.cb_annotationType == null)
			{
				IJvmInlineInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmInlineInvoker.n_AnnotationType));
			}
			return IJvmInlineInvoker.cb_annotationType;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0003B320 File Offset: 0x00039520
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmInline>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0003B334 File Offset: 0x00039534
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0003B385 File Offset: 0x00039585
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmInlineInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmInlineInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmInlineInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmInlineInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0003B3AC File Offset: 0x000395AC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmInline>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0003B3D0 File Offset: 0x000395D0
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

		// Token: 0x060011E1 RID: 4577 RVA: 0x0003B443 File Offset: 0x00039643
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmInlineInvoker.cb_hashCode == null)
			{
				IJvmInlineInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmInlineInvoker.n_GetHashCode));
			}
			return IJvmInlineInvoker.cb_hashCode;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0003B467 File Offset: 0x00039667
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmInline>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0003B476 File Offset: 0x00039676
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0003B4B6 File Offset: 0x000396B6
		private static Delegate GetToStringHandler()
		{
			if (IJvmInlineInvoker.cb_toString == null)
			{
				IJvmInlineInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmInlineInvoker.n_ToString));
			}
			return IJvmInlineInvoker.cb_toString;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0003B4DA File Offset: 0x000396DA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmInline>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0003B4F0 File Offset: 0x000396F0
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005C7 RID: 1479
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmInline", typeof(IJvmInlineInvoker));

		// Token: 0x040005C8 RID: 1480
		private IntPtr class_ref;

		// Token: 0x040005C9 RID: 1481
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005CA RID: 1482
		private IntPtr id_annotationType;

		// Token: 0x040005CB RID: 1483
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005CC RID: 1484
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005CD RID: 1485
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005CE RID: 1486
		private IntPtr id_hashCode;

		// Token: 0x040005CF RID: 1487
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005D0 RID: 1488
		private IntPtr id_toString;
	}
}
