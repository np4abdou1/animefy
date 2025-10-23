using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000AD RID: 173
	[Register("androidx/core/view/NestedScrollingParent", DoNotGenerateAcw = true)]
	internal class INestedScrollingParentInvoker : Java.Lang.Object, INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingParentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0001CBFC File Offset: 0x0001ADFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingParentInvoker._members;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0001CC03 File Offset: 0x0001AE03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0001CC0B File Offset: 0x0001AE0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingParentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001CC17 File Offset: 0x0001AE17
		public static INestedScrollingParent GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingParent>(handle, transfer);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001CC20 File Offset: 0x0001AE20
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingParentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingParent'.");
			}
			return handle;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0001CC4B File Offset: 0x0001AE4B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		public INestedScrollingParentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingParentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0001CCB4 File Offset: 0x0001AEB4
		private static Delegate GetGetNestedScrollAxesHandler()
		{
			if (INestedScrollingParentInvoker.cb_getNestedScrollAxes == null)
			{
				INestedScrollingParentInvoker.cb_getNestedScrollAxes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INestedScrollingParentInvoker.n_GetNestedScrollAxes));
			}
			return INestedScrollingParentInvoker.cb_getNestedScrollAxes;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001CCD8 File Offset: 0x0001AED8
		private static int n_GetNestedScrollAxes(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollAxes;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0001CCE7 File Offset: 0x0001AEE7
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

		// Token: 0x06000988 RID: 2440 RVA: 0x0001CD27 File Offset: 0x0001AF27
		private static Delegate GetOnNestedFling_Landroid_view_View_FFZHandler()
		{
			if (INestedScrollingParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ == null)
			{
				INestedScrollingParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFZ_Z(INestedScrollingParentInvoker.n_OnNestedFling_Landroid_view_View_FFZ));
			}
			return INestedScrollingParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		private static bool n_OnNestedFling_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY, bool consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedFling(object2, velocityX, velocityY, consumed);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0001CD74 File Offset: 0x0001AF74
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

		// Token: 0x0600098B RID: 2443 RVA: 0x0001CE27 File Offset: 0x0001B027
		private static Delegate GetOnNestedPreFling_Landroid_view_View_FFHandler()
		{
			if (INestedScrollingParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF == null)
			{
				INestedScrollingParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(INestedScrollingParentInvoker.n_OnNestedPreFling_Landroid_view_View_FF));
			}
			return INestedScrollingParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0001CE4C File Offset: 0x0001B04C
		private static bool n_OnNestedPreFling_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, velocityX, velocityY);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001CE74 File Offset: 0x0001B074
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

		// Token: 0x0600098E RID: 2446 RVA: 0x0001CF10 File Offset: 0x0001B110
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler()
		{
			if (INestedScrollingParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI == null)
			{
				INestedScrollingParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(INestedScrollingParentInvoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayI));
			}
			return INestedScrollingParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0001CF34 File Offset: 0x0001B134
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001CF80 File Offset: 0x0001B180
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

		// Token: 0x06000991 RID: 2449 RVA: 0x0001D04C File Offset: 0x0001B24C
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIHandler()
		{
			if (INestedScrollingParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII == null)
			{
				INestedScrollingParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(INestedScrollingParentInvoker.n_OnNestedScroll_Landroid_view_View_IIII));
			}
			return INestedScrollingParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001D070 File Offset: 0x0001B270
		private static void n_OnNestedScroll_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001D09C File Offset: 0x0001B29C
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

		// Token: 0x06000994 RID: 2452 RVA: 0x0001D166 File Offset: 0x0001B366
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(INestedScrollingParentInvoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0001D18C File Offset: 0x0001B38C
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001D1BC File Offset: 0x0001B3BC
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

		// Token: 0x06000997 RID: 2455 RVA: 0x0001D267 File Offset: 0x0001B467
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(INestedScrollingParentInvoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001D28C File Offset: 0x0001B48C
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001D2BC File Offset: 0x0001B4BC
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

		// Token: 0x0600099A RID: 2458 RVA: 0x0001D367 File Offset: 0x0001B567
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_Handler()
		{
			if (INestedScrollingParentInvoker.cb_onStopNestedScroll_Landroid_view_View_ == null)
			{
				INestedScrollingParentInvoker.cb_onStopNestedScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(INestedScrollingParentInvoker.n_OnStopNestedScroll_Landroid_view_View_));
			}
			return INestedScrollingParentInvoker.cb_onStopNestedScroll_Landroid_view_View_;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0001D38C File Offset: 0x0001B58C
		private static void n_OnStopNestedScroll_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
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

		// Token: 0x040002B3 RID: 691
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingParent", typeof(INestedScrollingParentInvoker));

		// Token: 0x040002B4 RID: 692
		private IntPtr class_ref;

		// Token: 0x040002B5 RID: 693
		private static Delegate cb_getNestedScrollAxes;

		// Token: 0x040002B6 RID: 694
		private IntPtr id_getNestedScrollAxes;

		// Token: 0x040002B7 RID: 695
		private static Delegate cb_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002B8 RID: 696
		private IntPtr id_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002B9 RID: 697
		private static Delegate cb_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002BA RID: 698
		private IntPtr id_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002BB RID: 699
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002BC RID: 700
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002BD RID: 701
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002BE RID: 702
		private IntPtr id_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002BF RID: 703
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002C0 RID: 704
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002C1 RID: 705
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002C2 RID: 706
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002C3 RID: 707
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x040002C4 RID: 708
		private IntPtr id_onStopNestedScroll_Landroid_view_View_;
	}
}
