using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio.Charset;
using Java.Security;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000DF RID: 223
	[Register("com/bumptech/glide/load/Options", DoNotGenerateAcw = true)]
	public sealed class Options : Java.Lang.Object, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00022F24 File Offset: 0x00021124
		internal static IntPtr class_ref
		{
			get
			{
				return Options._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00022F48 File Offset: 0x00021148
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Options._members;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00022F50 File Offset: 0x00021150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Options._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00022F74 File Offset: 0x00021174
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Options._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00022F80 File Offset: 0x00021180
		internal Options(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00022F8C File Offset: 0x0002118C
		[Register(".ctor", "()V", "")]
		public Options() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Options._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Options._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00022FFC File Offset: 0x000211FC
		[Register("get", "(Lcom/bumptech/glide/load/Option;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object Get(Option option)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(Options._members.InstanceMethods.InvokeAbstractObjectMethod("get.(Lcom/bumptech/glide/load/Option;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(option);
			}
			return @object;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00023070 File Offset: 0x00021270
		[Register("putAll", "(Lcom/bumptech/glide/load/Options;)V", "")]
		public unsafe void PutAll(Options other)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				Options._members.InstanceMethods.InvokeAbstractVoidMethod("putAll.(Lcom/bumptech/glide/load/Options;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000230D4 File Offset: 0x000212D4
		[Register("remove", "(Lcom/bumptech/glide/load/Option;)Lcom/bumptech/glide/load/Options;", "")]
		public unsafe Options Remove(Option option)
		{
			Options @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				@object = Java.Lang.Object.GetObject<Options>(Options._members.InstanceMethods.InvokeAbstractObjectMethod("remove.(Lcom/bumptech/glide/load/Option;)Lcom/bumptech/glide/load/Options;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(option);
			}
			return @object;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00023148 File Offset: 0x00021348
		[Register("set", "(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/load/Options;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Options Set(Option option, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Options @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Options>(Options._members.InstanceMethods.InvokeAbstractObjectMethod("set.(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/load/Options;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(option);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000231E4 File Offset: 0x000213E4
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				Options._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040002C9 RID: 713
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/Options", typeof(Options));

		// Token: 0x020001C6 RID: 454
		public static class InterfaceConsts
		{
			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00044B00 File Offset: 0x00042D00
			[Register("CHARSET")]
			public static Charset Charset
			{
				get
				{
					return Java.Lang.Object.GetObject<Charset>(Options._members.StaticFields.GetObjectValue("CHARSET.Ljava/nio/charset/Charset;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0400053C RID: 1340
			[Register("STRING_CHARSET_NAME")]
			public const string StringCharsetName = "UTF-8";
		}
	}
}
