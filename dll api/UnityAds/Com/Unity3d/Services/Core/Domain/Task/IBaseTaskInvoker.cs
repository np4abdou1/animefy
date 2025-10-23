using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000107 RID: 263
	[Register("com/unity3d/services/core/domain/task/BaseTask", DoNotGenerateAcw = true)]
	internal class IBaseTaskInvoker : Java.Lang.Object, IBaseTask, IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x0001DA60 File Offset: 0x0001BC60
		private static IntPtr java_class_ref
		{
			get
			{
				return IBaseTaskInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0001DA84 File Offset: 0x0001BC84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBaseTaskInvoker._members;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0001DA8B File Offset: 0x0001BC8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0001DA93 File Offset: 0x0001BC93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBaseTaskInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001DA9F File Offset: 0x0001BC9F
		public static IBaseTask GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IBaseTask>(handle, transfer);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001DAA8 File Offset: 0x0001BCA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBaseTaskInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.domain.task.BaseTask'.");
			}
			return handle;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001DAD3 File Offset: 0x0001BCD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0001DB04 File Offset: 0x0001BD04
		public IBaseTaskInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBaseTaskInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001DB3C File Offset: 0x0001BD3C
		private static Delegate GetGetServiceProviderHandler()
		{
			if (IBaseTaskInvoker.cb_getServiceProvider == null)
			{
				IBaseTaskInvoker.cb_getServiceProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IBaseTaskInvoker.n_GetServiceProvider));
			}
			return IBaseTaskInvoker.cb_getServiceProvider;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001DB60 File Offset: 0x0001BD60
		private static IntPtr n_GetServiceProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IBaseTask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServiceProvider);
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0001DB74 File Offset: 0x0001BD74
		public Com.Unity3d.Services.Core.DI.IServiceProvider ServiceProvider
		{
			get
			{
				if (this.id_getServiceProvider == IntPtr.Zero)
				{
					this.id_getServiceProvider = JNIEnv.GetMethodID(this.class_ref, "getServiceProvider", "()Lcom/unity3d/services/core/di/IServiceProvider;");
				}
				return Java.Lang.Object.GetObject<Com.Unity3d.Services.Core.DI.IServiceProvider>(JNIEnv.CallObjectMethod(base.Handle, this.id_getServiceProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00002226 File Offset: 0x00000426
		ServiceProvider IServiceComponent.ServiceProvider
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x0400026C RID: 620
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/BaseTask", typeof(IBaseTaskInvoker));

		// Token: 0x0400026D RID: 621
		private IntPtr class_ref;

		// Token: 0x0400026E RID: 622
		private static Delegate cb_getServiceProvider;

		// Token: 0x0400026F RID: 623
		private IntPtr id_getServiceProvider;
	}
}
