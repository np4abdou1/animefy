using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Bumptech.Glide.Load;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x0200009B RID: 155
	[Register("com/bumptech/glide/request/transition/BitmapContainerTransitionFactory", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public abstract class BitmapContainerTransitionFactory : Java.Lang.Object, ITransitionFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00019900 File Offset: 0x00017B00
		internal static IntPtr class_ref
		{
			get
			{
				return BitmapContainerTransitionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00019924 File Offset: 0x00017B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BitmapContainerTransitionFactory._members;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0001992C File Offset: 0x00017B2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BitmapContainerTransitionFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x00019950 File Offset: 0x00017B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BitmapContainerTransitionFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0001995C File Offset: 0x00017B5C
		protected BitmapContainerTransitionFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00019968 File Offset: 0x00017B68
		[Register(".ctor", "(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", "")]
		public unsafe BitmapContainerTransitionFactory(ITransitionFactory realFactory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((realFactory == null) ? IntPtr.Zero : ((Java.Lang.Object)realFactory).Handle);
				base.SetHandle(BitmapContainerTransitionFactory._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BitmapContainerTransitionFactory._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/request/transition/TransitionFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(realFactory);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00019A1C File Offset: 0x00017C1C
		private static Delegate GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler()
		{
			if (BitmapContainerTransitionFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z == null)
			{
				BitmapContainerTransitionFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(BitmapContainerTransitionFactory.n_Build_Lcom_bumptech_glide_load_DataSource_Z));
			}
			return BitmapContainerTransitionFactory.cb_build_Lcom_bumptech_glide_load_DataSource_Z;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00019A40 File Offset: 0x00017C40
		private static IntPtr n_Build_Lcom_bumptech_glide_load_DataSource_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_dataSource, bool isFirstResource)
		{
			BitmapContainerTransitionFactory @object = Java.Lang.Object.GetObject<BitmapContainerTransitionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DataSource object2 = Java.Lang.Object.GetObject<DataSource>(native_dataSource, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, isFirstResource));
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00019A6C File Offset: 0x00017C6C
		[Register("build", "(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", "GetBuild_Lcom_bumptech_glide_load_DataSource_ZHandler")]
		public unsafe virtual ITransition Build(DataSource dataSource, bool isFirstResource)
		{
			ITransition @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataSource == null) ? IntPtr.Zero : dataSource.Handle);
				ptr[1] = new JniArgumentValue(isFirstResource);
				@object = Java.Lang.Object.GetObject<ITransition>(BitmapContainerTransitionFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Lcom/bumptech/glide/load/DataSource;Z)Lcom/bumptech/glide/request/transition/Transition;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(dataSource);
			}
			return @object;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00019AF4 File Offset: 0x00017CF4
		private static Delegate GetGetBitmap_Ljava_lang_Object_Handler()
		{
			if (BitmapContainerTransitionFactory.cb_getBitmap_Ljava_lang_Object_ == null)
			{
				BitmapContainerTransitionFactory.cb_getBitmap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BitmapContainerTransitionFactory.n_GetBitmap_Ljava_lang_Object_));
			}
			return BitmapContainerTransitionFactory.cb_getBitmap_Ljava_lang_Object_;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00019B18 File Offset: 0x00017D18
		private static IntPtr n_GetBitmap_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BitmapContainerTransitionFactory @object = Java.Lang.Object.GetObject<BitmapContainerTransitionFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetBitmap(object2));
		}

		// Token: 0x06000843 RID: 2115
		[Register("getBitmap", "(Ljava/lang/Object;)Landroid/graphics/Bitmap;", "GetGetBitmap_Ljava_lang_Object_Handler")]
		protected abstract Bitmap GetBitmap(Java.Lang.Object p0);

		// Token: 0x04000208 RID: 520
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/BitmapContainerTransitionFactory", typeof(BitmapContainerTransitionFactory));

		// Token: 0x04000209 RID: 521
		private static Delegate cb_build_Lcom_bumptech_glide_load_DataSource_Z;

		// Token: 0x0400020A RID: 522
		private static Delegate cb_getBitmap_Ljava_lang_Object_;
	}
}
