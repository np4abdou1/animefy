using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Nio.FileNio
{
	// Token: 0x02000379 RID: 889
	[Register("java/nio/file/FileSystem", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class FileSystemInvoker : FileSystem
	{
		// Token: 0x06002737 RID: 10039 RVA: 0x0006FA46 File Offset: 0x0006DC46
		public FileSystemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x0006FA50 File Offset: 0x0006DC50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileSystemInvoker._members;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x0006FA57 File Offset: 0x0006DC57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileSystemInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0006FA63 File Offset: 0x0006DC63
		public override void Close()
		{
			FileSystemInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x0400101C RID: 4124
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/FileSystem", typeof(FileSystemInvoker));
	}
}
