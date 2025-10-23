using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Load.Resource.Bitmap;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000086 RID: 134
	[Register("com/bumptech/glide/request/BaseRequestOptions", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends com.bumptech.glide.request.BaseRequestOptions<T>"
	})]
	public abstract class BaseRequestOptions : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000134A4 File Offset: 0x000116A4
		internal static IntPtr class_ref
		{
			get
			{
				return BaseRequestOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000134C8 File Offset: 0x000116C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseRequestOptions._members;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000134D0 File Offset: 0x000116D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseRequestOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000134F4 File Offset: 0x000116F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseRequestOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00013500 File Offset: 0x00011700
		protected BaseRequestOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001350C File Offset: 0x0001170C
		[Register(".ctor", "()V", "")]
		public BaseRequestOptions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BaseRequestOptions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BaseRequestOptions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001357C File Offset: 0x0001177C
		public DiskCacheStrategy DiskCacheStrategy
		{
			[Register("getDiskCacheStrategy", "()Lcom/bumptech/glide/load/engine/DiskCacheStrategy;", "")]
			get
			{
				return Java.Lang.Object.GetObject<DiskCacheStrategy>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getDiskCacheStrategy.()Lcom/bumptech/glide/load/engine/DiskCacheStrategy;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000135AE File Offset: 0x000117AE
		public int ErrorId
		{
			[Register("getErrorId", "()I", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualInt32Method("getErrorId.()I", this, null);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x000135C8 File Offset: 0x000117C8
		public Drawable ErrorPlaceholder
		{
			[Register("getErrorPlaceholder", "()Landroid/graphics/drawable/Drawable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getErrorPlaceholder.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000135FC File Offset: 0x000117FC
		public Drawable FallbackDrawable
		{
			[Register("getFallbackDrawable", "()Landroid/graphics/drawable/Drawable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFallbackDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001362E File Offset: 0x0001182E
		public int FallbackId
		{
			[Register("getFallbackId", "()I", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualInt32Method("getFallbackId.()I", this, null);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00013647 File Offset: 0x00011847
		protected bool IsAutoCloneEnabled
		{
			[Register("isAutoCloneEnabled", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isAutoCloneEnabled.()Z", this, null);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00013660 File Offset: 0x00011860
		public bool IsDiskCacheStrategySet
		{
			[Register("isDiskCacheStrategySet", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isDiskCacheStrategySet.()Z", this, null);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00013679 File Offset: 0x00011879
		public bool IsLocked
		{
			[Register("isLocked", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isLocked.()Z", this, null);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00013692 File Offset: 0x00011892
		public bool IsMemoryCacheable
		{
			[Register("isMemoryCacheable", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isMemoryCacheable.()Z", this, null);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000136AB File Offset: 0x000118AB
		public bool IsPrioritySet
		{
			[Register("isPrioritySet", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isPrioritySet.()Z", this, null);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000136C4 File Offset: 0x000118C4
		public bool IsSkipMemoryCacheSet
		{
			[Register("isSkipMemoryCacheSet", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isSkipMemoryCacheSet.()Z", this, null);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x000136DD File Offset: 0x000118DD
		public bool IsTransformationAllowed
		{
			[Register("isTransformationAllowed", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isTransformationAllowed.()Z", this, null);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x000136F6 File Offset: 0x000118F6
		public bool IsTransformationRequired
		{
			[Register("isTransformationRequired", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isTransformationRequired.()Z", this, null);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001370F File Offset: 0x0001190F
		public bool IsTransformationSet
		{
			[Register("isTransformationSet", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isTransformationSet.()Z", this, null);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00013728 File Offset: 0x00011928
		public bool IsValidOverride
		{
			[Register("isValidOverride", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isValidOverride.()Z", this, null);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00013741 File Offset: 0x00011941
		public bool OnlyRetrieveFromCache
		{
			[Register("getOnlyRetrieveFromCache", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getOnlyRetrieveFromCache.()Z", this, null);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001375C File Offset: 0x0001195C
		public Options Options
		{
			[Register("getOptions", "()Lcom/bumptech/glide/load/Options;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Options>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOptions.()Lcom/bumptech/glide/load/Options;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001378E File Offset: 0x0001198E
		public int OverrideHeight
		{
			[Register("getOverrideHeight", "()I", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualInt32Method("getOverrideHeight.()I", this, null);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x000137A7 File Offset: 0x000119A7
		public int OverrideWidth
		{
			[Register("getOverrideWidth", "()I", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualInt32Method("getOverrideWidth.()I", this, null);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000137C0 File Offset: 0x000119C0
		public Drawable PlaceholderDrawable
		{
			[Register("getPlaceholderDrawable", "()Landroid/graphics/drawable/Drawable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPlaceholderDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000137F2 File Offset: 0x000119F2
		public int PlaceholderId
		{
			[Register("getPlaceholderId", "()I", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualInt32Method("getPlaceholderId.()I", this, null);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001380C File Offset: 0x00011A0C
		public Priority Priority
		{
			[Register("getPriority", "()Lcom/bumptech/glide/Priority;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Priority>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getPriority.()Lcom/bumptech/glide/Priority;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00013840 File Offset: 0x00011A40
		public Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00013874 File Offset: 0x00011A74
		public IKey Signature
		{
			[Register("getSignature", "()Lcom/bumptech/glide/load/Key;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IKey>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getSignature.()Lcom/bumptech/glide/load/Key;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000138A6 File Offset: 0x00011AA6
		public float SizeMultiplier
		{
			[Register("getSizeMultiplier", "()F", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualSingleMethod("getSizeMultiplier.()F", this, null);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000138C0 File Offset: 0x00011AC0
		public Resources.Theme Theme
		{
			[Register("getTheme", "()Landroid/content/res/Resources$Theme;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Resources.Theme>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTheme.()Landroid/content/res/Resources$Theme;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000138F4 File Offset: 0x00011AF4
		public IDictionary Transformations
		{
			[Register("getTransformations", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary.FromJniHandle(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("getTransformations.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00013926 File Offset: 0x00011B26
		public bool UseAnimationPool
		{
			[Register("getUseAnimationPool", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getUseAnimationPool.()Z", this, null);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001393F File Offset: 0x00011B3F
		public bool UseUnlimitedSourceGeneratorsPool
		{
			[Register("getUseUnlimitedSourceGeneratorsPool", "()Z", "")]
			get
			{
				return BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualBooleanMethod("getUseUnlimitedSourceGeneratorsPool.()Z", this, null);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00013958 File Offset: 0x00011B58
		private static Delegate GetApply_T_Lcom_bumptech_glide_request_BaseRequestOptions_Handler()
		{
			if (BaseRequestOptions.cb_apply_Lcom_bumptech_glide_request_BaseRequestOptions_ == null)
			{
				BaseRequestOptions.cb_apply_Lcom_bumptech_glide_request_BaseRequestOptions_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Apply_T_Lcom_bumptech_glide_request_BaseRequestOptions_));
			}
			return BaseRequestOptions.cb_apply_Lcom_bumptech_glide_request_BaseRequestOptions_;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001397C File Offset: 0x00011B7C
		private static IntPtr n_Apply_T_Lcom_bumptech_glide_request_BaseRequestOptions_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BaseRequestOptions object2 = Java.Lang.Object.GetObject<BaseRequestOptions>(native_o, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Apply_T(object2));
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000139A4 File Offset: 0x00011BA4
		[Register("apply", "(Lcom/bumptech/glide/request/BaseRequestOptions;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetApply_T_Lcom_bumptech_glide_request_BaseRequestOptions_Handler")]
		public unsafe virtual Java.Lang.Object Apply_T(BaseRequestOptions o)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((o == null) ? IntPtr.Zero : o.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("apply.(Lcom/bumptech/glide/request/BaseRequestOptions;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(o);
			}
			return @object;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00013A18 File Offset: 0x00011C18
		private static Delegate GetAutoClone_THandler()
		{
			if (BaseRequestOptions.cb_autoClone == null)
			{
				BaseRequestOptions.cb_autoClone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_AutoClone_T));
			}
			return BaseRequestOptions.cb_autoClone;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00013A3C File Offset: 0x00011C3C
		private static IntPtr n_AutoClone_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AutoClone_T());
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00013A50 File Offset: 0x00011C50
		[Register("autoClone", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetAutoClone_THandler")]
		public virtual Java.Lang.Object AutoClone_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("autoClone.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00013A82 File Offset: 0x00011C82
		private static Delegate GetCenterCrop_THandler()
		{
			if (BaseRequestOptions.cb_centerCrop == null)
			{
				BaseRequestOptions.cb_centerCrop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_CenterCrop_T));
			}
			return BaseRequestOptions.cb_centerCrop;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00013AA6 File Offset: 0x00011CA6
		private static IntPtr n_CenterCrop_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CenterCrop_T());
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00013ABC File Offset: 0x00011CBC
		[Register("centerCrop", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetCenterCrop_THandler")]
		public virtual Java.Lang.Object CenterCrop_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("centerCrop.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00013AEE File Offset: 0x00011CEE
		private static Delegate GetCenterInside_THandler()
		{
			if (BaseRequestOptions.cb_centerInside == null)
			{
				BaseRequestOptions.cb_centerInside = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_CenterInside_T));
			}
			return BaseRequestOptions.cb_centerInside;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00013B12 File Offset: 0x00011D12
		private static IntPtr n_CenterInside_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CenterInside_T());
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00013B28 File Offset: 0x00011D28
		[Register("centerInside", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetCenterInside_THandler")]
		public virtual Java.Lang.Object CenterInside_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("centerInside.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00013B5A File Offset: 0x00011D5A
		private static Delegate GetCircleCrop_THandler()
		{
			if (BaseRequestOptions.cb_circleCrop == null)
			{
				BaseRequestOptions.cb_circleCrop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_CircleCrop_T));
			}
			return BaseRequestOptions.cb_circleCrop;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00013B7E File Offset: 0x00011D7E
		private static IntPtr n_CircleCrop_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CircleCrop_T());
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00013B94 File Offset: 0x00011D94
		[Register("circleCrop", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetCircleCrop_THandler")]
		public virtual Java.Lang.Object CircleCrop_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("circleCrop.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00013BC6 File Offset: 0x00011DC6
		private static Delegate GetClone_THandler()
		{
			if (BaseRequestOptions.cb_clone == null)
			{
				BaseRequestOptions.cb_clone = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_Clone_T));
			}
			return BaseRequestOptions.cb_clone;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00013BEA File Offset: 0x00011DEA
		private static IntPtr n_Clone_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clone_T());
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00013C00 File Offset: 0x00011E00
		[Register("clone", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetClone_THandler")]
		public virtual Java.Lang.Object Clone_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("clone.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00013C32 File Offset: 0x00011E32
		private static Delegate GetDecode_T_Ljava_lang_Class_Handler()
		{
			if (BaseRequestOptions.cb_decode_Ljava_lang_Class_ == null)
			{
				BaseRequestOptions.cb_decode_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Decode_T_Ljava_lang_Class_));
			}
			return BaseRequestOptions.cb_decode_Ljava_lang_Class_;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00013C58 File Offset: 0x00011E58
		private static IntPtr n_Decode_T_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Decode_T(object2));
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00013C80 File Offset: 0x00011E80
		[Register("decode", "(Ljava/lang/Class;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDecode_T_Ljava_lang_Class_Handler")]
		public unsafe virtual Java.Lang.Object Decode_T(Class resourceClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("decode.(Ljava/lang/Class;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
			}
			return @object;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00013CF4 File Offset: 0x00011EF4
		private static Delegate GetDisallowHardwareConfig_THandler()
		{
			if (BaseRequestOptions.cb_disallowHardwareConfig == null)
			{
				BaseRequestOptions.cb_disallowHardwareConfig = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_DisallowHardwareConfig_T));
			}
			return BaseRequestOptions.cb_disallowHardwareConfig;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00013D18 File Offset: 0x00011F18
		private static IntPtr n_DisallowHardwareConfig_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisallowHardwareConfig_T());
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00013D2C File Offset: 0x00011F2C
		[Register("disallowHardwareConfig", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDisallowHardwareConfig_THandler")]
		public virtual Java.Lang.Object DisallowHardwareConfig_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("disallowHardwareConfig.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00013D5E File Offset: 0x00011F5E
		private static Delegate GetDiskCacheStrategy_T_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Handler()
		{
			if (BaseRequestOptions.cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ == null)
			{
				BaseRequestOptions.cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_DiskCacheStrategy_T_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_));
			}
			return BaseRequestOptions.cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00013D84 File Offset: 0x00011F84
		private static IntPtr n_DiskCacheStrategy_T_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_(IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DiskCacheStrategy object2 = Java.Lang.Object.GetObject<DiskCacheStrategy>(native_strategy, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.DiskCacheStrategy_T(object2));
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00013DAC File Offset: 0x00011FAC
		[Register("diskCacheStrategy", "(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDiskCacheStrategy_T_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_Handler")]
		public unsafe virtual Java.Lang.Object DiskCacheStrategy_T(DiskCacheStrategy strategy)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((strategy == null) ? IntPtr.Zero : strategy.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("diskCacheStrategy.(Lcom/bumptech/glide/load/engine/DiskCacheStrategy;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(strategy);
			}
			return @object;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00013E20 File Offset: 0x00012020
		private static Delegate GetDontAnimate_THandler()
		{
			if (BaseRequestOptions.cb_dontAnimate == null)
			{
				BaseRequestOptions.cb_dontAnimate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_DontAnimate_T));
			}
			return BaseRequestOptions.cb_dontAnimate;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00013E44 File Offset: 0x00012044
		private static IntPtr n_DontAnimate_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DontAnimate_T());
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00013E58 File Offset: 0x00012058
		[Register("dontAnimate", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDontAnimate_THandler")]
		public virtual Java.Lang.Object DontAnimate_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("dontAnimate.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00013E8A File Offset: 0x0001208A
		private static Delegate GetDontTransform_THandler()
		{
			if (BaseRequestOptions.cb_dontTransform == null)
			{
				BaseRequestOptions.cb_dontTransform = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_DontTransform_T));
			}
			return BaseRequestOptions.cb_dontTransform;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00013EAE File Offset: 0x000120AE
		private static IntPtr n_DontTransform_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DontTransform_T());
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00013EC4 File Offset: 0x000120C4
		[Register("dontTransform", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDontTransform_THandler")]
		public virtual Java.Lang.Object DontTransform_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("dontTransform.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00013EF6 File Offset: 0x000120F6
		private static Delegate GetDownsample_T_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_Handler()
		{
			if (BaseRequestOptions.cb_downsample_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_ == null)
			{
				BaseRequestOptions.cb_downsample_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Downsample_T_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_));
			}
			return BaseRequestOptions.cb_downsample_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00013F1C File Offset: 0x0001211C
		private static IntPtr n_Downsample_T_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_(IntPtr jnienv, IntPtr native__this, IntPtr native_strategy)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DownsampleStrategy object2 = Java.Lang.Object.GetObject<DownsampleStrategy>(native_strategy, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Downsample_T(object2));
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00013F44 File Offset: 0x00012144
		[Register("downsample", "(Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetDownsample_T_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_Handler")]
		public unsafe virtual Java.Lang.Object Downsample_T(DownsampleStrategy strategy)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((strategy == null) ? IntPtr.Zero : strategy.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("downsample.(Lcom/bumptech/glide/load/resource/bitmap/DownsampleStrategy;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(strategy);
			}
			return @object;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00013FB8 File Offset: 0x000121B8
		private static Delegate GetEncodeFormat_T_Landroid_graphics_Bitmap_CompressFormat_Handler()
		{
			if (BaseRequestOptions.cb_encodeFormat_Landroid_graphics_Bitmap_CompressFormat_ == null)
			{
				BaseRequestOptions.cb_encodeFormat_Landroid_graphics_Bitmap_CompressFormat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_EncodeFormat_T_Landroid_graphics_Bitmap_CompressFormat_));
			}
			return BaseRequestOptions.cb_encodeFormat_Landroid_graphics_Bitmap_CompressFormat_;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00013FDC File Offset: 0x000121DC
		private static IntPtr n_EncodeFormat_T_Landroid_graphics_Bitmap_CompressFormat_(IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bitmap.CompressFormat object2 = Java.Lang.Object.GetObject<Bitmap.CompressFormat>(native_format, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.EncodeFormat_T(object2));
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00014004 File Offset: 0x00012204
		[Register("encodeFormat", "(Landroid/graphics/Bitmap$CompressFormat;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetEncodeFormat_T_Landroid_graphics_Bitmap_CompressFormat_Handler")]
		public unsafe virtual Java.Lang.Object EncodeFormat_T(Bitmap.CompressFormat format)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("encodeFormat.(Landroid/graphics/Bitmap$CompressFormat;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @object;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00014078 File Offset: 0x00012278
		private static Delegate GetEncodeQuality_T_IHandler()
		{
			if (BaseRequestOptions.cb_encodeQuality_I == null)
			{
				BaseRequestOptions.cb_encodeQuality_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_EncodeQuality_T_I));
			}
			return BaseRequestOptions.cb_encodeQuality_I;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001409C File Offset: 0x0001229C
		private static IntPtr n_EncodeQuality_T_I(IntPtr jnienv, IntPtr native__this, int quality)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EncodeQuality_T(quality));
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000140B4 File Offset: 0x000122B4
		[Register("encodeQuality", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetEncodeQuality_T_IHandler")]
		public unsafe virtual Java.Lang.Object EncodeQuality_T(int quality)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(quality);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("encodeQuality.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000140FD File Offset: 0x000122FD
		private static Delegate GetError_T_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseRequestOptions.cb_error_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseRequestOptions.cb_error_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Error_T_Landroid_graphics_drawable_Drawable_));
			}
			return BaseRequestOptions.cb_error_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00014124 File Offset: 0x00012324
		private static IntPtr n_Error_T_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Error_T(object2));
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0001414C File Offset: 0x0001234C
		[Register("error", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetError_T_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual Java.Lang.Object Error_T(Drawable drawable)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("error.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
			return @object;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000141C0 File Offset: 0x000123C0
		private static Delegate GetError_T_IHandler()
		{
			if (BaseRequestOptions.cb_error_I == null)
			{
				BaseRequestOptions.cb_error_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_Error_T_I));
			}
			return BaseRequestOptions.cb_error_I;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000141E4 File Offset: 0x000123E4
		private static IntPtr n_Error_T_I(IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Error_T(resourceId));
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000141FC File Offset: 0x000123FC
		[Register("error", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetError_T_IHandler")]
		public unsafe virtual Java.Lang.Object Error_T(int resourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resourceId);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("error.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00014245 File Offset: 0x00012445
		private static Delegate GetFallback_T_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseRequestOptions.cb_fallback_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseRequestOptions.cb_fallback_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Fallback_T_Landroid_graphics_drawable_Drawable_));
			}
			return BaseRequestOptions.cb_fallback_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001426C File Offset: 0x0001246C
		private static IntPtr n_Fallback_T_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Fallback_T(object2));
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00014294 File Offset: 0x00012494
		[Register("fallback", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetFallback_T_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual Java.Lang.Object Fallback_T(Drawable drawable)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("fallback.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
			return @object;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00014308 File Offset: 0x00012508
		private static Delegate GetFallback_T_IHandler()
		{
			if (BaseRequestOptions.cb_fallback_I == null)
			{
				BaseRequestOptions.cb_fallback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_Fallback_T_I));
			}
			return BaseRequestOptions.cb_fallback_I;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001432C File Offset: 0x0001252C
		private static IntPtr n_Fallback_T_I(IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Fallback_T(resourceId));
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00014344 File Offset: 0x00012544
		[Register("fallback", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetFallback_T_IHandler")]
		public unsafe virtual Java.Lang.Object Fallback_T(int resourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resourceId);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("fallback.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001438D File Offset: 0x0001258D
		private static Delegate GetFitCenter_THandler()
		{
			if (BaseRequestOptions.cb_fitCenter == null)
			{
				BaseRequestOptions.cb_fitCenter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_FitCenter_T));
			}
			return BaseRequestOptions.cb_fitCenter;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000143B1 File Offset: 0x000125B1
		private static IntPtr n_FitCenter_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FitCenter_T());
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000143C8 File Offset: 0x000125C8
		[Register("fitCenter", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetFitCenter_THandler")]
		public virtual Java.Lang.Object FitCenter_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("fitCenter.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x000143FA File Offset: 0x000125FA
		private static Delegate GetFormat_T_Lcom_bumptech_glide_load_DecodeFormat_Handler()
		{
			if (BaseRequestOptions.cb_format_Lcom_bumptech_glide_load_DecodeFormat_ == null)
			{
				BaseRequestOptions.cb_format_Lcom_bumptech_glide_load_DecodeFormat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Format_T_Lcom_bumptech_glide_load_DecodeFormat_));
			}
			return BaseRequestOptions.cb_format_Lcom_bumptech_glide_load_DecodeFormat_;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00014420 File Offset: 0x00012620
		private static IntPtr n_Format_T_Lcom_bumptech_glide_load_DecodeFormat_(IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DecodeFormat object2 = Java.Lang.Object.GetObject<DecodeFormat>(native_format, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Format_T(object2));
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00014448 File Offset: 0x00012648
		[Register("format", "(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetFormat_T_Lcom_bumptech_glide_load_DecodeFormat_Handler")]
		public unsafe virtual Java.Lang.Object Format_T(DecodeFormat format)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((format == null) ? IntPtr.Zero : format.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("format.(Lcom/bumptech/glide/load/DecodeFormat;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(format);
			}
			return @object;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000144BC File Offset: 0x000126BC
		private static Delegate GetFrame_T_JHandler()
		{
			if (BaseRequestOptions.cb_frame_J == null)
			{
				BaseRequestOptions.cb_frame_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(BaseRequestOptions.n_Frame_T_J));
			}
			return BaseRequestOptions.cb_frame_J;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000144E0 File Offset: 0x000126E0
		private static IntPtr n_Frame_T_J(IntPtr jnienv, IntPtr native__this, long frameTimeMicros)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Frame_T(frameTimeMicros));
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x000144F8 File Offset: 0x000126F8
		[Register("frame", "(J)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetFrame_T_JHandler")]
		public unsafe virtual Java.Lang.Object Frame_T(long frameTimeMicros)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(frameTimeMicros);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("frame.(J)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00014541 File Offset: 0x00012741
		private static Delegate GetLock_THandler()
		{
			if (BaseRequestOptions.cb_lock == null)
			{
				BaseRequestOptions.cb_lock = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_Lock_T));
			}
			return BaseRequestOptions.cb_lock;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00014565 File Offset: 0x00012765
		private static IntPtr n_Lock_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Lock_T());
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0001457C File Offset: 0x0001277C
		[Register("lock", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetLock_THandler")]
		public virtual Java.Lang.Object Lock_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("lock.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000145AE File Offset: 0x000127AE
		private static Delegate GetOnlyRetrieveFromCache_T_ZHandler()
		{
			if (BaseRequestOptions.cb_onlyRetrieveFromCache_Z == null)
			{
				BaseRequestOptions.cb_onlyRetrieveFromCache_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(BaseRequestOptions.n_OnlyRetrieveFromCache_T_Z));
			}
			return BaseRequestOptions.cb_onlyRetrieveFromCache_Z;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000145D2 File Offset: 0x000127D2
		private static IntPtr n_OnlyRetrieveFromCache_T_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnlyRetrieveFromCache_T(flag));
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000145E8 File Offset: 0x000127E8
		[Register("onlyRetrieveFromCache", "(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOnlyRetrieveFromCache_T_ZHandler")]
		public unsafe virtual Java.Lang.Object OnlyRetrieveFromCache_T(bool flag)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flag);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("onlyRetrieveFromCache.(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00014631 File Offset: 0x00012831
		private static Delegate GetOptionalCenterCrop_THandler()
		{
			if (BaseRequestOptions.cb_optionalCenterCrop == null)
			{
				BaseRequestOptions.cb_optionalCenterCrop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_OptionalCenterCrop_T));
			}
			return BaseRequestOptions.cb_optionalCenterCrop;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00014655 File Offset: 0x00012855
		private static IntPtr n_OptionalCenterCrop_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionalCenterCrop_T());
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001466C File Offset: 0x0001286C
		[Register("optionalCenterCrop", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalCenterCrop_THandler")]
		public virtual Java.Lang.Object OptionalCenterCrop_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalCenterCrop.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0001469E File Offset: 0x0001289E
		private static Delegate GetOptionalCenterInside_THandler()
		{
			if (BaseRequestOptions.cb_optionalCenterInside == null)
			{
				BaseRequestOptions.cb_optionalCenterInside = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_OptionalCenterInside_T));
			}
			return BaseRequestOptions.cb_optionalCenterInside;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000146C2 File Offset: 0x000128C2
		private static IntPtr n_OptionalCenterInside_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionalCenterInside_T());
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000146D8 File Offset: 0x000128D8
		[Register("optionalCenterInside", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalCenterInside_THandler")]
		public virtual Java.Lang.Object OptionalCenterInside_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalCenterInside.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001470A File Offset: 0x0001290A
		private static Delegate GetOptionalCircleCrop_THandler()
		{
			if (BaseRequestOptions.cb_optionalCircleCrop == null)
			{
				BaseRequestOptions.cb_optionalCircleCrop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_OptionalCircleCrop_T));
			}
			return BaseRequestOptions.cb_optionalCircleCrop;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001472E File Offset: 0x0001292E
		private static IntPtr n_OptionalCircleCrop_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionalCircleCrop_T());
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00014744 File Offset: 0x00012944
		[Register("optionalCircleCrop", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalCircleCrop_THandler")]
		public virtual Java.Lang.Object OptionalCircleCrop_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalCircleCrop.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00014776 File Offset: 0x00012976
		private static Delegate GetOptionalFitCenter_THandler()
		{
			if (BaseRequestOptions.cb_optionalFitCenter == null)
			{
				BaseRequestOptions.cb_optionalFitCenter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseRequestOptions.n_OptionalFitCenter_T));
			}
			return BaseRequestOptions.cb_optionalFitCenter;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001479A File Offset: 0x0001299A
		private static IntPtr n_OptionalFitCenter_T(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OptionalFitCenter_T());
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000147B0 File Offset: 0x000129B0
		[Register("optionalFitCenter", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalFitCenter_THandler")]
		public virtual Java.Lang.Object OptionalFitCenter_T()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalFitCenter.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000147E2 File Offset: 0x000129E2
		private static Delegate GetOptionalTransform_T_Lcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_optionalTransform_Lcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_optionalTransform_Lcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_OptionalTransform_T_Lcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_optionalTransform_Lcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00014808 File Offset: 0x00012A08
		private static IntPtr n_OptionalTransform_T_Lcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_transformation)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformation object2 = Java.Lang.Object.GetObject<ITransformation>(native_transformation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OptionalTransform_T(object2));
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00014830 File Offset: 0x00012A30
		[Register("optionalTransform", "(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalTransform_T_Lcom_bumptech_glide_load_Transformation_Handler")]
		public unsafe virtual Java.Lang.Object OptionalTransform_T(ITransformation transformation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transformation == null) ? IntPtr.Zero : ((Java.Lang.Object)transformation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalTransform.(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transformation);
			}
			return @object;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x000148A8 File Offset: 0x00012AA8
		private static Delegate GetOptionalTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_optionalTransform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_optionalTransform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BaseRequestOptions.n_OptionalTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_optionalTransform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000148CC File Offset: 0x00012ACC
		private static IntPtr n_OptionalTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_transformation)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			ITransformation object3 = Java.Lang.Object.GetObject<ITransformation>(native_transformation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OptionalTransform_T(object2, object3));
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00014900 File Offset: 0x00012B00
		[Register("optionalTransform", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOptionalTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Y"
		})]
		public unsafe virtual Java.Lang.Object OptionalTransform_T(Class resourceClass, ITransformation transformation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((transformation == null) ? IntPtr.Zero : ((Java.Lang.Object)transformation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("optionalTransform.(Ljava/lang/Class;Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transformation);
			}
			return @object;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x000149A0 File Offset: 0x00012BA0
		private static Delegate GetOverride_T_IHandler()
		{
			if (BaseRequestOptions.cb_override_I == null)
			{
				BaseRequestOptions.cb_override_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_Override_T_I));
			}
			return BaseRequestOptions.cb_override_I;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000149C4 File Offset: 0x00012BC4
		private static IntPtr n_Override_T_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Override_T(size));
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000149DC File Offset: 0x00012BDC
		[Register("override", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOverride_T_IHandler")]
		public unsafe virtual Java.Lang.Object Override_T(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("override.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00014A25 File Offset: 0x00012C25
		private static Delegate GetOverride_T_IIHandler()
		{
			if (BaseRequestOptions.cb_override_II == null)
			{
				BaseRequestOptions.cb_override_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(BaseRequestOptions.n_Override_T_II));
			}
			return BaseRequestOptions.cb_override_II;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00014A49 File Offset: 0x00012C49
		private static IntPtr n_Override_T_II(IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Override_T(width, height));
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00014A60 File Offset: 0x00012C60
		[Register("override", "(II)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetOverride_T_IIHandler")]
		public unsafe virtual Java.Lang.Object Override_T(int width, int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("override.(II)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00014ABC File Offset: 0x00012CBC
		private static Delegate GetPlaceholder_T_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (BaseRequestOptions.cb_placeholder_Landroid_graphics_drawable_Drawable_ == null)
			{
				BaseRequestOptions.cb_placeholder_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Placeholder_T_Landroid_graphics_drawable_Drawable_));
			}
			return BaseRequestOptions.cb_placeholder_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00014AE0 File Offset: 0x00012CE0
		private static IntPtr n_Placeholder_T_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_drawable, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Placeholder_T(object2));
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00014B08 File Offset: 0x00012D08
		[Register("placeholder", "(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetPlaceholder_T_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual Java.Lang.Object Placeholder_T(Drawable drawable)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawable == null) ? IntPtr.Zero : drawable.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("placeholder.(Landroid/graphics/drawable/Drawable;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(drawable);
			}
			return @object;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00014B7C File Offset: 0x00012D7C
		private static Delegate GetPlaceholder_T_IHandler()
		{
			if (BaseRequestOptions.cb_placeholder_I == null)
			{
				BaseRequestOptions.cb_placeholder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_Placeholder_T_I));
			}
			return BaseRequestOptions.cb_placeholder_I;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00014BA0 File Offset: 0x00012DA0
		private static IntPtr n_Placeholder_T_I(IntPtr jnienv, IntPtr native__this, int resourceId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Placeholder_T(resourceId));
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00014BB8 File Offset: 0x00012DB8
		[Register("placeholder", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetPlaceholder_T_IHandler")]
		public unsafe virtual Java.Lang.Object Placeholder_T(int resourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resourceId);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("placeholder.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00014C01 File Offset: 0x00012E01
		private static Delegate GetPriority_T_Lcom_bumptech_glide_Priority_Handler()
		{
			if (BaseRequestOptions.cb_priority_Lcom_bumptech_glide_Priority_ == null)
			{
				BaseRequestOptions.cb_priority_Lcom_bumptech_glide_Priority_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Priority_T_Lcom_bumptech_glide_Priority_));
			}
			return BaseRequestOptions.cb_priority_Lcom_bumptech_glide_Priority_;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00014C28 File Offset: 0x00012E28
		private static IntPtr n_Priority_T_Lcom_bumptech_glide_Priority_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Priority_T(object2));
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00014C50 File Offset: 0x00012E50
		[Register("priority", "(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetPriority_T_Lcom_bumptech_glide_Priority_Handler")]
		public unsafe virtual Java.Lang.Object Priority_T(Priority priority)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("priority.(Lcom/bumptech/glide/Priority;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return @object;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00014CC4 File Offset: 0x00012EC4
		[Register("selfOrThrowIfLocked", "()Lcom/bumptech/glide/request/BaseRequestOptions;", "")]
		protected Java.Lang.Object SelfOrThrowIfLocked()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeNonvirtualObjectMethod("selfOrThrowIfLocked.()Lcom/bumptech/glide/request/BaseRequestOptions;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00014CF6 File Offset: 0x00012EF6
		private static Delegate GetSet_T_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_Handler()
		{
			if (BaseRequestOptions.cb_set_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_ == null)
			{
				BaseRequestOptions.cb_set_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BaseRequestOptions.n_Set_T_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_));
			}
			return BaseRequestOptions.cb_set_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00014D1C File Offset: 0x00012F1C
		private static IntPtr n_Set_T_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_option, IntPtr native_value)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Option object2 = Java.Lang.Object.GetObject<Option>(native_option, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Set_T(object2, object3));
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00014D50 File Offset: 0x00012F50
		[Register("set", "(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetSet_T_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Y"
		})]
		public unsafe virtual Java.Lang.Object Set_T(Option option, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((option == null) ? IntPtr.Zero : option.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("set.(Lcom/bumptech/glide/load/Option;Ljava/lang/Object;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(option);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00014DEC File Offset: 0x00012FEC
		private static Delegate GetSignature_T_Lcom_bumptech_glide_load_Key_Handler()
		{
			if (BaseRequestOptions.cb_signature_Lcom_bumptech_glide_load_Key_ == null)
			{
				BaseRequestOptions.cb_signature_Lcom_bumptech_glide_load_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Signature_T_Lcom_bumptech_glide_load_Key_));
			}
			return BaseRequestOptions.cb_signature_Lcom_bumptech_glide_load_Key_;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00014E10 File Offset: 0x00013010
		private static IntPtr n_Signature_T_Lcom_bumptech_glide_load_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_signature)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IKey object2 = Java.Lang.Object.GetObject<IKey>(native_signature, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Signature_T(object2));
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00014E38 File Offset: 0x00013038
		[Register("signature", "(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetSignature_T_Lcom_bumptech_glide_load_Key_Handler")]
		public unsafe virtual Java.Lang.Object Signature_T(IKey signature)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((signature == null) ? IntPtr.Zero : ((Java.Lang.Object)signature).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("signature.(Lcom/bumptech/glide/load/Key;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(signature);
			}
			return @object;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00014EB0 File Offset: 0x000130B0
		private static Delegate GetSizeMultiplier_T_FHandler()
		{
			if (BaseRequestOptions.cb_sizeMultiplier_F == null)
			{
				BaseRequestOptions.cb_sizeMultiplier_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_L(BaseRequestOptions.n_SizeMultiplier_T_F));
			}
			return BaseRequestOptions.cb_sizeMultiplier_F;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00014ED4 File Offset: 0x000130D4
		private static IntPtr n_SizeMultiplier_T_F(IntPtr jnienv, IntPtr native__this, float sizeMultiplier)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SizeMultiplier_T(sizeMultiplier));
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00014EEC File Offset: 0x000130EC
		[Register("sizeMultiplier", "(F)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetSizeMultiplier_T_FHandler")]
		public unsafe virtual Java.Lang.Object SizeMultiplier_T(float sizeMultiplier)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sizeMultiplier);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("sizeMultiplier.(F)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00014F35 File Offset: 0x00013135
		private static Delegate GetSkipMemoryCache_T_ZHandler()
		{
			if (BaseRequestOptions.cb_skipMemoryCache_Z == null)
			{
				BaseRequestOptions.cb_skipMemoryCache_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(BaseRequestOptions.n_SkipMemoryCache_T_Z));
			}
			return BaseRequestOptions.cb_skipMemoryCache_Z;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00014F59 File Offset: 0x00013159
		private static IntPtr n_SkipMemoryCache_T_Z(IntPtr jnienv, IntPtr native__this, bool skip)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SkipMemoryCache_T(skip));
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00014F70 File Offset: 0x00013170
		[Register("skipMemoryCache", "(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetSkipMemoryCache_T_ZHandler")]
		public unsafe virtual Java.Lang.Object SkipMemoryCache_T(bool skip)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(skip);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("skipMemoryCache.(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00014FB9 File Offset: 0x000131B9
		private static Delegate GetTheme_T_Landroid_content_res_Resources_Theme_Handler()
		{
			if (BaseRequestOptions.cb_theme_Landroid_content_res_Resources_Theme_ == null)
			{
				BaseRequestOptions.cb_theme_Landroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Theme_T_Landroid_content_res_Resources_Theme_));
			}
			return BaseRequestOptions.cb_theme_Landroid_content_res_Resources_Theme_;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00014FE0 File Offset: 0x000131E0
		private static IntPtr n_Theme_T_Landroid_content_res_Resources_Theme_(IntPtr jnienv, IntPtr native__this, IntPtr native_theme)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Resources.Theme object2 = Java.Lang.Object.GetObject<Resources.Theme>(native_theme, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Theme_T(object2));
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00015008 File Offset: 0x00013208
		[Register("theme", "(Landroid/content/res/Resources$Theme;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTheme_T_Landroid_content_res_Resources_Theme_Handler")]
		public unsafe virtual Java.Lang.Object Theme_T(Resources.Theme theme)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((theme == null) ? IntPtr.Zero : theme.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("theme.(Landroid/content/res/Resources$Theme;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(theme);
			}
			return @object;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001507C File Offset: 0x0001327C
		private static Delegate GetTimeout_T_IHandler()
		{
			if (BaseRequestOptions.cb_timeout_I == null)
			{
				BaseRequestOptions.cb_timeout_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseRequestOptions.n_Timeout_T_I));
			}
			return BaseRequestOptions.cb_timeout_I;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000150A0 File Offset: 0x000132A0
		private static IntPtr n_Timeout_T_I(IntPtr jnienv, IntPtr native__this, int timeoutMs)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Timeout_T(timeoutMs));
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000150B8 File Offset: 0x000132B8
		[Register("timeout", "(I)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTimeout_T_IHandler")]
		public unsafe virtual Java.Lang.Object Timeout_T(int timeoutMs)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(timeoutMs);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("timeout.(I)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00015101 File Offset: 0x00013301
		private static Delegate GetTransform_T_Lcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_transform_Lcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_transform_Lcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Transform_T_Lcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_transform_Lcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00015128 File Offset: 0x00013328
		private static IntPtr n_Transform_T_Lcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_transformation)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformation object2 = Java.Lang.Object.GetObject<ITransformation>(native_transformation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform_T(object2));
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00015150 File Offset: 0x00013350
		[Register("transform", "(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTransform_T_Lcom_bumptech_glide_load_Transformation_Handler")]
		public unsafe virtual Java.Lang.Object Transform_T(ITransformation transformation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transformation == null) ? IntPtr.Zero : ((Java.Lang.Object)transformation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(transformation);
			}
			return @object;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000151C8 File Offset: 0x000133C8
		private static Delegate GetTransform_T_arrayLcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_transform_arrayLcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_transform_arrayLcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Transform_T_arrayLcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_transform_arrayLcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000151EC File Offset: 0x000133EC
		private static IntPtr n_Transform_T_arrayLcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_transformations)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformation[] array = (ITransformation[])JNIEnv.GetArray(native_transformations, JniHandleOwnership.DoNotTransfer, typeof(ITransformation));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Transform_T(array));
			if (array != null)
			{
				JNIEnv.CopyArray<ITransformation>(array, native_transformations);
			}
			return result;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00015230 File Offset: 0x00013430
		[Register("transform", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTransform_T_arrayLcom_bumptech_glide_load_Transformation_Handler")]
		public unsafe virtual Java.Lang.Object Transform_T(params ITransformation[] transformations)
		{
			IntPtr intPtr = JNIEnv.NewArray<ITransformation>(transformations);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("transform.([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (transformations != null)
				{
					JNIEnv.CopyArray<ITransformation>(intPtr, transformations);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(transformations);
			}
			return @object;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000152AC File Offset: 0x000134AC
		private static Delegate GetTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_transform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_transform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(BaseRequestOptions.n_Transform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_transform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000152D0 File Offset: 0x000134D0
		private static IntPtr n_Transform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_resourceClass, IntPtr native_transformation)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_resourceClass, JniHandleOwnership.DoNotTransfer);
			ITransformation object3 = Java.Lang.Object.GetObject<ITransformation>(native_transformation, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Transform_T(object2, object3));
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00015304 File Offset: 0x00013504
		[Register("transform", "(Ljava/lang/Class;Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTransform_T_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Y"
		})]
		public unsafe virtual Java.Lang.Object Transform_T(Class resourceClass, ITransformation transformation)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[1] = new JniArgumentValue((transformation == null) ? IntPtr.Zero : ((Java.Lang.Object)transformation).Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("transform.(Ljava/lang/Class;Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transformation);
			}
			return @object;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000153A4 File Offset: 0x000135A4
		[Obsolete]
		private static Delegate GetTransforms_arrayLcom_bumptech_glide_load_Transformation_Handler()
		{
			if (BaseRequestOptions.cb_transforms_arrayLcom_bumptech_glide_load_Transformation_ == null)
			{
				BaseRequestOptions.cb_transforms_arrayLcom_bumptech_glide_load_Transformation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseRequestOptions.n_Transforms_arrayLcom_bumptech_glide_load_Transformation_));
			}
			return BaseRequestOptions.cb_transforms_arrayLcom_bumptech_glide_load_Transformation_;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000153C8 File Offset: 0x000135C8
		[Obsolete]
		private static IntPtr n_Transforms_arrayLcom_bumptech_glide_load_Transformation_(IntPtr jnienv, IntPtr native__this, IntPtr native_transformations)
		{
			BaseRequestOptions @object = Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ITransformation[] array = (ITransformation[])JNIEnv.GetArray(native_transformations, JniHandleOwnership.DoNotTransfer, typeof(ITransformation));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.Transforms(array));
			if (array != null)
			{
				JNIEnv.CopyArray<ITransformation>(array, native_transformations);
			}
			return result;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001540C File Offset: 0x0001360C
		[Obsolete("deprecated")]
		[Register("transforms", "([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetTransforms_arrayLcom_bumptech_glide_load_Transformation_Handler")]
		public unsafe virtual Java.Lang.Object Transforms(params ITransformation[] transformations)
		{
			IntPtr intPtr = JNIEnv.NewArray<ITransformation>(transformations);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("transforms.([Lcom/bumptech/glide/load/Transformation;)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (transformations != null)
				{
					JNIEnv.CopyArray<ITransformation>(intPtr, transformations);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(transformations);
			}
			return @object;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00015488 File Offset: 0x00013688
		private static Delegate GetUseAnimationPool_T_ZHandler()
		{
			if (BaseRequestOptions.cb_useAnimationPool_Z == null)
			{
				BaseRequestOptions.cb_useAnimationPool_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(BaseRequestOptions.n_UseAnimationPool_T_Z));
			}
			return BaseRequestOptions.cb_useAnimationPool_Z;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x000154AC File Offset: 0x000136AC
		private static IntPtr n_UseAnimationPool_T_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseAnimationPool_T(flag));
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000154C4 File Offset: 0x000136C4
		[Register("useAnimationPool", "(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetUseAnimationPool_T_ZHandler")]
		public unsafe virtual Java.Lang.Object UseAnimationPool_T(bool flag)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flag);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("useAnimationPool.(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001550D File Offset: 0x0001370D
		private static Delegate GetUseUnlimitedSourceGeneratorsPool_T_ZHandler()
		{
			if (BaseRequestOptions.cb_useUnlimitedSourceGeneratorsPool_Z == null)
			{
				BaseRequestOptions.cb_useUnlimitedSourceGeneratorsPool_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(BaseRequestOptions.n_UseUnlimitedSourceGeneratorsPool_T_Z));
			}
			return BaseRequestOptions.cb_useUnlimitedSourceGeneratorsPool_Z;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00015531 File Offset: 0x00013731
		private static IntPtr n_UseUnlimitedSourceGeneratorsPool_T_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseRequestOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UseUnlimitedSourceGeneratorsPool_T(flag));
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00015548 File Offset: 0x00013748
		[Register("useUnlimitedSourceGeneratorsPool", "(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", "GetUseUnlimitedSourceGeneratorsPool_T_ZHandler")]
		public unsafe virtual Java.Lang.Object UseUnlimitedSourceGeneratorsPool_T(bool flag)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(flag);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseRequestOptions._members.InstanceMethods.InvokeVirtualObjectMethod("useUnlimitedSourceGeneratorsPool.(Z)Lcom/bumptech/glide/request/BaseRequestOptions;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000150 RID: 336
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/BaseRequestOptions", typeof(BaseRequestOptions));

		// Token: 0x04000151 RID: 337
		private static Delegate cb_apply_Lcom_bumptech_glide_request_BaseRequestOptions_;

		// Token: 0x04000152 RID: 338
		private static Delegate cb_autoClone;

		// Token: 0x04000153 RID: 339
		private static Delegate cb_centerCrop;

		// Token: 0x04000154 RID: 340
		private static Delegate cb_centerInside;

		// Token: 0x04000155 RID: 341
		private static Delegate cb_circleCrop;

		// Token: 0x04000156 RID: 342
		private static Delegate cb_clone;

		// Token: 0x04000157 RID: 343
		private static Delegate cb_decode_Ljava_lang_Class_;

		// Token: 0x04000158 RID: 344
		private static Delegate cb_disallowHardwareConfig;

		// Token: 0x04000159 RID: 345
		private static Delegate cb_diskCacheStrategy_Lcom_bumptech_glide_load_engine_DiskCacheStrategy_;

		// Token: 0x0400015A RID: 346
		private static Delegate cb_dontAnimate;

		// Token: 0x0400015B RID: 347
		private static Delegate cb_dontTransform;

		// Token: 0x0400015C RID: 348
		private static Delegate cb_downsample_Lcom_bumptech_glide_load_resource_bitmap_DownsampleStrategy_;

		// Token: 0x0400015D RID: 349
		private static Delegate cb_encodeFormat_Landroid_graphics_Bitmap_CompressFormat_;

		// Token: 0x0400015E RID: 350
		private static Delegate cb_encodeQuality_I;

		// Token: 0x0400015F RID: 351
		private static Delegate cb_error_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000160 RID: 352
		private static Delegate cb_error_I;

		// Token: 0x04000161 RID: 353
		private static Delegate cb_fallback_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000162 RID: 354
		private static Delegate cb_fallback_I;

		// Token: 0x04000163 RID: 355
		private static Delegate cb_fitCenter;

		// Token: 0x04000164 RID: 356
		private static Delegate cb_format_Lcom_bumptech_glide_load_DecodeFormat_;

		// Token: 0x04000165 RID: 357
		private static Delegate cb_frame_J;

		// Token: 0x04000166 RID: 358
		private static Delegate cb_lock;

		// Token: 0x04000167 RID: 359
		private static Delegate cb_onlyRetrieveFromCache_Z;

		// Token: 0x04000168 RID: 360
		private static Delegate cb_optionalCenterCrop;

		// Token: 0x04000169 RID: 361
		private static Delegate cb_optionalCenterInside;

		// Token: 0x0400016A RID: 362
		private static Delegate cb_optionalCircleCrop;

		// Token: 0x0400016B RID: 363
		private static Delegate cb_optionalFitCenter;

		// Token: 0x0400016C RID: 364
		private static Delegate cb_optionalTransform_Lcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400016D RID: 365
		private static Delegate cb_optionalTransform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400016E RID: 366
		private static Delegate cb_override_I;

		// Token: 0x0400016F RID: 367
		private static Delegate cb_override_II;

		// Token: 0x04000170 RID: 368
		private static Delegate cb_placeholder_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000171 RID: 369
		private static Delegate cb_placeholder_I;

		// Token: 0x04000172 RID: 370
		private static Delegate cb_priority_Lcom_bumptech_glide_Priority_;

		// Token: 0x04000173 RID: 371
		private static Delegate cb_set_Lcom_bumptech_glide_load_Option_Ljava_lang_Object_;

		// Token: 0x04000174 RID: 372
		private static Delegate cb_signature_Lcom_bumptech_glide_load_Key_;

		// Token: 0x04000175 RID: 373
		private static Delegate cb_sizeMultiplier_F;

		// Token: 0x04000176 RID: 374
		private static Delegate cb_skipMemoryCache_Z;

		// Token: 0x04000177 RID: 375
		private static Delegate cb_theme_Landroid_content_res_Resources_Theme_;

		// Token: 0x04000178 RID: 376
		private static Delegate cb_timeout_I;

		// Token: 0x04000179 RID: 377
		private static Delegate cb_transform_Lcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400017A RID: 378
		private static Delegate cb_transform_arrayLcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400017B RID: 379
		private static Delegate cb_transform_Ljava_lang_Class_Lcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400017C RID: 380
		private static Delegate cb_transforms_arrayLcom_bumptech_glide_load_Transformation_;

		// Token: 0x0400017D RID: 381
		private static Delegate cb_useAnimationPool_Z;

		// Token: 0x0400017E RID: 382
		private static Delegate cb_useUnlimitedSourceGeneratorsPool_Z;
	}
}
