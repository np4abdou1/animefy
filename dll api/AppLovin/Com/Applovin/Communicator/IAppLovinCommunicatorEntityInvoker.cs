using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Communicator
{
	// Token: 0x02000175 RID: 373
	[Register("com/applovin/communicator/AppLovinCommunicatorEntity", DoNotGenerateAcw = true)]
	internal class IAppLovinCommunicatorEntityInvoker : Java.Lang.Object, IAppLovinCommunicatorEntity, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00033B74 File Offset: 0x00031D74
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinCommunicatorEntityInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00033B98 File Offset: 0x00031D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinCommunicatorEntityInvoker._members;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00033B9F File Offset: 0x00031D9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00033BA7 File Offset: 0x00031DA7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinCommunicatorEntityInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00033BB3 File Offset: 0x00031DB3
		public static IAppLovinCommunicatorEntity GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinCommunicatorEntity>(handle, transfer);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00033BBC File Offset: 0x00031DBC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinCommunicatorEntityInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.communicator.AppLovinCommunicatorEntity'.");
			}
			return handle;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00033BE7 File Offset: 0x00031DE7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00033C18 File Offset: 0x00031E18
		public IAppLovinCommunicatorEntityInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinCommunicatorEntityInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00033C50 File Offset: 0x00031E50
		private static Delegate GetGetCommunicatorIdHandler()
		{
			if (IAppLovinCommunicatorEntityInvoker.cb_getCommunicatorId == null)
			{
				IAppLovinCommunicatorEntityInvoker.cb_getCommunicatorId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAppLovinCommunicatorEntityInvoker.n_GetCommunicatorId));
			}
			return IAppLovinCommunicatorEntityInvoker.cb_getCommunicatorId;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00033C74 File Offset: 0x00031E74
		private static IntPtr n_GetCommunicatorId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAppLovinCommunicatorEntity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommunicatorId);
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00033C88 File Offset: 0x00031E88
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

		// Token: 0x040005DA RID: 1498
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/communicator/AppLovinCommunicatorEntity", typeof(IAppLovinCommunicatorEntityInvoker));

		// Token: 0x040005DB RID: 1499
		private IntPtr class_ref;

		// Token: 0x040005DC RID: 1500
		private static Delegate cb_getCommunicatorId;

		// Token: 0x040005DD RID: 1501
		private IntPtr id_getCommunicatorId;
	}
}
