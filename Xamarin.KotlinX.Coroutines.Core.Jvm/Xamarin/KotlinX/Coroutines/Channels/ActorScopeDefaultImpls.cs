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
	// Token: 0x020000CA RID: 202
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ActorScope$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ActorScopeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00021970 File Offset: 0x0001FB70
		internal static IntPtr class_ref
		{
			get
			{
				return ActorScopeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00021994 File Offset: 0x0001FB94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActorScopeDefaultImpls._members;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0002199C File Offset: 0x0001FB9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActorScopeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x000219C0 File Offset: 0x0001FBC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActorScopeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000219CC File Offset: 0x0001FBCC
		internal ActorScopeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000219D8 File Offset: 0x0001FBD8
		[Obsolete("deprecated")]
		[Register("getOnReceiveOrNull", "(Lkotlinx/coroutines/channels/ActorScope;)Lkotlinx/coroutines/selects/SelectClause1;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static ISelectClause1 GetOnReceiveOrNull(IActorScope _this)
		{
			ISelectClause1 @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<ISelectClause1>(ActorScopeDefaultImpls._members.StaticMethods.InvokeObjectMethod("getOnReceiveOrNull.(Lkotlinx/coroutines/channels/ActorScope;)Lkotlinx/coroutines/selects/SelectClause1;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00021A50 File Offset: 0x0001FC50
		[Obsolete("deprecated")]
		[Register("poll", "(Lkotlinx/coroutines/channels/ActorScope;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object Poll(IActorScope _this)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ActorScopeDefaultImpls._members.StaticMethods.InvokeObjectMethod("poll.(Lkotlinx/coroutines/channels/ActorScope;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[Obsolete("deprecated")]
		[Register("receiveOrNull", "(Lkotlinx/coroutines/channels/ActorScope;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		[return: Nullable(2)]
		public unsafe static Java.Lang.Object ReceiveOrNull(IActorScope _this, IContinuation _completion)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue((_completion == null) ? IntPtr.Zero : ((Java.Lang.Object)_completion).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ActorScopeDefaultImpls._members.StaticMethods.InvokeObjectMethod("receiveOrNull.(Lkotlinx/coroutines/channels/ActorScope;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
				GC.KeepAlive(_completion);
			}
			return @object;
		}

		// Token: 0x040002C9 RID: 713
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ActorScope$DefaultImpls", typeof(ActorScopeDefaultImpls));
	}
}
