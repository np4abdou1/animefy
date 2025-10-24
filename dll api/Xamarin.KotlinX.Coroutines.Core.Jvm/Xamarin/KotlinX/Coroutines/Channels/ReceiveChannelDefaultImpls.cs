using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;
using Xamarin.KotlinX.Coroutines.Selects;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DC RID: 220
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ReceiveChannel$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ReceiveChannelDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00024914 File Offset: 0x00022B14
		internal static IntPtr class_ref
		{
			get
			{
				return ReceiveChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00024938 File Offset: 0x00022B38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ReceiveChannelDefaultImpls._members;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00024940 File Offset: 0x00022B40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ReceiveChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00024964 File Offset: 0x00022B64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ReceiveChannelDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00024970 File Offset: 0x00022B70
		internal ReceiveChannelDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002497C File Offset: 0x00022B7C
		[Obsolete("deprecated")]
		[Register("getOnReceiveOrNull", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/selects/SelectClause1;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ISelectClause1 GetOnReceiveOrNull(IReceiveChannel _this)
		{
			ISelectClause1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<ISelectClause1>(ReceiveChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("getOnReceiveOrNull.(Lkotlinx/coroutines/channels/ReceiveChannel;)Lkotlinx/coroutines/selects/SelectClause1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000249F4 File Offset: 0x00022BF4
		[Obsolete("deprecated")]
		[Register("poll", "(Lkotlinx/coroutines/channels/ReceiveChannel;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Poll(IReceiveChannel _this)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ReceiveChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("poll.(Lkotlinx/coroutines/channels/ReceiveChannel;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00024A6C File Offset: 0x00022C6C
		[Obsolete("deprecated")]
		[Register("receiveOrNull", "(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReceiveOrNull(IReceiveChannel p0, IContinuation p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ReceiveChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("receiveOrNull.(Lkotlinx/coroutines/channels/ReceiveChannel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000350 RID: 848
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ReceiveChannel$DefaultImpls", typeof(ReceiveChannelDefaultImpls));
	}
}
