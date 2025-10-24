using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x0200038C RID: 908
	[Register("java/nio/file/WatchKey", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IWatchKeyInvoker : Java.Lang.Object, IWatchKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x00072050 File Offset: 0x00070250
		private static IntPtr java_class_ref
		{
			get
			{
				return IWatchKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x00072074 File Offset: 0x00070274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWatchKeyInvoker._members;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x0007207B File Offset: 0x0007027B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x00072083 File Offset: 0x00070283
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWatchKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x0007208F File Offset: 0x0007028F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWatchKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.WatchKey'.");
			}
			return handle;
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000720BA File Offset: 0x000702BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000720EC File Offset: 0x000702EC
		public IWatchKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWatchKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00072124 File Offset: 0x00070324
		private static Delegate GetIsValidHandler()
		{
			if (IWatchKeyInvoker.cb_isValid == null)
			{
				IWatchKeyInvoker.cb_isValid = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWatchKeyInvoker.n_IsValid));
			}
			return IWatchKeyInvoker.cb_isValid;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00072148 File Offset: 0x00070348
		private static bool n_IsValid(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWatchKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsValid;
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x00072157 File Offset: 0x00070357
		public bool IsValid
		{
			get
			{
				if (this.id_isValid == IntPtr.Zero)
				{
					this.id_isValid = JNIEnv.GetMethodID(this.class_ref, "isValid", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isValid);
			}
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00072197 File Offset: 0x00070397
		private static Delegate GetCancelHandler()
		{
			if (IWatchKeyInvoker.cb_cancel == null)
			{
				IWatchKeyInvoker.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IWatchKeyInvoker.n_Cancel));
			}
			return IWatchKeyInvoker.cb_cancel;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000721BB File Offset: 0x000703BB
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IWatchKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000721CA File Offset: 0x000703CA
		public void Cancel()
		{
			if (this.id_cancel == IntPtr.Zero)
			{
				this.id_cancel = JNIEnv.GetMethodID(this.class_ref, "cancel", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cancel);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0007220A File Offset: 0x0007040A
		private static Delegate GetPollEventsHandler()
		{
			if (IWatchKeyInvoker.cb_pollEvents == null)
			{
				IWatchKeyInvoker.cb_pollEvents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchKeyInvoker.n_PollEvents));
			}
			return IWatchKeyInvoker.cb_pollEvents;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0007222E File Offset: 0x0007042E
		private static IntPtr n_PollEvents(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IWatchEvent>.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PollEvents());
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00072244 File Offset: 0x00070444
		public IList<IWatchEvent> PollEvents()
		{
			if (this.id_pollEvents == IntPtr.Zero)
			{
				this.id_pollEvents = JNIEnv.GetMethodID(this.class_ref, "pollEvents", "()Ljava/util/List;");
			}
			return JavaList<IWatchEvent>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_pollEvents), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00072295 File Offset: 0x00070495
		private static Delegate GetResetHandler()
		{
			if (IWatchKeyInvoker.cb_reset == null)
			{
				IWatchKeyInvoker.cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWatchKeyInvoker.n_Reset));
			}
			return IWatchKeyInvoker.cb_reset;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x000722B9 File Offset: 0x000704B9
		private static bool n_Reset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWatchKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset();
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000722C8 File Offset: 0x000704C8
		public bool Reset()
		{
			if (this.id_reset == IntPtr.Zero)
			{
				this.id_reset = JNIEnv.GetMethodID(this.class_ref, "reset", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_reset);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00072308 File Offset: 0x00070508
		private static Delegate GetWatchableHandler()
		{
			if (IWatchKeyInvoker.cb_watchable == null)
			{
				IWatchKeyInvoker.cb_watchable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWatchKeyInvoker.n_Watchable));
			}
			return IWatchKeyInvoker.cb_watchable;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0007232C File Offset: 0x0007052C
		private static IntPtr n_Watchable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWatchKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Watchable());
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00072340 File Offset: 0x00070540
		public IWatchable Watchable()
		{
			if (this.id_watchable == IntPtr.Zero)
			{
				this.id_watchable = JNIEnv.GetMethodID(this.class_ref, "watchable", "()Ljava/nio/file/Watchable;");
			}
			return Java.Lang.Object.GetObject<IWatchable>(JNIEnv.CallObjectMethod(base.Handle, this.id_watchable), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001081 RID: 4225
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/WatchKey", typeof(IWatchKeyInvoker));

		// Token: 0x04001082 RID: 4226
		private IntPtr class_ref;

		// Token: 0x04001083 RID: 4227
		private static Delegate cb_isValid;

		// Token: 0x04001084 RID: 4228
		private IntPtr id_isValid;

		// Token: 0x04001085 RID: 4229
		private static Delegate cb_cancel;

		// Token: 0x04001086 RID: 4230
		private IntPtr id_cancel;

		// Token: 0x04001087 RID: 4231
		private static Delegate cb_pollEvents;

		// Token: 0x04001088 RID: 4232
		private IntPtr id_pollEvents;

		// Token: 0x04001089 RID: 4233
		private static Delegate cb_reset;

		// Token: 0x0400108A RID: 4234
		private IntPtr id_reset;

		// Token: 0x0400108B RID: 4235
		private static Delegate cb_watchable;

		// Token: 0x0400108C RID: 4236
		private IntPtr id_watchable;
	}
}
