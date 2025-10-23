using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000D4 RID: 212
	[Register("android/widget/ImageView", DoNotGenerateAcw = true)]
	public class ImageView : View
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000884F File Offset: 0x00006A4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ImageView._members;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00008858 File Offset: 0x00006A58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ImageView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000887C File Offset: 0x00006A7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ImageView._members.ManagedPeerType;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00008888 File Offset: 0x00006A88
		protected ImageView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00008894 File Offset: 0x00006A94
		public unsafe ImageView(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(ImageView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ImageView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00008970 File Offset: 0x00006B70
		public unsafe ImageView(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(ImageView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ImageView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00008A60 File Offset: 0x00006C60
		private static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_Handler()
		{
			if (ImageView.cb_setImageBitmap_Landroid_graphics_Bitmap_ == null)
			{
				ImageView.cb_setImageBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ImageView.n_SetImageBitmap_Landroid_graphics_Bitmap_));
			}
			return ImageView.cb_setImageBitmap_Landroid_graphics_Bitmap_;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00008A84 File Offset: 0x00006C84
		private static void n_SetImageBitmap_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_bm)
		{
			ImageView @object = Java.Lang.Object.GetObject<ImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_bm, JniHandleOwnership.DoNotTransfer);
			@object.SetImageBitmap(object2);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00008AA8 File Offset: 0x00006CA8
		public unsafe virtual void SetImageBitmap(Bitmap bm)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bm == null) ? IntPtr.Zero : bm.Handle);
				ImageView._members.InstanceMethods.InvokeVirtualVoidMethod("setImageBitmap.(Landroid/graphics/Bitmap;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bm);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00008B0C File Offset: 0x00006D0C
		private static Delegate GetSetImageResource_IHandler()
		{
			if (ImageView.cb_setImageResource_I == null)
			{
				ImageView.cb_setImageResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ImageView.n_SetImageResource_I));
			}
			return ImageView.cb_setImageResource_I;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00008B30 File Offset: 0x00006D30
		private static void n_SetImageResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetImageResource(resId);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00008B40 File Offset: 0x00006D40
		public unsafe virtual void SetImageResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ImageView._members.InstanceMethods.InvokeVirtualVoidMethod("setImageResource.(I)V", this, ptr);
		}

		// Token: 0x040000E3 RID: 227
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ImageView", typeof(ImageView));

		// Token: 0x040000E4 RID: 228
		private static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_;

		// Token: 0x040000E5 RID: 229
		private static Delegate cb_setImageResource_I;

		// Token: 0x020000D5 RID: 213
		[Register("android/widget/ImageView$ScaleType", DoNotGenerateAcw = true)]
		public sealed class ScaleType : Java.Lang.Enum
		{
			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x00008B96 File Offset: 0x00006D96
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ImageView.ScaleType._members;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000481 RID: 1153 RVA: 0x00008BA0 File Offset: 0x00006DA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ImageView.ScaleType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x00008BC4 File Offset: 0x00006DC4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ImageView.ScaleType._members.ManagedPeerType;
				}
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal ScaleType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040000E6 RID: 230
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/ImageView$ScaleType", typeof(ImageView.ScaleType));
		}
	}
}
