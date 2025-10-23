using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Util
{
	// Token: 0x02000195 RID: 405
	[Register("android/util/Property", DoNotGenerateAcw = true)]
	internal class PropertyInvoker : Property
	{
		// Token: 0x06000E43 RID: 3651 RVA: 0x000249CF File Offset: 0x00022BCF
		public PropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000249D9 File Offset: 0x00022BD9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PropertyInvoker._members;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000249E0 File Offset: 0x00022BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040006A4 RID: 1700
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/Property", typeof(PropertyInvoker));
	}
}
