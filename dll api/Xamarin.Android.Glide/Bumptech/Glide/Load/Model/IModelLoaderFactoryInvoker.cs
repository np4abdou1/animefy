using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200013E RID: 318
	[Register("com/bumptech/glide/load/model/ModelLoaderFactory", DoNotGenerateAcw = true)]
	internal class IModelLoaderFactoryInvoker : Java.Lang.Object, IModelLoaderFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00033724 File Offset: 0x00031924
		private static IntPtr java_class_ref
		{
			get
			{
				return IModelLoaderFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x00033748 File Offset: 0x00031948
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IModelLoaderFactoryInvoker._members;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x0003374F File Offset: 0x0003194F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00033757 File Offset: 0x00031957
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IModelLoaderFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00033763 File Offset: 0x00031963
		public static IModelLoaderFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IModelLoaderFactory>(handle, transfer);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0003376C File Offset: 0x0003196C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IModelLoaderFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.ModelLoaderFactory'.");
			}
			return handle;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00033797 File Offset: 0x00031997
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000337C8 File Offset: 0x000319C8
		public IModelLoaderFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IModelLoaderFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00033800 File Offset: 0x00031A00
		private static Delegate GetBuild_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_Handler()
		{
			if (IModelLoaderFactoryInvoker.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == null)
			{
				IModelLoaderFactoryInvoker.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IModelLoaderFactoryInvoker.n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_));
			}
			return IModelLoaderFactoryInvoker.cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00033824 File Offset: 0x00031A24
		private static IntPtr n_Build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModelLoaderFactory @object = Java.Lang.Object.GetObject<IModelLoaderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MultiModelLoaderFactory object2 = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2));
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0003384C File Offset: 0x00031A4C
		public unsafe IModelLoader Build(MultiModelLoaderFactory p0)
		{
			if (this.id_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ == IntPtr.Zero)
			{
				this.id_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_ = JNIEnv.GetMethodID(this.class_ref, "build", "(Lcom/bumptech/glide/load/model/MultiModelLoaderFactory;)Lcom/bumptech/glide/load/model/ModelLoader;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<IModelLoader>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000338C5 File Offset: 0x00031AC5
		private static Delegate GetTeardownHandler()
		{
			if (IModelLoaderFactoryInvoker.cb_teardown == null)
			{
				IModelLoaderFactoryInvoker.cb_teardown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IModelLoaderFactoryInvoker.n_Teardown));
			}
			return IModelLoaderFactoryInvoker.cb_teardown;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000338E9 File Offset: 0x00031AE9
		private static void n_Teardown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IModelLoaderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Teardown();
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000338F8 File Offset: 0x00031AF8
		public void Teardown()
		{
			if (this.id_teardown == IntPtr.Zero)
			{
				this.id_teardown = JNIEnv.GetMethodID(this.class_ref, "teardown", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_teardown);
		}

		// Token: 0x040003B1 RID: 945
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ModelLoaderFactory", typeof(IModelLoaderFactoryInvoker));

		// Token: 0x040003B2 RID: 946
		private IntPtr class_ref;

		// Token: 0x040003B3 RID: 947
		private static Delegate cb_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

		// Token: 0x040003B4 RID: 948
		private IntPtr id_build_Lcom_bumptech_glide_load_model_MultiModelLoaderFactory_;

		// Token: 0x040003B5 RID: 949
		private static Delegate cb_teardown;

		// Token: 0x040003B6 RID: 950
		private IntPtr id_teardown;
	}
}
