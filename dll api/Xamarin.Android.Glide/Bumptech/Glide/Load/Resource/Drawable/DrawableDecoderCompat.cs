using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F1 RID: 241
	[Register("com/bumptech/glide/load/resource/drawable/DrawableDecoderCompat", DoNotGenerateAcw = true)]
	public sealed class DrawableDecoderCompat : Java.Lang.Object
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00025584 File Offset: 0x00023784
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableDecoderCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000255A8 File Offset: 0x000237A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableDecoderCompat._members;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000255B0 File Offset: 0x000237B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableDecoderCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x000255D4 File Offset: 0x000237D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableDecoderCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000255E0 File Offset: 0x000237E0
		internal DrawableDecoderCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000255EC File Offset: 0x000237EC
		[Register("getDrawable", "(Landroid/content/Context;Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe static Drawable GetDrawable(Context ourContext, Context targetContext, int id)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ourContext == null) ? IntPtr.Zero : ourContext.Handle);
				ptr[1] = new JniArgumentValue((targetContext == null) ? IntPtr.Zero : targetContext.Handle);
				ptr[2] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<Drawable>(DrawableDecoderCompat._members.StaticMethods.InvokeObjectMethod("getDrawable.(Landroid/content/Context;Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(ourContext);
				GC.KeepAlive(targetContext);
			}
			return @object;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002569C File Offset: 0x0002389C
		[Register("getDrawable", "(Landroid/content/Context;ILandroid/content/res/Resources$Theme;)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe static Drawable GetDrawable(Context ourContext, int id, Resources.Theme theme)
		{
			Drawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ourContext == null) ? IntPtr.Zero : ourContext.Handle);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue((theme == null) ? IntPtr.Zero : theme.Handle);
				@object = Java.Lang.Object.GetObject<Drawable>(DrawableDecoderCompat._members.StaticMethods.InvokeObjectMethod("getDrawable.(Landroid/content/Context;ILandroid/content/res/Resources$Theme;)Landroid/graphics/drawable/Drawable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(ourContext);
				GC.KeepAlive(theme);
			}
			return @object;
		}

		// Token: 0x040002E7 RID: 743
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/DrawableDecoderCompat", typeof(DrawableDecoderCompat));
	}
}
