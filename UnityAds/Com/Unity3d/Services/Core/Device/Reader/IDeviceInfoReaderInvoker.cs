using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013C RID: 316
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoReader", DoNotGenerateAcw = true)]
	internal class IDeviceInfoReaderInvoker : Java.Lang.Object, IDeviceInfoReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0002390C File Offset: 0x00021B0C
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeviceInfoReaderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00023930 File Offset: 0x00021B30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDeviceInfoReaderInvoker._members;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00023937 File Offset: 0x00021B37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0002393F File Offset: 0x00021B3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDeviceInfoReaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0002394B File Offset: 0x00021B4B
		public static IDeviceInfoReader GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeviceInfoReader>(handle, transfer);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00023954 File Offset: 0x00021B54
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeviceInfoReaderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.device.reader.IDeviceInfoReader'.");
			}
			return handle;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002397F File Offset: 0x00021B7F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000239B0 File Offset: 0x00021BB0
		public IDeviceInfoReaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeviceInfoReaderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000239E8 File Offset: 0x00021BE8
		private static Delegate GetGetDeviceInfoDataHandler()
		{
			if (IDeviceInfoReaderInvoker.cb_getDeviceInfoData == null)
			{
				IDeviceInfoReaderInvoker.cb_getDeviceInfoData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeviceInfoReaderInvoker.n_GetDeviceInfoData));
			}
			return IDeviceInfoReaderInvoker.cb_getDeviceInfoData;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00023A0C File Offset: 0x00021C0C
		private static IntPtr n_GetDeviceInfoData(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeviceInfoReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfoData);
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00023A20 File Offset: 0x00021C20
		public IDictionary<string, Java.Lang.Object> DeviceInfoData
		{
			get
			{
				if (this.id_getDeviceInfoData == IntPtr.Zero)
				{
					this.id_getDeviceInfoData = JNIEnv.GetMethodID(this.class_ref, "getDeviceInfoData", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeviceInfoData), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002DE RID: 734
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/IDeviceInfoReader", typeof(IDeviceInfoReaderInvoker));

		// Token: 0x040002DF RID: 735
		private IntPtr class_ref;

		// Token: 0x040002E0 RID: 736
		private static Delegate cb_getDeviceInfoData;

		// Token: 0x040002E1 RID: 737
		private IntPtr id_getDeviceInfoData;
	}
}
