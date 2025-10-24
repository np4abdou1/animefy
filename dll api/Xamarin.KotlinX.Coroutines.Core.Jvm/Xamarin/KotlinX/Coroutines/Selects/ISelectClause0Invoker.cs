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
	// Token: 0x02000096 RID: 150
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectClause0", DoNotGenerateAcw = true)]
	internal class ISelectClause0Invoker : Java.Lang.Object, ISelectClause0, ISelectClause, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00015988 File Offset: 0x00013B88
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectClause0Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x000159AC File Offset: 0x00013BAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectClause0Invoker._members;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000159B3 File Offset: 0x00013BB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x000159BB File Offset: 0x00013BBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectClause0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000159C7 File Offset: 0x00013BC7
		[NullableContext(2)]
		public static ISelectClause0 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectClause0>(handle, transfer);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000159D0 File Offset: 0x00013BD0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectClause0Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectClause0'.");
			}
			return handle;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000159FB File Offset: 0x00013BFB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00015A2C File Offset: 0x00013C2C
		public ISelectClause0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectClause0Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00015A64 File Offset: 0x00013C64
		private static Delegate GetGetClauseObjectHandler()
		{
			if (ISelectClause0Invoker.cb_getClauseObject == null)
			{
				ISelectClause0Invoker.cb_getClauseObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause0Invoker.n_GetClauseObject));
			}
			return ISelectClause0Invoker.cb_getClauseObject;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00015A88 File Offset: 0x00013C88
		private static IntPtr n_GetClauseObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClauseObject);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00015A9C File Offset: 0x00013C9C
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

		// Token: 0x060006A4 RID: 1700 RVA: 0x00015AED File Offset: 0x00013CED
		private static Delegate GetGetOnCancellationConstructorHandler()
		{
			if (ISelectClause0Invoker.cb_getOnCancellationConstructor == null)
			{
				ISelectClause0Invoker.cb_getOnCancellationConstructor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause0Invoker.n_GetOnCancellationConstructor));
			}
			return ISelectClause0Invoker.cb_getOnCancellationConstructor;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00015B11 File Offset: 0x00013D11
		private static IntPtr n_GetOnCancellationConstructor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCancellationConstructor);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00015B28 File Offset: 0x00013D28
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

		// Token: 0x060006A7 RID: 1703 RVA: 0x00015B79 File Offset: 0x00013D79
		private static Delegate GetGetProcessResFuncHandler()
		{
			if (ISelectClause0Invoker.cb_getProcessResFunc == null)
			{
				ISelectClause0Invoker.cb_getProcessResFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause0Invoker.n_GetProcessResFunc));
			}
			return ISelectClause0Invoker.cb_getProcessResFunc;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00015B9D File Offset: 0x00013D9D
		private static IntPtr n_GetProcessResFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProcessResFunc);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00015BB4 File Offset: 0x00013DB4
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

		// Token: 0x060006AA RID: 1706 RVA: 0x00015C05 File Offset: 0x00013E05
		private static Delegate GetGetRegFuncHandler()
		{
			if (ISelectClause0Invoker.cb_getRegFunc == null)
			{
				ISelectClause0Invoker.cb_getRegFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause0Invoker.n_GetRegFunc));
			}
			return ISelectClause0Invoker.cb_getRegFunc;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00015C29 File Offset: 0x00013E29
		private static IntPtr n_GetRegFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause0>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RegFunc);
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00015C40 File Offset: 0x00013E40
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

		// Token: 0x04000244 RID: 580
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectClause0", typeof(ISelectClause0Invoker));

		// Token: 0x04000245 RID: 581
		private IntPtr class_ref;

		// Token: 0x04000246 RID: 582
		[Nullable(2)]
		private static Delegate cb_getClauseObject;

		// Token: 0x04000247 RID: 583
		private IntPtr id_getClauseObject;

		// Token: 0x04000248 RID: 584
		[Nullable(2)]
		private static Delegate cb_getOnCancellationConstructor;

		// Token: 0x04000249 RID: 585
		private IntPtr id_getOnCancellationConstructor;

		// Token: 0x0400024A RID: 586
		[Nullable(2)]
		private static Delegate cb_getProcessResFunc;

		// Token: 0x0400024B RID: 587
		private IntPtr id_getProcessResFunc;

		// Token: 0x0400024C RID: 588
		[Nullable(2)]
		private static Delegate cb_getRegFunc;

		// Token: 0x0400024D RID: 589
		private IntPtr id_getRegFunc;
	}
}
