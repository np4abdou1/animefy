using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Bumptech.Glide.Load.Engine.Cache;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.Prefill
{
	// Token: 0x02000159 RID: 345
	[Register("com/bumptech/glide/load/engine/prefill/BitmapPreFiller", DoNotGenerateAcw = true)]
	public sealed class BitmapPreFiller : Java.Lang.Object
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00038388 File Offset: 0x00036588
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapPreFiller._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000383AC File Offset: 0x000365AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapPreFiller._members;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000383B4 File Offset: 0x000365B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapPreFiller._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x000383D8 File Offset: 0x000365D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapPreFiller._members.ManagedPeerType;
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000383E4 File Offset: 0x000365E4
		internal BitmapPreFiller(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000383F0 File Offset: 0x000365F0
		[Register(".ctor", "(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", "")]
		public unsafe BitmapPreFiller(IMemoryCache memoryCache, IBitmapPool bitmapPool, DecodeFormat defaultFormat) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((memoryCache == null) ? IntPtr.Zero : ((Java.Lang.Object)memoryCache).Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[2] = new JniArgumentValue((defaultFormat == null) ? IntPtr.Zero : defaultFormat.Handle);
				base.SetHandle(BitmapPreFiller._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapPreFiller._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/engine/cache/MemoryCache;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/DecodeFormat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(memoryCache);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(defaultFormat);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000384FC File Offset: 0x000366FC
		[Register("preFill", "([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", "")]
		public unsafe void PreFill(params PreFillType.Builder[] bitmapAttributeBuilders)
		{
			IntPtr intPtr = JNIEnv.NewArray<PreFillType.Builder>(bitmapAttributeBuilders);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BitmapPreFiller._members.InstanceMethods.InvokeAbstractVoidMethod("preFill.([Lcom/bumptech/glide/load/engine/prefill/PreFillType$Builder;)V", this, ptr);
			}
			finally
			{
				if (bitmapAttributeBuilders != null)
				{
					JNIEnv.CopyArray<PreFillType.Builder>(intPtr, bitmapAttributeBuilders);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(bitmapAttributeBuilders);
			}
		}

		// Token: 0x04000400 RID: 1024
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/prefill/BitmapPreFiller", typeof(BitmapPreFiller));
	}
}
