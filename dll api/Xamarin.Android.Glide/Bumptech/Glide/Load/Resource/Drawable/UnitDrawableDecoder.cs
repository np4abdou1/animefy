using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F6 RID: 246
	[Register("com/bumptech/glide/load/resource/drawable/UnitDrawableDecoder", DoNotGenerateAcw = true)]
	public class UnitDrawableDecoder : Java.Lang.Object, IResourceDecoder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00026298 File Offset: 0x00024498
		internal static IntPtr class_ref
		{
			get
			{
				return UnitDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x000262BC File Offset: 0x000244BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnitDrawableDecoder._members;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x000262C4 File Offset: 0x000244C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnitDrawableDecoder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000262E8 File Offset: 0x000244E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnitDrawableDecoder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000262F4 File Offset: 0x000244F4
		protected UnitDrawableDecoder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00026300 File Offset: 0x00024500
		[Register(".ctor", "()V", "")]
		public UnitDrawableDecoder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnitDrawableDecoder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnitDrawableDecoder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0002636E File Offset: 0x0002456E
		private static Delegate GetDecode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (UnitDrawableDecoder.cb_decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_ == null)
			{
				UnitDrawableDecoder.cb_decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(UnitDrawableDecoder.n_Decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_));
			}
			return UnitDrawableDecoder.cb_decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00026394 File Offset: 0x00024594
		private static IntPtr n_Decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int width, int height, IntPtr native_options)
		{
			UnitDrawableDecoder @object = Java.Lang.Object.GetObject<UnitDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode(object2, width, height, object3));
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000263CC File Offset: 0x000245CC
		[Register("decode", "(Landroid/graphics/drawable/Drawable;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", "GetDecode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual IResource Decode(Drawable source, int width, int height, Options options)
		{
			IResource @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue(width);
				ptr[2] = new JniArgumentValue(height);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<IResource>(UnitDrawableDecoder._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Landroid/graphics/drawable/Drawable;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/engine/Resource;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00026498 File Offset: 0x00024698
		private static Delegate GetHandles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_Handler()
		{
			if (UnitDrawableDecoder.cb_handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_ == null)
			{
				UnitDrawableDecoder.cb_handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(UnitDrawableDecoder.n_Handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_));
			}
			return UnitDrawableDecoder.cb_handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x000264BC File Offset: 0x000246BC
		private static bool n_Handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_options)
		{
			UnitDrawableDecoder @object = Java.Lang.Object.GetObject<UnitDrawableDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_source, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_options, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2, object3);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000264E8 File Offset: 0x000246E8
		[Register("handles", "(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/load/Options;)Z", "GetHandles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_Handler")]
		public unsafe virtual bool Handles(Drawable source, Options options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = UnitDrawableDecoder._members.InstanceMethods.InvokeVirtualBooleanMethod("handles.(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/load/Options;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(source);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00026578 File Offset: 0x00024778
		IResource IResourceDecoder.Decode(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			return this.Decode(p0.JavaCast<Drawable>(), p1, p2, p3).JavaCast<IResource>();
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0002658F File Offset: 0x0002478F
		bool IResourceDecoder.Handles(Java.Lang.Object p0, Options p1)
		{
			return this.Handles(p0.JavaCast<Drawable>(), p1);
		}

		// Token: 0x040002F2 RID: 754
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/UnitDrawableDecoder", typeof(UnitDrawableDecoder));

		// Token: 0x040002F3 RID: 755
		private static Delegate cb_decode_Landroid_graphics_drawable_Drawable_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040002F4 RID: 756
		private static Delegate cb_handles_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_load_Options_;
	}
}
