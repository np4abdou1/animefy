using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Sensorinfo
{
	// Token: 0x0200009B RID: 155
	[Register("com/unity3d/services/core/sensorinfo/SensorInfoError", DoNotGenerateAcw = true)]
	public sealed class SensorInfoError : Java.Lang.Enum
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0000FF28 File Offset: 0x0000E128
		[Register("ACCELEROMETER_DATA_NOT_AVAILABLE")]
		public static SensorInfoError AccelerometerDataNotAvailable
		{
			get
			{
				return Java.Lang.Object.GetObject<SensorInfoError>(SensorInfoError._members.StaticFields.GetObjectValue("ACCELEROMETER_DATA_NOT_AVAILABLE.Lcom/unity3d/services/core/sensorinfo/SensorInfoError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000FF58 File Offset: 0x0000E158
		internal static IntPtr class_ref
		{
			get
			{
				return SensorInfoError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000FF7C File Offset: 0x0000E17C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SensorInfoError._members;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0000FF84 File Offset: 0x0000E184
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SensorInfoError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SensorInfoError._members.ManagedPeerType;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000256C File Offset: 0x0000076C
		internal SensorInfoError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000FFB4 File Offset: 0x0000E1B4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/sensorinfo/SensorInfoError;", "")]
		public unsafe static SensorInfoError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			SensorInfoError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SensorInfoError>(SensorInfoError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/sensorinfo/SensorInfoError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00010020 File Offset: 0x0000E220
		[Register("values", "()[Lcom/unity3d/services/core/sensorinfo/SensorInfoError;", "")]
		public static SensorInfoError[] Values()
		{
			return (SensorInfoError[])JNIEnv.GetArray(SensorInfoError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/sensorinfo/SensorInfoError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(SensorInfoError));
		}

		// Token: 0x04000149 RID: 329
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/sensorinfo/SensorInfoError", typeof(SensorInfoError));
	}
}
