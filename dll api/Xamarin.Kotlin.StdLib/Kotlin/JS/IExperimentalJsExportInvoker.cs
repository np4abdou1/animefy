using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.JS
{
	// Token: 0x02000218 RID: 536
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/js/ExperimentalJsExport", DoNotGenerateAcw = true)]
	internal class IExperimentalJsExportInvoker : Java.Lang.Object, IExperimentalJsExport, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00053148 File Offset: 0x00051348
		private static IntPtr java_class_ref
		{
			get
			{
				return IExperimentalJsExportInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0005316C File Offset: 0x0005136C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IExperimentalJsExportInvoker._members;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00053173 File Offset: 0x00051373
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x0005317B File Offset: 0x0005137B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IExperimentalJsExportInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00053187 File Offset: 0x00051387
		[NullableContext(2)]
		public static IExperimentalJsExport GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IExperimentalJsExport>(handle, transfer);
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00053190 File Offset: 0x00051390
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IExperimentalJsExportInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.js.ExperimentalJsExport'.");
			}
			return handle;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000531BB File Offset: 0x000513BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x000531EC File Offset: 0x000513EC
		public IExperimentalJsExportInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IExperimentalJsExportInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00053224 File Offset: 0x00051424
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IExperimentalJsExportInvoker.cb_annotationType == null)
			{
				IExperimentalJsExportInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalJsExportInvoker.n_AnnotationType));
			}
			return IExperimentalJsExportInvoker.cb_annotationType;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00053248 File Offset: 0x00051448
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IExperimentalJsExport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0005325C File Offset: 0x0005145C
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000532AD File Offset: 0x000514AD
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IExperimentalJsExportInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IExperimentalJsExportInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IExperimentalJsExportInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IExperimentalJsExportInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x000532D4 File Offset: 0x000514D4
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IExperimentalJsExport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000532F8 File Offset: 0x000514F8
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

		// Token: 0x060018FB RID: 6395 RVA: 0x0005336B File Offset: 0x0005156B
		private static Delegate GetGetHashCodeHandler()
		{
			if (IExperimentalJsExportInvoker.cb_hashCode == null)
			{
				IExperimentalJsExportInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IExperimentalJsExportInvoker.n_GetHashCode));
			}
			return IExperimentalJsExportInvoker.cb_hashCode;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0005338F File Offset: 0x0005158F
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IExperimentalJsExport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0005339E File Offset: 0x0005159E
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x000533DE File Offset: 0x000515DE
		private static Delegate GetToStringHandler()
		{
			if (IExperimentalJsExportInvoker.cb_toString == null)
			{
				IExperimentalJsExportInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IExperimentalJsExportInvoker.n_ToString));
			}
			return IExperimentalJsExportInvoker.cb_toString;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00053402 File Offset: 0x00051602
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IExperimentalJsExport>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00053418 File Offset: 0x00051618
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040007BF RID: 1983
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/js/ExperimentalJsExport", typeof(IExperimentalJsExportInvoker));

		// Token: 0x040007C0 RID: 1984
		private IntPtr class_ref;

		// Token: 0x040007C1 RID: 1985
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x040007C2 RID: 1986
		private IntPtr id_annotationType;

		// Token: 0x040007C3 RID: 1987
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040007C4 RID: 1988
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040007C5 RID: 1989
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x040007C6 RID: 1990
		private IntPtr id_hashCode;

		// Token: 0x040007C7 RID: 1991
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040007C8 RID: 1992
		private IntPtr id_toString;
	}
}
