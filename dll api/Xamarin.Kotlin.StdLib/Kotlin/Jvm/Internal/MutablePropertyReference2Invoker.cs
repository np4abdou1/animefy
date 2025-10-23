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
	// Token: 0x020001BC RID: 444
	[Register("kotlin/jvm/internal/MutablePropertyReference2", DoNotGenerateAcw = true)]
	internal class MutablePropertyReference2Invoker : MutablePropertyReference2, IKMutableProperty2, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKProperty2, IFunction2, IFunction
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00047183 File Offset: 0x00045383
		public MutablePropertyReference2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0004718D File Offset: 0x0004538D
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference2Invoker._members;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00047194 File Offset: 0x00045394
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReference2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000707 RID: 1799
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference2", typeof(MutablePropertyReference2Invoker));
	}
}
