using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views.Animations;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000BC RID: 188
	[Register("androidx/core/view/ViewPropertyAnimatorCompat", DoNotGenerateAcw = true)]
	public sealed class ViewPropertyAnimatorCompat : Java.Lang.Object
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00020170 File Offset: 0x0001E370
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPropertyAnimatorCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00020194 File Offset: 0x0001E394
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPropertyAnimatorCompat._members;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0002019C File Offset: 0x0001E39C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPropertyAnimatorCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000201C0 File Offset: 0x0001E3C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPropertyAnimatorCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00002384 File Offset: 0x00000584
		internal ViewPropertyAnimatorCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000201CC File Offset: 0x0001E3CC
		public long Duration
		{
			[Register("getDuration", "()J", "")]
			get
			{
				return ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractInt64Method("getDuration.()J", this, null);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000201E8 File Offset: 0x0001E3E8
		public IInterpolator Interpolator
		{
			[Register("getInterpolator", "()Landroid/view/animation/Interpolator;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IInterpolator>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getInterpolator.()Landroid/view/animation/Interpolator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002021A File Offset: 0x0001E41A
		public long StartDelay
		{
			[Register("getStartDelay", "()J", "")]
			get
			{
				return ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractInt64Method("getStartDelay.()J", this, null);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00020234 File Offset: 0x0001E434
		[Register("alpha", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat Alpha(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("alpha.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00020280 File Offset: 0x0001E480
		[Register("alphaBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat AlphaBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("alphaBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000202C9 File Offset: 0x0001E4C9
		[Register("cancel", "()V", "")]
		public void Cancel()
		{
			ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000202E4 File Offset: 0x0001E4E4
		[Register("rotation", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat Rotation(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotation.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00020330 File Offset: 0x0001E530
		[Register("rotationBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat RotationBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotationBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002037C File Offset: 0x0001E57C
		[Register("rotationX", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat RotationX(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotationX.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000203C8 File Offset: 0x0001E5C8
		[Register("rotationXBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat RotationXBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotationXBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00020414 File Offset: 0x0001E614
		[Register("rotationY", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat RotationY(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotationY.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00020460 File Offset: 0x0001E660
		[Register("rotationYBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat RotationYBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("rotationYBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000204AC File Offset: 0x0001E6AC
		[Register("scaleX", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat ScaleX(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("scaleX.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000204F8 File Offset: 0x0001E6F8
		[Register("scaleXBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat ScaleXBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("scaleXBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00020544 File Offset: 0x0001E744
		[Register("scaleY", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat ScaleY(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("scaleY.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00020590 File Offset: 0x0001E790
		[Register("scaleYBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat ScaleYBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("scaleYBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000205DC File Offset: 0x0001E7DC
		[Register("setDuration", "(J)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat SetDuration(long value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("setDuration.(J)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00020628 File Offset: 0x0001E828
		[Register("setInterpolator", "(Landroid/view/animation/Interpolator;)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat SetInterpolator(IInterpolator value)
		{
			ViewPropertyAnimatorCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
				@object = Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("setInterpolator.(Landroid/view/animation/Interpolator;)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000206A0 File Offset: 0x0001E8A0
		[Register("setListener", "(Landroidx/core/view/ViewPropertyAnimatorListener;)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat SetListener(IViewPropertyAnimatorListener listener)
		{
			ViewPropertyAnimatorCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("setListener.(Landroidx/core/view/ViewPropertyAnimatorListener;)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00020718 File Offset: 0x0001E918
		[Register("setStartDelay", "(J)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat SetStartDelay(long value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("setStartDelay.(J)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00020764 File Offset: 0x0001E964
		[Register("setUpdateListener", "(Landroidx/core/view/ViewPropertyAnimatorUpdateListener;)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat SetUpdateListener(IViewPropertyAnimatorUpdateListener listener)
		{
			ViewPropertyAnimatorCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("setUpdateListener.(Landroidx/core/view/ViewPropertyAnimatorUpdateListener;)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000207DC File Offset: 0x0001E9DC
		[Register("start", "()V", "")]
		public void Start()
		{
			ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractVoidMethod("start.()V", this, null);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000207F8 File Offset: 0x0001E9F8
		[Register("translationX", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationX(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationX.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00020844 File Offset: 0x0001EA44
		[Register("translationXBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationXBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationXBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00020890 File Offset: 0x0001EA90
		[Register("translationY", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationY(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationY.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000208DC File Offset: 0x0001EADC
		[Register("translationYBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationYBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationYBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00020928 File Offset: 0x0001EB28
		[Register("translationZ", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationZ(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationZ.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00020974 File Offset: 0x0001EB74
		[Register("translationZBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat TranslationZBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("translationZBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000209C0 File Offset: 0x0001EBC0
		[Register("withEndAction", "(Ljava/lang/Runnable;)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat WithEndAction(IRunnable runnable)
		{
			ViewPropertyAnimatorCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				@object = Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("withEndAction.(Ljava/lang/Runnable;)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
			return @object;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00020A38 File Offset: 0x0001EC38
		[Register("withLayer", "()Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public ViewPropertyAnimatorCompat WithLayer()
		{
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("withLayer.()Landroidx/core/view/ViewPropertyAnimatorCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00020A6C File Offset: 0x0001EC6C
		[Register("withStartAction", "(Ljava/lang/Runnable;)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat WithStartAction(IRunnable runnable)
		{
			ViewPropertyAnimatorCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((runnable == null) ? IntPtr.Zero : ((Java.Lang.Object)runnable).Handle);
				@object = Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("withStartAction.(Ljava/lang/Runnable;)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(runnable);
			}
			return @object;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00020AE4 File Offset: 0x0001ECE4
		[Register("x", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat X(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("x.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00020B30 File Offset: 0x0001ED30
		[Register("xBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat XBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("xBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00020B7C File Offset: 0x0001ED7C
		[Register("y", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat Y(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("y.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		[Register("yBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat YBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("yBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00020C14 File Offset: 0x0001EE14
		[Register("z", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat Z(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("z.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00020C60 File Offset: 0x0001EE60
		[Register("zBy", "(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", "")]
		public unsafe ViewPropertyAnimatorCompat ZBy(float value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<ViewPropertyAnimatorCompat>(ViewPropertyAnimatorCompat._members.InstanceMethods.InvokeAbstractObjectMethod("zBy.(F)Landroidx/core/view/ViewPropertyAnimatorCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000328 RID: 808
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ViewPropertyAnimatorCompat", typeof(ViewPropertyAnimatorCompat));
	}
}
