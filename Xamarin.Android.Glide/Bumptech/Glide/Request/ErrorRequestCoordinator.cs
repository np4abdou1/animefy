using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000088 RID: 136
	[Register("com/bumptech/glide/request/ErrorRequestCoordinator", DoNotGenerateAcw = true)]
	public sealed class ErrorRequestCoordinator : Java.Lang.Object, IRequest, IJavaObject, IDisposable, IJavaPeerable, IRequestCoordinator
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000155E4 File Offset: 0x000137E4
		internal static IntPtr class_ref
		{
			get
			{
				return ErrorRequestCoordinator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00015608 File Offset: 0x00013808
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ErrorRequestCoordinator._members;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00015610 File Offset: 0x00013810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ErrorRequestCoordinator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00015634 File Offset: 0x00013834
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ErrorRequestCoordinator._members.ManagedPeerType;
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00015640 File Offset: 0x00013840
		internal ErrorRequestCoordinator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001564C File Offset: 0x0001384C
		[Register(".ctor", "(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", "")]
		public unsafe ErrorRequestCoordinator(Java.Lang.Object requestLock, IRequestCoordinator parent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestLock == null) ? IntPtr.Zero : requestLock.Handle);
				ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				base.SetHandle(ErrorRequestCoordinator._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ErrorRequestCoordinator._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;Lcom/bumptech/glide/request/RequestCoordinator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(requestLock);
				GC.KeepAlive(parent);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00015728 File Offset: 0x00013928
		public bool IsAnyResourceSet
		{
			[Register("isAnyResourceSet", "()Z", "")]
			get
			{
				return ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("isAnyResourceSet.()Z", this, null);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00015741 File Offset: 0x00013941
		public bool IsCleared
		{
			[Register("isCleared", "()Z", "")]
			get
			{
				return ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("isCleared.()Z", this, null);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001575A File Offset: 0x0001395A
		public bool IsComplete
		{
			[Register("isComplete", "()Z", "")]
			get
			{
				return ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("isComplete.()Z", this, null);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00015773 File Offset: 0x00013973
		public bool IsRunning
		{
			[Register("isRunning", "()Z", "")]
			get
			{
				return ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("isRunning.()Z", this, null);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001578C File Offset: 0x0001398C
		public IRequestCoordinator Root
		{
			[Register("getRoot", "()Lcom/bumptech/glide/request/RequestCoordinator;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IRequestCoordinator>(ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractObjectMethod("getRoot.()Lcom/bumptech/glide/request/RequestCoordinator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000157BE File Offset: 0x000139BE
		[Register("begin", "()V", "")]
		public void Begin()
		{
			ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("begin.()V", this, null);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000157D8 File Offset: 0x000139D8
		[Register("canNotifyCleared", "(Lcom/bumptech/glide/request/Request;)Z", "")]
		public unsafe bool CanNotifyCleared(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("canNotifyCleared.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00015844 File Offset: 0x00013A44
		[Register("canNotifyStatusChanged", "(Lcom/bumptech/glide/request/Request;)Z", "")]
		public unsafe bool CanNotifyStatusChanged(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("canNotifyStatusChanged.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000158B0 File Offset: 0x00013AB0
		[Register("canSetImage", "(Lcom/bumptech/glide/request/Request;)Z", "")]
		public unsafe bool CanSetImage(IRequest request)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				result = ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("canSetImage.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
			return result;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001591C File Offset: 0x00013B1C
		[Register("clear", "()V", "")]
		public void Clear()
		{
			ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00015938 File Offset: 0x00013B38
		[Register("isEquivalentTo", "(Lcom/bumptech/glide/request/Request;)Z", "")]
		public unsafe bool IsEquivalentTo(IRequest o)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : ((Java.Lang.Object)o).Handle);
				result = ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractBooleanMethod("isEquivalentTo.(Lcom/bumptech/glide/request/Request;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return result;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000159A4 File Offset: 0x00013BA4
		[Register("onRequestFailed", "(Lcom/bumptech/glide/request/Request;)V", "")]
		public unsafe void OnRequestFailed(IRequest request)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("onRequestFailed.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00015A0C File Offset: 0x00013C0C
		[Register("onRequestSuccess", "(Lcom/bumptech/glide/request/Request;)V", "")]
		public unsafe void OnRequestSuccess(IRequest request)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((request == null) ? IntPtr.Zero : ((Java.Lang.Object)request).Handle);
				ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("onRequestSuccess.(Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(request);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00015A74 File Offset: 0x00013C74
		[Register("pause", "()V", "")]
		public void Pause()
		{
			ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("pause.()V", this, null);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00015A90 File Offset: 0x00013C90
		[Register("setRequests", "(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V", "")]
		public unsafe void SetRequests(IRequest primary, IRequest error)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((primary == null) ? IntPtr.Zero : ((Java.Lang.Object)primary).Handle);
				ptr[1] = new JniArgumentValue((error == null) ? IntPtr.Zero : ((Java.Lang.Object)error).Handle);
				ErrorRequestCoordinator._members.InstanceMethods.InvokeAbstractVoidMethod("setRequests.(Lcom/bumptech/glide/request/Request;Lcom/bumptech/glide/request/Request;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(primary);
				GC.KeepAlive(error);
			}
		}

		// Token: 0x04000180 RID: 384
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/ErrorRequestCoordinator", typeof(ErrorRequestCoordinator));
	}
}
