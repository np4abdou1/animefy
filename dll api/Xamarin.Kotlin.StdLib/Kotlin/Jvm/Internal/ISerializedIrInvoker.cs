using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AB RID: 427
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/SerializedIr", DoNotGenerateAcw = true)]
	internal class ISerializedIrInvoker : Java.Lang.Object, ISerializedIr, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000440DC File Offset: 0x000422DC
		private static IntPtr java_class_ref
		{
			get
			{
				return ISerializedIrInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00044100 File Offset: 0x00042300
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISerializedIrInvoker._members;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x00044107 File Offset: 0x00042307
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0004410F File Offset: 0x0004230F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISerializedIrInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0004411B File Offset: 0x0004231B
		[NullableContext(2)]
		public static ISerializedIr GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISerializedIr>(handle, transfer);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00044124 File Offset: 0x00042324
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISerializedIrInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.SerializedIr'.");
			}
			return handle;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0004414F File Offset: 0x0004234F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00044180 File Offset: 0x00042380
		public ISerializedIrInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISerializedIrInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000441B8 File Offset: 0x000423B8
		private static Delegate GetBHandler()
		{
			if (ISerializedIrInvoker.cb_b == null)
			{
				ISerializedIrInvoker.cb_b = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISerializedIrInvoker.n_B));
			}
			return ISerializedIrInvoker.cb_b;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000441DC File Offset: 0x000423DC
		private static IntPtr n_B(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<ISerializedIr>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).B());
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000441F0 File Offset: 0x000423F0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] B()
		{
			if (this.id_b == IntPtr.Zero)
			{
				this.id_b = JNIEnv.GetMethodID(this.class_ref, "b", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_b), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00044250 File Offset: 0x00042450
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ISerializedIrInvoker.cb_annotationType == null)
			{
				ISerializedIrInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISerializedIrInvoker.n_AnnotationType));
			}
			return ISerializedIrInvoker.cb_annotationType;
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00044274 File Offset: 0x00042474
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISerializedIr>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00044288 File Offset: 0x00042488
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000442D9 File Offset: 0x000424D9
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ISerializedIrInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ISerializedIrInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ISerializedIrInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ISerializedIrInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00044300 File Offset: 0x00042500
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ISerializedIr>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00044324 File Offset: 0x00042524
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

		// Token: 0x06001514 RID: 5396 RVA: 0x00044397 File Offset: 0x00042597
		private static Delegate GetGetHashCodeHandler()
		{
			if (ISerializedIrInvoker.cb_hashCode == null)
			{
				ISerializedIrInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISerializedIrInvoker.n_GetHashCode));
			}
			return ISerializedIrInvoker.cb_hashCode;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000443BB File Offset: 0x000425BB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISerializedIr>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000443CA File Offset: 0x000425CA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0004440A File Offset: 0x0004260A
		private static Delegate GetToStringHandler()
		{
			if (ISerializedIrInvoker.cb_toString == null)
			{
				ISerializedIrInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISerializedIrInvoker.n_ToString));
			}
			return ISerializedIrInvoker.cb_toString;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0004442E File Offset: 0x0004262E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ISerializedIr>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00044444 File Offset: 0x00042644
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040006C7 RID: 1735
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/SerializedIr", typeof(ISerializedIrInvoker));

		// Token: 0x040006C8 RID: 1736
		private IntPtr class_ref;

		// Token: 0x040006C9 RID: 1737
		[Nullable(2)]
		private static Delegate cb_b;

		// Token: 0x040006CA RID: 1738
		private IntPtr id_b;

		// Token: 0x040006CB RID: 1739
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040006CC RID: 1740
		private IntPtr id_annotationType;

		// Token: 0x040006CD RID: 1741
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040006CE RID: 1742
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040006CF RID: 1743
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040006D0 RID: 1744
		private IntPtr id_hashCode;

		// Token: 0x040006D1 RID: 1745
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040006D2 RID: 1746
		private IntPtr id_toString;
	}
}
