using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001C3 RID: 451
	[Register("android/text/style/ClickableSpan", DoNotGenerateAcw = true)]
	public abstract class ClickableSpan : CharacterStyle, IUpdateAppearance, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0002A57B File Offset: 0x0002877B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClickableSpan._members;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x0002A584 File Offset: 0x00028784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClickableSpan._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0002A5A8 File Offset: 0x000287A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClickableSpan._members.ManagedPeerType;
			}
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0002A4DE File Offset: 0x000286DE
		protected ClickableSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0002A5B4 File Offset: 0x000287B4
		public ClickableSpan() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ClickableSpan._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ClickableSpan._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0002A622 File Offset: 0x00028822
		private static Delegate GetOnClick_Landroid_view_View_Handler()
		{
			if (ClickableSpan.cb_onClick_Landroid_view_View_ == null)
			{
				ClickableSpan.cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ClickableSpan.n_OnClick_Landroid_view_View_));
			}
			return ClickableSpan.cb_onClick_Landroid_view_View_;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0002A648 File Offset: 0x00028848
		private static void n_OnClick_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_widget)
		{
			ClickableSpan @object = Java.Lang.Object.GetObject<ClickableSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_widget, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2);
		}

		// Token: 0x0600103F RID: 4159
		public abstract void OnClick(View widget);

		// Token: 0x06001040 RID: 4160 RVA: 0x0002A66B File Offset: 0x0002886B
		private static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler()
		{
			if (ClickableSpan.cb_updateDrawState_Landroid_text_TextPaint_ == null)
			{
				ClickableSpan.cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ClickableSpan.n_UpdateDrawState_Landroid_text_TextPaint_));
			}
			return ClickableSpan.cb_updateDrawState_Landroid_text_TextPaint_;
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002A690 File Offset: 0x00028890
		private static void n_UpdateDrawState_Landroid_text_TextPaint_(IntPtr jnienv, IntPtr native__this, IntPtr native_ds)
		{
			CharacterStyle @object = Java.Lang.Object.GetObject<ClickableSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextPaint object2 = Java.Lang.Object.GetObject<TextPaint>(native_ds, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2);
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0002A6B4 File Offset: 0x000288B4
		public unsafe override void UpdateDrawState(TextPaint ds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ds == null) ? IntPtr.Zero : ds.Handle);
				ClickableSpan._members.InstanceMethods.InvokeVirtualVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ds);
			}
		}

		// Token: 0x04000779 RID: 1913
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/ClickableSpan", typeof(ClickableSpan));

		// Token: 0x0400077A RID: 1914
		private static Delegate cb_onClick_Landroid_view_View_;

		// Token: 0x0400077B RID: 1915
		private static Delegate cb_updateDrawState_Landroid_text_TextPaint_;
	}
}
