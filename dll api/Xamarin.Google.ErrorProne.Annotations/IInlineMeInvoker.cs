using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000026 RID: 38
	[Register("com/google/errorprone/annotations/InlineMe", DoNotGenerateAcw = true)]
	internal class IInlineMeInvoker : Java.Lang.Object, IInlineMe, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000046F4 File Offset: 0x000028F4
		private static IntPtr java_class_ref
		{
			get
			{
				return IInlineMeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004718 File Offset: 0x00002918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInlineMeInvoker._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000471F File Offset: 0x0000291F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004727 File Offset: 0x00002927
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInlineMeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004733 File Offset: 0x00002933
		public static IInlineMe GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInlineMe>(handle, transfer);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000473C File Offset: 0x0000293C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInlineMeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.InlineMe'.");
			}
			return handle;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004767 File Offset: 0x00002967
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004798 File Offset: 0x00002998
		public IInlineMeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInlineMeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000047D0 File Offset: 0x000029D0
		private static Delegate GetImportsHandler()
		{
			if (IInlineMeInvoker.cb_imports == null)
			{
				IInlineMeInvoker.cb_imports = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeInvoker.n_Imports));
			}
			return IInlineMeInvoker.cb_imports;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000047F4 File Offset: 0x000029F4
		private static IntPtr n_Imports(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Imports());
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004808 File Offset: 0x00002A08
		public string[] Imports()
		{
			if (this.id_imports == IntPtr.Zero)
			{
				this.id_imports = JNIEnv.GetMethodID(this.class_ref, "imports", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_imports), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004868 File Offset: 0x00002A68
		private static Delegate GetReplacementHandler()
		{
			if (IInlineMeInvoker.cb_replacement == null)
			{
				IInlineMeInvoker.cb_replacement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeInvoker.n_Replacement));
			}
			return IInlineMeInvoker.cb_replacement;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000488C File Offset: 0x00002A8C
		private static IntPtr n_Replacement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Replacement());
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000048A0 File Offset: 0x00002AA0
		public string Replacement()
		{
			if (this.id_replacement == IntPtr.Zero)
			{
				this.id_replacement = JNIEnv.GetMethodID(this.class_ref, "replacement", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_replacement), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000048F1 File Offset: 0x00002AF1
		private static Delegate GetStaticImportsHandler()
		{
			if (IInlineMeInvoker.cb_staticImports == null)
			{
				IInlineMeInvoker.cb_staticImports = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeInvoker.n_StaticImports));
			}
			return IInlineMeInvoker.cb_staticImports;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004915 File Offset: 0x00002B15
		private static IntPtr n_StaticImports(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StaticImports());
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000492C File Offset: 0x00002B2C
		public string[] StaticImports()
		{
			if (this.id_staticImports == IntPtr.Zero)
			{
				this.id_staticImports = JNIEnv.GetMethodID(this.class_ref, "staticImports", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_staticImports), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000498C File Offset: 0x00002B8C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IInlineMeInvoker.cb_annotationType == null)
			{
				IInlineMeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeInvoker.n_AnnotationType));
			}
			return IInlineMeInvoker.cb_annotationType;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000049B0 File Offset: 0x00002BB0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000049C4 File Offset: 0x00002BC4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004A15 File Offset: 0x00002C15
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IInlineMeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IInlineMeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IInlineMeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IInlineMeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004A3C File Offset: 0x00002C3C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004A60 File Offset: 0x00002C60
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

		// Token: 0x06000132 RID: 306 RVA: 0x00004AD3 File Offset: 0x00002CD3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IInlineMeInvoker.cb_hashCode == null)
			{
				IInlineMeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IInlineMeInvoker.n_GetHashCode));
			}
			return IInlineMeInvoker.cb_hashCode;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004AF7 File Offset: 0x00002CF7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004B06 File Offset: 0x00002D06
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004B46 File Offset: 0x00002D46
		private static Delegate GetToStringHandler()
		{
			if (IInlineMeInvoker.cb_toString == null)
			{
				IInlineMeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IInlineMeInvoker.n_ToString));
			}
			return IInlineMeInvoker.cb_toString;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004B6A File Offset: 0x00002D6A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IInlineMe>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004B80 File Offset: 0x00002D80
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400007C RID: 124
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/InlineMe", typeof(IInlineMeInvoker));

		// Token: 0x0400007D RID: 125
		private IntPtr class_ref;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_imports;

		// Token: 0x0400007F RID: 127
		private IntPtr id_imports;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_replacement;

		// Token: 0x04000081 RID: 129
		private IntPtr id_replacement;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_staticImports;

		// Token: 0x04000083 RID: 131
		private IntPtr id_staticImports;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_annotationType;

		// Token: 0x04000085 RID: 133
		private IntPtr id_annotationType;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000087 RID: 135
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_hashCode;

		// Token: 0x04000089 RID: 137
		private IntPtr id_hashCode;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_toString;

		// Token: 0x0400008B RID: 139
		private IntPtr id_toString;
	}
}
