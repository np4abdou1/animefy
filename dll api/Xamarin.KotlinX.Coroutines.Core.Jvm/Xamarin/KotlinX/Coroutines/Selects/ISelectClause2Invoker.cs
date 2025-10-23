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
	// Token: 0x0200009A RID: 154
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectClause2", DoNotGenerateAcw = true)]
	internal class ISelectClause2Invoker : Java.Lang.Object, ISelectClause2, ISelectClause, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00015FD0 File Offset: 0x000141D0
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectClause2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00015FF4 File Offset: 0x000141F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectClause2Invoker._members;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00015FFB File Offset: 0x000141FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00016003 File Offset: 0x00014203
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectClause2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001600F File Offset: 0x0001420F
		[NullableContext(2)]
		public static ISelectClause2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectClause2>(handle, transfer);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00016018 File Offset: 0x00014218
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectClause2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectClause2'.");
			}
			return handle;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00016043 File Offset: 0x00014243
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00016074 File Offset: 0x00014274
		public ISelectClause2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectClause2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000160AC File Offset: 0x000142AC
		private static Delegate GetGetClauseObjectHandler()
		{
			if (ISelectClause2Invoker.cb_getClauseObject == null)
			{
				ISelectClause2Invoker.cb_getClauseObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause2Invoker.n_GetClauseObject));
			}
			return ISelectClause2Invoker.cb_getClauseObject;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000160D0 File Offset: 0x000142D0
		private static IntPtr n_GetClauseObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClauseObject);
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000160E4 File Offset: 0x000142E4
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

		// Token: 0x060006CE RID: 1742 RVA: 0x00016135 File Offset: 0x00014335
		private static Delegate GetGetOnCancellationConstructorHandler()
		{
			if (ISelectClause2Invoker.cb_getOnCancellationConstructor == null)
			{
				ISelectClause2Invoker.cb_getOnCancellationConstructor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause2Invoker.n_GetOnCancellationConstructor));
			}
			return ISelectClause2Invoker.cb_getOnCancellationConstructor;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00016159 File Offset: 0x00014359
		private static IntPtr n_GetOnCancellationConstructor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCancellationConstructor);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00016170 File Offset: 0x00014370
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

		// Token: 0x060006D1 RID: 1745 RVA: 0x000161C1 File Offset: 0x000143C1
		private static Delegate GetGetProcessResFuncHandler()
		{
			if (ISelectClause2Invoker.cb_getProcessResFunc == null)
			{
				ISelectClause2Invoker.cb_getProcessResFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause2Invoker.n_GetProcessResFunc));
			}
			return ISelectClause2Invoker.cb_getProcessResFunc;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000161E5 File Offset: 0x000143E5
		private static IntPtr n_GetProcessResFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProcessResFunc);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x000161FC File Offset: 0x000143FC
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

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001624D File Offset: 0x0001444D
		private static Delegate GetGetRegFuncHandler()
		{
			if (ISelectClause2Invoker.cb_getRegFunc == null)
			{
				ISelectClause2Invoker.cb_getRegFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClause2Invoker.n_GetRegFunc));
			}
			return ISelectClause2Invoker.cb_getRegFunc;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00016271 File Offset: 0x00014471
		private static IntPtr n_GetRegFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RegFunc);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00016288 File Offset: 0x00014488
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

		// Token: 0x04000258 RID: 600
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectClause2", typeof(ISelectClause2Invoker));

		// Token: 0x04000259 RID: 601
		private IntPtr class_ref;

		// Token: 0x0400025A RID: 602
		[Nullable(2)]
		private static Delegate cb_getClauseObject;

		// Token: 0x0400025B RID: 603
		private IntPtr id_getClauseObject;

		// Token: 0x0400025C RID: 604
		[Nullable(2)]
		private static Delegate cb_getOnCancellationConstructor;

		// Token: 0x0400025D RID: 605
		private IntPtr id_getOnCancellationConstructor;

		// Token: 0x0400025E RID: 606
		[Nullable(2)]
		private static Delegate cb_getProcessResFunc;

		// Token: 0x0400025F RID: 607
		private IntPtr id_getProcessResFunc;

		// Token: 0x04000260 RID: 608
		[Nullable(2)]
		private static Delegate cb_getRegFunc;

		// Token: 0x04000261 RID: 609
		private IntPtr id_getRegFunc;
	}
}
