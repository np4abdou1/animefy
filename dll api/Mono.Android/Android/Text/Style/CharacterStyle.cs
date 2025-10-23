using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001C1 RID: 449
	[Register("android/text/style/CharacterStyle", DoNotGenerateAcw = true)]
	public abstract class CharacterStyle : Java.Lang.Object
	{
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x0002A445 File Offset: 0x00028645
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharacterStyle._members;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0002A44C File Offset: 0x0002864C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharacterStyle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x0002A470 File Offset: 0x00028670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharacterStyle._members.ManagedPeerType;
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x000021E0 File Offset: 0x000003E0
		protected CharacterStyle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002A47C File Offset: 0x0002867C
		private static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler()
		{
			if (CharacterStyle.cb_updateDrawState_Landroid_text_TextPaint_ == null)
			{
				CharacterStyle.cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CharacterStyle.n_UpdateDrawState_Landroid_text_TextPaint_));
			}
			return CharacterStyle.cb_updateDrawState_Landroid_text_TextPaint_;
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002A4A0 File Offset: 0x000286A0
		private static void n_UpdateDrawState_Landroid_text_TextPaint_(IntPtr jnienv, IntPtr native__this, IntPtr native_tp)
		{
			CharacterStyle @object = Java.Lang.Object.GetObject<CharacterStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextPaint object2 = Java.Lang.Object.GetObject<TextPaint>(native_tp, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2);
		}

		// Token: 0x06001031 RID: 4145
		public abstract void UpdateDrawState(TextPaint tp);

		// Token: 0x04000776 RID: 1910
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/CharacterStyle", typeof(CharacterStyle));

		// Token: 0x04000777 RID: 1911
		private static Delegate cb_updateDrawState_Landroid_text_TextPaint_;
	}
}
