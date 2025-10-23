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
	// Token: 0x02000050 RID: 80
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Language", DoNotGenerateAcw = true)]
	internal class ILanguageInvoker : Java.Lang.Object, ILanguage, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00006EEC File Offset: 0x000050EC
		private static IntPtr java_class_ref
		{
			get
			{
				return ILanguageInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00006F10 File Offset: 0x00005110
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ILanguageInvoker._members;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00006F17 File Offset: 0x00005117
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00006F1F File Offset: 0x0000511F
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ILanguageInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00006F2B File Offset: 0x0000512B
		public static ILanguage GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILanguage>(handle, transfer);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00006F34 File Offset: 0x00005134
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILanguageInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.Language'.");
			}
			return handle;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00006F5F File Offset: 0x0000515F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00006F90 File Offset: 0x00005190
		public ILanguageInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILanguageInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00006FC8 File Offset: 0x000051C8
		[NullableContext(1)]
		private static Delegate GetPrefixHandler()
		{
			if (ILanguageInvoker.cb_prefix == null)
			{
				ILanguageInvoker.cb_prefix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILanguageInvoker.n_Prefix));
			}
			return ILanguageInvoker.cb_prefix;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00006FEC File Offset: 0x000051EC
		private static IntPtr n_Prefix(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Prefix());
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00007000 File Offset: 0x00005200
		public string Prefix()
		{
			if (this.id_prefix == IntPtr.Zero)
			{
				this.id_prefix = JNIEnv.GetMethodID(this.class_ref, "prefix", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_prefix), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00007051 File Offset: 0x00005251
		[NullableContext(1)]
		private static Delegate GetSuffixHandler()
		{
			if (ILanguageInvoker.cb_suffix == null)
			{
				ILanguageInvoker.cb_suffix = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILanguageInvoker.n_Suffix));
			}
			return ILanguageInvoker.cb_suffix;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007075 File Offset: 0x00005275
		private static IntPtr n_Suffix(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Suffix());
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000708C File Offset: 0x0000528C
		public string Suffix()
		{
			if (this.id_suffix == IntPtr.Zero)
			{
				this.id_suffix = JNIEnv.GetMethodID(this.class_ref, "suffix", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_suffix), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000070DD File Offset: 0x000052DD
		[NullableContext(1)]
		private static Delegate GetValueHandler()
		{
			if (ILanguageInvoker.cb_value == null)
			{
				ILanguageInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILanguageInvoker.n_Value));
			}
			return ILanguageInvoker.cb_value;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00007101 File Offset: 0x00005301
		private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00007118 File Offset: 0x00005318
		public string Value()
		{
			if (this.id_value == IntPtr.Zero)
			{
				this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00007169 File Offset: 0x00005369
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (ILanguageInvoker.cb_annotationType == null)
			{
				ILanguageInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILanguageInvoker.n_AnnotationType));
			}
			return ILanguageInvoker.cb_annotationType;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000718D File Offset: 0x0000538D
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000071A4 File Offset: 0x000053A4
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000071F5 File Offset: 0x000053F5
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (ILanguageInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				ILanguageInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ILanguageInvoker.n_Equals_Ljava_lang_Object_));
			}
			return ILanguageInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000721C File Offset: 0x0000541C
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007240 File Offset: 0x00005440
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

		// Token: 0x06000269 RID: 617 RVA: 0x000072B3 File Offset: 0x000054B3
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (ILanguageInvoker.cb_hashCode == null)
			{
				ILanguageInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ILanguageInvoker.n_GetHashCode));
			}
			return ILanguageInvoker.cb_hashCode;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000072D7 File Offset: 0x000054D7
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000072E6 File Offset: 0x000054E6
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00007326 File Offset: 0x00005526
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (ILanguageInvoker.cb_toString == null)
			{
				ILanguageInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILanguageInvoker.n_ToString));
			}
			return ILanguageInvoker.cb_toString;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000734A File Offset: 0x0000554A
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ILanguage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00007360 File Offset: 0x00005560
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000103 RID: 259
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/Language", typeof(ILanguageInvoker));

		// Token: 0x04000104 RID: 260
		private IntPtr class_ref;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_prefix;

		// Token: 0x04000106 RID: 262
		private IntPtr id_prefix;

		// Token: 0x04000107 RID: 263
		private static Delegate cb_suffix;

		// Token: 0x04000108 RID: 264
		private IntPtr id_suffix;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_value;

		// Token: 0x0400010A RID: 266
		private IntPtr id_value;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_annotationType;

		// Token: 0x0400010C RID: 268
		private IntPtr id_annotationType;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400010E RID: 270
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_hashCode;

		// Token: 0x04000110 RID: 272
		private IntPtr id_hashCode;

		// Token: 0x04000111 RID: 273
		private static Delegate cb_toString;

		// Token: 0x04000112 RID: 274
		private IntPtr id_toString;
	}
}
