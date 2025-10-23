using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.CoroutinesAndroid
{
	// Token: 0x0200000C RID: 12
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/android/HandlerDispatcherKt", DoNotGenerateAcw = true)]
	public sealed class HandlerDispatcherKt : Java.Lang.Object
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002594 File Offset: 0x00000794
		internal static IntPtr class_ref
		{
			get
			{
				return HandlerDispatcherKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000025B8 File Offset: 0x000007B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HandlerDispatcherKt._members;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000025C0 File Offset: 0x000007C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HandlerDispatcherKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000025E4 File Offset: 0x000007E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HandlerDispatcherKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000025F0 File Offset: 0x000007F0
		internal HandlerDispatcherKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000025FC File Offset: 0x000007FC
		[Register("awaitFrame", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object AwaitFrame(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(HandlerDispatcherKt._members.StaticMethods.InvokeObjectMethod("awaitFrame.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002674 File Offset: 0x00000874
		[Register("from", "(Landroid/os/Handler;)Lkotlinx/coroutines/android/HandlerDispatcher;", "")]
		public unsafe static HandlerDispatcher From(Handler obj)
		{
			HandlerDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<HandlerDispatcher>(HandlerDispatcherKt._members.StaticMethods.InvokeObjectMethod("from.(Landroid/os/Handler;)Lkotlinx/coroutines/android/HandlerDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000026E8 File Offset: 0x000008E8
		[Register("from", "(Landroid/os/Handler;Ljava/lang/String;)Lkotlinx/coroutines/android/HandlerDispatcher;", "")]
		public unsafe static HandlerDispatcher From(Handler obj, [Nullable(2)] string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			HandlerDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<HandlerDispatcher>(HandlerDispatcherKt._members.StaticMethods.InvokeObjectMethod("from.(Landroid/os/Handler;Ljava/lang/String;)Lkotlinx/coroutines/android/HandlerDispatcher;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/android/HandlerDispatcherKt", typeof(HandlerDispatcherKt));
	}
}
