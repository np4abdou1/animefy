using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bitmap
{
	// Token: 0x02000103 RID: 259
	[Register("com/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions", DoNotGenerateAcw = true)]
	public sealed class BitmapTransitionOptions : TransitionOptions
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00028A58 File Offset: 0x00026C58
		internal new static IntPtr class_ref
		{
			get
			{
				return BitmapTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00028A7C File Offset: 0x00026C7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapTransitionOptions._members;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00028A84 File Offset: 0x00026C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00028AA8 File Offset: 0x00026CA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapTransitionOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00028AB4 File Offset: 0x00026CB4
		internal BitmapTransitionOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00028AC0 File Offset: 0x00026CC0
		[Register(".ctor", "()V", "")]
		public BitmapTransitionOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BitmapTransitionOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BitmapTransitionOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00028B30 File Offset: 0x00026D30
		[Register("crossFade", "()Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public BitmapTransitionOptions CrossFade()
		{
			return Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.()Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00028B64 File Offset: 0x00026D64
		[Register("crossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe BitmapTransitionOptions CrossFade(DrawableCrossFadeFactory drawableCrossFadeFactory)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : drawableCrossFadeFactory.Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00028BD8 File Offset: 0x00026DD8
		[Register("crossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe BitmapTransitionOptions CrossFade(DrawableCrossFadeFactory.Builder builder)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
			return @object;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00028C4C File Offset: 0x00026E4C
		[Register("crossFade", "(I)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe BitmapTransitionOptions CrossFade(int duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("crossFade.(I)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00028C98 File Offset: 0x00026E98
		[Register("transitionUsing", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe BitmapTransitionOptions TransitionUsing(ITransitionFactory drawableCrossFadeFactory)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)drawableCrossFadeFactory).Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.InstanceMethods.InvokeAbstractObjectMethod("transitionUsing.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00028D10 File Offset: 0x00026F10
		[Register("with", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe static BitmapTransitionOptions With(ITransitionFactory transitionFactory)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transitionFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)transitionFactory).Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("with.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transitionFactory);
			}
			return @object;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00028D88 File Offset: 0x00026F88
		[Register("withCrossFade", "()Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public static BitmapTransitionOptions WithCrossFade()
		{
			return Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.()Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00028DBC File Offset: 0x00026FBC
		[Register("withCrossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe static BitmapTransitionOptions WithCrossFade(DrawableCrossFadeFactory drawableCrossFadeFactory)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : drawableCrossFadeFactory.Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00028E30 File Offset: 0x00027030
		[Register("withCrossFade", "(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe static BitmapTransitionOptions WithCrossFade(DrawableCrossFadeFactory.Builder builder)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
			}
			return @object;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00028EA4 File Offset: 0x000270A4
		[Register("withCrossFade", "(I)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe static BitmapTransitionOptions WithCrossFade(int duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("withCrossFade.(I)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00028EEC File Offset: 0x000270EC
		[Register("withWrapped", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", "")]
		public unsafe static BitmapTransitionOptions WithWrapped(ITransitionFactory drawableCrossFadeFactory)
		{
			BitmapTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawableCrossFadeFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)drawableCrossFadeFactory).Handle);
				@object = Java.Lang.Object.GetObject<BitmapTransitionOptions>(BitmapTransitionOptions._members.StaticMethods.InvokeObjectMethod("withWrapped.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawableCrossFadeFactory);
			}
			return @object;
		}

		// Token: 0x0400031B RID: 795
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions", typeof(BitmapTransitionOptions));
	}
}
