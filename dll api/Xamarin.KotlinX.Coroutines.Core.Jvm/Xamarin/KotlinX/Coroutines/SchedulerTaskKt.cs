using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000080 RID: 128
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/SchedulerTaskKt", DoNotGenerateAcw = true)]
	public sealed class SchedulerTaskKt : Java.Lang.Object
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00013748 File Offset: 0x00011948
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulerTaskKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001376C File Offset: 0x0001196C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulerTaskKt._members;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00013774 File Offset: 0x00011974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulerTaskKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00013798 File Offset: 0x00011998
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulerTaskKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000137A4 File Offset: 0x000119A4
		internal SchedulerTaskKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000137B0 File Offset: 0x000119B0
		[Register("getTaskContext", "(Ljava/lang/Object;)Lkotlinx/coroutines/scheduling/TaskContext;", "")]
		public unsafe static Java.Lang.Object GetTaskContext(Java.Lang.Object obj)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(SchedulerTaskKt._members.StaticMethods.InvokeObjectMethod("getTaskContext.(Ljava/lang/Object;)Lkotlinx/coroutines/scheduling/TaskContext;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return @object;
		}

		// Token: 0x04000209 RID: 521
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/SchedulerTaskKt", typeof(SchedulerTaskKt));
	}
}
