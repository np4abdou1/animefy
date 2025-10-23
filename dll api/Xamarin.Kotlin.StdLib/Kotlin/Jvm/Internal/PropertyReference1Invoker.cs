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
	// Token: 0x020001C5 RID: 453
	[Register("kotlin/jvm/internal/PropertyReference1", DoNotGenerateAcw = true)]
	internal class PropertyReference1Invoker : PropertyReference1, IKProperty1, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x0600165F RID: 5727 RVA: 0x00048633 File Offset: 0x00046833
		public PropertyReference1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0004863D File Offset: 0x0004683D
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference1Invoker._members;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00048644 File Offset: 0x00046844
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400071E RID: 1822
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference1", typeof(PropertyReference1Invoker));
	}
}
