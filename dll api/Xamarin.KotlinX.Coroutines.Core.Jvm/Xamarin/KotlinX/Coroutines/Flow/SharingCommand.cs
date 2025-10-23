using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000BC RID: 188
	[NullableContext(2)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharingCommand", DoNotGenerateAcw = true)]
	public sealed class SharingCommand : Java.Lang.Enum
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0001F22C File Offset: 0x0001D42C
		[Register("START")]
		public static SharingCommand Start
		{
			get
			{
				return Java.Lang.Object.GetObject<SharingCommand>(SharingCommand._members.StaticFields.GetObjectValue("START.Lkotlinx/coroutines/flow/SharingCommand;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001F25C File Offset: 0x0001D45C
		[Register("STOP")]
		public static SharingCommand Stop
		{
			get
			{
				return Java.Lang.Object.GetObject<SharingCommand>(SharingCommand._members.StaticFields.GetObjectValue("STOP.Lkotlinx/coroutines/flow/SharingCommand;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0001F28C File Offset: 0x0001D48C
		[Register("STOP_AND_RESET_REPLAY_CACHE")]
		public static SharingCommand StopAndResetReplayCache
		{
			get
			{
				return Java.Lang.Object.GetObject<SharingCommand>(SharingCommand._members.StaticFields.GetObjectValue("STOP_AND_RESET_REPLAY_CACHE.Lkotlinx/coroutines/flow/SharingCommand;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		internal static IntPtr class_ref
		{
			get
			{
				return SharingCommand._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return SharingCommand._members;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SharingCommand._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0001F30C File Offset: 0x0001D50C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return SharingCommand._members.ManagedPeerType;
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0001F318 File Offset: 0x0001D518
		internal SharingCommand(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0001F324 File Offset: 0x0001D524
		[Register("valueOf", "(Ljava/lang/String;)Lkotlinx/coroutines/flow/SharingCommand;", "")]
		public unsafe static SharingCommand ValueOf(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			SharingCommand @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SharingCommand>(SharingCommand._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lkotlinx/coroutines/flow/SharingCommand;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0001F390 File Offset: 0x0001D590
		[Register("values", "()[Lkotlinx/coroutines/flow/SharingCommand;", "")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public static SharingCommand[] Values()
		{
			return (SharingCommand[])JNIEnv.GetArray(SharingCommand._members.StaticMethods.InvokeObjectMethod("values.()[Lkotlinx/coroutines/flow/SharingCommand;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(SharingCommand));
		}

		// Token: 0x040002BA RID: 698
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingCommand", typeof(SharingCommand));
	}
}
