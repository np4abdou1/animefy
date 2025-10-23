using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x02000227 RID: 551
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/SerializableKt", DoNotGenerateAcw = true)]
	public sealed class SerializableKt : Java.Lang.Object
	{
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x00055E74 File Offset: 0x00054074
		internal static IntPtr class_ref
		{
			get
			{
				return SerializableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00055E98 File Offset: 0x00054098
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SerializableKt._members;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00055EA0 File Offset: 0x000540A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SerializableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00055EC4 File Offset: 0x000540C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SerializableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00055ED0 File Offset: 0x000540D0
		internal SerializableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/SerializableKt", typeof(SerializableKt));
	}
}
