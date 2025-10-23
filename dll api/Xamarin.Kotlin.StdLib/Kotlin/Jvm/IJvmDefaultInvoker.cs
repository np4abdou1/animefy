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
	// Token: 0x0200014F RID: 335
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/JvmDefault", DoNotGenerateAcw = true)]
	internal class IJvmDefaultInvoker : Java.Lang.Object, IJvmDefault, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0003A530 File Offset: 0x00038730
		private static IntPtr java_class_ref
		{
			get
			{
				return IJvmDefaultInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0003A554 File Offset: 0x00038754
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IJvmDefaultInvoker._members;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0003A55B File Offset: 0x0003875B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0003A563 File Offset: 0x00038763
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IJvmDefaultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0003A56F File Offset: 0x0003876F
		[NullableContext(2)]
		public static IJvmDefault GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IJvmDefault>(handle, transfer);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0003A578 File Offset: 0x00038778
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IJvmDefaultInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.JvmDefault'.");
			}
			return handle;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0003A5A3 File Offset: 0x000387A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0003A5D4 File Offset: 0x000387D4
		public IJvmDefaultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IJvmDefaultInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0003A60C File Offset: 0x0003880C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IJvmDefaultInvoker.cb_annotationType == null)
			{
				IJvmDefaultInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultInvoker.n_AnnotationType));
			}
			return IJvmDefaultInvoker.cb_annotationType;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0003A630 File Offset: 0x00038830
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IJvmDefault>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0003A644 File Offset: 0x00038844
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0003A695 File Offset: 0x00038895
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IJvmDefaultInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IJvmDefaultInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IJvmDefaultInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IJvmDefaultInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0003A6BC File Offset: 0x000388BC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IJvmDefault>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0003A6E0 File Offset: 0x000388E0
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

		// Token: 0x0600118D RID: 4493 RVA: 0x0003A753 File Offset: 0x00038953
		private static Delegate GetGetHashCodeHandler()
		{
			if (IJvmDefaultInvoker.cb_hashCode == null)
			{
				IJvmDefaultInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IJvmDefaultInvoker.n_GetHashCode));
			}
			return IJvmDefaultInvoker.cb_hashCode;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0003A777 File Offset: 0x00038977
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IJvmDefault>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0003A786 File Offset: 0x00038986
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0003A7C6 File Offset: 0x000389C6
		private static Delegate GetToStringHandler()
		{
			if (IJvmDefaultInvoker.cb_toString == null)
			{
				IJvmDefaultInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IJvmDefaultInvoker.n_ToString));
			}
			return IJvmDefaultInvoker.cb_toString;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0003A7EA File Offset: 0x000389EA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IJvmDefault>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0003A800 File Offset: 0x00038A00
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400059F RID: 1439
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/JvmDefault", typeof(IJvmDefaultInvoker));

		// Token: 0x040005A0 RID: 1440
		private IntPtr class_ref;

		// Token: 0x040005A1 RID: 1441
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040005A2 RID: 1442
		private IntPtr id_annotationType;

		// Token: 0x040005A3 RID: 1443
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040005A4 RID: 1444
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040005A5 RID: 1445
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040005A6 RID: 1446
		private IntPtr id_hashCode;

		// Token: 0x040005A7 RID: 1447
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040005A8 RID: 1448
		private IntPtr id_toString;
	}
}
