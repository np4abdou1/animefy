using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Firebase.Encoders;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200000F RID: 15
	[Register("com/google/android/datatransport/cct/internal/BatchedLogRequest", DoNotGenerateAcw = true)]
	public abstract class BatchedLogRequest : Java.Lang.Object
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000036F4 File Offset: 0x000018F4
		internal static IntPtr class_ref
		{
			get
			{
				return BatchedLogRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003718 File Offset: 0x00001918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BatchedLogRequest._members;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003720 File Offset: 0x00001920
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BatchedLogRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003744 File Offset: 0x00001944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BatchedLogRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000020B4 File Offset: 0x000002B4
		protected BatchedLogRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003750 File Offset: 0x00001950
		[Register(".ctor", "()V", "")]
		public BatchedLogRequest() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BatchedLogRequest._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BatchedLogRequest._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000037BE File Offset: 0x000019BE
		private static Delegate GetGetLogRequestsHandler()
		{
			if (BatchedLogRequest.cb_getLogRequests == null)
			{
				BatchedLogRequest.cb_getLogRequests = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BatchedLogRequest.n_GetLogRequests));
			}
			return BatchedLogRequest.cb_getLogRequests;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000037E2 File Offset: 0x000019E2
		private static IntPtr n_GetLogRequests(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<LogRequest>.ToLocalJniHandle(Java.Lang.Object.GetObject<BatchedLogRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LogRequests);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BA RID: 186
		public abstract IList<LogRequest> LogRequests { [Register("getLogRequests", "()Ljava/util/List;", "GetGetLogRequestsHandler")] get; }

		// Token: 0x060000BB RID: 187 RVA: 0x000037F8 File Offset: 0x000019F8
		[Register("create", "(Ljava/util/List;)Lcom/google/android/datatransport/cct/internal/BatchedLogRequest;", "")]
		public unsafe static BatchedLogRequest Create(IList<LogRequest> logRequests)
		{
			IntPtr intPtr = JavaList<LogRequest>.ToLocalJniHandle(logRequests);
			BatchedLogRequest @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BatchedLogRequest>(BatchedLogRequest._members.StaticMethods.InvokeObjectMethod("create.(Ljava/util/List;)Lcom/google/android/datatransport/cct/internal/BatchedLogRequest;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(logRequests);
			}
			return @object;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003868 File Offset: 0x00001A68
		[Register("createDataEncoder", "()Lcom/google/firebase/encoders/DataEncoder;", "")]
		public static IDataEncoder CreateDataEncoder()
		{
			return Java.Lang.Object.GetObject<IDataEncoder>(BatchedLogRequest._members.StaticMethods.InvokeObjectMethod("createDataEncoder.()Lcom/google/firebase/encoders/DataEncoder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000022 RID: 34
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/BatchedLogRequest", typeof(BatchedLogRequest));

		// Token: 0x04000023 RID: 35
		private static Delegate cb_getLogRequests;
	}
}
