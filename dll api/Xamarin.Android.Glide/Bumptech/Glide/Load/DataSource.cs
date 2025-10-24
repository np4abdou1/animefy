using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000C7 RID: 199
	[Register("com/bumptech/glide/load/DataSource", DoNotGenerateAcw = true)]
	public sealed class DataSource : Java.Lang.Enum
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002029C File Offset: 0x0001E49C
		[Register("DATA_DISK_CACHE")]
		public static DataSource DataDiskCache
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticFields.GetObjectValue("DATA_DISK_CACHE.Lcom/bumptech/glide/load/DataSource;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x000202CC File Offset: 0x0001E4CC
		[Register("LOCAL")]
		public static DataSource Local
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticFields.GetObjectValue("LOCAL.Lcom/bumptech/glide/load/DataSource;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000202FC File Offset: 0x0001E4FC
		[Register("MEMORY_CACHE")]
		public static DataSource MemoryCache
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticFields.GetObjectValue("MEMORY_CACHE.Lcom/bumptech/glide/load/DataSource;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002032C File Offset: 0x0001E52C
		[Register("REMOTE")]
		public static DataSource Remote
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticFields.GetObjectValue("REMOTE.Lcom/bumptech/glide/load/DataSource;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002035C File Offset: 0x0001E55C
		[Register("RESOURCE_DISK_CACHE")]
		public static DataSource ResourceDiskCache
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticFields.GetObjectValue("RESOURCE_DISK_CACHE.Lcom/bumptech/glide/load/DataSource;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002038C File Offset: 0x0001E58C
		internal static IntPtr class_ref
		{
			get
			{
				return DataSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000203B0 File Offset: 0x0001E5B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataSource._members;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DataSource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000203DC File Offset: 0x0001E5DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataSource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000203E8 File Offset: 0x0001E5E8
		internal DataSource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000203F4 File Offset: 0x0001E5F4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/DataSource;", "")]
		public unsafe static DataSource ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			DataSource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DataSource>(DataSource._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/DataSource;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00020460 File Offset: 0x0001E660
		[Register("values", "()[Lcom/bumptech/glide/load/DataSource;", "")]
		public static DataSource[] Values()
		{
			return (DataSource[])JNIEnv.GetArray(DataSource._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/DataSource;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DataSource));
		}

		// Token: 0x0400028E RID: 654
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/DataSource", typeof(DataSource));
	}
}
