using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;
using Java.Security;

namespace Bumptech.Glide.Signature
{
	// Token: 0x0200005C RID: 92
	[Register("com/bumptech/glide/signature/EmptySignature", DoNotGenerateAcw = true)]
	public sealed class EmptySignature : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000DF08 File Offset: 0x0000C108
		internal static IntPtr class_ref
		{
			get
			{
				return EmptySignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000DF2C File Offset: 0x0000C12C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EmptySignature._members;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000DF34 File Offset: 0x0000C134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EmptySignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0000DF58 File Offset: 0x0000C158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EmptySignature._members.ManagedPeerType;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000DF64 File Offset: 0x0000C164
		internal EmptySignature(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000DF70 File Offset: 0x0000C170
		[Register("obtain", "()Lcom/bumptech/glide/signature/EmptySignature;", "")]
		public static EmptySignature Obtain()
		{
			return Java.Lang.Object.GetObject<EmptySignature>(EmptySignature._members.StaticMethods.InvokeObjectMethod("obtain.()Lcom/bumptech/glide/signature/EmptySignature;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000DFA4 File Offset: 0x0000C1A4
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				EmptySignature._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/signature/EmptySignature", typeof(EmptySignature));

		// Token: 0x020001B8 RID: 440
		public static class InterfaceConsts
		{
			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x0600159F RID: 5535 RVA: 0x0004400C File Offset: 0x0004220C
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(EmptySignature._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000525 RID: 1317
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
