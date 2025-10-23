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
	// Token: 0x020001A9 RID: 425
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/RepeatableContainer", DoNotGenerateAcw = true)]
	internal class IRepeatableContainerInvoker : Java.Lang.Object, IRepeatableContainer, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x00043DA0 File Offset: 0x00041FA0
		private static IntPtr java_class_ref
		{
			get
			{
				return IRepeatableContainerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x00043DC4 File Offset: 0x00041FC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRepeatableContainerInvoker._members;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00043DCB File Offset: 0x00041FCB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00043DD3 File Offset: 0x00041FD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRepeatableContainerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00043DDF File Offset: 0x00041FDF
		[NullableContext(2)]
		public static IRepeatableContainer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRepeatableContainer>(handle, transfer);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00043DE8 File Offset: 0x00041FE8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRepeatableContainerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.RepeatableContainer'.");
			}
			return handle;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00043E13 File Offset: 0x00042013
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00043E44 File Offset: 0x00042044
		public IRepeatableContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRepeatableContainerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00043E7C File Offset: 0x0004207C
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRepeatableContainerInvoker.cb_annotationType == null)
			{
				IRepeatableContainerInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRepeatableContainerInvoker.n_AnnotationType));
			}
			return IRepeatableContainerInvoker.cb_annotationType;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00043EA0 File Offset: 0x000420A0
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRepeatableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00043EB4 File Offset: 0x000420B4
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00043F05 File Offset: 0x00042105
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRepeatableContainerInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRepeatableContainerInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRepeatableContainerInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRepeatableContainerInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00043F2C File Offset: 0x0004212C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRepeatableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00043F50 File Offset: 0x00042150
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

		// Token: 0x060014FB RID: 5371 RVA: 0x00043FC3 File Offset: 0x000421C3
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRepeatableContainerInvoker.cb_hashCode == null)
			{
				IRepeatableContainerInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRepeatableContainerInvoker.n_GetHashCode));
			}
			return IRepeatableContainerInvoker.cb_hashCode;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00043FE7 File Offset: 0x000421E7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRepeatableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00043FF6 File Offset: 0x000421F6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00044036 File Offset: 0x00042236
		private static Delegate GetToStringHandler()
		{
			if (IRepeatableContainerInvoker.cb_toString == null)
			{
				IRepeatableContainerInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRepeatableContainerInvoker.n_ToString));
			}
			return IRepeatableContainerInvoker.cb_toString;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0004405A File Offset: 0x0004225A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRepeatableContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00044070 File Offset: 0x00042270
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040006BD RID: 1725
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/RepeatableContainer", typeof(IRepeatableContainerInvoker));

		// Token: 0x040006BE RID: 1726
		private IntPtr class_ref;

		// Token: 0x040006BF RID: 1727
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040006C0 RID: 1728
		private IntPtr id_annotationType;

		// Token: 0x040006C1 RID: 1729
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040006C2 RID: 1730
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040006C3 RID: 1731
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040006C4 RID: 1732
		private IntPtr id_hashCode;

		// Token: 0x040006C5 RID: 1733
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040006C6 RID: 1734
		private IntPtr id_toString;
	}
}
