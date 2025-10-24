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
	// Token: 0x020002CE RID: 718
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/LongIterator", DoNotGenerateAcw = true)]
	public abstract class LongIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x000AC8C8 File Offset: 0x000AAAC8
		internal static IntPtr class_ref
		{
			get
			{
				return LongIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000AC8EC File Offset: 0x000AAAEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongIterator._members;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x000AC8F4 File Offset: 0x000AAAF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LongIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000AC918 File Offset: 0x000AAB18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000AC924 File Offset: 0x000AAB24
		protected LongIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000AC930 File Offset: 0x000AAB30
		[Register(".ctor", "()V", "")]
		public LongIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LongIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LongIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000AC9A0 File Offset: 0x000AABA0
		[Register("next", "()Ljava/lang/Long;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LongIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000AC9D2 File Offset: 0x000AABD2
		private static Delegate GetNextLongHandler()
		{
			if (LongIterator.cb_nextLong == null)
			{
				LongIterator.cb_nextLong = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LongIterator.n_NextLong));
			}
			return LongIterator.cb_nextLong;
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000AC9F6 File Offset: 0x000AABF6
		private static long n_NextLong(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LongIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextLong();
		}

		// Token: 0x060027B3 RID: 10163
		[Register("nextLong", "()J", "GetNextLongHandler")]
		public abstract long NextLong();

		// Token: 0x060027B4 RID: 10164 RVA: 0x000ACA05 File Offset: 0x000AAC05
		private static Delegate GetRemoveHandler()
		{
			if (LongIterator.cb_remove == null)
			{
				LongIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LongIterator.n_Remove));
			}
			return LongIterator.cb_remove;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000ACA29 File Offset: 0x000AAC29
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LongIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000ACA38 File Offset: 0x000AAC38
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			LongIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000ACA51 File Offset: 0x000AAC51
		private static Delegate GetGetHasNextHandler()
		{
			if (LongIterator.cb_hasNext == null)
			{
				LongIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(LongIterator.n_GetHasNext));
			}
			return LongIterator.cb_hasNext;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x000ACA75 File Offset: 0x000AAC75
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LongIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060027B9 RID: 10169
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x040009B6 RID: 2486
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/LongIterator", typeof(LongIterator));

		// Token: 0x040009B7 RID: 2487
		[Nullable(2)]
		private static Delegate cb_nextLong;

		// Token: 0x040009B8 RID: 2488
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x040009B9 RID: 2489
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
