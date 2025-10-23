using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Properties
{
	// Token: 0x020000CC RID: 204
	[Register("com/unity3d/services/core/properties/MadeWithUnityDetector", DoNotGenerateAcw = true)]
	public class MadeWithUnityDetector : Java.Lang.Object
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x00016E98 File Offset: 0x00015098
		internal static IntPtr class_ref
		{
			get
			{
				return MadeWithUnityDetector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00016EBC File Offset: 0x000150BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MadeWithUnityDetector._members;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00016EC4 File Offset: 0x000150C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MadeWithUnityDetector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00016EE8 File Offset: 0x000150E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MadeWithUnityDetector._members.ManagedPeerType;
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MadeWithUnityDetector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00016EF4 File Offset: 0x000150F4
		[Register(".ctor", "()V", "")]
		public MadeWithUnityDetector() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MadeWithUnityDetector._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MadeWithUnityDetector._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00016F62 File Offset: 0x00015162
		public static bool IsMadeWithUnity
		{
			[Register("isMadeWithUnity", "()Z", "")]
			get
			{
				return MadeWithUnityDetector._members.StaticMethods.InvokeBooleanMethod("isMadeWithUnity.()Z", null);
			}
		}

		// Token: 0x040001E9 RID: 489
		[Register("UNITY_PLAYER_CLASS_NAME")]
		public const string UnityPlayerClassName = "com.unity3d.player.UnityPlayer";

		// Token: 0x040001EA RID: 490
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/properties/MadeWithUnityDetector", typeof(MadeWithUnityDetector));
	}
}
