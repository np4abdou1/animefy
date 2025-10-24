using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x02000272 RID: 626
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/contracts/ContractBuilder$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ContractBuilderDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0005E6D8 File Offset: 0x0005C8D8
		internal static IntPtr class_ref
		{
			get
			{
				return ContractBuilderDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0005E6FC File Offset: 0x0005C8FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContractBuilderDefaultImpls._members;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0005E704 File Offset: 0x0005C904
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContractBuilderDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0005E728 File Offset: 0x0005C928
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContractBuilderDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0005E734 File Offset: 0x0005C934
		internal ContractBuilderDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008B8 RID: 2232
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ContractBuilder$DefaultImpls", typeof(ContractBuilderDefaultImpls));
	}
}
