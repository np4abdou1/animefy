using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Internal
{
	// Token: 0x02000096 RID: 150
	[Register("com/google/android/material/internal/ScrimInsetsFrameLayout", DoNotGenerateAcw = true)]
	public class ScrimInsetsFrameLayout : FrameLayout
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0001B7B8 File Offset: 0x000199B8
		internal static IntPtr class_ref
		{
			get
			{
				return ScrimInsetsFrameLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0001B7DC File Offset: 0x000199DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScrimInsetsFrameLayout._members;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0001B7E4 File Offset: 0x000199E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScrimInsetsFrameLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0001B808 File Offset: 0x00019A08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScrimInsetsFrameLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001B814 File Offset: 0x00019A14
		protected ScrimInsetsFrameLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001B820 File Offset: 0x00019A20
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ScrimInsetsFrameLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ScrimInsetsFrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrimInsetsFrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ScrimInsetsFrameLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScrimInsetsFrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrimInsetsFrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0001B9AC File Offset: 0x00019BAC
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ScrimInsetsFrameLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ScrimInsetsFrameLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrimInsetsFrameLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001BA9C File Offset: 0x00019C9C
		private static Delegate GetOnInsetsChanged_Landroidx_core_view_WindowInsetsCompat_Handler()
		{
			if (ScrimInsetsFrameLayout.cb_onInsetsChanged_Landroidx_core_view_WindowInsetsCompat_ == null)
			{
				ScrimInsetsFrameLayout.cb_onInsetsChanged_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScrimInsetsFrameLayout.n_OnInsetsChanged_Landroidx_core_view_WindowInsetsCompat_));
			}
			return ScrimInsetsFrameLayout.cb_onInsetsChanged_Landroidx_core_view_WindowInsetsCompat_;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001BAC0 File Offset: 0x00019CC0
		private static void n_OnInsetsChanged_Landroidx_core_view_WindowInsetsCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			ScrimInsetsFrameLayout @object = Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WindowInsetsCompat object2 = Java.Lang.Object.GetObject<WindowInsetsCompat>(native_insets, JniHandleOwnership.DoNotTransfer);
			@object.OnInsetsChanged(object2);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		[Register("onInsetsChanged", "(Landroidx/core/view/WindowInsetsCompat;)V", "GetOnInsetsChanged_Landroidx_core_view_WindowInsetsCompat_Handler")]
		protected unsafe virtual void OnInsetsChanged(WindowInsetsCompat insets)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onInsetsChanged.(Landroidx/core/view/WindowInsetsCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001BB48 File Offset: 0x00019D48
		private static Delegate GetSetDrawBottomInsetForeground_ZHandler()
		{
			if (ScrimInsetsFrameLayout.cb_setDrawBottomInsetForeground_Z == null)
			{
				ScrimInsetsFrameLayout.cb_setDrawBottomInsetForeground_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScrimInsetsFrameLayout.n_SetDrawBottomInsetForeground_Z));
			}
			return ScrimInsetsFrameLayout.cb_setDrawBottomInsetForeground_Z;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001BB6C File Offset: 0x00019D6C
		private static void n_SetDrawBottomInsetForeground_Z(IntPtr jnienv, IntPtr native__this, bool drawBottomInsetForeground)
		{
			Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawBottomInsetForeground(drawBottomInsetForeground);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001BB7C File Offset: 0x00019D7C
		[Register("setDrawBottomInsetForeground", "(Z)V", "GetSetDrawBottomInsetForeground_ZHandler")]
		public unsafe virtual void SetDrawBottomInsetForeground(bool drawBottomInsetForeground)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawBottomInsetForeground);
			ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawBottomInsetForeground.(Z)V", this, ptr);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001BBB7 File Offset: 0x00019DB7
		private static Delegate GetSetDrawLeftInsetForeground_ZHandler()
		{
			if (ScrimInsetsFrameLayout.cb_setDrawLeftInsetForeground_Z == null)
			{
				ScrimInsetsFrameLayout.cb_setDrawLeftInsetForeground_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScrimInsetsFrameLayout.n_SetDrawLeftInsetForeground_Z));
			}
			return ScrimInsetsFrameLayout.cb_setDrawLeftInsetForeground_Z;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001BBDB File Offset: 0x00019DDB
		private static void n_SetDrawLeftInsetForeground_Z(IntPtr jnienv, IntPtr native__this, bool drawLeftInsetForeground)
		{
			Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawLeftInsetForeground(drawLeftInsetForeground);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001BBEC File Offset: 0x00019DEC
		[Register("setDrawLeftInsetForeground", "(Z)V", "GetSetDrawLeftInsetForeground_ZHandler")]
		public unsafe virtual void SetDrawLeftInsetForeground(bool drawLeftInsetForeground)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawLeftInsetForeground);
			ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawLeftInsetForeground.(Z)V", this, ptr);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001BC27 File Offset: 0x00019E27
		private static Delegate GetSetDrawRightInsetForeground_ZHandler()
		{
			if (ScrimInsetsFrameLayout.cb_setDrawRightInsetForeground_Z == null)
			{
				ScrimInsetsFrameLayout.cb_setDrawRightInsetForeground_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScrimInsetsFrameLayout.n_SetDrawRightInsetForeground_Z));
			}
			return ScrimInsetsFrameLayout.cb_setDrawRightInsetForeground_Z;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001BC4B File Offset: 0x00019E4B
		private static void n_SetDrawRightInsetForeground_Z(IntPtr jnienv, IntPtr native__this, bool drawRightInsetForeground)
		{
			Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawRightInsetForeground(drawRightInsetForeground);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001BC5C File Offset: 0x00019E5C
		[Register("setDrawRightInsetForeground", "(Z)V", "GetSetDrawRightInsetForeground_ZHandler")]
		public unsafe virtual void SetDrawRightInsetForeground(bool drawRightInsetForeground)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawRightInsetForeground);
			ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawRightInsetForeground.(Z)V", this, ptr);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001BC97 File Offset: 0x00019E97
		private static Delegate GetSetDrawTopInsetForeground_ZHandler()
		{
			if (ScrimInsetsFrameLayout.cb_setDrawTopInsetForeground_Z == null)
			{
				ScrimInsetsFrameLayout.cb_setDrawTopInsetForeground_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScrimInsetsFrameLayout.n_SetDrawTopInsetForeground_Z));
			}
			return ScrimInsetsFrameLayout.cb_setDrawTopInsetForeground_Z;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001BCBB File Offset: 0x00019EBB
		private static void n_SetDrawTopInsetForeground_Z(IntPtr jnienv, IntPtr native__this, bool drawTopInsetForeground)
		{
			Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawTopInsetForeground(drawTopInsetForeground);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001BCCC File Offset: 0x00019ECC
		[Register("setDrawTopInsetForeground", "(Z)V", "GetSetDrawTopInsetForeground_ZHandler")]
		public unsafe virtual void SetDrawTopInsetForeground(bool drawTopInsetForeground)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawTopInsetForeground);
			ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawTopInsetForeground.(Z)V", this, ptr);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0001BD07 File Offset: 0x00019F07
		private static Delegate GetSetScrimInsetForeground_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ScrimInsetsFrameLayout.cb_setScrimInsetForeground_Landroid_graphics_drawable_Drawable_ == null)
			{
				ScrimInsetsFrameLayout.cb_setScrimInsetForeground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScrimInsetsFrameLayout.n_SetScrimInsetForeground_Landroid_graphics_drawable_Drawable_));
			}
			return ScrimInsetsFrameLayout.cb_setScrimInsetForeground_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0001BD2C File Offset: 0x00019F2C
		private static void n_SetScrimInsetForeground_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			ScrimInsetsFrameLayout @object = Java.Lang.Object.GetObject<ScrimInsetsFrameLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			@object.SetScrimInsetForeground(object2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0001BD50 File Offset: 0x00019F50
		[Register("setScrimInsetForeground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetScrimInsetForeground_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetScrimInsetForeground(Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				ScrimInsetsFrameLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimInsetForeground.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x040002EC RID: 748
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/internal/ScrimInsetsFrameLayout", typeof(ScrimInsetsFrameLayout));

		// Token: 0x040002ED RID: 749
		private static Delegate cb_onInsetsChanged_Landroidx_core_view_WindowInsetsCompat_;

		// Token: 0x040002EE RID: 750
		private static Delegate cb_setDrawBottomInsetForeground_Z;

		// Token: 0x040002EF RID: 751
		private static Delegate cb_setDrawLeftInsetForeground_Z;

		// Token: 0x040002F0 RID: 752
		private static Delegate cb_setDrawRightInsetForeground_Z;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_setDrawTopInsetForeground_Z;

		// Token: 0x040002F2 RID: 754
		private static Delegate cb_setScrimInsetForeground_Landroid_graphics_drawable_Drawable_;
	}
}
