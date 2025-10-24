using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000082 RID: 130
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ThreadContextElementKt", DoNotGenerateAcw = true)]
	public sealed class ThreadContextElementKt : Java.Lang.Object
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000139E0 File Offset: 0x00011BE0
		internal static IntPtr class_ref
		{
			get
			{
				return ThreadContextElementKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00013A04 File Offset: 0x00011C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ThreadContextElementKt._members;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00013A0C File Offset: 0x00011C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ThreadContextElementKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00013A30 File Offset: 0x00011C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ThreadContextElementKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00013A3C File Offset: 0x00011C3C
		internal ThreadContextElementKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00013A48 File Offset: 0x00011C48
		[Register("asContextElement", "(Ljava/lang/ThreadLocal;Ljava/lang/Object;)Lkotlinx/coroutines/ThreadContextElement;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IThreadContextElement AsContextElement(ThreadLocal obj, [Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IThreadContextElement @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IThreadContextElement>(ThreadContextElementKt._members.StaticMethods.InvokeObjectMethod("asContextElement.(Ljava/lang/ThreadLocal;Ljava/lang/Object;)Lkotlinx/coroutines/ThreadContextElement;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00013AE0 File Offset: 0x00011CE0
		[Register("ensurePresent", "(Ljava/lang/ThreadLocal;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object EnsurePresent(ThreadLocal obj, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ThreadContextElementKt._members.StaticMethods.InvokeObjectMethod("ensurePresent.(Ljava/lang/ThreadLocal;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00013B80 File Offset: 0x00011D80
		[Register("isPresent", "(Ljava/lang/ThreadLocal;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object IsPresent(ThreadLocal obj, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ThreadContextElementKt._members.StaticMethods.InvokeObjectMethod("isPresent.(Ljava/lang/ThreadLocal;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0400020B RID: 523
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ThreadContextElementKt", typeof(ThreadContextElementKt));
	}
}
