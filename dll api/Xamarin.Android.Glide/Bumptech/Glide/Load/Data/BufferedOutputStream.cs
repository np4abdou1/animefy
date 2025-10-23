using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018D RID: 397
	[Register("com/bumptech/glide/load/data/BufferedOutputStream", DoNotGenerateAcw = true)]
	public sealed class BufferedOutputStream : OutputStream
	{
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00040620 File Offset: 0x0003E820
		internal static IntPtr class_ref
		{
			get
			{
				return BufferedOutputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00040644 File Offset: 0x0003E844
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BufferedOutputStream._members;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0004064C File Offset: 0x0003E84C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BufferedOutputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x00040670 File Offset: 0x0003E870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BufferedOutputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0004067C File Offset: 0x0003E87C
		internal BufferedOutputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00040688 File Offset: 0x0003E888
		[Register(".ctor", "(Ljava/io/OutputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", "")]
		public unsafe BufferedOutputStream(Stream @out, IArrayPool arrayPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(@out);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				base.SetHandle(BufferedOutputStream._members.InstanceMethods.StartCreateInstance("(Ljava/io/OutputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BufferedOutputStream._members.InstanceMethods.FinishCreateInstance("(Ljava/io/OutputStream;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@out);
				GC.KeepAlive(arrayPool);
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00040760 File Offset: 0x0003E960
		[Register("write", "(I)V", "")]
		public unsafe override void Write(int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(b);
			BufferedOutputStream._members.InstanceMethods.InvokeAbstractVoidMethod("write.(I)V", this, ptr);
		}

		// Token: 0x040004C0 RID: 1216
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/BufferedOutputStream", typeof(BufferedOutputStream));
	}
}
