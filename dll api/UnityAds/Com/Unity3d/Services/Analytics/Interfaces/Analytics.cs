using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics.Interfaces
{
	// Token: 0x020001C5 RID: 453
	[Register("com/unity3d/services/analytics/interfaces/Analytics", DoNotGenerateAcw = true)]
	public class Analytics : Java.Lang.Object
	{
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001441 RID: 5185 RVA: 0x00039E74 File Offset: 0x00038074
		internal static IntPtr class_ref
		{
			get
			{
				return Analytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00039E98 File Offset: 0x00038098
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Analytics._members;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x00039EA0 File Offset: 0x000380A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Analytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00039EC4 File Offset: 0x000380C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Analytics._members.ManagedPeerType;
			}
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Analytics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00039ED0 File Offset: 0x000380D0
		[Register(".ctor", "()V", "")]
		public Analytics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Analytics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Analytics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00039F40 File Offset: 0x00038140
		[Register("initialize", "(Lcom/unity3d/services/analytics/interfaces/IAnalytics;)V", "")]
		public unsafe static void Initialize(IAnalytics analyticsInterfaces)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((analyticsInterfaces == null) ? IntPtr.Zero : ((Java.Lang.Object)analyticsInterfaces).Handle);
				Analytics._members.StaticMethods.InvokeVoidMethod("initialize.(Lcom/unity3d/services/analytics/interfaces/IAnalytics;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(analyticsInterfaces);
			}
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/interfaces/Analytics", typeof(Analytics));
	}
}
