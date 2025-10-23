using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x0200008D RID: 141
	[Register("com/bumptech/glide/request/RequestCoordinator$RequestState", DoNotGenerateAcw = true)]
	public sealed class RequestCoordinatorRequestState : Java.Lang.Enum
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00016B44 File Offset: 0x00014D44
		[Register("CLEARED")]
		public static RequestCoordinatorRequestState Cleared
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticFields.GetObjectValue("CLEARED.Lcom/bumptech/glide/request/RequestCoordinator$RequestState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00016B74 File Offset: 0x00014D74
		[Register("FAILED")]
		public static RequestCoordinatorRequestState Failed
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticFields.GetObjectValue("FAILED.Lcom/bumptech/glide/request/RequestCoordinator$RequestState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00016BA4 File Offset: 0x00014DA4
		[Register("PAUSED")]
		public static RequestCoordinatorRequestState Paused
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticFields.GetObjectValue("PAUSED.Lcom/bumptech/glide/request/RequestCoordinator$RequestState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00016BD4 File Offset: 0x00014DD4
		[Register("RUNNING")]
		public static RequestCoordinatorRequestState Running
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticFields.GetObjectValue("RUNNING.Lcom/bumptech/glide/request/RequestCoordinator$RequestState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00016C04 File Offset: 0x00014E04
		[Register("SUCCESS")]
		public static RequestCoordinatorRequestState Success
		{
			get
			{
				return Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticFields.GetObjectValue("SUCCESS.Lcom/bumptech/glide/request/RequestCoordinator$RequestState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00016C34 File Offset: 0x00014E34
		internal static IntPtr class_ref
		{
			get
			{
				return RequestCoordinatorRequestState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00016C58 File Offset: 0x00014E58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RequestCoordinatorRequestState._members;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00016C60 File Offset: 0x00014E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RequestCoordinatorRequestState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00016C84 File Offset: 0x00014E84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RequestCoordinatorRequestState._members.ManagedPeerType;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00016C90 File Offset: 0x00014E90
		internal RequestCoordinatorRequestState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00016C9C File Offset: 0x00014E9C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/bumptech/glide/request/RequestCoordinator$RequestState;", "")]
		public unsafe static RequestCoordinatorRequestState ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			RequestCoordinatorRequestState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<RequestCoordinatorRequestState>(RequestCoordinatorRequestState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/bumptech/glide/request/RequestCoordinator$RequestState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00016D08 File Offset: 0x00014F08
		[Register("values", "()[Lcom/bumptech/glide/request/RequestCoordinator$RequestState;", "")]
		public static RequestCoordinatorRequestState[] Values()
		{
			return (RequestCoordinatorRequestState[])JNIEnv.GetArray(RequestCoordinatorRequestState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/bumptech/glide/request/RequestCoordinator$RequestState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RequestCoordinatorRequestState));
		}

		// Token: 0x040001B5 RID: 437
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/RequestCoordinator$RequestState", typeof(RequestCoordinatorRequestState));
	}
}
