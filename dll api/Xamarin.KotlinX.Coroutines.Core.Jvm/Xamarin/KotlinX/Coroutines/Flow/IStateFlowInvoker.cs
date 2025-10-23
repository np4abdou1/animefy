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
	// Token: 0x020000B9 RID: 185
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/StateFlow", DoNotGenerateAcw = true)]
	internal class IStateFlowInvoker : Java.Lang.Object, IStateFlow, ISharedFlow, IFlow, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0001E9FC File Offset: 0x0001CBFC
		private static IntPtr java_class_ref
		{
			get
			{
				return IStateFlowInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0001EA20 File Offset: 0x0001CC20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStateFlowInvoker._members;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0001EA27 File Offset: 0x0001CC27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0001EA2F File Offset: 0x0001CC2F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStateFlowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001EA3B File Offset: 0x0001CC3B
		[NullableContext(2)]
		public static IStateFlow GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStateFlow>(handle, transfer);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001EA44 File Offset: 0x0001CC44
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStateFlowInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.StateFlow'.");
			}
			return handle;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0001EA6F File Offset: 0x0001CC6F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		public IStateFlowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStateFlowInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		private static Delegate GetGetValueHandler()
		{
			if (IStateFlowInvoker.cb_getValue == null)
			{
				IStateFlowInvoker.cb_getValue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStateFlowInvoker.n_GetValue));
			}
			return IStateFlowInvoker.cb_getValue;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0001EAFC File Offset: 0x0001CCFC
		private static IntPtr n_GetValue(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Value);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0001EB10 File Offset: 0x0001CD10
		[Nullable(2)]
		public Java.Lang.Object Value
		{
			[NullableContext(2)]
			get
			{
				if (this.id_getValue == IntPtr.Zero)
				{
					this.id_getValue = JNIEnv.GetMethodID(this.class_ref, "getValue", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_getValue), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001EB61 File Offset: 0x0001CD61
		private static Delegate GetGetReplayCacheHandler()
		{
			if (IStateFlowInvoker.cb_getReplayCache == null)
			{
				IStateFlowInvoker.cb_getReplayCache = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IStateFlowInvoker.n_GetReplayCache));
			}
			return IStateFlowInvoker.cb_getReplayCache;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001EB85 File Offset: 0x0001CD85
		private static IntPtr n_GetReplayCache(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList.ToLocalJniHandle(Java.Lang.Object.GetObject<IStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReplayCache);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0001EB9C File Offset: 0x0001CD9C
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

		// Token: 0x06000872 RID: 2162 RVA: 0x0001EBED File Offset: 0x0001CDED
		private static Delegate GetCollect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_Handler()
		{
			if (IStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ == null)
			{
				IStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IStateFlowInvoker.n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_));
			}
			return IStateFlowInvoker.cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001EC14 File Offset: 0x0001CE14
		private static IntPtr n_Collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_collector, IntPtr native_p1)
		{
			ISharedFlow @object = Java.Lang.Object.GetObject<IStateFlow>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IFlowCollector object2 = Java.Lang.Object.GetObject<IFlowCollector>(native_collector, JniHandleOwnership.DoNotTransfer);
			IContinuation object3 = Java.Lang.Object.GetObject<IContinuation>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Collect(object2, object3));
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0001EC48 File Offset: 0x0001CE48
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

		// Token: 0x040002B0 RID: 688
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/StateFlow", typeof(IStateFlowInvoker));

		// Token: 0x040002B1 RID: 689
		private IntPtr class_ref;

		// Token: 0x040002B2 RID: 690
		[Nullable(2)]
		private static Delegate cb_getValue;

		// Token: 0x040002B3 RID: 691
		private IntPtr id_getValue;

		// Token: 0x040002B4 RID: 692
		[Nullable(2)]
		private static Delegate cb_getReplayCache;

		// Token: 0x040002B5 RID: 693
		private IntPtr id_getReplayCache;

		// Token: 0x040002B6 RID: 694
		[Nullable(2)]
		private static Delegate cb_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;

		// Token: 0x040002B7 RID: 695
		private IntPtr id_collect_Lkotlinx_coroutines_flow_FlowCollector_Lkotlin_coroutines_Continuation_;
	}
}
