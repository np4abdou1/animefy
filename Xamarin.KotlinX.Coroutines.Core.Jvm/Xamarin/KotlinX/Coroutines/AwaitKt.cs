using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200001A RID: 26
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/AwaitKt", DoNotGenerateAcw = true)]
	public sealed class AwaitKt : Java.Lang.Object
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000021B0 File Offset: 0x000003B0
		internal static IntPtr class_ref
		{
			get
			{
				return AwaitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000021D4 File Offset: 0x000003D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AwaitKt._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000021DC File Offset: 0x000003DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AwaitKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002200 File Offset: 0x00000400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AwaitKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000220C File Offset: 0x0000040C
		internal AwaitKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002218 File Offset: 0x00000418
		[Register("awaitAll", "(Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object AwaitAll(ICollection obj, IContinuation _completion)
		{
			IntPtr intPtr = JavaCollection.ToLocalJniHandle(obj);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AwaitKt._members.StaticMethods.InvokeObjectMethod("awaitAll.(Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(obj);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000022B8 File Offset: 0x000004B8
		[Register("awaitAll", "([Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object AwaitAll(IDeferred[] deferreds, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.NewArray<IDeferred>(deferreds);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AwaitKt._members.StaticMethods.InvokeObjectMethod("awaitAll.([Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (deferreds != null)
				{
					JNIEnv.CopyArray<IDeferred>(intPtr, deferreds);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(deferreds);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002360 File Offset: 0x00000560
		[Register("joinAll", "(Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object JoinAll(ICollection<IJob> p0, IContinuation p1)
		{
			IntPtr intPtr = JavaCollection<IJob>.ToLocalJniHandle(p0);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AwaitKt._members.StaticMethods.InvokeObjectMethod("joinAll.(Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002400 File Offset: 0x00000600
		[Register("joinAll", "([Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object JoinAll(IJob[] jobs, IContinuation p1)
		{
			IntPtr intPtr = JNIEnv.NewArray<IJob>(jobs);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AwaitKt._members.StaticMethods.InvokeObjectMethod("joinAll.([Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (jobs != null)
				{
					JNIEnv.CopyArray<IJob>(intPtr, jobs);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(jobs);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/AwaitKt", typeof(AwaitKt));
	}
}
