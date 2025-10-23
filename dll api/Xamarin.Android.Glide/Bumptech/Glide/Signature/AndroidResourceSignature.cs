using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;
using Java.Security;

namespace Bumptech.Glide.Signature
{
	// Token: 0x0200005A RID: 90
	[Register("com/bumptech/glide/signature/AndroidResourceSignature", DoNotGenerateAcw = true)]
	public sealed class AndroidResourceSignature : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
		internal static IntPtr class_ref
		{
			get
			{
				return AndroidResourceSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000DCD8 File Offset: 0x0000BED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AndroidResourceSignature._members;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AndroidResourceSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000DD04 File Offset: 0x0000BF04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AndroidResourceSignature._members.ManagedPeerType;
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000DD10 File Offset: 0x0000BF10
		internal AndroidResourceSignature(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		[Register("obtain", "(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;", "")]
		public unsafe static IKey Obtain(Context context)
		{
			IKey @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IKey>(AndroidResourceSignature._members.StaticMethods.InvokeObjectMethod("obtain.(Landroid/content/Context;)Lcom/bumptech/glide/load/Key;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000DD90 File Offset: 0x0000BF90
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				AndroidResourceSignature._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040000D7 RID: 215
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/signature/AndroidResourceSignature", typeof(AndroidResourceSignature));

		// Token: 0x020001B7 RID: 439
		public static class InterfaceConsts
		{
			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x0600159E RID: 5534 RVA: 0x00043FDC File Offset: 0x000421DC
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(AndroidResourceSignature._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000524 RID: 1316
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
