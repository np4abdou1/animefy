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
	// Token: 0x020001C7 RID: 455
	[Register("kotlin/jvm/internal/PropertyReference2", DoNotGenerateAcw = true)]
	internal class PropertyReference2Invoker : PropertyReference2, IKProperty2, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable, IKProperty, IKCallable, IKAnnotatedElement
	{
		// Token: 0x0600167A RID: 5754 RVA: 0x00048C1B File Offset: 0x00046E1B
		public PropertyReference2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00048C25 File Offset: 0x00046E25
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference2Invoker._members;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00048C2C File Offset: 0x00046E2C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReference2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000725 RID: 1829
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference2", typeof(PropertyReference2Invoker));
	}
}
