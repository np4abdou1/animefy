using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Misc;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000143 RID: 323
	[Register("com/unity3d/services/core/device/reader/pii/PiiDataSelector", DoNotGenerateAcw = true)]
	public class PiiDataSelector : Java.Lang.Object
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00024220 File Offset: 0x00022420
		internal static IntPtr class_ref
		{
			get
			{
				return PiiDataSelector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00024244 File Offset: 0x00022444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PiiDataSelector._members;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0002424C File Offset: 0x0002244C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PiiDataSelector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00024270 File Offset: 0x00022470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PiiDataSelector._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000021E8 File Offset: 0x000003E8
		protected PiiDataSelector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0002427C File Offset: 0x0002247C
		[Register(".ctor", "(Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;Lcom/unity3d/services/core/misc/IJsonStorageReader;Lcom/unity3d/services/core/configuration/IExperiments;)V", "")]
		public unsafe PiiDataSelector(PiiTrackingStatusReader piiTrackingStatusReader, IJsonStorageReader jsonStorageReader, IExperiments experiments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((piiTrackingStatusReader == null) ? IntPtr.Zero : piiTrackingStatusReader.Handle);
				ptr[1] = new JniArgumentValue((jsonStorageReader == null) ? IntPtr.Zero : ((Java.Lang.Object)jsonStorageReader).Handle);
				ptr[2] = new JniArgumentValue((experiments == null) ? IntPtr.Zero : ((Java.Lang.Object)experiments).Handle);
				base.SetHandle(PiiDataSelector._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;Lcom/unity3d/services/core/misc/IJsonStorageReader;Lcom/unity3d/services/core/configuration/IExperiments;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				PiiDataSelector._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/core/device/reader/pii/PiiTrackingStatusReader;Lcom/unity3d/services/core/misc/IJsonStorageReader;Lcom/unity3d/services/core/configuration/IExperiments;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(piiTrackingStatusReader);
				GC.KeepAlive(jsonStorageReader);
				GC.KeepAlive(experiments);
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00024388 File Offset: 0x00022588
		private static Delegate GetWhatToDoWithPIIHandler()
		{
			if (PiiDataSelector.cb_whatToDoWithPII == null)
			{
				PiiDataSelector.cb_whatToDoWithPII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PiiDataSelector.n_WhatToDoWithPII));
			}
			return PiiDataSelector.cb_whatToDoWithPII;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000243AC File Offset: 0x000225AC
		private static IntPtr n_WhatToDoWithPII(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PiiDataSelector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WhatToDoWithPII());
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000243C0 File Offset: 0x000225C0
		[Register("whatToDoWithPII", "()Lcom/unity3d/services/core/device/reader/pii/PiiDecisionData;", "GetWhatToDoWithPIIHandler")]
		public virtual PiiDecisionData WhatToDoWithPII()
		{
			return Java.Lang.Object.GetObject<PiiDecisionData>(PiiDataSelector._members.InstanceMethods.InvokeVirtualObjectMethod("whatToDoWithPII.()Lcom/unity3d/services/core/device/reader/pii/PiiDecisionData;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002FA RID: 762
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/PiiDataSelector", typeof(PiiDataSelector));

		// Token: 0x040002FB RID: 763
		private static Delegate cb_whatToDoWithPII;
	}
}
