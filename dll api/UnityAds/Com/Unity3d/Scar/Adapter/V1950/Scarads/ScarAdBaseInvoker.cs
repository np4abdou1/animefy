using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V1950.Scarads
{
	// Token: 0x02000274 RID: 628
	[Register("com/unity3d/scar/adapter/v1950/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	internal class ScarAdBaseInvoker : ScarAdBase
	{
		// Token: 0x0600236B RID: 9067 RVA: 0x0005D2AE File Offset: 0x0005B4AE
		public ScarAdBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0005D2B8 File Offset: 0x0005B4B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBaseInvoker._members;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x0005D2BF File Offset: 0x0005B4BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0005D2CC File Offset: 0x0005B4CC
		[Register("show", "(Landroid/app/Activity;)V", "GetShow_Landroid_app_Activity_Handler")]
		public unsafe override void Show(Activity p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ScarAdBaseInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("show.(Landroid/app/Activity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0400071D RID: 1821
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/scarads/ScarAdBase", typeof(ScarAdBaseInvoker));
	}
}
