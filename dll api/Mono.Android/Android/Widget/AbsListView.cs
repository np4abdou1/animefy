using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A0 RID: 160
	[Register("android/widget/AbsListView", DoNotGenerateAcw = true)]
	public abstract class AbsListView : AdapterView<IListAdapter>, ITextWatcher, INoCopySpan, IJavaObject, IDisposable, IJavaPeerable, ViewTreeObserver.IOnGlobalLayoutListener, ViewTreeObserver.IOnTouchModeChangeListener, Filter.IFilterListener
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002F2F File Offset: 0x0000112F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbsListView._members;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002F38 File Offset: 0x00001138
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbsListView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00002F5C File Offset: 0x0000115C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbsListView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002F68 File Offset: 0x00001168
		protected AbsListView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002F74 File Offset: 0x00001174
		public unsafe AbsListView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(AbsListView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsListView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003050 File Offset: 0x00001250
		public unsafe AbsListView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(AbsListView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsListView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003140 File Offset: 0x00001340
		private static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler()
		{
			if (AbsListView.cb_afterTextChanged_Landroid_text_Editable_ == null)
			{
				AbsListView.cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbsListView.n_AfterTextChanged_Landroid_text_Editable_));
			}
			return AbsListView.cb_afterTextChanged_Landroid_text_Editable_;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003164 File Offset: 0x00001364
		private static void n_AfterTextChanged_Landroid_text_Editable_(IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			AbsListView @object = Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IEditable object2 = Java.Lang.Object.GetObject<IEditable>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.AfterTextChanged(object2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003188 File Offset: 0x00001388
		public unsafe virtual void AfterTextChanged(IEditable s)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((s == null) ? IntPtr.Zero : ((Java.Lang.Object)s).Handle);
				AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("afterTextChanged.(Landroid/text/Editable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(s);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000031F0 File Offset: 0x000013F0
		private static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler()
		{
			if (AbsListView.cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
			{
				AbsListView.cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(AbsListView.n_BeforeTextChanged_Ljava_lang_CharSequence_III));
			}
			return AbsListView.cb_beforeTextChanged_Ljava_lang_CharSequence_III;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003214 File Offset: 0x00001414
		private static void n_BeforeTextChanged_Ljava_lang_CharSequence_III(IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int count, int after)
		{
			AbsListView @object = Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.BeforeTextChanged(object2, start, count, after);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe virtual void BeforeTextChanged(ICharSequence s, int start, int count, int after)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(count);
				ptr[3] = new JniArgumentValue(after);
				AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("beforeTextChanged.(Ljava/lang/CharSequence;III)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000032E0 File Offset: 0x000014E0
		private static Delegate GetOnFilterComplete_IHandler()
		{
			if (AbsListView.cb_onFilterComplete_I == null)
			{
				AbsListView.cb_onFilterComplete_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AbsListView.n_OnFilterComplete_I));
			}
			return AbsListView.cb_onFilterComplete_I;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003304 File Offset: 0x00001504
		private static void n_OnFilterComplete_I(IntPtr jnienv, IntPtr native__this, int count)
		{
			Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFilterComplete(count);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003314 File Offset: 0x00001514
		public unsafe virtual void OnFilterComplete(int count)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(count);
			AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("onFilterComplete.(I)V", this, ptr);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000334F File Offset: 0x0000154F
		private static Delegate GetOnGlobalLayoutHandler()
		{
			if (AbsListView.cb_onGlobalLayout == null)
			{
				AbsListView.cb_onGlobalLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AbsListView.n_OnGlobalLayout));
			}
			return AbsListView.cb_onGlobalLayout;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003373 File Offset: 0x00001573
		private static void n_OnGlobalLayout(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGlobalLayout();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00003382 File Offset: 0x00001582
		public virtual void OnGlobalLayout()
		{
			AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("onGlobalLayout.()V", this, null);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000339B File Offset: 0x0000159B
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (AbsListView.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				AbsListView.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbsListView.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return AbsListView.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000033C0 File Offset: 0x000015C0
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			AbsListView @object = Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000033E4 File Offset: 0x000015E4
		public new unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000344C File Offset: 0x0000164C
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (AbsListView.cb_onSaveInstanceState == null)
			{
				AbsListView.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbsListView.n_OnSaveInstanceState));
			}
			return AbsListView.cb_onSaveInstanceState;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003470 File Offset: 0x00001670
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003484 File Offset: 0x00001684
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(AbsListView._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000034B6 File Offset: 0x000016B6
		private static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler()
		{
			if (AbsListView.cb_onTextChanged_Ljava_lang_CharSequence_III == null)
			{
				AbsListView.cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(AbsListView.n_OnTextChanged_Ljava_lang_CharSequence_III));
			}
			return AbsListView.cb_onTextChanged_Ljava_lang_CharSequence_III;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000034DC File Offset: 0x000016DC
		private static void n_OnTextChanged_Ljava_lang_CharSequence_III(IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int before, int count)
		{
			AbsListView @object = Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.OnTextChanged(object2, start, before, count);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003504 File Offset: 0x00001704
		public unsafe virtual void OnTextChanged(ICharSequence s, int start, int before, int count)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(before);
				ptr[3] = new JniArgumentValue(count);
				AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("onTextChanged.(Ljava/lang/CharSequence;III)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(s);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000035A8 File Offset: 0x000017A8
		private static Delegate GetOnTouchModeChanged_ZHandler()
		{
			if (AbsListView.cb_onTouchModeChanged_Z == null)
			{
				AbsListView.cb_onTouchModeChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AbsListView.n_OnTouchModeChanged_Z));
			}
			return AbsListView.cb_onTouchModeChanged_Z;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000035CC File Offset: 0x000017CC
		private static void n_OnTouchModeChanged_Z(IntPtr jnienv, IntPtr native__this, bool isInTouchMode)
		{
			Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTouchModeChanged(isInTouchMode);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000035DC File Offset: 0x000017DC
		public unsafe virtual void OnTouchModeChanged(bool isInTouchMode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isInTouchMode);
			AbsListView._members.InstanceMethods.InvokeVirtualVoidMethod("onTouchModeChanged.(Z)V", this, ptr);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003617 File Offset: 0x00001817
		private static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler()
		{
			if (AbsListView.cb_setAdapter_Landroid_widget_Adapter_ == null)
			{
				Action<IntPtr, IntPtr, IntPtr> dlg;
				if ((dlg = AbsListView.<>O.<3>__n_SetAdapter_Landroid_widget_ListAdapter_) == null)
				{
					dlg = (AbsListView.<>O.<3>__n_SetAdapter_Landroid_widget_ListAdapter_ = new Action<IntPtr, IntPtr, IntPtr>(AbsListView.n_SetAdapter_Landroid_widget_ListAdapter_));
				}
				AbsListView.cb_setAdapter_Landroid_widget_Adapter_ = JNINativeWrapper.CreateDelegate(dlg);
			}
			return AbsListView.cb_setAdapter_Landroid_widget_Adapter_;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000364A File Offset: 0x0000184A
		private static void n_SetAdapter_Landroid_widget_ListAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			Java.Lang.Object.GetObject<AbsListView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Adapter = JavaConvert.FromJniHandle<IListAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
		}

		// Token: 0x17000025 RID: 37
		// (set) Token: 0x060002A5 RID: 677
		public abstract override IListAdapter Adapter { set; }

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsListView", typeof(AbsListView));

		// Token: 0x0400003D RID: 61
		private static Delegate cb_afterTextChanged_Landroid_text_Editable_;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_onFilterComplete_I;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_onGlobalLayout;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_onTouchModeChanged_Z;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_setAdapter_Landroid_widget_Adapter_;

		// Token: 0x020000A1 RID: 161
		[Register("android/widget/AbsListView$OnScrollListener", "", "Android.Widget.AbsListView/IOnScrollListenerInvoker")]
		public interface IOnScrollListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060002A7 RID: 679
			[Register("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler:Android.Widget.AbsListView/IOnScrollListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount);

			// Token: 0x060002A8 RID: 680
			[Register("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler:Android.Widget.AbsListView/IOnScrollListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnScrollStateChanged(AbsListView view, [GeneratedEnum] ScrollState scrollState);
		}

		// Token: 0x020000A2 RID: 162
		[Register("android/widget/AbsListView$OnScrollListener", DoNotGenerateAcw = true)]
		internal class IOnScrollListenerInvoker : Java.Lang.Object, AbsListView.IOnScrollListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000367C File Offset: 0x0000187C
			private static IntPtr java_class_ref
			{
				get
				{
					return AbsListView.IOnScrollListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060002AA RID: 682 RVA: 0x000036A0 File Offset: 0x000018A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AbsListView.IOnScrollListenerInvoker._members;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060002AB RID: 683 RVA: 0x000036A7 File Offset: 0x000018A7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060002AC RID: 684 RVA: 0x000036AF File Offset: 0x000018AF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AbsListView.IOnScrollListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060002AD RID: 685 RVA: 0x000036BB File Offset: 0x000018BB
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AbsListView.IOnScrollListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.widget.AbsListView.OnScrollListener'.");
				}
				return handle;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x000036E6 File Offset: 0x000018E6
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00003718 File Offset: 0x00001918
			public IOnScrollListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AbsListView.IOnScrollListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x00003750 File Offset: 0x00001950
			private static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler()
			{
				if (AbsListView.IOnScrollListenerInvoker.cb_onScroll_Landroid_widget_AbsListView_III == null)
				{
					AbsListView.IOnScrollListenerInvoker.cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(AbsListView.IOnScrollListenerInvoker.n_OnScroll_Landroid_widget_AbsListView_III));
				}
				return AbsListView.IOnScrollListenerInvoker.cb_onScroll_Landroid_widget_AbsListView_III;
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x00003774 File Offset: 0x00001974
			private static void n_OnScroll_Landroid_widget_AbsListView_III(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
			{
				AbsListView.IOnScrollListener @object = Java.Lang.Object.GetObject<AbsListView.IOnScrollListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AbsListView object2 = Java.Lang.Object.GetObject<AbsListView>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnScroll(object2, firstVisibleItem, visibleItemCount, totalItemCount);
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000379C File Offset: 0x0000199C
			public unsafe void OnScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
			{
				if (this.id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
				{
					this.id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID(this.class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JValue(firstVisibleItem);
				ptr[2] = new JValue(visibleItemCount);
				ptr[3] = new JValue(totalItemCount);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onScroll_Landroid_widget_AbsListView_III, ptr);
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0000384F File Offset: 0x00001A4F
			private static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler()
			{
				if (AbsListView.IOnScrollListenerInvoker.cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
				{
					AbsListView.IOnScrollListenerInvoker.cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AbsListView.IOnScrollListenerInvoker.n_OnScrollStateChanged_Landroid_widget_AbsListView_I));
				}
				return AbsListView.IOnScrollListenerInvoker.cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x00003874 File Offset: 0x00001A74
			private static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I(IntPtr jnienv, IntPtr native__this, IntPtr native_view, int native_scrollState)
			{
				AbsListView.IOnScrollListener @object = Java.Lang.Object.GetObject<AbsListView.IOnScrollListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AbsListView object2 = Java.Lang.Object.GetObject<AbsListView>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnScrollStateChanged(object2, (ScrollState)native_scrollState);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000389C File Offset: 0x00001A9C
			public unsafe void OnScrollStateChanged(AbsListView view, [GeneratedEnum] ScrollState scrollState)
			{
				if (this.id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
				{
					this.id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID(this.class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JValue((int)scrollState);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onScrollStateChanged_Landroid_widget_AbsListView_I, ptr);
			}

			// Token: 0x04000046 RID: 70
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsListView$OnScrollListener", typeof(AbsListView.IOnScrollListenerInvoker));

			// Token: 0x04000047 RID: 71
			private IntPtr class_ref;

			// Token: 0x04000048 RID: 72
			private static Delegate cb_onScroll_Landroid_widget_AbsListView_III;

			// Token: 0x04000049 RID: 73
			private IntPtr id_onScroll_Landroid_widget_AbsListView_III;

			// Token: 0x0400004A RID: 74
			private static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;

			// Token: 0x0400004B RID: 75
			private IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
		}

		// Token: 0x020000A3 RID: 163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400004C RID: 76
			public static Action<IntPtr, IntPtr, IntPtr> <3>__n_SetAdapter_Landroid_widget_ListAdapter_;
		}
	}
}
