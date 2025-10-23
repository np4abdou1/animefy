using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;
using Java.Security;

namespace Bumptech.Glide.Load.Resource
{
	// Token: 0x020000E4 RID: 228
	[Register("com/bumptech/glide/load/resource/UnitTransformation", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class UnitTransformation : Java.Lang.Object, ITransformation, IKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x000238E0 File Offset: 0x00021AE0
		internal static IntPtr class_ref
		{
			get
			{
				return UnitTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00023904 File Offset: 0x00021B04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnitTransformation._members;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002390C File Offset: 0x00021B0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnitTransformation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00023930 File Offset: 0x00021B30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnitTransformation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002393C File Offset: 0x00021B3C
		internal UnitTransformation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00023948 File Offset: 0x00021B48
		[Register("get", "()Lcom/bumptech/glide/load/resource/UnitTransformation;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static UnitTransformation Get()
		{
			return Java.Lang.Object.GetObject<UnitTransformation>(UnitTransformation._members.StaticMethods.InvokeObjectMethod("get.()Lcom/bumptech/glide/load/resource/UnitTransformation;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002397C File Offset: 0x00021B7C
		[Register("transform", "(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", "")]
		public unsafe IResource Transform(Context context, IResource resource, int outWidth, int outHeight)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((resource == null) ? IntPtr.Zero : ((Java.Lang.Object)resource).Handle);
				ptr[2] = new JniArgumentValue(outWidth);
				ptr[3] = new JniArgumentValue(outHeight);
				@object = Java.Lang.Object.GetObject<IResource>(UnitTransformation._members.InstanceMethods.InvokeAbstractObjectMethod("transform.(Landroid/content/Context;Lcom/bumptech/glide/load/engine/Resource;II)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(resource);
			}
			return @object;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00023A4C File Offset: 0x00021C4C
		[Register("updateDiskCacheKey", "(Ljava/security/MessageDigest;)V", "")]
		public unsafe void UpdateDiskCacheKey(MessageDigest messageDigest)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((messageDigest == null) ? IntPtr.Zero : messageDigest.Handle);
				UnitTransformation._members.InstanceMethods.InvokeAbstractVoidMethod("updateDiskCacheKey.(Ljava/security/MessageDigest;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(messageDigest);
			}
		}

		// Token: 0x040002CF RID: 719
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/UnitTransformation", typeof(UnitTransformation));
	}
}
