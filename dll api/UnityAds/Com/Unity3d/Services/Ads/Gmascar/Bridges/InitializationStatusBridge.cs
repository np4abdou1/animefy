using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Reflection;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges
{
	// Token: 0x02000212 RID: 530
	[Register("com/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge", DoNotGenerateAcw = true)]
	public class InitializationStatusBridge : GenericBridge
	{
		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x00047728 File Offset: 0x00045928
		internal new static IntPtr class_ref
		{
			get
			{
				return InitializationStatusBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0004774C File Offset: 0x0004594C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializationStatusBridge._members;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00047754 File Offset: 0x00045954
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializationStatusBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00047778 File Offset: 0x00045978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializationStatusBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x000058C0 File Offset: 0x00003AC0
		protected InitializationStatusBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00047784 File Offset: 0x00045984
		[Register(".ctor", "()V", "")]
		public InitializationStatusBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InitializationStatusBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InitializationStatusBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x000477F2 File Offset: 0x000459F2
		private static Delegate GetGetClassNameHandler()
		{
			if (InitializationStatusBridge.cb_getClassName == null)
			{
				InitializationStatusBridge.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(InitializationStatusBridge.n_GetClassName));
			}
			return InitializationStatusBridge.cb_getClassName;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00047816 File Offset: 0x00045A16
		private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<InitializationStatusBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0004782C File Offset: 0x00045A2C
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(InitializationStatusBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0004785E File Offset: 0x00045A5E
		private static Delegate GetGetAdapterStatusMap_Ljava_lang_Object_Handler()
		{
			if (InitializationStatusBridge.cb_getAdapterStatusMap_Ljava_lang_Object_ == null)
			{
				InitializationStatusBridge.cb_getAdapterStatusMap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(InitializationStatusBridge.n_GetAdapterStatusMap_Ljava_lang_Object_));
			}
			return InitializationStatusBridge.cb_getAdapterStatusMap_Ljava_lang_Object_;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00047884 File Offset: 0x00045A84
		private static IntPtr n_GetAdapterStatusMap_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_initStatusObj)
		{
			InitializationStatusBridge @object = Java.Lang.Object.GetObject<InitializationStatusBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_initStatusObj, JniHandleOwnership.DoNotTransfer);
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(@object.GetAdapterStatusMap(object2));
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000478AC File Offset: 0x00045AAC
		[Register("getAdapterStatusMap", "(Ljava/lang/Object;)Ljava/util/Map;", "GetGetAdapterStatusMap_Ljava_lang_Object_Handler")]
		public unsafe virtual IDictionary<string, Java.Lang.Object> GetAdapterStatusMap(Java.Lang.Object initStatusObj)
		{
			IDictionary<string, Java.Lang.Object> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((initStatusObj == null) ? IntPtr.Zero : initStatusObj.Handle);
				result = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(InitializationStatusBridge._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapterStatusMap.(Ljava/lang/Object;)Ljava/util/Map;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(initStatusObj);
			}
			return result;
		}

		// Token: 0x04000607 RID: 1543
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/InitializationStatusBridge", typeof(InitializationStatusBridge));

		// Token: 0x04000608 RID: 1544
		private static Delegate cb_getClassName;

		// Token: 0x04000609 RID: 1545
		private static Delegate cb_getAdapterStatusMap_Ljava_lang_Object_;
	}
}
