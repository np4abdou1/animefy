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
	// Token: 0x0200005E RID: 94
	[Register("com/bumptech/glide/signature/ObjectKey", DoNotGenerateAcw = true)]
	public sealed class ObjectKey : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000E224 File Offset: 0x0000C424
		internal static IntPtr class_ref
		{
			get
			{
				return ObjectKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000E248 File Offset: 0x0000C448
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ObjectKey._members;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000E250 File Offset: 0x0000C450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ObjectKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000E274 File Offset: 0x0000C474
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ObjectKey._members.ManagedPeerType;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000E280 File Offset: 0x0000C480
		internal ObjectKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000E28C File Offset: 0x0000C48C
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ObjectKey(Java.Lang.Object @object) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@object == null) ? IntPtr.Zero : @object.Handle);
				base.SetHandle(ObjectKey._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ObjectKey._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@object);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000E33C File Offset: 0x0000C53C
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				ObjectKey._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/signature/ObjectKey", typeof(ObjectKey));

		// Token: 0x020001BA RID: 442
		public static class InterfaceConsts
		{
			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0004406C File Offset: 0x0004226C
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(ObjectKey._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x04000527 RID: 1319
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
