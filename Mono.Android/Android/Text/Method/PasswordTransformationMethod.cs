using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Method
{
	// Token: 0x020001D4 RID: 468
	[Register("android/text/method/PasswordTransformationMethod", DoNotGenerateAcw = true)]
	public class PasswordTransformationMethod : Java.Lang.Object, ITransformationMethod, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0002CA80 File Offset: 0x0002AC80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PasswordTransformationMethod._members;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x0002CA88 File Offset: 0x0002AC88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PasswordTransformationMethod._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0002CAAC File Offset: 0x0002ACAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PasswordTransformationMethod._members.ManagedPeerType;
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PasswordTransformationMethod(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0002CAB8 File Offset: 0x0002ACB8
		public PasswordTransformationMethod() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PasswordTransformationMethod._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PasswordTransformationMethod._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0002CB26 File Offset: 0x0002AD26
		private static Delegate GetGetTransformation_Ljava_lang_CharSequence_Landroid_view_View_Handler()
		{
			if (PasswordTransformationMethod.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ == null)
			{
				PasswordTransformationMethod.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(PasswordTransformationMethod.n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_));
			}
			return PasswordTransformationMethod.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		private static IntPtr n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_view)
		{
			PasswordTransformationMethod @object = Java.Lang.Object.GetObject<PasswordTransformationMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_source, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle(@object.GetTransformationFormatted(object2, object3));
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0002CB80 File Offset: 0x0002AD80
		public unsafe virtual ICharSequence GetTransformationFormatted(ICharSequence source, View view)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(PasswordTransformationMethod._members.InstanceMethods.InvokeVirtualObjectMethod("getTransformation.(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(source);
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0002CC1C File Offset: 0x0002AE1C
		private static Delegate GetOnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_Handler()
		{
			if (PasswordTransformationMethod.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ == null)
			{
				PasswordTransformationMethod.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZIL_V(PasswordTransformationMethod.n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_));
			}
			return PasswordTransformationMethod.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0002CC40 File Offset: 0x0002AE40
		private static void n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_sourceText, bool focused, int native_direction, IntPtr native_previouslyFocusedRect)
		{
			PasswordTransformationMethod @object = Java.Lang.Object.GetObject<PasswordTransformationMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ICharSequence object3 = Java.Lang.Object.GetObject<ICharSequence>(native_sourceText, JniHandleOwnership.DoNotTransfer);
			Rect object4 = Java.Lang.Object.GetObject<Rect>(native_previouslyFocusedRect, JniHandleOwnership.DoNotTransfer);
			@object.OnFocusChanged(object2, object3, focused, (FocusSearchDirection)native_direction, object4);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0002CC7C File Offset: 0x0002AE7C
		public unsafe virtual void OnFocusChanged(View view, ICharSequence sourceText, bool focused, [GeneratedEnum] FocusSearchDirection direction, Rect previouslyFocusedRect)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(sourceText);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(focused);
				ptr[3] = new JniArgumentValue((int)direction);
				ptr[4] = new JniArgumentValue((previouslyFocusedRect == null) ? IntPtr.Zero : previouslyFocusedRect.Handle);
				PasswordTransformationMethod._members.InstanceMethods.InvokeVirtualVoidMethod("onFocusChanged.(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
				GC.KeepAlive(sourceText);
				GC.KeepAlive(previouslyFocusedRect);
			}
		}

		// Token: 0x040007B7 RID: 1975
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/PasswordTransformationMethod", typeof(PasswordTransformationMethod));

		// Token: 0x040007B8 RID: 1976
		private static Delegate cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;

		// Token: 0x040007B9 RID: 1977
		private static Delegate cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
	}
}
