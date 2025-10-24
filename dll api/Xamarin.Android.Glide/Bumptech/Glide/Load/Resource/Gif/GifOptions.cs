using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Gif
{
	// Token: 0x02000124 RID: 292
	[Register("com/bumptech/glide/load/resource/gif/GifOptions", DoNotGenerateAcw = true)]
	public sealed class GifOptions : Java.Lang.Object
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0002FEF8 File Offset: 0x0002E0F8
		[Register("DECODE_FORMAT")]
		public static Option DecodeFormat
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(GifOptions._members.StaticFields.GetObjectValue("DECODE_FORMAT.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0002FF28 File Offset: 0x0002E128
		[Register("DISABLE_ANIMATION")]
		public static Option DisableAnimation
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(GifOptions._members.StaticFields.GetObjectValue("DISABLE_ANIMATION.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x0002FF58 File Offset: 0x0002E158
		internal static IntPtr class_ref
		{
			get
			{
				return GifOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x0002FF7C File Offset: 0x0002E17C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GifOptions._members;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x0002FF84 File Offset: 0x0002E184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GifOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0002FFA8 File Offset: 0x0002E1A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GifOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
		internal GifOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000376 RID: 886
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/gif/GifOptions", typeof(GifOptions));
	}
}
