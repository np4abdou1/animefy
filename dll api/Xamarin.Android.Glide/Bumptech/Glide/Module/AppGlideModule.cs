using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x02000065 RID: 101
	[Register("com/bumptech/glide/module/AppGlideModule", DoNotGenerateAcw = true)]
	public abstract class AppGlideModule : LibraryGlideModule, IAppliesOptions, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000FA10 File Offset: 0x0000DC10
		internal new static IntPtr class_ref
		{
			get
			{
				return AppGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0000FA34 File Offset: 0x0000DC34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppGlideModule._members;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0000FA60 File Offset: 0x0000DC60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppGlideModule._members.ManagedPeerType;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000FA6C File Offset: 0x0000DC6C
		protected AppGlideModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000FA78 File Offset: 0x0000DC78
		[Register(".ctor", "()V", "")]
		public AppGlideModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppGlideModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppGlideModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000FAE6 File Offset: 0x0000DCE6
		private static Delegate GetIsManifestParsingEnabledHandler()
		{
			if (AppGlideModule.cb_isManifestParsingEnabled == null)
			{
				AppGlideModule.cb_isManifestParsingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppGlideModule.n_IsManifestParsingEnabled));
			}
			return AppGlideModule.cb_isManifestParsingEnabled;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000FB0A File Offset: 0x0000DD0A
		private static bool n_IsManifestParsingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsManifestParsingEnabled;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000FB19 File Offset: 0x0000DD19
		public virtual bool IsManifestParsingEnabled
		{
			[Register("isManifestParsingEnabled", "()Z", "GetIsManifestParsingEnabledHandler")]
			get
			{
				return AppGlideModule._members.InstanceMethods.InvokeVirtualBooleanMethod("isManifestParsingEnabled.()Z", this, null);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000FB32 File Offset: 0x0000DD32
		private static Delegate GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler()
		{
			if (AppGlideModule.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ == null)
			{
				AppGlideModule.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppGlideModule.n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_));
			}
			return AppGlideModule.cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000FB58 File Offset: 0x0000DD58
		private static void n_ApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_builder)
		{
			AppGlideModule @object = Java.Lang.Object.GetObject<AppGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			GlideBuilder object3 = Java.Lang.Object.GetObject<GlideBuilder>(native_builder, JniHandleOwnership.DoNotTransfer);
			@object.ApplyOptions(object2, object3);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000FB84 File Offset: 0x0000DD84
		[Register("applyOptions", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", "GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler")]
		public unsafe virtual void ApplyOptions(Context context, GlideBuilder builder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				AppGlideModule._members.InstanceMethods.InvokeVirtualVoidMethod("applyOptions.(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(builder);
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/AppGlideModule", typeof(AppGlideModule));

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_isManifestParsingEnabled;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_applyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_;
	}
}
