using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001BA RID: 442
	[Register("kotlin/jvm/internal/MutablePropertyReference1", DoNotGenerateAcw = true)]
	internal class MutablePropertyReference1Invoker : MutablePropertyReference1, IKMutableProperty1, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty1, IFunction1, IFunction
	{
		// Token: 0x060015D1 RID: 5585 RVA: 0x00046A1B File Offset: 0x00044C1B
		public MutablePropertyReference1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00046A25 File Offset: 0x00044C25
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference1Invoker._members;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00046A2C File Offset: 0x00044C2C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040006FE RID: 1790
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference1", typeof(MutablePropertyReference1Invoker));
	}
}
