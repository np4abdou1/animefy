using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000170 RID: 368
	[Register("com/bumptech/glide/load/engine/cache/MemoryCacheAdapter", DoNotGenerateAcw = true)]
	public class MemoryCacheAdapter : Java.Lang.Object, IMemoryCache, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0003B018 File Offset: 0x00039218
		internal static IntPtr class_ref
		{
			get
			{
				return MemoryCacheAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0003B03C File Offset: 0x0003923C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MemoryCacheAdapter._members;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x0003B044 File Offset: 0x00039244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MemoryCacheAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0003B068 File Offset: 0x00039268
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MemoryCacheAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0003B074 File Offset: 0x00039274
		protected MemoryCacheAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0003B080 File Offset: 0x00039280
		[Register(".ctor", "()V", "")]
		public MemoryCacheAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MemoryCacheAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MemoryCacheAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0003B0EE File Offset: 0x000392EE
		private static Delegate GetGetCurrentSizeHandler()
		{
			if (MemoryCacheAdapter.cb_getCurrentSize == null)
			{
				MemoryCacheAdapter.cb_getCurrentSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MemoryCacheAdapter.n_GetCurrentSize));
			}
			return MemoryCacheAdapter.cb_getCurrentSize;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0003B112 File Offset: 0x00039312
		private static long n_GetCurrentSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSize;
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0003B121 File Offset: 0x00039321
		public virtual long CurrentSize
		{
			[Register("getCurrentSize", "()J", "GetGetCurrentSizeHandler")]
			get
			{
				return MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualInt64Method("getCurrentSize.()J", this, null);
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0003B13A File Offset: 0x0003933A
		private static Delegate GetGetMaxSizeHandler()
		{
			if (MemoryCacheAdapter.cb_getMaxSize == null)
			{
				MemoryCacheAdapter.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MemoryCacheAdapter.n_GetMaxSize));
			}
			return MemoryCacheAdapter.cb_getMaxSize;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0003B15E File Offset: 0x0003935E
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0003B16D File Offset: 0x0003936D
		public virtual long MaxSize
		{
			[Register("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get
			{
				return MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualInt64Method("getMaxSize.()J", this, null);
			}
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0003B186 File Offset: 0x00039386
		private static Delegate GetClearMemoryHandler()
		{
			if (MemoryCacheAdapter.cb_clearMemory == null)
			{
				MemoryCacheAdapter.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MemoryCacheAdapter.n_ClearMemory));
			}
			return MemoryCacheAdapter.cb_clearMemory;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0003B1AA File Offset: 0x000393AA
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0003B1B9 File Offset: 0x000393B9
		[Register("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual void ClearMemory()
		{
			MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0003B1D2 File Offset: 0x000393D2
		private static Delegate GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (MemoryCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				MemoryCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MemoryCacheAdapter.n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return MemoryCacheAdapter.cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0003B1F8 File Offset: 0x000393F8
		private static IntPtr n_Put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_resource)
		{
			MemoryCacheAdapter @object = Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			IResource object3 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Put(object2, object3));
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0003B22C File Offset: 0x0003942C
		[Register("put", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", "GetPut_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public unsafe virtual IResource Put(IKey key, IResource resource)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				ptr[1] = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("put.(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/engine/Resource;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0003B2D4 File Offset: 0x000394D4
		private static Delegate GetRemove_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (MemoryCacheAdapter.cb_remove_Lcom_bumptech_glide_load_Key_ == null)
			{
				MemoryCacheAdapter.cb_remove_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MemoryCacheAdapter.n_Remove_Lcom_bumptech_glide_load_Key_));
			}
			return MemoryCacheAdapter.cb_remove_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0003B2F8 File Offset: 0x000394F8
		private static IntPtr n_Remove_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			MemoryCacheAdapter @object = Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Remove(object2));
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0003B320 File Offset: 0x00039520
		[Register("remove", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", "GetRemove_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual IResource Remove(IKey key)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : ((Java.Lang.Object)key).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("remove.(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0003B398 File Offset: 0x00039598
		private static Delegate GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler()
		{
			if (MemoryCacheAdapter.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ == null)
			{
				MemoryCacheAdapter.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MemoryCacheAdapter.n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_));
			}
			return MemoryCacheAdapter.cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0003B3BC File Offset: 0x000395BC
		private static void n_SetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			MemoryCacheAdapter @object = Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMemoryCacheResourceRemovedListener object2 = Java.Lang.Object.GetObject<IMemoryCacheResourceRemovedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetResourceRemovedListener(object2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0003B3E0 File Offset: 0x000395E0
		[Register("setResourceRemovedListener", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", "GetSetResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_Handler")]
		public unsafe virtual void SetResourceRemovedListener(IMemoryCacheResourceRemovedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setResourceRemovedListener.(Lcom/bumptech/glide/load/engine/cache/MemoryCache$ResourceRemovedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0003B448 File Offset: 0x00039648
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (MemoryCacheAdapter.cb_setSizeMultiplier_F == null)
			{
				MemoryCacheAdapter.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(MemoryCacheAdapter.n_SetSizeMultiplier_F));
			}
			return MemoryCacheAdapter.cb_setSizeMultiplier_F;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0003B46C File Offset: 0x0003966C
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float multiplier)
		{
			Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(multiplier);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0003B47C File Offset: 0x0003967C
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler")]
		public unsafe virtual void SetSizeMultiplier(float multiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(multiplier);
			MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setSizeMultiplier.(F)V", this, ptr);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0003B4B7 File Offset: 0x000396B7
		private static Delegate GetTrimMemory_IHandler()
		{
			if (MemoryCacheAdapter.cb_trimMemory_I == null)
			{
				MemoryCacheAdapter.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MemoryCacheAdapter.n_TrimMemory_I));
			}
			return MemoryCacheAdapter.cb_trimMemory_I;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0003B4DB File Offset: 0x000396DB
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int level)
		{
			Java.Lang.Object.GetObject<MemoryCacheAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(level);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0003B4EC File Offset: 0x000396EC
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public unsafe virtual void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			MemoryCacheAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06001267 RID: 4711 RVA: 0x0003B528 File Offset: 0x00039728
		// (remove) Token: 0x06001268 RID: 4712 RVA: 0x0003B574 File Offset: 0x00039774
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

		// Token: 0x06001269 RID: 4713 RVA: 0x0003B5C4 File Offset: 0x000397C4
		private IMemoryCacheResourceRemovedListenerImplementor __CreateIMemoryCacheResourceRemovedListenerImplementor()
		{
			return new IMemoryCacheResourceRemovedListenerImplementor(this);
		}

		// Token: 0x04000446 RID: 1094
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/MemoryCacheAdapter", typeof(MemoryCacheAdapter));

		// Token: 0x04000447 RID: 1095
		private static Delegate cb_getCurrentSize;

		// Token: 0x04000448 RID: 1096
		private static Delegate cb_getMaxSize;

		// Token: 0x04000449 RID: 1097
		private static Delegate cb_clearMemory;

		// Token: 0x0400044A RID: 1098
		private static Delegate cb_put_Lcom_bumptech_glide_load_Key_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x0400044B RID: 1099
		private static Delegate cb_remove_Lcom_bumptech_glide_load_Key_;

		// Token: 0x0400044C RID: 1100
		private static Delegate cb_setResourceRemovedListener_Lcom_bumptech_glide_load_engine_cache_MemoryCache_ResourceRemovedListener_;

		// Token: 0x0400044D RID: 1101
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x0400044E RID: 1102
		private static Delegate cb_trimMemory_I;

		// Token: 0x0400044F RID: 1103
		private WeakReference weak_implementor_SetResourceRemovedListener;
	}
}
