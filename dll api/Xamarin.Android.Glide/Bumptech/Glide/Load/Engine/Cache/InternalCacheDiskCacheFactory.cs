using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016E RID: 366
	[Register("com/bumptech/glide/load/engine/cache/InternalCacheDiskCacheFactory", DoNotGenerateAcw = true)]
	public sealed class InternalCacheDiskCacheFactory : DiskLruCacheFactory
	{
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0003A714 File Offset: 0x00038914
		internal new static IntPtr class_ref
		{
			get
			{
				return InternalCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0003A738 File Offset: 0x00038938
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InternalCacheDiskCacheFactory._members;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0003A740 File Offset: 0x00038940
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InternalCacheDiskCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0003A764 File Offset: 0x00038964
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InternalCacheDiskCacheFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0003A770 File Offset: 0x00038970
		internal InternalCacheDiskCacheFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0003A77C File Offset: 0x0003897C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe InternalCacheDiskCacheFactory(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(InternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0003A82C File Offset: 0x00038A2C
		[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public unsafe InternalCacheDiskCacheFactory(Context context, string diskCacheName, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(InternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0003A910 File Offset: 0x00038B10
		[Register(".ctor", "(Landroid/content/Context;J)V", "")]
		public unsafe InternalCacheDiskCacheFactory(Context context, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(InternalCacheDiskCacheFactory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				InternalCacheDiskCacheFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/InternalCacheDiskCacheFactory", typeof(InternalCacheDiskCacheFactory));
	}
}
