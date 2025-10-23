using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013A RID: 314
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoDataContainer", DoNotGenerateAcw = true)]
	internal class IDeviceInfoDataContainerInvoker : Java.Lang.Object, IDeviceInfoDataContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000236F0 File Offset: 0x000218F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeviceInfoDataContainerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00023714 File Offset: 0x00021914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDeviceInfoDataContainerInvoker._members;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0002371B File Offset: 0x0002191B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00023723 File Offset: 0x00021923
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDeviceInfoDataContainerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0002372F File Offset: 0x0002192F
		public static IDeviceInfoDataContainer GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeviceInfoDataContainer>(handle, transfer);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00023738 File Offset: 0x00021938
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeviceInfoDataContainerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.device.reader.IDeviceInfoDataContainer'.");
			}
			return handle;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00023763 File Offset: 0x00021963
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00023794 File Offset: 0x00021994
		public IDeviceInfoDataContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeviceInfoDataContainerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000237CC File Offset: 0x000219CC
		private static Delegate GetGetDeviceInfoHandler()
		{
			if (IDeviceInfoDataContainerInvoker.cb_getDeviceInfo == null)
			{
				IDeviceInfoDataContainerInvoker.cb_getDeviceInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeviceInfoDataContainerInvoker.n_GetDeviceInfo));
			}
			return IDeviceInfoDataContainerInvoker.cb_getDeviceInfo;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000237F0 File Offset: 0x000219F0
		private static IntPtr n_GetDeviceInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeviceInfoDataContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfo);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00023804 File Offset: 0x00021A04
		public IDictionary<string, Java.Lang.Object> DeviceInfo
		{
			get
			{
				if (this.id_getDeviceInfo == IntPtr.Zero)
				{
					this.id_getDeviceInfo = JNIEnv.GetMethodID(this.class_ref, "getDeviceInfo", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeviceInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00023855 File Offset: 0x00021A55
		private static Delegate GetGetDeviceDataHandler()
		{
			if (IDeviceInfoDataContainerInvoker.cb_getDeviceData == null)
			{
				IDeviceInfoDataContainerInvoker.cb_getDeviceData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeviceInfoDataContainerInvoker.n_GetDeviceData));
			}
			return IDeviceInfoDataContainerInvoker.cb_getDeviceData;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00023879 File Offset: 0x00021A79
		private static IntPtr n_GetDeviceData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IDeviceInfoDataContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeviceData());
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00023890 File Offset: 0x00021A90
		public byte[] GetDeviceData()
		{
			if (this.id_getDeviceData == IntPtr.Zero)
			{
				this.id_getDeviceData = JNIEnv.GetMethodID(this.class_ref, "getDeviceData", "()[B");
			}
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeviceData), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x040002D8 RID: 728
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/IDeviceInfoDataContainer", typeof(IDeviceInfoDataContainerInvoker));

		// Token: 0x040002D9 RID: 729
		private IntPtr class_ref;

		// Token: 0x040002DA RID: 730
		private static Delegate cb_getDeviceInfo;

		// Token: 0x040002DB RID: 731
		private IntPtr id_getDeviceInfo;

		// Token: 0x040002DC RID: 732
		private static Delegate cb_getDeviceData;

		// Token: 0x040002DD RID: 733
		private IntPtr id_getDeviceData;
	}
}
