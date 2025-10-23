using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;
using Kotlin.Jvm.Functions;

namespace AndroidX.Activity
{
	// Token: 0x02000013 RID: 19
	[Register("androidx/activity/FullyDrawnReporter", DoNotGenerateAcw = true)]
	public sealed class FullyDrawnReporter : Java.Lang.Object
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003428 File Offset: 0x00001628
		internal static IntPtr class_ref
		{
			get
			{
				return FullyDrawnReporter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000344C File Offset: 0x0000164C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FullyDrawnReporter._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003454 File Offset: 0x00001654
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FullyDrawnReporter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003478 File Offset: 0x00001678
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FullyDrawnReporter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003484 File Offset: 0x00001684
		internal FullyDrawnReporter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003490 File Offset: 0x00001690
		[Register(".ctor", "(Ljava/util/concurrent/Executor;Lkotlin/jvm/functions/Function0;)V", "")]
		public unsafe FullyDrawnReporter(IExecutor executor, IFunction0 reportFullyDrawn) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executor == null) ? IntPtr.Zero : ((Java.Lang.Object)executor).Handle);
				ptr[1] = new JniArgumentValue((reportFullyDrawn == null) ? IntPtr.Zero : ((Java.Lang.Object)reportFullyDrawn).Handle);
				base.SetHandle(FullyDrawnReporter._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/Executor;Lkotlin/jvm/functions/Function0;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FullyDrawnReporter._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/Executor;Lkotlin/jvm/functions/Function0;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executor);
				GC.KeepAlive(reportFullyDrawn);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003570 File Offset: 0x00001770
		public bool IsFullyDrawnReported
		{
			[Register("isFullyDrawnReported", "()Z", "")]
			get
			{
				return FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isFullyDrawnReported.()Z", this, null);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000358C File Offset: 0x0000178C
		[Register("addOnReportDrawnListener", "(Lkotlin/jvm/functions/Function0;)V", "")]
		public unsafe void AddOnReportDrawnListener(IFunction0 callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualVoidMethod("addOnReportDrawnListener.(Lkotlin/jvm/functions/Function0;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000035F4 File Offset: 0x000017F4
		[Register("addReporter", "()V", "")]
		public void AddReporter()
		{
			FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualVoidMethod("addReporter.()V", this, null);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000360D File Offset: 0x0000180D
		[Register("fullyDrawnReported", "()V", "")]
		public void FullyDrawnReported()
		{
			FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualVoidMethod("fullyDrawnReported.()V", this, null);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003628 File Offset: 0x00001828
		[Register("removeOnReportDrawnListener", "(Lkotlin/jvm/functions/Function0;)V", "")]
		public unsafe void RemoveOnReportDrawnListener(IFunction0 callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeOnReportDrawnListener.(Lkotlin/jvm/functions/Function0;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003690 File Offset: 0x00001890
		[Register("removeReporter", "()V", "")]
		public void RemoveReporter()
		{
			FullyDrawnReporter._members.InstanceMethods.InvokeNonvirtualVoidMethod("removeReporter.()V", this, null);
		}

		// Token: 0x04000019 RID: 25
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/FullyDrawnReporter", typeof(FullyDrawnReporter));
	}
}
