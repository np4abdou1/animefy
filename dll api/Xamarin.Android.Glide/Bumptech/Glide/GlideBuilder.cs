using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Load.Engine.Cache;
using Bumptech.Glide.Load.Engine.Executor;
using Bumptech.Glide.Manager;
using Bumptech.Glide.Request;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x0200003A RID: 58
	[Register("com/bumptech/glide/GlideBuilder", DoNotGenerateAcw = true)]
	public sealed class GlideBuilder : Java.Lang.Object
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000599C File Offset: 0x00003B9C
		internal static IntPtr class_ref
		{
			get
			{
				return GlideBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000059C0 File Offset: 0x00003BC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideBuilder._members;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000059C8 File Offset: 0x00003BC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000059EC File Offset: 0x00003BEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000059F8 File Offset: 0x00003BF8
		internal GlideBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00005A04 File Offset: 0x00003C04
		[Register(".ctor", "()V", "")]
		public GlideBuilder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GlideBuilder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GlideBuilder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00005A74 File Offset: 0x00003C74
		[Register("addGlobalRequestListener", "(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder AddGlobalRequestListener(IRequestListener listener)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addGlobalRequestListener.(Lcom/bumptech/glide/request/RequestListener;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00005AEC File Offset: 0x00003CEC
		[Register("setAnimationExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetAnimationExecutor(GlideExecutor service)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((service == null) ? IntPtr.Zero : service.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setAnimationExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(service);
			}
			return @object;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005B60 File Offset: 0x00003D60
		[Register("setArrayPool", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetArrayPool(IArrayPool arrayPool)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setArrayPool.(Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(arrayPool);
			}
			return @object;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00005BD8 File Offset: 0x00003DD8
		[Register("setBitmapPool", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetBitmapPool(IBitmapPool bitmapPool)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setBitmapPool.(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmapPool);
			}
			return @object;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00005C50 File Offset: 0x00003E50
		[Register("setConnectivityMonitorFactory", "(Lcom/bumptech/glide/manager/ConnectivityMonitorFactory;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetConnectivityMonitorFactory(IConnectivityMonitorFactory factory)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setConnectivityMonitorFactory.(Lcom/bumptech/glide/manager/ConnectivityMonitorFactory;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00005CC8 File Offset: 0x00003EC8
		[Register("setDefaultRequestOptions", "(Lcom/bumptech/glide/Glide$RequestOptionsFactory;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetDefaultRequestOptions(Glide.IRequestOptionsFactory factory)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((factory == null) ? IntPtr.Zero : ((Java.Lang.Object)factory).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setDefaultRequestOptions.(Lcom/bumptech/glide/Glide$RequestOptionsFactory;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(factory);
			}
			return @object;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005D40 File Offset: 0x00003F40
		[Register("setDefaultRequestOptions", "(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetDefaultRequestOptions(RequestOptions requestOptions)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestOptions == null) ? IntPtr.Zero : requestOptions.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setDefaultRequestOptions.(Lcom/bumptech/glide/request/RequestOptions;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestOptions);
			}
			return @object;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005DB4 File Offset: 0x00003FB4
		[Register("setDefaultTransitionOptions", "(Ljava/lang/Class;Lcom/bumptech/glide/TransitionOptions;)Lcom/bumptech/glide/GlideBuilder;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe GlideBuilder SetDefaultTransitionOptions(Class clazz, TransitionOptions options)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setDefaultTransitionOptions.(Ljava/lang/Class;Lcom/bumptech/glide/TransitionOptions;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(clazz);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005E50 File Offset: 0x00004050
		[Register("setDiskCache", "(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetDiskCache(IDiskCacheFactory diskCacheFactory)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((diskCacheFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)diskCacheFactory).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setDiskCache.(Lcom/bumptech/glide/load/engine/cache/DiskCache$Factory;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(diskCacheFactory);
			}
			return @object;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Register("setDiskCacheExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetDiskCacheExecutor(GlideExecutor service)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((service == null) ? IntPtr.Zero : service.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setDiskCacheExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(service);
			}
			return @object;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00005F3C File Offset: 0x0000413C
		[Register("setImageDecoderEnabledForBitmaps", "(Z)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetImageDecoderEnabledForBitmaps(bool isEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isEnabled);
			return Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setImageDecoderEnabledForBitmaps.(Z)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00005F88 File Offset: 0x00004188
		[Register("setIsActiveResourceRetentionAllowed", "(Z)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetIsActiveResourceRetentionAllowed(bool isActiveResourceRetentionAllowed)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isActiveResourceRetentionAllowed);
			return Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setIsActiveResourceRetentionAllowed.(Z)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00005FD4 File Offset: 0x000041D4
		[Register("setLogLevel", "(I)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetLogLevel(int logLevel)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(logLevel);
			return Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogLevel.(I)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006020 File Offset: 0x00004220
		[Register("setLogRequestOrigins", "(Z)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetLogRequestOrigins(bool isEnabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isEnabled);
			return Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setLogRequestOrigins.(Z)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000606C File Offset: 0x0000426C
		[Register("setMemoryCache", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetMemoryCache(IMemoryCache memoryCache)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((memoryCache == null) ? IntPtr.Zero : ((Java.Lang.Object)memoryCache).Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setMemoryCache.(Lcom/bumptech/glide/load/engine/cache/MemoryCache;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(memoryCache);
			}
			return @object;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000060E4 File Offset: 0x000042E4
		[Register("setMemorySizeCalculator", "(Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetMemorySizeCalculator(MemorySizeCalculator calculator)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((calculator == null) ? IntPtr.Zero : calculator.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setMemorySizeCalculator.(Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(calculator);
			}
			return @object;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00006158 File Offset: 0x00004358
		[Register("setMemorySizeCalculator", "(Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetMemorySizeCalculator(MemorySizeCalculator.Builder builder)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setMemorySizeCalculator.(Lcom/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
			return @object;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000061CC File Offset: 0x000043CC
		[Obsolete("deprecated")]
		[Register("setResizeExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetResizeExecutor(GlideExecutor service)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((service == null) ? IntPtr.Zero : service.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setResizeExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(service);
			}
			return @object;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00006240 File Offset: 0x00004440
		[Register("setSourceExecutor", "(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", "")]
		public unsafe GlideBuilder SetSourceExecutor(GlideExecutor service)
		{
			GlideBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((service == null) ? IntPtr.Zero : service.Handle);
				@object = Java.Lang.Object.GetObject<GlideBuilder>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("setSourceExecutor.(Lcom/bumptech/glide/load/engine/executor/GlideExecutor;)Lcom/bumptech/glide/GlideBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(service);
			}
			return @object;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000062B4 File Offset: 0x000044B4
		[Register("build", "(Landroid/content/Context;)Lcom/bumptech/glide/Glide;", "")]
		public unsafe Glide Build(Context context)
		{
			Glide @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Glide>(GlideBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Landroid/content/Context;)Lcom/bumptech/glide/Glide;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0400004E RID: 78
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideBuilder", typeof(GlideBuilder));

		// Token: 0x020001A3 RID: 419
		[Register("com/bumptech/glide/GlideBuilder$LogRequestOrigins", DoNotGenerateAcw = true)]
		public sealed class LogRequestOrigins : Java.Lang.Object
		{
			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x06001513 RID: 5395 RVA: 0x00042B84 File Offset: 0x00040D84
			internal static IntPtr class_ref
			{
				get
				{
					return GlideBuilder.LogRequestOrigins._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x06001514 RID: 5396 RVA: 0x00042BA8 File Offset: 0x00040DA8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideBuilder.LogRequestOrigins._members;
				}
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x06001515 RID: 5397 RVA: 0x00042BB0 File Offset: 0x00040DB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GlideBuilder.LogRequestOrigins._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x06001516 RID: 5398 RVA: 0x00042BD4 File Offset: 0x00040DD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideBuilder.LogRequestOrigins._members.ManagedPeerType;
				}
			}

			// Token: 0x06001517 RID: 5399 RVA: 0x00042BE0 File Offset: 0x00040DE0
			internal LogRequestOrigins(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001518 RID: 5400 RVA: 0x00042BEC File Offset: 0x00040DEC
			[Register(".ctor", "()V", "")]
			public LogRequestOrigins() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(GlideBuilder.LogRequestOrigins._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				GlideBuilder.LogRequestOrigins._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x04000502 RID: 1282
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideBuilder$LogRequestOrigins", typeof(GlideBuilder.LogRequestOrigins));
		}

		// Token: 0x020001A4 RID: 420
		[Register("com/bumptech/glide/GlideBuilder$UseDirectResourceLoader", DoNotGenerateAcw = true)]
		public sealed class UseDirectResourceLoader : Java.Lang.Object
		{
			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x0600151A RID: 5402 RVA: 0x00042C78 File Offset: 0x00040E78
			internal static IntPtr class_ref
			{
				get
				{
					return GlideBuilder.UseDirectResourceLoader._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x0600151B RID: 5403 RVA: 0x00042C9C File Offset: 0x00040E9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideBuilder.UseDirectResourceLoader._members;
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x0600151C RID: 5404 RVA: 0x00042CA4 File Offset: 0x00040EA4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GlideBuilder.UseDirectResourceLoader._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x0600151D RID: 5405 RVA: 0x00042CC8 File Offset: 0x00040EC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideBuilder.UseDirectResourceLoader._members.ManagedPeerType;
				}
			}

			// Token: 0x0600151E RID: 5406 RVA: 0x00042CD4 File Offset: 0x00040ED4
			internal UseDirectResourceLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600151F RID: 5407 RVA: 0x00042CE0 File Offset: 0x00040EE0
			[Register(".ctor", "()V", "")]
			public UseDirectResourceLoader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(GlideBuilder.UseDirectResourceLoader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				GlideBuilder.UseDirectResourceLoader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x04000503 RID: 1283
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideBuilder$UseDirectResourceLoader", typeof(GlideBuilder.UseDirectResourceLoader));
		}

		// Token: 0x020001A5 RID: 421
		[Register("com/bumptech/glide/GlideBuilder$WaitForFramesAfterTrimMemory", DoNotGenerateAcw = true)]
		public sealed class WaitForFramesAfterTrimMemory : Java.Lang.Object
		{
			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06001521 RID: 5409 RVA: 0x00042D6C File Offset: 0x00040F6C
			internal static IntPtr class_ref
			{
				get
				{
					return GlideBuilder.WaitForFramesAfterTrimMemory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06001522 RID: 5410 RVA: 0x00042D90 File Offset: 0x00040F90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideBuilder.WaitForFramesAfterTrimMemory._members;
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x06001523 RID: 5411 RVA: 0x00042D98 File Offset: 0x00040F98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return GlideBuilder.WaitForFramesAfterTrimMemory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x06001524 RID: 5412 RVA: 0x00042DBC File Offset: 0x00040FBC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideBuilder.WaitForFramesAfterTrimMemory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001525 RID: 5413 RVA: 0x00042DC8 File Offset: 0x00040FC8
			internal WaitForFramesAfterTrimMemory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000504 RID: 1284
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GlideBuilder$WaitForFramesAfterTrimMemory", typeof(GlideBuilder.WaitForFramesAfterTrimMemory));
		}
	}
}
