using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B3 RID: 179
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharingStarted$Companion", DoNotGenerateAcw = true)]
	public sealed class SharingStartedCompanion : Java.Lang.Object
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0001E648 File Offset: 0x0001C848
		internal static IntPtr class_ref
		{
			get
			{
				return SharingStartedCompanion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0001E66C File Offset: 0x0001C86C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SharingStartedCompanion._members;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0001E674 File Offset: 0x0001C874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SharingStartedCompanion._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0001E698 File Offset: 0x0001C898
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SharingStartedCompanion._members.ManagedPeerType;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		internal SharingStartedCompanion(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
		public ISharingStarted Eagerly
		{
			[Register("getEagerly", "()Lkotlinx/coroutines/flow/SharingStarted;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISharingStarted>(SharingStartedCompanion._members.InstanceMethods.InvokeNonvirtualObjectMethod("getEagerly.()Lkotlinx/coroutines/flow/SharingStarted;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0001E6E4 File Offset: 0x0001C8E4
		public ISharingStarted Lazily
		{
			[Register("getLazily", "()Lkotlinx/coroutines/flow/SharingStarted;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISharingStarted>(SharingStartedCompanion._members.InstanceMethods.InvokeNonvirtualObjectMethod("getLazily.()Lkotlinx/coroutines/flow/SharingStarted;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001E718 File Offset: 0x0001C918
		[Register("WhileSubscribed", "(JJ)Lkotlinx/coroutines/flow/SharingStarted;", "")]
		public unsafe ISharingStarted WhileSubscribed(long stopTimeoutMillis, long replayExpirationMillis)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(stopTimeoutMillis);
			ptr[1] = new JniArgumentValue(replayExpirationMillis);
			return Java.Lang.Object.GetObject<ISharingStarted>(SharingStartedCompanion._members.InstanceMethods.InvokeNonvirtualObjectMethod("WhileSubscribed.(JJ)Lkotlinx/coroutines/flow/SharingStarted;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002A9 RID: 681
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingStarted$Companion", typeof(SharingStartedCompanion));
	}
}
