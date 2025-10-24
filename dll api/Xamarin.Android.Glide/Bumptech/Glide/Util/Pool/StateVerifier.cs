using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util.Pool
{
	// Token: 0x02000058 RID: 88
	[Register("com/bumptech/glide/util/pool/StateVerifier", DoNotGenerateAcw = true)]
	public abstract class StateVerifier : Java.Lang.Object
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		internal static IntPtr class_ref
		{
			get
			{
				return StateVerifier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StateVerifier._members;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StateVerifier._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StateVerifier._members.ManagedPeerType;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		protected StateVerifier(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		[Register("newInstance", "()Lcom/bumptech/glide/util/pool/StateVerifier;", "")]
		public static StateVerifier NewInstance()
		{
			return Java.Lang.Object.GetObject<StateVerifier>(StateVerifier._members.StaticMethods.InvokeObjectMethod("newInstance.()Lcom/bumptech/glide/util/pool/StateVerifier;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000DC15 File Offset: 0x0000BE15
		private static Delegate GetThrowIfRecycledHandler()
		{
			if (StateVerifier.cb_throwIfRecycled == null)
			{
				StateVerifier.cb_throwIfRecycled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StateVerifier.n_ThrowIfRecycled));
			}
			return StateVerifier.cb_throwIfRecycled;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000DC39 File Offset: 0x0000BE39
		private static void n_ThrowIfRecycled(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StateVerifier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThrowIfRecycled();
		}

		// Token: 0x0600040A RID: 1034
		[Register("throwIfRecycled", "()V", "GetThrowIfRecycledHandler")]
		public abstract void ThrowIfRecycled();

		// Token: 0x040000D4 RID: 212
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/StateVerifier", typeof(StateVerifier));

		// Token: 0x040000D5 RID: 213
		private static Delegate cb_throwIfRecycled;
	}
}
