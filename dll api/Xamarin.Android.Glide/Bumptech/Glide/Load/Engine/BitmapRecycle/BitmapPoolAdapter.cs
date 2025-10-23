using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000175 RID: 373
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPoolAdapter", DoNotGenerateAcw = true)]
	public class BitmapPoolAdapter : Java.Lang.Object, IBitmapPool, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0003B9D4 File Offset: 0x00039BD4
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapPoolAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0003B9F8 File Offset: 0x00039BF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapPoolAdapter._members;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0003BA00 File Offset: 0x00039C00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapPoolAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0003BA24 File Offset: 0x00039C24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapPoolAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0003BA30 File Offset: 0x00039C30
		protected BitmapPoolAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0003BA3C File Offset: 0x00039C3C
		[Register(".ctor", "()V", "")]
		public BitmapPoolAdapter() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapPoolAdapter._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapPoolAdapter._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0003BAAA File Offset: 0x00039CAA
		private static Delegate GetGetMaxSizeHandler()
		{
			if (BitmapPoolAdapter.cb_getMaxSize == null)
			{
				BitmapPoolAdapter.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(BitmapPoolAdapter.n_GetMaxSize));
			}
			return BitmapPoolAdapter.cb_getMaxSize;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0003BACE File Offset: 0x00039CCE
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0003BADD File Offset: 0x00039CDD
		public virtual long MaxSize
		{
			[Register("getMaxSize", "()J", "GetGetMaxSizeHandler")]
			get
			{
				return BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualInt64Method("getMaxSize.()J", this, null);
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0003BAF6 File Offset: 0x00039CF6
		private static Delegate GetClearMemoryHandler()
		{
			if (BitmapPoolAdapter.cb_clearMemory == null)
			{
				BitmapPoolAdapter.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BitmapPoolAdapter.n_ClearMemory));
			}
			return BitmapPoolAdapter.cb_clearMemory;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0003BB1A File Offset: 0x00039D1A
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0003BB29 File Offset: 0x00039D29
		[Register("clearMemory", "()V", "GetClearMemoryHandler")]
		public virtual void ClearMemory()
		{
			BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0003BB42 File Offset: 0x00039D42
		private static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (BitmapPoolAdapter.cb_get_IILandroid_graphics_Bitmap_Config_ == null)
			{
				BitmapPoolAdapter.cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(BitmapPoolAdapter.n_Get_IILandroid_graphics_Bitmap_Config_));
			}
			return BitmapPoolAdapter.cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0003BB68 File Offset: 0x00039D68
		private static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			BitmapPoolAdapter @object = Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(width, height, object2));
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0003BB94 File Offset: 0x00039D94
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
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("get.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0003BC30 File Offset: 0x00039E30
		private static Delegate GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (BitmapPoolAdapter.cb_getDirty_IILandroid_graphics_Bitmap_Config_ == null)
			{
				BitmapPoolAdapter.cb_getDirty_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(BitmapPoolAdapter.n_GetDirty_IILandroid_graphics_Bitmap_Config_));
			}
			return BitmapPoolAdapter.cb_getDirty_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0003BC54 File Offset: 0x00039E54
		private static IntPtr n_GetDirty_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			BitmapPoolAdapter @object = Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDirty(width, height, object2));
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0003BC80 File Offset: 0x00039E80
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
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getDirty.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0003BD1C File Offset: 0x00039F1C
		private static Delegate GetPut_Landroid_graphics_Bitmap_Handler()
		{
			if (BitmapPoolAdapter.cb_put_Landroid_graphics_Bitmap_ == null)
			{
				BitmapPoolAdapter.cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BitmapPoolAdapter.n_Put_Landroid_graphics_Bitmap_));
			}
			return BitmapPoolAdapter.cb_put_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0003BD40 File Offset: 0x00039F40
		private static void n_Put_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			BitmapPoolAdapter @object = Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0003BD64 File Offset: 0x00039F64
		[Register("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual void Put(Bitmap bitmap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0003BDC8 File Offset: 0x00039FC8
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (BitmapPoolAdapter.cb_setSizeMultiplier_F == null)
			{
				BitmapPoolAdapter.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(BitmapPoolAdapter.n_SetSizeMultiplier_F));
			}
			return BitmapPoolAdapter.cb_setSizeMultiplier_F;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0003BDEC File Offset: 0x00039FEC
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float sizeMultiplier)
		{
			Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(sizeMultiplier);
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003BDFC File Offset: 0x00039FFC
		[Register("setSizeMultiplier", "(F)V", "GetSetSizeMultiplier_FHandler")]
		public unsafe virtual void SetSizeMultiplier(float sizeMultiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sizeMultiplier);
			BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("setSizeMultiplier.(F)V", this, ptr);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003BE37 File Offset: 0x0003A037
		private static Delegate GetTrimMemory_IHandler()
		{
			if (BitmapPoolAdapter.cb_trimMemory_I == null)
			{
				BitmapPoolAdapter.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BitmapPoolAdapter.n_TrimMemory_I));
			}
			return BitmapPoolAdapter.cb_trimMemory_I;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0003BE5B File Offset: 0x0003A05B
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int level)
		{
			Java.Lang.Object.GetObject<BitmapPoolAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(level);
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0003BE6C File Offset: 0x0003A06C
		[Register("trimMemory", "(I)V", "GetTrimMemory_IHandler")]
		public unsafe virtual void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			BitmapPoolAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x04000456 RID: 1110
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPoolAdapter", typeof(BitmapPoolAdapter));

		// Token: 0x04000457 RID: 1111
		private static Delegate cb_getMaxSize;

		// Token: 0x04000458 RID: 1112
		private static Delegate cb_clearMemory;

		// Token: 0x04000459 RID: 1113
		private static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x0400045A RID: 1114
		private static Delegate cb_getDirty_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x0400045B RID: 1115
		private static Delegate cb_put_Landroid_graphics_Bitmap_;

		// Token: 0x0400045C RID: 1116
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x0400045D RID: 1117
		private static Delegate cb_trimMemory_I;
	}
}
