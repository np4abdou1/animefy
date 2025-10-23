using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharingStartedKt", DoNotGenerateAcw = true)]
	public sealed class SharingStartedKt : Java.Lang.Object
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0001F3EC File Offset: 0x0001D5EC
		internal static IntPtr class_ref
		{
			get
			{
				return SharingStartedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0001F410 File Offset: 0x0001D610
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SharingStartedKt._members;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0001F418 File Offset: 0x0001D618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SharingStartedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0001F43C File Offset: 0x0001D63C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SharingStartedKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0001F448 File Offset: 0x0001D648
		internal SharingStartedKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0001F454 File Offset: 0x0001D654
		[Register("WhileSubscribed-5qebJ5I", "(Lkotlinx/coroutines/flow/SharingStarted$Companion;JJ)Lkotlinx/coroutines/flow/SharingStarted;", "")]
		public unsafe static ISharingStarted WhileSubscribed(SharingStartedCompanion obj, long stopTimeout, long replayExpiration)
		{
			ISharingStarted @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				ptr[1] = new JniArgumentValue(stopTimeout);
				ptr[2] = new JniArgumentValue(replayExpiration);
				@object = Java.Lang.Object.GetObject<ISharingStarted>(SharingStartedKt._members.StaticMethods.InvokeObjectMethod("WhileSubscribed-5qebJ5I.(Lkotlinx/coroutines/flow/SharingStarted$Companion;JJ)Lkotlinx/coroutines/flow/SharingStarted;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x040002BB RID: 699
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingStartedKt", typeof(SharingStartedKt));
	}
}
