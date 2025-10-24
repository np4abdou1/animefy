using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038F RID: 911
	[Register("java/nio/file/LinkOption", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class LinkOption : Java.Lang.Enum, ICopyOption, IJavaObject, IDisposable, IJavaPeerable, IOpenOption
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x00072700 File Offset: 0x00070900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LinkOption._members;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x00072708 File Offset: 0x00070908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LinkOption._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0007272C File Offset: 0x0007092C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LinkOption._members.ManagedPeerType;
			}
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00008BD0 File Offset: 0x00006DD0
		internal LinkOption(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001097 RID: 4247
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/LinkOption", typeof(LinkOption));
	}
}
