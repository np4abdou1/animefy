using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Scar.Adapter.V2100.Scarads
{
	// Token: 0x02000247 RID: 583
	[Register("com/unity3d/scar/adapter/v2100/scarads/ScarAdBase", DoNotGenerateAcw = true)]
	internal class ScarAdBaseInvoker : ScarAdBase
	{
		// Token: 0x06001E69 RID: 7785 RVA: 0x000550AA File Offset: 0x000532AA
		public ScarAdBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x000550B4 File Offset: 0x000532B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScarAdBaseInvoker._members;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x000550BB File Offset: 0x000532BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScarAdBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000550C8 File Offset: 0x000532C8
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

		// Token: 0x040006D9 RID: 1753
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/scarads/ScarAdBase", typeof(ScarAdBaseInvoker));
	}
}
