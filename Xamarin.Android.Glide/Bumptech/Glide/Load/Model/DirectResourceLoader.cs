using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000130 RID: 304
	[Register("com/bumptech/glide/load/model/DirectResourceLoader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"DataT"
	})]
	public sealed class DirectResourceLoader : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x000321BC File Offset: 0x000303BC
		internal static IntPtr class_ref
		{
			get
			{
				return DirectResourceLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x000321E0 File Offset: 0x000303E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DirectResourceLoader._members;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000321E8 File Offset: 0x000303E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DirectResourceLoader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0003220C File Offset: 0x0003040C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DirectResourceLoader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00032218 File Offset: 0x00030418
		internal DirectResourceLoader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00032224 File Offset: 0x00030424
		[Register("assetFileDescriptorFactory", "(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "")]
		public unsafe static IModelLoaderFactory AssetFileDescriptorFactory(Context context)
		{
			IModelLoaderFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoaderFactory>(DirectResourceLoader._members.StaticMethods.InvokeObjectMethod("assetFileDescriptorFactory.(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00032298 File Offset: 0x00030498
		[Register("buildLoadData", "(Ljava/lang/Integer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", "")]
		public unsafe ModelLoaderLoadData BuildLoadData(Java.Lang.Object resourceId, int width, int height, Options options)
		{
			ModelLoaderLoadData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceId == null) ? IntPtr.Zero : resourceId.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(DirectResourceLoader._members.InstanceMethods.InvokeAbstractObjectMethod("buildLoadData.(Ljava/lang/Integer;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceId);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00032364 File Offset: 0x00030564
		[Register("drawableFactory", "(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "")]
		public unsafe static IModelLoaderFactory DrawableFactory(Context context)
		{
			IModelLoaderFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoaderFactory>(DirectResourceLoader._members.StaticMethods.InvokeObjectMethod("drawableFactory.(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000323D8 File Offset: 0x000305D8
		[Register("handles", "(Ljava/lang/Integer;)Z", "")]
		public unsafe bool Handles(Java.Lang.Object integer)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((integer == null) ? IntPtr.Zero : integer.Handle);
				result = DirectResourceLoader._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/lang/Integer;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(integer);
			}
			return result;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00032440 File Offset: 0x00030640
		[Register("inputStreamFactory", "(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", "")]
		public unsafe static IModelLoaderFactory InputStreamFactory(Context context)
		{
			IModelLoaderFactory @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoaderFactory>(DirectResourceLoader._members.StaticMethods.InvokeObjectMethod("inputStreamFactory.(Landroid/content/Context;)Lcom/bumptech/glide/load/model/ModelLoaderFactory;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x04000395 RID: 917
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/DirectResourceLoader", typeof(DirectResourceLoader));
	}
}
