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
	// Token: 0x0200011E RID: 286
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KParameter", DoNotGenerateAcw = true)]
	internal class IKParameterInvoker : Java.Lang.Object, IKParameter, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00030ED8 File Offset: 0x0002F0D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IKParameterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00030EFC File Offset: 0x0002F0FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKParameterInvoker._members;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00030F03 File Offset: 0x0002F103
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00030F0B File Offset: 0x0002F10B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKParameterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00030F17 File Offset: 0x0002F117
		[NullableContext(2)]
		public static IKParameter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKParameter>(handle, transfer);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00030F20 File Offset: 0x0002F120
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKParameterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KParameter'.");
			}
			return handle;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00030F4B File Offset: 0x0002F14B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00030F7C File Offset: 0x0002F17C
		public IKParameterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKParameterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		private static Delegate GetGetIndexHandler()
		{
			if (IKParameterInvoker.cb_getIndex == null)
			{
				IKParameterInvoker.cb_getIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IKParameterInvoker.n_GetIndex));
			}
			return IKParameterInvoker.cb_getIndex;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		private static int n_GetIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Index;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00030FE7 File Offset: 0x0002F1E7
		public int Index
		{
			get
			{
				if (this.id_getIndex == IntPtr.Zero)
				{
					this.id_getIndex = JNIEnv.GetMethodID(this.class_ref, "getIndex", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getIndex);
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00031027 File Offset: 0x0002F227
		private static Delegate GetIsOptionalHandler()
		{
			if (IKParameterInvoker.cb_isOptional == null)
			{
				IKParameterInvoker.cb_isOptional = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKParameterInvoker.n_IsOptional));
			}
			return IKParameterInvoker.cb_isOptional;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0003104B File Offset: 0x0002F24B
		private static bool n_IsOptional(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOptional;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x0003105A File Offset: 0x0002F25A
		public bool IsOptional
		{
			get
			{
				if (this.id_isOptional == IntPtr.Zero)
				{
					this.id_isOptional = JNIEnv.GetMethodID(this.class_ref, "isOptional", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isOptional);
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0003109A File Offset: 0x0002F29A
		private static Delegate GetIsVarargHandler()
		{
			if (IKParameterInvoker.cb_isVararg == null)
			{
				IKParameterInvoker.cb_isVararg = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKParameterInvoker.n_IsVararg));
			}
			return IKParameterInvoker.cb_isVararg;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000310BE File Offset: 0x0002F2BE
		private static bool n_IsVararg(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVararg;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000310CD File Offset: 0x0002F2CD
		public bool IsVararg
		{
			get
			{
				if (this.id_isVararg == IntPtr.Zero)
				{
					this.id_isVararg = JNIEnv.GetMethodID(this.class_ref, "isVararg", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isVararg);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0003110D File Offset: 0x0002F30D
		private static Delegate GetGetKindHandler()
		{
			if (IKParameterInvoker.cb_getKind == null)
			{
				IKParameterInvoker.cb_getKind = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKParameterInvoker.n_GetKind));
			}
			return IKParameterInvoker.cb_getKind;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00031131 File Offset: 0x0002F331
		private static IntPtr n_GetKind(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Kind);
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00031148 File Offset: 0x0002F348
		public KParameterKind Kind
		{
			get
			{
				if (this.id_getKind == IntPtr.Zero)
				{
					this.id_getKind = JNIEnv.GetMethodID(this.class_ref, "getKind", "()Lkotlin/reflect/KParameter$Kind;");
				}
				return Java.Lang.Object.GetObject<KParameterKind>(JNIEnv.CallObjectMethod(base.Handle, this.id_getKind), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00031199 File Offset: 0x0002F399
		private static Delegate GetGetNameHandler()
		{
			if (IKParameterInvoker.cb_getName == null)
			{
				IKParameterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKParameterInvoker.n_GetName));
			}
			return IKParameterInvoker.cb_getName;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000311BD File Offset: 0x0002F3BD
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000311D4 File Offset: 0x0002F3D4
		[Nullable(2)]
		public string Name
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00031225 File Offset: 0x0002F425
		private static Delegate GetGetTypeHandler()
		{
			if (IKParameterInvoker.cb_getType == null)
			{
				IKParameterInvoker.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKParameterInvoker.n_GetType));
			}
			return IKParameterInvoker.cb_getType;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00031249 File Offset: 0x0002F449
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00031260 File Offset: 0x0002F460
		public IKType Type
		{
			get
			{
				if (this.id_getType == IntPtr.Zero)
				{
					this.id_getType = JNIEnv.GetMethodID(this.class_ref, "getType", "()Lkotlin/reflect/KType;");
				}
				return Java.Lang.Object.GetObject<IKType>(JNIEnv.CallObjectMethod(base.Handle, this.id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000312B1 File Offset: 0x0002F4B1
		private static Delegate GetGetAnnotationsHandler()
		{
			if (IKParameterInvoker.cb_getAnnotations == null)
			{
				IKParameterInvoker.cb_getAnnotations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKParameterInvoker.n_GetAnnotations));
			}
			return IKParameterInvoker.cb_getAnnotations;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000312D5 File Offset: 0x0002F4D5
		private static IntPtr n_GetAnnotations(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IAnnotation>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Annotations);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000312EC File Offset: 0x0002F4EC
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

		// Token: 0x04000419 RID: 1049
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KParameter", typeof(IKParameterInvoker));

		// Token: 0x0400041A RID: 1050
		private IntPtr class_ref;

		// Token: 0x0400041B RID: 1051
		[Nullable(2)]
		private static Delegate cb_getIndex;

		// Token: 0x0400041C RID: 1052
		private IntPtr id_getIndex;

		// Token: 0x0400041D RID: 1053
		[Nullable(2)]
		private static Delegate cb_isOptional;

		// Token: 0x0400041E RID: 1054
		private IntPtr id_isOptional;

		// Token: 0x0400041F RID: 1055
		[Nullable(2)]
		private static Delegate cb_isVararg;

		// Token: 0x04000420 RID: 1056
		private IntPtr id_isVararg;

		// Token: 0x04000421 RID: 1057
		[Nullable(2)]
		private static Delegate cb_getKind;

		// Token: 0x04000422 RID: 1058
		private IntPtr id_getKind;

		// Token: 0x04000423 RID: 1059
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000424 RID: 1060
		private IntPtr id_getName;

		// Token: 0x04000425 RID: 1061
		[Nullable(2)]
		private static Delegate cb_getType;

		// Token: 0x04000426 RID: 1062
		private IntPtr id_getType;

		// Token: 0x04000427 RID: 1063
		[Nullable(2)]
		private static Delegate cb_getAnnotations;

		// Token: 0x04000428 RID: 1064
		private IntPtr id_getAnnotations;
	}
}
