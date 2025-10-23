using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000188 RID: 392
	[Register("com/bumptech/glide/load/data/FileDescriptorLocalUriFetcher", DoNotGenerateAcw = true)]
	public class FileDescriptorLocalUriFetcher : LocalUriFetcher
	{
		// Token: 0x060013C5 RID: 5061 RVA: 0x0003F5A3 File Offset: 0x0003D7A3
		protected override void Close(Java.Lang.Object data)
		{
			this.Close((ParcelFileDescriptor)data);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0003F5B1 File Offset: 0x0003D7B1
		protected override Java.Lang.Object LoadResource(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			return this.LoadResource_T(uri, contentResolver);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0003F5BC File Offset: 0x0003D7BC
		internal new static IntPtr class_ref
		{
			get
			{
				return FileDescriptorLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0003F5E0 File Offset: 0x0003D7E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileDescriptorLocalUriFetcher._members;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileDescriptorLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0003F60C File Offset: 0x0003D80C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileDescriptorLocalUriFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0003F618 File Offset: 0x0003D818
		protected FileDescriptorLocalUriFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0003F624 File Offset: 0x0003D824
		[Register(".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "")]
		public unsafe FileDescriptorLocalUriFetcher(ContentResolver contentResolver, Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FileDescriptorLocalUriFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileDescriptorLocalUriFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(contentResolver);
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0003F6FC File Offset: 0x0003D8FC
		private static Delegate GetGetDataClassHandler()
		{
			if (FileDescriptorLocalUriFetcher.cb_getDataClass == null)
			{
				FileDescriptorLocalUriFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(FileDescriptorLocalUriFetcher.n_GetDataClass));
			}
			return FileDescriptorLocalUriFetcher.cb_getDataClass;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0003F720 File Offset: 0x0003D920
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FileDescriptorLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x0003F734 File Offset: 0x0003D934
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(FileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0003F766 File Offset: 0x0003D966
		private static Delegate GetClose_Landroid_os_ParcelFileDescriptor_Handler()
		{
			if (FileDescriptorLocalUriFetcher.cb_close_Landroid_os_ParcelFileDescriptor_ == null)
			{
				FileDescriptorLocalUriFetcher.cb_close_Landroid_os_ParcelFileDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(FileDescriptorLocalUriFetcher.n_Close_Landroid_os_ParcelFileDescriptor_));
			}
			return FileDescriptorLocalUriFetcher.cb_close_Landroid_os_ParcelFileDescriptor_;
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0003F78C File Offset: 0x0003D98C
		private static void n_Close_Landroid_os_ParcelFileDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			FileDescriptorLocalUriFetcher @object = Java.Lang.Object.GetObject<FileDescriptorLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ParcelFileDescriptor object2 = Java.Lang.Object.GetObject<ParcelFileDescriptor>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.Close(object2);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0003F7B0 File Offset: 0x0003D9B0
		[Register("close", "(Landroid/os/ParcelFileDescriptor;)V", "GetClose_Landroid_os_ParcelFileDescriptor_Handler")]
		protected unsafe virtual void Close(ParcelFileDescriptor data)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
				FileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("close.(Landroid/os/ParcelFileDescriptor;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0003F814 File Offset: 0x0003DA14
		private static Delegate GetLoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_Handler()
		{
			if (FileDescriptorLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == null)
			{
				FileDescriptorLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(FileDescriptorLocalUriFetcher.n_LoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_));
			}
			return FileDescriptorLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0003F838 File Offset: 0x0003DA38
		private static IntPtr n_LoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_contentResolver)
		{
			FileDescriptorLocalUriFetcher @object = Java.Lang.Object.GetObject<FileDescriptorLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			ContentResolver object3 = Java.Lang.Object.GetObject<ContentResolver>(native_contentResolver, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.LoadResource_T(object2, object3));
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0003F86C File Offset: 0x0003DA6C
		[Register("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/os/ParcelFileDescriptor;", "GetLoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected unsafe virtual ParcelFileDescriptor LoadResource_T(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			ParcelFileDescriptor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
				@object = Java.Lang.Object.GetObject<ParcelFileDescriptor>(FileDescriptorLocalUriFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("loadResource.(Landroid/net/Uri;Landroid/content/ContentResolver;)Landroid/os/ParcelFileDescriptor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(contentResolver);
			}
			return @object;
		}

		// Token: 0x040004AB RID: 1195
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/FileDescriptorLocalUriFetcher", typeof(FileDescriptorLocalUriFetcher));

		// Token: 0x040004AC RID: 1196
		private static Delegate cb_getDataClass;

		// Token: 0x040004AD RID: 1197
		private static Delegate cb_close_Landroid_os_ParcelFileDescriptor_;

		// Token: 0x040004AE RID: 1198
		private static Delegate cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
	}
}
