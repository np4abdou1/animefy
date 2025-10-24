using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Hardware;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Sensorinfo
{
	// Token: 0x0200009C RID: 156
	[Register("com/unity3d/services/core/sensorinfo/SensorInfoListener", DoNotGenerateAcw = true)]
	public class SensorInfoListener : Java.Lang.Object, ISensorEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001007C File Offset: 0x0000E27C
		internal static IntPtr class_ref
		{
			get
			{
				return SensorInfoListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000100A0 File Offset: 0x0000E2A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SensorInfoListener._members;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x000100A8 File Offset: 0x0000E2A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SensorInfoListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000100CC File Offset: 0x0000E2CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SensorInfoListener._members.ManagedPeerType;
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SensorInfoListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000100D8 File Offset: 0x0000E2D8
		[Register(".ctor", "()V", "")]
		public SensorInfoListener() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SensorInfoListener._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SensorInfoListener._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00010148 File Offset: 0x0000E348
		public static JSONObject AccelerometerData
		{
			[Register("getAccelerometerData", "()Lorg/json/JSONObject;", "")]
			get
			{
				return Java.Lang.Object.GetObject<JSONObject>(SensorInfoListener._members.StaticMethods.InvokeObjectMethod("getAccelerometerData.()Lorg/json/JSONObject;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00010179 File Offset: 0x0000E379
		public static bool IsAccelerometerListenerActive
		{
			[Register("isAccelerometerListenerActive", "()Z", "")]
			get
			{
				return SensorInfoListener._members.StaticMethods.InvokeBooleanMethod("isAccelerometerListenerActive.()Z", null);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00010191 File Offset: 0x0000E391
		private static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler()
		{
			if (SensorInfoListener.cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
			{
				SensorInfoListener.cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(SensorInfoListener.n_OnAccuracyChanged_Landroid_hardware_Sensor_I));
			}
			return SensorInfoListener.cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000101B8 File Offset: 0x0000E3B8
		private static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_sensor, int native_i)
		{
			SensorInfoListener @object = Java.Lang.Object.GetObject<SensorInfoListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Sensor object2 = Java.Lang.Object.GetObject<Sensor>(native_sensor, JniHandleOwnership.DoNotTransfer);
			@object.OnAccuracyChanged(object2, (SensorStatus)native_i);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000101E0 File Offset: 0x0000E3E0
		[Register("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public unsafe virtual void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus i)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sensor == null) ? IntPtr.Zero : sensor.Handle);
				ptr[1] = new JniArgumentValue((int)i);
				SensorInfoListener._members.InstanceMethods.InvokeVirtualVoidMethod("onAccuracyChanged.(Landroid/hardware/Sensor;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sensor);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00010258 File Offset: 0x0000E458
		private static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler()
		{
			if (SensorInfoListener.cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
			{
				SensorInfoListener.cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SensorInfoListener.n_OnSensorChanged_Landroid_hardware_SensorEvent_));
			}
			return SensorInfoListener.cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001027C File Offset: 0x0000E47C
		private static void n_OnSensorChanged_Landroid_hardware_SensorEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_sensorEvent)
		{
			SensorInfoListener @object = Java.Lang.Object.GetObject<SensorInfoListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SensorEvent object2 = Java.Lang.Object.GetObject<SensorEvent>(native_sensorEvent, JniHandleOwnership.DoNotTransfer);
			@object.OnSensorChanged(object2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000102A0 File Offset: 0x0000E4A0
		[Register("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public unsafe virtual void OnSensorChanged(SensorEvent sensorEvent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sensorEvent == null) ? IntPtr.Zero : sensorEvent.Handle);
				SensorInfoListener._members.InstanceMethods.InvokeVirtualVoidMethod("onSensorChanged.(Landroid/hardware/SensorEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sensorEvent);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00010304 File Offset: 0x0000E504
		[Register("startAccelerometerListener", "(I)Z", "")]
		public unsafe static bool StartAccelerometerListener(int sensorDelay)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sensorDelay);
			return SensorInfoListener._members.StaticMethods.InvokeBooleanMethod("startAccelerometerListener.(I)Z", ptr);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001033E File Offset: 0x0000E53E
		[Register("stopAccelerometerListener", "()V", "")]
		public static void StopAccelerometerListener()
		{
			SensorInfoListener._members.StaticMethods.InvokeVoidMethod("stopAccelerometerListener.()V", null);
		}

		// Token: 0x0400014A RID: 330
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/sensorinfo/SensorInfoListener", typeof(SensorInfoListener));

		// Token: 0x0400014B RID: 331
		private static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;

		// Token: 0x0400014C RID: 332
		private static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
	}
}
