using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x02000036 RID: 54
	[Register("com/google/android/material/shape/CornerTreatment", DoNotGenerateAcw = true)]
	public class CornerTreatment : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return CornerTreatment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CornerTreatment._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CornerTreatment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CornerTreatment._members.ManagedPeerType;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020DC File Offset: 0x000002DC
		protected CornerTreatment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "()V", "")]
		public CornerTreatment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CornerTreatment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CornerTreatment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002156 File Offset: 0x00000356
		private static Delegate GetGetCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_Handler()
		{
			if (CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_ == null)
			{
				CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFLL_V(CornerTreatment.n_GetCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_));
			}
			return CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000217C File Offset: 0x0000037C
		private static void n_GetCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_(IntPtr jnienv, IntPtr native__this, IntPtr native_shapePath, float angle, float interpolation, IntPtr native_bounds, IntPtr native_size)
		{
			CornerTreatment @object = Java.Lang.Object.GetObject<CornerTreatment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapePath object2 = Java.Lang.Object.GetObject<ShapePath>(native_shapePath, JniHandleOwnership.DoNotTransfer);
			RectF object3 = Java.Lang.Object.GetObject<RectF>(native_bounds, JniHandleOwnership.DoNotTransfer);
			ICornerSize object4 = Java.Lang.Object.GetObject<ICornerSize>(native_size, JniHandleOwnership.DoNotTransfer);
			@object.GetCornerPath(object2, angle, interpolation, object3, object4);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000021B8 File Offset: 0x000003B8
		[Register("getCornerPath", "(Lcom/google/android/material/shape/ShapePath;FFLandroid/graphics/RectF;Lcom/google/android/material/shape/CornerSize;)V", "GetGetCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_Handler")]
		public unsafe virtual void GetCornerPath(ShapePath shapePath, float angle, float interpolation, RectF bounds, ICornerSize size)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((shapePath == null) ? IntPtr.Zero : shapePath.Handle);
				ptr[1] = new JniArgumentValue(angle);
				ptr[2] = new JniArgumentValue(interpolation);
				ptr[3] = new JniArgumentValue((bounds == null) ? IntPtr.Zero : bounds.Handle);
				ptr[4] = new JniArgumentValue((size == null) ? IntPtr.Zero : ((Java.Lang.Object)size).Handle);
				CornerTreatment._members.InstanceMethods.InvokeVirtualVoidMethod("getCornerPath.(Lcom/google/android/material/shape/ShapePath;FFLandroid/graphics/RectF;Lcom/google/android/material/shape/CornerSize;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shapePath);
				GC.KeepAlive(bounds);
				GC.KeepAlive(size);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000022A8 File Offset: 0x000004A8
		private static Delegate GetGetCornerPath_Lcom_google_android_material_shape_ShapePath_FFFHandler()
		{
			if (CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFF == null)
			{
				CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFF_V(CornerTreatment.n_GetCornerPath_Lcom_google_android_material_shape_ShapePath_FFF));
			}
			return CornerTreatment.cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFF;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000022CC File Offset: 0x000004CC
		private static void n_GetCornerPath_Lcom_google_android_material_shape_ShapePath_FFF(IntPtr jnienv, IntPtr native__this, IntPtr native_shapePath, float angle, float interpolation, float radius)
		{
			CornerTreatment @object = Java.Lang.Object.GetObject<CornerTreatment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapePath object2 = Java.Lang.Object.GetObject<ShapePath>(native_shapePath, JniHandleOwnership.DoNotTransfer);
			@object.GetCornerPath(object2, angle, interpolation, radius);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000022F4 File Offset: 0x000004F4
		[Register("getCornerPath", "(Lcom/google/android/material/shape/ShapePath;FFF)V", "GetGetCornerPath_Lcom_google_android_material_shape_ShapePath_FFFHandler")]
		public unsafe virtual void GetCornerPath(ShapePath shapePath, float angle, float interpolation, float radius)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((shapePath == null) ? IntPtr.Zero : shapePath.Handle);
				ptr[1] = new JniArgumentValue(angle);
				ptr[2] = new JniArgumentValue(interpolation);
				ptr[3] = new JniArgumentValue(radius);
				CornerTreatment._members.InstanceMethods.InvokeVirtualVoidMethod("getCornerPath.(Lcom/google/android/material/shape/ShapePath;FFF)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shapePath);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002398 File Offset: 0x00000598
		private static Delegate GetGetCornerPath_FFLcom_google_android_material_shape_ShapePath_Handler()
		{
			if (CornerTreatment.cb_getCornerPath_FFLcom_google_android_material_shape_ShapePath_ == null)
			{
				CornerTreatment.cb_getCornerPath_FFLcom_google_android_material_shape_ShapePath_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFL_V(CornerTreatment.n_GetCornerPath_FFLcom_google_android_material_shape_ShapePath_));
			}
			return CornerTreatment.cb_getCornerPath_FFLcom_google_android_material_shape_ShapePath_;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000023BC File Offset: 0x000005BC
		private static void n_GetCornerPath_FFLcom_google_android_material_shape_ShapePath_(IntPtr jnienv, IntPtr native__this, float angle, float interpolation, IntPtr native_shapePath)
		{
			CornerTreatment @object = Java.Lang.Object.GetObject<CornerTreatment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapePath object2 = Java.Lang.Object.GetObject<ShapePath>(native_shapePath, JniHandleOwnership.DoNotTransfer);
			@object.GetCornerPath(angle, interpolation, object2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000023E4 File Offset: 0x000005E4
		[Register("getCornerPath", "(FFLcom/google/android/material/shape/ShapePath;)V", "GetGetCornerPath_FFLcom_google_android_material_shape_ShapePath_Handler")]
		public unsafe virtual void GetCornerPath(float angle, float interpolation, ShapePath shapePath)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(angle);
				ptr[1] = new JniArgumentValue(interpolation);
				ptr[2] = new JniArgumentValue((shapePath == null) ? IntPtr.Zero : shapePath.Handle);
				CornerTreatment._members.InstanceMethods.InvokeVirtualVoidMethod("getCornerPath.(FFLcom/google/android/material/shape/ShapePath;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shapePath);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/CornerTreatment", typeof(CornerTreatment));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFLandroid_graphics_RectF_Lcom_google_android_material_shape_CornerSize_;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getCornerPath_Lcom_google_android_material_shape_ShapePath_FFF;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getCornerPath_FFLcom_google_android_material_shape_ShapePath_;
	}
}
