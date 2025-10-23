using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000DF RID: 223
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/SendChannel$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class SendChannelDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00025370 File Offset: 0x00023570
		internal static IntPtr class_ref
		{
			get
			{
				return SendChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00025394 File Offset: 0x00023594
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SendChannelDefaultImpls._members;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002539C File Offset: 0x0002359C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SendChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x000253C0 File Offset: 0x000235C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SendChannelDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000253CC File Offset: 0x000235CC
		internal SendChannelDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000253D8 File Offset: 0x000235D8
		[Obsolete("deprecated")]
		[Register("offer", "(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static bool Offer(ISendChannel _this, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = SendChannelDefaultImpls._members.StaticMethods.InvokeBooleanMethod("offer.(Lkotlinx/coroutines/channels/SendChannel;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0400036B RID: 875
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/SendChannel$DefaultImpls", typeof(SendChannelDefaultImpls));
	}
}
