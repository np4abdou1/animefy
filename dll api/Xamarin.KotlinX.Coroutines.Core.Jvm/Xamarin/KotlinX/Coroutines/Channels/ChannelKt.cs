using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C4 RID: 196
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ChannelKt", DoNotGenerateAcw = true)]
	public sealed class ChannelKt : Java.Lang.Object
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0001FF8C File Offset: 0x0001E18C
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelKt._members;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001FFE8 File Offset: 0x0001E1E8
		internal ChannelKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		[Register("Channel", "(ILkotlinx/coroutines/channels/BufferOverflow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/channels/Channel;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static IChannel Channel(int capacity, BufferOverflow onBufferOverflow, [Nullable(2)] IFunction1 onUndeliveredElement)
		{
			IChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(capacity);
				ptr[1] = new JniArgumentValue((onBufferOverflow == null) ? IntPtr.Zero : onBufferOverflow.Handle);
				ptr[2] = new JniArgumentValue((onUndeliveredElement == null) ? IntPtr.Zero : ((Java.Lang.Object)onUndeliveredElement).Handle);
				@object = Java.Lang.Object.GetObject<IChannel>(ChannelKt._members.StaticMethods.InvokeObjectMethod("Channel.(ILkotlinx/coroutines/channels/BufferOverflow;Lkotlin/jvm/functions/Function1;)Lkotlinx/coroutines/channels/Channel;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(onBufferOverflow);
				GC.KeepAlive(onUndeliveredElement);
			}
			return @object;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000200AC File Offset: 0x0001E2AC
		[Register("getOrElse-WpGqRn0", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object GetOrElse(Java.Lang.Object obj, IFunction1 onFailure)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((onFailure == null) ? IntPtr.Zero : ((Java.Lang.Object)onFailure).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelKt._members.StaticMethods.InvokeObjectMethod("getOrElse-WpGqRn0.(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(onFailure);
			}
			return @object;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0002014C File Offset: 0x0001E34C
		[Register("onClosed-WpGqRn0", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object OnClosed(Java.Lang.Object obj, IFunction1 action)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelKt._members.StaticMethods.InvokeObjectMethod("onClosed-WpGqRn0.(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000201EC File Offset: 0x0001E3EC
		[Register("onFailure-WpGqRn0", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object OnFailure(Java.Lang.Object obj, IFunction1 action)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelKt._members.StaticMethods.InvokeObjectMethod("onFailure-WpGqRn0.(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002028C File Offset: 0x0001E48C
		[Register("onSuccess-WpGqRn0", "(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static Java.Lang.Object OnSuccess(Java.Lang.Object obj, IFunction1 action)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue((action == null) ? IntPtr.Zero : ((Java.Lang.Object)action).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelKt._members.StaticMethods.InvokeObjectMethod("onSuccess-WpGqRn0.(Ljava/lang/Object;Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
				GC.KeepAlive(action);
			}
			return @object;
		}

		// Token: 0x040002C2 RID: 706
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ChannelKt", typeof(ChannelKt));
	}
}
