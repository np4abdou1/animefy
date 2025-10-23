using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.KotlinX.Coroutines.Channels;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000BB RID: 187
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharedFlowKt", DoNotGenerateAcw = true)]
	public sealed class SharedFlowKt : Java.Lang.Object
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0001F10C File Offset: 0x0001D30C
		internal static IntPtr class_ref
		{
			get
			{
				return SharedFlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0001F130 File Offset: 0x0001D330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SharedFlowKt._members;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0001F138 File Offset: 0x0001D338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SharedFlowKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0001F15C File Offset: 0x0001D35C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SharedFlowKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001F168 File Offset: 0x0001D368
		internal SharedFlowKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001F174 File Offset: 0x0001D374
		[Register("MutableSharedFlow", "(IILkotlinx/coroutines/channels/BufferOverflow;)Lkotlinx/coroutines/flow/MutableSharedFlow;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static IMutableSharedFlow MutableSharedFlow(int replay, int extraBufferCapacity, BufferOverflow onBufferOverflow)
		{
			IMutableSharedFlow @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(replay);
				ptr[1] = new JniArgumentValue(extraBufferCapacity);
				ptr[2] = new JniArgumentValue((onBufferOverflow == null) ? IntPtr.Zero : onBufferOverflow.Handle);
				@object = Java.Lang.Object.GetObject<IMutableSharedFlow>(SharedFlowKt._members.StaticMethods.InvokeObjectMethod("MutableSharedFlow.(IILkotlinx/coroutines/channels/BufferOverflow;)Lkotlinx/coroutines/flow/MutableSharedFlow;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(onBufferOverflow);
			}
			return @object;
		}

		// Token: 0x040002B9 RID: 697
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharedFlowKt", typeof(SharedFlowKt));
	}
}
