using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001EB RID: 491
	[Register("com/unity3d/services/ads/operation/IAdOperation", DoNotGenerateAcw = true)]
	internal class IAdOperationInvoker : Java.Lang.Object, IAdOperation, IWebViewSharedObject, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0003FF2C File Offset: 0x0003E12C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdOperationInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0003FF50 File Offset: 0x0003E150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdOperationInvoker._members;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x0003FF57 File Offset: 0x0003E157
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0003FF5F File Offset: 0x0003E15F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdOperationInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0003FF6B File Offset: 0x0003E16B
		public static IAdOperation GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdOperation>(handle, transfer);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0003FF74 File Offset: 0x0003E174
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdOperationInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.operation.IAdOperation'.");
			}
			return handle;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0003FF9F File Offset: 0x0003E19F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0003FFD0 File Offset: 0x0003E1D0
		public IAdOperationInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdOperationInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00040008 File Offset: 0x0003E208
		private static Delegate GetInvoke_IarrayLjava_lang_Object_Handler()
		{
			if (IAdOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ == null)
			{
				IAdOperationInvoker.cb_invoke_IarrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IAdOperationInvoker.n_Invoke_IarrayLjava_lang_Object_));
			}
			return IAdOperationInvoker.cb_invoke_IarrayLjava_lang_Object_;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0004002C File Offset: 0x0003E22C
		private static void n_Invoke_IarrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			IAdOperation @object = Java.Lang.Object.GetObject<IAdOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native_p1, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			@object.Invoke(p0, array);
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native_p1);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0004006C File Offset: 0x0003E26C
		public unsafe void Invoke(int p0, params Java.Lang.Object[] p1)
		{
			if (this.id_invoke_IarrayLjava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(I[Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invoke_IarrayLjava_lang_Object_, ptr);
			if (p1 != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(intPtr, p1);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000400FA File Offset: 0x0003E2FA
		private static Delegate GetGetIdHandler()
		{
			if (IAdOperationInvoker.cb_getId == null)
			{
				IAdOperationInvoker.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdOperationInvoker.n_GetId));
			}
			return IAdOperationInvoker.cb_getId;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0004011E File Offset: 0x0003E31E
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAdOperation>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00040134 File Offset: 0x0003E334
		public string Id
		{
			get
			{
				if (this.id_getId == IntPtr.Zero)
				{
					this.id_getId = JNIEnv.GetMethodID(this.class_ref, "getId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400054B RID: 1355
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/IAdOperation", typeof(IAdOperationInvoker));

		// Token: 0x0400054C RID: 1356
		private IntPtr class_ref;

		// Token: 0x0400054D RID: 1357
		private static Delegate cb_invoke_IarrayLjava_lang_Object_;

		// Token: 0x0400054E RID: 1358
		private IntPtr id_invoke_IarrayLjava_lang_Object_;

		// Token: 0x0400054F RID: 1359
		private static Delegate cb_getId;

		// Token: 0x04000550 RID: 1360
		private IntPtr id_getId;
	}
}
