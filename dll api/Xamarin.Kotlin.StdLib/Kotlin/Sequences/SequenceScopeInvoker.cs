using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Coroutines;

namespace Kotlin.Sequences
{
	// Token: 0x020000F9 RID: 249
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/sequences/SequenceScope", DoNotGenerateAcw = true)]
	internal class SequenceScopeInvoker : SequenceScope
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x00021FCB File Offset: 0x000201CB
		public SequenceScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00021FD5 File Offset: 0x000201D5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SequenceScopeInvoker._members;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00021FDC File Offset: 0x000201DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SequenceScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00021FE8 File Offset: 0x000201E8
		[NullableContext(2)]
		[Register("yield", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetYield_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		public unsafe override Java.Lang.Object Yield(Java.Lang.Object value, [Nullable(1)] IContinuation p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequenceScopeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("yield.(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00022088 File Offset: 0x00020288
		[Register("yieldAll", "(Ljava/util/Iterator;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetYieldAll_Ljava_util_Iterator_Lkotlin_coroutines_Continuation_Handler")]
		[return: Nullable(2)]
		public unsafe override Java.Lang.Object YieldAll(IIterator iterator, IContinuation p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((iterator == null) ? IntPtr.Zero : ((Java.Lang.Object)iterator).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SequenceScopeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("yieldAll.(Ljava/util/Iterator;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(iterator);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000265 RID: 613
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/sequences/SequenceScope", typeof(SequenceScopeInvoker));
	}
}
