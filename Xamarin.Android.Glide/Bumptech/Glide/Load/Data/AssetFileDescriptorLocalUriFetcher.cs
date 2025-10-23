using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000186 RID: 390
	[Register("com/bumptech/glide/load/data/AssetFileDescriptorLocalUriFetcher", DoNotGenerateAcw = true)]
	public sealed class AssetFileDescriptorLocalUriFetcher : LocalUriFetcher
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x0003EF8F File Offset: 0x0003D18F
		protected override void Close(Java.Lang.Object data)
		{
			this.Close((AssetFileDescriptor)data);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0003EF9D File Offset: 0x0003D19D
		protected override Java.Lang.Object LoadResource(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			return this.LoadResource_T(uri, contentResolver);
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		internal new static IntPtr class_ref
		{
			get
			{
				return AssetFileDescriptorLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0003EFCC File Offset: 0x0003D1CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetFileDescriptorLocalUriFetcher._members;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0003EFD4 File Offset: 0x0003D1D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AssetFileDescriptorLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0003EFF8 File Offset: 0x0003D1F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetFileDescriptorLocalUriFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0003F004 File Offset: 0x0003D204
		internal AssetFileDescriptorLocalUriFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0003F010 File Offset: 0x0003D210
		[Register(".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "")]
		public unsafe AssetFileDescriptorLocalUriFetcher(ContentResolver contentResolver, Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				base.SetHandle(AssetFileDescriptorLocalUriFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AssetFileDescriptorLocalUriFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contentResolver);
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0003F0E8 File Offset: 0x0003D2E8
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(AssetFileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeAbstractObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0003F11C File Offset: 0x0003D31C
		[Register("close", "(Landroid/content/res/AssetFileDescriptor;)V", "")]
		private unsafe void Close(AssetFileDescriptor data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				AssetFileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeAbstractVoidMethod("close.(Landroid/content/res/AssetFileDescriptor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003F180 File Offset: 0x0003D380
		[Register("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/content/res/AssetFileDescriptor;", "")]
		private unsafe AssetFileDescriptor LoadResource_T(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			AssetFileDescriptor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
				@object = Java.Lang.Object.GetObject<AssetFileDescriptor>(AssetFileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeAbstractObjectMethod("loadResource.(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/content/res/AssetFileDescriptor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(contentResolver);
			}
			return @object;
		}

		// Token: 0x040004A6 RID: 1190
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/AssetFileDescriptorLocalUriFetcher", typeof(AssetFileDescriptorLocalUriFetcher));
	}
}
