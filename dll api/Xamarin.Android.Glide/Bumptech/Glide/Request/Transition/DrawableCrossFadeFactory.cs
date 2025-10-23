using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009D RID: 157
	[Register("com/bumptech/glide/request/transition/DrawableCrossFadeFactory", DoNotGenerateAcw = true)]
	public class DrawableCrossFadeFactory : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00019C08 File Offset: 0x00017E08
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableCrossFadeFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00019C2C File Offset: 0x00017E2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableCrossFadeFactory._members;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00019C34 File Offset: 0x00017E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableCrossFadeFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00019C58 File Offset: 0x00017E58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableCrossFadeFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00019C64 File Offset: 0x00017E64
		protected DrawableCrossFadeFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00019C70 File Offset: 0x00017E70
		[Register(".ctor", "(IZ)V", "")]
		protected unsafe DrawableCrossFadeFactory(int duration, bool isCrossFadeEnabled) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			ptr[1] = new JniArgumentValue(isCrossFadeEnabled);
			base.SetHandle(DrawableCrossFadeFactory._members.InstanceMethods.StartCreateInstance("(IZ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			DrawableCrossFadeFactory._members.InstanceMethods.FinishCreateInstance("(IZ)V", this, ptr);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00019D07 File Offset: 0x00017F07
		private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (DrawableCrossFadeFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				DrawableCrossFadeFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(DrawableCrossFadeFactory.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return DrawableCrossFadeFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00019D2C File Offset: 0x00017F2C
		private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource, bool isFirstResource)
		{
			DrawableCrossFadeFactory @object = Java.Lang.Object.GetObject<DrawableCrossFadeFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, isFirstResource));
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00019D58 File Offset: 0x00017F58
		[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler")]
		public unsafe virtual ITransition Build(DataSource dataSource, bool isFirstResource)
		{
			ITransition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[1] = new JniArgumentValue(isFirstResource);
				@object = Java.Lang.Object.GetObject<ITransition>(DrawableCrossFadeFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataSource);
			}
			return @object;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00019DE0 File Offset: 0x00017FE0
		ITransition ITransitionFactory.Build(DataSource p0, bool p1)
		{
			return this.Build(p0, p1).JavaCast<ITransition>();
		}

		// Token: 0x0400020C RID: 524
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/DrawableCrossFadeFactory", typeof(DrawableCrossFadeFactory));

		// Token: 0x0400020D RID: 525
		private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x020001BD RID: 445
		[Register("com/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x060015AF RID: 5551 RVA: 0x000442F0 File Offset: 0x000424F0
			internal static IntPtr class_ref
			{
				get
				{
					return DrawableCrossFadeFactory.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00044314 File Offset: 0x00042514
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DrawableCrossFadeFactory.Builder._members;
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0004431C File Offset: 0x0004251C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DrawableCrossFadeFactory.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00044340 File Offset: 0x00042540
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DrawableCrossFadeFactory.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060015B3 RID: 5555 RVA: 0x0004434C File Offset: 0x0004254C
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060015B4 RID: 5556 RVA: 0x00044358 File Offset: 0x00042558
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(DrawableCrossFadeFactory.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableCrossFadeFactory.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060015B5 RID: 5557 RVA: 0x000443C8 File Offset: 0x000425C8
			[Register(".ctor", "(I)V", "")]
			public unsafe Builder(int durationMillis) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(durationMillis);
				base.SetHandle(DrawableCrossFadeFactory.Builder._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableCrossFadeFactory.Builder._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
			}

			// Token: 0x060015B6 RID: 5558 RVA: 0x0004444C File Offset: 0x0004264C
			private static Delegate GetBuildHandler()
			{
				if (DrawableCrossFadeFactory.Builder.cb_build == null)
				{
					DrawableCrossFadeFactory.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DrawableCrossFadeFactory.Builder.n_Build));
				}
				return DrawableCrossFadeFactory.Builder.cb_build;
			}

			// Token: 0x060015B7 RID: 5559 RVA: 0x00044470 File Offset: 0x00042670
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawableCrossFadeFactory.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060015B8 RID: 5560 RVA: 0x00044484 File Offset: 0x00042684
			[Register("build", "()Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;", "GetBuildHandler")]
			public virtual DrawableCrossFadeFactory Build()
			{
				return Java.Lang.Object.GetObject<DrawableCrossFadeFactory>(DrawableCrossFadeFactory.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060015B9 RID: 5561 RVA: 0x000444B6 File Offset: 0x000426B6
			private static Delegate GetSetCrossFadeEnabled_ZHandler()
			{
				if (DrawableCrossFadeFactory.Builder.cb_setCrossFadeEnabled_Z == null)
				{
					DrawableCrossFadeFactory.Builder.cb_setCrossFadeEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(DrawableCrossFadeFactory.Builder.n_SetCrossFadeEnabled_Z));
				}
				return DrawableCrossFadeFactory.Builder.cb_setCrossFadeEnabled_Z;
			}

			// Token: 0x060015BA RID: 5562 RVA: 0x000444DA File Offset: 0x000426DA
			private static IntPtr n_SetCrossFadeEnabled_Z(IntPtr jnienv, IntPtr native__this, bool isCrossFadeEnabled)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawableCrossFadeFactory.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCrossFadeEnabled(isCrossFadeEnabled));
			}

			// Token: 0x060015BB RID: 5563 RVA: 0x000444F0 File Offset: 0x000426F0
			[Register("setCrossFadeEnabled", "(Z)Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;", "GetSetCrossFadeEnabled_ZHandler")]
			public unsafe virtual DrawableCrossFadeFactory.Builder SetCrossFadeEnabled(bool isCrossFadeEnabled)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(isCrossFadeEnabled);
				return Java.Lang.Object.GetObject<DrawableCrossFadeFactory.Builder>(DrawableCrossFadeFactory.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCrossFadeEnabled.(Z)Lcom/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400052C RID: 1324
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder", typeof(DrawableCrossFadeFactory.Builder));

			// Token: 0x0400052D RID: 1325
			private static Delegate cb_build;

			// Token: 0x0400052E RID: 1326
			private static Delegate cb_setCrossFadeEnabled_Z;
		}
	}
}
