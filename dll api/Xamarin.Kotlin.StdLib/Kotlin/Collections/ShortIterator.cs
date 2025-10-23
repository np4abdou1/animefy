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
	// Token: 0x020002D3 RID: 723
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/ShortIterator", DoNotGenerateAcw = true)]
	public abstract class ShortIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x000B0174 File Offset: 0x000AE374
		internal static IntPtr class_ref
		{
			get
			{
				return ShortIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000B0198 File Offset: 0x000AE398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShortIterator._members;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x000B01A0 File Offset: 0x000AE3A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShortIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000B01C4 File Offset: 0x000AE3C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShortIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000B01D0 File Offset: 0x000AE3D0
		protected ShortIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000B01DC File Offset: 0x000AE3DC
		[Register(".ctor", "()V", "")]
		public ShortIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ShortIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ShortIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000B024C File Offset: 0x000AE44C
		[Register("next", "()Ljava/lang/Short;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ShortIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Short;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000B027E File Offset: 0x000AE47E
		private static Delegate GetNextShortHandler()
		{
			if (ShortIterator.cb_nextShort == null)
			{
				ShortIterator.cb_nextShort = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_S(ShortIterator.n_NextShort));
			}
			return ShortIterator.cb_nextShort;
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000B02A2 File Offset: 0x000AE4A2
		private static short n_NextShort(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextShort();
		}

		// Token: 0x0600283B RID: 10299
		[Register("nextShort", "()S", "GetNextShortHandler")]
		public abstract short NextShort();

		// Token: 0x0600283C RID: 10300 RVA: 0x000B02B1 File Offset: 0x000AE4B1
		private static Delegate GetRemoveHandler()
		{
			if (ShortIterator.cb_remove == null)
			{
				ShortIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ShortIterator.n_Remove));
			}
			return ShortIterator.cb_remove;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000B02D5 File Offset: 0x000AE4D5
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ShortIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000B02E4 File Offset: 0x000AE4E4
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			ShortIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000B02FD File Offset: 0x000AE4FD
		private static Delegate GetGetHasNextHandler()
		{
			if (ShortIterator.cb_hasNext == null)
			{
				ShortIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ShortIterator.n_GetHasNext));
			}
			return ShortIterator.cb_hasNext;
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000B0321 File Offset: 0x000AE521
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ShortIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002841 RID: 10305
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x040009BE RID: 2494
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/ShortIterator", typeof(ShortIterator));

		// Token: 0x040009BF RID: 2495
		[Nullable(2)]
		private static Delegate cb_nextShort;

		// Token: 0x040009C0 RID: 2496
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x040009C1 RID: 2497
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
