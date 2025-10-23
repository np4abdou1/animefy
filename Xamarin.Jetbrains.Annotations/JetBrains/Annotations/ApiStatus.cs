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
	// Token: 0x0200000C RID: 12
	[NullableContext(1)]
	[Nullable(0)]
	[Register("org/jetbrains/annotations/ApiStatus", DoNotGenerateAcw = true)]
	public sealed class ApiStatus : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000020A8 File Offset: 0x000002A8
		internal static IntPtr class_ref
		{
			get
			{
				return ApiStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020CC File Offset: 0x000002CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ApiStatus._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020D4 File Offset: 0x000002D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ApiStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020F8 File Offset: 0x000002F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ApiStatus._members.ManagedPeerType;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002104 File Offset: 0x00000304
		internal ApiStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus", typeof(ApiStatus));

		// Token: 0x02000062 RID: 98
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$AvailableSince", "", "JetBrains.Annotations.ApiStatus/IAvailableSinceInvoker")]
		public interface IAvailableSince : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000321 RID: 801
			[NullableContext(2)]
			[Register("value", "()Ljava/lang/String;", "GetValueHandler:JetBrains.Annotations.ApiStatus/IAvailableSinceInvoker, Xamarin.Jetbrains.Annotations")]
			string Value();
		}

		// Token: 0x02000063 RID: 99
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$AvailableSince", DoNotGenerateAcw = true)]
		internal class IAvailableSinceInvoker : Java.Lang.Object, ApiStatus.IAvailableSince, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000322 RID: 802 RVA: 0x00008A88 File Offset: 0x00006C88
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IAvailableSinceInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000323 RID: 803 RVA: 0x00008AAC File Offset: 0x00006CAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IAvailableSinceInvoker._members;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000324 RID: 804 RVA: 0x00008AB3 File Offset: 0x00006CB3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00008ABB File Offset: 0x00006CBB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IAvailableSinceInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000326 RID: 806 RVA: 0x00008AC7 File Offset: 0x00006CC7
			[NullableContext(2)]
			public static ApiStatus.IAvailableSince GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(handle, transfer);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x00008AD0 File Offset: 0x00006CD0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IAvailableSinceInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.AvailableSince'.");
				}
				return handle;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00008AFB File Offset: 0x00006CFB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x00008B2C File Offset: 0x00006D2C
			public IAvailableSinceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IAvailableSinceInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00008B64 File Offset: 0x00006D64
			private static Delegate GetValueHandler()
			{
				if (ApiStatus.IAvailableSinceInvoker.cb_value == null)
				{
					ApiStatus.IAvailableSinceInvoker.cb_value = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IAvailableSinceInvoker.n_Value));
				}
				return ApiStatus.IAvailableSinceInvoker.cb_value;
			}

			// Token: 0x0600032B RID: 811 RVA: 0x00008B88 File Offset: 0x00006D88
			private static IntPtr n_Value(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value());
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00008B9C File Offset: 0x00006D9C
			[NullableContext(2)]
			public string Value()
			{
				if (this.id_value == IntPtr.Zero)
				{
					this.id_value = JNIEnv.GetMethodID(this.class_ref, "value", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_value), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600032D RID: 813 RVA: 0x00008BED File Offset: 0x00006DED
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IAvailableSinceInvoker.cb_annotationType == null)
				{
					ApiStatus.IAvailableSinceInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IAvailableSinceInvoker.n_AnnotationType));
				}
				return ApiStatus.IAvailableSinceInvoker.cb_annotationType;
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00008C11 File Offset: 0x00006E11
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00008C28 File Offset: 0x00006E28
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00008C79 File Offset: 0x00006E79
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IAvailableSinceInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IAvailableSinceInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IAvailableSinceInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IAvailableSinceInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00008CA0 File Offset: 0x00006EA0
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00008CC4 File Offset: 0x00006EC4
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

			// Token: 0x06000333 RID: 819 RVA: 0x00008D37 File Offset: 0x00006F37
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IAvailableSinceInvoker.cb_hashCode == null)
				{
					ApiStatus.IAvailableSinceInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IAvailableSinceInvoker.n_GetHashCode));
				}
				return ApiStatus.IAvailableSinceInvoker.cb_hashCode;
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00008D5B File Offset: 0x00006F5B
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00008D6A File Offset: 0x00006F6A
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00008DAA File Offset: 0x00006FAA
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IAvailableSinceInvoker.cb_toString == null)
				{
					ApiStatus.IAvailableSinceInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IAvailableSinceInvoker.n_ToString));
				}
				return ApiStatus.IAvailableSinceInvoker.cb_toString;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00008DCE File Offset: 0x00006FCE
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IAvailableSince>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00008DE4 File Offset: 0x00006FE4
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000164 RID: 356
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$AvailableSince", typeof(ApiStatus.IAvailableSinceInvoker));

			// Token: 0x04000165 RID: 357
			private IntPtr class_ref;

			// Token: 0x04000166 RID: 358
			[Nullable(2)]
			private static Delegate cb_value;

			// Token: 0x04000167 RID: 359
			private IntPtr id_value;

			// Token: 0x04000168 RID: 360
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000169 RID: 361
			private IntPtr id_annotationType;

			// Token: 0x0400016A RID: 362
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400016B RID: 363
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400016C RID: 364
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400016D RID: 365
			private IntPtr id_hashCode;

			// Token: 0x0400016E RID: 366
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400016F RID: 367
			private IntPtr id_toString;
		}

		// Token: 0x02000064 RID: 100
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Experimental", "", "JetBrains.Annotations.ApiStatus/IExperimentalInvoker")]
		public interface IExperimental : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000065 RID: 101
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Experimental", DoNotGenerateAcw = true)]
		internal class IExperimentalInvoker : Java.Lang.Object, ApiStatus.IExperimental, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600033A RID: 826 RVA: 0x00008E50 File Offset: 0x00007050
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IExperimentalInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600033B RID: 827 RVA: 0x00008E74 File Offset: 0x00007074
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IExperimentalInvoker._members;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600033C RID: 828 RVA: 0x00008E7B File Offset: 0x0000707B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600033D RID: 829 RVA: 0x00008E83 File Offset: 0x00007083
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IExperimentalInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600033E RID: 830 RVA: 0x00008E8F File Offset: 0x0000708F
			[NullableContext(2)]
			public static ApiStatus.IExperimental GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IExperimental>(handle, transfer);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x00008E98 File Offset: 0x00007098
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IExperimentalInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.Experimental'.");
				}
				return handle;
			}

			// Token: 0x06000340 RID: 832 RVA: 0x00008EC3 File Offset: 0x000070C3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00008EF4 File Offset: 0x000070F4
			public IExperimentalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IExperimentalInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000342 RID: 834 RVA: 0x00008F2C File Offset: 0x0000712C
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IExperimentalInvoker.cb_annotationType == null)
				{
					ApiStatus.IExperimentalInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IExperimentalInvoker.n_AnnotationType));
				}
				return ApiStatus.IExperimentalInvoker.cb_annotationType;
			}

			// Token: 0x06000343 RID: 835 RVA: 0x00008F50 File Offset: 0x00007150
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IExperimental>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000344 RID: 836 RVA: 0x00008F64 File Offset: 0x00007164
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000345 RID: 837 RVA: 0x00008FB5 File Offset: 0x000071B5
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IExperimentalInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IExperimentalInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IExperimentalInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IExperimentalInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00008FDC File Offset: 0x000071DC
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IExperimental>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00009000 File Offset: 0x00007200
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

			// Token: 0x06000348 RID: 840 RVA: 0x00009073 File Offset: 0x00007273
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IExperimentalInvoker.cb_hashCode == null)
				{
					ApiStatus.IExperimentalInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IExperimentalInvoker.n_GetHashCode));
				}
				return ApiStatus.IExperimentalInvoker.cb_hashCode;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00009097 File Offset: 0x00007297
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IExperimental>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600034A RID: 842 RVA: 0x000090A6 File Offset: 0x000072A6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x000090E6 File Offset: 0x000072E6
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IExperimentalInvoker.cb_toString == null)
				{
					ApiStatus.IExperimentalInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IExperimentalInvoker.n_ToString));
				}
				return ApiStatus.IExperimentalInvoker.cb_toString;
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0000910A File Offset: 0x0000730A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IExperimental>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00009120 File Offset: 0x00007320
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000170 RID: 368
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$Experimental", typeof(ApiStatus.IExperimentalInvoker));

			// Token: 0x04000171 RID: 369
			private IntPtr class_ref;

			// Token: 0x04000172 RID: 370
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000173 RID: 371
			private IntPtr id_annotationType;

			// Token: 0x04000174 RID: 372
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000175 RID: 373
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000176 RID: 374
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000177 RID: 375
			private IntPtr id_hashCode;

			// Token: 0x04000178 RID: 376
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000179 RID: 377
			private IntPtr id_toString;
		}

		// Token: 0x02000066 RID: 102
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Internal", "", "JetBrains.Annotations.ApiStatus/IInternalInvoker")]
		public interface IInternal : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000067 RID: 103
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Internal", DoNotGenerateAcw = true)]
		internal class IInternalInvoker : Java.Lang.Object, ApiStatus.IInternal, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600034F RID: 847 RVA: 0x0000918C File Offset: 0x0000738C
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IInternalInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000350 RID: 848 RVA: 0x000091B0 File Offset: 0x000073B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IInternalInvoker._members;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000351 RID: 849 RVA: 0x000091B7 File Offset: 0x000073B7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000352 RID: 850 RVA: 0x000091BF File Offset: 0x000073BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IInternalInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000353 RID: 851 RVA: 0x000091CB File Offset: 0x000073CB
			[NullableContext(2)]
			public static ApiStatus.IInternal GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IInternal>(handle, transfer);
			}

			// Token: 0x06000354 RID: 852 RVA: 0x000091D4 File Offset: 0x000073D4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IInternalInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.Internal'.");
				}
				return handle;
			}

			// Token: 0x06000355 RID: 853 RVA: 0x000091FF File Offset: 0x000073FF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000356 RID: 854 RVA: 0x00009230 File Offset: 0x00007430
			public IInternalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IInternalInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000357 RID: 855 RVA: 0x00009268 File Offset: 0x00007468
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IInternalInvoker.cb_annotationType == null)
				{
					ApiStatus.IInternalInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IInternalInvoker.n_AnnotationType));
				}
				return ApiStatus.IInternalInvoker.cb_annotationType;
			}

			// Token: 0x06000358 RID: 856 RVA: 0x0000928C File Offset: 0x0000748C
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000359 RID: 857 RVA: 0x000092A0 File Offset: 0x000074A0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600035A RID: 858 RVA: 0x000092F1 File Offset: 0x000074F1
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IInternalInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IInternalInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IInternalInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IInternalInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600035B RID: 859 RVA: 0x00009318 File Offset: 0x00007518
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600035C RID: 860 RVA: 0x0000933C File Offset: 0x0000753C
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

			// Token: 0x0600035D RID: 861 RVA: 0x000093AF File Offset: 0x000075AF
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IInternalInvoker.cb_hashCode == null)
				{
					ApiStatus.IInternalInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IInternalInvoker.n_GetHashCode));
				}
				return ApiStatus.IInternalInvoker.cb_hashCode;
			}

			// Token: 0x0600035E RID: 862 RVA: 0x000093D3 File Offset: 0x000075D3
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600035F RID: 863 RVA: 0x000093E2 File Offset: 0x000075E2
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00009422 File Offset: 0x00007622
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IInternalInvoker.cb_toString == null)
				{
					ApiStatus.IInternalInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IInternalInvoker.n_ToString));
				}
				return ApiStatus.IInternalInvoker.cb_toString;
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00009446 File Offset: 0x00007646
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IInternal>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000362 RID: 866 RVA: 0x0000945C File Offset: 0x0000765C
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400017A RID: 378
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$Internal", typeof(ApiStatus.IInternalInvoker));

			// Token: 0x0400017B RID: 379
			private IntPtr class_ref;

			// Token: 0x0400017C RID: 380
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400017D RID: 381
			private IntPtr id_annotationType;

			// Token: 0x0400017E RID: 382
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400017F RID: 383
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000180 RID: 384
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000181 RID: 385
			private IntPtr id_hashCode;

			// Token: 0x04000182 RID: 386
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000183 RID: 387
			private IntPtr id_toString;
		}

		// Token: 0x02000068 RID: 104
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$NonExtendable", "", "JetBrains.Annotations.ApiStatus/INonExtendableInvoker")]
		public interface INonExtendable : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000069 RID: 105
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$NonExtendable", DoNotGenerateAcw = true)]
		internal class INonExtendableInvoker : Java.Lang.Object, ApiStatus.INonExtendable, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000364 RID: 868 RVA: 0x000094C8 File Offset: 0x000076C8
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.INonExtendableInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000365 RID: 869 RVA: 0x000094EC File Offset: 0x000076EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.INonExtendableInvoker._members;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000366 RID: 870 RVA: 0x000094F3 File Offset: 0x000076F3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000367 RID: 871 RVA: 0x000094FB File Offset: 0x000076FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.INonExtendableInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00009507 File Offset: 0x00007707
			[NullableContext(2)]
			public static ApiStatus.INonExtendable GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.INonExtendable>(handle, transfer);
			}

			// Token: 0x06000369 RID: 873 RVA: 0x00009510 File Offset: 0x00007710
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.INonExtendableInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.NonExtendable'.");
				}
				return handle;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0000953B File Offset: 0x0000773B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600036B RID: 875 RVA: 0x0000956C File Offset: 0x0000776C
			public INonExtendableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.INonExtendableInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600036C RID: 876 RVA: 0x000095A4 File Offset: 0x000077A4
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.INonExtendableInvoker.cb_annotationType == null)
				{
					ApiStatus.INonExtendableInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.INonExtendableInvoker.n_AnnotationType));
				}
				return ApiStatus.INonExtendableInvoker.cb_annotationType;
			}

			// Token: 0x0600036D RID: 877 RVA: 0x000095C8 File Offset: 0x000077C8
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.INonExtendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600036E RID: 878 RVA: 0x000095DC File Offset: 0x000077DC
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0000962D File Offset: 0x0000782D
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.INonExtendableInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.INonExtendableInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.INonExtendableInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.INonExtendableInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000370 RID: 880 RVA: 0x00009654 File Offset: 0x00007854
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.INonExtendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x00009678 File Offset: 0x00007878
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

			// Token: 0x06000372 RID: 882 RVA: 0x000096EB File Offset: 0x000078EB
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.INonExtendableInvoker.cb_hashCode == null)
				{
					ApiStatus.INonExtendableInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.INonExtendableInvoker.n_GetHashCode));
				}
				return ApiStatus.INonExtendableInvoker.cb_hashCode;
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000970F File Offset: 0x0000790F
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.INonExtendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x06000374 RID: 884 RVA: 0x0000971E File Offset: 0x0000791E
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x06000375 RID: 885 RVA: 0x0000975E File Offset: 0x0000795E
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.INonExtendableInvoker.cb_toString == null)
				{
					ApiStatus.INonExtendableInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.INonExtendableInvoker.n_ToString));
				}
				return ApiStatus.INonExtendableInvoker.cb_toString;
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00009782 File Offset: 0x00007982
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.INonExtendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00009798 File Offset: 0x00007998
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000184 RID: 388
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$NonExtendable", typeof(ApiStatus.INonExtendableInvoker));

			// Token: 0x04000185 RID: 389
			private IntPtr class_ref;

			// Token: 0x04000186 RID: 390
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000187 RID: 391
			private IntPtr id_annotationType;

			// Token: 0x04000188 RID: 392
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000189 RID: 393
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x0400018A RID: 394
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x0400018B RID: 395
			private IntPtr id_hashCode;

			// Token: 0x0400018C RID: 396
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x0400018D RID: 397
			private IntPtr id_toString;
		}

		// Token: 0x0200006A RID: 106
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Obsolete", "", "JetBrains.Annotations.ApiStatus/IObsoleteInvoker")]
		public interface IObsolete : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000379 RID: 889
			[NullableContext(2)]
			[Register("since", "()Ljava/lang/String;", "GetSinceHandler:JetBrains.Annotations.ApiStatus/IObsoleteInvoker, Xamarin.Jetbrains.Annotations")]
			string Since();
		}

		// Token: 0x0200006B RID: 107
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$Obsolete", DoNotGenerateAcw = true)]
		internal class IObsoleteInvoker : Java.Lang.Object, ApiStatus.IObsolete, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000AA RID: 170
			// (get) Token: 0x0600037A RID: 890 RVA: 0x00009804 File Offset: 0x00007A04
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IObsoleteInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x0600037B RID: 891 RVA: 0x00009828 File Offset: 0x00007A28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IObsoleteInvoker._members;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0000982F File Offset: 0x00007A2F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x0600037D RID: 893 RVA: 0x00009837 File Offset: 0x00007A37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IObsoleteInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00009843 File Offset: 0x00007A43
			[NullableContext(2)]
			public static ApiStatus.IObsolete GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IObsolete>(handle, transfer);
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0000984C File Offset: 0x00007A4C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IObsoleteInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.Obsolete'.");
				}
				return handle;
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00009877 File Offset: 0x00007A77
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x000098A8 File Offset: 0x00007AA8
			public IObsoleteInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IObsoleteInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000382 RID: 898 RVA: 0x000098E0 File Offset: 0x00007AE0
			private static Delegate GetSinceHandler()
			{
				if (ApiStatus.IObsoleteInvoker.cb_since == null)
				{
					ApiStatus.IObsoleteInvoker.cb_since = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IObsoleteInvoker.n_Since));
				}
				return ApiStatus.IObsoleteInvoker.cb_since;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00009904 File Offset: 0x00007B04
			private static IntPtr n_Since(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IObsolete>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Since());
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00009918 File Offset: 0x00007B18
			[NullableContext(2)]
			public string Since()
			{
				if (this.id_since == IntPtr.Zero)
				{
					this.id_since = JNIEnv.GetMethodID(this.class_ref, "since", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_since), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000385 RID: 901 RVA: 0x00009969 File Offset: 0x00007B69
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IObsoleteInvoker.cb_annotationType == null)
				{
					ApiStatus.IObsoleteInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IObsoleteInvoker.n_AnnotationType));
				}
				return ApiStatus.IObsoleteInvoker.cb_annotationType;
			}

			// Token: 0x06000386 RID: 902 RVA: 0x0000998D File Offset: 0x00007B8D
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IObsolete>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x06000387 RID: 903 RVA: 0x000099A4 File Offset: 0x00007BA4
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000388 RID: 904 RVA: 0x000099F5 File Offset: 0x00007BF5
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IObsoleteInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IObsoleteInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IObsoleteInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IObsoleteInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00009A1C File Offset: 0x00007C1C
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IObsolete>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00009A40 File Offset: 0x00007C40
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

			// Token: 0x0600038B RID: 907 RVA: 0x00009AB3 File Offset: 0x00007CB3
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IObsoleteInvoker.cb_hashCode == null)
				{
					ApiStatus.IObsoleteInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IObsoleteInvoker.n_GetHashCode));
				}
				return ApiStatus.IObsoleteInvoker.cb_hashCode;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00009AD7 File Offset: 0x00007CD7
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IObsolete>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x0600038D RID: 909 RVA: 0x00009AE6 File Offset: 0x00007CE6
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x0600038E RID: 910 RVA: 0x00009B26 File Offset: 0x00007D26
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IObsoleteInvoker.cb_toString == null)
				{
					ApiStatus.IObsoleteInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IObsoleteInvoker.n_ToString));
				}
				return ApiStatus.IObsoleteInvoker.cb_toString;
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00009B4A File Offset: 0x00007D4A
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IObsolete>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00009B60 File Offset: 0x00007D60
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400018E RID: 398
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$Obsolete", typeof(ApiStatus.IObsoleteInvoker));

			// Token: 0x0400018F RID: 399
			private IntPtr class_ref;

			// Token: 0x04000190 RID: 400
			[Nullable(2)]
			private static Delegate cb_since;

			// Token: 0x04000191 RID: 401
			private IntPtr id_since;

			// Token: 0x04000192 RID: 402
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x04000193 RID: 403
			private IntPtr id_annotationType;

			// Token: 0x04000194 RID: 404
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x04000195 RID: 405
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x04000196 RID: 406
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x04000197 RID: 407
			private IntPtr id_hashCode;

			// Token: 0x04000198 RID: 408
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x04000199 RID: 409
			private IntPtr id_toString;
		}

		// Token: 0x0200006C RID: 108
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$OverrideOnly", "", "JetBrains.Annotations.ApiStatus/IOverrideOnlyInvoker")]
		public interface IOverrideOnly : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200006D RID: 109
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$OverrideOnly", DoNotGenerateAcw = true)]
		internal class IOverrideOnlyInvoker : Java.Lang.Object, ApiStatus.IOverrideOnly, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00009BCC File Offset: 0x00007DCC
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IOverrideOnlyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000393 RID: 915 RVA: 0x00009BF0 File Offset: 0x00007DF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IOverrideOnlyInvoker._members;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000394 RID: 916 RVA: 0x00009BF7 File Offset: 0x00007DF7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000395 RID: 917 RVA: 0x00009BFF File Offset: 0x00007DFF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IOverrideOnlyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00009C0B File Offset: 0x00007E0B
			[NullableContext(2)]
			public static ApiStatus.IOverrideOnly GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IOverrideOnly>(handle, transfer);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00009C14 File Offset: 0x00007E14
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IOverrideOnlyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.OverrideOnly'.");
				}
				return handle;
			}

			// Token: 0x06000398 RID: 920 RVA: 0x00009C3F File Offset: 0x00007E3F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00009C70 File Offset: 0x00007E70
			public IOverrideOnlyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IOverrideOnlyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600039A RID: 922 RVA: 0x00009CA8 File Offset: 0x00007EA8
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IOverrideOnlyInvoker.cb_annotationType == null)
				{
					ApiStatus.IOverrideOnlyInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IOverrideOnlyInvoker.n_AnnotationType));
				}
				return ApiStatus.IOverrideOnlyInvoker.cb_annotationType;
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00009CCC File Offset: 0x00007ECC
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IOverrideOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00009CE0 File Offset: 0x00007EE0
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00009D31 File Offset: 0x00007F31
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IOverrideOnlyInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IOverrideOnlyInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IOverrideOnlyInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IOverrideOnlyInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00009D58 File Offset: 0x00007F58
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IOverrideOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00009D7C File Offset: 0x00007F7C
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

			// Token: 0x060003A0 RID: 928 RVA: 0x00009DEF File Offset: 0x00007FEF
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IOverrideOnlyInvoker.cb_hashCode == null)
				{
					ApiStatus.IOverrideOnlyInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IOverrideOnlyInvoker.n_GetHashCode));
				}
				return ApiStatus.IOverrideOnlyInvoker.cb_hashCode;
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x00009E13 File Offset: 0x00008013
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IOverrideOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x00009E22 File Offset: 0x00008022
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x00009E62 File Offset: 0x00008062
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IOverrideOnlyInvoker.cb_toString == null)
				{
					ApiStatus.IOverrideOnlyInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IOverrideOnlyInvoker.n_ToString));
				}
				return ApiStatus.IOverrideOnlyInvoker.cb_toString;
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x00009E86 File Offset: 0x00008086
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IOverrideOnly>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00009E9C File Offset: 0x0000809C
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400019A RID: 410
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$OverrideOnly", typeof(ApiStatus.IOverrideOnlyInvoker));

			// Token: 0x0400019B RID: 411
			private IntPtr class_ref;

			// Token: 0x0400019C RID: 412
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x0400019D RID: 413
			private IntPtr id_annotationType;

			// Token: 0x0400019E RID: 414
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x0400019F RID: 415
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001A0 RID: 416
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001A1 RID: 417
			private IntPtr id_hashCode;

			// Token: 0x040001A2 RID: 418
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001A3 RID: 419
			private IntPtr id_toString;
		}

		// Token: 0x0200006E RID: 110
		[NullableContext(0)]
		[Register("org/jetbrains/annotations/ApiStatus$ScheduledForRemoval", "", "JetBrains.Annotations.ApiStatus/IScheduledForRemovalInvoker")]
		public interface IScheduledForRemoval : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003A7 RID: 935
			[NullableContext(2)]
			[Register("inVersion", "()Ljava/lang/String;", "GetInVersionHandler:JetBrains.Annotations.ApiStatus/IScheduledForRemovalInvoker, Xamarin.Jetbrains.Annotations")]
			string InVersion();
		}

		// Token: 0x0200006F RID: 111
		[Nullable(0)]
		[Register("org/jetbrains/annotations/ApiStatus$ScheduledForRemoval", DoNotGenerateAcw = true)]
		internal class IScheduledForRemovalInvoker : Java.Lang.Object, ApiStatus.IScheduledForRemoval, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x00009F08 File Offset: 0x00008108
			private static IntPtr java_class_ref
			{
				get
				{
					return ApiStatus.IScheduledForRemovalInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x00009F2C File Offset: 0x0000812C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ApiStatus.IScheduledForRemovalInvoker._members;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060003AA RID: 938 RVA: 0x00009F33 File Offset: 0x00008133
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00009F3B File Offset: 0x0000813B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ApiStatus.IScheduledForRemovalInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00009F47 File Offset: 0x00008147
			[NullableContext(2)]
			public static ApiStatus.IScheduledForRemoval GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(handle, transfer);
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00009F50 File Offset: 0x00008150
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ApiStatus.IScheduledForRemovalInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.jetbrains.annotations.ApiStatus.ScheduledForRemoval'.");
				}
				return handle;
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00009F7B File Offset: 0x0000817B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00009FAC File Offset: 0x000081AC
			public IScheduledForRemovalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ApiStatus.IScheduledForRemovalInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00009FE4 File Offset: 0x000081E4
			private static Delegate GetInVersionHandler()
			{
				if (ApiStatus.IScheduledForRemovalInvoker.cb_inVersion == null)
				{
					ApiStatus.IScheduledForRemovalInvoker.cb_inVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IScheduledForRemovalInvoker.n_InVersion));
				}
				return ApiStatus.IScheduledForRemovalInvoker.cb_inVersion;
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000A008 File Offset: 0x00008208
			private static IntPtr n_InVersion(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InVersion());
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0000A01C File Offset: 0x0000821C
			[NullableContext(2)]
			public string InVersion()
			{
				if (this.id_inVersion == IntPtr.Zero)
				{
					this.id_inVersion = JNIEnv.GetMethodID(this.class_ref, "inVersion", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_inVersion), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x0000A06D File Offset: 0x0000826D
			private static Delegate GetAnnotationTypeHandler()
			{
				if (ApiStatus.IScheduledForRemovalInvoker.cb_annotationType == null)
				{
					ApiStatus.IScheduledForRemovalInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IScheduledForRemovalInvoker.n_AnnotationType));
				}
				return ApiStatus.IScheduledForRemovalInvoker.cb_annotationType;
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x0000A091 File Offset: 0x00008291
			private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000A0A8 File Offset: 0x000082A8
			[NullableContext(2)]
			public Class AnnotationType()
			{
				if (this.id_annotationType == IntPtr.Zero)
				{
					this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
				}
				return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0000A0F9 File Offset: 0x000082F9
			private static Delegate GetEquals_Ljava_lang_Object_Handler()
			{
				if (ApiStatus.IScheduledForRemovalInvoker.cb_equals_Ljava_lang_Object_ == null)
				{
					ApiStatus.IScheduledForRemovalInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ApiStatus.IScheduledForRemovalInvoker.n_Equals_Ljava_lang_Object_));
				}
				return ApiStatus.IScheduledForRemovalInvoker.cb_equals_Ljava_lang_Object_;
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x0000A120 File Offset: 0x00008320
			private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				IAnnotation @object = Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return @object.Equals(object2);
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000A144 File Offset: 0x00008344
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

			// Token: 0x060003B9 RID: 953 RVA: 0x0000A1B7 File Offset: 0x000083B7
			private static Delegate GetGetHashCodeHandler()
			{
				if (ApiStatus.IScheduledForRemovalInvoker.cb_hashCode == null)
				{
					ApiStatus.IScheduledForRemovalInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ApiStatus.IScheduledForRemovalInvoker.n_GetHashCode));
				}
				return ApiStatus.IScheduledForRemovalInvoker.cb_hashCode;
			}

			// Token: 0x060003BA RID: 954 RVA: 0x0000A1DB File Offset: 0x000083DB
			private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0000A1EA File Offset: 0x000083EA
			public new int GetHashCode()
			{
				if (this.id_hashCode == IntPtr.Zero)
				{
					this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0000A22A File Offset: 0x0000842A
			private static Delegate GetToStringHandler()
			{
				if (ApiStatus.IScheduledForRemovalInvoker.cb_toString == null)
				{
					ApiStatus.IScheduledForRemovalInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ApiStatus.IScheduledForRemovalInvoker.n_ToString));
				}
				return ApiStatus.IScheduledForRemovalInvoker.cb_toString;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x0000A24E File Offset: 0x0000844E
			private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<ApiStatus.IScheduledForRemoval>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000A264 File Offset: 0x00008464
			[NullableContext(2)]
			public new string ToString()
			{
				if (this.id_toString == IntPtr.Zero)
				{
					this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001A4 RID: 420
			private static readonly JniPeerMembers _members = new XAPeerMembers("org/jetbrains/annotations/ApiStatus$ScheduledForRemoval", typeof(ApiStatus.IScheduledForRemovalInvoker));

			// Token: 0x040001A5 RID: 421
			private IntPtr class_ref;

			// Token: 0x040001A6 RID: 422
			[Nullable(2)]
			private static Delegate cb_inVersion;

			// Token: 0x040001A7 RID: 423
			private IntPtr id_inVersion;

			// Token: 0x040001A8 RID: 424
			[Nullable(2)]
			private static Delegate cb_annotationType;

			// Token: 0x040001A9 RID: 425
			private IntPtr id_annotationType;

			// Token: 0x040001AA RID: 426
			[Nullable(2)]
			private static Delegate cb_equals_Ljava_lang_Object_;

			// Token: 0x040001AB RID: 427
			private IntPtr id_equals_Ljava_lang_Object_;

			// Token: 0x040001AC RID: 428
			[Nullable(2)]
			private static Delegate cb_hashCode;

			// Token: 0x040001AD RID: 429
			private IntPtr id_hashCode;

			// Token: 0x040001AE RID: 430
			[Nullable(2)]
			private static Delegate cb_toString;

			// Token: 0x040001AF RID: 431
			private IntPtr id_toString;
		}
	}
}
