using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x0200008D RID: 141
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/sync/MutexKt", DoNotGenerateAcw = true)]
	public sealed class MutexKt : Java.Lang.Object
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00014AB0 File Offset: 0x00012CB0
		internal static IntPtr class_ref
		{
			get
			{
				return MutexKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00014AD4 File Offset: 0x00012CD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MutexKt._members;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00014ADC File Offset: 0x00012CDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutexKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00014B00 File Offset: 0x00012D00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MutexKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00014B0C File Offset: 0x00012D0C
		internal MutexKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00014B18 File Offset: 0x00012D18
		[Register("Mutex", "(Z)Lkotlinx/coroutines/sync/Mutex;", "")]
		public unsafe static IMutex Mutex(bool locked)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(locked);
			return Java.Lang.Object.GetObject<IMutex>(MutexKt._members.StaticMethods.InvokeObjectMethod("Mutex.(Z)Lkotlinx/coroutines/sync/Mutex;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00014B60 File Offset: 0x00012D60
		[Register("withLock", "(Lkotlinx/coroutines/sync/Mutex;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object WithLock(IMutex p0, [Nullable(2)] Java.Lang.Object owner, IFunction0 action, IContinuation p3)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((owner == null) ? IntPtr.Zero : owner.Handle);
				ptr[2] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((Java.Lang.Object)p3).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(MutexKt._members.StaticMethods.InvokeObjectMethod("withLock.(Lkotlinx/coroutines/sync/Mutex;Ljava/lang/Object;Lkotlin/jvm/functions/Function0;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(owner);
				GC.KeepAlive(action);
				GC.KeepAlive(p3);
			}
			return @object;
		}

		// Token: 0x0400022A RID: 554
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/sync/MutexKt", typeof(MutexKt));
	}
}
