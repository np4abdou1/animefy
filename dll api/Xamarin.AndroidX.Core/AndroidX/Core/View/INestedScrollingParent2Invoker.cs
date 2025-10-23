using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000AE RID: 174
	[Register("androidx/core/view/NestedScrollingParent2", DoNotGenerateAcw = true)]
	internal class INestedScrollingParent2Invoker : Java.Lang.Object, INestedScrollingParent2, INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0001D440 File Offset: 0x0001B640
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingParent2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0001D464 File Offset: 0x0001B664
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingParent2Invoker._members;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0001D46B File Offset: 0x0001B66B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0001D473 File Offset: 0x0001B673
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingParent2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001D47F File Offset: 0x0001B67F
		public static INestedScrollingParent2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingParent2>(handle, transfer);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0001D488 File Offset: 0x0001B688
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingParent2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingParent2'.");
			}
			return handle;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0001D4B3 File Offset: 0x0001B6B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001D4E4 File Offset: 0x0001B6E4
		public INestedScrollingParent2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingParent2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001D51C File Offset: 0x0001B71C
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_V(INestedScrollingParent2Invoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayII));
			}
			return INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001D540 File Offset: 0x0001B740
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001D58C File Offset: 0x0001B78C
		public unsafe void OnNestedPreScroll(View target, int dx, int dy, int[] consumed, int type)
		{
			if (this.id_onNestedPreScroll_Landroid_view_View_IIarrayII == IntPtr.Zero)
			{
				this.id_onNestedPreScroll_Landroid_view_View_IIarrayII = JNIEnv.GetMethodID(this.class_ref, "onNestedPreScroll", "(Landroid/view/View;II[II)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dx);
			ptr[2] = new JValue(dy);
			ptr[3] = new JValue(intPtr);
			ptr[4] = new JValue(type);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedPreScroll_Landroid_view_View_IIarrayII, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001D66F File Offset: 0x0001B86F
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIIII == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIII_V(INestedScrollingParent2Invoker.n_OnNestedScroll_Landroid_view_View_IIIII));
			}
			return INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0001D694 File Offset: 0x0001B894
		private static void n_OnNestedScroll_Landroid_view_View_IIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		public unsafe void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			if (this.id_onNestedScroll_Landroid_view_View_IIIII == IntPtr.Zero)
			{
				this.id_onNestedScroll_Landroid_view_View_IIIII = JNIEnv.GetMethodID(this.class_ref, "onNestedScroll", "(Landroid/view/View;IIIII)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dxConsumed);
			ptr[2] = new JValue(dyConsumed);
			ptr[3] = new JValue(dxUnconsumed);
			ptr[4] = new JValue(dyUnconsumed);
			ptr[5] = new JValue(type);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScroll_Landroid_view_View_IIIII, ptr);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0001D7A1 File Offset: 0x0001B9A1
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(INestedScrollingParent2Invoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II));
			}
			return INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001D7FC File Offset: 0x0001B9FC
		public unsafe void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			if (this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == IntPtr.Zero)
			{
				this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNIEnv.GetMethodID(this.class_ref, "onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)axes);
			ptr[3] = new JValue(type);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II, ptr);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001D8BE File Offset: 0x0001BABE
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
			{
				INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_Z(INestedScrollingParent2Invoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II));
			}
			return INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001D918 File Offset: 0x0001BB18
		public unsafe bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			if (this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == IntPtr.Zero)
			{
				this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNIEnv.GetMethodID(this.class_ref, "onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)axes);
			ptr[3] = new JValue(type);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II, ptr);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001D9DA File Offset: 0x0001BBDA
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_I == null)
			{
				INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(INestedScrollingParent2Invoker.n_OnStopNestedScroll_Landroid_view_View_I));
			}
			return INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_I;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0001DA00 File Offset: 0x0001BC00
		private static void n_OnStopNestedScroll_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2, type);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0001DA24 File Offset: 0x0001BC24
		public unsafe void OnStopNestedScroll(View target, int type)
		{
			if (this.id_onStopNestedScroll_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_onStopNestedScroll_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "onStopNestedScroll", "(Landroid/view/View;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(type);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStopNestedScroll_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001DAAA File Offset: 0x0001BCAA
		private static Delegate GetGetNestedScrollAxesHandler()
		{
			if (INestedScrollingParent2Invoker.cb_getNestedScrollAxes == null)
			{
				INestedScrollingParent2Invoker.cb_getNestedScrollAxes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INestedScrollingParent2Invoker.n_GetNestedScrollAxes));
			}
			return INestedScrollingParent2Invoker.cb_getNestedScrollAxes;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0001DACE File Offset: 0x0001BCCE
		private static int n_GetNestedScrollAxes(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollAxes;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0001DADD File Offset: 0x0001BCDD
		public ScrollAxis NestedScrollAxes
		{
			get
			{
				if (this.id_getNestedScrollAxes == IntPtr.Zero)
				{
					this.id_getNestedScrollAxes = JNIEnv.GetMethodID(this.class_ref, "getNestedScrollAxes", "()I");
				}
				return (ScrollAxis)JNIEnv.CallIntMethod(base.Handle, this.id_getNestedScrollAxes);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0001DB1D File Offset: 0x0001BD1D
		private static Delegate GetOnNestedFling_Landroid_view_View_FFZHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedFling_Landroid_view_View_FFZ == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedFling_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFZ_Z(INestedScrollingParent2Invoker.n_OnNestedFling_Landroid_view_View_FFZ));
			}
			return INestedScrollingParent2Invoker.cb_onNestedFling_Landroid_view_View_FFZ;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001DB44 File Offset: 0x0001BD44
		private static bool n_OnNestedFling_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY, bool consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedFling(object2, velocityX, velocityY, consumed);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		public unsafe bool OnNestedFling(View target, float velocityX, float velocityY, bool consumed)
		{
			if (this.id_onNestedFling_Landroid_view_View_FFZ == IntPtr.Zero)
			{
				this.id_onNestedFling_Landroid_view_View_FFZ = JNIEnv.GetMethodID(this.class_ref, "onNestedFling", "(Landroid/view/View;FFZ)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(velocityX);
			ptr[2] = new JValue(velocityY);
			ptr[3] = new JValue(consumed);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNestedFling_Landroid_view_View_FFZ, ptr);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0001DC1F File Offset: 0x0001BE1F
		private static Delegate GetOnNestedPreFling_Landroid_view_View_FFHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedPreFling_Landroid_view_View_FF == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedPreFling_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(INestedScrollingParent2Invoker.n_OnNestedPreFling_Landroid_view_View_FF));
			}
			return INestedScrollingParent2Invoker.cb_onNestedPreFling_Landroid_view_View_FF;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0001DC44 File Offset: 0x0001BE44
		private static bool n_OnNestedPreFling_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, velocityX, velocityY);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		public unsafe bool OnNestedPreFling(View target, float velocityX, float velocityY)
		{
			if (this.id_onNestedPreFling_Landroid_view_View_FF == IntPtr.Zero)
			{
				this.id_onNestedPreFling_Landroid_view_View_FF = JNIEnv.GetMethodID(this.class_ref, "onNestedPreFling", "(Landroid/view/View;FF)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(velocityX);
			ptr[2] = new JValue(velocityY);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNestedPreFling_Landroid_view_View_FF, ptr);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001DD08 File Offset: 0x0001BF08
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(INestedScrollingParent2Invoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayI));
			}
			return INestedScrollingParent2Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0001DD2C File Offset: 0x0001BF2C
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0001DD78 File Offset: 0x0001BF78
		public unsafe void OnNestedPreScroll(View target, int dx, int dy, int[] consumed)
		{
			if (this.id_onNestedPreScroll_Landroid_view_View_IIarrayI == IntPtr.Zero)
			{
				this.id_onNestedPreScroll_Landroid_view_View_IIarrayI = JNIEnv.GetMethodID(this.class_ref, "onNestedPreScroll", "(Landroid/view/View;II[I)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dx);
			ptr[2] = new JValue(dy);
			ptr[3] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedPreScroll_Landroid_view_View_IIarrayI, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0001DE44 File Offset: 0x0001C044
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIII == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(INestedScrollingParent2Invoker.n_OnNestedScroll_Landroid_view_View_IIII));
			}
			return INestedScrollingParent2Invoker.cb_onNestedScroll_Landroid_view_View_IIII;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0001DE68 File Offset: 0x0001C068
		private static void n_OnNestedScroll_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0001DE94 File Offset: 0x0001C094
		public unsafe void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			if (this.id_onNestedScroll_Landroid_view_View_IIII == IntPtr.Zero)
			{
				this.id_onNestedScroll_Landroid_view_View_IIII = JNIEnv.GetMethodID(this.class_ref, "onNestedScroll", "(Landroid/view/View;IIII)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dxConsumed);
			ptr[2] = new JValue(dyConsumed);
			ptr[3] = new JValue(dxUnconsumed);
			ptr[4] = new JValue(dyUnconsumed);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScroll_Landroid_view_View_IIII, ptr);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0001DF5E File Offset: 0x0001C15E
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(INestedScrollingParent2Invoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParent2Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0001DF84 File Offset: 0x0001C184
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0001DFB4 File Offset: 0x0001C1B4
		public unsafe void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes)
		{
			if (this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)axes);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001E05F File Offset: 0x0001C25F
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(INestedScrollingParent2Invoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParent2Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001E084 File Offset: 0x0001C284
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		public unsafe bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes)
		{
			if (this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)axes);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0001E15F File Offset: 0x0001C35F
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_Handler()
		{
			if (INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_ == null)
			{
				INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(INestedScrollingParent2Invoker.n_OnStopNestedScroll_Landroid_view_View_));
			}
			return INestedScrollingParent2Invoker.cb_onStopNestedScroll_Landroid_view_View_;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001E184 File Offset: 0x0001C384
		private static void n_OnStopNestedScroll_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		public unsafe void OnStopNestedScroll(View target)
		{
			if (this.id_onStopNestedScroll_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onStopNestedScroll_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onStopNestedScroll", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStopNestedScroll_Landroid_view_View_, ptr);
		}

		// Token: 0x040002C5 RID: 709
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingParent2", typeof(INestedScrollingParent2Invoker));

		// Token: 0x040002C6 RID: 710
		private IntPtr class_ref;

		// Token: 0x040002C7 RID: 711
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x040002C8 RID: 712
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x040002C9 RID: 713
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x040002CA RID: 714
		private IntPtr id_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x040002CB RID: 715
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002CC RID: 716
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002CD RID: 717
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002CE RID: 718
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002CF RID: 719
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x040002D0 RID: 720
		private IntPtr id_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x040002D1 RID: 721
		private static Delegate cb_getNestedScrollAxes;

		// Token: 0x040002D2 RID: 722
		private IntPtr id_getNestedScrollAxes;

		// Token: 0x040002D3 RID: 723
		private static Delegate cb_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002D4 RID: 724
		private IntPtr id_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002D5 RID: 725
		private static Delegate cb_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002D6 RID: 726
		private IntPtr id_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002D7 RID: 727
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002D8 RID: 728
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002D9 RID: 729
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002DA RID: 730
		private IntPtr id_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002DB RID: 731
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002DC RID: 732
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002DD RID: 733
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002DE RID: 734
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002DF RID: 735
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x040002E0 RID: 736
		private IntPtr id_onStopNestedScroll_Landroid_view_View_;
	}
}
