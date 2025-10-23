using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x0200017E RID: 382
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/LruPoolStrategy", DoNotGenerateAcw = true)]
	internal class ILruPoolStrategyInvoker : Java.Lang.Object, ILruPoolStrategy, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0003CBEC File Offset: 0x0003ADEC
		private static IntPtr java_class_ref
		{
			get
			{
				return ILruPoolStrategyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0003CC10 File Offset: 0x0003AE10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILruPoolStrategyInvoker._members;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0003CC17 File Offset: 0x0003AE17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0003CC1F File Offset: 0x0003AE1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILruPoolStrategyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0003CC2B File Offset: 0x0003AE2B
		public static ILruPoolStrategy GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILruPoolStrategy>(handle, transfer);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003CC34 File Offset: 0x0003AE34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILruPoolStrategyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.bitmap_recycle.LruPoolStrategy'.");
			}
			return handle;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003CC5F File Offset: 0x0003AE5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0003CC90 File Offset: 0x0003AE90
		public ILruPoolStrategyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILruPoolStrategyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0003CCC8 File Offset: 0x0003AEC8
		private static Delegate GetGet_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (ILruPoolStrategyInvoker.cb_get_IILandroid_graphics_Bitmap_Config_ == null)
			{
				ILruPoolStrategyInvoker.cb_get_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(ILruPoolStrategyInvoker.n_Get_IILandroid_graphics_Bitmap_Config_));
			}
			return ILruPoolStrategyInvoker.cb_get_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0003CCEC File Offset: 0x0003AEEC
		private static IntPtr n_Get_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			ILruPoolStrategy @object = Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(p0, p1, object2));
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0003CD18 File Offset: 0x0003AF18
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

		// Token: 0x0600130B RID: 4875 RVA: 0x0003CDBA File Offset: 0x0003AFBA
		private static Delegate GetGetSize_Landroid_graphics_Bitmap_Handler()
		{
			if (ILruPoolStrategyInvoker.cb_getSize_Landroid_graphics_Bitmap_ == null)
			{
				ILruPoolStrategyInvoker.cb_getSize_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(ILruPoolStrategyInvoker.n_GetSize_Landroid_graphics_Bitmap_));
			}
			return ILruPoolStrategyInvoker.cb_getSize_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0003CDE0 File Offset: 0x0003AFE0
		private static int n_GetSize_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILruPoolStrategy @object = Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.GetSize(object2);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0003CE04 File Offset: 0x0003B004
		public unsafe int GetSize(Bitmap p0)
		{
			if (this.id_getSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
			{
				this.id_getSize_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(this.class_ref, "getSize", "(Landroid/graphics/Bitmap;)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getSize_Landroid_graphics_Bitmap_, ptr);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0003CE77 File Offset: 0x0003B077
		private static Delegate GetLogBitmap_Landroid_graphics_Bitmap_Handler()
		{
			if (ILruPoolStrategyInvoker.cb_logBitmap_Landroid_graphics_Bitmap_ == null)
			{
				ILruPoolStrategyInvoker.cb_logBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ILruPoolStrategyInvoker.n_LogBitmap_Landroid_graphics_Bitmap_));
			}
			return ILruPoolStrategyInvoker.cb_logBitmap_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0003CE9C File Offset: 0x0003B09C
		private static IntPtr n_LogBitmap_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILruPoolStrategy @object = Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.LogBitmap(object2));
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0003CEC4 File Offset: 0x0003B0C4
		public unsafe string LogBitmap(Bitmap p0)
		{
			if (this.id_logBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
			{
				this.id_logBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(this.class_ref, "logBitmap", "(Landroid/graphics/Bitmap;)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_logBitmap_Landroid_graphics_Bitmap_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0003CF3D File Offset: 0x0003B13D
		private static Delegate GetLogBitmap_IILandroid_graphics_Bitmap_Config_Handler()
		{
			if (ILruPoolStrategyInvoker.cb_logBitmap_IILandroid_graphics_Bitmap_Config_ == null)
			{
				ILruPoolStrategyInvoker.cb_logBitmap_IILandroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIL_L(ILruPoolStrategyInvoker.n_LogBitmap_IILandroid_graphics_Bitmap_Config_));
			}
			return ILruPoolStrategyInvoker.cb_logBitmap_IILandroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0003CF64 File Offset: 0x0003B164
		private static IntPtr n_LogBitmap_IILandroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			ILruPoolStrategy @object = Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p2, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.LogBitmap(p0, p1, object2));
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0003CF90 File Offset: 0x0003B190
		public unsafe string LogBitmap(int p0, int p1, Bitmap.Config p2)
		{
			if (this.id_logBitmap_IILandroid_graphics_Bitmap_Config_ == IntPtr.Zero)
			{
				this.id_logBitmap_IILandroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID(this.class_ref, "logBitmap", "(IILandroid/graphics/Bitmap$Config;)Ljava/lang/String;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_logBitmap_IILandroid_graphics_Bitmap_Config_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0003D032 File Offset: 0x0003B232
		private static Delegate GetPut_Landroid_graphics_Bitmap_Handler()
		{
			if (ILruPoolStrategyInvoker.cb_put_Landroid_graphics_Bitmap_ == null)
			{
				ILruPoolStrategyInvoker.cb_put_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILruPoolStrategyInvoker.n_Put_Landroid_graphics_Bitmap_));
			}
			return ILruPoolStrategyInvoker.cb_put_Landroid_graphics_Bitmap_;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003D058 File Offset: 0x0003B258
		private static void n_Put_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILruPoolStrategy @object = Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Put(object2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003D07C File Offset: 0x0003B27C
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

		// Token: 0x06001317 RID: 4887 RVA: 0x0003D0EF File Offset: 0x0003B2EF
		private static Delegate GetRemoveLastHandler()
		{
			if (ILruPoolStrategyInvoker.cb_removeLast == null)
			{
				ILruPoolStrategyInvoker.cb_removeLast = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ILruPoolStrategyInvoker.n_RemoveLast));
			}
			return ILruPoolStrategyInvoker.cb_removeLast;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003D113 File Offset: 0x0003B313
		private static IntPtr n_RemoveLast(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ILruPoolStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveLast());
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003D128 File Offset: 0x0003B328
		public Bitmap RemoveLast()
		{
			if (this.id_removeLast == IntPtr.Zero)
			{
				this.id_removeLast = JNIEnv.GetMethodID(this.class_ref, "removeLast", "()Landroid/graphics/Bitmap;");
			}
			return Java.Lang.Object.GetObject<Bitmap>(JNIEnv.CallObjectMethod(base.Handle, this.id_removeLast), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400047E RID: 1150
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/LruPoolStrategy", typeof(ILruPoolStrategyInvoker));

		// Token: 0x0400047F RID: 1151
		private IntPtr class_ref;

		// Token: 0x04000480 RID: 1152
		private static Delegate cb_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000481 RID: 1153
		private IntPtr id_get_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000482 RID: 1154
		private static Delegate cb_getSize_Landroid_graphics_Bitmap_;

		// Token: 0x04000483 RID: 1155
		private IntPtr id_getSize_Landroid_graphics_Bitmap_;

		// Token: 0x04000484 RID: 1156
		private static Delegate cb_logBitmap_Landroid_graphics_Bitmap_;

		// Token: 0x04000485 RID: 1157
		private IntPtr id_logBitmap_Landroid_graphics_Bitmap_;

		// Token: 0x04000486 RID: 1158
		private static Delegate cb_logBitmap_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000487 RID: 1159
		private IntPtr id_logBitmap_IILandroid_graphics_Bitmap_Config_;

		// Token: 0x04000488 RID: 1160
		private static Delegate cb_put_Landroid_graphics_Bitmap_;

		// Token: 0x04000489 RID: 1161
		private IntPtr id_put_Landroid_graphics_Bitmap_;

		// Token: 0x0400048A RID: 1162
		private static Delegate cb_removeLast;

		// Token: 0x0400048B RID: 1163
		private IntPtr id_removeLast;
	}
}
