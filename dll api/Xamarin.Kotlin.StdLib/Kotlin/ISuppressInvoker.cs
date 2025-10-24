using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x02000084 RID: 132
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/Suppress", DoNotGenerateAcw = true)]
	internal class ISuppressInvoker : Java.Lang.Object, ISuppress, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000085DC File Offset: 0x000067DC
		private static IntPtr java_class_ref
		{
			get
			{
				return ISuppressInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00008600 File Offset: 0x00006800
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISuppressInvoker._members;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00008607 File Offset: 0x00006807
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000860F File Offset: 0x0000680F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISuppressInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000861B File Offset: 0x0000681B
		[NullableContext(2)]
		public static ISuppress GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISuppress>(handle, transfer);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00008624 File Offset: 0x00006824
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISuppressInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.Suppress'.");
			}
			return handle;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000864F File Offset: 0x0000684F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00008680 File Offset: 0x00006880
		public ISuppressInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISuppressInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000086B8 File Offset: 0x000068B8
		private static Delegate GetNamesHandler()
		{
			if (ISuppressInvoker.cb_names == null)
			{
				ISuppressInvoker.cb_names = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISuppressInvoker.n_Names));
			}
			return ISuppressInvoker.cb_names;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000086DC File Offset: 0x000068DC
		private static IntPtr n_Names(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ISuppress>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Names());
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000086F0 File Offset: 0x000068F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] Names()
		{
			if (this.id_names == IntPtr.Zero)
			{
				this.id_names = JNIEnv.GetMethodID(this.class_ref, "names", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_names), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00008750 File Offset: 0x00006950
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISuppressInvoker.cb_annotationType == null)
			{
				ISuppressInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISuppressInvoker.n_AnnotationType));
			}
			return ISuppressInvoker.cb_annotationType;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00008774 File Offset: 0x00006974
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISuppress>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00008788 File Offset: 0x00006988
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000087D9 File Offset: 0x000069D9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISuppressInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISuppressInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISuppressInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISuppressInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00008800 File Offset: 0x00006A00
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISuppress>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00008824 File Offset: 0x00006A24
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

		// Token: 0x0600039B RID: 923 RVA: 0x00008897 File Offset: 0x00006A97
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISuppressInvoker.cb_hashCode == null)
			{
				ISuppressInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISuppressInvoker.n_GetHashCode));
			}
			return ISuppressInvoker.cb_hashCode;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000088BB File Offset: 0x00006ABB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISuppress>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000088CA File Offset: 0x00006ACA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000890A File Offset: 0x00006B0A
		private static Delegate GetToStringHandler()
		{
			if (ISuppressInvoker.cb_toString == null)
			{
				ISuppressInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISuppressInvoker.n_ToString));
			}
			return ISuppressInvoker.cb_toString;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000892E File Offset: 0x00006B2E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISuppress>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00008944 File Offset: 0x00006B44
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000120 RID: 288
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Suppress", typeof(ISuppressInvoker));

		// Token: 0x04000121 RID: 289
		private IntPtr class_ref;

		// Token: 0x04000122 RID: 290
		[Nullable(2)]
		private static Delegate cb_names;

		// Token: 0x04000123 RID: 291
		private IntPtr id_names;

		// Token: 0x04000124 RID: 292
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x04000125 RID: 293
		private IntPtr id_annotationType;

		// Token: 0x04000126 RID: 294
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000127 RID: 295
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000128 RID: 296
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x04000129 RID: 297
		private IntPtr id_hashCode;

		// Token: 0x0400012A RID: 298
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x0400012B RID: 299
		private IntPtr id_toString;
	}
}
