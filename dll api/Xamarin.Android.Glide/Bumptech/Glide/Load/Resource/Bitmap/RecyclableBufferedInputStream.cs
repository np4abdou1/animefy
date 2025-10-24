using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000115 RID: 277
	[Register("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream", DoNotGenerateAcw = true)]
	public class RecyclableBufferedInputStream : FilterInputStream
	{
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0002C20C File Offset: 0x0002A40C
		internal static IntPtr class_ref
		{
			get
			{
				return RecyclableBufferedInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0002C230 File Offset: 0x0002A430
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RecyclableBufferedInputStream._members;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0002C238 File Offset: 0x0002A438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RecyclableBufferedInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0002C25C File Offset: 0x0002A45C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RecyclableBufferedInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0002C268 File Offset: 0x0002A468
		protected RecyclableBufferedInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0002C274 File Offset: 0x0002A474
		[Register(".ctor", "(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe RecyclableBufferedInputStream(Stream @in, IArrayPool byteArrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@in);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((byteArrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)byteArrayPool).Handle);
				base.SetHandle(RecyclableBufferedInputStream._members.InstanceMethods.StartCreateInstance("(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RecyclableBufferedInputStream._members.InstanceMethods.FinishCreateInstance("(Ljava/io/InputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@in);
				GC.KeepAlive(byteArrayPool);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0002C34C File Offset: 0x0002A54C
		private static Delegate GetFixMarkLimitHandler()
		{
			if (RecyclableBufferedInputStream.cb_fixMarkLimit == null)
			{
				RecyclableBufferedInputStream.cb_fixMarkLimit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclableBufferedInputStream.n_FixMarkLimit));
			}
			return RecyclableBufferedInputStream.cb_fixMarkLimit;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0002C370 File Offset: 0x0002A570
		private static void n_FixMarkLimit(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclableBufferedInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FixMarkLimit();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0002C37F File Offset: 0x0002A57F
		[Register("fixMarkLimit", "()V", "GetFixMarkLimitHandler")]
		public virtual void FixMarkLimit()
		{
			RecyclableBufferedInputStream._members.InstanceMethods.InvokeVirtualVoidMethod("fixMarkLimit.()V", this, null);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0002C398 File Offset: 0x0002A598
		private static Delegate GetReleaseHandler()
		{
			if (RecyclableBufferedInputStream.cb_release == null)
			{
				RecyclableBufferedInputStream.cb_release = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RecyclableBufferedInputStream.n_Release));
			}
			return RecyclableBufferedInputStream.cb_release;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0002C3BC File Offset: 0x0002A5BC
		private static void n_Release(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RecyclableBufferedInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Release();
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0002C3CB File Offset: 0x0002A5CB
		[Register("release", "()V", "GetReleaseHandler")]
		public virtual void Release()
		{
			RecyclableBufferedInputStream._members.InstanceMethods.InvokeVirtualVoidMethod("release.()V", this, null);
		}

		// Token: 0x0400033D RID: 829
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream", typeof(RecyclableBufferedInputStream));

		// Token: 0x0400033E RID: 830
		private static Delegate cb_fixMarkLimit;

		// Token: 0x0400033F RID: 831
		private static Delegate cb_release;
	}
}
