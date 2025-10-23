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
	// Token: 0x0200001B RID: 27
	[Register("com/bumptech/glide/gifdecoder/GifDecoder", DoNotGenerateAcw = true)]
	internal class IGifDecoderInvoker : Java.Lang.Object, IGifDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002FB8 File Offset: 0x000011B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IGifDecoderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002FDC File Offset: 0x000011DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGifDecoderInvoker._members;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002FE3 File Offset: 0x000011E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002FEB File Offset: 0x000011EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGifDecoderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002FF7 File Offset: 0x000011F7
		public static IGifDecoder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(handle, transfer);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003000 File Offset: 0x00001200
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGifDecoderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.gifdecoder.GifDecoder'.");
			}
			return handle;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000302B File Offset: 0x0000122B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000305C File Offset: 0x0000125C
		public IGifDecoderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGifDecoderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003094 File Offset: 0x00001294
		private static Delegate GetGetByteSizeHandler()
		{
			if (IGifDecoderInvoker.cb_getByteSize == null)
			{
				IGifDecoderInvoker.cb_getByteSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetByteSize));
			}
			return IGifDecoderInvoker.cb_getByteSize;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000030B8 File Offset: 0x000012B8
		private static int n_GetByteSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ByteSize;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000030C7 File Offset: 0x000012C7
		public int ByteSize
		{
			get
			{
				if (this.id_getByteSize == IntPtr.Zero)
				{
					this.id_getByteSize = JNIEnv.GetMethodID(this.class_ref, "getByteSize", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getByteSize);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003107 File Offset: 0x00001307
		private static Delegate GetGetCurrentFrameIndexHandler()
		{
			if (IGifDecoderInvoker.cb_getCurrentFrameIndex == null)
			{
				IGifDecoderInvoker.cb_getCurrentFrameIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetCurrentFrameIndex));
			}
			return IGifDecoderInvoker.cb_getCurrentFrameIndex;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000312B File Offset: 0x0000132B
		private static int n_GetCurrentFrameIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentFrameIndex;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000313A File Offset: 0x0000133A
		public int CurrentFrameIndex
		{
			get
			{
				if (this.id_getCurrentFrameIndex == IntPtr.Zero)
				{
					this.id_getCurrentFrameIndex = JNIEnv.GetMethodID(this.class_ref, "getCurrentFrameIndex", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getCurrentFrameIndex);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000317A File Offset: 0x0000137A
		private static Delegate GetGetDataHandler()
		{
			if (IGifDecoderInvoker.cb_getData == null)
			{
				IGifDecoderInvoker.cb_getData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGifDecoderInvoker.n_GetData));
			}
			return IGifDecoderInvoker.cb_getData;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000319E File Offset: 0x0000139E
		private static IntPtr n_GetData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Data);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000031B4 File Offset: 0x000013B4
		public ByteBuffer Data
		{
			get
			{
				if (this.id_getData == IntPtr.Zero)
				{
					this.id_getData = JNIEnv.GetMethodID(this.class_ref, "getData", "()Ljava/nio/ByteBuffer;");
				}
				return Java.Lang.Object.GetObject<ByteBuffer>(JNIEnv.CallObjectMethod(base.Handle, this.id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003205 File Offset: 0x00001405
		private static Delegate GetGetFrameCountHandler()
		{
			if (IGifDecoderInvoker.cb_getFrameCount == null)
			{
				IGifDecoderInvoker.cb_getFrameCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetFrameCount));
			}
			return IGifDecoderInvoker.cb_getFrameCount;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003229 File Offset: 0x00001429
		private static int n_GetFrameCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FrameCount;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003238 File Offset: 0x00001438
		public int FrameCount
		{
			get
			{
				if (this.id_getFrameCount == IntPtr.Zero)
				{
					this.id_getFrameCount = JNIEnv.GetMethodID(this.class_ref, "getFrameCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getFrameCount);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003278 File Offset: 0x00001478
		private static Delegate GetGetHeightHandler()
		{
			if (IGifDecoderInvoker.cb_getHeight == null)
			{
				IGifDecoderInvoker.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetHeight));
			}
			return IGifDecoderInvoker.cb_getHeight;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000329C File Offset: 0x0000149C
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000032AB File Offset: 0x000014AB
		public int Height
		{
			get
			{
				if (this.id_getHeight == IntPtr.Zero)
				{
					this.id_getHeight = JNIEnv.GetMethodID(this.class_ref, "getHeight", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getHeight);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000032EB File Offset: 0x000014EB
		[Obsolete]
		private static Delegate GetGetLoopCountHandler()
		{
			if (IGifDecoderInvoker.cb_getLoopCount == null)
			{
				IGifDecoderInvoker.cb_getLoopCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetLoopCount));
			}
			return IGifDecoderInvoker.cb_getLoopCount;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000330F File Offset: 0x0000150F
		[Obsolete]
		private static int n_GetLoopCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoopCount;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000331E File Offset: 0x0000151E
		public int LoopCount
		{
			get
			{
				if (this.id_getLoopCount == IntPtr.Zero)
				{
					this.id_getLoopCount = JNIEnv.GetMethodID(this.class_ref, "getLoopCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getLoopCount);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000335E File Offset: 0x0000155E
		private static Delegate GetGetNetscapeLoopCountHandler()
		{
			if (IGifDecoderInvoker.cb_getNetscapeLoopCount == null)
			{
				IGifDecoderInvoker.cb_getNetscapeLoopCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetNetscapeLoopCount));
			}
			return IGifDecoderInvoker.cb_getNetscapeLoopCount;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003382 File Offset: 0x00001582
		private static int n_GetNetscapeLoopCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetscapeLoopCount;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003391 File Offset: 0x00001591
		public int NetscapeLoopCount
		{
			get
			{
				if (this.id_getNetscapeLoopCount == IntPtr.Zero)
				{
					this.id_getNetscapeLoopCount = JNIEnv.GetMethodID(this.class_ref, "getNetscapeLoopCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNetscapeLoopCount);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000033D1 File Offset: 0x000015D1
		private static Delegate GetGetNextDelayHandler()
		{
			if (IGifDecoderInvoker.cb_getNextDelay == null)
			{
				IGifDecoderInvoker.cb_getNextDelay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetNextDelay));
			}
			return IGifDecoderInvoker.cb_getNextDelay;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000033F5 File Offset: 0x000015F5
		private static int n_GetNextDelay(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDelay;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003404 File Offset: 0x00001604
		public int NextDelay
		{
			get
			{
				if (this.id_getNextDelay == IntPtr.Zero)
				{
					this.id_getNextDelay = JNIEnv.GetMethodID(this.class_ref, "getNextDelay", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getNextDelay);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003444 File Offset: 0x00001644
		private static Delegate GetGetNextFrameHandler()
		{
			if (IGifDecoderInvoker.cb_getNextFrame == null)
			{
				IGifDecoderInvoker.cb_getNextFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGifDecoderInvoker.n_GetNextFrame));
			}
			return IGifDecoderInvoker.cb_getNextFrame;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003468 File Offset: 0x00001668
		private static IntPtr n_GetNextFrame(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextFrame);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000347C File Offset: 0x0000167C
		public Bitmap NextFrame
		{
			get
			{
				if (this.id_getNextFrame == IntPtr.Zero)
				{
					this.id_getNextFrame = JNIEnv.GetMethodID(this.class_ref, "getNextFrame", "()Landroid/graphics/Bitmap;");
				}
				return Java.Lang.Object.GetObject<Bitmap>(JNIEnv.CallObjectMethod(base.Handle, this.id_getNextFrame), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000034CD File Offset: 0x000016CD
		private static Delegate GetGetStatusHandler()
		{
			if (IGifDecoderInvoker.cb_getStatus == null)
			{
				IGifDecoderInvoker.cb_getStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetStatus));
			}
			return IGifDecoderInvoker.cb_getStatus;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000034F1 File Offset: 0x000016F1
		private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Status;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003500 File Offset: 0x00001700
		public int Status
		{
			get
			{
				if (this.id_getStatus == IntPtr.Zero)
				{
					this.id_getStatus = JNIEnv.GetMethodID(this.class_ref, "getStatus", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getStatus);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003540 File Offset: 0x00001740
		private static Delegate GetGetTotalIterationCountHandler()
		{
			if (IGifDecoderInvoker.cb_getTotalIterationCount == null)
			{
				IGifDecoderInvoker.cb_getTotalIterationCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetTotalIterationCount));
			}
			return IGifDecoderInvoker.cb_getTotalIterationCount;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003564 File Offset: 0x00001764
		private static int n_GetTotalIterationCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TotalIterationCount;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003573 File Offset: 0x00001773
		public int TotalIterationCount
		{
			get
			{
				if (this.id_getTotalIterationCount == IntPtr.Zero)
				{
					this.id_getTotalIterationCount = JNIEnv.GetMethodID(this.class_ref, "getTotalIterationCount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getTotalIterationCount);
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000035B3 File Offset: 0x000017B3
		private static Delegate GetGetWidthHandler()
		{
			if (IGifDecoderInvoker.cb_getWidth == null)
			{
				IGifDecoderInvoker.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IGifDecoderInvoker.n_GetWidth));
			}
			return IGifDecoderInvoker.cb_getWidth;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000035D7 File Offset: 0x000017D7
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000035E6 File Offset: 0x000017E6
		public int Width
		{
			get
			{
				if (this.id_getWidth == IntPtr.Zero)
				{
					this.id_getWidth = JNIEnv.GetMethodID(this.class_ref, "getWidth", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getWidth);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003626 File Offset: 0x00001826
		private static Delegate GetAdvanceHandler()
		{
			if (IGifDecoderInvoker.cb_advance == null)
			{
				IGifDecoderInvoker.cb_advance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IGifDecoderInvoker.n_Advance));
			}
			return IGifDecoderInvoker.cb_advance;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000364A File Offset: 0x0000184A
		private static void n_Advance(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Advance();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003659 File Offset: 0x00001859
		public void Advance()
		{
			if (this.id_advance == IntPtr.Zero)
			{
				this.id_advance = JNIEnv.GetMethodID(this.class_ref, "advance", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_advance);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003699 File Offset: 0x00001899
		private static Delegate GetClearHandler()
		{
			if (IGifDecoderInvoker.cb_clear == null)
			{
				IGifDecoderInvoker.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IGifDecoderInvoker.n_Clear));
			}
			return IGifDecoderInvoker.cb_clear;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000036BD File Offset: 0x000018BD
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000036CC File Offset: 0x000018CC
		public void Clear()
		{
			if (this.id_clear == IntPtr.Zero)
			{
				this.id_clear = JNIEnv.GetMethodID(this.class_ref, "clear", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clear);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000370C File Offset: 0x0000190C
		private static Delegate GetGetDelay_IHandler()
		{
			if (IGifDecoderInvoker.cb_getDelay_I == null)
			{
				IGifDecoderInvoker.cb_getDelay_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(IGifDecoderInvoker.n_GetDelay_I));
			}
			return IGifDecoderInvoker.cb_getDelay_I;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003730 File Offset: 0x00001930
		private static int n_GetDelay_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDelay(p0);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003740 File Offset: 0x00001940
		public unsafe int GetDelay(int p0)
		{
			if (this.id_getDelay_I == IntPtr.Zero)
			{
				this.id_getDelay_I = JNIEnv.GetMethodID(this.class_ref, "getDelay", "(I)I");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return JNIEnv.CallIntMethod(base.Handle, this.id_getDelay_I, ptr);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000037A4 File Offset: 0x000019A4
		private static Delegate GetRead_arrayBHandler()
		{
			if (IGifDecoderInvoker.cb_read_arrayB == null)
			{
				IGifDecoderInvoker.cb_read_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IGifDecoderInvoker.n_Read_arrayB));
			}
			return IGifDecoderInvoker.cb_read_arrayB;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000037C8 File Offset: 0x000019C8
		private static int n_Read_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
			int result = @object.Read(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p0);
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003804 File Offset: 0x00001A04
		public unsafe int Read(byte[] p0)
		{
			if (this.id_read_arrayB == IntPtr.Zero)
			{
				this.id_read_arrayB = JNIEnv.GetMethodID(this.class_ref, "read", "([B)I");
			}
			IntPtr intPtr = JNIEnv.NewArray(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_read_arrayB, ptr);
			if (p0 != null)
			{
				JNIEnv.CopyArray(intPtr, p0);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000387F File Offset: 0x00001A7F
		private static Delegate GetRead_Ljava_io_InputStream_IHandler()
		{
			if (IGifDecoderInvoker.cb_read_Ljava_io_InputStream_I == null)
			{
				IGifDecoderInvoker.cb_read_Ljava_io_InputStream_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(IGifDecoderInvoker.n_Read_Ljava_io_InputStream_I));
			}
			return IGifDecoderInvoker.cb_read_Ljava_io_InputStream_I;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000038A4 File Offset: 0x00001AA4
		private static int n_Read_Ljava_io_InputStream_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream p2 = InputStreamInvoker.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Read(p2, p1);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000038C8 File Offset: 0x00001AC8
		public unsafe int Read(Stream p0, int p1)
		{
			if (this.id_read_Ljava_io_InputStream_I == IntPtr.Zero)
			{
				this.id_read_Ljava_io_InputStream_I = JNIEnv.GetMethodID(this.class_ref, "read", "(Ljava/io/InputStream;I)I");
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_read_Ljava_io_InputStream_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000394C File Offset: 0x00001B4C
		private static Delegate GetResetFrameIndexHandler()
		{
			if (IGifDecoderInvoker.cb_resetFrameIndex == null)
			{
				IGifDecoderInvoker.cb_resetFrameIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IGifDecoderInvoker.n_ResetFrameIndex));
			}
			return IGifDecoderInvoker.cb_resetFrameIndex;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003970 File Offset: 0x00001B70
		private static void n_ResetFrameIndex(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResetFrameIndex();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000397F File Offset: 0x00001B7F
		public void ResetFrameIndex()
		{
			if (this.id_resetFrameIndex == IntPtr.Zero)
			{
				this.id_resetFrameIndex = JNIEnv.GetMethodID(this.class_ref, "resetFrameIndex", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_resetFrameIndex);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000039BF File Offset: 0x00001BBF
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayBHandler()
		{
			if (IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB == null)
			{
				IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IGifDecoderInvoker.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB));
			}
			return IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000039E4 File Offset: 0x00001BE4
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.SetData(object2, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p1);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003A2C File Offset: 0x00001C2C
		public unsafe void SetData(GifHeader p0, byte[] p1)
		{
			if (this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB == IntPtr.Zero)
			{
				this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB = JNIEnv.GetMethodID(this.class_ref, "setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;[B)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB, ptr);
			if (p1 != null)
			{
				JNIEnv.CopyArray(intPtr, p1);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003AC9 File Offset: 0x00001CC9
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_Handler()
		{
			if (IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ == null)
			{
				IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IGifDecoderInvoker.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_));
			}
			return IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003AF0 File Offset: 0x00001CF0
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_p0, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object3 = Java.Lang.Object.GetObject<ByteBuffer>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetData(object2, object3);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003B1C File Offset: 0x00001D1C
		public unsafe void SetData(GifHeader p0, ByteBuffer p1)
		{
			if (this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
			{
				this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID(this.class_ref, "setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_, ptr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003BB1 File Offset: 0x00001DB1
		private static Delegate GetSetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_IHandler()
		{
			if (IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I == null)
			{
				IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IGifDecoderInvoker.n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I));
			}
			return IGifDecoderInvoker.cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003BD8 File Offset: 0x00001DD8
		private static void n_SetData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			GifHeader object2 = Java.Lang.Object.GetObject<GifHeader>(native_p0, JniHandleOwnership.DoNotTransfer);
			ByteBuffer object3 = Java.Lang.Object.GetObject<ByteBuffer>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetData(object2, object3, p2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003C08 File Offset: 0x00001E08
		public unsafe void SetData(GifHeader p0, ByteBuffer p1, int p2)
		{
			if (this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
			{
				this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID(this.class_ref, "setData", "(Lcom/bumptech/glide/gifdecoder/GifHeader;Ljava/nio/ByteBuffer;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I, ptr);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003CB3 File Offset: 0x00001EB3
		private static Delegate GetSetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_Handler()
		{
			if (IGifDecoderInvoker.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ == null)
			{
				IGifDecoderInvoker.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IGifDecoderInvoker.n_SetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_));
			}
			return IGifDecoderInvoker.cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003CD8 File Offset: 0x00001ED8
		private static void n_SetDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IGifDecoder @object = Java.Lang.Object.GetObject<IGifDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.Config object2 = Java.Lang.Object.GetObject<Bitmap.Config>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetDefaultBitmapConfig(object2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003CFC File Offset: 0x00001EFC
		public unsafe void SetDefaultBitmapConfig(Bitmap.Config p0)
		{
			if (this.id_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ == IntPtr.Zero)
			{
				this.id_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_ = JNIEnv.GetMethodID(this.class_ref, "setDefaultBitmapConfig", "(Landroid/graphics/Bitmap$Config;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_, ptr);
		}

		// Token: 0x0400002C RID: 44
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/GifDecoder", typeof(IGifDecoderInvoker));

		// Token: 0x0400002D RID: 45
		private IntPtr class_ref;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_getByteSize;

		// Token: 0x0400002F RID: 47
		private IntPtr id_getByteSize;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_getCurrentFrameIndex;

		// Token: 0x04000031 RID: 49
		private IntPtr id_getCurrentFrameIndex;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_getData;

		// Token: 0x04000033 RID: 51
		private IntPtr id_getData;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_getFrameCount;

		// Token: 0x04000035 RID: 53
		private IntPtr id_getFrameCount;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_getHeight;

		// Token: 0x04000037 RID: 55
		private IntPtr id_getHeight;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_getLoopCount;

		// Token: 0x04000039 RID: 57
		private IntPtr id_getLoopCount;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_getNetscapeLoopCount;

		// Token: 0x0400003B RID: 59
		private IntPtr id_getNetscapeLoopCount;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getNextDelay;

		// Token: 0x0400003D RID: 61
		private IntPtr id_getNextDelay;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_getNextFrame;

		// Token: 0x0400003F RID: 63
		private IntPtr id_getNextFrame;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_getStatus;

		// Token: 0x04000041 RID: 65
		private IntPtr id_getStatus;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_getTotalIterationCount;

		// Token: 0x04000043 RID: 67
		private IntPtr id_getTotalIterationCount;

		// Token: 0x04000044 RID: 68
		private static Delegate cb_getWidth;

		// Token: 0x04000045 RID: 69
		private IntPtr id_getWidth;

		// Token: 0x04000046 RID: 70
		private static Delegate cb_advance;

		// Token: 0x04000047 RID: 71
		private IntPtr id_advance;

		// Token: 0x04000048 RID: 72
		private static Delegate cb_clear;

		// Token: 0x04000049 RID: 73
		private IntPtr id_clear;

		// Token: 0x0400004A RID: 74
		private static Delegate cb_getDelay_I;

		// Token: 0x0400004B RID: 75
		private IntPtr id_getDelay_I;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_read_arrayB;

		// Token: 0x0400004D RID: 77
		private IntPtr id_read_arrayB;

		// Token: 0x0400004E RID: 78
		private static Delegate cb_read_Ljava_io_InputStream_I;

		// Token: 0x0400004F RID: 79
		private IntPtr id_read_Ljava_io_InputStream_I;

		// Token: 0x04000050 RID: 80
		private static Delegate cb_resetFrameIndex;

		// Token: 0x04000051 RID: 81
		private IntPtr id_resetFrameIndex;

		// Token: 0x04000052 RID: 82
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;

		// Token: 0x04000053 RID: 83
		private IntPtr id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_arrayB;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_;

		// Token: 0x04000055 RID: 85
		private IntPtr id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I;

		// Token: 0x04000057 RID: 87
		private IntPtr id_setData_Lcom_bumptech_glide_gifdecoder_GifHeader_Ljava_nio_ByteBuffer_I;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_;

		// Token: 0x04000059 RID: 89
		private IntPtr id_setDefaultBitmapConfig_Landroid_graphics_Bitmap_Config_;
	}
}
