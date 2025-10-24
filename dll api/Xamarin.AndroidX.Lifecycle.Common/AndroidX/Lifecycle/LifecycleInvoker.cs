using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000D RID: 13
	[Register("androidx/lifecycle/Lifecycle", DoNotGenerateAcw = true)]
	internal class LifecycleInvoker : Lifecycle
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000027D4 File Offset: 0x000009D4
		public LifecycleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000027DE File Offset: 0x000009DE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LifecycleInvoker._members;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000027E5 File Offset: 0x000009E5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LifecycleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000027F4 File Offset: 0x000009F4
		public override Lifecycle.State CurrentState
		{
			[Register("getCurrentState", "()Landroidx/lifecycle/Lifecycle$State;", "GetGetCurrentStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Lifecycle.State>(LifecycleInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCurrentState.()Landroidx/lifecycle/Lifecycle$State;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002828 File Offset: 0x00000A28
		[Register("addObserver", "(Landroidx/lifecycle/LifecycleObserver;)V", "GetAddObserver_Landroidx_lifecycle_LifecycleObserver_Handler")]
		public unsafe override void AddObserver(ILifecycleObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				LifecycleInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addObserver.(Landroidx/lifecycle/LifecycleObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002890 File Offset: 0x00000A90
		[Register("removeObserver", "(Landroidx/lifecycle/LifecycleObserver;)V", "GetRemoveObserver_Landroidx_lifecycle_LifecycleObserver_Handler")]
		public unsafe override void RemoveObserver(ILifecycleObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				LifecycleInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeObserver.(Landroidx/lifecycle/LifecycleObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/Lifecycle", typeof(LifecycleInvoker));
	}
}
