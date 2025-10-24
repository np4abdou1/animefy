using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A1 RID: 417
	[Register("android/text/InputFilter", DoNotGenerateAcw = true)]
	internal class IInputFilterInvoker : Java.Lang.Object, IInputFilter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0002608C File Offset: 0x0002428C
		private static IntPtr java_class_ref
		{
			get
			{
				return IInputFilterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000260B0 File Offset: 0x000242B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInputFilterInvoker._members;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000260B7 File Offset: 0x000242B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x000260BF File Offset: 0x000242BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInputFilterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000260CB File Offset: 0x000242CB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInputFilterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.InputFilter'.");
			}
			return handle;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000260F6 File Offset: 0x000242F6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00026128 File Offset: 0x00024328
		public IInputFilterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInputFilterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00026160 File Offset: 0x00024360
		private static Delegate GetFilter_Ljava_lang_CharSequence_IILandroid_text_Spanned_IIHandler()
		{
			if (IInputFilterInvoker.cb_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II == null)
			{
				IInputFilterInvoker.cb_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILII_L(IInputFilterInvoker.n_Filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II));
			}
			return IInputFilterInvoker.cb_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00026184 File Offset: 0x00024384
		private static IntPtr n_Filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II(IntPtr jnienv, IntPtr native__this, IntPtr native_source, int start, int end, IntPtr native_dest, int dstart, int dend)
		{
			IInputFilter @object = Java.Lang.Object.GetObject<IInputFilter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_source, JniHandleOwnership.DoNotTransfer);
			ISpanned object3 = Java.Lang.Object.GetObject<ISpanned>(native_dest, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle(@object.FilterFormatted(object2, start, end, object3, dstart, dend));
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000261C0 File Offset: 0x000243C0
		public unsafe ICharSequence FilterFormatted(ICharSequence source, int start, int end, ISpanned dest, int dstart, int dend)
		{
			if (this.id_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II == IntPtr.Zero)
			{
				this.id_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II = JNIEnv.GetMethodID(this.class_ref, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(source);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(end);
			ptr[3] = new JValue((dest == null) ? IntPtr.Zero : ((Java.Lang.Object)dest).Handle);
			ptr[4] = new JValue(dstart);
			ptr[5] = new JValue(dend);
			ICharSequence @object = Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x040006DF RID: 1759
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/InputFilter", typeof(IInputFilterInvoker));

		// Token: 0x040006E0 RID: 1760
		private IntPtr class_ref;

		// Token: 0x040006E1 RID: 1761
		private static Delegate cb_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II;

		// Token: 0x040006E2 RID: 1762
		private IntPtr id_filter_Ljava_lang_CharSequence_IILandroid_text_Spanned_II;
	}
}
