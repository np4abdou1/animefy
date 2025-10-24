using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001B RID: 27
	[Register("com/google/android/gms/common/api/Result", DoNotGenerateAcw = true)]
	internal class IResultInvoker : Java.Lang.Object, IResult, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000032A0 File Offset: 0x000014A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IResultInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000032C4 File Offset: 0x000014C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResultInvoker._members;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000032CB File Offset: 0x000014CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000032D3 File Offset: 0x000014D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000032DF File Offset: 0x000014DF
		public static IResult GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResult>(handle, transfer);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000032E8 File Offset: 0x000014E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResultInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Result'.");
			}
			return handle;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003313 File Offset: 0x00001513
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003344 File Offset: 0x00001544
		public IResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResultInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000337C File Offset: 0x0000157C
		private static Delegate GetGetStatusHandler()
		{
			if (IResultInvoker.cb_getStatus == null)
			{
				IResultInvoker.cb_getStatus = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IResultInvoker.n_GetStatus));
			}
			return IResultInvoker.cb_getStatus;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000033A0 File Offset: 0x000015A0
		private static IntPtr n_GetStatus(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Status);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000033B4 File Offset: 0x000015B4
		public Statuses Status
		{
			get
			{
				if (this.id_getStatus == IntPtr.Zero)
				{
					this.id_getStatus = JNIEnv.GetMethodID(this.class_ref, "getStatus", "()Lcom/google/android/gms/common/api/Status;");
				}
				return Java.Lang.Object.GetObject<Statuses>(JNIEnv.CallObjectMethod(base.Handle, this.id_getStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Result", typeof(IResultInvoker));

		// Token: 0x0400001D RID: 29
		private IntPtr class_ref;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_getStatus;

		// Token: 0x0400001F RID: 31
		private IntPtr id_getStatus;
	}
}
