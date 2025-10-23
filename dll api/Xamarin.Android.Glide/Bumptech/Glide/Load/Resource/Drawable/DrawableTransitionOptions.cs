using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F4 RID: 244
	[Register("com/bumptech/glide/load/resource/drawable/DrawableTransitionOptions", DoNotGenerateAcw = true)]
	public sealed class DrawableTransitionOptions : TransitionOptions
	{
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00025ACC File Offset: 0x00023CCC
		internal new static IntPtr class_ref
		{
			get
			{
				return DrawableTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00025AF0 File Offset: 0x00023CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableTransitionOptions._members;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00025AF8 File Offset: 0x00023CF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00025B1C File Offset: 0x00023D1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableTransitionOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00025B28 File Offset: 0x00023D28
		internal DrawableTransitionOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00025B34 File Offset: 0x00023D34
		[Register(".ctor", "()V", "")]
		public DrawableTransitionOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DrawableTransitionOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DrawableTransitionOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00025BA4 File Offset: 0x00023DA4
		[Register("crossFade", "()Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public DrawableTransitionOptions CrossFade()
		{
			return Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.()Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00025BD8 File Offset: 0x00023DD8
		[Register("crossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe DrawableTransitionOptions CrossFade(DrawableCrossFadeFactory drawableCrossFadeFactory)
		{
			DrawableTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : drawableCrossFadeFactory.Handle);
				@object = Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00025C4C File Offset: 0x00023E4C
		[Register("crossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe DrawableTransitionOptions CrossFade(DrawableCrossFadeFactory.Builder builder)
		{
			DrawableTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				@object = Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
			return @object;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00025CC0 File Offset: 0x00023EC0
		[Register("crossFade", "(I)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe DrawableTransitionOptions CrossFade(int duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(I)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00025D0C File Offset: 0x00023F0C
		[Register("with", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe static DrawableTransitionOptions With(ITransitionFactory transitionFactory)
		{
			DrawableTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transitionFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)transitionFactory).Handle);
				@object = Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.StaticMethods.InvokeObjectMethod("with.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transitionFactory);
			}
			return @object;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00025D84 File Offset: 0x00023F84
		[Register("withCrossFade", "()Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public static DrawableTransitionOptions WithCrossFade()
		{
			return Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.()Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00025DB8 File Offset: 0x00023FB8
		[Register("withCrossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe static DrawableTransitionOptions WithCrossFade(DrawableCrossFadeFactory drawableCrossFadeFactory)
		{
			DrawableTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : drawableCrossFadeFactory.Handle);
				@object = Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00025E2C File Offset: 0x0002402C
		[Register("withCrossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe static DrawableTransitionOptions WithCrossFade(DrawableCrossFadeFactory.Builder builder)
		{
			DrawableTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				@object = Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
			return @object;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00025EA0 File Offset: 0x000240A0
		[Register("withCrossFade", "(I)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", "")]
		public unsafe static DrawableTransitionOptions WithCrossFade(int duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<DrawableTransitionOptions>(DrawableTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(I)Lcom/bumptech/glide/load/resource/drawable/DrawableTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002EE RID: 750
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/DrawableTransitionOptions", typeof(DrawableTransitionOptions));
	}
}
