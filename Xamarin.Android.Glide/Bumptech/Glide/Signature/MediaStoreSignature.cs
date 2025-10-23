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
	// Token: 0x0200005D RID: 93
	[Register("com/bumptech/glide/signature/MediaStoreSignature", DoNotGenerateAcw = true)]
	public class MediaStoreSignature : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000E024 File Offset: 0x0000C224
		internal static IntPtr class_ref
		{
			get
			{
				return MediaStoreSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000E048 File Offset: 0x0000C248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStoreSignature._members;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000E050 File Offset: 0x0000C250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStoreSignature._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0000E074 File Offset: 0x0000C274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStoreSignature._members.ManagedPeerType;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000E080 File Offset: 0x0000C280
		protected MediaStoreSignature(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000E08C File Offset: 0x0000C28C
		[Register(".ctor", "(Ljava/lang/String;JI)V", "")]
		public unsafe MediaStoreSignature(string mimeType, long dateModified, int orientation) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(mimeType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(dateModified);
				ptr[2] = new JniArgumentValue(orientation);
				base.SetHandle(MediaStoreSignature._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;JI)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaStoreSignature._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;JI)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000E15C File Offset: 0x0000C35C
		private static Delegate GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler()
		{
			if (MediaStoreSignature.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ == null)
			{
				MediaStoreSignature.cb_updateDiskCacheKey_Ljava_security_MessageDigest_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MediaStoreSignature.n_UpdateDiskCacheKey_Ljava_security_MessageDigest_));
			}
			return MediaStoreSignature.cb_updateDiskCacheKey_Ljava_security_MessageDigest_;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000E180 File Offset: 0x0000C380
		private static void n_UpdateDiskCacheKey_Ljava_security_MessageDigest_(IntPtr jnienv, IntPtr native__this, IntPtr native_messageDigest)
		{
			MediaStoreSignature @object = Java.Lang.Object.GetObject<MediaStoreSignature>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MessageDigest object2 = Java.Lang.Object.GetObject<MessageDigest>(native_messageDigest, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDiskCacheKey(object2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "GetUpdateDiskCacheKey_Ljava_security_MessageDigest_Handler")]
		public unsafe virtual void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				MediaStoreSignature._members.InstanceMethods.InvokeVirtualVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/signature/MediaStoreSignature", typeof(MediaStoreSignature));

		// Token: 0x040000DB RID: 219
		private static Delegate cb_updateDiskCacheKey_Ljava_security_MessageDigest_;

		// Token: 0x020001B9 RID: 441
		public static class InterfaceConsts
		{
			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0004403C File Offset: 0x0004223C
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(MediaStoreSignature._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000526 RID: 1318
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
