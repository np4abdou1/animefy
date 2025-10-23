using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000B7 RID: 183
	[Register("com/unity3d/services/core/request/WebRequestRunnable", DoNotGenerateAcw = true)]
	public class WebRequestRunnable : Java.Lang.Object, IRunnable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00012824 File Offset: 0x00010A24
		internal static IntPtr class_ref
		{
			get
			{
				return WebRequestRunnable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00012848 File Offset: 0x00010A48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebRequestRunnable._members;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00012850 File Offset: 0x00010A50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebRequestRunnable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00012874 File Offset: 0x00010A74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebRequestRunnable._members.ManagedPeerType;
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebRequestRunnable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00012880 File Offset: 0x00010A80
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/util/Map;Lcom/unity3d/services/core/request/IWebRequestListener;)V", "")]
		public unsafe WebRequestRunnable(string url, string type, string body, int connectTimeout, int readTimeout, IDictionary<string, IList<string>> headers, IWebRequestListener listener) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(type);
			IntPtr intPtr3 = JNIEnv.NewString(body);
			IntPtr intPtr4 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(connectTimeout);
				ptr[4] = new JniArgumentValue(readTimeout);
				ptr[5] = new JniArgumentValue(intPtr4);
				ptr[6] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				base.SetHandle(WebRequestRunnable._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/util/Map;Lcom/unity3d/services/core/request/IWebRequestListener;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebRequestRunnable._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IILjava/util/Map;Lcom/unity3d/services/core/request/IWebRequestListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(headers);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00012A00 File Offset: 0x00010C00
		private static Delegate GetRunHandler()
		{
			if (WebRequestRunnable.cb_run == null)
			{
				WebRequestRunnable.cb_run = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebRequestRunnable.n_Run));
			}
			return WebRequestRunnable.cb_run;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00012A24 File Offset: 0x00010C24
		private static void n_Run(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebRequestRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Run();
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00012A33 File Offset: 0x00010C33
		[Register("run", "()V", "GetRunHandler")]
		public virtual void Run()
		{
			WebRequestRunnable._members.InstanceMethods.InvokeVirtualVoidMethod("run.()V", this, null);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00012A4C File Offset: 0x00010C4C
		private static Delegate GetSetCancelStatus_ZHandler()
		{
			if (WebRequestRunnable.cb_setCancelStatus_Z == null)
			{
				WebRequestRunnable.cb_setCancelStatus_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebRequestRunnable.n_SetCancelStatus_Z));
			}
			return WebRequestRunnable.cb_setCancelStatus_Z;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00012A70 File Offset: 0x00010C70
		private static void n_SetCancelStatus_Z(IntPtr jnienv, IntPtr native__this, bool canceled)
		{
			Java.Lang.Object.GetObject<WebRequestRunnable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCancelStatus(canceled);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00012A80 File Offset: 0x00010C80
		[Register("setCancelStatus", "(Z)V", "GetSetCancelStatus_ZHandler")]
		public unsafe virtual void SetCancelStatus(bool canceled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(canceled);
			WebRequestRunnable._members.InstanceMethods.InvokeVirtualVoidMethod("setCancelStatus.(Z)V", this, ptr);
		}

		// Token: 0x0400019D RID: 413
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequestRunnable", typeof(WebRequestRunnable));

		// Token: 0x0400019E RID: 414
		private static Delegate cb_run;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_setCancelStatus_Z;
	}
}
