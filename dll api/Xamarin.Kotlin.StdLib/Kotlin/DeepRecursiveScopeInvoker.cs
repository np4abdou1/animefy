using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Kotlin
{
	// Token: 0x02000049 RID: 73
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/DeepRecursiveScope", DoNotGenerateAcw = true)]
	internal class DeepRecursiveScopeInvoker : DeepRecursiveScope
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00002C4B File Offset: 0x00000E4B
		public DeepRecursiveScopeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002C55 File Offset: 0x00000E55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeepRecursiveScopeInvoker._members;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00002C5C File Offset: 0x00000E5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeepRecursiveScopeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002C68 File Offset: 0x00000E68
		[Register("callRecursive", "(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCallRecursive_Lkotlin_DeepRecursiveFunction_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"U",
			"S"
		})]
		[return: Nullable(2)]
		public unsafe override Java.Lang.Object CallRecursive(DeepRecursiveFunction p0, [Nullable(2)] Java.Lang.Object value, IContinuation p2)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DeepRecursiveScopeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("callRecursive.(Lkotlin/DeepRecursiveFunction;Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(value);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002D34 File Offset: 0x00000F34
		[NullableContext(2)]
		[Register("callRecursive", "(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetCallRecursive_Ljava_lang_Object_Lkotlin_coroutines_Continuation_Handler")]
		public unsafe override Java.Lang.Object CallRecursive(Java.Lang.Object value, [Nullable(1)] IContinuation p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(DeepRecursiveScopeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("callRecursive.(Ljava/lang/Object;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000018 RID: 24
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/DeepRecursiveScope", typeof(DeepRecursiveScopeInvoker));
	}
}
