using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000183 RID: 387
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool", DoNotGenerateAcw = true)]
	public class LruBitmapPool : Java.Lang.Object, IBitmapPool, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
		internal static IntPtr class_ref
		{
			get
			{
				return LruBitmapPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LruBitmapPool._members;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x0003D904 File Offset: 0x0003BB04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LruBitmapPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0003D928 File Offset: 0x0003BB28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LruBitmapPool._members.ManagedPeerType;
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0003D934 File Offset: 0x0003BB34
		protected LruBitmapPool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0003D940 File Offset: 0x0003BB40
		[Register(".ctor", "(J)V", "")]
		public unsafe LruBitmapPool(long maxSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxSize);
			base.SetHandle(LruBitmapPool._members.InstanceMethods.StartCreateInstance("(J)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LruBitmapPool._members.InstanceMethods.FinishCreateInstance("(J)V", this, ptr);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
		[Register(".ctor", "(JLjava/util/Set;)V", "")]
		public unsafe LruBitmapPool(long maxSize, ICollection<Bitmap.Config> allowedConfigs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaSet<Bitmap.Config>.ToLocalJniHandle(allowedConfigs);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(maxSize);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(LruBitmapPool._members.InstanceMethods.StartCreateInstance("(JLjava/util/Set;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LruBitmapPool._members.InstanceMethods.FinishCreateInstance("(JLjava/util/Set;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(allowedConfigs);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0003DA84 File Offset: 0x0003BC84
		private static Delegate GetGetCurrentSizeHandler()
		{
			if (LruBitmapPool.cb_getCurrentSize == null)
			{
				LruBitmapPool.cb_getCurrentSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruBitmapPool.n_GetCurrentSize));
			}
			return LruBitmapPool.cb_getCurrentSize;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		private static long n_GetCurrentSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentSize;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0003DAB7 File Offset: 0x0003BCB7
		public virtual long CurrentSize
		{
			[Register("getCurrentSize", "()J", "GetGetCurrentSizeHandler")]
			get
			{
				return LruBitmapPool._members.InstanceMethods.InvokeVirtualInt64Method("getCurrentSize.()J", this, null);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
		private static Delegate GetGetMaxSizeHandler()
		{
			if (LruBitmapPool.cb_getMaxSize == null)
			{
				LruBitmapPool.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruBitmapPool.n_GetMaxSize));
			}
			return LruBitmapPool.cb_getMaxSize;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0003DB03 File Offset: 0x0003BD03
		public virtual long MaxSize
		{
			[Register("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get
			{
				return LruBitmapPool._members.InstanceMethods.InvokeVirtualInt64Method("getMaxSize.()J", this, null);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		private static Delegate GetClearMemoryHandler()
		{
			if (LruBitmapPool.cb_clearMemory == null)
			{
				LruBitmapPool.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LruBitmapPool.n_ClearMemory));
			}
			return LruBitmapPool.cb_clearMemory;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0003DB40 File Offset: 0x0003BD40
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0003DB4F File Offset: 0x0003BD4F
		[Register("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual void ClearMemory()
		{
			LruBitmapPool._members.InstanceMethods.InvokeVirtualVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x0003DB68 File Offset: 0x0003BD68
		private static Delegate GetEvictionCountHandler()
		{
			if (LruBitmapPool.cb_evictionCount == null)
			{
				LruBitmapPool.cb_evictionCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruBitmapPool.n_EvictionCount));
			}
			return LruBitmapPool.cb_evictionCount;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0003DB8C File Offset: 0x0003BD8C
		private static long n_EvictionCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EvictionCount();
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0003DB9B File Offset: 0x0003BD9B
		[Register("evictionCount", "()J", "GetEvictionCountHandler")]
		public virtual long EvictionCount()
		{
			return LruBitmapPool._members.InstanceMethods.InvokeVirtualInt64Method("evictionCount.()J", this, null);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0003DBB4 File Offset: 0x0003BDB4
		private static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (LruBitmapPool.cb_get_IILandroid_graphics_Bitmap_Config_ == null)
			{
				LruBitmapPool.cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(LruBitmapPool.n_Get_IILandroid_graphics_Bitmap_Config_));
			}
			return LruBitmapPool.cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
		private static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			LruBitmapPool @object = Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(width, height, object2));
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0003DC04 File Offset: 0x0003BE04
		[Register("get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGet_IILandroid_graphics_Bitmap_Config_Handler")]
		public unsafe virtual Bitmap Get(int width, int height, Bitmap.Config config)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(LruBitmapPool._members.InstanceMethods.InvokeVirtualObjectMethod("get.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0003DCA0 File Offset: 0x0003BEA0
		private static Delegate GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (LruBitmapPool.cb_getDirty_IILandroid_graphics_Bitmap_Config_ == null)
			{
				LruBitmapPool.cb_getDirty_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(LruBitmapPool.n_GetDirty_IILandroid_graphics_Bitmap_Config_));
			}
			return LruBitmapPool.cb_getDirty_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
		private static IntPtr n_GetDirty_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			LruBitmapPool @object = Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDirty(width, height, object2));
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		[Register("getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", "GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler")]
		public unsafe virtual Bitmap GetDirty(int width, int height, Bitmap.Config config)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(LruBitmapPool._members.InstanceMethods.InvokeVirtualObjectMethod("getDirty.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0003DD8C File Offset: 0x0003BF8C
		private static Delegate GetHitCountHandler()
		{
			if (LruBitmapPool.cb_hitCount == null)
			{
				LruBitmapPool.cb_hitCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruBitmapPool.n_HitCount));
			}
			return LruBitmapPool.cb_hitCount;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0003DDB0 File Offset: 0x0003BFB0
		private static long n_HitCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HitCount();
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003DDBF File Offset: 0x0003BFBF
		[Register("hitCount", "()J", "GetHitCountHandler")]
		public virtual long HitCount()
		{
			return LruBitmapPool._members.InstanceMethods.InvokeVirtualInt64Method("hitCount.()J", this, null);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003DDD8 File Offset: 0x0003BFD8
		private static Delegate GetMissCountHandler()
		{
			if (LruBitmapPool.cb_missCount == null)
			{
				LruBitmapPool.cb_missCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(LruBitmapPool.n_MissCount));
			}
			return LruBitmapPool.cb_missCount;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0003DDFC File Offset: 0x0003BFFC
		private static long n_MissCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MissCount();
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0003DE0B File Offset: 0x0003C00B
		[Register("missCount", "()J", "GetMissCountHandler")]
		public virtual long MissCount()
		{
			return LruBitmapPool._members.InstanceMethods.InvokeVirtualInt64Method("missCount.()J", this, null);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0003DE24 File Offset: 0x0003C024
		private static Delegate GetPut_Landroid_graphics_Bitmap_Handler()
		{
			if (LruBitmapPool.cb_put_Landroid_graphics_Bitmap_ == null)
			{
				LruBitmapPool.cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(LruBitmapPool.n_Put_Landroid_graphics_Bitmap_));
			}
			return LruBitmapPool.cb_put_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0003DE48 File Offset: 0x0003C048
		private static void n_Put_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			LruBitmapPool @object = Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0003DE6C File Offset: 0x0003C06C
		[Register("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual void Put(Bitmap bitmap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				LruBitmapPool._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0003DED0 File Offset: 0x0003C0D0
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (LruBitmapPool.cb_setSizeMultiplier_F == null)
			{
				LruBitmapPool.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(LruBitmapPool.n_SetSizeMultiplier_F));
			}
			return LruBitmapPool.cb_setSizeMultiplier_F;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float sizeMultiplier)
		{
			Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(sizeMultiplier);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0003DF04 File Offset: 0x0003C104
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler")]
		public unsafe virtual void SetSizeMultiplier(float sizeMultiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sizeMultiplier);
			LruBitmapPool._members.InstanceMethods.InvokeVirtualVoidMethod("setSizeMultiplier.(F)V", this, ptr);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003DF3F File Offset: 0x0003C13F
		private static Delegate GetTrimMemory_IHandler()
		{
			if (LruBitmapPool.cb_trimMemory_I == null)
			{
				LruBitmapPool.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(LruBitmapPool.n_TrimMemory_I));
			}
			return LruBitmapPool.cb_trimMemory_I;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0003DF63 File Offset: 0x0003C163
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int level)
		{
			Java.Lang.Object.GetObject<LruBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(level);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0003DF74 File Offset: 0x0003C174
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public unsafe virtual void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			LruBitmapPool._members.InstanceMethods.InvokeVirtualVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x04000492 RID: 1170
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool", typeof(LruBitmapPool));

		// Token: 0x04000493 RID: 1171
		private static Delegate cb_getCurrentSize;

		// Token: 0x04000494 RID: 1172
		private static Delegate cb_getMaxSize;

		// Token: 0x04000495 RID: 1173
		private static Delegate cb_clearMemory;

		// Token: 0x04000496 RID: 1174
		private static Delegate cb_evictionCount;

		// Token: 0x04000497 RID: 1175
		private static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000498 RID: 1176
		private static Delegate cb_getDirty_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000499 RID: 1177
		private static Delegate cb_hitCount;

		// Token: 0x0400049A RID: 1178
		private static Delegate cb_missCount;

		// Token: 0x0400049B RID: 1179
		private static Delegate cb_put_Landroid_graphics_Bitmap_;

		// Token: 0x0400049C RID: 1180
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x0400049D RID: 1181
		private static Delegate cb_trimMemory_I;
	}
}
