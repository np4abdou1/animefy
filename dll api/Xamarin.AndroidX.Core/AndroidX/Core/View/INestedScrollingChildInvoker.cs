using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A7 RID: 167
	[Register("androidx/core/view/NestedScrollingChild", DoNotGenerateAcw = true)]
	internal class INestedScrollingChildInvoker : Java.Lang.Object, INestedScrollingChild, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0001A9D4 File Offset: 0x00018BD4
		private static IntPtr java_class_ref
		{
			get
			{
				return INestedScrollingChildInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INestedScrollingChildInvoker._members;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0001A9FF File Offset: 0x00018BFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0001AA07 File Offset: 0x00018C07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INestedScrollingChildInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0001AA13 File Offset: 0x00018C13
		public static INestedScrollingChild GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(handle, transfer);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0001AA1C File Offset: 0x00018C1C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INestedScrollingChildInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.NestedScrollingChild'.");
			}
			return handle;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0001AA47 File Offset: 0x00018C47
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0001AA78 File Offset: 0x00018C78
		public INestedScrollingChildInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INestedScrollingChildInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0001AAB0 File Offset: 0x00018CB0
		private static Delegate GetHasNestedScrollingParentHandler()
		{
			if (INestedScrollingChildInvoker.cb_hasNestedScrollingParent == null)
			{
				INestedScrollingChildInvoker.cb_hasNestedScrollingParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChildInvoker.n_HasNestedScrollingParent));
			}
			return INestedScrollingChildInvoker.cb_hasNestedScrollingParent;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0001AAD4 File Offset: 0x00018CD4
		private static bool n_HasNestedScrollingParent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNestedScrollingParent;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0001AAE3 File Offset: 0x00018CE3
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

		// Token: 0x060008ED RID: 2285 RVA: 0x0001AB23 File Offset: 0x00018D23
		private static Delegate GetIsNestedScrollingEnabledHandler()
		{
			if (INestedScrollingChildInvoker.cb_isNestedScrollingEnabled == null)
			{
				INestedScrollingChildInvoker.cb_isNestedScrollingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(INestedScrollingChildInvoker.n_IsNestedScrollingEnabled));
			}
			return INestedScrollingChildInvoker.cb_isNestedScrollingEnabled;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0001AB47 File Offset: 0x00018D47
		private static bool n_IsNestedScrollingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0001AB56 File Offset: 0x00018D56
		private static Delegate GetSetNestedScrollingEnabled_ZHandler()
		{
			if (INestedScrollingChildInvoker.cb_setNestedScrollingEnabled_Z == null)
			{
				INestedScrollingChildInvoker.cb_setNestedScrollingEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(INestedScrollingChildInvoker.n_SetNestedScrollingEnabled_Z));
			}
			return INestedScrollingChildInvoker.cb_setNestedScrollingEnabled_Z;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001AB7A File Offset: 0x00018D7A
		private static void n_SetNestedScrollingEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollingEnabled = enabled;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0001AB8A File Offset: 0x00018D8A
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x0001ABCC File Offset: 0x00018DCC
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

		// Token: 0x060008F3 RID: 2291 RVA: 0x0001AC30 File Offset: 0x00018E30
		private static Delegate GetDispatchNestedFling_FFZHandler()
		{
			if (INestedScrollingChildInvoker.cb_dispatchNestedFling_FFZ == null)
			{
				INestedScrollingChildInvoker.cb_dispatchNestedFling_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFZ_Z(INestedScrollingChildInvoker.n_DispatchNestedFling_FFZ));
			}
			return INestedScrollingChildInvoker.cb_dispatchNestedFling_FFZ;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0001AC54 File Offset: 0x00018E54
		private static bool n_DispatchNestedFling_FFZ(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY, bool consumed)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedFling(velocityX, velocityY, consumed);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0001AC68 File Offset: 0x00018E68
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

		// Token: 0x060008F6 RID: 2294 RVA: 0x0001ACF5 File Offset: 0x00018EF5
		private static Delegate GetDispatchNestedPreFling_FFHandler()
		{
			if (INestedScrollingChildInvoker.cb_dispatchNestedPreFling_FF == null)
			{
				INestedScrollingChildInvoker.cb_dispatchNestedPreFling_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_Z(INestedScrollingChildInvoker.n_DispatchNestedPreFling_FF));
			}
			return INestedScrollingChildInvoker.cb_dispatchNestedPreFling_FF;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0001AD19 File Offset: 0x00018F19
		private static bool n_DispatchNestedPreFling_FF(IntPtr jnienv, IntPtr native__this, float velocityX, float velocityY)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchNestedPreFling(velocityX, velocityY);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0001AD2C File Offset: 0x00018F2C
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

		// Token: 0x060008F9 RID: 2297 RVA: 0x0001ADA3 File Offset: 0x00018FA3
		private static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIHandler()
		{
			if (INestedScrollingChildInvoker.cb_dispatchNestedPreScroll_IIarrayIarrayI == null)
			{
				INestedScrollingChildInvoker.cb_dispatchNestedPreScroll_IIarrayIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIILL_Z(INestedScrollingChildInvoker.n_DispatchNestedPreScroll_IIarrayIarrayI));
			}
			return INestedScrollingChildInvoker.cb_dispatchNestedPreScroll_IIarrayIarrayI;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		private static bool n_DispatchNestedPreScroll_IIarrayIarrayI(IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Token: 0x060008FB RID: 2299 RVA: 0x0001AE2C File Offset: 0x0001902C
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

		// Token: 0x060008FC RID: 2300 RVA: 0x0001AF00 File Offset: 0x00019100
		private static Delegate GetDispatchNestedScroll_IIIIarrayIHandler()
		{
			if (INestedScrollingChildInvoker.cb_dispatchNestedScroll_IIIIarrayI == null)
			{
				INestedScrollingChildInvoker.cb_dispatchNestedScroll_IIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIIL_Z(INestedScrollingChildInvoker.n_DispatchNestedScroll_IIIIarrayI));
			}
			return INestedScrollingChildInvoker.cb_dispatchNestedScroll_IIIIarrayI;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0001AF24 File Offset: 0x00019124
		private static bool n_DispatchNestedScroll_IIIIarrayI(IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow)
		{
			INestedScrollingChild @object = Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.DispatchNestedScroll(dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_offsetInWindow);
			}
			return result;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0001AF68 File Offset: 0x00019168
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

		// Token: 0x060008FF RID: 2303 RVA: 0x0001B03C File Offset: 0x0001923C
		private static Delegate GetStartNestedScroll_IHandler()
		{
			if (INestedScrollingChildInvoker.cb_startNestedScroll_I == null)
			{
				INestedScrollingChildInvoker.cb_startNestedScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(INestedScrollingChildInvoker.n_StartNestedScroll_I));
			}
			return INestedScrollingChildInvoker.cb_startNestedScroll_I;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001B060 File Offset: 0x00019260
		private static bool n_StartNestedScroll_I(IntPtr jnienv, IntPtr native__this, int native_axes)
		{
			return Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartNestedScroll((ScrollAxis)native_axes);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001B080 File Offset: 0x00019280
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

		// Token: 0x06000902 RID: 2306 RVA: 0x0001B0E4 File Offset: 0x000192E4
		private static Delegate GetStopNestedScrollHandler()
		{
			if (INestedScrollingChildInvoker.cb_stopNestedScroll == null)
			{
				INestedScrollingChildInvoker.cb_stopNestedScroll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(INestedScrollingChildInvoker.n_StopNestedScroll));
			}
			return INestedScrollingChildInvoker.cb_stopNestedScroll;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001B108 File Offset: 0x00019308
		private static void n_StopNestedScroll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<INestedScrollingChild>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopNestedScroll();
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001B117 File Offset: 0x00019317
		public void StopNestedScroll()
		{
			if (this.id_stopNestedScroll == IntPtr.Zero)
			{
				this.id_stopNestedScroll = JNIEnv.GetMethodID(this.class_ref, "stopNestedScroll", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stopNestedScroll);
		}

		// Token: 0x04000261 RID: 609
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/NestedScrollingChild", typeof(INestedScrollingChildInvoker));

		// Token: 0x04000262 RID: 610
		private IntPtr class_ref;

		// Token: 0x04000263 RID: 611
		private static Delegate cb_hasNestedScrollingParent;

		// Token: 0x04000264 RID: 612
		private IntPtr id_hasNestedScrollingParent;

		// Token: 0x04000265 RID: 613
		private static Delegate cb_isNestedScrollingEnabled;

		// Token: 0x04000266 RID: 614
		private static Delegate cb_setNestedScrollingEnabled_Z;

		// Token: 0x04000267 RID: 615
		private IntPtr id_isNestedScrollingEnabled;

		// Token: 0x04000268 RID: 616
		private IntPtr id_setNestedScrollingEnabled_Z;

		// Token: 0x04000269 RID: 617
		private static Delegate cb_dispatchNestedFling_FFZ;

		// Token: 0x0400026A RID: 618
		private IntPtr id_dispatchNestedFling_FFZ;

		// Token: 0x0400026B RID: 619
		private static Delegate cb_dispatchNestedPreFling_FF;

		// Token: 0x0400026C RID: 620
		private IntPtr id_dispatchNestedPreFling_FF;

		// Token: 0x0400026D RID: 621
		private static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x0400026E RID: 622
		private IntPtr id_dispatchNestedPreScroll_IIarrayIarrayI;

		// Token: 0x0400026F RID: 623
		private static Delegate cb_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x04000270 RID: 624
		private IntPtr id_dispatchNestedScroll_IIIIarrayI;

		// Token: 0x04000271 RID: 625
		private static Delegate cb_startNestedScroll_I;

		// Token: 0x04000272 RID: 626
		private IntPtr id_startNestedScroll_I;

		// Token: 0x04000273 RID: 627
		private static Delegate cb_stopNestedScroll;

		// Token: 0x04000274 RID: 628
		private IntPtr id_stopNestedScroll;
	}
}
