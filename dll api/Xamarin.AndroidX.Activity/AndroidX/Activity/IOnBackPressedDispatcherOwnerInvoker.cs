using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Lifecycle;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity
{
	// Token: 0x02000017 RID: 23
	[Register("androidx/activity/OnBackPressedDispatcherOwner", DoNotGenerateAcw = true)]
	internal class IOnBackPressedDispatcherOwnerInvoker : Java.Lang.Object, IOnBackPressedDispatcherOwner, ILifecycleOwner, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003844 File Offset: 0x00001A44
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnBackPressedDispatcherOwnerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003868 File Offset: 0x00001A68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnBackPressedDispatcherOwnerInvoker._members;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000386F File Offset: 0x00001A6F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003877 File Offset: 0x00001A77
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnBackPressedDispatcherOwnerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003883 File Offset: 0x00001A83
		public static IOnBackPressedDispatcherOwner GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnBackPressedDispatcherOwner>(handle, transfer);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000388C File Offset: 0x00001A8C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnBackPressedDispatcherOwnerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.OnBackPressedDispatcherOwner'.");
			}
			return handle;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000038B7 File Offset: 0x00001AB7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000038E8 File Offset: 0x00001AE8
		public IOnBackPressedDispatcherOwnerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnBackPressedDispatcherOwnerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003920 File Offset: 0x00001B20
		private static Delegate GetGetOnBackPressedDispatcherHandler()
		{
			if (IOnBackPressedDispatcherOwnerInvoker.cb_getOnBackPressedDispatcher == null)
			{
				IOnBackPressedDispatcherOwnerInvoker.cb_getOnBackPressedDispatcher = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOnBackPressedDispatcherOwnerInvoker.n_GetOnBackPressedDispatcher));
			}
			return IOnBackPressedDispatcherOwnerInvoker.cb_getOnBackPressedDispatcher;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003944 File Offset: 0x00001B44
		private static IntPtr n_GetOnBackPressedDispatcher(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOnBackPressedDispatcherOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnBackPressedDispatcher);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003958 File Offset: 0x00001B58
		public OnBackPressedDispatcher OnBackPressedDispatcher
		{
			get
			{
				if (this.id_getOnBackPressedDispatcher == IntPtr.Zero)
				{
					this.id_getOnBackPressedDispatcher = JNIEnv.GetMethodID(this.class_ref, "getOnBackPressedDispatcher", "()Landroidx/activity/OnBackPressedDispatcher;");
				}
				return Java.Lang.Object.GetObject<OnBackPressedDispatcher>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOnBackPressedDispatcher), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000039A9 File Offset: 0x00001BA9
		private static Delegate GetGetLifecycleHandler()
		{
			if (IOnBackPressedDispatcherOwnerInvoker.cb_getLifecycle == null)
			{
				IOnBackPressedDispatcherOwnerInvoker.cb_getLifecycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IOnBackPressedDispatcherOwnerInvoker.n_GetLifecycle));
			}
			return IOnBackPressedDispatcherOwnerInvoker.cb_getLifecycle;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000039CD File Offset: 0x00001BCD
		private static IntPtr n_GetLifecycle(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IOnBackPressedDispatcherOwner>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lifecycle);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000039E4 File Offset: 0x00001BE4
		public Lifecycle Lifecycle
		{
			get
			{
				if (this.id_getLifecycle == IntPtr.Zero)
				{
					this.id_getLifecycle = JNIEnv.GetMethodID(this.class_ref, "getLifecycle", "()Landroidx/lifecycle/Lifecycle;");
				}
				return Java.Lang.Object.GetObject<Lifecycle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLifecycle), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/OnBackPressedDispatcherOwner", typeof(IOnBackPressedDispatcherOwnerInvoker));

		// Token: 0x0400001F RID: 31
		private IntPtr class_ref;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_getOnBackPressedDispatcher;

		// Token: 0x04000021 RID: 33
		private IntPtr id_getOnBackPressedDispatcher;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_getLifecycle;

		// Token: 0x04000023 RID: 35
		private IntPtr id_getLifecycle;
	}
}
