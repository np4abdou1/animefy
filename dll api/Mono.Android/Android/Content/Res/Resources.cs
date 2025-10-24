using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Content.Res
{
	// Token: 0x020002AA RID: 682
	[Register("android/content/res/Resources", DoNotGenerateAcw = true)]
	public class Resources : Java.Lang.Object
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00044139 File Offset: 0x00042339
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Resources._members;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00044140 File Offset: 0x00042340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Resources._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00044164 File Offset: 0x00042364
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Resources._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Resources(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00044170 File Offset: 0x00042370
		private static Delegate GetGetConfigurationHandler()
		{
			if (Resources.cb_getConfiguration == null)
			{
				Resources.cb_getConfiguration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Resources.n_GetConfiguration));
			}
			return Resources.cb_getConfiguration;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00044194 File Offset: 0x00042394
		private static IntPtr n_GetConfiguration(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Configuration);
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x000441A8 File Offset: 0x000423A8
		public virtual Configuration Configuration
		{
			get
			{
				return Java.Lang.Object.GetObject<Configuration>(Resources._members.InstanceMethods.InvokeVirtualObjectMethod("getConfiguration.()Landroid/content/res/Configuration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000441DA File Offset: 0x000423DA
		private static Delegate GetGetDisplayMetricsHandler()
		{
			if (Resources.cb_getDisplayMetrics == null)
			{
				Resources.cb_getDisplayMetrics = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Resources.n_GetDisplayMetrics));
			}
			return Resources.cb_getDisplayMetrics;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000441FE File Offset: 0x000423FE
		private static IntPtr n_GetDisplayMetrics(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayMetrics);
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00044214 File Offset: 0x00042414
		public virtual DisplayMetrics DisplayMetrics
		{
			get
			{
				return Java.Lang.Object.GetObject<DisplayMetrics>(Resources._members.InstanceMethods.InvokeVirtualObjectMethod("getDisplayMetrics.()Landroid/util/DisplayMetrics;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00044246 File Offset: 0x00042446
		private static Delegate GetGetColor_ILandroid_content_res_Resources_Theme_Handler()
		{
			if (Resources.cb_getColor_ILandroid_content_res_Resources_Theme_ == null)
			{
				Resources.cb_getColor_ILandroid_content_res_Resources_Theme_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_I(Resources.n_GetColor_ILandroid_content_res_Resources_Theme_));
			}
			return Resources.cb_getColor_ILandroid_content_res_Resources_Theme_;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0004426C File Offset: 0x0004246C
		private static int n_GetColor_ILandroid_content_res_Resources_Theme_(IntPtr jnienv, IntPtr native__this, int id, IntPtr native_theme)
		{
			Resources @object = Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Resources.Theme object2 = Java.Lang.Object.GetObject<Resources.Theme>(native_theme, JniHandleOwnership.DoNotTransfer);
			return @object.GetColor(id, object2).ToArgb();
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00044298 File Offset: 0x00042498
		public unsafe virtual Color GetColor(int id, Resources.Theme theme)
		{
			Color result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((theme == null) ? IntPtr.Zero : theme.Handle);
				result = new Color(Resources._members.InstanceMethods.InvokeVirtualInt32Method("getColor.(ILandroid/content/res/Resources$Theme;)I", this, ptr));
			}
			finally
			{
				GC.KeepAlive(theme);
			}
			return result;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00044318 File Offset: 0x00042518
		private static Delegate GetGetDimension_IHandler()
		{
			if (Resources.cb_getDimension_I == null)
			{
				Resources.cb_getDimension_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_F(Resources.n_GetDimension_I));
			}
			return Resources.cb_getDimension_I;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0004433C File Offset: 0x0004253C
		private static float n_GetDimension_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDimension(id);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0004434C File Offset: 0x0004254C
		public unsafe virtual float GetDimension(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Resources._members.InstanceMethods.InvokeVirtualSingleMethod("getDimension.(I)F", this, ptr);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00044387 File Offset: 0x00042587
		private static Delegate GetGetDimensionPixelSize_IHandler()
		{
			if (Resources.cb_getDimensionPixelSize_I == null)
			{
				Resources.cb_getDimensionPixelSize_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(Resources.n_GetDimensionPixelSize_I));
			}
			return Resources.cb_getDimensionPixelSize_I;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x000443AB File Offset: 0x000425AB
		private static int n_GetDimensionPixelSize_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDimensionPixelSize(id);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x000443BC File Offset: 0x000425BC
		public unsafe virtual int GetDimensionPixelSize(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Resources._members.InstanceMethods.InvokeVirtualInt32Method("getDimensionPixelSize.(I)I", this, ptr);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000443F7 File Offset: 0x000425F7
		private static Delegate GetGetString_IHandler()
		{
			if (Resources.cb_getString_I == null)
			{
				Resources.cb_getString_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Resources.n_GetString_I));
			}
			return Resources.cb_getString_I;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0004441B File Offset: 0x0004261B
		private static IntPtr n_GetString_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetString(id));
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00044430 File Offset: 0x00042630
		public unsafe virtual string GetString(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return JNIEnv.GetString(Resources._members.InstanceMethods.InvokeVirtualObjectMethod("getString.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00044479 File Offset: 0x00042679
		private static Delegate GetUpdateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_Handler()
		{
			if (Resources.cb_updateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_ == null)
			{
				Resources.cb_updateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Resources.n_UpdateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_));
			}
			return Resources.cb_updateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000444A0 File Offset: 0x000426A0
		private static void n_UpdateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_(IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native_metrics)
		{
			Resources @object = Java.Lang.Object.GetObject<Resources>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_config, JniHandleOwnership.DoNotTransfer);
			DisplayMetrics object3 = Java.Lang.Object.GetObject<DisplayMetrics>(native_metrics, JniHandleOwnership.DoNotTransfer);
			@object.UpdateConfiguration(object2, object3);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000444CC File Offset: 0x000426CC
		public unsafe virtual void UpdateConfiguration(Configuration config, DisplayMetrics metrics)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				ptr[1] = new JniArgumentValue((metrics == null) ? IntPtr.Zero : metrics.Handle);
				Resources._members.InstanceMethods.InvokeVirtualVoidMethod("updateConfiguration.(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(config);
				GC.KeepAlive(metrics);
			}
		}

		// Token: 0x04000B25 RID: 2853
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/Resources", typeof(Resources));

		// Token: 0x04000B26 RID: 2854
		private static Delegate cb_getConfiguration;

		// Token: 0x04000B27 RID: 2855
		private static Delegate cb_getDisplayMetrics;

		// Token: 0x04000B28 RID: 2856
		private static Delegate cb_getColor_ILandroid_content_res_Resources_Theme_;

		// Token: 0x04000B29 RID: 2857
		private static Delegate cb_getDimension_I;

		// Token: 0x04000B2A RID: 2858
		private static Delegate cb_getDimensionPixelSize_I;

		// Token: 0x04000B2B RID: 2859
		private static Delegate cb_getString_I;

		// Token: 0x04000B2C RID: 2860
		private static Delegate cb_updateConfiguration_Landroid_content_res_Configuration_Landroid_util_DisplayMetrics_;

		// Token: 0x020002AB RID: 683
		[Register("android/content/res/Resources$Theme", DoNotGenerateAcw = true)]
		public sealed class Theme : Java.Lang.Object
		{
			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00044573 File Offset: 0x00042773
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Resources.Theme._members;
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06001A55 RID: 6741 RVA: 0x0004457C File Offset: 0x0004277C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Resources.Theme._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000445A0 File Offset: 0x000427A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Resources.Theme._members.ManagedPeerType;
				}
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x000021E0 File Offset: 0x000003E0
			internal Theme(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000B2D RID: 2861
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/Resources$Theme", typeof(Resources.Theme));
		}
	}
}
