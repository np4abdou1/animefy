using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000058 RID: 88
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/RegExp", DoNotGenerateAcw = true)]
	internal class IRegExpInvoker : Java.Lang.Object, IRegExp, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000080EC File Offset: 0x000062EC
		private static IntPtr java_class_ref
		{
			get
			{
				return IRegExpInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00008110 File Offset: 0x00006310
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IRegExpInvoker._members;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00008117 File Offset: 0x00006317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000811F File Offset: 0x0000631F
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IRegExpInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000812B File Offset: 0x0000632B
		public static IRegExp GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRegExp>(handle, transfer);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00008134 File Offset: 0x00006334
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRegExpInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.RegExp'.");
			}
			return handle;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000815F File Offset: 0x0000635F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00008190 File Offset: 0x00006390
		public IRegExpInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRegExpInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000081C8 File Offset: 0x000063C8
		[NullableContext(1)]
		private static Delegate GetPrefixHandler()
		{
			if (IRegExpInvoker.cb_prefix == null)
			{
				IRegExpInvoker.cb_prefix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRegExpInvoker.n_Prefix));
			}
			return IRegExpInvoker.cb_prefix;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000081EC File Offset: 0x000063EC
		private static IntPtr n_Prefix(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Prefix());
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00008200 File Offset: 0x00006400
		public string Prefix()
		{
			if (this.id_prefix == IntPtr.Zero)
			{
				this.id_prefix = JNIEnv.GetMethodID(this.class_ref, "prefix", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_prefix), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00008251 File Offset: 0x00006451
		[NullableContext(1)]
		private static Delegate GetSuffixHandler()
		{
			if (IRegExpInvoker.cb_suffix == null)
			{
				IRegExpInvoker.cb_suffix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRegExpInvoker.n_Suffix));
			}
			return IRegExpInvoker.cb_suffix;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00008275 File Offset: 0x00006475
		private static IntPtr n_Suffix(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Suffix());
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000828C File Offset: 0x0000648C
		public string Suffix()
		{
			if (this.id_suffix == IntPtr.Zero)
			{
				this.id_suffix = JNIEnv.GetMethodID(this.class_ref, "suffix", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_suffix), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000082DD File Offset: 0x000064DD
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRegExpInvoker.cb_annotationType == null)
			{
				IRegExpInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRegExpInvoker.n_AnnotationType));
			}
			return IRegExpInvoker.cb_annotationType;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00008301 File Offset: 0x00006501
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00008318 File Offset: 0x00006518
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00008369 File Offset: 0x00006569
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRegExpInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRegExpInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRegExpInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRegExpInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00008390 File Offset: 0x00006590
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000083B4 File Offset: 0x000065B4
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

		// Token: 0x060002DD RID: 733 RVA: 0x00008427 File Offset: 0x00006627
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRegExpInvoker.cb_hashCode == null)
			{
				IRegExpInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRegExpInvoker.n_GetHashCode));
			}
			return IRegExpInvoker.cb_hashCode;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000844B File Offset: 0x0000664B
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000845A File Offset: 0x0000665A
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000849A File Offset: 0x0000669A
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IRegExpInvoker.cb_toString == null)
			{
				IRegExpInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRegExpInvoker.n_ToString));
			}
			return IRegExpInvoker.cb_toString;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000084BE File Offset: 0x000066BE
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRegExp>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000084D4 File Offset: 0x000066D4
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400013D RID: 317
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/RegExp", typeof(IRegExpInvoker));

		// Token: 0x0400013E RID: 318
		private IntPtr class_ref;

		// Token: 0x0400013F RID: 319
		private static Delegate cb_prefix;

		// Token: 0x04000140 RID: 320
		private IntPtr id_prefix;

		// Token: 0x04000141 RID: 321
		private static Delegate cb_suffix;

		// Token: 0x04000142 RID: 322
		private IntPtr id_suffix;

		// Token: 0x04000143 RID: 323
		private static Delegate cb_annotationType;

		// Token: 0x04000144 RID: 324
		private IntPtr id_annotationType;

		// Token: 0x04000145 RID: 325
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000146 RID: 326
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_hashCode;

		// Token: 0x04000148 RID: 328
		private IntPtr id_hashCode;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_toString;

		// Token: 0x0400014A RID: 330
		private IntPtr id_toString;
	}
}
