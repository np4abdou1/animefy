using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Graphics.Drawables
{
	// Token: 0x02000239 RID: 569
	[Register("android/graphics/drawable/Drawable", DoNotGenerateAcw = true)]
	internal class DrawableInvoker : Drawable
	{
		// Token: 0x0600142C RID: 5164 RVA: 0x000334B4 File Offset: 0x000316B4
		public DrawableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x000340ED File Offset: 0x000322ED
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableInvoker._members;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x000340F4 File Offset: 0x000322F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00034100 File Offset: 0x00032300
		public override int Opacity
		{
			get
			{
				return DrawableInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0003411C File Offset: 0x0003231C
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				DrawableInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00034180 File Offset: 0x00032380
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			DrawableInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000341BC File Offset: 0x000323BC
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				DrawableInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x040008D6 RID: 2262
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/Drawable", typeof(DrawableInvoker));
	}
}
