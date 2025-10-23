using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000096 RID: 150
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/PropertyReferenceDelegatesKt", DoNotGenerateAcw = true)]
	public sealed class PropertyReferenceDelegatesKt : Java.Lang.Object
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000A18C File Offset: 0x0000838C
		internal static IntPtr class_ref
		{
			get
			{
				return PropertyReferenceDelegatesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000A1B0 File Offset: 0x000083B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PropertyReferenceDelegatesKt._members;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PropertyReferenceDelegatesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000A1DC File Offset: 0x000083DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PropertyReferenceDelegatesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000A1E8 File Offset: 0x000083E8
		internal PropertyReferenceDelegatesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400014B RID: 331
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/PropertyReferenceDelegatesKt", typeof(PropertyReferenceDelegatesKt));
	}
}
