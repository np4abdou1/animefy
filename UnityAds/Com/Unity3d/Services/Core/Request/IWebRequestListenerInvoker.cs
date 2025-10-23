using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A4 RID: 164
	[Register("com/unity3d/services/core/request/IWebRequestListener", DoNotGenerateAcw = true)]
	internal class IWebRequestListenerInvoker : Java.Lang.Object, IWebRequestListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00010970 File Offset: 0x0000EB70
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebRequestListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00010994 File Offset: 0x0000EB94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebRequestListenerInvoker._members;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001099B File Offset: 0x0000EB9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000109A3 File Offset: 0x0000EBA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebRequestListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000109AF File Offset: 0x0000EBAF
		public static IWebRequestListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebRequestListener>(handle, transfer);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000109B8 File Offset: 0x0000EBB8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebRequestListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.request.IWebRequestListener'.");
			}
			return handle;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000109E3 File Offset: 0x0000EBE3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00010A14 File Offset: 0x0000EC14
		public IWebRequestListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebRequestListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00010A4C File Offset: 0x0000EC4C
		private static Delegate GetOnComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_Handler()
		{
			if (IWebRequestListenerInvoker.cb_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_ == null)
			{
				IWebRequestListenerInvoker.cb_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIL_V(IWebRequestListenerInvoker.n_OnComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_));
			}
			return IWebRequestListenerInvoker.cb_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00010A70 File Offset: 0x0000EC70
		private static void n_OnComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			IWebRequestListener @object = Java.Lang.Object.GetObject<IWebRequestListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, IList<string>> p3 = JavaDictionary<string, IList<string>>.FromJniHandle(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.OnComplete(@string, string2, p2, p3);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		public unsafe void OnComplete(string p0, string p1, int p2, IDictionary<string, IList<string>> p3)
		{
			if (this.id_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_ == IntPtr.Zero)
			{
				this.id_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "onComplete", "(Ljava/lang/String;Ljava/lang/String;ILjava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(p3);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(intPtr3);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00010B73 File Offset: 0x0000ED73
		private static Delegate GetOnFailed_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IWebRequestListenerInvoker.cb_onFailed_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IWebRequestListenerInvoker.cb_onFailed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IWebRequestListenerInvoker.n_OnFailed_Ljava_lang_String_Ljava_lang_String_));
			}
			return IWebRequestListenerInvoker.cb_onFailed_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00010B98 File Offset: 0x0000ED98
		private static void n_OnFailed_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IWebRequestListener @object = Java.Lang.Object.GetObject<IWebRequestListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnFailed(@string, string2);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		public unsafe void OnFailed(string p0, string p1)
		{
			if (this.id_onFailed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onFailed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onFailed", "(Ljava/lang/String;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFailed_Ljava_lang_String_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0400015F RID: 351
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/IWebRequestListener", typeof(IWebRequestListenerInvoker));

		// Token: 0x04000160 RID: 352
		private IntPtr class_ref;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_;

		// Token: 0x04000162 RID: 354
		private IntPtr id_onComplete_Ljava_lang_String_Ljava_lang_String_ILjava_util_Map_;

		// Token: 0x04000163 RID: 355
		private static Delegate cb_onFailed_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000164 RID: 356
		private IntPtr id_onFailed_Ljava_lang_String_Ljava_lang_String_;
	}
}
