using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x0200023C RID: 572
	[Register("android/graphics/drawable/Animatable", DoNotGenerateAcw = true)]
	internal class IAnimatableInvoker : Java.Lang.Object, IAnimatable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0003472C File Offset: 0x0003292C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAnimatableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00034750 File Offset: 0x00032950
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAnimatableInvoker._members;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00034757 File Offset: 0x00032957
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0003475F File Offset: 0x0003295F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAnimatableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0003476B File Offset: 0x0003296B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAnimatableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.graphics.drawable.Animatable'.");
			}
			return handle;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00034796 File Offset: 0x00032996
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000347C8 File Offset: 0x000329C8
		public IAnimatableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAnimatableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00034800 File Offset: 0x00032A00
		private static Delegate GetIsRunningHandler()
		{
			if (IAnimatableInvoker.cb_isRunning == null)
			{
				IAnimatableInvoker.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAnimatableInvoker.n_IsRunning));
			}
			return IAnimatableInvoker.cb_isRunning;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00034824 File Offset: 0x00032A24
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAnimatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00034833 File Offset: 0x00032A33
		public bool IsRunning
		{
			get
			{
				if (this.id_isRunning == IntPtr.Zero)
				{
					this.id_isRunning = JNIEnv.GetMethodID(this.class_ref, "isRunning", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isRunning);
			}
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00034873 File Offset: 0x00032A73
		private static Delegate GetStartHandler()
		{
			if (IAnimatableInvoker.cb_start == null)
			{
				IAnimatableInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAnimatableInvoker.n_Start));
			}
			return IAnimatableInvoker.cb_start;
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00034897 File Offset: 0x00032A97
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAnimatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x000348A6 File Offset: 0x00032AA6
		public void Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000348E6 File Offset: 0x00032AE6
		private static Delegate GetStopHandler()
		{
			if (IAnimatableInvoker.cb_stop == null)
			{
				IAnimatableInvoker.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAnimatableInvoker.n_Stop));
			}
			return IAnimatableInvoker.cb_stop;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0003490A File Offset: 0x00032B0A
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAnimatable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00034919 File Offset: 0x00032B19
		public void Stop()
		{
			if (this.id_stop == IntPtr.Zero)
			{
				this.id_stop = JNIEnv.GetMethodID(this.class_ref, "stop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stop);
		}

		// Token: 0x040008DF RID: 2271
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/Animatable", typeof(IAnimatableInvoker));

		// Token: 0x040008E0 RID: 2272
		private IntPtr class_ref;

		// Token: 0x040008E1 RID: 2273
		private static Delegate cb_isRunning;

		// Token: 0x040008E2 RID: 2274
		private IntPtr id_isRunning;

		// Token: 0x040008E3 RID: 2275
		private static Delegate cb_start;

		// Token: 0x040008E4 RID: 2276
		private IntPtr id_start;

		// Token: 0x040008E5 RID: 2277
		private static Delegate cb_stop;

		// Token: 0x040008E6 RID: 2278
		private IntPtr id_stop;
	}
}
