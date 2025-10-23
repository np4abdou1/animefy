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
	// Token: 0x020002C4 RID: 708
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/DoubleIterator", DoNotGenerateAcw = true)]
	public abstract class DoubleIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x000AB534 File Offset: 0x000A9734
		internal static IntPtr class_ref
		{
			get
			{
				return DoubleIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x000AB558 File Offset: 0x000A9758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DoubleIterator._members;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x000AB560 File Offset: 0x000A9760
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DoubleIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x000AB584 File Offset: 0x000A9784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DoubleIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000AB590 File Offset: 0x000A9790
		protected DoubleIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000AB59C File Offset: 0x000A979C
		[Register(".ctor", "()V", "")]
		public DoubleIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DoubleIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DoubleIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000AB60C File Offset: 0x000A980C
		[Register("next", "()Ljava/lang/Double;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(DoubleIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Double;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000AB63E File Offset: 0x000A983E
		private static Delegate GetNextDoubleHandler()
		{
			if (DoubleIterator.cb_nextDouble == null)
			{
				DoubleIterator.cb_nextDouble = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(DoubleIterator.n_NextDouble));
			}
			return DoubleIterator.cb_nextDouble;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000AB662 File Offset: 0x000A9862
		private static double n_NextDouble(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DoubleIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDouble();
		}

		// Token: 0x06002741 RID: 10049
		[Register("nextDouble", "()D", "GetNextDoubleHandler")]
		public abstract double NextDouble();

		// Token: 0x06002742 RID: 10050 RVA: 0x000AB671 File Offset: 0x000A9871
		private static Delegate GetRemoveHandler()
		{
			if (DoubleIterator.cb_remove == null)
			{
				DoubleIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DoubleIterator.n_Remove));
			}
			return DoubleIterator.cb_remove;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000AB695 File Offset: 0x000A9895
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DoubleIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000AB6A4 File Offset: 0x000A98A4
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			DoubleIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000AB6BD File Offset: 0x000A98BD
		private static Delegate GetGetHasNextHandler()
		{
			if (DoubleIterator.cb_hasNext == null)
			{
				DoubleIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DoubleIterator.n_GetHasNext));
			}
			return DoubleIterator.cb_hasNext;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000AB6E1 File Offset: 0x000A98E1
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DoubleIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06002747 RID: 10055
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x0400099F RID: 2463
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/DoubleIterator", typeof(DoubleIterator));

		// Token: 0x040009A0 RID: 2464
		[Nullable(2)]
		private static Delegate cb_nextDouble;

		// Token: 0x040009A1 RID: 2465
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x040009A2 RID: 2466
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
