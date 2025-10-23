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
	// Token: 0x020002C6 RID: 710
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/FloatIterator", DoNotGenerateAcw = true)]
	public abstract class FloatIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000AB778 File Offset: 0x000A9978
		internal static IntPtr class_ref
		{
			get
			{
				return FloatIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000AB79C File Offset: 0x000A999C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FloatIterator._members;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AB7A4 File Offset: 0x000A99A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FloatIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000AB7C8 File Offset: 0x000A99C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FloatIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000AB7D4 File Offset: 0x000A99D4
		protected FloatIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000AB7E0 File Offset: 0x000A99E0
		[Register(".ctor", "()V", "")]
		public FloatIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FloatIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FloatIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000AB850 File Offset: 0x000A9A50
		[Register("next", "()Ljava/lang/Float;", "")]
		public Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(FloatIterator._members.InstanceMethods.InvokeNonvirtualObjectMethod("next.()Ljava/lang/Float;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000AB882 File Offset: 0x000A9A82
		private static Delegate GetNextFloatHandler()
		{
			if (FloatIterator.cb_nextFloat == null)
			{
				FloatIterator.cb_nextFloat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(FloatIterator.n_NextFloat));
			}
			return FloatIterator.cb_nextFloat;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000AB8A6 File Offset: 0x000A9AA6
		private static float n_NextFloat(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextFloat();
		}

		// Token: 0x06002758 RID: 10072
		[Register("nextFloat", "()F", "GetNextFloatHandler")]
		public abstract float NextFloat();

		// Token: 0x06002759 RID: 10073 RVA: 0x000AB8B5 File Offset: 0x000A9AB5
		private static Delegate GetRemoveHandler()
		{
			if (FloatIterator.cb_remove == null)
			{
				FloatIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FloatIterator.n_Remove));
			}
			return FloatIterator.cb_remove;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000AB8D9 File Offset: 0x000A9AD9
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FloatIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000AB8E8 File Offset: 0x000A9AE8
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			FloatIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000AB901 File Offset: 0x000A9B01
		private static Delegate GetGetHasNextHandler()
		{
			if (FloatIterator.cb_hasNext == null)
			{
				FloatIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(FloatIterator.n_GetHasNext));
			}
			return FloatIterator.cb_hasNext;
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000AB925 File Offset: 0x000A9B25
		private static bool n_GetHasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<FloatIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600275E RID: 10078
		public abstract bool HasNext { [Register("hasNext", "()Z", "GetGetHasNextHandler")] get; }

		// Token: 0x040009A4 RID: 2468
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/FloatIterator", typeof(FloatIterator));

		// Token: 0x040009A5 RID: 2469
		[Nullable(2)]
		private static Delegate cb_nextFloat;

		// Token: 0x040009A6 RID: 2470
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x040009A7 RID: 2471
		[Nullable(2)]
		private static Delegate cb_hasNext;
	}
}
