using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Timer;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation
{
	// Token: 0x020001EC RID: 492
	[Register("com/unity3d/services/ads/operation/OperationState", DoNotGenerateAcw = true)]
	public class OperationState : Java.Lang.Object, IWebViewSharedObject, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x000401A0 File Offset: 0x0003E3A0
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x000401D0 File Offset: 0x0003E3D0
		[Register("configuration")]
		public Configuration Configuration
		{
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(OperationState._members.InstanceFields.GetObjectValue("configuration.Lcom/unity3d/services/core/configuration/Configuration;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					OperationState._members.InstanceFields.SetValue("configuration.Lcom/unity3d/services/core/configuration/Configuration;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0004021C File Offset: 0x0003E41C
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x0004024C File Offset: 0x0003E44C
		[Register("placementId")]
		public string PlacementId
		{
			get
			{
				return JNIEnv.GetString(OperationState._members.InstanceFields.GetObjectValue("placementId.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					OperationState._members.InstanceFields.SetValue("placementId.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x00040298 File Offset: 0x0003E498
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x000402AF File Offset: 0x0003E4AF
		[Register("startTime")]
		public long StartTime
		{
			get
			{
				return OperationState._members.InstanceFields.GetInt64Value("startTime.J", this);
			}
			set
			{
				OperationState._members.InstanceFields.SetValue("startTime.J", this, value);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x000402C8 File Offset: 0x0003E4C8
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x000402F8 File Offset: 0x0003E4F8
		[Register("timeoutTimer")]
		public BaseTimer TimeoutTimer
		{
			get
			{
				return Java.Lang.Object.GetObject<BaseTimer>(OperationState._members.InstanceFields.GetObjectValue("timeoutTimer.Lcom/unity3d/services/core/timer/BaseTimer;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					OperationState._members.InstanceFields.SetValue("timeoutTimer.Lcom/unity3d/services/core/timer/BaseTimer;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00040344 File Offset: 0x0003E544
		internal static IntPtr class_ref
		{
			get
			{
				return OperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00040368 File Offset: 0x0003E568
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OperationState._members;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00040370 File Offset: 0x0003E570
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OperationState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00040394 File Offset: 0x0003E594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OperationState._members.ManagedPeerType;
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000021E8 File Offset: 0x000003E8
		protected OperationState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000403A0 File Offset: 0x0003E5A0
		[Register(".ctor", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe OperationState(string placementId, Configuration configuration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				base.SetHandle(OperationState._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				OperationState._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0004046C File Offset: 0x0003E66C
		private static Delegate GetGetIdHandler()
		{
			if (OperationState.cb_getId == null)
			{
				OperationState.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(OperationState.n_GetId));
			}
			return OperationState.cb_getId;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00040490 File Offset: 0x0003E690
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<OperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x000404A4 File Offset: 0x0003E6A4
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(OperationState._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000404D6 File Offset: 0x0003E6D6
		private static Delegate GetDurationHandler()
		{
			if (OperationState.cb_duration == null)
			{
				OperationState.cb_duration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(OperationState.n_Duration));
			}
			return OperationState.cb_duration;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000404FA File Offset: 0x0003E6FA
		private static long n_Duration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<OperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration();
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00040509 File Offset: 0x0003E709
		[Register("duration", "()J", "GetDurationHandler")]
		public virtual long Duration()
		{
			return OperationState._members.InstanceMethods.InvokeVirtualInt64Method("duration.()J", this, null);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00040522 File Offset: 0x0003E722
		private static Delegate GetStartHandler()
		{
			if (OperationState.cb_start == null)
			{
				OperationState.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(OperationState.n_Start));
			}
			return OperationState.cb_start;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00040546 File Offset: 0x0003E746
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<OperationState>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00040555 File Offset: 0x0003E755
		[Register("start", "()V", "GetStartHandler")]
		public virtual void Start()
		{
			OperationState._members.InstanceMethods.InvokeVirtualVoidMethod("start.()V", this, null);
		}

		// Token: 0x04000551 RID: 1361
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/OperationState", typeof(OperationState));

		// Token: 0x04000552 RID: 1362
		private static Delegate cb_getId;

		// Token: 0x04000553 RID: 1363
		private static Delegate cb_duration;

		// Token: 0x04000554 RID: 1364
		private static Delegate cb_start;
	}
}
