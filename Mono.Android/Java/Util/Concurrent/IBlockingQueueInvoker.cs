using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000346 RID: 838
	[Register("java/util/concurrent/BlockingQueue", DoNotGenerateAcw = true)]
	internal class IBlockingQueueInvoker : Java.Lang.Object, IBlockingQueue, IQueue, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x00066798 File Offset: 0x00064998
		private static IntPtr java_class_ref
		{
			get
			{
				return IBlockingQueueInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000667BC File Offset: 0x000649BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBlockingQueueInvoker._members;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000667C3 File Offset: 0x000649C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000667CB File Offset: 0x000649CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBlockingQueueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000667D7 File Offset: 0x000649D7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBlockingQueueInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.concurrent.BlockingQueue'.");
			}
			return handle;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00066802 File Offset: 0x00064A02
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00066834 File Offset: 0x00064A34
		public IBlockingQueueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBlockingQueueInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0006686C File Offset: 0x00064A6C
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IBlockingQueueInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IBlockingQueueInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingQueueInvoker.n_Add_Ljava_lang_Object_));
			}
			return IBlockingQueueInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00066890 File Offset: 0x00064A90
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000668B4 File Offset: 0x00064AB4
		public unsafe bool Add(Java.Lang.Object e)
		{
			if (this.id_add_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_add_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00066927 File Offset: 0x00064B27
		private static Delegate GetContains_Ljava_lang_Object_Handler()
		{
			if (IBlockingQueueInvoker.cb_contains_Ljava_lang_Object_ == null)
			{
				IBlockingQueueInvoker.cb_contains_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingQueueInvoker.n_Contains_Ljava_lang_Object_));
			}
			return IBlockingQueueInvoker.cb_contains_Ljava_lang_Object_;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0006694C File Offset: 0x00064B4C
		private static bool n_Contains_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Contains(object2);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00066970 File Offset: 0x00064B70
		public unsafe bool Contains(Java.Lang.Object o)
		{
			if (this.id_contains_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_contains_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "contains", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_contains_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x000669E3 File Offset: 0x00064BE3
		private static Delegate GetDrainTo_Ljava_util_Collection_Handler()
		{
			if (IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_ == null)
			{
				IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IBlockingQueueInvoker.n_DrainTo_Ljava_util_Collection_));
			}
			return IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00066A08 File Offset: 0x00064C08
		private static int n_DrainTo_Ljava_util_Collection_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.DrainTo(c);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00066A2C File Offset: 0x00064C2C
		public unsafe int DrainTo(ICollection c)
		{
			if (this.id_drainTo_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_drainTo_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "drainTo", "(Ljava/util/Collection;)I");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_drainTo_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x00066A9D File Offset: 0x00064C9D
		private static Delegate GetDrainTo_Ljava_util_Collection_IHandler()
		{
			if (IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_I == null)
			{
				IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(IBlockingQueueInvoker.n_DrainTo_Ljava_util_Collection_I));
			}
			return IBlockingQueueInvoker.cb_drainTo_Ljava_util_Collection_I;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00066AC4 File Offset: 0x00064CC4
		private static int n_DrainTo_Ljava_util_Collection_I(IntPtr jnienv, IntPtr native__this, IntPtr native_c, int maxElements)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICollection c = JavaCollection.FromJniHandle(native_c, JniHandleOwnership.DoNotTransfer);
			return @object.DrainTo(c, maxElements);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00066AE8 File Offset: 0x00064CE8
		public unsafe int DrainTo(ICollection c, int maxElements)
		{
			if (this.id_drainTo_Ljava_util_Collection_I == IntPtr.Zero)
			{
				this.id_drainTo_Ljava_util_Collection_I = JNIEnv.GetMethodID(this.class_ref, "drainTo", "(Ljava/util/Collection;I)I");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(maxElements);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_drainTo_Ljava_util_Collection_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00066B6C File Offset: 0x00064D6C
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingQueueInvoker.n_Offer_Ljava_lang_Object_));
			}
			return IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00066B90 File Offset: 0x00064D90
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00066BB4 File Offset: 0x00064DB4
		public unsafe bool Offer(Java.Lang.Object e)
		{
			if (this.id_offer_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_offer_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "offer", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_offer_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00066C27 File Offset: 0x00064E27
		private static Delegate GetOffer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_Z(IBlockingQueueInvoker.n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_));
			}
			return IBlockingQueueInvoker.cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00066C4C File Offset: 0x00064E4C
		private static bool n_Offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_e, long timeout, IntPtr native_unit)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2, timeout, object3);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00066C7C File Offset: 0x00064E7C
		public unsafe bool Offer(Java.Lang.Object e, long timeout, TimeUnit unit)
		{
			if (this.id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			ptr[1] = new JValue(timeout);
			ptr[2] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, ptr);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00066D27 File Offset: 0x00064F27
		private static Delegate GetPoll_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (IBlockingQueueInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_ == null)
			{
				IBlockingQueueInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(IBlockingQueueInvoker.n_Poll_JLjava_util_concurrent_TimeUnit_));
			}
			return IBlockingQueueInvoker.cb_poll_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00066D4C File Offset: 0x00064F4C
		private static IntPtr n_Poll_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Poll(timeout, object2));
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00066D78 File Offset: 0x00064F78
		public unsafe Java.Lang.Object Poll(long timeout, TimeUnit unit)
		{
			if (this.id_poll_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
			{
				this.id_poll_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(this.class_ref, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(timeout);
			ptr[1] = new JValue((unit == null) ? IntPtr.Zero : unit.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll_JLjava_util_concurrent_TimeUnit_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00066E04 File Offset: 0x00065004
		private static Delegate GetPut_Ljava_lang_Object_Handler()
		{
			if (IBlockingQueueInvoker.cb_put_Ljava_lang_Object_ == null)
			{
				IBlockingQueueInvoker.cb_put_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBlockingQueueInvoker.n_Put_Ljava_lang_Object_));
			}
			return IBlockingQueueInvoker.cb_put_Ljava_lang_Object_;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00066E28 File Offset: 0x00065028
		private static void n_Put_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00066E4C File Offset: 0x0006504C
		public unsafe void Put(Java.Lang.Object e)
		{
			if (this.id_put_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_put_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_put_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00066EBF File Offset: 0x000650BF
		private static Delegate GetRemainingCapacityHandler()
		{
			if (IBlockingQueueInvoker.cb_remainingCapacity == null)
			{
				IBlockingQueueInvoker.cb_remainingCapacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IBlockingQueueInvoker.n_RemainingCapacity));
			}
			return IBlockingQueueInvoker.cb_remainingCapacity;
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00066EE3 File Offset: 0x000650E3
		private static int n_RemainingCapacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemainingCapacity();
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00066EF2 File Offset: 0x000650F2
		public int RemainingCapacity()
		{
			if (this.id_remainingCapacity == IntPtr.Zero)
			{
				this.id_remainingCapacity = JNIEnv.GetMethodID(this.class_ref, "remainingCapacity", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_remainingCapacity);
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00066F32 File Offset: 0x00065132
		private static Delegate GetRemove_Ljava_lang_Object_Handler()
		{
			if (IBlockingQueueInvoker.cb_remove_Ljava_lang_Object_ == null)
			{
				IBlockingQueueInvoker.cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IBlockingQueueInvoker.n_Remove_Ljava_lang_Object_));
			}
			return IBlockingQueueInvoker.cb_remove_Ljava_lang_Object_;
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00066F58 File Offset: 0x00065158
		private static bool n_Remove_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IBlockingQueue @object = Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.Remove(object2);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00066F7C File Offset: 0x0006517C
		public unsafe bool Remove(Java.Lang.Object o)
		{
			if (this.id_remove_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "remove", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_remove_Ljava_lang_Object_, ptr);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00066FEF File Offset: 0x000651EF
		private static Delegate GetTakeHandler()
		{
			if (IBlockingQueueInvoker.cb_take == null)
			{
				IBlockingQueueInvoker.cb_take = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBlockingQueueInvoker.n_Take));
			}
			return IBlockingQueueInvoker.cb_take;
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00067013 File Offset: 0x00065213
		private static IntPtr n_Take(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBlockingQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Take());
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00067028 File Offset: 0x00065228
		public Java.Lang.Object Take()
		{
			if (this.id_take == IntPtr.Zero)
			{
				this.id_take = JNIEnv.GetMethodID(this.class_ref, "take", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_take), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0006707C File Offset: 0x0006527C
		public Java.Lang.Object Element()
		{
			if (this.id_element == IntPtr.Zero)
			{
				this.id_element = JNIEnv.GetMethodID(this.class_ref, "element", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_element), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x000670D0 File Offset: 0x000652D0
		public Java.Lang.Object Peek()
		{
			if (this.id_peek == IntPtr.Zero)
			{
				this.id_peek = JNIEnv.GetMethodID(this.class_ref, "peek", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_peek), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00067124 File Offset: 0x00065324
		public Java.Lang.Object Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00067178 File Offset: 0x00065378
		public Java.Lang.Object Remove()
		{
			if (this.id_remove == IntPtr.Zero)
			{
				this.id_remove = JNIEnv.GetMethodID(this.class_ref, "remove", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000671C9 File Offset: 0x000653C9
		public bool IsEmpty
		{
			get
			{
				if (this.id_isEmpty == IntPtr.Zero)
				{
					this.id_isEmpty = JNIEnv.GetMethodID(this.class_ref, "isEmpty", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEmpty);
			}
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0006720C File Offset: 0x0006540C
		public unsafe bool AddAll(ICollection c)
		{
			if (this.id_addAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_addAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "addAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_addAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0006727D File Offset: 0x0006547D
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x000672C0 File Offset: 0x000654C0
		public unsafe bool ContainsAll(ICollection c)
		{
			if (this.id_containsAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_containsAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "containsAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_containsAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00067334 File Offset: 0x00065534
		public new unsafe bool Equals(Java.Lang.Object o)
		{
			if (this.id_equals_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "equals", "(Ljava/lang/Object;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((o == null) ? IntPtr.Zero : o.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_equals_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x000673A7 File Offset: 0x000655A7
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x000673E8 File Offset: 0x000655E8
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0006743C File Offset: 0x0006563C
		public unsafe bool RemoveAll(ICollection c)
		{
			if (this.id_removeAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_removeAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "removeAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_removeAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000674B0 File Offset: 0x000656B0
		public unsafe bool RetainAll(ICollection c)
		{
			if (this.id_retainAll_Ljava_util_Collection_ == IntPtr.Zero)
			{
				this.id_retainAll_Ljava_util_Collection_ = JNIEnv.GetMethodID(this.class_ref, "retainAll", "(Ljava/util/Collection;)Z");
			}
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(c);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_retainAll_Ljava_util_Collection_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00067521 File Offset: 0x00065721
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00067564 File Offset: 0x00065764
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x000675C4 File Offset: 0x000657C4
		public unsafe Java.Lang.Object[] ToArray(Java.Lang.Object[] a)
		{
			if (this.id_toArray_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_toArray_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(a);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object[] result = (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray_arrayLjava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
			if (a != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, a);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x04000EC8 RID: 3784
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/concurrent/BlockingQueue", typeof(IBlockingQueueInvoker));

		// Token: 0x04000EC9 RID: 3785
		private IntPtr class_ref;

		// Token: 0x04000ECA RID: 3786
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000ECB RID: 3787
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000ECC RID: 3788
		private static Delegate cb_contains_Ljava_lang_Object_;

		// Token: 0x04000ECD RID: 3789
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000ECE RID: 3790
		private static Delegate cb_drainTo_Ljava_util_Collection_;

		// Token: 0x04000ECF RID: 3791
		private IntPtr id_drainTo_Ljava_util_Collection_;

		// Token: 0x04000ED0 RID: 3792
		private static Delegate cb_drainTo_Ljava_util_Collection_I;

		// Token: 0x04000ED1 RID: 3793
		private IntPtr id_drainTo_Ljava_util_Collection_I;

		// Token: 0x04000ED2 RID: 3794
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x04000ED3 RID: 3795
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x04000ED4 RID: 3796
		private static Delegate cb_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000ED5 RID: 3797
		private IntPtr id_offer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000ED6 RID: 3798
		private static Delegate cb_poll_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000ED7 RID: 3799
		private IntPtr id_poll_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x04000ED8 RID: 3800
		private static Delegate cb_put_Ljava_lang_Object_;

		// Token: 0x04000ED9 RID: 3801
		private IntPtr id_put_Ljava_lang_Object_;

		// Token: 0x04000EDA RID: 3802
		private static Delegate cb_remainingCapacity;

		// Token: 0x04000EDB RID: 3803
		private IntPtr id_remainingCapacity;

		// Token: 0x04000EDC RID: 3804
		private static Delegate cb_remove_Ljava_lang_Object_;

		// Token: 0x04000EDD RID: 3805
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000EDE RID: 3806
		private static Delegate cb_take;

		// Token: 0x04000EDF RID: 3807
		private IntPtr id_take;

		// Token: 0x04000EE0 RID: 3808
		private IntPtr id_element;

		// Token: 0x04000EE1 RID: 3809
		private IntPtr id_peek;

		// Token: 0x04000EE2 RID: 3810
		private IntPtr id_poll;

		// Token: 0x04000EE3 RID: 3811
		private IntPtr id_remove;

		// Token: 0x04000EE4 RID: 3812
		private IntPtr id_isEmpty;

		// Token: 0x04000EE5 RID: 3813
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000EE6 RID: 3814
		private IntPtr id_clear;

		// Token: 0x04000EE7 RID: 3815
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000EE8 RID: 3816
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000EE9 RID: 3817
		private IntPtr id_hashCode;

		// Token: 0x04000EEA RID: 3818
		private IntPtr id_iterator;

		// Token: 0x04000EEB RID: 3819
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000EEC RID: 3820
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000EED RID: 3821
		private IntPtr id_size;

		// Token: 0x04000EEE RID: 3822
		private IntPtr id_toArray;

		// Token: 0x04000EEF RID: 3823
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
