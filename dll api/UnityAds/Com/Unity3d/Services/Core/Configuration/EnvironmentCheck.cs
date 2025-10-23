using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000154 RID: 340
	[Register("com/unity3d/services/core/configuration/EnvironmentCheck", DoNotGenerateAcw = true)]
	public class EnvironmentCheck : Java.Lang.Object
	{
		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00027624 File Offset: 0x00025824
		internal static IntPtr class_ref
		{
			get
			{
				return EnvironmentCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00027648 File Offset: 0x00025848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EnvironmentCheck._members;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00027650 File Offset: 0x00025850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EnvironmentCheck._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00027674 File Offset: 0x00025874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EnvironmentCheck._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000021E8 File Offset: 0x000003E8
		protected EnvironmentCheck(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00027680 File Offset: 0x00025880
		[Register(".ctor", "()V", "")]
		public EnvironmentCheck() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EnvironmentCheck._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EnvironmentCheck._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000276EE File Offset: 0x000258EE
		public static bool IsEnvironmentOk
		{
			[Register("isEnvironmentOk", "()Z", "")]
			get
			{
				return EnvironmentCheck._members.StaticMethods.InvokeBooleanMethod("isEnvironmentOk.()Z", null);
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00027706 File Offset: 0x00025906
		[Register("testCacheDirectory", "()Z", "")]
		public static bool TestCacheDirectory()
		{
			return EnvironmentCheck._members.StaticMethods.InvokeBooleanMethod("testCacheDirectory.()Z", null);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002771E File Offset: 0x0002591E
		[Register("testProGuard", "()Z", "")]
		public static bool TestProGuard()
		{
			return EnvironmentCheck._members.StaticMethods.InvokeBooleanMethod("testProGuard.()Z", null);
		}

		// Token: 0x0400034A RID: 842
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/EnvironmentCheck", typeof(EnvironmentCheck));
	}
}
