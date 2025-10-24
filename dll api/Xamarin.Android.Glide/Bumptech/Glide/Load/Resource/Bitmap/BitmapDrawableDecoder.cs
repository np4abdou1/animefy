using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Engine.BitmapRecycle;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x020000FC RID: 252
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapDrawableDecoder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"DataType"
	})]
	public class BitmapDrawableDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00027558 File Offset: 0x00025758
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0002757C File Offset: 0x0002577C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapDrawableDecoder._members;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00027584 File Offset: 0x00025784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000275A8 File Offset: 0x000257A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapDrawableDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000275B4 File Offset: 0x000257B4
		protected BitmapDrawableDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000275C0 File Offset: 0x000257C0
		[Register(".ctor", "(Landroid/content/Context;Lcom/bumptech/glide/load/ResourceDecoder;)V", "")]
		public unsafe BitmapDrawableDecoder(Context context, IResourceDecoder decoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				base.SetHandle(BitmapDrawableDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/load/ResourceDecoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/bumptech/glide/load/ResourceDecoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(decoder);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0002769C File Offset: 0x0002589C
		[Register(".ctor", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceDecoder;)V", "")]
		[Obsolete("deprecated")]
		public unsafe BitmapDrawableDecoder(Resources resources, IBitmapPool bitmapPool, IResourceDecoder decoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((bitmapPool == null) ? IntPtr.Zero : ((Java.Lang.Object)bitmapPool).Handle);
				ptr[2] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				base.SetHandle(BitmapDrawableDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceDecoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/engine/bitmap_recycle/BitmapPool;Lcom/bumptech/glide/load/ResourceDecoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(bitmapPool);
				GC.KeepAlive(decoder);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x000277A8 File Offset: 0x000259A8
		[Register(".ctor", "(Landroid/content/res/Resources;Lcom/bumptech/glide/load/ResourceDecoder;)V", "")]
		public unsafe BitmapDrawableDecoder(Resources resources, IResourceDecoder decoder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resources == null) ? IntPtr.Zero : resources.Handle);
				ptr[1] = new JniArgumentValue((decoder == null) ? IntPtr.Zero : ((Java.Lang.Object)decoder).Handle);
				base.SetHandle(BitmapDrawableDecoder._members.InstanceMethods.StartCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/ResourceDecoder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapDrawableDecoder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/res/Resources;Lcom/bumptech/glide/load/ResourceDecoder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(resources);
				GC.KeepAlive(decoder);
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00027884 File Offset: 0x00025A84
		private static Delegate GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapDrawableDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				BitmapDrawableDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(BitmapDrawableDecoder.n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return BitmapDrawableDecoder.cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000278A8 File Offset: 0x00025AA8
		private static IntPtr n_Decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			BitmapDrawableDecoder @object = Java.Lang.Object.GetObject<BitmapDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000278E0 File Offset: 0x00025AE0
		[Register("decode", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Java.Lang.Object source, int width, int height, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(source);
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(BitmapDrawableDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x000279A8 File Offset: 0x00025BA8
		private static Delegate GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (BitmapDrawableDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ == null)
			{
				BitmapDrawableDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(BitmapDrawableDecoder.n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_));
			}
			return BitmapDrawableDecoder.cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000279CC File Offset: 0x00025BCC
		private static bool n_Handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			BitmapDrawableDecoder @object = Java.Lang.Object.GetObject<BitmapDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x000279F8 File Offset: 0x00025BF8
		[Register("handles", "(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Java.Lang.Object source, Options options)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(source);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = BitmapDrawableDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Ljava/lang/Object;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x04000306 RID: 774
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapDrawableDecoder", typeof(BitmapDrawableDecoder));

		// Token: 0x04000307 RID: 775
		private static Delegate cb_decode_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x04000308 RID: 776
		private static Delegate cb_handles_Ljava_lang_Object_Lcom_bumptech_glide_load_Options_;
	}
}
