using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003CD RID: 973
	[Register("java/lang/Appendable", DoNotGenerateAcw = true)]
	internal class IAppendableInvoker : Object, IAppendable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002AF3 RID: 10995 RVA: 0x00077AE4 File Offset: 0x00075CE4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppendableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x00077B08 File Offset: 0x00075D08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppendableInvoker._members;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x00077B0F File Offset: 0x00075D0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x00077B17 File Offset: 0x00075D17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppendableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00077B23 File Offset: 0x00075D23
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppendableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Appendable'.");
			}
			return handle;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00077B4E File Offset: 0x00075D4E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00077B80 File Offset: 0x00075D80
		public IAppendableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppendableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00077BB8 File Offset: 0x00075DB8
		private static Delegate GetAppend_CHandler()
		{
			if (IAppendableInvoker.cb_append_C == null)
			{
				IAppendableInvoker.cb_append_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(IAppendableInvoker.n_Append_C));
			}
			return IAppendableInvoker.cb_append_C;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00077BDC File Offset: 0x00075DDC
		private static IntPtr n_Append_C(IntPtr jnienv, IntPtr native__this, char c)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<IAppendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Append(c));
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00077BF4 File Offset: 0x00075DF4
		public unsafe IAppendable Append(char c)
		{
			if (this.id_append_C == IntPtr.Zero)
			{
				this.id_append_C = JNIEnv.GetMethodID(this.class_ref, "append", "(C)Ljava/lang/Appendable;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(c);
			return Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00077C5E File Offset: 0x00075E5E
		private static Delegate GetAppend_Ljava_lang_CharSequence_Handler()
		{
			if (IAppendableInvoker.cb_append_Ljava_lang_CharSequence_ == null)
			{
				IAppendableInvoker.cb_append_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAppendableInvoker.n_Append_Ljava_lang_CharSequence_));
			}
			return IAppendableInvoker.cb_append_Ljava_lang_CharSequence_;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00077C84 File Offset: 0x00075E84
		private static IntPtr n_Append_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_csq)
		{
			IAppendable @object = Object.GetObject<IAppendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2));
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00077CAC File Offset: 0x00075EAC
		public unsafe IAppendable Append(ICharSequence csq)
		{
			if (this.id_append_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_append_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IAppendable @object = Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00077D23 File Offset: 0x00075F23
		private static Delegate GetAppend_Ljava_lang_CharSequence_IIHandler()
		{
			if (IAppendableInvoker.cb_append_Ljava_lang_CharSequence_II == null)
			{
				IAppendableInvoker.cb_append_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(IAppendableInvoker.n_Append_Ljava_lang_CharSequence_II));
			}
			return IAppendableInvoker.cb_append_Ljava_lang_CharSequence_II;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00077D48 File Offset: 0x00075F48
		private static IntPtr n_Append_Ljava_lang_CharSequence_II(IntPtr jnienv, IntPtr native__this, IntPtr native_csq, int start, int end)
		{
			IAppendable @object = Object.GetObject<IAppendable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Object.GetObject<ICharSequence>(native_csq, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Append(object2, start, end));
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00077D74 File Offset: 0x00075F74
		public unsafe IAppendable Append(ICharSequence csq, int start, int end)
		{
			if (this.id_append_Ljava_lang_CharSequence_II == IntPtr.Zero)
			{
				this.id_append_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID(this.class_ref, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(csq);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(start);
			ptr[2] = new JValue(end);
			IAppendable @object = Object.GetObject<IAppendable>(JNIEnv.CallObjectMethod(base.Handle, this.id_append_Ljava_lang_CharSequence_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x0400113E RID: 4414
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Appendable", typeof(IAppendableInvoker));

		// Token: 0x0400113F RID: 4415
		private IntPtr class_ref;

		// Token: 0x04001140 RID: 4416
		private static Delegate cb_append_C;

		// Token: 0x04001141 RID: 4417
		private IntPtr id_append_C;

		// Token: 0x04001142 RID: 4418
		private static Delegate cb_append_Ljava_lang_CharSequence_;

		// Token: 0x04001143 RID: 4419
		private IntPtr id_append_Ljava_lang_CharSequence_;

		// Token: 0x04001144 RID: 4420
		private static Delegate cb_append_Ljava_lang_CharSequence_II;

		// Token: 0x04001145 RID: 4421
		private IntPtr id_append_Ljava_lang_CharSequence_II;
	}
}
