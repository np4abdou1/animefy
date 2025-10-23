using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;

namespace Android.Text.Style
{
	// Token: 0x020001C4 RID: 452
	[Register("android/text/style/ClickableSpan", DoNotGenerateAcw = true)]
	internal class ClickableSpanInvoker : ClickableSpan
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x0002A733 File Offset: 0x00028933
		public ClickableSpanInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0002A73D File Offset: 0x0002893D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClickableSpanInvoker._members;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0002A744 File Offset: 0x00028944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClickableSpanInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002A750 File Offset: 0x00028950
		public unsafe override void OnClick(View widget)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((widget == null) ? IntPtr.Zero : widget.Handle);
				ClickableSpanInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onClick.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(widget);
			}
		}

		// Token: 0x0400077C RID: 1916
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/ClickableSpan", typeof(ClickableSpanInvoker));
	}
}
