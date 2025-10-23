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
	// Token: 0x0200004C RID: 76
	[NullableContext(2)]
	[Nullable(0)]
	[Register("org/intellij/lang/annotations/Flow", DoNotGenerateAcw = true)]
	internal class IFlowInvoker : Java.Lang.Object, IFlow, IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000667C File Offset: 0x0000487C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000066A0 File Offset: 0x000048A0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFlowInvoker._members;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600021B RID: 539 RVA: 0x000066A7 File Offset: 0x000048A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000066AF File Offset: 0x000048AF
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000066BB File Offset: 0x000048BB
		public static IFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFlow>(handle, transfer);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000066C4 File Offset: 0x000048C4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'org.intellij.lang.annotations.Flow'.");
			}
			return handle;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000066EF File Offset: 0x000048EF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00006720 File Offset: 0x00004920
		public IFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00006758 File Offset: 0x00004958
		[NullableContext(1)]
		private static Delegate GetSourceHandler()
		{
			if (IFlowInvoker.cb_source == null)
			{
				IFlowInvoker.cb_source = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowInvoker.n_Source));
			}
			return IFlowInvoker.cb_source;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000677C File Offset: 0x0000497C
		private static IntPtr n_Source(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Source());
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00006790 File Offset: 0x00004990
		public string Source()
		{
			if (this.id_source == IntPtr.Zero)
			{
				this.id_source = JNIEnv.GetMethodID(this.class_ref, "source", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_source), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000067E1 File Offset: 0x000049E1
		[NullableContext(1)]
		private static Delegate GetSourceIsContainerHandler()
		{
			if (IFlowInvoker.cb_sourceIsContainer == null)
			{
				IFlowInvoker.cb_sourceIsContainer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFlowInvoker.n_SourceIsContainer));
			}
			return IFlowInvoker.cb_sourceIsContainer;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00006805 File Offset: 0x00004A05
		private static bool n_SourceIsContainer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SourceIsContainer();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00006814 File Offset: 0x00004A14
		public bool SourceIsContainer()
		{
			if (this.id_sourceIsContainer == IntPtr.Zero)
			{
				this.id_sourceIsContainer = JNIEnv.GetMethodID(this.class_ref, "sourceIsContainer", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_sourceIsContainer);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00006854 File Offset: 0x00004A54
		[NullableContext(1)]
		private static Delegate GetTargetHandler()
		{
			if (IFlowInvoker.cb_target == null)
			{
				IFlowInvoker.cb_target = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowInvoker.n_Target));
			}
			return IFlowInvoker.cb_target;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00006878 File Offset: 0x00004A78
		private static IntPtr n_Target(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Target());
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000688C File Offset: 0x00004A8C
		public string Target()
		{
			if (this.id_target == IntPtr.Zero)
			{
				this.id_target = JNIEnv.GetMethodID(this.class_ref, "target", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_target), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000068DD File Offset: 0x00004ADD
		[NullableContext(1)]
		private static Delegate GetTargetIsContainerHandler()
		{
			if (IFlowInvoker.cb_targetIsContainer == null)
			{
				IFlowInvoker.cb_targetIsContainer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IFlowInvoker.n_TargetIsContainer));
			}
			return IFlowInvoker.cb_targetIsContainer;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00006901 File Offset: 0x00004B01
		private static bool n_TargetIsContainer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TargetIsContainer();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00006910 File Offset: 0x00004B10
		public bool TargetIsContainer()
		{
			if (this.id_targetIsContainer == IntPtr.Zero)
			{
				this.id_targetIsContainer = JNIEnv.GetMethodID(this.class_ref, "targetIsContainer", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_targetIsContainer);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00006950 File Offset: 0x00004B50
		[NullableContext(1)]
		private static Delegate GetAnnotationTypeHandler()
		{
			if (IFlowInvoker.cb_annotationType == null)
			{
				IFlowInvoker.cb_annotationType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowInvoker.n_AnnotationType));
			}
			return IFlowInvoker.cb_annotationType;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00006974 File Offset: 0x00004B74
		private static IntPtr n_AnnotationType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnnotationType());
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00006988 File Offset: 0x00004B88
		public Class AnnotationType()
		{
			if (this.id_annotationType == IntPtr.Zero)
			{
				this.id_annotationType = JNIEnv.GetMethodID(this.class_ref, "annotationType", "()Ljava/lang/Class;");
			}
			return Java.Lang.Object.GetObject<Class>(JNIEnv.CallObjectMethod(base.Handle, this.id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000069D9 File Offset: 0x00004BD9
		[NullableContext(1)]
		private static Delegate GetEquals_Ljava_lang_Object_Handler()
		{
			if (IFlowInvoker.cb_equals_Ljava_lang_Object_ == null)
			{
				IFlowInvoker.cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IFlowInvoker.n_Equals_Ljava_lang_Object_));
			}
			return IFlowInvoker.cb_equals_Ljava_lang_Object_;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006A00 File Offset: 0x00004C00
		private static bool n_Equals_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			IAnnotation @object = Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
			return @object.Equals(object2);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00006A24 File Offset: 0x00004C24
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

		// Token: 0x06000233 RID: 563 RVA: 0x00006A97 File Offset: 0x00004C97
		[NullableContext(1)]
		private static Delegate GetGetHashCodeHandler()
		{
			if (IFlowInvoker.cb_hashCode == null)
			{
				IFlowInvoker.cb_hashCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IFlowInvoker.n_GetHashCode));
			}
			return IFlowInvoker.cb_hashCode;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00006ABB File Offset: 0x00004CBB
		private static int n_GetHashCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetHashCode();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00006ACA File Offset: 0x00004CCA
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00006B0A File Offset: 0x00004D0A
		[NullableContext(1)]
		private static Delegate GetToStringHandler()
		{
			if (IFlowInvoker.cb_toString == null)
			{
				IFlowInvoker.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IFlowInvoker.n_ToString));
			}
			return IFlowInvoker.cb_toString;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00006B2E File Offset: 0x00004D2E
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00006B44 File Offset: 0x00004D44
		public new string ToString()
		{
			if (this.id_toString == IntPtr.Zero)
			{
				this.id_toString = JNIEnv.GetMethodID(this.class_ref, "toString", "()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_toString), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000E7 RID: 231
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("org/intellij/lang/annotations/Flow", typeof(IFlowInvoker));

		// Token: 0x040000E8 RID: 232
		private IntPtr class_ref;

		// Token: 0x040000E9 RID: 233
		private static Delegate cb_source;

		// Token: 0x040000EA RID: 234
		private IntPtr id_source;

		// Token: 0x040000EB RID: 235
		private static Delegate cb_sourceIsContainer;

		// Token: 0x040000EC RID: 236
		private IntPtr id_sourceIsContainer;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_target;

		// Token: 0x040000EE RID: 238
		private IntPtr id_target;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_targetIsContainer;

		// Token: 0x040000F0 RID: 240
		private IntPtr id_targetIsContainer;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_annotationType;

		// Token: 0x040000F2 RID: 242
		private IntPtr id_annotationType;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_equals_Ljava_lang_Object_;

		// Token: 0x040000F4 RID: 244
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_hashCode;

		// Token: 0x040000F6 RID: 246
		private IntPtr id_hashCode;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_toString;

		// Token: 0x040000F8 RID: 248
		private IntPtr id_toString;
	}
}
