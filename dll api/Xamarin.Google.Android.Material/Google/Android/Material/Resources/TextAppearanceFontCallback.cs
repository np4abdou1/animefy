using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Resources
{
	// Token: 0x02000042 RID: 66
	[Register("com/google/android/material/resources/TextAppearanceFontCallback", DoNotGenerateAcw = true)]
	public abstract class TextAppearanceFontCallback : Java.Lang.Object
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00005D28 File Offset: 0x00003F28
		internal static IntPtr class_ref
		{
			get
			{
				return TextAppearanceFontCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00005D4C File Offset: 0x00003F4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextAppearanceFontCallback._members;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00005D54 File Offset: 0x00003F54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextAppearanceFontCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00005D78 File Offset: 0x00003F78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextAppearanceFontCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000020DC File Offset: 0x000002DC
		protected TextAppearanceFontCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00005D84 File Offset: 0x00003F84
		[Register(".ctor", "()V", "")]
		public TextAppearanceFontCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TextAppearanceFontCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TextAppearanceFontCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005DF2 File Offset: 0x00003FF2
		private static Delegate GetOnFontRetrievalFailed_IHandler()
		{
			if (TextAppearanceFontCallback.cb_onFontRetrievalFailed_I == null)
			{
				TextAppearanceFontCallback.cb_onFontRetrievalFailed_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TextAppearanceFontCallback.n_OnFontRetrievalFailed_I));
			}
			return TextAppearanceFontCallback.cb_onFontRetrievalFailed_I;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00005E16 File Offset: 0x00004016
		private static void n_OnFontRetrievalFailed_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<TextAppearanceFontCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnFontRetrievalFailed(p0);
		}

		// Token: 0x060001EA RID: 490
		[Register("onFontRetrievalFailed", "(I)V", "GetOnFontRetrievalFailed_IHandler")]
		public abstract void OnFontRetrievalFailed(int p0);

		// Token: 0x060001EB RID: 491 RVA: 0x00005E26 File Offset: 0x00004026
		private static Delegate GetOnFontRetrieved_Landroid_graphics_Typeface_ZHandler()
		{
			if (TextAppearanceFontCallback.cb_onFontRetrieved_Landroid_graphics_Typeface_Z == null)
			{
				TextAppearanceFontCallback.cb_onFontRetrieved_Landroid_graphics_Typeface_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(TextAppearanceFontCallback.n_OnFontRetrieved_Landroid_graphics_Typeface_Z));
			}
			return TextAppearanceFontCallback.cb_onFontRetrieved_Landroid_graphics_Typeface_Z;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00005E4C File Offset: 0x0000404C
		private static void n_OnFontRetrieved_Landroid_graphics_Typeface_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			TextAppearanceFontCallback @object = Java.Lang.Object.GetObject<TextAppearanceFontCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnFontRetrieved(object2, p1);
		}

		// Token: 0x060001ED RID: 493
		[Register("onFontRetrieved", "(Landroid/graphics/Typeface;Z)V", "GetOnFontRetrieved_Landroid_graphics_Typeface_ZHandler")]
		public abstract void OnFontRetrieved(Typeface p0, bool p1);

		// Token: 0x04000040 RID: 64
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/resources/TextAppearanceFontCallback", typeof(TextAppearanceFontCallback));

		// Token: 0x04000041 RID: 65
		private static Delegate cb_onFontRetrievalFailed_I;

		// Token: 0x04000042 RID: 66
		private static Delegate cb_onFontRetrieved_Landroid_graphics_Typeface_Z;
	}
}
