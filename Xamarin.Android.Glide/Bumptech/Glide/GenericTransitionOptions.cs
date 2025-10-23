using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000038 RID: 56
	[Register("com/bumptech/glide/GenericTransitionOptions", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"TranscodeType"
	})]
	public sealed class GenericTransitionOptions : TransitionOptions
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00004B40 File Offset: 0x00002D40
		internal new static IntPtr class_ref
		{
			get
			{
				return GenericTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00004B64 File Offset: 0x00002D64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GenericTransitionOptions._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00004B6C File Offset: 0x00002D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GenericTransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00004B90 File Offset: 0x00002D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GenericTransitionOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004B9C File Offset: 0x00002D9C
		internal GenericTransitionOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Register(".ctor", "()V", "")]
		public GenericTransitionOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GenericTransitionOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GenericTransitionOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004C18 File Offset: 0x00002E18
		[Register("with", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/GenericTransitionOptions;", "")]
		[JavaTypeParameters(new string[]
		{
			"TranscodeType"
		})]
		public unsafe static GenericTransitionOptions With(ITransitionFactory transitionFactory)
		{
			GenericTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transitionFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)transitionFactory).Handle);
				@object = Java.Lang.Object.GetObject<GenericTransitionOptions>(GenericTransitionOptions._members.StaticMethods.InvokeObjectMethod("with.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/GenericTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transitionFactory);
			}
			return @object;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004C90 File Offset: 0x00002E90
		[Register("with", "(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)Lcom/bumptech/glide/GenericTransitionOptions;", "")]
		[JavaTypeParameters(new string[]
		{
			"TranscodeType"
		})]
		public unsafe static GenericTransitionOptions With(ViewPropertyTransition.IAnimator animator)
		{
			GenericTransitionOptions @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : ((Java.Lang.Object)animator).Handle);
				@object = Java.Lang.Object.GetObject<GenericTransitionOptions>(GenericTransitionOptions._members.StaticMethods.InvokeObjectMethod("with.(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)Lcom/bumptech/glide/GenericTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
			return @object;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00004D08 File Offset: 0x00002F08
		[Register("with", "(I)Lcom/bumptech/glide/GenericTransitionOptions;", "")]
		[JavaTypeParameters(new string[]
		{
			"TranscodeType"
		})]
		public unsafe static GenericTransitionOptions With(int viewAnimationId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(viewAnimationId);
			return Java.Lang.Object.GetObject<GenericTransitionOptions>(GenericTransitionOptions._members.StaticMethods.InvokeObjectMethod("with.(I)Lcom/bumptech/glide/GenericTransitionOptions;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004D50 File Offset: 0x00002F50
		[Register("withNoTransition", "()Lcom/bumptech/glide/GenericTransitionOptions;", "")]
		[JavaTypeParameters(new string[]
		{
			"TranscodeType"
		})]
		public static GenericTransitionOptions WithNoTransition()
		{
			return Java.Lang.Object.GetObject<GenericTransitionOptions>(GenericTransitionOptions._members.StaticMethods.InvokeObjectMethod("withNoTransition.()Lcom/bumptech/glide/GenericTransitionOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/GenericTransitionOptions", typeof(GenericTransitionOptions));
	}
}
