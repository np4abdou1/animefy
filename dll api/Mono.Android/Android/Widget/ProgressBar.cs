using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000ED RID: 237
	[Register("android/widget/ProgressBar", DoNotGenerateAcw = true)]
	public class ProgressBar : View
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0000B103 File Offset: 0x00009303
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProgressBar._members;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000B10C File Offset: 0x0000930C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProgressBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0000B130 File Offset: 0x00009330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProgressBar._members.ManagedPeerType;
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00008888 File Offset: 0x00006A88
		protected ProgressBar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000B13C File Offset: 0x0000933C
		public unsafe ProgressBar(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ProgressBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ProgressBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000B1EC File Offset: 0x000093EC
		public unsafe ProgressBar(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ProgressBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ProgressBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000B2C8 File Offset: 0x000094C8
		public unsafe ProgressBar(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ProgressBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ProgressBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000B3B8 File Offset: 0x000095B8
		private static Delegate GetSetIndeterminate_ZHandler()
		{
			if (ProgressBar.cb_setIndeterminate_Z == null)
			{
				ProgressBar.cb_setIndeterminate_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ProgressBar.n_SetIndeterminate_Z));
			}
			return ProgressBar.cb_setIndeterminate_Z;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000B3DC File Offset: 0x000095DC
		private static void n_SetIndeterminate_Z(IntPtr jnienv, IntPtr native__this, bool indeterminate)
		{
			Java.Lang.Object.GetObject<ProgressBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Indeterminate = indeterminate;
		}

		// Token: 0x170000E9 RID: 233
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000B3EC File Offset: 0x000095EC
		public unsafe virtual bool Indeterminate
		{
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ProgressBar._members.InstanceMethods.InvokeVirtualVoidMethod("setIndeterminate.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000B427 File Offset: 0x00009627
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (ProgressBar.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				ProgressBar.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ProgressBar.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return ProgressBar.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000B44C File Offset: 0x0000964C
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			ProgressBar @object = Java.Lang.Object.GetObject<ProgressBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000B470 File Offset: 0x00009670
		public new unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				ProgressBar._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000B4D8 File Offset: 0x000096D8
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (ProgressBar.cb_onSaveInstanceState == null)
			{
				ProgressBar.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ProgressBar.n_OnSaveInstanceState));
			}
			return ProgressBar.cb_onSaveInstanceState;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000B4FC File Offset: 0x000096FC
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ProgressBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000B510 File Offset: 0x00009710
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(ProgressBar._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000144 RID: 324
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ProgressBar", typeof(ProgressBar));

		// Token: 0x04000145 RID: 325
		private static Delegate cb_setIndeterminate_Z;

		// Token: 0x04000146 RID: 326
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_onSaveInstanceState;
	}
}
