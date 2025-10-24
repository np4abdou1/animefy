using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200009A RID: 154
	[Register("kotlin/Result", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class Result : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000A258 File Offset: 0x00008458
		internal static IntPtr class_ref
		{
			get
			{
				return Result._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000A27C File Offset: 0x0000847C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return Result._members;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000A284 File Offset: 0x00008484
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Result._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return Result._members.ManagedPeerType;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000A2B4 File Offset: 0x000084B4
		internal Result(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400014F RID: 335
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Result", typeof(Result));
	}
}
