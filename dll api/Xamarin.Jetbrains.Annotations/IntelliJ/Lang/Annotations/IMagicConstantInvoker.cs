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
	// Token: 0x02000052 RID: 82
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/MagicConstant", DoNotGenerateAcw = true)]
	internal class IMagicConstantInvoker : Java.Lang.Object, IMagicConstant, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000073CC File Offset: 0x000055CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMagicConstantInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000073F0 File Offset: 0x000055F0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IMagicConstantInvoker._members;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000073F7 File Offset: 0x000055F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000073FF File Offset: 0x000055FF
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IMagicConstantInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000740B File Offset: 0x0000560B
		public static IMagicConstant GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMagicConstant>(handle, transfer);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007414 File Offset: 0x00005614
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMagicConstantInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.MagicConstant'.");
			}
			return handle;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000743F File Offset: 0x0000563F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00007470 File Offset: 0x00005670
		public IMagicConstantInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMagicConstantInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000074A8 File Offset: 0x000056A8
		[NullableContext(1)]
		private static Delegate GetFlagsHandler()
		{
			if (IMagicConstantInvoker.cb_flags == null)
			{
				IMagicConstantInvoker.cb_flags = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_Flags));
			}
			return IMagicConstantInvoker.cb_flags;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000074CC File Offset: 0x000056CC
		private static IntPtr n_Flags(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flags());
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000074E0 File Offset: 0x000056E0
		public long[] Flags()
		{
			if (this.id_flags == IntPtr.Zero)
			{
				this.id_flags = JNIEnv.GetMethodID(this.class_ref, "flags", "()[J");
			}
			return (long[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_flags), JniHandleOwnership.TransferLocalRef, typeof(long));
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00007540 File Offset: 0x00005740
		[NullableContext(1)]
		private static Delegate GetFlagsFromClassHandler()
		{
			if (IMagicConstantInvoker.cb_flagsFromClass == null)
			{
				IMagicConstantInvoker.cb_flagsFromClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_FlagsFromClass));
			}
			return IMagicConstantInvoker.cb_flagsFromClass;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00007564 File Offset: 0x00005764
		private static IntPtr n_FlagsFromClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FlagsFromClass());
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00007578 File Offset: 0x00005778
		public Class FlagsFromClass()
		{
			if (this.id_flagsFromClass == IntPtr.Zero)
			{
				this.id_flagsFromClass = JNIEnv.GetMethodID(this.class_ref, "flagsFromClass", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_flagsFromClass), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000075C9 File Offset: 0x000057C9
		[NullableContext(1)]
		private static Delegate GetIntValuesHandler()
		{
			if (IMagicConstantInvoker.cb_intValues == null)
			{
				IMagicConstantInvoker.cb_intValues = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_IntValues));
			}
			return IMagicConstantInvoker.cb_intValues;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000075ED File Offset: 0x000057ED
		private static IntPtr n_IntValues(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IntValues());
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00007604 File Offset: 0x00005804
		public long[] IntValues()
		{
			if (this.id_intValues == IntPtr.Zero)
			{
				this.id_intValues = JNIEnv.GetMethodID(this.class_ref, "intValues", "()[J");
			}
			return (long[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_intValues), JniHandleOwnership.TransferLocalRef, typeof(long));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00007664 File Offset: 0x00005864
		[NullableContext(1)]
		private static Delegate GetStringValuesHandler()
		{
			if (IMagicConstantInvoker.cb_stringValues == null)
			{
				IMagicConstantInvoker.cb_stringValues = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_StringValues));
			}
			return IMagicConstantInvoker.cb_stringValues;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00007688 File Offset: 0x00005888
		private static IntPtr n_StringValues(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StringValues());
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000769C File Offset: 0x0000589C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] StringValues()
		{
			if (this.id_stringValues == IntPtr.Zero)
			{
				this.id_stringValues = JNIEnv.GetMethodID(this.class_ref, "stringValues", "()[Ljava/lang/String;");
			}
			return (string[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_stringValues), JniHandleOwnership.TransferLocalRef, typeof(string));
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000076FC File Offset: 0x000058FC
		[NullableContext(1)]
		private static Delegate GetValuesFromClassHandler()
		{
			if (IMagicConstantInvoker.cb_valuesFromClass == null)
			{
				IMagicConstantInvoker.cb_valuesFromClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_ValuesFromClass));
			}
			return IMagicConstantInvoker.cb_valuesFromClass;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00007720 File Offset: 0x00005920
		private static IntPtr n_ValuesFromClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ValuesFromClass());
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00007734 File Offset: 0x00005934
		public Class ValuesFromClass()
		{
			if (this.id_valuesFromClass == IntPtr.Zero)
			{
				this.id_valuesFromClass = JNIEnv.GetMethodID(this.class_ref, "valuesFromClass", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_valuesFromClass), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00007785 File Offset: 0x00005985
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IMagicConstantInvoker.cb_annotationType == null)
			{
				IMagicConstantInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_AnnotationType));
			}
			return IMagicConstantInvoker.cb_annotationType;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000077A9 File Offset: 0x000059A9
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000077C0 File Offset: 0x000059C0
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00007811 File Offset: 0x00005A11
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IMagicConstantInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IMagicConstantInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IMagicConstantInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IMagicConstantInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00007838 File Offset: 0x00005A38
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000785C File Offset: 0x00005A5C
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

		// Token: 0x06000292 RID: 658 RVA: 0x000078CF File Offset: 0x00005ACF
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IMagicConstantInvoker.cb_hashCode == null)
			{
				IMagicConstantInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMagicConstantInvoker.n_GetHashCode));
			}
			return IMagicConstantInvoker.cb_hashCode;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000078F3 File Offset: 0x00005AF3
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007902 File Offset: 0x00005B02
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00007942 File Offset: 0x00005B42
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IMagicConstantInvoker.cb_toString == null)
			{
				IMagicConstantInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMagicConstantInvoker.n_ToString));
			}
			return IMagicConstantInvoker.cb_toString;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00007966 File Offset: 0x00005B66
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMagicConstant>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000797C File Offset: 0x00005B7C
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000113 RID: 275
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/MagicConstant", typeof(IMagicConstantInvoker));

		// Token: 0x04000114 RID: 276
		private IntPtr class_ref;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_flags;

		// Token: 0x04000116 RID: 278
		private IntPtr id_flags;

		// Token: 0x04000117 RID: 279
		private static Delegate cb_flagsFromClass;

		// Token: 0x04000118 RID: 280
		private IntPtr id_flagsFromClass;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_intValues;

		// Token: 0x0400011A RID: 282
		private IntPtr id_intValues;

		// Token: 0x0400011B RID: 283
		private static Delegate cb_stringValues;

		// Token: 0x0400011C RID: 284
		private IntPtr id_stringValues;

		// Token: 0x0400011D RID: 285
		private static Delegate cb_valuesFromClass;

		// Token: 0x0400011E RID: 286
		private IntPtr id_valuesFromClass;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_annotationType;

		// Token: 0x04000120 RID: 288
		private IntPtr id_annotationType;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x04000122 RID: 290
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_hashCode;

		// Token: 0x04000124 RID: 292
		private IntPtr id_hashCode;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_toString;

		// Token: 0x04000126 RID: 294
		private IntPtr id_toString;
	}
}
