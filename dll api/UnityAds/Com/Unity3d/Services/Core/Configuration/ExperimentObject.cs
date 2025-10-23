using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000157 RID: 343
	[Register("com/unity3d/services/core/configuration/ExperimentObject", DoNotGenerateAcw = true)]
	public class ExperimentObject : Java.Lang.Object
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00027CA0 File Offset: 0x00025EA0
		internal static IntPtr class_ref
		{
			get
			{
				return ExperimentObject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00027CC4 File Offset: 0x00025EC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentObject._members;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00027CCC File Offset: 0x00025ECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExperimentObject._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00027CF0 File Offset: 0x00025EF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentObject._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ExperimentObject(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00027CFC File Offset: 0x00025EFC
		[Register(".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ExperimentObject(JSONObject experimentData) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((experimentData == null) ? IntPtr.Zero : experimentData.Handle);
				base.SetHandle(ExperimentObject._members.InstanceMethods.StartCreateInstance("(Lorg/json/JSONObject;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExperimentObject._members.InstanceMethods.FinishCreateInstance("(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(experimentData);
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00027DAC File Offset: 0x00025FAC
		private static Delegate GetGetAppliedRuleHandler()
		{
			if (ExperimentObject.cb_getAppliedRule == null)
			{
				ExperimentObject.cb_getAppliedRule = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExperimentObject.n_GetAppliedRule));
			}
			return ExperimentObject.cb_getAppliedRule;
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00027DD0 File Offset: 0x00025FD0
		private static IntPtr n_GetAppliedRule(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExperimentObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AppliedRule);
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00027DE4 File Offset: 0x00025FE4
		public virtual ExperimentAppliedRule AppliedRule
		{
			[Register("getAppliedRule", "()Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", "GetGetAppliedRuleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ExperimentAppliedRule>(ExperimentObject._members.InstanceMethods.InvokeVirtualObjectMethod("getAppliedRule.()Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00027E16 File Offset: 0x00026016
		private static Delegate GetGetBooleanValueHandler()
		{
			if (ExperimentObject.cb_getBooleanValue == null)
			{
				ExperimentObject.cb_getBooleanValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ExperimentObject.n_GetBooleanValue));
			}
			return ExperimentObject.cb_getBooleanValue;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00027E3A File Offset: 0x0002603A
		private static bool n_GetBooleanValue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExperimentObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BooleanValue;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00027E49 File Offset: 0x00026049
		public virtual bool BooleanValue
		{
			[Register("getBooleanValue", "()Z", "GetGetBooleanValueHandler")]
			get
			{
				return ExperimentObject._members.InstanceMethods.InvokeVirtualBooleanMethod("getBooleanValue.()Z", this, null);
			}
		}

		// Token: 0x0400034D RID: 845
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentObject", typeof(ExperimentObject));

		// Token: 0x0400034E RID: 846
		private static Delegate cb_getAppliedRule;

		// Token: 0x0400034F RID: 847
		private static Delegate cb_getBooleanValue;
	}
}
