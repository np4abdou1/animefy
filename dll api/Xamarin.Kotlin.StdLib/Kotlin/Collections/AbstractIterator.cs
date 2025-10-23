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
	// Token: 0x020002AD RID: 685
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractIterator", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class AbstractIterator : Java.Lang.Object, IIterator, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0006A338 File Offset: 0x00068538
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0006A35C File Offset: 0x0006855C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractIterator._members;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0006A364 File Offset: 0x00068564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractIterator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0006A388 File Offset: 0x00068588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractIterator._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0006A394 File Offset: 0x00068594
		protected AbstractIterator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0006A3A0 File Offset: 0x000685A0
		[Register(".ctor", "()V", "")]
		public AbstractIterator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractIterator._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractIterator._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x0006A40E File Offset: 0x0006860E
		private static Delegate GetHasNextHandler()
		{
			if (AbstractIterator.cb_hasNext == null)
			{
				AbstractIterator.cb_hasNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AbstractIterator.n_HasNext));
			}
			return AbstractIterator.cb_hasNext;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0006A432 File Offset: 0x00068632
		private static bool n_HasNext(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AbstractIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNext;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0006A441 File Offset: 0x00068641
		public virtual bool HasNext
		{
			[Register("hasNext", "()Z", "GetHasNextHandler")]
			get
			{
				return AbstractIterator._members.InstanceMethods.InvokeVirtualBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0006A45A File Offset: 0x0006865A
		private static Delegate GetComputeNextHandler()
		{
			if (AbstractIterator.cb_computeNext == null)
			{
				AbstractIterator.cb_computeNext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractIterator.n_ComputeNext));
			}
			return AbstractIterator.cb_computeNext;
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0006A47E File Offset: 0x0006867E
		private static void n_ComputeNext(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeNext();
		}

		// Token: 0x06001FBC RID: 8124
		[Register("computeNext", "()V", "GetComputeNextHandler")]
		protected abstract void ComputeNext();

		// Token: 0x06001FBD RID: 8125 RVA: 0x0006A48D File Offset: 0x0006868D
		[Register("done", "()V", "")]
		protected void Done()
		{
			AbstractIterator._members.InstanceMethods.InvokeNonvirtualVoidMethod("done.()V", this, null);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0006A4A6 File Offset: 0x000686A6
		private static Delegate GetNextHandler()
		{
			if (AbstractIterator.cb_next == null)
			{
				AbstractIterator.cb_next = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractIterator.n_Next));
			}
			return AbstractIterator.cb_next;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0006A4CA File Offset: 0x000686CA
		private static IntPtr n_Next(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Next());
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0006A4E0 File Offset: 0x000686E0
		[NullableContext(2)]
		[Register("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual Java.Lang.Object Next()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractIterator._members.InstanceMethods.InvokeVirtualObjectMethod("next.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0006A512 File Offset: 0x00068712
		private static Delegate GetRemoveHandler()
		{
			if (AbstractIterator.cb_remove == null)
			{
				AbstractIterator.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbstractIterator.n_Remove));
			}
			return AbstractIterator.cb_remove;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0006A536 File Offset: 0x00068736
		private static void n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbstractIterator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove();
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0006A545 File Offset: 0x00068745
		[Register("remove", "()V", "GetRemoveHandler")]
		public virtual void Remove()
		{
			AbstractIterator._members.InstanceMethods.InvokeVirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0006A560 File Offset: 0x00068760
		[NullableContext(2)]
		[Register("setNext", "(Ljava/lang/Object;)V", "")]
		protected unsafe void SetNext(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AbstractIterator._members.InstanceMethods.InvokeNonvirtualVoidMethod("setNext.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x04000958 RID: 2392
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractIterator", typeof(AbstractIterator));

		// Token: 0x04000959 RID: 2393
		[Nullable(2)]
		private static Delegate cb_hasNext;

		// Token: 0x0400095A RID: 2394
		[Nullable(2)]
		private static Delegate cb_computeNext;

		// Token: 0x0400095B RID: 2395
		[Nullable(2)]
		private static Delegate cb_next;

		// Token: 0x0400095C RID: 2396
		[Nullable(2)]
		private static Delegate cb_remove;

		// Token: 0x02000302 RID: 770
		[Nullable(0)]
		[Register("kotlin/collections/AbstractIterator$WhenMappings", DoNotGenerateAcw = true)]
		public sealed class WhenMappings : Java.Lang.Object
		{
			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000BAF28 File Offset: 0x000B9128
			internal static IntPtr class_ref
			{
				get
				{
					return AbstractIterator.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AB1 RID: 2737
			// (get) Token: 0x06002A87 RID: 10887 RVA: 0x000BAF4C File Offset: 0x000B914C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AbstractIterator.WhenMappings._members;
				}
			}

			// Token: 0x17000AB2 RID: 2738
			// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000BAF54 File Offset: 0x000B9154
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AbstractIterator.WhenMappings._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AB3 RID: 2739
			// (get) Token: 0x06002A89 RID: 10889 RVA: 0x000BAF78 File Offset: 0x000B9178
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AbstractIterator.WhenMappings._members.ManagedPeerType;
				}
			}

			// Token: 0x06002A8A RID: 10890 RVA: 0x000BAF84 File Offset: 0x000B9184
			internal WhenMappings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040009F9 RID: 2553
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractIterator$WhenMappings", typeof(AbstractIterator.WhenMappings));
		}
	}
}
