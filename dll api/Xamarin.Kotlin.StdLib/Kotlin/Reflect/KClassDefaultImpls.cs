using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000101 RID: 257
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/reflect/KClass$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class KClassDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00029718 File Offset: 0x00027918
		internal static IntPtr class_ref
		{
			get
			{
				return KClassDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002973C File Offset: 0x0002793C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KClassDefaultImpls._members;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00029744 File Offset: 0x00027944
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KClassDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00029768 File Offset: 0x00027968
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KClassDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00029774 File Offset: 0x00027974
		internal KClassDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000287 RID: 647
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/reflect/KClass$DefaultImpls", typeof(KClassDefaultImpls));
	}
}
