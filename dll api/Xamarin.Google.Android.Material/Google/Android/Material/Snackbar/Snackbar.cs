using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Snackbar
{
	// Token: 0x02000089 RID: 137
	[Register("com/google/android/material/snackbar/Snackbar", DoNotGenerateAcw = true)]
	public class Snackbar : BaseTransientBottomBar
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00018DD3 File Offset: 0x00016FD3
		public Snackbar SetAction(string text, Action<View> clickHandler)
		{
			return this.SetAction(text, new Snackbar.SnackbarActionClickImplementor(clickHandler));
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00018DE2 File Offset: 0x00016FE2
		public Snackbar SetAction(ICharSequence text, Action<View> clickHandler)
		{
			return this.SetAction(text, new Snackbar.SnackbarActionClickImplementor(clickHandler));
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00018DF1 File Offset: 0x00016FF1
		public Snackbar SetAction(int resId, Action<View> clickHandler)
		{
			return this.SetAction(resId, new Snackbar.SnackbarActionClickImplementor(clickHandler));
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00018E00 File Offset: 0x00017000
		internal new static IntPtr class_ref
		{
			get
			{
				return Snackbar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00018E24 File Offset: 0x00017024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Snackbar._members;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00018E2C File Offset: 0x0001702C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Snackbar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00018E50 File Offset: 0x00017050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Snackbar._members.ManagedPeerType;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00018E5C File Offset: 0x0001705C
		protected Snackbar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00018E68 File Offset: 0x00017068
		[Register("hasSnackbarButtonStyleAttr", "(Landroid/content/Context;)Z", "")]
		protected unsafe static bool HasSnackbarButtonStyleAttr(Context context)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = Snackbar._members.StaticMethods.InvokeBooleanMethod("hasSnackbarButtonStyleAttr.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00018ECC File Offset: 0x000170CC
		[Register("make", "(Landroid/content/Context;Landroid/view/View;Ljava/lang/CharSequence;I)Lcom/google/android/material/snackbar/Snackbar;", "")]
		public unsafe static Snackbar Make(Context context, View view, ICharSequence text, int duration)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.StaticMethods.InvokeObjectMethod("make.(Landroid/content/Context;Landroid/view/View;Ljava/lang/CharSequence;I)Lcom/google/android/material/snackbar/Snackbar;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(view);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00018FA8 File Offset: 0x000171A8
		public static Snackbar Make(Context context, View view, string text, int duration)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			Snackbar result = Snackbar.Make(context, view, @string, duration);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00018FD4 File Offset: 0x000171D4
		[Register("make", "(Landroid/view/View;II)Lcom/google/android/material/snackbar/Snackbar;", "")]
		public unsafe static Snackbar Make(View view, int resId, int duration)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(resId);
				ptr[2] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.StaticMethods.InvokeObjectMethod("make.(Landroid/view/View;II)Lcom/google/android/material/snackbar/Snackbar;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00019070 File Offset: 0x00017270
		[Register("make", "(Landroid/view/View;Ljava/lang/CharSequence;I)Lcom/google/android/material/snackbar/Snackbar;", "")]
		public unsafe static Snackbar Make(View view, ICharSequence text, int duration)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(duration);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.StaticMethods.InvokeObjectMethod("make.(Landroid/view/View;Ljava/lang/CharSequence;I)Lcom/google/android/material/snackbar/Snackbar;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00019120 File Offset: 0x00017320
		public static Snackbar Make(View view, string text, int duration)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			Snackbar result = Snackbar.Make(view, @string, duration);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001914B File Offset: 0x0001734B
		private static Delegate GetSetAction_ILandroid_view_View_OnClickListener_Handler()
		{
			if (Snackbar.cb_setAction_ILandroid_view_View_OnClickListener_ == null)
			{
				Snackbar.cb_setAction_ILandroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(Snackbar.n_SetAction_ILandroid_view_View_OnClickListener_));
			}
			return Snackbar.cb_setAction_ILandroid_view_View_OnClickListener_;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00019170 File Offset: 0x00017370
		private static IntPtr n_SetAction_ILandroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, int resId, IntPtr native_listener)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object2 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetAction(resId, object2));
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001919C File Offset: 0x0001739C
		[Register("setAction", "(ILandroid/view/View$OnClickListener;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetAction_ILandroid_view_View_OnClickListener_Handler")]
		public unsafe virtual Snackbar SetAction(int resId, View.IOnClickListener listener)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setAction.(ILandroid/view/View$OnClickListener;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00019228 File Offset: 0x00017428
		private static Delegate GetSetAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_Handler()
		{
			if (Snackbar.cb_setAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_ == null)
			{
				Snackbar.cb_setAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(Snackbar.n_SetAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_));
			}
			return Snackbar.cb_setAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001924C File Offset: 0x0001744C
		private static IntPtr n_SetAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_text, IntPtr native_listener)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
			View.IOnClickListener object3 = Java.Lang.Object.GetObject<View.IOnClickListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetAction(object2, object3));
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00019280 File Offset: 0x00017480
		[Register("setAction", "(Ljava/lang/CharSequence;Landroid/view/View$OnClickListener;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_Handler")]
		public unsafe virtual Snackbar SetAction(ICharSequence text, View.IOnClickListener listener)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setAction.(Ljava/lang/CharSequence;Landroid/view/View$OnClickListener;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(text);
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00019320 File Offset: 0x00017520
		public Snackbar SetAction(string text, View.IOnClickListener listener)
		{
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			Snackbar result = this.SetAction(@string, listener);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001934B File Offset: 0x0001754B
		private static Delegate GetSetActionTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (Snackbar.cb_setActionTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				Snackbar.cb_setActionTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetActionTextColor_Landroid_content_res_ColorStateList_));
			}
			return Snackbar.cb_setActionTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00019370 File Offset: 0x00017570
		private static IntPtr n_SetActionTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_colors, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetActionTextColor(object2));
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00019398 File Offset: 0x00017598
		[Register("setActionTextColor", "(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetActionTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Snackbar SetActionTextColor(ColorStateList colors)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colors == null) ? IntPtr.Zero : colors.Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setActionTextColor.(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(colors);
			}
			return @object;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001940C File Offset: 0x0001760C
		private static Delegate GetSetActionTextColor_IHandler()
		{
			if (Snackbar.cb_setActionTextColor_I == null)
			{
				Snackbar.cb_setActionTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetActionTextColor_I));
			}
			return Snackbar.cb_setActionTextColor_I;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00019430 File Offset: 0x00017630
		private static IntPtr n_SetActionTextColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetActionTextColor(color));
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00019448 File Offset: 0x00017648
		[Register("setActionTextColor", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetActionTextColor_IHandler")]
		public unsafe virtual Snackbar SetActionTextColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setActionTextColor.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00019491 File Offset: 0x00017691
		private static Delegate GetSetBackgroundTint_IHandler()
		{
			if (Snackbar.cb_setBackgroundTint_I == null)
			{
				Snackbar.cb_setBackgroundTint_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetBackgroundTint_I));
			}
			return Snackbar.cb_setBackgroundTint_I;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000194B5 File Offset: 0x000176B5
		private static IntPtr n_SetBackgroundTint_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBackgroundTint(color));
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000194CC File Offset: 0x000176CC
		[Register("setBackgroundTint", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetBackgroundTint_IHandler")]
		public unsafe virtual Snackbar SetBackgroundTint(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setBackgroundTint.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00019515 File Offset: 0x00017715
		private static Delegate GetSetBackgroundTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (Snackbar.cb_setBackgroundTintList_Landroid_content_res_ColorStateList_ == null)
			{
				Snackbar.cb_setBackgroundTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetBackgroundTintList_Landroid_content_res_ColorStateList_));
			}
			return Snackbar.cb_setBackgroundTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001953C File Offset: 0x0001773C
		private static IntPtr n_SetBackgroundTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorStateList)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_colorStateList, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetBackgroundTintList(object2));
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00019564 File Offset: 0x00017764
		[Register("setBackgroundTintList", "(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetBackgroundTintList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Snackbar SetBackgroundTintList(ColorStateList colorStateList)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorStateList == null) ? IntPtr.Zero : colorStateList.Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setBackgroundTintList.(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(colorStateList);
			}
			return @object;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000195D8 File Offset: 0x000177D8
		private static Delegate GetSetBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (Snackbar.cb_setBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				Snackbar.cb_setBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return Snackbar.cb_setBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000195FC File Offset: 0x000177FC
		private static IntPtr n_SetBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_mode, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetBackgroundTintMode(object2));
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00019624 File Offset: 0x00017824
		[Register("setBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
		public unsafe virtual Snackbar SetBackgroundTintMode(PorterDuff.Mode mode)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setBackgroundTintMode.(Landroid/graphics/PorterDuff$Mode;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(mode);
			}
			return @object;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00019698 File Offset: 0x00017898
		private static Delegate GetSetCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_Handler()
		{
			if (Snackbar.cb_setCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_ == null)
			{
				Snackbar.cb_setCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_));
			}
			return Snackbar.cb_setCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000196BC File Offset: 0x000178BC
		private static IntPtr n_SetCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Snackbar.Callback object2 = Java.Lang.Object.GetObject<Snackbar.Callback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetCallback(object2));
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000196E4 File Offset: 0x000178E4
		[Register("setCallback", "(Lcom/google/android/material/snackbar/Snackbar$Callback;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_Handler")]
		public unsafe virtual Snackbar SetCallback(Snackbar.Callback callback)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setCallback.(Lcom/google/android/material/snackbar/Snackbar$Callback;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00019758 File Offset: 0x00017958
		private static Delegate GetSetMaxInlineActionWidth_IHandler()
		{
			if (Snackbar.cb_setMaxInlineActionWidth_I == null)
			{
				Snackbar.cb_setMaxInlineActionWidth_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetMaxInlineActionWidth_I));
			}
			return Snackbar.cb_setMaxInlineActionWidth_I;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0001977C File Offset: 0x0001797C
		private static IntPtr n_SetMaxInlineActionWidth_I(IntPtr jnienv, IntPtr native__this, int width)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxInlineActionWidth(width));
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00019794 File Offset: 0x00017994
		[Register("setMaxInlineActionWidth", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetMaxInlineActionWidth_IHandler")]
		public unsafe virtual Snackbar SetMaxInlineActionWidth(int width)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setMaxInlineActionWidth.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000197DD File Offset: 0x000179DD
		private static Delegate GetSetText_IHandler()
		{
			if (Snackbar.cb_setText_I == null)
			{
				Snackbar.cb_setText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetText_I));
			}
			return Snackbar.cb_setText_I;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00019801 File Offset: 0x00017A01
		private static IntPtr n_SetText_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetText(resId));
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00019818 File Offset: 0x00017A18
		[Register("setText", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetText_IHandler")]
		public unsafe virtual Snackbar SetText(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setText.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00019861 File Offset: 0x00017A61
		private static Delegate GetSetText_Ljava_lang_CharSequence_Handler()
		{
			if (Snackbar.cb_setText_Ljava_lang_CharSequence_ == null)
			{
				Snackbar.cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetText_Ljava_lang_CharSequence_));
			}
			return Snackbar.cb_setText_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00019888 File Offset: 0x00017A88
		private static IntPtr n_SetText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_message, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetText(object2));
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000198B0 File Offset: 0x00017AB0
		[Register("setText", "(Ljava/lang/CharSequence;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetText_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual Snackbar SetText(ICharSequence message)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(message);
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setText.(Ljava/lang/CharSequence;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(message);
			}
			return @object;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00019924 File Offset: 0x00017B24
		public Snackbar SetText(string message)
		{
			Java.Lang.String @string = (message == null) ? null : new Java.Lang.String(message);
			Snackbar result = this.SetText(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001994E File Offset: 0x00017B4E
		private static Delegate GetSetTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (Snackbar.cb_setTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				Snackbar.cb_setTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Snackbar.n_SetTextColor_Landroid_content_res_ColorStateList_));
			}
			return Snackbar.cb_setTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00019974 File Offset: 0x00017B74
		private static IntPtr n_SetTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			Snackbar @object = Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_colors, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTextColor(object2));
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0001999C File Offset: 0x00017B9C
		[Register("setTextColor", "(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", "GetSetTextColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Snackbar SetTextColor(ColorStateList colors)
		{
			Snackbar @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colors == null) ? IntPtr.Zero : colors.Handle);
				@object = Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setTextColor.(Landroid/content/res/ColorStateList;)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(colors);
			}
			return @object;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00019A10 File Offset: 0x00017C10
		private static Delegate GetSetTextColor_IHandler()
		{
			if (Snackbar.cb_setTextColor_I == null)
			{
				Snackbar.cb_setTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetTextColor_I));
			}
			return Snackbar.cb_setTextColor_I;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00019A34 File Offset: 0x00017C34
		private static IntPtr n_SetTextColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTextColor(color));
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00019A4C File Offset: 0x00017C4C
		[Register("setTextColor", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetTextColor_IHandler")]
		public unsafe virtual Snackbar SetTextColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setTextColor.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00019A95 File Offset: 0x00017C95
		private static Delegate GetSetTextMaxLines_IHandler()
		{
			if (Snackbar.cb_setTextMaxLines_I == null)
			{
				Snackbar.cb_setTextMaxLines_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Snackbar.n_SetTextMaxLines_I));
			}
			return Snackbar.cb_setTextMaxLines_I;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00019AB9 File Offset: 0x00017CB9
		private static IntPtr n_SetTextMaxLines_I(IntPtr jnienv, IntPtr native__this, int maxLines)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Snackbar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTextMaxLines(maxLines));
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Register("setTextMaxLines", "(I)Lcom/google/android/material/snackbar/Snackbar;", "GetSetTextMaxLines_IHandler")]
		public unsafe virtual Snackbar SetTextMaxLines(int maxLines)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxLines);
			return Java.Lang.Object.GetObject<Snackbar>(Snackbar._members.InstanceMethods.InvokeVirtualObjectMethod("setTextMaxLines.(I)Lcom/google/android/material/snackbar/Snackbar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002AD RID: 685
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/Snackbar", typeof(Snackbar));

		// Token: 0x040002AE RID: 686
		private static Delegate cb_setAction_ILandroid_view_View_OnClickListener_;

		// Token: 0x040002AF RID: 687
		private static Delegate cb_setAction_Ljava_lang_CharSequence_Landroid_view_View_OnClickListener_;

		// Token: 0x040002B0 RID: 688
		private static Delegate cb_setActionTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_setActionTextColor_I;

		// Token: 0x040002B2 RID: 690
		private static Delegate cb_setBackgroundTint_I;

		// Token: 0x040002B3 RID: 691
		private static Delegate cb_setBackgroundTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040002B4 RID: 692
		private static Delegate cb_setBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040002B5 RID: 693
		private static Delegate cb_setCallback_Lcom_google_android_material_snackbar_Snackbar_Callback_;

		// Token: 0x040002B6 RID: 694
		private static Delegate cb_setMaxInlineActionWidth_I;

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_setText_I;

		// Token: 0x040002B8 RID: 696
		private static Delegate cb_setText_Ljava_lang_CharSequence_;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_setTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x040002BA RID: 698
		private static Delegate cb_setTextColor_I;

		// Token: 0x040002BB RID: 699
		private static Delegate cb_setTextMaxLines_I;

		// Token: 0x0200008A RID: 138
		internal class SnackbarActionClickImplementor : Java.Lang.Object, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000977 RID: 2423 RVA: 0x00019B34 File Offset: 0x00017D34
			public SnackbarActionClickImplementor(Action<View> handler)
			{
				this.handler = handler;
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x00019B43 File Offset: 0x00017D43
			public void OnClick(View v)
			{
				Action<View> action = this.handler;
				if (action == null)
				{
					return;
				}
				action(v);
			}

			// Token: 0x040002BC RID: 700
			private Action<View> handler;
		}

		// Token: 0x0200008B RID: 139
		[Register("com/google/android/material/snackbar/Snackbar$Callback", DoNotGenerateAcw = true)]
		public class Callback : BaseTransientBottomBar.BaseCallback
		{
			// Token: 0x17000175 RID: 373
			// (get) Token: 0x06000979 RID: 2425 RVA: 0x00019B58 File Offset: 0x00017D58
			internal new static IntPtr class_ref
			{
				get
				{
					return Snackbar.Callback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x0600097A RID: 2426 RVA: 0x00019B7C File Offset: 0x00017D7C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Snackbar.Callback._members;
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x0600097B RID: 2427 RVA: 0x00019B84 File Offset: 0x00017D84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Snackbar.Callback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x0600097C RID: 2428 RVA: 0x00019BA8 File Offset: 0x00017DA8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Snackbar.Callback._members.ManagedPeerType;
				}
			}

			// Token: 0x0600097D RID: 2429 RVA: 0x00019BB4 File Offset: 0x00017DB4
			protected Callback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x00019BC0 File Offset: 0x00017DC0
			[Register(".ctor", "()V", "")]
			public Callback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Snackbar.Callback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Snackbar.Callback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600097F RID: 2431 RVA: 0x00019C2E File Offset: 0x00017E2E
			private static Delegate GetOnDismissed_Lcom_google_android_material_snackbar_Snackbar_IHandler()
			{
				if (Snackbar.Callback.cb_onDismissed_Lcom_google_android_material_snackbar_Snackbar_I == null)
				{
					Snackbar.Callback.cb_onDismissed_Lcom_google_android_material_snackbar_Snackbar_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Snackbar.Callback.n_OnDismissed_Lcom_google_android_material_snackbar_Snackbar_I));
				}
				return Snackbar.Callback.cb_onDismissed_Lcom_google_android_material_snackbar_Snackbar_I;
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x00019C54 File Offset: 0x00017E54
			private static void n_OnDismissed_Lcom_google_android_material_snackbar_Snackbar_I(IntPtr jnienv, IntPtr native__this, IntPtr native_transientBottomBar, int e)
			{
				Snackbar.Callback @object = Java.Lang.Object.GetObject<Snackbar.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Snackbar object2 = Java.Lang.Object.GetObject<Snackbar>(native_transientBottomBar, JniHandleOwnership.DoNotTransfer);
				@object.OnDismissed(object2, e);
			}

			// Token: 0x06000981 RID: 2433 RVA: 0x00019C78 File Offset: 0x00017E78
			[Register("onDismissed", "(Lcom/google/android/material/snackbar/Snackbar;I)V", "GetOnDismissed_Lcom_google_android_material_snackbar_Snackbar_IHandler")]
			public unsafe virtual void OnDismissed(Snackbar transientBottomBar, int e)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((transientBottomBar == null) ? IntPtr.Zero : transientBottomBar.Handle);
					ptr[1] = new JniArgumentValue(e);
					Snackbar.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onDismissed.(Lcom/google/android/material/snackbar/Snackbar;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(transientBottomBar);
				}
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x00019CF0 File Offset: 0x00017EF0
			private static Delegate GetOnShown_Lcom_google_android_material_snackbar_Snackbar_Handler()
			{
				if (Snackbar.Callback.cb_onShown_Lcom_google_android_material_snackbar_Snackbar_ == null)
				{
					Snackbar.Callback.cb_onShown_Lcom_google_android_material_snackbar_Snackbar_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Snackbar.Callback.n_OnShown_Lcom_google_android_material_snackbar_Snackbar_));
				}
				return Snackbar.Callback.cb_onShown_Lcom_google_android_material_snackbar_Snackbar_;
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x00019D14 File Offset: 0x00017F14
			private static void n_OnShown_Lcom_google_android_material_snackbar_Snackbar_(IntPtr jnienv, IntPtr native__this, IntPtr native_sb)
			{
				Snackbar.Callback @object = Java.Lang.Object.GetObject<Snackbar.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Snackbar object2 = Java.Lang.Object.GetObject<Snackbar>(native_sb, JniHandleOwnership.DoNotTransfer);
				@object.OnShown(object2);
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x00019D38 File Offset: 0x00017F38
			[Register("onShown", "(Lcom/google/android/material/snackbar/Snackbar;)V", "GetOnShown_Lcom_google_android_material_snackbar_Snackbar_Handler")]
			public unsafe virtual void OnShown(Snackbar sb)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((sb == null) ? IntPtr.Zero : sb.Handle);
					Snackbar.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onShown.(Lcom/google/android/material/snackbar/Snackbar;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(sb);
				}
			}

			// Token: 0x040002BD RID: 701
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/Snackbar$Callback", typeof(Snackbar.Callback));

			// Token: 0x040002BE RID: 702
			private static Delegate cb_onDismissed_Lcom_google_android_material_snackbar_Snackbar_I;

			// Token: 0x040002BF RID: 703
			private static Delegate cb_onShown_Lcom_google_android_material_snackbar_Snackbar_;
		}
	}
}
