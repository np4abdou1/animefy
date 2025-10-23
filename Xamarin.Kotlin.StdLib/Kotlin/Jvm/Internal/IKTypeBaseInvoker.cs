using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;
using Java.Lang.Reflect;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A4 RID: 420
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/KTypeBase", DoNotGenerateAcw = true)]
	internal class IKTypeBaseInvoker : Java.Lang.Object, IKTypeBase, IKType, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x000425A4 File Offset: 0x000407A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IKTypeBaseInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000425C8 File Offset: 0x000407C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKTypeBaseInvoker._members;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x000425CF File Offset: 0x000407CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000425D7 File Offset: 0x000407D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKTypeBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x000425E3 File Offset: 0x000407E3
		[NullableContext(2)]
		public static IKTypeBase GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKTypeBase>(handle, transfer);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x000425EC File Offset: 0x000407EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKTypeBaseInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.KTypeBase'.");
			}
			return handle;
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00042617 File Offset: 0x00040817
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00042648 File Offset: 0x00040848
		public IKTypeBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKTypeBaseInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00042680 File Offset: 0x00040880
		private static Delegate GetGetJavaTypeHandler()
		{
			if (IKTypeBaseInvoker.cb_getJavaType == null)
			{
				IKTypeBaseInvoker.cb_getJavaType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeBaseInvoker.n_GetJavaType));
			}
			return IKTypeBaseInvoker.cb_getJavaType;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000426A4 File Offset: 0x000408A4
		private static IntPtr n_GetJavaType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).JavaType);
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x000426B8 File Offset: 0x000408B8
		[Nullable(2)]
		public IType JavaType
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getJavaType == IntPtr.Zero)
				{
					this.id_getJavaType = JNIEnv.GetMethodID(this.class_ref, "getJavaType", "()Ljava/lang/reflect/Type;");
				}
				return Java.Lang.Object.GetObject<IType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getJavaType), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00042709 File Offset: 0x00040909
		private static Delegate GetGetArgumentsHandler()
		{
			if (IKTypeBaseInvoker.cb_getArguments == null)
			{
				IKTypeBaseInvoker.cb_getArguments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeBaseInvoker.n_GetArguments));
			}
			return IKTypeBaseInvoker.cb_getArguments;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0004272D File Offset: 0x0004092D
		private static IntPtr n_GetArguments(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<KTypeProjection>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Arguments);
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00042744 File Offset: 0x00040944
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

		// Token: 0x0600149E RID: 5278 RVA: 0x00042795 File Offset: 0x00040995
		private static Delegate GetGetClassifierHandler()
		{
			if (IKTypeBaseInvoker.cb_getClassifier == null)
			{
				IKTypeBaseInvoker.cb_getClassifier = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeBaseInvoker.n_GetClassifier));
			}
			return IKTypeBaseInvoker.cb_getClassifier;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000427B9 File Offset: 0x000409B9
		private static IntPtr n_GetClassifier(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Classifier);
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x000427D0 File Offset: 0x000409D0
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

		// Token: 0x060014A1 RID: 5281 RVA: 0x00042821 File Offset: 0x00040A21
		private static Delegate GetIsMarkedNullableHandler()
		{
			if (IKTypeBaseInvoker.cb_isMarkedNullable == null)
			{
				IKTypeBaseInvoker.cb_isMarkedNullable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKTypeBaseInvoker.n_IsMarkedNullable));
			}
			return IKTypeBaseInvoker.cb_isMarkedNullable;
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00042845 File Offset: 0x00040A45
		private static bool n_IsMarkedNullable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKTypeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsMarkedNullable;
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00042854 File Offset: 0x00040A54
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

		// Token: 0x060014A4 RID: 5284 RVA: 0x00042894 File Offset: 0x00040A94
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKTypeBaseInvoker.cb_getAnnotations == null)
			{
				IKTypeBaseInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeBaseInvoker.n_GetAnnotations));
			}
			return IKTypeBaseInvoker.cb_getAnnotations;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000428B8 File Offset: 0x00040AB8
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x000428CC File Offset: 0x00040ACC
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

		// Token: 0x040006AE RID: 1710
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/KTypeBase", typeof(IKTypeBaseInvoker));

		// Token: 0x040006AF RID: 1711
		private IntPtr class_ref;

		// Token: 0x040006B0 RID: 1712
		[Nullable(2)]
		private static Delegate cb_getJavaType;

		// Token: 0x040006B1 RID: 1713
		private IntPtr id_getJavaType;

		// Token: 0x040006B2 RID: 1714
		[Nullable(2)]
		private static Delegate cb_getArguments;

		// Token: 0x040006B3 RID: 1715
		private IntPtr id_getArguments;

		// Token: 0x040006B4 RID: 1716
		[Nullable(2)]
		private static Delegate cb_getClassifier;

		// Token: 0x040006B5 RID: 1717
		private IntPtr id_getClassifier;

		// Token: 0x040006B6 RID: 1718
		[Nullable(2)]
		private static Delegate cb_isMarkedNullable;

		// Token: 0x040006B7 RID: 1719
		private IntPtr id_isMarkedNullable;

		// Token: 0x040006B8 RID: 1720
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x040006B9 RID: 1721
		private IntPtr id_getAnnotations;
	}
}
