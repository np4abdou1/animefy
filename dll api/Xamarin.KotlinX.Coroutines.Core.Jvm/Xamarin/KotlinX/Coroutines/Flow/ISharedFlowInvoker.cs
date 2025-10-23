using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharedFlow", DoNotGenerateAcw = true)]
	internal class ISharedFlowInvoker : Java.Lang.Object, ISharedFlow, IFlow, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0001E3C8 File Offset: 0x0001C5C8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISharedFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISharedFlowInvoker._members;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0001E3F3 File Offset: 0x0001C5F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0001E3FB File Offset: 0x0001C5FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISharedFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0001E407 File Offset: 0x0001C607
		[NullableContext(2)]
		public static ISharedFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISharedFlow>(handle, transfer);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0001E410 File Offset: 0x0001C610
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISharedFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.SharedFlow'.");
			}
			return handle;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001E43B File Offset: 0x0001C63B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0001E46C File Offset: 0x0001C66C
		public ISharedFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISharedFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0001E4A4 File Offset: 0x0001C6A4
		private static Delegate GetGetReplayCacheHandler()
		{
			if (ISharedFlowInvoker.cb_getReplayCache == null)
			{
				ISharedFlowInvoker.cb_getReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISharedFlowInvoker.n_GetReplayCache));
			}
			return ISharedFlowInvoker.cb_getReplayCache;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		private static IntPtr n_GetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<ISharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplayCache);
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x0001E4DC File Offset: 0x0001C6DC
		public IList ReplayCache
		{
			get
			{
				if (this.id_getReplayCache == IntPtr.Zero)
				{
					this.id_getReplayCache = JNIEnv.GetMethodID(this.class_ref, "getReplayCache", "()Ljava/util/List;");
				}
				return JavaList.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getReplayCache), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0001E52D File Offset: 0x0001C72D
		private static Delegate GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler()
		{
			if (ISharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == null)
			{
				ISharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ISharedFlowInvoker.n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_));
			}
			return ISharedFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001E554 File Offset: 0x0001C754
		private static IntPtr n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector, IntPtr native_p1)
		{
			ISharedFlow @object = Java.Lang.Object.GetObject<ISharedFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFlowCollector object2 = Java.Lang.Object.GetObject<IFlowCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Collect(object2, object3));
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0001E588 File Offset: 0x0001C788
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

		// Token: 0x040002A3 RID: 675
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharedFlow", typeof(ISharedFlowInvoker));

		// Token: 0x040002A4 RID: 676
		private IntPtr class_ref;

		// Token: 0x040002A5 RID: 677
		[Nullable(2)]
		private static Delegate cb_getReplayCache;

		// Token: 0x040002A6 RID: 678
		private IntPtr id_getReplayCache;

		// Token: 0x040002A7 RID: 679
		[Nullable(2)]
		private static Delegate cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002A8 RID: 680
		private IntPtr id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
	}
}
