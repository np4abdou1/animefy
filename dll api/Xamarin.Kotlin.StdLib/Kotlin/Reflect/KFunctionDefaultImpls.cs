using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000108 RID: 264
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KFunction$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KFunctionDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0002A700 File Offset: 0x00028900
		internal static IntPtr class_ref
		{
			get
			{
				return KFunctionDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0002A724 File Offset: 0x00028924
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KFunctionDefaultImpls._members;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0002A72C File Offset: 0x0002892C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KFunctionDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0002A750 File Offset: 0x00028950
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KFunctionDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0002A75C File Offset: 0x0002895C
		internal KFunctionDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040002BE RID: 702
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KFunction$DefaultImpls", typeof(KFunctionDefaultImpls));
	}
}
