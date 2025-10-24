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

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000028 RID: 40
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CoroutineScopeKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineScopeKt : Java.Lang.Object
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003E00 File Offset: 0x00002000
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineScopeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003E24 File Offset: 0x00002024
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineScopeKt._members;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003E2C File Offset: 0x0000202C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineScopeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003E50 File Offset: 0x00002050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineScopeKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003E5C File Offset: 0x0000205C
		internal CoroutineScopeKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003E68 File Offset: 0x00002068
		[Register("CoroutineScope", "(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/CoroutineScope;", "")]
		public unsafe static ICoroutineScope CoroutineScope(ICoroutineContext context)
		{
			ICoroutineScope @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineScope>(CoroutineScopeKt._members.StaticMethods.InvokeObjectMethod("CoroutineScope.(Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/CoroutineScope;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003EE0 File Offset: 0x000020E0
		[Register("MainScope", "()Lkotlinx/coroutines/CoroutineScope;", "")]
		public static ICoroutineScope MainScope()
		{
			return Java.Lang.Object.GetObject<ICoroutineScope>(CoroutineScopeKt._members.StaticMethods.InvokeObjectMethod("MainScope.()Lkotlinx/coroutines/CoroutineScope;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003F14 File Offset: 0x00002114
		[Register("cancel", "(Lkotlinx/coroutines/CoroutineScope;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe static void Cancel(ICoroutineScope obj, string message, [Nullable(2)] Throwable cause)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				CoroutineScopeKt._members.StaticMethods.InvokeVoidMethod("cancel.(Lkotlinx/coroutines/CoroutineScope;Ljava/lang/String;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003FC8 File Offset: 0x000021C8
		[Register("cancel", "(Lkotlinx/coroutines/CoroutineScope;Ljava/util/concurrent/CancellationException;)V", "")]
		public unsafe static void Cancel(ICoroutineScope obj, [Nullable(2)] CancellationException cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				CoroutineScopeKt._members.StaticMethods.InvokeVoidMethod("cancel.(Lkotlinx/coroutines/CoroutineScope;Ljava/util/concurrent/CancellationException;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004058 File Offset: 0x00002258
		[Register("coroutineScope", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CoroutineScope(IFunction2 block, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CoroutineScopeKt._members.StaticMethods.InvokeObjectMethod("coroutineScope.(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000040FC File Offset: 0x000022FC
		[Register("currentCoroutineContext", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CurrentCoroutineContext(IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CoroutineScopeKt._members.StaticMethods.InvokeObjectMethod("currentCoroutineContext.(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004174 File Offset: 0x00002374
		[Register("ensureActive", "(Lkotlinx/coroutines/CoroutineScope;)V", "")]
		public unsafe static void EnsureActive(ICoroutineScope obj)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				CoroutineScopeKt._members.StaticMethods.InvokeVoidMethod("ensureActive.(Lkotlinx/coroutines/CoroutineScope;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000041DC File Offset: 0x000023DC
		[Register("isActive", "(Lkotlinx/coroutines/CoroutineScope;)Z", "")]
		public unsafe static bool IsActive(ICoroutineScope obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				result = CoroutineScopeKt._members.StaticMethods.InvokeBooleanMethod("isActive.(Lkotlinx/coroutines/CoroutineScope;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004248 File Offset: 0x00002448
		[Register("plus", "(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/CoroutineScope;", "")]
		public unsafe static ICoroutineScope Plus(ICoroutineScope obj, ICoroutineContext context)
		{
			ICoroutineScope @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<ICoroutineScope>(CoroutineScopeKt._members.StaticMethods.InvokeObjectMethod("plus.(Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/CoroutineScope;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0400001A RID: 26
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineScopeKt", typeof(CoroutineScopeKt));
	}
}
