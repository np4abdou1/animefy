using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000326 RID: 806
	[Register("java/util/TreeSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public class TreeSet : AbstractSet, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, INavigableSet, ISortedSet, ISet, ICollection, IIterable
	{
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x000609F7 File Offset: 0x0005EBF7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TreeSet._members;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x00060A00 File Offset: 0x0005EC00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TreeSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00060A24 File Offset: 0x0005EC24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TreeSet._members.ManagedPeerType;
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00053ADF File Offset: 0x00051CDF
		protected TreeSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00060A30 File Offset: 0x0005EC30
		private static Delegate GetCeiling_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_ceiling_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_ceiling_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_Ceiling_Ljava_lang_Object_));
			}
			return TreeSet.cb_ceiling_Ljava_lang_Object_;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00060A54 File Offset: 0x0005EC54
		private static IntPtr n_Ceiling_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Ceiling(object2));
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00060A7C File Offset: 0x0005EC7C
		public unsafe virtual Java.Lang.Object Ceiling(Java.Lang.Object e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("ceiling.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00060AF0 File Offset: 0x0005ECF0
		private static Delegate GetComparatorHandler()
		{
			if (TreeSet.cb_comparator == null)
			{
				TreeSet.cb_comparator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_Comparator));
			}
			return TreeSet.cb_comparator;
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00060B14 File Offset: 0x0005ED14
		private static IntPtr n_Comparator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Comparator());
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00060B28 File Offset: 0x0005ED28
		public virtual IComparator Comparator()
		{
			return Java.Lang.Object.GetObject<IComparator>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("comparator.()Ljava/util/Comparator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00060B5A File Offset: 0x0005ED5A
		private static Delegate GetDescendingIteratorHandler()
		{
			if (TreeSet.cb_descendingIterator == null)
			{
				TreeSet.cb_descendingIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_DescendingIterator));
			}
			return TreeSet.cb_descendingIterator;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00060B7E File Offset: 0x0005ED7E
		private static IntPtr n_DescendingIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescendingIterator());
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00060B94 File Offset: 0x0005ED94
		public virtual IIterator DescendingIterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("descendingIterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00060BC6 File Offset: 0x0005EDC6
		private static Delegate GetDescendingSetHandler()
		{
			if (TreeSet.cb_descendingSet == null)
			{
				TreeSet.cb_descendingSet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_DescendingSet));
			}
			return TreeSet.cb_descendingSet;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00060BEA File Offset: 0x0005EDEA
		private static IntPtr n_DescendingSet(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescendingSet());
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00060C00 File Offset: 0x0005EE00
		public virtual INavigableSet DescendingSet()
		{
			return Java.Lang.Object.GetObject<INavigableSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("descendingSet.()Ljava/util/NavigableSet;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00060C32 File Offset: 0x0005EE32
		private static Delegate GetFirstHandler()
		{
			if (TreeSet.cb_first == null)
			{
				TreeSet.cb_first = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_First));
			}
			return TreeSet.cb_first;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00060C56 File Offset: 0x0005EE56
		private static IntPtr n_First(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).First());
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00060C6C File Offset: 0x0005EE6C
		public virtual Java.Lang.Object First()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("first.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00060C9E File Offset: 0x0005EE9E
		private static Delegate GetFloor_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_floor_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_floor_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_Floor_Ljava_lang_Object_));
			}
			return TreeSet.cb_floor_Ljava_lang_Object_;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00060CC4 File Offset: 0x0005EEC4
		private static IntPtr n_Floor_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Floor(object2));
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00060CEC File Offset: 0x0005EEEC
		public unsafe virtual Java.Lang.Object Floor(Java.Lang.Object e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("floor.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00060D60 File Offset: 0x0005EF60
		private static Delegate GetHeadSet_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_headSet_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_headSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_HeadSet_Ljava_lang_Object_));
			}
			return TreeSet.cb_headSet_Ljava_lang_Object_;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00060D84 File Offset: 0x0005EF84
		private static IntPtr n_HeadSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_toElement)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HeadSet(object2));
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00060DAC File Offset: 0x0005EFAC
		public unsafe virtual ISortedSet HeadSet(Java.Lang.Object toElement)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(toElement);
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISortedSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("headSet.(Ljava/lang/Object;)Ljava/util/SortedSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(toElement);
			}
			return @object;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00060E20 File Offset: 0x0005F020
		private static Delegate GetHeadSet_Ljava_lang_Object_ZHandler()
		{
			if (TreeSet.cb_headSet_Ljava_lang_Object_Z == null)
			{
				TreeSet.cb_headSet_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(TreeSet.n_HeadSet_Ljava_lang_Object_Z));
			}
			return TreeSet.cb_headSet_Ljava_lang_Object_Z;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00060E44 File Offset: 0x0005F044
		private static IntPtr n_HeadSet_Ljava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_toElement, bool inclusive)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.HeadSet(object2, inclusive));
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00060E70 File Offset: 0x0005F070
		public unsafe virtual INavigableSet HeadSet(Java.Lang.Object toElement, bool inclusive)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(toElement);
			INavigableSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(inclusive);
				@object = Java.Lang.Object.GetObject<INavigableSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("headSet.(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(toElement);
			}
			return @object;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00060EF4 File Offset: 0x0005F0F4
		private static Delegate GetHigher_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_higher_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_higher_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_Higher_Ljava_lang_Object_));
			}
			return TreeSet.cb_higher_Ljava_lang_Object_;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00060F18 File Offset: 0x0005F118
		private static IntPtr n_Higher_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Higher(object2));
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00060F40 File Offset: 0x0005F140
		public unsafe virtual Java.Lang.Object Higher(Java.Lang.Object e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("higher.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00060FB4 File Offset: 0x0005F1B4
		private static Delegate GetIteratorHandler()
		{
			if (TreeSet.cb_iterator == null)
			{
				TreeSet.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_Iterator));
			}
			return TreeSet.cb_iterator;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00060FEC File Offset: 0x0005F1EC
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0006101E File Offset: 0x0005F21E
		private static Delegate GetLastHandler()
		{
			if (TreeSet.cb_last == null)
			{
				TreeSet.cb_last = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_Last));
			}
			return TreeSet.cb_last;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00061042 File Offset: 0x0005F242
		private static IntPtr n_Last(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Last());
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00061058 File Offset: 0x0005F258
		public virtual Java.Lang.Object Last()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("last.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0006108A File Offset: 0x0005F28A
		private static Delegate GetLower_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_lower_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_lower_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_Lower_Ljava_lang_Object_));
			}
			return TreeSet.cb_lower_Ljava_lang_Object_;
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x000610B0 File Offset: 0x0005F2B0
		private static IntPtr n_Lower_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Lower(object2));
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x000610D8 File Offset: 0x0005F2D8
		public unsafe virtual Java.Lang.Object Lower(Java.Lang.Object e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(e);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("lower.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(e);
			}
			return @object;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0006114C File Offset: 0x0005F34C
		private static Delegate GetPollFirstHandler()
		{
			if (TreeSet.cb_pollFirst == null)
			{
				TreeSet.cb_pollFirst = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_PollFirst));
			}
			return TreeSet.cb_pollFirst;
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00061170 File Offset: 0x0005F370
		private static IntPtr n_PollFirst(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PollFirst());
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00061184 File Offset: 0x0005F384
		public virtual Java.Lang.Object PollFirst()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("pollFirst.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000611B6 File Offset: 0x0005F3B6
		private static Delegate GetPollLastHandler()
		{
			if (TreeSet.cb_pollLast == null)
			{
				TreeSet.cb_pollLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_PollLast));
			}
			return TreeSet.cb_pollLast;
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x000611DA File Offset: 0x0005F3DA
		private static IntPtr n_PollLast(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PollLast());
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x000611F0 File Offset: 0x0005F3F0
		public virtual Java.Lang.Object PollLast()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("pollLast.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00061222 File Offset: 0x0005F422
		private static Delegate GetSizeHandler()
		{
			if (TreeSet.cb_size == null)
			{
				TreeSet.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TreeSet.n_Size));
			}
			return TreeSet.cb_size;
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00061246 File Offset: 0x0005F446
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00061255 File Offset: 0x0005F455
		public override int Size()
		{
			return TreeSet._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0006126E File Offset: 0x0005F46E
		private static Delegate GetSpliteratorHandler()
		{
			if (TreeSet.cb_spliterator == null)
			{
				TreeSet.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TreeSet.n_Spliterator));
			}
			return TreeSet.cb_spliterator;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00061292 File Offset: 0x0005F492
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x000612A8 File Offset: 0x0005F4A8
		public virtual ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x000612DA File Offset: 0x0005F4DA
		private static Delegate GetSubSet_Ljava_lang_Object_ZLjava_lang_Object_ZHandler()
		{
			if (TreeSet.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z == null)
			{
				TreeSet.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZLZ_L(TreeSet.n_SubSet_Ljava_lang_Object_ZLjava_lang_Object_Z));
			}
			return TreeSet.cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z;
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00061300 File Offset: 0x0005F500
		private static IntPtr n_SubSet_Ljava_lang_Object_ZLjava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, bool fromInclusive, IntPtr native_toElement, bool toInclusive)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubSet(object2, fromInclusive, object3, toInclusive));
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00061338 File Offset: 0x0005F538
		public unsafe virtual INavigableSet SubSet(Java.Lang.Object fromElement, bool fromInclusive, Java.Lang.Object toElement, bool toInclusive)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(toElement);
			INavigableSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromInclusive);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(toInclusive);
				@object = Java.Lang.Object.GetObject<INavigableSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("subSet.(Ljava/lang/Object;ZLjava/lang/Object;Z)Ljava/util/NavigableSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(fromElement);
				GC.KeepAlive(toElement);
			}
			return @object;
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00061400 File Offset: 0x0005F600
		private static Delegate GetSubSet_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(TreeSet.n_SubSet_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return TreeSet.cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00061424 File Offset: 0x0005F624
		private static IntPtr n_SubSet_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, IntPtr native_toElement)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_toElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SubSet(object2, object3));
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00061458 File Offset: 0x0005F658
		public unsafe virtual ISortedSet SubSet(Java.Lang.Object fromElement, Java.Lang.Object toElement)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(toElement);
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ISortedSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("subSet.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(fromElement);
				GC.KeepAlive(toElement);
			}
			return @object;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000614F4 File Offset: 0x0005F6F4
		private static Delegate GetTailSet_Ljava_lang_Object_Handler()
		{
			if (TreeSet.cb_tailSet_Ljava_lang_Object_ == null)
			{
				TreeSet.cb_tailSet_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TreeSet.n_TailSet_Ljava_lang_Object_));
			}
			return TreeSet.cb_tailSet_Ljava_lang_Object_;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00061518 File Offset: 0x0005F718
		private static IntPtr n_TailSet_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TailSet(object2));
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00061540 File Offset: 0x0005F740
		public unsafe virtual ISortedSet TailSet(Java.Lang.Object fromElement)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			ISortedSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISortedSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("tailSet.(Ljava/lang/Object;)Ljava/util/SortedSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fromElement);
			}
			return @object;
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000615B4 File Offset: 0x0005F7B4
		private static Delegate GetTailSet_Ljava_lang_Object_ZHandler()
		{
			if (TreeSet.cb_tailSet_Ljava_lang_Object_Z == null)
			{
				TreeSet.cb_tailSet_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(TreeSet.n_TailSet_Ljava_lang_Object_Z));
			}
			return TreeSet.cb_tailSet_Ljava_lang_Object_Z;
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000615D8 File Offset: 0x0005F7D8
		private static IntPtr n_TailSet_Ljava_lang_Object_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_fromElement, bool inclusive)
		{
			TreeSet @object = Java.Lang.Object.GetObject<TreeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_fromElement, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TailSet(object2, inclusive));
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00061604 File Offset: 0x0005F804
		public unsafe virtual INavigableSet TailSet(Java.Lang.Object fromElement, bool inclusive)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fromElement);
			INavigableSet @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(inclusive);
				@object = Java.Lang.Object.GetObject<INavigableSet>(TreeSet._members.InstanceMethods.InvokeVirtualObjectMethod("tailSet.(Ljava/lang/Object;Z)Ljava/util/NavigableSet;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(fromElement);
			}
			return @object;
		}

		// Token: 0x04000E1D RID: 3613
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/TreeSet", typeof(TreeSet));

		// Token: 0x04000E1E RID: 3614
		private static Delegate cb_ceiling_Ljava_lang_Object_;

		// Token: 0x04000E1F RID: 3615
		private static Delegate cb_comparator;

		// Token: 0x04000E20 RID: 3616
		private static Delegate cb_descendingIterator;

		// Token: 0x04000E21 RID: 3617
		private static Delegate cb_descendingSet;

		// Token: 0x04000E22 RID: 3618
		private static Delegate cb_first;

		// Token: 0x04000E23 RID: 3619
		private static Delegate cb_floor_Ljava_lang_Object_;

		// Token: 0x04000E24 RID: 3620
		private static Delegate cb_headSet_Ljava_lang_Object_;

		// Token: 0x04000E25 RID: 3621
		private static Delegate cb_headSet_Ljava_lang_Object_Z;

		// Token: 0x04000E26 RID: 3622
		private static Delegate cb_higher_Ljava_lang_Object_;

		// Token: 0x04000E27 RID: 3623
		private static Delegate cb_iterator;

		// Token: 0x04000E28 RID: 3624
		private static Delegate cb_last;

		// Token: 0x04000E29 RID: 3625
		private static Delegate cb_lower_Ljava_lang_Object_;

		// Token: 0x04000E2A RID: 3626
		private static Delegate cb_pollFirst;

		// Token: 0x04000E2B RID: 3627
		private static Delegate cb_pollLast;

		// Token: 0x04000E2C RID: 3628
		private static Delegate cb_size;

		// Token: 0x04000E2D RID: 3629
		private static Delegate cb_spliterator;

		// Token: 0x04000E2E RID: 3630
		private static Delegate cb_subSet_Ljava_lang_Object_ZLjava_lang_Object_Z;

		// Token: 0x04000E2F RID: 3631
		private static Delegate cb_subSet_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000E30 RID: 3632
		private static Delegate cb_tailSet_Ljava_lang_Object_;

		// Token: 0x04000E31 RID: 3633
		private static Delegate cb_tailSet_Ljava_lang_Object_Z;
	}
}
