using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x0200037A RID: 890
	[Register("java/nio/file/FileVisitResult", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class FileVisitResult : Java.Lang.Enum
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x0006FA97 File Offset: 0x0006DC97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileVisitResult._members;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x0006FAA0 File Offset: 0x0006DCA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileVisitResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x0006FAC4 File Offset: 0x0006DCC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileVisitResult._members.ManagedPeerType;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00008BD0 File Offset: 0x00006DD0
		internal FileVisitResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400101D RID: 4125
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/FileVisitResult", typeof(FileVisitResult));
	}
}
