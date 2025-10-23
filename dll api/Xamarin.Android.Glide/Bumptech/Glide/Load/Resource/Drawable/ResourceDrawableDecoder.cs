using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F5 RID: 245
	[Register("com/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder", DoNotGenerateAcw = true)]
	public class ResourceDrawableDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00025F04 File Offset: 0x00024104
		[Register("THEME")]
		public static Option Theme
		{
			get
			{
				return Java.Lang.Object.GetObject<Option>(ResourceDrawableDecoder._members.StaticFields.GetObjectValue("THEME.Lcom/bumptech/glide/load/Option;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00025F34 File Offset: 0x00024134
		internal static IntPtr class_ref
		{
			get
			{
				return ResourceDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00025F58 File Offset: 0x00024158
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResourceDrawableDecoder._members;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00025F60 File Offset: 0x00024160
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResourceDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00025F84 File Offset: 0x00024184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResourceDrawableDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00025F90 File Offset: 0x00024190
		protected ResourceDrawableDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00025F9C File Offset: 0x0002419C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ResourceDrawableDecoder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ResourceDrawableDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ResourceDrawableDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0002604C File Offset: 0x0002424C
		private static Delegate GetDecode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (ResourceDrawableDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ == null)
			{
				ResourceDrawableDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(ResourceDrawableDecoder.n_Decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_));
			}
			return ResourceDrawableDecoder.cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00026070 File Offset: 0x00024270
		private static IntPtr n_Decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			ResourceDrawableDecoder @object = Java.Lang.Object.GetObject<ResourceDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000260A8 File Offset: 0x000242A8
		[Register("decode", "(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Android.Net.Uri source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(ResourceDrawableDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Landroid/net/Uri;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00026174 File Offset: 0x00024374
		private static Delegate GetHandles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (ResourceDrawableDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_ == null)
			{
				ResourceDrawableDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ResourceDrawableDecoder.n_Handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_));
			}
			return ResourceDrawableDecoder.cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00026198 File Offset: 0x00024398
		private static bool n_Handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			ResourceDrawableDecoder @object = Java.Lang.Object.GetObject<ResourceDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000261C4 File Offset: 0x000243C4
		[Register("handles", "(Landroid/net/Uri;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Android.Net.Uri source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = ResourceDrawableDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/net/Uri;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00026254 File Offset: 0x00024454
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<Android.Net.Uri>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0002626B File Offset: 0x0002446B
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<Android.Net.Uri>(), p1);
		}

		// Token: 0x040002EF RID: 751
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder", typeof(ResourceDrawableDecoder));

		// Token: 0x040002F0 RID: 752
		private static Delegate cb_decode_Landroid_net_Uri_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_handles_Landroid_net_Uri_Lcom_bumptech_glide_load_Options_;
	}
}
