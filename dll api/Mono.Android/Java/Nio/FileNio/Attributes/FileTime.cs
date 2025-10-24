using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio.Attributes
{
	// Token: 0x02000390 RID: 912
	[Register("java/nio/file/attribute/FileTime", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class FileTime : Java.Lang.Object, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x00072753 File Offset: 0x00070953
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileTime._members;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x0007275C File Offset: 0x0007095C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileTime._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x00072780 File Offset: 0x00070980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileTime._members.ManagedPeerType;
			}
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000021E0 File Offset: 0x000003E0
		internal FileTime(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0007278C File Offset: 0x0007098C
		public unsafe int CompareTo(FileTime other)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = FileTime._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Ljava/nio/file/attribute/FileTime;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000727F4 File Offset: 0x000709F4
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<FileTime>());
		}

		// Token: 0x04001098 RID: 4248
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/attribute/FileTime", typeof(FileTime));
	}
}
