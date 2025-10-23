using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000319 RID: 793
	[Register("java/util/Queue", DoNotGenerateAcw = true)]
	internal class IQueueInvoker : Java.Lang.Object, IQueue, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x0005D2BC File Offset: 0x0005B4BC
		private static IntPtr java_class_ref
		{
			get
			{
				return IQueueInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x0005D2E0 File Offset: 0x0005B4E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IQueueInvoker._members;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0005D2E7 File Offset: 0x0005B4E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x0005D2EF File Offset: 0x0005B4EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IQueueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0005D2FB File Offset: 0x0005B4FB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IQueueInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.Queue'.");
			}
			return handle;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0005D326 File Offset: 0x0005B526
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0005D358 File Offset: 0x0005B558
		public IQueueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IQueueInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0005D390 File Offset: 0x0005B590
		private static Delegate GetAdd_Ljava_lang_Object_Handler()
		{
			if (IQueueInvoker.cb_add_Ljava_lang_Object_ == null)
			{
				IQueueInvoker.cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IQueueInvoker.n_Add_Ljava_lang_Object_));
			}
			return IQueueInvoker.cb_add_Ljava_lang_Object_;
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x0005D3B4 File Offset: 0x0005B5B4
		private static bool n_Add_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IQueue @object = Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Add(object2);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0005D3D8 File Offset: 0x0005B5D8
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

		// Token: 0x06002151 RID: 8529 RVA: 0x0005D44B File Offset: 0x0005B64B
		private static Delegate GetElementHandler()
		{
			if (IQueueInvoker.cb_element == null)
			{
				IQueueInvoker.cb_element = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQueueInvoker.n_Element));
			}
			return IQueueInvoker.cb_element;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0005D46F File Offset: 0x0005B66F
		private static IntPtr n_Element(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Element());
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0005D484 File Offset: 0x0005B684
		public Java.Lang.Object Element()
		{
			if (this.id_element == IntPtr.Zero)
			{
				this.id_element = JNIEnv.GetMethodID(this.class_ref, "element", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_element), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0005D4D5 File Offset: 0x0005B6D5
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (IQueueInvoker.cb_offer_Ljava_lang_Object_ == null)
			{
				IQueueInvoker.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IQueueInvoker.n_Offer_Ljava_lang_Object_));
			}
			return IQueueInvoker.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0005D4FC File Offset: 0x0005B6FC
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			IQueue @object = Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0005D520 File Offset: 0x0005B720
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

		// Token: 0x06002157 RID: 8535 RVA: 0x0005D593 File Offset: 0x0005B793
		private static Delegate GetPeekHandler()
		{
			if (IQueueInvoker.cb_peek == null)
			{
				IQueueInvoker.cb_peek = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQueueInvoker.n_Peek));
			}
			return IQueueInvoker.cb_peek;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0005D5B7 File Offset: 0x0005B7B7
		private static IntPtr n_Peek(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Peek());
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0005D5CC File Offset: 0x0005B7CC
		public Java.Lang.Object Peek()
		{
			if (this.id_peek == IntPtr.Zero)
			{
				this.id_peek = JNIEnv.GetMethodID(this.class_ref, "peek", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_peek), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0005D61D File Offset: 0x0005B81D
		private static Delegate GetPollHandler()
		{
			if (IQueueInvoker.cb_poll == null)
			{
				IQueueInvoker.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQueueInvoker.n_Poll));
			}
			return IQueueInvoker.cb_poll;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0005D641 File Offset: 0x0005B841
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0005D658 File Offset: 0x0005B858
		public Java.Lang.Object Poll()
		{
			if (this.id_poll == IntPtr.Zero)
			{
				this.id_poll = JNIEnv.GetMethodID(this.class_ref, "poll", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_poll), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0005D6A9 File Offset: 0x0005B8A9
		private static Delegate GetRemoveHandler()
		{
			if (IQueueInvoker.cb_remove == null)
			{
				IQueueInvoker.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IQueueInvoker.n_Remove));
			}
			return IQueueInvoker.cb_remove;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0005D6CD File Offset: 0x0005B8CD
		private static IntPtr n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove());
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0005D6E4 File Offset: 0x0005B8E4
		public Java.Lang.Object Remove()
		{
			if (this.id_remove == IntPtr.Zero)
			{
				this.id_remove = JNIEnv.GetMethodID(this.class_ref, "remove", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_remove), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0005D735 File Offset: 0x0005B935
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

		// Token: 0x06002161 RID: 8545 RVA: 0x0005D778 File Offset: 0x0005B978
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

		// Token: 0x06002162 RID: 8546 RVA: 0x0005D7E9 File Offset: 0x0005B9E9
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0005D82C File Offset: 0x0005BA2C
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

		// Token: 0x06002164 RID: 8548 RVA: 0x0005D8A0 File Offset: 0x0005BAA0
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

		// Token: 0x06002165 RID: 8549 RVA: 0x0005D914 File Offset: 0x0005BB14
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

		// Token: 0x06002166 RID: 8550 RVA: 0x0005D987 File Offset: 0x0005BB87
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0005D9C8 File Offset: 0x0005BBC8
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0005DA1C File Offset: 0x0005BC1C
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

		// Token: 0x06002169 RID: 8553 RVA: 0x0005DA90 File Offset: 0x0005BC90
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

		// Token: 0x0600216A RID: 8554 RVA: 0x0005DB04 File Offset: 0x0005BD04
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

		// Token: 0x0600216B RID: 8555 RVA: 0x0005DB75 File Offset: 0x0005BD75
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x0005DBB8 File Offset: 0x0005BDB8
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x0005DC18 File Offset: 0x0005BE18
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

		// Token: 0x04000DAB RID: 3499
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Queue", typeof(IQueueInvoker));

		// Token: 0x04000DAC RID: 3500
		private IntPtr class_ref;

		// Token: 0x04000DAD RID: 3501
		private static Delegate cb_add_Ljava_lang_Object_;

		// Token: 0x04000DAE RID: 3502
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000DAF RID: 3503
		private static Delegate cb_element;

		// Token: 0x04000DB0 RID: 3504
		private IntPtr id_element;

		// Token: 0x04000DB1 RID: 3505
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x04000DB2 RID: 3506
		private IntPtr id_offer_Ljava_lang_Object_;

		// Token: 0x04000DB3 RID: 3507
		private static Delegate cb_peek;

		// Token: 0x04000DB4 RID: 3508
		private IntPtr id_peek;

		// Token: 0x04000DB5 RID: 3509
		private static Delegate cb_poll;

		// Token: 0x04000DB6 RID: 3510
		private IntPtr id_poll;

		// Token: 0x04000DB7 RID: 3511
		private static Delegate cb_remove;

		// Token: 0x04000DB8 RID: 3512
		private IntPtr id_remove;

		// Token: 0x04000DB9 RID: 3513
		private IntPtr id_isEmpty;

		// Token: 0x04000DBA RID: 3514
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000DBB RID: 3515
		private IntPtr id_clear;

		// Token: 0x04000DBC RID: 3516
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000DBD RID: 3517
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000DBE RID: 3518
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000DBF RID: 3519
		private IntPtr id_hashCode;

		// Token: 0x04000DC0 RID: 3520
		private IntPtr id_iterator;

		// Token: 0x04000DC1 RID: 3521
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000DC2 RID: 3522
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000DC3 RID: 3523
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000DC4 RID: 3524
		private IntPtr id_size;

		// Token: 0x04000DC5 RID: 3525
		private IntPtr id_toArray;

		// Token: 0x04000DC6 RID: 3526
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
