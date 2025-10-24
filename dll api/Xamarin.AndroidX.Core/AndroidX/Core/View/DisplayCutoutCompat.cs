using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using AndroidX.Core.Graphics;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000A0 RID: 160
	[Register("androidx/core/view/DisplayCutoutCompat", DoNotGenerateAcw = true)]
	public sealed class DisplayCutoutCompat : Java.Lang.Object
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00019BD8 File Offset: 0x00017DD8
		internal static IntPtr class_ref
		{
			get
			{
				return DisplayCutoutCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00019BFC File Offset: 0x00017DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DisplayCutoutCompat._members;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00019C04 File Offset: 0x00017E04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DisplayCutoutCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00019C28 File Offset: 0x00017E28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DisplayCutoutCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002384 File Offset: 0x00000584
		internal DisplayCutoutCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00019C34 File Offset: 0x00017E34
		[Register(".ctor", "(Landroid/graphics/Rect;Ljava/util/List;)V", "")]
		public unsafe DisplayCutoutCompat(Rect safeInsets, IList<Rect> boundingRects) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<Rect>.ToLocalJniHandle(boundingRects);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((safeInsets == null) ? IntPtr.Zero : safeInsets.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(DisplayCutoutCompat._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/Rect;Ljava/util/List;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DisplayCutoutCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/Rect;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(safeInsets);
				GC.KeepAlive(boundingRects);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00019D08 File Offset: 0x00017F08
		[Register(".ctor", "(Landroidx/core/graphics/Insets;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroidx/core/graphics/Insets;)V", "")]
		public unsafe DisplayCutoutCompat(AndroidX.Core.Graphics.Insets safeInsets, Rect boundLeft, Rect boundTop, Rect boundRight, Rect boundBottom, AndroidX.Core.Graphics.Insets waterfallInsets) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((safeInsets == null) ? IntPtr.Zero : safeInsets.Handle);
				ptr[1] = new JniArgumentValue((boundLeft == null) ? IntPtr.Zero : boundLeft.Handle);
				ptr[2] = new JniArgumentValue((boundTop == null) ? IntPtr.Zero : boundTop.Handle);
				ptr[3] = new JniArgumentValue((boundRight == null) ? IntPtr.Zero : boundRight.Handle);
				ptr[4] = new JniArgumentValue((boundBottom == null) ? IntPtr.Zero : boundBottom.Handle);
				ptr[5] = new JniArgumentValue((waterfallInsets == null) ? IntPtr.Zero : waterfallInsets.Handle);
				base.SetHandle(DisplayCutoutCompat._members.InstanceMethods.StartCreateInstance("(Landroidx/core/graphics/Insets;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroidx/core/graphics/Insets;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DisplayCutoutCompat._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/graphics/Insets;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroid/graphics/Rect;Landroidx/core/graphics/Insets;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(safeInsets);
				GC.KeepAlive(boundLeft);
				GC.KeepAlive(boundTop);
				GC.KeepAlive(boundRight);
				GC.KeepAlive(boundBottom);
				GC.KeepAlive(waterfallInsets);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00019EA0 File Offset: 0x000180A0
		public IList<Rect> BoundingRects
		{
			[Register("getBoundingRects", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<Rect>.FromJniHandle(DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getBoundingRects.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00019ED2 File Offset: 0x000180D2
		public int SafeInsetBottom
		{
			[Register("getSafeInsetBottom", "()I", "")]
			get
			{
				return DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractInt32Method("getSafeInsetBottom.()I", this, null);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00019EEB File Offset: 0x000180EB
		public int SafeInsetLeft
		{
			[Register("getSafeInsetLeft", "()I", "")]
			get
			{
				return DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractInt32Method("getSafeInsetLeft.()I", this, null);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00019F04 File Offset: 0x00018104
		public int SafeInsetRight
		{
			[Register("getSafeInsetRight", "()I", "")]
			get
			{
				return DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractInt32Method("getSafeInsetRight.()I", this, null);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00019F1D File Offset: 0x0001811D
		public int SafeInsetTop
		{
			[Register("getSafeInsetTop", "()I", "")]
			get
			{
				return DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractInt32Method("getSafeInsetTop.()I", this, null);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00019F38 File Offset: 0x00018138
		public AndroidX.Core.Graphics.Insets WaterfallInsets
		{
			[Register("getWaterfallInsets", "()Landroidx/core/graphics/Insets;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.Graphics.Insets>(DisplayCutoutCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getWaterfallInsets.()Landroidx/core/graphics/Insets;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400024A RID: 586
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/DisplayCutoutCompat", typeof(DisplayCutoutCompat));
	}
}
