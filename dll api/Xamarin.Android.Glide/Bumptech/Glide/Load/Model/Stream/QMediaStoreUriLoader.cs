using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x02000147 RID: 327
	[Register("com/bumptech/glide/load/model/stream/QMediaStoreUriLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"DataT"
	})]
	public sealed class QMediaStoreUriLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x00035233 File Offset: 0x00033433
		public bool Handles(Java.Lang.Object uri)
		{
			return this.Handles((Android.Net.Uri)uri);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00035241 File Offset: 0x00033441
		public ModelLoaderLoadData BuildLoadData(Java.Lang.Object uri, int width, int height, Options options)
		{
			return this.BuildLoadData((Android.Net.Uri)uri, width, height, options);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00035254 File Offset: 0x00033454
		internal static IntPtr class_ref
		{
			get
			{
				return QMediaStoreUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00035278 File Offset: 0x00033478
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return QMediaStoreUriLoader._members;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x00035280 File Offset: 0x00033480
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return QMediaStoreUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000352A4 File Offset: 0x000334A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return QMediaStoreUriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000352B0 File Offset: 0x000334B0
		internal QMediaStoreUriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000352BC File Offset: 0x000334BC
		[Register("buildLoadData", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "")]
		public unsafe ModelLoaderLoadData BuildLoadData(Android.Net.Uri uri, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(QMediaStoreUriLoader._members.InstanceMethods.InvokeAbstractObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x00035388 File Offset: 0x00033588
		[Register("handles", "(Landroid/net/Uri;)Z", "")]
		public unsafe bool Handles(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = QMediaStoreUriLoader._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x040003CD RID: 973
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/QMediaStoreUriLoader", typeof(QMediaStoreUriLoader));
	}
}
