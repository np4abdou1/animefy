using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x0200003B RID: 59
	[Register("com/google/android/material/shape/Shapeable", DoNotGenerateAcw = true)]
	internal class IShapeableInvoker : Java.Lang.Object, IShapeable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000028F4 File Offset: 0x00000AF4
		private static IntPtr java_class_ref
		{
			get
			{
				return IShapeableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002918 File Offset: 0x00000B18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IShapeableInvoker._members;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000291F File Offset: 0x00000B1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002927 File Offset: 0x00000B27
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IShapeableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002933 File Offset: 0x00000B33
		public static IShapeable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IShapeable>(handle, transfer);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000293C File Offset: 0x00000B3C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IShapeableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.shape.Shapeable'.");
			}
			return handle;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002967 File Offset: 0x00000B67
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002998 File Offset: 0x00000B98
		public IShapeableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IShapeableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000029D0 File Offset: 0x00000BD0
		private static Delegate GetGetShapeAppearanceModelHandler()
		{
			if (IShapeableInvoker.cb_getShapeAppearanceModel == null)
			{
				IShapeableInvoker.cb_getShapeAppearanceModel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IShapeableInvoker.n_GetShapeAppearanceModel));
			}
			return IShapeableInvoker.cb_getShapeAppearanceModel;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000029F4 File Offset: 0x00000BF4
		private static IntPtr n_GetShapeAppearanceModel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IShapeable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShapeAppearanceModel);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002A08 File Offset: 0x00000C08
		private static Delegate GetSetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_Handler()
		{
			if (IShapeableInvoker.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ == null)
			{
				IShapeableInvoker.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IShapeableInvoker.n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_));
			}
			return IShapeableInvoker.cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002A2C File Offset: 0x00000C2C
		private static void n_SetShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IShapeable @object = Java.Lang.Object.GetObject<IShapeable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapeAppearanceModel object2 = Java.Lang.Object.GetObject<ShapeAppearanceModel>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ShapeAppearanceModel = object2;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002A50 File Offset: 0x00000C50
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002AA4 File Offset: 0x00000CA4
		public unsafe ShapeAppearanceModel ShapeAppearanceModel
		{
			get
			{
				if (this.id_getShapeAppearanceModel == IntPtr.Zero)
				{
					this.id_getShapeAppearanceModel = JNIEnv.GetMethodID(this.class_ref, "getShapeAppearanceModel", "()Lcom/google/android/material/shape/ShapeAppearanceModel;");
				}
				return Java.Lang.Object.GetObject<ShapeAppearanceModel>(JNIEnv.CallObjectMethod(base.Handle, this.id_getShapeAppearanceModel), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ == IntPtr.Zero)
				{
					this.id_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_ = JNIEnv.GetMethodID(this.class_ref, "setShapeAppearanceModel", "(Lcom/google/android/material/shape/ShapeAppearanceModel;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_, ptr);
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/Shapeable", typeof(IShapeableInvoker));

		// Token: 0x0400000F RID: 15
		private IntPtr class_ref;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_getShapeAppearanceModel;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;

		// Token: 0x04000012 RID: 18
		private IntPtr id_getShapeAppearanceModel;

		// Token: 0x04000013 RID: 19
		private IntPtr id_setShapeAppearanceModel_Lcom_google_android_material_shape_ShapeAppearanceModel_;
	}
}
