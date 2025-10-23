using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000028 RID: 40
	[Register("com/google/android/gms/ads/rewarded/RewardItem", DoNotGenerateAcw = true)]
	internal class IRewardItemInvoker : Java.Lang.Object, IRewardItem, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00005804 File Offset: 0x00003A04
		private static IntPtr java_class_ref
		{
			get
			{
				return IRewardItemInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005828 File Offset: 0x00003A28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRewardItemInvoker._members;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000582F File Offset: 0x00003A2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005837 File Offset: 0x00003A37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRewardItemInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005843 File Offset: 0x00003A43
		public static IRewardItem GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRewardItem>(handle, transfer);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000584C File Offset: 0x00003A4C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRewardItemInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.ads.rewarded.RewardItem'.");
			}
			return handle;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005877 File Offset: 0x00003A77
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000058A8 File Offset: 0x00003AA8
		public IRewardItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRewardItemInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000058E0 File Offset: 0x00003AE0
		private static Delegate GetGetAmountHandler()
		{
			if (IRewardItemInvoker.cb_getAmount == null)
			{
				IRewardItemInvoker.cb_getAmount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IRewardItemInvoker.n_GetAmount));
			}
			return IRewardItemInvoker.cb_getAmount;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005904 File Offset: 0x00003B04
		private static int n_GetAmount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IRewardItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Amount;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00005913 File Offset: 0x00003B13
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

		// Token: 0x06000189 RID: 393 RVA: 0x00005953 File Offset: 0x00003B53
		private static Delegate GetGetTypeHandler()
		{
			if (IRewardItemInvoker.cb_getType == null)
			{
				IRewardItemInvoker.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IRewardItemInvoker.n_GetType));
			}
			return IRewardItemInvoker.cb_getType;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005977 File Offset: 0x00003B77
		private static IntPtr n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IRewardItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000598C File Offset: 0x00003B8C
		public string Type
		{
			get
			{
				if (this.id_getType == IntPtr.Zero)
				{
					this.id_getType = JNIEnv.GetMethodID(this.class_ref, "getType", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000052 RID: 82
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/RewardItem", typeof(IRewardItemInvoker));

		// Token: 0x04000053 RID: 83
		private IntPtr class_ref;

		// Token: 0x04000054 RID: 84
		private static Delegate cb_getAmount;

		// Token: 0x04000055 RID: 85
		private IntPtr id_getAmount;

		// Token: 0x04000056 RID: 86
		private static Delegate cb_getType;

		// Token: 0x04000057 RID: 87
		private IntPtr id_getType;
	}
}
