using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Load.Resource.File
{
	// Token: 0x020000EE RID: 238
	[Register("com/bumptech/glide/load/resource/file/FileResource", DoNotGenerateAcw = true)]
	public class FileResource : SimpleResource
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000250C8 File Offset: 0x000232C8
		internal new static IntPtr class_ref
		{
			get
			{
				return FileResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000250EC File Offset: 0x000232EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileResource._members;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000250F4 File Offset: 0x000232F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00025118 File Offset: 0x00023318
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00025124 File Offset: 0x00023324
		protected FileResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00025130 File Offset: 0x00023330
		[Register(".ctor", "(Ljava/io/File;)V", "")]
		public unsafe FileResource(File file) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				base.SetHandle(FileResource._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileResource._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(file);
			}
		}

		// Token: 0x040002E4 RID: 740
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/file/FileResource", typeof(FileResource));
	}
}
