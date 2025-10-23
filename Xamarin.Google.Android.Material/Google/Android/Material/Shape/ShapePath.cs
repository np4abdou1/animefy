using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x02000040 RID: 64
	[Register("com/google/android/material/shape/ShapePath", DoNotGenerateAcw = true)]
	public class ShapePath : Java.Lang.Object
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000047E9 File Offset: 0x000029E9
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00004800 File Offset: 0x00002A00
		[Register("currentShadowAngle")]
		public float CurrentShadowAngle
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("currentShadowAngle.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("currentShadowAngle.F", this, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00004818 File Offset: 0x00002A18
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000482F File Offset: 0x00002A2F
		[Register("endShadowAngle")]
		public float EndShadowAngle
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("endShadowAngle.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("endShadowAngle.F", this, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00004847 File Offset: 0x00002A47
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000485E File Offset: 0x00002A5E
		[Register("endX")]
		public float EndX
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("endX.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("endX.F", this, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00004876 File Offset: 0x00002A76
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000488D File Offset: 0x00002A8D
		[Register("endY")]
		public float EndY
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("endY.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("endY.F", this, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000048A5 File Offset: 0x00002AA5
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000048BC File Offset: 0x00002ABC
		[Register("startX")]
		public float StartX
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("startX.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("startX.F", this, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000048EB File Offset: 0x00002AEB
		[Register("startY")]
		public float StartY
		{
			get
			{
				return ShapePath._members.InstanceFields.GetSingleValue("startY.F", this);
			}
			set
			{
				ShapePath._members.InstanceFields.SetValue("startY.F", this, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00004904 File Offset: 0x00002B04
		internal static IntPtr class_ref
		{
			get
			{
				return ShapePath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00004928 File Offset: 0x00002B28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShapePath._members;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00004930 File Offset: 0x00002B30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShapePath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00004954 File Offset: 0x00002B54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShapePath._members.ManagedPeerType;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000020DC File Offset: 0x000002DC
		protected ShapePath(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004960 File Offset: 0x00002B60
		[Register(".ctor", "()V", "")]
		public ShapePath() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ShapePath._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ShapePath._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000049D0 File Offset: 0x00002BD0
		[Register(".ctor", "(FF)V", "")]
		public unsafe ShapePath(float startX, float startY) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(startX);
			ptr[1] = new JniArgumentValue(startY);
			base.SetHandle(ShapePath._members.InstanceMethods.StartCreateInstance("(FF)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ShapePath._members.InstanceMethods.FinishCreateInstance("(FF)V", this, ptr);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004A67 File Offset: 0x00002C67
		private static Delegate GetAddArc_FFFFFFHandler()
		{
			if (ShapePath.cb_addArc_FFFFFF == null)
			{
				ShapePath.cb_addArc_FFFFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFFFF_V(ShapePath.n_AddArc_FFFFFF));
			}
			return ShapePath.cb_addArc_FFFFFF;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00004A8B File Offset: 0x00002C8B
		private static void n_AddArc_FFFFFF(IntPtr jnienv, IntPtr native__this, float left, float top, float right, float bottom, float startAngle, float sweepAngle)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddArc(left, top, right, bottom, startAngle, sweepAngle);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004AA4 File Offset: 0x00002CA4
		[Register("addArc", "(FFFFFF)V", "GetAddArc_FFFFFFHandler")]
		public unsafe virtual void AddArc(float left, float top, float right, float bottom, float startAngle, float sweepAngle)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(left);
			ptr[1] = new JniArgumentValue(top);
			ptr[2] = new JniArgumentValue(right);
			ptr[3] = new JniArgumentValue(bottom);
			ptr[4] = new JniArgumentValue(startAngle);
			ptr[5] = new JniArgumentValue(sweepAngle);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("addArc.(FFFFFF)V", this, ptr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004B4D File Offset: 0x00002D4D
		private static Delegate GetApplyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_Handler()
		{
			if (ShapePath.cb_applyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_ == null)
			{
				ShapePath.cb_applyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ShapePath.n_ApplyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_));
			}
			return ShapePath.cb_applyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004B74 File Offset: 0x00002D74
		private static void n_ApplyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_(IntPtr jnienv, IntPtr native__this, IntPtr native_transform, IntPtr native_path)
		{
			ShapePath @object = Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Matrix object2 = Java.Lang.Object.GetObject<Matrix>(native_transform, JniHandleOwnership.DoNotTransfer);
			Path object3 = Java.Lang.Object.GetObject<Path>(native_path, JniHandleOwnership.DoNotTransfer);
			@object.ApplyToPath(object2, object3);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004BA0 File Offset: 0x00002DA0
		[Register("applyToPath", "(Landroid/graphics/Matrix;Landroid/graphics/Path;)V", "GetApplyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_Handler")]
		public unsafe virtual void ApplyToPath(Matrix transform, Path path)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transform == null) ? IntPtr.Zero : transform.Handle);
				ptr[1] = new JniArgumentValue((path == null) ? IntPtr.Zero : path.Handle);
				ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("applyToPath.(Landroid/graphics/Matrix;Landroid/graphics/Path;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transform);
				GC.KeepAlive(path);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004C2C File Offset: 0x00002E2C
		private static Delegate GetCubicToPoint_FFFFFFHandler()
		{
			if (ShapePath.cb_cubicToPoint_FFFFFF == null)
			{
				ShapePath.cb_cubicToPoint_FFFFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFFFF_V(ShapePath.n_CubicToPoint_FFFFFF));
			}
			return ShapePath.cb_cubicToPoint_FFFFFF;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004C50 File Offset: 0x00002E50
		private static void n_CubicToPoint_FFFFFF(IntPtr jnienv, IntPtr native__this, float controlX1, float controlY1, float controlX2, float controlY2, float toX, float toY)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CubicToPoint(controlX1, controlY1, controlX2, controlY2, toX, toY);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004C6C File Offset: 0x00002E6C
		[Register("cubicToPoint", "(FFFFFF)V", "GetCubicToPoint_FFFFFFHandler")]
		public unsafe virtual void CubicToPoint(float controlX1, float controlY1, float controlX2, float controlY2, float toX, float toY)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(controlX1);
			ptr[1] = new JniArgumentValue(controlY1);
			ptr[2] = new JniArgumentValue(controlX2);
			ptr[3] = new JniArgumentValue(controlY2);
			ptr[4] = new JniArgumentValue(toX);
			ptr[5] = new JniArgumentValue(toY);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("cubicToPoint.(FFFFFF)V", this, ptr);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004D15 File Offset: 0x00002F15
		private static Delegate GetLineTo_FFHandler()
		{
			if (ShapePath.cb_lineTo_FF == null)
			{
				ShapePath.cb_lineTo_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_V(ShapePath.n_LineTo_FF));
			}
			return ShapePath.cb_lineTo_FF;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004D39 File Offset: 0x00002F39
		private static void n_LineTo_FF(IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineTo(x, y);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004D4C File Offset: 0x00002F4C
		[Register("lineTo", "(FF)V", "GetLineTo_FFHandler")]
		public unsafe virtual void LineTo(float x, float y)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x);
			ptr[1] = new JniArgumentValue(y);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("lineTo.(FF)V", this, ptr);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004D9A File Offset: 0x00002F9A
		private static Delegate GetLineTo_FFFFHandler()
		{
			if (ShapePath.cb_lineTo_FFFF == null)
			{
				ShapePath.cb_lineTo_FFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFF_V(ShapePath.n_LineTo_FFFF));
			}
			return ShapePath.cb_lineTo_FFFF;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00004DBE File Offset: 0x00002FBE
		private static void n_LineTo_FFFF(IntPtr jnienv, IntPtr native__this, float x1, float y1, float x2, float y2)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LineTo(x1, y1, x2, y2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00004DD4 File Offset: 0x00002FD4
		[Register("lineTo", "(FFFF)V", "GetLineTo_FFFFHandler")]
		public unsafe virtual void LineTo(float x1, float y1, float x2, float y2)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(x1);
			ptr[1] = new JniArgumentValue(y1);
			ptr[2] = new JniArgumentValue(x2);
			ptr[3] = new JniArgumentValue(y2);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("lineTo.(FFFF)V", this, ptr);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00004E4F File Offset: 0x0000304F
		private static Delegate GetQuadToPoint_FFFFHandler()
		{
			if (ShapePath.cb_quadToPoint_FFFF == null)
			{
				ShapePath.cb_quadToPoint_FFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFF_V(ShapePath.n_QuadToPoint_FFFF));
			}
			return ShapePath.cb_quadToPoint_FFFF;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00004E73 File Offset: 0x00003073
		private static void n_QuadToPoint_FFFF(IntPtr jnienv, IntPtr native__this, float controlX, float controlY, float toX, float toY)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).QuadToPoint(controlX, controlY, toX, toY);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00004E88 File Offset: 0x00003088
		[Register("quadToPoint", "(FFFF)V", "GetQuadToPoint_FFFFHandler")]
		public unsafe virtual void QuadToPoint(float controlX, float controlY, float toX, float toY)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(controlX);
			ptr[1] = new JniArgumentValue(controlY);
			ptr[2] = new JniArgumentValue(toX);
			ptr[3] = new JniArgumentValue(toY);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("quadToPoint.(FFFF)V", this, ptr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004F03 File Offset: 0x00003103
		private static Delegate GetReset_FFHandler()
		{
			if (ShapePath.cb_reset_FF == null)
			{
				ShapePath.cb_reset_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFF_V(ShapePath.n_Reset_FF));
			}
			return ShapePath.cb_reset_FF;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004F27 File Offset: 0x00003127
		private static void n_Reset_FF(IntPtr jnienv, IntPtr native__this, float startX, float startY)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset(startX, startY);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004F38 File Offset: 0x00003138
		[Register("reset", "(FF)V", "GetReset_FFHandler")]
		public unsafe virtual void Reset(float startX, float startY)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(startX);
			ptr[1] = new JniArgumentValue(startY);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("reset.(FF)V", this, ptr);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00004F86 File Offset: 0x00003186
		private static Delegate GetReset_FFFFHandler()
		{
			if (ShapePath.cb_reset_FFFF == null)
			{
				ShapePath.cb_reset_FFFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPFFFF_V(ShapePath.n_Reset_FFFF));
			}
			return ShapePath.cb_reset_FFFF;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004FAA File Offset: 0x000031AA
		private static void n_Reset_FFFF(IntPtr jnienv, IntPtr native__this, float startX, float startY, float shadowStartAngle, float shadowSweepAngle)
		{
			Java.Lang.Object.GetObject<ShapePath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset(startX, startY, shadowStartAngle, shadowSweepAngle);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004FC0 File Offset: 0x000031C0
		[Register("reset", "(FFFF)V", "GetReset_FFFFHandler")]
		public unsafe virtual void Reset(float startX, float startY, float shadowStartAngle, float shadowSweepAngle)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(startX);
			ptr[1] = new JniArgumentValue(startY);
			ptr[2] = new JniArgumentValue(shadowStartAngle);
			ptr[3] = new JniArgumentValue(shadowSweepAngle);
			ShapePath._members.InstanceMethods.InvokeVirtualVoidMethod("reset.(FFFF)V", this, ptr);
		}

		// Token: 0x0400002B RID: 43
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/ShapePath", typeof(ShapePath));

		// Token: 0x0400002C RID: 44
		private static Delegate cb_addArc_FFFFFF;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_applyToPath_Landroid_graphics_Matrix_Landroid_graphics_Path_;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_cubicToPoint_FFFFFF;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_lineTo_FF;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_lineTo_FFFF;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_quadToPoint_FFFF;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_reset_FF;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_reset_FFFF;
	}
}
