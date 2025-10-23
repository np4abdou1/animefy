using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views.Animations;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A6 RID: 166
	[Register("com/bumptech/glide/request/transition/ViewAnimationFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class ViewAnimationFactory : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0001A8DC File Offset: 0x00018ADC
		internal static IntPtr class_ref
		{
			get
			{
				return ViewAnimationFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0001A900 File Offset: 0x00018B00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewAnimationFactory._members;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001A908 File Offset: 0x00018B08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewAnimationFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0001A92C File Offset: 0x00018B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewAnimationFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0001A938 File Offset: 0x00018B38
		protected ViewAnimationFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0001A944 File Offset: 0x00018B44
		[Register(".ctor", "(Landroid/view/animation/Animation;)V", "")]
		public unsafe ViewAnimationFactory(Animation animation) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				base.SetHandle(ViewAnimationFactory._members.InstanceMethods.StartCreateInstance("(Landroid/view/animation/Animation;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewAnimationFactory._members.InstanceMethods.FinishCreateInstance("(Landroid/view/animation/Animation;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		[Register(".ctor", "(I)V", "")]
		public unsafe ViewAnimationFactory(int animationId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(animationId);
			base.SetHandle(ViewAnimationFactory._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ViewAnimationFactory._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001AA78 File Offset: 0x00018C78
		private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (ViewAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				ViewAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(ViewAnimationFactory.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return ViewAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0001AA9C File Offset: 0x00018C9C
		private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource, bool isFirstResource)
		{
			ViewAnimationFactory @object = Java.Lang.Object.GetObject<ViewAnimationFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, isFirstResource));
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler")]
		public unsafe virtual ITransition Build(DataSource dataSource, bool isFirstResource)
		{
			ITransition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[1] = new JniArgumentValue(isFirstResource);
				@object = Java.Lang.Object.GetObject<ITransition>(ViewAnimationFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataSource);
			}
			return @object;
		}

		// Token: 0x04000222 RID: 546
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/ViewAnimationFactory", typeof(ViewAnimationFactory));

		// Token: 0x04000223 RID: 547
		private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;
	}
}
