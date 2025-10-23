using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x02000018 RID: 24
	[Register("androidx/activity/OnBackPressedCallback", DoNotGenerateAcw = true)]
	public abstract class OnBackPressedCallback : Java.Lang.Object
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003A50 File Offset: 0x00001C50
		internal static IntPtr class_ref
		{
			get
			{
				return OnBackPressedCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00003A74 File Offset: 0x00001C74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnBackPressedCallback._members;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003A7C File Offset: 0x00001C7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OnBackPressedCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnBackPressedCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003484 File Offset: 0x00001684
		protected OnBackPressedCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Register(".ctor", "(Z)V", "")]
		public unsafe OnBackPressedCallback(bool enabled) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			base.SetHandle(OnBackPressedCallback._members.InstanceMethods.StartCreateInstance("(Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			OnBackPressedCallback._members.InstanceMethods.FinishCreateInstance("(Z)V", this, ptr);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003B30 File Offset: 0x00001D30
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00003B4C File Offset: 0x00001D4C
		public unsafe bool Enabled
		{
			[Register("isEnabled", "()Z", "")]
			get
			{
				return OnBackPressedCallback._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isEnabled.()Z", this, null);
			}
			[Register("setEnabled", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				OnBackPressedCallback._members.InstanceMethods.InvokeNonvirtualVoidMethod("setEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003B87 File Offset: 0x00001D87
		private static Delegate GetHandleOnBackPressedHandler()
		{
			if (OnBackPressedCallback.cb_handleOnBackPressed == null)
			{
				OnBackPressedCallback.cb_handleOnBackPressed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(OnBackPressedCallback.n_HandleOnBackPressed));
			}
			return OnBackPressedCallback.cb_handleOnBackPressed;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003BAB File Offset: 0x00001DAB
		private static void n_HandleOnBackPressed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<OnBackPressedCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HandleOnBackPressed();
		}

		// Token: 0x060000B4 RID: 180
		[Register("handleOnBackPressed", "()V", "GetHandleOnBackPressedHandler")]
		public abstract void HandleOnBackPressed();

		// Token: 0x060000B5 RID: 181 RVA: 0x00003BBA File Offset: 0x00001DBA
		[Register("remove", "()V", "")]
		public void Remove()
		{
			OnBackPressedCallback._members.InstanceMethods.InvokeNonvirtualVoidMethod("remove.()V", this, null);
		}

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/OnBackPressedCallback", typeof(OnBackPressedCallback));

		// Token: 0x04000025 RID: 37
		private static Delegate cb_handleOnBackPressed;
	}
}
