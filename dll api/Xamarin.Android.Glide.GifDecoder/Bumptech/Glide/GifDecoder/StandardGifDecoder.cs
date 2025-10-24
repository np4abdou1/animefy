using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Nio;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x0200001C RID: 28
	[Register("com/bumptech/glide/gifdecoder/StandardGifDecoder", DoNotGenerateAcw = true)]
	public class StandardGifDecoder : Java.Lang.Object, IGifDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00003D8C File Offset: 0x00001F8C
		internal static IntPtr class_ref
		{
			get
			{
				return StandardGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StandardGifDecoder._members;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00003DB8 File Offset: 0x00001FB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StandardGifDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003DDC File Offset: 0x00001FDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StandardGifDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003DE8 File Offset: 0x00001FE8
		protected StandardGifDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Register(".ctor", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", "")]
		public unsafe StandardGifDecoder(IGifDecoderBitmapProvider provider) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				base.SetHandle(StandardGifDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StandardGifDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003EA8 File Offset: 0x000020A8
		[Register(".ctor", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe StandardGifDecoder(IGifDecoderBitmapProvider provider, GifHeader gifHeader, ByteBuffer rawData) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((gifHeader == null) ? IntPtr.Zero : gifHeader.Handle);
				ptr[2] = new JniArgumentValue((rawData == null) ? IntPtr.Zero : rawData.Handle);
				base.SetHandle(StandardGifDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StandardGifDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(gifHeader);
				GC.KeepAlive(rawData);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003FB0 File Offset: 0x000021B0
		[Register(".ctor", "(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", "")]
		public unsafe StandardGifDecoder(IGifDecoderBitmapProvider provider, GifHeader gifHeader, ByteBuffer rawData, int sampleSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((provider == null) ? IntPtr.Zero : ((Java.Lang.Object)provider).Handle);
				ptr[1] = new JniArgumentValue((gifHeader == null) ? IntPtr.Zero : gifHeader.Handle);
				ptr[2] = new JniArgumentValue((rawData == null) ? IntPtr.Zero : rawData.Handle);
				ptr[3] = new JniArgumentValue(sampleSize);
				base.SetHandle(StandardGifDecoder._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StandardGifDecoder._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/gifdecoder/GifDecoder$BitmapProvider;Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(provider);
				GC.KeepAlive(gifHeader);
				GC.KeepAlive(rawData);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000040CC File Offset: 0x000022CC
		private static Delegate GetGetByteSizeHandler()
		{
			if (StandardGifDecoder.cb_getByteSize == null)
			{
				StandardGifDecoder.cb_getByteSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetByteSize));
			}
			return StandardGifDecoder.cb_getByteSize;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000040F0 File Offset: 0x000022F0
		private static int n_GetByteSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ByteSize;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000040FF File Offset: 0x000022FF
		public virtual int ByteSize
		{
			[Register("getByteSize", "()I", "GetGetByteSizeHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getByteSize.()I", this, null);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004118 File Offset: 0x00002318
		private static Delegate GetGetCurrentFrameIndexHandler()
		{
			if (StandardGifDecoder.cb_getCurrentFrameIndex == null)
			{
				StandardGifDecoder.cb_getCurrentFrameIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetCurrentFrameIndex));
			}
			return StandardGifDecoder.cb_getCurrentFrameIndex;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000413C File Offset: 0x0000233C
		private static int n_GetCurrentFrameIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentFrameIndex;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000414B File Offset: 0x0000234B
		public virtual int CurrentFrameIndex
		{
			[Register("getCurrentFrameIndex", "()I", "GetGetCurrentFrameIndexHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentFrameIndex.()I", this, null);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004164 File Offset: 0x00002364
		private static Delegate GetGetDataHandler()
		{
			if (StandardGifDecoder.cb_getData == null)
			{
				StandardGifDecoder.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(StandardGifDecoder.n_GetData));
			}
			return StandardGifDecoder.cb_getData;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004188 File Offset: 0x00002388
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000419C File Offset: 0x0000239C
		public virtual ByteBuffer Data
		{
			[Register("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ByteBuffer>(StandardGifDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("getData.()Ljava/nio/ByteBuffer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000041CE File Offset: 0x000023CE
		private static Delegate GetGetFrameCountHandler()
		{
			if (StandardGifDecoder.cb_getFrameCount == null)
			{
				StandardGifDecoder.cb_getFrameCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetFrameCount));
			}
			return StandardGifDecoder.cb_getFrameCount;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000041F2 File Offset: 0x000023F2
		private static int n_GetFrameCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FrameCount;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004201 File Offset: 0x00002401
		public virtual int FrameCount
		{
			[Register("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getFrameCount.()I", this, null);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000421A File Offset: 0x0000241A
		private static Delegate GetGetHeightHandler()
		{
			if (StandardGifDecoder.cb_getHeight == null)
			{
				StandardGifDecoder.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetHeight));
			}
			return StandardGifDecoder.cb_getHeight;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000423E File Offset: 0x0000243E
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000424D File Offset: 0x0000244D
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004266 File Offset: 0x00002466
		[Obsolete]
		private static Delegate GetGetLoopCountHandler()
		{
			if (StandardGifDecoder.cb_getLoopCount == null)
			{
				StandardGifDecoder.cb_getLoopCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetLoopCount));
			}
			return StandardGifDecoder.cb_getLoopCount;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000428A File Offset: 0x0000248A
		[Obsolete]
		private static int n_GetLoopCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoopCount;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004299 File Offset: 0x00002499
		[Obsolete("deprecated")]
		public virtual int LoopCount
		{
			[Register("getLoopCount", "()I", "GetGetLoopCountHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getLoopCount.()I", this, null);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000042B2 File Offset: 0x000024B2
		private static Delegate GetGetNetscapeLoopCountHandler()
		{
			if (StandardGifDecoder.cb_getNetscapeLoopCount == null)
			{
				StandardGifDecoder.cb_getNetscapeLoopCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetNetscapeLoopCount));
			}
			return StandardGifDecoder.cb_getNetscapeLoopCount;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000042D6 File Offset: 0x000024D6
		private static int n_GetNetscapeLoopCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetscapeLoopCount;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000042E5 File Offset: 0x000024E5
		public virtual int NetscapeLoopCount
		{
			[Register("getNetscapeLoopCount", "()I", "GetGetNetscapeLoopCountHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getNetscapeLoopCount.()I", this, null);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000042FE File Offset: 0x000024FE
		private static Delegate GetGetNextDelayHandler()
		{
			if (StandardGifDecoder.cb_getNextDelay == null)
			{
				StandardGifDecoder.cb_getNextDelay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetNextDelay));
			}
			return StandardGifDecoder.cb_getNextDelay;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004322 File Offset: 0x00002522
		private static int n_GetNextDelay(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDelay;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004331 File Offset: 0x00002531
		public virtual int NextDelay
		{
			[Register("getNextDelay", "()I", "GetGetNextDelayHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getNextDelay.()I", this, null);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000434A File Offset: 0x0000254A
		private static Delegate GetGetNextFrameHandler()
		{
			if (StandardGifDecoder.cb_getNextFrame == null)
			{
				StandardGifDecoder.cb_getNextFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(StandardGifDecoder.n_GetNextFrame));
			}
			return StandardGifDecoder.cb_getNextFrame;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000436E File Offset: 0x0000256E
		private static IntPtr n_GetNextFrame(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextFrame);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00004384 File Offset: 0x00002584
		public virtual Bitmap NextFrame
		{
			[Register("getNextFrame", "()Landroid/graphics/Bitmap;", "GetGetNextFrameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bitmap>(StandardGifDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("getNextFrame.()Landroid/graphics/Bitmap;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000043B6 File Offset: 0x000025B6
		private static Delegate GetGetStatusHandler()
		{
			if (StandardGifDecoder.cb_getStatus == null)
			{
				StandardGifDecoder.cb_getStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetStatus));
			}
			return StandardGifDecoder.cb_getStatus;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000043DA File Offset: 0x000025DA
		private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Status;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000043E9 File Offset: 0x000025E9
		public virtual int Status
		{
			[Register("getStatus", "()I", "GetGetStatusHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getStatus.()I", this, null);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004402 File Offset: 0x00002602
		private static Delegate GetGetTotalIterationCountHandler()
		{
			if (StandardGifDecoder.cb_getTotalIterationCount == null)
			{
				StandardGifDecoder.cb_getTotalIterationCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetTotalIterationCount));
			}
			return StandardGifDecoder.cb_getTotalIterationCount;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004426 File Offset: 0x00002626
		private static int n_GetTotalIterationCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TotalIterationCount;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00004435 File Offset: 0x00002635
		public virtual int TotalIterationCount
		{
			[Register("getTotalIterationCount", "()I", "GetGetTotalIterationCountHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getTotalIterationCount.()I", this, null);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000444E File Offset: 0x0000264E
		private static Delegate GetGetWidthHandler()
		{
			if (StandardGifDecoder.cb_getWidth == null)
			{
				StandardGifDecoder.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StandardGifDecoder.n_GetWidth));
			}
			return StandardGifDecoder.cb_getWidth;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00004472 File Offset: 0x00002672
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00004481 File Offset: 0x00002681
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000449A File Offset: 0x0000269A
		private static Delegate GetAdvanceHandler()
		{
			if (StandardGifDecoder.cb_advance == null)
			{
				StandardGifDecoder.cb_advance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StandardGifDecoder.n_Advance));
			}
			return StandardGifDecoder.cb_advance;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000044BE File Offset: 0x000026BE
		private static void n_Advance(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Advance();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000044CD File Offset: 0x000026CD
		[Register("advance", "()V", "GetAdvanceHandler")]
		public virtual void Advance()
		{
			StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("advance.()V", this, null);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000044E6 File Offset: 0x000026E6
		private static Delegate GetClearHandler()
		{
			if (StandardGifDecoder.cb_clear == null)
			{
				StandardGifDecoder.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StandardGifDecoder.n_Clear));
			}
			return StandardGifDecoder.cb_clear;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000450A File Offset: 0x0000270A
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004519 File Offset: 0x00002719
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004532 File Offset: 0x00002732
		private static Delegate GetGetDelay_IHandler()
		{
			if (StandardGifDecoder.cb_getDelay_I == null)
			{
				StandardGifDecoder.cb_getDelay_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(StandardGifDecoder.n_GetDelay_I));
			}
			return StandardGifDecoder.cb_getDelay_I;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004556 File Offset: 0x00002756
		private static int n_GetDelay_I(IntPtr jnienv, IntPtr native__this, int n)
		{
			return Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDelay(n);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004568 File Offset: 0x00002768
		[Register("getDelay", "(I)I", "GetGetDelay_IHandler")]
		public unsafe virtual int GetDelay(int n)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(n);
			return StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("getDelay.(I)I", this, ptr);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000045A3 File Offset: 0x000027A3
		private static Delegate GetRead_arrayBHandler()
		{
			if (StandardGifDecoder.cb_read_arrayB == null)
			{
				StandardGifDecoder.cb_read_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(StandardGifDecoder.n_Read_arrayB));
			}
			return StandardGifDecoder.cb_read_arrayB;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000045C8 File Offset: 0x000027C8
		private static int n_Read_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_data, JniHandleOwnership.DoNotTransfer, typeof(byte));
			int result = @object.Read(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_data);
			}
			return result;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004604 File Offset: 0x00002804
		[Register("read", "([B)I", "GetRead_arrayBHandler")]
		public unsafe virtual int Read(byte[] data)
		{
			IntPtr intPtr = JNIEnv.NewArray(data);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("read.([B)I", this, ptr);
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
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004674 File Offset: 0x00002874
		private static Delegate GetRead_Ljava_io_InputStream_IHandler()
		{
			if (StandardGifDecoder.cb_read_Ljava_io_InputStream_I == null)
			{
				StandardGifDecoder.cb_read_Ljava_io_InputStream_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(StandardGifDecoder.n_Read_Ljava_io_InputStream_I));
			}
			return StandardGifDecoder.cb_read_Ljava_io_InputStream_I;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004698 File Offset: 0x00002898
		private static int n_Read_Ljava_io_InputStream_I(IntPtr jnienv, IntPtr native__this, IntPtr native__is, int contentLength)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream @is = InputStreamInvoker.FromJniHandle(native__is, JniHandleOwnership.DoNotTransfer);
			return @object.Read(@is, contentLength);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000046BC File Offset: 0x000028BC
		[Register("read", "(Ljava/io/InputStream;I)I", "GetRead_Ljava_io_InputStream_IHandler")]
		public unsafe virtual int Read(Stream @is, int contentLength)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@is);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(contentLength);
				result = StandardGifDecoder._members.InstanceMethods.InvokeVirtualInt32Method("read.(Ljava/io/InputStream;I)I", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@is);
			}
			return result;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004734 File Offset: 0x00002934
		private static Delegate GetResetFrameIndexHandler()
		{
			if (StandardGifDecoder.cb_resetFrameIndex == null)
			{
				StandardGifDecoder.cb_resetFrameIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(StandardGifDecoder.n_ResetFrameIndex));
			}
			return StandardGifDecoder.cb_resetFrameIndex;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004758 File Offset: 0x00002958
		private static void n_ResetFrameIndex(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetFrameIndex();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004767 File Offset: 0x00002967
		[Register("resetFrameIndex", "()V", "GetResetFrameIndexHandler")]
		public virtual void ResetFrameIndex()
		{
			StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("resetFrameIndex.()V", this, null);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004780 File Offset: 0x00002980
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler()
		{
			if (StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB == null)
			{
				StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(StandardGifDecoder.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB));
			}
			return StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000047A4 File Offset: 0x000029A4
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_header, IntPtr native_data)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_header, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_data, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.SetData(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_data);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000047EC File Offset: 0x000029EC
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler")]
		public unsafe virtual void SetData(GifHeader header, byte[] data)
		{
			IntPtr intPtr = JNIEnv.NewArray(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((header == null) ? IntPtr.Zero : header.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("setData.(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V", this, ptr);
			}
			finally
			{
				if (data != null)
				{
					JNIEnv.CopyArray(intPtr, data);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(header);
				GC.KeepAlive(data);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00004880 File Offset: 0x00002A80
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_Handler()
		{
			if (StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ == null)
			{
				StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(StandardGifDecoder.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_));
			}
			return StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000048A4 File Offset: 0x00002AA4
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_header, IntPtr native_buffer)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_header, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object3 = Java.Lang.Object.GetObject<ByteBuffer>(native_buffer, JniHandleOwnership.DoNotTransfer);
			@object.SetData(object2, object3);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000048D0 File Offset: 0x00002AD0
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_Handler")]
		public unsafe virtual void SetData(GifHeader header, ByteBuffer buffer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((header == null) ? IntPtr.Zero : header.Handle);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("setData.(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(header);
				GC.KeepAlive(buffer);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000495C File Offset: 0x00002B5C
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_IHandler()
		{
			if (StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I == null)
			{
				StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(StandardGifDecoder.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I));
			}
			return StandardGifDecoder.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00004980 File Offset: 0x00002B80
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I(IntPtr jnienv, IntPtr native__this, IntPtr native_header, IntPtr native_buffer, int sampleSize)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_header, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object3 = Java.Lang.Object.GetObject<ByteBuffer>(native_buffer, JniHandleOwnership.DoNotTransfer);
			@object.SetData(object2, object3, sampleSize);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Register("setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", "GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_IHandler")]
		public unsafe virtual void SetData(GifHeader header, ByteBuffer buffer, int sampleSize)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((header == null) ? IntPtr.Zero : header.Handle);
				ptr[1] = new JniArgumentValue((buffer == null) ? IntPtr.Zero : buffer.Handle);
				ptr[2] = new JniArgumentValue(sampleSize);
				StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("setData.(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(header);
				GC.KeepAlive(buffer);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004A54 File Offset: 0x00002C54
		private static Delegate GetSetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler()
		{
			if (StandardGifDecoder.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ == null)
			{
				StandardGifDecoder.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StandardGifDecoder.n_SetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_));
			}
			return StandardGifDecoder.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004A78 File Offset: 0x00002C78
		private static void n_SetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			StandardGifDecoder @object = Java.Lang.Object.GetObject<StandardGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_config, JniHandleOwnership.DoNotTransfer);
			@object.SetDefaultBitmapConfig(object2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Register("setDefaultBitmapConfig", "(Landroid/graphics/Bitmap$Config;)V", "GetSetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler")]
		public unsafe virtual void SetDefaultBitmapConfig(Bitmap.Config config)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				StandardGifDecoder._members.InstanceMethods.InvokeVirtualVoidMethod("setDefaultBitmapConfig.(Landroid/graphics/Bitmap$Config;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(config);
			}
		}

		// Token: 0x0400005A RID: 90
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/StandardGifDecoder", typeof(StandardGifDecoder));

		// Token: 0x0400005B RID: 91
		private static Delegate cb_getByteSize;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_getCurrentFrameIndex;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_getData;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_getFrameCount;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_getHeight;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_getLoopCount;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_getNetscapeLoopCount;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_getNextDelay;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_getNextFrame;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_getStatus;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_getTotalIterationCount;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_getWidth;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_advance;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_clear;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_getDelay_I;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_read_arrayB;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_read_Ljava_io_InputStream_I;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_resetFrameIndex;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_;

		// Token: 0x0200001D RID: 29
		public static class InterfaceConsts
		{
			// Token: 0x04000071 RID: 113
			[Register("STATUS_FORMAT_ERROR")]
			public const int StatusFormatError = 1;

			// Token: 0x04000072 RID: 114
			[Register("STATUS_OK")]
			public const int StatusOk = 0;

			// Token: 0x04000073 RID: 115
			[Register("STATUS_OPEN_ERROR")]
			public const int StatusOpenError = 2;

			// Token: 0x04000074 RID: 116
			[Register("STATUS_PARTIAL_DECODE")]
			public const int StatusPartialDecode = 3;

			// Token: 0x04000075 RID: 117
			[Register("TOTAL_ITERATION_COUNT_FOREVER")]
			public const int TotalIterationCountForever = 0;
		}
	}
}
