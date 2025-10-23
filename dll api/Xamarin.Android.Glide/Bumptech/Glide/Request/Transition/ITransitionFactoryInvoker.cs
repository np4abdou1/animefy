using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A4 RID: 164
	[Register("com/bumptech/glide/request/transition/TransitionFactory", DoNotGenerateAcw = true)]
	internal class ITransitionFactoryInvoker : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0001A4C8 File Offset: 0x000186C8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransitionFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0001A4EC File Offset: 0x000186EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransitionFactoryInvoker._members;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0001A4F3 File Offset: 0x000186F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0001A4FB File Offset: 0x000186FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransitionFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001A507 File Offset: 0x00018707
		public static ITransitionFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransitionFactory>(handle, transfer);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001A510 File Offset: 0x00018710
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransitionFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.transition.TransitionFactory'.");
			}
			return handle;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0001A53B File Offset: 0x0001873B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0001A56C File Offset: 0x0001876C
		public ITransitionFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransitionFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0001A5A4 File Offset: 0x000187A4
		private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (ITransitionFactoryInvoker.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				ITransitionFactoryInvoker.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(ITransitionFactoryInvoker.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return ITransitionFactoryInvoker.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0001A5C8 File Offset: 0x000187C8
		private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			ITransitionFactory @object = Java.Lang.Object.GetObject<ITransitionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, p1));
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0001A5F4 File Offset: 0x000187F4
		public unsafe ITransition Build(DataSource p0, bool p1)
		{
			if (this.id_build_Lcom_bumptech_glide_load_DataSource_Z == IntPtr.Zero)
			{
				this.id_build_Lcom_bumptech_glide_load_DataSource_Z = JNIEnv.GetMethodID(this.class_ref, "build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(p1);
			return Java.Lang.Object.GetObject<ITransition>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Lcom_bumptech_glide_load_DataSource_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400021C RID: 540
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/TransitionFactory", typeof(ITransitionFactoryInvoker));

		// Token: 0x0400021D RID: 541
		private IntPtr class_ref;

		// Token: 0x0400021E RID: 542
		private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x0400021F RID: 543
		private IntPtr id_build_Lcom_bumptech_glide_load_DataSource_Z;
	}
}
