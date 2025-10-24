using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Security.Cert
{
	// Token: 0x0200036E RID: 878
	[Register("java/security/cert/X509Extension", DoNotGenerateAcw = true)]
	internal class IX509ExtensionInvoker : Java.Lang.Object, IX509Extension, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		private static IntPtr java_class_ref
		{
			get
			{
				return IX509ExtensionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x0006EBF0 File Offset: 0x0006CDF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IX509ExtensionInvoker._members;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x0006EBF7 File Offset: 0x0006CDF7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x0006EBFF File Offset: 0x0006CDFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IX509ExtensionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0006EC0B File Offset: 0x0006CE0B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IX509ExtensionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.security.cert.X509Extension'.");
			}
			return handle;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0006EC36 File Offset: 0x0006CE36
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0006EC68 File Offset: 0x0006CE68
		public IX509ExtensionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IX509ExtensionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		private static Delegate GetGetCriticalExtensionOIDsHandler()
		{
			if (IX509ExtensionInvoker.cb_getCriticalExtensionOIDs == null)
			{
				IX509ExtensionInvoker.cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IX509ExtensionInvoker.n_GetCriticalExtensionOIDs));
			}
			return IX509ExtensionInvoker.cb_getCriticalExtensionOIDs;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0006ECC4 File Offset: 0x0006CEC4
		private static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IX509Extension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CriticalExtensionOIDs);
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x0006ECD8 File Offset: 0x0006CED8
		public ICollection<string> CriticalExtensionOIDs
		{
			get
			{
				if (this.id_getCriticalExtensionOIDs == IntPtr.Zero)
				{
					this.id_getCriticalExtensionOIDs = JNIEnv.GetMethodID(this.class_ref, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
				}
				return JavaSet<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0006ED29 File Offset: 0x0006CF29
		private static Delegate GetHasUnsupportedCriticalExtensionHandler()
		{
			if (IX509ExtensionInvoker.cb_hasUnsupportedCriticalExtension == null)
			{
				IX509ExtensionInvoker.cb_hasUnsupportedCriticalExtension = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IX509ExtensionInvoker.n_HasUnsupportedCriticalExtension));
			}
			return IX509ExtensionInvoker.cb_hasUnsupportedCriticalExtension;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0006ED4D File Offset: 0x0006CF4D
		private static bool n_HasUnsupportedCriticalExtension(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IX509Extension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUnsupportedCriticalExtension;
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0006ED5C File Offset: 0x0006CF5C
		public bool HasUnsupportedCriticalExtension
		{
			get
			{
				if (this.id_hasUnsupportedCriticalExtension == IntPtr.Zero)
				{
					this.id_hasUnsupportedCriticalExtension = JNIEnv.GetMethodID(this.class_ref, "hasUnsupportedCriticalExtension", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasUnsupportedCriticalExtension);
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0006ED9C File Offset: 0x0006CF9C
		private static Delegate GetGetNonCriticalExtensionOIDsHandler()
		{
			if (IX509ExtensionInvoker.cb_getNonCriticalExtensionOIDs == null)
			{
				IX509ExtensionInvoker.cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IX509ExtensionInvoker.n_GetNonCriticalExtensionOIDs));
			}
			return IX509ExtensionInvoker.cb_getNonCriticalExtensionOIDs;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
		private static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
		{
			return JavaSet<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IX509Extension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NonCriticalExtensionOIDs);
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		public ICollection<string> NonCriticalExtensionOIDs
		{
			get
			{
				if (this.id_getNonCriticalExtensionOIDs == IntPtr.Zero)
				{
					this.id_getNonCriticalExtensionOIDs = JNIEnv.GetMethodID(this.class_ref, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
				}
				return JavaSet<string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getNonCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0006EE25 File Offset: 0x0006D025
		private static Delegate GetGetExtensionValue_Ljava_lang_String_Handler()
		{
			if (IX509ExtensionInvoker.cb_getExtensionValue_Ljava_lang_String_ == null)
			{
				IX509ExtensionInvoker.cb_getExtensionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IX509ExtensionInvoker.n_GetExtensionValue_Ljava_lang_String_));
			}
			return IX509ExtensionInvoker.cb_getExtensionValue_Ljava_lang_String_;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0006EE4C File Offset: 0x0006D04C
		private static IntPtr n_GetExtensionValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
		{
			IX509Extension @object = Java.Lang.Object.GetObject<IX509Extension>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_oid, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.GetExtensionValue(@string));
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0006EE74 File Offset: 0x0006D074
		public unsafe byte[] GetExtensionValue(string oid)
		{
			if (this.id_getExtensionValue_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getExtensionValue_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getExtensionValue", "(Ljava/lang/String;)[B");
			}
			IntPtr intPtr = JNIEnv.NewString(oid);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			byte[] result = (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getExtensionValue_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef, typeof(byte));
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/security/cert/X509Extension", typeof(IX509ExtensionInvoker));

		// Token: 0x04000FFA RID: 4090
		private IntPtr class_ref;

		// Token: 0x04000FFB RID: 4091
		private static Delegate cb_getCriticalExtensionOIDs;

		// Token: 0x04000FFC RID: 4092
		private IntPtr id_getCriticalExtensionOIDs;

		// Token: 0x04000FFD RID: 4093
		private static Delegate cb_hasUnsupportedCriticalExtension;

		// Token: 0x04000FFE RID: 4094
		private IntPtr id_hasUnsupportedCriticalExtension;

		// Token: 0x04000FFF RID: 4095
		private static Delegate cb_getNonCriticalExtensionOIDs;

		// Token: 0x04001000 RID: 4096
		private IntPtr id_getNonCriticalExtensionOIDs;

		// Token: 0x04001001 RID: 4097
		private static Delegate cb_getExtensionValue_Ljava_lang_String_;

		// Token: 0x04001002 RID: 4098
		private IntPtr id_getExtensionValue_Ljava_lang_String_;
	}
}
