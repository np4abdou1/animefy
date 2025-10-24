using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200026B RID: 619
	[Register("android/app/Service", DoNotGenerateAcw = true)]
	public abstract class Service : ContextWrapper, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable, IComponentCallbacks2
	{
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x0003D99B File Offset: 0x0003BB9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Service._members;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Service._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Service._members.ManagedPeerType;
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00010120 File Offset: 0x0000E320
		protected Service(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		private static Delegate GetOnBind_Landroid_content_Intent_Handler()
		{
			if (Service.cb_onBind_Landroid_content_Intent_ == null)
			{
				Service.cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Service.n_OnBind_Landroid_content_Intent_));
			}
			return Service.cb_onBind_Landroid_content_Intent_;
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0003D9F8 File Offset: 0x0003BBF8
		private static IntPtr n_OnBind_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			Service @object = Java.Lang.Object.GetObject<Service>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnBind(object2));
		}

		// Token: 0x060017BF RID: 6079
		public abstract IBinder OnBind(Intent intent);

		// Token: 0x060017C0 RID: 6080 RVA: 0x0003DA20 File Offset: 0x0003BC20
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (Service.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				Service.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Service.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return Service.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0003DA44 File Offset: 0x0003BC44
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			Service @object = Java.Lang.Object.GetObject<Service>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0003DA68 File Offset: 0x0003BC68
		public unsafe virtual void OnConfigurationChanged(Configuration newConfig)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
				Service._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(newConfig);
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0003DACC File Offset: 0x0003BCCC
		private static Delegate GetOnLowMemoryHandler()
		{
			if (Service.cb_onLowMemory == null)
			{
				Service.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Service.n_OnLowMemory));
			}
			return Service.cb_onLowMemory;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0003DAF0 File Offset: 0x0003BCF0
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Service>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0003DAFF File Offset: 0x0003BCFF
		public virtual void OnLowMemory()
		{
			Service._members.InstanceMethods.InvokeVirtualVoidMethod("onLowMemory.()V", this, null);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0003DB18 File Offset: 0x0003BD18
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (Service.cb_onTrimMemory_I == null)
			{
				Service.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Service.n_OnTrimMemory_I));
			}
			return Service.cb_onTrimMemory_I;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0003DB3C File Offset: 0x0003BD3C
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<Service>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0003DB5C File Offset: 0x0003BD5C
		public unsafe virtual void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)level);
			Service._members.InstanceMethods.InvokeVirtualVoidMethod("onTrimMemory.(I)V", this, ptr);
		}

		// Token: 0x04000A14 RID: 2580
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Service", typeof(Service));

		// Token: 0x04000A15 RID: 2581
		private static Delegate cb_onBind_Landroid_content_Intent_;

		// Token: 0x04000A16 RID: 2582
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A17 RID: 2583
		private static Delegate cb_onLowMemory;

		// Token: 0x04000A18 RID: 2584
		private static Delegate cb_onTrimMemory_I;
	}
}
