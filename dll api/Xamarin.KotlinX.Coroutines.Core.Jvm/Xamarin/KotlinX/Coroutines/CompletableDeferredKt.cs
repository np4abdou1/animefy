using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200001E RID: 30
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletableDeferredKt", DoNotGenerateAcw = true)]
	public sealed class CompletableDeferredKt : Java.Lang.Object
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002BD0 File Offset: 0x00000DD0
		internal static IntPtr class_ref
		{
			get
			{
				return CompletableDeferredKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletableDeferredKt._members;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002BFC File Offset: 0x00000DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletableDeferredKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002C20 File Offset: 0x00000E20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletableDeferredKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002C2C File Offset: 0x00000E2C
		internal CompletableDeferredKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002C38 File Offset: 0x00000E38
		[Register("CompletableDeferred", "(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableDeferred;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICompletableDeferred CompletableDeferred([Nullable(2)] IJob parent)
		{
			ICompletableDeferred @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((Java.Lang.Object)parent).Handle);
				@object = Java.Lang.Object.GetObject<ICompletableDeferred>(CompletableDeferredKt._members.StaticMethods.InvokeObjectMethod("CompletableDeferred.(Lkotlinx/coroutines/Job;)Lkotlinx/coroutines/CompletableDeferred;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002CB0 File Offset: 0x00000EB0
		[Register("CompletableDeferred", "(Ljava/lang/Object;)Lkotlinx/coroutines/CompletableDeferred;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ICompletableDeferred CompletableDeferred([Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			ICompletableDeferred @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ICompletableDeferred>(CompletableDeferredKt._members.StaticMethods.InvokeObjectMethod("CompletableDeferred.(Ljava/lang/Object;)Lkotlinx/coroutines/CompletableDeferred;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002D20 File Offset: 0x00000F20
		[Register("completeWith", "(Lkotlinx/coroutines/CompletableDeferred;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static bool CompleteWith(ICompletableDeferred obj, Java.Lang.Object result)
		{
			bool result2;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((result == null) ? IntPtr.Zero : result.Handle);
				result2 = CompletableDeferredKt._members.StaticMethods.InvokeBooleanMethod("completeWith.(Lkotlinx/coroutines/CompletableDeferred;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(result);
			}
			return result2;
		}

		// Token: 0x0400000A RID: 10
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletableDeferredKt", typeof(CompletableDeferredKt));
	}
}
