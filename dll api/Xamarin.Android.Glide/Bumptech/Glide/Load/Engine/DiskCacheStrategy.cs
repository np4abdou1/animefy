using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000150 RID: 336
	[Register("com/bumptech/glide/load/engine/DiskCacheStrategy", DoNotGenerateAcw = true)]
	public abstract class DiskCacheStrategy : Java.Lang.Object
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00036C50 File Offset: 0x00034E50
		[Register("ALL")]
		public static DiskCacheStrategy All
		{
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(DiskCacheStrategy._members.StaticFields.GetObjectValue("ALL.Lcom/bumptech/glide/load/engine/DiskCacheStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00036C80 File Offset: 0x00034E80
		[Register("AUTOMATIC")]
		public static DiskCacheStrategy Automatic
		{
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(DiskCacheStrategy._members.StaticFields.GetObjectValue("AUTOMATIC.Lcom/bumptech/glide/load/engine/DiskCacheStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00036CB0 File Offset: 0x00034EB0
		[Register("DATA")]
		public static DiskCacheStrategy Data
		{
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(DiskCacheStrategy._members.StaticFields.GetObjectValue("DATA.Lcom/bumptech/glide/load/engine/DiskCacheStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00036CE0 File Offset: 0x00034EE0
		[Register("NONE")]
		public static DiskCacheStrategy None
		{
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(DiskCacheStrategy._members.StaticFields.GetObjectValue("NONE.Lcom/bumptech/glide/load/engine/DiskCacheStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00036D10 File Offset: 0x00034F10
		[Register("RESOURCE")]
		public static DiskCacheStrategy Resource
		{
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(DiskCacheStrategy._members.StaticFields.GetObjectValue("RESOURCE.Lcom/bumptech/glide/load/engine/DiskCacheStrategy;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00036D40 File Offset: 0x00034F40
		internal static IntPtr class_ref
		{
			get
			{
				return DiskCacheStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00036D64 File Offset: 0x00034F64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskCacheStrategy._members;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00036D6C File Offset: 0x00034F6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DiskCacheStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00036D90 File Offset: 0x00034F90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskCacheStrategy._members.ManagedPeerType;
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00036D9C File Offset: 0x00034F9C
		protected DiskCacheStrategy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00036DA8 File Offset: 0x00034FA8
		[Register(".ctor", "()V", "")]
		public DiskCacheStrategy() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DiskCacheStrategy._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DiskCacheStrategy._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00036E16 File Offset: 0x00035016
		private static Delegate GetDecodeCachedDataHandler()
		{
			if (DiskCacheStrategy.cb_decodeCachedData == null)
			{
				DiskCacheStrategy.cb_decodeCachedData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DiskCacheStrategy.n_DecodeCachedData));
			}
			return DiskCacheStrategy.cb_decodeCachedData;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00036E3A File Offset: 0x0003503A
		private static bool n_DecodeCachedData(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DiskCacheStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DecodeCachedData();
		}

		// Token: 0x060010F9 RID: 4345
		[Register("decodeCachedData", "()Z", "GetDecodeCachedDataHandler")]
		public abstract bool DecodeCachedData();

		// Token: 0x060010FA RID: 4346 RVA: 0x00036E49 File Offset: 0x00035049
		private static Delegate GetDecodeCachedResourceHandler()
		{
			if (DiskCacheStrategy.cb_decodeCachedResource == null)
			{
				DiskCacheStrategy.cb_decodeCachedResource = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DiskCacheStrategy.n_DecodeCachedResource));
			}
			return DiskCacheStrategy.cb_decodeCachedResource;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00036E6D File Offset: 0x0003506D
		private static bool n_DecodeCachedResource(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DiskCacheStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DecodeCachedResource();
		}

		// Token: 0x060010FC RID: 4348
		[Register("decodeCachedResource", "()Z", "GetDecodeCachedResourceHandler")]
		public abstract bool DecodeCachedResource();

		// Token: 0x060010FD RID: 4349 RVA: 0x00036E7C File Offset: 0x0003507C
		private static Delegate GetIsDataCacheable_Lcom_bumptech_glide_load_DataSource_Handler()
		{
			if (DiskCacheStrategy.cb_isDataCacheable_Lcom_bumptech_glide_load_DataSource_ == null)
			{
				DiskCacheStrategy.cb_isDataCacheable_Lcom_bumptech_glide_load_DataSource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(DiskCacheStrategy.n_IsDataCacheable_Lcom_bumptech_glide_load_DataSource_));
			}
			return DiskCacheStrategy.cb_isDataCacheable_Lcom_bumptech_glide_load_DataSource_;
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00036EA0 File Offset: 0x000350A0
		private static bool n_IsDataCacheable_Lcom_bumptech_glide_load_DataSource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			DiskCacheStrategy @object = Java.Lang.Object.GetObject<DiskCacheStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.IsDataCacheable(object2);
		}

		// Token: 0x060010FF RID: 4351
		[Register("isDataCacheable", "(Lcom/bumptech/glide/load/DataSource;)Z", "GetIsDataCacheable_Lcom_bumptech_glide_load_DataSource_Handler")]
		public abstract bool IsDataCacheable(DataSource p0);

		// Token: 0x06001100 RID: 4352 RVA: 0x00036EC3 File Offset: 0x000350C3
		private static Delegate GetIsResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_Handler()
		{
			if (DiskCacheStrategy.cb_isResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_ == null)
			{
				DiskCacheStrategy.cb_isResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZLL_Z(DiskCacheStrategy.n_IsResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_));
			}
			return DiskCacheStrategy.cb_isResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00036EE8 File Offset: 0x000350E8
		private static bool n_IsResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_(IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2)
		{
			DiskCacheStrategy @object = Java.Lang.Object.GetObject<DiskCacheStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_p1, JniHandleOwnership.DoNotTransfer);
			EncodeStrategy object3 = Java.Lang.Object.GetObject<EncodeStrategy>(native_p2, JniHandleOwnership.DoNotTransfer);
			return @object.IsResourceCacheable(p0, object2, object3);
		}

		// Token: 0x06001102 RID: 4354
		[Register("isResourceCacheable", "(ZLcom/bumptech/glide/load/DataSource;Lcom/bumptech/glide/load/EncodeStrategy;)Z", "GetIsResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_Handler")]
		public abstract bool IsResourceCacheable(bool p0, DataSource p1, EncodeStrategy p2);

		// Token: 0x040003E3 RID: 995
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/DiskCacheStrategy", typeof(DiskCacheStrategy));

		// Token: 0x040003E4 RID: 996
		private static Delegate cb_decodeCachedData;

		// Token: 0x040003E5 RID: 997
		private static Delegate cb_decodeCachedResource;

		// Token: 0x040003E6 RID: 998
		private static Delegate cb_isDataCacheable_Lcom_bumptech_glide_load_DataSource_;

		// Token: 0x040003E7 RID: 999
		private static Delegate cb_isResourceCacheable_ZLcom_bumptech_glide_load_DataSource_Lcom_bumptech_glide_load_EncodeStrategy_;
	}
}
