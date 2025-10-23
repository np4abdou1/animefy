using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Shape
{
	// Token: 0x0200003C RID: 60
	[Register("com/google/android/material/shape/ShapeAppearanceModel", DoNotGenerateAcw = true)]
	public class ShapeAppearanceModel : Java.Lang.Object
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002B34 File Offset: 0x00000D34
		[Register("PILL")]
		public static ICornerSize Pill
		{
			get
			{
				return Java.Lang.Object.GetObject<ICornerSize>(ShapeAppearanceModel._members.StaticFields.GetObjectValue("PILL.Lcom/google/android/material/shape/CornerSize;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002B64 File Offset: 0x00000D64
		internal static IntPtr class_ref
		{
			get
			{
				return ShapeAppearanceModel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002B88 File Offset: 0x00000D88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShapeAppearanceModel._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002B90 File Offset: 0x00000D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShapeAppearanceModel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002BB4 File Offset: 0x00000DB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShapeAppearanceModel._members.ManagedPeerType;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000020DC File Offset: 0x000002DC
		protected ShapeAppearanceModel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002BC0 File Offset: 0x00000DC0
		[Register(".ctor", "()V", "")]
		public ShapeAppearanceModel() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ShapeAppearanceModel._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ShapeAppearanceModel._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002C2E File Offset: 0x00000E2E
		private static Delegate GetGetBottomEdgeHandler()
		{
			if (ShapeAppearanceModel.cb_getBottomEdge == null)
			{
				ShapeAppearanceModel.cb_getBottomEdge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetBottomEdge));
			}
			return ShapeAppearanceModel.cb_getBottomEdge;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C52 File Offset: 0x00000E52
		private static IntPtr n_GetBottomEdge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomEdge);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002C68 File Offset: 0x00000E68
		public virtual EdgeTreatment BottomEdge
		{
			[Register("getBottomEdge", "()Lcom/google/android/material/shape/EdgeTreatment;", "GetGetBottomEdgeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EdgeTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getBottomEdge.()Lcom/google/android/material/shape/EdgeTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002C9A File Offset: 0x00000E9A
		private static Delegate GetGetBottomLeftCornerHandler()
		{
			if (ShapeAppearanceModel.cb_getBottomLeftCorner == null)
			{
				ShapeAppearanceModel.cb_getBottomLeftCorner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetBottomLeftCorner));
			}
			return ShapeAppearanceModel.cb_getBottomLeftCorner;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002CBE File Offset: 0x00000EBE
		private static IntPtr n_GetBottomLeftCorner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomLeftCorner);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public virtual CornerTreatment BottomLeftCorner
		{
			[Register("getBottomLeftCorner", "()Lcom/google/android/material/shape/CornerTreatment;", "GetGetBottomLeftCornerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CornerTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getBottomLeftCorner.()Lcom/google/android/material/shape/CornerTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002D06 File Offset: 0x00000F06
		private static Delegate GetGetBottomLeftCornerSizeHandler()
		{
			if (ShapeAppearanceModel.cb_getBottomLeftCornerSize == null)
			{
				ShapeAppearanceModel.cb_getBottomLeftCornerSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetBottomLeftCornerSize));
			}
			return ShapeAppearanceModel.cb_getBottomLeftCornerSize;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002D2A File Offset: 0x00000F2A
		private static IntPtr n_GetBottomLeftCornerSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomLeftCornerSize);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002D40 File Offset: 0x00000F40
		public virtual ICornerSize BottomLeftCornerSize
		{
			[Register("getBottomLeftCornerSize", "()Lcom/google/android/material/shape/CornerSize;", "GetGetBottomLeftCornerSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICornerSize>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getBottomLeftCornerSize.()Lcom/google/android/material/shape/CornerSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002D72 File Offset: 0x00000F72
		private static Delegate GetGetBottomRightCornerHandler()
		{
			if (ShapeAppearanceModel.cb_getBottomRightCorner == null)
			{
				ShapeAppearanceModel.cb_getBottomRightCorner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetBottomRightCorner));
			}
			return ShapeAppearanceModel.cb_getBottomRightCorner;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002D96 File Offset: 0x00000F96
		private static IntPtr n_GetBottomRightCorner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomRightCorner);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002DAC File Offset: 0x00000FAC
		public virtual CornerTreatment BottomRightCorner
		{
			[Register("getBottomRightCorner", "()Lcom/google/android/material/shape/CornerTreatment;", "GetGetBottomRightCornerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CornerTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getBottomRightCorner.()Lcom/google/android/material/shape/CornerTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002DDE File Offset: 0x00000FDE
		private static Delegate GetGetBottomRightCornerSizeHandler()
		{
			if (ShapeAppearanceModel.cb_getBottomRightCornerSize == null)
			{
				ShapeAppearanceModel.cb_getBottomRightCornerSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetBottomRightCornerSize));
			}
			return ShapeAppearanceModel.cb_getBottomRightCornerSize;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002E02 File Offset: 0x00001002
		private static IntPtr n_GetBottomRightCornerSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BottomRightCornerSize);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002E18 File Offset: 0x00001018
		public virtual ICornerSize BottomRightCornerSize
		{
			[Register("getBottomRightCornerSize", "()Lcom/google/android/material/shape/CornerSize;", "GetGetBottomRightCornerSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICornerSize>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getBottomRightCornerSize.()Lcom/google/android/material/shape/CornerSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002E4A File Offset: 0x0000104A
		private static Delegate GetGetLeftEdgeHandler()
		{
			if (ShapeAppearanceModel.cb_getLeftEdge == null)
			{
				ShapeAppearanceModel.cb_getLeftEdge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetLeftEdge));
			}
			return ShapeAppearanceModel.cb_getLeftEdge;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002E6E File Offset: 0x0000106E
		private static IntPtr n_GetLeftEdge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LeftEdge);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00002E84 File Offset: 0x00001084
		public virtual EdgeTreatment LeftEdge
		{
			[Register("getLeftEdge", "()Lcom/google/android/material/shape/EdgeTreatment;", "GetGetLeftEdgeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EdgeTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getLeftEdge.()Lcom/google/android/material/shape/EdgeTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002EB6 File Offset: 0x000010B6
		private static Delegate GetGetRightEdgeHandler()
		{
			if (ShapeAppearanceModel.cb_getRightEdge == null)
			{
				ShapeAppearanceModel.cb_getRightEdge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetRightEdge));
			}
			return ShapeAppearanceModel.cb_getRightEdge;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002EDA File Offset: 0x000010DA
		private static IntPtr n_GetRightEdge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RightEdge);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002EF0 File Offset: 0x000010F0
		public virtual EdgeTreatment RightEdge
		{
			[Register("getRightEdge", "()Lcom/google/android/material/shape/EdgeTreatment;", "GetGetRightEdgeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EdgeTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getRightEdge.()Lcom/google/android/material/shape/EdgeTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002F22 File Offset: 0x00001122
		private static Delegate GetGetTopEdgeHandler()
		{
			if (ShapeAppearanceModel.cb_getTopEdge == null)
			{
				ShapeAppearanceModel.cb_getTopEdge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetTopEdge));
			}
			return ShapeAppearanceModel.cb_getTopEdge;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002F46 File Offset: 0x00001146
		private static IntPtr n_GetTopEdge(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopEdge);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00002F5C File Offset: 0x0000115C
		public virtual EdgeTreatment TopEdge
		{
			[Register("getTopEdge", "()Lcom/google/android/material/shape/EdgeTreatment;", "GetGetTopEdgeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EdgeTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getTopEdge.()Lcom/google/android/material/shape/EdgeTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002F8E File Offset: 0x0000118E
		private static Delegate GetGetTopLeftCornerHandler()
		{
			if (ShapeAppearanceModel.cb_getTopLeftCorner == null)
			{
				ShapeAppearanceModel.cb_getTopLeftCorner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetTopLeftCorner));
			}
			return ShapeAppearanceModel.cb_getTopLeftCorner;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002FB2 File Offset: 0x000011B2
		private static IntPtr n_GetTopLeftCorner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopLeftCorner);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00002FC8 File Offset: 0x000011C8
		public virtual CornerTreatment TopLeftCorner
		{
			[Register("getTopLeftCorner", "()Lcom/google/android/material/shape/CornerTreatment;", "GetGetTopLeftCornerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CornerTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getTopLeftCorner.()Lcom/google/android/material/shape/CornerTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002FFA File Offset: 0x000011FA
		private static Delegate GetGetTopLeftCornerSizeHandler()
		{
			if (ShapeAppearanceModel.cb_getTopLeftCornerSize == null)
			{
				ShapeAppearanceModel.cb_getTopLeftCornerSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetTopLeftCornerSize));
			}
			return ShapeAppearanceModel.cb_getTopLeftCornerSize;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000301E File Offset: 0x0000121E
		private static IntPtr n_GetTopLeftCornerSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopLeftCornerSize);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00003034 File Offset: 0x00001234
		public virtual ICornerSize TopLeftCornerSize
		{
			[Register("getTopLeftCornerSize", "()Lcom/google/android/material/shape/CornerSize;", "GetGetTopLeftCornerSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICornerSize>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getTopLeftCornerSize.()Lcom/google/android/material/shape/CornerSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003066 File Offset: 0x00001266
		private static Delegate GetGetTopRightCornerHandler()
		{
			if (ShapeAppearanceModel.cb_getTopRightCorner == null)
			{
				ShapeAppearanceModel.cb_getTopRightCorner = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetTopRightCorner));
			}
			return ShapeAppearanceModel.cb_getTopRightCorner;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000308A File Offset: 0x0000128A
		private static IntPtr n_GetTopRightCorner(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopRightCorner);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000030A0 File Offset: 0x000012A0
		public virtual CornerTreatment TopRightCorner
		{
			[Register("getTopRightCorner", "()Lcom/google/android/material/shape/CornerTreatment;", "GetGetTopRightCornerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<CornerTreatment>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getTopRightCorner.()Lcom/google/android/material/shape/CornerTreatment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000030D2 File Offset: 0x000012D2
		private static Delegate GetGetTopRightCornerSizeHandler()
		{
			if (ShapeAppearanceModel.cb_getTopRightCornerSize == null)
			{
				ShapeAppearanceModel.cb_getTopRightCornerSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_GetTopRightCornerSize));
			}
			return ShapeAppearanceModel.cb_getTopRightCornerSize;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000030F6 File Offset: 0x000012F6
		private static IntPtr n_GetTopRightCornerSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopRightCornerSize);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000310C File Offset: 0x0000130C
		public virtual ICornerSize TopRightCornerSize
		{
			[Register("getTopRightCornerSize", "()Lcom/google/android/material/shape/CornerSize;", "GetGetTopRightCornerSizeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICornerSize>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("getTopRightCornerSize.()Lcom/google/android/material/shape/CornerSize;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003140 File Offset: 0x00001340
		[Register("builder", "()Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
		public static ShapeAppearanceModel.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003174 File Offset: 0x00001374
		[Register("builder", "(Landroid/content/Context;Landroid/util/AttributeSet;II)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
		public unsafe static ShapeAppearanceModel.Builder InvokeBuilder(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes)
		{
			ShapeAppearanceModel.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.StaticMethods.InvokeObjectMethod("builder.(Landroid/content/Context;Landroid/util/AttributeSet;II)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
			return @object;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003240 File Offset: 0x00001440
		[Register("builder", "(Landroid/content/Context;Landroid/util/AttributeSet;IILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
		public unsafe static ShapeAppearanceModel.Builder InvokeBuilder(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes, ICornerSize defaultCornerSize)
		{
			ShapeAppearanceModel.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				ptr[4] = new JniArgumentValue((defaultCornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)defaultCornerSize).Handle);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.StaticMethods.InvokeObjectMethod("builder.(Landroid/content/Context;Landroid/util/AttributeSet;IILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
				GC.KeepAlive(defaultCornerSize);
			}
			return @object;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003340 File Offset: 0x00001540
		[Register("builder", "(Landroid/content/Context;Landroid/util/AttributeSet;III)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
		public unsafe static ShapeAppearanceModel.Builder InvokeBuilder(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes, int defaultCornerSize)
		{
			ShapeAppearanceModel.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				ptr[4] = new JniArgumentValue(defaultCornerSize);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.StaticMethods.InvokeObjectMethod("builder.(Landroid/content/Context;Landroid/util/AttributeSet;III)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
			return @object;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003424 File Offset: 0x00001624
		[Register("builder", "(Landroid/content/Context;II)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
		public unsafe static ShapeAppearanceModel.Builder InvokeBuilder(Context context, int shapeAppearanceResId, int shapeAppearanceOverlayResId)
		{
			ShapeAppearanceModel.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(shapeAppearanceResId);
				ptr[2] = new JniArgumentValue(shapeAppearanceOverlayResId);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.StaticMethods.InvokeObjectMethod("builder.(Landroid/content/Context;II)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000034C0 File Offset: 0x000016C0
		private static Delegate GetIsRoundRect_Landroid_graphics_RectF_Handler()
		{
			if (ShapeAppearanceModel.cb_isRoundRect_Landroid_graphics_RectF_ == null)
			{
				ShapeAppearanceModel.cb_isRoundRect_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ShapeAppearanceModel.n_IsRoundRect_Landroid_graphics_RectF_));
			}
			return ShapeAppearanceModel.cb_isRoundRect_Landroid_graphics_RectF_;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000034E4 File Offset: 0x000016E4
		private static bool n_IsRoundRect_Landroid_graphics_RectF_(IntPtr jnienv, IntPtr native__this, IntPtr native_bounds)
		{
			ShapeAppearanceModel @object = Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RectF object2 = Java.Lang.Object.GetObject<RectF>(native_bounds, JniHandleOwnership.DoNotTransfer);
			return @object.IsRoundRect(object2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003508 File Offset: 0x00001708
		[Register("isRoundRect", "(Landroid/graphics/RectF;)Z", "GetIsRoundRect_Landroid_graphics_RectF_Handler")]
		public unsafe virtual bool IsRoundRect(RectF bounds)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bounds == null) ? IntPtr.Zero : bounds.Handle);
				result = ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualBooleanMethod("isRoundRect.(Landroid/graphics/RectF;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bounds);
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003570 File Offset: 0x00001770
		private static Delegate GetToBuilderHandler()
		{
			if (ShapeAppearanceModel.cb_toBuilder == null)
			{
				ShapeAppearanceModel.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ShapeAppearanceModel.n_ToBuilder));
			}
			return ShapeAppearanceModel.cb_toBuilder;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003594 File Offset: 0x00001794
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000035A8 File Offset: 0x000017A8
		[Register("toBuilder", "()Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "GetToBuilderHandler")]
		public virtual ShapeAppearanceModel.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000035DA File Offset: 0x000017DA
		private static Delegate GetWithCornerSize_Lcom_google_android_material_shape_CornerSize_Handler()
		{
			if (ShapeAppearanceModel.cb_withCornerSize_Lcom_google_android_material_shape_CornerSize_ == null)
			{
				ShapeAppearanceModel.cb_withCornerSize_Lcom_google_android_material_shape_CornerSize_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ShapeAppearanceModel.n_WithCornerSize_Lcom_google_android_material_shape_CornerSize_));
			}
			return ShapeAppearanceModel.cb_withCornerSize_Lcom_google_android_material_shape_CornerSize_;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003600 File Offset: 0x00001800
		private static IntPtr n_WithCornerSize_Lcom_google_android_material_shape_CornerSize_(IntPtr jnienv, IntPtr native__this, IntPtr native_cornerSize)
		{
			ShapeAppearanceModel @object = Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICornerSize object2 = Java.Lang.Object.GetObject<ICornerSize>(native_cornerSize, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WithCornerSize(object2));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003628 File Offset: 0x00001828
		[Register("withCornerSize", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetWithCornerSize_Lcom_google_android_material_shape_CornerSize_Handler")]
		public unsafe virtual ShapeAppearanceModel WithCornerSize(ICornerSize cornerSize)
		{
			ShapeAppearanceModel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("withCornerSize.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(cornerSize);
			}
			return @object;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000036A0 File Offset: 0x000018A0
		private static Delegate GetWithCornerSize_FHandler()
		{
			if (ShapeAppearanceModel.cb_withCornerSize_F == null)
			{
				ShapeAppearanceModel.cb_withCornerSize_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_L(ShapeAppearanceModel.n_WithCornerSize_F));
			}
			return ShapeAppearanceModel.cb_withCornerSize_F;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000036C4 File Offset: 0x000018C4
		private static IntPtr n_WithCornerSize_F(IntPtr jnienv, IntPtr native__this, float cornerSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WithCornerSize(cornerSize));
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000036DC File Offset: 0x000018DC
		[Register("withCornerSize", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetWithCornerSize_FHandler")]
		public unsafe virtual ShapeAppearanceModel WithCornerSize(float cornerSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(cornerSize);
			return Java.Lang.Object.GetObject<ShapeAppearanceModel>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("withCornerSize.(F)Lcom/google/android/material/shape/ShapeAppearanceModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003725 File Offset: 0x00001925
		private static Delegate GetWithTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_Handler()
		{
			if (ShapeAppearanceModel.cb_withTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_ == null)
			{
				ShapeAppearanceModel.cb_withTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ShapeAppearanceModel.n_WithTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_));
			}
			return ShapeAppearanceModel.cb_withTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000374C File Offset: 0x0000194C
		private static IntPtr n_WithTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_(IntPtr jnienv, IntPtr native__this, IntPtr native_op)
		{
			ShapeAppearanceModel @object = Java.Lang.Object.GetObject<ShapeAppearanceModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ShapeAppearanceModel.ICornerSizeUnaryOperator object2 = Java.Lang.Object.GetObject<ShapeAppearanceModel.ICornerSizeUnaryOperator>(native_op, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.WithTransformedCornerSizes(object2));
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003774 File Offset: 0x00001974
		[Register("withTransformedCornerSizes", "(Lcom/google/android/material/shape/ShapeAppearanceModel$CornerSizeUnaryOperator;)Lcom/google/android/material/shape/ShapeAppearanceModel;", "GetWithTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_Handler")]
		public unsafe virtual ShapeAppearanceModel WithTransformedCornerSizes(ShapeAppearanceModel.ICornerSizeUnaryOperator op)
		{
			ShapeAppearanceModel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((op == null) ? IntPtr.Zero : ((Java.Lang.Object)op).Handle);
				@object = Java.Lang.Object.GetObject<ShapeAppearanceModel>(ShapeAppearanceModel._members.InstanceMethods.InvokeVirtualObjectMethod("withTransformedCornerSizes.(Lcom/google/android/material/shape/ShapeAppearanceModel$CornerSizeUnaryOperator;)Lcom/google/android/material/shape/ShapeAppearanceModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(op);
			}
			return @object;
		}

		// Token: 0x04000014 RID: 20
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/ShapeAppearanceModel", typeof(ShapeAppearanceModel));

		// Token: 0x04000015 RID: 21
		private static Delegate cb_getBottomEdge;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_getBottomLeftCorner;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getBottomLeftCornerSize;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_getBottomRightCorner;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_getBottomRightCornerSize;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_getLeftEdge;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_getRightEdge;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getTopEdge;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_getTopLeftCorner;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_getTopLeftCornerSize;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_getTopRightCorner;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_getTopRightCornerSize;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_isRoundRect_Landroid_graphics_RectF_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_toBuilder;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_withCornerSize_Lcom_google_android_material_shape_CornerSize_;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_withCornerSize_F;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_withTransformedCornerSizes_Lcom_google_android_material_shape_ShapeAppearanceModel_CornerSizeUnaryOperator_;

		// Token: 0x0200003D RID: 61
		[Register("com/google/android/material/shape/ShapeAppearanceModel$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00003808 File Offset: 0x00001A08
			internal static IntPtr class_ref
			{
				get
				{
					return ShapeAppearanceModel.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000144 RID: 324 RVA: 0x0000382C File Offset: 0x00001A2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ShapeAppearanceModel.Builder._members;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00003834 File Offset: 0x00001A34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ShapeAppearanceModel.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00003858 File Offset: 0x00001A58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ShapeAppearanceModel.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000147 RID: 327 RVA: 0x000020DC File Offset: 0x000002DC
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00003864 File Offset: 0x00001A64
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ShapeAppearanceModel.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ShapeAppearanceModel.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000149 RID: 329 RVA: 0x000038D4 File Offset: 0x00001AD4
			[Register(".ctor", "(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", "")]
			public unsafe Builder(ShapeAppearanceModel other) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
					base.SetHandle(ShapeAppearanceModel.Builder._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ShapeAppearanceModel.Builder._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/material/shape/ShapeAppearanceModel;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(other);
				}
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00003984 File Offset: 0x00001B84
			[Register("build", "()Lcom/google/android/material/shape/ShapeAppearanceModel;", "")]
			public ShapeAppearanceModel Build()
			{
				return Java.Lang.Object.GetObject<ShapeAppearanceModel>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/material/shape/ShapeAppearanceModel;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000039B8 File Offset: 0x00001BB8
			[Register("setAllCornerSizes", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetAllCornerSizes(ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAllCornerSizes.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00003A30 File Offset: 0x00001C30
			[Register("setAllCornerSizes", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetAllCornerSizes(float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAllCornerSizes.(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00003A7C File Offset: 0x00001C7C
			[Register("setAllCorners", "(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetAllCorners(CornerTreatment cornerTreatment)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerTreatment == null) ? IntPtr.Zero : cornerTreatment.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAllCorners.(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerTreatment);
				}
				return @object;
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00003AF0 File Offset: 0x00001CF0
			[Register("setAllCorners", "(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetAllCorners(int cornerFamily, float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerFamily);
				ptr[1] = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAllCorners.(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00003B4C File Offset: 0x00001D4C
			[Register("setAllEdges", "(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetAllEdges(EdgeTreatment edgeTreatment)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((edgeTreatment == null) ? IntPtr.Zero : edgeTreatment.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setAllEdges.(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(edgeTreatment);
				}
				return @object;
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00003BC0 File Offset: 0x00001DC0
			[Register("setBottomEdge", "(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomEdge(EdgeTreatment bottomEdge)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bottomEdge == null) ? IntPtr.Zero : bottomEdge.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomEdge.(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(bottomEdge);
				}
				return @object;
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00003C34 File Offset: 0x00001E34
			[Register("setBottomLeftCorner", "(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomLeftCorner(CornerTreatment bottomLeftCorner)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bottomLeftCorner == null) ? IntPtr.Zero : bottomLeftCorner.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomLeftCorner.(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(bottomLeftCorner);
				}
				return @object;
			}

			// Token: 0x06000152 RID: 338 RVA: 0x00003CA8 File Offset: 0x00001EA8
			[Register("setBottomLeftCorner", "(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomLeftCorner(int cornerFamily, ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(cornerFamily);
					ptr[1] = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomLeftCorner.(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000153 RID: 339 RVA: 0x00003D34 File Offset: 0x00001F34
			[Register("setBottomLeftCorner", "(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomLeftCorner(int cornerFamily, float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerFamily);
				ptr[1] = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomLeftCorner.(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000154 RID: 340 RVA: 0x00003D90 File Offset: 0x00001F90
			[Register("setBottomLeftCornerSize", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomLeftCornerSize(ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomLeftCornerSize.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000155 RID: 341 RVA: 0x00003E08 File Offset: 0x00002008
			[Register("setBottomLeftCornerSize", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomLeftCornerSize(float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomLeftCornerSize.(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000156 RID: 342 RVA: 0x00003E54 File Offset: 0x00002054
			[Register("setBottomRightCorner", "(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomRightCorner(CornerTreatment bottomRightCorner)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((bottomRightCorner == null) ? IntPtr.Zero : bottomRightCorner.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomRightCorner.(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(bottomRightCorner);
				}
				return @object;
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00003EC8 File Offset: 0x000020C8
			[Register("setBottomRightCorner", "(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomRightCorner(int cornerFamily, ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(cornerFamily);
					ptr[1] = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomRightCorner.(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00003F54 File Offset: 0x00002154
			[Register("setBottomRightCorner", "(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomRightCorner(int cornerFamily, float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerFamily);
				ptr[1] = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomRightCorner.(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00003FB0 File Offset: 0x000021B0
			[Register("setBottomRightCornerSize", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomRightCornerSize(ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomRightCornerSize.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00004028 File Offset: 0x00002228
			[Register("setBottomRightCornerSize", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetBottomRightCornerSize(float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setBottomRightCornerSize.(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00004074 File Offset: 0x00002274
			[Register("setLeftEdge", "(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetLeftEdge(EdgeTreatment leftEdge)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((leftEdge == null) ? IntPtr.Zero : leftEdge.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setLeftEdge.(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(leftEdge);
				}
				return @object;
			}

			// Token: 0x0600015C RID: 348 RVA: 0x000040E8 File Offset: 0x000022E8
			[Register("setRightEdge", "(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetRightEdge(EdgeTreatment rightEdge)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((rightEdge == null) ? IntPtr.Zero : rightEdge.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setRightEdge.(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(rightEdge);
				}
				return @object;
			}

			// Token: 0x0600015D RID: 349 RVA: 0x0000415C File Offset: 0x0000235C
			[Register("setTopEdge", "(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopEdge(EdgeTreatment topEdge)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((topEdge == null) ? IntPtr.Zero : topEdge.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopEdge.(Lcom/google/android/material/shape/EdgeTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(topEdge);
				}
				return @object;
			}

			// Token: 0x0600015E RID: 350 RVA: 0x000041D0 File Offset: 0x000023D0
			[Register("setTopLeftCorner", "(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopLeftCorner(CornerTreatment topLeftCorner)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((topLeftCorner == null) ? IntPtr.Zero : topLeftCorner.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopLeftCorner.(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(topLeftCorner);
				}
				return @object;
			}

			// Token: 0x0600015F RID: 351 RVA: 0x00004244 File Offset: 0x00002444
			[Register("setTopLeftCorner", "(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopLeftCorner(int cornerFamily, ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(cornerFamily);
					ptr[1] = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopLeftCorner.(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000160 RID: 352 RVA: 0x000042D0 File Offset: 0x000024D0
			[Register("setTopLeftCorner", "(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopLeftCorner(int cornerFamily, float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerFamily);
				ptr[1] = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopLeftCorner.(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000161 RID: 353 RVA: 0x0000432C File Offset: 0x0000252C
			[Register("setTopLeftCornerSize", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopLeftCornerSize(ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopLeftCornerSize.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000162 RID: 354 RVA: 0x000043A4 File Offset: 0x000025A4
			[Register("setTopLeftCornerSize", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopLeftCornerSize(float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopLeftCornerSize.(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000163 RID: 355 RVA: 0x000043F0 File Offset: 0x000025F0
			[Register("setTopRightCorner", "(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopRightCorner(CornerTreatment topRightCorner)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((topRightCorner == null) ? IntPtr.Zero : topRightCorner.Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopRightCorner.(Lcom/google/android/material/shape/CornerTreatment;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(topRightCorner);
				}
				return @object;
			}

			// Token: 0x06000164 RID: 356 RVA: 0x00004464 File Offset: 0x00002664
			[Register("setTopRightCorner", "(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopRightCorner(int cornerFamily, ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(cornerFamily);
					ptr[1] = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopRightCorner.(ILcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000165 RID: 357 RVA: 0x000044F0 File Offset: 0x000026F0
			[Register("setTopRightCorner", "(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopRightCorner(int cornerFamily, float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerFamily);
				ptr[1] = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopRightCorner.(IF)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x0000454C File Offset: 0x0000274C
			[Register("setTopRightCornerSize", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopRightCornerSize(ICornerSize cornerSize)
			{
				ShapeAppearanceModel.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((cornerSize == null) ? IntPtr.Zero : ((Java.Lang.Object)cornerSize).Handle);
					@object = Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopRightCornerSize.(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(cornerSize);
				}
				return @object;
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000045C4 File Offset: 0x000027C4
			[Register("setTopRightCornerSize", "(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", "")]
			public unsafe ShapeAppearanceModel.Builder SetTopRightCornerSize(float cornerSize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(cornerSize);
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.Builder>(ShapeAppearanceModel.Builder._members.InstanceMethods.InvokeAbstractObjectMethod("setTopRightCornerSize.(F)Lcom/google/android/material/shape/ShapeAppearanceModel$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000026 RID: 38
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/ShapeAppearanceModel$Builder", typeof(ShapeAppearanceModel.Builder));
		}

		// Token: 0x0200003E RID: 62
		[Register("com/google/android/material/shape/ShapeAppearanceModel$CornerSizeUnaryOperator", "", "Google.Android.Material.Shape.ShapeAppearanceModel/ICornerSizeUnaryOperatorInvoker")]
		public interface ICornerSizeUnaryOperator : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000169 RID: 361
			[Register("apply", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/CornerSize;", "GetApply_Lcom_google_android_material_shape_CornerSize_Handler:Google.Android.Material.Shape.ShapeAppearanceModel/ICornerSizeUnaryOperatorInvoker, Xamarin.Google.Android.Material")]
			ICornerSize Apply(ICornerSize p0);
		}

		// Token: 0x0200003F RID: 63
		[Register("com/google/android/material/shape/ShapeAppearanceModel$CornerSizeUnaryOperator", DoNotGenerateAcw = true)]
		internal class ICornerSizeUnaryOperatorInvoker : Java.Lang.Object, ShapeAppearanceModel.ICornerSizeUnaryOperator, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600016A RID: 362 RVA: 0x00004628 File Offset: 0x00002828
			private static IntPtr java_class_ref
			{
				get
				{
					return ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600016B RID: 363 RVA: 0x0000464C File Offset: 0x0000284C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker._members;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00004653 File Offset: 0x00002853
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600016D RID: 365 RVA: 0x0000465B File Offset: 0x0000285B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00004667 File Offset: 0x00002867
			public static ShapeAppearanceModel.ICornerSizeUnaryOperator GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ShapeAppearanceModel.ICornerSizeUnaryOperator>(handle, transfer);
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00004670 File Offset: 0x00002870
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.shape.ShapeAppearanceModel.CornerSizeUnaryOperator'.");
				}
				return handle;
			}

			// Token: 0x06000170 RID: 368 RVA: 0x0000469B File Offset: 0x0000289B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x000046CC File Offset: 0x000028CC
			public ICornerSizeUnaryOperatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x00004704 File Offset: 0x00002904
			private static Delegate GetApply_Lcom_google_android_material_shape_CornerSize_Handler()
			{
				if (ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.cb_apply_Lcom_google_android_material_shape_CornerSize_ == null)
				{
					ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.cb_apply_Lcom_google_android_material_shape_CornerSize_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.n_Apply_Lcom_google_android_material_shape_CornerSize_));
				}
				return ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker.cb_apply_Lcom_google_android_material_shape_CornerSize_;
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00004728 File Offset: 0x00002928
			private static IntPtr n_Apply_Lcom_google_android_material_shape_CornerSize_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ShapeAppearanceModel.ICornerSizeUnaryOperator @object = Java.Lang.Object.GetObject<ShapeAppearanceModel.ICornerSizeUnaryOperator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICornerSize object2 = Java.Lang.Object.GetObject<ICornerSize>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Apply(object2));
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00004750 File Offset: 0x00002950
			public unsafe ICornerSize Apply(ICornerSize p0)
			{
				if (this.id_apply_Lcom_google_android_material_shape_CornerSize_ == IntPtr.Zero)
				{
					this.id_apply_Lcom_google_android_material_shape_CornerSize_ = JNIEnv.GetMethodID(this.class_ref, "apply", "(Lcom/google/android/material/shape/CornerSize;)Lcom/google/android/material/shape/CornerSize;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				return Java.Lang.Object.GetObject<ICornerSize>(JNIEnv.CallObjectMethod(base.Handle, this.id_apply_Lcom_google_android_material_shape_CornerSize_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000027 RID: 39
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/shape/ShapeAppearanceModel$CornerSizeUnaryOperator", typeof(ShapeAppearanceModel.ICornerSizeUnaryOperatorInvoker));

			// Token: 0x04000028 RID: 40
			private IntPtr class_ref;

			// Token: 0x04000029 RID: 41
			private static Delegate cb_apply_Lcom_google_android_material_shape_CornerSize_;

			// Token: 0x0400002A RID: 42
			private IntPtr id_apply_Lcom_google_android_material_shape_CornerSize_;
		}
	}
}
