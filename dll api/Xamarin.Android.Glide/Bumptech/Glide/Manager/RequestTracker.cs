using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000082 RID: 130
	[Register("com/bumptech/glide/manager/RequestTracker", DoNotGenerateAcw = true)]
	public class RequestTracker : Java.Lang.Object
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00011F54 File Offset: 0x00010154
		internal static IntPtr class_ref
		{
			get
			{
				return RequestTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00011F78 File Offset: 0x00010178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestTracker._members;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00011F80 File Offset: 0x00010180
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00011FA4 File Offset: 0x000101A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestTracker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00011FB0 File Offset: 0x000101B0
		protected RequestTracker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00011FBC File Offset: 0x000101BC
		[Register(".ctor", "()V", "")]
		public RequestTracker() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(RequestTracker._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			RequestTracker._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0001202A File Offset: 0x0001022A
		private static Delegate GetIsPausedHandler()
		{
			if (RequestTracker.cb_isPaused == null)
			{
				RequestTracker.cb_isPaused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RequestTracker.n_IsPaused));
			}
			return RequestTracker.cb_isPaused;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0001204E File Offset: 0x0001024E
		private static bool n_IsPaused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsPaused;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001205D File Offset: 0x0001025D
		public virtual bool IsPaused
		{
			[Register("isPaused", "()Z", "GetIsPausedHandler")]
			get
			{
				return RequestTracker._members.InstanceMethods.InvokeVirtualBooleanMethod("isPaused.()Z", this, null);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00012076 File Offset: 0x00010276
		private static Delegate GetClearAndRemove_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (RequestTracker.cb_clearAndRemove_Lcom_bumptech_glide_request_Request_ == null)
			{
				RequestTracker.cb_clearAndRemove_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RequestTracker.n_ClearAndRemove_Lcom_bumptech_glide_request_Request_));
			}
			return RequestTracker.cb_clearAndRemove_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0001209C File Offset: 0x0001029C
		private static bool n_ClearAndRemove_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			RequestTracker @object = Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			return @object.ClearAndRemove(object2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000120C0 File Offset: 0x000102C0
		[Register("clearAndRemove", "(Lcom/bumptech/glide/request/Request;)Z", "GetClearAndRemove_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual bool ClearAndRemove(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = RequestTracker._members.InstanceMethods.InvokeVirtualBooleanMethod("clearAndRemove.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0001212C File Offset: 0x0001032C
		private static Delegate GetClearRequestsHandler()
		{
			if (RequestTracker.cb_clearRequests == null)
			{
				RequestTracker.cb_clearRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestTracker.n_ClearRequests));
			}
			return RequestTracker.cb_clearRequests;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00012150 File Offset: 0x00010350
		private static void n_ClearRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearRequests();
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001215F File Offset: 0x0001035F
		[Register("clearRequests", "()V", "GetClearRequestsHandler")]
		public virtual void ClearRequests()
		{
			RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("clearRequests.()V", this, null);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00012178 File Offset: 0x00010378
		private static Delegate GetPauseAllRequestsHandler()
		{
			if (RequestTracker.cb_pauseAllRequests == null)
			{
				RequestTracker.cb_pauseAllRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestTracker.n_PauseAllRequests));
			}
			return RequestTracker.cb_pauseAllRequests;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001219C File Offset: 0x0001039C
		private static void n_PauseAllRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseAllRequests();
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000121AB File Offset: 0x000103AB
		[Register("pauseAllRequests", "()V", "GetPauseAllRequestsHandler")]
		public virtual void PauseAllRequests()
		{
			RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("pauseAllRequests.()V", this, null);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000121C4 File Offset: 0x000103C4
		private static Delegate GetPauseRequestsHandler()
		{
			if (RequestTracker.cb_pauseRequests == null)
			{
				RequestTracker.cb_pauseRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestTracker.n_PauseRequests));
			}
			return RequestTracker.cb_pauseRequests;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000121E8 File Offset: 0x000103E8
		private static void n_PauseRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PauseRequests();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000121F7 File Offset: 0x000103F7
		[Register("pauseRequests", "()V", "GetPauseRequestsHandler")]
		public virtual void PauseRequests()
		{
			RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("pauseRequests.()V", this, null);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00012210 File Offset: 0x00010410
		private static Delegate GetRestartRequestsHandler()
		{
			if (RequestTracker.cb_restartRequests == null)
			{
				RequestTracker.cb_restartRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestTracker.n_RestartRequests));
			}
			return RequestTracker.cb_restartRequests;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00012234 File Offset: 0x00010434
		private static void n_RestartRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RestartRequests();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00012243 File Offset: 0x00010443
		[Register("restartRequests", "()V", "GetRestartRequestsHandler")]
		public virtual void RestartRequests()
		{
			RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("restartRequests.()V", this, null);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001225C File Offset: 0x0001045C
		private static Delegate GetResumeRequestsHandler()
		{
			if (RequestTracker.cb_resumeRequests == null)
			{
				RequestTracker.cb_resumeRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(RequestTracker.n_ResumeRequests));
			}
			return RequestTracker.cb_resumeRequests;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00012280 File Offset: 0x00010480
		private static void n_ResumeRequests(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResumeRequests();
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001228F File Offset: 0x0001048F
		[Register("resumeRequests", "()V", "GetResumeRequestsHandler")]
		public virtual void ResumeRequests()
		{
			RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("resumeRequests.()V", this, null);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000122A8 File Offset: 0x000104A8
		private static Delegate GetRunRequest_Lcom_bumptech_glide_request_Request_Handler()
		{
			if (RequestTracker.cb_runRequest_Lcom_bumptech_glide_request_Request_ == null)
			{
				RequestTracker.cb_runRequest_Lcom_bumptech_glide_request_Request_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(RequestTracker.n_RunRequest_Lcom_bumptech_glide_request_Request_));
			}
			return RequestTracker.cb_runRequest_Lcom_bumptech_glide_request_Request_;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000122CC File Offset: 0x000104CC
		private static void n_RunRequest_Lcom_bumptech_glide_request_Request_(IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			RequestTracker @object = Java.Lang.Object.GetObject<RequestTracker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IRequest object2 = Java.Lang.Object.GetObject<IRequest>(native_request, JniHandleOwnership.DoNotTransfer);
			@object.RunRequest(object2);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000122F0 File Offset: 0x000104F0
		[Register("runRequest", "(Lcom/bumptech/glide/request/Request;)V", "GetRunRequest_Lcom_bumptech_glide_request_Request_Handler")]
		public unsafe virtual void RunRequest(IRequest request)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				RequestTracker._members.InstanceMethods.InvokeVirtualVoidMethod("runRequest.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
		}

		// Token: 0x04000141 RID: 321
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/RequestTracker", typeof(RequestTracker));

		// Token: 0x04000142 RID: 322
		private static Delegate cb_isPaused;

		// Token: 0x04000143 RID: 323
		private static Delegate cb_clearAndRemove_Lcom_bumptech_glide_request_Request_;

		// Token: 0x04000144 RID: 324
		private static Delegate cb_clearRequests;

		// Token: 0x04000145 RID: 325
		private static Delegate cb_pauseAllRequests;

		// Token: 0x04000146 RID: 326
		private static Delegate cb_pauseRequests;

		// Token: 0x04000147 RID: 327
		private static Delegate cb_restartRequests;

		// Token: 0x04000148 RID: 328
		private static Delegate cb_resumeRequests;

		// Token: 0x04000149 RID: 329
		private static Delegate cb_runRequest_Lcom_bumptech_glide_request_Request_;
	}
}
