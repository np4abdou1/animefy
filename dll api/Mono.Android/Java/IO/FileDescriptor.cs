using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000414 RID: 1044
	[Register("java/io/FileDescriptor", DoNotGenerateAcw = true)]
	public sealed class FileDescriptor : Java.Lang.Object
	{
		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x0007DAE5 File Offset: 0x0007BCE5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileDescriptor._members;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileDescriptor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x0007DB10 File Offset: 0x0007BD10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileDescriptor._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000021E0 File Offset: 0x000003E0
		internal FileDescriptor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001208 RID: 4616
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/FileDescriptor", typeof(FileDescriptor));
	}
}
