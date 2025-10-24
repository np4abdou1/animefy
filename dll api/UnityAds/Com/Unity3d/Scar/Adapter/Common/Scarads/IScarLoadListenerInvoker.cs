using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Scarads
{
	// Token: 0x020002BE RID: 702
	[Register("com/unity3d/scar/adapter/common/scarads/IScarLoadListener", DoNotGenerateAcw = true)]
	internal class IScarLoadListenerInvoker : Java.Lang.Object, IScarLoadListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x00066550 File Offset: 0x00064750
		private static IntPtr java_class_ref
		{
			get
			{
				return IScarLoadListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x00066574 File Offset: 0x00064774
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IScarLoadListenerInvoker._members;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x0006657B File Offset: 0x0006477B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x00066583 File Offset: 0x00064783
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IScarLoadListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0006658F File Offset: 0x0006478F
		public static IScarLoadListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IScarLoadListener>(handle, transfer);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00066598 File Offset: 0x00064798
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IScarLoadListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.scarads.IScarLoadListener'.");
			}
			return handle;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000665C3 File Offset: 0x000647C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000665F4 File Offset: 0x000647F4
		public IScarLoadListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IScarLoadListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0006662C File Offset: 0x0006482C
		private static Delegate GetOnAdLoadedHandler()
		{
			if (IScarLoadListenerInvoker.cb_onAdLoaded == null)
			{
				IScarLoadListenerInvoker.cb_onAdLoaded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IScarLoadListenerInvoker.n_OnAdLoaded));
			}
			return IScarLoadListenerInvoker.cb_onAdLoaded;
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00066650 File Offset: 0x00064850
		private static void n_OnAdLoaded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IScarLoadListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAdLoaded();
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x0006665F File Offset: 0x0006485F
		public void OnAdLoaded()
		{
			if (this.id_onAdLoaded == IntPtr.Zero)
			{
				this.id_onAdLoaded = JNIEnv.GetMethodID(this.class_ref, "onAdLoaded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdLoaded);
		}

		// Token: 0x040007EF RID: 2031
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/scarads/IScarLoadListener", typeof(IScarLoadListenerInvoker));

		// Token: 0x040007F0 RID: 2032
		private IntPtr class_ref;

		// Token: 0x040007F1 RID: 2033
		private static Delegate cb_onAdLoaded;

		// Token: 0x040007F2 RID: 2034
		private IntPtr id_onAdLoaded;
	}
}
