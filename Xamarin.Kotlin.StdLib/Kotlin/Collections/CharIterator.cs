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
	// Token: 0x020002C1 RID: 705
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/CharIterator", DoNotGenerateAcw = true)]
	public abstract class CharIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000A1B5C File Offset: 0x0009FD5C
		internal static IntPtr class_ref
		{
			get
			{
				return CharIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000A1B80 File Offset: 0x0009FD80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharIterator._members;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x000A1B88 File Offset: 0x0009FD88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000A1BAC File Offset: 0x0009FDAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000A1BB8 File Offset: 0x0009FDB8
		protected CharIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000A1BC4 File Offset: 0x0009FDC4
		[Register(".ctor", "()V", "")]
		public CharIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CharIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CharIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000A1C34 File Offset: 0x0009FE34
		[Register("next", "()Ljava/lang/Character;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(CharIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Character;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000A1C66 File Offset: 0x0009FE66
		private static Delegate GetNextCharHandler()
		{
			if (CharIterator.cb_nextChar == null)
			{
				CharIterator.cb_nextChar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(CharIterator.n_NextChar));
			}
			return CharIterator.cb_nextChar;
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000A1C8A File Offset: 0x0009FE8A
		private static char n_NextChar(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CharIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextChar();
		}

		// Token: 0x06002620 RID: 9760
		[Register("nextChar", "()C", "GetNextCharHandler")]
		public abstract char NextChar();

		// Token: 0x06002621 RID: 9761 RVA: 0x000A1C99 File Offset: 0x0009FE99
		private static Delegate GetRemoveHandler()
		{
			if (CharIterator.cb_remove == null)
			{
				CharIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CharIterator.n_Remove));
			}
			return CharIterator.cb_remove;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000A1CBD File Offset: 0x0009FEBD
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CharIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000A1CCC File Offset: 0x0009FECC
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			CharIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000A1CE5 File Offset: 0x0009FEE5
		private static Delegate GetGetHasNextHandler()
		{
			if (CharIterator.cb_hasNext == null)
			{
				CharIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(CharIterator.n_GetHasNext));
			}
			return CharIterator.cb_hasNext;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000A1D09 File Offset: 0x0009FF09
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<CharIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002626 RID: 9766
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x04000999 RID: 2457
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/CharIterator", typeof(CharIterator));

		// Token: 0x0400099A RID: 2458
		[Nullable(2)]
		private static Delegate cb_nextChar;

		// Token: 0x0400099B RID: 2459
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x0400099C RID: 2460
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
