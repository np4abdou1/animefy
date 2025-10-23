using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C2 RID: 194
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/BufferedChannelKt", DoNotGenerateAcw = true)]
	public sealed class BufferedChannelKt : Java.Lang.Object
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0001FD18 File Offset: 0x0001DF18
		internal static IntPtr class_ref
		{
			get
			{
				return BufferedChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BufferedChannelKt._members;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0001FD44 File Offset: 0x0001DF44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BufferedChannelKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0001FD68 File Offset: 0x0001DF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BufferedChannelKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0001FD74 File Offset: 0x0001DF74
		internal BufferedChannelKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0001FD80 File Offset: 0x0001DF80
		[Register("createSegmentFunction", "()Lkotlin/reflect/KFunction;", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public static IKFunction CreateSegmentFunction()
		{
			return Java.Lang.Object.GetObject<IKFunction>(BufferedChannelKt._members.StaticMethods.InvokeObjectMethod("createSegmentFunction.()Lkotlin/reflect/KFunction;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002C0 RID: 704
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/BufferedChannelKt", typeof(BufferedChannelKt));
	}
}
