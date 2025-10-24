using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.GifDecoder
{
	// Token: 0x02000012 RID: 18
	[Register("com/bumptech/glide/gifdecoder/GifHeader", DoNotGenerateAcw = true)]
	public class GifHeader : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000020E4 File Offset: 0x000002E4
		internal static IntPtr class_ref
		{
			get
			{
				return GifHeader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002108 File Offset: 0x00000308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifHeader._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002110 File Offset: 0x00000310
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifHeader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002134 File Offset: 0x00000334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifHeader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002140 File Offset: 0x00000340
		protected GifHeader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000214C File Offset: 0x0000034C
		[Register(".ctor", "()V", "")]
		public GifHeader() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GifHeader._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GifHeader._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021BA File Offset: 0x000003BA
		private static Delegate GetGetHeightHandler()
		{
			if (GifHeader.cb_getHeight == null)
			{
				GifHeader.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifHeader.n_GetHeight));
			}
			return GifHeader.cb_getHeight;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021DE File Offset: 0x000003DE
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifHeader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000021ED File Offset: 0x000003ED
		public virtual int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return GifHeader._members.InstanceMethods.InvokeVirtualInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002206 File Offset: 0x00000406
		private static Delegate GetGetNumFramesHandler()
		{
			if (GifHeader.cb_getNumFrames == null)
			{
				GifHeader.cb_getNumFrames = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifHeader.n_GetNumFrames));
			}
			return GifHeader.cb_getNumFrames;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000222A File Offset: 0x0000042A
		private static int n_GetNumFrames(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifHeader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NumFrames;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002239 File Offset: 0x00000439
		public virtual int NumFrames
		{
			[Register("getNumFrames", "()I", "GetGetNumFramesHandler")]
			get
			{
				return GifHeader._members.InstanceMethods.InvokeVirtualInt32Method("getNumFrames.()I", this, null);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002252 File Offset: 0x00000452
		private static Delegate GetGetStatusHandler()
		{
			if (GifHeader.cb_getStatus == null)
			{
				GifHeader.cb_getStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifHeader.n_GetStatus));
			}
			return GifHeader.cb_getStatus;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002276 File Offset: 0x00000476
		private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifHeader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Status;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002285 File Offset: 0x00000485
		public virtual int Status
		{
			[Register("getStatus", "()I", "GetGetStatusHandler")]
			get
			{
				return GifHeader._members.InstanceMethods.InvokeVirtualInt32Method("getStatus.()I", this, null);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000229E File Offset: 0x0000049E
		private static Delegate GetGetWidthHandler()
		{
			if (GifHeader.cb_getWidth == null)
			{
				GifHeader.cb_getWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(GifHeader.n_GetWidth));
			}
			return GifHeader.cb_getWidth;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000022C2 File Offset: 0x000004C2
		private static int n_GetWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GifHeader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Width;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000022D1 File Offset: 0x000004D1
		public virtual int Width
		{
			[Register("getWidth", "()I", "GetGetWidthHandler")]
			get
			{
				return GifHeader._members.InstanceMethods.InvokeVirtualInt32Method("getWidth.()I", this, null);
			}
		}

		// Token: 0x04000002 RID: 2
		[Register("NETSCAPE_LOOP_COUNT_DOES_NOT_EXIST")]
		public const int NetscapeLoopCountDoesNotExist = -1;

		// Token: 0x04000003 RID: 3
		[Register("NETSCAPE_LOOP_COUNT_FOREVER")]
		public const int NetscapeLoopCountForever = 0;

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/gifdecoder/GifHeader", typeof(GifHeader));

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getHeight;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getNumFrames;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getStatus;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getWidth;
	}
}
