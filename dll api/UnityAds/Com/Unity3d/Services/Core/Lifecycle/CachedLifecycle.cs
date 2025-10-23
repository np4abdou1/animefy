using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000EA RID: 234
	[Register("com/unity3d/services/core/lifecycle/CachedLifecycle", DoNotGenerateAcw = true)]
	public class CachedLifecycle : Java.Lang.Object
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0001B5E0 File Offset: 0x000197E0
		internal static IntPtr class_ref
		{
			get
			{
				return CachedLifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0001B604 File Offset: 0x00019804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CachedLifecycle._members;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0001B60C File Offset: 0x0001980C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CachedLifecycle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0001B630 File Offset: 0x00019830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CachedLifecycle._members.ManagedPeerType;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000021E8 File Offset: 0x000003E8
		protected CachedLifecycle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001B63C File Offset: 0x0001983C
		[Register(".ctor", "()V", "")]
		public CachedLifecycle() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CachedLifecycle._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CachedLifecycle._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0001B6AC File Offset: 0x000198AC
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x0001B6E0 File Offset: 0x000198E0
		public unsafe static LifecycleCache LifecycleListener
		{
			[Register("getLifecycleListener", "()Lcom/unity3d/services/core/lifecycle/LifecycleCache;", "")]
			get
			{
				return Java.Lang.Object.GetObject<LifecycleCache>(CachedLifecycle._members.StaticMethods.InvokeObjectMethod("getLifecycleListener.()Lcom/unity3d/services/core/lifecycle/LifecycleCache;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setLifecycleListener", "(Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CachedLifecycle._members.StaticMethods.InvokeVoidMethod("setLifecycleListener.(Lcom/unity3d/services/core/lifecycle/LifecycleCache;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0001B744 File Offset: 0x00019944
		[Register("register", "()V", "")]
		public static void Register()
		{
			CachedLifecycle._members.StaticMethods.InvokeVoidMethod("register.()V", null);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0001B75C File Offset: 0x0001995C
		[Register("unregister", "()V", "")]
		public static void Unregister()
		{
			CachedLifecycle._members.StaticMethods.InvokeVoidMethod("unregister.()V", null);
		}

		// Token: 0x04000230 RID: 560
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/CachedLifecycle", typeof(CachedLifecycle));
	}
}
