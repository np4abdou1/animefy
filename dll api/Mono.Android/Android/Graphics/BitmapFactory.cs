using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000216 RID: 534
	[Register("android/graphics/BitmapFactory", DoNotGenerateAcw = true)]
	public class BitmapFactory : Java.Lang.Object
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0003204A File Offset: 0x0003024A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapFactory._members;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00032054 File Offset: 0x00030254
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00032078 File Offset: 0x00030278
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000021E0 File Offset: 0x000003E0
		protected BitmapFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00032084 File Offset: 0x00030284
		public unsafe static Bitmap DecodeByteArray(byte[] data, int offset, int length)
		{
			IntPtr intPtr = JNIEnv.NewArray(data);
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(offset);
				ptr[2] = new JniArgumentValue(length);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapFactory._members.StaticMethods.InvokeObjectMethod("decodeByteArray.([BII)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (data != null)
				{
					JNIEnv.CopyArray(intPtr, data);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(data);
			}
			return @object;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00032128 File Offset: 0x00030328
		public static Task<Bitmap> DecodeByteArrayAsync(byte[] data, int offset, int length)
		{
			return Task.Run<Bitmap>(() => BitmapFactory.DecodeByteArray(data, offset, length));
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00032154 File Offset: 0x00030354
		public unsafe static Bitmap DecodeStream(Stream @is)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapFactory._members.StaticMethods.InvokeObjectMethod("decodeStream.(Ljava/io/InputStream;)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
			}
			return @object;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000321C4 File Offset: 0x000303C4
		public unsafe static Bitmap DecodeStream(Stream @is, Rect outPadding, BitmapFactory.Options opts)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((outPadding == null) ? IntPtr.Zero : outPadding.Handle);
				ptr[2] = new JniArgumentValue((opts == null) ? IntPtr.Zero : opts.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(BitmapFactory._members.StaticMethods.InvokeObjectMethod("decodeStream.(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
				GC.KeepAlive(outPadding);
				GC.KeepAlive(opts);
			}
			return @object;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00032288 File Offset: 0x00030488
		public static Task<Bitmap> DecodeStreamAsync(Stream @is, Rect outPadding, BitmapFactory.Options opts)
		{
			return Task.Run<Bitmap>(() => BitmapFactory.DecodeStream(@is, outPadding, opts));
		}

		// Token: 0x0400088A RID: 2186
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/BitmapFactory", typeof(BitmapFactory));

		// Token: 0x02000217 RID: 535
		[Register("android/graphics/BitmapFactory$Options", DoNotGenerateAcw = true)]
		public class Options : Java.Lang.Object
		{
			// Token: 0x17000409 RID: 1033
			// (set) Token: 0x06001329 RID: 4905 RVA: 0x000322CF File Offset: 0x000304CF
			[Register("inJustDecodeBounds")]
			public bool InJustDecodeBounds
			{
				set
				{
					BitmapFactory.Options._members.InstanceFields.SetValue("inJustDecodeBounds.Z", this, value);
				}
			}

			// Token: 0x1700040A RID: 1034
			// (set) Token: 0x0600132A RID: 4906 RVA: 0x000322E7 File Offset: 0x000304E7
			[Register("inSampleSize")]
			public int InSampleSize
			{
				set
				{
					BitmapFactory.Options._members.InstanceFields.SetValue("inSampleSize.I", this, value);
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x0600132B RID: 4907 RVA: 0x000322FF File Offset: 0x000304FF
			[Register("outHeight")]
			public int OutHeight
			{
				get
				{
					return BitmapFactory.Options._members.InstanceFields.GetInt32Value("outHeight.I", this);
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x0600132C RID: 4908 RVA: 0x00032316 File Offset: 0x00030516
			[Register("outWidth")]
			public int OutWidth
			{
				get
				{
					return BitmapFactory.Options._members.InstanceFields.GetInt32Value("outWidth.I", this);
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x0600132D RID: 4909 RVA: 0x0003232D File Offset: 0x0003052D
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BitmapFactory.Options._members;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x0600132E RID: 4910 RVA: 0x00032334 File Offset: 0x00030534
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BitmapFactory.Options._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x0600132F RID: 4911 RVA: 0x00032358 File Offset: 0x00030558
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BitmapFactory.Options._members.ManagedPeerType;
				}
			}

			// Token: 0x06001330 RID: 4912 RVA: 0x000021E0 File Offset: 0x000003E0
			protected Options(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001331 RID: 4913 RVA: 0x00032364 File Offset: 0x00030564
			[Register(".ctor", "()V", "")]
			public Options() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BitmapFactory.Options._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapFactory.Options._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0400088B RID: 2187
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/BitmapFactory$Options", typeof(BitmapFactory.Options));
		}
	}
}
