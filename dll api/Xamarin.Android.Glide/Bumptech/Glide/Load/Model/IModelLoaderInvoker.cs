using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200013C RID: 316
	[Register("com/bumptech/glide/load/model/ModelLoader", DoNotGenerateAcw = true)]
	internal class IModelLoaderInvoker : Java.Lang.Object, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00033450 File Offset: 0x00031650
		private static IntPtr java_class_ref
		{
			get
			{
				return IModelLoaderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00033474 File Offset: 0x00031674
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IModelLoaderInvoker._members;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0003347B File Offset: 0x0003167B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00033483 File Offset: 0x00031683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IModelLoaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0003348F File Offset: 0x0003168F
		public static IModelLoader GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IModelLoader>(handle, transfer);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00033498 File Offset: 0x00031698
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IModelLoaderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.model.ModelLoader'.");
			}
			return handle;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x000334C3 File Offset: 0x000316C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000334F4 File Offset: 0x000316F4
		public IModelLoaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IModelLoaderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0003352C File Offset: 0x0003172C
		private static Delegate GetBuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler()
		{
			if (IModelLoaderInvoker.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == null)
			{
				IModelLoaderInvoker.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_L(IModelLoaderInvoker.n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_));
			}
			return IModelLoaderInvoker.cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00033550 File Offset: 0x00031750
		private static IntPtr n_BuildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			IModelLoader @object = Java.Lang.Object.GetObject<IModelLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Options object3 = Java.Lang.Object.GetObject<Options>(native_p3, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.BuildLoadData(object2, p1, p2, object3));
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00033588 File Offset: 0x00031788
		public unsafe ModelLoaderLoadData BuildLoadData(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			if (this.id_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ == IntPtr.Zero)
			{
				this.id_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_ = JNIEnv.GetMethodID(this.class_ref, "buildLoadData", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Lcom/bumptech/glide/load/model/ModelLoader$LoadData;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue((p3 == null) ? IntPtr.Zero : p3.Handle);
			ModelLoaderLoadData @object = Java.Lang.Object.GetObject<ModelLoaderLoadData>(JNIEnv.CallObjectMethod(base.Handle, this.id_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0003364F File Offset: 0x0003184F
		private static Delegate GetHandles_Ljava_lang_Object_Handler()
		{
			if (IModelLoaderInvoker.cb_handles_Ljava_lang_Object_ == null)
			{
				IModelLoaderInvoker.cb_handles_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IModelLoaderInvoker.n_Handles_Ljava_lang_Object_));
			}
			return IModelLoaderInvoker.cb_handles_Ljava_lang_Object_;
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00033674 File Offset: 0x00031874
		private static bool n_Handles_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IModelLoader @object = Java.Lang.Object.GetObject<IModelLoader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return @object.Handles(object2);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00033698 File Offset: 0x00031898
		public unsafe bool Handles(Java.Lang.Object p0)
		{
			if (this.id_handles_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_handles_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "handles", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_handles_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x040003AB RID: 939
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ModelLoader", typeof(IModelLoaderInvoker));

		// Token: 0x040003AC RID: 940
		private IntPtr class_ref;

		// Token: 0x040003AD RID: 941
		private static Delegate cb_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003AE RID: 942
		private IntPtr id_buildLoadData_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_;

		// Token: 0x040003AF RID: 943
		private static Delegate cb_handles_Ljava_lang_Object_;

		// Token: 0x040003B0 RID: 944
		private IntPtr id_handles_Ljava_lang_Object_;
	}
}
