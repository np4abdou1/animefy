using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001B1 RID: 433
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/LocalVariableReferencesKt", DoNotGenerateAcw = true)]
	public sealed class LocalVariableReferencesKt : Java.Lang.Object
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00044B70 File Offset: 0x00042D70
		internal static IntPtr class_ref
		{
			get
			{
				return LocalVariableReferencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x00044B94 File Offset: 0x00042D94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocalVariableReferencesKt._members;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00044B9C File Offset: 0x00042D9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocalVariableReferencesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x00044BC0 File Offset: 0x00042DC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocalVariableReferencesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00044BCC File Offset: 0x00042DCC
		internal LocalVariableReferencesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006E4 RID: 1764
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/LocalVariableReferencesKt", typeof(LocalVariableReferencesKt));
	}
}
