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
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C9 RID: 201
	[NullableContext(1)]
	[Nullable(0)]
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/channels/ConflatedBroadcastChannel", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public sealed class ConflatedBroadcastChannel : Java.Lang.Object, IBroadcastChannel, ISendChannel, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00021438 File Offset: 0x0001F638
		internal static IntPtr class_ref
		{
			get
			{
				return ConflatedBroadcastChannel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0002145C File Offset: 0x0001F65C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConflatedBroadcastChannel._members;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00021464 File Offset: 0x0001F664
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConflatedBroadcastChannel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00021488 File Offset: 0x0001F688
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConflatedBroadcastChannel._members.ManagedPeerType;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00021494 File Offset: 0x0001F694
		internal ConflatedBroadcastChannel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000214A0 File Offset: 0x0001F6A0
		[Register(".ctor", "()V", "")]
		public ConflatedBroadcastChannel() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ConflatedBroadcastChannel._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ConflatedBroadcastChannel._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00021510 File Offset: 0x0001F710
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe ConflatedBroadcastChannel(Java.Lang.Object value) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(ConflatedBroadcastChannel._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConflatedBroadcastChannel._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x000215BC File Offset: 0x0001F7BC
		public bool IsClosedForSend
		{
			[Register("isClosedForSend", "()Z", "")]
			get
			{
				return ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractBooleanMethod("isClosedForSend.()Z", this, null);
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x000215D8 File Offset: 0x0001F7D8
		public ISelectClause2 OnSend
		{
			[Register("getOnSend", "()Lkotlinx/coroutines/selects/SelectClause2;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISelectClause2>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractObjectMethod("getOnSend.()Lkotlinx/coroutines/selects/SelectClause2;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002160C File Offset: 0x0001F80C
		[Nullable(2)]
		public Java.Lang.Object Value
		{
			[NullableContext(2)]
			[Register("getValue", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValue.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00021640 File Offset: 0x0001F840
		[Nullable(2)]
		public Java.Lang.Object ValueOrNull
		{
			[NullableContext(2)]
			[Register("getValueOrNull", "()Ljava/lang/Object;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeNonvirtualObjectMethod("getValueOrNull.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00021674 File Offset: 0x0001F874
		[NullableContext(2)]
		[Register("cancel", "(Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe void Cancel(CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.(Ljava/util/concurrent/CancellationException;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000216D8 File Offset: 0x0001F8D8
		[NullableContext(2)]
		[Register("close", "(Ljava/lang/Throwable;)Z", "")]
		public unsafe bool Close(Throwable cause)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				result = ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractBooleanMethod("close.(Ljava/lang/Throwable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
			return result;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00021740 File Offset: 0x0001F940
		[Register("invokeOnClose", "(Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe void InvokeOnClose(IFunction1 handler)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((handler == null) ? IntPtr.Zero : ((Java.Lang.Object)handler).Handle);
				ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractVoidMethod("invokeOnClose.(Lkotlin/jvm/functions/Function1;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(handler);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000217A8 File Offset: 0x0001F9A8
		[NullableContext(2)]
		[Obsolete("deprecated")]
		[Register("offer", "(Ljava/lang/Object;)Z", "")]
		public unsafe bool Offer(Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractBooleanMethod("offer.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002180C File Offset: 0x0001FA0C
		[Register("openSubscription", "()Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		public IReceiveChannel OpenSubscription()
		{
			return Java.Lang.Object.GetObject<IReceiveChannel>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractObjectMethod("openSubscription.()Lkotlinx/coroutines/channels/ReceiveChannel;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00021840 File Offset: 0x0001FA40
		[NullableContext(2)]
		[Register("send", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		public unsafe Java.Lang.Object Send(Java.Lang.Object element, [Nullable(1)] IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeAbstractObjectMethod("send.(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000218E0 File Offset: 0x0001FAE0
		[Register("trySend-JP2dKIU", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public unsafe Java.Lang.Object TrySend([Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ConflatedBroadcastChannel._members.InstanceMethods.InvokeNonvirtualObjectMethod("trySend-JP2dKIU.(Ljava/lang/Object;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x040002C8 RID: 712
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ConflatedBroadcastChannel", typeof(ConflatedBroadcastChannel));
	}
}
