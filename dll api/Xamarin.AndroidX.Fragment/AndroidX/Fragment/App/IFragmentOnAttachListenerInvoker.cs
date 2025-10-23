using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000049 RID: 73
	[Register("androidx/fragment/app/FragmentOnAttachListener", DoNotGenerateAcw = true)]
	internal class IFragmentOnAttachListenerInvoker : Java.Lang.Object, IFragmentOnAttachListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000D76C File Offset: 0x0000B96C
		private static IntPtr java_class_ref
		{
			get
			{
				return IFragmentOnAttachListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000D790 File Offset: 0x0000B990
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFragmentOnAttachListenerInvoker._members;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000D797 File Offset: 0x0000B997
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000D79F File Offset: 0x0000B99F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFragmentOnAttachListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000D7AB File Offset: 0x0000B9AB
		public static IFragmentOnAttachListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFragmentOnAttachListener>(handle, transfer);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFragmentOnAttachListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.fragment.app.FragmentOnAttachListener'.");
			}
			return handle;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000D7DF File Offset: 0x0000B9DF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000D810 File Offset: 0x0000BA10
		public IFragmentOnAttachListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFragmentOnAttachListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000D848 File Offset: 0x0000BA48
		private static Delegate GetOnAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_Handler()
		{
			if (IFragmentOnAttachListenerInvoker.cb_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == null)
			{
				IFragmentOnAttachListenerInvoker.cb_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IFragmentOnAttachListenerInvoker.n_OnAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_));
			}
			return IFragmentOnAttachListenerInvoker.cb_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000D86C File Offset: 0x0000BA6C
		private static void n_OnAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFragmentOnAttachListener @object = Java.Lang.Object.GetObject<IFragmentOnAttachListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			FragmentManager object2 = Java.Lang.Object.GetObject<FragmentManager>(native_p0, JniHandleOwnership.DoNotTransfer);
			Fragment object3 = Java.Lang.Object.GetObject<Fragment>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnAttachFragment(object2, object3);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000D898 File Offset: 0x0000BA98
		public unsafe void OnAttachFragment(FragmentManager p0, Fragment p1)
		{
			if (this.id_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ == IntPtr.Zero)
			{
				this.id_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_ = JNIEnv.GetMethodID(this.class_ref, "onAttachFragment", "(Landroidx/fragment/app/FragmentManager;Landroidx/fragment/app/Fragment;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_, ptr);
		}

		// Token: 0x04000117 RID: 279
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentOnAttachListener", typeof(IFragmentOnAttachListenerInvoker));

		// Token: 0x04000118 RID: 280
		private IntPtr class_ref;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;

		// Token: 0x0400011A RID: 282
		private IntPtr id_onAttachFragment_Landroidx_fragment_app_FragmentManager_Landroidx_fragment_app_Fragment_;
	}
}
