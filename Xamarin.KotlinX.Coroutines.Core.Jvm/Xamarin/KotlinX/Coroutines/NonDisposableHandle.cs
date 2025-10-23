using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200007D RID: 125
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/NonDisposableHandle", DoNotGenerateAcw = true)]
	public sealed class NonDisposableHandle : Java.Lang.Object, IChildHandle, IDisposableHandle, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x000134DC File Offset: 0x000116DC
		[Register("INSTANCE")]
		public static NonDisposableHandle Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<NonDisposableHandle>(NonDisposableHandle._members.StaticFields.GetObjectValue("INSTANCE.Lkotlinx/coroutines/NonDisposableHandle;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001350C File Offset: 0x0001170C
		internal static IntPtr class_ref
		{
			get
			{
				return NonDisposableHandle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00013530 File Offset: 0x00011730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NonDisposableHandle._members;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00013538 File Offset: 0x00011738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NonDisposableHandle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001355C File Offset: 0x0001175C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NonDisposableHandle._members.ManagedPeerType;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00013568 File Offset: 0x00011768
		internal NonDisposableHandle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00013574 File Offset: 0x00011774
		[Nullable(2)]
		public IJob Parent
		{
			[NullableContext(2)]
			[Register("getParent", "()Lkotlinx/coroutines/Job;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IJob>(NonDisposableHandle._members.InstanceMethods.InvokeAbstractObjectMethod("getParent.()Lkotlinx/coroutines/Job;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000135A8 File Offset: 0x000117A8
		[Register("childCancelled", "(Ljava/lang/Throwable;)Z", "")]
		public unsafe bool ChildCancelled(Throwable cause)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				result = NonDisposableHandle._members.InstanceMethods.InvokeAbstractBooleanMethod("childCancelled.(Ljava/lang/Throwable;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cause);
			}
			return result;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00013610 File Offset: 0x00011810
		[Register("dispose", "()V", "")]
		public new void Dispose()
		{
			NonDisposableHandle._members.InstanceMethods.InvokeAbstractVoidMethod("dispose.()V", this, null);
		}

		// Token: 0x04000207 RID: 519
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/NonDisposableHandle", typeof(NonDisposableHandle));
	}
}
