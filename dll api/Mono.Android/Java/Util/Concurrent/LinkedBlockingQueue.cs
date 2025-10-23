using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Java.Util.Functions;

namespace Java.Util.Concurrent
{
	// Token: 0x02000359 RID: 857
	[Register("java/util/concurrent/LinkedBlockingQueue", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public class LinkedBlockingQueue : AbstractQueue, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IBlockingQueue, IQueue, ICollection, IIterable
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x0006CE6B File Offset: 0x0006B06B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkedBlockingQueue._members;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x0006CE74 File Offset: 0x0006B074
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkedBlockingQueue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x0006CE98 File Offset: 0x0006B098
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkedBlockingQueue._members.ManagedPeerType;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00053936 File Offset: 0x00051B36
		protected LinkedBlockingQueue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0006CEA4 File Offset: 0x0006B0A4
		private static Delegate GetDrainTo_Ljava_util_Collection_Handler()
		{
			if (LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_ == null)
			{
				LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(LinkedBlockingQueue.n_DrainTo_Ljava_util_Collection_));
			}
			return LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_;
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x0006CEC8 File Offset: 0x0006B0C8
		private static int n_DrainTo_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.DrainTo(c);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x0006CEEC File Offset: 0x0006B0EC
		public unsafe virtual int DrainTo(ICollection c)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualInt32Method("drainTo.(Ljava/util/Collection;)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x0006CF50 File Offset: 0x0006B150
		private static Delegate GetDrainTo_Ljava_util_Collection_IHandler()
		{
			if (LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_I == null)
			{
				LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(LinkedBlockingQueue.n_DrainTo_Ljava_util_Collection_I));
			}
			return LinkedBlockingQueue.cb_drainTo_Ljava_util_Collection_I;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0006CF74 File Offset: 0x0006B174
		private static int n_DrainTo_Ljava_util_Collection_I(IntPtr jnienv, IntPtr native__this, IntPtr native_c, int maxElements)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.DrainTo(c, maxElements);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0006CF98 File Offset: 0x0006B198
		public unsafe virtual int DrainTo(ICollection c, int maxElements)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(maxElements);
				result = LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualInt32Method("drainTo.(Ljava/util/Collection;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(c);
			}
			return result;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x0006D010 File Offset: 0x0006B210
		private static Delegate GetForEach_Ljava_util_function_Consumer_Handler()
		{
			if (LinkedBlockingQueue.cb_forEach_Ljava_util_function_Consumer_ == null)
			{
				LinkedBlockingQueue.cb_forEach_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LinkedBlockingQueue.n_ForEach_Ljava_util_function_Consumer_));
			}
			return LinkedBlockingQueue.cb_forEach_Ljava_util_function_Consumer_;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x0006D034 File Offset: 0x0006B234
		private static void n_ForEach_Ljava_util_function_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_action, JniHandleOwnership.DoNotTransfer);
			@object.ForEach(object2);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0006D058 File Offset: 0x0006B258
		public unsafe virtual void ForEach(IConsumer action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualVoidMethod("forEach.(Ljava/util/function/Consumer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(action);
			}
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x0006D0C0 File Offset: 0x0006B2C0
		private static Delegate GetIteratorHandler()
		{
			if (LinkedBlockingQueue.cb_iterator == null)
			{
				LinkedBlockingQueue.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinkedBlockingQueue.n_Iterator));
			}
			return LinkedBlockingQueue.cb_iterator;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0006D0E4 File Offset: 0x0006B2E4
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x0006D12A File Offset: 0x0006B32A
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (LinkedBlockingQueue.cb_offer_Ljava_lang_Object_ == null)
			{
				LinkedBlockingQueue.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(LinkedBlockingQueue.n_Offer_Ljava_lang_Object_));
			}
			return LinkedBlockingQueue.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0006D150 File Offset: 0x0006B350
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			AbstractQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0006D174 File Offset: 0x0006B374
		public unsafe override bool Offer(Java.Lang.Object e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualBooleanMethod("offer.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0006D1DC File Offset: 0x0006B3DC
		private static Delegate GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (LinkedBlockingQueue.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
			{
				LinkedBlockingQueue.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_Z(LinkedBlockingQueue.n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_));
			}
			return LinkedBlockingQueue.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0006D200 File Offset: 0x0006B400
		private static bool n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, long timeout, IntPtr native_unit)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2, timeout, object3);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0006D230 File Offset: 0x0006B430
		public unsafe virtual bool Offer(Java.Lang.Object e, long timeout, TimeUnit unit)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				ptr[1] = new JniArgumentValue(timeout);
				ptr[2] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				result = LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualBooleanMethod("offer.(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
				GC.KeepAlive(unit);
			}
			return result;
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
		private static Delegate GetPeekHandler()
		{
			if (LinkedBlockingQueue.cb_peek == null)
			{
				LinkedBlockingQueue.cb_peek = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinkedBlockingQueue.n_Peek));
			}
			return LinkedBlockingQueue.cb_peek;
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0006D2F8 File Offset: 0x0006B4F8
		private static IntPtr n_Peek(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Peek());
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0006D30C File Offset: 0x0006B50C
		public override Java.Lang.Object Peek()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("peek.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0006D33E File Offset: 0x0006B53E
		private static Delegate GetPollHandler()
		{
			if (LinkedBlockingQueue.cb_poll == null)
			{
				LinkedBlockingQueue.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinkedBlockingQueue.n_Poll));
			}
			return LinkedBlockingQueue.cb_poll;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0006D362 File Offset: 0x0006B562
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0006D378 File Offset: 0x0006B578
		public override Java.Lang.Object Poll()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("poll.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0006D3AA File Offset: 0x0006B5AA
		private static Delegate GetPoll_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (LinkedBlockingQueue.cb_poll_JLjava_util_concurrent_TimeUnit_ == null)
			{
				LinkedBlockingQueue.cb_poll_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(LinkedBlockingQueue.n_Poll_JLjava_util_concurrent_TimeUnit_));
			}
			return LinkedBlockingQueue.cb_poll_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
		private static IntPtr n_Poll_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Poll(timeout, object2));
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0006D3FC File Offset: 0x0006B5FC
		public unsafe virtual Java.Lang.Object Poll(long timeout, TimeUnit unit)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(timeout);
				ptr[1] = new JniArgumentValue((unit == null) ? IntPtr.Zero : unit.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("poll.(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(unit);
			}
			return @object;
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x0006D484 File Offset: 0x0006B684
		private static Delegate GetPut_Ljava_lang_Object_Handler()
		{
			if (LinkedBlockingQueue.cb_put_Ljava_lang_Object_ == null)
			{
				LinkedBlockingQueue.cb_put_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LinkedBlockingQueue.n_Put_Ljava_lang_Object_));
			}
			return LinkedBlockingQueue.cb_put_Ljava_lang_Object_;
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0006D4A8 File Offset: 0x0006B6A8
		private static void n_Put_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x0006D4CC File Offset: 0x0006B6CC
		public unsafe virtual void Put(Java.Lang.Object e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0006D530 File Offset: 0x0006B730
		private static Delegate GetRemainingCapacityHandler()
		{
			if (LinkedBlockingQueue.cb_remainingCapacity == null)
			{
				LinkedBlockingQueue.cb_remainingCapacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinkedBlockingQueue.n_RemainingCapacity));
			}
			return LinkedBlockingQueue.cb_remainingCapacity;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x0006D554 File Offset: 0x0006B754
		private static int n_RemainingCapacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemainingCapacity();
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x0006D563 File Offset: 0x0006B763
		public virtual int RemainingCapacity()
		{
			return LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualInt32Method("remainingCapacity.()I", this, null);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0006D57C File Offset: 0x0006B77C
		private static Delegate GetRemoveIf_Ljava_util_function_Predicate_Handler()
		{
			if (LinkedBlockingQueue.cb_removeIf_Ljava_util_function_Predicate_ == null)
			{
				LinkedBlockingQueue.cb_removeIf_Ljava_util_function_Predicate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(LinkedBlockingQueue.n_RemoveIf_Ljava_util_function_Predicate_));
			}
			return LinkedBlockingQueue.cb_removeIf_Ljava_util_function_Predicate_;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
		private static bool n_RemoveIf_Ljava_util_function_Predicate_(IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			LinkedBlockingQueue @object = Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IPredicate object2 = Java.Lang.Object.GetObject<IPredicate>(native_filter, JniHandleOwnership.DoNotTransfer);
			return @object.RemoveIf(object2);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x0006D5C4 File Offset: 0x0006B7C4
		public unsafe virtual bool RemoveIf(IPredicate filter)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((filter == null) ? IntPtr.Zero : ((Java.Lang.Object)filter).Handle);
				result = LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualBooleanMethod("removeIf.(Ljava/util/function/Predicate;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(filter);
			}
			return result;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0006D630 File Offset: 0x0006B830
		private static Delegate GetSizeHandler()
		{
			if (LinkedBlockingQueue.cb_size == null)
			{
				LinkedBlockingQueue.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(LinkedBlockingQueue.n_Size));
			}
			return LinkedBlockingQueue.cb_size;
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x0006D654 File Offset: 0x0006B854
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0006D663 File Offset: 0x0006B863
		public override int Size()
		{
			return LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0006D67C File Offset: 0x0006B87C
		private static Delegate GetSpliteratorHandler()
		{
			if (LinkedBlockingQueue.cb_spliterator == null)
			{
				LinkedBlockingQueue.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinkedBlockingQueue.n_Spliterator));
			}
			return LinkedBlockingQueue.cb_spliterator;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0006D6B4 File Offset: 0x0006B8B4
		public virtual ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0006D6E6 File Offset: 0x0006B8E6
		private static Delegate GetTakeHandler()
		{
			if (LinkedBlockingQueue.cb_take == null)
			{
				LinkedBlockingQueue.cb_take = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(LinkedBlockingQueue.n_Take));
			}
			return LinkedBlockingQueue.cb_take;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x0006D70A File Offset: 0x0006B90A
		private static IntPtr n_Take(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<LinkedBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Take());
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x0006D720 File Offset: 0x0006B920
		public virtual Java.Lang.Object Take()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(LinkedBlockingQueue._members.InstanceMethods.InvokeVirtualObjectMethod("take.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000FB2 RID: 4018
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/LinkedBlockingQueue", typeof(LinkedBlockingQueue));

		// Token: 0x04000FB3 RID: 4019
		private static Delegate cb_drainTo_Ljava_util_Collection_;

		// Token: 0x04000FB4 RID: 4020
		private static Delegate cb_drainTo_Ljava_util_Collection_I;

		// Token: 0x04000FB5 RID: 4021
		private static Delegate cb_forEach_Ljava_util_function_Consumer_;

		// Token: 0x04000FB6 RID: 4022
		private static Delegate cb_iterator;

		// Token: 0x04000FB7 RID: 4023
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x04000FB8 RID: 4024
		private static Delegate cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FB9 RID: 4025
		private static Delegate cb_peek;

		// Token: 0x04000FBA RID: 4026
		private static Delegate cb_poll;

		// Token: 0x04000FBB RID: 4027
		private static Delegate cb_poll_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000FBC RID: 4028
		private static Delegate cb_put_Ljava_lang_Object_;

		// Token: 0x04000FBD RID: 4029
		private static Delegate cb_remainingCapacity;

		// Token: 0x04000FBE RID: 4030
		private static Delegate cb_removeIf_Ljava_util_function_Predicate_;

		// Token: 0x04000FBF RID: 4031
		private static Delegate cb_size;

		// Token: 0x04000FC0 RID: 4032
		private static Delegate cb_spliterator;

		// Token: 0x04000FC1 RID: 4033
		private static Delegate cb_take;
	}
}
