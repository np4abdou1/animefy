using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000CD RID: 205
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BroadcastChannel$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class BroadcastChannelDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000224E0 File Offset: 0x000206E0
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00022504 File Offset: 0x00020704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastChannelDefaultImpls._members;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002250C File Offset: 0x0002070C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastChannelDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00022530 File Offset: 0x00020730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastChannelDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0002253C File Offset: 0x0002073C
		internal BroadcastChannelDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00022548 File Offset: 0x00020748
		[Obsolete("deprecated")]
		[Register("offer", "(Lkotlinx/coroutines/channels/BroadcastChannel;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static bool Offer(IBroadcastChannel _this, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = BroadcastChannelDefaultImpls._members.StaticMethods.InvokeBooleanMethod("offer.(Lkotlinx/coroutines/channels/BroadcastChannel;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x040002E8 RID: 744
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BroadcastChannel$DefaultImpls", typeof(BroadcastChannelDefaultImpls));
	}
}
