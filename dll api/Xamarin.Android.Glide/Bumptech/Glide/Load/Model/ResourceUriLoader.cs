using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000144 RID: 324
	[Register("com/bumptech/glide/load/model/ResourceUriLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"DataT"
	})]
	public sealed class ResourceUriLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00034A50 File Offset: 0x00032C50
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00034A74 File Offset: 0x00032C74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceUriLoader._members;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00034A7C File Offset: 0x00032C7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceUriLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00034AA0 File Offset: 0x00032CA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceUriLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00034AAC File Offset: 0x00032CAC
		internal ResourceUriLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00034AB8 File Offset: 0x00032CB8
		[Register("buildLoadData", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "")]
		public unsafe ModelLoaderLoadData BuildLoadData(Java.Lang.Object uri, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(ResourceUriLoader._members.InstanceMethods.InvokeAbstractObjectMethod("buildLoadData.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00034B84 File Offset: 0x00032D84
		[Register("handles", "(Landroid/net/Uri;)Z", "")]
		public unsafe bool Handles(Java.Lang.Object uri)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				result = ResourceUriLoader._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Landroid/net/Uri;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(uri);
			}
			return result;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00034BEC File Offset: 0x00032DEC
		[Register("newAssetFileDescriptorFactory", "(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "")]
		public unsafe static IModelLoaderFactory NewAssetFileDescriptorFactory(Context context)
		{
			IModelLoaderFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoaderFactory>(ResourceUriLoader._members.StaticMethods.InvokeObjectMethod("newAssetFileDescriptorFactory.(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00034C60 File Offset: 0x00032E60
		[Register("newStreamFactory", "(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "")]
		public unsafe static IModelLoaderFactory NewStreamFactory(Context context)
		{
			IModelLoaderFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoaderFactory>(ResourceUriLoader._members.StaticMethods.InvokeObjectMethod("newStreamFactory.(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x040003C7 RID: 967
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ResourceUriLoader", typeof(ResourceUriLoader));
	}
}
