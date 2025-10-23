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
	// Token: 0x020002BF RID: 703
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/ByteIterator", DoNotGenerateAcw = true)]
	public abstract class ByteIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000A1918 File Offset: 0x0009FB18
		internal static IntPtr class_ref
		{
			get
			{
				return ByteIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000A193C File Offset: 0x0009FB3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteIterator._members;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000A1944 File Offset: 0x0009FB44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ByteIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A1968 File Offset: 0x0009FB68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x000A1974 File Offset: 0x0009FB74
		protected ByteIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000A1980 File Offset: 0x0009FB80
		[Register(".ctor", "()V", "")]
		public ByteIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ByteIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ByteIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000A19F0 File Offset: 0x0009FBF0
		[Register("next", "()Ljava/lang/Byte;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(ByteIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Byte;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000A1A22 File Offset: 0x0009FC22
		private static Delegate GetNextByteHandler()
		{
			if (ByteIterator.cb_nextByte == null)
			{
				ByteIterator.cb_nextByte = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_B(ByteIterator.n_NextByte));
			}
			return ByteIterator.cb_nextByte;
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000A1A46 File Offset: 0x0009FC46
		private static sbyte n_NextByte(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ByteIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextByte();
		}

		// Token: 0x06002609 RID: 9737
		[Register("nextByte", "()B", "GetNextByteHandler")]
		public abstract sbyte NextByte();

		// Token: 0x0600260A RID: 9738 RVA: 0x000A1A55 File Offset: 0x0009FC55
		private static Delegate GetRemoveHandler()
		{
			if (ByteIterator.cb_remove == null)
			{
				ByteIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ByteIterator.n_Remove));
			}
			return ByteIterator.cb_remove;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000A1A79 File Offset: 0x0009FC79
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ByteIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000A1A88 File Offset: 0x0009FC88
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			ByteIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000A1AA1 File Offset: 0x0009FCA1
		private static Delegate GetGetHasNextHandler()
		{
			if (ByteIterator.cb_hasNext == null)
			{
				ByteIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ByteIterator.n_GetHasNext));
			}
			return ByteIterator.cb_hasNext;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x000A1AC5 File Offset: 0x0009FCC5
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ByteIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x0600260F RID: 9743
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x04000994 RID: 2452
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/ByteIterator", typeof(ByteIterator));

		// Token: 0x04000995 RID: 2453
		[Nullable(2)]
		private static Delegate cb_nextByte;

		// Token: 0x04000996 RID: 2454
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x04000997 RID: 2455
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
