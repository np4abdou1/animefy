using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000138 RID: 312
	[Register("com/unity3d/services/core/device/reader/IDeviceInfoDataCompressor", DoNotGenerateAcw = true)]
	internal class IDeviceInfoDataCompressorInvoker : Java.Lang.Object, IDeviceInfoDataCompressor, IDeviceInfoDataContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00023400 File Offset: 0x00021600
		private static IntPtr java_class_ref
		{
			get
			{
				return IDeviceInfoDataCompressorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00023424 File Offset: 0x00021624
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDeviceInfoDataCompressorInvoker._members;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0002342B File Offset: 0x0002162B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00023433 File Offset: 0x00021633
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDeviceInfoDataCompressorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0002343F File Offset: 0x0002163F
		public static IDeviceInfoDataCompressor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDeviceInfoDataCompressor>(handle, transfer);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00023448 File Offset: 0x00021648
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDeviceInfoDataCompressorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.device.reader.IDeviceInfoDataCompressor'.");
			}
			return handle;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00023473 File Offset: 0x00021673
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000234A4 File Offset: 0x000216A4
		public IDeviceInfoDataCompressorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDeviceInfoDataCompressorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000234DC File Offset: 0x000216DC
		private static Delegate GetCompressDeviceInfo_Ljava_util_Map_Handler()
		{
			if (IDeviceInfoDataCompressorInvoker.cb_compressDeviceInfo_Ljava_util_Map_ == null)
			{
				IDeviceInfoDataCompressorInvoker.cb_compressDeviceInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IDeviceInfoDataCompressorInvoker.n_CompressDeviceInfo_Ljava_util_Map_));
			}
			return IDeviceInfoDataCompressorInvoker.cb_compressDeviceInfo_Ljava_util_Map_;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00023500 File Offset: 0x00021700
		private static IntPtr n_CompressDeviceInfo_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IDeviceInfoDataCompressor @object = Java.Lang.Object.GetObject<IDeviceInfoDataCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, Java.Lang.Object> p = JavaDictionary<string, Java.Lang.Object>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.CompressDeviceInfo(p));
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00023528 File Offset: 0x00021728
		public unsafe byte[] CompressDeviceInfo(IDictionary<string, Java.Lang.Object> p0)
		{
			if (this.id_compressDeviceInfo_Ljava_util_Map_ == IntPtr.Zero)
			{
				this.id_compressDeviceInfo_Ljava_util_Map_ = JNIEnv.GetMethodID(this.class_ref, "compressDeviceInfo", "(Ljava/util/Map;)[B");
			}
			IntPtr intPtr = JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			byte[] result = (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_compressDeviceInfo_Ljava_util_Map_, ptr), JniHandleOwnership.TransferLocalRef, typeof(byte));
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000235AE File Offset: 0x000217AE
		private static Delegate GetGetDeviceInfoHandler()
		{
			if (IDeviceInfoDataCompressorInvoker.cb_getDeviceInfo == null)
			{
				IDeviceInfoDataCompressorInvoker.cb_getDeviceInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeviceInfoDataCompressorInvoker.n_GetDeviceInfo));
			}
			return IDeviceInfoDataCompressorInvoker.cb_getDeviceInfo;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000235D2 File Offset: 0x000217D2
		private static IntPtr n_GetDeviceInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, Java.Lang.Object>.ToLocalJniHandle(Java.Lang.Object.GetObject<IDeviceInfoDataCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeviceInfo);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000235E8 File Offset: 0x000217E8
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

		// Token: 0x06000C84 RID: 3204 RVA: 0x00023639 File Offset: 0x00021839
		private static Delegate GetGetDeviceDataHandler()
		{
			if (IDeviceInfoDataCompressorInvoker.cb_getDeviceData == null)
			{
				IDeviceInfoDataCompressorInvoker.cb_getDeviceData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDeviceInfoDataCompressorInvoker.n_GetDeviceData));
			}
			return IDeviceInfoDataCompressorInvoker.cb_getDeviceData;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0002365D File Offset: 0x0002185D
		private static IntPtr n_GetDeviceData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<IDeviceInfoDataCompressor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDeviceData());
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00023674 File Offset: 0x00021874
		public byte[] GetDeviceData()
		{
			if (this.id_getDeviceData == IntPtr.Zero)
			{
				this.id_getDeviceData = JNIEnv.GetMethodID(this.class_ref, "getDeviceData", "()[B");
			}
			return (byte[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getDeviceData), JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x040002D0 RID: 720
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/IDeviceInfoDataCompressor", typeof(IDeviceInfoDataCompressorInvoker));

		// Token: 0x040002D1 RID: 721
		private IntPtr class_ref;

		// Token: 0x040002D2 RID: 722
		private static Delegate cb_compressDeviceInfo_Ljava_util_Map_;

		// Token: 0x040002D3 RID: 723
		private IntPtr id_compressDeviceInfo_Ljava_util_Map_;

		// Token: 0x040002D4 RID: 724
		private static Delegate cb_getDeviceInfo;

		// Token: 0x040002D5 RID: 725
		private IntPtr id_getDeviceInfo;

		// Token: 0x040002D6 RID: 726
		private static Delegate cb_getDeviceData;

		// Token: 0x040002D7 RID: 727
		private IntPtr id_getDeviceData;
	}
}
