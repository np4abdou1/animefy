using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using AndroidX.Fragment.App;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Load.Engine.Prefill;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000039 RID: 57
	[Register("com/bumptech/glide/Glide", DoNotGenerateAcw = true)]
	public class Glide : Java.Lang.Object, IComponentCallbacks2, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00004D9C File Offset: 0x00002F9C
		internal static IntPtr class_ref
		{
			get
			{
				return Glide._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00004DC0 File Offset: 0x00002FC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Glide._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00004DC8 File Offset: 0x00002FC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Glide._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00004DEC File Offset: 0x00002FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Glide._members.ManagedPeerType;
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004DF8 File Offset: 0x00002FF8
		protected Glide(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004E02 File Offset: 0x00003002
		private static Delegate GetGetArrayPoolHandler()
		{
			if (Glide.cb_getArrayPool == null)
			{
				Glide.cb_getArrayPool = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.n_GetArrayPool));
			}
			return Glide.cb_getArrayPool;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004E26 File Offset: 0x00003026
		private static IntPtr n_GetArrayPool(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrayPool);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00004E3C File Offset: 0x0000303C
		public virtual IArrayPool ArrayPool
		{
			[Register("getArrayPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;", "GetGetArrayPoolHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IArrayPool>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("getArrayPool.()Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004E6E File Offset: 0x0000306E
		private static Delegate GetGetBitmapPoolHandler()
		{
			if (Glide.cb_getBitmapPool == null)
			{
				Glide.cb_getBitmapPool = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.n_GetBitmapPool));
			}
			return Glide.cb_getBitmapPool;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004E92 File Offset: 0x00003092
		private static IntPtr n_GetBitmapPool(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BitmapPool);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00004EA8 File Offset: 0x000030A8
		public virtual IBitmapPool BitmapPool
		{
			[Register("getBitmapPool", "()Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;", "GetGetBitmapPoolHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IBitmapPool>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("getBitmapPool.()Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004EDA File Offset: 0x000030DA
		private static Delegate GetGetContextHandler()
		{
			if (Glide.cb_getContext == null)
			{
				Glide.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.n_GetContext));
			}
			return Glide.cb_getContext;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004EFE File Offset: 0x000030FE
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00004F14 File Offset: 0x00003114
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004F46 File Offset: 0x00003146
		private static Delegate GetGetRegistryHandler()
		{
			if (Glide.cb_getRegistry == null)
			{
				Glide.cb_getRegistry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.n_GetRegistry));
			}
			return Glide.cb_getRegistry;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004F6A File Offset: 0x0000316A
		private static IntPtr n_GetRegistry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Registry);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00004F80 File Offset: 0x00003180
		public virtual Registry Registry
		{
			[Register("getRegistry", "()Lcom/bumptech/glide/Registry;", "GetGetRegistryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Registry>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("getRegistry.()Lcom/bumptech/glide/Registry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004FB2 File Offset: 0x000031B2
		private static Delegate GetGetRequestManagerRetrieverHandler()
		{
			if (Glide.cb_getRequestManagerRetriever == null)
			{
				Glide.cb_getRequestManagerRetriever = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.n_GetRequestManagerRetriever));
			}
			return Glide.cb_getRequestManagerRetriever;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004FD6 File Offset: 0x000031D6
		private static IntPtr n_GetRequestManagerRetriever(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestManagerRetriever);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00004FEC File Offset: 0x000031EC
		public virtual RequestManagerRetriever RequestManagerRetriever
		{
			[Register("getRequestManagerRetriever", "()Lcom/bumptech/glide/manager/RequestManagerRetriever;", "GetGetRequestManagerRetrieverHandler")]
			get
			{
				return Java.Lang.Object.GetObject<RequestManagerRetriever>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestManagerRetriever.()Lcom/bumptech/glide/manager/RequestManagerRetriever;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000501E File Offset: 0x0000321E
		private static Delegate GetClearDiskCacheHandler()
		{
			if (Glide.cb_clearDiskCache == null)
			{
				Glide.cb_clearDiskCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Glide.n_ClearDiskCache));
			}
			return Glide.cb_clearDiskCache;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00005042 File Offset: 0x00003242
		private static void n_ClearDiskCache(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearDiskCache();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00005051 File Offset: 0x00003251
		[Register("clearDiskCache", "()V", "GetClearDiskCacheHandler")]
		public virtual void ClearDiskCache()
		{
			Glide._members.InstanceMethods.InvokeVirtualVoidMethod("clearDiskCache.()V", this, null);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000506A File Offset: 0x0000326A
		private static Delegate GetClearMemoryHandler()
		{
			if (Glide.cb_clearMemory == null)
			{
				Glide.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Glide.n_ClearMemory));
			}
			return Glide.cb_clearMemory;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000508E File Offset: 0x0000328E
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000509D File Offset: 0x0000329D
		[Register("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual void ClearMemory()
		{
			Glide._members.InstanceMethods.InvokeVirtualVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000050B6 File Offset: 0x000032B6
		[Register("enableHardwareBitmaps", "()V", "")]
		public static void EnableHardwareBitmaps()
		{
			Glide._members.StaticMethods.InvokeVoidMethod("enableHardwareBitmaps.()V", null);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000050D0 File Offset: 0x000032D0
		[Register("get", "(Landroid/content/Context;)Lcom/bumptech/glide/Glide;", "")]
		public unsafe static Glide Get(Context context)
		{
			Glide @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Glide>(Glide._members.StaticMethods.InvokeObjectMethod("get.(Landroid/content/Context;)Lcom/bumptech/glide/Glide;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005144 File Offset: 0x00003344
		[Register("getPhotoCacheDir", "(Landroid/content/Context;)Ljava/io/File;", "")]
		public unsafe static File GetPhotoCacheDir(Context context)
		{
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<File>(Glide._members.StaticMethods.InvokeObjectMethod("getPhotoCacheDir.(Landroid/content/Context;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000051B8 File Offset: 0x000033B8
		[Register("getPhotoCacheDir", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public unsafe static File GetPhotoCacheDir(Context context, string cacheName)
		{
			IntPtr intPtr = JNIEnv.NewString(cacheName);
			File @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<File>(Glide._members.StaticMethods.InvokeObjectMethod("getPhotoCacheDir.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000524C File Offset: 0x0000344C
		[Register("init", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", "")]
		public unsafe static void Init(Context context, GlideBuilder builder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				Glide._members.StaticMethods.InvokeVoidMethod("init.(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(builder);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000052D8 File Offset: 0x000034D8
		[Obsolete("deprecated")]
		[Register("init", "(Lcom/bumptech/glide/Glide;)V", "")]
		public unsafe static void Init(Glide glide)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((glide == null) ? IntPtr.Zero : glide.Handle);
				Glide._members.StaticMethods.InvokeVoidMethod("init.(Lcom/bumptech/glide/Glide;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(glide);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000533C File Offset: 0x0000353C
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Glide.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Glide.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Glide.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Glide.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00005360 File Offset: 0x00003560
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Glide @object = Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00005384 File Offset: 0x00003584
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Glide._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000053E8 File Offset: 0x000035E8
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Glide.cb_onLowMemory == null)
			{
				Glide.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Glide.n_OnLowMemory));
			}
			return Glide.cb_onLowMemory;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000540C File Offset: 0x0000360C
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000541B File Offset: 0x0000361B
		[Register("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual void OnLowMemory()
		{
			Glide._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00005434 File Offset: 0x00003634
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (Glide.cb_onTrimMemory_I == null)
			{
				Glide.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Glide.n_OnTrimMemory_I));
			}
			return Glide.cb_onTrimMemory_I;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005458 File Offset: 0x00003658
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005478 File Offset: 0x00003678
		[Register("onTrimMemory", "(I)V", "GetOnTrimMemory_IHandler")]
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			Glide._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000054B3 File Offset: 0x000036B3
		private static Delegate GetPreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_Handler()
		{
			if (Glide.cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ == null)
			{
				Glide.cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Glide.n_PreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_));
			}
			return Glide.cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000054D8 File Offset: 0x000036D8
		private static void n_PreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmapAttributeBuilders)
		{
			Glide @object = Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PreFillType.Builder[] array = (PreFillType.Builder[])JNIEnv.GetArray(native_bitmapAttributeBuilders, JniHandleOwnership.DoNotTransfer, typeof(PreFillType.Builder));
			@object.PreFillBitmapPool(array);
			if (array != null)
			{
				JNIEnv.CopyArray<PreFillType.Builder>(array, native_bitmapAttributeBuilders);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005514 File Offset: 0x00003714
		[Register("preFillBitmapPool", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", "GetPreFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_Handler")]
		public unsafe virtual void PreFillBitmapPool(params PreFillType.Builder[] bitmapAttributeBuilders)
		{
			IntPtr intPtr = JNIEnv.NewArray<PreFillType.Builder>(bitmapAttributeBuilders);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Glide._members.InstanceMethods.InvokeVirtualVoidMethod("preFillBitmapPool.([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", this, ptr);
			}
			finally
			{
				if (bitmapAttributeBuilders != null)
				{
					JNIEnv.CopyArray<PreFillType.Builder>(intPtr, bitmapAttributeBuilders);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(bitmapAttributeBuilders);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005580 File Offset: 0x00003780
		private static Delegate GetSetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_Handler()
		{
			if (Glide.cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ == null)
			{
				Glide.cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Glide.n_SetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_));
			}
			return Glide.cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000055A4 File Offset: 0x000037A4
		private static IntPtr n_SetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_(IntPtr jnienv, IntPtr native__this, IntPtr native_memoryCategory)
		{
			Glide @object = Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MemoryCategory object2 = Java.Lang.Object.GetObject<MemoryCategory>(native_memoryCategory, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetMemoryCategory(object2));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000055CC File Offset: 0x000037CC
		[Register("setMemoryCategory", "(Lcom/bumptech/glide/MemoryCategory;)Lcom/bumptech/glide/MemoryCategory;", "GetSetMemoryCategory_Lcom_bumptech_glide_MemoryCategory_Handler")]
		public unsafe virtual MemoryCategory SetMemoryCategory(MemoryCategory memoryCategory)
		{
			MemoryCategory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((memoryCategory == null) ? IntPtr.Zero : memoryCategory.Handle);
				@object = Java.Lang.Object.GetObject<MemoryCategory>(Glide._members.InstanceMethods.InvokeVirtualObjectMethod("setMemoryCategory.(Lcom/bumptech/glide/MemoryCategory;)Lcom/bumptech/glide/MemoryCategory;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(memoryCategory);
			}
			return @object;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00005640 File Offset: 0x00003840
		[Register("tearDown", "()V", "")]
		public static void TearDown()
		{
			Glide._members.StaticMethods.InvokeVoidMethod("tearDown.()V", null);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005658 File Offset: 0x00003858
		private static Delegate GetTrimMemory_IHandler()
		{
			if (Glide.cb_trimMemory_I == null)
			{
				Glide.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Glide.n_TrimMemory_I));
			}
			return Glide.cb_trimMemory_I;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000567C File Offset: 0x0000387C
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int level)
		{
			Java.Lang.Object.GetObject<Glide>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(level);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000568C File Offset: 0x0000388C
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public unsafe virtual void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			Glide._members.InstanceMethods.InvokeVirtualVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000056C8 File Offset: 0x000038C8
		[Obsolete("deprecated")]
		[Register("with", "(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(Activity activity)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroid/app/Activity;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000573C File Offset: 0x0000393C
		[Obsolete("deprecated")]
		[Register("with", "(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(Android.App.Fragment fragment)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroid/app/Fragment;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000057B0 File Offset: 0x000039B0
		[Register("with", "(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(Context context)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroid/content/Context;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00005824 File Offset: 0x00003A24
		[Register("with", "(Landroid/view/View;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(View view)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroid/view/View;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00005898 File Offset: 0x00003A98
		[Register("with", "(Landroidx/fragment/app/Fragment;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(AndroidX.Fragment.App.Fragment fragment)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroidx/fragment/app/Fragment;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
			return @object;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000590C File Offset: 0x00003B0C
		[Register("with", "(Landroidx/fragment/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", "")]
		public unsafe static RequestManager With(FragmentActivity activity)
		{
			RequestManager @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<RequestManager>(Glide._members.StaticMethods.InvokeObjectMethod("with.(Landroidx/fragment/app/FragmentActivity;)Lcom/bumptech/glide/RequestManager;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Glide", typeof(Glide));

		// Token: 0x04000041 RID: 65
		private static Delegate cb_getArrayPool;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_getBitmapPool;

		// Token: 0x04000043 RID: 67
		private static Delegate cb_getContext;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_getRegistry;

		// Token: 0x04000045 RID: 69
		private static Delegate cb_getRequestManagerRetriever;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_clearDiskCache;

		// Token: 0x04000047 RID: 71
		private static Delegate cb_clearMemory;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_onLowMemory;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x0400004B RID: 75
		private static Delegate cb_preFillBitmapPool_arrayLcom_bumptech_glide_load_engine_prefill_PreFillType_Builder_;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_setMemoryCategory_Lcom_bumptech_glide_MemoryCategory_;

		// Token: 0x0400004D RID: 77
		private static Delegate cb_trimMemory_I;

		// Token: 0x020001A1 RID: 417
		[Register("com/bumptech/glide/Glide$RequestOptionsFactory", "", "Bumptech.Glide.Glide/IRequestOptionsFactoryInvoker")]
		public interface IRequestOptionsFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001506 RID: 5382
			[Register("build", "()Lcom/bumptech/glide/request/RequestOptions;", "GetBuildHandler:Bumptech.Glide.Glide/IRequestOptionsFactoryInvoker, Xamarin.Android.Glide")]
			RequestOptions Build();
		}

		// Token: 0x020001A2 RID: 418
		[Register("com/bumptech/glide/Glide$RequestOptionsFactory", DoNotGenerateAcw = true)]
		internal class IRequestOptionsFactoryInvoker : Java.Lang.Object, Glide.IRequestOptionsFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x06001507 RID: 5383 RVA: 0x00042A04 File Offset: 0x00040C04
			private static IntPtr java_class_ref
			{
				get
				{
					return Glide.IRequestOptionsFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x06001508 RID: 5384 RVA: 0x00042A28 File Offset: 0x00040C28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Glide.IRequestOptionsFactoryInvoker._members;
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x06001509 RID: 5385 RVA: 0x00042A2F File Offset: 0x00040C2F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x0600150A RID: 5386 RVA: 0x00042A37 File Offset: 0x00040C37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Glide.IRequestOptionsFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600150B RID: 5387 RVA: 0x00042A43 File Offset: 0x00040C43
			public static Glide.IRequestOptionsFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Glide.IRequestOptionsFactory>(handle, transfer);
			}

			// Token: 0x0600150C RID: 5388 RVA: 0x00042A4C File Offset: 0x00040C4C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Glide.IRequestOptionsFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.Glide.RequestOptionsFactory'.");
				}
				return handle;
			}

			// Token: 0x0600150D RID: 5389 RVA: 0x00042A77 File Offset: 0x00040C77
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600150E RID: 5390 RVA: 0x00042AA8 File Offset: 0x00040CA8
			public IRequestOptionsFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Glide.IRequestOptionsFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600150F RID: 5391 RVA: 0x00042AE0 File Offset: 0x00040CE0
			private static Delegate GetBuildHandler()
			{
				if (Glide.IRequestOptionsFactoryInvoker.cb_build == null)
				{
					Glide.IRequestOptionsFactoryInvoker.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Glide.IRequestOptionsFactoryInvoker.n_Build));
				}
				return Glide.IRequestOptionsFactoryInvoker.cb_build;
			}

			// Token: 0x06001510 RID: 5392 RVA: 0x00042B04 File Offset: 0x00040D04
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Glide.IRequestOptionsFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06001511 RID: 5393 RVA: 0x00042B18 File Offset: 0x00040D18
			public RequestOptions Build()
			{
				if (this.id_build == IntPtr.Zero)
				{
					this.id_build = JNIEnv.GetMethodID(this.class_ref, "build", "()Lcom/bumptech/glide/request/RequestOptions;");
				}
				return Java.Lang.Object.GetObject<RequestOptions>(JNIEnv.CallObjectMethod(base.Handle, this.id_build), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040004FE RID: 1278
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/Glide$RequestOptionsFactory", typeof(Glide.IRequestOptionsFactoryInvoker));

			// Token: 0x040004FF RID: 1279
			private IntPtr class_ref;

			// Token: 0x04000500 RID: 1280
			private static Delegate cb_build;

			// Token: 0x04000501 RID: 1281
			private IntPtr id_build;
		}
	}
}
