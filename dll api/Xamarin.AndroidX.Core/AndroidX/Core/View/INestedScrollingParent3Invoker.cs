using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B0 RID: 176
	[Register("androidx/core/view/NestedScrollingParent3", DoNotGenerateAcw = true)]
	internal class INestedScrollingParent3Invoker : Java.Lang.Object, INestedScrollingParent3, INestedScrollingParent2, INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0001E238 File Offset: 0x0001C438
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingParent3Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0001E25C File Offset: 0x0001C45C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingParent3Invoker._members;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0001E263 File Offset: 0x0001C463
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0001E26B File Offset: 0x0001C46B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingParent3Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001E277 File Offset: 0x0001C477
		public static INestedScrollingParent3 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingParent3>(handle, transfer);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001E280 File Offset: 0x0001C480
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingParent3Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingParent3'.");
			}
			return handle;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001E2AB File Offset: 0x0001C4AB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public INestedScrollingParent3Invoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingParent3Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001E314 File Offset: 0x0001C514
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIIIL_V(INestedScrollingParent3Invoker.n_OnNestedScroll_Landroid_view_View_IIIIIarrayI));
			}
			return INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0001E338 File Offset: 0x0001C538
		private static void n_OnNestedScroll_Landroid_view_View_IIIIIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
		{
			INestedScrollingParent3 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0001E388 File Offset: 0x0001C588
		public unsafe void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
		{
			if (this.id_onNestedScroll_Landroid_view_View_IIIIIarrayI == IntPtr.Zero)
			{
				this.id_onNestedScroll_Landroid_view_View_IIIIIarrayI = JNIEnv.GetMethodID(this.class_ref, "onNestedScroll", "(Landroid/view/View;IIIII[I)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dxConsumed);
			ptr[2] = new JValue(dyConsumed);
			ptr[3] = new JValue(dxUnconsumed);
			ptr[4] = new JValue(dyUnconsumed);
			ptr[5] = new JValue(type);
			ptr[6] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScroll_Landroid_view_View_IIIIIarrayI, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001E499 File Offset: 0x0001C699
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_V(INestedScrollingParent3Invoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayII));
			}
			return INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001E4C0 File Offset: 0x0001C6C0
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001E50C File Offset: 0x0001C70C
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

		// Token: 0x060009DD RID: 2525 RVA: 0x0001E5EF File Offset: 0x0001C7EF
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIII == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIII_V(INestedScrollingParent3Invoker.n_OnNestedScroll_Landroid_view_View_IIIII));
			}
			return INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0001E614 File Offset: 0x0001C814
		private static void n_OnNestedScroll_Landroid_view_View_IIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0001E640 File Offset: 0x0001C840
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

		// Token: 0x060009E0 RID: 2528 RVA: 0x0001E721 File Offset: 0x0001C921
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(INestedScrollingParent3Invoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II));
			}
			return INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001E748 File Offset: 0x0001C948
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001E77C File Offset: 0x0001C97C
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

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001E83E File Offset: 0x0001CA3E
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
			{
				INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_Z(INestedScrollingParent3Invoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II));
			}
			return INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0001E864 File Offset: 0x0001CA64
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0001E898 File Offset: 0x0001CA98
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

		// Token: 0x060009E6 RID: 2534 RVA: 0x0001E95A File Offset: 0x0001CB5A
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_I == null)
			{
				INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(INestedScrollingParent3Invoker.n_OnStopNestedScroll_Landroid_view_View_I));
			}
			return INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_I;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0001E980 File Offset: 0x0001CB80
		private static void n_OnStopNestedScroll_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			INestedScrollingParent2 @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2, type);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0001E9A4 File Offset: 0x0001CBA4
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

		// Token: 0x060009E9 RID: 2537 RVA: 0x0001EA2A File Offset: 0x0001CC2A
		private static Delegate GetGetNestedScrollAxesHandler()
		{
			if (INestedScrollingParent3Invoker.cb_getNestedScrollAxes == null)
			{
				INestedScrollingParent3Invoker.cb_getNestedScrollAxes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(INestedScrollingParent3Invoker.n_GetNestedScrollAxes));
			}
			return INestedScrollingParent3Invoker.cb_getNestedScrollAxes;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0001EA4E File Offset: 0x0001CC4E
		private static int n_GetNestedScrollAxes(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollAxes;
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0001EA5D File Offset: 0x0001CC5D
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

		// Token: 0x060009EC RID: 2540 RVA: 0x0001EA9D File Offset: 0x0001CC9D
		private static Delegate GetOnNestedFling_Landroid_view_View_FFZHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedFling_Landroid_view_View_FFZ == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedFling_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFZ_Z(INestedScrollingParent3Invoker.n_OnNestedFling_Landroid_view_View_FFZ));
			}
			return INestedScrollingParent3Invoker.cb_onNestedFling_Landroid_view_View_FFZ;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
		private static bool n_OnNestedFling_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY, bool consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedFling(object2, velocityX, velocityY, consumed);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0001EAEC File Offset: 0x0001CCEC
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

		// Token: 0x060009EF RID: 2543 RVA: 0x0001EB9F File Offset: 0x0001CD9F
		private static Delegate GetOnNestedPreFling_Landroid_view_View_FFHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedPreFling_Landroid_view_View_FF == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedPreFling_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(INestedScrollingParent3Invoker.n_OnNestedPreFling_Landroid_view_View_FF));
			}
			return INestedScrollingParent3Invoker.cb_onNestedPreFling_Landroid_view_View_FF;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0001EBC4 File Offset: 0x0001CDC4
		private static bool n_OnNestedPreFling_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, velocityX, velocityY);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0001EBEC File Offset: 0x0001CDEC
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

		// Token: 0x060009F2 RID: 2546 RVA: 0x0001EC88 File Offset: 0x0001CE88
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(INestedScrollingParent3Invoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayI));
			}
			return INestedScrollingParent3Invoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0001ECAC File Offset: 0x0001CEAC
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
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

		// Token: 0x060009F5 RID: 2549 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIII == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(INestedScrollingParent3Invoker.n_OnNestedScroll_Landroid_view_View_IIII));
			}
			return INestedScrollingParent3Invoker.cb_onNestedScroll_Landroid_view_View_IIII;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0001EDE8 File Offset: 0x0001CFE8
		private static void n_OnNestedScroll_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0001EE14 File Offset: 0x0001D014
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

		// Token: 0x060009F8 RID: 2552 RVA: 0x0001EEDE File Offset: 0x0001D0DE
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(INestedScrollingParent3Invoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParent3Invoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001EF04 File Offset: 0x0001D104
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0001EF34 File Offset: 0x0001D134
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

		// Token: 0x060009FB RID: 2555 RVA: 0x0001EFDF File Offset: 0x0001D1DF
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == null)
			{
				INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(INestedScrollingParent3Invoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I));
			}
			return INestedScrollingParent3Invoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0001F004 File Offset: 0x0001D204
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0001F034 File Offset: 0x0001D234
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

		// Token: 0x060009FE RID: 2558 RVA: 0x0001F0DF File Offset: 0x0001D2DF
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_Handler()
		{
			if (INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_ == null)
			{
				INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(INestedScrollingParent3Invoker.n_OnStopNestedScroll_Landroid_view_View_));
			}
			return INestedScrollingParent3Invoker.cb_onStopNestedScroll_Landroid_view_View_;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0001F104 File Offset: 0x0001D304
		private static void n_OnStopNestedScroll_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			INestedScrollingParent @object = Java.Lang.Object.GetObject<INestedScrollingParent3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0001F128 File Offset: 0x0001D328
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

		// Token: 0x040002E1 RID: 737
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingParent3", typeof(INestedScrollingParent3Invoker));

		// Token: 0x040002E2 RID: 738
		private IntPtr class_ref;

		// Token: 0x040002E3 RID: 739
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;

		// Token: 0x040002E4 RID: 740
		private IntPtr id_onNestedScroll_Landroid_view_View_IIIIIarrayI;

		// Token: 0x040002E5 RID: 741
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x040002E6 RID: 742
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x040002E7 RID: 743
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x040002E8 RID: 744
		private IntPtr id_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x040002E9 RID: 745
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002EA RID: 746
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002EB RID: 747
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002EC RID: 748
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x040002ED RID: 749
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x040002EE RID: 750
		private IntPtr id_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x040002EF RID: 751
		private static Delegate cb_getNestedScrollAxes;

		// Token: 0x040002F0 RID: 752
		private IntPtr id_getNestedScrollAxes;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002F2 RID: 754
		private IntPtr id_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x040002F3 RID: 755
		private static Delegate cb_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002F4 RID: 756
		private IntPtr id_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x040002F5 RID: 757
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002F6 RID: 758
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x040002F7 RID: 759
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002F8 RID: 760
		private IntPtr id_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002FA RID: 762
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002FB RID: 763
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002FC RID: 764
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040002FD RID: 765
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x040002FE RID: 766
		private IntPtr id_onStopNestedScroll_Landroid_view_View_;
	}
}
