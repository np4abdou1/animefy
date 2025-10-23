using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.Widget
{
	// Token: 0x0200008C RID: 140
	[Register("androidx/core/widget/TintableCompoundDrawablesView", DoNotGenerateAcw = true)]
	internal class ITintableCompoundDrawablesViewInvoker : Java.Lang.Object, ITintableCompoundDrawablesView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00017DB8 File Offset: 0x00015FB8
		private static IntPtr java_class_ref
		{
			get
			{
				return ITintableCompoundDrawablesViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00017DDC File Offset: 0x00015FDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITintableCompoundDrawablesViewInvoker._members;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00017DE3 File Offset: 0x00015FE3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00017DEB File Offset: 0x00015FEB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITintableCompoundDrawablesViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00017DF7 File Offset: 0x00015FF7
		public static ITintableCompoundDrawablesView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITintableCompoundDrawablesView>(handle, transfer);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00017E00 File Offset: 0x00016000
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITintableCompoundDrawablesViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.widget.TintableCompoundDrawablesView'.");
			}
			return handle;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00017E2B File Offset: 0x0001602B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00017E5C File Offset: 0x0001605C
		public ITintableCompoundDrawablesViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITintableCompoundDrawablesViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00017E94 File Offset: 0x00016094
		private static Delegate GetGetSupportCompoundDrawablesTintListHandler()
		{
			if (ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintList == null)
			{
				ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableCompoundDrawablesViewInvoker.n_GetSupportCompoundDrawablesTintList));
			}
			return ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintList;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00017EB8 File Offset: 0x000160B8
		private static IntPtr n_GetSupportCompoundDrawablesTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableCompoundDrawablesView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportCompoundDrawablesTintList);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00017ECC File Offset: 0x000160CC
		private static Delegate GetSetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ == null)
			{
				ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableCompoundDrawablesViewInvoker.n_SetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_));
			}
			return ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00017EF0 File Offset: 0x000160F0
		private static void n_SetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			ITintableCompoundDrawablesView @object = Java.Lang.Object.GetObject<ITintableCompoundDrawablesView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportCompoundDrawablesTintList = object2;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00017F14 File Offset: 0x00016114
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00017F68 File Offset: 0x00016168
		public unsafe ColorStateList SupportCompoundDrawablesTintList
		{
			get
			{
				if (this.id_getSupportCompoundDrawablesTintList == IntPtr.Zero)
				{
					this.id_getSupportCompoundDrawablesTintList = JNIEnv.GetMethodID(this.class_ref, "getSupportCompoundDrawablesTintList", "()Landroid/content/res/ColorStateList;");
				}
				return Java.Lang.Object.GetObject<ColorStateList>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportCompoundDrawablesTintList), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ == IntPtr.Zero)
				{
					this.id_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ = JNIEnv.GetMethodID(this.class_ref, "setSupportCompoundDrawablesTintList", "(Landroid/content/res/ColorStateList;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_, ptr);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00017FDB File Offset: 0x000161DB
		private static Delegate GetGetSupportCompoundDrawablesTintModeHandler()
		{
			if (ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintMode == null)
			{
				ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITintableCompoundDrawablesViewInvoker.n_GetSupportCompoundDrawablesTintMode));
			}
			return ITintableCompoundDrawablesViewInvoker.cb_getSupportCompoundDrawablesTintMode;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00017FFF File Offset: 0x000161FF
		private static IntPtr n_GetSupportCompoundDrawablesTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITintableCompoundDrawablesView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportCompoundDrawablesTintMode);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00018013 File Offset: 0x00016213
		private static Delegate GetSetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITintableCompoundDrawablesViewInvoker.n_SetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return ITintableCompoundDrawablesViewInvoker.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00018038 File Offset: 0x00016238
		private static void n_SetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			ITintableCompoundDrawablesView @object = Java.Lang.Object.GetObject<ITintableCompoundDrawablesView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportCompoundDrawablesTintMode = object2;
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0001805C File Offset: 0x0001625C
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000180B0 File Offset: 0x000162B0
		public unsafe PorterDuff.Mode SupportCompoundDrawablesTintMode
		{
			get
			{
				if (this.id_getSupportCompoundDrawablesTintMode == IntPtr.Zero)
				{
					this.id_getSupportCompoundDrawablesTintMode = JNIEnv.GetMethodID(this.class_ref, "getSupportCompoundDrawablesTintMode", "()Landroid/graphics/PorterDuff$Mode;");
				}
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportCompoundDrawablesTintMode), JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				if (this.id_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
				{
					this.id_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID(this.class_ref, "setSupportCompoundDrawablesTintMode", "(Landroid/graphics/PorterDuff$Mode;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((value == null) ? IntPtr.Zero : value.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_, ptr);
			}
		}

		// Token: 0x04000205 RID: 517
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/widget/TintableCompoundDrawablesView", typeof(ITintableCompoundDrawablesViewInvoker));

		// Token: 0x04000206 RID: 518
		private IntPtr class_ref;

		// Token: 0x04000207 RID: 519
		private static Delegate cb_getSupportCompoundDrawablesTintList;

		// Token: 0x04000208 RID: 520
		private static Delegate cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x04000209 RID: 521
		private IntPtr id_getSupportCompoundDrawablesTintList;

		// Token: 0x0400020A RID: 522
		private IntPtr id_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x0400020B RID: 523
		private static Delegate cb_getSupportCompoundDrawablesTintMode;

		// Token: 0x0400020C RID: 524
		private static Delegate cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x0400020D RID: 525
		private IntPtr id_getSupportCompoundDrawablesTintMode;

		// Token: 0x0400020E RID: 526
		private IntPtr id_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_;
	}
}
