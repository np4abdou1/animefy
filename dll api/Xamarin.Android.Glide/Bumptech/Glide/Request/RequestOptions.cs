using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Resource.Bitmap;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000085 RID: 133
	[Register("com/bumptech/glide/request/RequestOptions", DoNotGenerateAcw = true)]
	public class RequestOptions : BaseRequestOptions
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x00012847 File Offset: 0x00010A47
		public virtual RequestOptions Apply(BaseRequestOptions o)
		{
			return (RequestOptions)this.Apply_T(o);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00012855 File Offset: 0x00010A55
		public virtual RequestOptions AutoClone()
		{
			return (RequestOptions)this.AutoClone_T();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00012862 File Offset: 0x00010A62
		public virtual RequestOptions CenterCrop()
		{
			return (RequestOptions)this.CenterCrop_T();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001286F File Offset: 0x00010A6F
		public virtual RequestOptions CenterInside()
		{
			return (RequestOptions)this.CenterInside_T();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001287C File Offset: 0x00010A7C
		public virtual RequestOptions CircleCrop()
		{
			return (RequestOptions)this.CircleCrop_T();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00012889 File Offset: 0x00010A89
		public virtual RequestOptions Clone()
		{
			return (RequestOptions)this.Clone_T();
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00012896 File Offset: 0x00010A96
		public virtual RequestOptions Decode(Class resourceClass)
		{
			return (RequestOptions)this.Decode_T(resourceClass);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000128A4 File Offset: 0x00010AA4
		public virtual RequestOptions DisallowHardwareConfig()
		{
			return (RequestOptions)this.DisallowHardwareConfig_T();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000128B1 File Offset: 0x00010AB1
		public virtual RequestOptions DontAnimate()
		{
			return (RequestOptions)this.DontAnimate_T();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000128BE File Offset: 0x00010ABE
		public virtual RequestOptions DontTransform()
		{
			return (RequestOptions)this.DontTransform_T();
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000128CB File Offset: 0x00010ACB
		public virtual RequestOptions Downsample(DownsampleStrategy strategy)
		{
			return (RequestOptions)this.Downsample_T(strategy);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000128D9 File Offset: 0x00010AD9
		public virtual RequestOptions EncodeFormat(Bitmap.CompressFormat format)
		{
			return (RequestOptions)this.EncodeFormat_T(format);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000128E7 File Offset: 0x00010AE7
		public virtual RequestOptions EncodeQuality(int quality)
		{
			return (RequestOptions)this.EncodeQuality_T(quality);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000128F5 File Offset: 0x00010AF5
		public virtual RequestBuilder Error(Drawable drawable)
		{
			return (RequestBuilder)this.Error_T(drawable);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00012903 File Offset: 0x00010B03
		public virtual RequestOptions Error(int resourceId)
		{
			return (RequestOptions)this.Error_T(resourceId);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00012911 File Offset: 0x00010B11
		public virtual RequestOptions Fallback(Drawable drawable)
		{
			return (RequestOptions)this.Fallback_T(drawable);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0001291F File Offset: 0x00010B1F
		public virtual RequestOptions Fallback(int resourceId)
		{
			return (RequestOptions)this.Fallback_T(resourceId);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001292D File Offset: 0x00010B2D
		public virtual RequestOptions FitCenter()
		{
			return (RequestOptions)this.FitCenter_T();
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001293A File Offset: 0x00010B3A
		public virtual RequestOptions Format(DecodeFormat format)
		{
			return (RequestOptions)this.Format_T(format);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00012948 File Offset: 0x00010B48
		public virtual RequestOptions Frame(long frameTimeMicros)
		{
			return (RequestOptions)this.Frame_T(frameTimeMicros);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00012956 File Offset: 0x00010B56
		public virtual RequestOptions Lock()
		{
			return (RequestOptions)this.Lock_T();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00012963 File Offset: 0x00010B63
		public virtual RequestOptions OptionalCenterCrop()
		{
			return (RequestOptions)this.OptionalCenterCrop_T();
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00012970 File Offset: 0x00010B70
		public virtual RequestOptions OptionalCenterInside()
		{
			return (RequestOptions)this.OptionalCenterInside_T();
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001297D File Offset: 0x00010B7D
		public virtual RequestOptions OptionalCircleCrop()
		{
			return (RequestOptions)this.OptionalCircleCrop_T();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001298A File Offset: 0x00010B8A
		public virtual RequestOptions OptionalFitCenter()
		{
			return (RequestOptions)this.OptionalFitCenter_T();
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00012997 File Offset: 0x00010B97
		public virtual RequestOptions OptionalTransform(Class resourceClass, ITransformation transformation)
		{
			return (RequestOptions)this.OptionalTransform_T(resourceClass, transformation);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000129A6 File Offset: 0x00010BA6
		public virtual RequestOptions OptionalTransform(ITransformation transformation)
		{
			return (RequestOptions)this.OptionalTransform_T(transformation);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000129B4 File Offset: 0x00010BB4
		public virtual RequestOptions Override(int width, int height)
		{
			return (RequestOptions)this.Override_T(width, height);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000129C3 File Offset: 0x00010BC3
		public virtual RequestOptions Override(int size)
		{
			return (RequestOptions)this.Override_T(size);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000129D1 File Offset: 0x00010BD1
		public virtual RequestOptions Placeholder(Drawable drawable)
		{
			return (RequestOptions)this.Placeholder_T(drawable);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000129DF File Offset: 0x00010BDF
		public virtual RequestOptions Placeholder(int resourceId)
		{
			return (RequestOptions)this.Placeholder_T(resourceId);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000129ED File Offset: 0x00010BED
		public virtual RequestOptions Set(Option option, Java.Lang.Object value)
		{
			return (RequestOptions)this.Set_T(option, value);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000129FC File Offset: 0x00010BFC
		public virtual RequestOptions SetDiskCacheStrategy(DiskCacheStrategy strategy)
		{
			return (RequestOptions)this.DiskCacheStrategy_T(strategy);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00012A0A File Offset: 0x00010C0A
		public virtual RequestOptions SetOnlyRetrieveFromCache(bool flag)
		{
			return (RequestOptions)this.OnlyRetrieveFromCache_T(flag);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00012A18 File Offset: 0x00010C18
		public virtual RequestOptions SetPriority(Priority priority)
		{
			return (RequestOptions)this.Priority_T(priority);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00012A26 File Offset: 0x00010C26
		public virtual RequestOptions SetSignature(IKey signature)
		{
			return (RequestOptions)this.Signature_T(signature);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00012A34 File Offset: 0x00010C34
		public virtual RequestOptions SetSizeMultiplier(float sizeMultiplier)
		{
			return (RequestOptions)this.SizeMultiplier_T(sizeMultiplier);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00012A42 File Offset: 0x00010C42
		public virtual RequestOptions SetTheme(Resources.Theme theme)
		{
			return (RequestOptions)this.Theme_T(theme);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00012A50 File Offset: 0x00010C50
		public virtual RequestOptions SetUseAnimationPool(bool flag)
		{
			return (RequestOptions)this.UseAnimationPool_T(flag);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00012A5E File Offset: 0x00010C5E
		public virtual RequestOptions SetUseUnlimitedSourceGeneratorsPool(bool flag)
		{
			return (RequestOptions)this.UseUnlimitedSourceGeneratorsPool_T(flag);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00012A6C File Offset: 0x00010C6C
		public virtual RequestOptions SkipMemoryCache(bool skip)
		{
			return (RequestOptions)this.SkipMemoryCache_T(skip);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00012A7A File Offset: 0x00010C7A
		public virtual RequestOptions Timeout(int timeoutMs)
		{
			return (RequestOptions)this.Timeout_T(timeoutMs);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00012A88 File Offset: 0x00010C88
		public virtual RequestOptions Transform(Class resourceClass, ITransformation transformation)
		{
			return (RequestOptions)this.Transform_T(resourceClass, transformation);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00012A97 File Offset: 0x00010C97
		public virtual RequestOptions Transform(params ITransformation[] transformations)
		{
			return (RequestOptions)this.Transform_T(transformations);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00012AA5 File Offset: 0x00010CA5
		public virtual RequestOptions Transform(ITransformation transformation)
		{
			return (RequestOptions)this.Transform_T(transformation);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00012AB4 File Offset: 0x00010CB4
		internal new static IntPtr class_ref
		{
			get
			{
				return RequestOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00012AD8 File Offset: 0x00010CD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestOptions._members;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00012B04 File Offset: 0x00010D04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00012B10 File Offset: 0x00010D10
		protected RequestOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00012B1C File Offset: 0x00010D1C
		[Register(".ctor", "()V", "")]
		public RequestOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(RequestOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			RequestOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00012B8C File Offset: 0x00010D8C
		[Register("bitmapTransform", "(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions BitmapTransform(ITransformation transformation)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transformation == null) ? IntPtr.Zero : ((Java.Lang.Object)transformation).Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("bitmapTransform.(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transformation);
			}
			return @object;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00012C04 File Offset: 0x00010E04
		[Register("centerCropTransform", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions CenterCropTransform()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("centerCropTransform.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00012C38 File Offset: 0x00010E38
		[Register("centerInsideTransform", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions CenterInsideTransform()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("centerInsideTransform.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00012C6C File Offset: 0x00010E6C
		[Register("circleCropTransform", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions CircleCropTransform()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("circleCropTransform.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00012CA0 File Offset: 0x00010EA0
		[Register("decodeTypeOf", "(Ljava/lang/Class;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions DecodeTypeOf(Class resourceClass)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("decodeTypeOf.(Ljava/lang/Class;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
			}
			return @object;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00012D14 File Offset: 0x00010F14
		[Register("diskCacheStrategyOf", "(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions DiskCacheStrategyOf(DiskCacheStrategy diskCacheStrategy)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((diskCacheStrategy == null) ? IntPtr.Zero : diskCacheStrategy.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("diskCacheStrategyOf.(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(diskCacheStrategy);
			}
			return @object;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00012D88 File Offset: 0x00010F88
		[Register("downsampleOf", "(Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions DownsampleOf(DownsampleStrategy strategy)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((strategy == null) ? IntPtr.Zero : strategy.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("downsampleOf.(Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(strategy);
			}
			return @object;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00012DFC File Offset: 0x00010FFC
		[Register("encodeFormatOf", "(Landroid/graphics/Bitmap$CompressFormat;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions EncodeFormatOf(Bitmap.CompressFormat format)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("encodeFormatOf.(Landroid/graphics/Bitmap$CompressFormat;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @object;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00012E70 File Offset: 0x00011070
		[Register("encodeQualityOf", "(I)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions EncodeQualityOf(int quality)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(quality);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("encodeQualityOf.(I)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Register("errorOf", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions ErrorOf(Drawable errorDrawable)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorDrawable == null) ? IntPtr.Zero : errorDrawable.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("errorOf.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(errorDrawable);
			}
			return @object;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00012F2C File Offset: 0x0001112C
		[Register("errorOf", "(I)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions ErrorOf(int errorId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(errorId);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("errorOf.(I)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00012F74 File Offset: 0x00011174
		[Register("fitCenterTransform", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions FitCenterTransform()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("fitCenterTransform.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Register("formatOf", "(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions FormatOf(DecodeFormat format)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("formatOf.(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @object;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001301C File Offset: 0x0001121C
		[Register("frameOf", "(J)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions FrameOf(long frameTimeMicros)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(frameTimeMicros);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("frameOf.(J)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00013064 File Offset: 0x00011264
		[Register("noAnimation", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions NoAnimation()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("noAnimation.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00013098 File Offset: 0x00011298
		[Register("noTransformation", "()Lcom/bumptech/glide/request/RequestOptions;", "")]
		public static RequestOptions NoTransformation()
		{
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("noTransformation.()Lcom/bumptech/glide/request/RequestOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000130CC File Offset: 0x000112CC
		[Register("option", "(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static RequestOptions Option(Option option, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("option.(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(option);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00013164 File Offset: 0x00011364
		[Register("overrideOf", "(I)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions OverrideOf(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("overrideOf.(I)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000131AC File Offset: 0x000113AC
		[Register("overrideOf", "(II)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions OverrideOf(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("overrideOf.(II)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00013208 File Offset: 0x00011408
		[Register("placeholderOf", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions PlaceholderOf(Drawable placeholder)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((placeholder == null) ? IntPtr.Zero : placeholder.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("placeholderOf.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(placeholder);
			}
			return @object;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001327C File Offset: 0x0001147C
		[Register("placeholderOf", "(I)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions PlaceholderOf(int placeholderId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(placeholderId);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("placeholderOf.(I)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000132C4 File Offset: 0x000114C4
		[Register("priorityOf", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions PriorityOf(Priority priority)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("priorityOf.(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return @object;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00013338 File Offset: 0x00011538
		[Register("signatureOf", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions SignatureOf(IKey signature)
		{
			RequestOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((signature == null) ? IntPtr.Zero : ((Java.Lang.Object)signature).Handle);
				@object = Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("signatureOf.(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(signature);
			}
			return @object;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000133B0 File Offset: 0x000115B0
		[Register("sizeMultiplierOf", "(F)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions SizeMultiplierOf(float sizeMultiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sizeMultiplier);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("sizeMultiplierOf.(F)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000133F8 File Offset: 0x000115F8
		[Register("skipMemoryCacheOf", "(Z)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions SkipMemoryCacheOf(bool skipMemoryCache)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(skipMemoryCache);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("skipMemoryCacheOf.(Z)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00013440 File Offset: 0x00011640
		[Register("timeoutOf", "(I)Lcom/bumptech/glide/request/RequestOptions;", "")]
		public unsafe static RequestOptions TimeoutOf(int timeout)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(timeout);
			return Java.Lang.Object.GetObject<RequestOptions>(RequestOptions._members.StaticMethods.InvokeObjectMethod("timeoutOf.(I)Lcom/bumptech/glide/request/RequestOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400014F RID: 335
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/RequestOptions", typeof(RequestOptions));
	}
}
