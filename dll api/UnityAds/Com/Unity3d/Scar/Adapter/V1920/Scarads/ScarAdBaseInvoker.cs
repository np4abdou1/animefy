using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V1920.Scarads
{
	// Token: 0x0200028C RID: 652
	[Register("com/unity3d/scar/adapter/v1920/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	internal class ScarAdBaseInvoker : ScarAdBase
	{
		// Token: 0x0600258F RID: 9615 RVA: 0x00060B72 File Offset: 0x0005ED72
		public ScarAdBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x00060B7C File Offset: 0x0005ED7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBaseInvoker._members;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x00060B83 File Offset: 0x0005ED83
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00060B90 File Offset: 0x0005ED90
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

		// Token: 0x04000745 RID: 1861
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/scarads/ScarAdBase", typeof(ScarAdBaseInvoker));
	}
}
