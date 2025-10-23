using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Graphics.Drawable
{
	// Token: 0x02000039 RID: 57
	[Register("androidx/appcompat/graphics/drawable/DrawerArrowDrawable", DoNotGenerateAcw = true)]
	public class DrawerArrowDrawable : Drawable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return DrawerArrowDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawerArrowDrawable._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawerArrowDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawerArrowDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000020DC File Offset: 0x000002DC
		protected DrawerArrowDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DrawerArrowDrawable(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(DrawerArrowDrawable._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawerArrowDrawable._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002198 File Offset: 0x00000398
		private static Delegate GetGetArrowHeadLengthHandler()
		{
			if (DrawerArrowDrawable.cb_getArrowHeadLength == null)
			{
				DrawerArrowDrawable.cb_getArrowHeadLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetArrowHeadLength));
			}
			return DrawerArrowDrawable.cb_getArrowHeadLength;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000021BC File Offset: 0x000003BC
		private static float n_GetArrowHeadLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrowHeadLength;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000021CB File Offset: 0x000003CB
		private static Delegate GetSetArrowHeadLength_FHandler()
		{
			if (DrawerArrowDrawable.cb_setArrowHeadLength_F == null)
			{
				DrawerArrowDrawable.cb_setArrowHeadLength_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetArrowHeadLength_F));
			}
			return DrawerArrowDrawable.cb_setArrowHeadLength_F;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000021EF File Offset: 0x000003EF
		private static void n_SetArrowHeadLength_F(IntPtr jnienv, IntPtr native__this, float length)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrowHeadLength = length;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000021FF File Offset: 0x000003FF
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002218 File Offset: 0x00000418
		public unsafe virtual float ArrowHeadLength
		{
			[Register("getArrowHeadLength", "()F", "GetGetArrowHeadLengthHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getArrowHeadLength.()F", this, null);
			}
			[Register("setArrowHeadLength", "(F)V", "GetSetArrowHeadLength_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setArrowHeadLength.(F)V", this, ptr);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002253 File Offset: 0x00000453
		private static Delegate GetGetArrowShaftLengthHandler()
		{
			if (DrawerArrowDrawable.cb_getArrowShaftLength == null)
			{
				DrawerArrowDrawable.cb_getArrowShaftLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetArrowShaftLength));
			}
			return DrawerArrowDrawable.cb_getArrowShaftLength;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002277 File Offset: 0x00000477
		private static float n_GetArrowShaftLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrowShaftLength;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002286 File Offset: 0x00000486
		private static Delegate GetSetArrowShaftLength_FHandler()
		{
			if (DrawerArrowDrawable.cb_setArrowShaftLength_F == null)
			{
				DrawerArrowDrawable.cb_setArrowShaftLength_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetArrowShaftLength_F));
			}
			return DrawerArrowDrawable.cb_setArrowShaftLength_F;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000022AA File Offset: 0x000004AA
		private static void n_SetArrowShaftLength_F(IntPtr jnienv, IntPtr native__this, float length)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrowShaftLength = length;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000022BA File Offset: 0x000004BA
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000022D4 File Offset: 0x000004D4
		public unsafe virtual float ArrowShaftLength
		{
			[Register("getArrowShaftLength", "()F", "GetGetArrowShaftLengthHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getArrowShaftLength.()F", this, null);
			}
			[Register("setArrowShaftLength", "(F)V", "GetSetArrowShaftLength_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setArrowShaftLength.(F)V", this, ptr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000230F File Offset: 0x0000050F
		private static Delegate GetGetBarLengthHandler()
		{
			if (DrawerArrowDrawable.cb_getBarLength == null)
			{
				DrawerArrowDrawable.cb_getBarLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetBarLength));
			}
			return DrawerArrowDrawable.cb_getBarLength;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002333 File Offset: 0x00000533
		private static float n_GetBarLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BarLength;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002342 File Offset: 0x00000542
		private static Delegate GetSetBarLength_FHandler()
		{
			if (DrawerArrowDrawable.cb_setBarLength_F == null)
			{
				DrawerArrowDrawable.cb_setBarLength_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetBarLength_F));
			}
			return DrawerArrowDrawable.cb_setBarLength_F;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002366 File Offset: 0x00000566
		private static void n_SetBarLength_F(IntPtr jnienv, IntPtr native__this, float length)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BarLength = length;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002376 File Offset: 0x00000576
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002390 File Offset: 0x00000590
		public unsafe virtual float BarLength
		{
			[Register("getBarLength", "()F", "GetGetBarLengthHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getBarLength.()F", this, null);
			}
			[Register("setBarLength", "(F)V", "GetSetBarLength_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBarLength.(F)V", this, ptr);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000023CB File Offset: 0x000005CB
		private static Delegate GetGetBarThicknessHandler()
		{
			if (DrawerArrowDrawable.cb_getBarThickness == null)
			{
				DrawerArrowDrawable.cb_getBarThickness = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetBarThickness));
			}
			return DrawerArrowDrawable.cb_getBarThickness;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000023EF File Offset: 0x000005EF
		private static float n_GetBarThickness(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BarThickness;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000023FE File Offset: 0x000005FE
		private static Delegate GetSetBarThickness_FHandler()
		{
			if (DrawerArrowDrawable.cb_setBarThickness_F == null)
			{
				DrawerArrowDrawable.cb_setBarThickness_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetBarThickness_F));
			}
			return DrawerArrowDrawable.cb_setBarThickness_F;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002422 File Offset: 0x00000622
		private static void n_SetBarThickness_F(IntPtr jnienv, IntPtr native__this, float width)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BarThickness = width;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002432 File Offset: 0x00000632
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000244C File Offset: 0x0000064C
		public unsafe virtual float BarThickness
		{
			[Register("getBarThickness", "()F", "GetGetBarThicknessHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getBarThickness.()F", this, null);
			}
			[Register("setBarThickness", "(F)V", "GetSetBarThickness_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBarThickness.(F)V", this, ptr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002487 File Offset: 0x00000687
		private static Delegate GetGetColorHandler()
		{
			if (DrawerArrowDrawable.cb_getColor == null)
			{
				DrawerArrowDrawable.cb_getColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DrawerArrowDrawable.n_GetColor));
			}
			return DrawerArrowDrawable.cb_getColor;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000024AB File Offset: 0x000006AB
		private static int n_GetColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Color;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000024BA File Offset: 0x000006BA
		private static Delegate GetSetColor_IHandler()
		{
			if (DrawerArrowDrawable.cb_setColor_I == null)
			{
				DrawerArrowDrawable.cb_setColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerArrowDrawable.n_SetColor_I));
			}
			return DrawerArrowDrawable.cb_setColor_I;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000024DE File Offset: 0x000006DE
		private static void n_SetColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Color = color;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000024EE File Offset: 0x000006EE
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002508 File Offset: 0x00000708
		public unsafe virtual int Color
		{
			[Register("getColor", "()I", "GetGetColorHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getColor.()I", this, null);
			}
			[Register("setColor", "(I)V", "GetSetColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColor.(I)V", this, ptr);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002543 File Offset: 0x00000743
		private static Delegate GetGetDirectionHandler()
		{
			if (DrawerArrowDrawable.cb_getDirection == null)
			{
				DrawerArrowDrawable.cb_getDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DrawerArrowDrawable.n_GetDirection));
			}
			return DrawerArrowDrawable.cb_getDirection;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002567 File Offset: 0x00000767
		private static int n_GetDirection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Direction;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002576 File Offset: 0x00000776
		private static Delegate GetSetDirection_IHandler()
		{
			if (DrawerArrowDrawable.cb_setDirection_I == null)
			{
				DrawerArrowDrawable.cb_setDirection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerArrowDrawable.n_SetDirection_I));
			}
			return DrawerArrowDrawable.cb_setDirection_I;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000259A File Offset: 0x0000079A
		private static void n_SetDirection_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Direction = direction;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000025AA File Offset: 0x000007AA
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000025C4 File Offset: 0x000007C4
		public unsafe virtual int Direction
		{
			[Register("getDirection", "()I", "GetGetDirectionHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getDirection.()I", this, null);
			}
			[Register("setDirection", "(I)V", "GetSetDirection_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setDirection.(I)V", this, ptr);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000025FF File Offset: 0x000007FF
		private static Delegate GetGetGapSizeHandler()
		{
			if (DrawerArrowDrawable.cb_getGapSize == null)
			{
				DrawerArrowDrawable.cb_getGapSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetGapSize));
			}
			return DrawerArrowDrawable.cb_getGapSize;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002623 File Offset: 0x00000823
		private static float n_GetGapSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GapSize;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002632 File Offset: 0x00000832
		private static Delegate GetSetGapSize_FHandler()
		{
			if (DrawerArrowDrawable.cb_setGapSize_F == null)
			{
				DrawerArrowDrawable.cb_setGapSize_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetGapSize_F));
			}
			return DrawerArrowDrawable.cb_setGapSize_F;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002656 File Offset: 0x00000856
		private static void n_SetGapSize_F(IntPtr jnienv, IntPtr native__this, float gap)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GapSize = gap;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002666 File Offset: 0x00000866
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002680 File Offset: 0x00000880
		public unsafe virtual float GapSize
		{
			[Register("getGapSize", "()F", "GetGetGapSizeHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getGapSize.()F", this, null);
			}
			[Register("setGapSize", "(F)V", "GetSetGapSize_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setGapSize.(F)V", this, ptr);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000026BB File Offset: 0x000008BB
		private static Delegate GetGetOpacityHandler()
		{
			if (DrawerArrowDrawable.cb_getOpacity == null)
			{
				DrawerArrowDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DrawerArrowDrawable.n_GetOpacity));
			}
			return DrawerArrowDrawable.cb_getOpacity;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026DF File Offset: 0x000008DF
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000026EE File Offset: 0x000008EE
		public override int Opacity
		{
			[Register("getOpacity", "()I", "GetGetOpacityHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002708 File Offset: 0x00000908
		public Paint Paint
		{
			[Register("getPaint", "()Landroid/graphics/Paint;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Paint>(DrawerArrowDrawable._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPaint.()Landroid/graphics/Paint;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000273A File Offset: 0x0000093A
		private static Delegate GetGetProgressHandler()
		{
			if (DrawerArrowDrawable.cb_getProgress == null)
			{
				DrawerArrowDrawable.cb_getProgress = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerArrowDrawable.n_GetProgress));
			}
			return DrawerArrowDrawable.cb_getProgress;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000275E File Offset: 0x0000095E
		private static float n_GetProgress(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Progress;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000276D File Offset: 0x0000096D
		private static Delegate GetSetProgress_FHandler()
		{
			if (DrawerArrowDrawable.cb_setProgress_F == null)
			{
				DrawerArrowDrawable.cb_setProgress_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerArrowDrawable.n_SetProgress_F));
			}
			return DrawerArrowDrawable.cb_setProgress_F;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002791 File Offset: 0x00000991
		private static void n_SetProgress_F(IntPtr jnienv, IntPtr native__this, float progress)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Progress = progress;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000027A1 File Offset: 0x000009A1
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe virtual float Progress
		{
			[Register("getProgress", "()F", "GetGetProgressHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualSingleMethod("getProgress.()F", this, null);
			}
			[Register("setProgress", "(F)V", "GetSetProgress_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setProgress.(F)V", this, ptr);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000027F7 File Offset: 0x000009F7
		private static Delegate GetIsSpinEnabledHandler()
		{
			if (DrawerArrowDrawable.cb_isSpinEnabled == null)
			{
				DrawerArrowDrawable.cb_isSpinEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DrawerArrowDrawable.n_IsSpinEnabled));
			}
			return DrawerArrowDrawable.cb_isSpinEnabled;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000281B File Offset: 0x00000A1B
		private static bool n_IsSpinEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpinEnabled;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000282A File Offset: 0x00000A2A
		private static Delegate GetSetSpinEnabled_ZHandler()
		{
			if (DrawerArrowDrawable.cb_setSpinEnabled_Z == null)
			{
				DrawerArrowDrawable.cb_setSpinEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(DrawerArrowDrawable.n_SetSpinEnabled_Z));
			}
			return DrawerArrowDrawable.cb_setSpinEnabled_Z;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000284E File Offset: 0x00000A4E
		private static void n_SetSpinEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpinEnabled = enabled;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000285E File Offset: 0x00000A5E
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002878 File Offset: 0x00000A78
		public unsafe virtual bool SpinEnabled
		{
			[Register("isSpinEnabled", "()Z", "GetIsSpinEnabledHandler")]
			get
			{
				return DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualBooleanMethod("isSpinEnabled.()Z", this, null);
			}
			[Register("setSpinEnabled", "(Z)V", "GetSetSpinEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setSpinEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000028B3 File Offset: 0x00000AB3
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (DrawerArrowDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				DrawerArrowDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerArrowDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return DrawerArrowDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000028D8 File Offset: 0x00000AD8
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000028FC File Offset: 0x00000AFC
		[Register("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002960 File Offset: 0x00000B60
		private static Delegate GetSetAlpha_IHandler()
		{
			if (DrawerArrowDrawable.cb_setAlpha_I == null)
			{
				DrawerArrowDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerArrowDrawable.n_SetAlpha_I));
			}
			return DrawerArrowDrawable.cb_setAlpha_I;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002984 File Offset: 0x00000B84
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002994 File Offset: 0x00000B94
		[Register("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000029CF File Offset: 0x00000BCF
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (DrawerArrowDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				DrawerArrowDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerArrowDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return DrawerArrowDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000029F4 File Offset: 0x00000BF4
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002A18 File Offset: 0x00000C18
		[Register("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002A7C File Offset: 0x00000C7C
		private static Delegate GetSetVerticalMirror_ZHandler()
		{
			if (DrawerArrowDrawable.cb_setVerticalMirror_Z == null)
			{
				DrawerArrowDrawable.cb_setVerticalMirror_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(DrawerArrowDrawable.n_SetVerticalMirror_Z));
			}
			return DrawerArrowDrawable.cb_setVerticalMirror_Z;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002AA0 File Offset: 0x00000CA0
		private static void n_SetVerticalMirror_Z(IntPtr jnienv, IntPtr native__this, bool verticalMirror)
		{
			Java.Lang.Object.GetObject<DrawerArrowDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVerticalMirror(verticalMirror);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[Register("setVerticalMirror", "(Z)V", "GetSetVerticalMirror_ZHandler")]
		public unsafe virtual void SetVerticalMirror(bool verticalMirror)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(verticalMirror);
			DrawerArrowDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setVerticalMirror.(Z)V", this, ptr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/graphics/drawable/DrawerArrowDrawable", typeof(DrawerArrowDrawable));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getArrowHeadLength;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_setArrowHeadLength_F;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getArrowShaftLength;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_setArrowShaftLength_F;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getBarLength;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_setBarLength_F;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getBarThickness;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_setBarThickness_F;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getColor;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_setColor_I;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_getDirection;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_setDirection_I;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_getGapSize;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_setGapSize_F;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_getOpacity;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_getProgress;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_setProgress_F;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_isSpinEnabled;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_setSpinEnabled_Z;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_setAlpha_I;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_setVerticalMirror_Z;
	}
}
