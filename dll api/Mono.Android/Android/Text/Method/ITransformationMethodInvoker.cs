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
	// Token: 0x020001D2 RID: 466
	[Register("android/text/method/TransformationMethod", DoNotGenerateAcw = true)]
	internal class ITransformationMethodInvoker : Java.Lang.Object, ITransformationMethod, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransformationMethodInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransformationMethodInvoker._members;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0002C6EF File Offset: 0x0002A8EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x0002C6F7 File Offset: 0x0002A8F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransformationMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0002C703 File Offset: 0x0002A903
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransformationMethodInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.method.TransformationMethod'.");
			}
			return handle;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0002C72E File Offset: 0x0002A92E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0002C760 File Offset: 0x0002A960
		public ITransformationMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransformationMethodInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0002C798 File Offset: 0x0002A998
		private static Delegate GetGetTransformation_Ljava_lang_CharSequence_Landroid_view_View_Handler()
		{
			if (ITransformationMethodInvoker.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ == null)
			{
				ITransformationMethodInvoker.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ITransformationMethodInvoker.n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_));
			}
			return ITransformationMethodInvoker.cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		private static IntPtr n_GetTransformation_Ljava_lang_CharSequence_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_source, IntPtr native_view)
		{
			ITransformationMethod @object = Java.Lang.Object.GetObject<ITransformationMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_source, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle(@object.GetTransformationFormatted(object2, object3));
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		public unsafe ICharSequence GetTransformationFormatted(ICharSequence source, View view)
		{
			if (this.id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "getTransformation", "(Ljava/lang/CharSequence;Landroid/view/View;)Ljava/lang/CharSequence;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ICharSequence @object = Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0002C889 File Offset: 0x0002AA89
		private static Delegate GetOnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_Handler()
		{
			if (ITransformationMethodInvoker.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ == null)
			{
				ITransformationMethodInvoker.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZIL_V(ITransformationMethodInvoker.n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_));
			}
			return ITransformationMethodInvoker.cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		private static void n_OnFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_sourceText, bool focused, int native_direction, IntPtr native_previouslyFocusedRect)
		{
			ITransformationMethod @object = Java.Lang.Object.GetObject<ITransformationMethod>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ICharSequence object3 = Java.Lang.Object.GetObject<ICharSequence>(native_sourceText, JniHandleOwnership.DoNotTransfer);
			Rect object4 = Java.Lang.Object.GetObject<Rect>(native_previouslyFocusedRect, JniHandleOwnership.DoNotTransfer);
			@object.OnFocusChanged(object2, object3, focused, (FocusSearchDirection)native_direction, object4);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0002C8EC File Offset: 0x0002AAEC
		public unsafe void OnFocusChanged(View view, ICharSequence sourceText, bool focused, [GeneratedEnum] FocusSearchDirection direction, Rect previouslyFocusedRect)
		{
			if (this.id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ == IntPtr.Zero)
			{
				this.id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_ = JNIEnv.GetMethodID(this.class_ref, "onFocusChanged", "(Landroid/view/View;Ljava/lang/CharSequence;ZILandroid/graphics/Rect;)V");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(sourceText);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(focused);
			ptr[3] = new JValue((int)direction);
			ptr[4] = new JValue((previouslyFocusedRect == null) ? IntPtr.Zero : previouslyFocusedRect.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040007B0 RID: 1968
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/method/TransformationMethod", typeof(ITransformationMethodInvoker));

		// Token: 0x040007B1 RID: 1969
		private IntPtr class_ref;

		// Token: 0x040007B2 RID: 1970
		private static Delegate cb_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;

		// Token: 0x040007B3 RID: 1971
		private IntPtr id_getTransformation_Ljava_lang_CharSequence_Landroid_view_View_;

		// Token: 0x040007B4 RID: 1972
		private static Delegate cb_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;

		// Token: 0x040007B5 RID: 1973
		private IntPtr id_onFocusChanged_Landroid_view_View_Ljava_lang_CharSequence_ZILandroid_graphics_Rect_;
	}
}
