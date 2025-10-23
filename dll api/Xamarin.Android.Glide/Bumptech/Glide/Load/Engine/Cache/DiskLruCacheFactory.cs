using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200015C RID: 348
	[Register("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory", DoNotGenerateAcw = true)]
	public class DiskLruCacheFactory : Java.Lang.Object, IDiskCacheFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000389A4 File Offset: 0x00036BA4
		internal static IntPtr class_ref
		{
			get
			{
				return DiskLruCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x000389C8 File Offset: 0x00036BC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskLruCacheFactory._members;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000389D0 File Offset: 0x00036BD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DiskLruCacheFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x000389F4 File Offset: 0x00036BF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskLruCacheFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00038A00 File Offset: 0x00036C00
		protected DiskLruCacheFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00038A0C File Offset: 0x00036C0C
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;J)V", "")]
		public unsafe DiskLruCacheFactory(DiskLruCacheFactory.ICacheDirectoryGetter cacheDirectoryGetter, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cacheDirectoryGetter == null) ? IntPtr.Zero : ((Java.Lang.Object)cacheDirectoryGetter).Handle);
				ptr[1] = new JniArgumentValue(diskCacheSize);
				base.SetHandle(DiskLruCacheFactory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DiskLruCacheFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter;J)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cacheDirectoryGetter);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00038AD4 File Offset: 0x00036CD4
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;J)V", "")]
		public unsafe DiskLruCacheFactory(string diskCacheFolder, string diskCacheName, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(diskCacheFolder);
			IntPtr intPtr2 = JNIEnv.NewString(diskCacheName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(diskCacheSize);
				base.SetHandle(DiskLruCacheFactory._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DiskLruCacheFactory._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00038BB0 File Offset: 0x00036DB0
		[Register(".ctor", "(Ljava/lang/String;J)V", "")]
		public unsafe DiskLruCacheFactory(string diskCacheFolder, long diskCacheSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(diskCacheFolder);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(diskCacheSize);
				base.SetHandle(DiskLruCacheFactory._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DiskLruCacheFactory._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;J)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00038C68 File Offset: 0x00036E68
		private static Delegate GetBuildHandler()
		{
			if (DiskLruCacheFactory.cb_build == null)
			{
				DiskLruCacheFactory.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DiskLruCacheFactory.n_Build));
			}
			return DiskLruCacheFactory.cb_build;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00038C8C File Offset: 0x00036E8C
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DiskLruCacheFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00038CA0 File Offset: 0x00036EA0
		[Register("build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;", "GetBuildHandler")]
		public virtual IDiskCache Build()
		{
			return Java.Lang.Object.GetObject<IDiskCache>(DiskLruCacheFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/bumptech/glide/load/engine/cache/DiskCache;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000407 RID: 1031
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory", typeof(DiskLruCacheFactory));

		// Token: 0x04000408 RID: 1032
		private static Delegate cb_build;

		// Token: 0x020001F8 RID: 504
		public static class InterfaceConsts
		{
			// Token: 0x040005B2 RID: 1458
			[Register("DEFAULT_DISK_CACHE_DIR")]
			public const string DefaultDiskCacheDir = "image_manager_disk_cache";

			// Token: 0x040005B3 RID: 1459
			[Register("DEFAULT_DISK_CACHE_SIZE")]
			public const int DefaultDiskCacheSize = 262144000;
		}

		// Token: 0x020001F9 RID: 505
		[Register("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter", "", "Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory/ICacheDirectoryGetterInvoker")]
		public interface ICacheDirectoryGetter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060017EB RID: 6123
			File CacheDirectory { [Register("getCacheDirectory", "()Ljava/io/File;", "GetGetCacheDirectoryHandler:Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory/ICacheDirectoryGetterInvoker, Xamarin.Android.Glide")] get; }
		}

		// Token: 0x020001FA RID: 506
		[Register("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter", DoNotGenerateAcw = true)]
		internal class ICacheDirectoryGetterInvoker : Java.Lang.Object, DiskLruCacheFactory.ICacheDirectoryGetter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060017EC RID: 6124 RVA: 0x00049EF0 File Offset: 0x000480F0
			private static IntPtr java_class_ref
			{
				get
				{
					return DiskLruCacheFactory.ICacheDirectoryGetterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x060017ED RID: 6125 RVA: 0x00049F14 File Offset: 0x00048114
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DiskLruCacheFactory.ICacheDirectoryGetterInvoker._members;
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x060017EE RID: 6126 RVA: 0x00049F1B File Offset: 0x0004811B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x060017EF RID: 6127 RVA: 0x00049F23 File Offset: 0x00048123
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DiskLruCacheFactory.ICacheDirectoryGetterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060017F0 RID: 6128 RVA: 0x00049F2F File Offset: 0x0004812F
			public static DiskLruCacheFactory.ICacheDirectoryGetter GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<DiskLruCacheFactory.ICacheDirectoryGetter>(handle, transfer);
			}

			// Token: 0x060017F1 RID: 6129 RVA: 0x00049F38 File Offset: 0x00048138
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, DiskLruCacheFactory.ICacheDirectoryGetterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.DiskLruCacheFactory.CacheDirectoryGetter'.");
				}
				return handle;
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x00049F63 File Offset: 0x00048163
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x00049F94 File Offset: 0x00048194
			public ICacheDirectoryGetterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(DiskLruCacheFactory.ICacheDirectoryGetterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x00049FCC File Offset: 0x000481CC
			private static Delegate GetGetCacheDirectoryHandler()
			{
				if (DiskLruCacheFactory.ICacheDirectoryGetterInvoker.cb_getCacheDirectory == null)
				{
					DiskLruCacheFactory.ICacheDirectoryGetterInvoker.cb_getCacheDirectory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DiskLruCacheFactory.ICacheDirectoryGetterInvoker.n_GetCacheDirectory));
				}
				return DiskLruCacheFactory.ICacheDirectoryGetterInvoker.cb_getCacheDirectory;
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x00049FF0 File Offset: 0x000481F0
			private static IntPtr n_GetCacheDirectory(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DiskLruCacheFactory.ICacheDirectoryGetter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CacheDirectory);
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0004A004 File Offset: 0x00048204
			public File CacheDirectory
			{
				get
				{
					if (this.id_getCacheDirectory == IntPtr.Zero)
					{
						this.id_getCacheDirectory = JNIEnv.GetMethodID(this.class_ref, "getCacheDirectory", "()Ljava/io/File;");
					}
					return Java.Lang.Object.GetObject<File>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCacheDirectory), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040005B4 RID: 1460
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskLruCacheFactory$CacheDirectoryGetter", typeof(DiskLruCacheFactory.ICacheDirectoryGetterInvoker));

			// Token: 0x040005B5 RID: 1461
			private IntPtr class_ref;

			// Token: 0x040005B6 RID: 1462
			private static Delegate cb_getCacheDirectory;

			// Token: 0x040005B7 RID: 1463
			private IntPtr id_getCacheDirectory;
		}
	}
}
