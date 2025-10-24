using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Domain.Task;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain
{
	// Token: 0x02000100 RID: 256
	[Register("com/unity3d/services/core/domain/ResultExtensionsKt", DoNotGenerateAcw = true)]
	public sealed class ResultExtensionsKt : Java.Lang.Object
	{
		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0001D588 File Offset: 0x0001B788
		internal static IntPtr class_ref
		{
			get
			{
				return ResultExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0001D5AC File Offset: 0x0001B7AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultExtensionsKt._members;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0001D5B4 File Offset: 0x0001B7B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResultExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultExtensionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ResultExtensionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001D5E4 File Offset: 0x0001B7E4
		[Register("getInitializationExceptionOrNull", "(Ljava/lang/Object;)Lcom/unity3d/services/core/domain/task/InitializationException;", "")]
		public unsafe static InitializationException GetInitializationExceptionOrNull(Java.Lang.Object obj)
		{
			InitializationException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<InitializationException>(ResultExtensionsKt._members.StaticMethods.InvokeObjectMethod("getInitializationExceptionOrNull.(Ljava/lang/Object;)Lcom/unity3d/services/core/domain/task/InitializationException;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0001D658 File Offset: 0x0001B858
		[Register("getInitializationExceptionOrThrow", "(Ljava/lang/Object;)Lcom/unity3d/services/core/domain/task/InitializationException;", "")]
		public unsafe static InitializationException GetInitializationExceptionOrThrow(Java.Lang.Object obj)
		{
			InitializationException @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<InitializationException>(ResultExtensionsKt._members.StaticMethods.InvokeObjectMethod("getInitializationExceptionOrThrow.(Ljava/lang/Object;)Lcom/unity3d/services/core/domain/task/InitializationException;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000266 RID: 614
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/ResultExtensionsKt", typeof(ResultExtensionsKt));
	}
}
