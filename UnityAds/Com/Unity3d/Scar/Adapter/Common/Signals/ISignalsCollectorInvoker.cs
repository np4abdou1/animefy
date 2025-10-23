using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B5 RID: 693
	[Register("com/unity3d/scar/adapter/common/signals/ISignalsCollector", DoNotGenerateAcw = true)]
	internal class ISignalsCollectorInvoker : Java.Lang.Object, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x00065154 File Offset: 0x00063354
		private static IntPtr java_class_ref
		{
			get
			{
				return ISignalsCollectorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00065178 File Offset: 0x00063378
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISignalsCollectorInvoker._members;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x0006517F File Offset: 0x0006337F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x00065187 File Offset: 0x00063387
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISignalsCollectorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x00065193 File Offset: 0x00063393
		public static ISignalsCollector GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISignalsCollector>(handle, transfer);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0006519C File Offset: 0x0006339C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISignalsCollectorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.signals.ISignalsCollector'.");
			}
			return handle;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000651C7 File Offset: 0x000633C7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000651F8 File Offset: 0x000633F8
		public ISignalsCollectorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISignalsCollectorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00065230 File Offset: 0x00063430
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (ISignalsCollectorInvoker.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				ISignalsCollectorInvoker.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(ISignalsCollectorInvoker.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return ISignalsCollectorInvoker.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00065254 File Offset: 0x00063454
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3, IntPtr native_p4)
		{
			ISignalsCollector @object = Java.Lang.Object.GetObject<ISignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_p3, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_p4, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, p2, object3, object4);
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00065298 File Offset: 0x00063498
		public unsafe void GetSCARSignal(Context p0, string p1, bool p2, DispatchGroup p3, SignalsResult p4)
		{
			if (this.id_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == IntPtr.Zero)
			{
				this.id_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNIEnv.GetMethodID(this.class_ref, "getSCARSignal", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : p3.Handle);
			ptr[4] = new JValue((p4 == null) ? IntPtr.Zero : p4.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0006538F File Offset: 0x0006358F
		private static Delegate GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler()
		{
			if (ISignalsCollectorInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == null)
			{
				ISignalsCollectorInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(ISignalsCollectorInvoker.n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_));
			}
			return ISignalsCollectorInvoker.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000653B4 File Offset: 0x000635B4
		private static void n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			ISignalsCollector @object = Java.Lang.Object.GetObject<ISignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(string));
			string[] array2 = (string[])JNIEnv.GetArray(native_p2, JniHandleOwnership.DoNotTransfer, typeof(string));
			ISignalCollectionListener object3 = Java.Lang.Object.GetObject<ISignalCollectionListener>(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignals(object2, array, array2, object3);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_p1);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_p2);
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00065428 File Offset: 0x00063628
		public unsafe void GetSCARSignals(Context p0, string[] p1, string[] p2, ISignalCollectionListener p3)
		{
			if (this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == IntPtr.Zero)
			{
				this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNIEnv.GetMethodID(this.class_ref, "getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(p1);
			IntPtr intPtr2 = JNIEnv.NewArray(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			ptr[2] = new JValue(intPtr2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_, ptr);
			if (p1 != null)
			{
				JNIEnv.CopyArray(intPtr, p1);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (p2 != null)
			{
				JNIEnv.CopyArray(intPtr2, p2);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x040007D4 RID: 2004
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/ISignalsCollector", typeof(ISignalsCollectorInvoker));

		// Token: 0x040007D5 RID: 2005
		private IntPtr class_ref;

		// Token: 0x040007D6 RID: 2006
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;

		// Token: 0x040007D7 RID: 2007
		private IntPtr id_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;

		// Token: 0x040007D8 RID: 2008
		private static Delegate cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;

		// Token: 0x040007D9 RID: 2009
		private IntPtr id_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;
	}
}
