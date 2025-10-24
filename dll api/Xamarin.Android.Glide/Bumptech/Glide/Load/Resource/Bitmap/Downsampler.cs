using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x0200010A RID: 266
	[Register("com/bumptech/glide/load/resource/bitmap/Downsampler", DoNotGenerateAcw = true)]
	public sealed class Downsampler : Java.Lang.Object
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0002A0C0 File Offset: 0x000282C0
		[Register("ALLOW_HARDWARE_CONFIG")]
		public static Option AllowHardwareConfig
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(Downsampler._members.StaticFields.GetObjectValue("ALLOW_HARDWARE_CONFIG.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Register("DECODE_FORMAT")]
		public static Option DecodeFormat
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(Downsampler._members.StaticFields.GetObjectValue("DECODE_FORMAT.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0002A120 File Offset: 0x00028320
		[Register("DOWNSAMPLE_STRATEGY")]
		[Obsolete("deprecated")]
		public static Option DownsampleStrategy
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(Downsampler._members.StaticFields.GetObjectValue("DOWNSAMPLE_STRATEGY.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0002A150 File Offset: 0x00028350
		[Register("FIX_BITMAP_SIZE_TO_REQUESTED_DIMENSIONS")]
		public static Option FixBitmapSizeToRequestedDimensions
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(Downsampler._members.StaticFields.GetObjectValue("FIX_BITMAP_SIZE_TO_REQUESTED_DIMENSIONS.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x0002A180 File Offset: 0x00028380
		[Register("PREFERRED_COLOR_SPACE")]
		public static Option PreferredColorSpace
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(Downsampler._members.StaticFields.GetObjectValue("PREFERRED_COLOR_SPACE.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0002A1B0 File Offset: 0x000283B0
		internal static IntPtr class_ref
		{
			get
			{
				return Downsampler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0002A1D4 File Offset: 0x000283D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Downsampler._members;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0002A1DC File Offset: 0x000283DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Downsampler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002A200 File Offset: 0x00028400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Downsampler._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0002A20C File Offset: 0x0002840C
		internal Downsampler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0002A218 File Offset: 0x00028418
		[Register(".ctor", "(Ljava/util/List;Landroid/util/DisplayMetrics;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe Downsampler(IList<IImageHeaderParser> parsers, DisplayMetrics displayMetrics, IBitmapPool bitmapPool, IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(parsers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((displayMetrics == null) ? IntPtr.Zero : displayMetrics.Handle);
				ptr[2] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[3] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(Downsampler._members.InstanceMethods.StartCreateInstance("(Ljava/util/List;Landroid/util/DisplayMetrics;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Downsampler._members.InstanceMethods.FinishCreateInstance("(Ljava/util/List;Landroid/util/DisplayMetrics;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parsers);
				GC.KeepAlive(displayMetrics);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0002A350 File Offset: 0x00028550
		[Register("decode", "(Landroid/os/ParcelFileDescriptor;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(ParcelFileDescriptor parcelFileDescriptor, int outWidth, int outHeight, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcelFileDescriptor == null) ? IntPtr.Zero : parcelFileDescriptor.Handle);
				ptr[1] = new JniArgumentValue(outWidth);
				ptr[2] = new JniArgumentValue(outHeight);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(Downsampler._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Landroid/os/ParcelFileDescriptor;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parcelFileDescriptor);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0002A41C File Offset: 0x0002861C
		[Register("decode", "(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(Stream @is, int outWidth, int outHeight, Options options)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(outWidth);
				ptr[2] = new JniArgumentValue(outHeight);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(Downsampler._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0002A4E4 File Offset: 0x000286E4
		[Register("decode", "(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;Lcom/bumptech/glide/load/resource/bitmap/Downsampler$DecodeCallbacks;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(Stream @is, int requestedWidth, int requestedHeight, Options options, Downsampler.IDecodeCallbacks callbacks)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(requestedWidth);
				ptr[2] = new JniArgumentValue(requestedHeight);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[4] = new JniArgumentValue((callbacks == null) ? IntPtr.Zero : ((Java.Lang.Object)callbacks).Handle);
				@object = Java.Lang.Object.GetObject<IResource>(Downsampler._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Ljava/io/InputStream;IILcom/bumptech/glide/load/Options;Lcom/bumptech/glide/load/resource/bitmap/Downsampler$DecodeCallbacks;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(options);
				GC.KeepAlive(callbacks);
			}
			return @object;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0002A5E0 File Offset: 0x000287E0
		[Register("decode", "(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Decode(ByteBuffer buffer, int requestedWidth, int requestedHeight, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				ptr[1] = new JniArgumentValue(requestedWidth);
				ptr[2] = new JniArgumentValue(requestedHeight);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(Downsampler._members.InstanceMethods.InvokeAbstractObjectMethod("decode.(Ljava/nio/ByteBuffer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(buffer);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002A6AC File Offset: 0x000288AC
		[Register("handles", "(Landroid/os/ParcelFileDescriptor;)Z", "")]
		public unsafe bool Handles(ParcelFileDescriptor source)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				result = Downsampler._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/os/ParcelFileDescriptor;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
			}
			return result;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0002A714 File Offset: 0x00028914
		[Register("handles", "(Ljava/io/InputStream;)Z", "")]
		public unsafe bool Handles(Stream @is)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Downsampler._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/io/InputStream;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
			}
			return result;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0002A778 File Offset: 0x00028978
		[Register("handles", "(Ljava/nio/ByteBuffer;)Z", "")]
		public unsafe bool Handles(ByteBuffer byteBuffer)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((byteBuffer == null) ? IntPtr.Zero : byteBuffer.Handle);
				result = Downsampler._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/nio/ByteBuffer;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(byteBuffer);
			}
			return result;
		}

		// Token: 0x0400032A RID: 810
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/Downsampler", typeof(Downsampler));

		// Token: 0x020001C9 RID: 457
		[Register("com/bumptech/glide/load/resource/bitmap/Downsampler$DecodeCallbacks", "", "Bumptech.Glide.Load.Resource.Bitmap.Downsampler/IDecodeCallbacksInvoker")]
		public interface IDecodeCallbacks : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060015F0 RID: 5616
			[Register("onDecodeComplete", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V", "GetOnDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_Handler:Bumptech.Glide.Load.Resource.Bitmap.Downsampler/IDecodeCallbacksInvoker, Xamarin.Android.Glide")]
			void OnDecodeComplete(IBitmapPool p0, Bitmap p1);

			// Token: 0x060015F1 RID: 5617
			[Register("onObtainBounds", "()V", "GetOnObtainBoundsHandler:Bumptech.Glide.Load.Resource.Bitmap.Downsampler/IDecodeCallbacksInvoker, Xamarin.Android.Glide")]
			void OnObtainBounds();
		}

		// Token: 0x020001CA RID: 458
		[Register("com/bumptech/glide/load/resource/bitmap/Downsampler$DecodeCallbacks", DoNotGenerateAcw = true)]
		internal class IDecodeCallbacksInvoker : Java.Lang.Object, Downsampler.IDecodeCallbacks, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00044D64 File Offset: 0x00042F64
			private static IntPtr java_class_ref
			{
				get
				{
					return Downsampler.IDecodeCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00044D88 File Offset: 0x00042F88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Downsampler.IDecodeCallbacksInvoker._members;
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00044D8F File Offset: 0x00042F8F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060015F5 RID: 5621 RVA: 0x00044D97 File Offset: 0x00042F97
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Downsampler.IDecodeCallbacksInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060015F6 RID: 5622 RVA: 0x00044DA3 File Offset: 0x00042FA3
			public static Downsampler.IDecodeCallbacks GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Downsampler.IDecodeCallbacks>(handle, transfer);
			}

			// Token: 0x060015F7 RID: 5623 RVA: 0x00044DAC File Offset: 0x00042FAC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Downsampler.IDecodeCallbacksInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.resource.bitmap.Downsampler.DecodeCallbacks'.");
				}
				return handle;
			}

			// Token: 0x060015F8 RID: 5624 RVA: 0x00044DD7 File Offset: 0x00042FD7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060015F9 RID: 5625 RVA: 0x00044E08 File Offset: 0x00043008
			public IDecodeCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Downsampler.IDecodeCallbacksInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060015FA RID: 5626 RVA: 0x00044E40 File Offset: 0x00043040
			private static Delegate GetOnDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_Handler()
			{
				if (Downsampler.IDecodeCallbacksInvoker.cb_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ == null)
				{
					Downsampler.IDecodeCallbacksInvoker.cb_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Downsampler.IDecodeCallbacksInvoker.n_OnDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_));
				}
				return Downsampler.IDecodeCallbacksInvoker.cb_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_;
			}

			// Token: 0x060015FB RID: 5627 RVA: 0x00044E64 File Offset: 0x00043064
			private static void n_OnDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				Downsampler.IDecodeCallbacks @object = Java.Lang.Object.GetObject<Downsampler.IDecodeCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IBitmapPool object2 = Java.Lang.Object.GetObject<IBitmapPool>(native_p0, JniHandleOwnership.DoNotTransfer);
				Bitmap object3 = Java.Lang.Object.GetObject<Bitmap>(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.OnDecodeComplete(object2, object3);
			}

			// Token: 0x060015FC RID: 5628 RVA: 0x00044E90 File Offset: 0x00043090
			public unsafe void OnDecodeComplete(IBitmapPool p0, Bitmap p1)
			{
				if (this.id_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				{
					this.id_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID(this.class_ref, "onDecodeComplete", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Landroid/graphics/Bitmap;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_, ptr);
			}

			// Token: 0x060015FD RID: 5629 RVA: 0x00044F2A File Offset: 0x0004312A
			private static Delegate GetOnObtainBoundsHandler()
			{
				if (Downsampler.IDecodeCallbacksInvoker.cb_onObtainBounds == null)
				{
					Downsampler.IDecodeCallbacksInvoker.cb_onObtainBounds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Downsampler.IDecodeCallbacksInvoker.n_OnObtainBounds));
				}
				return Downsampler.IDecodeCallbacksInvoker.cb_onObtainBounds;
			}

			// Token: 0x060015FE RID: 5630 RVA: 0x00044F4E File Offset: 0x0004314E
			private static void n_OnObtainBounds(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Downsampler.IDecodeCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnObtainBounds();
			}

			// Token: 0x060015FF RID: 5631 RVA: 0x00044F5D File Offset: 0x0004315D
			public void OnObtainBounds()
			{
				if (this.id_onObtainBounds == IntPtr.Zero)
				{
					this.id_onObtainBounds = JNIEnv.GetMethodID(this.class_ref, "onObtainBounds", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onObtainBounds);
			}

			// Token: 0x04000541 RID: 1345
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/Downsampler$DecodeCallbacks", typeof(Downsampler.IDecodeCallbacksInvoker));

			// Token: 0x04000542 RID: 1346
			private IntPtr class_ref;

			// Token: 0x04000543 RID: 1347
			private static Delegate cb_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_;

			// Token: 0x04000544 RID: 1348
			private IntPtr id_onDecodeComplete_Lcom_bumptech_glide_load_engine_bitmap_recycle_BitmapPool_Landroid_graphics_Bitmap_;

			// Token: 0x04000545 RID: 1349
			private static Delegate cb_onObtainBounds;

			// Token: 0x04000546 RID: 1350
			private IntPtr id_onObtainBounds;
		}
	}
}
