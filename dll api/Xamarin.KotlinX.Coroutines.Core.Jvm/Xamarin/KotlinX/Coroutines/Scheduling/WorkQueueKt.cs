using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Scheduling
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/scheduling/WorkQueueKt", DoNotGenerateAcw = true)]
	public sealed class WorkQueueKt : Java.Lang.Object
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00016E1C File Offset: 0x0001501C
		internal static IntPtr class_ref
		{
			get
			{
				return WorkQueueKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00016E40 File Offset: 0x00015040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WorkQueueKt._members;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00016E48 File Offset: 0x00015048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WorkQueueKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00016E6C File Offset: 0x0001506C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WorkQueueKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00016E78 File Offset: 0x00015078
		internal WorkQueueKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00016E84 File Offset: 0x00015084
		[Register("getMaskForStealingMode", "(Ljava/lang/Object;)I", "")]
		public unsafe static int GetMaskForStealingMode(Java.Lang.Object obj)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = WorkQueueKt._members.StaticMethods.InvokeInt32Method("getMaskForStealingMode.(Ljava/lang/Object;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x04000273 RID: 627
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/scheduling/WorkQueueKt", typeof(WorkQueueKt));
	}
}
