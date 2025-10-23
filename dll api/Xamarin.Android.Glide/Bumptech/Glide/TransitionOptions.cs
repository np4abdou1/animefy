using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Request.Transition;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide
{
	// Token: 0x02000042 RID: 66
	[Register("com/bumptech/glide/TransitionOptions", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"CHILD extends com.bumptech.glide.TransitionOptions<CHILD, TranscodeType>",
		"TranscodeType"
	})]
	public abstract class TransitionOptions : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000A240 File Offset: 0x00008440
		internal static IntPtr class_ref
		{
			get
			{
				return TransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000A264 File Offset: 0x00008464
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransitionOptions._members;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000A26C File Offset: 0x0000846C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransitionOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000A290 File Offset: 0x00008490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransitionOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000A29C File Offset: 0x0000849C
		protected TransitionOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Register(".ctor", "()V", "")]
		public TransitionOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TransitionOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TransitionOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000A318 File Offset: 0x00008518
		[Register("clone", "()Lcom/bumptech/glide/TransitionOptions;", "")]
		public Java.Lang.Object Clone()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TransitionOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("clone.()Lcom/bumptech/glide/TransitionOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000A34C File Offset: 0x0000854C
		[Register("dontTransition", "()Lcom/bumptech/glide/TransitionOptions;", "")]
		public Java.Lang.Object DontTransition()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TransitionOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("dontTransition.()Lcom/bumptech/glide/TransitionOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000A380 File Offset: 0x00008580
		[Register("transition", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/TransitionOptions;", "")]
		public unsafe Java.Lang.Object Transition(ITransitionFactory transitionFactory)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transitionFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)transitionFactory).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TransitionOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("transition.(Lcom/bumptech/glide/request/transition/TransitionFactory;)Lcom/bumptech/glide/TransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transitionFactory);
			}
			return @object;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Register("transition", "(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)Lcom/bumptech/glide/TransitionOptions;", "")]
		public unsafe Java.Lang.Object Transition(ViewPropertyTransition.IAnimator animator)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : ((Java.Lang.Object)animator).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(TransitionOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("transition.(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)Lcom/bumptech/glide/TransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
			return @object;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000A470 File Offset: 0x00008670
		[Register("transition", "(I)Lcom/bumptech/glide/TransitionOptions;", "")]
		public unsafe Java.Lang.Object Transition(int viewAnimationId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(viewAnimationId);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(TransitionOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("transition.(I)Lcom/bumptech/glide/TransitionOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000A2 RID: 162
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/TransitionOptions", typeof(TransitionOptions));
	}
}
