using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000184 RID: 388
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy", DoNotGenerateAcw = true)]
	public class SizeConfigStrategy : Java.Lang.Object, ILruPoolStrategy, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		internal static IntPtr class_ref
		{
			get
			{
				return SizeConfigStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0003DFF0 File Offset: 0x0003C1F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SizeConfigStrategy._members;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0003DFF8 File Offset: 0x0003C1F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SizeConfigStrategy._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003E01C File Offset: 0x0003C21C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SizeConfigStrategy._members.ManagedPeerType;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0003E028 File Offset: 0x0003C228
		protected SizeConfigStrategy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0003E034 File Offset: 0x0003C234
		[Register(".ctor", "()V", "")]
		public SizeConfigStrategy() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SizeConfigStrategy._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SizeConfigStrategy._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0003E0A2 File Offset: 0x0003C2A2
		private static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (SizeConfigStrategy.cb_get_IILandroid_graphics_Bitmap_Config_ == null)
			{
				SizeConfigStrategy.cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SizeConfigStrategy.n_Get_IILandroid_graphics_Bitmap_Config_));
			}
			return SizeConfigStrategy.cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0003E0C8 File Offset: 0x0003C2C8
		private static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			SizeConfigStrategy @object = Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(width, height, object2));
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0003E0F4 File Offset: 0x0003C2F4
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
				@object = Java.Lang.Object.GetObject<Bitmap>(SizeConfigStrategy._members.InstanceMethods.InvokeVirtualObjectMethod("get.(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @object;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0003E190 File Offset: 0x0003C390
		private static Delegate GetGetSize_Landroid_graphics_Bitmap_Handler()
		{
			if (SizeConfigStrategy.cb_getSize_Landroid_graphics_Bitmap_ == null)
			{
				SizeConfigStrategy.cb_getSize_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(SizeConfigStrategy.n_GetSize_Landroid_graphics_Bitmap_));
			}
			return SizeConfigStrategy.cb_getSize_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0003E1B4 File Offset: 0x0003C3B4
		private static int n_GetSize_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			SizeConfigStrategy @object = Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			return @object.GetSize(object2);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0003E1D8 File Offset: 0x0003C3D8
		[Register("getSize", "(Landroid/graphics/Bitmap;)I", "GetGetSize_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual int GetSize(Bitmap bitmap)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				result = SizeConfigStrategy._members.InstanceMethods.InvokeVirtualInt32Method("getSize.(Landroid/graphics/Bitmap;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return result;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0003E240 File Offset: 0x0003C440
		private static Delegate GetLogBitmap_Landroid_graphics_Bitmap_Handler()
		{
			if (SizeConfigStrategy.cb_logBitmap_Landroid_graphics_Bitmap_ == null)
			{
				SizeConfigStrategy.cb_logBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SizeConfigStrategy.n_LogBitmap_Landroid_graphics_Bitmap_));
			}
			return SizeConfigStrategy.cb_logBitmap_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0003E264 File Offset: 0x0003C464
		private static IntPtr n_LogBitmap_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			SizeConfigStrategy @object = Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.LogBitmap(object2));
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0003E28C File Offset: 0x0003C48C
		[Register("logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;", "GetLogBitmap_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual string LogBitmap(Bitmap bitmap)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				@string = JNIEnv.GetString(SizeConfigStrategy._members.InstanceMethods.InvokeVirtualObjectMethod("logBitmap.(Landroid/graphics/Bitmap;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
			return @string;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0003E300 File Offset: 0x0003C500
		private static Delegate GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (SizeConfigStrategy.cb_logBitmap_IILandroid_graphics_Bitmap_Config_ == null)
			{
				SizeConfigStrategy.cb_logBitmap_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(SizeConfigStrategy.n_LogBitmap_IILandroid_graphics_Bitmap_Config_));
			}
			return SizeConfigStrategy.cb_logBitmap_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0003E324 File Offset: 0x0003C524
		private static IntPtr n_LogBitmap_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int width, int height, IntPtr native_config)
		{
			SizeConfigStrategy @object = Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.LogBitmap(width, height, object2));
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0003E350 File Offset: 0x0003C550
		[Register("logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;", "GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler")]
		public unsafe virtual string LogBitmap(int width, int height, Bitmap.Config config)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				@string = JNIEnv.GetString(SizeConfigStrategy._members.InstanceMethods.InvokeVirtualObjectMethod("logBitmap.(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(config);
			}
			return @string;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0003E3EC File Offset: 0x0003C5EC
		private static Delegate GetPut_Landroid_graphics_Bitmap_Handler()
		{
			if (SizeConfigStrategy.cb_put_Landroid_graphics_Bitmap_ == null)
			{
				SizeConfigStrategy.cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SizeConfigStrategy.n_Put_Landroid_graphics_Bitmap_));
			}
			return SizeConfigStrategy.cb_put_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0003E410 File Offset: 0x0003C610
		private static void n_Put_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			SizeConfigStrategy @object = Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bitmap, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0003E434 File Offset: 0x0003C634
		[Register("put", "(Landroid/graphics/Bitmap;)V", "GetPut_Landroid_graphics_Bitmap_Handler")]
		public unsafe virtual void Put(Bitmap bitmap)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bitmap == null) ? IntPtr.Zero : bitmap.Handle);
				SizeConfigStrategy._members.InstanceMethods.InvokeVirtualVoidMethod("put.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bitmap);
			}
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003E498 File Offset: 0x0003C698
		private static Delegate GetRemoveLastHandler()
		{
			if (SizeConfigStrategy.cb_removeLast == null)
			{
				SizeConfigStrategy.cb_removeLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SizeConfigStrategy.n_RemoveLast));
			}
			return SizeConfigStrategy.cb_removeLast;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0003E4BC File Offset: 0x0003C6BC
		private static IntPtr n_RemoveLast(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SizeConfigStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveLast());
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
		[Register("removeLast", "()Landroid/graphics/Bitmap;", "GetRemoveLastHandler")]
		public virtual Bitmap RemoveLast()
		{
			return Java.Lang.Object.GetObject<Bitmap>(SizeConfigStrategy._members.InstanceMethods.InvokeVirtualObjectMethod("removeLast.()Landroid/graphics/Bitmap;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400049E RID: 1182
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy", typeof(SizeConfigStrategy));

		// Token: 0x0400049F RID: 1183
		private static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x040004A0 RID: 1184
		private static Delegate cb_getSize_Landroid_graphics_Bitmap_;

		// Token: 0x040004A1 RID: 1185
		private static Delegate cb_logBitmap_Landroid_graphics_Bitmap_;

		// Token: 0x040004A2 RID: 1186
		private static Delegate cb_logBitmap_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x040004A3 RID: 1187
		private static Delegate cb_put_Landroid_graphics_Bitmap_;

		// Token: 0x040004A4 RID: 1188
		private static Delegate cb_removeLast;
	}
}
