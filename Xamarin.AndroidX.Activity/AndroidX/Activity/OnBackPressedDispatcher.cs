using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x0200001A RID: 26
	[Register("androidx/activity/OnBackPressedDispatcher", DoNotGenerateAcw = true)]
	public sealed class OnBackPressedDispatcher : Java.Lang.Object
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003C40 File Offset: 0x00001E40
		internal static IntPtr class_ref
		{
			get
			{
				return OnBackPressedDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003C64 File Offset: 0x00001E64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnBackPressedDispatcher._members;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00003C6C File Offset: 0x00001E6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OnBackPressedDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003C90 File Offset: 0x00001E90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnBackPressedDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003484 File Offset: 0x00001684
		internal OnBackPressedDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003C9C File Offset: 0x00001E9C
		[Register(".ctor", "()V", "")]
		public OnBackPressedDispatcher() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(OnBackPressedDispatcher._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			OnBackPressedDispatcher._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003D0C File Offset: 0x00001F0C
		[Register(".ctor", "(Ljava/lang/Runnable;)V", "")]
		public unsafe OnBackPressedDispatcher(IRunnable fallbackOnBackPressed) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fallbackOnBackPressed == null) ? IntPtr.Zero : ((Java.Lang.Object)fallbackOnBackPressed).Handle);
				base.SetHandle(OnBackPressedDispatcher._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Runnable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				OnBackPressedDispatcher._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Runnable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fallbackOnBackPressed);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public bool HasEnabledCallbacks
		{
			[Register("hasEnabledCallbacks", "()Z", "")]
			get
			{
				return OnBackPressedDispatcher._members.InstanceMethods.InvokeNonvirtualBooleanMethod("hasEnabledCallbacks.()Z", this, null);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Register("addCallback", "(Landroidx/activity/OnBackPressedCallback;)V", "")]
		public unsafe void AddCallback(OnBackPressedCallback onBackPressedCallback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((onBackPressedCallback == null) ? IntPtr.Zero : onBackPressedCallback.Handle);
				OnBackPressedDispatcher._members.InstanceMethods.InvokeNonvirtualVoidMethod("addCallback.(Landroidx/activity/OnBackPressedCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(onBackPressedCallback);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00003E40 File Offset: 0x00002040
		[Register("addCallback", "(Landroidx/lifecycle/LifecycleOwner;Landroidx/activity/OnBackPressedCallback;)V", "")]
		public unsafe void AddCallback(ILifecycleOwner owner, OnBackPressedCallback onBackPressedCallback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((owner == null) ? IntPtr.Zero : ((Java.Lang.Object)owner).Handle);
				ptr[1] = new JniArgumentValue((onBackPressedCallback == null) ? IntPtr.Zero : onBackPressedCallback.Handle);
				OnBackPressedDispatcher._members.InstanceMethods.InvokeNonvirtualVoidMethod("addCallback.(Landroidx/lifecycle/LifecycleOwner;Landroidx/activity/OnBackPressedCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(owner);
				GC.KeepAlive(onBackPressedCallback);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Register("onBackPressed", "()V", "")]
		public void OnBackPressed()
		{
			OnBackPressedDispatcher._members.InstanceMethods.InvokeNonvirtualVoidMethod("onBackPressed.()V", this, null);
		}

		// Token: 0x04000027 RID: 39
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/OnBackPressedDispatcher", typeof(OnBackPressedDispatcher));
	}
}
