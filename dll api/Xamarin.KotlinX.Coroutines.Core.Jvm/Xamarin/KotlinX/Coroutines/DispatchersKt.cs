using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000031 RID: 49
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DispatchersKt", DoNotGenerateAcw = true)]
	public sealed class DispatchersKt : Java.Lang.Object
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00004D7C File Offset: 0x00002F7C
		internal static IntPtr class_ref
		{
			get
			{
				return DispatchersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DispatchersKt._members;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00004DA8 File Offset: 0x00002FA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DispatchersKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00004DCC File Offset: 0x00002FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DispatchersKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004DD8 File Offset: 0x00002FD8
		internal DispatchersKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000026 RID: 38
		[Register("IO_PARALLELISM_PROPERTY_NAME")]
		public const string IoParallelismPropertyName = "kotlinx.coroutines.io.parallelism";

		// Token: 0x04000027 RID: 39
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DispatchersKt", typeof(DispatchersKt));
	}
}
