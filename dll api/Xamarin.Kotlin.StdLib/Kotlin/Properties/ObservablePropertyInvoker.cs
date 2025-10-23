using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Properties
{
	// Token: 0x0200014B RID: 331
	[Register("kotlin/properties/ObservableProperty", DoNotGenerateAcw = true)]
	internal class ObservablePropertyInvoker : ObservableProperty, IReadWriteProperty, IReadOnlyProperty, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x0003A043 File Offset: 0x00038243
		public ObservablePropertyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0003A04D File Offset: 0x0003824D
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ObservablePropertyInvoker._members;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0003A054 File Offset: 0x00038254
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ObservablePropertyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400059A RID: 1434
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/properties/ObservableProperty", typeof(ObservablePropertyInvoker));
	}
}
