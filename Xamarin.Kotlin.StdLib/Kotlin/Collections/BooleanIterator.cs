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
	// Token: 0x020002BD RID: 701
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/BooleanIterator", DoNotGenerateAcw = true)]
	public abstract class BooleanIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000A16D4 File Offset: 0x0009F8D4
		internal static IntPtr class_ref
		{
			get
			{
				return BooleanIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000A16F8 File Offset: 0x0009F8F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BooleanIterator._members;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060025EB RID: 9707 RVA: 0x000A1700 File Offset: 0x0009F900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BooleanIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000A1724 File Offset: 0x0009F924
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BooleanIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000A1730 File Offset: 0x0009F930
		protected BooleanIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000A173C File Offset: 0x0009F93C
		[Register(".ctor", "()V", "")]
		public BooleanIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BooleanIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BooleanIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000A17AC File Offset: 0x0009F9AC
		[Register("next", "()Ljava/lang/Boolean;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BooleanIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Boolean;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000A17DE File Offset: 0x0009F9DE
		private static Delegate GetNextBooleanHandler()
		{
			if (BooleanIterator.cb_nextBoolean == null)
			{
				BooleanIterator.cb_nextBoolean = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BooleanIterator.n_NextBoolean));
			}
			return BooleanIterator.cb_nextBoolean;
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000A1802 File Offset: 0x0009FA02
		private static bool n_NextBoolean(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BooleanIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextBoolean();
		}

		// Token: 0x060025F2 RID: 9714
		[Register("nextBoolean", "()Z", "GetNextBooleanHandler")]
		public abstract bool NextBoolean();

		// Token: 0x060025F3 RID: 9715 RVA: 0x000A1811 File Offset: 0x0009FA11
		private static Delegate GetRemoveHandler()
		{
			if (BooleanIterator.cb_remove == null)
			{
				BooleanIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BooleanIterator.n_Remove));
			}
			return BooleanIterator.cb_remove;
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000A1835 File Offset: 0x0009FA35
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BooleanIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000A1844 File Offset: 0x0009FA44
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			BooleanIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000A185D File Offset: 0x0009FA5D
		private static Delegate GetGetHasNextHandler()
		{
			if (BooleanIterator.cb_hasNext == null)
			{
				BooleanIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BooleanIterator.n_GetHasNext));
			}
			return BooleanIterator.cb_hasNext;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000A1881 File Offset: 0x0009FA81
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BooleanIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060025F8 RID: 9720
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x0400098F RID: 2447
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/BooleanIterator", typeof(BooleanIterator));

		// Token: 0x04000990 RID: 2448
		[Nullable(2)]
		private static Delegate cb_nextBoolean;

		// Token: 0x04000991 RID: 2449
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x04000992 RID: 2450
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
