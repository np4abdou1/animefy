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
	// Token: 0x02000194 RID: 404
	[Register("kotlin/jvm/internal/CallableReference", DoNotGenerateAcw = true)]
	internal class CallableReferenceInvoker : CallableReference, IKCallable, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060013F4 RID: 5108 RVA: 0x00040CF1 File Offset: 0x0003EEF1
		public CallableReferenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00040CFB File Offset: 0x0003EEFB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CallableReferenceInvoker._members;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00040D02 File Offset: 0x0003EF02
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CallableReferenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00040D10 File Offset: 0x0003EF10
		[NullableContext(2)]
		[Register("computeReflected", "()Lkotlin/reflect/KCallable;", "GetComputeReflectedHandler")]
		protected override IKCallable ComputeReflected()
		{
			return Java.Lang.Object.GetObject<IKCallable>(CallableReferenceInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("computeReflected.()Lkotlin/reflect/KCallable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000691 RID: 1681
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/CallableReference", typeof(CallableReferenceInvoker));
	}
}
