using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200028A RID: 650
	[Register("android/content/ComponentCallbacks2", DoNotGenerateAcw = true)]
	internal class IComponentCallbacks2Invoker : Java.Lang.Object, IComponentCallbacks2, IComponentCallbacks, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00040650 File Offset: 0x0003E850
		private static IntPtr java_class_ref
		{
			get
			{
				return IComponentCallbacks2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00040674 File Offset: 0x0003E874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComponentCallbacks2Invoker._members;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0004067B File Offset: 0x0003E87B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00040683 File Offset: 0x0003E883
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComponentCallbacks2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0004068F File Offset: 0x0003E88F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComponentCallbacks2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.content.ComponentCallbacks2'.");
			}
			return handle;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x000406BA File Offset: 0x0003E8BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000406EC File Offset: 0x0003E8EC
		public IComponentCallbacks2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IComponentCallbacks2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00040724 File Offset: 0x0003E924
		private static Delegate GetOnTrimMemory_IHandler()
		{
			if (IComponentCallbacks2Invoker.cb_onTrimMemory_I == null)
			{
				IComponentCallbacks2Invoker.cb_onTrimMemory_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IComponentCallbacks2Invoker.n_OnTrimMemory_I));
			}
			return IComponentCallbacks2Invoker.cb_onTrimMemory_I;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00040748 File Offset: 0x0003E948
		private static void n_OnTrimMemory_I(IntPtr jnienv, IntPtr native__this, int native_level)
		{
			Java.Lang.Object.GetObject<IComponentCallbacks2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTrimMemory((TrimMemory)native_level);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00040768 File Offset: 0x0003E968
		public unsafe void OnTrimMemory([GeneratedEnum] TrimMemory level)
		{
			if (this.id_onTrimMemory_I == IntPtr.Zero)
			{
				this.id_onTrimMemory_I = JNIEnv.GetMethodID(this.class_ref, "onTrimMemory", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)level);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTrimMemory_I, ptr);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x000407CC File Offset: 0x0003E9CC
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

		// Token: 0x060018F2 RID: 6386 RVA: 0x0004083F File Offset: 0x0003EA3F
		public void OnLowMemory()
		{
			if (this.id_onLowMemory == IntPtr.Zero)
			{
				this.id_onLowMemory = JNIEnv.GetMethodID(this.class_ref, "onLowMemory", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLowMemory);
		}

		// Token: 0x04000A79 RID: 2681
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ComponentCallbacks2", typeof(IComponentCallbacks2Invoker));

		// Token: 0x04000A7A RID: 2682
		private IntPtr class_ref;

		// Token: 0x04000A7B RID: 2683
		private static Delegate cb_onTrimMemory_I;

		// Token: 0x04000A7C RID: 2684
		private IntPtr id_onTrimMemory_I;

		// Token: 0x04000A7D RID: 2685
		private IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x04000A7E RID: 2686
		private IntPtr id_onLowMemory;
	}
}
