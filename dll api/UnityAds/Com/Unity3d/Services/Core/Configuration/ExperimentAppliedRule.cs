using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000156 RID: 342
	[Register("com/unity3d/services/core/configuration/ExperimentAppliedRule", DoNotGenerateAcw = true)]
	public sealed class ExperimentAppliedRule : Java.Lang.Enum
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00027B1C File Offset: 0x00025D1C
		[Register("IMMEDIATE")]
		public static ExperimentAppliedRule Immediate
		{
			get
			{
				return Java.Lang.Object.GetObject<ExperimentAppliedRule>(ExperimentAppliedRule._members.StaticFields.GetObjectValue("IMMEDIATE.Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00027B4C File Offset: 0x00025D4C
		[Register("NEXT")]
		public static ExperimentAppliedRule Next
		{
			get
			{
				return Java.Lang.Object.GetObject<ExperimentAppliedRule>(ExperimentAppliedRule._members.StaticFields.GetObjectValue("NEXT.Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00027B7C File Offset: 0x00025D7C
		internal static IntPtr class_ref
		{
			get
			{
				return ExperimentAppliedRule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExperimentAppliedRule._members;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00027BA8 File Offset: 0x00025DA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExperimentAppliedRule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00027BCC File Offset: 0x00025DCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExperimentAppliedRule._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0000256C File Offset: 0x0000076C
		internal ExperimentAppliedRule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x00027BD8 File Offset: 0x00025DD8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", "")]
		public unsafe static ExperimentAppliedRule ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ExperimentAppliedRule @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExperimentAppliedRule>(ExperimentAppliedRule._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00027C44 File Offset: 0x00025E44
		[Register("values", "()[Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", "")]
		public static ExperimentAppliedRule[] Values()
		{
			return (ExperimentAppliedRule[])JNIEnv.GetArray(ExperimentAppliedRule._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/configuration/ExperimentAppliedRule;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ExperimentAppliedRule));
		}

		// Token: 0x0400034C RID: 844
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/ExperimentAppliedRule", typeof(ExperimentAppliedRule));
	}
}
