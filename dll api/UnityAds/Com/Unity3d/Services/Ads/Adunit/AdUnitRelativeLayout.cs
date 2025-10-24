using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022D RID: 557
	[Register("com/unity3d/services/ads/adunit/AdUnitRelativeLayout", DoNotGenerateAcw = true)]
	public class AdUnitRelativeLayout : RelativeLayout
	{
		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0004E024 File Offset: 0x0004C224
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitRelativeLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0004E048 File Offset: 0x0004C248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitRelativeLayout._members;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0004E050 File Offset: 0x0004C250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitRelativeLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0004E074 File Offset: 0x0004C274
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitRelativeLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0003528C File Offset: 0x0003348C
		protected AdUnitRelativeLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x0004E080 File Offset: 0x0004C280
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AdUnitRelativeLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(AdUnitRelativeLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdUnitRelativeLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004E130 File Offset: 0x0004C330
		private static Delegate GetGetCurrentEventCountHandler()
		{
			if (AdUnitRelativeLayout.cb_getCurrentEventCount == null)
			{
				AdUnitRelativeLayout.cb_getCurrentEventCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitRelativeLayout.n_GetCurrentEventCount));
			}
			return AdUnitRelativeLayout.cb_getCurrentEventCount;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0004E154 File Offset: 0x0004C354
		private static int n_GetCurrentEventCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentEventCount;
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x0004E163 File Offset: 0x0004C363
		public virtual int CurrentEventCount
		{
			[Register("getCurrentEventCount", "()I", "GetGetCurrentEventCountHandler")]
			get
			{
				return AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentEventCount.()I", this, null);
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0004E17C File Offset: 0x0004C37C
		private static Delegate GetGetMaxEventCountHandler()
		{
			if (AdUnitRelativeLayout.cb_getMaxEventCount == null)
			{
				AdUnitRelativeLayout.cb_getMaxEventCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdUnitRelativeLayout.n_GetMaxEventCount));
			}
			return AdUnitRelativeLayout.cb_getMaxEventCount;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0004E1A0 File Offset: 0x0004C3A0
		private static int n_GetMaxEventCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxEventCount;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0004E1AF File Offset: 0x0004C3AF
		public virtual int MaxEventCount
		{
			[Register("getMaxEventCount", "()I", "GetGetMaxEventCountHandler")]
			get
			{
				return AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualInt32Method("getMaxEventCount.()I", this, null);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
		private static Delegate GetClearCaptureHandler()
		{
			if (AdUnitRelativeLayout.cb_clearCapture == null)
			{
				AdUnitRelativeLayout.cb_clearCapture = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdUnitRelativeLayout.n_ClearCapture));
			}
			return AdUnitRelativeLayout.cb_clearCapture;
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004E1EC File Offset: 0x0004C3EC
		private static void n_ClearCapture(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearCapture();
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004E1FB File Offset: 0x0004C3FB
		[Register("clearCapture", "()V", "GetClearCaptureHandler")]
		public virtual void ClearCapture()
		{
			AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualVoidMethod("clearCapture.()V", this, null);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0004E214 File Offset: 0x0004C414
		private static Delegate GetEndCaptureHandler()
		{
			if (AdUnitRelativeLayout.cb_endCapture == null)
			{
				AdUnitRelativeLayout.cb_endCapture = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AdUnitRelativeLayout.n_EndCapture));
			}
			return AdUnitRelativeLayout.cb_endCapture;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004E238 File Offset: 0x0004C438
		private static void n_EndCapture(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndCapture();
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0004E247 File Offset: 0x0004C447
		[Register("endCapture", "()V", "GetEndCaptureHandler")]
		public virtual void EndCapture()
		{
			AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualVoidMethod("endCapture.()V", this, null);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004E260 File Offset: 0x0004C460
		private static Delegate GetGetEventCount_Ljava_util_ArrayList_Handler()
		{
			if (AdUnitRelativeLayout.cb_getEventCount_Ljava_util_ArrayList_ == null)
			{
				AdUnitRelativeLayout.cb_getEventCount_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdUnitRelativeLayout.n_GetEventCount_Ljava_util_ArrayList_));
			}
			return AdUnitRelativeLayout.cb_getEventCount_Ljava_util_ArrayList_;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004E284 File Offset: 0x0004C484
		private static IntPtr n_GetEventCount_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_eventTypes)
		{
			AdUnitRelativeLayout @object = Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<Integer> eventTypes = JavaList<Integer>.FromJniHandle(native_eventTypes, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEventCount(eventTypes));
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004E2AC File Offset: 0x0004C4AC
		[Register("getEventCount", "(Ljava/util/ArrayList;)Landroid/util/SparseIntArray;", "GetGetEventCount_Ljava_util_ArrayList_Handler")]
		public unsafe virtual SparseIntArray GetEventCount(IList<Integer> eventTypes)
		{
			IntPtr intPtr = JavaList<Integer>.ToLocalJniHandle(eventTypes);
			SparseIntArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<SparseIntArray>(AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEventCount.(Ljava/util/ArrayList;)Landroid/util/SparseIntArray;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(eventTypes);
			}
			return @object;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0004E320 File Offset: 0x0004C520
		private static Delegate GetGetEvents_Landroid_util_SparseArray_Handler()
		{
			if (AdUnitRelativeLayout.cb_getEvents_Landroid_util_SparseArray_ == null)
			{
				AdUnitRelativeLayout.cb_getEvents_Landroid_util_SparseArray_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AdUnitRelativeLayout.n_GetEvents_Landroid_util_SparseArray_));
			}
			return AdUnitRelativeLayout.cb_getEvents_Landroid_util_SparseArray_;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004E344 File Offset: 0x0004C544
		private static IntPtr n_GetEvents_Landroid_util_SparseArray_(IntPtr jnienv, IntPtr native__this, IntPtr native_requestedInfos)
		{
			AdUnitRelativeLayout @object = Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SparseArray object2 = Java.Lang.Object.GetObject<SparseArray>(native_requestedInfos, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetEvents(object2));
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0004E36C File Offset: 0x0004C56C
		[Register("getEvents", "(Landroid/util/SparseArray;)Landroid/util/SparseArray;", "GetGetEvents_Landroid_util_SparseArray_Handler")]
		public unsafe virtual SparseArray GetEvents(SparseArray requestedInfos)
		{
			SparseArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((requestedInfos == null) ? IntPtr.Zero : requestedInfos.Handle);
				@object = Java.Lang.Object.GetObject<SparseArray>(AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getEvents.(Landroid/util/SparseArray;)Landroid/util/SparseArray;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(requestedInfos);
			}
			return @object;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		private static Delegate GetStartCapture_IHandler()
		{
			if (AdUnitRelativeLayout.cb_startCapture_I == null)
			{
				AdUnitRelativeLayout.cb_startCapture_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(AdUnitRelativeLayout.n_StartCapture_I));
			}
			return AdUnitRelativeLayout.cb_startCapture_I;
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0004E404 File Offset: 0x0004C604
		private static void n_StartCapture_I(IntPtr jnienv, IntPtr native__this, int maxEvents)
		{
			Java.Lang.Object.GetObject<AdUnitRelativeLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartCapture(maxEvents);
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0004E414 File Offset: 0x0004C614
		[Register("startCapture", "(I)V", "GetStartCapture_IHandler")]
		public unsafe virtual void StartCapture(int maxEvents)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxEvents);
			AdUnitRelativeLayout._members.InstanceMethods.InvokeVirtualVoidMethod("startCapture.(I)V", this, ptr);
		}

		// Token: 0x04000682 RID: 1666
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitRelativeLayout", typeof(AdUnitRelativeLayout));

		// Token: 0x04000683 RID: 1667
		private static Delegate cb_getCurrentEventCount;

		// Token: 0x04000684 RID: 1668
		private static Delegate cb_getMaxEventCount;

		// Token: 0x04000685 RID: 1669
		private static Delegate cb_clearCapture;

		// Token: 0x04000686 RID: 1670
		private static Delegate cb_endCapture;

		// Token: 0x04000687 RID: 1671
		private static Delegate cb_getEventCount_Ljava_util_ArrayList_;

		// Token: 0x04000688 RID: 1672
		private static Delegate cb_getEvents_Landroid_util_SparseArray_;

		// Token: 0x04000689 RID: 1673
		private static Delegate cb_startCapture_I;
	}
}
