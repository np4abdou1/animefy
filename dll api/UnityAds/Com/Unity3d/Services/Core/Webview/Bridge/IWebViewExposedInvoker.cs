using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000079 RID: 121
	[Register("com/unity3d/services/core/webview/bridge/WebViewExposed", DoNotGenerateAcw = true)]
	internal class IWebViewExposedInvoker : Java.Lang.Object, IWebViewExposed, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000C108 File Offset: 0x0000A308
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebViewExposedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000C12C File Offset: 0x0000A32C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebViewExposedInvoker._members;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000C133 File Offset: 0x0000A333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000C13B File Offset: 0x0000A33B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebViewExposedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000C147 File Offset: 0x0000A347
		public static IWebViewExposed GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebViewExposed>(handle, transfer);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000C150 File Offset: 0x0000A350
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebViewExposedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.webview.bridge.WebViewExposed'.");
			}
			return handle;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C17B File Offset: 0x0000A37B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		public IWebViewExposedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebViewExposedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IWebViewExposedInvoker.cb_annotationType == null)
			{
				IWebViewExposedInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebViewExposedInvoker.n_AnnotationType));
			}
			return IWebViewExposedInvoker.cb_annotationType;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000C208 File Offset: 0x0000A408
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWebViewExposed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000C21C File Offset: 0x0000A41C
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000C26D File Offset: 0x0000A46D
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IWebViewExposedInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IWebViewExposedInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IWebViewExposedInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IWebViewExposedInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000C294 File Offset: 0x0000A494
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IWebViewExposed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
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

		// Token: 0x0600043D RID: 1085 RVA: 0x0000C32B File Offset: 0x0000A52B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IWebViewExposedInvoker.cb_hashCode == null)
			{
				IWebViewExposedInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IWebViewExposedInvoker.n_GetHashCode));
			}
			return IWebViewExposedInvoker.cb_hashCode;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000C34F File Offset: 0x0000A54F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWebViewExposed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000C35E File Offset: 0x0000A55E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000C39E File Offset: 0x0000A59E
		private static Delegate GetToStringHandler()
		{
			if (IWebViewExposedInvoker.cb_toString == null)
			{
				IWebViewExposedInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebViewExposedInvoker.n_ToString));
			}
			return IWebViewExposedInvoker.cb_toString;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWebViewExposed>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000DB RID: 219
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewExposed", typeof(IWebViewExposedInvoker));

		// Token: 0x040000DC RID: 220
		private IntPtr class_ref;

		// Token: 0x040000DD RID: 221
		private static Delegate cb_annotationType;

		// Token: 0x040000DE RID: 222
		private IntPtr id_annotationType;

		// Token: 0x040000DF RID: 223
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000E0 RID: 224
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000E1 RID: 225
		private static Delegate cb_hashCode;

		// Token: 0x040000E2 RID: 226
		private IntPtr id_hashCode;

		// Token: 0x040000E3 RID: 227
		private static Delegate cb_toString;

		// Token: 0x040000E4 RID: 228
		private IntPtr id_toString;
	}
}
