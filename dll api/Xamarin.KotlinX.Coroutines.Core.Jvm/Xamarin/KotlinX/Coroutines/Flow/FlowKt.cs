using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;
using Kotlin.Ranges;
using Kotlin.Reflect;
using Kotlin.Sequences;
using Xamarin.KotlinX.Coroutines.Channels;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000A8 RID: 168
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/FlowKt", DoNotGenerateAcw = true)]
	public sealed class FlowKt : Java.Lang.Object
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00017430 File Offset: 0x00015630
		internal static IntPtr class_ref
		{
			get
			{
				return FlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00017454 File Offset: 0x00015654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FlowKt._members;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0001745C File Offset: 0x0001565C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00017480 File Offset: 0x00015680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FlowKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001748C File Offset: 0x0001568C
		internal FlowKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00017496 File Offset: 0x00015696
		public static int DEFAULT_CONCURRENCY
		{
			[Register("getDEFAULT_CONCURRENCY", "()I", "")]
			get
			{
				return FlowKt._members.StaticMethods.InvokeInt32Method("getDEFAULT_CONCURRENCY.()I", null);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000174B0 File Offset: 0x000156B0
		[Register("asFlow", "([I)Lkotlinx/coroutines/flow/Flow;", "")]
		public unsafe static IFlow AsFlow(int[] _this_asFlow)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asFlow);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.([I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asFlow != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asFlow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0001752C File Offset: 0x0001572C
		[Register("asFlow", "(Ljava/lang/Iterable;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(IIterable _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Ljava/lang/Iterable;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000175A4 File Offset: 0x000157A4
		[Register("asFlow", "(Ljava/util/Iterator;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(IIterator _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Ljava/util/Iterator;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001761C File Offset: 0x0001581C
		[Register("asFlow", "(Lkotlin/jvm/functions/Function0;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(IFunction0 _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlin/jvm/functions/Function0;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00017694 File Offset: 0x00015894
		[Register("asFlow", "(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(IFunction1 _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001770C File Offset: 0x0001590C
		[Register("asFlow", "(Lkotlin/ranges/IntRange;)Lkotlinx/coroutines/flow/Flow;", "")]
		public unsafe static IFlow AsFlow(IntRange _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : _this_asFlow.Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlin/ranges/IntRange;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00017780 File Offset: 0x00015980
		[Register("asFlow", "(Lkotlin/ranges/LongRange;)Lkotlinx/coroutines/flow/Flow;", "")]
		public unsafe static IFlow AsFlow(LongRange _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : _this_asFlow.Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlin/ranges/LongRange;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000177F4 File Offset: 0x000159F4
		[Register("asFlow", "(Lkotlin/sequences/Sequence;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(ISequence _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlin/sequences/Sequence;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001786C File Offset: 0x00015A6C
		[Obsolete("deprecated")]
		[Register("asFlow", "(Lkotlinx/coroutines/channels/BroadcastChannel;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(IBroadcastChannel _this_asFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.(Lkotlinx/coroutines/channels/BroadcastChannel;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000178E4 File Offset: 0x00015AE4
		[Register("asFlow", "([J)Lkotlinx/coroutines/flow/Flow;", "")]
		public unsafe static IFlow AsFlow(long[] _this_asFlow)
		{
			IntPtr intPtr = JNIEnv.NewArray(_this_asFlow);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.([J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asFlow != null)
				{
					JNIEnv.CopyArray(intPtr, _this_asFlow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00017960 File Offset: 0x00015B60
		[Register("asFlow", "([Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow AsFlow(Java.Lang.Object[] _this_asFlow)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(_this_asFlow);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asFlow.([Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (_this_asFlow != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, _this_asFlow);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(_this_asFlow);
			}
			return @object;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000179DC File Offset: 0x00015BDC
		[Register("asSharedFlow", "(Lkotlinx/coroutines/flow/MutableSharedFlow;)Lkotlinx/coroutines/flow/SharedFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISharedFlow AsSharedFlow(IMutableSharedFlow _this_asSharedFlow)
		{
			ISharedFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asSharedFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asSharedFlow).Handle);
				@object = Java.Lang.Object.GetObject<ISharedFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asSharedFlow.(Lkotlinx/coroutines/flow/MutableSharedFlow;)Lkotlinx/coroutines/flow/SharedFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asSharedFlow);
			}
			return @object;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00017A54 File Offset: 0x00015C54
		[Register("asStateFlow", "(Lkotlinx/coroutines/flow/MutableStateFlow;)Lkotlinx/coroutines/flow/StateFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IStateFlow AsStateFlow(IMutableStateFlow _this_asStateFlow)
		{
			IStateFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_asStateFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_asStateFlow).Handle);
				@object = Java.Lang.Object.GetObject<IStateFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("asStateFlow.(Lkotlinx/coroutines/flow/MutableStateFlow;)Lkotlinx/coroutines/flow/StateFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_asStateFlow);
			}
			return @object;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00017ACC File Offset: 0x00015CCC
		[Register("buffer", "(Lkotlinx/coroutines/flow/Flow;ILkotlinx/coroutines/channels/BufferOverflow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Buffer(IFlow _this_buffer, int capacity, BufferOverflow onBufferOverflow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_buffer == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_buffer).Handle);
				ptr[1] = new JniArgumentValue(capacity);
				ptr[2] = new JniArgumentValue((onBufferOverflow == null) ? IntPtr.Zero : onBufferOverflow.Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("buffer.(Lkotlinx/coroutines/flow/Flow;ILkotlinx/coroutines/channels/BufferOverflow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_buffer);
				GC.KeepAlive(onBufferOverflow);
			}
			return @object;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00017B84 File Offset: 0x00015D84
		[Obsolete("deprecated")]
		[Register("cache", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Cache(IFlow _this_cache)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cache == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cache).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("cache.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_cache);
			}
			return @object;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00017BFC File Offset: 0x00015DFC
		[Register("callbackFlow", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow CallbackFlow(IFunction2 block)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("callbackFlow.(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00017C74 File Offset: 0x00015E74
		[Register("cancellable", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Cancellable(IFlow _this_cancellable)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancellable == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancellable).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("cancellable.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_cancellable);
			}
			return @object;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00017CEC File Offset: 0x00015EEC
		[Register("catch", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Catch(IFlow _this_catch, IFunction3 action)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_catch == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_catch).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("catch.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_catch);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00017D90 File Offset: 0x00015F90
		[Register("catchImpl", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CatchImpl(IFlow _this_catchImpl, IFlowCollector collector, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_catchImpl == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_catchImpl).Handle);
				ptr[1] = new JniArgumentValue((collector == null) ? IntPtr.Zero : ((Java.Lang.Object)collector).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("catchImpl.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_catchImpl);
				GC.KeepAlive(collector);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00017E64 File Offset: 0x00016064
		[Register("channelFlow", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ChannelFlow(IFunction2 block)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("channelFlow.(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00017EDC File Offset: 0x000160DC
		[Register("collect", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Collect(IFlow _this_collect, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collect == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collect).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("collect.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_collect);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00017F80 File Offset: 0x00016180
		[Register("collectIndexed", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CollectIndexed(IFlow _this_collectIndexed, IFunction3 action, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collectIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collectIndexed).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("collectIndexed.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_collectIndexed);
				GC.KeepAlive(action);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00018054 File Offset: 0x00016254
		[Register("collectLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CollectLatest(IFlow _this_collectLatest, IFunction2 action, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collectLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collectLatest).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("collectLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_collectLatest);
				GC.KeepAlive(action);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00018128 File Offset: 0x00016328
		[Register("collectWhile", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object CollectWhile(IFlow _this_collectWhile, IFunction2 predicate, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_collectWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_collectWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("collectWhile.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_collectWhile);
				GC.KeepAlive(predicate);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000181FC File Offset: 0x000163FC
		[Register("combine", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow Combine(IFlow flow, IFlow flow2, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combine.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000182D0 File Offset: 0x000164D0
		[Register("combine", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"R"
		})]
		public unsafe static IFlow Combine(IFlow flow, IFlow flow2, IFlow flow3, IFunction4 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combine.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000183D4 File Offset: 0x000165D4
		[Register("combine", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"R"
		})]
		public unsafe static IFlow Combine(IFlow flow, IFlow flow2, IFlow flow3, IFlow flow4, IFunction5 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((flow4 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow4).Handle);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combine.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(flow4);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001850C File Offset: 0x0001670C
		[Register("combine", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"T5",
			"R"
		})]
		public unsafe static IFlow Combine(IFlow flow, IFlow flow2, IFlow flow3, IFlow flow4, IFlow flow5, IFunction6 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((flow4 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow4).Handle);
				ptr[4] = new JniArgumentValue((flow5 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow5).Handle);
				ptr[5] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combine.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(flow4);
				GC.KeepAlive(flow5);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00018684 File Offset: 0x00016884
		[Obsolete("deprecated")]
		[Register("combineLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow CombineLatest(IFlow _this_combineLatest, IFlow other, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combineLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combineLatest).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combineLatest);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00018758 File Offset: 0x00016958
		[Obsolete("deprecated")]
		[Register("combineLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"R"
		})]
		public unsafe static IFlow CombineLatest(IFlow _this_combineLatest, IFlow other, IFlow other2, IFunction4 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combineLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combineLatest).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((other2 == null) ? IntPtr.Zero : ((Java.Lang.Object)other2).Handle);
				ptr[3] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combineLatest);
				GC.KeepAlive(other);
				GC.KeepAlive(other2);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0001885C File Offset: 0x00016A5C
		[Obsolete("deprecated")]
		[Register("combineLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"R"
		})]
		public unsafe static IFlow CombineLatest(IFlow _this_combineLatest, IFlow other, IFlow other2, IFlow other3, IFunction5 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combineLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combineLatest).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((other2 == null) ? IntPtr.Zero : ((Java.Lang.Object)other2).Handle);
				ptr[3] = new JniArgumentValue((other3 == null) ? IntPtr.Zero : ((Java.Lang.Object)other3).Handle);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combineLatest);
				GC.KeepAlive(other);
				GC.KeepAlive(other2);
				GC.KeepAlive(other3);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00018994 File Offset: 0x00016B94
		[Obsolete("deprecated")]
		[Register("combineLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"T5",
			"R"
		})]
		public unsafe static IFlow CombineLatest(IFlow _this_combineLatest, IFlow other, IFlow other2, IFlow other3, IFlow other4, IFunction6 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combineLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combineLatest).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((other2 == null) ? IntPtr.Zero : ((Java.Lang.Object)other2).Handle);
				ptr[3] = new JniArgumentValue((other3 == null) ? IntPtr.Zero : ((Java.Lang.Object)other3).Handle);
				ptr[4] = new JniArgumentValue((other4 == null) ? IntPtr.Zero : ((Java.Lang.Object)other4).Handle);
				ptr[5] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combineLatest);
				GC.KeepAlive(other);
				GC.KeepAlive(other2);
				GC.KeepAlive(other3);
				GC.KeepAlive(other4);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00018B0C File Offset: 0x00016D0C
		[Register("combineTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow CombineTransform(IFlow flow, IFlow flow2, IFunction4 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00018BE0 File Offset: 0x00016DE0
		[Register("combineTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"R"
		})]
		public unsafe static IFlow CombineTransform(IFlow flow, IFlow flow2, IFlow flow3, IFunction5 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function5;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00018CE4 File Offset: 0x00016EE4
		[Register("combineTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"R"
		})]
		public unsafe static IFlow CombineTransform(IFlow flow, IFlow flow2, IFlow flow3, IFlow flow4, IFunction6 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((flow4 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow4).Handle);
				ptr[4] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function6;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(flow4);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00018E1C File Offset: 0x0001701C
		[Register("combineTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function7;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"T3",
			"T4",
			"T5",
			"R"
		})]
		public unsafe static IFlow CombineTransform(IFlow flow, IFlow flow2, IFlow flow3, IFlow flow4, IFlow flow5, IFunction7 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[1] = new JniArgumentValue((flow2 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow2).Handle);
				ptr[2] = new JniArgumentValue((flow3 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow3).Handle);
				ptr[3] = new JniArgumentValue((flow4 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow4).Handle);
				ptr[4] = new JniArgumentValue((flow5 == null) ? IntPtr.Zero : ((Java.Lang.Object)flow5).Handle);
				ptr[5] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("combineTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function7;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(flow);
				GC.KeepAlive(flow2);
				GC.KeepAlive(flow3);
				GC.KeepAlive(flow4);
				GC.KeepAlive(flow5);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00018F94 File Offset: 0x00017194
		[Obsolete("deprecated")]
		[Register("compose", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow Compose(IFlow _this_compose, IFunction1 transformer)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_compose == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_compose).Handle);
				ptr[1] = new JniArgumentValue((transformer == null) ? IntPtr.Zero : ((Java.Lang.Object)transformer).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("compose.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_compose);
				GC.KeepAlive(transformer);
			}
			return @object;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00019038 File Offset: 0x00017238
		[Obsolete("deprecated")]
		[Register("concatMap", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow ConcatMap(IFlow _this_concatMap, IFunction1 mapper)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_concatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_concatMap).Handle);
				ptr[1] = new JniArgumentValue((mapper == null) ? IntPtr.Zero : ((Java.Lang.Object)mapper).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("concatMap.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_concatMap);
				GC.KeepAlive(mapper);
			}
			return @object;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000190DC File Offset: 0x000172DC
		[Obsolete("deprecated")]
		[Register("concatWith", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ConcatWith(IFlow _this_concatWith, IFlow other)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_concatWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_concatWith).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("concatWith.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_concatWith);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00019180 File Offset: 0x00017380
		[Obsolete("deprecated")]
		[Register("concatWith", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ConcatWith(IFlow _this_concatWith, [Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_concatWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_concatWith).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("concatWith.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_concatWith);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00019220 File Offset: 0x00017420
		[Register("conflate", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Conflate(IFlow _this_conflate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_conflate == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_conflate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("conflate.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_conflate);
			}
			return @object;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00019298 File Offset: 0x00017498
		[Register("consumeAsFlow", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ConsumeAsFlow(IReceiveChannel _this_consumeAsFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consumeAsFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consumeAsFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("consumeAsFlow.(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consumeAsFlow);
			}
			return @object;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00019310 File Offset: 0x00017510
		[Register("count", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Count(IFlow _this_count, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("count.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_count);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000193B4 File Offset: 0x000175B4
		[Register("count", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Count(IFlow _this_count, IFunction2 predicate, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_count == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_count).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("count.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_count);
				GC.KeepAlive(predicate);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00019488 File Offset: 0x00017688
		[Register("debounce", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Debounce(IFlow _this_debounce, IFunction1 timeoutMillis)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_debounce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_debounce).Handle);
				ptr[1] = new JniArgumentValue((timeoutMillis == null) ? IntPtr.Zero : ((Java.Lang.Object)timeoutMillis).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("debounce.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_debounce);
				GC.KeepAlive(timeoutMillis);
			}
			return @object;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001952C File Offset: 0x0001772C
		[Register("debounce", "(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Debounce(IFlow _this_debounce, long timeoutMillis)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_debounce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_debounce).Handle);
				ptr[1] = new JniArgumentValue(timeoutMillis);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("debounce.(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_debounce);
			}
			return @object;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000195B8 File Offset: 0x000177B8
		[Register("debounceDuration", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DebounceDuration(IFlow _this_debounce, IFunction1 timeout)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_debounce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_debounce).Handle);
				ptr[1] = new JniArgumentValue((timeout == null) ? IntPtr.Zero : ((Java.Lang.Object)timeout).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("debounceDuration.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_debounce);
				GC.KeepAlive(timeout);
			}
			return @object;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001965C File Offset: 0x0001785C
		[Obsolete("deprecated")]
		[Register("delayEach", "(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DelayEach(IFlow _this_delayEach, long timeMillis)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_delayEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_delayEach).Handle);
				ptr[1] = new JniArgumentValue(timeMillis);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("delayEach.(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_delayEach);
			}
			return @object;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000196E8 File Offset: 0x000178E8
		[Obsolete("deprecated")]
		[Register("delayFlow", "(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DelayFlow(IFlow _this_delayFlow, long timeMillis)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_delayFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_delayFlow).Handle);
				ptr[1] = new JniArgumentValue(timeMillis);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("delayFlow.(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_delayFlow);
			}
			return @object;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00019774 File Offset: 0x00017974
		[Register("distinctUntilChanged", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DistinctUntilChanged(IFlow _this_distinctUntilChanged)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctUntilChanged == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctUntilChanged).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("distinctUntilChanged.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctUntilChanged);
			}
			return @object;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000197EC File Offset: 0x000179EC
		[Register("distinctUntilChanged", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DistinctUntilChanged(IFlow _this_distinctUntilChanged, IFunction2 areEquivalent)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctUntilChanged == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctUntilChanged).Handle);
				ptr[1] = new JniArgumentValue((areEquivalent == null) ? IntPtr.Zero : ((Java.Lang.Object)areEquivalent).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("distinctUntilChanged.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctUntilChanged);
				GC.KeepAlive(areEquivalent);
			}
			return @object;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00019890 File Offset: 0x00017A90
		[Register("distinctUntilChangedBy", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"K"
		})]
		public unsafe static IFlow DistinctUntilChangedBy(IFlow _this_distinctUntilChangedBy, IFunction1 keySelector)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctUntilChangedBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctUntilChangedBy).Handle);
				ptr[1] = new JniArgumentValue((keySelector == null) ? IntPtr.Zero : ((Java.Lang.Object)keySelector).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("distinctUntilChangedBy.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctUntilChangedBy);
				GC.KeepAlive(keySelector);
			}
			return @object;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00019934 File Offset: 0x00017B34
		[Register("drop", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Drop(IFlow _this_drop, int count)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_drop == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_drop).Handle);
				ptr[1] = new JniArgumentValue(count);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("drop.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_drop);
			}
			return @object;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000199C0 File Offset: 0x00017BC0
		[Register("dropWhile", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow DropWhile(IFlow _this_dropWhile, IFunction2 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_dropWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_dropWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("dropWhile.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_dropWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00019A64 File Offset: 0x00017C64
		[Register("emitAll", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object EmitAll(IFlowCollector _this_emitAll, IReceiveChannel channel, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_emitAll == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_emitAll).Handle);
				ptr[1] = new JniArgumentValue((channel == null) ? IntPtr.Zero : ((Java.Lang.Object)channel).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("emitAll.(Lkotlinx/coroutines/flow/FlowCollector;Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_emitAll);
				GC.KeepAlive(channel);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00019B38 File Offset: 0x00017D38
		[Register("emitAll", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object EmitAll(IFlowCollector _this_emitAll, IFlow flow, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_emitAll == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_emitAll).Handle);
				ptr[1] = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("emitAll.(Lkotlinx/coroutines/flow/FlowCollector;Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_emitAll);
				GC.KeepAlive(flow);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00019C0C File Offset: 0x00017E0C
		[Register("emptyFlow", "()Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IFlow EmptyFlow()
		{
			return Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("emptyFlow.()Lkotlinx/coroutines/flow/Flow;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00019C40 File Offset: 0x00017E40
		[Register("ensureActive", "(Lkotlinx/coroutines/flow/FlowCollector;)V", "")]
		public unsafe static void EnsureActive(IFlowCollector _this_ensureActive)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_ensureActive == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_ensureActive).Handle);
				FlowKt._members.StaticMethods.InvokeVoidMethod("ensureActive.(Lkotlinx/coroutines/flow/FlowCollector;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_ensureActive);
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00019CA8 File Offset: 0x00017EA8
		[Register("filter", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Filter(IFlow _this_filter, IFunction2 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filter == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filter).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("filter.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00019D4C File Offset: 0x00017F4C
		[Register("filterIsInstance", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/reflect/KClass;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public unsafe static IFlow FilterIsInstance(IFlow _this_filterIsInstance, IKClass klass)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterIsInstance == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterIsInstance).Handle);
				ptr[1] = new JniArgumentValue((klass == null) ? IntPtr.Zero : ((Java.Lang.Object)klass).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("filterIsInstance.(Lkotlinx/coroutines/flow/Flow;Lkotlin/reflect/KClass;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterIsInstance);
				GC.KeepAlive(klass);
			}
			return @object;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00019DF0 File Offset: 0x00017FF0
		[Register("filterNot", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FilterNot(IFlow _this_filterNot, IFunction2 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNot == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNot).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("filterNot.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNot);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00019E94 File Offset: 0x00018094
		[Register("filterNotNull", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FilterNotNull(IFlow _this_filterNotNull)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNull).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("filterNotNull.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNotNull);
			}
			return @object;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00019F0C File Offset: 0x0001810C
		[Register("first", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(IFlow _this_first, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("first.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Register("first", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object First(IFlow _this_first, IFunction2 predicate, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_first == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_first).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("first.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_first);
				GC.KeepAlive(predicate);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001A084 File Offset: 0x00018284
		[Register("firstOrNull", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(IFlow _this_firstOrNull, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001A128 File Offset: 0x00018328
		[Register("firstOrNull", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object FirstOrNull(IFlow _this_firstOrNull, IFunction2 predicate, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_firstOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_firstOrNull).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("firstOrNull.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_firstOrNull);
				GC.KeepAlive(predicate);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001A1FC File Offset: 0x000183FC
		[Register("fixedPeriodTicker", "(Lkotlinx/coroutines/CoroutineScope;JJ)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		public unsafe static IReceiveChannel FixedPeriodTicker(ICoroutineScope _this_fixedPeriodTicker, long delayMillis, long initialDelayMillis)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fixedPeriodTicker == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fixedPeriodTicker).Handle);
				ptr[1] = new JniArgumentValue(delayMillis);
				ptr[2] = new JniArgumentValue(initialDelayMillis);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(FlowKt._members.StaticMethods.InvokeObjectMethod("fixedPeriodTicker.(Lkotlinx/coroutines/CoroutineScope;JJ)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_fixedPeriodTicker);
			}
			return @object;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001A29C File Offset: 0x0001849C
		[Obsolete("deprecated")]
		[Register("flatMap", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow FlatMap(IFlow _this_flatMap, IFunction2 mapper)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMap).Handle);
				ptr[1] = new JniArgumentValue((mapper == null) ? IntPtr.Zero : ((Java.Lang.Object)mapper).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flatMap.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMap);
				GC.KeepAlive(mapper);
			}
			return @object;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001A340 File Offset: 0x00018540
		[Register("flatMapConcat", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow FlatMapConcat(IFlow _this_flatMapConcat, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapConcat == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapConcat).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flatMapConcat.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMapConcat);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001A3E4 File Offset: 0x000185E4
		[Register("flatMapLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow FlatMapLatest(IFlow _this_flatMapLatest, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapLatest).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flatMapLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMapLatest);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001A488 File Offset: 0x00018688
		[Register("flatMapMerge", "(Lkotlinx/coroutines/flow/Flow;ILkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow FlatMapMerge(IFlow _this_flatMapMerge, int concurrency, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatMapMerge == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatMapMerge).Handle);
				ptr[1] = new JniArgumentValue(concurrency);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flatMapMerge.(Lkotlinx/coroutines/flow/Flow;ILkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatMapMerge);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001A544 File Offset: 0x00018744
		[Obsolete("deprecated")]
		[Register("flatten", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Flatten(IFlow _this_flatten)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flatten == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flatten).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flatten.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flatten);
			}
			return @object;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001A5BC File Offset: 0x000187BC
		[Register("flattenConcat", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlattenConcat(IFlow _this_flattenConcat)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flattenConcat == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flattenConcat).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flattenConcat.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flattenConcat);
			}
			return @object;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001A634 File Offset: 0x00018834
		[Register("flattenMerge", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlattenMerge(IFlow _this_flattenMerge, int concurrency)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flattenMerge == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flattenMerge).Handle);
				ptr[1] = new JniArgumentValue(concurrency);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flattenMerge.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flattenMerge);
			}
			return @object;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001A6C0 File Offset: 0x000188C0
		[Register("flow", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Flow(IFunction2 block)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flow.(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001A738 File Offset: 0x00018938
		[Register("flowCombine", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow FlowCombine(IFlow _this_combine, IFlow flow, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combine == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combine).Handle);
				ptr[1] = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flowCombine.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combine);
				GC.KeepAlive(flow);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001A80C File Offset: 0x00018A0C
		[Register("flowCombineTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow FlowCombineTransform(IFlow _this_combineTransform, IFlow flow, IFunction4 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_combineTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_combineTransform).Handle);
				ptr[1] = new JniArgumentValue((flow == null) ? IntPtr.Zero : ((Java.Lang.Object)flow).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flowCombineTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_combineTransform);
				GC.KeepAlive(flow);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		[Register("flowOf", "(Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlowOf([Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flowOf.(Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0001A950 File Offset: 0x00018B50
		[Register("flowOf", "([Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlowOf(params Java.Lang.Object[] elements)
		{
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(elements);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flowOf.([Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (elements != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, elements);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(elements);
			}
			return @object;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001A9CC File Offset: 0x00018BCC
		[Register("flowOn", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow FlowOn(IFlow _this_flowOn, ICoroutineContext context)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_flowOn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_flowOn).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("flowOn.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_flowOn);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001AA70 File Offset: 0x00018C70
		[Register("fold", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Fold(IFlow _this_fold, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_fold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_fold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				ptr[3] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("fold.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_fold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001AB70 File Offset: 0x00018D70
		[Obsolete("deprecated")]
		[Register("forEach", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void ForEach(IFlow _this_forEach, IFunction2 action)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_forEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_forEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				FlowKt._members.StaticMethods.InvokeVoidMethod("forEach.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_forEach);
				GC.KeepAlive(action);
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0001AC04 File Offset: 0x00018E04
		[Register("last", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Last(IFlow _this_last, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_last == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_last).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("last.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_last);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0001ACA8 File Offset: 0x00018EA8
		[Register("lastOrNull", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object LastOrNull(IFlow _this_lastOrNull, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_lastOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_lastOrNull).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("lastOrNull.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_lastOrNull);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0001AD4C File Offset: 0x00018F4C
		[Register("launchIn", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;)Lkotlinx/coroutines/Job;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IJob LaunchIn(IFlow _this_launchIn, ICoroutineScope scope)
		{
			IJob @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_launchIn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_launchIn).Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : ((Java.Lang.Object)scope).Handle);
				@object = Java.Lang.Object.GetObject<IJob>(FlowKt._members.StaticMethods.InvokeObjectMethod("launchIn.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;)Lkotlinx/coroutines/Job;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_launchIn);
				GC.KeepAlive(scope);
			}
			return @object;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0001ADF0 File Offset: 0x00018FF0
		[Register("map", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow Map(IFlow _this_map, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_map == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_map).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("map.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_map);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0001AE94 File Offset: 0x00019094
		[Register("mapLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow MapLatest(IFlow _this_mapLatest, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapLatest).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("mapLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapLatest);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001AF38 File Offset: 0x00019138
		[Register("mapNotNull", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow MapNotNull(IFlow _this_mapNotNull, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapNotNull).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("mapNotNull.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapNotNull);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0001AFDC File Offset: 0x000191DC
		[Register("merge", "(Ljava/lang/Iterable;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Merge(IIterable _this_merge)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_merge == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_merge).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("merge.(Ljava/lang/Iterable;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_merge);
			}
			return @object;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001B054 File Offset: 0x00019254
		[Obsolete("deprecated")]
		[Register("merge", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Merge(IFlow _this_merge)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_merge == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_merge).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("merge.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_merge);
			}
			return @object;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0001B0CC File Offset: 0x000192CC
		[Register("merge", "([Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Merge(params IFlow[] flows)
		{
			IntPtr intPtr = JNIEnv.NewArray<IFlow>(flows);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("merge.([Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (flows != null)
				{
					JNIEnv.CopyArray<IFlow>(intPtr, flows);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(flows);
			}
			return @object;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0001B148 File Offset: 0x00019348
		[Register("noImpl", "()Ljava/lang/Void;", "")]
		public static Java.Lang.Void NoImpl()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Void>(FlowKt._members.StaticMethods.InvokeObjectMethod("noImpl.()Ljava/lang/Void;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0001B17C File Offset: 0x0001937C
		[Obsolete("deprecated")]
		[Register("observeOn", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ObserveOn(IFlow _this_observeOn, ICoroutineContext context)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_observeOn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_observeOn).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("observeOn.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_observeOn);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0001B220 File Offset: 0x00019420
		[Register("onCompletion", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnCompletion(IFlow _this_onCompletion, IFunction3 action)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onCompletion == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onCompletion).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onCompletion.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onCompletion);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001B2C4 File Offset: 0x000194C4
		[Register("onEach", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnEach(IFlow _this_onEach, IFunction2 action)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onEach.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onEach);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001B368 File Offset: 0x00019568
		[Register("onEmpty", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnEmpty(IFlow _this_onEmpty, IFunction2 action)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onEmpty == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onEmpty).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onEmpty.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onEmpty);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0001B40C File Offset: 0x0001960C
		[Obsolete("deprecated")]
		[Register("onErrorResume", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnErrorResume(IFlow _this_onErrorResume, IFlow fallback)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onErrorResume == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onErrorResume).Handle);
				ptr[1] = new JniArgumentValue((fallback == null) ? IntPtr.Zero : ((Java.Lang.Object)fallback).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onErrorResume.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onErrorResume);
				GC.KeepAlive(fallback);
			}
			return @object;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Obsolete("deprecated")]
		[Register("onErrorResumeNext", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnErrorResumeNext(IFlow _this_onErrorResumeNext, IFlow fallback)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onErrorResumeNext == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onErrorResumeNext).Handle);
				ptr[1] = new JniArgumentValue((fallback == null) ? IntPtr.Zero : ((Java.Lang.Object)fallback).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onErrorResumeNext.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onErrorResumeNext);
				GC.KeepAlive(fallback);
			}
			return @object;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0001B554 File Offset: 0x00019754
		[Obsolete("deprecated")]
		[Register("onErrorReturn", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnErrorReturn(IFlow _this_onErrorReturn, [Nullable(2)] Java.Lang.Object fallback)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fallback);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onErrorReturn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onErrorReturn).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onErrorReturn.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onErrorReturn);
				GC.KeepAlive(fallback);
			}
			return @object;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0001B5F4 File Offset: 0x000197F4
		[Obsolete("deprecated")]
		[Register("onErrorReturn", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnErrorReturn(IFlow _this_onErrorReturn, [Nullable(2)] Java.Lang.Object fallback, IFunction1 predicate)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(fallback);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onErrorReturn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onErrorReturn).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onErrorReturn.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_onErrorReturn);
				GC.KeepAlive(fallback);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0001B6C4 File Offset: 0x000198C4
		[Register("onStart", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow OnStart(IFlow _this_onStart, IFunction2 action)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onStart == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onStart).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onStart.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onStart);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0001B768 File Offset: 0x00019968
		[Register("onSubscription", "(Lkotlinx/coroutines/flow/SharedFlow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/SharedFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISharedFlow OnSubscription(ISharedFlow _this_onSubscription, IFunction2 action)
		{
			ISharedFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_onSubscription == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_onSubscription).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<ISharedFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("onSubscription.(Lkotlinx/coroutines/flow/SharedFlow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/SharedFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_onSubscription);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0001B80C File Offset: 0x00019A0C
		[Register("produceIn", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IReceiveChannel ProduceIn(IFlow _this_produceIn, ICoroutineScope scope)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_produceIn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_produceIn).Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : ((Java.Lang.Object)scope).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(FlowKt._members.StaticMethods.InvokeObjectMethod("produceIn.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_produceIn);
				GC.KeepAlive(scope);
			}
			return @object;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		[Obsolete("deprecated")]
		[Register("publish", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Publish(IFlow _this_publish)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_publish == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_publish).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("publish.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_publish);
			}
			return @object;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0001B928 File Offset: 0x00019B28
		[Obsolete("deprecated")]
		[Register("publish", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Publish(IFlow _this_publish, int bufferSize)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_publish == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_publish).Handle);
				ptr[1] = new JniArgumentValue(bufferSize);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("publish.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_publish);
			}
			return @object;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		[Obsolete("deprecated")]
		[Register("publishOn", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow PublishOn(IFlow _this_publishOn, ICoroutineContext context)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_publishOn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_publishOn).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("publishOn.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_publishOn);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0001BA58 File Offset: 0x00019C58
		[Register("receiveAsFlow", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ReceiveAsFlow(IReceiveChannel _this_receiveAsFlow)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_receiveAsFlow == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_receiveAsFlow).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("receiveAsFlow.(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_receiveAsFlow);
			}
			return @object;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		[Register("reduce", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"S",
			"T extends S"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Reduce(IFlow _this_reduce, IFunction3 operation, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_reduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_reduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("reduce.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_reduce);
				GC.KeepAlive(operation);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		[Obsolete("deprecated")]
		[Register("replay", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Replay(IFlow _this_replay)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_replay == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_replay).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("replay.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_replay);
			}
			return @object;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0001BC1C File Offset: 0x00019E1C
		[Obsolete("deprecated")]
		[Register("replay", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Replay(IFlow _this_replay, int bufferSize)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_replay == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_replay).Handle);
				ptr[1] = new JniArgumentValue(bufferSize);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("replay.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_replay);
			}
			return @object;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[Register("retry", "(Lkotlinx/coroutines/flow/Flow;JLkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Retry(IFlow _this_retry, long retries, IFunction2 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_retry == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_retry).Handle);
				ptr[1] = new JniArgumentValue(retries);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("retry.(Lkotlinx/coroutines/flow/Flow;JLkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_retry);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0001BD64 File Offset: 0x00019F64
		[Register("retryWhen", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow RetryWhen(IFlow _this_retryWhen, IFunction4 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_retryWhen == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_retryWhen).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("retryWhen.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function4;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_retryWhen);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0001BE08 File Offset: 0x0001A008
		[Register("runningFold", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow RunningFold(IFlow _this_runningFold, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningFold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningFold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("runningFold.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_runningFold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		[Register("runningReduce", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow RunningReduce(IFlow _this_runningReduce, IFunction3 operation)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_runningReduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_runningReduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("runningReduce.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_runningReduce);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0001BF7C File Offset: 0x0001A17C
		[Register("sample", "(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Sample(IFlow _this_sample, long periodMillis)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_sample == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_sample).Handle);
				ptr[1] = new JniArgumentValue(periodMillis);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("sample.(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_sample);
			}
			return @object;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0001C008 File Offset: 0x0001A208
		[Register("scan", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow Scan(IFlow _this_scan, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scan == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scan).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("scan.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scan);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		[Obsolete("deprecated")]
		[Register("scanFold", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow ScanFold(IFlow _this_scanFold, [Nullable(2)] Java.Lang.Object initial, IFunction3 operation)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initial);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scanFold == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scanFold).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("scanFold.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_scanFold);
				GC.KeepAlive(initial);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		[Obsolete("deprecated")]
		[Register("scanReduce", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow ScanReduce(IFlow _this_scanReduce, IFunction3 operation)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_scanReduce == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_scanReduce).Handle);
				ptr[1] = new JniArgumentValue((operation == null) ? IntPtr.Zero : ((Java.Lang.Object)operation).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("scanReduce.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_scanReduce);
				GC.KeepAlive(operation);
			}
			return @object;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0001C24C File Offset: 0x0001A44C
		[Register("shareIn", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/flow/SharingStarted;I)Lkotlinx/coroutines/flow/SharedFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static ISharedFlow ShareIn(IFlow _this_shareIn, ICoroutineScope scope, ISharingStarted started, int replay)
		{
			ISharedFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_shareIn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_shareIn).Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : ((Java.Lang.Object)scope).Handle);
				ptr[2] = new JniArgumentValue((started == null) ? IntPtr.Zero : ((Java.Lang.Object)started).Handle);
				ptr[3] = new JniArgumentValue(replay);
				@object = Java.Lang.Object.GetObject<ISharedFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("shareIn.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/flow/SharingStarted;I)Lkotlinx/coroutines/flow/SharedFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_shareIn);
				GC.KeepAlive(scope);
				GC.KeepAlive(started);
			}
			return @object;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0001C338 File Offset: 0x0001A538
		[Register("single", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Single(IFlow _this_single, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_single == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_single).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("single.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_single);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		[Register("singleOrNull", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object SingleOrNull(IFlow _this_singleOrNull, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_singleOrNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_singleOrNull).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("singleOrNull.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_singleOrNull);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0001C480 File Offset: 0x0001A680
		[Obsolete("deprecated")]
		[Register("skip", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Skip(IFlow _this_skip, int count)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_skip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_skip).Handle);
				ptr[1] = new JniArgumentValue(count);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("skip.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_skip);
			}
			return @object;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0001C50C File Offset: 0x0001A70C
		[Obsolete("deprecated")]
		[Register("startWith", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow StartWith(IFlow _this_startWith, IFlow other)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_startWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_startWith).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("startWith.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_startWith);
				GC.KeepAlive(other);
			}
			return @object;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		[Obsolete("deprecated")]
		[Register("startWith", "(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow StartWith(IFlow _this_startWith, [Nullable(2)] Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_startWith == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_startWith).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("startWith.(Lkotlinx/coroutines/flow/Flow;Ljava/lang/Object;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_startWith);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001C650 File Offset: 0x0001A850
		[Register("stateIn", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object StateIn(IFlow _this_stateIn, ICoroutineScope scope, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_stateIn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_stateIn).Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : ((Java.Lang.Object)scope).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("stateIn.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_stateIn);
				GC.KeepAlive(scope);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001C724 File Offset: 0x0001A924
		[Register("stateIn", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/flow/SharingStarted;Ljava/lang/Object;)Lkotlinx/coroutines/flow/StateFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IStateFlow StateIn(IFlow _this_stateIn, ICoroutineScope scope, ISharingStarted started, [Nullable(2)] Java.Lang.Object initialValue)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(initialValue);
			IStateFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_stateIn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_stateIn).Handle);
				ptr[1] = new JniArgumentValue((scope == null) ? IntPtr.Zero : ((Java.Lang.Object)scope).Handle);
				ptr[2] = new JniArgumentValue((started == null) ? IntPtr.Zero : ((Java.Lang.Object)started).Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IStateFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("stateIn.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/CoroutineScope;Lkotlinx/coroutines/flow/SharingStarted;Ljava/lang/Object;)Lkotlinx/coroutines/flow/StateFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_stateIn);
				GC.KeepAlive(scope);
				GC.KeepAlive(started);
				GC.KeepAlive(initialValue);
			}
			return @object;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0001C824 File Offset: 0x0001AA24
		[Obsolete("deprecated")]
		[Register("subscribe", "(Lkotlinx/coroutines/flow/Flow;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Subscribe(IFlow _this_subscribe)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subscribe == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_subscribe).Handle);
				FlowKt._members.StaticMethods.InvokeVoidMethod("subscribe.(Lkotlinx/coroutines/flow/Flow;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_subscribe);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001C88C File Offset: 0x0001AA8C
		[Obsolete("deprecated")]
		[Register("subscribe", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Subscribe(IFlow _this_subscribe, IFunction2 onEach)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subscribe == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_subscribe).Handle);
				ptr[1] = new JniArgumentValue((onEach == null) ? IntPtr.Zero : ((Java.Lang.Object)onEach).Handle);
				FlowKt._members.StaticMethods.InvokeVoidMethod("subscribe.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_subscribe);
				GC.KeepAlive(onEach);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001C920 File Offset: 0x0001AB20
		[Obsolete("deprecated")]
		[Register("subscribe", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static void Subscribe(IFlow _this_subscribe, IFunction2 onEach, IFunction2 onError)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subscribe == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_subscribe).Handle);
				ptr[1] = new JniArgumentValue((onEach == null) ? IntPtr.Zero : ((Java.Lang.Object)onEach).Handle);
				ptr[2] = new JniArgumentValue((onError == null) ? IntPtr.Zero : ((Java.Lang.Object)onError).Handle);
				FlowKt._members.StaticMethods.InvokeVoidMethod("subscribe.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_subscribe);
				GC.KeepAlive(onEach);
				GC.KeepAlive(onError);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		[Obsolete("deprecated")]
		[Register("subscribeOn", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow SubscribeOn(IFlow _this_subscribeOn, ICoroutineContext context)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_subscribeOn == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_subscribeOn).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("subscribeOn.(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/CoroutineContext;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_subscribeOn);
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Obsolete("deprecated")]
		[Register("switchMap", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow SwitchMap(IFlow _this_switchMap, IFunction2 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_switchMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_switchMap).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("switchMap.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_switchMap);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0001CB2C File Offset: 0x0001AD2C
		[Register("take", "(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Take(IFlow _this_take, int count)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_take == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_take).Handle);
				ptr[1] = new JniArgumentValue(count);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("take.(Lkotlinx/coroutines/flow/Flow;I)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_take);
			}
			return @object;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
		[Register("takeWhile", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow TakeWhile(IFlow _this_takeWhile, IFunction2 predicate)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_takeWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_takeWhile).Handle);
				ptr[1] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("takeWhile.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_takeWhile);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0001CC5C File Offset: 0x0001AE5C
		[Register("timeout-HG0u8IE", "(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow Timeout(IFlow _this_timeout_u2dHG0u8IE, long timeout)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_timeout_u2dHG0u8IE == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_timeout_u2dHG0u8IE).Handle);
				ptr[1] = new JniArgumentValue(timeout);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("timeout-HG0u8IE.(Lkotlinx/coroutines/flow/Flow;J)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_timeout_u2dHG0u8IE);
			}
			return @object;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
		[Register("toCollection", "(Lkotlinx/coroutines/flow/Flow;Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"C extends java.util.Collection<? super T>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToCollection(IFlow _this_toCollection, Java.Lang.Object destination, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toCollection == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toCollection).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Lkotlinx/coroutines/flow/Flow;Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toCollection);
				GC.KeepAlive(destination);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		[Register("toList", "(Lkotlinx/coroutines/flow/Flow;Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToList(IFlow _this_toList, System.Collections.IList destination, IContinuation _completion)
		{
			IntPtr intPtr = JavaList.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toList).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("toList.(Lkotlinx/coroutines/flow/Flow;Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toList);
				GC.KeepAlive(destination);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0001CE88 File Offset: 0x0001B088
		[Register("toSet", "(Lkotlinx/coroutines/flow/Flow;Ljava/util/Set;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToSet(IFlow _this_toSet, System.Collections.ICollection destination, IContinuation _completion)
		{
			IntPtr intPtr = JavaSet.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toSet).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(FlowKt._members.StaticMethods.InvokeObjectMethod("toSet.(Lkotlinx/coroutines/flow/Flow;Ljava/util/Set;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toSet);
				GC.KeepAlive(destination);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0001CF58 File Offset: 0x0001B158
		[Register("transform", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow Transform(IFlow _this_transform, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_transform == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_transform).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("transform.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_transform);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001CFFC File Offset: 0x0001B1FC
		[Register("transformLatest", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow TransformLatest(IFlow _this_transformLatest, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_transformLatest == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_transformLatest).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("transformLatest.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_transformLatest);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		[Register("transformWhile", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow TransformWhile(IFlow _this_transformWhile, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_transformWhile == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_transformWhile).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("transformWhile.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_transformWhile);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001D144 File Offset: 0x0001B344
		[Register("unsafeTransform", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T",
			"R"
		})]
		public unsafe static IFlow UnsafeTransform(IFlow _this_unsafeTransform, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_unsafeTransform == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_unsafeTransform).Handle);
				ptr[1] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("unsafeTransform.(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_unsafeTransform);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0001D1E8 File Offset: 0x0001B3E8
		[Register("withIndex", "(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IFlow WithIndex(IFlow _this_withIndex)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_withIndex == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_withIndex).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("withIndex.(Lkotlinx/coroutines/flow/Flow;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_withIndex);
			}
			return @object;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0001D260 File Offset: 0x0001B460
		[Register("zip", "(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T1",
			"T2",
			"R"
		})]
		public unsafe static IFlow Zip(IFlow _this_zip, IFlow other, IFunction3 transform)
		{
			IFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IFlow>(FlowKt._members.StaticMethods.InvokeObjectMethod("zip.(Lkotlinx/coroutines/flow/Flow;Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/flow/Flow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x04000277 RID: 631
		[Register("DEFAULT_CONCURRENCY_PROPERTY_NAME")]
		public const string DefaultConcurrencyPropertyName = "kotlinx.coroutines.flow.defaultConcurrency";

		// Token: 0x04000278 RID: 632
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/FlowKt", typeof(FlowKt));
	}
}
