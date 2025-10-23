using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x0200004B RID: 75
	[Register("com/unity3d/services/store/gpbl/IBillingResponse", DoNotGenerateAcw = true)]
	internal class IBillingResponseInvoker : Java.Lang.Object, IBillingResponse, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00004468 File Offset: 0x00002668
		private static IntPtr java_class_ref
		{
			get
			{
				return IBillingResponseInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000448C File Offset: 0x0000268C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBillingResponseInvoker._members;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00004493 File Offset: 0x00002693
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000449B File Offset: 0x0000269B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBillingResponseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000044A7 File Offset: 0x000026A7
		public static IBillingResponse GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBillingResponse>(handle, transfer);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000044B0 File Offset: 0x000026B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBillingResponseInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.store.gpbl.IBillingResponse'.");
			}
			return handle;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000044DB File Offset: 0x000026DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000450C File Offset: 0x0000270C
		public IBillingResponseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBillingResponseInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004544 File Offset: 0x00002744
		private static Delegate GetGetOriginalJsonHandler()
		{
			if (IBillingResponseInvoker.cb_getOriginalJson == null)
			{
				IBillingResponseInvoker.cb_getOriginalJson = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBillingResponseInvoker.n_GetOriginalJson));
			}
			return IBillingResponseInvoker.cb_getOriginalJson;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004568 File Offset: 0x00002768
		private static IntPtr n_GetOriginalJson(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBillingResponse>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OriginalJson);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000457C File Offset: 0x0000277C
		public JSONObject OriginalJson
		{
			get
			{
				if (this.id_getOriginalJson == IntPtr.Zero)
				{
					this.id_getOriginalJson = JNIEnv.GetMethodID(this.class_ref, "getOriginalJson", "()Lorg/json/JSONObject;");
				}
				return Java.Lang.Object.GetObject<JSONObject>(JNIEnv.CallObjectMethod(base.Handle, this.id_getOriginalJson), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/IBillingResponse", typeof(IBillingResponseInvoker));

		// Token: 0x04000031 RID: 49
		private IntPtr class_ref;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_getOriginalJson;

		// Token: 0x04000033 RID: 51
		private IntPtr id_getOriginalJson;
	}
}
