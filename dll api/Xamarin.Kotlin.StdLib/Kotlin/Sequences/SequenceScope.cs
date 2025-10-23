using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Coroutines;

namespace Kotlin.Sequences
{
	// Token: 0x020000F8 RID: 248
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/sequences/SequenceScope", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class SequenceScope : Java.Lang.Object
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00021D48 File Offset: 0x0001FF48
		internal static IntPtr class_ref
		{
			get
			{
				return SequenceScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00021D6C File Offset: 0x0001FF6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SequenceScope._members;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00021D74 File Offset: 0x0001FF74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SequenceScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00021D98 File Offset: 0x0001FF98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SequenceScope._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		protected SequenceScope(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00021DAE File Offset: 0x0001FFAE
		private static Delegate GetYield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler()
		{
			if (SequenceScope.cb_yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ == null)
			{
				SequenceScope.cb_yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SequenceScope.n_Yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_));
			}
			return SequenceScope.cb_yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00021DD4 File Offset: 0x0001FFD4
		private static IntPtr n_Yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_value, IntPtr native_p1)
		{
			SequenceScope @object = Java.Lang.Object.GetObject<SequenceScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Yield(object2, object3));
		}

		// Token: 0x06000A1C RID: 2588
		[NullableContext(2)]
		[Register("yield", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetYield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		public abstract Java.Lang.Object Yield(Java.Lang.Object value, [Nullable(1)] IContinuation p1);

		// Token: 0x06000A1D RID: 2589 RVA: 0x00021E08 File Offset: 0x00020008
		[Register("yieldAll", "(Ljava/lang/Iterable;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe Java.Lang.Object YieldAll(IIterable elements, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((elements == null) ? IntPtr.Zero : ((Java.Lang.Object)elements).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequenceScope._members.InstanceMethods.InvokeNonvirtualObjectMethod("yieldAll.(Ljava/lang/Iterable;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(elements);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00021EB0 File Offset: 0x000200B0
		private static Delegate GetYieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_Handler()
		{
			if (SequenceScope.cb_yieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_ == null)
			{
				SequenceScope.cb_yieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SequenceScope.n_YieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_));
			}
			return SequenceScope.cb_yieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00021ED4 File Offset: 0x000200D4
		private static IntPtr n_YieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_iterator, IntPtr native_p1)
		{
			SequenceScope @object = Java.Lang.Object.GetObject<SequenceScope>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IIterator object2 = Java.Lang.Object.GetObject<IIterator>(native_iterator, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.YieldAll(object2, object3));
		}

		// Token: 0x06000A20 RID: 2592
		[Register("yieldAll", "(Ljava/util/Iterator;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetYieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_Handler")]
		[return: Nullable(2)]
		public abstract Java.Lang.Object YieldAll(IIterator iterator, IContinuation p1);

		// Token: 0x06000A21 RID: 2593 RVA: 0x00021F08 File Offset: 0x00020108
		[Register("yieldAll", "(Lkotlin/sequences/Sequence;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe Java.Lang.Object YieldAll(ISequence sequence, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sequence == null) ? IntPtr.Zero : ((Java.Lang.Object)sequence).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequenceScope._members.InstanceMethods.InvokeNonvirtualObjectMethod("yieldAll.(Lkotlin/sequences/Sequence;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(sequence);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x04000262 RID: 610
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/sequences/SequenceScope", typeof(SequenceScope));

		// Token: 0x04000263 RID: 611
		[Nullable(2)]
		private static Delegate cb_yield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_;

		// Token: 0x04000264 RID: 612
		[Nullable(2)]
		private static Delegate cb_yieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_;
	}
}
