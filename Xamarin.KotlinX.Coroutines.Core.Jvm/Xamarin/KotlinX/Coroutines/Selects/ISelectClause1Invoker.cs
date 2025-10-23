using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectClause1", DoNotGenerateAcw = true)]
	internal class ISelectClause1Invoker : Java.Lang.Object, ISelectClause1, ISelectClause, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00015CAC File Offset: 0x00013EAC
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectClause1Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00015CD0 File Offset: 0x00013ED0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectClause1Invoker._members;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00015CD7 File Offset: 0x00013ED7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00015CDF File Offset: 0x00013EDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectClause1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00015CEB File Offset: 0x00013EEB
		[NullableContext(2)]
		public static ISelectClause1 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectClause1>(handle, transfer);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00015CF4 File Offset: 0x00013EF4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectClause1Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectClause1'.");
			}
			return handle;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00015D1F File Offset: 0x00013F1F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00015D50 File Offset: 0x00013F50
		public ISelectClause1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectClause1Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00015D88 File Offset: 0x00013F88
		private static Delegate GetGetClauseObjectHandler()
		{
			if (ISelectClause1Invoker.cb_getClauseObject == null)
			{
				ISelectClause1Invoker.cb_getClauseObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause1Invoker.n_GetClauseObject));
			}
			return ISelectClause1Invoker.cb_getClauseObject;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00015DAC File Offset: 0x00013FAC
		private static IntPtr n_GetClauseObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClauseObject);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00015DC0 File Offset: 0x00013FC0
		public Java.Lang.Object ClauseObject
		{
			get
			{
				if (this.id_getClauseObject == IntPtr.Zero)
				{
					this.id_getClauseObject = JNIEnv.GetMethodID(this.class_ref, "getClauseObject", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getClauseObject), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00015E11 File Offset: 0x00014011
		private static Delegate GetGetOnCancellationConstructorHandler()
		{
			if (ISelectClause1Invoker.cb_getOnCancellationConstructor == null)
			{
				ISelectClause1Invoker.cb_getOnCancellationConstructor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause1Invoker.n_GetOnCancellationConstructor));
			}
			return ISelectClause1Invoker.cb_getOnCancellationConstructor;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00015E35 File Offset: 0x00014035
		private static IntPtr n_GetOnCancellationConstructor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCancellationConstructor);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00015E4C File Offset: 0x0001404C
		[Nullable(2)]
		public IFunction3 OnCancellationConstructor
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getOnCancellationConstructor == IntPtr.Zero)
				{
					this.id_getOnCancellationConstructor = JNIEnv.GetMethodID(this.class_ref, "getOnCancellationConstructor", "()Lkotlin/jvm/functions/Function3;");
				}
				return Java.Lang.Object.GetObject<IFunction3>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnCancellationConstructor), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00015E9D File Offset: 0x0001409D
		private static Delegate GetGetProcessResFuncHandler()
		{
			if (ISelectClause1Invoker.cb_getProcessResFunc == null)
			{
				ISelectClause1Invoker.cb_getProcessResFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause1Invoker.n_GetProcessResFunc));
			}
			return ISelectClause1Invoker.cb_getProcessResFunc;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00015EC1 File Offset: 0x000140C1
		private static IntPtr n_GetProcessResFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProcessResFunc);
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00015ED8 File Offset: 0x000140D8
		public IFunction3 ProcessResFunc
		{
			get
			{
				if (this.id_getProcessResFunc == IntPtr.Zero)
				{
					this.id_getProcessResFunc = JNIEnv.GetMethodID(this.class_ref, "getProcessResFunc", "()Lkotlin/jvm/functions/Function3;");
				}
				return Java.Lang.Object.GetObject<IFunction3>(JNIEnv.CallObjectMethod(base.Handle, this.id_getProcessResFunc), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00015F29 File Offset: 0x00014129
		private static Delegate GetGetRegFuncHandler()
		{
			if (ISelectClause1Invoker.cb_getRegFunc == null)
			{
				ISelectClause1Invoker.cb_getRegFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause1Invoker.n_GetRegFunc));
			}
			return ISelectClause1Invoker.cb_getRegFunc;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00015F4D File Offset: 0x0001414D
		private static IntPtr n_GetRegFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RegFunc);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00015F64 File Offset: 0x00014164
		public IFunction3 RegFunc
		{
			get
			{
				if (this.id_getRegFunc == IntPtr.Zero)
				{
					this.id_getRegFunc = JNIEnv.GetMethodID(this.class_ref, "getRegFunc", "()Lkotlin/jvm/functions/Function3;");
				}
				return Java.Lang.Object.GetObject<IFunction3>(JNIEnv.CallObjectMethod(base.Handle, this.id_getRegFunc), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400024E RID: 590
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectClause1", typeof(ISelectClause1Invoker));

		// Token: 0x0400024F RID: 591
		private IntPtr class_ref;

		// Token: 0x04000250 RID: 592
		[Nullable(2)]
		private static Delegate cb_getClauseObject;

		// Token: 0x04000251 RID: 593
		private IntPtr id_getClauseObject;

		// Token: 0x04000252 RID: 594
		[Nullable(2)]
		private static Delegate cb_getOnCancellationConstructor;

		// Token: 0x04000253 RID: 595
		private IntPtr id_getOnCancellationConstructor;

		// Token: 0x04000254 RID: 596
		[Nullable(2)]
		private static Delegate cb_getProcessResFunc;

		// Token: 0x04000255 RID: 597
		private IntPtr id_getProcessResFunc;

		// Token: 0x04000256 RID: 598
		[Nullable(2)]
		private static Delegate cb_getRegFunc;

		// Token: 0x04000257 RID: 599
		private IntPtr id_getRegFunc;
	}
}
