using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A9 RID: 169
	[Register("androidx/core/view/NestedScrollingChild2", DoNotGenerateAcw = true)]
	internal class INestedScrollingChild2Invoker : Java.Lang.Object, INestedScrollingChild2, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0001B174 File Offset: 0x00019374
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingChild2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001B198 File Offset: 0x00019398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingChild2Invoker._members;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0001B19F File Offset: 0x0001939F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0001B1A7 File Offset: 0x000193A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingChild2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001B1B3 File Offset: 0x000193B3
		public static INestedScrollingChild2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(handle, transfer);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001B1BC File Offset: 0x000193BC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingChild2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingChild2'.");
			}
			return handle;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0001B1E7 File Offset: 0x000193E7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0001B218 File Offset: 0x00019418
		public INestedScrollingChild2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingChild2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0001B250 File Offset: 0x00019450
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIIHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILLI_Z(INestedScrollingChild2Invoker.n_DispatchNestedPreScroll_IIarrayIarrayII));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayII;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0001B274 File Offset: 0x00019474
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayII(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow, int type)
		{
			INestedScrollingChild2 @object = Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x06000915 RID: 2325 RVA: 0x0001B2DC File Offset: 0x000194DC
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

		// Token: 0x06000916 RID: 2326 RVA: 0x0001B3C7 File Offset: 0x000195C7
		private static Delegate GetDispatchNestedScroll_IIIIarrayIIHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayII == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIILI_Z(INestedScrollingChild2Invoker.n_DispatchNestedScroll_IIIIarrayII));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayII;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001B3EC File Offset: 0x000195EC
		private static bool n_DispatchNestedScroll_IIIIarrayII(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type)
		{
			INestedScrollingChild2 @object = Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0001B434 File Offset: 0x00019634
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

		// Token: 0x06000919 RID: 2329 RVA: 0x0001B51F File Offset: 0x0001971F
		private static Delegate GetInvokeHasNestedScrollingParent_IHandler()
		{
			if (INestedScrollingChild2Invoker.cb_hasNestedScrollingParent_I == null)
			{
				INestedScrollingChild2Invoker.cb_hasNestedScrollingParent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(INestedScrollingChild2Invoker.n_InvokeHasNestedScrollingParent_I));
			}
			return INestedScrollingChild2Invoker.cb_hasNestedScrollingParent_I;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001B543 File Offset: 0x00019743
		private static bool n_InvokeHasNestedScrollingParent_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvokeHasNestedScrollingParent(type);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001B554 File Offset: 0x00019754
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

		// Token: 0x0600091C RID: 2332 RVA: 0x0001B5B8 File Offset: 0x000197B8
		private static Delegate GetStartNestedScroll_IIHandler()
		{
			if (INestedScrollingChild2Invoker.cb_startNestedScroll_II == null)
			{
				INestedScrollingChild2Invoker.cb_startNestedScroll_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(INestedScrollingChild2Invoker.n_StartNestedScroll_II));
			}
			return INestedScrollingChild2Invoker.cb_startNestedScroll_II;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001B5DC File Offset: 0x000197DC
		private static bool n_StartNestedScroll_II(IntPtr jnienv, IntPtr native__this, int native_axes, int type)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes, type);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001B5FC File Offset: 0x000197FC
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

		// Token: 0x0600091F RID: 2335 RVA: 0x0001B673 File Offset: 0x00019873
		private static Delegate GetStopNestedScroll_IHandler()
		{
			if (INestedScrollingChild2Invoker.cb_stopNestedScroll_I == null)
			{
				INestedScrollingChild2Invoker.cb_stopNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(INestedScrollingChild2Invoker.n_StopNestedScroll_I));
			}
			return INestedScrollingChild2Invoker.cb_stopNestedScroll_I;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0001B697 File Offset: 0x00019897
		private static void n_StopNestedScroll_I(IntPtr jnienv, IntPtr native__this, int type)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll(type);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001B6A8 File Offset: 0x000198A8
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

		// Token: 0x06000922 RID: 2338 RVA: 0x0001B70C File Offset: 0x0001990C
		private static Delegate GetHasNestedScrollingParentHandler()
		{
			if (INestedScrollingChild2Invoker.cb_hasNestedScrollingParent == null)
			{
				INestedScrollingChild2Invoker.cb_hasNestedScrollingParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChild2Invoker.n_HasNestedScrollingParent));
			}
			return INestedScrollingChild2Invoker.cb_hasNestedScrollingParent;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0001B730 File Offset: 0x00019930
		private static bool n_HasNestedScrollingParent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNestedScrollingParent;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0001B73F File Offset: 0x0001993F
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

		// Token: 0x06000925 RID: 2341 RVA: 0x0001B77F File Offset: 0x0001997F
		private static Delegate GetIsNestedScrollingEnabledHandler()
		{
			if (INestedScrollingChild2Invoker.cb_isNestedScrollingEnabled == null)
			{
				INestedScrollingChild2Invoker.cb_isNestedScrollingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChild2Invoker.n_IsNestedScrollingEnabled));
			}
			return INestedScrollingChild2Invoker.cb_isNestedScrollingEnabled;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001B7A3 File Offset: 0x000199A3
		private static bool n_IsNestedScrollingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001B7B2 File Offset: 0x000199B2
		private static Delegate GetSetNestedScrollingEnabled_ZHandler()
		{
			if (INestedScrollingChild2Invoker.cb_setNestedScrollingEnabled_Z == null)
			{
				INestedScrollingChild2Invoker.cb_setNestedScrollingEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(INestedScrollingChild2Invoker.n_SetNestedScrollingEnabled_Z));
			}
			return INestedScrollingChild2Invoker.cb_setNestedScrollingEnabled_Z;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0001B7D6 File Offset: 0x000199D6
		private static void n_SetNestedScrollingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled = enabled;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0001B7E6 File Offset: 0x000199E6
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0001B828 File Offset: 0x00019A28
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

		// Token: 0x0600092B RID: 2347 RVA: 0x0001B88C File Offset: 0x00019A8C
		private static Delegate GetDispatchNestedFling_FFZHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedFling_FFZ == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedFling_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFZ_Z(INestedScrollingChild2Invoker.n_DispatchNestedFling_FFZ));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedFling_FFZ;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		private static bool n_DispatchNestedFling_FFZ(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY, bool consumed)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedFling(velocityX, velocityY, consumed);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001B8C4 File Offset: 0x00019AC4
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

		// Token: 0x0600092E RID: 2350 RVA: 0x0001B951 File Offset: 0x00019B51
		private static Delegate GetDispatchNestedPreFling_FFHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedPreFling_FF == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedPreFling_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_Z(INestedScrollingChild2Invoker.n_DispatchNestedPreFling_FF));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedPreFling_FF;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0001B975 File Offset: 0x00019B75
		private static bool n_DispatchNestedPreFling_FF(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedPreFling(velocityX, velocityY);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0001B988 File Offset: 0x00019B88
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

		// Token: 0x06000931 RID: 2353 RVA: 0x0001B9FF File Offset: 0x00019BFF
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_Z(INestedScrollingChild2Invoker.n_DispatchNestedPreScroll_IIarrayIarrayI));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedPreScroll_IIarrayIarrayI;
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0001BA24 File Offset: 0x00019C24
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayI(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x06000933 RID: 2355 RVA: 0x0001BA88 File Offset: 0x00019C88
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

		// Token: 0x06000934 RID: 2356 RVA: 0x0001BB5C File Offset: 0x00019D5C
		private static Delegate GetDispatchNestedScroll_IIIIarrayIHandler()
		{
			if (INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayI == null)
			{
				INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIIL_Z(INestedScrollingChild2Invoker.n_DispatchNestedScroll_IIIIarrayI));
			}
			return INestedScrollingChild2Invoker.cb_dispatchNestedScroll_IIIIarrayI;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0001BB80 File Offset: 0x00019D80
		private static bool n_DispatchNestedScroll_IIIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001BBC4 File Offset: 0x00019DC4
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

		// Token: 0x06000937 RID: 2359 RVA: 0x0001BC98 File Offset: 0x00019E98
		private static Delegate GetStartNestedScroll_IHandler()
		{
			if (INestedScrollingChild2Invoker.cb_startNestedScroll_I == null)
			{
				INestedScrollingChild2Invoker.cb_startNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(INestedScrollingChild2Invoker.n_StartNestedScroll_I));
			}
			return INestedScrollingChild2Invoker.cb_startNestedScroll_I;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0001BCBC File Offset: 0x00019EBC
		private static bool n_StartNestedScroll_I(IntPtr jnienv, IntPtr native__this, int native_axes)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0001BCDC File Offset: 0x00019EDC
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

		// Token: 0x0600093A RID: 2362 RVA: 0x0001BD40 File Offset: 0x00019F40
		private static Delegate GetStopNestedScrollHandler()
		{
			if (INestedScrollingChild2Invoker.cb_stopNestedScroll == null)
			{
				INestedScrollingChild2Invoker.cb_stopNestedScroll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(INestedScrollingChild2Invoker.n_StopNestedScroll));
			}
			return INestedScrollingChild2Invoker.cb_stopNestedScroll;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0001BD64 File Offset: 0x00019F64
		private static void n_StopNestedScroll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0001BD73 File Offset: 0x00019F73
		public void StopNestedScroll()
		{
			if (this.id_stopNestedScroll == IntPtr.Zero)
			{
				this.id_stopNestedScroll = JNIEnv.GetMethodID(this.class_ref, "stopNestedScroll", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stopNestedScroll);
		}

		// Token: 0x04000275 RID: 629
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingChild2", typeof(INestedScrollingChild2Invoker));

		// Token: 0x04000276 RID: 630
		private IntPtr class_ref;

		// Token: 0x04000277 RID: 631
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x04000278 RID: 632
		private IntPtr id_dispatchNestedPreScroll_IIarrayIarrayII;

		// Token: 0x04000279 RID: 633
		private static Delegate cb_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x0400027A RID: 634
		private IntPtr id_dispatchNestedScroll_IIIIarrayII;

		// Token: 0x0400027B RID: 635
		private static Delegate cb_hasNestedScrollingParent_I;

		// Token: 0x0400027C RID: 636
		private IntPtr id_hasNestedScrollingParent_I;

		// Token: 0x0400027D RID: 637
		private static Delegate cb_startNestedScroll_II;

		// Token: 0x0400027E RID: 638
		private IntPtr id_startNestedScroll_II;

		// Token: 0x0400027F RID: 639
		private static Delegate cb_stopNestedScroll_I;

		// Token: 0x04000280 RID: 640
		private IntPtr id_stopNestedScroll_I;

		// Token: 0x04000281 RID: 641
		private static Delegate cb_hasNestedScrollingParent;

		// Token: 0x04000282 RID: 642
		private IntPtr id_hasNestedScrollingParent;

		// Token: 0x04000283 RID: 643
		private static Delegate cb_isNestedScrollingEnabled;

		// Token: 0x04000284 RID: 644
		private static Delegate cb_setNestedScrollingEnabled_Z;

		// Token: 0x04000285 RID: 645
		private IntPtr id_isNestedScrollingEnabled;

		// Token: 0x04000286 RID: 646
		private IntPtr id_setNestedScrollingEnabled_Z;

		// Token: 0x04000287 RID: 647
		private static Delegate cb_dispatchNestedFling_FFZ;

		// Token: 0x04000288 RID: 648
		private IntPtr id_dispatchNestedFling_FFZ;

		// Token: 0x04000289 RID: 649
		private static Delegate cb_dispatchNestedPreFling_FF;

		// Token: 0x0400028A RID: 650
		private IntPtr id_dispatchNestedPreFling_FF;

		// Token: 0x0400028B RID: 651
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x0400028C RID: 652
		private IntPtr id_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x0400028D RID: 653
		private static Delegate cb_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x0400028E RID: 654
		private IntPtr id_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x0400028F RID: 655
		private static Delegate cb_startNestedScroll_I;

		// Token: 0x04000290 RID: 656
		private IntPtr id_startNestedScroll_I;

		// Token: 0x04000291 RID: 657
		private static Delegate cb_stopNestedScroll;

		// Token: 0x04000292 RID: 658
		private IntPtr id_stopNestedScroll;
	}
}
