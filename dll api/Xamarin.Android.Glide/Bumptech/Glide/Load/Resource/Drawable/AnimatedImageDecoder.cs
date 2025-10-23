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
	// Token: 0x020000EF RID: 239
	[Register("com/bumptech/glide/load/resource/drawable/AnimatedImageDecoder", DoNotGenerateAcw = true)]
	public sealed class AnimatedImageDecoder : Java.Lang.Object
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000251FC File Offset: 0x000233FC
		internal static IntPtr class_ref
		{
			get
			{
				return AnimatedImageDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00025220 File Offset: 0x00023420
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimatedImageDecoder._members;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00025228 File Offset: 0x00023428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnimatedImageDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0002524C File Offset: 0x0002344C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimatedImageDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00025258 File Offset: 0x00023458
		internal AnimatedImageDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00025264 File Offset: 0x00023464
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
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(AnimatedImageDecoder._members.StaticMethods.InvokeObjectMethod("byteBufferDecoder.(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(imageHeaderParsers);
				GC.KeepAlive(arrayPool);
			}
			return @object;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00025304 File Offset: 0x00023504
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
				@object = Java.Lang.Object.GetObject<IResourceDecoder>(AnimatedImageDecoder._members.StaticMethods.InvokeObjectMethod("streamDecoder.(Ljava/util/List;Lcom/bumptech/glide/load/engine/bitmap_recycle/ArrayPool;)Lcom/bumptech/glide/load/ResourceDecoder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(imageHeaderParsers);
				GC.KeepAlive(arrayPool);
			}
			return @object;
		}

		// Token: 0x040002E5 RID: 741
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/AnimatedImageDecoder", typeof(AnimatedImageDecoder));
	}
}
