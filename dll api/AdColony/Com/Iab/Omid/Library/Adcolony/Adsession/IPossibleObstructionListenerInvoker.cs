using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Adsession
{
	// Token: 0x02000030 RID: 48
	[Register("com/iab/omid/library/adcolony/adsession/PossibleObstructionListener", DoNotGenerateAcw = true)]
	internal class IPossibleObstructionListenerInvoker : Java.Lang.Object, IPossibleObstructionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000050E0 File Offset: 0x000032E0
		private static IntPtr java_class_ref
		{
			get
			{
				return IPossibleObstructionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00005104 File Offset: 0x00003304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPossibleObstructionListenerInvoker._members;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000510B File Offset: 0x0000330B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00005113 File Offset: 0x00003313
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPossibleObstructionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000511F File Offset: 0x0000331F
		public static IPossibleObstructionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPossibleObstructionListener>(handle, transfer);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005128 File Offset: 0x00003328
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPossibleObstructionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.adcolony.adsession.PossibleObstructionListener'.");
			}
			return handle;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005153 File Offset: 0x00003353
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005184 File Offset: 0x00003384
		public IPossibleObstructionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPossibleObstructionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000051BC File Offset: 0x000033BC
		private static Delegate GetOnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_Handler()
		{
			if (IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ == null)
			{
				IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IPossibleObstructionListenerInvoker.n_OnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_));
			}
			return IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000051E0 File Offset: 0x000033E0
		private static void n_OnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IPossibleObstructionListener @object = Java.Lang.Object.GetObject<IPossibleObstructionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<View> p = JavaList<View>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnPossibleObstructionsDetected(@string, p);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000520C File Offset: 0x0000340C
		public unsafe void OnPossibleObstructionsDetected(string p0, IList<View> p1)
		{
			if (this.id_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
			{
				this.id_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID(this.class_ref, "onPossibleObstructionsDetected", "(Ljava/lang/String;Ljava/util/List;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JavaList<View>.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000047 RID: 71
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/adsession/PossibleObstructionListener", typeof(IPossibleObstructionListenerInvoker));

		// Token: 0x04000048 RID: 72
		private IntPtr class_ref;

		// Token: 0x04000049 RID: 73
		private static Delegate cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;

		// Token: 0x0400004A RID: 74
		private IntPtr id_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;
	}
}
