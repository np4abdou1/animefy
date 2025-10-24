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
	// Token: 0x020001C3 RID: 451
	[Register("kotlin/jvm/internal/PropertyReference0", DoNotGenerateAcw = true)]
	internal class PropertyReference0Invoker : PropertyReference0, IKProperty0, IFunction0, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x06001643 RID: 5699 RVA: 0x00048009 File Offset: 0x00046209
		public PropertyReference0Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00048013 File Offset: 0x00046213
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference0Invoker._members;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0004801A File Offset: 0x0004621A
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference0Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000717 RID: 1815
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference0", typeof(PropertyReference0Invoker));
	}
}
