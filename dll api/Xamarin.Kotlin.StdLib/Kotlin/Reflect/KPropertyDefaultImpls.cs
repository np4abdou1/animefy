using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000121 RID: 289
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KProperty$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KPropertyDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000314D8 File Offset: 0x0002F6D8
		internal static IntPtr class_ref
		{
			get
			{
				return KPropertyDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x000314FC File Offset: 0x0002F6FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KPropertyDefaultImpls._members;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00031504 File Offset: 0x0002F704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KPropertyDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00031528 File Offset: 0x0002F728
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KPropertyDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00031534 File Offset: 0x0002F734
		internal KPropertyDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400042D RID: 1069
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KProperty$DefaultImpls", typeof(KPropertyDefaultImpls));
	}
}
