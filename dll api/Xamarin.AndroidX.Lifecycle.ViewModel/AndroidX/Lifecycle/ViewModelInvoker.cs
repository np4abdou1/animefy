using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000F RID: 15
	[Register("androidx/lifecycle/ViewModel", DoNotGenerateAcw = true)]
	internal class ViewModelInvoker : ViewModel
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000026AB File Offset: 0x000008AB
		public ViewModelInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000026B5 File Offset: 0x000008B5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewModelInvoker._members;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000026BC File Offset: 0x000008BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewModelInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModel", typeof(ViewModelInvoker));
	}
}
