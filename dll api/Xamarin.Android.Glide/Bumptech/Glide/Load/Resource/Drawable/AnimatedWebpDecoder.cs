using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F0 RID: 240
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/load/resource/drawable/AnimatedWebpDecoder", DoNotGenerateAcw = true)]
	public sealed class AnimatedWebpDecoder : Java.Lang.Object
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000253C0 File Offset: 0x000235C0
		internal static IntPtr class_ref
		{
			get
			{
				return AnimatedWebpDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000253E4 File Offset: 0x000235E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimatedWebpDecoder._members;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000253EC File Offset: 0x000235EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnimatedWebpDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00025410 File Offset: 0x00023610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimatedWebpDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0002541C File Offset: 0x0002361C
		internal AnimatedWebpDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00025428 File Offset: 0x00023628
		[Register("byteBufferDecoder", "(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", "")]
		public unsafe static IResourceDecoder ByteBufferDecoder(IList<IImageHeaderParser> imageHeaderParsers, IArrayPool arrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(imageHeaderParsers);
			IResourceDecoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(AnimatedWebpDecoder._members.StaticMethods.InvokeObjectMethod("byteBufferDecoder.(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(imageHeaderParsers);
				GC.KeepAlive(arrayPool);
			}
			return @object;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000254C8 File Offset: 0x000236C8
		[Register("streamDecoder", "(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", "")]
		public unsafe static IResourceDecoder StreamDecoder(IList<IImageHeaderParser> imageHeaderParsers, IArrayPool arrayPool)
		{
			IntPtr intPtr = JavaList<IImageHeaderParser>.ToLocalJniHandle(imageHeaderParsers);
			IResourceDecoder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arrayPool == null) ? IntPtr.Zero : ((Java.Lang.Object)arrayPool).Handle);
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(AnimatedWebpDecoder._members.StaticMethods.InvokeObjectMethod("streamDecoder.(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(imageHeaderParsers);
				GC.KeepAlive(arrayPool);
			}
			return @object;
		}

		// Token: 0x040002E6 RID: 742
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/AnimatedWebpDecoder", typeof(AnimatedWebpDecoder));
	}
}
