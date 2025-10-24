using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Kotlin.Sequences;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200007C RID: 124
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/NonCancellable", DoNotGenerateAcw = true)]
	public sealed class NonCancellable : AbstractCoroutineContextElement, IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001300C File Offset: 0x0001120C
		[Register("INSTANCE")]
		public static NonCancellable Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<NonCancellable>(NonCancellable._members.StaticFields.GetObjectValue("INSTANCE.Lkotlinx/coroutines/NonCancellable;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001303C File Offset: 0x0001123C
		internal static IntPtr class_ref
		{
			get
			{
				return NonCancellable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00013060 File Offset: 0x00011260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NonCancellable._members;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00013068 File Offset: 0x00011268
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NonCancellable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001308C File Offset: 0x0001128C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NonCancellable._members.ManagedPeerType;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00013098 File Offset: 0x00011298
		internal NonCancellable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000130A4 File Offset: 0x000112A4
		[Obsolete("deprecated")]
		public CancellationException CancellationException
		{
			[Register("getCancellationException", "()Ljava/util/concurrent/CancellationException;", "")]
			get
			{
				return Java.Lang.Object.GetObject<CancellationException>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("getCancellationException.()Ljava/util/concurrent/CancellationException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x000130D8 File Offset: 0x000112D8
		[Obsolete("deprecated")]
		public ISequence Children
		{
			[Register("getChildren", "()Lkotlin/sequences/Sequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISequence>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("getChildren.()Lkotlin/sequences/Sequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001310A File Offset: 0x0001130A
		[Obsolete("deprecated")]
		public bool IsActive
		{
			[Register("isActive", "()Z", "")]
			get
			{
				return NonCancellable._members.InstanceMethods.InvokeAbstractBooleanMethod("isActive.()Z", this, null);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00013123 File Offset: 0x00011323
		[Obsolete("deprecated")]
		public bool IsCancelled
		{
			[Register("isCancelled", "()Z", "")]
			get
			{
				return NonCancellable._members.InstanceMethods.InvokeAbstractBooleanMethod("isCancelled.()Z", this, null);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001313C File Offset: 0x0001133C
		[Obsolete("deprecated")]
		public bool IsCompleted
		{
			[Register("isCompleted", "()Z", "")]
			get
			{
				return NonCancellable._members.InstanceMethods.InvokeAbstractBooleanMethod("isCompleted.()Z", this, null);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00013158 File Offset: 0x00011358
		[Obsolete("deprecated")]
		public ISelectClause0 OnJoin
		{
			[Register("getOnJoin", "()Lkotlinx/coroutines/selects/SelectClause0;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISelectClause0>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("getOnJoin.()Lkotlinx/coroutines/selects/SelectClause0;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001318C File Offset: 0x0001138C
		[Nullable(2)]
		[Obsolete("deprecated")]
		public IJob Parent
		{
			[NullableContext(2)]
			[Register("getParent", "()Lkotlinx/coroutines/Job;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IJob>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("getParent.()Lkotlinx/coroutines/Job;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000131C0 File Offset: 0x000113C0
		[Obsolete("deprecated")]
		[Register("attachChild", "(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;", "")]
		public unsafe IChildHandle AttachChild(IChildJob child)
		{
			IChildHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : ((Java.Lang.Object)child).Handle);
				@object = Java.Lang.Object.GetObject<IChildHandle>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("attachChild.(Lkotlinx/coroutines/ChildJob;)Lkotlinx/coroutines/ChildHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return @object;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00013238 File Offset: 0x00011438
		[NullableContext(2)]
		[Obsolete("deprecated")]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe void Cancel(CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				NonCancellable._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.(Ljava/util/concurrent/CancellationException;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001329C File Offset: 0x0001149C
		[Obsolete("deprecated")]
		[Register("invokeOnCompletion", "(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe IDisposableHandle InvokeOnCompletion(bool onCancelling, bool invokeImmediately, IFunction1 handler)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(onCancelling);
				ptr[1] = new JniArgumentValue(invokeImmediately);
				ptr[2] = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("invokeOnCompletion.(ZZLkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
			return @object;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00013340 File Offset: 0x00011540
		[Obsolete("deprecated")]
		[Register("invokeOnCompletion", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", "")]
		public unsafe IDisposableHandle InvokeOnCompletion(IFunction1 handler)
		{
			IDisposableHandle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				@object = Java.Lang.Object.GetObject<IDisposableHandle>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("invokeOnCompletion.(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/DisposableHandle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
			return @object;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000133B8 File Offset: 0x000115B8
		[Obsolete("deprecated")]
		[Register("join", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Join(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("join.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00013430 File Offset: 0x00011630
		[Obsolete("deprecated")]
		[Register("plus", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", "")]
		public unsafe IJob Plus(IJob other)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(NonCancellable._members.InstanceMethods.InvokeAbstractObjectMethod("plus.(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/Job;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000134A8 File Offset: 0x000116A8
		[Obsolete("deprecated")]
		[Register("start", "()Z", "")]
		public bool Start()
		{
			return NonCancellable._members.InstanceMethods.InvokeAbstractBooleanMethod("start.()Z", this, null);
		}

		// Token: 0x04000206 RID: 518
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/NonCancellable", typeof(NonCancellable));
	}
}
