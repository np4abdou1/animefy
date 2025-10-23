using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Xamarin.Google.ErrorProne.Annotations
{
	// Token: 0x02000036 RID: 54
	[Register("com/google/errorprone/annotations/RequiredModifiers", DoNotGenerateAcw = true)]
	internal class IRequiredModifiersInvoker : Java.Lang.Object, IRequiredModifiers, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00005CFC File Offset: 0x00003EFC
		private static IntPtr java_class_ref
		{
			get
			{
				return IRequiredModifiersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00005D20 File Offset: 0x00003F20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRequiredModifiersInvoker._members;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00005D27 File Offset: 0x00003F27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005D2F File Offset: 0x00003F2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRequiredModifiersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00005D3B File Offset: 0x00003F3B
		public static IRequiredModifiers GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRequiredModifiers>(handle, transfer);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005D44 File Offset: 0x00003F44
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRequiredModifiersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.errorprone.annotations.RequiredModifiers'.");
			}
			return handle;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00005D6F File Offset: 0x00003F6F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public IRequiredModifiersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRequiredModifiersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00005DD8 File Offset: 0x00003FD8
		private static Delegate GetModifierHandler()
		{
			if (IRequiredModifiersInvoker.cb_modifier == null)
			{
				IRequiredModifiersInvoker.cb_modifier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiredModifiersInvoker.n_Modifier));
			}
			return IRequiredModifiersInvoker.cb_modifier;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00005DFC File Offset: 0x00003FFC
		private static IntPtr n_Modifier(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Modifier>(Java.Lang.Object.GetObject<IRequiredModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Modifier());
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005E10 File Offset: 0x00004010
		public Modifier[] Modifier()
		{
			if (this.id_modifier == IntPtr.Zero)
			{
				this.id_modifier = JNIEnv.GetMethodID(this.class_ref, "modifier", "()[Lcom/google/errorprone/annotations/Modifier;");
			}
			return (Modifier[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_modifier), JniHandleOwnership.TransferLocalRef, typeof(Modifier));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00005E70 File Offset: 0x00004070
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRequiredModifiersInvoker.cb_annotationType == null)
			{
				IRequiredModifiersInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiredModifiersInvoker.n_AnnotationType));
			}
			return IRequiredModifiersInvoker.cb_annotationType;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005E94 File Offset: 0x00004094
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRequiredModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005EA8 File Offset: 0x000040A8
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005EF9 File Offset: 0x000040F9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRequiredModifiersInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRequiredModifiersInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRequiredModifiersInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRequiredModifiersInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005F20 File Offset: 0x00004120
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRequiredModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005F44 File Offset: 0x00004144
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

		// Token: 0x060001C6 RID: 454 RVA: 0x00005FB7 File Offset: 0x000041B7
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRequiredModifiersInvoker.cb_hashCode == null)
			{
				IRequiredModifiersInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRequiredModifiersInvoker.n_GetHashCode));
			}
			return IRequiredModifiersInvoker.cb_hashCode;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005FDB File Offset: 0x000041DB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRequiredModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00005FEA File Offset: 0x000041EA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000602A File Offset: 0x0000422A
		private static Delegate GetToStringHandler()
		{
			if (IRequiredModifiersInvoker.cb_toString == null)
			{
				IRequiredModifiersInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRequiredModifiersInvoker.n_ToString));
			}
			return IRequiredModifiersInvoker.cb_toString;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000604E File Offset: 0x0000424E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRequiredModifiers>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00006064 File Offset: 0x00004264
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000C5 RID: 197
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/errorprone/annotations/RequiredModifiers", typeof(IRequiredModifiersInvoker));

		// Token: 0x040000C6 RID: 198
		private IntPtr class_ref;

		// Token: 0x040000C7 RID: 199
		private static Delegate cb_modifier;

		// Token: 0x040000C8 RID: 200
		private IntPtr id_modifier;

		// Token: 0x040000C9 RID: 201
		private static Delegate cb_annotationType;

		// Token: 0x040000CA RID: 202
		private IntPtr id_annotationType;

		// Token: 0x040000CB RID: 203
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000CC RID: 204
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000CD RID: 205
		private static Delegate cb_hashCode;

		// Token: 0x040000CE RID: 206
		private IntPtr id_hashCode;

		// Token: 0x040000CF RID: 207
		private static Delegate cb_toString;

		// Token: 0x040000D0 RID: 208
		private IntPtr id_toString;
	}
}
