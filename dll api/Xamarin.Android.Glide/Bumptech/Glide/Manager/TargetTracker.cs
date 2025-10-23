using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Target;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000084 RID: 132
	[Register("com/bumptech/glide/manager/TargetTracker", DoNotGenerateAcw = true)]
	public sealed class TargetTracker : Java.Lang.Object, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000125EC File Offset: 0x000107EC
		internal static IntPtr class_ref
		{
			get
			{
				return TargetTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00012610 File Offset: 0x00010810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TargetTracker._members;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00012618 File Offset: 0x00010818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TargetTracker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001263C File Offset: 0x0001083C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TargetTracker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00012648 File Offset: 0x00010848
		internal TargetTracker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00012654 File Offset: 0x00010854
		[Register(".ctor", "()V", "")]
		public TargetTracker() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TargetTracker._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TargetTracker._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000126C4 File Offset: 0x000108C4
		public IList<ITarget> All
		{
			[Register("getAll", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<ITarget>.FromJniHandle(TargetTracker._members.InstanceMethods.InvokeAbstractObjectMethod("getAll.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000126F6 File Offset: 0x000108F6
		[Register("clear", "()V", "")]
		public void Clear()
		{
			TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("clear.()V", this, null);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001270F File Offset: 0x0001090F
		[Register("onDestroy", "()V", "")]
		public void OnDestroy()
		{
			TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("onDestroy.()V", this, null);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00012728 File Offset: 0x00010928
		[Register("onStart", "()V", "")]
		public void OnStart()
		{
			TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("onStart.()V", this, null);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00012741 File Offset: 0x00010941
		[Register("onStop", "()V", "")]
		public void OnStop()
		{
			TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("onStop.()V", this, null);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001275C File Offset: 0x0001095C
		[Register("track", "(Lcom/bumptech/glide/request/target/Target;)V", "")]
		public unsafe void Track(ITarget target)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("track.(Lcom/bumptech/glide/request/target/Target;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000127C4 File Offset: 0x000109C4
		[Register("untrack", "(Lcom/bumptech/glide/request/target/Target;)V", "")]
		public unsafe void Untrack(ITarget target)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : ((Java.Lang.Object)target).Handle);
				TargetTracker._members.InstanceMethods.InvokeAbstractVoidMethod("untrack.(Lcom/bumptech/glide/request/target/Target;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x0400014E RID: 334
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/TargetTracker", typeof(TargetTracker));
	}
}
