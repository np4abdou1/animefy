using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000BE RID: 190
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/StateFlowKt", DoNotGenerateAcw = true)]
	public sealed class StateFlowKt : Java.Lang.Object
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0001F50C File Offset: 0x0001D70C
		internal static IntPtr class_ref
		{
			get
			{
				return StateFlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001F530 File Offset: 0x0001D730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StateFlowKt._members;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0001F538 File Offset: 0x0001D738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StateFlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001F55C File Offset: 0x0001D75C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StateFlowKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001F568 File Offset: 0x0001D768
		internal StateFlowKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001F574 File Offset: 0x0001D774
		[Register("MutableStateFlow", "(Ljava/lang/Object;)Lkotlinx/coroutines/flow/MutableStateFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IMutableStateFlow MutableStateFlow([Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IMutableStateFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMutableStateFlow>(StateFlowKt._members.StaticMethods.InvokeObjectMethod("MutableStateFlow.(Ljava/lang/Object;)Lkotlinx/coroutines/flow/MutableStateFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		[Register("getAndUpdate", "(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetAndUpdate(IMutableStateFlow obj, IFunction1 function)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StateFlowKt._members.StaticMethods.InvokeObjectMethod("getAndUpdate.(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(function);
			}
			return @object;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0001F688 File Offset: 0x0001D888
		[Register("update", "(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Update(IMutableStateFlow obj, IFunction1 function)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				StateFlowKt._members.StaticMethods.InvokeVoidMethod("update.(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(function);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0001F71C File Offset: 0x0001D91C
		[Register("updateAndGet", "(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object UpdateAndGet(IMutableStateFlow obj, IFunction1 function)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : ((Java.Lang.Object)obj).Handle);
				ptr[1] = new JniArgumentValue((function == null) ? IntPtr.Zero : ((Java.Lang.Object)function).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(StateFlowKt._members.StaticMethods.InvokeObjectMethod("updateAndGet.(Lkotlinx/coroutines/flow/MutableStateFlow;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(function);
			}
			return @object;
		}

		// Token: 0x040002BC RID: 700
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/StateFlowKt", typeof(StateFlowKt));
	}
}
