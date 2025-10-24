using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000281 RID: 641
	[Register("android/content/ContentResolver", DoNotGenerateAcw = true)]
	public abstract class ContentResolver : Java.Lang.Object
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0003F24B File Offset: 0x0003D44B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentResolver._members;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0003F254 File Offset: 0x0003D454
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContentResolver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0003F278 File Offset: 0x0003D478
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentResolver._members.ManagedPeerType;
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ContentResolver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0003F284 File Offset: 0x0003D484
		public unsafe Stream OpenInputStream(Android.Net.Uri uri)
		{
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = InputStreamInvoker.FromJniHandle(ContentResolver._members.InstanceMethods.InvokeNonvirtualObjectMethod("openInputStream.(Landroid/net/Uri;)Ljava/io/InputStream;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x04000A54 RID: 2644
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContentResolver", typeof(ContentResolver));
	}
}
