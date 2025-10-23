using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Log
{
	// Token: 0x020000E9 RID: 233
	[Register("com/unity3d/services/core/log/DeviceLogLevel", DoNotGenerateAcw = true)]
	public class DeviceLogLevel : Java.Lang.Object
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0001B3EC File Offset: 0x000195EC
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceLogLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0001B410 File Offset: 0x00019610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceLogLevel._members;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0001B418 File Offset: 0x00019618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceLogLevel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0001B43C File Offset: 0x0001963C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceLogLevel._members.ManagedPeerType;
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceLogLevel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001B448 File Offset: 0x00019648
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DeviceLogLevel(string receivingMethodName) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(receivingMethodName);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(DeviceLogLevel._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DeviceLogLevel._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001B4EC File Offset: 0x000196EC
		private static Delegate GetGetLogTagHandler()
		{
			if (DeviceLogLevel.cb_getLogTag == null)
			{
				DeviceLogLevel.cb_getLogTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceLogLevel.n_GetLogTag));
			}
			return DeviceLogLevel.cb_getLogTag;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001B510 File Offset: 0x00019710
		private static IntPtr n_GetLogTag(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<DeviceLogLevel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogTag);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0001B524 File Offset: 0x00019724
		public virtual string LogTag
		{
			[Register("getLogTag", "()Ljava/lang/String;", "GetGetLogTagHandler")]
			get
			{
				return JNIEnv.GetString(DeviceLogLevel._members.InstanceMethods.InvokeVirtualObjectMethod("getLogTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001B556 File Offset: 0x00019756
		private static Delegate GetGetReceivingMethodNameHandler()
		{
			if (DeviceLogLevel.cb_getReceivingMethodName == null)
			{
				DeviceLogLevel.cb_getReceivingMethodName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DeviceLogLevel.n_GetReceivingMethodName));
			}
			return DeviceLogLevel.cb_getReceivingMethodName;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001B57A File Offset: 0x0001977A
		private static IntPtr n_GetReceivingMethodName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<DeviceLogLevel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReceivingMethodName);
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0001B590 File Offset: 0x00019790
		public virtual string ReceivingMethodName
		{
			[Register("getReceivingMethodName", "()Ljava/lang/String;", "GetGetReceivingMethodNameHandler")]
			get
			{
				return JNIEnv.GetString(DeviceLogLevel._members.InstanceMethods.InvokeVirtualObjectMethod("getReceivingMethodName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400022D RID: 557
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/log/DeviceLogLevel", typeof(DeviceLogLevel));

		// Token: 0x0400022E RID: 558
		private static Delegate cb_getLogTag;

		// Token: 0x0400022F RID: 559
		private static Delegate cb_getReceivingMethodName;
	}
}
