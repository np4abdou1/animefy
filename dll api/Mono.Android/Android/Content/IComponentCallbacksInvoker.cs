using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000288 RID: 648
	[Register("android/content/ComponentCallbacks", DoNotGenerateAcw = true)]
	internal class IComponentCallbacksInvoker : Java.Lang.Object, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x00040430 File Offset: 0x0003E630
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentCallbacksInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00040454 File Offset: 0x0003E654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentCallbacksInvoker._members;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x0004045B File Offset: 0x0003E65B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00040463 File Offset: 0x0003E663
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentCallbacksInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0004046F File Offset: 0x0003E66F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentCallbacksInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.ComponentCallbacks'.");
			}
			return handle;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0004049A File Offset: 0x0003E69A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000404CC File Offset: 0x0003E6CC
		public IComponentCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentCallbacksInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00040504 File Offset: 0x0003E704
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (IComponentCallbacksInvoker.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				IComponentCallbacksInvoker.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IComponentCallbacksInvoker.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return IComponentCallbacksInvoker.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00040528 File Offset: 0x0003E728
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_newConfig)
		{
			IComponentCallbacks @object = Java.Lang.Object.GetObject<IComponentCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_newConfig, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0004054C File Offset: 0x0003E74C
		public unsafe void OnConfigurationChanged(Configuration newConfig)
		{
			if (this.id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
			{
				this.id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID(this.class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((newConfig == null) ? IntPtr.Zero : newConfig.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConfigurationChanged_Landroid_content_res_Configuration_, ptr);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000405BF File Offset: 0x0003E7BF
		private static Delegate GetOnLowMemoryHandler()
		{
			if (IComponentCallbacksInvoker.cb_onLowMemory == null)
			{
				IComponentCallbacksInvoker.cb_onLowMemory = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IComponentCallbacksInvoker.n_OnLowMemory));
			}
			return IComponentCallbacksInvoker.cb_onLowMemory;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x000405E3 File Offset: 0x0003E7E3
		private static void n_OnLowMemory(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IComponentCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLowMemory();
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000405F2 File Offset: 0x0003E7F2
		public void OnLowMemory()
		{
			if (this.id_onLowMemory == IntPtr.Zero)
			{
				this.id_onLowMemory = JNIEnv.GetMethodID(this.class_ref, "onLowMemory", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLowMemory);
		}

		// Token: 0x04000A73 RID: 2675
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ComponentCallbacks", typeof(IComponentCallbacksInvoker));

		// Token: 0x04000A74 RID: 2676
		private IntPtr class_ref;

		// Token: 0x04000A75 RID: 2677
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A76 RID: 2678
		private IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A77 RID: 2679
		private static Delegate cb_onLowMemory;

		// Token: 0x04000A78 RID: 2680
		private IntPtr id_onLowMemory;
	}
}
