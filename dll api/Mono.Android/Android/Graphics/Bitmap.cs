using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000212 RID: 530
	[Register("android/graphics/Bitmap", DoNotGenerateAcw = true)]
	public sealed class Bitmap : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00031C7B File Offset: 0x0002FE7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Bitmap._members;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00031C84 File Offset: 0x0002FE84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Bitmap._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Bitmap._members.ManagedPeerType;
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Bitmap(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		public int Height
		{
			get
			{
				return Bitmap._members.InstanceMethods.InvokeAbstractInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00031CCD File Offset: 0x0002FECD
		public int Width
		{
			get
			{
				return Bitmap._members.InstanceMethods.InvokeAbstractInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00031CE8 File Offset: 0x0002FEE8
		public unsafe bool Compress(Bitmap.CompressFormat format, int quality, Stream stream)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(stream);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				ptr[1] = new JniArgumentValue(quality);
				ptr[2] = new JniArgumentValue(intPtr);
				result = Bitmap._members.InstanceMethods.InvokeAbstractBooleanMethod("compress.(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(format);
				GC.KeepAlive(stream);
			}
			return result;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00031D8C File Offset: 0x0002FF8C
		public Task<bool> CompressAsync(Bitmap.CompressFormat format, int quality, Stream stream)
		{
			return Task.Run<bool>(() => this.Compress(format, quality, stream));
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		public unsafe static Bitmap CreateScaledBitmap(Bitmap src, int dstWidth, int dstHeight, bool filter)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((src == null) ? IntPtr.Zero : src.Handle);
				ptr[1] = new JniArgumentValue(dstWidth);
				ptr[2] = new JniArgumentValue(dstHeight);
				ptr[3] = new JniArgumentValue(filter);
				@object = Java.Lang.Object.GetObject<Bitmap>(Bitmap._members.StaticMethods.InvokeObjectMethod("createScaledBitmap.(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(src);
			}
			return @object;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00031E74 File Offset: 0x00030074
		public int DescribeContents()
		{
			return Bitmap._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00031E90 File Offset: 0x00030090
		public unsafe void WriteToParcel(Parcel p, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Bitmap._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p);
			}
		}

		// Token: 0x04000883 RID: 2179
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Bitmap", typeof(Bitmap));

		// Token: 0x02000213 RID: 531
		[Register("android/graphics/Bitmap$CompressFormat", DoNotGenerateAcw = true)]
		public sealed class CompressFormat : Java.Lang.Enum
		{
			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06001311 RID: 4881 RVA: 0x00031F24 File Offset: 0x00030124
			[Register("JPEG")]
			public static Bitmap.CompressFormat Jpeg
			{
				get
				{
					return Java.Lang.Object.GetObject<Bitmap.CompressFormat>(Bitmap.CompressFormat._members.StaticFields.GetObjectValue("JPEG.Landroid/graphics/Bitmap$CompressFormat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06001312 RID: 4882 RVA: 0x00031F54 File Offset: 0x00030154
			[Register("PNG")]
			public static Bitmap.CompressFormat Png
			{
				get
				{
					return Java.Lang.Object.GetObject<Bitmap.CompressFormat>(Bitmap.CompressFormat._members.StaticFields.GetObjectValue("PNG.Landroid/graphics/Bitmap$CompressFormat;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06001313 RID: 4883 RVA: 0x00031F83 File Offset: 0x00030183
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Bitmap.CompressFormat._members;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06001314 RID: 4884 RVA: 0x00031F8C File Offset: 0x0003018C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Bitmap.CompressFormat._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06001315 RID: 4885 RVA: 0x00031FB0 File Offset: 0x000301B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Bitmap.CompressFormat._members.ManagedPeerType;
				}
			}

			// Token: 0x06001316 RID: 4886 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal CompressFormat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000884 RID: 2180
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Bitmap$CompressFormat", typeof(Bitmap.CompressFormat));
		}

		// Token: 0x02000214 RID: 532
		[Register("android/graphics/Bitmap$Config", DoNotGenerateAcw = true)]
		public sealed class Config : Java.Lang.Enum
		{
			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06001318 RID: 4888 RVA: 0x00031FD7 File Offset: 0x000301D7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Bitmap.Config._members;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06001319 RID: 4889 RVA: 0x00031FE0 File Offset: 0x000301E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Bitmap.Config._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x0600131A RID: 4890 RVA: 0x00032004 File Offset: 0x00030204
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Bitmap.Config._members.ManagedPeerType;
				}
			}

			// Token: 0x0600131B RID: 4891 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal Config(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000885 RID: 2181
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Bitmap$Config", typeof(Bitmap.Config));
		}
	}
}
