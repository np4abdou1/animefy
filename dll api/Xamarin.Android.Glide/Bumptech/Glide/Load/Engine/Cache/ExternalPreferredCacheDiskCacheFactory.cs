using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200015F RID: 351
	[Register("com/bumptech/glide/load/engine/cache/ExternalPreferredCacheDiskCacheFactory", DoNotGenerateAcw = true)]
	public sealed class ExternalPreferredCacheDiskCacheFactory : DiskLruCacheFactory
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x000394C4 File Offset: 0x000376C4
		internal new static IntPtr class_ref
		{
			get
			{
				return ExternalPreferredCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x000394E8 File Offset: 0x000376E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExternalPreferredCacheDiskCacheFactory._members;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000394F0 File Offset: 0x000376F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExternalPreferredCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00039514 File Offset: 0x00037714
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExternalPreferredCacheDiskCacheFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00039520 File Offset: 0x00037720
		internal ExternalPreferredCacheDiskCacheFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0003952C File Offset: 0x0003772C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ExternalPreferredCacheDiskCacheFactory(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x000395DC File Offset: 0x000377DC
		[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public unsafe ExternalPreferredCacheDiskCacheFactory(Context context, string diskCacheName, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000396C0 File Offset: 0x000378C0
		[Register(".ctor", "(Landroid/content/Context;J)V", "")]
		public unsafe ExternalPreferredCacheDiskCacheFactory(Context context, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExternalPreferredCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0400040F RID: 1039
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/ExternalPreferredCacheDiskCacheFactory", typeof(ExternalPreferredCacheDiskCacheFactory));
	}
}
