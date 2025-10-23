using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace JetBrains.Annotations
{
	// Token: 0x0200002D RID: 45
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Range", DoNotGenerateAcw = true)]
	internal class IRangeInvoker : Java.Lang.Object, IRange, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00004F58 File Offset: 0x00003158
		private static IntPtr java_class_ref
		{
			get
			{
				return IRangeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00004F7C File Offset: 0x0000317C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRangeInvoker._members;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00004F83 File Offset: 0x00003183
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00004F8B File Offset: 0x0000318B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRangeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004F97 File Offset: 0x00003197
		[NullableContext(2)]
		public static IRange GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRange>(handle, transfer);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00004FA0 File Offset: 0x000031A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRangeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Range'.");
			}
			return handle;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00004FCB File Offset: 0x000031CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00004FFC File Offset: 0x000031FC
		public IRangeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRangeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00005034 File Offset: 0x00003234
		private static Delegate GetFromHandler()
		{
			if (IRangeInvoker.cb_from == null)
			{
				IRangeInvoker.cb_from = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IRangeInvoker.n_From));
			}
			return IRangeInvoker.cb_from;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005058 File Offset: 0x00003258
		private static long n_From(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).From();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005067 File Offset: 0x00003267
		public long From()
		{
			if (this.id_from == IntPtr.Zero)
			{
				this.id_from = JNIEnv.GetMethodID(this.class_ref, "from", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_from);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000050A7 File Offset: 0x000032A7
		private static Delegate GetToHandler()
		{
			if (IRangeInvoker.cb_to == null)
			{
				IRangeInvoker.cb_to = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IRangeInvoker.n_To));
			}
			return IRangeInvoker.cb_to;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000050CB File Offset: 0x000032CB
		private static long n_To(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).To();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000050DA File Offset: 0x000032DA
		public long To()
		{
			if (this.id_to == IntPtr.Zero)
			{
				this.id_to = JNIEnv.GetMethodID(this.class_ref, "to", "()J");
			}
			return JNIEnv.CallLongMethod(base.Handle, this.id_to);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000511A File Offset: 0x0000331A
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IRangeInvoker.cb_annotationType == null)
			{
				IRangeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRangeInvoker.n_AnnotationType));
			}
			return IRangeInvoker.cb_annotationType;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000513E File Offset: 0x0000333E
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005154 File Offset: 0x00003354
		[NullableContext(2)]
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000051A5 File Offset: 0x000033A5
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IRangeInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IRangeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IRangeInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IRangeInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000051CC File Offset: 0x000033CC
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000051F0 File Offset: 0x000033F0
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

		// Token: 0x06000174 RID: 372 RVA: 0x00005263 File Offset: 0x00003463
		private static Delegate GetGetHashCodeHandler()
		{
			if (IRangeInvoker.cb_hashCode == null)
			{
				IRangeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRangeInvoker.n_GetHashCode));
			}
			return IRangeInvoker.cb_hashCode;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005287 File Offset: 0x00003487
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005296 File Offset: 0x00003496
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000052D6 File Offset: 0x000034D6
		private static Delegate GetToStringHandler()
		{
			if (IRangeInvoker.cb_toString == null)
			{
				IRangeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRangeInvoker.n_ToString));
			}
			return IRangeInvoker.cb_toString;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000052FA File Offset: 0x000034FA
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRange>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005310 File Offset: 0x00003510
		[NullableContext(2)]
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000093 RID: 147
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Range", typeof(IRangeInvoker));

		// Token: 0x04000094 RID: 148
		private IntPtr class_ref;

		// Token: 0x04000095 RID: 149
		[Nullable(2)]
		private static Delegate cb_from;

		// Token: 0x04000096 RID: 150
		private IntPtr id_from;

		// Token: 0x04000097 RID: 151
		[Nullable(2)]
		private static Delegate cb_to;

		// Token: 0x04000098 RID: 152
		private IntPtr id_to;

		// Token: 0x04000099 RID: 153
		[Nullable(2)]
		private static Delegate cb_annotationType;

		// Token: 0x0400009A RID: 154
		private IntPtr id_annotationType;

		// Token: 0x0400009B RID: 155
		[Nullable(2)]
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x0400009C RID: 156
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x0400009D RID: 157
		[Nullable(2)]
		private static Delegate cb_hashCode;

		// Token: 0x0400009E RID: 158
		private IntPtr id_hashCode;

		// Token: 0x0400009F RID: 159
		[Nullable(2)]
		private static Delegate cb_toString;

		// Token: 0x040000A0 RID: 160
		private IntPtr id_toString;
	}
}
