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
	// Token: 0x020001B6 RID: 438
	[Register("kotlin/jvm/internal/MutablePropertyReference", DoNotGenerateAcw = true)]
	internal class MutablePropertyReferenceInvoker : MutablePropertyReference, IKMutableProperty, IKProperty, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x00045BCB File Offset: 0x00043DCB
		public MutablePropertyReferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00045BD5 File Offset: 0x00043DD5
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReferenceInvoker._members;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00045BDC File Offset: 0x00043DDC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return MutablePropertyReferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00045BE8 File Offset: 0x00043DE8
		[Nullable(2)]
		public override IKMutablePropertySetter Setter
		{
			[NullableContext(2)]
			[Register("getSetter", "()Lkotlin/reflect/KMutableProperty$Setter;", "GetGetSetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKMutablePropertySetter>(MutablePropertyReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSetter.()Lkotlin/reflect/KMutableProperty$Setter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00045C1C File Offset: 0x00043E1C
		[Nullable(2)]
		public override IKPropertyGetter Getter
		{
			[NullableContext(2)]
			[Register("getGetter", "()Lkotlin/reflect/KProperty$Getter;", "GetGetGetterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IKPropertyGetter>(MutablePropertyReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getGetter.()Lkotlin/reflect/KProperty$Getter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00045C50 File Offset: 0x00043E50
		[NullableContext(2)]
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(MutablePropertyReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040006EC RID: 1772
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/MutablePropertyReference", typeof(MutablePropertyReferenceInvoker));
	}
}
