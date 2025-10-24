using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000E6 RID: 230
	[Register("com/unity3d/services/core/misc/ViewUtilities", DoNotGenerateAcw = true)]
	public class ViewUtilities : Java.Lang.Object
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0001A9E0 File Offset: 0x00018BE0
		internal static IntPtr class_ref
		{
			get
			{
				return ViewUtilities._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0001AA04 File Offset: 0x00018C04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewUtilities._members;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0001AA0C File Offset: 0x00018C0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewUtilities._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0001AA30 File Offset: 0x00018C30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewUtilities._members.ManagedPeerType;
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ViewUtilities(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001AA3C File Offset: 0x00018C3C
		[Register(".ctor", "()V", "")]
		public ViewUtilities() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ViewUtilities._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ViewUtilities._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0001AAAC File Offset: 0x00018CAC
		[Register("dpFromPx", "(Landroid/content/Context;F)F", "")]
		public unsafe static float DpFromPx(Context context, float px)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(px);
				result = ViewUtilities._members.StaticMethods.InvokeSingleMethod("dpFromPx.(Landroid/content/Context;F)F", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001AB24 File Offset: 0x00018D24
		[Register("pxFromDp", "(Landroid/content/Context;F)F", "")]
		public unsafe static float PxFromDp(Context context, float dp)
		{
			float result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(dp);
				result = ViewUtilities._members.StaticMethods.InvokeSingleMethod("pxFromDp.(Landroid/content/Context;F)F", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0001AB9C File Offset: 0x00018D9C
		[Register("removeViewFromParent", "(Landroid/view/View;)V", "")]
		public unsafe static void RemoveViewFromParent(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ViewUtilities._members.StaticMethods.InvokeVoidMethod("removeViewFromParent.(Landroid/view/View;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0001AC00 File Offset: 0x00018E00
		[Register("setBackground", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe static void SetBackground(View view, Drawable drawable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				ViewUtilities._members.StaticMethods.InvokeVoidMethod("setBackground.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x04000228 RID: 552
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/ViewUtilities", typeof(ViewUtilities));
	}
}
