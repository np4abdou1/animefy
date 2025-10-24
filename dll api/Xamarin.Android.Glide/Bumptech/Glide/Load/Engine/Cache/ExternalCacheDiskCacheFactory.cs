using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200015E RID: 350
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/load/engine/cache/ExternalCacheDiskCacheFactory", DoNotGenerateAcw = true)]
	public sealed class ExternalCacheDiskCacheFactory : DiskLruCacheFactory
	{
		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000391EC File Offset: 0x000373EC
		internal new static IntPtr class_ref
		{
			get
			{
				return ExternalCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00039210 File Offset: 0x00037410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExternalCacheDiskCacheFactory._members;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00039218 File Offset: 0x00037418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExternalCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0003923C File Offset: 0x0003743C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExternalCacheDiskCacheFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00039248 File Offset: 0x00037448
		internal ExternalCacheDiskCacheFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00039254 File Offset: 0x00037454
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ExternalCacheDiskCacheFactory(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ExternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00039304 File Offset: 0x00037504
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe ExternalCacheDiskCacheFactory(Context context, int diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(diskCacheSize);
				base.SetHandle(ExternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000393C4 File Offset: 0x000375C4
		[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public unsafe ExternalCacheDiskCacheFactory(Context context, string diskCacheName, int diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(diskCacheName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(diskCacheSize);
				base.SetHandle(ExternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0400040E RID: 1038
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/ExternalCacheDiskCacheFactory", typeof(ExternalCacheDiskCacheFactory));
	}
}
