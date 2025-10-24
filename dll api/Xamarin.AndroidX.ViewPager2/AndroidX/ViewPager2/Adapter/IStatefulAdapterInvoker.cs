using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager2.Adapter
{
	// Token: 0x02000016 RID: 22
	[Register("androidx/viewpager2/adapter/StatefulAdapter", DoNotGenerateAcw = true)]
	internal class IStatefulAdapterInvoker : Java.Lang.Object, IStatefulAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000094 RID: 148 RVA: 0x000038B8 File Offset: 0x00001AB8
		private static IntPtr java_class_ref
		{
			get
			{
				return IStatefulAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000038DC File Offset: 0x00001ADC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStatefulAdapterInvoker._members;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000038E3 File Offset: 0x00001AE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000038EB File Offset: 0x00001AEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStatefulAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000038F7 File Offset: 0x00001AF7
		public static IStatefulAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStatefulAdapter>(handle, transfer);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003900 File Offset: 0x00001B00
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStatefulAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.viewpager2.adapter.StatefulAdapter'.");
			}
			return handle;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000392B File Offset: 0x00001B2B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000395C File Offset: 0x00001B5C
		public IStatefulAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStatefulAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003994 File Offset: 0x00001B94
		private static Delegate GetRestoreState_Landroid_os_Parcelable_Handler()
		{
			if (IStatefulAdapterInvoker.cb_restoreState_Landroid_os_Parcelable_ == null)
			{
				IStatefulAdapterInvoker.cb_restoreState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IStatefulAdapterInvoker.n_RestoreState_Landroid_os_Parcelable_));
			}
			return IStatefulAdapterInvoker.cb_restoreState_Landroid_os_Parcelable_;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000039B8 File Offset: 0x00001BB8
		private static void n_RestoreState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IStatefulAdapter @object = Java.Lang.Object.GetObject<IStatefulAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RestoreState(object2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000039DC File Offset: 0x00001BDC
		public unsafe void RestoreState(IParcelable p0)
		{
			if (this.id_restoreState_Landroid_os_Parcelable_ == IntPtr.Zero)
			{
				this.id_restoreState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID(this.class_ref, "restoreState", "(Landroid/os/Parcelable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_restoreState_Landroid_os_Parcelable_, ptr);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003A54 File Offset: 0x00001C54
		private static Delegate GetSaveStateHandler()
		{
			if (IStatefulAdapterInvoker.cb_saveState == null)
			{
				IStatefulAdapterInvoker.cb_saveState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStatefulAdapterInvoker.n_SaveState));
			}
			return IStatefulAdapterInvoker.cb_saveState;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003A78 File Offset: 0x00001C78
		private static IntPtr n_SaveState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IStatefulAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SaveState());
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003A8C File Offset: 0x00001C8C
		public IParcelable SaveState()
		{
			if (this.id_saveState == IntPtr.Zero)
			{
				this.id_saveState = JNIEnv.GetMethodID(this.class_ref, "saveState", "()Landroid/os/Parcelable;");
			}
			return Java.Lang.Object.GetObject<IParcelable>(JNIEnv.CallObjectMethod(base.Handle, this.id_saveState), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000013 RID: 19
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/adapter/StatefulAdapter", typeof(IStatefulAdapterInvoker));

		// Token: 0x04000014 RID: 20
		private IntPtr class_ref;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_restoreState_Landroid_os_Parcelable_;

		// Token: 0x04000016 RID: 22
		private IntPtr id_restoreState_Landroid_os_Parcelable_;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_saveState;

		// Token: 0x04000018 RID: 24
		private IntPtr id_saveState;
	}
}
