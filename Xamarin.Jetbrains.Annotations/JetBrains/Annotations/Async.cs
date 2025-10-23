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
	// Token: 0x0200000D RID: 13
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/Async", DoNotGenerateAcw = true)]
	public sealed class Async : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000212C File Offset: 0x0000032C
		internal static IntPtr class_ref
		{
			get
			{
				return Async._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002150 File Offset: 0x00000350
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Async._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002158 File Offset: 0x00000358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Async._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000037C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Async._members.ManagedPeerType;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002188 File Offset: 0x00000388
		internal Async(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Async", typeof(Async));

		// Token: 0x02000070 RID: 112
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/Async$Execute", "", "JetBrains.Annotations.Async/IExecuteInvoker")]
		public interface IExecute : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000071 RID: 113
		[Nullable(0)]
		[Register("org/jetbrains/annotations/Async$Execute", DoNotGenerateAcw = true)]
		internal class IExecuteInvoker : Java.Lang.Object, Async.IExecute, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000A2D0 File Offset: 0x000084D0
			private static IntPtr java_class_ref
			{
				get
				{
					return Async.IExecuteInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000A2F4 File Offset: 0x000084F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Async.IExecuteInvoker._members;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000A2FB File Offset: 0x000084FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000A303 File Offset: 0x00008503
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Async.IExecuteInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000A30F File Offset: 0x0000850F
			[NullableContext(2)]
			public static Async.IExecute GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Async.IExecute>(handle, transfer);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000A318 File Offset: 0x00008518
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Async.IExecuteInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Async.Execute'.");
				}
				return handle;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x0000A343 File Offset: 0x00008543
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000A374 File Offset: 0x00008574
			public IExecuteInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Async.IExecuteInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000A3AC File Offset: 0x000085AC
			private static Delegate GetAnnotationTypeHandler()
			{
				if (Async.IExecuteInvoker.cb_annotationType == null)
				{
					Async.IExecuteInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Async.IExecuteInvoker.n_AnnotationType));
				}
				return Async.IExecuteInvoker.cb_annotationType;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x0000A3D0 File Offset: 0x000085D0
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Async.IExecute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000A3E4 File Offset: 0x000085E4
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0000A435 File Offset: 0x00008635
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (Async.IExecuteInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					Async.IExecuteInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Async.IExecuteInvoker.n_Equals_Ljava_lang_Object_));
				}
				return Async.IExecuteInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0000A45C File Offset: 0x0000865C
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<Async.IExecute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0000A480 File Offset: 0x00008680
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

			// Token: 0x060003CE RID: 974 RVA: 0x0000A4F3 File Offset: 0x000086F3
			private static Delegate GetGetHashCodeHandler()
			{
				if (Async.IExecuteInvoker.cb_hashCode == null)
				{
					Async.IExecuteInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Async.IExecuteInvoker.n_GetHashCode));
				}
				return Async.IExecuteInvoker.cb_hashCode;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000A517 File Offset: 0x00008717
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Async.IExecute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000A526 File Offset: 0x00008726
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000A566 File Offset: 0x00008766
			private static Delegate GetToStringHandler()
			{
				if (Async.IExecuteInvoker.cb_toString == null)
				{
					Async.IExecuteInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Async.IExecuteInvoker.n_ToString));
				}
				return Async.IExecuteInvoker.cb_toString;
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0000A58A File Offset: 0x0000878A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Async.IExecute>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0000A5A0 File Offset: 0x000087A0
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001B0 RID: 432
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Async$Execute", typeof(Async.IExecuteInvoker));

			// Token: 0x040001B1 RID: 433
			private IntPtr class_ref;

			// Token: 0x040001B2 RID: 434
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001B3 RID: 435
			private IntPtr id_annotationType;

			// Token: 0x040001B4 RID: 436
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001B5 RID: 437
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001B6 RID: 438
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001B7 RID: 439
			private IntPtr id_hashCode;

			// Token: 0x040001B8 RID: 440
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001B9 RID: 441
			private IntPtr id_toString;
		}

		// Token: 0x02000072 RID: 114
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/Async$Schedule", "", "JetBrains.Annotations.Async/IScheduleInvoker")]
		public interface ISchedule : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000073 RID: 115
		[Nullable(0)]
		[Register("org/jetbrains/annotations/Async$Schedule", DoNotGenerateAcw = true)]
		internal class IScheduleInvoker : Java.Lang.Object, Async.ISchedule, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000A60C File Offset: 0x0000880C
			private static IntPtr java_class_ref
			{
				get
				{
					return Async.IScheduleInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x0000A630 File Offset: 0x00008830
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Async.IScheduleInvoker._members;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000A637 File Offset: 0x00008837
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000A63F File Offset: 0x0000883F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Async.IScheduleInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x0000A64B File Offset: 0x0000884B
			[NullableContext(2)]
			public static Async.ISchedule GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Async.ISchedule>(handle, transfer);
			}

			// Token: 0x060003DA RID: 986 RVA: 0x0000A654 File Offset: 0x00008854
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Async.IScheduleInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.Async.Schedule'.");
				}
				return handle;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000A67F File Offset: 0x0000887F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0000A6B0 File Offset: 0x000088B0
			public IScheduleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Async.IScheduleInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003DD RID: 989 RVA: 0x0000A6E8 File Offset: 0x000088E8
			private static Delegate GetAnnotationTypeHandler()
			{
				if (Async.IScheduleInvoker.cb_annotationType == null)
				{
					Async.IScheduleInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Async.IScheduleInvoker.n_AnnotationType));
				}
				return Async.IScheduleInvoker.cb_annotationType;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x0000A70C File Offset: 0x0000890C
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Async.ISchedule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060003DF RID: 991 RVA: 0x0000A720 File Offset: 0x00008920
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x0000A771 File Offset: 0x00008971
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (Async.IScheduleInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					Async.IScheduleInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Async.IScheduleInvoker.n_Equals_Ljava_lang_Object_));
				}
				return Async.IScheduleInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0000A798 File Offset: 0x00008998
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<Async.ISchedule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0000A7BC File Offset: 0x000089BC
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

			// Token: 0x060003E3 RID: 995 RVA: 0x0000A82F File Offset: 0x00008A2F
			private static Delegate GetGetHashCodeHandler()
			{
				if (Async.IScheduleInvoker.cb_hashCode == null)
				{
					Async.IScheduleInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Async.IScheduleInvoker.n_GetHashCode));
				}
				return Async.IScheduleInvoker.cb_hashCode;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0000A853 File Offset: 0x00008A53
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Async.ISchedule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x0000A862 File Offset: 0x00008A62
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0000A8A2 File Offset: 0x00008AA2
			private static Delegate GetToStringHandler()
			{
				if (Async.IScheduleInvoker.cb_toString == null)
				{
					Async.IScheduleInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Async.IScheduleInvoker.n_ToString));
				}
				return Async.IScheduleInvoker.cb_toString;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0000A8C6 File Offset: 0x00008AC6
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Async.ISchedule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x0000A8DC File Offset: 0x00008ADC
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001BA RID: 442
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/Async$Schedule", typeof(Async.IScheduleInvoker));

			// Token: 0x040001BB RID: 443
			private IntPtr class_ref;

			// Token: 0x040001BC RID: 444
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001BD RID: 445
			private IntPtr id_annotationType;

			// Token: 0x040001BE RID: 446
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001BF RID: 447
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001C0 RID: 448
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001C1 RID: 449
			private IntPtr id_hashCode;

			// Token: 0x040001C2 RID: 450
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001C3 RID: 451
			private IntPtr id_toString;
		}
	}
}
