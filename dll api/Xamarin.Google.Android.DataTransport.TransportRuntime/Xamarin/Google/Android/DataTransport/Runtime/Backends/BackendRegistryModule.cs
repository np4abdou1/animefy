using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000083 RID: 131
	[Register("com/google/android/datatransport/runtime/backends/BackendRegistryModule", DoNotGenerateAcw = true)]
	public abstract class BackendRegistryModule : Java.Lang.Object
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0000EC50 File Offset: 0x0000CE50
		internal static IntPtr class_ref
		{
			get
			{
				return BackendRegistryModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0000EC74 File Offset: 0x0000CE74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendRegistryModule._members;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BackendRegistryModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendRegistryModule._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000026C4 File Offset: 0x000008C4
		protected BackendRegistryModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		[Register(".ctor", "()V", "")]
		public BackendRegistryModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BackendRegistryModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BackendRegistryModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000107 RID: 263
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRegistryModule", typeof(BackendRegistryModule));
	}
}
