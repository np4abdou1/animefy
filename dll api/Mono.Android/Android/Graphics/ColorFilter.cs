using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200021C RID: 540
	[Register("android/graphics/ColorFilter", DoNotGenerateAcw = true)]
	public class ColorFilter : Java.Lang.Object
	{
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x000324C7 File Offset: 0x000306C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ColorFilter._members;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x000324D0 File Offset: 0x000306D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ColorFilter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x000324F4 File Offset: 0x000306F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ColorFilter._members.ManagedPeerType;
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ColorFilter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000894 RID: 2196
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/ColorFilter", typeof(ColorFilter));
	}
}
