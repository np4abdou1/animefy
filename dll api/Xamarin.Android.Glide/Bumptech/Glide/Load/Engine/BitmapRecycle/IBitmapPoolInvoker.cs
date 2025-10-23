using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017C RID: 380
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool", DoNotGenerateAcw = true)]
	internal class IBitmapPoolInvoker : Java.Lang.Object, IBitmapPool, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x0003C638 File Offset: 0x0003A838
		private static IntPtr java_class_ref
		{
			get
			{
				return IBitmapPoolInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x0003C65C File Offset: 0x0003A85C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBitmapPoolInvoker._members;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x0003C663 File Offset: 0x0003A863
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0003C66B File Offset: 0x0003A86B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBitmapPoolInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0003C677 File Offset: 0x0003A877
		public static IBitmapPool GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBitmapPool>(handle, transfer);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0003C680 File Offset: 0x0003A880
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBitmapPoolInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.bitmap_recycle.BitmapPool'.");
			}
			return handle;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0003C6AB File Offset: 0x0003A8AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0003C6DC File Offset: 0x0003A8DC
		public IBitmapPoolInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBitmapPoolInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0003C714 File Offset: 0x0003A914
		private static Delegate GetGetMaxSizeHandler()
		{
			if (IBitmapPoolInvoker.cb_getMaxSize == null)
			{
				IBitmapPoolInvoker.cb_getMaxSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IBitmapPoolInvoker.n_GetMaxSize));
			}
			return IBitmapPoolInvoker.cb_getMaxSize;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0003C738 File Offset: 0x0003A938
		private static long n_GetMaxSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxSize;
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0003C747 File Offset: 0x0003A947
		public long MaxSize
		{
			get
			{
				if (this.id_getMaxSize == IntPtr.Zero)
				{
					this.id_getMaxSize = JNIEnv.GetMethodID(this.class_ref, "getMaxSize", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getMaxSize);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0003C787 File Offset: 0x0003A987
		private static Delegate GetClearMemoryHandler()
		{
			if (IBitmapPoolInvoker.cb_clearMemory == null)
			{
				IBitmapPoolInvoker.cb_clearMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IBitmapPoolInvoker.n_ClearMemory));
			}
			return IBitmapPoolInvoker.cb_clearMemory;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0003C7AB File Offset: 0x0003A9AB
		private static void n_ClearMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearMemory();
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0003C7BA File Offset: 0x0003A9BA
		public void ClearMemory()
		{
			if (this.id_clearMemory == IntPtr.Zero)
			{
				this.id_clearMemory = JNIEnv.GetMethodID(this.class_ref, "clearMemory", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearMemory);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0003C7FA File Offset: 0x0003A9FA
		private static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (IBitmapPoolInvoker.cb_get_IILandroid_graphics_Bitmap_Config_ == null)
			{
				IBitmapPoolInvoker.cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(IBitmapPoolInvoker.n_Get_IILandroid_graphics_Bitmap_Config_));
			}
			return IBitmapPoolInvoker.cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0003C820 File Offset: 0x0003AA20
		private static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			IBitmapPool @object = Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(p0, p1, object2));
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0003C84C File Offset: 0x0003AA4C
		public unsafe Bitmap Get(int p0, int p1, Bitmap.Config p2)
		{
			if (this.id_get_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
			{
				this.id_get_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID(this.class_ref, "get", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			return Java.Lang.Object.GetObject<Bitmap>(JNIEnv.CallObjectMethod(base.Handle, this.id_get_IILandroid_graphics_Bitmap_Config_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0003C8EE File Offset: 0x0003AAEE
		private static Delegate GetGetDirty_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (IBitmapPoolInvoker.cb_getDirty_IILandroid_graphics_Bitmap_Config_ == null)
			{
				IBitmapPoolInvoker.cb_getDirty_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(IBitmapPoolInvoker.n_GetDirty_IILandroid_graphics_Bitmap_Config_));
			}
			return IBitmapPoolInvoker.cb_getDirty_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0003C914 File Offset: 0x0003AB14
		private static IntPtr n_GetDirty_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			IBitmapPool @object = Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetDirty(p0, p1, object2));
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0003C940 File Offset: 0x0003AB40
		public unsafe Bitmap GetDirty(int p0, int p1, Bitmap.Config p2)
		{
			if (this.id_getDirty_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
			{
				this.id_getDirty_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID(this.class_ref, "getDirty", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			return Java.Lang.Object.GetObject<Bitmap>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDirty_IILandroid_graphics_Bitmap_Config_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0003C9E2 File Offset: 0x0003ABE2
		private static Delegate GetPut_Landroid_graphics_Bitmap_Handler()
		{
			if (IBitmapPoolInvoker.cb_put_Landroid_graphics_Bitmap_ == null)
			{
				IBitmapPoolInvoker.cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IBitmapPoolInvoker.n_Put_Landroid_graphics_Bitmap_));
			}
			return IBitmapPoolInvoker.cb_put_Landroid_graphics_Bitmap_;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0003CA08 File Offset: 0x0003AC08
		private static void n_Put_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IBitmapPool @object = Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0003CA2C File Offset: 0x0003AC2C
		public unsafe void Put(Bitmap p0)
		{
			if (this.id_put_Landroid_graphics_Bitmap_ == IntPtr.Zero)
			{
				this.id_put_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(this.class_ref, "put", "(Landroid/graphics/Bitmap;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_put_Landroid_graphics_Bitmap_, ptr);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0003CA9F File Offset: 0x0003AC9F
		private static Delegate GetSetSizeMultiplier_FHandler()
		{
			if (IBitmapPoolInvoker.cb_setSizeMultiplier_F == null)
			{
				IBitmapPoolInvoker.cb_setSizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(IBitmapPoolInvoker.n_SetSizeMultiplier_F));
			}
			return IBitmapPoolInvoker.cb_setSizeMultiplier_F;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0003CAC3 File Offset: 0x0003ACC3
		private static void n_SetSizeMultiplier_F(IntPtr jnienv, IntPtr native__this, float p0)
		{
			Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSizeMultiplier(p0);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
		public unsafe void SetSizeMultiplier(float p0)
		{
			if (this.id_setSizeMultiplier_F == IntPtr.Zero)
			{
				this.id_setSizeMultiplier_F = JNIEnv.GetMethodID(this.class_ref, "setSizeMultiplier", "(F)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setSizeMultiplier_F, ptr);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003CB38 File Offset: 0x0003AD38
		private static Delegate GetTrimMemory_IHandler()
		{
			if (IBitmapPoolInvoker.cb_trimMemory_I == null)
			{
				IBitmapPoolInvoker.cb_trimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IBitmapPoolInvoker.n_TrimMemory_I));
			}
			return IBitmapPoolInvoker.cb_trimMemory_I;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0003CB5C File Offset: 0x0003AD5C
		private static void n_TrimMemory_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IBitmapPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrimMemory(p0);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0003CB6C File Offset: 0x0003AD6C
		public unsafe void TrimMemory(int p0)
		{
			if (this.id_trimMemory_I == IntPtr.Zero)
			{
				this.id_trimMemory_I = JNIEnv.GetMethodID(this.class_ref, "trimMemory", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_trimMemory_I, ptr);
		}

		// Token: 0x0400046E RID: 1134
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/BitmapPool", typeof(IBitmapPoolInvoker));

		// Token: 0x0400046F RID: 1135
		private IntPtr class_ref;

		// Token: 0x04000470 RID: 1136
		private static Delegate cb_getMaxSize;

		// Token: 0x04000471 RID: 1137
		private IntPtr id_getMaxSize;

		// Token: 0x04000472 RID: 1138
		private static Delegate cb_clearMemory;

		// Token: 0x04000473 RID: 1139
		private IntPtr id_clearMemory;

		// Token: 0x04000474 RID: 1140
		private static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000475 RID: 1141
		private IntPtr id_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000476 RID: 1142
		private static Delegate cb_getDirty_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000477 RID: 1143
		private IntPtr id_getDirty_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000478 RID: 1144
		private static Delegate cb_put_Landroid_graphics_Bitmap_;

		// Token: 0x04000479 RID: 1145
		private IntPtr id_put_Landroid_graphics_Bitmap_;

		// Token: 0x0400047A RID: 1146
		private static Delegate cb_setSizeMultiplier_F;

		// Token: 0x0400047B RID: 1147
		private IntPtr id_setSizeMultiplier_F;

		// Token: 0x0400047C RID: 1148
		private static Delegate cb_trimMemory_I;

		// Token: 0x0400047D RID: 1149
		private IntPtr id_trimMemory_I;
	}
}
