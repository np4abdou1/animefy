using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A9 RID: 681
	[Register("com/unity3d/scar/adapter/common/WebViewAdsError", DoNotGenerateAcw = true)]
	public class WebViewAdsError : Java.Lang.Object, IUnityAdsError, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x00064664 File Offset: 0x00062864
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x00064694 File Offset: 0x00062894
		[Register("_errorArguments")]
		protected IList<Java.Lang.Object> ErrorArguments
		{
			get
			{
				return Android.Runtime.JavaArray<Java.Lang.Object>.FromJniHandle(WebViewAdsError._members.InstanceFields.GetObjectValue("_errorArguments.[Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = Android.Runtime.JavaArray<Java.Lang.Object>.ToLocalJniHandle(value);
				try
				{
					WebViewAdsError._members.InstanceFields.SetValue("_errorArguments.[Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000646E0 File Offset: 0x000628E0
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewAdsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x00064704 File Offset: 0x00062904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewAdsError._members;
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x0006470C File Offset: 0x0006290C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewAdsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x00064730 File Offset: 0x00062930
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewAdsError._members.ManagedPeerType;
			}
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewAdsError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0006473C File Offset: 0x0006293C
		[Register(".ctor", "(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe WebViewAdsError(Java.Lang.Enum errorCategory, string description, params Java.Lang.Object[] errorArguments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(description);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(errorArguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorCategory == null) ? IntPtr.Zero : errorCategory.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(WebViewAdsError._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebViewAdsError._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Enum;Ljava/lang/String;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (errorArguments != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, errorArguments);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(errorCategory);
				GC.KeepAlive(errorArguments);
			}
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0006483C File Offset: 0x00062A3C
		private static Delegate GetGetCodeHandler()
		{
			if (WebViewAdsError.cb_getCode == null)
			{
				WebViewAdsError.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebViewAdsError.n_GetCode));
			}
			return WebViewAdsError.cb_getCode;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00064860 File Offset: 0x00062A60
		private static int n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebViewAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code;
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x0006486F File Offset: 0x00062A6F
		public virtual int Code
		{
			[Register("getCode", "()I", "GetGetCodeHandler")]
			get
			{
				return WebViewAdsError._members.InstanceMethods.InvokeVirtualInt32Method("getCode.()I", this, null);
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00064888 File Offset: 0x00062A88
		private static Delegate GetGetDescriptionHandler()
		{
			if (WebViewAdsError.cb_getDescription == null)
			{
				WebViewAdsError.cb_getDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewAdsError.n_GetDescription));
			}
			return WebViewAdsError.cb_getDescription;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000648AC File Offset: 0x00062AAC
		private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebViewAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Description);
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000648C0 File Offset: 0x00062AC0
		public virtual string Description
		{
			[Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get
			{
				return JNIEnv.GetString(WebViewAdsError._members.InstanceMethods.InvokeVirtualObjectMethod("getDescription.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000648F2 File Offset: 0x00062AF2
		private static Delegate GetGetDomainHandler()
		{
			if (WebViewAdsError.cb_getDomain == null)
			{
				WebViewAdsError.cb_getDomain = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewAdsError.n_GetDomain));
			}
			return WebViewAdsError.cb_getDomain;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00064916 File Offset: 0x00062B16
		private static IntPtr n_GetDomain(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebViewAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Domain);
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x0006492C File Offset: 0x00062B2C
		public virtual string Domain
		{
			[Register("getDomain", "()Ljava/lang/String;", "GetGetDomainHandler")]
			get
			{
				return JNIEnv.GetString(WebViewAdsError._members.InstanceMethods.InvokeVirtualObjectMethod("getDomain.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0006495E File Offset: 0x00062B5E
		private static Delegate GetGetErrorCategoryHandler()
		{
			if (WebViewAdsError.cb_getErrorCategory == null)
			{
				WebViewAdsError.cb_getErrorCategory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewAdsError.n_GetErrorCategory));
			}
			return WebViewAdsError.cb_getErrorCategory;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00064982 File Offset: 0x00062B82
		private static IntPtr n_GetErrorCategory(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebViewAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorCategory);
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x00064998 File Offset: 0x00062B98
		public virtual Java.Lang.Enum ErrorCategory
		{
			[Register("getErrorCategory", "()Ljava/lang/Enum;", "GetGetErrorCategoryHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Enum>(WebViewAdsError._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorCategory.()Ljava/lang/Enum;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000649CA File Offset: 0x00062BCA
		private static Delegate GetGetErrorArgumentsHandler()
		{
			if (WebViewAdsError.cb_getErrorArguments == null)
			{
				WebViewAdsError.cb_getErrorArguments = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebViewAdsError.n_GetErrorArguments));
			}
			return WebViewAdsError.cb_getErrorArguments;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000649EE File Offset: 0x00062BEE
		private static IntPtr n_GetErrorArguments(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<WebViewAdsError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetErrorArguments());
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00064A04 File Offset: 0x00062C04
		[Register("getErrorArguments", "()[Ljava/lang/Object;", "GetGetErrorArgumentsHandler")]
		public virtual Java.Lang.Object[] GetErrorArguments()
		{
			return (Java.Lang.Object[])JNIEnv.GetArray(WebViewAdsError._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorArguments.()[Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x040007B6 RID: 1974
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/WebViewAdsError", typeof(WebViewAdsError));

		// Token: 0x040007B7 RID: 1975
		private static Delegate cb_getCode;

		// Token: 0x040007B8 RID: 1976
		private static Delegate cb_getDescription;

		// Token: 0x040007B9 RID: 1977
		private static Delegate cb_getDomain;

		// Token: 0x040007BA RID: 1978
		private static Delegate cb_getErrorCategory;

		// Token: 0x040007BB RID: 1979
		private static Delegate cb_getErrorArguments;
	}
}
