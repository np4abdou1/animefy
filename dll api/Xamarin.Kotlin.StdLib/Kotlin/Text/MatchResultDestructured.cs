using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000E5 RID: 229
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/MatchResult$Destructured", DoNotGenerateAcw = true)]
	public sealed class MatchResultDestructured : Java.Lang.Object
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00013D20 File Offset: 0x00011F20
		internal static IntPtr class_ref
		{
			get
			{
				return MatchResultDestructured._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00013D44 File Offset: 0x00011F44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MatchResultDestructured._members;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00013D4C File Offset: 0x00011F4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MatchResultDestructured._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00013D70 File Offset: 0x00011F70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MatchResultDestructured._members.ManagedPeerType;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00013D7C File Offset: 0x00011F7C
		internal MatchResultDestructured(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00013D88 File Offset: 0x00011F88
		public IMatchResult Match
		{
			[Register("getMatch", "()Lkotlin/text/MatchResult;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IMatchResult>(MatchResultDestructured._members.InstanceMethods.InvokeNonvirtualObjectMethod("getMatch.()Lkotlin/text/MatchResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00013DBC File Offset: 0x00011FBC
		[Register("toList", "()Ljava/util/List;", "")]
		public IList<string> ToList()
		{
			return JavaList<string>.FromJniHandle(MatchResultDestructured._members.InstanceMethods.InvokeNonvirtualObjectMethod("toList.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000218 RID: 536
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/MatchResult$Destructured", typeof(MatchResultDestructured));
	}
}
