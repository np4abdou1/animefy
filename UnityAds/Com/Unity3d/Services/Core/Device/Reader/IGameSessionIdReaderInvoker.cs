using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x0200013E RID: 318
	[Register("com/unity3d/services/core/device/reader/IGameSessionIdReader", DoNotGenerateAcw = true)]
	internal class IGameSessionIdReaderInvoker : Java.Lang.Object, IGameSessionIdReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00023A8C File Offset: 0x00021C8C
		private static IntPtr java_class_ref
		{
			get
			{
				return IGameSessionIdReaderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00023AB0 File Offset: 0x00021CB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IGameSessionIdReaderInvoker._members;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00023AB7 File Offset: 0x00021CB7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00023ABF File Offset: 0x00021CBF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IGameSessionIdReaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00023ACB File Offset: 0x00021CCB
		public static IGameSessionIdReader GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IGameSessionIdReader>(handle, transfer);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00023AD4 File Offset: 0x00021CD4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IGameSessionIdReaderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.device.reader.IGameSessionIdReader'.");
			}
			return handle;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00023AFF File Offset: 0x00021CFF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00023B30 File Offset: 0x00021D30
		public IGameSessionIdReaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IGameSessionIdReaderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00023B68 File Offset: 0x00021D68
		private static Delegate GetGetGameSessionIdHandler()
		{
			if (IGameSessionIdReaderInvoker.cb_getGameSessionId == null)
			{
				IGameSessionIdReaderInvoker.cb_getGameSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGameSessionIdReaderInvoker.n_GetGameSessionId));
			}
			return IGameSessionIdReaderInvoker.cb_getGameSessionId;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00023B8C File Offset: 0x00021D8C
		private static IntPtr n_GetGameSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGameSessionIdReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GameSessionId);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00023BA0 File Offset: 0x00021DA0
		public Long GameSessionId
		{
			get
			{
				if (this.id_getGameSessionId == IntPtr.Zero)
				{
					this.id_getGameSessionId = JNIEnv.GetMethodID(this.class_ref, "getGameSessionId", "()Ljava/lang/Long;");
				}
				return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGameSessionId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00023BF1 File Offset: 0x00021DF1
		private static Delegate GetGetGameSessionIdAndStoreHandler()
		{
			if (IGameSessionIdReaderInvoker.cb_getGameSessionIdAndStore == null)
			{
				IGameSessionIdReaderInvoker.cb_getGameSessionIdAndStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IGameSessionIdReaderInvoker.n_GetGameSessionIdAndStore));
			}
			return IGameSessionIdReaderInvoker.cb_getGameSessionIdAndStore;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00023C15 File Offset: 0x00021E15
		private static IntPtr n_GetGameSessionIdAndStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IGameSessionIdReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GameSessionIdAndStore);
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00023C2C File Offset: 0x00021E2C
		public Long GameSessionIdAndStore
		{
			get
			{
				if (this.id_getGameSessionIdAndStore == IntPtr.Zero)
				{
					this.id_getGameSessionIdAndStore = JNIEnv.GetMethodID(this.class_ref, "getGameSessionIdAndStore", "()Ljava/lang/Long;");
				}
				return Java.Lang.Object.GetObject<Long>(JNIEnv.CallObjectMethod(base.Handle, this.id_getGameSessionIdAndStore), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002E2 RID: 738
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/IGameSessionIdReader", typeof(IGameSessionIdReaderInvoker));

		// Token: 0x040002E3 RID: 739
		private IntPtr class_ref;

		// Token: 0x040002E4 RID: 740
		private static Delegate cb_getGameSessionId;

		// Token: 0x040002E5 RID: 741
		private IntPtr id_getGameSessionId;

		// Token: 0x040002E6 RID: 742
		private static Delegate cb_getGameSessionIdAndStore;

		// Token: 0x040002E7 RID: 743
		private IntPtr id_getGameSessionIdAndStore;
	}
}
