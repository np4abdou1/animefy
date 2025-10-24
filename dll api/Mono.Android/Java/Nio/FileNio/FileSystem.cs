using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000378 RID: 888
	[Register("java/nio/file/FileSystem", DoNotGenerateAcw = true, ApiSince = 26)]
	public abstract class FileSystem : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x0006F9BF File Offset: 0x0006DBBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileSystem._members;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileSystem._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x0006F9EC File Offset: 0x0006DBEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileSystem._members.ManagedPeerType;
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000021E0 File Offset: 0x000003E0
		protected FileSystem(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0006F9F8 File Offset: 0x0006DBF8
		private static Delegate GetCloseHandler()
		{
			if (FileSystem.cb_close == null)
			{
				FileSystem.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(FileSystem.n_Close));
			}
			return FileSystem.cb_close;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0006FA1C File Offset: 0x0006DC1C
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<FileSystem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002735 RID: 10037
		public abstract void Close();

		// Token: 0x0400101A RID: 4122
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/FileSystem", typeof(FileSystem));

		// Token: 0x0400101B RID: 4123
		private static Delegate cb_close;
	}
}
