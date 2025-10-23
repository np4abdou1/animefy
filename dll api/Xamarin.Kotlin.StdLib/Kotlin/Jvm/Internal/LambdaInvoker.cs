using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AF RID: 431
	[Register("kotlin/jvm/internal/Lambda", DoNotGenerateAcw = true)]
	internal class LambdaInvoker : Lambda, IFunctionBase, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600153E RID: 5438 RVA: 0x000449D7 File Offset: 0x00042BD7
		public LambdaInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000449E1 File Offset: 0x00042BE1
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return LambdaInvoker._members;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000449E8 File Offset: 0x00042BE8
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return LambdaInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040006E1 RID: 1761
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/Lambda", typeof(LambdaInvoker));
	}
}
