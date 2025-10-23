using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C8 RID: 968
	[Register("java/lang/Enum", DoNotGenerateAcw = true)]
	internal class EnumInvoker : Enum, IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002AC3 RID: 10947 RVA: 0x00008BD0 File Offset: 0x00006DD0
		public EnumInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x0007762C File Offset: 0x0007582C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EnumInvoker._members;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x00077633 File Offset: 0x00075833
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EnumInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400113A RID: 4410
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Enum", typeof(EnumInvoker));
	}
}
