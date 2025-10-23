using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Text;
using Google.Android.Material.Resources;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Internal
{
	// Token: 0x02000097 RID: 151
	[Register("com/google/android/material/internal/TextDrawableHelper", DoNotGenerateAcw = true)]
	public class TextDrawableHelper : Java.Lang.Object
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		internal static IntPtr class_ref
		{
			get
			{
				return TextDrawableHelper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextDrawableHelper._members;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0001BDFC File Offset: 0x00019FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextDrawableHelper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0001BE20 File Offset: 0x0001A020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextDrawableHelper._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000020DC File Offset: 0x000002DC
		protected TextDrawableHelper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001BE2C File Offset: 0x0001A02C
		[Register(".ctor", "(Lcom/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate;)V", "")]
		public unsafe TextDrawableHelper(TextDrawableHelper.ITextDrawableDelegate @delegate) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@delegate == null) ? IntPtr.Zero : ((Java.Lang.Object)@delegate).Handle);
				base.SetHandle(TextDrawableHelper._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextDrawableHelper._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@delegate);
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
		private static Delegate GetGetTextAppearanceHandler()
		{
			if (TextDrawableHelper.cb_getTextAppearance == null)
			{
				TextDrawableHelper.cb_getTextAppearance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextDrawableHelper.n_GetTextAppearance));
			}
			return TextDrawableHelper.cb_getTextAppearance;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001BF04 File Offset: 0x0001A104
		private static IntPtr n_GetTextAppearance(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextAppearance);
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0001BF18 File Offset: 0x0001A118
		public virtual TextAppearance TextAppearance
		{
			[Register("getTextAppearance", "()Lcom/google/android/material/resources/TextAppearance;", "GetGetTextAppearanceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextAppearance>(TextDrawableHelper._members.InstanceMethods.InvokeVirtualObjectMethod("getTextAppearance.()Lcom/google/android/material/resources/TextAppearance;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001BF4A File Offset: 0x0001A14A
		private static Delegate GetGetTextPaintHandler()
		{
			if (TextDrawableHelper.cb_getTextPaint == null)
			{
				TextDrawableHelper.cb_getTextPaint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextDrawableHelper.n_GetTextPaint));
			}
			return TextDrawableHelper.cb_getTextPaint;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001BF6E File Offset: 0x0001A16E
		private static IntPtr n_GetTextPaint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextPaint);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0001BF84 File Offset: 0x0001A184
		public virtual TextPaint TextPaint
		{
			[Register("getTextPaint", "()Landroid/text/TextPaint;", "GetGetTextPaintHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TextPaint>(TextDrawableHelper._members.InstanceMethods.InvokeVirtualObjectMethod("getTextPaint.()Landroid/text/TextPaint;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001BFB6 File Offset: 0x0001A1B6
		private static Delegate GetIsTextWidthDirtyHandler()
		{
			if (TextDrawableHelper.cb_isTextWidthDirty == null)
			{
				TextDrawableHelper.cb_isTextWidthDirty = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TextDrawableHelper.n_IsTextWidthDirty));
			}
			return TextDrawableHelper.cb_isTextWidthDirty;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001BFDA File Offset: 0x0001A1DA
		private static bool n_IsTextWidthDirty(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextWidthDirty;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001BFE9 File Offset: 0x0001A1E9
		private static Delegate GetSetTextWidthDirty_ZHandler()
		{
			if (TextDrawableHelper.cb_setTextWidthDirty_Z == null)
			{
				TextDrawableHelper.cb_setTextWidthDirty_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TextDrawableHelper.n_SetTextWidthDirty_Z));
			}
			return TextDrawableHelper.cb_setTextWidthDirty_Z;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001C00D File Offset: 0x0001A20D
		private static void n_SetTextWidthDirty_Z(IntPtr jnienv, IntPtr native__this, bool dirty)
		{
			Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextWidthDirty = dirty;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0001C01D File Offset: 0x0001A21D
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0001C038 File Offset: 0x0001A238
		public unsafe virtual bool TextWidthDirty
		{
			[Register("isTextWidthDirty", "()Z", "GetIsTextWidthDirtyHandler")]
			get
			{
				return TextDrawableHelper._members.InstanceMethods.InvokeVirtualBooleanMethod("isTextWidthDirty.()Z", this, null);
			}
			[Register("setTextWidthDirty", "(Z)V", "GetSetTextWidthDirty_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextDrawableHelper._members.InstanceMethods.InvokeVirtualVoidMethod("setTextWidthDirty.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0001C073 File Offset: 0x0001A273
		private static Delegate GetGetTextWidth_Ljava_lang_String_Handler()
		{
			if (TextDrawableHelper.cb_getTextWidth_Ljava_lang_String_ == null)
			{
				TextDrawableHelper.cb_getTextWidth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_F(TextDrawableHelper.n_GetTextWidth_Ljava_lang_String_));
			}
			return TextDrawableHelper.cb_getTextWidth_Ljava_lang_String_;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0001C098 File Offset: 0x0001A298
		private static float n_GetTextWidth_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			TextDrawableHelper @object = Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_text, JniHandleOwnership.DoNotTransfer);
			return @object.GetTextWidth(@string);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0001C0BC File Offset: 0x0001A2BC
		[Register("getTextWidth", "(Ljava/lang/String;)F", "GetGetTextWidth_Ljava_lang_String_Handler")]
		public unsafe virtual float GetTextWidth(string text)
		{
			IntPtr intPtr = JNIEnv.NewString(text);
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = TextDrawableHelper._members.InstanceMethods.InvokeVirtualSingleMethod("getTextWidth.(Ljava/lang/String;)F", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0001C11C File Offset: 0x0001A31C
		private static Delegate GetSetDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_Handler()
		{
			if (TextDrawableHelper.cb_setDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_ == null)
			{
				TextDrawableHelper.cb_setDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextDrawableHelper.n_SetDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_));
			}
			return TextDrawableHelper.cb_setDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001C140 File Offset: 0x0001A340
		private static void n_SetDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_(IntPtr jnienv, IntPtr native__this, IntPtr native__delegate)
		{
			TextDrawableHelper @object = Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextDrawableHelper.ITextDrawableDelegate object2 = Java.Lang.Object.GetObject<TextDrawableHelper.ITextDrawableDelegate>(native__delegate, JniHandleOwnership.DoNotTransfer);
			@object.SetDelegate(object2);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001C164 File Offset: 0x0001A364
		[Register("setDelegate", "(Lcom/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate;)V", "GetSetDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_Handler")]
		public unsafe virtual void SetDelegate(TextDrawableHelper.ITextDrawableDelegate @delegate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@delegate == null) ? IntPtr.Zero : ((Java.Lang.Object)@delegate).Handle);
				TextDrawableHelper._members.InstanceMethods.InvokeVirtualVoidMethod("setDelegate.(Lcom/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@delegate);
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		private static Delegate GetSetTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_Handler()
		{
			if (TextDrawableHelper.cb_setTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_ == null)
			{
				TextDrawableHelper.cb_setTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(TextDrawableHelper.n_SetTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_));
			}
			return TextDrawableHelper.cb_setTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		private static void n_SetTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_textAppearance, IntPtr native_context)
		{
			TextDrawableHelper @object = Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextAppearance object2 = Java.Lang.Object.GetObject<TextAppearance>(native_textAppearance, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.SetTextAppearance(object2, object3);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001C21C File Offset: 0x0001A41C
		[Register("setTextAppearance", "(Lcom/google/android/material/resources/TextAppearance;Landroid/content/Context;)V", "GetSetTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_Handler")]
		public unsafe virtual void SetTextAppearance(TextAppearance textAppearance, Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((textAppearance == null) ? IntPtr.Zero : textAppearance.Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				TextDrawableHelper._members.InstanceMethods.InvokeVirtualVoidMethod("setTextAppearance.(Lcom/google/android/material/resources/TextAppearance;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(textAppearance);
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001C2A8 File Offset: 0x0001A4A8
		private static Delegate GetUpdateTextPaintDrawState_Landroid_content_Context_Handler()
		{
			if (TextDrawableHelper.cb_updateTextPaintDrawState_Landroid_content_Context_ == null)
			{
				TextDrawableHelper.cb_updateTextPaintDrawState_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextDrawableHelper.n_UpdateTextPaintDrawState_Landroid_content_Context_));
			}
			return TextDrawableHelper.cb_updateTextPaintDrawState_Landroid_content_Context_;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001C2CC File Offset: 0x0001A4CC
		private static void n_UpdateTextPaintDrawState_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			TextDrawableHelper @object = Java.Lang.Object.GetObject<TextDrawableHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			@object.UpdateTextPaintDrawState(object2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		[Register("updateTextPaintDrawState", "(Landroid/content/Context;)V", "GetUpdateTextPaintDrawState_Landroid_content_Context_Handler")]
		public unsafe virtual void UpdateTextPaintDrawState(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				TextDrawableHelper._members.InstanceMethods.InvokeVirtualVoidMethod("updateTextPaintDrawState.(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x040002F3 RID: 755
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/internal/TextDrawableHelper", typeof(TextDrawableHelper));

		// Token: 0x040002F4 RID: 756
		private static Delegate cb_getTextAppearance;

		// Token: 0x040002F5 RID: 757
		private static Delegate cb_getTextPaint;

		// Token: 0x040002F6 RID: 758
		private static Delegate cb_isTextWidthDirty;

		// Token: 0x040002F7 RID: 759
		private static Delegate cb_setTextWidthDirty_Z;

		// Token: 0x040002F8 RID: 760
		private static Delegate cb_getTextWidth_Ljava_lang_String_;

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_setDelegate_Lcom_google_android_material_internal_TextDrawableHelper_TextDrawableDelegate_;

		// Token: 0x040002FA RID: 762
		private static Delegate cb_setTextAppearance_Lcom_google_android_material_resources_TextAppearance_Landroid_content_Context_;

		// Token: 0x040002FB RID: 763
		private static Delegate cb_updateTextPaintDrawState_Landroid_content_Context_;

		// Token: 0x02000098 RID: 152
		[Register("com/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate", "", "Google.Android.Material.Internal.TextDrawableHelper/ITextDrawableDelegateInvoker")]
		public interface ITextDrawableDelegate : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A5E RID: 2654
			[Register("getState", "()[I", "GetGetStateHandler:Google.Android.Material.Internal.TextDrawableHelper/ITextDrawableDelegateInvoker, Xamarin.Google.Android.Material")]
			int[] GetState();

			// Token: 0x06000A5F RID: 2655
			[Register("onStateChange", "([I)Z", "GetOnStateChange_arrayIHandler:Google.Android.Material.Internal.TextDrawableHelper/ITextDrawableDelegateInvoker, Xamarin.Google.Android.Material")]
			bool OnStateChange(int[] p0);

			// Token: 0x06000A60 RID: 2656
			[Register("onTextSizeChange", "()V", "GetOnTextSizeChangeHandler:Google.Android.Material.Internal.TextDrawableHelper/ITextDrawableDelegateInvoker, Xamarin.Google.Android.Material")]
			void OnTextSizeChange();
		}

		// Token: 0x02000099 RID: 153
		[Register("com/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate", DoNotGenerateAcw = true)]
		internal class ITextDrawableDelegateInvoker : Java.Lang.Object, TextDrawableHelper.ITextDrawableDelegate, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0001C370 File Offset: 0x0001A570
			private static IntPtr java_class_ref
			{
				get
				{
					return TextDrawableHelper.ITextDrawableDelegateInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0001C394 File Offset: 0x0001A594
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TextDrawableHelper.ITextDrawableDelegateInvoker._members;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0001C39B File Offset: 0x0001A59B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0001C3A3 File Offset: 0x0001A5A3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TextDrawableHelper.ITextDrawableDelegateInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x0001C3AF File Offset: 0x0001A5AF
			public static TextDrawableHelper.ITextDrawableDelegate GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TextDrawableHelper.ITextDrawableDelegate>(handle, transfer);
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TextDrawableHelper.ITextDrawableDelegateInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.internal.TextDrawableHelper.TextDrawableDelegate'.");
				}
				return handle;
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x0001C3E3 File Offset: 0x0001A5E3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x0001C414 File Offset: 0x0001A614
			public ITextDrawableDelegateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TextDrawableHelper.ITextDrawableDelegateInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x0001C44C File Offset: 0x0001A64C
			private static Delegate GetGetStateHandler()
			{
				if (TextDrawableHelper.ITextDrawableDelegateInvoker.cb_getState == null)
				{
					TextDrawableHelper.ITextDrawableDelegateInvoker.cb_getState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextDrawableHelper.ITextDrawableDelegateInvoker.n_GetState));
				}
				return TextDrawableHelper.ITextDrawableDelegateInvoker.cb_getState;
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x0001C470 File Offset: 0x0001A670
			private static IntPtr n_GetState(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray(Java.Lang.Object.GetObject<TextDrawableHelper.ITextDrawableDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetState());
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x0001C484 File Offset: 0x0001A684
			public int[] GetState()
			{
				if (this.id_getState == IntPtr.Zero)
				{
					this.id_getState = JNIEnv.GetMethodID(this.class_ref, "getState", "()[I");
				}
				return (int[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getState), JniHandleOwnership.TransferLocalRef, typeof(int));
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
			private static Delegate GetOnStateChange_arrayIHandler()
			{
				if (TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onStateChange_arrayI == null)
				{
					TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onStateChange_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(TextDrawableHelper.ITextDrawableDelegateInvoker.n_OnStateChange_arrayI));
				}
				return TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onStateChange_arrayI;
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x0001C508 File Offset: 0x0001A708
			private static bool n_OnStateChange_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				TextDrawableHelper.ITextDrawableDelegate @object = Java.Lang.Object.GetObject<TextDrawableHelper.ITextDrawableDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] array = (int[])JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(int));
				bool result = @object.OnStateChange(array);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p0);
				}
				return result;
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x0001C544 File Offset: 0x0001A744
			public unsafe bool OnStateChange(int[] p0)
			{
				if (this.id_onStateChange_arrayI == IntPtr.Zero)
				{
					this.id_onStateChange_arrayI = JNIEnv.GetMethodID(this.class_ref, "onStateChange", "([I)Z");
				}
				IntPtr intPtr = JNIEnv.NewArray(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_onStateChange_arrayI, ptr);
				if (p0 != null)
				{
					JNIEnv.CopyArray(intPtr, p0);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return result;
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x0001C5BF File Offset: 0x0001A7BF
			private static Delegate GetOnTextSizeChangeHandler()
			{
				if (TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onTextSizeChange == null)
				{
					TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onTextSizeChange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TextDrawableHelper.ITextDrawableDelegateInvoker.n_OnTextSizeChange));
				}
				return TextDrawableHelper.ITextDrawableDelegateInvoker.cb_onTextSizeChange;
			}

			// Token: 0x06000A70 RID: 2672 RVA: 0x0001C5E3 File Offset: 0x0001A7E3
			private static void n_OnTextSizeChange(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<TextDrawableHelper.ITextDrawableDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTextSizeChange();
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x0001C5F2 File Offset: 0x0001A7F2
			public void OnTextSizeChange()
			{
				if (this.id_onTextSizeChange == IntPtr.Zero)
				{
					this.id_onTextSizeChange = JNIEnv.GetMethodID(this.class_ref, "onTextSizeChange", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTextSizeChange);
			}

			// Token: 0x040002FC RID: 764
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/internal/TextDrawableHelper$TextDrawableDelegate", typeof(TextDrawableHelper.ITextDrawableDelegateInvoker));

			// Token: 0x040002FD RID: 765
			private IntPtr class_ref;

			// Token: 0x040002FE RID: 766
			private static Delegate cb_getState;

			// Token: 0x040002FF RID: 767
			private IntPtr id_getState;

			// Token: 0x04000300 RID: 768
			private static Delegate cb_onStateChange_arrayI;

			// Token: 0x04000301 RID: 769
			private IntPtr id_onStateChange_arrayI;

			// Token: 0x04000302 RID: 770
			private static Delegate cb_onTextSizeChange;

			// Token: 0x04000303 RID: 771
			private IntPtr id_onTextSizeChange;
		}
	}
}
