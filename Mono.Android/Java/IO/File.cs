using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000413 RID: 1043
	[Register("java/io/File", DoNotGenerateAcw = true)]
	public class File : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x0007D989 File Offset: 0x0007BB89
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return File._members;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x0007D990 File Offset: 0x0007BB90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return File._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x0007D9B4 File Offset: 0x0007BBB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return File._members.ManagedPeerType;
			}
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x000021E0 File Offset: 0x000003E0
		protected File(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x0007D9C0 File Offset: 0x0007BBC0
		private static Delegate GetCompareTo_Ljava_io_File_Handler()
		{
			if (File.cb_compareTo_Ljava_io_File_ == null)
			{
				File.cb_compareTo_Ljava_io_File_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(File.n_CompareTo_Ljava_io_File_));
			}
			return File.cb_compareTo_Ljava_io_File_;
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0007D9E4 File Offset: 0x0007BBE4
		private static int n_CompareTo_Ljava_io_File_(IntPtr jnienv, IntPtr native__this, IntPtr native_pathname)
		{
			File @object = Java.Lang.Object.GetObject<File>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			File object2 = Java.Lang.Object.GetObject<File>(native_pathname, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x0007DA08 File Offset: 0x0007BC08
		public unsafe virtual int CompareTo(File pathname)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((pathname == null) ? IntPtr.Zero : pathname.Handle);
				result = File._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/io/File;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(pathname);
			}
			return result;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0007DA70 File Offset: 0x0007BC70
		private static Delegate GetMkdirsHandler()
		{
			if (File.cb_mkdirs == null)
			{
				File.cb_mkdirs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(File.n_Mkdirs));
			}
			return File.cb_mkdirs;
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x0007DA94 File Offset: 0x0007BC94
		private static bool n_Mkdirs(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<File>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Mkdirs();
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x0007DAA3 File Offset: 0x0007BCA3
		public virtual bool Mkdirs()
		{
			return File._members.InstanceMethods.InvokeVirtualBooleanMethod("mkdirs.()Z", this, null);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x0007DABC File Offset: 0x0007BCBC
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<File>());
		}

		// Token: 0x04001205 RID: 4613
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/File", typeof(File));

		// Token: 0x04001206 RID: 4614
		private static Delegate cb_compareTo_Ljava_io_File_;

		// Token: 0x04001207 RID: 4615
		private static Delegate cb_mkdirs;
	}
}
