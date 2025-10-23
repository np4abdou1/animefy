using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000179 RID: 377
	[Register("com/applovin/communicator/AppLovinCommunicatorPublisher", DoNotGenerateAcw = true)]
	internal class IAppLovinCommunicatorPublisherInvoker : Java.Lang.Object, IAppLovinCommunicatorPublisher, IAppLovinCommunicatorEntity, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00033EA8 File Offset: 0x000320A8
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinCommunicatorPublisherInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00033ECC File Offset: 0x000320CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinCommunicatorPublisherInvoker._members;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00033ED3 File Offset: 0x000320D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00033EDB File Offset: 0x000320DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinCommunicatorPublisherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00033EE7 File Offset: 0x000320E7
		public static IAppLovinCommunicatorPublisher GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinCommunicatorPublisher>(handle, transfer);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00033EF0 File Offset: 0x000320F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinCommunicatorPublisherInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.communicator.AppLovinCommunicatorPublisher'.");
			}
			return handle;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00033F1B File Offset: 0x0003211B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00033F4C File Offset: 0x0003214C
		public IAppLovinCommunicatorPublisherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinCommunicatorPublisherInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00033F84 File Offset: 0x00032184
		private static Delegate GetGetCommunicatorIdHandler()
		{
			if (IAppLovinCommunicatorPublisherInvoker.cb_getCommunicatorId == null)
			{
				IAppLovinCommunicatorPublisherInvoker.cb_getCommunicatorId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinCommunicatorPublisherInvoker.n_GetCommunicatorId));
			}
			return IAppLovinCommunicatorPublisherInvoker.cb_getCommunicatorId;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00033FA8 File Offset: 0x000321A8
		private static IntPtr n_GetCommunicatorId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinCommunicatorPublisher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommunicatorId);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00033FBC File Offset: 0x000321BC
		public string CommunicatorId
		{
			get
			{
				if (this.id_getCommunicatorId == IntPtr.Zero)
				{
					this.id_getCommunicatorId = JNIEnv.GetMethodID(this.class_ref, "getCommunicatorId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getCommunicatorId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040005E2 RID: 1506
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicatorPublisher", typeof(IAppLovinCommunicatorPublisherInvoker));

		// Token: 0x040005E3 RID: 1507
		private IntPtr class_ref;

		// Token: 0x040005E4 RID: 1508
		private static Delegate cb_getCommunicatorId;

		// Token: 0x040005E5 RID: 1509
		private IntPtr id_getCommunicatorId;
	}
}
