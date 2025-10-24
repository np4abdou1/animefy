using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.Cache;
using Bumptech.Glide.Load.Engine.Executor;
using Bumptech.Glide.Request;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000152 RID: 338
	[Register("com/bumptech/glide/load/engine/Engine", DoNotGenerateAcw = true)]
	public class Engine : Java.Lang.Object, IMemoryCacheResourceRemovedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x000370A8 File Offset: 0x000352A8
		internal static IntPtr class_ref
		{
			get
			{
				return Engine._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000370CC File Offset: 0x000352CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Engine._members;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000370D4 File Offset: 0x000352D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Engine._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000370F8 File Offset: 0x000352F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Engine._members.ManagedPeerType;
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00037104 File Offset: 0x00035304
		protected Engine(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00037110 File Offset: 0x00035310
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Z)V", "")]
		public unsafe Engine(IMemoryCache memoryCache, IDiskCacheFactory diskCacheFactory, GlideExecutor diskCacheExecutor, GlideExecutor sourceExecutor, GlideExecutor sourceUnlimitedExecutor, GlideExecutor animationExecutor, bool isActiveResourceRetentionAllowed) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((memoryCache == null) ? IntPtr.Zero : ((Java.Lang.Object)memoryCache).Handle);
				ptr[1] = new JniArgumentValue((diskCacheFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)diskCacheFactory).Handle);
				ptr[2] = new JniArgumentValue((diskCacheExecutor == null) ? IntPtr.Zero : diskCacheExecutor.Handle);
				ptr[3] = new JniArgumentValue((sourceExecutor == null) ? IntPtr.Zero : sourceExecutor.Handle);
				ptr[4] = new JniArgumentValue((sourceUnlimitedExecutor == null) ? IntPtr.Zero : sourceUnlimitedExecutor.Handle);
				ptr[5] = new JniArgumentValue((animationExecutor == null) ? IntPtr.Zero : animationExecutor.Handle);
				ptr[6] = new JniArgumentValue(isActiveResourceRetentionAllowed);
				base.SetHandle(Engine._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Engine._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Lcom/bumptech/glide/load/engine/executor/GlideExecutor;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(memoryCache);
				GC.KeepAlive(diskCacheFactory);
				GC.KeepAlive(diskCacheExecutor);
				GC.KeepAlive(sourceExecutor);
				GC.KeepAlive(sourceUnlimitedExecutor);
				GC.KeepAlive(animationExecutor);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x000372C8 File Offset: 0x000354C8
		private static Delegate GetClearDiskCacheHandler()
		{
			if (Engine.cb_clearDiskCache == null)
			{
				Engine.cb_clearDiskCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Engine.n_ClearDiskCache));
			}
			return Engine.cb_clearDiskCache;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x000372EC File Offset: 0x000354EC
		private static void n_ClearDiskCache(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Engine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearDiskCache();
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x000372FB File Offset: 0x000354FB
		[Register("clearDiskCache", "()V", "GetClearDiskCacheHandler")]
		public virtual void ClearDiskCache()
		{
			Engine._members.InstanceMethods.InvokeVirtualVoidMethod("clearDiskCache.()V", this, null);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00037314 File Offset: 0x00035514
		private static Delegate GetLoad_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_Handler()
		{
			if (Engine.cb_load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_ == null)
			{
				Engine.cb_load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIILLLLLZZLZZZZLL_L(Engine.n_Load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_));
			}
			return Engine.cb_load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00037338 File Offset: 0x00035538
		private static IntPtr n_Load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_(IntPtr jnienv, IntPtr native__this, IntPtr native_glideContext, IntPtr native_model, IntPtr native_signature, int width, int height, IntPtr native_resourceClass, IntPtr native_transcodeClass, IntPtr native_priority, IntPtr native_diskCacheStrategy, IntPtr native_transformations, bool isTransformationRequired, bool isScaleOnlyOrNoTransform, IntPtr native_options, bool isMemoryCacheable, bool useUnlimitedSourceExecutorPool, bool useAnimationPool, bool onlyRetrieveFromCache, IntPtr native_cb, IntPtr native_callbackExecutor)
		{
			Engine @object = Java.Lang.Object.GetObject<Engine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GlideContext object2 = Java.Lang.Object.GetObject<GlideContext>(native_glideContext, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_model, JniHandleOwnership.DoNotTransfer);
			IKey object4 = Java.Lang.Object.GetObject<IKey>(native_signature, JniHandleOwnership.DoNotTransfer);
			Class object5 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			Class object6 = Java.Lang.Object.GetObject<Class>(native_transcodeClass, JniHandleOwnership.DoNotTransfer);
			Priority object7 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			DiskCacheStrategy object8 = Java.Lang.Object.GetObject<DiskCacheStrategy>(native_diskCacheStrategy, JniHandleOwnership.DoNotTransfer);
			IDictionary<Class, ITransformation> transformations = JavaDictionary<Class, ITransformation>.FromJniHandle(native_transformations, JniHandleOwnership.DoNotTransfer);
			Options object9 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			IResourceCallback object10 = Java.Lang.Object.GetObject<IResourceCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			IExecutor object11 = Java.Lang.Object.GetObject<IExecutor>(native_callbackExecutor, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Load(object2, object3, object4, width, height, object5, object6, object7, object8, transformations, isTransformationRequired, isScaleOnlyOrNoTransform, object9, isMemoryCacheable, useUnlimitedSourceExecutorPool, useAnimationPool, onlyRetrieveFromCache, object10, object11));
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000373E4 File Offset: 0x000355E4
		[Register("load", "(Lcom/bumptech/glide/GlideContext;Ljava/lang/Object;Lcom/bumptech/glide/load/Key;IILjava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/engine/DiskCacheStrategy;Ljava/util/Map;ZZLcom/bumptech/glide/load/Options;ZZZZLcom/bumptech/glide/request/ResourceCallback;Ljava/util/concurrent/Executor;)Lcom/bumptech/glide/load/engine/Engine$LoadStatus;", "GetLoad_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_Handler")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe virtual Engine.LoadStatus Load(GlideContext glideContext, Java.Lang.Object model, IKey signature, int width, int height, Class resourceClass, Class transcodeClass, Priority priority, DiskCacheStrategy diskCacheStrategy, IDictionary<Class, ITransformation> transformations, bool isTransformationRequired, bool isScaleOnlyOrNoTransform, Options options, bool isMemoryCacheable, bool useUnlimitedSourceExecutorPool, bool useAnimationPool, bool onlyRetrieveFromCache, IResourceCallback cb, IExecutor callbackExecutor)
		{
			IntPtr intPtr = JavaDictionary<Class, ITransformation>.ToLocalJniHandle(transformations);
			Engine.LoadStatus @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glideContext == null) ? IntPtr.Zero : glideContext.Handle);
				ptr[1] = new JniArgumentValue((model == null) ? IntPtr.Zero : model.Handle);
				ptr[2] = new JniArgumentValue((signature == null) ? IntPtr.Zero : ((Java.Lang.Object)signature).Handle);
				ptr[3] = new JniArgumentValue(width);
				ptr[4] = new JniArgumentValue(height);
				ptr[5] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[6] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[7] = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[8] = new JniArgumentValue((diskCacheStrategy == null) ? IntPtr.Zero : diskCacheStrategy.Handle);
				ptr[9] = new JniArgumentValue(intPtr);
				ptr[10] = new JniArgumentValue(isTransformationRequired);
				ptr[11] = new JniArgumentValue(isScaleOnlyOrNoTransform);
				ptr[12] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[13] = new JniArgumentValue(isMemoryCacheable);
				ptr[14] = new JniArgumentValue(useUnlimitedSourceExecutorPool);
				ptr[15] = new JniArgumentValue(useAnimationPool);
				ptr[16] = new JniArgumentValue(onlyRetrieveFromCache);
				ptr[17] = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				ptr[18] = new JniArgumentValue((callbackExecutor == null) ? IntPtr.Zero : ((Java.Lang.Object)callbackExecutor).Handle);
				@object = Java.Lang.Object.GetObject<Engine.LoadStatus>(Engine._members.InstanceMethods.InvokeVirtualObjectMethod("load.(Lcom/bumptech/glide/GlideContext;Ljava/lang/Object;Lcom/bumptech/glide/load/Key;IILjava/lang/Class;Ljava/lang/Class;Lcom/bumptech/glide/Priority;Lcom/bumptech/glide/load/engine/DiskCacheStrategy;Ljava/util/Map;ZZLcom/bumptech/glide/load/Options;ZZZZLcom/bumptech/glide/request/ResourceCallback;Ljava/util/concurrent/Executor;)Lcom/bumptech/glide/load/engine/Engine$LoadStatus;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(glideContext);
				GC.KeepAlive(model);
				GC.KeepAlive(signature);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(priority);
				GC.KeepAlive(diskCacheStrategy);
				GC.KeepAlive(transformations);
				GC.KeepAlive(options);
				GC.KeepAlive(cb);
				GC.KeepAlive(callbackExecutor);
			}
			return @object;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x000376F8 File Offset: 0x000358F8
		private static Delegate GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (Engine.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				Engine.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Engine.n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return Engine.cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0003771C File Offset: 0x0003591C
		private static void n_OnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			Engine @object = Java.Lang.Object.GetObject<Engine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			@object.OnResourceRemoved(object2);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00037740 File Offset: 0x00035940
		[Register("onResourceRemoved", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetOnResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public unsafe virtual void OnResourceRemoved(IResource resource)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				Engine._members.InstanceMethods.InvokeVirtualVoidMethod("onResourceRemoved.(Lcom/bumptech/glide/load/engine/Resource;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000377A8 File Offset: 0x000359A8
		private static Delegate GetRelease_Lcom_bumptech_glide_load_engine_Resource_Handler()
		{
			if (Engine.cb_release_Lcom_bumptech_glide_load_engine_Resource_ == null)
			{
				Engine.cb_release_Lcom_bumptech_glide_load_engine_Resource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Engine.n_Release_Lcom_bumptech_glide_load_engine_Resource_));
			}
			return Engine.cb_release_Lcom_bumptech_glide_load_engine_Resource_;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000377CC File Offset: 0x000359CC
		private static void n_Release_Lcom_bumptech_glide_load_engine_Resource_(IntPtr jnienv, IntPtr native__this, IntPtr native_resource)
		{
			Engine @object = Java.Lang.Object.GetObject<Engine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResource object2 = Java.Lang.Object.GetObject<IResource>(native_resource, JniHandleOwnership.DoNotTransfer);
			@object.Release(object2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000377F0 File Offset: 0x000359F0
		[Register("release", "(Lcom/bumptech/glide/load/engine/Resource;)V", "GetRelease_Lcom_bumptech_glide_load_engine_Resource_Handler")]
		public unsafe virtual void Release(IResource resource)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				Engine._members.InstanceMethods.InvokeVirtualVoidMethod("release.(Lcom/bumptech/glide/load/engine/Resource;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resource);
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00037858 File Offset: 0x00035A58
		private static Delegate GetShutdownHandler()
		{
			if (Engine.cb_shutdown == null)
			{
				Engine.cb_shutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Engine.n_Shutdown));
			}
			return Engine.cb_shutdown;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0003787C File Offset: 0x00035A7C
		private static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Engine>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Shutdown();
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0003788B File Offset: 0x00035A8B
		[Register("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown()
		{
			Engine._members.InstanceMethods.InvokeVirtualVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x040003E9 RID: 1001
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/Engine", typeof(Engine));

		// Token: 0x040003EA RID: 1002
		private static Delegate cb_clearDiskCache;

		// Token: 0x040003EB RID: 1003
		private static Delegate cb_load_Lcom_bumptech_glide_GlideContext_Ljava_lang_Object_Lcom_bumptech_glide_load_Key_IILjava_lang_Class_Ljava_lang_Class_Lcom_bumptech_glide_Priority_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Ljava_util_Map_ZZLcom_bumptech_glide_load_Options_ZZZZLcom_bumptech_glide_request_ResourceCallback_Ljava_util_concurrent_Executor_;

		// Token: 0x040003EC RID: 1004
		private static Delegate cb_onResourceRemoved_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x040003ED RID: 1005
		private static Delegate cb_release_Lcom_bumptech_glide_load_engine_Resource_;

		// Token: 0x040003EE RID: 1006
		private static Delegate cb_shutdown;

		// Token: 0x020001F5 RID: 501
		[Register("com/bumptech/glide/load/engine/Engine$LoadStatus", DoNotGenerateAcw = true)]
		public class LoadStatus : Java.Lang.Object
		{
			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x060017CC RID: 6092 RVA: 0x00049A14 File Offset: 0x00047C14
			internal static IntPtr class_ref
			{
				get
				{
					return Engine.LoadStatus._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x060017CD RID: 6093 RVA: 0x00049A38 File Offset: 0x00047C38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Engine.LoadStatus._members;
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060017CE RID: 6094 RVA: 0x00049A40 File Offset: 0x00047C40
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Engine.LoadStatus._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060017CF RID: 6095 RVA: 0x00049A64 File Offset: 0x00047C64
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Engine.LoadStatus._members.ManagedPeerType;
				}
			}

			// Token: 0x060017D0 RID: 6096 RVA: 0x00049A70 File Offset: 0x00047C70
			protected LoadStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060017D1 RID: 6097 RVA: 0x00049A7A File Offset: 0x00047C7A
			private static Delegate GetCancelHandler()
			{
				if (Engine.LoadStatus.cb_cancel == null)
				{
					Engine.LoadStatus.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Engine.LoadStatus.n_Cancel));
				}
				return Engine.LoadStatus.cb_cancel;
			}

			// Token: 0x060017D2 RID: 6098 RVA: 0x00049A9E File Offset: 0x00047C9E
			private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Engine.LoadStatus>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
			}

			// Token: 0x060017D3 RID: 6099 RVA: 0x00049AAD File Offset: 0x00047CAD
			[Register("cancel", "()V", "GetCancelHandler")]
			public virtual void Cancel()
			{
				Engine.LoadStatus._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
			}

			// Token: 0x040005AC RID: 1452
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/Engine$LoadStatus", typeof(Engine.LoadStatus));

			// Token: 0x040005AD RID: 1453
			private static Delegate cb_cancel;
		}
	}
}
