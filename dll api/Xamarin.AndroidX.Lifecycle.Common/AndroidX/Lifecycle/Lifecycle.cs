using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent.Atomic;

namespace AndroidX.Lifecycle
{
	// Token: 0x02000007 RID: 7
	[Register("androidx/lifecycle/Lifecycle", DoNotGenerateAcw = true)]
	public abstract class Lifecycle : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return Lifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Lifecycle._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Lifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Lifecycle._members.ManagedPeerType;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020DC File Offset: 0x000002DC
		protected Lifecycle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public Lifecycle() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Lifecycle._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Lifecycle._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002156 File Offset: 0x00000356
		private static Delegate GetGetCurrentStateHandler()
		{
			if (Lifecycle.cb_getCurrentState == null)
			{
				Lifecycle.cb_getCurrentState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Lifecycle.n_GetCurrentState));
			}
			return Lifecycle.cb_getCurrentState;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000217A File Offset: 0x0000037A
		private static IntPtr n_GetCurrentState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Lifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentState);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20
		public abstract Lifecycle.State CurrentState { [Register("getCurrentState", "()Landroidx/lifecycle/Lifecycle$State;", "GetGetCurrentStateHandler")] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000021C4 File Offset: 0x000003C4
		public unsafe AtomicReference InternalScopeRef
		{
			[Register("getInternalScopeRef", "()Ljava/util/concurrent/atomic/AtomicReference;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AtomicReference>(Lifecycle._members.InstanceMethods.InvokeNonvirtualObjectMethod("getInternalScopeRef.()Ljava/util/concurrent/atomic/AtomicReference;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setInternalScopeRef", "(Ljava/util/concurrent/atomic/AtomicReference;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					Lifecycle._members.InstanceMethods.InvokeNonvirtualVoidMethod("setInternalScopeRef.(Ljava/util/concurrent/atomic/AtomicReference;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002228 File Offset: 0x00000428
		private static Delegate GetAddObserver_Landroidx_lifecycle_LifecycleObserver_Handler()
		{
			if (Lifecycle.cb_addObserver_Landroidx_lifecycle_LifecycleObserver_ == null)
			{
				Lifecycle.cb_addObserver_Landroidx_lifecycle_LifecycleObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Lifecycle.n_AddObserver_Landroidx_lifecycle_LifecycleObserver_));
			}
			return Lifecycle.cb_addObserver_Landroidx_lifecycle_LifecycleObserver_;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000224C File Offset: 0x0000044C
		private static void n_AddObserver_Landroidx_lifecycle_LifecycleObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			Lifecycle @object = Java.Lang.Object.GetObject<Lifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleObserver object2 = Java.Lang.Object.GetObject<ILifecycleObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.AddObserver(object2);
		}

		// Token: 0x06000019 RID: 25
		[Register("addObserver", "(Landroidx/lifecycle/LifecycleObserver;)V", "GetAddObserver_Landroidx_lifecycle_LifecycleObserver_Handler")]
		public abstract void AddObserver(ILifecycleObserver observer);

		// Token: 0x0600001A RID: 26 RVA: 0x0000226F File Offset: 0x0000046F
		private static Delegate GetRemoveObserver_Landroidx_lifecycle_LifecycleObserver_Handler()
		{
			if (Lifecycle.cb_removeObserver_Landroidx_lifecycle_LifecycleObserver_ == null)
			{
				Lifecycle.cb_removeObserver_Landroidx_lifecycle_LifecycleObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Lifecycle.n_RemoveObserver_Landroidx_lifecycle_LifecycleObserver_));
			}
			return Lifecycle.cb_removeObserver_Landroidx_lifecycle_LifecycleObserver_;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002294 File Offset: 0x00000494
		private static void n_RemoveObserver_Landroidx_lifecycle_LifecycleObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			Lifecycle @object = Java.Lang.Object.GetObject<Lifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleObserver object2 = Java.Lang.Object.GetObject<ILifecycleObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RemoveObserver(object2);
		}

		// Token: 0x0600001C RID: 28
		[Register("removeObserver", "(Landroidx/lifecycle/LifecycleObserver;)V", "GetRemoveObserver_Landroidx_lifecycle_LifecycleObserver_Handler")]
		public abstract void RemoveObserver(ILifecycleObserver observer);

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/Lifecycle", typeof(Lifecycle));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getCurrentState;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_addObserver_Landroidx_lifecycle_LifecycleObserver_;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_removeObserver_Landroidx_lifecycle_LifecycleObserver_;

		// Token: 0x02000008 RID: 8
		[Register("androidx/lifecycle/Lifecycle$State", DoNotGenerateAcw = true)]
		public sealed class State : Java.Lang.Enum
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600001E RID: 30 RVA: 0x000022D4 File Offset: 0x000004D4
			[Register("CREATED")]
			public static Lifecycle.State Created
			{
				get
				{
					return Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticFields.GetObjectValue("CREATED.Landroidx/lifecycle/Lifecycle$State;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600001F RID: 31 RVA: 0x00002304 File Offset: 0x00000504
			[Register("DESTROYED")]
			public static Lifecycle.State Destroyed
			{
				get
				{
					return Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticFields.GetObjectValue("DESTROYED.Landroidx/lifecycle/Lifecycle$State;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000020 RID: 32 RVA: 0x00002334 File Offset: 0x00000534
			[Register("INITIALIZED")]
			public static Lifecycle.State Initialized
			{
				get
				{
					return Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticFields.GetObjectValue("INITIALIZED.Landroidx/lifecycle/Lifecycle$State;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000021 RID: 33 RVA: 0x00002364 File Offset: 0x00000564
			[Register("RESUMED")]
			public static Lifecycle.State Resumed
			{
				get
				{
					return Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticFields.GetObjectValue("RESUMED.Landroidx/lifecycle/Lifecycle$State;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000022 RID: 34 RVA: 0x00002394 File Offset: 0x00000594
			[Register("STARTED")]
			public static Lifecycle.State Started
			{
				get
				{
					return Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticFields.GetObjectValue("STARTED.Landroidx/lifecycle/Lifecycle$State;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000023 RID: 35 RVA: 0x000023C4 File Offset: 0x000005C4
			internal static IntPtr class_ref
			{
				get
				{
					return Lifecycle.State._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000024 RID: 36 RVA: 0x000023E8 File Offset: 0x000005E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Lifecycle.State._members;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000025 RID: 37 RVA: 0x000023F0 File Offset: 0x000005F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Lifecycle.State._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00002414 File Offset: 0x00000614
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Lifecycle.State._members.ManagedPeerType;
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00002420 File Offset: 0x00000620
			internal State(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000028 RID: 40 RVA: 0x0000242C File Offset: 0x0000062C
			[Register("isAtLeast", "(Landroidx/lifecycle/Lifecycle$State;)Z", "")]
			public unsafe bool IsAtLeast(Lifecycle.State state)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
					result = Lifecycle.State._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isAtLeast.(Landroidx/lifecycle/Lifecycle$State;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(state);
				}
				return result;
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00002494 File Offset: 0x00000694
			[Register("valueOf", "(Ljava/lang/String;)Landroidx/lifecycle/Lifecycle$State;", "")]
			public unsafe static Lifecycle.State ValueOf(string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				Lifecycle.State @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<Lifecycle.State>(Lifecycle.State._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Landroidx/lifecycle/Lifecycle$State;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00002500 File Offset: 0x00000700
			[Register("values", "()[Landroidx/lifecycle/Lifecycle$State;", "")]
			public static Lifecycle.State[] Values()
			{
				return (Lifecycle.State[])JNIEnv.GetArray(Lifecycle.State._members.StaticMethods.InvokeObjectMethod("values.()[Landroidx/lifecycle/Lifecycle$State;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Lifecycle.State));
			}

			// Token: 0x04000007 RID: 7
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/Lifecycle$State", typeof(Lifecycle.State));
		}
	}
}
