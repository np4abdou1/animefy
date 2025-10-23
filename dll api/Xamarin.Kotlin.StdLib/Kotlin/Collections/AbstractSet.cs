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
	// Token: 0x020002BA RID: 698
	[Register("kotlin/collections/AbstractSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractSet : AbstractCollection, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0006C2DC File Offset: 0x0006A4DC
		internal new static IntPtr class_ref
		{
			get
			{
				return AbstractSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0006C300 File Offset: 0x0006A500
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return AbstractSet._members;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0006C308 File Offset: 0x0006A508
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0006C32C File Offset: 0x0006A52C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return AbstractSet._members.ManagedPeerType;
			}
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x0006C338 File Offset: 0x0006A538
		protected AbstractSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x0006C344 File Offset: 0x0006A544
		[Register(".ctor", "()V", "")]
		protected AbstractSet() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractSet._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractSet._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0006C3B2 File Offset: 0x0006A5B2
		[NullableContext(1)]
		private static Delegate GetIteratorHandler()
		{
			if (AbstractSet.cb_iterator == null)
			{
				AbstractSet.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractSet.n_Iterator));
			}
			return AbstractSet.cb_iterator;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x0006C3D6 File Offset: 0x0006A5D6
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x0006C3EC File Offset: 0x0006A5EC
		[NullableContext(2)]
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractSet._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400098B RID: 2443
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractSet", typeof(AbstractSet));

		// Token: 0x0400098C RID: 2444
		[Nullable(2)]
		private static Delegate cb_iterator;
	}
}
