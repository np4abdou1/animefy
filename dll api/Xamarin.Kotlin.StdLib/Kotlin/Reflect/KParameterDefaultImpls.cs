using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x0200011B RID: 283
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KParameter$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KParameterDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00030C60 File Offset: 0x0002EE60
		internal static IntPtr class_ref
		{
			get
			{
				return KParameterDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x00030C84 File Offset: 0x0002EE84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KParameterDefaultImpls._members;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KParameterDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00030CB0 File Offset: 0x0002EEB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KParameterDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00030CBC File Offset: 0x0002EEBC
		internal KParameterDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000417 RID: 1047
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KParameter$DefaultImpls", typeof(KParameterDefaultImpls));
	}
}
