using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000CD RID: 205
	[Register("com/bumptech/glide/load/ImageHeaderParser$ImageType", DoNotGenerateAcw = true)]
	public sealed class ImageHeaderParserImageType : Java.Lang.Enum
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[Register("ANIMATED_AVIF")]
		public static ImageHeaderParserImageType AnimatedAvif
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("ANIMATED_AVIF.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[Register("ANIMATED_WEBP")]
		public static ImageHeaderParserImageType AnimatedWebp
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("ANIMATED_WEBP.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00020E08 File Offset: 0x0001F008
		[Register("AVIF")]
		public static ImageHeaderParserImageType Avif
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("AVIF.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00020E38 File Offset: 0x0001F038
		[Register("GIF")]
		public static ImageHeaderParserImageType Gif
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("GIF.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00020E68 File Offset: 0x0001F068
		[Register("JPEG")]
		public static ImageHeaderParserImageType Jpeg
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("JPEG.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00020E98 File Offset: 0x0001F098
		[Register("PNG")]
		public static ImageHeaderParserImageType Png
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("PNG.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[Register("PNG_A")]
		public static ImageHeaderParserImageType PngA
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("PNG_A.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		[Register("RAW")]
		public static ImageHeaderParserImageType Raw
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("RAW.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00020F28 File Offset: 0x0001F128
		[Register("UNKNOWN")]
		public static ImageHeaderParserImageType Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00020F58 File Offset: 0x0001F158
		[Register("WEBP")]
		public static ImageHeaderParserImageType Webp
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("WEBP.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00020F88 File Offset: 0x0001F188
		[Register("WEBP_A")]
		public static ImageHeaderParserImageType WebpA
		{
			get
			{
				return Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticFields.GetObjectValue("WEBP_A.Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		internal static IntPtr class_ref
		{
			get
			{
				return ImageHeaderParserImageType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00020FDC File Offset: 0x0001F1DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageHeaderParserImageType._members;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00020FE4 File Offset: 0x0001F1E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageHeaderParserImageType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00021008 File Offset: 0x0001F208
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageHeaderParserImageType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00021014 File Offset: 0x0001F214
		internal ImageHeaderParserImageType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0002101E File Offset: 0x0001F21E
		public bool HasAlpha
		{
			[Register("hasAlpha", "()Z", "")]
			get
			{
				return ImageHeaderParserImageType._members.InstanceMethods.InvokeAbstractBooleanMethod("hasAlpha.()Z", this, null);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00021037 File Offset: 0x0001F237
		public bool IsWebp
		{
			[Register("isWebp", "()Z", "")]
			get
			{
				return ImageHeaderParserImageType._members.InstanceMethods.InvokeAbstractBooleanMethod("isWebp.()Z", this, null);
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00021050 File Offset: 0x0001F250
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public unsafe static ImageHeaderParserImageType ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ImageHeaderParserImageType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ImageHeaderParserImageType>(ImageHeaderParserImageType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000210BC File Offset: 0x0001F2BC
		[Register("values", "()[Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", "")]
		public static ImageHeaderParserImageType[] Values()
		{
			return (ImageHeaderParserImageType[])JNIEnv.GetArray(ImageHeaderParserImageType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/load/ImageHeaderParser$ImageType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ImageHeaderParserImageType));
		}

		// Token: 0x04000297 RID: 663
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/ImageHeaderParser$ImageType", typeof(ImageHeaderParserImageType));
	}
}
