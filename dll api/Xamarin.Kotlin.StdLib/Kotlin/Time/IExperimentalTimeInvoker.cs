using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Time
{
	// Token: 0x020000C9 RID: 201
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/ExperimentalTime", DoNotGenerateAcw = true)]
	internal class IExperimentalTimeInvoker : Java.Lang.Object, IExperimentalTime, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0000EF90 File Offset: 0x0000D190
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalTimeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalTimeInvoker._members;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0000EFBB File Offset: 0x0000D1BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000EFC3 File Offset: 0x0000D1C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalTimeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000EFCF File Offset: 0x0000D1CF
		[NullableContext(2)]
		public static IExperimentalTime GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalTime>(handle, transfer);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalTimeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.time.ExperimentalTime'.");
			}
			return handle;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000F003 File Offset: 0x0000D203
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000F034 File Offset: 0x0000D234
		public IExperimentalTimeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalTimeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000F06C File Offset: 0x0000D26C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalTimeInvoker.cb_annotationType == null)
			{
				IExperimentalTimeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalTimeInvoker.n_AnnotationType));
			}
			return IExperimentalTimeInvoker.cb_annotationType;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000F090 File Offset: 0x0000D290
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000F0F5 File Offset: 0x0000D2F5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalTimeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalTimeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalTimeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalTimeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000F11C File Offset: 0x0000D31C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000F140 File Offset: 0x0000D340
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

		// Token: 0x06000602 RID: 1538 RVA: 0x0000F1B3 File Offset: 0x0000D3B3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalTimeInvoker.cb_hashCode == null)
			{
				IExperimentalTimeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalTimeInvoker.n_GetHashCode));
			}
			return IExperimentalTimeInvoker.cb_hashCode;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000F1D7 File Offset: 0x0000D3D7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000F226 File Offset: 0x0000D426
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalTimeInvoker.cb_toString == null)
			{
				IExperimentalTimeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalTimeInvoker.n_ToString));
			}
			return IExperimentalTimeInvoker.cb_toString;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000F24A File Offset: 0x0000D44A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalTime>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000F260 File Offset: 0x0000D460
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040001A3 RID: 419
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/ExperimentalTime", typeof(IExperimentalTimeInvoker));

		// Token: 0x040001A4 RID: 420
		private IntPtr class_ref;

		// Token: 0x040001A5 RID: 421
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040001A6 RID: 422
		private IntPtr id_annotationType;

		// Token: 0x040001A7 RID: 423
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040001A8 RID: 424
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040001A9 RID: 425
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040001AA RID: 426
		private IntPtr id_hashCode;

		// Token: 0x040001AB RID: 427
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040001AC RID: 428
		private IntPtr id_toString;
	}
}
