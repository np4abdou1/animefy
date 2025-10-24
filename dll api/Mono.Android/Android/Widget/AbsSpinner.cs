using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A6 RID: 166
	[Register("android/widget/AbsSpinner", DoNotGenerateAcw = true)]
	public abstract class AbsSpinner : AdapterView<ISpinnerAdapter>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00003D6D File Offset: 0x00001F6D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbsSpinner._members;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00003D74 File Offset: 0x00001F74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbsSpinner._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003D98 File Offset: 0x00001F98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbsSpinner._members.ManagedPeerType;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003DA4 File Offset: 0x00001FA4
		protected AbsSpinner(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public unsafe AbsSpinner(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AbsSpinner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsSpinner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00003E8C File Offset: 0x0000208C
		public unsafe AbsSpinner(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AbsSpinner._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbsSpinner._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00003F7C File Offset: 0x0000217C
		private static Delegate GetSetAdapter_Landroid_widget_SpinnerAdapter_Handler()
		{
			if (AbsSpinner.cb_setAdapter_Landroid_widget_SpinnerAdapter_ == null)
			{
				AbsSpinner.cb_setAdapter_Landroid_widget_SpinnerAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbsSpinner.n_SetAdapter_Landroid_widget_SpinnerAdapter_));
			}
			return AbsSpinner.cb_setAdapter_Landroid_widget_SpinnerAdapter_;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00003FA0 File Offset: 0x000021A0
		private static void n_SetAdapter_Landroid_widget_SpinnerAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			AdapterView<ISpinnerAdapter> @object = Java.Lang.Object.GetObject<AbsSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISpinnerAdapter object2 = Java.Lang.Object.GetObject<ISpinnerAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.Adapter = object2;
		}

		// Token: 0x17000034 RID: 52
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003FC4 File Offset: 0x000021C4
		public unsafe override ISpinnerAdapter Adapter
		{
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					AbsSpinner._members.InstanceMethods.InvokeVirtualVoidMethod("setAdapter.(Landroid/widget/SpinnerAdapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000402C File Offset: 0x0000222C
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (AbsSpinner.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				AbsSpinner.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AbsSpinner.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return AbsSpinner.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00004050 File Offset: 0x00002250
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			AbsSpinner @object = Java.Lang.Object.GetObject<AbsSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00004074 File Offset: 0x00002274
		public new unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				AbsSpinner._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000040DC File Offset: 0x000022DC
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (AbsSpinner.cb_onSaveInstanceState == null)
			{
				AbsSpinner.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbsSpinner.n_OnSaveInstanceState));
			}
			return AbsSpinner.cb_onSaveInstanceState;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00004100 File Offset: 0x00002300
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbsSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00004114 File Offset: 0x00002314
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(AbsSpinner._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00004146 File Offset: 0x00002346
		private static Delegate GetSetSelection_IHandler()
		{
			if (AbsSpinner.cb_setSelection_I == null)
			{
				AbsSpinner.cb_setSelection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AbsSpinner.n_SetSelection_I));
			}
			return AbsSpinner.cb_setSelection_I;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000416A File Offset: 0x0000236A
		private static void n_SetSelection_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<AbsSpinner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelection(position);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000417C File Offset: 0x0000237C
		public unsafe override void SetSelection(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			AbsSpinner._members.InstanceMethods.InvokeVirtualVoidMethod("setSelection.(I)V", this, ptr);
		}

		// Token: 0x04000050 RID: 80
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsSpinner", typeof(AbsSpinner));

		// Token: 0x04000051 RID: 81
		private static Delegate cb_setAdapter_Landroid_widget_SpinnerAdapter_;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000053 RID: 83
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_setSelection_I;
	}
}
