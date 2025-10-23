using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager.Widget
{
	// Token: 0x0200001E RID: 30
	[Register("androidx/viewpager/widget/PagerAdapter", DoNotGenerateAcw = true)]
	public abstract class PagerAdapter : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return PagerAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PagerAdapter._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PagerAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PagerAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000020DC File Offset: 0x000002DC
		protected PagerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public PagerAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PagerAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PagerAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002156 File Offset: 0x00000356
		private static Delegate GetGetCountHandler()
		{
			if (PagerAdapter.cb_getCount == null)
			{
				PagerAdapter.cb_getCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(PagerAdapter.n_GetCount));
			}
			return PagerAdapter.cb_getCount;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000217A File Offset: 0x0000037A
		private static int n_GetCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Count;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000070 RID: 112
		public abstract int Count { [Register("getCount", "()I", "GetGetCountHandler")] get; }

		// Token: 0x06000071 RID: 113 RVA: 0x00002189 File Offset: 0x00000389
		private static Delegate GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_destroyItem_Landroid_view_View_ILjava_lang_Object_ == null)
			{
				PagerAdapter.cb_destroyItem_Landroid_view_View_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(PagerAdapter.n_DestroyItem_Landroid_view_View_ILjava_lang_Object_));
			}
			return PagerAdapter.cb_destroyItem_Landroid_view_View_ILjava_lang_Object_;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021B0 File Offset: 0x000003B0
		private static void n_DestroyItem_Landroid_view_View_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_container, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			@object.DestroyItem(object2, position, object3);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000021E0 File Offset: 0x000003E0
		[Register("destroyItem", "(Landroid/view/View;ILjava/lang/Object;)V", "GetDestroyItem_Landroid_view_View_ILjava_lang_Object_Handler")]
		public unsafe virtual void DestroyItem(View container, int position, Java.Lang.Object @object)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("destroyItem.(Landroid/view/View;ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002284 File Offset: 0x00000484
		private static Delegate GetDestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == null)
			{
				PagerAdapter.cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(PagerAdapter.n_DestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_));
			}
			return PagerAdapter.cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000022A8 File Offset: 0x000004A8
		private static void n_DestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			@object.DestroyItem(object2, position, object3);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000022D8 File Offset: 0x000004D8
		[Register("destroyItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetDestroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		public unsafe virtual void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("destroyItem.(Landroid/view/ViewGroup;ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000237C File Offset: 0x0000057C
		private static Delegate GetFinishUpdate_Landroid_view_View_Handler()
		{
			if (PagerAdapter.cb_finishUpdate_Landroid_view_View_ == null)
			{
				PagerAdapter.cb_finishUpdate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_FinishUpdate_Landroid_view_View_));
			}
			return PagerAdapter.cb_finishUpdate_Landroid_view_View_;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000023A0 File Offset: 0x000005A0
		private static void n_FinishUpdate_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.FinishUpdate(object2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000023C4 File Offset: 0x000005C4
		[Register("finishUpdate", "(Landroid/view/View;)V", "GetFinishUpdate_Landroid_view_View_Handler")]
		public unsafe virtual void FinishUpdate(View container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("finishUpdate.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002428 File Offset: 0x00000628
		private static Delegate GetFinishUpdate_Landroid_view_ViewGroup_Handler()
		{
			if (PagerAdapter.cb_finishUpdate_Landroid_view_ViewGroup_ == null)
			{
				PagerAdapter.cb_finishUpdate_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_FinishUpdate_Landroid_view_ViewGroup_));
			}
			return PagerAdapter.cb_finishUpdate_Landroid_view_ViewGroup_;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000244C File Offset: 0x0000064C
		private static void n_FinishUpdate_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.FinishUpdate(object2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002470 File Offset: 0x00000670
		[Register("finishUpdate", "(Landroid/view/ViewGroup;)V", "GetFinishUpdate_Landroid_view_ViewGroup_Handler")]
		public unsafe virtual void FinishUpdate(ViewGroup container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("finishUpdate.(Landroid/view/ViewGroup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000024D4 File Offset: 0x000006D4
		private static Delegate GetGetItemPosition_Ljava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_getItemPosition_Ljava_lang_Object_ == null)
			{
				PagerAdapter.cb_getItemPosition_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(PagerAdapter.n_GetItemPosition_Ljava_lang_Object_));
			}
			return PagerAdapter.cb_getItemPosition_Ljava_lang_Object_;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024F8 File Offset: 0x000006F8
		private static int n_GetItemPosition_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			return @object.GetItemPosition(object2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000251C File Offset: 0x0000071C
		[Register("getItemPosition", "(Ljava/lang/Object;)I", "GetGetItemPosition_Ljava_lang_Object_Handler")]
		public unsafe virtual int GetItemPosition(Java.Lang.Object @object)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				result = PagerAdapter._members.InstanceMethods.InvokeVirtualInt32Method("getItemPosition.(Ljava/lang/Object;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@object);
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002584 File Offset: 0x00000784
		private static Delegate GetGetPageTitle_IHandler()
		{
			if (PagerAdapter.cb_getPageTitle_I == null)
			{
				PagerAdapter.cb_getPageTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(PagerAdapter.n_GetPageTitle_I));
			}
			return PagerAdapter.cb_getPageTitle_I;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000025A8 File Offset: 0x000007A8
		private static IntPtr n_GetPageTitle_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetPageTitleFormatted(position));
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000025C0 File Offset: 0x000007C0
		[Register("getPageTitle", "(I)Ljava/lang/CharSequence;", "GetGetPageTitle_IHandler")]
		public unsafe virtual ICharSequence GetPageTitleFormatted(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<ICharSequence>(PagerAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getPageTitle.(I)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002609 File Offset: 0x00000809
		public string GetPageTitle(int position)
		{
			ICharSequence pageTitleFormatted = this.GetPageTitleFormatted(position);
			if (pageTitleFormatted == null)
			{
				return null;
			}
			return pageTitleFormatted.ToString();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000261D File Offset: 0x0000081D
		private static Delegate GetGetPageWidth_IHandler()
		{
			if (PagerAdapter.cb_getPageWidth_I == null)
			{
				PagerAdapter.cb_getPageWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_F(PagerAdapter.n_GetPageWidth_I));
			}
			return PagerAdapter.cb_getPageWidth_I;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002641 File Offset: 0x00000841
		private static float n_GetPageWidth_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			return Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetPageWidth(position);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002654 File Offset: 0x00000854
		[Register("getPageWidth", "(I)F", "GetGetPageWidth_IHandler")]
		public unsafe virtual float GetPageWidth(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return PagerAdapter._members.InstanceMethods.InvokeVirtualSingleMethod("getPageWidth.(I)F", this, ptr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000268F File Offset: 0x0000088F
		private static Delegate GetInstantiateItem_Landroid_view_View_IHandler()
		{
			if (PagerAdapter.cb_instantiateItem_Landroid_view_View_I == null)
			{
				PagerAdapter.cb_instantiateItem_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(PagerAdapter.n_InstantiateItem_Landroid_view_View_I));
			}
			return PagerAdapter.cb_instantiateItem_Landroid_view_View_I;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000026B4 File Offset: 0x000008B4
		private static IntPtr n_InstantiateItem_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_container, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InstantiateItem(object2, position));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000026E0 File Offset: 0x000008E0
		[Register("instantiateItem", "(Landroid/view/View;I)Ljava/lang/Object;", "GetInstantiateItem_Landroid_view_View_IHandler")]
		public unsafe virtual Java.Lang.Object InstantiateItem(View container, int position)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PagerAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("instantiateItem.(Landroid/view/View;I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(container);
			}
			return @object;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002768 File Offset: 0x00000968
		private static Delegate GetInstantiateItem_Landroid_view_ViewGroup_IHandler()
		{
			if (PagerAdapter.cb_instantiateItem_Landroid_view_ViewGroup_I == null)
			{
				PagerAdapter.cb_instantiateItem_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(PagerAdapter.n_InstantiateItem_Landroid_view_ViewGroup_I));
			}
			return PagerAdapter.cb_instantiateItem_Landroid_view_ViewGroup_I;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000278C File Offset: 0x0000098C
		private static IntPtr n_InstantiateItem_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.InstantiateItem(object2, position));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000027B8 File Offset: 0x000009B8
		[Register("instantiateItem", "(Landroid/view/ViewGroup;I)Ljava/lang/Object;", "GetInstantiateItem_Landroid_view_ViewGroup_IHandler")]
		public unsafe virtual Java.Lang.Object InstantiateItem(ViewGroup container, int position)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PagerAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("instantiateItem.(Landroid/view/ViewGroup;I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(container);
			}
			return @object;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002840 File Offset: 0x00000A40
		private static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
			{
				PagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(PagerAdapter.n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_));
			}
			return PagerAdapter.cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002864 File Offset: 0x00000A64
		private static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			return @object.IsViewFromObject(object2, object3);
		}

		// Token: 0x0600008F RID: 143
		[Register("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public abstract bool IsViewFromObject(View view, Java.Lang.Object @object);

		// Token: 0x06000090 RID: 144 RVA: 0x00002890 File Offset: 0x00000A90
		private static Delegate GetNotifyDataSetChangedHandler()
		{
			if (PagerAdapter.cb_notifyDataSetChanged == null)
			{
				PagerAdapter.cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PagerAdapter.n_NotifyDataSetChanged));
			}
			return PagerAdapter.cb_notifyDataSetChanged;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000028B4 File Offset: 0x00000AB4
		private static void n_NotifyDataSetChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NotifyDataSetChanged();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000028C3 File Offset: 0x00000AC3
		[Register("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual void NotifyDataSetChanged()
		{
			PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("notifyDataSetChanged.()V", this, null);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000028DC File Offset: 0x00000ADC
		private static Delegate GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (PagerAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				PagerAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_RegisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return PagerAdapter.cb_registerDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002900 File Offset: 0x00000B00
		private static void n_RegisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterDataSetObserver(object2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002924 File Offset: 0x00000B24
		[Register("registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetRegisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public unsafe virtual void RegisterDataSetObserver(DataSetObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("registerDataSetObserver.(Landroid/database/DataSetObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002988 File Offset: 0x00000B88
		private static Delegate GetRestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_Handler()
		{
			if (PagerAdapter.cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ == null)
			{
				PagerAdapter.cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(PagerAdapter.n_RestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_));
			}
			return PagerAdapter.cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000029AC File Offset: 0x00000BAC
		private static void n_RestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_(IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_loader)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			ClassLoader object3 = Java.Lang.Object.GetObject<ClassLoader>(native_loader, JniHandleOwnership.DoNotTransfer);
			@object.RestoreState(object2, object3);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000029D8 File Offset: 0x00000BD8
		[Register("restoreState", "(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V", "GetRestoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_Handler")]
		public unsafe virtual void RestoreState(IParcelable state, ClassLoader loader)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				ptr[1] = new JniArgumentValue((loader == null) ? IntPtr.Zero : loader.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("restoreState.(Landroid/os/Parcelable;Ljava/lang/ClassLoader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
				GC.KeepAlive(loader);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002A68 File Offset: 0x00000C68
		private static Delegate GetSaveStateHandler()
		{
			if (PagerAdapter.cb_saveState == null)
			{
				PagerAdapter.cb_saveState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PagerAdapter.n_SaveState));
			}
			return PagerAdapter.cb_saveState;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002A8C File Offset: 0x00000C8C
		private static IntPtr n_SaveState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveState());
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[Register("saveState", "()Landroid/os/Parcelable;", "GetSaveStateHandler")]
		public virtual IParcelable SaveState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(PagerAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("saveState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002AD2 File Offset: 0x00000CD2
		private static Delegate GetSetPrimaryItem_Landroid_view_View_ILjava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ == null)
			{
				PagerAdapter.cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(PagerAdapter.n_SetPrimaryItem_Landroid_view_View_ILjava_lang_Object_));
			}
			return PagerAdapter.cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private static void n_SetPrimaryItem_Landroid_view_View_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_container, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			@object.SetPrimaryItem(object2, position, object3);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B28 File Offset: 0x00000D28
		[Register("setPrimaryItem", "(Landroid/view/View;ILjava/lang/Object;)V", "GetSetPrimaryItem_Landroid_view_View_ILjava_lang_Object_Handler")]
		public unsafe virtual void SetPrimaryItem(View container, int position, Java.Lang.Object @object)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setPrimaryItem.(Landroid/view/View;ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002BCC File Offset: 0x00000DCC
		private static Delegate GetSetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler()
		{
			if (PagerAdapter.cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ == null)
			{
				PagerAdapter.cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_V(PagerAdapter.n_SetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_));
			}
			return PagerAdapter.cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002BF0 File Offset: 0x00000DF0
		private static void n_SetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_container, int position, IntPtr native__object)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native__object, JniHandleOwnership.DoNotTransfer);
			@object.SetPrimaryItem(object2, position, object3);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002C20 File Offset: 0x00000E20
		[Register("setPrimaryItem", "(Landroid/view/ViewGroup;ILjava/lang/Object;)V", "GetSetPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_Handler")]
		public unsafe virtual void SetPrimaryItem(ViewGroup container, int position, Java.Lang.Object @object)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setPrimaryItem.(Landroid/view/ViewGroup;ILjava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002CC4 File Offset: 0x00000EC4
		private static Delegate GetStartUpdate_Landroid_view_View_Handler()
		{
			if (PagerAdapter.cb_startUpdate_Landroid_view_View_ == null)
			{
				PagerAdapter.cb_startUpdate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_StartUpdate_Landroid_view_View_));
			}
			return PagerAdapter.cb_startUpdate_Landroid_view_View_;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002CE8 File Offset: 0x00000EE8
		private static void n_StartUpdate_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.StartUpdate(object2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002D0C File Offset: 0x00000F0C
		[Register("startUpdate", "(Landroid/view/View;)V", "GetStartUpdate_Landroid_view_View_Handler")]
		public unsafe virtual void StartUpdate(View container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("startUpdate.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002D70 File Offset: 0x00000F70
		private static Delegate GetStartUpdate_Landroid_view_ViewGroup_Handler()
		{
			if (PagerAdapter.cb_startUpdate_Landroid_view_ViewGroup_ == null)
			{
				PagerAdapter.cb_startUpdate_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_StartUpdate_Landroid_view_ViewGroup_));
			}
			return PagerAdapter.cb_startUpdate_Landroid_view_ViewGroup_;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002D94 File Offset: 0x00000F94
		private static void n_StartUpdate_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_container)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_container, JniHandleOwnership.DoNotTransfer);
			@object.StartUpdate(object2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002DB8 File Offset: 0x00000FB8
		[Register("startUpdate", "(Landroid/view/ViewGroup;)V", "GetStartUpdate_Landroid_view_ViewGroup_Handler")]
		public unsafe virtual void StartUpdate(ViewGroup container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("startUpdate.(Landroid/view/ViewGroup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002E1C File Offset: 0x0000101C
		private static Delegate GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler()
		{
			if (PagerAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ == null)
			{
				PagerAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PagerAdapter.n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_));
			}
			return PagerAdapter.cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002E40 File Offset: 0x00001040
		private static void n_UnregisterDataSetObserver_Landroid_database_DataSetObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			PagerAdapter @object = Java.Lang.Object.GetObject<PagerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSetObserver object2 = Java.Lang.Object.GetObject<DataSetObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterDataSetObserver(object2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002E64 File Offset: 0x00001064
		[Register("unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", "GetUnregisterDataSetObserver_Landroid_database_DataSetObserver_Handler")]
		public unsafe virtual void UnregisterDataSetObserver(DataSetObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : observer.Handle);
				PagerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterDataSetObserver.(Landroid/database/DataSetObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/PagerAdapter", typeof(PagerAdapter));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getCount;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_destroyItem_Landroid_view_View_ILjava_lang_Object_;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_destroyItem_Landroid_view_ViewGroup_ILjava_lang_Object_;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_finishUpdate_Landroid_view_View_;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_finishUpdate_Landroid_view_ViewGroup_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getItemPosition_Ljava_lang_Object_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getPageTitle_I;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getPageWidth_I;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_instantiateItem_Landroid_view_View_I;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_instantiateItem_Landroid_view_ViewGroup_I;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_notifyDataSetChanged;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_registerDataSetObserver_Landroid_database_DataSetObserver_;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_restoreState_Landroid_os_Parcelable_Ljava_lang_ClassLoader_;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_saveState;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_setPrimaryItem_Landroid_view_View_ILjava_lang_Object_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_setPrimaryItem_Landroid_view_ViewGroup_ILjava_lang_Object_;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_startUpdate_Landroid_view_View_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_startUpdate_Landroid_view_ViewGroup_;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_unregisterDataSetObserver_Landroid_database_DataSetObserver_;
	}
}
