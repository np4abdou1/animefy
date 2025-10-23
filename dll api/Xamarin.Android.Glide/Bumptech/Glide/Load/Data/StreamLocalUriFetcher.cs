using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018A RID: 394
	[Register("com/bumptech/glide/load/data/StreamLocalUriFetcher", DoNotGenerateAcw = true)]
	public class StreamLocalUriFetcher : LocalUriFetcher
	{
		// Token: 0x060013E9 RID: 5097 RVA: 0x0003FCE0 File Offset: 0x0003DEE0
		protected override void Close(Java.Lang.Object data)
		{
			Stream data2 = InputStreamInvoker.FromJniHandle(((InputStream)data).Handle, JniHandleOwnership.DoNotTransfer);
			this.Close(data2);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0003FD08 File Offset: 0x0003DF08
		protected override Java.Lang.Object LoadResource(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(this.LoadResource_T(uri, contentResolver));
			Java.Lang.Object result;
			try
			{
				result = new Java.Lang.Object(intPtr, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x0003FD48 File Offset: 0x0003DF48
		internal new static IntPtr class_ref
		{
			get
			{
				return StreamLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StreamLocalUriFetcher._members;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x0003FD74 File Offset: 0x0003DF74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StreamLocalUriFetcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0003FD98 File Offset: 0x0003DF98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StreamLocalUriFetcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0003FDA4 File Offset: 0x0003DFA4
		protected StreamLocalUriFetcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0003FDB0 File Offset: 0x0003DFB0
		[Register(".ctor", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V", "")]
		public unsafe StreamLocalUriFetcher(ContentResolver resolver, Android.Net.Uri uri) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resolver == null) ? IntPtr.Zero : resolver.Handle);
				ptr[1] = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				base.SetHandle(StreamLocalUriFetcher._members.InstanceMethods.StartCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				StreamLocalUriFetcher._members.InstanceMethods.FinishCreateInstance("(Landroid/content/ContentResolver;Landroid/net/Uri;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resolver);
				GC.KeepAlive(uri);
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0003FE88 File Offset: 0x0003E088
		private static Delegate GetGetDataClassHandler()
		{
			if (StreamLocalUriFetcher.cb_getDataClass == null)
			{
				StreamLocalUriFetcher.cb_getDataClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(StreamLocalUriFetcher.n_GetDataClass));
			}
			return StreamLocalUriFetcher.cb_getDataClass;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0003FEAC File Offset: 0x0003E0AC
		private static IntPtr n_GetDataClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<StreamLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DataClass);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0003FEC0 File Offset: 0x0003E0C0
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(StreamLocalUriFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0003FEF2 File Offset: 0x0003E0F2
		private static Delegate GetClose_Ljava_io_InputStream_Handler()
		{
			if (StreamLocalUriFetcher.cb_close_Ljava_io_InputStream_ == null)
			{
				StreamLocalUriFetcher.cb_close_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StreamLocalUriFetcher.n_Close_Ljava_io_InputStream_));
			}
			return StreamLocalUriFetcher.cb_close_Ljava_io_InputStream_;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0003FF18 File Offset: 0x0003E118
		private static void n_Close_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			StreamLocalUriFetcher @object = Java.Lang.Object.GetObject<StreamLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream data = InputStreamInvoker.FromJniHandle(native_data, JniHandleOwnership.DoNotTransfer);
			@object.Close(data);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0003FF3C File Offset: 0x0003E13C
		[Register("close", "(Ljava/io/InputStream;)V", "GetClose_Ljava_io_InputStream_Handler")]
		protected unsafe virtual void Close(Stream data)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				StreamLocalUriFetcher._members.InstanceMethods.InvokeVirtualVoidMethod("close.(Ljava/io/InputStream;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0003FFA0 File Offset: 0x0003E1A0
		private static Delegate GetLoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_Handler()
		{
			if (StreamLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ == null)
			{
				StreamLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(StreamLocalUriFetcher.n_LoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_));
			}
			return StreamLocalUriFetcher.cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		private static IntPtr n_LoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_contentResolver)
		{
			StreamLocalUriFetcher @object = Java.Lang.Object.GetObject<StreamLocalUriFetcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_uri, JniHandleOwnership.DoNotTransfer);
			ContentResolver object3 = Java.Lang.Object.GetObject<ContentResolver>(native_contentResolver, JniHandleOwnership.DoNotTransfer);
			return InputStreamAdapter.ToLocalJniHandle(@object.LoadResource_T(object2, object3));
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		[Register("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/io/InputStream;", "GetLoadResource_T_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected unsafe virtual Stream LoadResource_T(Android.Net.Uri uri, ContentResolver contentResolver)
		{
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((uri == null) ? IntPtr.Zero : uri.Handle);
				ptr[1] = new JniArgumentValue((contentResolver == null) ? IntPtr.Zero : contentResolver.Handle);
				result = InputStreamInvoker.FromJniHandle(StreamLocalUriFetcher._members.InstanceMethods.InvokeVirtualObjectMethod("loadResource.(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/io/InputStream;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(uri);
				GC.KeepAlive(contentResolver);
			}
			return result;
		}

		// Token: 0x040004B3 RID: 1203
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/StreamLocalUriFetcher", typeof(StreamLocalUriFetcher));

		// Token: 0x040004B4 RID: 1204
		private static Delegate cb_getDataClass;

		// Token: 0x040004B5 RID: 1205
		private static Delegate cb_close_Ljava_io_InputStream_;

		// Token: 0x040004B6 RID: 1206
		private static Delegate cb_loadResource_Landroid_net_Uri_Landroid_content_ContentResolver_;
	}
}
