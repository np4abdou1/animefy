using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000003 RID: 3
	[Register("com/warkiz/widget/Builder", DoNotGenerateAcw = true)]
	public class Builder : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002314 File Offset: 0x00000514
		internal static IntPtr class_ref
		{
			get
			{
				return Builder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002338 File Offset: 0x00000538
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Builder._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002340 File Offset: 0x00000540
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Builder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002364 File Offset: 0x00000564
		protected override Type ThresholdType
		{
			get
			{
				return Builder._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002370 File Offset: 0x00000570
		protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000237A File Offset: 0x0000057A
		private static Delegate GetBuildHandler()
		{
			if (Builder.cb_build == null)
			{
				Builder.cb_build = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(Builder.n_Build));
			}
			return Builder.cb_build;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000239E File Offset: 0x0000059E
		private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023B4 File Offset: 0x000005B4
		[Register("build", "()Lcom/warkiz/widget/IndicatorSeekBar;", "GetBuildHandler")]
		public virtual IndicatorSeekBar Build()
		{
			return Java.Lang.Object.GetObject<IndicatorSeekBar>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/warkiz/widget/IndicatorSeekBar;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023E6 File Offset: 0x000005E6
		private static Delegate GetClearPadding_ZHandler()
		{
			if (Builder.cb_clearPadding_Z == null)
			{
				Builder.cb_clearPadding_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_ClearPadding_Z));
			}
			return Builder.cb_clearPadding_Z;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000240A File Offset: 0x0000060A
		private static IntPtr n_ClearPadding_Z(IntPtr jnienv, IntPtr native__this, bool clearPadding)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearPadding(clearPadding));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002420 File Offset: 0x00000620
		[Register("clearPadding", "(Z)Lcom/warkiz/widget/Builder;", "GetClearPadding_ZHandler")]
		public unsafe virtual Builder ClearPadding(bool clearPadding)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(clearPadding);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("clearPadding.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002469 File Offset: 0x00000669
		private static Delegate GetIndicatorColor_IHandler()
		{
			if (Builder.cb_indicatorColor_I == null)
			{
				Builder.cb_indicatorColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_IndicatorColor_I));
			}
			return Builder.cb_indicatorColor_I;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000248D File Offset: 0x0000068D
		private static IntPtr n_IndicatorColor_I(IntPtr jnienv, IntPtr native__this, int indicatorColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IndicatorColor(indicatorColor));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024A4 File Offset: 0x000006A4
		[Register("indicatorColor", "(I)Lcom/warkiz/widget/Builder;", "GetIndicatorColor_IHandler")]
		public unsafe virtual Builder IndicatorColor(int indicatorColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(indicatorColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024ED File Offset: 0x000006ED
		private static Delegate GetIndicatorContentView_Landroid_view_View_Handler()
		{
			if (Builder.cb_indicatorContentView_Landroid_view_View_ == null)
			{
				Builder.cb_indicatorContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_IndicatorContentView_Landroid_view_View_));
			}
			return Builder.cb_indicatorContentView_Landroid_view_View_;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002514 File Offset: 0x00000714
		private static IntPtr n_IndicatorContentView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_indicatorContentView)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_indicatorContentView, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.IndicatorContentView(object2));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000253C File Offset: 0x0000073C
		[Register("indicatorContentView", "(Landroid/view/View;)Lcom/warkiz/widget/Builder;", "GetIndicatorContentView_Landroid_view_View_Handler")]
		public unsafe virtual Builder IndicatorContentView(View indicatorContentView)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((indicatorContentView == null) ? IntPtr.Zero : indicatorContentView.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorContentView.(Landroid/view/View;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(indicatorContentView);
			return @object;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000259A File Offset: 0x0000079A
		private static Delegate GetIndicatorContentViewLayoutId_IHandler()
		{
			if (Builder.cb_indicatorContentViewLayoutId_I == null)
			{
				Builder.cb_indicatorContentViewLayoutId_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_IndicatorContentViewLayoutId_I));
			}
			return Builder.cb_indicatorContentViewLayoutId_I;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025BE File Offset: 0x000007BE
		private static IntPtr n_IndicatorContentViewLayoutId_I(IntPtr jnienv, IntPtr native__this, int layoutId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IndicatorContentViewLayoutId(layoutId));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025D4 File Offset: 0x000007D4
		[Register("indicatorContentViewLayoutId", "(I)Lcom/warkiz/widget/Builder;", "GetIndicatorContentViewLayoutId_IHandler")]
		public unsafe virtual Builder IndicatorContentViewLayoutId(int layoutId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(layoutId);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorContentViewLayoutId.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000261D File Offset: 0x0000081D
		private static Delegate GetIndicatorTextColor_IHandler()
		{
			if (Builder.cb_indicatorTextColor_I == null)
			{
				Builder.cb_indicatorTextColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_IndicatorTextColor_I));
			}
			return Builder.cb_indicatorTextColor_I;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002641 File Offset: 0x00000841
		private static IntPtr n_IndicatorTextColor_I(IntPtr jnienv, IntPtr native__this, int indicatorTextColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IndicatorTextColor(indicatorTextColor));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002658 File Offset: 0x00000858
		[Register("indicatorTextColor", "(I)Lcom/warkiz/widget/Builder;", "GetIndicatorTextColor_IHandler")]
		public unsafe virtual Builder IndicatorTextColor(int indicatorTextColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(indicatorTextColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorTextColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026A1 File Offset: 0x000008A1
		private static Delegate GetIndicatorTextSize_IHandler()
		{
			if (Builder.cb_indicatorTextSize_I == null)
			{
				Builder.cb_indicatorTextSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_IndicatorTextSize_I));
			}
			return Builder.cb_indicatorTextSize_I;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026C5 File Offset: 0x000008C5
		private static IntPtr n_IndicatorTextSize_I(IntPtr jnienv, IntPtr native__this, int indicatorTextSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IndicatorTextSize(indicatorTextSize));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026DC File Offset: 0x000008DC
		[Register("indicatorTextSize", "(I)Lcom/warkiz/widget/Builder;", "GetIndicatorTextSize_IHandler")]
		public unsafe virtual Builder IndicatorTextSize(int indicatorTextSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(indicatorTextSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorTextSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002725 File Offset: 0x00000925
		private static Delegate GetIndicatorTopContentView_Landroid_view_View_Handler()
		{
			if (Builder.cb_indicatorTopContentView_Landroid_view_View_ == null)
			{
				Builder.cb_indicatorTopContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_IndicatorTopContentView_Landroid_view_View_));
			}
			return Builder.cb_indicatorTopContentView_Landroid_view_View_;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000274C File Offset: 0x0000094C
		private static IntPtr n_IndicatorTopContentView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_topContentView)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_topContentView, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.IndicatorTopContentView(object2));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002774 File Offset: 0x00000974
		[Register("indicatorTopContentView", "(Landroid/view/View;)Lcom/warkiz/widget/Builder;", "GetIndicatorTopContentView_Landroid_view_View_Handler")]
		public unsafe virtual Builder IndicatorTopContentView(View topContentView)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((topContentView == null) ? IntPtr.Zero : topContentView.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorTopContentView.(Landroid/view/View;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(topContentView);
			return @object;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027D2 File Offset: 0x000009D2
		private static Delegate GetIndicatorTopContentViewLayoutId_IHandler()
		{
			if (Builder.cb_indicatorTopContentViewLayoutId_I == null)
			{
				Builder.cb_indicatorTopContentViewLayoutId_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_IndicatorTopContentViewLayoutId_I));
			}
			return Builder.cb_indicatorTopContentViewLayoutId_I;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027F6 File Offset: 0x000009F6
		private static IntPtr n_IndicatorTopContentViewLayoutId_I(IntPtr jnienv, IntPtr native__this, int layoutId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IndicatorTopContentViewLayoutId(layoutId));
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000280C File Offset: 0x00000A0C
		[Register("indicatorTopContentViewLayoutId", "(I)Lcom/warkiz/widget/Builder;", "GetIndicatorTopContentViewLayoutId_IHandler")]
		public unsafe virtual Builder IndicatorTopContentViewLayoutId(int layoutId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(layoutId);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("indicatorTopContentViewLayoutId.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002855 File Offset: 0x00000A55
		private static Delegate GetMax_FHandler()
		{
			if (Builder.cb_max_F == null)
			{
				Builder.cb_max_F = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float, IntPtr>(Builder.n_Max_F));
			}
			return Builder.cb_max_F;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002879 File Offset: 0x00000A79
		private static IntPtr n_Max_F(IntPtr jnienv, IntPtr native__this, float max)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Max(max));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002890 File Offset: 0x00000A90
		[Register("max", "(F)Lcom/warkiz/widget/Builder;", "GetMax_FHandler")]
		public unsafe virtual Builder Max(float max)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(max);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("max.(F)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000028D9 File Offset: 0x00000AD9
		private static Delegate GetMin_FHandler()
		{
			if (Builder.cb_min_F == null)
			{
				Builder.cb_min_F = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float, IntPtr>(Builder.n_Min_F));
			}
			return Builder.cb_min_F;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028FD File Offset: 0x00000AFD
		private static IntPtr n_Min_F(IntPtr jnienv, IntPtr native__this, float min)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Min(min));
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002914 File Offset: 0x00000B14
		[Register("min", "(F)Lcom/warkiz/widget/Builder;", "GetMin_FHandler")]
		public unsafe virtual Builder Min(float min)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(min);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("min.(F)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000295D File Offset: 0x00000B5D
		private static Delegate GetOnlyThumbDraggable_ZHandler()
		{
			if (Builder.cb_onlyThumbDraggable_Z == null)
			{
				Builder.cb_onlyThumbDraggable_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_OnlyThumbDraggable_Z));
			}
			return Builder.cb_onlyThumbDraggable_Z;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002981 File Offset: 0x00000B81
		private static IntPtr n_OnlyThumbDraggable_Z(IntPtr jnienv, IntPtr native__this, bool onlyThumbDraggable)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnlyThumbDraggable(onlyThumbDraggable));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002998 File Offset: 0x00000B98
		[Register("onlyThumbDraggable", "(Z)Lcom/warkiz/widget/Builder;", "GetOnlyThumbDraggable_ZHandler")]
		public unsafe virtual Builder OnlyThumbDraggable(bool onlyThumbDraggable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(onlyThumbDraggable);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("onlyThumbDraggable.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029E1 File Offset: 0x00000BE1
		private static Delegate GetProgress_FHandler()
		{
			if (Builder.cb_progress_F == null)
			{
				Builder.cb_progress_F = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, float, IntPtr>(Builder.n_Progress_F));
			}
			return Builder.cb_progress_F;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002A05 File Offset: 0x00000C05
		private static IntPtr n_Progress_F(IntPtr jnienv, IntPtr native__this, float progress)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Progress(progress));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A1C File Offset: 0x00000C1C
		[Register("progress", "(F)Lcom/warkiz/widget/Builder;", "GetProgress_FHandler")]
		public unsafe virtual Builder Progress(float progress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(progress);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("progress.(F)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A65 File Offset: 0x00000C65
		private static Delegate GetProgressValueFloat_ZHandler()
		{
			if (Builder.cb_progressValueFloat_Z == null)
			{
				Builder.cb_progressValueFloat_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_ProgressValueFloat_Z));
			}
			return Builder.cb_progressValueFloat_Z;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A89 File Offset: 0x00000C89
		private static IntPtr n_ProgressValueFloat_Z(IntPtr jnienv, IntPtr native__this, bool isFloatProgress)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProgressValueFloat(isFloatProgress));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[Register("progressValueFloat", "(Z)Lcom/warkiz/widget/Builder;", "GetProgressValueFloat_ZHandler")]
		public unsafe virtual Builder ProgressValueFloat(bool isFloatProgress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isFloatProgress);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("progressValueFloat.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002AE9 File Offset: 0x00000CE9
		private static Delegate GetR2L_ZHandler()
		{
			if (Builder.cb_r2l_Z == null)
			{
				Builder.cb_r2l_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_R2L_Z));
			}
			return Builder.cb_r2l_Z;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B0D File Offset: 0x00000D0D
		private static IntPtr n_R2L_Z(IntPtr jnienv, IntPtr native__this, bool r2l)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).R2L(r2l));
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B24 File Offset: 0x00000D24
		[Register("r2l", "(Z)Lcom/warkiz/widget/Builder;", "GetR2L_ZHandler")]
		public unsafe virtual Builder R2L(bool r2l)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(r2l);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("r2l.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002B6D File Offset: 0x00000D6D
		private static Delegate GetSeekSmoothly_ZHandler()
		{
			if (Builder.cb_seekSmoothly_Z == null)
			{
				Builder.cb_seekSmoothly_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_SeekSmoothly_Z));
			}
			return Builder.cb_seekSmoothly_Z;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002B91 File Offset: 0x00000D91
		private static IntPtr n_SeekSmoothly_Z(IntPtr jnienv, IntPtr native__this, bool seekSmoothly)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SeekSmoothly(seekSmoothly));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002BA8 File Offset: 0x00000DA8
		[Register("seekSmoothly", "(Z)Lcom/warkiz/widget/Builder;", "GetSeekSmoothly_ZHandler")]
		public unsafe virtual Builder SeekSmoothly(bool seekSmoothly)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(seekSmoothly);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("seekSmoothly.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002BF1 File Offset: 0x00000DF1
		private static Delegate GetShowIndicatorType_IHandler()
		{
			if (Builder.cb_showIndicatorType_I == null)
			{
				Builder.cb_showIndicatorType_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_ShowIndicatorType_I));
			}
			return Builder.cb_showIndicatorType_I;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C18 File Offset: 0x00000E18
		private static IntPtr n_ShowIndicatorType_I(IntPtr jnienv, IntPtr native__this, int native_showIndicatorType)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowIndicatorType((IndicatorTypes)native_showIndicatorType));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Register("showIndicatorType", "(I)Lcom/warkiz/widget/Builder;", "GetShowIndicatorType_IHandler")]
		public unsafe virtual Builder ShowIndicatorType([GeneratedEnum] IndicatorTypes showIndicatorType)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)showIndicatorType);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("showIndicatorType.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002C85 File Offset: 0x00000E85
		private static Delegate GetShowThumbText_ZHandler()
		{
			if (Builder.cb_showThumbText_Z == null)
			{
				Builder.cb_showThumbText_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_ShowThumbText_Z));
			}
			return Builder.cb_showThumbText_Z;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CA9 File Offset: 0x00000EA9
		private static IntPtr n_ShowThumbText_Z(IntPtr jnienv, IntPtr native__this, bool showThumbText)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowThumbText(showThumbText));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002CC0 File Offset: 0x00000EC0
		[Register("showThumbText", "(Z)Lcom/warkiz/widget/Builder;", "GetShowThumbText_ZHandler")]
		public unsafe virtual Builder ShowThumbText(bool showThumbText)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showThumbText);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("showThumbText.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002D09 File Offset: 0x00000F09
		private static Delegate GetShowTickMarksType_IHandler()
		{
			if (Builder.cb_showTickMarksType_I == null)
			{
				Builder.cb_showTickMarksType_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_ShowTickMarksType_I));
			}
			return Builder.cb_showTickMarksType_I;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002D30 File Offset: 0x00000F30
		private static IntPtr n_ShowTickMarksType_I(IntPtr jnienv, IntPtr native__this, int native_tickMarksType)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowTickMarksType((TickMarkTypes)native_tickMarksType));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002D54 File Offset: 0x00000F54
		[Register("showTickMarksType", "(I)Lcom/warkiz/widget/Builder;", "GetShowTickMarksType_IHandler")]
		public unsafe virtual Builder ShowTickMarksType([GeneratedEnum] TickMarkTypes tickMarksType)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)tickMarksType);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("showTickMarksType.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002D9D File Offset: 0x00000F9D
		private static Delegate GetShowTickTexts_ZHandler()
		{
			if (Builder.cb_showTickTexts_Z == null)
			{
				Builder.cb_showTickTexts_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_ShowTickTexts_Z));
			}
			return Builder.cb_showTickTexts_Z;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002DC1 File Offset: 0x00000FC1
		private static IntPtr n_ShowTickTexts_Z(IntPtr jnienv, IntPtr native__this, bool showTickText)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowTickTexts(showTickText));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Register("showTickTexts", "(Z)Lcom/warkiz/widget/Builder;", "GetShowTickTexts_ZHandler")]
		public unsafe virtual Builder ShowTickTexts(bool showTickText)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showTickText);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("showTickTexts.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002E21 File Offset: 0x00001021
		private static Delegate GetThumbColor_IHandler()
		{
			if (Builder.cb_thumbColor_I == null)
			{
				Builder.cb_thumbColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_ThumbColor_I));
			}
			return Builder.cb_thumbColor_I;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E45 File Offset: 0x00001045
		private static IntPtr n_ThumbColor_I(IntPtr jnienv, IntPtr native__this, int thumbColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbColor(thumbColor));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E5C File Offset: 0x0000105C
		[Register("thumbColor", "(I)Lcom/warkiz/widget/Builder;", "GetThumbColor_IHandler")]
		public unsafe virtual Builder ThumbColor(int thumbColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thumbColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002EA5 File Offset: 0x000010A5
		private static Delegate GetThumbColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (Builder.cb_thumbColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				Builder.cb_thumbColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_ThumbColorStateList_Landroid_content_res_ColorStateList_));
			}
			return Builder.cb_thumbColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002ECC File Offset: 0x000010CC
		private static IntPtr n_ThumbColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbColorStateList)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_thumbColorStateList, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThumbColorStateList(object2));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Register("thumbColorStateList", "(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", "GetThumbColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Builder ThumbColorStateList(ColorStateList thumbColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((thumbColorStateList == null) ? IntPtr.Zero : thumbColorStateList.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbColorStateList.(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(thumbColorStateList);
			return @object;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F52 File Offset: 0x00001152
		private static Delegate GetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Builder.cb_thumbDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				Builder.cb_thumbDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_ThumbDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return Builder.cb_thumbDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002F78 File Offset: 0x00001178
		private static IntPtr n_ThumbDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbDrawable)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_thumbDrawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThumbDrawable(object2));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Register("thumbDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/warkiz/widget/Builder;", "GetThumbDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual Builder ThumbDrawable(Drawable thumbDrawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((thumbDrawable == null) ? IntPtr.Zero : thumbDrawable.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(thumbDrawable);
			return @object;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002FFE File Offset: 0x000011FE
		private static Delegate GetThumbDrawable_Landroid_graphics_drawable_StateListDrawable_Handler()
		{
			if (Builder.cb_thumbDrawable_Landroid_graphics_drawable_StateListDrawable_ == null)
			{
				Builder.cb_thumbDrawable_Landroid_graphics_drawable_StateListDrawable_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_ThumbDrawable_Landroid_graphics_drawable_StateListDrawable_));
			}
			return Builder.cb_thumbDrawable_Landroid_graphics_drawable_StateListDrawable_;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003024 File Offset: 0x00001224
		private static IntPtr n_ThumbDrawable_Landroid_graphics_drawable_StateListDrawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_thumbStateListDrawable)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			StateListDrawable object2 = Java.Lang.Object.GetObject<StateListDrawable>(native_thumbStateListDrawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ThumbDrawable(object2));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000304C File Offset: 0x0000124C
		[Register("thumbDrawable", "(Landroid/graphics/drawable/StateListDrawable;)Lcom/warkiz/widget/Builder;", "GetThumbDrawable_Landroid_graphics_drawable_StateListDrawable_Handler")]
		public unsafe virtual Builder ThumbDrawable(StateListDrawable thumbStateListDrawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((thumbStateListDrawable == null) ? IntPtr.Zero : thumbStateListDrawable.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbDrawable.(Landroid/graphics/drawable/StateListDrawable;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(thumbStateListDrawable);
			return @object;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000030AA File Offset: 0x000012AA
		private static Delegate GetThumbSize_IHandler()
		{
			if (Builder.cb_thumbSize_I == null)
			{
				Builder.cb_thumbSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_ThumbSize_I));
			}
			return Builder.cb_thumbSize_I;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000030CE File Offset: 0x000012CE
		private static IntPtr n_ThumbSize_I(IntPtr jnienv, IntPtr native__this, int thumbSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbSize(thumbSize));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000030E4 File Offset: 0x000012E4
		[Register("thumbSize", "(I)Lcom/warkiz/widget/Builder;", "GetThumbSize_IHandler")]
		public unsafe virtual Builder ThumbSize(int thumbSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thumbSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000312D File Offset: 0x0000132D
		private static Delegate GetThumbTextColor_IHandler()
		{
			if (Builder.cb_thumbTextColor_I == null)
			{
				Builder.cb_thumbTextColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_ThumbTextColor_I));
			}
			return Builder.cb_thumbTextColor_I;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003151 File Offset: 0x00001351
		private static IntPtr n_ThumbTextColor_I(IntPtr jnienv, IntPtr native__this, int thumbTextColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThumbTextColor(thumbTextColor));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003168 File Offset: 0x00001368
		[Register("thumbTextColor", "(I)Lcom/warkiz/widget/Builder;", "GetThumbTextColor_IHandler")]
		public unsafe virtual Builder ThumbTextColor(int thumbTextColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(thumbTextColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("thumbTextColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000031B1 File Offset: 0x000013B1
		private static Delegate GetTickCount_IHandler()
		{
			if (Builder.cb_tickCount_I == null)
			{
				Builder.cb_tickCount_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickCount_I));
			}
			return Builder.cb_tickCount_I;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000031D5 File Offset: 0x000013D5
		private static IntPtr n_TickCount_I(IntPtr jnienv, IntPtr native__this, int tickCount)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickCount(tickCount));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000031EC File Offset: 0x000013EC
		[Register("tickCount", "(I)Lcom/warkiz/widget/Builder;", "GetTickCount_IHandler")]
		public unsafe virtual Builder TickCount(int tickCount)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickCount);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickCount.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003235 File Offset: 0x00001435
		private static Delegate GetTickMarksColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (Builder.cb_tickMarksColor_Landroid_content_res_ColorStateList_ == null)
			{
				Builder.cb_tickMarksColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickMarksColor_Landroid_content_res_ColorStateList_));
			}
			return Builder.cb_tickMarksColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000325C File Offset: 0x0000145C
		private static IntPtr n_TickMarksColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickMarksColorStateList)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tickMarksColorStateList, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TickMarksColor(object2));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003284 File Offset: 0x00001484
		[Register("tickMarksColor", "(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", "GetTickMarksColor_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Builder TickMarksColor(ColorStateList tickMarksColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickMarksColorStateList == null) ? IntPtr.Zero : tickMarksColorStateList.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksColor.(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(tickMarksColorStateList);
			return @object;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000032E2 File Offset: 0x000014E2
		private static Delegate GetTickMarksColor_IHandler()
		{
			if (Builder.cb_tickMarksColor_I == null)
			{
				Builder.cb_tickMarksColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickMarksColor_I));
			}
			return Builder.cb_tickMarksColor_I;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003306 File Offset: 0x00001506
		private static IntPtr n_TickMarksColor_I(IntPtr jnienv, IntPtr native__this, int tickMarksColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickMarksColor(tickMarksColor));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000331C File Offset: 0x0000151C
		[Register("tickMarksColor", "(I)Lcom/warkiz/widget/Builder;", "GetTickMarksColor_IHandler")]
		public unsafe virtual Builder TickMarksColor(int tickMarksColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickMarksColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003365 File Offset: 0x00001565
		private static Delegate GetTickMarksDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickMarksDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000338C File Offset: 0x0000158C
		private static IntPtr n_TickMarksDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickMarksDrawable)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_tickMarksDrawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TickMarksDrawable(object2));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000033B4 File Offset: 0x000015B4
		[Register("tickMarksDrawable", "(Landroid/graphics/drawable/Drawable;)Lcom/warkiz/widget/Builder;", "GetTickMarksDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual Builder TickMarksDrawable(Drawable tickMarksDrawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickMarksDrawable == null) ? IntPtr.Zero : tickMarksDrawable.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksDrawable.(Landroid/graphics/drawable/Drawable;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(tickMarksDrawable);
			return @object;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003412 File Offset: 0x00001612
		private static Delegate GetTickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_Handler()
		{
			if (Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_ == null)
			{
				Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_));
			}
			return Builder.cb_tickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003438 File Offset: 0x00001638
		private static IntPtr n_TickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickMarksStateListDrawable)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			StateListDrawable object2 = Java.Lang.Object.GetObject<StateListDrawable>(native_tickMarksStateListDrawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TickMarksDrawable(object2));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003460 File Offset: 0x00001660
		[Register("tickMarksDrawable", "(Landroid/graphics/drawable/StateListDrawable;)Lcom/warkiz/widget/Builder;", "GetTickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_Handler")]
		public unsafe virtual Builder TickMarksDrawable(StateListDrawable tickMarksStateListDrawable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickMarksStateListDrawable == null) ? IntPtr.Zero : tickMarksStateListDrawable.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksDrawable.(Landroid/graphics/drawable/StateListDrawable;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(tickMarksStateListDrawable);
			return @object;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000034BE File Offset: 0x000016BE
		private static Delegate GetTickMarksEndsHide_ZHandler()
		{
			if (Builder.cb_tickMarksEndsHide_Z == null)
			{
				Builder.cb_tickMarksEndsHide_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_TickMarksEndsHide_Z));
			}
			return Builder.cb_tickMarksEndsHide_Z;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000034E2 File Offset: 0x000016E2
		private static IntPtr n_TickMarksEndsHide_Z(IntPtr jnienv, IntPtr native__this, bool tickMarksEndsHide)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickMarksEndsHide(tickMarksEndsHide));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000034F8 File Offset: 0x000016F8
		[Register("tickMarksEndsHide", "(Z)Lcom/warkiz/widget/Builder;", "GetTickMarksEndsHide_ZHandler")]
		public unsafe virtual Builder TickMarksEndsHide(bool tickMarksEndsHide)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickMarksEndsHide);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksEndsHide.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003541 File Offset: 0x00001741
		private static Delegate GetTickMarksSize_IHandler()
		{
			if (Builder.cb_tickMarksSize_I == null)
			{
				Builder.cb_tickMarksSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickMarksSize_I));
			}
			return Builder.cb_tickMarksSize_I;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003565 File Offset: 0x00001765
		private static IntPtr n_TickMarksSize_I(IntPtr jnienv, IntPtr native__this, int tickMarksSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickMarksSize(tickMarksSize));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000357C File Offset: 0x0000177C
		[Register("tickMarksSize", "(I)Lcom/warkiz/widget/Builder;", "GetTickMarksSize_IHandler")]
		public unsafe virtual Builder TickMarksSize(int tickMarksSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickMarksSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000035C5 File Offset: 0x000017C5
		private static Delegate GetTickMarksSweptHide_ZHandler()
		{
			if (Builder.cb_tickMarksSweptHide_Z == null)
			{
				Builder.cb_tickMarksSweptHide_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_TickMarksSweptHide_Z));
			}
			return Builder.cb_tickMarksSweptHide_Z;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000035E9 File Offset: 0x000017E9
		private static IntPtr n_TickMarksSweptHide_Z(IntPtr jnienv, IntPtr native__this, bool tickMarksSweptHide)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickMarksSweptHide(tickMarksSweptHide));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003600 File Offset: 0x00001800
		[Register("tickMarksSweptHide", "(Z)Lcom/warkiz/widget/Builder;", "GetTickMarksSweptHide_ZHandler")]
		public unsafe virtual Builder TickMarksSweptHide(bool tickMarksSweptHide)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickMarksSweptHide);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickMarksSweptHide.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003649 File Offset: 0x00001849
		private static Delegate GetTickTextsArray_IHandler()
		{
			if (Builder.cb_tickTextsArray_I == null)
			{
				Builder.cb_tickTextsArray_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickTextsArray_I));
			}
			return Builder.cb_tickTextsArray_I;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000366D File Offset: 0x0000186D
		private static IntPtr n_TickTextsArray_I(IntPtr jnienv, IntPtr native__this, int tickTextsArray)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickTextsArray(tickTextsArray));
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003684 File Offset: 0x00001884
		[Register("tickTextsArray", "(I)Lcom/warkiz/widget/Builder;", "GetTickTextsArray_IHandler")]
		public unsafe virtual Builder TickTextsArray(int tickTextsArray)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickTextsArray);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsArray.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000036CD File Offset: 0x000018CD
		private static Delegate GetTickTextsArray_arrayLjava_lang_String_Handler()
		{
			if (Builder.cb_tickTextsArray_arrayLjava_lang_String_ == null)
			{
				Builder.cb_tickTextsArray_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickTextsArray_arrayLjava_lang_String_));
			}
			return Builder.cb_tickTextsArray_arrayLjava_lang_String_;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000036F4 File Offset: 0x000018F4
		private static IntPtr n_TickTextsArray_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickTextsArray)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_tickTextsArray, JniHandleOwnership.DoNotTransfer, typeof(string));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.TickTextsArray(array));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_tickTextsArray);
			}
			return result;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003738 File Offset: 0x00001938
		[Register("tickTextsArray", "([Ljava/lang/String;)Lcom/warkiz/widget/Builder;", "GetTickTextsArray_arrayLjava_lang_String_Handler")]
		public unsafe virtual Builder TickTextsArray(string[] tickTextsArray)
		{
			IntPtr intPtr = JNIEnv.NewArray(tickTextsArray);
			Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsArray.([Ljava/lang/String;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (tickTextsArray != null)
				{
					JNIEnv.CopyArray(intPtr, tickTextsArray);
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
			Builder result = @object;
			GC.KeepAlive(tickTextsArray);
			return result;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000037B4 File Offset: 0x000019B4
		private static Delegate GetTickTextsColor_IHandler()
		{
			if (Builder.cb_tickTextsColor_I == null)
			{
				Builder.cb_tickTextsColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickTextsColor_I));
			}
			return Builder.cb_tickTextsColor_I;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000037D8 File Offset: 0x000019D8
		private static IntPtr n_TickTextsColor_I(IntPtr jnienv, IntPtr native__this, int tickTextsColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickTextsColor(tickTextsColor));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000037F0 File Offset: 0x000019F0
		[Register("tickTextsColor", "(I)Lcom/warkiz/widget/Builder;", "GetTickTextsColor_IHandler")]
		public unsafe virtual Builder TickTextsColor(int tickTextsColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickTextsColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003839 File Offset: 0x00001A39
		private static Delegate GetTickTextsColorStateList_Landroid_content_res_ColorStateList_Handler()
		{
			if (Builder.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_ == null)
			{
				Builder.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickTextsColorStateList_Landroid_content_res_ColorStateList_));
			}
			return Builder.cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003860 File Offset: 0x00001A60
		private static IntPtr n_TickTextsColorStateList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickTextsColorStateList)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tickTextsColorStateList, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TickTextsColorStateList(object2));
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003888 File Offset: 0x00001A88
		[Register("tickTextsColorStateList", "(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", "GetTickTextsColorStateList_Landroid_content_res_ColorStateList_Handler")]
		public unsafe virtual Builder TickTextsColorStateList(ColorStateList tickTextsColorStateList)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickTextsColorStateList == null) ? IntPtr.Zero : tickTextsColorStateList.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsColorStateList.(Landroid/content/res/ColorStateList;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(tickTextsColorStateList);
			return @object;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000038E6 File Offset: 0x00001AE6
		private static Delegate GetTickTextsSize_IHandler()
		{
			if (Builder.cb_tickTextsSize_I == null)
			{
				Builder.cb_tickTextsSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TickTextsSize_I));
			}
			return Builder.cb_tickTextsSize_I;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000390A File Offset: 0x00001B0A
		private static IntPtr n_TickTextsSize_I(IntPtr jnienv, IntPtr native__this, int tickTextsSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TickTextsSize(tickTextsSize));
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003920 File Offset: 0x00001B20
		[Register("tickTextsSize", "(I)Lcom/warkiz/widget/Builder;", "GetTickTextsSize_IHandler")]
		public unsafe virtual Builder TickTextsSize(int tickTextsSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tickTextsSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003969 File Offset: 0x00001B69
		private static Delegate GetTickTextsTypeFace_Landroid_graphics_Typeface_Handler()
		{
			if (Builder.cb_tickTextsTypeFace_Landroid_graphics_Typeface_ == null)
			{
				Builder.cb_tickTextsTypeFace_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(Builder.n_TickTextsTypeFace_Landroid_graphics_Typeface_));
			}
			return Builder.cb_tickTextsTypeFace_Landroid_graphics_Typeface_;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003990 File Offset: 0x00001B90
		private static IntPtr n_TickTextsTypeFace_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickTextsTypeFace)
		{
			Builder @object = Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Typeface object2 = Java.Lang.Object.GetObject<Typeface>(native_tickTextsTypeFace, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.TickTextsTypeFace(object2));
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000039B8 File Offset: 0x00001BB8
		[Register("tickTextsTypeFace", "(Landroid/graphics/Typeface;)Lcom/warkiz/widget/Builder;", "GetTickTextsTypeFace_Landroid_graphics_Typeface_Handler")]
		public unsafe virtual Builder TickTextsTypeFace(Typeface tickTextsTypeFace)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((tickTextsTypeFace == null) ? IntPtr.Zero : tickTextsTypeFace.Handle);
			Builder @object = Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("tickTextsTypeFace.(Landroid/graphics/Typeface;)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			GC.KeepAlive(tickTextsTypeFace);
			return @object;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003A16 File Offset: 0x00001C16
		private static Delegate GetTrackBackgroundColor_IHandler()
		{
			if (Builder.cb_trackBackgroundColor_I == null)
			{
				Builder.cb_trackBackgroundColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TrackBackgroundColor_I));
			}
			return Builder.cb_trackBackgroundColor_I;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003A3A File Offset: 0x00001C3A
		private static IntPtr n_TrackBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int trackBackgroundColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackBackgroundColor(trackBackgroundColor));
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003A50 File Offset: 0x00001C50
		[Register("trackBackgroundColor", "(I)Lcom/warkiz/widget/Builder;", "GetTrackBackgroundColor_IHandler")]
		public unsafe virtual Builder TrackBackgroundColor(int trackBackgroundColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(trackBackgroundColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("trackBackgroundColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003A99 File Offset: 0x00001C99
		private static Delegate GetTrackBackgroundSize_IHandler()
		{
			if (Builder.cb_trackBackgroundSize_I == null)
			{
				Builder.cb_trackBackgroundSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TrackBackgroundSize_I));
			}
			return Builder.cb_trackBackgroundSize_I;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003ABD File Offset: 0x00001CBD
		private static IntPtr n_TrackBackgroundSize_I(IntPtr jnienv, IntPtr native__this, int trackBackgroundSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackBackgroundSize(trackBackgroundSize));
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[Register("trackBackgroundSize", "(I)Lcom/warkiz/widget/Builder;", "GetTrackBackgroundSize_IHandler")]
		public unsafe virtual Builder TrackBackgroundSize(int trackBackgroundSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(trackBackgroundSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("trackBackgroundSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003B1D File Offset: 0x00001D1D
		private static Delegate GetTrackProgressColor_IHandler()
		{
			if (Builder.cb_trackProgressColor_I == null)
			{
				Builder.cb_trackProgressColor_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TrackProgressColor_I));
			}
			return Builder.cb_trackProgressColor_I;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003B41 File Offset: 0x00001D41
		private static IntPtr n_TrackProgressColor_I(IntPtr jnienv, IntPtr native__this, int trackProgressColor)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackProgressColor(trackProgressColor));
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003B58 File Offset: 0x00001D58
		[Register("trackProgressColor", "(I)Lcom/warkiz/widget/Builder;", "GetTrackProgressColor_IHandler")]
		public unsafe virtual Builder TrackProgressColor(int trackProgressColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(trackProgressColor);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("trackProgressColor.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003BA1 File Offset: 0x00001DA1
		private static Delegate GetTrackProgressSize_IHandler()
		{
			if (Builder.cb_trackProgressSize_I == null)
			{
				Builder.cb_trackProgressSize_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr>(Builder.n_TrackProgressSize_I));
			}
			return Builder.cb_trackProgressSize_I;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003BC5 File Offset: 0x00001DC5
		private static IntPtr n_TrackProgressSize_I(IntPtr jnienv, IntPtr native__this, int trackProgressSize)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackProgressSize(trackProgressSize));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003BDC File Offset: 0x00001DDC
		[Register("trackProgressSize", "(I)Lcom/warkiz/widget/Builder;", "GetTrackProgressSize_IHandler")]
		public unsafe virtual Builder TrackProgressSize(int trackProgressSize)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(trackProgressSize);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("trackProgressSize.(I)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003C25 File Offset: 0x00001E25
		private static Delegate GetTrackRoundedCorners_ZHandler()
		{
			if (Builder.cb_trackRoundedCorners_Z == null)
			{
				Builder.cb_trackRoundedCorners_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_TrackRoundedCorners_Z));
			}
			return Builder.cb_trackRoundedCorners_Z;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003C49 File Offset: 0x00001E49
		private static IntPtr n_TrackRoundedCorners_Z(IntPtr jnienv, IntPtr native__this, bool trackRoundedCorners)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TrackRoundedCorners(trackRoundedCorners));
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003C60 File Offset: 0x00001E60
		[Register("trackRoundedCorners", "(Z)Lcom/warkiz/widget/Builder;", "GetTrackRoundedCorners_ZHandler")]
		public unsafe virtual Builder TrackRoundedCorners(bool trackRoundedCorners)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(trackRoundedCorners);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("trackRoundedCorners.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003CA9 File Offset: 0x00001EA9
		private static Delegate GetUserSeekable_ZHandler()
		{
			if (Builder.cb_userSeekable_Z == null)
			{
				Builder.cb_userSeekable_Z = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool, IntPtr>(Builder.n_UserSeekable_Z));
			}
			return Builder.cb_userSeekable_Z;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003CCD File Offset: 0x00001ECD
		private static IntPtr n_UserSeekable_Z(IntPtr jnienv, IntPtr native__this, bool userSeekable)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserSeekable(userSeekable));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003CE4 File Offset: 0x00001EE4
		[Register("userSeekable", "(Z)Lcom/warkiz/widget/Builder;", "GetUserSeekable_ZHandler")]
		public unsafe virtual Builder UserSeekable(bool userSeekable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(userSeekable);
			return Java.Lang.Object.GetObject<Builder>(Builder._members.InstanceMethods.InvokeVirtualObjectMethod("userSeekable.(Z)Lcom/warkiz/widget/Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000002 RID: 2
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/Builder", typeof(Builder));

		// Token: 0x04000003 RID: 3
		private static Delegate cb_build;

		// Token: 0x04000004 RID: 4
		private static Delegate cb_clearPadding_Z;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_indicatorColor_I;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_indicatorContentView_Landroid_view_View_;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_indicatorContentViewLayoutId_I;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_indicatorTextColor_I;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_indicatorTextSize_I;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_indicatorTopContentView_Landroid_view_View_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_indicatorTopContentViewLayoutId_I;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_max_F;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_min_F;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_onlyThumbDraggable_Z;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_progress_F;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_progressValueFloat_Z;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_r2l_Z;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_seekSmoothly_Z;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_showIndicatorType_I;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_showThumbText_Z;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_showTickMarksType_I;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_showTickTexts_Z;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_thumbColor_I;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_thumbColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_thumbDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_thumbDrawable_Landroid_graphics_drawable_StateListDrawable_;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_thumbSize_I;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_thumbTextColor_I;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_tickCount_I;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_tickMarksColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_tickMarksColor_I;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_tickMarksDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_tickMarksDrawable_Landroid_graphics_drawable_StateListDrawable_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_tickMarksEndsHide_Z;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_tickMarksSize_I;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_tickMarksSweptHide_Z;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_tickTextsArray_I;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_tickTextsArray_arrayLjava_lang_String_;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_tickTextsColor_I;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_tickTextsColorStateList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_tickTextsSize_I;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_tickTextsTypeFace_Landroid_graphics_Typeface_;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_trackBackgroundColor_I;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_trackBackgroundSize_I;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_trackProgressColor_I;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_trackProgressSize_I;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_trackRoundedCorners_Z;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_userSeekable_Z;
	}
}
