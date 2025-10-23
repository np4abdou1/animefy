using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain
{
	// Token: 0x02000101 RID: 257
	[Register("com/unity3d/services/core/domain/SDKDispatchers", DoNotGenerateAcw = true)]
	public sealed class SDKDispatchers : Java.Lang.Object, ISDKDispatchers, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		internal static IntPtr class_ref
		{
			get
			{
				return SDKDispatchers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0001D70C File Offset: 0x0001B90C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SDKDispatchers._members;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0001D714 File Offset: 0x0001B914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SDKDispatchers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0001D738 File Offset: 0x0001B938
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SDKDispatchers._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000021E8 File Offset: 0x000003E8
		internal SDKDispatchers(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001D744 File Offset: 0x0001B944
		[Register(".ctor", "()V", "")]
		public SDKDispatchers() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SDKDispatchers._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SDKDispatchers._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000267 RID: 615
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/SDKDispatchers", typeof(SDKDispatchers));
	}
}
