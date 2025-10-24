using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Scheduling
{
	// Token: 0x020000A3 RID: 163
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/scheduling/TasksKt", DoNotGenerateAcw = true)]
	public sealed class TasksKt : Java.Lang.Object
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00016D34 File Offset: 0x00014F34
		internal static IntPtr class_ref
		{
			get
			{
				return TasksKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00016D58 File Offset: 0x00014F58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TasksKt._members;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00016D60 File Offset: 0x00014F60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TasksKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00016D84 File Offset: 0x00014F84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TasksKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00016D90 File Offset: 0x00014F90
		internal TasksKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00016D9C File Offset: 0x00014F9C
		[Register("isBlocking", "(Ljava/lang/Object;)Z", "")]
		public unsafe static bool IsBlocking(Java.Lang.Object obj)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
				result = TasksKt._members.StaticMethods.InvokeBooleanMethod("isBlocking.(Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x04000272 RID: 626
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/scheduling/TasksKt", typeof(TasksKt));
	}
}
