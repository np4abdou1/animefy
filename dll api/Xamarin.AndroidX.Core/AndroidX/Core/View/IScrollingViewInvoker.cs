using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B2 RID: 178
	[Register("androidx/core/view/ScrollingView", DoNotGenerateAcw = true)]
	internal class IScrollingViewInvoker : Java.Lang.Object, IScrollingView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IScrollingViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0001F1DC File Offset: 0x0001D3DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScrollingViewInvoker._members;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0001F1E3 File Offset: 0x0001D3E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0001F1EB File Offset: 0x0001D3EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScrollingViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0001F1F7 File Offset: 0x0001D3F7
		public static IScrollingView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(handle, transfer);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0001F200 File Offset: 0x0001D400
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScrollingViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.ScrollingView'.");
			}
			return handle;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0001F22B File Offset: 0x0001D42B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0001F25C File Offset: 0x0001D45C
		public IScrollingViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScrollingViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0001F294 File Offset: 0x0001D494
		private static Delegate GetComputeHorizontalScrollExtentHandler()
		{
			if (IScrollingViewInvoker.cb_computeHorizontalScrollExtent == null)
			{
				IScrollingViewInvoker.cb_computeHorizontalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeHorizontalScrollExtent));
			}
			return IScrollingViewInvoker.cb_computeHorizontalScrollExtent;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		private static int n_ComputeHorizontalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollExtent();
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0001F2C7 File Offset: 0x0001D4C7
		public int ComputeHorizontalScrollExtent()
		{
			if (this.id_computeHorizontalScrollExtent == IntPtr.Zero)
			{
				this.id_computeHorizontalScrollExtent = JNIEnv.GetMethodID(this.class_ref, "computeHorizontalScrollExtent", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeHorizontalScrollExtent);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0001F307 File Offset: 0x0001D507
		private static Delegate GetComputeHorizontalScrollOffsetHandler()
		{
			if (IScrollingViewInvoker.cb_computeHorizontalScrollOffset == null)
			{
				IScrollingViewInvoker.cb_computeHorizontalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeHorizontalScrollOffset));
			}
			return IScrollingViewInvoker.cb_computeHorizontalScrollOffset;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0001F32B File Offset: 0x0001D52B
		private static int n_ComputeHorizontalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollOffset();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0001F33A File Offset: 0x0001D53A
		public int ComputeHorizontalScrollOffset()
		{
			if (this.id_computeHorizontalScrollOffset == IntPtr.Zero)
			{
				this.id_computeHorizontalScrollOffset = JNIEnv.GetMethodID(this.class_ref, "computeHorizontalScrollOffset", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeHorizontalScrollOffset);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0001F37A File Offset: 0x0001D57A
		private static Delegate GetComputeHorizontalScrollRangeHandler()
		{
			if (IScrollingViewInvoker.cb_computeHorizontalScrollRange == null)
			{
				IScrollingViewInvoker.cb_computeHorizontalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeHorizontalScrollRange));
			}
			return IScrollingViewInvoker.cb_computeHorizontalScrollRange;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001F39E File Offset: 0x0001D59E
		private static int n_ComputeHorizontalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeHorizontalScrollRange();
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001F3AD File Offset: 0x0001D5AD
		public int ComputeHorizontalScrollRange()
		{
			if (this.id_computeHorizontalScrollRange == IntPtr.Zero)
			{
				this.id_computeHorizontalScrollRange = JNIEnv.GetMethodID(this.class_ref, "computeHorizontalScrollRange", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeHorizontalScrollRange);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0001F3ED File Offset: 0x0001D5ED
		private static Delegate GetComputeVerticalScrollExtentHandler()
		{
			if (IScrollingViewInvoker.cb_computeVerticalScrollExtent == null)
			{
				IScrollingViewInvoker.cb_computeVerticalScrollExtent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeVerticalScrollExtent));
			}
			return IScrollingViewInvoker.cb_computeVerticalScrollExtent;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0001F411 File Offset: 0x0001D611
		private static int n_ComputeVerticalScrollExtent(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollExtent();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0001F420 File Offset: 0x0001D620
		public int ComputeVerticalScrollExtent()
		{
			if (this.id_computeVerticalScrollExtent == IntPtr.Zero)
			{
				this.id_computeVerticalScrollExtent = JNIEnv.GetMethodID(this.class_ref, "computeVerticalScrollExtent", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeVerticalScrollExtent);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001F460 File Offset: 0x0001D660
		private static Delegate GetComputeVerticalScrollOffsetHandler()
		{
			if (IScrollingViewInvoker.cb_computeVerticalScrollOffset == null)
			{
				IScrollingViewInvoker.cb_computeVerticalScrollOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeVerticalScrollOffset));
			}
			return IScrollingViewInvoker.cb_computeVerticalScrollOffset;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001F484 File Offset: 0x0001D684
		private static int n_ComputeVerticalScrollOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollOffset();
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001F493 File Offset: 0x0001D693
		public int ComputeVerticalScrollOffset()
		{
			if (this.id_computeVerticalScrollOffset == IntPtr.Zero)
			{
				this.id_computeVerticalScrollOffset = JNIEnv.GetMethodID(this.class_ref, "computeVerticalScrollOffset", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeVerticalScrollOffset);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001F4D3 File Offset: 0x0001D6D3
		private static Delegate GetComputeVerticalScrollRangeHandler()
		{
			if (IScrollingViewInvoker.cb_computeVerticalScrollRange == null)
			{
				IScrollingViewInvoker.cb_computeVerticalScrollRange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IScrollingViewInvoker.n_ComputeVerticalScrollRange));
			}
			return IScrollingViewInvoker.cb_computeVerticalScrollRange;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001F4F7 File Offset: 0x0001D6F7
		private static int n_ComputeVerticalScrollRange(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IScrollingView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ComputeVerticalScrollRange();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001F506 File Offset: 0x0001D706
		public int ComputeVerticalScrollRange()
		{
			if (this.id_computeVerticalScrollRange == IntPtr.Zero)
			{
				this.id_computeVerticalScrollRange = JNIEnv.GetMethodID(this.class_ref, "computeVerticalScrollRange", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_computeVerticalScrollRange);
		}

		// Token: 0x040002FF RID: 767
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ScrollingView", typeof(IScrollingViewInvoker));

		// Token: 0x04000300 RID: 768
		private IntPtr class_ref;

		// Token: 0x04000301 RID: 769
		private static Delegate cb_computeHorizontalScrollExtent;

		// Token: 0x04000302 RID: 770
		private IntPtr id_computeHorizontalScrollExtent;

		// Token: 0x04000303 RID: 771
		private static Delegate cb_computeHorizontalScrollOffset;

		// Token: 0x04000304 RID: 772
		private IntPtr id_computeHorizontalScrollOffset;

		// Token: 0x04000305 RID: 773
		private static Delegate cb_computeHorizontalScrollRange;

		// Token: 0x04000306 RID: 774
		private IntPtr id_computeHorizontalScrollRange;

		// Token: 0x04000307 RID: 775
		private static Delegate cb_computeVerticalScrollExtent;

		// Token: 0x04000308 RID: 776
		private IntPtr id_computeVerticalScrollExtent;

		// Token: 0x04000309 RID: 777
		private static Delegate cb_computeVerticalScrollOffset;

		// Token: 0x0400030A RID: 778
		private IntPtr id_computeVerticalScrollOffset;

		// Token: 0x0400030B RID: 779
		private static Delegate cb_computeVerticalScrollRange;

		// Token: 0x0400030C RID: 780
		private IntPtr id_computeVerticalScrollRange;
	}
}
