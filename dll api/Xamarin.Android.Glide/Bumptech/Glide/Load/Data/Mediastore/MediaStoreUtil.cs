using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data.Mediastore
{
	// Token: 0x0200019F RID: 415
	[Register("com/bumptech/glide/load/data/mediastore/MediaStoreUtil", DoNotGenerateAcw = true)]
	public sealed class MediaStoreUtil : Java.Lang.Object
	{
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000423EC File Offset: 0x000405EC
		internal static IntPtr class_ref
		{
			get
			{
				return MediaStoreUtil._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x00042410 File Offset: 0x00040610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStoreUtil._members;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00042418 File Offset: 0x00040618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStoreUtil._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0004243C File Offset: 0x0004063C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStoreUtil._members.ManagedPeerType;
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00042448 File Offset: 0x00040648
		internal MediaStoreUtil(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00042454 File Offset: 0x00040654
		[Register("isMediaStoreImageUri", "(Landroid/net/Uri;)Z", "")]
		public unsafe static bool IsMediaStoreImageUri(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = MediaStoreUtil._members.StaticMethods.InvokeBooleanMethod("isMediaStoreImageUri.(Landroid/net/Uri;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000424B8 File Offset: 0x000406B8
		[Register("isMediaStoreUri", "(Landroid/net/Uri;)Z", "")]
		public unsafe static bool IsMediaStoreUri(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = MediaStoreUtil._members.StaticMethods.InvokeBooleanMethod("isMediaStoreUri.(Landroid/net/Uri;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0004251C File Offset: 0x0004071C
		[Register("isMediaStoreVideoUri", "(Landroid/net/Uri;)Z", "")]
		public unsafe static bool IsMediaStoreVideoUri(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = MediaStoreUtil._members.StaticMethods.InvokeBooleanMethod("isMediaStoreVideoUri.(Landroid/net/Uri;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00042580 File Offset: 0x00040780
		[Register("isThumbnailSize", "(II)Z", "")]
		public unsafe static bool IsThumbnailSize(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return MediaStoreUtil._members.StaticMethods.InvokeBooleanMethod("isThumbnailSize.(II)Z", ptr);
		}

		// Token: 0x040004F7 RID: 1271
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/mediastore/MediaStoreUtil", typeof(MediaStoreUtil));
	}
}
