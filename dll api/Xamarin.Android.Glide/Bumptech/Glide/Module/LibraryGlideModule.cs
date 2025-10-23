using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006D RID: 109
	[Register("com/bumptech/glide/module/LibraryGlideModule", DoNotGenerateAcw = true)]
	public abstract class LibraryGlideModule : Java.Lang.Object, IRegistersComponents, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00010348 File Offset: 0x0000E548
		internal static IntPtr class_ref
		{
			get
			{
				return LibraryGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0001036C File Offset: 0x0000E56C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LibraryGlideModule._members;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00010374 File Offset: 0x0000E574
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LibraryGlideModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00010398 File Offset: 0x0000E598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LibraryGlideModule._members.ManagedPeerType;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000103A4 File Offset: 0x0000E5A4
		protected LibraryGlideModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Register(".ctor", "()V", "")]
		public LibraryGlideModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LibraryGlideModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LibraryGlideModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001041E File Offset: 0x0000E61E
		private static Delegate GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_Handler()
		{
			if (LibraryGlideModule.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ == null)
			{
				LibraryGlideModule.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(LibraryGlideModule.n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_));
			}
			return LibraryGlideModule.cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00010444 File Offset: 0x0000E644
		private static void n_RegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_glide, IntPtr native_registry)
		{
			LibraryGlideModule @object = Java.Lang.Object.GetObject<LibraryGlideModule>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Glide object3 = Java.Lang.Object.GetObject<Glide>(native_glide, JniHandleOwnership.DoNotTransfer);
			Registry object4 = Java.Lang.Object.GetObject<Registry>(native_registry, JniHandleOwnership.DoNotTransfer);
			@object.RegisterComponents(object2, object3, object4);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001047C File Offset: 0x0000E67C
		[Register("registerComponents", "(Landroid/content/Context;Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/Registry;)V", "GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_Handler")]
		public unsafe virtual void RegisterComponents(Context context, Glide glide, Registry registry)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((glide == null) ? IntPtr.Zero : glide.Handle);
				ptr[2] = new JniArgumentValue((registry == null) ? IntPtr.Zero : registry.Handle);
				LibraryGlideModule._members.InstanceMethods.InvokeVirtualVoidMethod("registerComponents.(Landroid/content/Context;Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/Registry;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(glide);
				GC.KeepAlive(registry);
			}
		}

		// Token: 0x04000106 RID: 262
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/LibraryGlideModule", typeof(LibraryGlideModule));

		// Token: 0x04000107 RID: 263
		private static Delegate cb_registerComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_;
	}
}
