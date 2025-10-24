using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000136 RID: 310
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KTypeParameter", DoNotGenerateAcw = true)]
	internal class IKTypeParameterInvoker : Java.Lang.Object, IKTypeParameter, IKClassifier, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x00036ED0 File Offset: 0x000350D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IKTypeParameterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00036EF4 File Offset: 0x000350F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IKTypeParameterInvoker._members;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00036EFB File Offset: 0x000350FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00036F03 File Offset: 0x00035103
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IKTypeParameterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00036F0F File Offset: 0x0003510F
		[NullableContext(2)]
		public static IKTypeParameter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKTypeParameter>(handle, transfer);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00036F18 File Offset: 0x00035118
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKTypeParameterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.reflect.KTypeParameter'.");
			}
			return handle;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00036F43 File Offset: 0x00035143
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00036F74 File Offset: 0x00035174
		public IKTypeParameterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKTypeParameterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00036FAC File Offset: 0x000351AC
		private static Delegate GetIsReifiedHandler()
		{
			if (IKTypeParameterInvoker.cb_isReified == null)
			{
				IKTypeParameterInvoker.cb_isReified = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IKTypeParameterInvoker.n_IsReified));
			}
			return IKTypeParameterInvoker.cb_isReified;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00036FD0 File Offset: 0x000351D0
		private static bool n_IsReified(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IKTypeParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReified;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00036FDF File Offset: 0x000351DF
		public bool IsReified
		{
			get
			{
				if (this.id_isReified == IntPtr.Zero)
				{
					this.id_isReified = JNIEnv.GetMethodID(this.class_ref, "isReified", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isReified);
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0003701F File Offset: 0x0003521F
		private static Delegate GetGetNameHandler()
		{
			if (IKTypeParameterInvoker.cb_getName == null)
			{
				IKTypeParameterInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeParameterInvoker.n_GetName));
			}
			return IKTypeParameterInvoker.cb_getName;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00037043 File Offset: 0x00035243
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IKTypeParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00037058 File Offset: 0x00035258
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000370A9 File Offset: 0x000352A9
		private static Delegate GetGetUpperBoundsHandler()
		{
			if (IKTypeParameterInvoker.cb_getUpperBounds == null)
			{
				IKTypeParameterInvoker.cb_getUpperBounds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeParameterInvoker.n_GetUpperBounds));
			}
			return IKTypeParameterInvoker.cb_getUpperBounds;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000370CD File Offset: 0x000352CD
		private static IntPtr n_GetUpperBounds(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IKType>.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UpperBounds);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x000370E4 File Offset: 0x000352E4
		public IList<IKType> UpperBounds
		{
			get
			{
				if (this.id_getUpperBounds == IntPtr.Zero)
				{
					this.id_getUpperBounds = JNIEnv.GetMethodID(this.class_ref, "getUpperBounds", "()Ljava/util/List;");
				}
				return JavaList<IKType>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getUpperBounds), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00037135 File Offset: 0x00035335
		private static Delegate GetGetVarianceHandler()
		{
			if (IKTypeParameterInvoker.cb_getVariance == null)
			{
				IKTypeParameterInvoker.cb_getVariance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IKTypeParameterInvoker.n_GetVariance));
			}
			return IKTypeParameterInvoker.cb_getVariance;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00037159 File Offset: 0x00035359
		private static IntPtr n_GetVariance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IKTypeParameter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Variance);
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00037170 File Offset: 0x00035370
		public KVariance Variance
		{
			get
			{
				if (this.id_getVariance == IntPtr.Zero)
				{
					this.id_getVariance = JNIEnv.GetMethodID(this.class_ref, "getVariance", "()Lkotlin/reflect/KVariance;");
				}
				return Java.Lang.Object.GetObject<KVariance>(JNIEnv.CallObjectMethod(base.Handle, this.id_getVariance), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000561 RID: 1377
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KTypeParameter", typeof(IKTypeParameterInvoker));

		// Token: 0x04000562 RID: 1378
		private IntPtr class_ref;

		// Token: 0x04000563 RID: 1379
		[Nullable(2)]
		private static Delegate cb_isReified;

		// Token: 0x04000564 RID: 1380
		private IntPtr id_isReified;

		// Token: 0x04000565 RID: 1381
		[Nullable(2)]
		private static Delegate cb_getName;

		// Token: 0x04000566 RID: 1382
		private IntPtr id_getName;

		// Token: 0x04000567 RID: 1383
		[Nullable(2)]
		private static Delegate cb_getUpperBounds;

		// Token: 0x04000568 RID: 1384
		private IntPtr id_getUpperBounds;

		// Token: 0x04000569 RID: 1385
		[Nullable(2)]
		private static Delegate cb_getVariance;

		// Token: 0x0400056A RID: 1386
		private IntPtr id_getVariance;
	}
}
