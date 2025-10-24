using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000AB RID: 171
	[Register("androidx/core/view/NestedScrollingChild3", DoNotGenerateAcw = true)]
	internal class INestedScrollingChild3Invoker : Java.Lang.Object, INestedScrollingChild3, INestedScrollingChild2, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingChild3Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0001BDF4 File Offset: 0x00019FF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingChild3Invoker._members;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0001BDFB File Offset: 0x00019FFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0001BE03 File Offset: 0x0001A003
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingChild3Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001BE0F File Offset: 0x0001A00F
		public static INestedScrollingChild3 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(handle, transfer);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0001BE18 File Offset: 0x0001A018
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingChild3Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingChild3'.");
			}
			return handle;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001BE43 File Offset: 0x0001A043
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001BE74 File Offset: 0x0001A074
		public INestedScrollingChild3Invoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingChild3Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIarrayIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayIIarrayI == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILIL_V(INestedScrollingChild3Invoker.n_DispatchNestedScroll_IIIIarrayIIarrayI));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayIIarrayI;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		private static void n_DispatchNestedScroll_IIIIarrayIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type, IntPtr native_consumed)
		{
			INestedScrollingChild3 @object = Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_consumed);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001BF3C File Offset: 0x0001A13C
		public unsafe void DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type, int[] consumed)
		{
			if (this.id_dispatchNestedScroll_IIIIarrayIIarrayI == IntPtr.Zero)
			{
				this.id_dispatchNestedScroll_IIIIarrayIIarrayI = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedScroll", "(IIII[II[I)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			IntPtr intPtr2 = JNIEnv.NewArray(consumed);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(dxConsumed);
			ptr[1] = new JValue(dyConsumed);
			ptr[2] = new JValue(dxUnconsumed);
			ptr[3] = new JValue(dyUnconsumed);
			ptr[4] = new JValue(intPtr);
			ptr[5] = new JValue(type);
			ptr[6] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_dispatchNestedScroll_IIIIarrayIIarrayI, ptr);
			if (offsetInWindow != null)
			{
				JNIEnv.CopyArray(intPtr, offsetInWindow);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr2, consumed);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001C057 File Offset: 0x0001A257
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILLI_Z(INestedScrollingChild3Invoker.n_DispatchNestedPreScroll_IIarrayIarrayII));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001C07C File Offset: 0x0001A27C
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayII(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow, int type)
		{
			INestedScrollingChild2 @object = Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedPreScroll(dx, dy, array, array2, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		public unsafe bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow, int type)
		{
			if (this.id_dispatchNestedPreScroll_IIarrayIarrayII == IntPtr.Zero)
			{
				this.id_dispatchNestedPreScroll_IIarrayIarrayII = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedPreScroll", "(II[I[II)Z");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			IntPtr intPtr2 = JNIEnv.NewArray(offsetInWindow);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(dx);
			ptr[1] = new JValue(dy);
			ptr[2] = new JValue(intPtr);
			ptr[3] = new JValue(intPtr2);
			ptr[4] = new JValue(type);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedPreScroll_IIarrayIarrayII, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (offsetInWindow != null)
			{
				JNIEnv.CopyArray(intPtr2, offsetInWindow);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001C1CF File Offset: 0x0001A3CF
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayII == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILI_Z(INestedScrollingChild3Invoker.n_DispatchNestedScroll_IIIIarrayII));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayII;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		private static bool n_DispatchNestedScroll_IIIIarrayII(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type)
		{
			INestedScrollingChild2 @object = Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0001C23C File Offset: 0x0001A43C
		public unsafe bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type)
		{
			if (this.id_dispatchNestedScroll_IIIIarrayII == IntPtr.Zero)
			{
				this.id_dispatchNestedScroll_IIIIarrayII = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedScroll", "(IIII[II)Z");
			}
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(dxConsumed);
			ptr[1] = new JValue(dyConsumed);
			ptr[2] = new JValue(dxUnconsumed);
			ptr[3] = new JValue(dyUnconsumed);
			ptr[4] = new JValue(intPtr);
			ptr[5] = new JValue(type);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedScroll_IIIIarrayII, ptr);
			if (offsetInWindow != null)
			{
				JNIEnv.CopyArray(intPtr, offsetInWindow);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0001C327 File Offset: 0x0001A527
		private static Delegate GetInvokeHasNestedScrollingParent_IHandler()
		{
			if (INestedScrollingChild3Invoker.cb_hasNestedScrollingParent_I == null)
			{
				INestedScrollingChild3Invoker.cb_hasNestedScrollingParent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(INestedScrollingChild3Invoker.n_InvokeHasNestedScrollingParent_I));
			}
			return INestedScrollingChild3Invoker.cb_hasNestedScrollingParent_I;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0001C34B File Offset: 0x0001A54B
		private static bool n_InvokeHasNestedScrollingParent_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvokeHasNestedScrollingParent(type);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0001C35C File Offset: 0x0001A55C
		public unsafe bool InvokeHasNestedScrollingParent(int type)
		{
			if (this.id_hasNestedScrollingParent_I == IntPtr.Zero)
			{
				this.id_hasNestedScrollingParent_I = JNIEnv.GetMethodID(this.class_ref, "hasNestedScrollingParent", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(type);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasNestedScrollingParent_I, ptr);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		private static Delegate GetStartNestedScroll_IIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_startNestedScroll_II == null)
			{
				INestedScrollingChild3Invoker.cb_startNestedScroll_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(INestedScrollingChild3Invoker.n_StartNestedScroll_II));
			}
			return INestedScrollingChild3Invoker.cb_startNestedScroll_II;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
		private static bool n_StartNestedScroll_II(IntPtr jnienv, IntPtr native__this, int native_axes, int type)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes, type);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0001C404 File Offset: 0x0001A604
		public unsafe bool StartNestedScroll([GeneratedEnum] ScrollAxis axes, int type)
		{
			if (this.id_startNestedScroll_II == IntPtr.Zero)
			{
				this.id_startNestedScroll_II = JNIEnv.GetMethodID(this.class_ref, "startNestedScroll", "(II)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)axes);
			ptr[1] = new JValue(type);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_startNestedScroll_II, ptr);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0001C47B File Offset: 0x0001A67B
		private static Delegate GetStopNestedScroll_IHandler()
		{
			if (INestedScrollingChild3Invoker.cb_stopNestedScroll_I == null)
			{
				INestedScrollingChild3Invoker.cb_stopNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(INestedScrollingChild3Invoker.n_StopNestedScroll_I));
			}
			return INestedScrollingChild3Invoker.cb_stopNestedScroll_I;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0001C49F File Offset: 0x0001A69F
		private static void n_StopNestedScroll_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll(type);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
		public unsafe void StopNestedScroll(int type)
		{
			if (this.id_stopNestedScroll_I == IntPtr.Zero)
			{
				this.id_stopNestedScroll_I = JNIEnv.GetMethodID(this.class_ref, "stopNestedScroll", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(type);
			JNIEnv.CallVoidMethod(base.Handle, this.id_stopNestedScroll_I, ptr);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0001C514 File Offset: 0x0001A714
		private static Delegate GetHasNestedScrollingParentHandler()
		{
			if (INestedScrollingChild3Invoker.cb_hasNestedScrollingParent == null)
			{
				INestedScrollingChild3Invoker.cb_hasNestedScrollingParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChild3Invoker.n_HasNestedScrollingParent));
			}
			return INestedScrollingChild3Invoker.cb_hasNestedScrollingParent;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0001C538 File Offset: 0x0001A738
		private static bool n_HasNestedScrollingParent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNestedScrollingParent;
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0001C547 File Offset: 0x0001A747
		public bool HasNestedScrollingParent
		{
			get
			{
				if (this.id_hasNestedScrollingParent == IntPtr.Zero)
				{
					this.id_hasNestedScrollingParent = JNIEnv.GetMethodID(this.class_ref, "hasNestedScrollingParent", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasNestedScrollingParent);
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001C587 File Offset: 0x0001A787
		private static Delegate GetIsNestedScrollingEnabledHandler()
		{
			if (INestedScrollingChild3Invoker.cb_isNestedScrollingEnabled == null)
			{
				INestedScrollingChild3Invoker.cb_isNestedScrollingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChild3Invoker.n_IsNestedScrollingEnabled));
			}
			return INestedScrollingChild3Invoker.cb_isNestedScrollingEnabled;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0001C5AB File Offset: 0x0001A7AB
		private static bool n_IsNestedScrollingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001C5BA File Offset: 0x0001A7BA
		private static Delegate GetSetNestedScrollingEnabled_ZHandler()
		{
			if (INestedScrollingChild3Invoker.cb_setNestedScrollingEnabled_Z == null)
			{
				INestedScrollingChild3Invoker.cb_setNestedScrollingEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(INestedScrollingChild3Invoker.n_SetNestedScrollingEnabled_Z));
			}
			return INestedScrollingChild3Invoker.cb_setNestedScrollingEnabled_Z;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0001C5DE File Offset: 0x0001A7DE
		private static void n_SetNestedScrollingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled = enabled;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0001C5EE File Offset: 0x0001A7EE
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0001C630 File Offset: 0x0001A830
		public unsafe bool NestedScrollingEnabled
		{
			get
			{
				if (this.id_isNestedScrollingEnabled == IntPtr.Zero)
				{
					this.id_isNestedScrollingEnabled = JNIEnv.GetMethodID(this.class_ref, "isNestedScrollingEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isNestedScrollingEnabled);
			}
			set
			{
				if (this.id_setNestedScrollingEnabled_Z == IntPtr.Zero)
				{
					this.id_setNestedScrollingEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setNestedScrollingEnabled", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setNestedScrollingEnabled_Z, ptr);
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0001C694 File Offset: 0x0001A894
		private static Delegate GetDispatchNestedFling_FFZHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedFling_FFZ == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedFling_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFZ_Z(INestedScrollingChild3Invoker.n_DispatchNestedFling_FFZ));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedFling_FFZ;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0001C6B8 File Offset: 0x0001A8B8
		private static bool n_DispatchNestedFling_FFZ(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY, bool consumed)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedFling(velocityX, velocityY, consumed);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0001C6CC File Offset: 0x0001A8CC
		public unsafe bool DispatchNestedFling(float velocityX, float velocityY, bool consumed)
		{
			if (this.id_dispatchNestedFling_FFZ == IntPtr.Zero)
			{
				this.id_dispatchNestedFling_FFZ = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedFling", "(FFZ)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(velocityX);
			ptr[1] = new JValue(velocityY);
			ptr[2] = new JValue(consumed);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedFling_FFZ, ptr);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001C759 File Offset: 0x0001A959
		private static Delegate GetDispatchNestedPreFling_FFHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedPreFling_FF == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedPreFling_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_Z(INestedScrollingChild3Invoker.n_DispatchNestedPreFling_FF));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedPreFling_FF;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0001C77D File Offset: 0x0001A97D
		private static bool n_DispatchNestedPreFling_FF(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedPreFling(velocityX, velocityY);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0001C790 File Offset: 0x0001A990
		public unsafe bool DispatchNestedPreFling(float velocityX, float velocityY)
		{
			if (this.id_dispatchNestedPreFling_FF == IntPtr.Zero)
			{
				this.id_dispatchNestedPreFling_FF = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedPreFling", "(FF)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(velocityX);
			ptr[1] = new JValue(velocityY);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedPreFling_FF, ptr);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001C807 File Offset: 0x0001AA07
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_Z(INestedScrollingChild3Invoker.n_DispatchNestedPreScroll_IIarrayIarrayI));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001C82C File Offset: 0x0001AA2C
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayI(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			int[] array2 = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedPreScroll(dx, dy, array, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0001C890 File Offset: 0x0001AA90
		public unsafe bool DispatchNestedPreScroll(int dx, int dy, int[] consumed, int[] offsetInWindow)
		{
			if (this.id_dispatchNestedPreScroll_IIarrayIarrayI == IntPtr.Zero)
			{
				this.id_dispatchNestedPreScroll_IIarrayIarrayI = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedPreScroll", "(II[I[I)Z");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			IntPtr intPtr2 = JNIEnv.NewArray(offsetInWindow);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(dx);
			ptr[1] = new JValue(dy);
			ptr[2] = new JValue(intPtr);
			ptr[3] = new JValue(intPtr2);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedPreScroll_IIarrayIarrayI, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			if (offsetInWindow != null)
			{
				JNIEnv.CopyArray(intPtr2, offsetInWindow);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0001C964 File Offset: 0x0001AB64
		private static Delegate GetDispatchNestedScroll_IIIIarrayIHandler()
		{
			if (INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayI == null)
			{
				INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIIL_Z(INestedScrollingChild3Invoker.n_DispatchNestedScroll_IIIIarrayI));
			}
			return INestedScrollingChild3Invoker.cb_dispatchNestedScroll_IIIIarrayI;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0001C988 File Offset: 0x0001AB88
		private static bool n_DispatchNestedScroll_IIIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001C9CC File Offset: 0x0001ABCC
		public unsafe bool DispatchNestedScroll(int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow)
		{
			if (this.id_dispatchNestedScroll_IIIIarrayI == IntPtr.Zero)
			{
				this.id_dispatchNestedScroll_IIIIarrayI = JNIEnv.GetMethodID(this.class_ref, "dispatchNestedScroll", "(IIII[I)Z");
			}
			IntPtr intPtr = JNIEnv.NewArray(offsetInWindow);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(dxConsumed);
			ptr[1] = new JValue(dyConsumed);
			ptr[2] = new JValue(dxUnconsumed);
			ptr[3] = new JValue(dyUnconsumed);
			ptr[4] = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_dispatchNestedScroll_IIIIarrayI, ptr);
			if (offsetInWindow != null)
			{
				JNIEnv.CopyArray(intPtr, offsetInWindow);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		private static Delegate GetStartNestedScroll_IHandler()
		{
			if (INestedScrollingChild3Invoker.cb_startNestedScroll_I == null)
			{
				INestedScrollingChild3Invoker.cb_startNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(INestedScrollingChild3Invoker.n_StartNestedScroll_I));
			}
			return INestedScrollingChild3Invoker.cb_startNestedScroll_I;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
		private static bool n_StartNestedScroll_I(IntPtr jnienv, IntPtr native__this, int native_axes)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		public unsafe bool StartNestedScroll([GeneratedEnum] ScrollAxis axes)
		{
			if (this.id_startNestedScroll_I == IntPtr.Zero)
			{
				this.id_startNestedScroll_I = JNIEnv.GetMethodID(this.class_ref, "startNestedScroll", "(I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)axes);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_startNestedScroll_I, ptr);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0001CB48 File Offset: 0x0001AD48
		private static Delegate GetStopNestedScrollHandler()
		{
			if (INestedScrollingChild3Invoker.cb_stopNestedScroll == null)
			{
				INestedScrollingChild3Invoker.cb_stopNestedScroll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(INestedScrollingChild3Invoker.n_StopNestedScroll));
			}
			return INestedScrollingChild3Invoker.cb_stopNestedScroll;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0001CB6C File Offset: 0x0001AD6C
		private static void n_StopNestedScroll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild3>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0001CB7B File Offset: 0x0001AD7B
		public void StopNestedScroll()
		{
			if (this.id_stopNestedScroll == IntPtr.Zero)
			{
				this.id_stopNestedScroll = JNIEnv.GetMethodID(this.class_ref, "stopNestedScroll", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stopNestedScroll);
		}

		// Token: 0x04000293 RID: 659
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingChild3", typeof(INestedScrollingChild3Invoker));

		// Token: 0x04000294 RID: 660
		private IntPtr class_ref;

		// Token: 0x04000295 RID: 661
		private static Delegate cb_dispatchNestedScroll_IIIIarrayIIarrayI;

		// Token: 0x04000296 RID: 662
		private IntPtr id_dispatchNestedScroll_IIIIarrayIIarrayI;

		// Token: 0x04000297 RID: 663
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x04000298 RID: 664
		private IntPtr id_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x04000299 RID: 665
		private static Delegate cb_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x0400029A RID: 666
		private IntPtr id_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x0400029B RID: 667
		private static Delegate cb_hasNestedScrollingParent_I;

		// Token: 0x0400029C RID: 668
		private IntPtr id_hasNestedScrollingParent_I;

		// Token: 0x0400029D RID: 669
		private static Delegate cb_startNestedScroll_II;

		// Token: 0x0400029E RID: 670
		private IntPtr id_startNestedScroll_II;

		// Token: 0x0400029F RID: 671
		private static Delegate cb_stopNestedScroll_I;

		// Token: 0x040002A0 RID: 672
		private IntPtr id_stopNestedScroll_I;

		// Token: 0x040002A1 RID: 673
		private static Delegate cb_hasNestedScrollingParent;

		// Token: 0x040002A2 RID: 674
		private IntPtr id_hasNestedScrollingParent;

		// Token: 0x040002A3 RID: 675
		private static Delegate cb_isNestedScrollingEnabled;

		// Token: 0x040002A4 RID: 676
		private static Delegate cb_setNestedScrollingEnabled_Z;

		// Token: 0x040002A5 RID: 677
		private IntPtr id_isNestedScrollingEnabled;

		// Token: 0x040002A6 RID: 678
		private IntPtr id_setNestedScrollingEnabled_Z;

		// Token: 0x040002A7 RID: 679
		private static Delegate cb_dispatchNestedFling_FFZ;

		// Token: 0x040002A8 RID: 680
		private IntPtr id_dispatchNestedFling_FFZ;

		// Token: 0x040002A9 RID: 681
		private static Delegate cb_dispatchNestedPreFling_FF;

		// Token: 0x040002AA RID: 682
		private IntPtr id_dispatchNestedPreFling_FF;

		// Token: 0x040002AB RID: 683
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x040002AC RID: 684
		private IntPtr id_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x040002AD RID: 685
		private static Delegate cb_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x040002AE RID: 686
		private IntPtr id_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x040002AF RID: 687
		private static Delegate cb_startNestedScroll_I;

		// Token: 0x040002B0 RID: 688
		private IntPtr id_startNestedScroll_I;

		// Token: 0x040002B1 RID: 689
		private static Delegate cb_stopNestedScroll;

		// Token: 0x040002B2 RID: 690
		private IntPtr id_stopNestedScroll;
	}
}
