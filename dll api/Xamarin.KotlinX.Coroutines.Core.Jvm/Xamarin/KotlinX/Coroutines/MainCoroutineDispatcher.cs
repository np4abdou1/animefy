using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200007A RID: 122
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/MainCoroutineDispatcher", DoNotGenerateAcw = true)]
	public abstract class MainCoroutineDispatcher : CoroutineDispatcher
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00012DA8 File Offset: 0x00010FA8
		internal new static IntPtr class_ref
		{
			get
			{
				return MainCoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00012DCC File Offset: 0x00010FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MainCoroutineDispatcher._members;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00012DD4 File Offset: 0x00010FD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MainCoroutineDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MainCoroutineDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00012E04 File Offset: 0x00011004
		protected MainCoroutineDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00012E10 File Offset: 0x00011010
		[Register(".ctor", "()V", "")]
		public MainCoroutineDispatcher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MainCoroutineDispatcher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MainCoroutineDispatcher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00012E7E File Offset: 0x0001107E
		private static Delegate GetGetImmediateHandler()
		{
			if (MainCoroutineDispatcher.cb_getImmediate == null)
			{
				MainCoroutineDispatcher.cb_getImmediate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MainCoroutineDispatcher.n_GetImmediate));
			}
			return MainCoroutineDispatcher.cb_getImmediate;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00012EA2 File Offset: 0x000110A2
		private static IntPtr n_GetImmediate(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MainCoroutineDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Immediate);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000598 RID: 1432
		public abstract MainCoroutineDispatcher Immediate { [Register("getImmediate", "()Lkotlinx/coroutines/MainCoroutineDispatcher;", "GetGetImmediateHandler")] get; }

		// Token: 0x06000599 RID: 1433 RVA: 0x00012EB8 File Offset: 0x000110B8
		[NullableContext(2)]
		[Register("toStringInternalImpl", "()Ljava/lang/String;", "")]
		protected string ToStringInternalImpl()
		{
			return JNIEnv.GetString(MainCoroutineDispatcher._members.InstanceMethods.InvokeNonvirtualObjectMethod("toStringInternalImpl.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000203 RID: 515
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/MainCoroutineDispatcher", typeof(MainCoroutineDispatcher));

		// Token: 0x04000204 RID: 516
		[Nullable(2)]
		private static Delegate cb_getImmediate;
	}
}
