using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000111 RID: 273
	[Register("android/view/ActionProvider", DoNotGenerateAcw = true)]
	public abstract class ActionProvider : Java.Lang.Object
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001005D File Offset: 0x0000E25D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionProvider._members;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00010064 File Offset: 0x0000E264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00010088 File Offset: 0x0000E288
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ActionProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040001D2 RID: 466
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ActionProvider", typeof(ActionProvider));
	}
}
