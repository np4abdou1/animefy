using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2000.Scarads
{
	// Token: 0x0200025E RID: 606
	[Register("com/unity3d/scar/adapter/v2000/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	internal class ScarAdBaseInvoker : ScarAdBase
	{
		// Token: 0x060020F1 RID: 8433 RVA: 0x00059316 File Offset: 0x00057516
		public ScarAdBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x00059320 File Offset: 0x00057520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBaseInvoker._members;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x00059327 File Offset: 0x00057527
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00059334 File Offset: 0x00057534
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

		// Token: 0x040006FC RID: 1788
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/scarads/ScarAdBase", typeof(ScarAdBaseInvoker));
	}
}
