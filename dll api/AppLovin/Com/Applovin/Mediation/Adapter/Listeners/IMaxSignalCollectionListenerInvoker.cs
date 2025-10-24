using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter.Listeners
{
	// Token: 0x02000125 RID: 293
	[Register("com/applovin/mediation/adapter/listeners/MaxSignalCollectionListener", DoNotGenerateAcw = true)]
	internal class IMaxSignalCollectionListenerInvoker : Java.Lang.Object, IMaxSignalCollectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00022F78 File Offset: 0x00021178
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxSignalCollectionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x00022F9C File Offset: 0x0002119C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxSignalCollectionListenerInvoker._members;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00022FA3 File Offset: 0x000211A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x00022FAB File Offset: 0x000211AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxSignalCollectionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00022FB7 File Offset: 0x000211B7
		public static IMaxSignalCollectionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxSignalCollectionListener>(handle, transfer);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00022FC0 File Offset: 0x000211C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxSignalCollectionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.listeners.MaxSignalCollectionListener'.");
			}
			return handle;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00022FEB File Offset: 0x000211EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0002301C File Offset: 0x0002121C
		public IMaxSignalCollectionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxSignalCollectionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00023054 File Offset: 0x00021254
		private static Delegate GetOnSignalCollected_Ljava_lang_String_Handler()
		{
			if (IMaxSignalCollectionListenerInvoker.cb_onSignalCollected_Ljava_lang_String_ == null)
			{
				IMaxSignalCollectionListenerInvoker.cb_onSignalCollected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxSignalCollectionListenerInvoker.n_OnSignalCollected_Ljava_lang_String_));
			}
			return IMaxSignalCollectionListenerInvoker.cb_onSignalCollected_Ljava_lang_String_;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00023078 File Offset: 0x00021278
		private static void n_OnSignalCollected_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxSignalCollectionListener @object = Java.Lang.Object.GetObject<IMaxSignalCollectionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalCollected(@string);
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0002309C File Offset: 0x0002129C
		public unsafe void OnSignalCollected(string p0)
		{
			if (this.id_onSignalCollected_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onSignalCollected_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onSignalCollected", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSignalCollected_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0002310D File Offset: 0x0002130D
		private static Delegate GetOnSignalCollectionFailed_Ljava_lang_String_Handler()
		{
			if (IMaxSignalCollectionListenerInvoker.cb_onSignalCollectionFailed_Ljava_lang_String_ == null)
			{
				IMaxSignalCollectionListenerInvoker.cb_onSignalCollectionFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMaxSignalCollectionListenerInvoker.n_OnSignalCollectionFailed_Ljava_lang_String_));
			}
			return IMaxSignalCollectionListenerInvoker.cb_onSignalCollectionFailed_Ljava_lang_String_;
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00023134 File Offset: 0x00021334
		private static void n_OnSignalCollectionFailed_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxSignalCollectionListener @object = Java.Lang.Object.GetObject<IMaxSignalCollectionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalCollectionFailed(@string);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00023158 File Offset: 0x00021358
		public unsafe void OnSignalCollectionFailed(string p0)
		{
			if (this.id_onSignalCollectionFailed_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onSignalCollectionFailed_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onSignalCollectionFailed", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSignalCollectionFailed_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400048D RID: 1165
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/listeners/MaxSignalCollectionListener", typeof(IMaxSignalCollectionListenerInvoker));

		// Token: 0x0400048E RID: 1166
		private IntPtr class_ref;

		// Token: 0x0400048F RID: 1167
		private static Delegate cb_onSignalCollected_Ljava_lang_String_;

		// Token: 0x04000490 RID: 1168
		private IntPtr id_onSignalCollected_Ljava_lang_String_;

		// Token: 0x04000491 RID: 1169
		private static Delegate cb_onSignalCollectionFailed_Ljava_lang_String_;

		// Token: 0x04000492 RID: 1170
		private IntPtr id_onSignalCollectionFailed_Ljava_lang_String_;
	}
}
