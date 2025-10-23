using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Collections
{
	// Token: 0x020002CC RID: 716
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/IntIterator", DoNotGenerateAcw = true)]
	public abstract class IntIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000AC684 File Offset: 0x000AA884
		internal static IntPtr class_ref
		{
			get
			{
				return IntIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000AC6A8 File Offset: 0x000AA8A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntIterator._members;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000AC6B0 File Offset: 0x000AA8B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000AC6E0 File Offset: 0x000AA8E0
		protected IntIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000AC6EC File Offset: 0x000AA8EC
		[Register(".ctor", "()V", "")]
		public IntIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(IntIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			IntIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000AC75C File Offset: 0x000AA95C
		[Register("next", "()Ljava/lang/Integer;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(IntIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000AC78E File Offset: 0x000AA98E
		private static Delegate GetNextIntHandler()
		{
			if (IntIterator.cb_nextInt == null)
			{
				IntIterator.cb_nextInt = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IntIterator.n_NextInt));
			}
			return IntIterator.cb_nextInt;
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000AC7B2 File Offset: 0x000AA9B2
		private static int n_NextInt(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IntIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextInt();
		}

		// Token: 0x0600279C RID: 10140
		[Register("nextInt", "()I", "GetNextIntHandler")]
		public abstract int NextInt();

		// Token: 0x0600279D RID: 10141 RVA: 0x000AC7C1 File Offset: 0x000AA9C1
		private static Delegate GetRemoveHandler()
		{
			if (IntIterator.cb_remove == null)
			{
				IntIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IntIterator.n_Remove));
			}
			return IntIterator.cb_remove;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000AC7E5 File Offset: 0x000AA9E5
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IntIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000AC7F4 File Offset: 0x000AA9F4
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			IntIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000AC80D File Offset: 0x000AAA0D
		private static Delegate GetGetHasNextHandler()
		{
			if (IntIterator.cb_hasNext == null)
			{
				IntIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IntIterator.n_GetHasNext));
			}
			return IntIterator.cb_hasNext;
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000AC831 File Offset: 0x000AAA31
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IntIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060027A2 RID: 10146
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x040009B1 RID: 2481
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/IntIterator", typeof(IntIterator));

		// Token: 0x040009B2 RID: 2482
		[Nullable(2)]
		private static Delegate cb_nextInt;

		// Token: 0x040009B3 RID: 2483
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x040009B4 RID: 2484
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
