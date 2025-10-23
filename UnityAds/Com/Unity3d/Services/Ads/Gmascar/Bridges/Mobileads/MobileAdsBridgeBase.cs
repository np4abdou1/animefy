using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x02000219 RID: 537
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase", DoNotGenerateAcw = true)]
	public abstract class MobileAdsBridgeBase : GenericBridge, IMobileAdsBridge, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0004841C File Offset: 0x0004661C
		internal new static IntPtr class_ref
		{
			get
			{
				return MobileAdsBridgeBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00048440 File Offset: 0x00046640
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAdsBridgeBase._members;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x00048448 File Offset: 0x00046648
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MobileAdsBridgeBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0004846C File Offset: 0x0004666C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAdsBridgeBase._members.ManagedPeerType;
			}
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected MobileAdsBridgeBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00048478 File Offset: 0x00046678
		[Register(".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe MobileAdsBridgeBase(IDictionary<string, Class[]> functionAndParameters) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaDictionary<string, Class[]>.ToLocalJniHandle(functionAndParameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MobileAdsBridgeBase._members.InstanceMethods.StartCreateInstance("(Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MobileAdsBridgeBase._members.InstanceMethods.FinishCreateInstance("(Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(functionAndParameters);
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00048524 File Offset: 0x00046724
		private static Delegate GetGetClassNameHandler()
		{
			if (MobileAdsBridgeBase.cb_getClassName == null)
			{
				MobileAdsBridgeBase.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeBase.n_GetClassName));
			}
			return MobileAdsBridgeBase.cb_getClassName;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00048548 File Offset: 0x00046748
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0004855C File Offset: 0x0004675C
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(MobileAdsBridgeBase._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0004858E File Offset: 0x0004678E
		private static Delegate GetGetInitializationStatusHandler()
		{
			if (MobileAdsBridgeBase.cb_getInitializationStatus == null)
			{
				MobileAdsBridgeBase.cb_getInitializationStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeBase.n_GetInitializationStatus));
			}
			return MobileAdsBridgeBase.cb_getInitializationStatus;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000485B2 File Offset: 0x000467B2
		private static IntPtr n_GetInitializationStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationStatus);
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000485C8 File Offset: 0x000467C8
		public virtual Java.Lang.Object InitializationStatus
		{
			[Register("getInitializationStatus", "()Ljava/lang/Object;", "GetGetInitializationStatusHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(MobileAdsBridgeBase._members.InstanceMethods.InvokeVirtualObjectMethod("getInitializationStatus.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000485FA File Offset: 0x000467FA
		private static Delegate GetGetVersionCodeIndexHandler()
		{
			if (MobileAdsBridgeBase.cb_getVersionCodeIndex == null)
			{
				MobileAdsBridgeBase.cb_getVersionCodeIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MobileAdsBridgeBase.n_GetVersionCodeIndex));
			}
			return MobileAdsBridgeBase.cb_getVersionCodeIndex;
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0004861E File Offset: 0x0004681E
		private static int n_GetVersionCodeIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionCodeIndex;
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001934 RID: 6452
		public abstract int VersionCodeIndex { [Register("getVersionCodeIndex", "()I", "GetGetVersionCodeIndexHandler")] get; }

		// Token: 0x06001935 RID: 6453 RVA: 0x0004862D File Offset: 0x0004682D
		private static Delegate GetGetVersionMethodNameHandler()
		{
			if (MobileAdsBridgeBase.cb_getVersionMethodName == null)
			{
				MobileAdsBridgeBase.cb_getVersionMethodName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeBase.n_GetVersionMethodName));
			}
			return MobileAdsBridgeBase.cb_getVersionMethodName;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00048651 File Offset: 0x00046851
		private static IntPtr n_GetVersionMethodName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionMethodName);
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001937 RID: 6455
		public abstract string VersionMethodName { [Register("getVersionMethodName", "()Ljava/lang/String;", "GetGetVersionMethodNameHandler")] get; }

		// Token: 0x06001938 RID: 6456 RVA: 0x00048665 File Offset: 0x00046865
		private static Delegate GetGetVersionStringHandler()
		{
			if (MobileAdsBridgeBase.cb_getVersionString == null)
			{
				MobileAdsBridgeBase.cb_getVersionString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MobileAdsBridgeBase.n_GetVersionString));
			}
			return MobileAdsBridgeBase.cb_getVersionString;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00048689 File Offset: 0x00046889
		private static IntPtr n_GetVersionString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VersionString);
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000486A0 File Offset: 0x000468A0
		public virtual string VersionString
		{
			[Register("getVersionString", "()Ljava/lang/String;", "GetGetVersionStringHandler")]
			get
			{
				return JNIEnv.GetString(MobileAdsBridgeBase._members.InstanceMethods.InvokeVirtualObjectMethod("getVersionString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000486D2 File Offset: 0x000468D2
		private static Delegate GetGetAdapterVersion_IHandler()
		{
			if (MobileAdsBridgeBase.cb_getAdapterVersion_I == null)
			{
				MobileAdsBridgeBase.cb_getAdapterVersion_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MobileAdsBridgeBase.n_GetAdapterVersion_I));
			}
			return MobileAdsBridgeBase.cb_getAdapterVersion_I;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000486F6 File Offset: 0x000468F6
		private static IntPtr n_GetAdapterVersion_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAdapterVersion(p0));
		}

		// Token: 0x0600193D RID: 6461
		[Register("getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "GetGetAdapterVersion_IHandler")]
		public abstract ScarAdapterVersion GetAdapterVersion(int p0);

		// Token: 0x0600193E RID: 6462 RVA: 0x0004870B File Offset: 0x0004690B
		private static Delegate GetInitialize_Landroid_content_Context_Ljava_lang_Object_Handler()
		{
			if (MobileAdsBridgeBase.cb_initialize_Landroid_content_Context_Ljava_lang_Object_ == null)
			{
				MobileAdsBridgeBase.cb_initialize_Landroid_content_Context_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MobileAdsBridgeBase.n_Initialize_Landroid_content_Context_Ljava_lang_Object_));
			}
			return MobileAdsBridgeBase.cb_initialize_Landroid_content_Context_Ljava_lang_Object_;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00048730 File Offset: 0x00046930
		private static void n_Initialize_Landroid_content_Context_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_initializeListener)
		{
			MobileAdsBridgeBase @object = Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initializeListener, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2, object3);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0004875C File Offset: 0x0004695C
		[Register("initialize", "(Landroid/content/Context;Ljava/lang/Object;)V", "GetInitialize_Landroid_content_Context_Ljava_lang_Object_Handler")]
		public unsafe virtual void Initialize(Context context, Java.Lang.Object initializeListener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((initializeListener == null) ? IntPtr.Zero : initializeListener.Handle);
				MobileAdsBridgeBase._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.(Landroid/content/Context;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(initializeListener);
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000487E8 File Offset: 0x000469E8
		private static Delegate GetShouldInitializeHandler()
		{
			if (MobileAdsBridgeBase.cb_shouldInitialize == null)
			{
				MobileAdsBridgeBase.cb_shouldInitialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MobileAdsBridgeBase.n_ShouldInitialize));
			}
			return MobileAdsBridgeBase.cb_shouldInitialize;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0004880C File Offset: 0x00046A0C
		private static bool n_ShouldInitialize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MobileAdsBridgeBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldInitialize();
		}

		// Token: 0x06001943 RID: 6467
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler")]
		public abstract bool ShouldInitialize();

		// Token: 0x04000628 RID: 1576
		[Register("initializationStatusMethodName")]
		public const string InitializationStatusMethodName = "getInitializationStatus";

		// Token: 0x04000629 RID: 1577
		[Register("initializeMethodName")]
		public const string InitializeMethodName = "initialize";

		// Token: 0x0400062A RID: 1578
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase", typeof(MobileAdsBridgeBase));

		// Token: 0x0400062B RID: 1579
		private static Delegate cb_getClassName;

		// Token: 0x0400062C RID: 1580
		private static Delegate cb_getInitializationStatus;

		// Token: 0x0400062D RID: 1581
		private static Delegate cb_getVersionCodeIndex;

		// Token: 0x0400062E RID: 1582
		private static Delegate cb_getVersionMethodName;

		// Token: 0x0400062F RID: 1583
		private static Delegate cb_getVersionString;

		// Token: 0x04000630 RID: 1584
		private static Delegate cb_getAdapterVersion_I;

		// Token: 0x04000631 RID: 1585
		private static Delegate cb_initialize_Landroid_content_Context_Ljava_lang_Object_;

		// Token: 0x04000632 RID: 1586
		private static Delegate cb_shouldInitialize;
	}
}
