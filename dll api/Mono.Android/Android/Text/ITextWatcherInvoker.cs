using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001AD RID: 429
	[Register("android/text/TextWatcher", DoNotGenerateAcw = true)]
	internal class ITextWatcherInvoker : Java.Lang.Object, ITextWatcher, INoCopySpan, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000274B0 File Offset: 0x000256B0
		private static IntPtr java_class_ref
		{
			get
			{
				return ITextWatcherInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000274D4 File Offset: 0x000256D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITextWatcherInvoker._members;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000274DB File Offset: 0x000256DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000274E3 File Offset: 0x000256E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITextWatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000274EF File Offset: 0x000256EF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITextWatcherInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.TextWatcher'.");
			}
			return handle;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0002751A File Offset: 0x0002571A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0002754C File Offset: 0x0002574C
		public ITextWatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITextWatcherInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00027584 File Offset: 0x00025784
		private static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler()
		{
			if (ITextWatcherInvoker.cb_afterTextChanged_Landroid_text_Editable_ == null)
			{
				ITextWatcherInvoker.cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITextWatcherInvoker.n_AfterTextChanged_Landroid_text_Editable_));
			}
			return ITextWatcherInvoker.cb_afterTextChanged_Landroid_text_Editable_;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x000275A8 File Offset: 0x000257A8
		private static void n_AfterTextChanged_Landroid_text_Editable_(IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			ITextWatcher @object = Java.Lang.Object.GetObject<ITextWatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IEditable object2 = Java.Lang.Object.GetObject<IEditable>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.AfterTextChanged(object2);
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000275CC File Offset: 0x000257CC
		public unsafe void AfterTextChanged(IEditable s)
		{
			if (this.id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
			{
				this.id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID(this.class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((s == null) ? IntPtr.Zero : ((Java.Lang.Object)s).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_afterTextChanged_Landroid_text_Editable_, ptr);
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00027644 File Offset: 0x00025844
		private static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler()
		{
			if (ITextWatcherInvoker.cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
			{
				ITextWatcherInvoker.cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(ITextWatcherInvoker.n_BeforeTextChanged_Ljava_lang_CharSequence_III));
			}
			return ITextWatcherInvoker.cb_beforeTextChanged_Ljava_lang_CharSequence_III;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00027668 File Offset: 0x00025868
		private static void n_BeforeTextChanged_Ljava_lang_CharSequence_III(IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int count, int after)
		{
			ITextWatcher @object = Java.Lang.Object.GetObject<ITextWatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.BeforeTextChanged(object2, start, count, after);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00027690 File Offset: 0x00025890
		public unsafe void BeforeTextChanged(ICharSequence s, int start, int count, int after)
		{
			if (this.id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
			{
				this.id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID(this.class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(count);
			ptr[3] = new JValue(after);
			JNIEnv.CallVoidMethod(base.Handle, this.id_beforeTextChanged_Ljava_lang_CharSequence_III, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00027741 File Offset: 0x00025941
		private static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler()
		{
			if (ITextWatcherInvoker.cb_onTextChanged_Ljava_lang_CharSequence_III == null)
			{
				ITextWatcherInvoker.cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIII_V(ITextWatcherInvoker.n_OnTextChanged_Ljava_lang_CharSequence_III));
			}
			return ITextWatcherInvoker.cb_onTextChanged_Ljava_lang_CharSequence_III;
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00027768 File Offset: 0x00025968
		private static void n_OnTextChanged_Ljava_lang_CharSequence_III(IntPtr jnienv, IntPtr native__this, IntPtr native_s, int start, int before, int count)
		{
			ITextWatcher @object = Java.Lang.Object.GetObject<ITextWatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.OnTextChanged(object2, start, before, count);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00027790 File Offset: 0x00025990
		public unsafe void OnTextChanged(ICharSequence s, int start, int before, int count)
		{
			if (this.id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
			{
				this.id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID(this.class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(s);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(before);
			ptr[3] = new JValue(count);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTextChanged_Ljava_lang_CharSequence_III, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000712 RID: 1810
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/TextWatcher", typeof(ITextWatcherInvoker));

		// Token: 0x04000713 RID: 1811
		private IntPtr class_ref;

		// Token: 0x04000714 RID: 1812
		private static Delegate cb_afterTextChanged_Landroid_text_Editable_;

		// Token: 0x04000715 RID: 1813
		private IntPtr id_afterTextChanged_Landroid_text_Editable_;

		// Token: 0x04000716 RID: 1814
		private static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;

		// Token: 0x04000717 RID: 1815
		private IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;

		// Token: 0x04000718 RID: 1816
		private static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;

		// Token: 0x04000719 RID: 1817
		private IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
	}
}
