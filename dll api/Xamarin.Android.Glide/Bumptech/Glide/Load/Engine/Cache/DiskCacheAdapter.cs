using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200015B RID: 347
	[Register("com/bumptech/glide/load/engine/cache/DiskCacheAdapter", DoNotGenerateAcw = true)]
	public class DiskCacheAdapter : Java.Lang.Object, IDiskCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00038608 File Offset: 0x00036808
		internal static IntPtr class_ref
		{
			get
			{
				return DiskCacheAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0003862C File Offset: 0x0003682C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskCacheAdapter._members;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00038634 File Offset: 0x00036834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DiskCacheAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x00038658 File Offset: 0x00036858
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskCacheAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00038664 File Offset: 0x00036864
		protected DiskCacheAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00038670 File Offset: 0x00036870
		[Register(".ctor", "()V", "")]
		public DiskCacheAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DiskCacheAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DiskCacheAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000386DE File Offset: 0x000368DE
		private static Delegate GetClearHandler()
		{
			if (DiskCacheAdapter.cb_clear == null)
			{
				DiskCacheAdapter.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DiskCacheAdapter.n_Clear));
			}
			return DiskCacheAdapter.cb_clear;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00038702 File Offset: 0x00036902
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DiskCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00038711 File Offset: 0x00036911
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			DiskCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0003872A File Offset: 0x0003692A
		private static Delegate GetDelete_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (DiskCacheAdapter.cb_delete_Lcom_bumptech_glide_load_Key_ == null)
			{
				DiskCacheAdapter.cb_delete_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DiskCacheAdapter.n_Delete_Lcom_bumptech_glide_load_Key_));
			}
			return DiskCacheAdapter.cb_delete_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00038750 File Offset: 0x00036950
		private static void n_Delete_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			DiskCacheAdapter @object = Java.Lang.Object.GetObject<DiskCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			@object.Delete(object2);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00038774 File Offset: 0x00036974
		[Register("delete", "(Lcom/bumptech/glide/load/Key;)V", "GetDelete_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual void Delete(IKey key)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				DiskCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("delete.(Lcom/bumptech/glide/load/Key;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000387DC File Offset: 0x000369DC
		private static Delegate GetGet_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (DiskCacheAdapter.cb_get_Lcom_bumptech_glide_load_Key_ == null)
			{
				DiskCacheAdapter.cb_get_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DiskCacheAdapter.n_Get_Lcom_bumptech_glide_load_Key_));
			}
			return DiskCacheAdapter.cb_get_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00038800 File Offset: 0x00036A00
		private static IntPtr n_Get_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			DiskCacheAdapter @object = Java.Lang.Object.GetObject<DiskCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00038828 File Offset: 0x00036A28
		[Register("get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", "GetGet_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual File Get(IKey key)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<File>(DiskCacheAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000388A0 File Offset: 0x00036AA0
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler()
		{
			if (DiskCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == null)
			{
				DiskCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(DiskCacheAdapter.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_));
			}
			return DiskCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000388C4 File Offset: 0x00036AC4
		private static void n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_writer)
		{
			DiskCacheAdapter @object = Java.Lang.Object.GetObject<DiskCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			IDiskCacheWriter object3 = Java.Lang.Object.GetObject<IDiskCacheWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000388F0 File Offset: 0x00036AF0
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler")]
		public unsafe virtual void Put(IKey key, IDiskCacheWriter writer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				ptr[1] = new JniArgumentValue((writer == null) ? IntPtr.Zero : ((Java.Lang.Object)writer).Handle);
				DiskCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(writer);
			}
		}

		// Token: 0x04000402 RID: 1026
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskCacheAdapter", typeof(DiskCacheAdapter));

		// Token: 0x04000403 RID: 1027
		private static Delegate cb_clear;

		// Token: 0x04000404 RID: 1028
		private static Delegate cb_delete_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000405 RID: 1029
		private static Delegate cb_get_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000406 RID: 1030
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;

		// Token: 0x020001F7 RID: 503
		[Register("com/bumptech/glide/load/engine/cache/DiskCacheAdapter$Factory", DoNotGenerateAcw = true)]
		public sealed class Factory : Java.Lang.Object, IDiskCacheFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00049DC8 File Offset: 0x00047FC8
			internal static IntPtr class_ref
			{
				get
				{
					return DiskCacheAdapter.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00049DEC File Offset: 0x00047FEC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DiskCacheAdapter.Factory._members;
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00049DF4 File Offset: 0x00047FF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DiskCacheAdapter.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00049E18 File Offset: 0x00048018
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DiskCacheAdapter.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x00049E24 File Offset: 0x00048024
			internal Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017E8 RID: 6120 RVA: 0x00049E30 File Offset: 0x00048030
			[Register(".ctor", "()V", "")]
			public Factory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(DiskCacheAdapter.Factory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				DiskCacheAdapter.Factory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x00049EA0 File Offset: 0x000480A0
			[Register("build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "")]
			public IDiskCache Build()
			{
				return Java.Lang.Object.GetObject<IDiskCache>(DiskCacheAdapter.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/bumptech/glide/load/engine/cache/DiskCache;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040005B1 RID: 1457
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskCacheAdapter$Factory", typeof(DiskCacheAdapter.Factory));

			// Token: 0x02000208 RID: 520
			public static class InterfaceConsts
			{
				// Token: 0x040005CA RID: 1482
				[Register("DEFAULT_DISK_CACHE_DIR")]
				public const string DefaultDiskCacheDir = "image_manager_disk_cache";

				// Token: 0x040005CB RID: 1483
				[Register("DEFAULT_DISK_CACHE_SIZE")]
				public const int DefaultDiskCacheSize = 262144000;
			}
		}
	}
}
