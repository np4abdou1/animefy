using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B0 RID: 688
	[Register("com/unity3d/scar/adapter/common/signals/ISignalCollectionListener", DoNotGenerateAcw = true)]
	internal class ISignalCollectionListenerInvoker : Java.Lang.Object, ISignalCollectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x00064E14 File Offset: 0x00063014
		private static IntPtr java_class_ref
		{
			get
			{
				return ISignalCollectionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x00064E38 File Offset: 0x00063038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISignalCollectionListenerInvoker._members;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00064E3F File Offset: 0x0006303F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x00064E47 File Offset: 0x00063047
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISignalCollectionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00064E53 File Offset: 0x00063053
		public static ISignalCollectionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISignalCollectionListener>(handle, transfer);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00064E5C File Offset: 0x0006305C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISignalCollectionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.signals.ISignalCollectionListener'.");
			}
			return handle;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00064E87 File Offset: 0x00063087
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00064EB8 File Offset: 0x000630B8
		public ISignalCollectionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISignalCollectionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00064EF0 File Offset: 0x000630F0
		private static Delegate GetOnSignalsCollected_Ljava_lang_String_Handler()
		{
			if (ISignalCollectionListenerInvoker.cb_onSignalsCollected_Ljava_lang_String_ == null)
			{
				ISignalCollectionListenerInvoker.cb_onSignalsCollected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISignalCollectionListenerInvoker.n_OnSignalsCollected_Ljava_lang_String_));
			}
			return ISignalCollectionListenerInvoker.cb_onSignalsCollected_Ljava_lang_String_;
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00064F14 File Offset: 0x00063114
		private static void n_OnSignalsCollected_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISignalCollectionListener @object = Java.Lang.Object.GetObject<ISignalCollectionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalsCollected(@string);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00064F38 File Offset: 0x00063138
		public unsafe void OnSignalsCollected(string p0)
		{
			if (this.id_onSignalsCollected_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onSignalsCollected_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onSignalsCollected", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSignalsCollected_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00064FA9 File Offset: 0x000631A9
		private static Delegate GetOnSignalsCollectionFailed_Ljava_lang_String_Handler()
		{
			if (ISignalCollectionListenerInvoker.cb_onSignalsCollectionFailed_Ljava_lang_String_ == null)
			{
				ISignalCollectionListenerInvoker.cb_onSignalsCollectionFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISignalCollectionListenerInvoker.n_OnSignalsCollectionFailed_Ljava_lang_String_));
			}
			return ISignalCollectionListenerInvoker.cb_onSignalsCollectionFailed_Ljava_lang_String_;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00064FD0 File Offset: 0x000631D0
		private static void n_OnSignalsCollectionFailed_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISignalCollectionListener @object = Java.Lang.Object.GetObject<ISignalCollectionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalsCollectionFailed(@string);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00064FF4 File Offset: 0x000631F4
		public unsafe void OnSignalsCollectionFailed(string p0)
		{
			if (this.id_onSignalsCollectionFailed_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onSignalsCollectionFailed_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onSignalsCollectionFailed", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSignalsCollectionFailed_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x040007C9 RID: 1993
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/ISignalCollectionListener", typeof(ISignalCollectionListenerInvoker));

		// Token: 0x040007CA RID: 1994
		private IntPtr class_ref;

		// Token: 0x040007CB RID: 1995
		private static Delegate cb_onSignalsCollected_Ljava_lang_String_;

		// Token: 0x040007CC RID: 1996
		private IntPtr id_onSignalsCollected_Ljava_lang_String_;

		// Token: 0x040007CD RID: 1997
		private static Delegate cb_onSignalsCollectionFailed_Ljava_lang_String_;

		// Token: 0x040007CE RID: 1998
		private IntPtr id_onSignalsCollectionFailed_Ljava_lang_String_;
	}
}
