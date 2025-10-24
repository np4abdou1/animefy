using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000317 RID: 791
	[Register("java/util/NavigableSet", DoNotGenerateAcw = true)]
	internal class INavigableSetInvoker : Java.Lang.Object, INavigableSet, ISortedSet, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x0005C024 File Offset: 0x0005A224
		private static IntPtr java_class_ref
		{
			get
			{
				return INavigableSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0005C048 File Offset: 0x0005A248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INavigableSetInvoker._members;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0005C04F File Offset: 0x0005A24F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0005C057 File Offset: 0x0005A257
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INavigableSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x0005C063 File Offset: 0x0005A263
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INavigableSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.NavigableSet'.");
			}
			return handle;
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x0005C08E File Offset: 0x0005A28E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x0005C0C0 File Offset: 0x0005A2C0
		public INavigableSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INavigableSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0005C0F8 File Offset: 0x0005A2F8
		private static Delegate GetCeiling_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_ceiling_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_ceiling_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_Ceiling_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_ceiling_Ljava_lang_Object_;
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0005C11C File Offset: 0x0005A31C
		private static IntPtr n_Ceiling_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Ceiling(object2));
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0005C144 File Offset: 0x0005A344
		public unsafe Java.Lang.Object Ceiling(Java.Lang.Object e)
		{
			if (this.id_ceiling_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_ceiling_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "ceiling", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_ceiling_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0005C1BB File Offset: 0x0005A3BB
		private static Delegate GetDescendingIteratorHandler()
		{
			if (INavigableSetInvoker.cb_descendingIterator == null)
			{
				INavigableSetInvoker.cb_descendingIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INavigableSetInvoker.n_DescendingIterator));
			}
			return INavigableSetInvoker.cb_descendingIterator;
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x0005C1DF File Offset: 0x0005A3DF
		private static IntPtr n_DescendingIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescendingIterator());
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0005C1F4 File Offset: 0x0005A3F4
		public IIterator DescendingIterator()
		{
			if (this.id_descendingIterator == IntPtr.Zero)
			{
				this.id_descendingIterator = JNIEnv.GetMethodID(this.class_ref, "descendingIterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_descendingIterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x0005C245 File Offset: 0x0005A445
		private static Delegate GetDescendingSetHandler()
		{
			if (INavigableSetInvoker.cb_descendingSet == null)
			{
				INavigableSetInvoker.cb_descendingSet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INavigableSetInvoker.n_DescendingSet));
			}
			return INavigableSetInvoker.cb_descendingSet;
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x0005C269 File Offset: 0x0005A469
		private static IntPtr n_DescendingSet(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescendingSet());
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x0005C280 File Offset: 0x0005A480
		public INavigableSet DescendingSet()
		{
			if (this.id_descendingSet == IntPtr.Zero)
			{
				this.id_descendingSet = JNIEnv.GetMethodID(this.class_ref, "descendingSet", "()Ljava/util/NavigableSet;");
			}
			return Java.Lang.Object.GetObject<INavigableSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_descendingSet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x0005C2D1 File Offset: 0x0005A4D1
		private static Delegate GetFloor_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_floor_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_floor_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_Floor_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_floor_Ljava_lang_Object_;
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
		private static IntPtr n_Floor_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Floor(object2));
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x0005C320 File Offset: 0x0005A520
		public unsafe Java.Lang.Object Floor(Java.Lang.Object e)
		{
			if (this.id_floor_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_floor_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "floor", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_floor_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x0005C397 File Offset: 0x0005A597
		private static Delegate GetHeadSet_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_headSet_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_headSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_HeadSet_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_headSet_Ljava_lang_Object_;
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0005C3BC File Offset: 0x0005A5BC
		private static IntPtr n_HeadSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_toElement)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HeadSet(object2));
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		public unsafe ISortedSet HeadSet(Java.Lang.Object toElement)
		{
			if (this.id_headSet_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_headSet_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_headSet_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x0005C45B File Offset: 0x0005A65B
		private static Delegate GetHeadSet_Ljava_lang_Object_ZHandler()
		{
			if (INavigableSetInvoker.cb_headSet_Ljava_lang_Object_Z == null)
			{
				INavigableSetInvoker.cb_headSet_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(INavigableSetInvoker.n_HeadSet_Ljava_lang_Object_Z));
			}
			return INavigableSetInvoker.cb_headSet_Ljava_lang_Object_Z;
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x0005C480 File Offset: 0x0005A680
		private static IntPtr n_HeadSet_Ljava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_toElement, bool inclusive)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HeadSet(object2, inclusive));
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0005C4AC File Offset: 0x0005A6AC
		public unsafe INavigableSet HeadSet(Java.Lang.Object toElement, bool inclusive)
		{
			if (this.id_headSet_Ljava_lang_Object_Z == IntPtr.Zero)
			{
				this.id_headSet_Ljava_lang_Object_Z = JNIEnv.GetMethodID(this.class_ref, "headSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(inclusive);
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_headSet_Ljava_lang_Object_Z, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x0005C536 File Offset: 0x0005A736
		private static Delegate GetHigher_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_higher_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_higher_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_Higher_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_higher_Ljava_lang_Object_;
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0005C55C File Offset: 0x0005A75C
		private static IntPtr n_Higher_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Higher(object2));
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0005C584 File Offset: 0x0005A784
		public unsafe Java.Lang.Object Higher(Java.Lang.Object e)
		{
			if (this.id_higher_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_higher_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "higher", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_higher_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0005C5FB File Offset: 0x0005A7FB
		private static Delegate GetIteratorHandler()
		{
			if (INavigableSetInvoker.cb_iterator == null)
			{
				INavigableSetInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INavigableSetInvoker.n_Iterator));
			}
			return INavigableSetInvoker.cb_iterator;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x0005C61F File Offset: 0x0005A81F
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0005C634 File Offset: 0x0005A834
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0005C685 File Offset: 0x0005A885
		private static Delegate GetLower_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_lower_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_lower_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_Lower_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_lower_Ljava_lang_Object_;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x0005C6AC File Offset: 0x0005A8AC
		private static IntPtr n_Lower_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Lower(object2));
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
		public unsafe Java.Lang.Object Lower(Java.Lang.Object e)
		{
			if (this.id_lower_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_lower_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "lower", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_lower_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x0005C74B File Offset: 0x0005A94B
		private static Delegate GetPollFirstHandler()
		{
			if (INavigableSetInvoker.cb_pollFirst == null)
			{
				INavigableSetInvoker.cb_pollFirst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INavigableSetInvoker.n_PollFirst));
			}
			return INavigableSetInvoker.cb_pollFirst;
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0005C76F File Offset: 0x0005A96F
		private static IntPtr n_PollFirst(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PollFirst());
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x0005C784 File Offset: 0x0005A984
		public Java.Lang.Object PollFirst()
		{
			if (this.id_pollFirst == IntPtr.Zero)
			{
				this.id_pollFirst = JNIEnv.GetMethodID(this.class_ref, "pollFirst", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_pollFirst), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x0005C7D5 File Offset: 0x0005A9D5
		private static Delegate GetPollLastHandler()
		{
			if (INavigableSetInvoker.cb_pollLast == null)
			{
				INavigableSetInvoker.cb_pollLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INavigableSetInvoker.n_PollLast));
			}
			return INavigableSetInvoker.cb_pollLast;
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x0005C7F9 File Offset: 0x0005A9F9
		private static IntPtr n_PollLast(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PollLast());
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0005C810 File Offset: 0x0005AA10
		public Java.Lang.Object PollLast()
		{
			if (this.id_pollLast == IntPtr.Zero)
			{
				this.id_pollLast = JNIEnv.GetMethodID(this.class_ref, "pollLast", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_pollLast), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x0005C861 File Offset: 0x0005AA61
		private static Delegate GetSubSet_Ljava_lang_Object_ZLjava_lang_Object_ZHandler()
		{
			if (INavigableSetInvoker.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z == null)
			{
				INavigableSetInvoker.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZLZ_L(INavigableSetInvoker.n_SubSet_Ljava_lang_Object_ZLjava_lang_Object_Z));
			}
			return INavigableSetInvoker.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z;
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0005C888 File Offset: 0x0005AA88
		private static IntPtr n_SubSet_Ljava_lang_Object_ZLjava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, bool fromInclusive, IntPtr native_toElement, bool toInclusive)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubSet(object2, fromInclusive, object3, toInclusive));
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x0005C8C0 File Offset: 0x0005AAC0
		public unsafe INavigableSet SubSet(Java.Lang.Object fromElement, bool fromInclusive, Java.Lang.Object toElement, bool toInclusive)
		{
			if (this.id_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z == IntPtr.Zero)
			{
				this.id_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z = JNIEnv.GetMethodID(this.class_ref, "subSet", "(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(fromInclusive);
			ptr[2] = new JValue(intPtr2);
			ptr[3] = new JValue(toInclusive);
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0005C984 File Offset: 0x0005AB84
		private static Delegate GetSubSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(INavigableSetInvoker.n_SubSet_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0005C9A8 File Offset: 0x0005ABA8
		private static IntPtr n_SubSet_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, IntPtr native_toElement)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubSet(object2, object3));
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0005C9DC File Offset: 0x0005ABDC
		public unsafe ISortedSet SubSet(Java.Lang.Object fromElement, Java.Lang.Object toElement)
		{
			if (this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(toElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_subSet_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0005CA73 File Offset: 0x0005AC73
		private static Delegate GetTailSet_Ljava_lang_Object_Handler()
		{
			if (INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_ == null)
			{
				INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(INavigableSetInvoker.n_TailSet_Ljava_lang_Object_));
			}
			return INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_;
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0005CA98 File Offset: 0x0005AC98
		private static IntPtr n_TailSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TailSet(object2));
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x0005CAC0 File Offset: 0x0005ACC0
		public unsafe ISortedSet TailSet(Java.Lang.Object fromElement)
		{
			if (this.id_tailSet_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_tailSet_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ISortedSet @object = Java.Lang.Object.GetObject<ISortedSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_tailSet_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x0005CB37 File Offset: 0x0005AD37
		private static Delegate GetTailSet_Ljava_lang_Object_ZHandler()
		{
			if (INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_Z == null)
			{
				INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(INavigableSetInvoker.n_TailSet_Ljava_lang_Object_Z));
			}
			return INavigableSetInvoker.cb_tailSet_Ljava_lang_Object_Z;
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0005CB5C File Offset: 0x0005AD5C
		private static IntPtr n_TailSet_Ljava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, bool inclusive)
		{
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TailSet(object2, inclusive));
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0005CB88 File Offset: 0x0005AD88
		public unsafe INavigableSet TailSet(Java.Lang.Object fromElement, bool inclusive)
		{
			if (this.id_tailSet_Ljava_lang_Object_Z == IntPtr.Zero)
			{
				this.id_tailSet_Ljava_lang_Object_Z = JNIEnv.GetMethodID(this.class_ref, "tailSet", "(Ljava/lang/Object;Z)Ljava/util/NavigableSet;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(inclusive);
			INavigableSet @object = Java.Lang.Object.GetObject<INavigableSet>(JNIEnv.CallObjectMethod(base.Handle, this.id_tailSet_Ljava_lang_Object_Z, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x0005CC14 File Offset: 0x0005AE14
		public IComparator Comparator()
		{
			if (this.id_comparator == IntPtr.Zero)
			{
				this.id_comparator = JNIEnv.GetMethodID(this.class_ref, "comparator", "()Ljava/util/Comparator;");
			}
			return Java.Lang.Object.GetObject<IComparator>(JNIEnv.CallObjectMethod(base.Handle, this.id_comparator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x0005CC68 File Offset: 0x0005AE68
		public Java.Lang.Object First()
		{
			if (this.id_first == IntPtr.Zero)
			{
				this.id_first = JNIEnv.GetMethodID(this.class_ref, "first", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_first), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0005CCBC File Offset: 0x0005AEBC
		public Java.Lang.Object Last()
		{
			if (this.id_last == IntPtr.Zero)
			{
				this.id_last = JNIEnv.GetMethodID(this.class_ref, "last", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_last), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0005CD0D File Offset: 0x0005AF0D
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

		// Token: 0x06002133 RID: 8499 RVA: 0x0005CD50 File Offset: 0x0005AF50
		public unsafe bool Add(Java.Lang.Object e)
		{
			if (this.id_add_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "add", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_add_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x0005CDC4 File Offset: 0x0005AFC4
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

		// Token: 0x06002135 RID: 8501 RVA: 0x0005CE35 File Offset: 0x0005B035
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x0005CE78 File Offset: 0x0005B078
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

		// Token: 0x06002137 RID: 8503 RVA: 0x0005CEEC File Offset: 0x0005B0EC
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

		// Token: 0x06002138 RID: 8504 RVA: 0x0005CF60 File Offset: 0x0005B160
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

		// Token: 0x06002139 RID: 8505 RVA: 0x0005CFD3 File Offset: 0x0005B1D3
		public new int GetHashCode()
		{
			if (this.id_hashCode == IntPtr.Zero)
			{
				this.id_hashCode = JNIEnv.GetMethodID(this.class_ref, "hashCode", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_hashCode);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x0005D014 File Offset: 0x0005B214
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

		// Token: 0x0600213B RID: 8507 RVA: 0x0005D088 File Offset: 0x0005B288
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

		// Token: 0x0600213C RID: 8508 RVA: 0x0005D0FC File Offset: 0x0005B2FC
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

		// Token: 0x0600213D RID: 8509 RVA: 0x0005D16D File Offset: 0x0005B36D
		public int Size()
		{
			if (this.id_size == IntPtr.Zero)
			{
				this.id_size = JNIEnv.GetMethodID(this.class_ref, "size", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_size);
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0005D1B0 File Offset: 0x0005B3B0
		public Java.Lang.Object[] ToArray()
		{
			if (this.id_toArray == IntPtr.Zero)
			{
				this.id_toArray = JNIEnv.GetMethodID(this.class_ref, "toArray", "()[Ljava/lang/Object;");
			}
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_toArray), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0005D210 File Offset: 0x0005B410
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

		// Token: 0x04000D7A RID: 3450
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/NavigableSet", typeof(INavigableSetInvoker));

		// Token: 0x04000D7B RID: 3451
		private IntPtr class_ref;

		// Token: 0x04000D7C RID: 3452
		private static Delegate cb_ceiling_Ljava_lang_Object_;

		// Token: 0x04000D7D RID: 3453
		private IntPtr id_ceiling_Ljava_lang_Object_;

		// Token: 0x04000D7E RID: 3454
		private static Delegate cb_descendingIterator;

		// Token: 0x04000D7F RID: 3455
		private IntPtr id_descendingIterator;

		// Token: 0x04000D80 RID: 3456
		private static Delegate cb_descendingSet;

		// Token: 0x04000D81 RID: 3457
		private IntPtr id_descendingSet;

		// Token: 0x04000D82 RID: 3458
		private static Delegate cb_floor_Ljava_lang_Object_;

		// Token: 0x04000D83 RID: 3459
		private IntPtr id_floor_Ljava_lang_Object_;

		// Token: 0x04000D84 RID: 3460
		private static Delegate cb_headSet_Ljava_lang_Object_;

		// Token: 0x04000D85 RID: 3461
		private IntPtr id_headSet_Ljava_lang_Object_;

		// Token: 0x04000D86 RID: 3462
		private static Delegate cb_headSet_Ljava_lang_Object_Z;

		// Token: 0x04000D87 RID: 3463
		private IntPtr id_headSet_Ljava_lang_Object_Z;

		// Token: 0x04000D88 RID: 3464
		private static Delegate cb_higher_Ljava_lang_Object_;

		// Token: 0x04000D89 RID: 3465
		private IntPtr id_higher_Ljava_lang_Object_;

		// Token: 0x04000D8A RID: 3466
		private static Delegate cb_iterator;

		// Token: 0x04000D8B RID: 3467
		private IntPtr id_iterator;

		// Token: 0x04000D8C RID: 3468
		private static Delegate cb_lower_Ljava_lang_Object_;

		// Token: 0x04000D8D RID: 3469
		private IntPtr id_lower_Ljava_lang_Object_;

		// Token: 0x04000D8E RID: 3470
		private static Delegate cb_pollFirst;

		// Token: 0x04000D8F RID: 3471
		private IntPtr id_pollFirst;

		// Token: 0x04000D90 RID: 3472
		private static Delegate cb_pollLast;

		// Token: 0x04000D91 RID: 3473
		private IntPtr id_pollLast;

		// Token: 0x04000D92 RID: 3474
		private static Delegate cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z;

		// Token: 0x04000D93 RID: 3475
		private IntPtr id_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z;

		// Token: 0x04000D94 RID: 3476
		private static Delegate cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D95 RID: 3477
		private IntPtr id_subSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000D96 RID: 3478
		private static Delegate cb_tailSet_Ljava_lang_Object_;

		// Token: 0x04000D97 RID: 3479
		private IntPtr id_tailSet_Ljava_lang_Object_;

		// Token: 0x04000D98 RID: 3480
		private static Delegate cb_tailSet_Ljava_lang_Object_Z;

		// Token: 0x04000D99 RID: 3481
		private IntPtr id_tailSet_Ljava_lang_Object_Z;

		// Token: 0x04000D9A RID: 3482
		private IntPtr id_comparator;

		// Token: 0x04000D9B RID: 3483
		private IntPtr id_first;

		// Token: 0x04000D9C RID: 3484
		private IntPtr id_last;

		// Token: 0x04000D9D RID: 3485
		private IntPtr id_isEmpty;

		// Token: 0x04000D9E RID: 3486
		private IntPtr id_add_Ljava_lang_Object_;

		// Token: 0x04000D9F RID: 3487
		private IntPtr id_addAll_Ljava_util_Collection_;

		// Token: 0x04000DA0 RID: 3488
		private IntPtr id_clear;

		// Token: 0x04000DA1 RID: 3489
		private IntPtr id_contains_Ljava_lang_Object_;

		// Token: 0x04000DA2 RID: 3490
		private IntPtr id_containsAll_Ljava_util_Collection_;

		// Token: 0x04000DA3 RID: 3491
		private IntPtr id_equals_Ljava_lang_Object_;

		// Token: 0x04000DA4 RID: 3492
		private IntPtr id_hashCode;

		// Token: 0x04000DA5 RID: 3493
		private IntPtr id_remove_Ljava_lang_Object_;

		// Token: 0x04000DA6 RID: 3494
		private IntPtr id_removeAll_Ljava_util_Collection_;

		// Token: 0x04000DA7 RID: 3495
		private IntPtr id_retainAll_Ljava_util_Collection_;

		// Token: 0x04000DA8 RID: 3496
		private IntPtr id_size;

		// Token: 0x04000DA9 RID: 3497
		private IntPtr id_toArray;

		// Token: 0x04000DAA RID: 3498
		private IntPtr id_toArray_arrayLjava_lang_Object_;
	}
}
