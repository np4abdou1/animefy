using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001E0 RID: 480
	[Register("android/os/Environment", DoNotGenerateAcw = true)]
	public class Environment : Java.Lang.Object
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
		[Register("DIRECTORY_DOWNLOADS")]
		public static string DirectoryDownloads
		{
			get
			{
				return JNIEnv.GetString(Environment._members.StaticFields.GetObjectValue("DIRECTORY_DOWNLOADS.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0002E6D3 File Offset: 0x0002C8D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Environment._members;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Environment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0002E700 File Offset: 0x0002C900
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Environment._members.ManagedPeerType;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Environment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0002E70C File Offset: 0x0002C90C
		public unsafe static File GetExternalStoragePublicDirectory(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<File>(Environment._members.StaticMethods.InvokeObjectMethod("getExternalStoragePublicDirectory.(Ljava/lang/String;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Environment", typeof(Environment));
	}
}
