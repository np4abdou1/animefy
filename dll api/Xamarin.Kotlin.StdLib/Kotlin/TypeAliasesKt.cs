using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/TypeAliasesKt", DoNotGenerateAcw = true)]
	public sealed class TypeAliasesKt : Java.Lang.Object
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000AAB4 File Offset: 0x00008CB4
		internal static IntPtr class_ref
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypeAliasesKt._members;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypeAliasesKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000AB04 File Offset: 0x00008D04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypeAliasesKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000AB10 File Offset: 0x00008D10
		internal TypeAliasesKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000159 RID: 345
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/TypeAliasesKt", typeof(TypeAliasesKt));
	}
}
