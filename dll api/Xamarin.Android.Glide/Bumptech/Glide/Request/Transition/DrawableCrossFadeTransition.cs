using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009E RID: 158
	[Register("com/bumptech/glide/request/transition/DrawableCrossFadeTransition", DoNotGenerateAcw = true)]
	public class DrawableCrossFadeTransition : Java.Lang.Object, ITransition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00019E0C File Offset: 0x0001800C
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableCrossFadeTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00019E30 File Offset: 0x00018030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableCrossFadeTransition._members;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00019E38 File Offset: 0x00018038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableCrossFadeTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00019E5C File Offset: 0x0001805C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableCrossFadeTransition._members.ManagedPeerType;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00019E68 File Offset: 0x00018068
		protected DrawableCrossFadeTransition(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00019E74 File Offset: 0x00018074
		[Register(".ctor", "(IZ)V", "")]
		public unsafe DrawableCrossFadeTransition(int duration, bool isCrossFadeEnabled) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			ptr[1] = new JniArgumentValue(isCrossFadeEnabled);
			base.SetHandle(DrawableCrossFadeTransition._members.InstanceMethods.StartCreateInstance("(IZ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			DrawableCrossFadeTransition._members.InstanceMethods.FinishCreateInstance("(IZ)V", this, ptr);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00019F0B File Offset: 0x0001810B
		private static Delegate GetTransition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler()
		{
			if (DrawableCrossFadeTransition.cb_transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == null)
			{
				DrawableCrossFadeTransition.cb_transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(DrawableCrossFadeTransition.n_Transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_));
			}
			return DrawableCrossFadeTransition.cb_transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00019F30 File Offset: 0x00018130
		private static bool n_Transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_current, IntPtr native_adapter)
		{
			DrawableCrossFadeTransition @object = Java.Lang.Object.GetObject<DrawableCrossFadeTransition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_current, JniHandleOwnership.DoNotTransfer);
			ITransitionViewAdapter object3 = Java.Lang.Object.GetObject<ITransitionViewAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			return @object.Transition(object2, object3);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00019F5C File Offset: 0x0001815C
		[Register("transition", "(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", "GetTransition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler")]
		public unsafe virtual bool Transition(Drawable current, ITransitionViewAdapter adapter)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((current == null) ? IntPtr.Zero : current.Handle);
				ptr[1] = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
				result = DrawableCrossFadeTransition._members.InstanceMethods.InvokeVirtualBooleanMethod("transition.(Landroid/graphics/drawable/Drawable;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(current);
				GC.KeepAlive(adapter);
			}
			return result;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00019FF0 File Offset: 0x000181F0
		bool ITransition.Transition(Java.Lang.Object p0, ITransitionViewAdapter p1)
		{
			return this.Transition(p0.JavaCast<Drawable>(), p1);
		}

		// Token: 0x0400020E RID: 526
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/DrawableCrossFadeTransition", typeof(DrawableCrossFadeTransition));

		// Token: 0x0400020F RID: 527
		private static Delegate cb_transition_Landroid_graphics_drawable_Drawable_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
	}
}
