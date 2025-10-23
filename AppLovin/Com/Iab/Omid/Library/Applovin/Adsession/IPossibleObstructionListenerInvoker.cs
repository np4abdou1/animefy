using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Adsession
{
	// Token: 0x02000045 RID: 69
	[Register("com/iab/omid/library/applovin/adsession/PossibleObstructionListener", DoNotGenerateAcw = true)]
	internal class IPossibleObstructionListenerInvoker : Java.Lang.Object, IPossibleObstructionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000051A8 File Offset: 0x000033A8
		private static IntPtr java_class_ref
		{
			get
			{
				return IPossibleObstructionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000051CC File Offset: 0x000033CC
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
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000051D3 File Offset: 0x000033D3
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
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000051DB File Offset: 0x000033DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPossibleObstructionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000051E7 File Offset: 0x000033E7
		public static IPossibleObstructionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IPossibleObstructionListener>(handle, transfer);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000051F0 File Offset: 0x000033F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPossibleObstructionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.applovin.adsession.PossibleObstructionListener'.");
			}
			return handle;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000521B File Offset: 0x0000341B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000524C File Offset: 0x0000344C
		public IPossibleObstructionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPossibleObstructionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00005284 File Offset: 0x00003484
		private static Delegate GetOnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_Handler()
		{
			if (IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ == null)
			{
				IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IPossibleObstructionListenerInvoker.n_OnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_));
			}
			return IPossibleObstructionListenerInvoker.cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000052A8 File Offset: 0x000034A8
		private static void n_OnPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IPossibleObstructionListener @object = Java.Lang.Object.GetObject<IPossibleObstructionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IList<View> p = JavaList<View>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnPossibleObstructionsDetected(@string, p);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000052D4 File Offset: 0x000034D4
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

		// Token: 0x0400004A RID: 74
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/adsession/PossibleObstructionListener", typeof(IPossibleObstructionListenerInvoker));

		// Token: 0x0400004B RID: 75
		private IntPtr class_ref;

		// Token: 0x0400004C RID: 76
		private static Delegate cb_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;

		// Token: 0x0400004D RID: 77
		private IntPtr id_onPossibleObstructionsDetected_Ljava_lang_String_Ljava_util_List_;
	}
}
