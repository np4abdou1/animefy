using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace Kotlin.Reflect
{
	// Token: 0x02000134 RID: 308
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KType", DoNotGenerateAcw = true)]
	internal class IKTypeInvoker : Java.Lang.Object, IKType, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00036BC8 File Offset: 0x00034DC8
		private static IntPtr java_class_ref
		{
			get
			{
				return IKTypeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00036BEC File Offset: 0x00034DEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKTypeInvoker._members;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00036BF3 File Offset: 0x00034DF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00036BFB File Offset: 0x00034DFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKTypeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00036C07 File Offset: 0x00034E07
		[NullableContext(2)]
		public static IKType GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKType>(handle, transfer);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00036C10 File Offset: 0x00034E10
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKTypeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KType'.");
			}
			return handle;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00036C3B File Offset: 0x00034E3B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00036C6C File Offset: 0x00034E6C
		public IKTypeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKTypeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00036CA4 File Offset: 0x00034EA4
		private static Delegate GetGetArgumentsHandler()
		{
			if (IKTypeInvoker.cb_getArguments == null)
			{
				IKTypeInvoker.cb_getArguments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeInvoker.n_GetArguments));
			}
			return IKTypeInvoker.cb_getArguments;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00036CC8 File Offset: 0x00034EC8
		private static IntPtr n_GetArguments(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<KTypeProjection>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arguments);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00036CDC File Offset: 0x00034EDC
		public IList<KTypeProjection> Arguments
		{
			get
			{
				if (this.id_getArguments == IntPtr.Zero)
				{
					this.id_getArguments = JNIEnv.GetMethodID(this.class_ref, "getArguments", "()Ljava/util/List;");
				}
				return JavaList<KTypeProjection>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getArguments), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00036D2D File Offset: 0x00034F2D
		private static Delegate GetGetClassifierHandler()
		{
			if (IKTypeInvoker.cb_getClassifier == null)
			{
				IKTypeInvoker.cb_getClassifier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeInvoker.n_GetClassifier));
			}
			return IKTypeInvoker.cb_getClassifier;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00036D51 File Offset: 0x00034F51
		private static IntPtr n_GetClassifier(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Classifier);
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00036D68 File Offset: 0x00034F68
		[Nullable(2)]
		public IKClassifier Classifier
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getClassifier == IntPtr.Zero)
				{
					this.id_getClassifier = JNIEnv.GetMethodID(this.class_ref, "getClassifier", "()Lkotlin/reflect/KClassifier;");
				}
				return Java.Lang.Object.GetObject<IKClassifier>(JNIEnv.CallObjectMethod(base.Handle, this.id_getClassifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00036DB9 File Offset: 0x00034FB9
		private static Delegate GetIsMarkedNullableHandler()
		{
			if (IKTypeInvoker.cb_isMarkedNullable == null)
			{
				IKTypeInvoker.cb_isMarkedNullable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKTypeInvoker.n_IsMarkedNullable));
			}
			return IKTypeInvoker.cb_isMarkedNullable;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00036DDD File Offset: 0x00034FDD
		private static bool n_IsMarkedNullable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsMarkedNullable;
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00036DEC File Offset: 0x00034FEC
		public bool IsMarkedNullable
		{
			get
			{
				if (this.id_isMarkedNullable == IntPtr.Zero)
				{
					this.id_isMarkedNullable = JNIEnv.GetMethodID(this.class_ref, "isMarkedNullable", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isMarkedNullable);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00036E2C File Offset: 0x0003502C
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKTypeInvoker.cb_getAnnotations == null)
			{
				IKTypeInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeInvoker.n_GetAnnotations));
			}
			return IKTypeInvoker.cb_getAnnotations;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00036E50 File Offset: 0x00035050
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00036E64 File Offset: 0x00035064
		public IList<IAnnotation> Annotations
		{
			get
			{
				if (this.id_getAnnotations == IntPtr.Zero)
				{
					this.id_getAnnotations = JNIEnv.GetMethodID(this.class_ref, "getAnnotations", "()Ljava/util/List;");
				}
				return JavaList<IAnnotation>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getAnnotations), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000557 RID: 1367
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KType", typeof(IKTypeInvoker));

		// Token: 0x04000558 RID: 1368
		private IntPtr class_ref;

		// Token: 0x04000559 RID: 1369
		[Nullable(2)]
		private static Delegate cb_getArguments;

		// Token: 0x0400055A RID: 1370
		private IntPtr id_getArguments;

		// Token: 0x0400055B RID: 1371
		[Nullable(2)]
		private static Delegate cb_getClassifier;

		// Token: 0x0400055C RID: 1372
		private IntPtr id_getClassifier;

		// Token: 0x0400055D RID: 1373
		[Nullable(2)]
		private static Delegate cb_isMarkedNullable;

		// Token: 0x0400055E RID: 1374
		private IntPtr id_isMarkedNullable;

		// Token: 0x0400055F RID: 1375
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000560 RID: 1376
		private IntPtr id_getAnnotations;
	}
}
