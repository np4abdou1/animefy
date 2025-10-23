using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Hardware
{
	// Token: 0x0200020E RID: 526
	[Register("android/hardware/SensorEventListener", DoNotGenerateAcw = true)]
	internal class ISensorEventListenerInvoker : Java.Lang.Object, ISensorEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00031954 File Offset: 0x0002FB54
		private static IntPtr java_class_ref
		{
			get
			{
				return ISensorEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00031978 File Offset: 0x0002FB78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISensorEventListenerInvoker._members;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0003197F File Offset: 0x0002FB7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00031987 File Offset: 0x0002FB87
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISensorEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00031993 File Offset: 0x0002FB93
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISensorEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.hardware.SensorEventListener'.");
			}
			return handle;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000319BE File Offset: 0x0002FBBE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000319F0 File Offset: 0x0002FBF0
		public ISensorEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISensorEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00031A28 File Offset: 0x0002FC28
		private static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler()
		{
			if (ISensorEventListenerInvoker.cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
			{
				ISensorEventListenerInvoker.cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ISensorEventListenerInvoker.n_OnAccuracyChanged_Landroid_hardware_Sensor_I));
			}
			return ISensorEventListenerInvoker.cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00031A4C File Offset: 0x0002FC4C
		private static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_sensor, int native_accuracy)
		{
			ISensorEventListener @object = Java.Lang.Object.GetObject<ISensorEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Sensor object2 = Java.Lang.Object.GetObject<Sensor>(native_sensor, JniHandleOwnership.DoNotTransfer);
			@object.OnAccuracyChanged(object2, (SensorStatus)native_accuracy);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00031A74 File Offset: 0x0002FC74
		public unsafe void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
		{
			if (this.id_onAccuracyChanged_Landroid_hardware_Sensor_I == IntPtr.Zero)
			{
				this.id_onAccuracyChanged_Landroid_hardware_Sensor_I = JNIEnv.GetMethodID(this.class_ref, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((sensor == null) ? IntPtr.Zero : sensor.Handle);
			ptr[1] = new JValue((int)accuracy);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAccuracyChanged_Landroid_hardware_Sensor_I, ptr);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00031AFA File Offset: 0x0002FCFA
		private static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler()
		{
			if (ISensorEventListenerInvoker.cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
			{
				ISensorEventListenerInvoker.cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISensorEventListenerInvoker.n_OnSensorChanged_Landroid_hardware_SensorEvent_));
			}
			return ISensorEventListenerInvoker.cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00031B20 File Offset: 0x0002FD20
		private static void n_OnSensorChanged_Landroid_hardware_SensorEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ISensorEventListener @object = Java.Lang.Object.GetObject<ISensorEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SensorEvent object2 = Java.Lang.Object.GetObject<SensorEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.OnSensorChanged(object2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00031B44 File Offset: 0x0002FD44
		public unsafe void OnSensorChanged(SensorEvent e)
		{
			if (this.id_onSensorChanged_Landroid_hardware_SensorEvent_ == IntPtr.Zero)
			{
				this.id_onSensorChanged_Landroid_hardware_SensorEvent_ = JNIEnv.GetMethodID(this.class_ref, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSensorChanged_Landroid_hardware_SensorEvent_, ptr);
		}

		// Token: 0x04000875 RID: 2165
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/hardware/SensorEventListener", typeof(ISensorEventListenerInvoker));

		// Token: 0x04000876 RID: 2166
		private IntPtr class_ref;

		// Token: 0x04000877 RID: 2167
		private static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;

		// Token: 0x04000878 RID: 2168
		private IntPtr id_onAccuracyChanged_Landroid_hardware_Sensor_I;

		// Token: 0x04000879 RID: 2169
		private static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;

		// Token: 0x0400087A RID: 2170
		private IntPtr id_onSensorChanged_Landroid_hardware_SensorEvent_;
	}
}
