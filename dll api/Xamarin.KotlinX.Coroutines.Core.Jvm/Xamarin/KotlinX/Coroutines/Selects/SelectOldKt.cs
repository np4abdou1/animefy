using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Selects
{
	// Token: 0x0200009F RID: 159
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/selects/SelectOldKt", DoNotGenerateAcw = true)]
	public sealed class SelectOldKt : Java.Lang.Object
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x000169DC File Offset: 0x00014BDC
		internal static IntPtr class_ref
		{
			get
			{
				return SelectOldKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00016A00 File Offset: 0x00014C00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SelectOldKt._members;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00016A08 File Offset: 0x00014C08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SelectOldKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00016A2C File Offset: 0x00014C2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SelectOldKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00016A38 File Offset: 0x00014C38
		internal SelectOldKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400026E RID: 622
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/selects/SelectOldKt", typeof(SelectOldKt));
	}
}
