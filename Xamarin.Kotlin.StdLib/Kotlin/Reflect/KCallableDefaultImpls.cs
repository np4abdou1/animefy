using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x020000FE RID: 254
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KCallable$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KCallableDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00028EDC File Offset: 0x000270DC
		internal static IntPtr class_ref
		{
			get
			{
				return KCallableDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00028F00 File Offset: 0x00027100
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KCallableDefaultImpls._members;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00028F08 File Offset: 0x00027108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KCallableDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00028F2C File Offset: 0x0002712C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KCallableDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00028F38 File Offset: 0x00027138
		internal KCallableDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400026C RID: 620
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KCallable$DefaultImpls", typeof(KCallableDefaultImpls));
	}
}
