using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C6 RID: 198
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ChannelsKt", DoNotGenerateAcw = true)]
	public sealed class ChannelsKt : Java.Lang.Object
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x000203CC File Offset: 0x0001E5CC
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x000203F0 File Offset: 0x0001E5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelsKt._members;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000203F8 File Offset: 0x0001E5F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002041C File Offset: 0x0001E61C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00020428 File Offset: 0x0001E628
		internal ChannelsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00020434 File Offset: 0x0001E634
		[Register("cancelConsumed", "(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/lang/Throwable;)V", "")]
		public unsafe static void CancelConsumed(IReceiveChannel _this_cancelConsumed, [Nullable(2)] Throwable cause)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_cancelConsumed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_cancelConsumed).Handle);
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				ChannelsKt._members.StaticMethods.InvokeVoidMethod("cancelConsumed.(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/lang/Throwable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(_this_cancelConsumed);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000204C4 File Offset: 0x0001E6C4
		[Obsolete("deprecated")]
		[Register("consume", "(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Consume(IBroadcastChannel _this_consume, IFunction1 block)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consume == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consume).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consume.(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consume);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00020568 File Offset: 0x0001E768
		[Register("consume", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"R"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Consume(IReceiveChannel _this_consume, IFunction1 block)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consume == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consume).Handle);
				ptr[1] = new JniArgumentValue((block == null) ? IntPtr.Zero : ((Java.Lang.Object)block).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consume.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consume);
				GC.KeepAlive(block);
			}
			return @object;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002060C File Offset: 0x0001E80C
		[Obsolete("deprecated")]
		[Register("consumeEach", "(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ConsumeEach(IBroadcastChannel _this_consumeEach, IFunction1 action, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consumeEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consumeEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consumeEach.(Lkotlinx/coroutines/channels/BroadcastChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consumeEach);
				GC.KeepAlive(action);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000206E0 File Offset: 0x0001E8E0
		[Register("consumeEach", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ConsumeEach(IReceiveChannel _this_consumeEach, IFunction1 action, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consumeEach == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consumeEach).Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consumeEach.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consumeEach);
				GC.KeepAlive(action);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000207B4 File Offset: 0x0001E9B4
		[Register("consumes", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlin/jvm/functions/Function1;", "")]
		public unsafe static IFunction1 Consumes(IReceiveChannel _this_consumes)
		{
			IFunction1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_consumes == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_consumes).Handle);
				@object = Java.Lang.Object.GetObject<IFunction1>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consumes.(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlin/jvm/functions/Function1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_consumes);
			}
			return @object;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002082C File Offset: 0x0001EA2C
		[Register("consumesAll", "([Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlin/jvm/functions/Function1;", "")]
		public unsafe static IFunction1 ConsumesAll(params IReceiveChannel[] channels)
		{
			IntPtr intPtr = JNIEnv.NewArray<IReceiveChannel>(channels);
			IFunction1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IFunction1>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("consumesAll.([Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlin/jvm/functions/Function1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (channels != null)
				{
					JNIEnv.CopyArray<IReceiveChannel>(intPtr, channels);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(channels);
			}
			return @object;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000208A8 File Offset: 0x0001EAA8
		[Register("distinctBy", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"K"
		})]
		public unsafe static IReceiveChannel DistinctBy(IReceiveChannel _this_distinctBy, ICoroutineContext context, IFunction2 selector)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_distinctBy == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_distinctBy).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((selector == null) ? IntPtr.Zero : ((Java.Lang.Object)selector).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("distinctBy.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_distinctBy);
				GC.KeepAlive(context);
				GC.KeepAlive(selector);
			}
			return @object;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002097C File Offset: 0x0001EB7C
		[Register("filter", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IReceiveChannel Filter(IReceiveChannel _this_filter, ICoroutineContext context, IFunction2 predicate)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filter == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filter).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((predicate == null) ? IntPtr.Zero : ((Java.Lang.Object)predicate).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("filter.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filter);
				GC.KeepAlive(context);
				GC.KeepAlive(predicate);
			}
			return @object;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00020A50 File Offset: 0x0001EC50
		[Register("filterNotNull", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IReceiveChannel FilterNotNull(IReceiveChannel _this_filterNotNull)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_filterNotNull == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_filterNotNull).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("filterNotNull.(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_filterNotNull);
			}
			return @object;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		[Register("map", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"R"
		})]
		public unsafe static IReceiveChannel Map(IReceiveChannel _this_map, ICoroutineContext context, IFunction2 transform)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_map == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_map).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("map.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_map);
				GC.KeepAlive(context);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00020B9C File Offset: 0x0001ED9C
		[Register("mapIndexed", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"R"
		})]
		public unsafe static IReceiveChannel MapIndexed(IReceiveChannel _this_mapIndexed, ICoroutineContext context, IFunction3 transform)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_mapIndexed == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_mapIndexed).Handle);
				ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[2] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("mapIndexed.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function3;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_mapIndexed);
				GC.KeepAlive(context);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Register("toChannel", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlinx/coroutines/channels/SendChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"C extends kotlinx.coroutines.channels.SendChannel<? super E>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToChannel(IReceiveChannel _this_toChannel, Java.Lang.Object destination, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toChannel == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toChannel).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("toChannel.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlinx/coroutines/channels/SendChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toChannel);
				GC.KeepAlive(destination);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00020D40 File Offset: 0x0001EF40
		[Register("toCollection", "(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"C extends java.util.Collection<? super E>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToCollection(IReceiveChannel _this_toCollection, Java.Lang.Object destination, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toCollection == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toCollection).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("toCollection.(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/util/Collection;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
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

		// Token: 0x060008F2 RID: 2290 RVA: 0x00020E10 File Offset: 0x0001F010
		[Register("toList", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToList(IReceiveChannel _this_toList, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toList == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toList).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("toList.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toList);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		[Register("toMap", "(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V",
			"M extends java.util.Map<? super K, ? super V>"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToMap(IReceiveChannel _this_toMap, Java.Lang.Object destination, IContinuation _completion)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(destination);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMap == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMap).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("toMap.(Lkotlinx/coroutines/channels/ReceiveChannel;Ljava/util/Map;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_toMap);
				GC.KeepAlive(destination);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00020F84 File Offset: 0x0001F184
		[Register("toMutableSet", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ToMutableSet(IReceiveChannel _this_toMutableSet, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_toMutableSet == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_toMutableSet).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("toMutableSet.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_toMutableSet);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00021028 File Offset: 0x0001F228
		[Register("trySendBlocking", "(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static Java.Lang.Object TrySendBlocking(ISendChannel _this_trySendBlocking, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_trySendBlocking == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_trySendBlocking).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("trySendBlocking.(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/Object;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this_trySendBlocking);
				GC.KeepAlive(element);
			}
			return @object;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000210C8 File Offset: 0x0001F2C8
		[Register("zip", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E",
			"R",
			"V"
		})]
		public unsafe static IReceiveChannel Zip(IReceiveChannel _this_zip, IReceiveChannel other, ICoroutineContext context, IFunction2 transform)
		{
			IReceiveChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this_zip == null) ? IntPtr.Zero : ((Java.Lang.Object)_this_zip).Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : ((Java.Lang.Object)other).Handle);
				ptr[2] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((Java.Lang.Object)context).Handle);
				ptr[3] = new JniArgumentValue((transform == null) ? IntPtr.Zero : ((Java.Lang.Object)transform).Handle);
				@object = Java.Lang.Object.GetObject<IReceiveChannel>(ChannelsKt._members.StaticMethods.InvokeObjectMethod("zip.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/CoroutineContext;Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/channels/ReceiveChannel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this_zip);
				GC.KeepAlive(other);
				GC.KeepAlive(context);
				GC.KeepAlive(transform);
			}
			return @object;
		}

		// Token: 0x040002C4 RID: 708
		[Register("DEFAULT_CLOSE_MESSAGE")]
		public const string DefaultCloseMessage = "Channel was closed";

		// Token: 0x040002C5 RID: 709
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelsKt", typeof(ChannelsKt));
	}
}
