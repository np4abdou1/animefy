using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x02000163 RID: 355
	[Register("com/bumptech/glide/load/engine/cache/DiskCache$Factory", DoNotGenerateAcw = true)]
	internal class IDiskCacheFactoryInvoker : Java.Lang.Object, IDiskCacheFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000397AC File Offset: 0x000379AC
		private static IntPtr java_class_ref
		{
			get
			{
				return IDiskCacheFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000397D0 File Offset: 0x000379D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDiskCacheFactoryInvoker._members;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000397D7 File Offset: 0x000379D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000397DF File Offset: 0x000379DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDiskCacheFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000397EB File Offset: 0x000379EB
		public static IDiskCacheFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDiskCacheFactory>(handle, transfer);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000397F4 File Offset: 0x000379F4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDiskCacheFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.cache.DiskCache.Factory'.");
			}
			return handle;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0003981F File Offset: 0x00037A1F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00039850 File Offset: 0x00037A50
		public IDiskCacheFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDiskCacheFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00039888 File Offset: 0x00037A88
		private static Delegate GetBuildHandler()
		{
			if (IDiskCacheFactoryInvoker.cb_build == null)
			{
				IDiskCacheFactoryInvoker.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDiskCacheFactoryInvoker.n_Build));
			}
			return IDiskCacheFactoryInvoker.cb_build;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000398AC File Offset: 0x00037AAC
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDiskCacheFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000398C0 File Offset: 0x00037AC0
		public IDiskCache Build()
		{
			if (this.id_build == IntPtr.Zero)
			{
				this.id_build = JNIEnv.GetMethodID(this.class_ref, "build", "()Lcom/bumptech/glide/load/engine/cache/DiskCache;");
			}
			return Java.Lang.Object.GetObject<IDiskCache>(JNIEnv.CallObjectMethod(base.Handle, this.id_build), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000412 RID: 1042
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/cache/DiskCache$Factory", typeof(IDiskCacheFactoryInvoker));

		// Token: 0x04000413 RID: 1043
		private IntPtr class_ref;

		// Token: 0x04000414 RID: 1044
		private static Delegate cb_build;

		// Token: 0x04000415 RID: 1045
		private IntPtr id_build;
	}
}
