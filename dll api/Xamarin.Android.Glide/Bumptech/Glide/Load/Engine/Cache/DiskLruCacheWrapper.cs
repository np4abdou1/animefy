using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200015D RID: 349
	[Register("com/bumptech/glide/load/engine/cache/DiskLruCacheWrapper", DoNotGenerateAcw = true)]
	public class DiskLruCacheWrapper : Java.Lang.Object, IDiskCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00038CF0 File Offset: 0x00036EF0
		internal static IntPtr class_ref
		{
			get
			{
				return DiskLruCacheWrapper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00038D14 File Offset: 0x00036F14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskLruCacheWrapper._members;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00038D1C File Offset: 0x00036F1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DiskLruCacheWrapper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00038D40 File Offset: 0x00036F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskLruCacheWrapper._members.ManagedPeerType;
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00038D4C File Offset: 0x00036F4C
		protected DiskLruCacheWrapper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00038D58 File Offset: 0x00036F58
		[Register(".ctor", "(Ljava/io/File;J)V", "")]
		[Obsolete("deprecated")]
		protected unsafe DiskLruCacheWrapper(File directory, long maxSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				ptr[1] = new JniArgumentValue(maxSize);
				base.SetHandle(DiskLruCacheWrapper._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DiskLruCacheWrapper._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(directory);
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00038E18 File Offset: 0x00037018
		private static Delegate GetClearHandler()
		{
			if (DiskLruCacheWrapper.cb_clear == null)
			{
				DiskLruCacheWrapper.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DiskLruCacheWrapper.n_Clear));
			}
			return DiskLruCacheWrapper.cb_clear;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00038E3C File Offset: 0x0003703C
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DiskLruCacheWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00038E4B File Offset: 0x0003704B
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			DiskLruCacheWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00038E64 File Offset: 0x00037064
		[Register("create", "(Ljava/io/File;J)Lcom/bumptech/glide/load/engine/cache/DiskCache;", "")]
		public unsafe static IDiskCache Create(File directory, long maxSize)
		{
			IDiskCache @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				ptr[1] = new JniArgumentValue(maxSize);
				@object = Java.Lang.Object.GetObject<IDiskCache>(DiskLruCacheWrapper._members.StaticMethods.InvokeObjectMethod("create.(Ljava/io/File;J)Lcom/bumptech/glide/load/engine/cache/DiskCache;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(directory);
			}
			return @object;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00038EEC File Offset: 0x000370EC
		private static Delegate GetDelete_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (DiskLruCacheWrapper.cb_delete_Lcom_bumptech_glide_load_Key_ == null)
			{
				DiskLruCacheWrapper.cb_delete_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DiskLruCacheWrapper.n_Delete_Lcom_bumptech_glide_load_Key_));
			}
			return DiskLruCacheWrapper.cb_delete_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00038F10 File Offset: 0x00037110
		private static void n_Delete_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			DiskLruCacheWrapper @object = Java.Lang.Object.GetObject<DiskLruCacheWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			@object.Delete(object2);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00038F34 File Offset: 0x00037134
		[Register("delete", "(Lcom/bumptech/glide/load/Key;)V", "GetDelete_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual void Delete(IKey key)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				DiskLruCacheWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("delete.(Lcom/bumptech/glide/load/Key;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00038F9C File Offset: 0x0003719C
		private static Delegate GetGet_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (DiskLruCacheWrapper.cb_get_Lcom_bumptech_glide_load_Key_ == null)
			{
				DiskLruCacheWrapper.cb_get_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(DiskLruCacheWrapper.n_Get_Lcom_bumptech_glide_load_Key_));
			}
			return DiskLruCacheWrapper.cb_get_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00038FC0 File Offset: 0x000371C0
		private static IntPtr n_Get_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			DiskLruCacheWrapper @object = Java.Lang.Object.GetObject<DiskLruCacheWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00038FE8 File Offset: 0x000371E8
		[Register("get", "(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", "GetGet_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual File Get(IKey key)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<File>(DiskLruCacheWrapper._members.InstanceMethods.InvokeVirtualObjectMethod("get.(Lcom/bumptech/glide/load/Key;)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00039060 File Offset: 0x00037260
		[Obsolete("deprecated")]
		[Register("get", "(Ljava/io/File;J)Lcom/bumptech/glide/load/engine/cache/DiskCache;", "")]
		public unsafe static IDiskCache Get(File directory, long maxSize)
		{
			IDiskCache @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				ptr[1] = new JniArgumentValue(maxSize);
				@object = Java.Lang.Object.GetObject<IDiskCache>(DiskLruCacheWrapper._members.StaticMethods.InvokeObjectMethod("get.(Ljava/io/File;J)Lcom/bumptech/glide/load/engine/cache/DiskCache;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(directory);
			}
			return @object;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000390E8 File Offset: 0x000372E8
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler()
		{
			if (DiskLruCacheWrapper.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ == null)
			{
				DiskLruCacheWrapper.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(DiskLruCacheWrapper.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_));
			}
			return DiskLruCacheWrapper.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003910C File Offset: 0x0003730C
		private static void n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_writer)
		{
			DiskLruCacheWrapper @object = Java.Lang.Object.GetObject<DiskLruCacheWrapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			IDiskCacheWriter object3 = Java.Lang.Object.GetObject<IDiskCacheWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2, object3);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00039138 File Offset: 0x00037338
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_Handler")]
		public unsafe virtual void Put(IKey key, IDiskCacheWriter writer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				ptr[1] = new JniArgumentValue((writer == null) ? IntPtr.Zero : ((Java.Lang.Object)writer).Handle);
				DiskLruCacheWrapper._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/cache/DiskCache$Writer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(writer);
			}
		}

		// Token: 0x04000409 RID: 1033
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskLruCacheWrapper", typeof(DiskLruCacheWrapper));

		// Token: 0x0400040A RID: 1034
		private static Delegate cb_clear;

		// Token: 0x0400040B RID: 1035
		private static Delegate cb_delete_Lcom_bumptech_glide_load_Key_;

		// Token: 0x0400040C RID: 1036
		private static Delegate cb_get_Lcom_bumptech_glide_load_Key_;

		// Token: 0x0400040D RID: 1037
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_cache_DiskCache_Writer_;
	}
}
