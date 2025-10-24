using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x0200009F RID: 159
	[Register("androidx/core/view/ActionProvider", DoNotGenerateAcw = true)]
	internal class ActionProviderInvoker : ActionProvider
	{
		// Token: 0x06000889 RID: 2185 RVA: 0x00019B68 File Offset: 0x00017D68
		public ActionProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00019B72 File Offset: 0x00017D72
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionProviderInvoker._members;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00019B79 File Offset: 0x00017D79
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00019B88 File Offset: 0x00017D88
		[Register("onCreateActionView", "()Landroid/view/View;", "GetOnCreateActionViewHandler")]
		public override View OnCreateActionView()
		{
			return Java.Lang.Object.GetObject<View>(ActionProviderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onCreateActionView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000249 RID: 585
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ActionProvider", typeof(ActionProviderInvoker));
	}
}
