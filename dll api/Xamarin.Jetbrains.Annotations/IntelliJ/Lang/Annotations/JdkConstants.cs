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
	// Token: 0x0200005B RID: 91
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("org/intellij/lang/annotations/JdkConstants", DoNotGenerateAcw = true)]
	public sealed class JdkConstants : Java.Lang.Object
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00008908 File Offset: 0x00006B08
		internal static IntPtr class_ref
		{
			get
			{
				return JdkConstants._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000892C File Offset: 0x00006B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JdkConstants._members;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00008934 File Offset: 0x00006B34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JdkConstants._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00008958 File Offset: 0x00006B58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JdkConstants._members.ManagedPeerType;
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00008964 File Offset: 0x00006B64
		internal JdkConstants(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000157 RID: 343
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants", typeof(JdkConstants));

		// Token: 0x02000077 RID: 119
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$AdjustableOrientation", "", "IntelliJ.Lang.Annotations.JdkConstants/IAdjustableOrientationInvoker")]
		public interface IAdjustableOrientation : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000078 RID: 120
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$AdjustableOrientation", DoNotGenerateAcw = true)]
		internal class IAdjustableOrientationInvoker : Java.Lang.Object, JdkConstants.IAdjustableOrientation, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000AE28 File Offset: 0x00009028
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IAdjustableOrientationInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000AE4C File Offset: 0x0000904C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IAdjustableOrientationInvoker._members;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000AE53 File Offset: 0x00009053
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000AE5B File Offset: 0x0000905B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IAdjustableOrientationInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600040F RID: 1039 RVA: 0x0000AE67 File Offset: 0x00009067
			[NullableContext(2)]
			public static JdkConstants.IAdjustableOrientation GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IAdjustableOrientation>(handle, transfer);
			}

			// Token: 0x06000410 RID: 1040 RVA: 0x0000AE70 File Offset: 0x00009070
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IAdjustableOrientationInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.AdjustableOrientation'.");
				}
				return handle;
			}

			// Token: 0x06000411 RID: 1041 RVA: 0x0000AE9B File Offset: 0x0000909B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000412 RID: 1042 RVA: 0x0000AECC File Offset: 0x000090CC
			public IAdjustableOrientationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IAdjustableOrientationInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x0000AF04 File Offset: 0x00009104
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IAdjustableOrientationInvoker.cb_annotationType == null)
				{
					JdkConstants.IAdjustableOrientationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IAdjustableOrientationInvoker.n_AnnotationType));
				}
				return JdkConstants.IAdjustableOrientationInvoker.cb_annotationType;
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x0000AF28 File Offset: 0x00009128
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IAdjustableOrientation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x0000AF3C File Offset: 0x0000913C
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x0000AF8D File Offset: 0x0000918D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IAdjustableOrientationInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IAdjustableOrientationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IAdjustableOrientationInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IAdjustableOrientationInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x0000AFB4 File Offset: 0x000091B4
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IAdjustableOrientation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x0000AFD8 File Offset: 0x000091D8
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

			// Token: 0x06000419 RID: 1049 RVA: 0x0000B04B File Offset: 0x0000924B
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IAdjustableOrientationInvoker.cb_hashCode == null)
				{
					JdkConstants.IAdjustableOrientationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IAdjustableOrientationInvoker.n_GetHashCode));
				}
				return JdkConstants.IAdjustableOrientationInvoker.cb_hashCode;
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x0000B06F File Offset: 0x0000926F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IAdjustableOrientation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000B07E File Offset: 0x0000927E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x0000B0BE File Offset: 0x000092BE
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IAdjustableOrientationInvoker.cb_toString == null)
				{
					JdkConstants.IAdjustableOrientationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IAdjustableOrientationInvoker.n_ToString));
				}
				return JdkConstants.IAdjustableOrientationInvoker.cb_toString;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0000B0E2 File Offset: 0x000092E2
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IAdjustableOrientation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0000B0F8 File Offset: 0x000092F8
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001D6 RID: 470
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$AdjustableOrientation", typeof(JdkConstants.IAdjustableOrientationInvoker));

			// Token: 0x040001D7 RID: 471
			private IntPtr class_ref;

			// Token: 0x040001D8 RID: 472
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001D9 RID: 473
			private IntPtr id_annotationType;

			// Token: 0x040001DA RID: 474
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001DB RID: 475
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001DC RID: 476
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001DD RID: 477
			private IntPtr id_hashCode;

			// Token: 0x040001DE RID: 478
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001DF RID: 479
			private IntPtr id_toString;
		}

		// Token: 0x02000079 RID: 121
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$BoxLayoutAxis", "", "IntelliJ.Lang.Annotations.JdkConstants/IBoxLayoutAxisInvoker")]
		public interface IBoxLayoutAxis : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200007A RID: 122
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$BoxLayoutAxis", DoNotGenerateAcw = true)]
		internal class IBoxLayoutAxisInvoker : Java.Lang.Object, JdkConstants.IBoxLayoutAxis, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000B164 File Offset: 0x00009364
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IBoxLayoutAxisInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000B188 File Offset: 0x00009388
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IBoxLayoutAxisInvoker._members;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000B18F File Offset: 0x0000938F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000B197 File Offset: 0x00009397
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IBoxLayoutAxisInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x0000B1A3 File Offset: 0x000093A3
			[NullableContext(2)]
			public static JdkConstants.IBoxLayoutAxis GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IBoxLayoutAxis>(handle, transfer);
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x0000B1AC File Offset: 0x000093AC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IBoxLayoutAxisInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.BoxLayoutAxis'.");
				}
				return handle;
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x0000B1D7 File Offset: 0x000093D7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x0000B208 File Offset: 0x00009408
			public IBoxLayoutAxisInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IBoxLayoutAxisInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000428 RID: 1064 RVA: 0x0000B240 File Offset: 0x00009440
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IBoxLayoutAxisInvoker.cb_annotationType == null)
				{
					JdkConstants.IBoxLayoutAxisInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IBoxLayoutAxisInvoker.n_AnnotationType));
				}
				return JdkConstants.IBoxLayoutAxisInvoker.cb_annotationType;
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x0000B264 File Offset: 0x00009464
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IBoxLayoutAxis>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0000B278 File Offset: 0x00009478
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0000B2C9 File Offset: 0x000094C9
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IBoxLayoutAxisInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IBoxLayoutAxisInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IBoxLayoutAxisInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IBoxLayoutAxisInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x0000B2F0 File Offset: 0x000094F0
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IBoxLayoutAxis>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0000B314 File Offset: 0x00009514
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

			// Token: 0x0600042E RID: 1070 RVA: 0x0000B387 File Offset: 0x00009587
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IBoxLayoutAxisInvoker.cb_hashCode == null)
				{
					JdkConstants.IBoxLayoutAxisInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IBoxLayoutAxisInvoker.n_GetHashCode));
				}
				return JdkConstants.IBoxLayoutAxisInvoker.cb_hashCode;
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x0000B3AB File Offset: 0x000095AB
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IBoxLayoutAxis>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x0000B3BA File Offset: 0x000095BA
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x0000B3FA File Offset: 0x000095FA
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IBoxLayoutAxisInvoker.cb_toString == null)
				{
					JdkConstants.IBoxLayoutAxisInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IBoxLayoutAxisInvoker.n_ToString));
				}
				return JdkConstants.IBoxLayoutAxisInvoker.cb_toString;
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x0000B41E File Offset: 0x0000961E
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IBoxLayoutAxis>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0000B434 File Offset: 0x00009634
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001E0 RID: 480
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$BoxLayoutAxis", typeof(JdkConstants.IBoxLayoutAxisInvoker));

			// Token: 0x040001E1 RID: 481
			private IntPtr class_ref;

			// Token: 0x040001E2 RID: 482
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001E3 RID: 483
			private IntPtr id_annotationType;

			// Token: 0x040001E4 RID: 484
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001E5 RID: 485
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001E6 RID: 486
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001E7 RID: 487
			private IntPtr id_hashCode;

			// Token: 0x040001E8 RID: 488
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001E9 RID: 489
			private IntPtr id_toString;
		}

		// Token: 0x0200007B RID: 123
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$CalendarMonth", "", "IntelliJ.Lang.Annotations.JdkConstants/ICalendarMonthInvoker")]
		public interface ICalendarMonth : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200007C RID: 124
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$CalendarMonth", DoNotGenerateAcw = true)]
		internal class ICalendarMonthInvoker : Java.Lang.Object, JdkConstants.ICalendarMonth, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000B4A0 File Offset: 0x000096A0
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ICalendarMonthInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000B4C4 File Offset: 0x000096C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ICalendarMonthInvoker._members;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x0000B4CB File Offset: 0x000096CB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000B4D3 File Offset: 0x000096D3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ICalendarMonthInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x0000B4DF File Offset: 0x000096DF
			[NullableContext(2)]
			public static JdkConstants.ICalendarMonth GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ICalendarMonth>(handle, transfer);
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0000B4E8 File Offset: 0x000096E8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ICalendarMonthInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.CalendarMonth'.");
				}
				return handle;
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x0000B513 File Offset: 0x00009713
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x0000B544 File Offset: 0x00009744
			public ICalendarMonthInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ICalendarMonthInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0000B57C File Offset: 0x0000977C
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ICalendarMonthInvoker.cb_annotationType == null)
				{
					JdkConstants.ICalendarMonthInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ICalendarMonthInvoker.n_AnnotationType));
				}
				return JdkConstants.ICalendarMonthInvoker.cb_annotationType;
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0000B5A0 File Offset: 0x000097A0
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ICalendarMonth>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x0000B5B4 File Offset: 0x000097B4
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x0000B605 File Offset: 0x00009805
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ICalendarMonthInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ICalendarMonthInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ICalendarMonthInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ICalendarMonthInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x0000B62C File Offset: 0x0000982C
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ICalendarMonth>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x0000B650 File Offset: 0x00009850
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

			// Token: 0x06000443 RID: 1091 RVA: 0x0000B6C3 File Offset: 0x000098C3
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ICalendarMonthInvoker.cb_hashCode == null)
				{
					JdkConstants.ICalendarMonthInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ICalendarMonthInvoker.n_GetHashCode));
				}
				return JdkConstants.ICalendarMonthInvoker.cb_hashCode;
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x0000B6E7 File Offset: 0x000098E7
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ICalendarMonth>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x0000B6F6 File Offset: 0x000098F6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x0000B736 File Offset: 0x00009936
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ICalendarMonthInvoker.cb_toString == null)
				{
					JdkConstants.ICalendarMonthInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ICalendarMonthInvoker.n_ToString));
				}
				return JdkConstants.ICalendarMonthInvoker.cb_toString;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x0000B75A File Offset: 0x0000995A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ICalendarMonth>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x0000B770 File Offset: 0x00009970
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001EA RID: 490
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$CalendarMonth", typeof(JdkConstants.ICalendarMonthInvoker));

			// Token: 0x040001EB RID: 491
			private IntPtr class_ref;

			// Token: 0x040001EC RID: 492
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001ED RID: 493
			private IntPtr id_annotationType;

			// Token: 0x040001EE RID: 494
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001EF RID: 495
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001F0 RID: 496
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001F1 RID: 497
			private IntPtr id_hashCode;

			// Token: 0x040001F2 RID: 498
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001F3 RID: 499
			private IntPtr id_toString;
		}

		// Token: 0x0200007D RID: 125
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$CursorType", "", "IntelliJ.Lang.Annotations.JdkConstants/ICursorTypeInvoker")]
		public interface ICursorType : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200007E RID: 126
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$CursorType", DoNotGenerateAcw = true)]
		internal class ICursorTypeInvoker : Java.Lang.Object, JdkConstants.ICursorType, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000CE RID: 206
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000B7DC File Offset: 0x000099DC
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ICursorTypeInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000B800 File Offset: 0x00009A00
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ICursorTypeInvoker._members;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000B807 File Offset: 0x00009A07
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000B80F File Offset: 0x00009A0F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ICursorTypeInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x0000B81B File Offset: 0x00009A1B
			[NullableContext(2)]
			public static JdkConstants.ICursorType GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ICursorType>(handle, transfer);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x0000B824 File Offset: 0x00009A24
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ICursorTypeInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.CursorType'.");
				}
				return handle;
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x0000B84F File Offset: 0x00009A4F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x0000B880 File Offset: 0x00009A80
			public ICursorTypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ICursorTypeInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x0000B8B8 File Offset: 0x00009AB8
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ICursorTypeInvoker.cb_annotationType == null)
				{
					JdkConstants.ICursorTypeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ICursorTypeInvoker.n_AnnotationType));
				}
				return JdkConstants.ICursorTypeInvoker.cb_annotationType;
			}

			// Token: 0x06000453 RID: 1107 RVA: 0x0000B8DC File Offset: 0x00009ADC
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ICursorType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000454 RID: 1108 RVA: 0x0000B8F0 File Offset: 0x00009AF0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000455 RID: 1109 RVA: 0x0000B941 File Offset: 0x00009B41
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ICursorTypeInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ICursorTypeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ICursorTypeInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ICursorTypeInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x0000B968 File Offset: 0x00009B68
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ICursorType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x0000B98C File Offset: 0x00009B8C
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

			// Token: 0x06000458 RID: 1112 RVA: 0x0000B9FF File Offset: 0x00009BFF
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ICursorTypeInvoker.cb_hashCode == null)
				{
					JdkConstants.ICursorTypeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ICursorTypeInvoker.n_GetHashCode));
				}
				return JdkConstants.ICursorTypeInvoker.cb_hashCode;
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x0000BA23 File Offset: 0x00009C23
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ICursorType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x0000BA32 File Offset: 0x00009C32
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x0000BA72 File Offset: 0x00009C72
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ICursorTypeInvoker.cb_toString == null)
				{
					JdkConstants.ICursorTypeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ICursorTypeInvoker.n_ToString));
				}
				return JdkConstants.ICursorTypeInvoker.cb_toString;
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x0000BA96 File Offset: 0x00009C96
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ICursorType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0000BAAC File Offset: 0x00009CAC
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001F4 RID: 500
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$CursorType", typeof(JdkConstants.ICursorTypeInvoker));

			// Token: 0x040001F5 RID: 501
			private IntPtr class_ref;

			// Token: 0x040001F6 RID: 502
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001F7 RID: 503
			private IntPtr id_annotationType;

			// Token: 0x040001F8 RID: 504
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001F9 RID: 505
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001FA RID: 506
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001FB RID: 507
			private IntPtr id_hashCode;

			// Token: 0x040001FC RID: 508
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001FD RID: 509
			private IntPtr id_toString;
		}

		// Token: 0x0200007F RID: 127
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$FlowLayoutAlignment", "", "IntelliJ.Lang.Annotations.JdkConstants/IFlowLayoutAlignmentInvoker")]
		public interface IFlowLayoutAlignment : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000080 RID: 128
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$FlowLayoutAlignment", DoNotGenerateAcw = true)]
		internal class IFlowLayoutAlignmentInvoker : Java.Lang.Object, JdkConstants.IFlowLayoutAlignment, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000BB18 File Offset: 0x00009D18
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IFlowLayoutAlignmentInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000BB3C File Offset: 0x00009D3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IFlowLayoutAlignmentInvoker._members;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000BB43 File Offset: 0x00009D43
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000BB4B File Offset: 0x00009D4B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IFlowLayoutAlignmentInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000463 RID: 1123 RVA: 0x0000BB57 File Offset: 0x00009D57
			[NullableContext(2)]
			public static JdkConstants.IFlowLayoutAlignment GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IFlowLayoutAlignment>(handle, transfer);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x0000BB60 File Offset: 0x00009D60
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IFlowLayoutAlignmentInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.FlowLayoutAlignment'.");
				}
				return handle;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x0000BB8B File Offset: 0x00009D8B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x0000BBBC File Offset: 0x00009DBC
			public IFlowLayoutAlignmentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IFlowLayoutAlignmentInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x0000BBF4 File Offset: 0x00009DF4
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IFlowLayoutAlignmentInvoker.cb_annotationType == null)
				{
					JdkConstants.IFlowLayoutAlignmentInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IFlowLayoutAlignmentInvoker.n_AnnotationType));
				}
				return JdkConstants.IFlowLayoutAlignmentInvoker.cb_annotationType;
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x0000BC18 File Offset: 0x00009E18
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IFlowLayoutAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x0000BC2C File Offset: 0x00009E2C
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x0000BC7D File Offset: 0x00009E7D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IFlowLayoutAlignmentInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IFlowLayoutAlignmentInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IFlowLayoutAlignmentInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IFlowLayoutAlignmentInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x0000BCA4 File Offset: 0x00009EA4
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IFlowLayoutAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x0000BCC8 File Offset: 0x00009EC8
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

			// Token: 0x0600046D RID: 1133 RVA: 0x0000BD3B File Offset: 0x00009F3B
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IFlowLayoutAlignmentInvoker.cb_hashCode == null)
				{
					JdkConstants.IFlowLayoutAlignmentInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IFlowLayoutAlignmentInvoker.n_GetHashCode));
				}
				return JdkConstants.IFlowLayoutAlignmentInvoker.cb_hashCode;
			}

			// Token: 0x0600046E RID: 1134 RVA: 0x0000BD5F File Offset: 0x00009F5F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IFlowLayoutAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x0000BD6E File Offset: 0x00009F6E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x0000BDAE File Offset: 0x00009FAE
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IFlowLayoutAlignmentInvoker.cb_toString == null)
				{
					JdkConstants.IFlowLayoutAlignmentInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IFlowLayoutAlignmentInvoker.n_ToString));
				}
				return JdkConstants.IFlowLayoutAlignmentInvoker.cb_toString;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x0000BDD2 File Offset: 0x00009FD2
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IFlowLayoutAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x0000BDE8 File Offset: 0x00009FE8
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001FE RID: 510
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$FlowLayoutAlignment", typeof(JdkConstants.IFlowLayoutAlignmentInvoker));

			// Token: 0x040001FF RID: 511
			private IntPtr class_ref;

			// Token: 0x04000200 RID: 512
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000201 RID: 513
			private IntPtr id_annotationType;

			// Token: 0x04000202 RID: 514
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000203 RID: 515
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000204 RID: 516
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000205 RID: 517
			private IntPtr id_hashCode;

			// Token: 0x04000206 RID: 518
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000207 RID: 519
			private IntPtr id_toString;
		}

		// Token: 0x02000081 RID: 129
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$FontStyle", "", "IntelliJ.Lang.Annotations.JdkConstants/IFontStyleInvoker")]
		public interface IFontStyle : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000082 RID: 130
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$FontStyle", DoNotGenerateAcw = true)]
		internal class IFontStyleInvoker : Java.Lang.Object, JdkConstants.IFontStyle, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000BE54 File Offset: 0x0000A054
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IFontStyleInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000BE78 File Offset: 0x0000A078
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IFontStyleInvoker._members;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000BE7F File Offset: 0x0000A07F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000BE87 File Offset: 0x0000A087
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IFontStyleInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x0000BE93 File Offset: 0x0000A093
			[NullableContext(2)]
			public static JdkConstants.IFontStyle GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IFontStyle>(handle, transfer);
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x0000BE9C File Offset: 0x0000A09C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IFontStyleInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.FontStyle'.");
				}
				return handle;
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x0000BEC7 File Offset: 0x0000A0C7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
			public IFontStyleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IFontStyleInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x0000BF30 File Offset: 0x0000A130
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IFontStyleInvoker.cb_annotationType == null)
				{
					JdkConstants.IFontStyleInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IFontStyleInvoker.n_AnnotationType));
				}
				return JdkConstants.IFontStyleInvoker.cb_annotationType;
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x0000BF54 File Offset: 0x0000A154
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IFontStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x0000BF68 File Offset: 0x0000A168
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x0000BFB9 File Offset: 0x0000A1B9
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IFontStyleInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IFontStyleInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IFontStyleInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IFontStyleInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IFontStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x0000C004 File Offset: 0x0000A204
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

			// Token: 0x06000482 RID: 1154 RVA: 0x0000C077 File Offset: 0x0000A277
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IFontStyleInvoker.cb_hashCode == null)
				{
					JdkConstants.IFontStyleInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IFontStyleInvoker.n_GetHashCode));
				}
				return JdkConstants.IFontStyleInvoker.cb_hashCode;
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x0000C09B File Offset: 0x0000A29B
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IFontStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x0000C0AA File Offset: 0x0000A2AA
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x0000C0EA File Offset: 0x0000A2EA
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IFontStyleInvoker.cb_toString == null)
				{
					JdkConstants.IFontStyleInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IFontStyleInvoker.n_ToString));
				}
				return JdkConstants.IFontStyleInvoker.cb_toString;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x0000C10E File Offset: 0x0000A30E
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IFontStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x0000C124 File Offset: 0x0000A324
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000208 RID: 520
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$FontStyle", typeof(JdkConstants.IFontStyleInvoker));

			// Token: 0x04000209 RID: 521
			private IntPtr class_ref;

			// Token: 0x0400020A RID: 522
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400020B RID: 523
			private IntPtr id_annotationType;

			// Token: 0x0400020C RID: 524
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400020D RID: 525
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400020E RID: 526
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400020F RID: 527
			private IntPtr id_hashCode;

			// Token: 0x04000210 RID: 528
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000211 RID: 529
			private IntPtr id_toString;
		}

		// Token: 0x02000083 RID: 131
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$HorizontalAlignment", "", "IntelliJ.Lang.Annotations.JdkConstants/IHorizontalAlignmentInvoker")]
		public interface IHorizontalAlignment : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000084 RID: 132
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$HorizontalAlignment", DoNotGenerateAcw = true)]
		internal class IHorizontalAlignmentInvoker : Java.Lang.Object, JdkConstants.IHorizontalAlignment, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000DA RID: 218
			// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000C190 File Offset: 0x0000A390
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IHorizontalAlignmentInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IHorizontalAlignmentInvoker._members;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000C1BB File Offset: 0x0000A3BB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000C1C3 File Offset: 0x0000A3C3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IHorizontalAlignmentInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x0000C1CF File Offset: 0x0000A3CF
			[NullableContext(2)]
			public static JdkConstants.IHorizontalAlignment GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IHorizontalAlignment>(handle, transfer);
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IHorizontalAlignmentInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.HorizontalAlignment'.");
				}
				return handle;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0000C203 File Offset: 0x0000A403
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x0000C234 File Offset: 0x0000A434
			public IHorizontalAlignmentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IHorizontalAlignmentInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x0000C26C File Offset: 0x0000A46C
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IHorizontalAlignmentInvoker.cb_annotationType == null)
				{
					JdkConstants.IHorizontalAlignmentInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IHorizontalAlignmentInvoker.n_AnnotationType));
				}
				return JdkConstants.IHorizontalAlignmentInvoker.cb_annotationType;
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x0000C290 File Offset: 0x0000A490
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IHorizontalAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x0000C2F5 File Offset: 0x0000A4F5
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IHorizontalAlignmentInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IHorizontalAlignmentInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IHorizontalAlignmentInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IHorizontalAlignmentInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x0000C31C File Offset: 0x0000A51C
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IHorizontalAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x0000C340 File Offset: 0x0000A540
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

			// Token: 0x06000497 RID: 1175 RVA: 0x0000C3B3 File Offset: 0x0000A5B3
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IHorizontalAlignmentInvoker.cb_hashCode == null)
				{
					JdkConstants.IHorizontalAlignmentInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IHorizontalAlignmentInvoker.n_GetHashCode));
				}
				return JdkConstants.IHorizontalAlignmentInvoker.cb_hashCode;
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x0000C3D7 File Offset: 0x0000A5D7
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IHorizontalAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x0000C426 File Offset: 0x0000A626
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IHorizontalAlignmentInvoker.cb_toString == null)
				{
					JdkConstants.IHorizontalAlignmentInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IHorizontalAlignmentInvoker.n_ToString));
				}
				return JdkConstants.IHorizontalAlignmentInvoker.cb_toString;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0000C44A File Offset: 0x0000A64A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IHorizontalAlignment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x0000C460 File Offset: 0x0000A660
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000212 RID: 530
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$HorizontalAlignment", typeof(JdkConstants.IHorizontalAlignmentInvoker));

			// Token: 0x04000213 RID: 531
			private IntPtr class_ref;

			// Token: 0x04000214 RID: 532
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000215 RID: 533
			private IntPtr id_annotationType;

			// Token: 0x04000216 RID: 534
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000217 RID: 535
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000218 RID: 536
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000219 RID: 537
			private IntPtr id_hashCode;

			// Token: 0x0400021A RID: 538
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400021B RID: 539
			private IntPtr id_toString;
		}

		// Token: 0x02000085 RID: 133
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$HorizontalScrollBarPolicy", "", "IntelliJ.Lang.Annotations.JdkConstants/IHorizontalScrollBarPolicyInvoker")]
		public interface IHorizontalScrollBarPolicy : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000086 RID: 134
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$HorizontalScrollBarPolicy", DoNotGenerateAcw = true)]
		internal class IHorizontalScrollBarPolicyInvoker : Java.Lang.Object, JdkConstants.IHorizontalScrollBarPolicy, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000DE RID: 222
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x0000C4CC File Offset: 0x0000A6CC
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IHorizontalScrollBarPolicyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IHorizontalScrollBarPolicyInvoker._members;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000C4F7 File Offset: 0x0000A6F7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000C4FF File Offset: 0x0000A6FF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IHorizontalScrollBarPolicyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x0000C50B File Offset: 0x0000A70B
			[NullableContext(2)]
			public static JdkConstants.IHorizontalScrollBarPolicy GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IHorizontalScrollBarPolicy>(handle, transfer);
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x0000C514 File Offset: 0x0000A714
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IHorizontalScrollBarPolicyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.HorizontalScrollBarPolicy'.");
				}
				return handle;
			}

			// Token: 0x060004A4 RID: 1188 RVA: 0x0000C53F File Offset: 0x0000A73F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x0000C570 File Offset: 0x0000A770
			public IHorizontalScrollBarPolicyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IHorizontalScrollBarPolicyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_annotationType == null)
				{
					JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IHorizontalScrollBarPolicyInvoker.n_AnnotationType));
				}
				return JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_annotationType;
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x0000C5CC File Offset: 0x0000A7CC
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IHorizontalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x0000C631 File Offset: 0x0000A831
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IHorizontalScrollBarPolicyInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x0000C658 File Offset: 0x0000A858
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IHorizontalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x0000C67C File Offset: 0x0000A87C
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

			// Token: 0x060004AC RID: 1196 RVA: 0x0000C6EF File Offset: 0x0000A8EF
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_hashCode == null)
				{
					JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IHorizontalScrollBarPolicyInvoker.n_GetHashCode));
				}
				return JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_hashCode;
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x0000C713 File Offset: 0x0000A913
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IHorizontalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x0000C722 File Offset: 0x0000A922
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x0000C762 File Offset: 0x0000A962
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_toString == null)
				{
					JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IHorizontalScrollBarPolicyInvoker.n_ToString));
				}
				return JdkConstants.IHorizontalScrollBarPolicyInvoker.cb_toString;
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x0000C786 File Offset: 0x0000A986
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IHorizontalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x0000C79C File Offset: 0x0000A99C
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400021C RID: 540
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$HorizontalScrollBarPolicy", typeof(JdkConstants.IHorizontalScrollBarPolicyInvoker));

			// Token: 0x0400021D RID: 541
			private IntPtr class_ref;

			// Token: 0x0400021E RID: 542
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400021F RID: 543
			private IntPtr id_annotationType;

			// Token: 0x04000220 RID: 544
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000221 RID: 545
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000222 RID: 546
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000223 RID: 547
			private IntPtr id_hashCode;

			// Token: 0x04000224 RID: 548
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000225 RID: 549
			private IntPtr id_toString;
		}

		// Token: 0x02000087 RID: 135
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$InputEventMask", "", "IntelliJ.Lang.Annotations.JdkConstants/IInputEventMaskInvoker")]
		public interface IInputEventMask : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000088 RID: 136
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$InputEventMask", DoNotGenerateAcw = true)]
		internal class IInputEventMaskInvoker : Java.Lang.Object, JdkConstants.IInputEventMask, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000C808 File Offset: 0x0000AA08
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IInputEventMaskInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0000C82C File Offset: 0x0000AA2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IInputEventMaskInvoker._members;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000C833 File Offset: 0x0000AA33
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0000C83B File Offset: 0x0000AA3B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IInputEventMaskInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x0000C847 File Offset: 0x0000AA47
			[NullableContext(2)]
			public static JdkConstants.IInputEventMask GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IInputEventMask>(handle, transfer);
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0000C850 File Offset: 0x0000AA50
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IInputEventMaskInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.InputEventMask'.");
				}
				return handle;
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x0000C87B File Offset: 0x0000AA7B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x0000C8AC File Offset: 0x0000AAAC
			public IInputEventMaskInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IInputEventMaskInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IInputEventMaskInvoker.cb_annotationType == null)
				{
					JdkConstants.IInputEventMaskInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IInputEventMaskInvoker.n_AnnotationType));
				}
				return JdkConstants.IInputEventMaskInvoker.cb_annotationType;
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x0000C908 File Offset: 0x0000AB08
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IInputEventMask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x0000C91C File Offset: 0x0000AB1C
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x0000C96D File Offset: 0x0000AB6D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IInputEventMaskInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IInputEventMaskInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IInputEventMaskInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IInputEventMaskInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x0000C994 File Offset: 0x0000AB94
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IInputEventMask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
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

			// Token: 0x060004C1 RID: 1217 RVA: 0x0000CA2B File Offset: 0x0000AC2B
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IInputEventMaskInvoker.cb_hashCode == null)
				{
					JdkConstants.IInputEventMaskInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IInputEventMaskInvoker.n_GetHashCode));
				}
				return JdkConstants.IInputEventMaskInvoker.cb_hashCode;
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x0000CA4F File Offset: 0x0000AC4F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IInputEventMask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x0000CA5E File Offset: 0x0000AC5E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x0000CA9E File Offset: 0x0000AC9E
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IInputEventMaskInvoker.cb_toString == null)
				{
					JdkConstants.IInputEventMaskInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IInputEventMaskInvoker.n_ToString));
				}
				return JdkConstants.IInputEventMaskInvoker.cb_toString;
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x0000CAC2 File Offset: 0x0000ACC2
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IInputEventMask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000226 RID: 550
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$InputEventMask", typeof(JdkConstants.IInputEventMaskInvoker));

			// Token: 0x04000227 RID: 551
			private IntPtr class_ref;

			// Token: 0x04000228 RID: 552
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000229 RID: 553
			private IntPtr id_annotationType;

			// Token: 0x0400022A RID: 554
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400022B RID: 555
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400022C RID: 556
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400022D RID: 557
			private IntPtr id_hashCode;

			// Token: 0x0400022E RID: 558
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400022F RID: 559
			private IntPtr id_toString;
		}

		// Token: 0x02000089 RID: 137
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$ListSelectionMode", "", "IntelliJ.Lang.Annotations.JdkConstants/IListSelectionModeInvoker")]
		public interface IListSelectionMode : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200008A RID: 138
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$ListSelectionMode", DoNotGenerateAcw = true)]
		internal class IListSelectionModeInvoker : Java.Lang.Object, JdkConstants.IListSelectionMode, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000CB44 File Offset: 0x0000AD44
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IListSelectionModeInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0000CB68 File Offset: 0x0000AD68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IListSelectionModeInvoker._members;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060004CA RID: 1226 RVA: 0x0000CB6F File Offset: 0x0000AD6F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060004CB RID: 1227 RVA: 0x0000CB77 File Offset: 0x0000AD77
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IListSelectionModeInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x0000CB83 File Offset: 0x0000AD83
			[NullableContext(2)]
			public static JdkConstants.IListSelectionMode GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IListSelectionMode>(handle, transfer);
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x0000CB8C File Offset: 0x0000AD8C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IListSelectionModeInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.ListSelectionMode'.");
				}
				return handle;
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x0000CBB7 File Offset: 0x0000ADB7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
			public IListSelectionModeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IListSelectionModeInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x0000CC20 File Offset: 0x0000AE20
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IListSelectionModeInvoker.cb_annotationType == null)
				{
					JdkConstants.IListSelectionModeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IListSelectionModeInvoker.n_AnnotationType));
				}
				return JdkConstants.IListSelectionModeInvoker.cb_annotationType;
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x0000CC44 File Offset: 0x0000AE44
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IListSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x0000CC58 File Offset: 0x0000AE58
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x0000CCA9 File Offset: 0x0000AEA9
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IListSelectionModeInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IListSelectionModeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IListSelectionModeInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IListSelectionModeInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x0000CCD0 File Offset: 0x0000AED0
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IListSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x0000CCF4 File Offset: 0x0000AEF4
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

			// Token: 0x060004D6 RID: 1238 RVA: 0x0000CD67 File Offset: 0x0000AF67
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IListSelectionModeInvoker.cb_hashCode == null)
				{
					JdkConstants.IListSelectionModeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IListSelectionModeInvoker.n_GetHashCode));
				}
				return JdkConstants.IListSelectionModeInvoker.cb_hashCode;
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x0000CD8B File Offset: 0x0000AF8B
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IListSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x0000CD9A File Offset: 0x0000AF9A
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x0000CDDA File Offset: 0x0000AFDA
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IListSelectionModeInvoker.cb_toString == null)
				{
					JdkConstants.IListSelectionModeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IListSelectionModeInvoker.n_ToString));
				}
				return JdkConstants.IListSelectionModeInvoker.cb_toString;
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x0000CDFE File Offset: 0x0000AFFE
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IListSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x0000CE14 File Offset: 0x0000B014
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000230 RID: 560
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$ListSelectionMode", typeof(JdkConstants.IListSelectionModeInvoker));

			// Token: 0x04000231 RID: 561
			private IntPtr class_ref;

			// Token: 0x04000232 RID: 562
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000233 RID: 563
			private IntPtr id_annotationType;

			// Token: 0x04000234 RID: 564
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000235 RID: 565
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000236 RID: 566
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000237 RID: 567
			private IntPtr id_hashCode;

			// Token: 0x04000238 RID: 568
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000239 RID: 569
			private IntPtr id_toString;
		}

		// Token: 0x0200008B RID: 139
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$PatternFlags", "", "IntelliJ.Lang.Annotations.JdkConstants/IPatternFlagsInvoker")]
		public interface IPatternFlags : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200008C RID: 140
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$PatternFlags", DoNotGenerateAcw = true)]
		internal class IPatternFlagsInvoker : Java.Lang.Object, JdkConstants.IPatternFlags, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000CE80 File Offset: 0x0000B080
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IPatternFlagsInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IPatternFlagsInvoker._members;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0000CEAB File Offset: 0x0000B0AB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IPatternFlagsInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x0000CEBF File Offset: 0x0000B0BF
			[NullableContext(2)]
			public static JdkConstants.IPatternFlags GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IPatternFlags>(handle, transfer);
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IPatternFlagsInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.PatternFlags'.");
				}
				return handle;
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x0000CEF3 File Offset: 0x0000B0F3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x0000CF24 File Offset: 0x0000B124
			public IPatternFlagsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IPatternFlagsInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x0000CF5C File Offset: 0x0000B15C
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IPatternFlagsInvoker.cb_annotationType == null)
				{
					JdkConstants.IPatternFlagsInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IPatternFlagsInvoker.n_AnnotationType));
				}
				return JdkConstants.IPatternFlagsInvoker.cb_annotationType;
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0000CF80 File Offset: 0x0000B180
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IPatternFlags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x0000CF94 File Offset: 0x0000B194
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IPatternFlagsInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IPatternFlagsInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IPatternFlagsInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IPatternFlagsInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0000D00C File Offset: 0x0000B20C
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IPatternFlags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x0000D030 File Offset: 0x0000B230
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

			// Token: 0x060004EB RID: 1259 RVA: 0x0000D0A3 File Offset: 0x0000B2A3
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IPatternFlagsInvoker.cb_hashCode == null)
				{
					JdkConstants.IPatternFlagsInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IPatternFlagsInvoker.n_GetHashCode));
				}
				return JdkConstants.IPatternFlagsInvoker.cb_hashCode;
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0000D0C7 File Offset: 0x0000B2C7
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IPatternFlags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0000D0D6 File Offset: 0x0000B2D6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x0000D116 File Offset: 0x0000B316
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IPatternFlagsInvoker.cb_toString == null)
				{
					JdkConstants.IPatternFlagsInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IPatternFlagsInvoker.n_ToString));
				}
				return JdkConstants.IPatternFlagsInvoker.cb_toString;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x0000D13A File Offset: 0x0000B33A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IPatternFlags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x0000D150 File Offset: 0x0000B350
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400023A RID: 570
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$PatternFlags", typeof(JdkConstants.IPatternFlagsInvoker));

			// Token: 0x0400023B RID: 571
			private IntPtr class_ref;

			// Token: 0x0400023C RID: 572
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400023D RID: 573
			private IntPtr id_annotationType;

			// Token: 0x0400023E RID: 574
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400023F RID: 575
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000240 RID: 576
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000241 RID: 577
			private IntPtr id_hashCode;

			// Token: 0x04000242 RID: 578
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000243 RID: 579
			private IntPtr id_toString;
		}

		// Token: 0x0200008D RID: 141
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TabLayoutPolicy", "", "IntelliJ.Lang.Annotations.JdkConstants/ITabLayoutPolicyInvoker")]
		public interface ITabLayoutPolicy : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200008E RID: 142
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TabLayoutPolicy", DoNotGenerateAcw = true)]
		internal class ITabLayoutPolicyInvoker : Java.Lang.Object, JdkConstants.ITabLayoutPolicy, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000D1BC File Offset: 0x0000B3BC
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ITabLayoutPolicyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ITabLayoutPolicyInvoker._members;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0000D1E7 File Offset: 0x0000B3E7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000D1EF File Offset: 0x0000B3EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ITabLayoutPolicyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x0000D1FB File Offset: 0x0000B3FB
			[NullableContext(2)]
			public static JdkConstants.ITabLayoutPolicy GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITabLayoutPolicy>(handle, transfer);
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0000D204 File Offset: 0x0000B404
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ITabLayoutPolicyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.TabLayoutPolicy'.");
				}
				return handle;
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x0000D22F File Offset: 0x0000B42F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x0000D260 File Offset: 0x0000B460
			public ITabLayoutPolicyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ITabLayoutPolicyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x0000D298 File Offset: 0x0000B498
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ITabLayoutPolicyInvoker.cb_annotationType == null)
				{
					JdkConstants.ITabLayoutPolicyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITabLayoutPolicyInvoker.n_AnnotationType));
				}
				return JdkConstants.ITabLayoutPolicyInvoker.cb_annotationType;
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x0000D2BC File Offset: 0x0000B4BC
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ITabLayoutPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x0000D321 File Offset: 0x0000B521
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ITabLayoutPolicyInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ITabLayoutPolicyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ITabLayoutPolicyInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ITabLayoutPolicyInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x0000D348 File Offset: 0x0000B548
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ITabLayoutPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x0000D36C File Offset: 0x0000B56C
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

			// Token: 0x06000500 RID: 1280 RVA: 0x0000D3DF File Offset: 0x0000B5DF
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ITabLayoutPolicyInvoker.cb_hashCode == null)
				{
					JdkConstants.ITabLayoutPolicyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ITabLayoutPolicyInvoker.n_GetHashCode));
				}
				return JdkConstants.ITabLayoutPolicyInvoker.cb_hashCode;
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0000D403 File Offset: 0x0000B603
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITabLayoutPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0000D412 File Offset: 0x0000B612
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x0000D452 File Offset: 0x0000B652
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ITabLayoutPolicyInvoker.cb_toString == null)
				{
					JdkConstants.ITabLayoutPolicyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITabLayoutPolicyInvoker.n_ToString));
				}
				return JdkConstants.ITabLayoutPolicyInvoker.cb_toString;
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x0000D476 File Offset: 0x0000B676
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ITabLayoutPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0000D48C File Offset: 0x0000B68C
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000244 RID: 580
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$TabLayoutPolicy", typeof(JdkConstants.ITabLayoutPolicyInvoker));

			// Token: 0x04000245 RID: 581
			private IntPtr class_ref;

			// Token: 0x04000246 RID: 582
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000247 RID: 583
			private IntPtr id_annotationType;

			// Token: 0x04000248 RID: 584
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000249 RID: 585
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400024A RID: 586
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400024B RID: 587
			private IntPtr id_hashCode;

			// Token: 0x0400024C RID: 588
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400024D RID: 589
			private IntPtr id_toString;
		}

		// Token: 0x0200008F RID: 143
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TabPlacement", "", "IntelliJ.Lang.Annotations.JdkConstants/ITabPlacementInvoker")]
		public interface ITabPlacement : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000090 RID: 144
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TabPlacement", DoNotGenerateAcw = true)]
		internal class ITabPlacementInvoker : Java.Lang.Object, JdkConstants.ITabPlacement, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ITabPlacementInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000D51C File Offset: 0x0000B71C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ITabPlacementInvoker._members;
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000D523 File Offset: 0x0000B723
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000D52B File Offset: 0x0000B72B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ITabPlacementInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x0000D537 File Offset: 0x0000B737
			[NullableContext(2)]
			public static JdkConstants.ITabPlacement GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITabPlacement>(handle, transfer);
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x0000D540 File Offset: 0x0000B740
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ITabPlacementInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.TabPlacement'.");
				}
				return handle;
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x0000D56B File Offset: 0x0000B76B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x0000D59C File Offset: 0x0000B79C
			public ITabPlacementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ITabPlacementInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ITabPlacementInvoker.cb_annotationType == null)
				{
					JdkConstants.ITabPlacementInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITabPlacementInvoker.n_AnnotationType));
				}
				return JdkConstants.ITabPlacementInvoker.cb_annotationType;
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ITabPlacement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x0000D60C File Offset: 0x0000B80C
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x0000D65D File Offset: 0x0000B85D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ITabPlacementInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ITabPlacementInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ITabPlacementInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ITabPlacementInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x0000D684 File Offset: 0x0000B884
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ITabPlacement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
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

			// Token: 0x06000515 RID: 1301 RVA: 0x0000D71B File Offset: 0x0000B91B
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ITabPlacementInvoker.cb_hashCode == null)
				{
					JdkConstants.ITabPlacementInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ITabPlacementInvoker.n_GetHashCode));
				}
				return JdkConstants.ITabPlacementInvoker.cb_hashCode;
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x0000D73F File Offset: 0x0000B93F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITabPlacement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x0000D74E File Offset: 0x0000B94E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x0000D78E File Offset: 0x0000B98E
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ITabPlacementInvoker.cb_toString == null)
				{
					JdkConstants.ITabPlacementInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITabPlacementInvoker.n_ToString));
				}
				return JdkConstants.ITabPlacementInvoker.cb_toString;
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x0000D7B2 File Offset: 0x0000B9B2
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ITabPlacement>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400024E RID: 590
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$TabPlacement", typeof(JdkConstants.ITabPlacementInvoker));

			// Token: 0x0400024F RID: 591
			private IntPtr class_ref;

			// Token: 0x04000250 RID: 592
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000251 RID: 593
			private IntPtr id_annotationType;

			// Token: 0x04000252 RID: 594
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000253 RID: 595
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000254 RID: 596
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000255 RID: 597
			private IntPtr id_hashCode;

			// Token: 0x04000256 RID: 598
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000257 RID: 599
			private IntPtr id_toString;
		}

		// Token: 0x02000091 RID: 145
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TitledBorderJustification", "", "IntelliJ.Lang.Annotations.JdkConstants/ITitledBorderJustificationInvoker")]
		public interface ITitledBorderJustification : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000092 RID: 146
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TitledBorderJustification", DoNotGenerateAcw = true)]
		internal class ITitledBorderJustificationInvoker : Java.Lang.Object, JdkConstants.ITitledBorderJustification, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000D834 File Offset: 0x0000BA34
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ITitledBorderJustificationInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x0600051D RID: 1309 RVA: 0x0000D858 File Offset: 0x0000BA58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ITitledBorderJustificationInvoker._members;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000D85F File Offset: 0x0000BA5F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600051F RID: 1311 RVA: 0x0000D867 File Offset: 0x0000BA67
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ITitledBorderJustificationInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x0000D873 File Offset: 0x0000BA73
			[NullableContext(2)]
			public static JdkConstants.ITitledBorderJustification GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITitledBorderJustification>(handle, transfer);
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x0000D87C File Offset: 0x0000BA7C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ITitledBorderJustificationInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.TitledBorderJustification'.");
				}
				return handle;
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			public ITitledBorderJustificationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ITitledBorderJustificationInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x0000D910 File Offset: 0x0000BB10
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ITitledBorderJustificationInvoker.cb_annotationType == null)
				{
					JdkConstants.ITitledBorderJustificationInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITitledBorderJustificationInvoker.n_AnnotationType));
				}
				return JdkConstants.ITitledBorderJustificationInvoker.cb_annotationType;
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x0000D934 File Offset: 0x0000BB34
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ITitledBorderJustification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x0000D948 File Offset: 0x0000BB48
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x0000D999 File Offset: 0x0000BB99
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ITitledBorderJustificationInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ITitledBorderJustificationInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ITitledBorderJustificationInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ITitledBorderJustificationInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ITitledBorderJustification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
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

			// Token: 0x0600052A RID: 1322 RVA: 0x0000DA57 File Offset: 0x0000BC57
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ITitledBorderJustificationInvoker.cb_hashCode == null)
				{
					JdkConstants.ITitledBorderJustificationInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ITitledBorderJustificationInvoker.n_GetHashCode));
				}
				return JdkConstants.ITitledBorderJustificationInvoker.cb_hashCode;
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x0000DA7B File Offset: 0x0000BC7B
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITitledBorderJustification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x0000DA8A File Offset: 0x0000BC8A
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x0000DACA File Offset: 0x0000BCCA
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ITitledBorderJustificationInvoker.cb_toString == null)
				{
					JdkConstants.ITitledBorderJustificationInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITitledBorderJustificationInvoker.n_ToString));
				}
				return JdkConstants.ITitledBorderJustificationInvoker.cb_toString;
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x0000DAEE File Offset: 0x0000BCEE
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ITitledBorderJustification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000DB04 File Offset: 0x0000BD04
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000258 RID: 600
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$TitledBorderJustification", typeof(JdkConstants.ITitledBorderJustificationInvoker));

			// Token: 0x04000259 RID: 601
			private IntPtr class_ref;

			// Token: 0x0400025A RID: 602
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400025B RID: 603
			private IntPtr id_annotationType;

			// Token: 0x0400025C RID: 604
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400025D RID: 605
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400025E RID: 606
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400025F RID: 607
			private IntPtr id_hashCode;

			// Token: 0x04000260 RID: 608
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000261 RID: 609
			private IntPtr id_toString;
		}

		// Token: 0x02000093 RID: 147
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TitledBorderTitlePosition", "", "IntelliJ.Lang.Annotations.JdkConstants/ITitledBorderTitlePositionInvoker")]
		public interface ITitledBorderTitlePosition : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000094 RID: 148
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TitledBorderTitlePosition", DoNotGenerateAcw = true)]
		internal class ITitledBorderTitlePositionInvoker : Java.Lang.Object, JdkConstants.ITitledBorderTitlePosition, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000531 RID: 1329 RVA: 0x0000DB70 File Offset: 0x0000BD70
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ITitledBorderTitlePositionInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000DB94 File Offset: 0x0000BD94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ITitledBorderTitlePositionInvoker._members;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000533 RID: 1331 RVA: 0x0000DB9B File Offset: 0x0000BD9B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000DBA3 File Offset: 0x0000BDA3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ITitledBorderTitlePositionInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0000DBAF File Offset: 0x0000BDAF
			[NullableContext(2)]
			public static JdkConstants.ITitledBorderTitlePosition GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITitledBorderTitlePosition>(handle, transfer);
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ITitledBorderTitlePositionInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.TitledBorderTitlePosition'.");
				}
				return handle;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x0000DBE3 File Offset: 0x0000BDE3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x0000DC14 File Offset: 0x0000BE14
			public ITitledBorderTitlePositionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ITitledBorderTitlePositionInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x0000DC4C File Offset: 0x0000BE4C
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ITitledBorderTitlePositionInvoker.cb_annotationType == null)
				{
					JdkConstants.ITitledBorderTitlePositionInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITitledBorderTitlePositionInvoker.n_AnnotationType));
				}
				return JdkConstants.ITitledBorderTitlePositionInvoker.cb_annotationType;
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x0000DC70 File Offset: 0x0000BE70
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ITitledBorderTitlePosition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x0000DC84 File Offset: 0x0000BE84
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x0000DCD5 File Offset: 0x0000BED5
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ITitledBorderTitlePositionInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ITitledBorderTitlePositionInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ITitledBorderTitlePositionInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ITitledBorderTitlePositionInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x0000DCFC File Offset: 0x0000BEFC
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ITitledBorderTitlePosition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x0000DD20 File Offset: 0x0000BF20
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

			// Token: 0x0600053F RID: 1343 RVA: 0x0000DD93 File Offset: 0x0000BF93
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ITitledBorderTitlePositionInvoker.cb_hashCode == null)
				{
					JdkConstants.ITitledBorderTitlePositionInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ITitledBorderTitlePositionInvoker.n_GetHashCode));
				}
				return JdkConstants.ITitledBorderTitlePositionInvoker.cb_hashCode;
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x0000DDB7 File Offset: 0x0000BFB7
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITitledBorderTitlePosition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0000DDC6 File Offset: 0x0000BFC6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x0000DE06 File Offset: 0x0000C006
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ITitledBorderTitlePositionInvoker.cb_toString == null)
				{
					JdkConstants.ITitledBorderTitlePositionInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITitledBorderTitlePositionInvoker.n_ToString));
				}
				return JdkConstants.ITitledBorderTitlePositionInvoker.cb_toString;
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0000DE2A File Offset: 0x0000C02A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ITitledBorderTitlePosition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x0000DE40 File Offset: 0x0000C040
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000262 RID: 610
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$TitledBorderTitlePosition", typeof(JdkConstants.ITitledBorderTitlePositionInvoker));

			// Token: 0x04000263 RID: 611
			private IntPtr class_ref;

			// Token: 0x04000264 RID: 612
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000265 RID: 613
			private IntPtr id_annotationType;

			// Token: 0x04000266 RID: 614
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000267 RID: 615
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000268 RID: 616
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000269 RID: 617
			private IntPtr id_hashCode;

			// Token: 0x0400026A RID: 618
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400026B RID: 619
			private IntPtr id_toString;
		}

		// Token: 0x02000095 RID: 149
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TreeSelectionMode", "", "IntelliJ.Lang.Annotations.JdkConstants/ITreeSelectionModeInvoker")]
		public interface ITreeSelectionMode : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000096 RID: 150
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$TreeSelectionMode", DoNotGenerateAcw = true)]
		internal class ITreeSelectionModeInvoker : Java.Lang.Object, JdkConstants.ITreeSelectionMode, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x0000DEAC File Offset: 0x0000C0AC
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.ITreeSelectionModeInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000DED0 File Offset: 0x0000C0D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.ITreeSelectionModeInvoker._members;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0000DED7 File Offset: 0x0000C0D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000DEDF File Offset: 0x0000C0DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.ITreeSelectionModeInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x0000DEEB File Offset: 0x0000C0EB
			[NullableContext(2)]
			public static JdkConstants.ITreeSelectionMode GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITreeSelectionMode>(handle, transfer);
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.ITreeSelectionModeInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.TreeSelectionMode'.");
				}
				return handle;
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x0000DF1F File Offset: 0x0000C11F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0000DF50 File Offset: 0x0000C150
			public ITreeSelectionModeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.ITreeSelectionModeInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x0000DF88 File Offset: 0x0000C188
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.ITreeSelectionModeInvoker.cb_annotationType == null)
				{
					JdkConstants.ITreeSelectionModeInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITreeSelectionModeInvoker.n_AnnotationType));
				}
				return JdkConstants.ITreeSelectionModeInvoker.cb_annotationType;
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x0000DFAC File Offset: 0x0000C1AC
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.ITreeSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x0000E011 File Offset: 0x0000C211
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.ITreeSelectionModeInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.ITreeSelectionModeInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.ITreeSelectionModeInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.ITreeSelectionModeInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x0000E038 File Offset: 0x0000C238
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.ITreeSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x0000E05C File Offset: 0x0000C25C
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

			// Token: 0x06000554 RID: 1364 RVA: 0x0000E0CF File Offset: 0x0000C2CF
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.ITreeSelectionModeInvoker.cb_hashCode == null)
				{
					JdkConstants.ITreeSelectionModeInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.ITreeSelectionModeInvoker.n_GetHashCode));
				}
				return JdkConstants.ITreeSelectionModeInvoker.cb_hashCode;
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x0000E0F3 File Offset: 0x0000C2F3
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.ITreeSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0000E102 File Offset: 0x0000C302
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x0000E142 File Offset: 0x0000C342
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.ITreeSelectionModeInvoker.cb_toString == null)
				{
					JdkConstants.ITreeSelectionModeInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.ITreeSelectionModeInvoker.n_ToString));
				}
				return JdkConstants.ITreeSelectionModeInvoker.cb_toString;
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0000E166 File Offset: 0x0000C366
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.ITreeSelectionMode>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0000E17C File Offset: 0x0000C37C
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400026C RID: 620
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$TreeSelectionMode", typeof(JdkConstants.ITreeSelectionModeInvoker));

			// Token: 0x0400026D RID: 621
			private IntPtr class_ref;

			// Token: 0x0400026E RID: 622
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400026F RID: 623
			private IntPtr id_annotationType;

			// Token: 0x04000270 RID: 624
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000271 RID: 625
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000272 RID: 626
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000273 RID: 627
			private IntPtr id_hashCode;

			// Token: 0x04000274 RID: 628
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000275 RID: 629
			private IntPtr id_toString;
		}

		// Token: 0x02000097 RID: 151
		[NullableContext(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$VerticalScrollBarPolicy", "", "IntelliJ.Lang.Annotations.JdkConstants/IVerticalScrollBarPolicyInvoker")]
		public interface IVerticalScrollBarPolicy : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000098 RID: 152
		[Nullable(0)]
		[Register("org/intellij/lang/annotations/JdkConstants$VerticalScrollBarPolicy", DoNotGenerateAcw = true)]
		internal class IVerticalScrollBarPolicyInvoker : Java.Lang.Object, JdkConstants.IVerticalScrollBarPolicy, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600055B RID: 1371 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
			private static IntPtr java_class_ref
			{
				get
				{
					return JdkConstants.IVerticalScrollBarPolicyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000E20C File Offset: 0x0000C40C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JdkConstants.IVerticalScrollBarPolicyInvoker._members;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x0000E213 File Offset: 0x0000C413
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x0000E21B File Offset: 0x0000C41B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JdkConstants.IVerticalScrollBarPolicyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x0000E227 File Offset: 0x0000C427
			[NullableContext(2)]
			public static JdkConstants.IVerticalScrollBarPolicy GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IVerticalScrollBarPolicy>(handle, transfer);
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x0000E230 File Offset: 0x0000C430
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, JdkConstants.IVerticalScrollBarPolicyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.JdkConstants.VerticalScrollBarPolicy'.");
				}
				return handle;
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x0000E25B File Offset: 0x0000C45B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0000E28C File Offset: 0x0000C48C
			public IVerticalScrollBarPolicyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(JdkConstants.IVerticalScrollBarPolicyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0000E2C4 File Offset: 0x0000C4C4
			private static Delegate GetAnnotationTypeHandler()
			{
				if (JdkConstants.IVerticalScrollBarPolicyInvoker.cb_annotationType == null)
				{
					JdkConstants.IVerticalScrollBarPolicyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IVerticalScrollBarPolicyInvoker.n_AnnotationType));
				}
				return JdkConstants.IVerticalScrollBarPolicyInvoker.cb_annotationType;
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<JdkConstants.IVerticalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0000E2FC File Offset: 0x0000C4FC
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0000E34D File Offset: 0x0000C54D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (JdkConstants.IVerticalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					JdkConstants.IVerticalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JdkConstants.IVerticalScrollBarPolicyInvoker.n_Equals_Ljava_lang_Object_));
				}
				return JdkConstants.IVerticalScrollBarPolicyInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x0000E374 File Offset: 0x0000C574
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<JdkConstants.IVerticalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x0000E398 File Offset: 0x0000C598
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

			// Token: 0x06000569 RID: 1385 RVA: 0x0000E40B File Offset: 0x0000C60B
			private static Delegate GetGetHashCodeHandler()
			{
				if (JdkConstants.IVerticalScrollBarPolicyInvoker.cb_hashCode == null)
				{
					JdkConstants.IVerticalScrollBarPolicyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JdkConstants.IVerticalScrollBarPolicyInvoker.n_GetHashCode));
				}
				return JdkConstants.IVerticalScrollBarPolicyInvoker.cb_hashCode;
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x0000E42F File Offset: 0x0000C62F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<JdkConstants.IVerticalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x0000E43E File Offset: 0x0000C63E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x0000E47E File Offset: 0x0000C67E
			private static Delegate GetToStringHandler()
			{
				if (JdkConstants.IVerticalScrollBarPolicyInvoker.cb_toString == null)
				{
					JdkConstants.IVerticalScrollBarPolicyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(JdkConstants.IVerticalScrollBarPolicyInvoker.n_ToString));
				}
				return JdkConstants.IVerticalScrollBarPolicyInvoker.cb_toString;
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<JdkConstants.IVerticalScrollBarPolicy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000276 RID: 630
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/JdkConstants$VerticalScrollBarPolicy", typeof(JdkConstants.IVerticalScrollBarPolicyInvoker));

			// Token: 0x04000277 RID: 631
			private IntPtr class_ref;

			// Token: 0x04000278 RID: 632
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000279 RID: 633
			private IntPtr id_annotationType;

			// Token: 0x0400027A RID: 634
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400027B RID: 635
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400027C RID: 636
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400027D RID: 637
			private IntPtr id_hashCode;

			// Token: 0x0400027E RID: 638
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400027F RID: 639
			private IntPtr id_toString;
		}
	}
}
