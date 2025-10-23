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
	// Token: 0x020001B8 RID: 440
	[Register("kotlin/jvm/internal/MutablePropertyReference0", DoNotGenerateAcw = true)]
	internal class MutablePropertyReference0Invoker : MutablePropertyReference0, IKMutableProperty0, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty0, IFunction0, IFunction
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x000462AB File Offset: 0x000444AB
		public MutablePropertyReference0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000462B5 File Offset: 0x000444B5
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference0Invoker._members;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000462BC File Offset: 0x000444BC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040006F5 RID: 1781
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference0", typeof(MutablePropertyReference0Invoker));
	}
}
