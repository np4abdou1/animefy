using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x0200011E RID: 286
	[Register("com/unity3d/services/core/device/IVolumeChangeListener", DoNotGenerateAcw = true)]
	internal class IVolumeChangeListenerInvoker : Java.Lang.Object, IVolumeChangeListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00020158 File Offset: 0x0001E358
		private static IntPtr java_class_ref
		{
			get
			{
				return IVolumeChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002017C File Offset: 0x0001E37C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVolumeChangeListenerInvoker._members;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00020183 File Offset: 0x0001E383
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002018B File Offset: 0x0001E38B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVolumeChangeListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00020197 File Offset: 0x0001E397
		public static IVolumeChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IVolumeChangeListener>(handle, transfer);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000201A0 File Offset: 0x0001E3A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVolumeChangeListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.device.IVolumeChangeListener'.");
			}
			return handle;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000201CB File Offset: 0x0001E3CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000201FC File Offset: 0x0001E3FC
		public IVolumeChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVolumeChangeListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00020234 File Offset: 0x0001E434
		private static Delegate GetGetStreamTypeHandler()
		{
			if (IVolumeChangeListenerInvoker.cb_getStreamType == null)
			{
				IVolumeChangeListenerInvoker.cb_getStreamType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IVolumeChangeListenerInvoker.n_GetStreamType));
			}
			return IVolumeChangeListenerInvoker.cb_getStreamType;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00020258 File Offset: 0x0001E458
		private static int n_GetStreamType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IVolumeChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StreamType;
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00020267 File Offset: 0x0001E467
		public int StreamType
		{
			get
			{
				if (this.id_getStreamType == IntPtr.Zero)
				{
					this.id_getStreamType = JNIEnv.GetMethodID(this.class_ref, "getStreamType", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getStreamType);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000202A7 File Offset: 0x0001E4A7
		private static Delegate GetOnVolumeChanged_IHandler()
		{
			if (IVolumeChangeListenerInvoker.cb_onVolumeChanged_I == null)
			{
				IVolumeChangeListenerInvoker.cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IVolumeChangeListenerInvoker.n_OnVolumeChanged_I));
			}
			return IVolumeChangeListenerInvoker.cb_onVolumeChanged_I;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000202CB File Offset: 0x0001E4CB
		private static void n_OnVolumeChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<IVolumeChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnVolumeChanged(p0);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000202DC File Offset: 0x0001E4DC
		public unsafe void OnVolumeChanged(int p0)
		{
			if (this.id_onVolumeChanged_I == IntPtr.Zero)
			{
				this.id_onVolumeChanged_I = JNIEnv.GetMethodID(this.class_ref, "onVolumeChanged", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onVolumeChanged_I, ptr);
		}

		// Token: 0x04000292 RID: 658
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/IVolumeChangeListener", typeof(IVolumeChangeListenerInvoker));

		// Token: 0x04000293 RID: 659
		private IntPtr class_ref;

		// Token: 0x04000294 RID: 660
		private static Delegate cb_getStreamType;

		// Token: 0x04000295 RID: 661
		private IntPtr id_getStreamType;

		// Token: 0x04000296 RID: 662
		private static Delegate cb_onVolumeChanged_I;

		// Token: 0x04000297 RID: 663
		private IntPtr id_onVolumeChanged_I;
	}
}
