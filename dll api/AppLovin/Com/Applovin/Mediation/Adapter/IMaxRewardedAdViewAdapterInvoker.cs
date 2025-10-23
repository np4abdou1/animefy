using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x02000109 RID: 265
	[Register("com/applovin/mediation/adapter/MaxRewardedAdViewAdapter", DoNotGenerateAcw = true)]
	internal class IMaxRewardedAdViewAdapterInvoker : Java.Lang.Object, IMaxRewardedAdViewAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0001E334 File Offset: 0x0001C534
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxRewardedAdViewAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0001E358 File Offset: 0x0001C558
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxRewardedAdViewAdapterInvoker._members;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001E35F File Offset: 0x0001C55F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0001E367 File Offset: 0x0001C567
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxRewardedAdViewAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0001E373 File Offset: 0x0001C573
		public static IMaxRewardedAdViewAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxRewardedAdViewAdapter>(handle, transfer);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001E37C File Offset: 0x0001C57C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxRewardedAdViewAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxRewardedAdViewAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001E3A7 File Offset: 0x0001C5A7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001E3D8 File Offset: 0x0001C5D8
		public IMaxRewardedAdViewAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxRewardedAdViewAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040003A6 RID: 934
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxRewardedAdViewAdapter", typeof(IMaxRewardedAdViewAdapterInvoker));

		// Token: 0x040003A7 RID: 935
		private IntPtr class_ref;
	}
}
