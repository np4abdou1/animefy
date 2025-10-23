using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001C1 RID: 449
	[Register("kotlin/jvm/internal/PropertyReference", DoNotGenerateAcw = true)]
	internal class PropertyReferenceInvoker : PropertyReference, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001625 RID: 5669 RVA: 0x00047A77 File Offset: 0x00045C77
		public PropertyReferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00047A81 File Offset: 0x00045C81
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return PropertyReferenceInvoker._members;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00047A88 File Offset: 0x00045C88
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return PropertyReferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00047A94 File Offset: 0x00045C94
		[Nullable(2)]
		public override IKPropertyGetter Getter
		{
			[NullableContext(2)]
			[Register("getGetter", "()Lkotlin/reflect/KProperty$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(PropertyReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getGetter.()Lkotlin/reflect/KProperty$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00047AC8 File Offset: 0x00045CC8
		[NullableContext(2)]
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(PropertyReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000710 RID: 1808
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/PropertyReference", typeof(PropertyReferenceInvoker));
	}
}
