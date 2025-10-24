using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000140 RID: 320
	[Register("com/bumptech/glide/load/model/MediaStoreFileLoader", DoNotGenerateAcw = true)]
	public sealed class MediaStoreFileLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00033A0C File Offset: 0x00031C0C
		internal static IntPtr class_ref
		{
			get
			{
				return MediaStoreFileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00033A30 File Offset: 0x00031C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MediaStoreFileLoader._members;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00033A38 File Offset: 0x00031C38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MediaStoreFileLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x00033A5C File Offset: 0x00031C5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MediaStoreFileLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00033A68 File Offset: 0x00031C68
		internal MediaStoreFileLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00033A74 File Offset: 0x00031C74
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaStoreFileLoader(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MediaStoreFileLoader._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MediaStoreFileLoader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00033B24 File Offset: 0x00031D24
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
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(MediaStoreFileLoader._members.InstanceMethods.InvokeAbstractObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00033BF0 File Offset: 0x00031DF0
		[Register("handles", "(Landroid/net/Uri;)Z", "")]
		public unsafe bool Handles(Android.Net.Uri uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = MediaStoreFileLoader._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00033C58 File Offset: 0x00031E58
		ModelLoaderLoadData IModelLoader.BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.BuildLoadData(p0.JavaCast<Android.Net.Uri>(), p1, p2, p3).JavaCast<ModelLoaderLoadData>();
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00033C6F File Offset: 0x00031E6F
		bool IModelLoader.Handles(Java.Lang.Object p0)
		{
			return this.Handles(p0.JavaCast<Android.Net.Uri>());
		}

		// Token: 0x040003B8 RID: 952
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/MediaStoreFileLoader", typeof(MediaStoreFileLoader));

		// Token: 0x020001EE RID: 494
		[Register("com/bumptech/glide/load/model/MediaStoreFileLoader$Factory", DoNotGenerateAcw = true)]
		public sealed class Factory : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x06001775 RID: 6005 RVA: 0x00048C5C File Offset: 0x00046E5C
			internal static IntPtr class_ref
			{
				get
				{
					return MediaStoreFileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x06001776 RID: 6006 RVA: 0x00048C80 File Offset: 0x00046E80
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MediaStoreFileLoader.Factory._members;
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x06001777 RID: 6007 RVA: 0x00048C88 File Offset: 0x00046E88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return MediaStoreFileLoader.Factory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001778 RID: 6008 RVA: 0x00048CAC File Offset: 0x00046EAC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MediaStoreFileLoader.Factory._members.ManagedPeerType;
				}
			}

			// Token: 0x06001779 RID: 6009 RVA: 0x00048CB8 File Offset: 0x00046EB8
			internal Factory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x00048CC4 File Offset: 0x00046EC4
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Factory(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(MediaStoreFileLoader.Factory._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					MediaStoreFileLoader.Factory._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x0600177B RID: 6011 RVA: 0x00048D74 File Offset: 0x00046F74
			[Register("build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", "")]
			public unsafe IModelLoader Build(MultiModelLoaderFactory multiFactory)
			{
				IModelLoader @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((multiFactory == null) ? IntPtr.Zero : multiFactory.Handle);
					@object = Java.Lang.Object.GetObject<IModelLoader>(MediaStoreFileLoader.Factory._members.InstanceMethods.InvokeAbstractObjectMethod("build.(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(multiFactory);
				}
				return @object;
			}

			// Token: 0x0600177C RID: 6012 RVA: 0x00048DE8 File Offset: 0x00046FE8
			[Register("teardown", "()V", "")]
			public void Teardown()
			{
				MediaStoreFileLoader.Factory._members.InstanceMethods.InvokeAbstractVoidMethod("teardown.()V", this, null);
			}

			// Token: 0x0600177D RID: 6013 RVA: 0x00048E01 File Offset: 0x00047001
			IModelLoader IModelLoaderFactory.Build(MultiModelLoaderFactory p0)
			{
				return this.Build(p0).JavaCast<IModelLoader>();
			}

			// Token: 0x0400059B RID: 1435
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/MediaStoreFileLoader$Factory", typeof(MediaStoreFileLoader.Factory));
		}
	}
}
