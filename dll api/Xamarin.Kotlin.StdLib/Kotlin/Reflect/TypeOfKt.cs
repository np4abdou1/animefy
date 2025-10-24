using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x0200013C RID: 316
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/TypeOfKt", DoNotGenerateAcw = true)]
	public sealed class TypeOfKt : Java.Lang.Object
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00037D4C File Offset: 0x00035F4C
		internal static IntPtr class_ref
		{
			get
			{
				return TypeOfKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00037D70 File Offset: 0x00035F70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeOfKt._members;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00037D78 File Offset: 0x00035F78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeOfKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00037D9C File Offset: 0x00035F9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeOfKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00037DA8 File Offset: 0x00035FA8
		internal TypeOfKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000570 RID: 1392
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/TypeOfKt", typeof(TypeOfKt));
	}
}
