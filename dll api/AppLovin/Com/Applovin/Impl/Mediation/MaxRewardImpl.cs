using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000158 RID: 344
	[Register("com/applovin/impl/mediation/MaxRewardImpl", DoNotGenerateAcw = true)]
	public class MaxRewardImpl : Java.Lang.Object, IMaxReward, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00031108 File Offset: 0x0002F308
		internal static IntPtr class_ref
		{
			get
			{
				return MaxRewardImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0003112C File Offset: 0x0002F32C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxRewardImpl._members;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00031134 File Offset: 0x0002F334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxRewardImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00031158 File Offset: 0x0002F358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxRewardImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxRewardImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00031164 File Offset: 0x0002F364
		public int Amount
		{
			[Register("getAmount", "()I", "")]
			get
			{
				return MaxRewardImpl._members.InstanceMethods.InvokeNonvirtualInt32Method("getAmount.()I", this, null);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00031180 File Offset: 0x0002F380
		public string Label
		{
			[Register("getLabel", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(MaxRewardImpl._members.InstanceMethods.InvokeNonvirtualObjectMethod("getLabel.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x000311B4 File Offset: 0x0002F3B4
		[Register("create", "(ILjava/lang/String;)Lcom/applovin/mediation/MaxReward;", "")]
		public unsafe static IMaxReward Create(int p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			IMaxReward @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMaxReward>(MaxRewardImpl._members.StaticMethods.InvokeObjectMethod("create.(ILjava/lang/String;)Lcom/applovin/mediation/MaxReward;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00031234 File Offset: 0x0002F434
		[Register("createDefault", "()Lcom/applovin/mediation/MaxReward;", "")]
		public static IMaxReward CreateDefault()
		{
			return Java.Lang.Object.GetObject<IMaxReward>(MaxRewardImpl._members.StaticMethods.InvokeObjectMethod("createDefault.()Lcom/applovin/mediation/MaxReward;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000599 RID: 1433
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxRewardImpl", typeof(MaxRewardImpl));

		// Token: 0x02000159 RID: 345
		public static class InterfaceConsts
		{
			// Token: 0x0400059A RID: 1434
			[Register("DEFAULT_AMOUNT")]
			public const int DefaultAmount = 0;

			// Token: 0x0400059B RID: 1435
			[Register("DEFAULT_LABEL")]
			public const string DefaultLabel = "";
		}
	}
}
