using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x02000217 RID: 535
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge", DoNotGenerateAcw = true)]
	internal class IMobileAdsBridgeInvoker : Java.Lang.Object, IMobileAdsBridge, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00047C9C File Offset: 0x00045E9C
		private static IntPtr java_class_ref
		{
			get
			{
				return IMobileAdsBridgeInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00047CC0 File Offset: 0x00045EC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMobileAdsBridgeInvoker._members;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00047CC7 File Offset: 0x00045EC7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00047CCF File Offset: 0x00045ECF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMobileAdsBridgeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00047CDB File Offset: 0x00045EDB
		public static IMobileAdsBridge GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMobileAdsBridge>(handle, transfer);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00047CE4 File Offset: 0x00045EE4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMobileAdsBridgeInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.gmascar.bridges.mobileads.IMobileAdsBridge'.");
			}
			return handle;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00047D0F File Offset: 0x00045F0F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00047D40 File Offset: 0x00045F40
		public IMobileAdsBridgeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMobileAdsBridgeInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00047D78 File Offset: 0x00045F78
		private static Delegate GetGetInitializationStatusHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_getInitializationStatus == null)
			{
				IMobileAdsBridgeInvoker.cb_getInitializationStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMobileAdsBridgeInvoker.n_GetInitializationStatus));
			}
			return IMobileAdsBridgeInvoker.cb_getInitializationStatus;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00047D9C File Offset: 0x00045F9C
		private static IntPtr n_GetInitializationStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationStatus);
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00047DB0 File Offset: 0x00045FB0
		public Java.Lang.Object InitializationStatus
		{
			get
			{
				if (this.id_getInitializationStatus == IntPtr.Zero)
				{
					this.id_getInitializationStatus = JNIEnv.GetMethodID(this.class_ref, "getInitializationStatus", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getInitializationStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00047E01 File Offset: 0x00046001
		private static Delegate GetGetVersionCodeIndexHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_getVersionCodeIndex == null)
			{
				IMobileAdsBridgeInvoker.cb_getVersionCodeIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMobileAdsBridgeInvoker.n_GetVersionCodeIndex));
			}
			return IMobileAdsBridgeInvoker.cb_getVersionCodeIndex;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00047E25 File Offset: 0x00046025
		private static int n_GetVersionCodeIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionCodeIndex;
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00047E34 File Offset: 0x00046034
		public int VersionCodeIndex
		{
			get
			{
				if (this.id_getVersionCodeIndex == IntPtr.Zero)
				{
					this.id_getVersionCodeIndex = JNIEnv.GetMethodID(this.class_ref, "getVersionCodeIndex", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getVersionCodeIndex);
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00047E74 File Offset: 0x00046074
		private static Delegate GetGetVersionMethodNameHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_getVersionMethodName == null)
			{
				IMobileAdsBridgeInvoker.cb_getVersionMethodName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMobileAdsBridgeInvoker.n_GetVersionMethodName));
			}
			return IMobileAdsBridgeInvoker.cb_getVersionMethodName;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00047E98 File Offset: 0x00046098
		private static IntPtr n_GetVersionMethodName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionMethodName);
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x00047EAC File Offset: 0x000460AC
		public string VersionMethodName
		{
			get
			{
				if (this.id_getVersionMethodName == IntPtr.Zero)
				{
					this.id_getVersionMethodName = JNIEnv.GetMethodID(this.class_ref, "getVersionMethodName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getVersionMethodName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00047EFD File Offset: 0x000460FD
		private static Delegate GetGetVersionStringHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_getVersionString == null)
			{
				IMobileAdsBridgeInvoker.cb_getVersionString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMobileAdsBridgeInvoker.n_GetVersionString));
			}
			return IMobileAdsBridgeInvoker.cb_getVersionString;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00047F21 File Offset: 0x00046121
		private static IntPtr n_GetVersionString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionString);
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00047F38 File Offset: 0x00046138
		public string VersionString
		{
			get
			{
				if (this.id_getVersionString == IntPtr.Zero)
				{
					this.id_getVersionString = JNIEnv.GetMethodID(this.class_ref, "getVersionString", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getVersionString), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00047F89 File Offset: 0x00046189
		private static Delegate GetGetAdapterVersion_IHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_getAdapterVersion_I == null)
			{
				IMobileAdsBridgeInvoker.cb_getAdapterVersion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMobileAdsBridgeInvoker.n_GetAdapterVersion_I));
			}
			return IMobileAdsBridgeInvoker.cb_getAdapterVersion_I;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00047FAD File Offset: 0x000461AD
		private static IntPtr n_GetAdapterVersion_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapterVersion(p0));
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00047FC4 File Offset: 0x000461C4
		public unsafe ScarAdapterVersion GetAdapterVersion(int p0)
		{
			if (this.id_getAdapterVersion_I == IntPtr.Zero)
			{
				this.id_getAdapterVersion_I = JNIEnv.GetMethodID(this.class_ref, "getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			return Java.Lang.Object.GetObject<ScarAdapterVersion>(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdapterVersion_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0004802E File Offset: 0x0004622E
		private static Delegate GetInitialize_Landroid_content_Context_Ljava_lang_Object_Handler()
		{
			if (IMobileAdsBridgeInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_Object_ == null)
			{
				IMobileAdsBridgeInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMobileAdsBridgeInvoker.n_Initialize_Landroid_content_Context_Ljava_lang_Object_));
			}
			return IMobileAdsBridgeInvoker.cb_initialize_Landroid_content_Context_Ljava_lang_Object_;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00048054 File Offset: 0x00046254
		private static void n_Initialize_Landroid_content_Context_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMobileAdsBridge @object = Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00048080 File Offset: 0x00046280
		public unsafe void Initialize(Context p0, Java.Lang.Object p1)
		{
			if (this.id_initialize_Landroid_content_Context_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_initialize_Landroid_content_Context_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "initialize", "(Landroid/content/Context;Ljava/lang/Object;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize_Landroid_content_Context_Ljava_lang_Object_, ptr);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00048115 File Offset: 0x00046315
		private static Delegate GetShouldInitializeHandler()
		{
			if (IMobileAdsBridgeInvoker.cb_shouldInitialize == null)
			{
				IMobileAdsBridgeInvoker.cb_shouldInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMobileAdsBridgeInvoker.n_ShouldInitialize));
			}
			return IMobileAdsBridgeInvoker.cb_shouldInitialize;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00048139 File Offset: 0x00046339
		private static bool n_ShouldInitialize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMobileAdsBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldInitialize();
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00048148 File Offset: 0x00046348
		public bool ShouldInitialize()
		{
			if (this.id_shouldInitialize == IntPtr.Zero)
			{
				this.id_shouldInitialize = JNIEnv.GetMethodID(this.class_ref, "shouldInitialize", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_shouldInitialize);
		}

		// Token: 0x04000612 RID: 1554
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/IMobileAdsBridge", typeof(IMobileAdsBridgeInvoker));

		// Token: 0x04000613 RID: 1555
		private IntPtr class_ref;

		// Token: 0x04000614 RID: 1556
		private static Delegate cb_getInitializationStatus;

		// Token: 0x04000615 RID: 1557
		private IntPtr id_getInitializationStatus;

		// Token: 0x04000616 RID: 1558
		private static Delegate cb_getVersionCodeIndex;

		// Token: 0x04000617 RID: 1559
		private IntPtr id_getVersionCodeIndex;

		// Token: 0x04000618 RID: 1560
		private static Delegate cb_getVersionMethodName;

		// Token: 0x04000619 RID: 1561
		private IntPtr id_getVersionMethodName;

		// Token: 0x0400061A RID: 1562
		private static Delegate cb_getVersionString;

		// Token: 0x0400061B RID: 1563
		private IntPtr id_getVersionString;

		// Token: 0x0400061C RID: 1564
		private static Delegate cb_getAdapterVersion_I;

		// Token: 0x0400061D RID: 1565
		private IntPtr id_getAdapterVersion_I;

		// Token: 0x0400061E RID: 1566
		private static Delegate cb_initialize_Landroid_content_Context_Ljava_lang_Object_;

		// Token: 0x0400061F RID: 1567
		private IntPtr id_initialize_Landroid_content_Context_Ljava_lang_Object_;

		// Token: 0x04000620 RID: 1568
		private static Delegate cb_shouldInitialize;

		// Token: 0x04000621 RID: 1569
		private IntPtr id_shouldInitialize;
	}
}
