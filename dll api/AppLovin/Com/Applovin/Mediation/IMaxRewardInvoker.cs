using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C5 RID: 197
	[Register("com/applovin/mediation/MaxReward", DoNotGenerateAcw = true)]
	internal class IMaxRewardInvoker : Java.Lang.Object, IMaxReward, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00010F44 File Offset: 0x0000F144
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00010F68 File Offset: 0x0000F168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardInvoker._members;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00010F6F File Offset: 0x0000F16F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00010F77 File Offset: 0x0000F177
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00010F83 File Offset: 0x0000F183
		public static IMaxReward GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxReward>(handle, transfer);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00010F8C File Offset: 0x0000F18C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxReward'.");
			}
			return handle;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00010FB7 File Offset: 0x0000F1B7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public IMaxRewardInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00011020 File Offset: 0x0000F220
		private static Delegate GetGetAmountHandler()
		{
			if (IMaxRewardInvoker.cb_getAmount == null)
			{
				IMaxRewardInvoker.cb_getAmount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMaxRewardInvoker.n_GetAmount));
			}
			return IMaxRewardInvoker.cb_getAmount;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00011044 File Offset: 0x0000F244
		private static int n_GetAmount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Amount;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00011053 File Offset: 0x0000F253
		public int Amount
		{
			get
			{
				if (this.id_getAmount == IntPtr.Zero)
				{
					this.id_getAmount = JNIEnv.GetMethodID(this.class_ref, "getAmount", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getAmount);
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00011093 File Offset: 0x0000F293
		private static Delegate GetGetLabelHandler()
		{
			if (IMaxRewardInvoker.cb_getLabel == null)
			{
				IMaxRewardInvoker.cb_getLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxRewardInvoker.n_GetLabel));
			}
			return IMaxRewardInvoker.cb_getLabel;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000110B7 File Offset: 0x0000F2B7
		private static IntPtr n_GetLabel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Label);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000110CC File Offset: 0x0000F2CC
		public string Label
		{
			get
			{
				if (this.id_getLabel == IntPtr.Zero)
				{
					this.id_getLabel = JNIEnv.GetMethodID(this.class_ref, "getLabel", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getLabel), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400023D RID: 573
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxReward", typeof(IMaxRewardInvoker));

		// Token: 0x0400023E RID: 574
		private IntPtr class_ref;

		// Token: 0x0400023F RID: 575
		private static Delegate cb_getAmount;

		// Token: 0x04000240 RID: 576
		private IntPtr id_getAmount;

		// Token: 0x04000241 RID: 577
		private static Delegate cb_getLabel;

		// Token: 0x04000242 RID: 578
		private IntPtr id_getLabel;
	}
}
