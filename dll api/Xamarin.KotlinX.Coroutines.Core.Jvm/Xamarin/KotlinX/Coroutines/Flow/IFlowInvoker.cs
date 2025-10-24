using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000AA RID: 170
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/Flow", DoNotGenerateAcw = true)]
	internal class IFlowInvoker : Java.Lang.Object, IFlow, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001D350 File Offset: 0x0001B550
		private static IntPtr java_class_ref
		{
			get
			{
				return IFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0001D374 File Offset: 0x0001B574
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IFlowInvoker._members;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001D37B File Offset: 0x0001B57B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0001D383 File Offset: 0x0001B583
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0001D38F File Offset: 0x0001B58F
		[NullableContext(2)]
		public static IFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFlow>(handle, transfer);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0001D398 File Offset: 0x0001B598
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.Flow'.");
			}
			return handle;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0001D3C3 File Offset: 0x0001B5C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0001D3F4 File Offset: 0x0001B5F4
		public IFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0001D42C File Offset: 0x0001B62C
		private static Delegate GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == null)
			{
				IFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFlowInvoker.n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_));
			}
			return IFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0001D450 File Offset: 0x0001B650
		private static IntPtr n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector, IntPtr native_p1)
		{
			IFlow @object = Java.Lang.Object.GetObject<IFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFlowCollector object2 = Java.Lang.Object.GetObject<IFlowCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Collect(object2, object3));
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0001D484 File Offset: 0x0001B684
		[return: Nullable(2)]
		public unsafe Java.Lang.Object Collect(IFlowCollector collector, IContinuation p1)
		{
			if (this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
			{
				this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID(this.class_ref, "collect", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((collector == null) ? IntPtr.Zero : ((Java.Lang.Object)collector).Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000279 RID: 633
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/Flow", typeof(IFlowInvoker));

		// Token: 0x0400027A RID: 634
		private IntPtr class_ref;

		// Token: 0x0400027B RID: 635
		[Nullable(2)]
		private static Delegate cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;

		// Token: 0x0400027C RID: 636
		private IntPtr id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
	}
}
