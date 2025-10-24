using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000A8 RID: 168
	[Register("com/unity3d/services/core/request/IWebRequestProgressListener", DoNotGenerateAcw = true)]
	internal class IWebRequestProgressListenerInvoker : Java.Lang.Object, IWebRequestProgressListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00010D60 File Offset: 0x0000EF60
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebRequestProgressListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00010D84 File Offset: 0x0000EF84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebRequestProgressListenerInvoker._members;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00010D8B File Offset: 0x0000EF8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00010D93 File Offset: 0x0000EF93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebRequestProgressListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00010D9F File Offset: 0x0000EF9F
		public static IWebRequestProgressListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IWebRequestProgressListener>(handle, transfer);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebRequestProgressListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.request.IWebRequestProgressListener'.");
			}
			return handle;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00010DD3 File Offset: 0x0000EFD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00010E04 File Offset: 0x0000F004
		public IWebRequestProgressListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebRequestProgressListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00010E3C File Offset: 0x0000F03C
		private static Delegate GetOnRequestProgress_Ljava_lang_String_JJHandler()
		{
			if (IWebRequestProgressListenerInvoker.cb_onRequestProgress_Ljava_lang_String_JJ == null)
			{
				IWebRequestProgressListenerInvoker.cb_onRequestProgress_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJJ_V(IWebRequestProgressListenerInvoker.n_OnRequestProgress_Ljava_lang_String_JJ));
			}
			return IWebRequestProgressListenerInvoker.cb_onRequestProgress_Ljava_lang_String_JJ;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00010E60 File Offset: 0x0000F060
		private static void n_OnRequestProgress_Ljava_lang_String_JJ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			IWebRequestProgressListener @object = Java.Lang.Object.GetObject<IWebRequestProgressListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestProgress(@string, p1, p2);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00010E88 File Offset: 0x0000F088
		public unsafe void OnRequestProgress(string p0, long p1, long p2)
		{
			if (this.id_onRequestProgress_Ljava_lang_String_JJ == IntPtr.Zero)
			{
				this.id_onRequestProgress_Ljava_lang_String_JJ = JNIEnv.GetMethodID(this.class_ref, "onRequestProgress", "(Ljava/lang/String;JJ)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestProgress_Ljava_lang_String_JJ, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00010F22 File Offset: 0x0000F122
		private static Delegate GetOnRequestStart_Ljava_lang_String_JILjava_util_Map_Handler()
		{
			if (IWebRequestProgressListenerInvoker.cb_onRequestStart_Ljava_lang_String_JILjava_util_Map_ == null)
			{
				IWebRequestProgressListenerInvoker.cb_onRequestStart_Ljava_lang_String_JILjava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJIL_V(IWebRequestProgressListenerInvoker.n_OnRequestStart_Ljava_lang_String_JILjava_util_Map_));
			}
			return IWebRequestProgressListenerInvoker.cb_onRequestStart_Ljava_lang_String_JILjava_util_Map_;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00010F48 File Offset: 0x0000F148
		private static void n_OnRequestStart_Ljava_lang_String_JILjava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3)
		{
			IWebRequestProgressListener @object = Java.Lang.Object.GetObject<IWebRequestProgressListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, IList<string>> p3 = JavaDictionary<string, IList<string>>.FromJniHandle(native_p3, JniHandleOwnership.DoNotTransfer);
			@object.OnRequestStart(@string, p1, p2, p3);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00010F78 File Offset: 0x0000F178
		public unsafe void OnRequestStart(string p0, long p1, int p2, IDictionary<string, IList<string>> p3)
		{
			if (this.id_onRequestStart_Ljava_lang_String_JILjava_util_Map_ == IntPtr.Zero)
			{
				this.id_onRequestStart_Ljava_lang_String_JILjava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "onRequestStart", "(Ljava/lang/String;JILjava/util/Map;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(p3);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestStart_Ljava_lang_String_JILjava_util_Map_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0400016C RID: 364
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/IWebRequestProgressListener", typeof(IWebRequestProgressListenerInvoker));

		// Token: 0x0400016D RID: 365
		private IntPtr class_ref;

		// Token: 0x0400016E RID: 366
		private static Delegate cb_onRequestProgress_Ljava_lang_String_JJ;

		// Token: 0x0400016F RID: 367
		private IntPtr id_onRequestProgress_Ljava_lang_String_JJ;

		// Token: 0x04000170 RID: 368
		private static Delegate cb_onRequestStart_Ljava_lang_String_JILjava_util_Map_;

		// Token: 0x04000171 RID: 369
		private IntPtr id_onRequestStart_Ljava_lang_String_JILjava_util_Map_;
	}
}
