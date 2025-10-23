using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A7 RID: 167
	[Register("com/bumptech/glide/request/transition/ViewPropertyAnimationFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class ViewPropertyAnimationFactory : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0001AB6C File Offset: 0x00018D6C
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPropertyAnimationFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0001AB90 File Offset: 0x00018D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPropertyAnimationFactory._members;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0001AB98 File Offset: 0x00018D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPropertyAnimationFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001ABBC File Offset: 0x00018DBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPropertyAnimationFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		protected ViewPropertyAnimationFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0001ABD4 File Offset: 0x00018DD4
		[Register(".ctor", "(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", "")]
		public unsafe ViewPropertyAnimationFactory(ViewPropertyTransition.IAnimator animator) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : ((Java.Lang.Object)animator).Handle);
				base.SetHandle(ViewPropertyAnimationFactory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPropertyAnimationFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0001AC88 File Offset: 0x00018E88
		private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (ViewPropertyAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				ViewPropertyAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(ViewPropertyAnimationFactory.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return ViewPropertyAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0001ACAC File Offset: 0x00018EAC
		private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource, bool isFirstResource)
		{
			ViewPropertyAnimationFactory @object = Java.Lang.Object.GetObject<ViewPropertyAnimationFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, isFirstResource));
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler")]
		public unsafe virtual ITransition Build(DataSource dataSource, bool isFirstResource)
		{
			ITransition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[1] = new JniArgumentValue(isFirstResource);
				@object = Java.Lang.Object.GetObject<ITransition>(ViewPropertyAnimationFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataSource);
			}
			return @object;
		}

		// Token: 0x04000224 RID: 548
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/ViewPropertyAnimationFactory", typeof(ViewPropertyAnimationFactory));

		// Token: 0x04000225 RID: 549
		private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;
	}
}
