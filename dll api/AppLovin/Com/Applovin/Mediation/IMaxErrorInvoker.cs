using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B8 RID: 184
	[Register("com/applovin/mediation/MaxError", DoNotGenerateAcw = true)]
	internal class IMaxErrorInvoker : Java.Lang.Object, IMaxError, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000102C0 File Offset: 0x0000E4C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxErrorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000102E4 File Offset: 0x0000E4E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxErrorInvoker._members;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000102EB File Offset: 0x0000E4EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000102F3 File Offset: 0x0000E4F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxErrorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000102FF File Offset: 0x0000E4FF
		public static IMaxError GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxError>(handle, transfer);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00010308 File Offset: 0x0000E508
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxErrorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxError'.");
			}
			return handle;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00010333 File Offset: 0x0000E533
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00010364 File Offset: 0x0000E564
		public IMaxErrorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxErrorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001039C File Offset: 0x0000E59C
		private static Delegate GetGetAdLoadFailureInfoHandler()
		{
			if (IMaxErrorInvoker.cb_getAdLoadFailureInfo == null)
			{
				IMaxErrorInvoker.cb_getAdLoadFailureInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxErrorInvoker.n_GetAdLoadFailureInfo));
			}
			return IMaxErrorInvoker.cb_getAdLoadFailureInfo;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000103C0 File Offset: 0x0000E5C0
		private static IntPtr n_GetAdLoadFailureInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdLoadFailureInfo);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x000103D4 File Offset: 0x0000E5D4
		public string AdLoadFailureInfo
		{
			get
			{
				if (this.id_getAdLoadFailureInfo == IntPtr.Zero)
				{
					this.id_getAdLoadFailureInfo = JNIEnv.GetMethodID(this.class_ref, "getAdLoadFailureInfo", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdLoadFailureInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00010425 File Offset: 0x0000E625
		private static Delegate GetGetCodeHandler()
		{
			if (IMaxErrorInvoker.cb_getCode == null)
			{
				IMaxErrorInvoker.cb_getCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMaxErrorInvoker.n_GetCode));
			}
			return IMaxErrorInvoker.cb_getCode;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00010449 File Offset: 0x0000E649
		private static int n_GetCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Code;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00010458 File Offset: 0x0000E658
		public int Code
		{
			get
			{
				if (this.id_getCode == IntPtr.Zero)
				{
					this.id_getCode = JNIEnv.GetMethodID(this.class_ref, "getCode", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getCode);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00010498 File Offset: 0x0000E698
		private static Delegate GetGetMessageHandler()
		{
			if (IMaxErrorInvoker.cb_getMessage == null)
			{
				IMaxErrorInvoker.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxErrorInvoker.n_GetMessage));
			}
			return IMaxErrorInvoker.cb_getMessage;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000104BC File Offset: 0x0000E6BC
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x000104D0 File Offset: 0x0000E6D0
		public string Message
		{
			get
			{
				if (this.id_getMessage == IntPtr.Zero)
				{
					this.id_getMessage = JNIEnv.GetMethodID(this.class_ref, "getMessage", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00010521 File Offset: 0x0000E721
		private static Delegate GetGetWaterfallHandler()
		{
			if (IMaxErrorInvoker.cb_getWaterfall == null)
			{
				IMaxErrorInvoker.cb_getWaterfall = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxErrorInvoker.n_GetWaterfall));
			}
			return IMaxErrorInvoker.cb_getWaterfall;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00010545 File Offset: 0x0000E745
		private static IntPtr n_GetWaterfall(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxError>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Waterfall);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001055C File Offset: 0x0000E75C
		public IMaxAdWaterfallInfo Waterfall
		{
			get
			{
				if (this.id_getWaterfall == IntPtr.Zero)
				{
					this.id_getWaterfall = JNIEnv.GetMethodID(this.class_ref, "getWaterfall", "()Lcom/applovin/mediation/MaxAdWaterfallInfo;");
				}
				return Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getWaterfall), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400020E RID: 526
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxError", typeof(IMaxErrorInvoker));

		// Token: 0x0400020F RID: 527
		private IntPtr class_ref;

		// Token: 0x04000210 RID: 528
		private static Delegate cb_getAdLoadFailureInfo;

		// Token: 0x04000211 RID: 529
		private IntPtr id_getAdLoadFailureInfo;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_getCode;

		// Token: 0x04000213 RID: 531
		private IntPtr id_getCode;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_getMessage;

		// Token: 0x04000215 RID: 533
		private IntPtr id_getMessage;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_getWaterfall;

		// Token: 0x04000217 RID: 535
		private IntPtr id_getWaterfall;
	}
}
