using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000104 RID: 260
	[Register("com/unity3d/services/core/domain/task/BaseParams", DoNotGenerateAcw = true)]
	internal class IBaseParamsInvoker : Java.Lang.Object, IBaseParams, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0001D878 File Offset: 0x0001BA78
		private static IntPtr java_class_ref
		{
			get
			{
				return IBaseParamsInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0001D89C File Offset: 0x0001BA9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBaseParamsInvoker._members;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0001D8A3 File Offset: 0x0001BAA3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0001D8AB File Offset: 0x0001BAAB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBaseParamsInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001D8B7 File Offset: 0x0001BAB7
		public static IBaseParams GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBaseParams>(handle, transfer);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBaseParamsInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.domain.task.BaseParams'.");
			}
			return handle;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001D8EB File Offset: 0x0001BAEB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001D91C File Offset: 0x0001BB1C
		public IBaseParamsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBaseParamsInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000269 RID: 617
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/BaseParams", typeof(IBaseParamsInvoker));

		// Token: 0x0400026A RID: 618
		private IntPtr class_ref;
	}
}
