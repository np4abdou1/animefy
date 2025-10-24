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
	// Token: 0x0200015B RID: 347
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmName", DoNotGenerateAcw = true)]
	internal class IJvmNameInvoker : Java.Lang.Object, IJvmName, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0003B898 File Offset: 0x00039A98
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmNameInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmNameInvoker._members;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0003B8C3 File Offset: 0x00039AC3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0003B8CB File Offset: 0x00039ACB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmNameInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0003B8D7 File Offset: 0x00039AD7
		[NullableContext(2)]
		public static IJvmName GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmName>(handle, transfer);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0003B8E0 File Offset: 0x00039AE0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmNameInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmName'.");
			}
			return handle;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0003B90B File Offset: 0x00039B0B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0003B93C File Offset: 0x00039B3C
		public IJvmNameInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmNameInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0003B974 File Offset: 0x00039B74
		private static Delegate GetNameHandler()
		{
			if (IJvmNameInvoker.cb_name == null)
			{
				IJvmNameInvoker.cb_name = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmNameInvoker.n_Name));
			}
			return IJvmNameInvoker.cb_name;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0003B998 File Offset: 0x00039B98
		private static IntPtr n_Name(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name());
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0003B9AC File Offset: 0x00039BAC
		[NullableContext(2)]
		public string Name()
		{
			if (this.id_name == IntPtr.Zero)
			{
				this.id_name = JNIEnv.GetMethodID(this.class_ref, "name", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_name), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0003B9FD File Offset: 0x00039BFD
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmNameInvoker.cb_annotationType == null)
			{
				IJvmNameInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmNameInvoker.n_AnnotationType));
			}
			return IJvmNameInvoker.cb_annotationType;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0003BA21 File Offset: 0x00039C21
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0003BA38 File Offset: 0x00039C38
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0003BA89 File Offset: 0x00039C89
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmNameInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmNameInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmNameInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmNameInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0003BAD4 File Offset: 0x00039CD4
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

		// Token: 0x0600120F RID: 4623 RVA: 0x0003BB47 File Offset: 0x00039D47
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmNameInvoker.cb_hashCode == null)
			{
				IJvmNameInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmNameInvoker.n_GetHashCode));
			}
			return IJvmNameInvoker.cb_hashCode;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0003BB6B File Offset: 0x00039D6B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0003BB7A File Offset: 0x00039D7A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0003BBBA File Offset: 0x00039DBA
		private static Delegate GetToStringHandler()
		{
			if (IJvmNameInvoker.cb_toString == null)
			{
				IJvmNameInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmNameInvoker.n_ToString));
			}
			return IJvmNameInvoker.cb_toString;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0003BBDE File Offset: 0x00039DDE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmName>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0003BBF4 File Offset: 0x00039DF4
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040005DB RID: 1499
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmName", typeof(IJvmNameInvoker));

		// Token: 0x040005DC RID: 1500
		private IntPtr class_ref;

		// Token: 0x040005DD RID: 1501
		[Nullable(2)]
		private static Delegate cb_name;

		// Token: 0x040005DE RID: 1502
		private IntPtr id_name;

		// Token: 0x040005DF RID: 1503
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005E0 RID: 1504
		private IntPtr id_annotationType;

		// Token: 0x040005E1 RID: 1505
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005E2 RID: 1506
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005E3 RID: 1507
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005E4 RID: 1508
		private IntPtr id_hashCode;

		// Token: 0x040005E5 RID: 1509
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005E6 RID: 1510
		private IntPtr id_toString;
	}
}
