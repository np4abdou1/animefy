using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using AndroidX.Lifecycle;
using AndroidX.SavedState;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x02000012 RID: 18
	[Register("androidx/activity/ComponentDialog", DoNotGenerateAcw = true)]
	public class ComponentDialog : Dialog, IOnBackPressedDispatcherOwner, ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable, ISavedStateRegistryOwner
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000030BC File Offset: 0x000012BC
		internal static IntPtr class_ref
		{
			get
			{
				return ComponentDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000030E0 File Offset: 0x000012E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComponentDialog._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000030E8 File Offset: 0x000012E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComponentDialog._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000310C File Offset: 0x0000130C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComponentDialog._members.ManagedPeerType;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003118 File Offset: 0x00001318
		protected ComponentDialog(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003124 File Offset: 0x00001324
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ComponentDialog(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ComponentDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ComponentDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000031D4 File Offset: 0x000013D4
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe ComponentDialog(Context context, int themeResId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(themeResId);
				base.SetHandle(ComponentDialog._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ComponentDialog._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003294 File Offset: 0x00001494
		private static Delegate GetGetLifecycleHandler()
		{
			if (ComponentDialog.cb_getLifecycle == null)
			{
				ComponentDialog.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentDialog.n_GetLifecycle));
			}
			return ComponentDialog.cb_getLifecycle;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000032B8 File Offset: 0x000014B8
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000032CC File Offset: 0x000014CC
		public virtual Lifecycle Lifecycle
		{
			[Register("getLifecycle", "()Landroidx/lifecycle/Lifecycle;", "GetGetLifecycleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Lifecycle>(ComponentDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getLifecycle.()Landroidx/lifecycle/Lifecycle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003300 File Offset: 0x00001500
		public OnBackPressedDispatcher OnBackPressedDispatcher
		{
			[Register("getOnBackPressedDispatcher", "()Landroidx/activity/OnBackPressedDispatcher;", "")]
			get
			{
				return Java.Lang.Object.GetObject<OnBackPressedDispatcher>(ComponentDialog._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOnBackPressedDispatcher.()Landroidx/activity/OnBackPressedDispatcher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003332 File Offset: 0x00001532
		private static Delegate GetGetSavedStateRegistryHandler()
		{
			if (ComponentDialog.cb_getSavedStateRegistry == null)
			{
				ComponentDialog.cb_getSavedStateRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentDialog.n_GetSavedStateRegistry));
			}
			return ComponentDialog.cb_getSavedStateRegistry;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003356 File Offset: 0x00001556
		private static IntPtr n_GetSavedStateRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SavedStateRegistry);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000336C File Offset: 0x0000156C
		public virtual SavedStateRegistry SavedStateRegistry
		{
			[Register("getSavedStateRegistry", "()Landroidx/savedstate/SavedStateRegistry;", "GetGetSavedStateRegistryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<SavedStateRegistry>(ComponentDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getSavedStateRegistry.()Landroidx/savedstate/SavedStateRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000339E File Offset: 0x0000159E
		private static Delegate GetGetOnBackPressedDispatcherHandler()
		{
			if (ComponentDialog.cb_getOnBackPressedDispatcher == null)
			{
				ComponentDialog.cb_getOnBackPressedDispatcher = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ComponentDialog.n_GetOnBackPressedDispatcher));
			}
			return ComponentDialog.cb_getOnBackPressedDispatcher;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000033C2 File Offset: 0x000015C2
		private static IntPtr n_GetOnBackPressedDispatcher(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ComponentDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetOnBackPressedDispatcher());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000033D8 File Offset: 0x000015D8
		[Register("getOnBackPressedDispatcher", "()Landroidx/activity/OnBackPressedDispatcher;", "GetGetOnBackPressedDispatcherHandler")]
		public virtual OnBackPressedDispatcher GetOnBackPressedDispatcher()
		{
			return Java.Lang.Object.GetObject<OnBackPressedDispatcher>(ComponentDialog._members.InstanceMethods.InvokeVirtualObjectMethod("getOnBackPressedDispatcher.()Landroidx/activity/OnBackPressedDispatcher;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/ComponentDialog", typeof(ComponentDialog));

		// Token: 0x04000016 RID: 22
		private static Delegate cb_getLifecycle;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getSavedStateRegistry;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_getOnBackPressedDispatcher;
	}
}
