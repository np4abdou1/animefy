using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000019 RID: 25
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/AbstractTimeSourceKt", DoNotGenerateAcw = true)]
	public sealed class AbstractTimeSourceKt : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000212C File Offset: 0x0000032C
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractTimeSourceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002150 File Offset: 0x00000350
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractTimeSourceKt._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002158 File Offset: 0x00000358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractTimeSourceKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000217C File Offset: 0x0000037C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractTimeSourceKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002188 File Offset: 0x00000388
		internal AbstractTimeSourceKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/AbstractTimeSourceKt", typeof(AbstractTimeSourceKt));
	}
}
