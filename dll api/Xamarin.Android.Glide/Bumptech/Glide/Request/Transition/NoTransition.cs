using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A5 RID: 165
	[Register("com/bumptech/glide/request/transition/NoTransition", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class NoTransition : Java.Lang.Object, ITransition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0001A69C File Offset: 0x0001889C
		internal static IntPtr class_ref
		{
			get
			{
				return NoTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0001A6C0 File Offset: 0x000188C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NoTransition._members;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0001A6C8 File Offset: 0x000188C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NoTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0001A6EC File Offset: 0x000188EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NoTransition._members.ManagedPeerType;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0001A6F8 File Offset: 0x000188F8
		protected NoTransition(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0001A704 File Offset: 0x00018904
		[Register(".ctor", "()V", "")]
		public NoTransition() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(NoTransition._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			NoTransition._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0001A774 File Offset: 0x00018974
		public static ITransitionFactory Factory
		{
			[JavaTypeParameters(new string[]
			{
				"R"
			})]
			[Register("getFactory", "()Lcom/bumptech/glide/request/transition/TransitionFactory;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ITransitionFactory>(NoTransition._members.StaticMethods.InvokeObjectMethod("getFactory.()Lcom/bumptech/glide/request/transition/TransitionFactory;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0001A7A8 File Offset: 0x000189A8
		[Register("get", "()Lcom/bumptech/glide/request/transition/Transition;", "")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public static ITransition Get()
		{
			return Java.Lang.Object.GetObject<ITransition>(NoTransition._members.StaticMethods.InvokeObjectMethod("get.()Lcom/bumptech/glide/request/transition/Transition;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0001A7D9 File Offset: 0x000189D9
		private static Delegate GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler()
		{
			if (NoTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == null)
			{
				NoTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(NoTransition.n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_));
			}
			return NoTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0001A800 File Offset: 0x00018A00
		private static bool n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_current, IntPtr native_adapter)
		{
			NoTransition @object = Java.Lang.Object.GetObject<NoTransition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_current, JniHandleOwnership.DoNotTransfer);
			ITransitionViewAdapter object3 = Java.Lang.Object.GetObject<ITransitionViewAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			return @object.Transition(object2, object3);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0001A82C File Offset: 0x00018A2C
		[Register("transition", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", "GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler")]
		public unsafe virtual bool Transition(Java.Lang.Object current, ITransitionViewAdapter adapter)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((current == null) ? IntPtr.Zero : current.Handle);
				ptr[1] = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
				result = NoTransition._members.InstanceMethods.InvokeVirtualBooleanMethod("transition.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(current);
				GC.KeepAlive(adapter);
			}
			return result;
		}

		// Token: 0x04000220 RID: 544
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/NoTransition", typeof(NoTransition));

		// Token: 0x04000221 RID: 545
		private static Delegate cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;

		// Token: 0x020001BE RID: 446
		[Register("com/bumptech/glide/request/transition/NoTransition$NoAnimationFactory", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public class NoAnimationFactory : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x060015BD RID: 5565 RVA: 0x00044554 File Offset: 0x00042754
			internal static IntPtr class_ref
			{
				get
				{
					return NoTransition.NoAnimationFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x060015BE RID: 5566 RVA: 0x00044578 File Offset: 0x00042778
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NoTransition.NoAnimationFactory._members;
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x060015BF RID: 5567 RVA: 0x00044580 File Offset: 0x00042780
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NoTransition.NoAnimationFactory._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000445A4 File Offset: 0x000427A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NoTransition.NoAnimationFactory._members.ManagedPeerType;
				}
			}

			// Token: 0x060015C1 RID: 5569 RVA: 0x000445B0 File Offset: 0x000427B0
			protected NoAnimationFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060015C2 RID: 5570 RVA: 0x000445BC File Offset: 0x000427BC
			[Register(".ctor", "()V", "")]
			public NoAnimationFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(NoTransition.NoAnimationFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				NoTransition.NoAnimationFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060015C3 RID: 5571 RVA: 0x0004462A File Offset: 0x0004282A
			private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
			{
				if (NoTransition.NoAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
				{
					NoTransition.NoAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(NoTransition.NoAnimationFactory.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
				}
				return NoTransition.NoAnimationFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
			}

			// Token: 0x060015C4 RID: 5572 RVA: 0x00044650 File Offset: 0x00042850
			private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource, bool isFirstResource)
			{
				NoTransition.NoAnimationFactory @object = Java.Lang.Object.GetObject<NoTransition.NoAnimationFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Build(object2, isFirstResource));
			}

			// Token: 0x060015C5 RID: 5573 RVA: 0x0004467C File Offset: 0x0004287C
			[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler")]
			public unsafe virtual ITransition Build(DataSource dataSource, bool isFirstResource)
			{
				ITransition @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
					ptr[1] = new JniArgumentValue(isFirstResource);
					@object = Java.Lang.Object.GetObject<ITransition>(NoTransition.NoAnimationFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(dataSource);
				}
				return @object;
			}

			// Token: 0x0400052F RID: 1327
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/NoTransition$NoAnimationFactory", typeof(NoTransition.NoAnimationFactory));

			// Token: 0x04000530 RID: 1328
			private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}
	}
}
