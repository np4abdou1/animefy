using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Provider
{
	// Token: 0x020001D7 RID: 471
	[Register("android/provider/MediaStore", DoNotGenerateAcw = true)]
	public sealed class MediaStore : Java.Lang.Object
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0002D72B File Offset: 0x0002B92B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStore._members;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0002D734 File Offset: 0x0002B934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x0002D758 File Offset: 0x0002B958
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStore._members.ManagedPeerType;
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000021E0 File Offset: 0x000003E0
		internal MediaStore(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007C6 RID: 1990
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/provider/MediaStore", typeof(MediaStore));

		// Token: 0x020001D8 RID: 472
		[Register("android/provider/MediaStore$Images", DoNotGenerateAcw = true)]
		public sealed class Images : Java.Lang.Object
		{
			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06001134 RID: 4404 RVA: 0x0002D77F File Offset: 0x0002B97F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaStore.Images._members;
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06001135 RID: 4405 RVA: 0x0002D788 File Offset: 0x0002B988
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MediaStore.Images._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06001136 RID: 4406 RVA: 0x0002D7AC File Offset: 0x0002B9AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaStore.Images._members.ManagedPeerType;
				}
			}

			// Token: 0x06001137 RID: 4407 RVA: 0x000021E0 File Offset: 0x000003E0
			internal Images(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040007C7 RID: 1991
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/provider/MediaStore$Images", typeof(MediaStore.Images));

			// Token: 0x020001D9 RID: 473
			[Register("android/provider/MediaStore$Images$Media", DoNotGenerateAcw = true)]
			public sealed class Media : Java.Lang.Object
			{
				// Token: 0x17000366 RID: 870
				// (get) Token: 0x06001139 RID: 4409 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
				[Register("EXTERNAL_CONTENT_URI")]
				public static Android.Net.Uri ExternalContentUri
				{
					get
					{
						return Java.Lang.Object.GetObject<Android.Net.Uri>(MediaStore.Images.Media._members.StaticFields.GetObjectValue("EXTERNAL_CONTENT_URI.Landroid/net/Uri;").Handle, JniHandleOwnership.TransferLocalRef);
					}
				}

				// Token: 0x17000367 RID: 871
				// (get) Token: 0x0600113A RID: 4410 RVA: 0x0002D803 File Offset: 0x0002BA03
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return MediaStore.Images.Media._members;
					}
				}

				// Token: 0x17000368 RID: 872
				// (get) Token: 0x0600113B RID: 4411 RVA: 0x0002D80C File Offset: 0x0002BA0C
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return MediaStore.Images.Media._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x17000369 RID: 873
				// (get) Token: 0x0600113C RID: 4412 RVA: 0x0002D830 File Offset: 0x0002BA30
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return MediaStore.Images.Media._members.ManagedPeerType;
					}
				}

				// Token: 0x0600113D RID: 4413 RVA: 0x000021E0 File Offset: 0x000003E0
				internal Media(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x040007C8 RID: 1992
				private static readonly JniPeerMembers _members = new XAPeerMembers("android/provider/MediaStore$Images$Media", typeof(MediaStore.Images.Media));
			}
		}
	}
}
