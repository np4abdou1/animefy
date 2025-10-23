using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000087 RID: 135
	[Register("androidx/appcompat/widget/SwitchCompat", DoNotGenerateAcw = true)]
	public class SwitchCompat : CompoundButton, IEmojiCompatConfigurationView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0001747C File Offset: 0x0001567C
		internal static IntPtr class_ref
		{
			get
			{
				return SwitchCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000174A0 File Offset: 0x000156A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SwitchCompat._members;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000174A8 File Offset: 0x000156A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SwitchCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000174CC File Offset: 0x000156CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SwitchCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000174D8 File Offset: 0x000156D8
		protected SwitchCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000174E4 File Offset: 0x000156E4
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SwitchCompat(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(SwitchCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SwitchCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00017594 File Offset: 0x00015794
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SwitchCompat(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(SwitchCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SwitchCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00017670 File Offset: 0x00015870
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SwitchCompat(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(SwitchCompat._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SwitchCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00017760 File Offset: 0x00015960
		private static Delegate GetIsEmojiCompatEnabledHandler()
		{
			if (SwitchCompat.cb_isEmojiCompatEnabled == null)
			{
				SwitchCompat.cb_isEmojiCompatEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SwitchCompat.n_IsEmojiCompatEnabled));
			}
			return SwitchCompat.cb_isEmojiCompatEnabled;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00017784 File Offset: 0x00015984
		private static bool n_IsEmojiCompatEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00017793 File Offset: 0x00015993
		private static Delegate GetSetEmojiCompatEnabled_ZHandler()
		{
			if (SwitchCompat.cb_setEmojiCompatEnabled_Z == null)
			{
				SwitchCompat.cb_setEmojiCompatEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SwitchCompat.n_SetEmojiCompatEnabled_Z));
			}
			return SwitchCompat.cb_setEmojiCompatEnabled_Z;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000177B7 File Offset: 0x000159B7
		private static void n_SetEmojiCompatEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled = enabled;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x000177C7 File Offset: 0x000159C7
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000177E0 File Offset: 0x000159E0
		public unsafe virtual bool EmojiCompatEnabled
		{
			[Register("isEmojiCompatEnabled", "()Z", "GetIsEmojiCompatEnabledHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmojiCompatEnabled.()Z", this, null);
			}
			[Register("setEmojiCompatEnabled", "(Z)V", "GetSetEmojiCompatEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setEmojiCompatEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001781B File Offset: 0x00015A1B
		private static Delegate GetGetShowTextHandler()
		{
			if (SwitchCompat.cb_getShowText == null)
			{
				SwitchCompat.cb_getShowText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SwitchCompat.n_GetShowText));
			}
			return SwitchCompat.cb_getShowText;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001783F File Offset: 0x00015A3F
		private static bool n_GetShowText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowText;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001784E File Offset: 0x00015A4E
		private static Delegate GetSetShowText_ZHandler()
		{
			if (SwitchCompat.cb_setShowText_Z == null)
			{
				SwitchCompat.cb_setShowText_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SwitchCompat.n_SetShowText_Z));
			}
			return SwitchCompat.cb_setShowText_Z;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00017872 File Offset: 0x00015A72
		private static void n_SetShowText_Z(IntPtr jnienv, IntPtr native__this, bool showText)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowText = showText;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00017882 File Offset: 0x00015A82
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x0001789C File Offset: 0x00015A9C
		public unsafe virtual bool ShowText
		{
			[Register("getShowText", "()Z", "GetGetShowTextHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("getShowText.()Z", this, null);
			}
			[Register("setShowText", "(Z)V", "GetSetShowText_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setShowText.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000178D7 File Offset: 0x00015AD7
		private static Delegate GetGetSplitTrackHandler()
		{
			if (SwitchCompat.cb_getSplitTrack == null)
			{
				SwitchCompat.cb_getSplitTrack = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(SwitchCompat.n_GetSplitTrack));
			}
			return SwitchCompat.cb_getSplitTrack;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000178FB File Offset: 0x00015AFB
		private static bool n_GetSplitTrack(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SplitTrack;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0001790A File Offset: 0x00015B0A
		private static Delegate GetSetSplitTrack_ZHandler()
		{
			if (SwitchCompat.cb_setSplitTrack_Z == null)
			{
				SwitchCompat.cb_setSplitTrack_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(SwitchCompat.n_SetSplitTrack_Z));
			}
			return SwitchCompat.cb_setSplitTrack_Z;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001792E File Offset: 0x00015B2E
		private static void n_SetSplitTrack_Z(IntPtr jnienv, IntPtr native__this, bool splitTrack)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SplitTrack = splitTrack;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0001793E File Offset: 0x00015B3E
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00017958 File Offset: 0x00015B58
		public unsafe virtual bool SplitTrack
		{
			[Register("getSplitTrack", "()Z", "GetGetSplitTrackHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("getSplitTrack.()Z", this, null);
			}
			[Register("setSplitTrack", "(Z)V", "GetSetSplitTrack_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSplitTrack.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00017993 File Offset: 0x00015B93
		private static Delegate GetGetSwitchMinWidthHandler()
		{
			if (SwitchCompat.cb_getSwitchMinWidth == null)
			{
				SwitchCompat.cb_getSwitchMinWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwitchCompat.n_GetSwitchMinWidth));
			}
			return SwitchCompat.cb_getSwitchMinWidth;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000179B7 File Offset: 0x00015BB7
		private static int n_GetSwitchMinWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SwitchMinWidth;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000179C6 File Offset: 0x00015BC6
		private static Delegate GetSetSwitchMinWidth_IHandler()
		{
			if (SwitchCompat.cb_setSwitchMinWidth_I == null)
			{
				SwitchCompat.cb_setSwitchMinWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwitchCompat.n_SetSwitchMinWidth_I));
			}
			return SwitchCompat.cb_setSwitchMinWidth_I;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000179EA File Offset: 0x00015BEA
		private static void n_SetSwitchMinWidth_I(IntPtr jnienv, IntPtr native__this, int pixels)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SwitchMinWidth = pixels;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x000179FA File Offset: 0x00015BFA
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00017A14 File Offset: 0x00015C14
		public unsafe virtual int SwitchMinWidth
		{
			[Register("getSwitchMinWidth", "()I", "GetGetSwitchMinWidthHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSwitchMinWidth.()I", this, null);
			}
			[Register("setSwitchMinWidth", "(I)V", "GetSetSwitchMinWidth_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSwitchMinWidth.(I)V", this, ptr);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00017A4F File Offset: 0x00015C4F
		private static Delegate GetGetSwitchPaddingHandler()
		{
			if (SwitchCompat.cb_getSwitchPadding == null)
			{
				SwitchCompat.cb_getSwitchPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwitchCompat.n_GetSwitchPadding));
			}
			return SwitchCompat.cb_getSwitchPadding;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00017A73 File Offset: 0x00015C73
		private static int n_GetSwitchPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SwitchPadding;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00017A82 File Offset: 0x00015C82
		private static Delegate GetSetSwitchPadding_IHandler()
		{
			if (SwitchCompat.cb_setSwitchPadding_I == null)
			{
				SwitchCompat.cb_setSwitchPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwitchCompat.n_SetSwitchPadding_I));
			}
			return SwitchCompat.cb_setSwitchPadding_I;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00017AA6 File Offset: 0x00015CA6
		private static void n_SetSwitchPadding_I(IntPtr jnienv, IntPtr native__this, int pixels)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SwitchPadding = pixels;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00017AB6 File Offset: 0x00015CB6
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00017AD0 File Offset: 0x00015CD0
		public unsafe virtual int SwitchPadding
		{
			[Register("getSwitchPadding", "()I", "GetGetSwitchPaddingHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualInt32Method("getSwitchPadding.()I", this, null);
			}
			[Register("setSwitchPadding", "(I)V", "GetSetSwitchPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSwitchPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00017B0B File Offset: 0x00015D0B
		private static Delegate GetGetTextOffHandler()
		{
			if (SwitchCompat.cb_getTextOff == null)
			{
				SwitchCompat.cb_getTextOff = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetTextOff));
			}
			return SwitchCompat.cb_getTextOff;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00017B2F File Offset: 0x00015D2F
		private static IntPtr n_GetTextOff(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextOffFormatted);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00017B43 File Offset: 0x00015D43
		private static Delegate GetSetTextOff_Ljava_lang_CharSequence_Handler()
		{
			if (SwitchCompat.cb_setTextOff_Ljava_lang_CharSequence_ == null)
			{
				SwitchCompat.cb_setTextOff_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetTextOff_Ljava_lang_CharSequence_));
			}
			return SwitchCompat.cb_setTextOff_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00017B68 File Offset: 0x00015D68
		private static void n_SetTextOff_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_textOff)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_textOff, JniHandleOwnership.DoNotTransfer);
			@object.TextOffFormatted = object2;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00017B8C File Offset: 0x00015D8C
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00017BC0 File Offset: 0x00015DC0
		public unsafe virtual ICharSequence TextOffFormatted
		{
			[Register("getTextOff", "()Ljava/lang/CharSequence;", "GetGetTextOffHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTextOff.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTextOff", "(Ljava/lang/CharSequence;)V", "GetSetTextOff_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTextOff.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00017C24 File Offset: 0x00015E24
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00017C3C File Offset: 0x00015E3C
		public string TextOff
		{
			get
			{
				if (this.TextOffFormatted != null)
				{
					return this.TextOffFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TextOffFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00017C66 File Offset: 0x00015E66
		private static Delegate GetGetTextOnHandler()
		{
			if (SwitchCompat.cb_getTextOn == null)
			{
				SwitchCompat.cb_getTextOn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetTextOn));
			}
			return SwitchCompat.cb_getTextOn;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00017C8A File Offset: 0x00015E8A
		private static IntPtr n_GetTextOn(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextOnFormatted);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00017C9E File Offset: 0x00015E9E
		private static Delegate GetSetTextOn_Ljava_lang_CharSequence_Handler()
		{
			if (SwitchCompat.cb_setTextOn_Ljava_lang_CharSequence_ == null)
			{
				SwitchCompat.cb_setTextOn_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetTextOn_Ljava_lang_CharSequence_));
			}
			return SwitchCompat.cb_setTextOn_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00017CC4 File Offset: 0x00015EC4
		private static void n_SetTextOn_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_textOn)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_textOn, JniHandleOwnership.DoNotTransfer);
			@object.TextOnFormatted = object2;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00017CE8 File Offset: 0x00015EE8
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00017D1C File Offset: 0x00015F1C
		public unsafe virtual ICharSequence TextOnFormatted
		{
			[Register("getTextOn", "()Ljava/lang/CharSequence;", "GetGetTextOnHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTextOn.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTextOn", "(Ljava/lang/CharSequence;)V", "GetSetTextOn_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTextOn.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00017D80 File Offset: 0x00015F80
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00017D98 File Offset: 0x00015F98
		public string TextOn
		{
			get
			{
				if (this.TextOnFormatted != null)
				{
					return this.TextOnFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TextOnFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00017DC2 File Offset: 0x00015FC2
		private static Delegate GetGetThumbDrawableHandler()
		{
			if (SwitchCompat.cb_getThumbDrawable == null)
			{
				SwitchCompat.cb_getThumbDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetThumbDrawable));
			}
			return SwitchCompat.cb_getThumbDrawable;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00017DE6 File Offset: 0x00015FE6
		private static IntPtr n_GetThumbDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbDrawable);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00017DFA File Offset: 0x00015FFA
		private static Delegate GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (SwitchCompat.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				SwitchCompat.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return SwitchCompat.cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00017E20 File Offset: 0x00016020
		private static void n_SetThumbDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumb)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_thumb, JniHandleOwnership.DoNotTransfer);
			@object.ThumbDrawable = object2;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00017E44 File Offset: 0x00016044
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00017E78 File Offset: 0x00016078
		public unsafe virtual Drawable ThumbDrawable
		{
			[Register("getThumbDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetThumbDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getThumbDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setThumbDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00017EDC File Offset: 0x000160DC
		protected float ThumbPosition
		{
			[Register("getThumbPosition", "()F", "")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeNonvirtualSingleMethod("getThumbPosition.()F", this, null);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00017EF5 File Offset: 0x000160F5
		private static Delegate GetGetThumbTextPaddingHandler()
		{
			if (SwitchCompat.cb_getThumbTextPadding == null)
			{
				SwitchCompat.cb_getThumbTextPadding = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwitchCompat.n_GetThumbTextPadding));
			}
			return SwitchCompat.cb_getThumbTextPadding;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00017F19 File Offset: 0x00016119
		private static int n_GetThumbTextPadding(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbTextPadding;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00017F28 File Offset: 0x00016128
		private static Delegate GetSetThumbTextPadding_IHandler()
		{
			if (SwitchCompat.cb_setThumbTextPadding_I == null)
			{
				SwitchCompat.cb_setThumbTextPadding_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwitchCompat.n_SetThumbTextPadding_I));
			}
			return SwitchCompat.cb_setThumbTextPadding_I;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00017F4C File Offset: 0x0001614C
		private static void n_SetThumbTextPadding_I(IntPtr jnienv, IntPtr native__this, int pixels)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbTextPadding = pixels;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00017F5C File Offset: 0x0001615C
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00017F78 File Offset: 0x00016178
		public unsafe virtual int ThumbTextPadding
		{
			[Register("getThumbTextPadding", "()I", "GetGetThumbTextPaddingHandler")]
			get
			{
				return SwitchCompat._members.InstanceMethods.InvokeVirtualInt32Method("getThumbTextPadding.()I", this, null);
			}
			[Register("setThumbTextPadding", "(I)V", "GetSetThumbTextPadding_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbTextPadding.(I)V", this, ptr);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00017FB3 File Offset: 0x000161B3
		private static Delegate GetGetThumbTintListHandler()
		{
			if (SwitchCompat.cb_getThumbTintList == null)
			{
				SwitchCompat.cb_getThumbTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetThumbTintList));
			}
			return SwitchCompat.cb_getThumbTintList;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00017FD7 File Offset: 0x000161D7
		private static IntPtr n_GetThumbTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbTintList);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00017FEB File Offset: 0x000161EB
		private static Delegate GetSetThumbTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (SwitchCompat.cb_setThumbTintList_Landroid_content_res_ColorStateList_ == null)
			{
				SwitchCompat.cb_setThumbTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetThumbTintList_Landroid_content_res_ColorStateList_));
			}
			return SwitchCompat.cb_setThumbTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00018010 File Offset: 0x00016210
		private static void n_SetThumbTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.ThumbTintList = object2;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00018034 File Offset: 0x00016234
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00018068 File Offset: 0x00016268
		public unsafe virtual ColorStateList ThumbTintList
		{
			[Register("getThumbTintList", "()Landroid/content/res/ColorStateList;", "GetGetThumbTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getThumbTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setThumbTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetThumbTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000180CC File Offset: 0x000162CC
		private static Delegate GetGetThumbTintModeHandler()
		{
			if (SwitchCompat.cb_getThumbTintMode == null)
			{
				SwitchCompat.cb_getThumbTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetThumbTintMode));
			}
			return SwitchCompat.cb_getThumbTintMode;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000180F0 File Offset: 0x000162F0
		private static IntPtr n_GetThumbTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbTintMode);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00018104 File Offset: 0x00016304
		private static Delegate GetSetThumbTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (SwitchCompat.cb_setThumbTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				SwitchCompat.cb_setThumbTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetThumbTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return SwitchCompat.cb_setThumbTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00018128 File Offset: 0x00016328
		private static void n_SetThumbTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.ThumbTintMode = object2;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0001814C File Offset: 0x0001634C
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00018180 File Offset: 0x00016380
		public unsafe virtual PorterDuff.Mode ThumbTintMode
		{
			[Register("getThumbTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetThumbTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getThumbTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setThumbTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetThumbTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000181E4 File Offset: 0x000163E4
		private static Delegate GetGetTrackDrawableHandler()
		{
			if (SwitchCompat.cb_getTrackDrawable == null)
			{
				SwitchCompat.cb_getTrackDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetTrackDrawable));
			}
			return SwitchCompat.cb_getTrackDrawable;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00018208 File Offset: 0x00016408
		private static IntPtr n_GetTrackDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackDrawable);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001821C File Offset: 0x0001641C
		private static Delegate GetSetTrackDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (SwitchCompat.cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				SwitchCompat.cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetTrackDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return SwitchCompat.cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00018240 File Offset: 0x00016440
		private static void n_SetTrackDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_track, JniHandleOwnership.DoNotTransfer);
			@object.TrackDrawable = object2;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00018264 File Offset: 0x00016464
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00018298 File Offset: 0x00016498
		public unsafe virtual Drawable TrackDrawable
		{
			[Register("getTrackDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetTrackDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTrackDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTrackDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetTrackDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTrackDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000182FC File Offset: 0x000164FC
		private static Delegate GetGetTrackTintListHandler()
		{
			if (SwitchCompat.cb_getTrackTintList == null)
			{
				SwitchCompat.cb_getTrackTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetTrackTintList));
			}
			return SwitchCompat.cb_getTrackTintList;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00018320 File Offset: 0x00016520
		private static IntPtr n_GetTrackTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackTintList);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00018334 File Offset: 0x00016534
		private static Delegate GetSetTrackTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (SwitchCompat.cb_setTrackTintList_Landroid_content_res_ColorStateList_ == null)
			{
				SwitchCompat.cb_setTrackTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetTrackTintList_Landroid_content_res_ColorStateList_));
			}
			return SwitchCompat.cb_setTrackTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00018358 File Offset: 0x00016558
		private static void n_SetTrackTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.TrackTintList = object2;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0001837C File Offset: 0x0001657C
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x000183B0 File Offset: 0x000165B0
		public unsafe virtual ColorStateList TrackTintList
		{
			[Register("getTrackTintList", "()Landroid/content/res/ColorStateList;", "GetGetTrackTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTrackTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTrackTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetTrackTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTrackTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00018414 File Offset: 0x00016614
		private static Delegate GetGetTrackTintModeHandler()
		{
			if (SwitchCompat.cb_getTrackTintMode == null)
			{
				SwitchCompat.cb_getTrackTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwitchCompat.n_GetTrackTintMode));
			}
			return SwitchCompat.cb_getTrackTintMode;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00018438 File Offset: 0x00016638
		private static IntPtr n_GetTrackTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackTintMode);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001844C File Offset: 0x0001664C
		private static Delegate GetSetTrackTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (SwitchCompat.cb_setTrackTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				SwitchCompat.cb_setTrackTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetTrackTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return SwitchCompat.cb_setTrackTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00018470 File Offset: 0x00016670
		private static void n_SetTrackTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.TrackTintMode = object2;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00018494 File Offset: 0x00016694
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x000184C8 File Offset: 0x000166C8
		public unsafe virtual PorterDuff.Mode TrackTintMode
		{
			[Register("getTrackTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetTrackTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(SwitchCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTrackTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTrackTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetTrackTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTrackTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001852C File Offset: 0x0001672C
		private static Delegate GetOnMeasure_IIHandler()
		{
			if (SwitchCompat.cb_onMeasure_II == null)
			{
				SwitchCompat.cb_onMeasure_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(SwitchCompat.n_OnMeasure_II));
			}
			return SwitchCompat.cb_onMeasure_II;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00018550 File Offset: 0x00016750
		private static void n_OnMeasure_II(IntPtr jnienv, IntPtr native__this, int widthMeasureSpec, int heightMeasureSpec)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00018564 File Offset: 0x00016764
		[Register("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
		public new unsafe virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(widthMeasureSpec);
			ptr[1] = new JniArgumentValue(heightMeasureSpec);
			SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasure.(II)V", this, ptr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000185B4 File Offset: 0x000167B4
		[Register("setEnforceSwitchWidth", "(Z)V", "")]
		protected unsafe void SetEnforceSwitchWidth(bool enforceSwitchWidth)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enforceSwitchWidth);
			SwitchCompat._members.InstanceMethods.InvokeNonvirtualVoidMethod("setEnforceSwitchWidth.(Z)V", this, ptr);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000185EF File Offset: 0x000167EF
		private static Delegate GetSetSwitchTextAppearance_Landroid_content_Context_IHandler()
		{
			if (SwitchCompat.cb_setSwitchTextAppearance_Landroid_content_Context_I == null)
			{
				SwitchCompat.cb_setSwitchTextAppearance_Landroid_content_Context_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(SwitchCompat.n_SetSwitchTextAppearance_Landroid_content_Context_I));
			}
			return SwitchCompat.cb_setSwitchTextAppearance_Landroid_content_Context_I;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00018614 File Offset: 0x00016814
		private static void n_SetSwitchTextAppearance_Landroid_content_Context_I(IntPtr jnienv, IntPtr native__this, IntPtr native_context, int resid)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.SetSwitchTextAppearance(object2, resid);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00018638 File Offset: 0x00016838
		[Register("setSwitchTextAppearance", "(Landroid/content/Context;I)V", "GetSetSwitchTextAppearance_Landroid_content_Context_IHandler")]
		public unsafe virtual void SetSwitchTextAppearance(Context context, int resid)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(resid);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSwitchTextAppearance.(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000186B0 File Offset: 0x000168B0
		private static Delegate GetSetSwitchTypeface_Landroid_graphics_Typeface_Handler()
		{
			if (SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_ == null)
			{
				SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwitchCompat.n_SetSwitchTypeface_Landroid_graphics_Typeface_));
			}
			return SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000186D4 File Offset: 0x000168D4
		private static void n_SetSwitchTypeface_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_typeface)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.SetSwitchTypeface(object2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000186F8 File Offset: 0x000168F8
		[Register("setSwitchTypeface", "(Landroid/graphics/Typeface;)V", "GetSetSwitchTypeface_Landroid_graphics_Typeface_Handler")]
		public unsafe virtual void SetSwitchTypeface(Typeface typeface)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((typeface == null) ? IntPtr.Zero : typeface.Handle);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSwitchTypeface.(Landroid/graphics/Typeface;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(typeface);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0001875C File Offset: 0x0001695C
		private static Delegate GetSetSwitchTypeface_Landroid_graphics_Typeface_IHandler()
		{
			if (SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_I == null)
			{
				SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(SwitchCompat.n_SetSwitchTypeface_Landroid_graphics_Typeface_I));
			}
			return SwitchCompat.cb_setSwitchTypeface_Landroid_graphics_Typeface_I;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00018780 File Offset: 0x00016980
		private static void n_SetSwitchTypeface_Landroid_graphics_Typeface_I(IntPtr jnienv, IntPtr native__this, IntPtr native_tf, int style)
		{
			SwitchCompat @object = Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_tf, JniHandleOwnership.DoNotTransfer);
			@object.SetSwitchTypeface(object2, style);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000187A4 File Offset: 0x000169A4
		[Register("setSwitchTypeface", "(Landroid/graphics/Typeface;I)V", "GetSetSwitchTypeface_Landroid_graphics_Typeface_IHandler")]
		public unsafe virtual void SetSwitchTypeface(Typeface tf, int style)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tf == null) ? IntPtr.Zero : tf.Handle);
				ptr[1] = new JniArgumentValue(style);
				SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setSwitchTypeface.(Landroid/graphics/Typeface;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tf);
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001881C File Offset: 0x00016A1C
		private static Delegate GetSetThumbResource_IHandler()
		{
			if (SwitchCompat.cb_setThumbResource_I == null)
			{
				SwitchCompat.cb_setThumbResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwitchCompat.n_SetThumbResource_I));
			}
			return SwitchCompat.cb_setThumbResource_I;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00018840 File Offset: 0x00016A40
		private static void n_SetThumbResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetThumbResource(resId);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00018850 File Offset: 0x00016A50
		[Register("setThumbResource", "(I)V", "GetSetThumbResource_IHandler")]
		public unsafe virtual void SetThumbResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setThumbResource.(I)V", this, ptr);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001888B File Offset: 0x00016A8B
		private static Delegate GetSetTrackResource_IHandler()
		{
			if (SwitchCompat.cb_setTrackResource_I == null)
			{
				SwitchCompat.cb_setTrackResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwitchCompat.n_SetTrackResource_I));
			}
			return SwitchCompat.cb_setTrackResource_I;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000188AF File Offset: 0x00016AAF
		private static void n_SetTrackResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<SwitchCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTrackResource(resId);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000188C0 File Offset: 0x00016AC0
		[Register("setTrackResource", "(I)V", "GetSetTrackResource_IHandler")]
		public unsafe virtual void SetTrackResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			SwitchCompat._members.InstanceMethods.InvokeVirtualVoidMethod("setTrackResource.(I)V", this, ptr);
		}

		// Token: 0x040002A4 RID: 676
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/SwitchCompat", typeof(SwitchCompat));

		// Token: 0x040002A5 RID: 677
		private static Delegate cb_isEmojiCompatEnabled;

		// Token: 0x040002A6 RID: 678
		private static Delegate cb_setEmojiCompatEnabled_Z;

		// Token: 0x040002A7 RID: 679
		private static Delegate cb_getShowText;

		// Token: 0x040002A8 RID: 680
		private static Delegate cb_setShowText_Z;

		// Token: 0x040002A9 RID: 681
		private static Delegate cb_getSplitTrack;

		// Token: 0x040002AA RID: 682
		private static Delegate cb_setSplitTrack_Z;

		// Token: 0x040002AB RID: 683
		private static Delegate cb_getSwitchMinWidth;

		// Token: 0x040002AC RID: 684
		private static Delegate cb_setSwitchMinWidth_I;

		// Token: 0x040002AD RID: 685
		private static Delegate cb_getSwitchPadding;

		// Token: 0x040002AE RID: 686
		private static Delegate cb_setSwitchPadding_I;

		// Token: 0x040002AF RID: 687
		private static Delegate cb_getTextOff;

		// Token: 0x040002B0 RID: 688
		private static Delegate cb_setTextOff_Ljava_lang_CharSequence_;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_getTextOn;

		// Token: 0x040002B2 RID: 690
		private static Delegate cb_setTextOn_Ljava_lang_CharSequence_;

		// Token: 0x040002B3 RID: 691
		private static Delegate cb_getThumbDrawable;

		// Token: 0x040002B4 RID: 692
		private static Delegate cb_setThumbDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002B5 RID: 693
		private static Delegate cb_getThumbTextPadding;

		// Token: 0x040002B6 RID: 694
		private static Delegate cb_setThumbTextPadding_I;

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_getThumbTintList;

		// Token: 0x040002B8 RID: 696
		private static Delegate cb_setThumbTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_getThumbTintMode;

		// Token: 0x040002BA RID: 698
		private static Delegate cb_setThumbTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040002BB RID: 699
		private static Delegate cb_getTrackDrawable;

		// Token: 0x040002BC RID: 700
		private static Delegate cb_setTrackDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x040002BD RID: 701
		private static Delegate cb_getTrackTintList;

		// Token: 0x040002BE RID: 702
		private static Delegate cb_setTrackTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040002BF RID: 703
		private static Delegate cb_getTrackTintMode;

		// Token: 0x040002C0 RID: 704
		private static Delegate cb_setTrackTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040002C1 RID: 705
		private static Delegate cb_onMeasure_II;

		// Token: 0x040002C2 RID: 706
		private static Delegate cb_setSwitchTextAppearance_Landroid_content_Context_I;

		// Token: 0x040002C3 RID: 707
		private static Delegate cb_setSwitchTypeface_Landroid_graphics_Typeface_;

		// Token: 0x040002C4 RID: 708
		private static Delegate cb_setSwitchTypeface_Landroid_graphics_Typeface_I;

		// Token: 0x040002C5 RID: 709
		private static Delegate cb_setThumbResource_I;

		// Token: 0x040002C6 RID: 710
		private static Delegate cb_setTrackResource_I;
	}
}
