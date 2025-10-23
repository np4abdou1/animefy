using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x02000426 RID: 1062
	[Register("java/io/Writer", DoNotGenerateAcw = true)]
	public abstract class Writer : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable, IFlushable, IAppendable
	{
		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x0007EC5D File Offset: 0x0007CE5D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Writer._members;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x0007EC64 File Offset: 0x0007CE64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Writer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x0007EC88 File Offset: 0x0007CE88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Writer._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Writer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x0007EC94 File Offset: 0x0007CE94
		private static Delegate GetAppend_CHandler()
		{
			if (Writer.cb_append_C == null)
			{
				Writer.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(Writer.n_Append_C));
			}
			return Writer.cb_append_C;
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char c)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Writer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(c));
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x0007ECD0 File Offset: 0x0007CED0
		public unsafe virtual IAppendable Append(char c)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(c);
			return Java.Lang.Object.GetObject<IAppendable>(Writer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(C)Ljava/lang/Appendable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0007ED19 File Offset: 0x0007CF19
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (Writer.cb_append_Ljava_lang_CharSequence_ == null)
			{
				Writer.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Writer.n_Append_Ljava_lang_CharSequence_));
			}
			return Writer.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x0007ED40 File Offset: 0x0007CF40
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_csq)
		{
			Writer @object = Java.Lang.Object.GetObject<Writer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x0007ED68 File Offset: 0x0007CF68
		public unsafe virtual IAppendable Append(ICharSequence csq)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IAppendable>(Writer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;)Ljava/lang/Appendable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(csq);
			}
			return @object;
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x0007EDDC File Offset: 0x0007CFDC
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (Writer.cb_append_Ljava_lang_CharSequence_II == null)
			{
				Writer.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(Writer.n_Append_Ljava_lang_CharSequence_II));
			}
			return Writer.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x0007EE00 File Offset: 0x0007D000
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_csq, int start, int end)
		{
			Writer @object = Java.Lang.Object.GetObject<Writer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x0007EE2C File Offset: 0x0007D02C
		public unsafe virtual IAppendable Append(ICharSequence csq, int start, int end)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			IAppendable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(start);
				ptr[2] = new JniArgumentValue(end);
				@object = Java.Lang.Object.GetObject<IAppendable>(Writer._members.InstanceMethods.InvokeVirtualObjectMethod("append.(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(csq);
			}
			return @object;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		private static Delegate GetCloseHandler()
		{
			if (Writer.cb_close == null)
			{
				Writer.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Writer.n_Close));
			}
			return Writer.cb_close;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x0007EEEC File Offset: 0x0007D0EC
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Writer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06002E72 RID: 11890
		public abstract void Close();

		// Token: 0x06002E73 RID: 11891 RVA: 0x0007EEFB File Offset: 0x0007D0FB
		private static Delegate GetFlushHandler()
		{
			if (Writer.cb_flush == null)
			{
				Writer.cb_flush = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Writer.n_Flush));
			}
			return Writer.cb_flush;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x0007EF1F File Offset: 0x0007D11F
		private static void n_Flush(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Writer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Flush();
		}

		// Token: 0x06002E75 RID: 11893
		public abstract void Flush();

		// Token: 0x04001230 RID: 4656
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Writer", typeof(Writer));

		// Token: 0x04001231 RID: 4657
		private static Delegate cb_append_C;

		// Token: 0x04001232 RID: 4658
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x04001233 RID: 4659
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x04001234 RID: 4660
		private static Delegate cb_close;

		// Token: 0x04001235 RID: 4661
		private static Delegate cb_flush;
	}
}
