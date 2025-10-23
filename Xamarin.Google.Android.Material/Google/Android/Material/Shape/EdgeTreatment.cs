using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x02000037 RID: 55
	[Register("com/google/android/material/shape/EdgeTreatment", DoNotGenerateAcw = true)]
	public class EdgeTreatment : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000248C File Offset: 0x0000068C
		internal static IntPtr class_ref
		{
			get
			{
				return EdgeTreatment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000024B0 File Offset: 0x000006B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EdgeTreatment._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000024B8 File Offset: 0x000006B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EdgeTreatment._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000024DC File Offset: 0x000006DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EdgeTreatment._members.ManagedPeerType;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000020DC File Offset: 0x000002DC
		protected EdgeTreatment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024E8 File Offset: 0x000006E8
		[Register(".ctor", "()V", "")]
		public EdgeTreatment() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EdgeTreatment._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EdgeTreatment._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002556 File Offset: 0x00000756
		private static Delegate GetGetEdgePath_FFLcom_google_android_material_shape_ShapePath_Handler()
		{
			if (EdgeTreatment.cb_getEdgePath_FFLcom_google_android_material_shape_ShapePath_ == null)
			{
				EdgeTreatment.cb_getEdgePath_FFLcom_google_android_material_shape_ShapePath_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFL_V(EdgeTreatment.n_GetEdgePath_FFLcom_google_android_material_shape_ShapePath_));
			}
			return EdgeTreatment.cb_getEdgePath_FFLcom_google_android_material_shape_ShapePath_;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000257C File Offset: 0x0000077C
		private static void n_GetEdgePath_FFLcom_google_android_material_shape_ShapePath_(IntPtr jnienv, IntPtr native__this, float length, float interpolation, IntPtr native_shapePath)
		{
			EdgeTreatment @object = Java.Lang.Object.GetObject<EdgeTreatment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapePath object2 = Java.Lang.Object.GetObject<ShapePath>(native_shapePath, JniHandleOwnership.DoNotTransfer);
			@object.GetEdgePath(length, interpolation, object2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000025A4 File Offset: 0x000007A4
		[Register("getEdgePath", "(FFLcom/google/android/material/shape/ShapePath;)V", "GetGetEdgePath_FFLcom_google_android_material_shape_ShapePath_Handler")]
		public unsafe virtual void GetEdgePath(float length, float interpolation, ShapePath shapePath)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(length);
				ptr[1] = new JniArgumentValue(interpolation);
				ptr[2] = new JniArgumentValue((shapePath == null) ? IntPtr.Zero : shapePath.Handle);
				EdgeTreatment._members.InstanceMethods.InvokeVirtualVoidMethod("getEdgePath.(FFLcom/google/android/material/shape/ShapePath;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shapePath);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002630 File Offset: 0x00000830
		private static Delegate GetGetEdgePath_FFFLcom_google_android_material_shape_ShapePath_Handler()
		{
			if (EdgeTreatment.cb_getEdgePath_FFFLcom_google_android_material_shape_ShapePath_ == null)
			{
				EdgeTreatment.cb_getEdgePath_FFFLcom_google_android_material_shape_ShapePath_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFL_V(EdgeTreatment.n_GetEdgePath_FFFLcom_google_android_material_shape_ShapePath_));
			}
			return EdgeTreatment.cb_getEdgePath_FFFLcom_google_android_material_shape_ShapePath_;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002654 File Offset: 0x00000854
		private static void n_GetEdgePath_FFFLcom_google_android_material_shape_ShapePath_(IntPtr jnienv, IntPtr native__this, float length, float center, float interpolation, IntPtr native_shapePath)
		{
			EdgeTreatment @object = Java.Lang.Object.GetObject<EdgeTreatment>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapePath object2 = Java.Lang.Object.GetObject<ShapePath>(native_shapePath, JniHandleOwnership.DoNotTransfer);
			@object.GetEdgePath(length, center, interpolation, object2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000267C File Offset: 0x0000087C
		[Register("getEdgePath", "(FFFLcom/google/android/material/shape/ShapePath;)V", "GetGetEdgePath_FFFLcom_google_android_material_shape_ShapePath_Handler")]
		public unsafe virtual void GetEdgePath(float length, float center, float interpolation, ShapePath shapePath)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(length);
				ptr[1] = new JniArgumentValue(center);
				ptr[2] = new JniArgumentValue(interpolation);
				ptr[3] = new JniArgumentValue((shapePath == null) ? IntPtr.Zero : shapePath.Handle);
				EdgeTreatment._members.InstanceMethods.InvokeVirtualVoidMethod("getEdgePath.(FFFLcom/google/android/material/shape/ShapePath;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shapePath);
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/EdgeTreatment", typeof(EdgeTreatment));

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getEdgePath_FFLcom_google_android_material_shape_ShapePath_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getEdgePath_FFFLcom_google_android_material_shape_ShapePath_;
	}
}
