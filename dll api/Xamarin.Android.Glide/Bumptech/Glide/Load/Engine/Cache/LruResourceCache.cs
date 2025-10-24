using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016F RID: 367
	[Register("com/bumptech/glide/load/engine/cache/LruResourceCache", DoNotGenerateAcw = true)]
	public class LruResourceCache : LruCache, IMemoryCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0003A9EC File Offset: 0x00038BEC
		internal new static IntPtr class_ref
		{
			get
			{
				return LruResourceCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0003AA10 File Offset: 0x00038C10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LruResourceCache._members;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0003AA18 File Offset: 0x00038C18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LruResourceCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x0003AA3C File Offset: 0x00038C3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LruResourceCache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0003AA48 File Offset: 0x00038C48
		protected LruResourceCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0003AA54 File Offset: 0x00038C54
		[Register(".ctor", "(J)V", "")]
		public unsafe LruResourceCache(long size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			base.SetHandle(LruResourceCache._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LruResourceCache._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		private static Delegate GetGetSize_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (LruResourceCache.cb_getSize_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				LruResourceCache.cb_getSize_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(LruResourceCache.n_GetSize_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return LruResourceCache.cb_getSize_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0003AAFC File Offset: 0x00038CFC
		private static int n_GetSize_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			LruResourceCache @object = Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.GetSize(object2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0003AB20 File Offset: 0x00038D20
		[Register("getSize", "(Lcom/bumptech/glide/load/engine/Resource;)I", "GetGetSize_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		protected unsafe virtual int GetSize(IResource item)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				result = LruResourceCache._members.InstanceMethods.InvokeVirtualInt32Method("getSize.(Lcom/bumptech/glide/load/engine/Resource;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0003AB8C File Offset: 0x00038D8C
		private static Delegate GetOnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (LruResourceCache.cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				LruResourceCache.cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(LruResourceCache.n_OnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return LruResourceCache.cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0003ABB0 File Offset: 0x00038DB0
		private static void n_OnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_item)
		{
			LruResourceCache @object = Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_item, JniHandleOwnership.DoNotTransfer);
			@object.OnItemEvicted(object2, object3);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0003ABDC File Offset: 0x00038DDC
		[Register("onItemEvicted", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		protected unsafe virtual void OnItemEvicted(IKey key, IResource item)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				ptr[1] = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				LruResourceCache._members.InstanceMethods.InvokeVirtualVoidMethod("onItemEvicted.(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(item);
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0003AC74 File Offset: 0x00038E74
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (LruResourceCache.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				LruResourceCache.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(LruResourceCache.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return LruResourceCache.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0003AC98 File Offset: 0x00038E98
		private static IntPtr n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			LruResourceCache @object = Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0003ACCC File Offset: 0x00038ECC
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public unsafe virtual IResource Put(IKey p0, IResource p1)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(LruResourceCache._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0003AD74 File Offset: 0x00038F74
		private static Delegate GetRemove_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (LruResourceCache.cb_remove_Lcom_bumptech_glide_load_Key_ == null)
			{
				LruResourceCache.cb_remove_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(LruResourceCache.n_Remove_Lcom_bumptech_glide_load_Key_));
			}
			return LruResourceCache.cb_remove_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0003AD98 File Offset: 0x00038F98
		private static IntPtr n_Remove_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			LruResourceCache @object = Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0003ADC0 File Offset: 0x00038FC0
		[Register("remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", "GetRemove_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual IResource Remove(IKey p0)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(LruResourceCache._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0003AE38 File Offset: 0x00039038
		private static Delegate GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler()
		{
			if (LruResourceCache.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == null)
			{
				LruResourceCache.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LruResourceCache.n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_));
			}
			return LruResourceCache.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0003AE5C File Offset: 0x0003905C
		private static void n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			LruResourceCache @object = Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMemoryCacheResourceRemovedListener object2 = Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetResourceRemovedListener(object2);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0003AE80 File Offset: 0x00039080
		[Register("setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", "GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler")]
		public unsafe virtual void SetResourceRemovedListener(IMemoryCacheResourceRemovedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				LruResourceCache._members.InstanceMethods.InvokeVirtualVoidMethod("setResourceRemovedListener.(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0003AEE8 File Offset: 0x000390E8
		private static Delegate GetTrimMemory_IHandler()
		{
			if (LruResourceCache.cb_trimMemory_I == null)
			{
				LruResourceCache.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LruResourceCache.n_TrimMemory_I));
			}
			return LruResourceCache.cb_trimMemory_I;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0003AF0C File Offset: 0x0003910C
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int level)
		{
			Java.Lang.Object.GetObject<LruResourceCache>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(level);
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0003AF1C File Offset: 0x0003911C
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public unsafe virtual void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			LruResourceCache._members.InstanceMethods.InvokeVirtualVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06001245 RID: 4677 RVA: 0x0003AF58 File Offset: 0x00039158
		// (remove) Token: 0x06001246 RID: 4678 RVA: 0x0003AFA4 File Offset: 0x000391A4
		public event EventHandler<MemoryCacheResourceRemovedEventArgs> ResourceRemoved
		{
			add
			{
				EventHelper.AddEventHandler<IMemoryCacheResourceRemovedListener, IMemoryCacheResourceRemovedListenerImplementor>(ref this.weak_implementor_SetResourceRemovedListener, new Func<IMemoryCacheResourceRemovedListenerImplementor>(this.__CreateIMemoryCacheResourceRemovedListenerImplementor), new Action<IMemoryCacheResourceRemovedListener>(this.SetResourceRemovedListener), delegate(IMemoryCacheResourceRemovedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MemoryCacheResourceRemovedEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IMemoryCacheResourceRemovedListener, IMemoryCacheResourceRemovedListenerImplementor>(ref this.weak_implementor_SetResourceRemovedListener, new Func<IMemoryCacheResourceRemovedListenerImplementor, bool>(IMemoryCacheResourceRemovedListenerImplementor.__IsEmpty), delegate(IMemoryCacheResourceRemovedListener __v)
				{
					this.SetResourceRemovedListener(null);
				}, delegate(IMemoryCacheResourceRemovedListenerImplementor __h)
				{
					__h.Handler = (EventHandler<MemoryCacheResourceRemovedEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0003AFF4 File Offset: 0x000391F4
		private IMemoryCacheResourceRemovedListenerImplementor __CreateIMemoryCacheResourceRemovedListenerImplementor()
		{
			return new IMemoryCacheResourceRemovedListenerImplementor(this);
		}

		// Token: 0x0400043E RID: 1086
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/LruResourceCache", typeof(LruResourceCache));

		// Token: 0x0400043F RID: 1087
		private static Delegate cb_getSize_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000440 RID: 1088
		private static Delegate cb_onItemEvicted_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000441 RID: 1089
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x04000442 RID: 1090
		private static Delegate cb_remove_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000443 RID: 1091
		private static Delegate cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;

		// Token: 0x04000444 RID: 1092
		private static Delegate cb_trimMemory_I;

		// Token: 0x04000445 RID: 1093
		private WeakReference weak_implementor_SetResourceRemovedListener;
	}
}
