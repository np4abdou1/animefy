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
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectClause", DoNotGenerateAcw = true)]
	internal class ISelectClauseInvoker : Java.Lang.Object, ISelectClause, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00015664 File Offset: 0x00013864
		private static IntPtr java_class_ref
		{
			get
			{
				return ISelectClauseInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00015688 File Offset: 0x00013888
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISelectClauseInvoker._members;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001568F File Offset: 0x0001388F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00015697 File Offset: 0x00013897
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISelectClauseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000156A3 File Offset: 0x000138A3
		[NullableContext(2)]
		public static ISelectClause GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISelectClause>(handle, transfer);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000156AC File Offset: 0x000138AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISelectClauseInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.selects.SelectClause'.");
			}
			return handle;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000156D7 File Offset: 0x000138D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00015708 File Offset: 0x00013908
		public ISelectClauseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISelectClauseInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00015740 File Offset: 0x00013940
		private static Delegate GetGetClauseObjectHandler()
		{
			if (ISelectClauseInvoker.cb_getClauseObject == null)
			{
				ISelectClauseInvoker.cb_getClauseObject = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClauseInvoker.n_GetClauseObject));
			}
			return ISelectClauseInvoker.cb_getClauseObject;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00015764 File Offset: 0x00013964
		private static IntPtr n_GetClauseObject(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClauseObject);
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00015778 File Offset: 0x00013978
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

		// Token: 0x0600068F RID: 1679 RVA: 0x000157C9 File Offset: 0x000139C9
		private static Delegate GetGetOnCancellationConstructorHandler()
		{
			if (ISelectClauseInvoker.cb_getOnCancellationConstructor == null)
			{
				ISelectClauseInvoker.cb_getOnCancellationConstructor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClauseInvoker.n_GetOnCancellationConstructor));
			}
			return ISelectClauseInvoker.cb_getOnCancellationConstructor;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000157ED File Offset: 0x000139ED
		private static IntPtr n_GetOnCancellationConstructor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCancellationConstructor);
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00015804 File Offset: 0x00013A04
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

		// Token: 0x06000692 RID: 1682 RVA: 0x00015855 File Offset: 0x00013A55
		private static Delegate GetGetProcessResFuncHandler()
		{
			if (ISelectClauseInvoker.cb_getProcessResFunc == null)
			{
				ISelectClauseInvoker.cb_getProcessResFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClauseInvoker.n_GetProcessResFunc));
			}
			return ISelectClauseInvoker.cb_getProcessResFunc;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00015879 File Offset: 0x00013A79
		private static IntPtr n_GetProcessResFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProcessResFunc);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00015890 File Offset: 0x00013A90
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

		// Token: 0x06000695 RID: 1685 RVA: 0x000158E1 File Offset: 0x00013AE1
		private static Delegate GetGetRegFuncHandler()
		{
			if (ISelectClauseInvoker.cb_getRegFunc == null)
			{
				ISelectClauseInvoker.cb_getRegFunc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISelectClauseInvoker.n_GetRegFunc));
			}
			return ISelectClauseInvoker.cb_getRegFunc;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00015905 File Offset: 0x00013B05
		private static IntPtr n_GetRegFunc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISelectClause>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RegFunc);
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001591C File Offset: 0x00013B1C
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

		// Token: 0x0400023A RID: 570
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectClause", typeof(ISelectClauseInvoker));

		// Token: 0x0400023B RID: 571
		private IntPtr class_ref;

		// Token: 0x0400023C RID: 572
		[Nullable(2)]
		private static Delegate cb_getClauseObject;

		// Token: 0x0400023D RID: 573
		private IntPtr id_getClauseObject;

		// Token: 0x0400023E RID: 574
		[Nullable(2)]
		private static Delegate cb_getOnCancellationConstructor;

		// Token: 0x0400023F RID: 575
		private IntPtr id_getOnCancellationConstructor;

		// Token: 0x04000240 RID: 576
		[Nullable(2)]
		private static Delegate cb_getProcessResFunc;

		// Token: 0x04000241 RID: 577
		private IntPtr id_getProcessResFunc;

		// Token: 0x04000242 RID: 578
		[Nullable(2)]
		private static Delegate cb_getRegFunc;

		// Token: 0x04000243 RID: 579
		private IntPtr id_getRegFunc;
	}
}
