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
	// Token: 0x020000D0 RID: 208
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/Channel$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ChannelDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00022D24 File Offset: 0x00020F24
		internal static IntPtr class_ref
		{
			get
			{
				return ChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00022D48 File Offset: 0x00020F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChannelDefaultImpls._members;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00022D50 File Offset: 0x00020F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00022D74 File Offset: 0x00020F74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChannelDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00022D80 File Offset: 0x00020F80
		internal ChannelDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00022D8C File Offset: 0x00020F8C
		[Obsolete("deprecated")]
		[Register("getOnReceiveOrNull", "(Lkotlinx/coroutines/channels/Channel;)Lkotlinx/coroutines/selects/SelectClause1;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ISelectClause1 GetOnReceiveOrNull(IChannel _this)
		{
			ISelectClause1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<ISelectClause1>(ChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("getOnReceiveOrNull.(Lkotlinx/coroutines/channels/Channel;)Lkotlinx/coroutines/selects/SelectClause1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00022E04 File Offset: 0x00021004
		[Obsolete("deprecated")]
		[Register("offer", "(Lkotlinx/coroutines/channels/Channel;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static bool Offer(IChannel _this, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ChannelDefaultImpls._members.StaticMethods.InvokeBooleanMethod("offer.(Lkotlinx/coroutines/channels/Channel;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00022E94 File Offset: 0x00021094
		[Obsolete("deprecated")]
		[Register("poll", "(Lkotlinx/coroutines/channels/Channel;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Poll(IChannel _this)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("poll.(Lkotlinx/coroutines/channels/Channel;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00022F0C File Offset: 0x0002110C
		[Obsolete("deprecated")]
		[Register("receiveOrNull", "(Lkotlinx/coroutines/channels/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReceiveOrNull(IChannel _this, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ChannelDefaultImpls._members.StaticMethods.InvokeObjectMethod("receiveOrNull.(Lkotlinx/coroutines/channels/Channel;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x040002FD RID: 765
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/Channel$DefaultImpls", typeof(ChannelDefaultImpls));
	}
}
