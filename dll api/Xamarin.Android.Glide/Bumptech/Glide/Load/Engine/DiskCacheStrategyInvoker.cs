using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000151 RID: 337
	[Register("com/bumptech/glide/load/engine/DiskCacheStrategy", DoNotGenerateAcw = true)]
	internal class DiskCacheStrategyInvoker : DiskCacheStrategy
	{
		// Token: 0x06001104 RID: 4356 RVA: 0x00036F31 File Offset: 0x00035131
		public DiskCacheStrategyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00036F3B File Offset: 0x0003513B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskCacheStrategyInvoker._members;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00036F42 File Offset: 0x00035142
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskCacheStrategyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00036F4E File Offset: 0x0003514E
		[Register("decodeCachedData", "()Z", "GetDecodeCachedDataHandler")]
		public override bool DecodeCachedData()
		{
			return DiskCacheStrategyInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("decodeCachedData.()Z", this, null);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00036F67 File Offset: 0x00035167
		[Register("decodeCachedResource", "()Z", "GetDecodeCachedResourceHandler")]
		public override bool DecodeCachedResource()
		{
			return DiskCacheStrategyInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("decodeCachedResource.()Z", this, null);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00036F80 File Offset: 0x00035180
		[Register("isDataCacheable", "(Lcom/bumptech/glide/load/DataSource;)Z", "GetIsDataCacheable_Lcom_bumptech_glide_load_DataSource_Handler")]
		public unsafe override bool IsDataCacheable(DataSource p0)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				result = DiskCacheStrategyInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isDataCacheable.(Lcom/bumptech/glide/load/DataSource;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return result;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00036FE8 File Offset: 0x000351E8
		[Register("isResourceCacheable", "(ZLcom/bumptech/glide/load/DataSource;Lcom/bumptech/glide/load/EncodeStrategy;)Z", "GetIsResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_Handler")]
		public unsafe override bool IsResourceCacheable(bool p0, DataSource p1, EncodeStrategy p2)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				result = DiskCacheStrategyInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isResourceCacheable.(ZLcom/bumptech/glide/load/DataSource;Lcom/bumptech/glide/load/EncodeStrategy;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return result;
		}

		// Token: 0x040003E8 RID: 1000
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/DiskCacheStrategy", typeof(DiskCacheStrategyInvoker));
	}
}
